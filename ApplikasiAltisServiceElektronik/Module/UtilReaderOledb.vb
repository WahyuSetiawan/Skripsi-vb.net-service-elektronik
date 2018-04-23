Module UtilReaderOledb
    Function getSafeString(reader As OleDbDataReader, column As String) As String
        getSafeString = ""
        If Not reader.IsDBNull(reader.GetOrdinal(column)) Then
            getSafeString = reader.GetString(reader.GetOrdinal(column))
        End If
    End Function

    Function getSafeDate(reader As OleDbDataReader, column As String) As DateTime
        getSafeDate = New DateTime
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
