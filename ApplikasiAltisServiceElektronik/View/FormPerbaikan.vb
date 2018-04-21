Imports Microsoft.Reporting.WinForms

Public Class FormPerbaikan

    Private formDaftarKerusakan As FormDaftarKerusakan
    Private formMenutUtama As FormMenuUtama

    Public idPelanggan As Integer = 0
    Public idDetail As Integer

    Public totalPembayaran As Integer = 0

    Sub New(ByVal inst As FormDaftarKerusakan, ByVal idPelanggan As Integer)
        InitializeComponent()

        Me.formDaftarKerusakan = inst
        Me.idPelanggan = idPelanggan

        Me.Text = "Transaksi " + idPelanggan.ToString
        Try
            Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim cmd1 As New OleDbCommand("SELECT * FROM transaksi_masuk WHERE ID = @id", connection)

            cmd1.Parameters.AddWithValue("@id", idPelanggan)

            reader = cmd1.ExecuteReader
            reader.Read()

            If reader.HasRows Then
                Me.txtCatatan.Text = reader.GetString(reader.GetOrdinal("catatan")).ToString.Trim
                Me.txtKelengkapan.Text = reader.GetString(reader.GetOrdinal("kelengkapan_unit")).ToString.Trim
                Me.txtKeluhan.Text = reader.GetString(reader.GetOrdinal("keluhan")).ToString.Trim
                Me.txtNamaBarang.Text = reader.GetString(reader.GetOrdinal("nama_barang")).ToString.Trim
                Me.txtSerialNumber.Text = reader.GetString(reader.GetOrdinal("serial_number")).ToString.Trim

                Me.cmbJenisKerusakan.Text = reader.GetString(reader.GetOrdinal("jenis")).ToString.Trim
            Else
                MsgBox("Tidak Terdapat transaksi")
            End If

            connection.Close()

            loadTable()
            loadDataTable()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan " + ex.Message)
        End Try
    End Sub

    Sub New(ByVal inst As FormMenuUtama)
        InitializeComponent()
        Me.formMenutUtama = inst
        Me.Text = "Transaksi Baru"
        kosong()
    End Sub

    Sub New(ByVal inst As FormDaftarKerusakan)
        InitializeComponent()
        Me.formDaftarKerusakan = inst
        Me.Text = "Transaksi Baru"
        kosong()
        loadTable()
        loadDataTable()
    End Sub

    Sub loadComboBox()
        Me.cmbJenisKerusakan.Items.Clear()
        Me.cmbJenisKerusakan.Items.Add("Kerusakan Ringan")
        Me.cmbJenisKerusakan.Items.Add("Kerusakan Sedang")
        Me.cmbJenisKerusakan.Items.Add("Kerusakan Berat")
    End Sub

    Sub kosong()
        Me.txtCatatan.Text = ""
        Me.txtKeluhan.Text = ""
        Me.txtKelengkapan.Text = ""
        Me.txtNamaBarang.Text = ""
        Me.txtSerialNumber.Text = ""
        Me.cmbJenisKerusakan.ResetText()
    End Sub

    Sub kosongdetail()
        Me.txtPerihal.Text = ""
        Me.txtSatuan.Text = 0
        Me.txtHarga.Text = 0
    End Sub

    Sub loadTable()
        With Me.ListViewDetailTransaksi
            .Items.Clear()

            ListViewDetailTransaksi.View = View.Details
            ListViewDetailTransaksi.GridLines = True
            ListViewDetailTransaksi.HideSelection = False
            ListViewDetailTransaksi.MultiSelect = False
            ListViewDetailTransaksi.FullRowSelect = True

            .Columns.Add("No")
            .Columns.Add("ID")
            .Columns.Add("Perihal")
            .Columns.Add("Satuan")
            .Columns.Add("Harga")
        End With
    End Sub

    Sub loadDataTable()
        Dim baris As Integer = 1

        With Me.ListViewDetailTransaksi
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommand As New OleDbCommand("select * from detail_transaksi where id_transaksi = @id", myConnection)

            myCommand.Parameters.AddWithValue("@id", idPelanggan)

            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            While myReader.Read
                Me.ListViewDetailTransaksi.Items.Add(baris)
                Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(myReader.GetInt32(myReader.GetOrdinal("id")))
                Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("perihal")))
                Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(myReader.GetInt32(myReader.GetOrdinal("satuan")))
                Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(myReader.GetInt32(myReader.GetOrdinal("harga")))

                totalPembayaran = totalPembayaran + myReader.GetInt32(myReader.GetOrdinal("harga"))
                txtTotalHarga.Text = totalPembayaran
                baris += 1
            End While

            myConnection.Close()
        End With
    End Sub

    Private Sub FormCheckAndRepair_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadComboBox()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim simpan As Boolean = True

        If txtKeluhan.Text.Trim = "" Then
            txtKeluhan.Focus()
            simpan = False
        End If

        If txtNamaBarang.Text.Trim = "" Then
            txtNamaBarang.Focus()
            simpan = False
        End If

        If cmbJenisKerusakan.Text = "" Then
            cmbJenisKerusakan.Focus()
            simpan = False
        End If


        If simpan Then
            Try
                Dim myConnection As New OleDbConnection(appPathDatabase)
                myConnection.Open()

                Dim myCommand As New OleDbCommand("INSERT into transaksi_masuk (pelanggan, nama_barang, serial_number, jenis, kelengkapan_unit, keluhan, catatan) values  " & _
                    "(@pelanggan, @nama_barang, @serial_number, @jenis, @kelengkapan_unit, @keluhan, @catatan)", myConnection)

                myCommand.Parameters.AddWithValue("@pelanggan", idPelanggan.ToString.Trim)
                myCommand.Parameters.AddWithValue("@nama_barang", txtNamaBarang.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@serial_number", txtSerialNumber.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@jenis", cmbJenisKerusakan.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@kelengkapan_unit", txtKelengkapan.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@keluhan", txtKeluhan.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@catatan", txtCatatan.Text.ToString.Trim)

                myCommand.ExecuteNonQuery()

                myConnection.Close()

                MsgBox("Berhasil memasukan transaksi baru")
            Catch ex As Exception
                MsgBox("Terdapat kesahan dalam penyimpanan data " & ex.Message)
            End Try
        Else

        End If
    End Sub

    Private Sub lblNamaPelanggan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNamaPelanggan.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilihPelanggan.Click
        Dim form As New FormPelanggan(Me)
        form.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahDetail.Click
        If btnTambahDetail.Text.Trim = "Ubah" Then

            Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim myCommand As New OleDbCommand("update detail_transaksi set perihal = '" & txtPerihal.Text.Trim & "', satuan = " & txtSatuan.Text.Trim & ", harga = " & txtHarga.Text.Trim & " where id = " & idDetail.ToString, connection)

            myCommand.ExecuteNonQuery()

            totalPembayaran = totalPembayaran - Integer.Parse(Me.ListViewDetailTransaksi.SelectedItems(0).SubItems(4).Text)

            Me.ListViewDetailTransaksi.SelectedItems(0).SubItems(2).Text = txtPerihal.Text.Trim
            Me.ListViewDetailTransaksi.SelectedItems(0).SubItems(3).Text = txtSatuan.Text.Trim
            Me.ListViewDetailTransaksi.SelectedItems(0).SubItems(4).Text = txtHarga.Text.Trim

            totalPembayaran = totalPembayaran + txtHarga.Text

            txtTotalHarga.Text = totalPembayaran

            connection.Close()
        Else
            Try
                Dim myConnection As New OleDbConnection(appPathDatabase)

                Dim myCommand As New OleDbCommand("insert into detail_transaksi (id_transaksi, perihal, satuan, harga) values (@id_transaksi, @perihal, @satuan, @harga)", myConnection)

                myCommand.Parameters.AddWithValue("@id_transaksi", idPelanggan)
                myCommand.Parameters.AddWithValue("@perihal", txtPerihal.Text.Trim)
                myCommand.Parameters.AddWithValue("@satuan", txtSatuan.Text.Trim)
                myCommand.Parameters.AddWithValue("@harga", txtHarga.Text.Trim)

                myCommand.ExecuteNonQuery()

                Dim baris As Integer = Me.ListViewDetailTransaksi.Items.Count + 1
                Dim iddetail As Integer = LastInsertedID()

                Me.ListViewDetailTransaksi.Items.Add(baris)
                Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(iddetail.ToString)
                Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(txtPerihal.Text.Trim)
                Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(txtSatuan.Text.Trim)
                Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(txtHarga.Text.Trim)

                myConnection.Close()

                totalPembayaran = totalPembayaran + Integer.Parse(txtHarga.Text.Trim)

                txtTotalHarga.Text = totalPembayaran

                kosongdetail()
            Catch ex As Exception
                MsgBox("Terdapat masalah dalam penyimpanan database :" & ex.Message)
            End Try
        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewDetailTransaksi.CacheVirtualItems

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewDetailTransaksi.Click
        If ListViewDetailTransaksi.SelectedItems.Count > 0 Then
            idDetail = Me.ListViewDetailTransaksi.SelectedItems(0).SubItems(1).Text
            txtPerihal.Text = Me.ListViewDetailTransaksi.SelectedItems(0).SubItems(2).Text
            txtSatuan.Text = Me.ListViewDetailTransaksi.SelectedItems(0).SubItems(3).Text
            txtHarga.Text = Me.ListViewDetailTransaksi.SelectedItems(0).SubItems(4).Text

            btnTambahDetail.Text = "Ubah"
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim jawab As String = MsgBox("Anda yakin menghapus data detail transaksi ini ?", vbYesNo, "Peringatan ")
        If jawab = vbYes Then
            Dim myConnection As New OleDbConnection(appPathDatabase)
            myConnection.Open()

            Dim myCommand As New OleDbCommand("select * from detail_transaksi where id = @id", myConnection)
            myCommand.Parameters.AddWithValue("@id", ListViewDetailTransaksi.SelectedItems(0).SubItems(1).Text)

            Dim reader As OleDbDataReader = myCommand.ExecuteReader
            reader.Read()

            If reader.HasRows Then
                Dim connection2 As New OleDbConnection(appPathDatabase)
                connection2.Open()

                Dim command As New OleDbCommand("delete from detail_transaksi where id = @id", connection2)

                command.Parameters.AddWithValue("@id", ListViewDetailTransaksi.SelectedItems(0).SubItems(1).Text.Trim)

                command.ExecuteNonQuery()

                connection2.Close()

                ListViewDetailTransaksi.SelectedItems(0).Remove()
            Else
                MsgBox("Data detail transaksi tidak ditemukan")
            End If
            myConnection.Close()
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        FormLaporanNota.Show()
    End Sub

    Private Sub ListViewDetailTransaksi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtDibayarkan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDibayarkan.TextChanged
        txtSisaPembayaran.Text = Integer.Parse(txtTotalHarga.Text) - Integer.Parse(txtDibayarkan.Text)
    End Sub
End Class