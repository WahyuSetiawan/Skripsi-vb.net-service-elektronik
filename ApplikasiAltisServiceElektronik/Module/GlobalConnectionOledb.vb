Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Imports CrystalDecisions.CrystalReports.Engine

Module GlobalConnectionOledb
    Dim appPath As String = My.Application.Info.DirectoryPath
    Public appPathDatabase As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & appPath & "\Database\Database_reprasi.mdb"

    Function LastInsertedID(cmd As OleDbCommand) As Integer
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT @@IDENTITY"

        Dim id = CInt(cmd.ExecuteScalar())

        LastInsertedID = id
    End Function

    Function getSafeString(reader As OleDbDataReader, column As String) As String
        getSafeString = ""
        If Not reader.IsDBNull(reader.GetOrdinal(column)) Then
            getSafeString = reader.GetString(reader.GetOrdinal(column))
        End If
    End Function

    Function getSafeDate(reader As OleDbDataReader, column As String) As DateTime
        getSafeDate = Nothing
        If Not reader.IsDBNull(reader.GetOrdinal(column)) Then
            getSafeDate = reader.GetDateTime(reader.GetOrdinal(column))
        End If
    End Function

    Function getSafeInt32(reader As OleDbDataReader, column As String) As Integer
        getSafeInt32 = 0
        If Not reader.IsDBNull(reader.GetOrdinal(column)) Then
            getSafeInt32 = reader.GetInt32(reader.GetOrdinal(column))
        End If
    End Function
End Module
