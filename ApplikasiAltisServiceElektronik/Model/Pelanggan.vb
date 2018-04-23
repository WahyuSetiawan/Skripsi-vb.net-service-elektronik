Public Class Pelanggan
    Private _id As Integer
    Private _nama As String
    Private _alamat As String
    Private _noTelepon As String
    Private _noKtp As String

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property nama As String
        Get
            Return _nama
        End Get
        Set(value As String)
            _nama = Trim(value)
        End Set
    End Property

    Public Property alamat As String
        Get
            Return _alamat
        End Get
        Set(value As String)
            _alamat = Trim(value)
        End Set
    End Property

    Public Property noKtp As String
        Get
            Return _noKtp
        End Get
        Set(value As String)
            _noKtp = Trim(value)
        End Set
    End Property

    Public Property noTelepon As String
        Get
            Return _noTelepon
        End Get
        Set(value As String)
            _noTelepon = Trim(value)
        End Set
    End Property

    Public Function save() As Integer
        Try
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommmand As New OleDbCommand("Insert into pelanggan (nama, alamat, noktp, notelepon) values (@nama, @alamat, @noktp, @notelepon)", myConnection)

            myCommmand.Parameters.AddWithValue("@nama", _nama)
            myCommmand.Parameters.AddWithValue("@alamat", _alamat)
            myCommmand.Parameters.AddWithValue("@noktp", _noKtp)
            myCommmand.Parameters.AddWithValue("@notelepon", noTelepon)

            myCommmand.ExecuteNonQuery()

            _id = LastInsertedID(myCommmand)

            save = _id

            myConnection.Close()
        Catch ex As Exception
            MsgBox("Kesalahan dalam penyimpan data pelanggan dengan pesan : " & ex.Message)

            save = -1
        End Try
    End Function

    Function update(id As Integer) As Boolean
        update = False

        Try
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommand As New OleDbCommand("update pelanggan set nama = @nama, alamat = @alamat, notelepon = @notelepon, noktp = @noktp where id = @id", myConnection)

            myCommand.Parameters.AddWithValue("@id", id)
            myCommand.Parameters.AddWithValue("@nama", _nama)
            myCommand.Parameters.AddWithValue("@alamat", _alamat)
            myCommand.Parameters.AddWithValue("@noktp", _noKtp)
            myCommand.Parameters.AddWithValue("@notelepon", _noTelepon)

            myCommand.ExecuteNonQuery()

            myConnection.Close()

            update = True
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Function

    Public Shared Function show(id As Integer) As Pelanggan
        show = Nothing

        Try
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommand As New OleDbCommand("select * from pelanggan where id  = @id", myConnection)

            myCommand.Parameters.AddWithValue("@id", id)

            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            myReader.Read()

            Dim pelanggan As New Pelanggan

            If myReader.HasRows Then
                pelanggan.ID = getSafeInt32(myReader, "id")
                pelanggan.nama = getSafeString(myReader, "nama")
                pelanggan.alamat = getSafeString(myReader, "alamat")
                pelanggan.noTelepon = getSafeString(myReader, "notelepon")
                pelanggan.noKtp = getSafeString(myReader, "noktp")
            End If

            myConnection.Close()
            show = Pelanggan
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " + ex.Message)
        End Try

    End Function

    Public Shared Function all() As List(Of Pelanggan)
        Dim pelanggans As New List(Of Pelanggan)

        Try
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommand As New OleDbCommand("select * from pelanggan", myConnection)
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            While myReader.Read()
                Dim pelanggan As New Pelanggan

                pelanggan.ID = getSafeInt32(myReader, "id")
                pelanggan.nama = getSafeString(myReader, "nama")
                pelanggan.alamat = getSafeString(myReader, "alamat")
                pelanggan.noTelepon = getSafeString(myReader, "notelepon")
                pelanggan.noKtp = getSafeString(myReader, "noktp")

                pelanggans.Add(pelanggan)
            End While

            myConnection.Close()

        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " + ex.Message)
        Finally
            all = pelanggans
        End Try
    End Function

    Public Function delete() As Boolean
        delete = False
        Try
            Dim connDelete As New OleDbConnection(appPathDatabase)
            connDelete.Open()

            Dim command As New OleDbCommand("delete from pelanggan where id = @id", connDelete)

            command.Parameters.AddWithValue("@id", _id.ToString)
            command.ExecuteNonQuery()

            connDelete.Close()

            delete = True

        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Function

End Class
