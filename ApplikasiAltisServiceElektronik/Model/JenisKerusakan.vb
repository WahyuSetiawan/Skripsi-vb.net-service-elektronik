Public Class JenisKerusakan
    Dim _id As Integer
    Dim _jeniskerusakan As String
    Dim _biaya As Integer

    Private Shared table As String = "jenis_kerusakan"

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            Me._id = value
        End Set
    End Property

    Public Property JenisKerusakana As String
        Get
            Return _jeniskerusakan
        End Get
        Set(value As String)
            Me._jeniskerusakan = value
        End Set
    End Property

    Public Property Biaya As Integer
        Get
            Return _biaya
        End Get
        Set(value As Integer)
            Me._biaya = value
        End Set
    End Property

    Public Function save() As Integer
        Try
            Dim myConn As New OleDbConnection(appPathDatabase)
            myConn.Open()

            Dim myCmd As New OleDbCommand("insert into " & table & " (jenis, biaya) values (@jenis, @biaya)", myConn)

            myCmd.Parameters.AddWithValue("@jenis", _jeniskerusakan)
            myCmd.Parameters.AddWithValue("@biaya", Biaya)

            myCmd.ExecuteNonQuery()

            _id = LastInsertedID(myCmd)

            save = _id

            myConn.Close()
        Catch ex As Exception
            MsgBox("Terdapat Kesalahan dalam penyimpanan data jenis kerusakan dengan kesalahan : " & ex.Message)
            save = -1
        End Try
    End Function

    Public Function update(id As Integer) As Boolean
        update = False

        Try
            Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim command As New OleDbCommand("update " & table & " set jenis = @jenis, biaya = @biaya where id = " & id, connection)

            command.Parameters.AddWithValue("@jenis", _jeniskerusakan)
            command.Parameters.AddWithValue("@biaya", Biaya)

            command.ExecuteNonQuery()

            connection.Close()

            update = True
        Catch ex As Exception
            MsgBox("Tedapat kesalahan dalam perubahan data jenis keruskaan dengan kesalahan : " & ex.Message)
        End Try
    End Function

    Public Shared Function show(id As Integer) As JenisKerusakan
        show = Nothing


        Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim command As New OleDbCommand("Select * from " & table & " where id  = " & id, connection)

            Dim reader As OleDbDataReader = command.ExecuteReader

            reader.Read()

            Dim jenisKerusakan As New JenisKerusakan

            If reader.HasRows Then
                jenisKerusakan.id = getSafeInt32(reader, "id")
                jenisKerusakan.JenisKerusakana = getSafeString(reader, "jenis")
                jenisKerusakan.Biaya = getSafeInt32(reader, "biaya")
            End If

            connection.Close()

            show = jenisKerusakan

    End Function

    Public Shared Function all() As List(Of JenisKerusakan)
        Dim JenisKerusakans As New List(Of JenisKerusakan)

        Try
            Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim myCommand As New OleDbCommand("select * from " & table, connection)
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            While myReader.Read()
                Dim jenisKerusakan As New JenisKerusakan

                jenisKerusakan.id = getSafeInt32(myReader, "id")
                jenisKerusakan.JenisKerusakana = getSafeString(myReader, "jenis")
                jenisKerusakan.Biaya = getSafeInt32(myReader, "biaya")

                JenisKerusakans.Add(jenisKerusakan)
            End While

            connection.Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan dalam menghapus data jenis kerusakan denga kesalahan : " & ex.Message)
        End Try

        Return JenisKerusakans
    End Function

    Public Function delete() As Boolean
        delete = False

        Try
            Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim command As New OleDbCommand("delete from " & table & " where id = " & id, connection)
            command.ExecuteNonQuery()

            connection.Close()

            delete = True
        Catch ex As Exception
            MsgBox("Terjadi kesalahan dalam menghapus data jenis kerusakan dengan kesalahan : " & ex.Message)
        End Try
    End Function

    Public Shared Function search(text As String) As List(Of JenisKerusakan)
        Dim jenisKerusakans As New List(Of JenisKerusakan)

        Try
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommand As New OleDbCommand("select * from jenis_kerusakan where jenis like '%" & text & "%' or biaya & '' like '" & text & "' or  id like '%" & text & "%'", myConnection)
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            While myReader.Read()
                Dim jenisKerusakan As New JenisKerusakan

                jenisKerusakan.id = getSafeInt32(myReader, "id")
                jenisKerusakan.JenisKerusakana = getSafeString(myReader, "jenis")
                jenisKerusakan.Biaya = getSafeInt32(myReader, "biaya")

                jenisKerusakans.Add(jenisKerusakan)
            End While

            myConnection.Close()

        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " + ex.Message)
        Finally
            search = jenisKerusakans
        End Try
    End Function
End Class
