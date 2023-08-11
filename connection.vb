Imports System.Data.Odbc
Module connection
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public dr As OdbcDataReader
    Public cmd As OdbcCommand
    Public sql As String
    Public sql1 As String

    Sub koneksi()
        sql = "Driver={MySQL ODBC 5.3 ANSI Driver};server=localhost;uid=root;database=bioskop;port=3306"
        conn = New OdbcConnection(sql)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub
End Module
