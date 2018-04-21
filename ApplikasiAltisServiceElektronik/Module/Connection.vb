Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Module Connection
    Public koneksi As New OleDbConnection
    Public cmd As New OleDbCommand
    Public adaptor As New OleDbDataAdapter
    Public reader As OleDbDataReader
    Public data As DataSet
    Public str As String

    Dim appPath As String = My.Application.Info.DirectoryPath
    Public appPathDatabase As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & appPath & "\Database\Database_reprasi.mdb"


    Function LastInsertedID() As Integer
        cmd.Connection = koneksi
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT @@IDENTITY"

        Dim id = CInt(cmd.ExecuteScalar())
        
        LastInsertedID = id
    End Function
End Module
