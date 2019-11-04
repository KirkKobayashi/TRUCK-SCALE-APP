Public Class frmUserControl
    Dim SQL As New SqlControl
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim EncPass As String
        Dim isAdmin As Integer


        If txtUserName.Text = "" Then
            txtUserName.Select()
            Exit Sub
        End If

        If txtPass.Text = "" Then
            txtPass.Select()
            Exit Sub
        End If

        If txtConfirm.Text = "" Then
            txtConfirm.Select()
            Exit Sub
        End If

        If txtConfirm.Text <> txtPass.Text Then
            MsgBox("Passwords does not match", MsgBoxStyle.Critical, "Confirm password")
            Exit Sub
        End If

        Try
            EncPass = Encrypt(Trim(txtPass.Text))

            If chkAdmin.Checked Then
                isAdmin = 1
            End If

            SQL.AddParams("@username", Trim(txtUserName.Text))
            SQL.AddParams("@password", Trim(EncPass))
            SQL.AddParams("@admin", isAdmin)
            SQL.AddParams("@active", 1)

            SQL.ExecQuery("INSERT INTO weighers (username, password, joindate, lastactive, admin, active)
                                    VALUES(@username, @password, getdate(), getdate(), @admin, @active)")
            If SQL.HasException(True) Then Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        MsgBox("User added")
        Me.Close()

    End Sub
End Class