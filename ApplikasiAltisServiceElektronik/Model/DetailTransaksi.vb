Public Class DetailTransaksi
    Private _id As Integer
    Private _id_transaksi As Integer
    Private _perihal As String
    Private _satuan As Integer
    Private _harga As Integer

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property idTransaksi As Integer
        Get
            Return _id_transaksi
        End Get
        Set(value As Integer)
            _id_transaksi = value
        End Set
    End Property


    Public Property perihal As String
        Get
            Return _perihal
        End Get
        Set(value As String)
            _perihal = value
        End Set
    End Property

    Public Property satuan As Integer
        Get
            Return _satuan
        End Get
        Set(value As Integer)
            _satuan = value
        End Set
    End Property

    Public Property harga As Integer
        Get
            Return _harga
        End Get
        Set(value As Integer)
            _harga = value
        End Set
    End Property

    Public Function save() As Integer
        save = -1

        Try
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommand As New OleDbCommand("insert into detail_transaksi (id_transaksi, perihal, satuan, harga) values (@id_transaksi, @perihal, @satuan, @harga)", myConnection)

            myCommand.Parameters.AddWithValue("@id_transaksi", _id_transaksi)
            myCommand.Parameters.AddWithValue("@perihal", _perihal)
            myCommand.Parameters.AddWithValue("@satuan", _satuan)
            myCommand.Parameters.AddWithValue("@harga", _harga)

            myCommand.ExecuteNonQuery()

            _id = LastInsertedID(myCommand)
            save = _id

            myConnection.Close()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan : " & ex.Message)
        End Try
    End Function

    Public Shared Function all() As List(Of DetailTransaksi)
        Dim transaksis As New List(Of DetailTransaksi)

        Try
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommand As New OleDbCommand("select * from detail_transaksi", myConnection)

            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            While myReader.Read
                Dim detailtransaksi As New DetailTransaksi

                detailtransaksi.id = getSafeInt32(myReader, "id")
                detailtransaksi.perihal = getSafeString(myReader, "perihal")
                detailtransaksi.satuan = getSafeInt32(myReader, "satuan")
                detailtransaksi.harga = getSafeInt32(myReader, "harga")

                transaksis.Add(detailtransaksi)
            End While

            myConnection.Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try

        all = transaksis
    End Function

    Public Shared Function all(id As Integer) As List(Of DetailTransaksi)
        Dim transaksis As New List(Of DetailTransaksi)

        Try
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommand As New OleDbCommand("select * from detail_transaksi where id_transaksi = @id", myConnection)

            myCommand.Parameters.AddWithValue("@id", id)

            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            While myReader.Read
                Dim detailtransaksi As New DetailTransaksi

                detailtransaksi.id = getSafeInt32(myReader, "id")
                detailtransaksi.perihal = getSafeString(myReader, "perihal")
                detailtransaksi.satuan = getSafeInt32(myReader, "satuan")
                detailtransaksi.harga = getSafeInt32(myReader, "harga")

                transaksis.Add(detailtransaksi)
            End While

            myConnection.Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try

        all = transaksis
    End Function

    Public Function delete() As Boolean
        delete = False

        Try
            Dim connection2 As New OleDbConnection(appPathDatabase)
            connection2.Open()

            Dim command As New OleDbCommand("delete from detail_transaksi where id = @id", connection2)

            command.Parameters.AddWithValue("@id", _id)
            command.ExecuteNonQuery()

            delete = True

            connection2.Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Function
    Public Function update(id As Integer) As Boolean
        update = False

        Try
            Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim query As String = "update detail_transaksi set perihal = '@perihal', satuan = @satuan, harga = @harga where id = @id"

            query = Replace(query, "@perihal", _perihal)
            query = Replace(query, "@satuan", _satuan)
            query = Replace(query, "@harga", _harga)
            query = Replace(query, "@id", _id)

            Dim myCommand As New OleDbCommand(query, connection)

            myCommand.ExecuteNonQuery()

            update = True

            connection.Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Function
End Class
