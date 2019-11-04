Public Class frmLogin
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim SQL As New SqlControl
        Dim isAdmin As Integer = 0

        If txtUser.Text = "" Then
            txtUser.Select()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            txtPassword.Select()
            Exit Sub
        End If

        Try
            SQL.AddParams("@username", Trim(txtUser.Text))
            SQL.AddParams("@password", Encrypt(Trim(txtPassword.Text)))
            SQL.ExecQuery("SELECT * FROM WEIGHERS WHERE username = @username and password =@password")

            If SQL.RecordCount <> 0 Then


                With frmMain
                    .userPanel.Visible = True
                    .lblWelcome.Text = "Welcome " & UCase(txtUser.Text)
                    .lblUser.Text = Trim(txtUser.Text)
                    If SQL.DBDT.Rows(0)("admin") = 1 Then
                        .adminPanel.Visible = True
                    End If
                End With
                Me.Close()
            Else
                MsgBox("Username or password are incorrect", MsgBoxStyle.Exclamation, "Log In Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class