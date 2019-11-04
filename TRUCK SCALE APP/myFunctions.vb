
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Module myFunctions
    Public strSvr, strDB, strUI, strPass As String

    Dim SQL As New SqlControl
    Public Sub clearTexts(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            clearTexts(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If

            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    'GENERIC PROCEDURE TO FILL COMBO BOX - FOR STREAMLINING
    Sub FillCombo(cmb As ComboBox, query As String, dataField As String)
        Dim sql As New SqlControl

        cmb.Items.Clear()
        sql.ExecQuery(query)

        If sql.HasException(True) Then Exit Sub

        For Each R As DataRow In sql.DBDT.Rows
            cmb.Items.Add(R(dataField).ToString)
        Next
    End Sub

    Public Function ticketExists(ticketNumber As Integer) As Boolean
        Try
            SQL.AddParams("@ticket", ticketNumber)
            SQL.ExecQuery("select [transaction number] FROM transactions WHERE [transaction number] = @ticket  ")
            If SQL.RecordCount <> 0 Then
                Return True
            Else
                Return False
            End If

            If SQL.HasException(True) Then Exit Function
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Sub FillGrid(dgName As DataGridView, startDate As String, endDate As String)

        Try
            dgName.DataSource = Nothing
            dgName.Rows.Clear()

            SQL.addProcParam("@startdate", startDate)
            SQL.addProcParam("@enddate", endDate)

            SQL.ExecProcQuery("transactionlist")
            If SQL.HasException(True) Then Exit Sub

            dgName.DataSource = SQL.DBDT


            If SQL.HasException(True) Then Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ifNull(paramValue As String) As Object
        If paramValue Is Nothing Then
            Return DBNull.Value
        Else
            Return paramValue
        End If
    End Function
#Region "ENCRYPTION"
    Public Function Encrypt(clearText As String) As String
        Try
            Dim EncryptionKey As String = "P@ssw0rd"
            Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
                 &H65, &H64, &H76, &H65, &H64, &H65,
                 &H76})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)
                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                        cs.Write(clearBytes, 0, clearBytes.Length)
                        cs.Close()
                    End Using
                    clearText = Convert.ToBase64String(ms.ToArray())
                End Using
            End Using
            Return clearText
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "none"
        End Try

    End Function

    Public Function Decrypt(cipherText As String) As String
        Try
            Dim EncryptionKey As String = "P@ssw0rd"
            Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
                 &H65, &H64, &H76, &H65, &H64, &H65,
                 &H76})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)
                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                        cs.Write(cipherBytes, 0, cipherBytes.Length)
                        cs.Close()
                    End Using
                    cipherText = Encoding.Unicode.GetString(ms.ToArray())
                End Using
            End Using
            Return cipherText
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "none"
        End Try

    End Function
#End Region

    Public Function readCsvCon() As String
        Dim consTring As String()
        Dim srv As String = ""
        Dim db As String = ""
        Dim ui As String = ""
        Dim pw As String = ""
        Try
            If File.Exists(Application.StartupPath & "\CON_SETTINGS.CSV") Then
                Using csvReader As New FileIO.TextFieldParser(Application.StartupPath & "\CON_SETTINGS.CSV")
                    csvReader.TextFieldType = FileIO.FieldType.Delimited
                    csvReader.Delimiters = New String() {","}
                    While Not csvReader.EndOfData
                        consTring = csvReader.ReadFields()
                        srv = consTring(0)
                        db = consTring(1)
                        ui = consTring(2)
                        pw = Decrypt(consTring(3))
                    End While
                End Using
                strSvr = srv
                strDB = db
                strUI = ui
                strPass = pw
                readCsvCon = ($"Server={srv};Database={db};User={ui};Pwd={pw};")

            Else
                MsgBox("File does not exists")
            End If
        Catch ex As Exception
            readCsvCon = ""
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Read connection file error")
        End Try

    End Function

    ' READ TEXT FILE TO GET CONNECTION STRING
    Public Function ReadConString() As String

        If IO.File.Exists(Application.StartupPath & "\ConSettings.txt") Then
            Dim sr As New StreamReader(Application.StartupPath & "\ConSettings.txt")

            ReadConString = sr.ReadLine

            sr.Close()
        Else

            MsgBox("Connection settings not found", vbCritical, "SQL Connection error")
            Return "no"
        End If

    End Function

    Public Sub checkProcess()
        Dim process As New Process()
        ' Pass your exe file path here.
        Dim path As String = Application.StartupPath & "\indicator.exe"
        Dim fileName As String = System.IO.Path.GetFileName(path)
        ' Get the precess that already running as per the exe file name.
        Dim processName As Process() = Process.GetProcessesByName(fileName.Substring(0, fileName.LastIndexOf("."c)))
        If processName.Length > 0 Then
            Exit Sub
        Else
            process.StartInfo.FileName = path
            process.Start()
        End If
    End Sub
End Module
