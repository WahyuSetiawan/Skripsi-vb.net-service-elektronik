Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Imports CrystalDecisions.CrystalReports.Engine

Module Connection
    Dim appPath As String = My.Application.Info.DirectoryPath
    Public appPathDatabase As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & appPath & "\Database\Database_reprasi.mdb"

    Function LastInsertedID(cmd As OleDbCommand) As Integer
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT @@IDENTITY"

        Dim id = CInt(cmd.ExecuteScalar())

        LastInsertedID = id
    End Function
End Module
