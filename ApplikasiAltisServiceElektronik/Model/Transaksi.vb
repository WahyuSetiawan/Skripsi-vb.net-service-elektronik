Public Class Transaksi
    Private _id As Integer
    Private _id_pelanggan As String
    Private _merek As String
    Private _type As String
    Private _serial_number As String
    Private _kelengkapan As String
    Private _keluhan As String
    Private _catatan As String
    Private _tanggal_masuk As Date
    Private _jenis_kerusakan As String
    Private _total As Integer
    Private _bayar As Integer
    Private _kembalian As Integer
    Private _tanggal_keluar As Date

    Private _detail_transaksi As List(Of DetailTransaksi)
    Private _pelanggan As Pelanggan

    Public Property detail_transaksi As List(Of DetailTransaksi)
        Get
            Return _detail_transaksi
        End Get
        Set(value As List(Of DetailTransaksi))
            _detail_transaksi = value
        End Set
    End Property

    Public Property pelanggan As Pelanggan
        Get
            Return _pelanggan
        End Get
        Set(value As Pelanggan)
            _pelanggan = value
        End Set
    End Property

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property id_pelanggan As String
        Get
            Return _id_pelanggan
        End Get
        Set(value As String)
            _id_pelanggan = Trim(value)
        End Set
    End Property
    Public Property merek As String
        Get
            Return _merek
        End Get
        Set(value As String)
            _merek = value
        End Set
    End Property
    Public Property type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property
    Public Property serial_number As String
        Get
            Return _serial_number
        End Get
        Set(value As String)
            _serial_number = value
        End Set
    End Property
    Public Property kelengkapan As String
        Get
            Return _kelengkapan
        End Get
        Set(value As String)
            _kelengkapan = value
        End Set
    End Property
    Public Property keluhan As String
        Get
            Return _keluhan
        End Get
        Set(value As String)
            _keluhan = value
        End Set
    End Property
    Public Property catatan As String
        Get
            Return _catatan
        End Get
        Set(value As String)
            _catatan = value
        End Set
    End Property
    Public Property tanggal_masuk As Date
        Get
            Return _tanggal_masuk
        End Get
        Set(value As Date)
            _tanggal_masuk = value
        End Set
    End Property
    Public Property jenis_kerusakan As String
        Get
            Return _jenis_kerusakan
        End Get
        Set(value As String)
            _jenis_kerusakan = value
        End Set
    End Property
    Public Property total As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property
    Public Property bayar As Integer
        Get
            Return _bayar
        End Get
        Set(value As Integer)
            _bayar = value
        End Set
    End Property
    Public Property kembalian As Integer
        Get
            Return _kembalian
        End Get
        Set(value As Integer)
            _kembalian = value
        End Set
    End Property
    Public Property tanggal_keluar As Date
        Get
            Return _tanggal_keluar
        End Get
        Set(value As Date)
            _tanggal_keluar = value
        End Set
    End Property

    Public Function update() As Boolean
        update = False

        'Try
        Dim conn As New OleDbConnection(appPathDatabase)
            conn.Open()

        Dim query As String = "update transaksi set " &
                " pelanggan = '@pelanggan' " & "," &
                " merek = '@merek' " & "," &
                " type = '@type' " & "," &
                " jenis = '@jenis' " & "," &
                " serial_number = '@serial_number' " & "," &
                " kelengkapan = '@kelengkapan' " & "," &
                " keluhan = '@keluhan' " & "," &
                " catatan = '@catatan' " & "," &
                " bayar = @bayar " & "," &
                " kembalian = @kembalian " & "," &
                " tanggal_keluar = @tanggal_keluar " & "," &
                " total = @total " &
                " where id = @id"

        query = query.Replace("@pelanggan", _id_pelanggan)
            query = query.Replace("@merek", _merek)
            query = query.Replace("@type", _type)
            query = query.Replace("@serial_number", _serial_number)
            query = query.Replace("@jenis", _jenis_kerusakan)
            query = query.Replace("@kelengkapan", _kelengkapan)
            query = query.Replace("@keluhan", _keluhan)
            query = query.Replace("@catatan", _catatan)
            query = query.Replace("@bayar", _bayar)
            query = query.Replace("@kembalian", _kembalian)

            If _tanggal_keluar = Nothing Then
            query = query.Replace("@tanggal_keluar", "null")
        Else
            query = query.Replace("@tanggal_keluar", "'" & _tanggal_keluar & "'")
        End If
            query = query.Replace("@total", _total)
            query = query.Replace("@id", _id)

            Console.WriteLine(query)

            Dim cmd As New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()

            conn.Close()
            update = True
        'Catch ex As Exception
        '    MsgBox("terjadi kesalahan :  " + ex.Message)
        'End Try
    End Function

    Public Function save() As Integer
        save = -1

        If Pelanggan.show(_id_pelanggan) Is Nothing Then
            Exit Function
        End If

        Try
            Dim koneksi As New OleDbConnection(appPathDatabase)
            koneksi.Open()

            Dim query As String = "INSERT into transaksi (pelanggan, merek, type, serial_number, jenis, kelengkapan, keluhan, catatan) values  " &
                     "('@pelanggan','@merek', '@type', '@serial_number', '@jenis', '@kelengkapan', '@keluhan', '@catatan')"

            query = query.Replace("@pelanggan", _id_pelanggan)
            query = query.Replace("@merek", _merek)
            query = query.Replace("@type", _type)
            query = query.Replace("@serial_number", _serial_number)
            query = query.Replace("@jenis", _jenis_kerusakan)
            query = query.Replace("@kelengkapan", _kelengkapan)
            query = query.Replace("@keluhan", _keluhan)
            query = query.Replace("@catatan", _catatan)

            Console.WriteLine(query)
            Dim myCommand As New OleDbCommand(query, koneksi)
            myCommand.ExecuteNonQuery()

            _id = LastInsertedID(myCommand)
            Console.WriteLine("Berhasil memasukan transaksi baru")

            save = _id

            koneksi.Close()

        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try

    End Function

    Public Shared Function all() As List(Of Transaksi)
        Dim transaksis As New List(Of Transaksi)

        Try
            Dim myConnecion As New OleDbConnection(appPathDatabase)
            myConnecion.Open()

            Dim myCommand As New OleDbCommand("Select * from transaksi", myConnecion)

            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            While (myReader.Read())
                Dim transaksi As New Transaksi

                transaksi.id = getSafeInt32(myReader, "id")
                transaksi.id_pelanggan = getSafeInt32(myReader, "pelanggan")
                transaksi.merek = getSafeString(myReader, "merek")
                transaksi.type = getSafeString(myReader, "type")
                transaksi.serial_number = getSafeString(myReader, "serial_number")
                transaksi.kelengkapan = getSafeString(myReader, "kelengkapan")
                transaksi.keluhan = getSafeString(myReader, "keluhan")
                transaksi.catatan = getSafeString(myReader, "catatan")
                transaksi.tanggal_masuk = getSafeDate(myReader, "tanggal_masuk")
                transaksi.jenis_kerusakan = getSafeString(myReader, "jenis")
                transaksi.bayar = getSafeInt32(myReader, "bayar")
                transaksi.total = getSafeInt32(myReader, "total")
                transaksi.kembalian = getSafeInt32(myReader, "kembalian")
                transaksi.tanggal_keluar = getSafeDate(myReader, "tanggal_keluar")

                transaksi.pelanggan = Pelanggan.show(transaksi.id_pelanggan)
                transaksi.detail_transaksi = DetailTransaksi.all(transaksi.id)

                transaksis.Add(transaksi)
            End While

            myConnecion.Close()
        Catch ex As Exception
            MsgBox("Terdapat Kesalahan : " & ex.Message)
        End Try

        all = transaksis
    End Function

    Public Shared Function show(id As Integer) As Transaksi
        show = Nothing

        Try
            Dim myConnecion As New OleDbConnection(appPathDatabase)
            myConnecion.Open()

            Dim myCommand As New OleDbCommand("Select * from transaksi where id = @id", myConnecion)

            myCommand.Parameters.AddWithValue("@id", id)

            Dim myReader As OleDbDataReader = myCommand.ExecuteReader
            myReader.Read()

            If myReader.HasRows Then
                Dim transaksi As New Transaksi

                transaksi.id = getSafeInt32(myReader, "id")
                transaksi.id_pelanggan = getSafeInt32(myReader, "pelanggan")
                transaksi.merek = getSafeString(myReader, "merek")
                transaksi.type = getSafeString(myReader, "type")
                transaksi.serial_number = getSafeString(myReader, "serial_number")
                transaksi.kelengkapan = getSafeString(myReader, "kelengkapan")
                transaksi.keluhan = getSafeString(myReader, "keluhan")
                transaksi.catatan = getSafeString(myReader, "catatan")
                transaksi.tanggal_masuk = getSafeDate(myReader, "tanggal_masuk")
                transaksi.jenis_kerusakan = getSafeString(myReader, "jenis")
                transaksi.bayar = getSafeInt32(myReader, "bayar")
                transaksi.total = getSafeInt32(myReader, "total")
                transaksi.kembalian = getSafeInt32(myReader, "kembalian")
                transaksi.tanggal_keluar = getSafeDate(myReader, "tanggal_keluar")

                transaksi.pelanggan = Pelanggan.show(transaksi.id_pelanggan)
                transaksi.detail_transaksi = DetailTransaksi.all(transaksi.id)

                show = transaksi
            End If

            myConnecion.Close()
        Catch ex As Exception
            MsgBox("Terdapat Kesalahan : " & ex.Message)
        End Try
    End Function

    Public Function delete() As Boolean
        delete = False

        For Each detail As DetailTransaksi In _detail_transaksi
            detail.delete()
        Next

        Try
            Dim conn As New OleDbConnection(appPathDatabase)
            conn.Open()

            Dim query As String = "delete from transaksi where id = @id"

            query = query.Replace("@id", _id)

            Console.WriteLine(query)

            Dim cmd As New OleDbCommand(query, conn)

            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try

    End Function

    Function updateHarga(harga As String) As Boolean
        updateHarga = False

        Try
            Dim conn As New OleDbConnection(appPathDatabase)
            conn.Open()

            Dim query As String = "update transaksi set total = @total where id = @id"

            query = query.Replace("@total", harga)
            query = query.Replace("@id", id)

            Dim cmd As New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()

            conn.Close()
            updateHarga = True
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Function

    Public Function addDetailTransaksi(detailTransaksi As DetailTransaksi) As Integer
        addDetailTransaksi = -1
        detailTransaksi.idTransaksi = Me.id

        If Not detailTransaksi.save = -1 Then
            _detail_transaksi.Add(detailTransaksi)
            addDetailTransaksi = detailTransaksi.id

            updateHarga(totalHarga)
        End If
    End Function

    Public Function removeDetailTransaksi(index As Integer) As Boolean
        removeDetailTransaksi = False

        If _detail_transaksi.Item(index).delete Then
            _detail_transaksi.RemoveAt(index)
            removeDetailTransaksi = True

            updateHarga(totalHarga)
        End If
    End Function

    Public Function changeDetailTransaksi(index As Integer, detailTransaksi As DetailTransaksi) As Boolean
        changeDetailTransaksi = False

        If detailTransaksi.update(detailTransaksi.id) Then
            _detail_transaksi.Item(index) = detailTransaksi
            changeDetailTransaksi = True

            updateHarga(totalHarga)
        End If
    End Function

    Public Function totalHarga() As Double
        Dim total As Double = 0

        For Each detail As DetailTransaksi In _detail_transaksi
            total = total + (detail.harga * detail.satuan)
        Next

        totalHarga = total
    End Function

    Public Shared Function getYearAllTransaksi() As List(Of String)
        Dim Strings As New List(Of String)

        Try
            Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim reader As New OleDbCommand("Select distinct(year(tanggal_masuk)) as tahun from transaksi", connection)
            Dim data As OleDbDataReader = reader.ExecuteReader()

            While data.Read
                Strings.Add(CStr(data.GetInt16(data.GetOrdinal("tahun"))))
            End While

            connection.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        getYearAllTransaksi = Strings
    End Function

    Public Shared Function getMonthTransaksi(year As Integer) As List(Of Int16)
        Dim Strings As New List(Of Int16)

        Try

            Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim stm As String = "Select distinct(month(tanggal_masuk)) as bulan from transaksi where year(tanggal_masuk) = " & year

            Dim reader As New OleDbCommand(stm, connection)
            Dim Data As OleDbDataReader = reader.ExecuteReader()

            While Data.Read
                Strings.Add(Data.GetInt16(Data.GetOrdinal("bulan")))
            End While

            connection.Close()

        Catch EX As Exception
            Console.WriteLine(EX.Message)
        End Try
        getMonthTransaksi = Strings
    End Function

    Public Shared Function search(text As String) As List(Of Transaksi)
        Dim transaksis As New List(Of Transaksi)

        Dim connection As New OleDbConnection(appPathDatabase)
        connection.Open()

        Dim query As String = ""

        query = "select transaksi.* from transaksi inner join pelanggan on pelanggan.id = transaksi.pelanggan "
        query += " where transaksi.id & "" like '" & text & "' or  transaksi.pelanggan & "" like '" & text & "' or pelanggan.nama like '%" & text & "%'"

        Console.WriteLine(query)

        Dim reader As New OleDbCommand(query, connection)

        Dim myReader As OleDbDataReader = reader.ExecuteReader()

        While myReader.Read()
            Dim transaksi As New Transaksi

                transaksi.id = getSafeInt32(myReader, "id")
                transaksi.id_pelanggan = getSafeInt32(myReader, "pelanggan")
                transaksi.merek = getSafeString(myReader, "merek")
                transaksi.type = getSafeString(myReader, "type")
                transaksi.serial_number = getSafeString(myReader, "serial_number")
                transaksi.kelengkapan = getSafeString(myReader, "kelengkapan")
                transaksi.keluhan = getSafeString(myReader, "keluhan")
                transaksi.catatan = getSafeString(myReader, "catatan")
                transaksi.tanggal_masuk = getSafeDate(myReader, "tanggal_masuk")
                transaksi.jenis_kerusakan = getSafeString(myReader, "jenis")
                transaksi.bayar = getSafeInt32(myReader, "bayar")
                transaksi.total = getSafeInt32(myReader, "total")
                transaksi.kembalian = getSafeInt32(myReader, "kembalian")
                transaksi.tanggal_keluar = getSafeDate(myReader, "tanggal_keluar")

                transaksi.pelanggan = Pelanggan.show(transaksi.id_pelanggan)
                transaksi.detail_transaksi = DetailTransaksi.all(transaksi.id)

                transaksis.Add(transaksi)
            End While

            connection.Close()

            search = transaksis
    End Function

End Class
