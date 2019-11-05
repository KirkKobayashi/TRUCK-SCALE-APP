Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReporting
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmReporting_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtFrom.Value = Now
        dtTo.Value = Now

        loadCombos()

    End Sub

    Private Sub loadCombos()
        FillCombo(cboPlate, "SELECT platenumber from vehicles order by platenumber", "platenumber")
        FillCombo(cboCustomer, "SELECT companyname from addressbook order by companyname", "companyname")
        FillCombo(cboProduct, "SELECT productname from products order by productname", "productname")
    End Sub

    Private Sub getReport()
        Dim objReport As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table
        Dim rpt As New FrmReportView
        Dim filePath As String

        Dim SQL As New SqlControl
        Dim SQLString As String
        Dim strPlate, strCustomer, strProduct As String
        Dim dtStart As String = dtFrom.Value.ToString("yyyy-MM-dd")
        Dim dtEnd As String = dtTo.Value.ToString("yyyy-MM-dd")

        strPlate = ifNull(cboPlate.Text)
        strCustomer = ifNull(cboCustomer.Text)
        strProduct = ifNull(cboProduct.Text)

        SQL.AddParams("@fromdate", dtStart)
        SQL.AddParams("@todate", dtEnd)



        SQLString = "SELECT * FROM REPORTVIEW WHERE 
                    CONVERT(date,weighin) between CONVERT(date, @fromdate) and CONVERT(date, @todate)"

        If cboPlate.Text <> "" Then
            SQL.AddParams("@plate", strPlate)
            SQLString &= "AND platenumber = @plate"
        End If

        If cboCustomer.Text <> "" Then
            SQL.AddParams("@customer", strCustomer)
            SQLString &= "AND companyname = @customer"
        End If

        If cboProduct.Text <> "" Then
            SQL.AddParams("@product", strProduct)
            SQLString &= "AND productname = @product"
        End If

        SQL.ExecQuery(SQLString)


        Try
            filePath = Application.StartupPath & "\summaryreport.rpt"
            objReport.Load(filePath)
            objReport.SetDataSource(SQL.DBDT)

            With crConnectionInfo
                .ServerName = strSvr
                .DatabaseName = strDB
                .UserID = strUI
                .Password = strPass
            End With

            CrTables = objReport.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next


            rpt.CrViewer.ReportSource = objReport
            rpt.ShowDialog()
        Catch ex As Exception
            MsgBox("Summary report error" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        getReport()
    End Sub

    Private Sub frmReporting_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Top = 0
        Me.Left = 50
    End Sub
End Class