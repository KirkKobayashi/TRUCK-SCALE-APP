Imports System.IO
Public Class frmDatabase

    Private Sub btnClose_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub
    'READ CONNECTION SETTINGS CSV FORMAT
    Private Sub readText()
        Dim consTring As String()
        Try
            If File.Exists(Application.StartupPath & "\CON_SETTINGS.CSV") Then
                Using csvReader As New FileIO.TextFieldParser(Application.StartupPath & "\CON_SETTINGS.CSV")
                    csvReader.TextFieldType = FileIO.FieldType.Delimited
                    csvReader.Delimiters = New String() {","}
                    While Not csvReader.EndOfData
                        consTring = csvReader.ReadFields()
                        txtServer.Text = consTring(0)
                        txtDatabase.Text = consTring(1)
                        txtUser.Text = consTring(2)
                        txtPassword.Text = Decrypt(consTring(3))
                    End While
                End Using
            Else
                MsgBox("File does not exists")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Read connection file error")
        End Try
    End Sub

    Private Sub writeText()
        Try
            Dim srv, db, ui, pw As String
            Dim csvFile As String = (Application.StartupPath & "\CON_SETTINGS.CSV")

            If File.Exists(csvFile) Then
                File.Delete(csvFile)
            End If

            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            srv = Trim(txtServer.Text)
            db = Trim(txtDatabase.Text)
            ui = Trim(txtUser.Text)
            pw = Encrypt(Trim(txtPassword.Text))

            outFile.WriteLine($"{srv},{db},{ui},{pw}")
            outFile.Close()
        Catch ex As Exception
            MsgBox("Con settings save error" & vbCrLf & ex.Message, vbExclamation)
        End Try

    End Sub

    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load
        readText()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtServer.Text = "" Then
            txtServer.Select()
            Exit Sub
        End If

        If txtDatabase.Text = "" Then
            txtDatabase.Select()
            Exit Sub
        End If

        If txtUser.Text = "" Then
            txtUser.Select()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            txtPassword.Select()
            Exit Sub
        End If

        writeText()
    End Sub

    Private Sub btnView_MouseDown(sender As Object, e As MouseEventArgs)
        Dim decstr As String
        decstr = Decrypt(Trim(txtPassword.Text))
        txtPassword.UseSystemPasswordChar = False
        txtPassword.Text = decstr
    End Sub

    Private Sub btnView_MouseUp(sender As Object, e As MouseEventArgs)
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearTexts(Me)
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class