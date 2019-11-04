Public Class frmMain
    Public strUser As String = ""
    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Top = 0
        Me.Left = 50
    End Sub
    Private Sub alignIndicators(btn As Button)
        'buttonIndicator.Visible = True
        'buttonIndicator.Left = btn.Left
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim csvFile As String = (Application.StartupPath & "\CON_SETTINGS.CSV")

        If Not System.IO.File.Exists(csvFile) Then
            frmDatabase.ShowDialog()
            Exit Sub
        End If

        If userPanel.Visible = True Then Exit Sub
        frmLogin.ShowDialog()

    End Sub

    Private Sub btnWeighing_Click(sender As Object, e As EventArgs) Handles btnWeighing.Click

        MainPanel.Controls.Clear()
        With frmTrans
            .TopLevel = False
            MainPanel.Controls.Add(frmTrans)
            .BringToFront()
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
        alignIndicators(btnWeighing)

    End Sub



    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim frmRpt As New frmReporting


        MainPanel.Controls.Clear()
        With frmRpt
            .TopLevel = False
            MainPanel.Controls.Add(frmRpt)
            .BringToFront()
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
        alignIndicators(btnReport)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim frmUser As New frmUserControl


        MainPanel.Controls.Clear()
        With frmUser
            .TopLevel = False
            MainPanel.Controls.Add(frmUser)
            .BringToFront()
            .Show()
        End With
        alignIndicators(btnUser)
    End Sub

    Private Sub btnDatabase_Click(sender As Object, e As EventArgs) Handles btnDatabase.Click
        Dim frmDB As New frmDatabase


        MainPanel.Controls.Clear()
        With frmDB
            .TopLevel = False
            MainPanel.Controls.Add(frmDB)
            .BringToFront()
            .Show()
        End With
        alignIndicators(btnDatabase)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim sql As New SqlControl

            sql.ExecQuery("Select * from tickettnumber")
            If sql.HasException(True) Then Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class