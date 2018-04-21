Module Konfiguration
    Public usernameKonf As String = "username"
    Public passwordKonf As String = "password"
    Public keamananKonf As String = "keamanan"

    Function selectKonfigurationBoolean(ByVal konfiguration As String) As Boolean
        Dim connectionSelect As New OleDbConnection(appPathDatabase)
        connectionSelect.Open()

        Dim command As New OleDbCommand("select * from configurasi where konfigurasi = @konfigurasi", connectionSelect)

        command.Parameters.AddWithValue("@konfigurasi", konfiguration)

        Dim reader As OleDbDataReader = command.ExecuteReader
        reader.Read()

        If reader.HasRows Then
            selectKonfigurationBoolean = (reader.GetString(reader.GetOrdinal("nilai")) = "True")
        Else
            selectKonfigurationBoolean = ""
        End If
    End Function

    Function selectKonfiguration(ByVal konfiguration As String) As String
        Dim connectionSelect As New OleDbConnection(appPathDatabase)
        connectionSelect.Open()

        Dim command As New OleDbCommand("select * from configurasi where konfigurasi = @konfigurasi", connectionSelect)

        command.Parameters.AddWithValue("@konfigurasi", konfiguration)

        Dim reader As OleDbDataReader = command.ExecuteReader
        reader.Read()

        If reader.HasRows Then
            selectKonfiguration = reader.GetString(reader.GetOrdinal("nilai"))
        Else
            selectKonfiguration = ""
        End If
    End Function


    Function insertConfig(ByVal konfigurasi As String, ByVal value As String) As Integer
        Dim connection As New OleDbConnection(appPathDatabase)
        connection.Open()

        Dim command As New OleDbCommand("select * from configurasi where konfigurasi = @konfigurasi", connection)

        command.Parameters.AddWithValue("@konfigurasi", konfigurasi)

        Dim reader As OleDbDataReader = command.ExecuteReader
        reader.Read()

        If reader.HasRows Then
            Dim connectionUpdate As New OleDbConnection(appPathDatabase)
            connectionUpdate.Open()

            Dim commandupdate As New OleDbCommand("update configurasi set nilai = '" & value & "' where konfigurasi = '" & konfigurasi & "'", connectionUpdate)

            commandupdate.ExecuteNonQuery()

            connectionUpdate.Close()
        Else
            Dim connectionInsert As New OleDbConnection(appPathDatabase)
            connectionInsert.Open()

            Dim commmandInsert As New OleDbCommand("insert into configurasi (konfigurasi, nilai) values (@konfigurasi, @nilai)", connectionInsert)

            commmandInsert.Parameters.AddWithValue("@konfigurasi", konfigurasi)
            commmandInsert.Parameters.AddWithValue("@nilai", value)

            commmandInsert.ExecuteNonQuery()

            connectionInsert.Close()
        End If

        connection.Close()

        insertConfig = 0
    End Function
End Module
