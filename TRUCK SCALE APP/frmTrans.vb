Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmTrans
    Dim SQL As New SqlControl
    Dim blnNew As Boolean
    Dim intComplete As Integer

    Private Sub frmTrans_Load(sender As Object, e As EventArgs) Handles Me.Load

        dateStart.Value = Now
        dateEnd.Value = Now

        LoadCombos()
        DG_Fill()

        checkProcess()
    End Sub


#Region "Load Combo Boxes"
    Private Sub LoadCombos()
        FillCombo(cboSupplier, "SELECT COMPANYNAME FROM ADDRESSBOOK ORDER BY COMPANYNAME ASC", "companyname")
        FillCombo(cboCustomer, "SELECT COMPANYNAME FROM ADDRESSBOOK ORDER BY COMPANYNAME ASC", "companyname")
        FillCombo(cboProduct, "SELECT PRODUCTNAME FROM PRODUCTS ORDER BY PRODUCTNAME ASC", "productname")
        FillCombo(cboPlate, "SELECT PLATENUMBER FROM VEHICLES ORDER BY PLATENUMBER ASC", "platenumber")
        FillCombo(cboTruck, "SELECT TRUCKTYPE FROM [TRUCK TYPE] ORDER BY TRUCKTYPE ASC", "trucktype")
    End Sub
#End Region
    Private Sub SaveRecord(newTrans As Boolean)
        Dim strCustomer, strSupplier, strLoad, strNote, strQuantity, strtype As String

        If txtTicket.Text = "" Then txtTicket.Select()

        If blnNew = True Then
            If ticketExists(Trim(txtTicket.Text)) = True Then
                MsgBox("This is already a used ticket", MsgBoxStyle.Critical, "Check scale ticket")
                Exit Sub
            End If
        End If

        If cboPlate.Text = "" Then cboPlate.Select()

        strCustomer = ifNull(cboCustomer.Text)
        strSupplier = ifNull(cboSupplier.Text)
        strLoad = ifNull(cboProduct.Text)
        strNote = ifNull(txtNotes.Text)
        strQuantity = ifNull(txtQuantity.Text)
        strtype = ifNull(cboTruck.Text)

        'PASS SQL PARAMETERES HERE

        SQL.addProcParam("@transnum", Convert.ToInt32(txtTicket.Text))
        SQL.addProcParam("@truckplate", cboPlate.Text)
        SQL.addProcParam("@TRUCKTYPE", strtype)
        SQL.addProcParam("@custname", strCustomer)
        SQL.addProcParam("@supname", strSupplier)
        SQL.addProcParam("@truckload", strLoad)
        SQL.addProcParam("@loadquantity", strQuantity)
        SQL.addProcParam("@notes", strNote)
        SQL.addProcParam("@gross", txtGross.Text)
        SQL.addProcParam("@username", Trim(frmMain.lblUser.Text))

        If newTrans = True Then 'NEW TRANSACTION
            Try
                SQL.ExecProcNonQuery("saveweighin")
                If SQL.HasException(True) Then Exit Sub

                clearTexts(Me)
                LoadCombos()
                DG_Fill()
                cmdSave.Visible = False
                txtTicket.Select()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf blnNew = False Then ' EXISTING TRANSACTION FOR UPDATE
            Try
                SQL.addProcParam("@tare", txtTare.Text) 'additional weigh out parameters
                SQL.addProcParam("@net", txtNet.Text)

                SQL.ExecProcNonQuery("saveweighout")
                If SQL.HasException(True) Then Exit Sub

                clearTexts(Me)
                LoadCombos()
                DG_Fill()
                cmdSave.Visible = False
                txtTicket.Select()

                'OPTION TO PRINT
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Save error")
            End Try

        End If

        lockControls()
    End Sub

    Private Sub DG_Fill()
        Dim dtStart As String = dateStart.Value.ToString("yyyy-MM-dd")
        Dim dtEnd As String = dateEnd.Value.ToString("yyyy-MM-dd")

        frmMain.s_stripLabel.Text = "Loading.."
        DG_Trans.DataSource = Nothing
        DG_Trans.Rows.Clear()
        FillGrid(DG_Trans, dtStart, dtEnd)
        frmMain.s_stripLabel.Text = ""
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        NewTrans()

    End Sub
    Private Sub NewTrans()

        blnNew = True
        clearTexts(Me)
        unlockControls()
        txtGross.Text = ReadWeight()
        cmdScale.Visible = True
        txtTicket.Text = GetTicket()
        txtTicket.Select()
        cmdSave.Enabled = True
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DG_Fill()
    End Sub

    Private Sub unlockControls()
        TransPanel.Enabled = True
        txtTicket.BackColor = Color.White
        cboPlate.BackColor = Color.White
        cboTruck.BackColor = Color.White
        cboSupplier.BackColor = Color.White
        cboCustomer.BackColor = Color.White
        cboProduct.BackColor = Color.White
        txtQuantity.BackColor = Color.White
        txtNotes.BackColor = Color.White
    End Sub

    Private Sub lockControls()
        txtTicket.BackColor = DefaultBackColor
        cboPlate.BackColor = DefaultBackColor
        cboTruck.BackColor = DefaultBackColor
        cboSupplier.BackColor = DefaultBackColor
        cboCustomer.BackColor = DefaultBackColor
        cboProduct.BackColor = DefaultBackColor
        txtQuantity.BackColor = DefaultBackColor
        txtNotes.BackColor = DefaultBackColor

        TransPanel.Enabled = False
    End Sub
    'QUERY TRANSACTION DETAILS AND FILL CONTROLS
    Private Sub QueryDetails()
        Try
            'TEMPORARY STORE TICKETNUMBER THEN CLEAR CONTROLS BEFORE QUERY
            Dim tmp As String = Trim(txtTicket.Text)
            clearTexts(Me)
            txtTicket.Text = tmp

            frmMain.s_strip.Text = "Loading.."

            SQL.addProcParam("@transnum", Trim(txtTicket.Text))

            SQL.ExecProcQuery("QueryTransDetails")

            If SQL.RecordCount = 0 Then Exit Sub

            cboPlate.Text = Convert.ToString(SQL.DBDT.Rows(0)("platenumber"))
            cboTruck.Text = Convert.ToString(SQL.DBDT.Rows(0)("trucktype"))
            cboCustomer.Text = Convert.ToString(SQL.DBDT.Rows(0)("customer"))
            cboSupplier.Text = Convert.ToString(SQL.DBDT.Rows(0)("supplier"))
            cboProduct.Text = Convert.ToString(SQL.DBDT.Rows(0)("productname"))
            txtQuantity.Text = Convert.ToString(SQL.DBDT.Rows(0)("quantity"))
            txtNotes.Text = Convert.ToString(SQL.DBDT.Rows(0)("notes"))
            txtGross.Text = Convert.ToString(SQL.DBDT.Rows(0)("gross"))
            txtTare.Text = Convert.ToString(SQL.DBDT.Rows(0)("tare"))
            txtNet.Text = Convert.ToString(SQL.DBDT.Rows(0)("net"))

            intComplete = Convert.ToInt32(SQL.DBDT.Rows(0)("iscomplete")) 'CHECK IF TRANSACTION IS COMPLETED

            If intComplete = 2 Then
                cmdSave.Enabled = False
            End If

            If SQL.HasException(True) Then Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "DATA GRID EVENTS "

    Private Sub DG_Trans_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Trans.CellClick
        Dim index As Integer = e.RowIndex
        Dim selRow As DataGridViewRow

        selRow = DG_Trans.Rows(index)
        txtTicket.Text = selRow.Cells(0).Value.ToString
        QueryDetails()
    End Sub

    Private Sub DG_Trans_DoubleClick(sender As Object, e As EventArgs) Handles DG_Trans.DoubleClick
        If intComplete = 2 Then
            blnNew = False
            cmdSave.Visible = False
        Else
            blnNew = Nothing
            cmdSave.Visible = True
            cmdScale.Enabled = True
            unlockControls()
            cmdScale.Visible = True

            'COMPARE CURRENT WEIGHT TO GROSS WEIGHT AND COMPUTE FOR NET
            AssignGross()
            ComputeNet()
        End If
    End Sub
    'ASSIGN AND COMPUTE WEIGHTS
    Private Sub AssignGross()
        Dim rdWeight As Double
        Dim tmpGross As Double

        Int32.TryParse(ReadWeight, rdWeight)
        Int32.TryParse(txtGross.Text, tmpGross)

        If blnNew = True Then
            txtGross.Text = rdWeight
        ElseIf blnNew = False Then
            If rdWeight > tmpGross Then
                txtTare.Text = tmpGross
                txtGross.Text = rdWeight
            Else
                txtTare.Text = rdWeight
            End If
            ComputeNet()
        End If
    End Sub
    Private Sub ComputeNet()
        txtNet.Text = Convert.ToInt32(txtGross.Text) - Convert.ToInt32(txtTare.Text)
    End Sub
#End Region

    Private Sub cboPlate_Leave(sender As Object, e As EventArgs) Handles cboPlate.Leave
        Try
            Me.Cursor = Cursors.WaitCursor
            If cboPlate.Text = "" Then Exit Sub
            'QUERY TRUCK TYPE AND DISPLAY TO CBO TRUCKTYPE
            SQL.AddParams("@platenumber", cboPlate.Text)

            SQL.ExecQuery("SELECT [truck type].truckType as VehicleType from [truck type] 
                      JOIN vehicles on [truck type].id = [vehicles].trucktype  
                    where [vehicles].platenumber = @platenumber")

            'exit if record is not found
            If SQL.RecordCount = 0 Then Exit Sub

            cboTruck.Text = Convert.ToString(SQL.DBDT.Rows(0)("VehicleType"))
            Me.Cursor = DefaultCursor
        Catch ex As Exception
            Me.Cursor = DefaultCursor
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        SaveRecord(blnNew)
    End Sub

    Private Function ReadWeight() As String
        Try
            If IO.File.Exists(Application.StartupPath & "\binw.txt") Then
                Dim sr As New System.IO.StreamReader(Application.StartupPath & "\BINW.txt")

                ReadWeight = sr.ReadLine

                sr.Close()
            Else
                Return "----------"
            End If
        Catch ex As Exception
            Return "--------"
            MsgBox("Read weight error" & vbCrLf & ex.Message)
        End Try

    End Function

    Private Function GetTicket() As Double
        Try
            SQL.ExecQuery("SELECT ticketnumber FROM TICKETNUMBER WHERE id = 1")

            If SQL.HasException(True) Then Exit Function

            GetTicket = SQL.DBDT.Rows(0)("ticketnumber") + 1
        Catch ex As Exception
            GetTicket = 0
            MsgBox("Get Ticket error" & vbCrLf & ex.Message)
        End Try

    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        CrystalTicket()
    End Sub
    'PRINT SCALE TICKET WITH CRYSTAL REPORT
    Private Sub CrystalTicket()
        Dim objReport As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table
        'Dim rpt As New Report
        Dim rpt As New FrmReportView
        Dim filePath As String

        Try
            Me.Cursor = Cursors.WaitCursor
            filePath = Application.StartupPath & "\crticket.rpt"
            objReport.Load(filePath)
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

            'objReport.SetParameterValue("@transnum", txtTicket.Text)
            ''objReport.PrintToPrinter(1, False, 0, 0)
            'rpt.CrViewer.ReportSource = objReport

            objReport.SetParameterValue("@transnum", txtTicket.Text)
            'objReport.PrintToPrinter(1, False, 0, 0)
            rpt.CrViewer.ReportSource = objReport
            Me.Cursor = DefaultCursor
            rpt.ShowDialog()
        Catch ex As Exception
            Me.Cursor = DefaultCursor
            MsgBox("Print scale ticket error" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTicket.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            QueryDetails()
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        clearTexts(Me)
    End Sub

    Private Sub DeleteTrans()
        If txtTicket.Text = "" Then Exit Sub

        Dim ans As MsgBoxResult
        Try
            ans = MsgBox("Are you sure you want to delete this transaction?" & vbCrLf _
                         & "Ticket Number = " & txtTicket.Text & vbCrLf _
                         & "Plate Number =" & cboPlate.Text, MsgBoxStyle.YesNo + vbQuestion, "Delete?")

            If ans = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                SQL.AddParams("@transNum", Trim(txtTicket.Text))
                QueryDetails()

                SQL.ExecQuery("DELETE FROM TRANSACTIONS WHERE [transaction number] = @transnum")
                If SQL.HasException(True) Then Exit Sub

                Me.Cursor = DefaultCursor
                clearTexts(Me)
                MsgBox("Record deleted")
            End If

        Catch ex As Exception
            Me.Cursor = DefaultCursor
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteTrans()
    End Sub


End Class
