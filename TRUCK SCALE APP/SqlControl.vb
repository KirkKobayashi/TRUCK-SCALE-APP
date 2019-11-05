Imports System.Data.SqlClient
Imports System.IO


Public Class SqlControl
    Private StrCon As String
    Private DBCon As New SqlConnection(readCsvCon)
    Private DBCmd As SqlCommand

    'DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    'QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)
    Public ProcParams As New List(Of SqlParameter)

    'QUERY STATS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()

        'DBCon = New SqlConnection(ReadText)

    End Sub

    'ALLOW CONNECTION STRING OVERRIDE
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    'EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String)
        'RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            'CREATE DATABASE COMMAND
            DBCmd = New SqlCommand(Query, DBCon)

            'CLEAR OUT PARAMS LIST

            'LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'EXECUTE AND FILL DATASET

            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
            'Params.Clear()

        Catch ex As Exception
            'CAPTURE ERROR
            Exception = "Execquery error: " & ex.Message
        Finally
            'CLOSE CONNECTION
            Params.Clear()
            DBCmd.Parameters.Clear()
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    'Execute stored non query procedures such as insert, delete update IMPROVE LATER
    Public Sub ExecProcNonQuery(ProcName As String)


        'RESET QUERY STATS
        RecordCount = 0
        Exception = ""
        Params.Clear()
        Try
            DBCon.Open()

            'CREATE DATABASE COMMAND
            DBCmd = New SqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = ProcName,
                .Connection = DBCon
            }
            DBCmd.Parameters.Clear()

            ProcParams.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            'CAPTURE ERROR
            Exception = "Execquery error: " & ex.Message
        Finally
            'CLOSE CONNECTION
            ProcParams.Clear()
            DBCmd.Parameters.Clear()
            DBCmd.Dispose()
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    'Execute query type stored procedures - improve later
    Public Sub ExecProcQuery(ProcName As String)

        'RESET QUERY STATS
        RecordCount = 0
        Exception = ""
        'Params.Clear()
        Try
            DBCon.Open()

            'CREATE DATABASE COMMAND
            DBCmd = New SqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = ProcName,
                .Connection = DBCon
            }

            ProcParams.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            'CAPTURE ERROR
            Exception = "ExecProcQuery error: " & ex.Message
        Finally
            'CLOSE CONNECTION
            ProcParams.Clear()
            DBCmd.Parameters.Clear()

            DBCmd.Dispose()

            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    'SIMPLE PARAMETER PASSING
    Public Sub AddParams(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)

        Params.Add(NewParam)

    End Sub

    Public Sub addProcParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)

        ProcParams.Add(NewParam)
    End Sub

    'ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False

        'CLEAR PARAMETERS WHEN ERROR OCCURS
        'DBCmd.Parameters.Clear()
        Params.Clear()
        ProcParams.Clear()

        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception :")

        Return True
    End Function

End Class
