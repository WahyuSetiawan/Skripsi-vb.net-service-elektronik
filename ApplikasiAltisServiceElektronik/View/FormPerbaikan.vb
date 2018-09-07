Imports Microsoft.Reporting.WinForms

Public Class FormPerbaikan
    Private formDaftarKerusakan As FormDaftarKerusakan
    Private formMenutUtama As FormMenuUtama

    Public idPelanggan As Integer = 0
    Public idDetail As Integer
    Dim baris As Integer

    Dim transaksi As Transaksi

    Dim stringSelesai As String = "Cetak Selesai Dan Cetak"
    Dim stringCetak As String = "Cetak"

    Sub New(ByVal inst As FormDaftarKerusakan, ByVal id As Integer, baris As Integer)
        InitializeComponent()
        Me.formDaftarKerusakan = inst
        Me.baris = baris

        kosong()
        kosongdetail()
        loadTable()

        transaksi = Transaksi.show(id)

        If Not transaksi Is Nothing Then
            If Not transaksi.pelanggan Is Nothing Then
                Me.lblNamaPelanggan.Text = transaksi.pelanggan.ID.ToString & " - " & transaksi.pelanggan.nama.ToString
                Me.idPelanggan = transaksi.pelanggan.ID
            End If
            Me.Text = "Transaksi : " & transaksi.id & " /  pelanggan : " & transaksi.pelanggan.ID

            Me.txtCatatan.Text = transaksi.catatan
            Me.txtKelengkapan.Text = transaksi.kelengkapan
            Me.txtKeluhan.Text = transaksi.keluhan
            Me.txtMerek.Text = transaksi.merek
            Me.txtType.Text = transaksi.type
            Me.txtSerialNumber.Text = transaksi.serial_number
            Me.txtTotalHarga.Text = transaksi.totalHarga
            Me.txtDibayarkan.Text = transaksi.bayar
            Me.txtSisaPembayaran.Text = transaksi.kembalian

            'Me.cmbJenisKerusakan.Text = transaksi.jenis_kerusakan

            Me.lblJenisKerusakan.Text = CStr(Me.transaksi.jenis_kerusakan.id) + " " + Me.transaksi.jenis_kerusakan.JenisKerusakana
            Me.lblAsumsiPerbaikan.Text = Me.transaksi.jenis_kerusakan.Biaya

            If Me.transaksi.tanggal_keluar = Nothing Then

            Else
                disableAllButton(Me)
                readOnlyAllTextBox(Me)
                disableAllCMB(Me)
                disableAllList(Me)

                btnCetak.Text = stringCetak
                btnCetak.Enabled = True
            End If

            loadDataTable()
        Else
            Me.Close()
        End If
    End Sub

    Sub New(ByVal inst As FormMenuUtama)
        InitializeComponent()
        Me.formMenutUtama = inst
        Me.Text = "Transaksi Baru"
        pertamaJalan()
    End Sub

    Sub New(ByVal inst As FormDaftarKerusakan)
        InitializeComponent()
        Me.formDaftarKerusakan = inst
        Me.Text = "Transaksi Baru"
        pertamaJalan()
    End Sub

    Sub pertamaJalan()
        kosong()
        kosongdetail()
        loadTable()
        loadDataTable()
    End Sub

    Sub loadComboBox()
        'Me.cmbJenisKerusakan.Items.Clear()
        'Me.cmbJenisKerusakan.Items.Add("Kerusakan Ringan")
        'Me.cmbJenisKerusakan.Items.Add("Kerusakan Sedang")
        'Me.cmbJenisKerusakan.Items.Add("Kerusakan Berat")

        'If Me.cmbJenisKerusakan.Text = "" Then Me.cmbJenisKerusakan.Text = "Kerusakan Ringan"
    End Sub

    Sub kosong()
        Me.txtCatatan.Text = ""
        Me.txtKeluhan.Text = ""
        Me.txtKelengkapan.Text = ""
        Me.txtMerek.Text = ""
        Me.txtSerialNumber.Text = ""

        Me.lblAsumsiPerbaikan.Text = ""
        Me.lblJenisKerusakan.Text = ""
        Me.lblNamaPelanggan.Text = ""
        'Me.cmbJenisKerusakan.ResetText()
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

            .Columns.Add("No", 10)
            .Columns.Add("ID", 40)
            .Columns.Add("Perihal", 100)
            .Columns.Add("Satuan", 100)
            .Columns.Add("Harga", 100)
        End With
    End Sub

    Sub loadDataTable()
        If Not transaksi Is Nothing Then
            For i = 0 To transaksi.detail_transaksi.Count - 1
                addColumnListDetail(transaksi.detail_transaksi.Item(i))
            Next
            txtTotalHarga.Text = transaksi.totalHarga
        End If
    End Sub

    Private Sub FormCheckAndRepair_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadComboBox()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilihPelanggan.Click
        Dim form As New FormPelanggan(Me)
        form.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahDetail.Click
        If formValidationDetail() Then
            Select Case btnTambahDetail.Text.Trim
                Case "Ubah"
                    Dim index As Integer = Me.ListViewDetailTransaksi.FocusedItem.Index()

                    Dim detailTransaksi As DetailTransaksi = transaksi.detail_transaksi.Item(index)

                    detailTransaksi.perihal = txtPerihal.Text.Trim
                    detailTransaksi.satuan = txtSatuan.Text.Trim
                    detailTransaksi.harga = txtHarga.Text.Trim

                    If transaksi.changeDetailTransaksi(index, detailTransaksi) Then
                        changeColumnListDetail(index, detailTransaksi)

                        txtTotalHarga.Text = transaksi.totalHarga
                        kosongdetail()
                    End If
                Case "Tambah"
                    Dim detailTransaksi As New DetailTransaksi

                    detailTransaksi.perihal = txtPerihal.Text.Trim
                    detailTransaksi.satuan = txtSatuan.Text.Trim
                    detailTransaksi.harga = txtHarga.Text.Trim

                    Dim last_id As Integer = Me.transaksi.addDetailTransaksi(detailTransaksi)

                    If Not last_id = -1 Then
                        detailTransaksi.id = last_id
                        addColumnListDetail(detailTransaksi)

                        txtTotalHarga.Text = transaksi.totalHarga
                        kosongdetail()
                    Else
                        MsgBox("Tidak dapat menambahkan detail transaksi")
                    End If
            End Select
        End If
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

        Dim index As Integer = Me.ListViewDetailTransaksi.FocusedItem.Index()

        If jawab = vbYes Then
            If transaksi.removeDetailTransaksi(index) Then
                ListViewDetailTransaksi.Items(index).Remove()

                kosongdetail()

                btnTambahDetail.Text = "Tambah"
            Else
                MsgBox("Tidak dapat menghapus data Detail Transaksi")
            End If
        End If
    End Sub

    Private Sub txtDibayarkan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDibayarkan.TextChanged
        If IsNumeric(txtDibayarkan.Text) And IsNumeric(txtTotalHarga.Text) Then
            txtSisaPembayaran.Text = Double.Parse(txtDibayarkan.Text) - Double.Parse(txtTotalHarga.Text)
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If formValidation() Then
            transaksi.id_pelanggan = idPelanggan.ToString.Trim
            transaksi.merek = txtMerek.Text
            transaksi.type = txtType.Text
            transaksi.serial_number = txtSerialNumber.Text
            'transaksi.jenis_kerusakan = cmbJenisKerusakan.Text
            transaksi.jenis_kerusakan = transaksi.jenis_kerusakan
            transaksi.kelengkapan = txtKelengkapan.Text
            transaksi.keluhan = txtKeluhan.Text
            transaksi.catatan = txtCatatan.Text
            transaksi.total = txtTotalHarga.Text
            transaksi.bayar = 0
            transaksi.kembalian = 0
            transaksi.tanggal_keluar = Nothing

            If Me.transaksi.update Then
                MsgBox("Update data trasaksi berhasil")

                Dim transaksiChange As Transaksi = Transaksi.show(transaksi.id)

                formDaftarKerusakan.changeList(baris, transaksiChange)

                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Select Case btnCetak.Text
            Case stringSelesai
                If formValidation() Then
                    transaksi.id_pelanggan = idPelanggan.ToString.Trim
                    transaksi.merek = txtMerek.Text
                    transaksi.type = txtType.Text
                    transaksi.serial_number = txtSerialNumber.Text
                    'transaksi.jenis_kerusakan = cmbJenisKerusakan.Text
                    transaksi.jenis_kerusakan = transaksi.jenis_kerusakan
                    transaksi.kelengkapan = txtKelengkapan.Text
                    transaksi.keluhan = txtKeluhan.Text
                    transaksi.catatan = txtCatatan.Text
                    transaksi.total = txtTotalHarga.Text
                    transaksi.bayar = txtDibayarkan.Text
                    transaksi.kembalian = txtSisaPembayaran.Text
                    transaksi.tanggal_keluar = Date.Now

                    If transaksi.update() Then
                        MsgBox("Berhasil menyimpan data transaksi")

                        Me.Close()

                        Dim formLaporanNota As New LaporanNota(Me, transaksi.id)
                        formLaporanNota.MdiParent = formMenutUtama
                        formLaporanNota.Show()

                        formDaftarKerusakan.changeList(baris, transaksi)
                    Else
                        MsgBox("Menyimpan data transaksi gagal")
                    End If
                Else
                    MsgBox("Tidak berhasil menyimpan data")
                End If
            Case "Cetak"
                Dim formLaporanNota As New LaporanNota(Me, transaksi.id)
                formLaporanNota.MdiParent = formMenutUtama
                formLaporanNota.Show()

                formDaftarKerusakan.changeList(baris, transaksi)
        End Select
    End Sub

    Sub changeColumnListDetail(index As Integer, detailTransaksi As DetailTransaksi)
        Me.ListViewDetailTransaksi.Items(index).SubItems(2).Text = detailTransaksi.perihal
        Me.ListViewDetailTransaksi.Items(index).SubItems(3).Text = detailTransaksi.satuan
        Me.ListViewDetailTransaksi.Items(index).SubItems(4).Text = detailTransaksi.harga
    End Sub

    Sub addColumnListDetail(detailTransaksi As DetailTransaksi)
        Dim baris As Integer = Me.ListViewDetailTransaksi.Items.Count + 1

        Me.ListViewDetailTransaksi.Items.Add(baris)
        Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(detailTransaksi.id)
        Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(detailTransaksi.perihal)
        Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(detailTransaksi.satuan)
        Me.ListViewDetailTransaksi.Items(baris - 1).SubItems.Add(detailTransaksi.harga)

    End Sub

    Function formValidation() As Boolean
        formValidation = True

        If idPelanggan = 0 Then GoTo ErrorResult
        If FormIsNull(txtMerek, "merek") Then GoTo ErrorResult

        If FormIsNumeric(txtSisaPembayaran, "pembayaran") Then GoTo ErrorResult
        If FormIsNull(txtSisaPembayaran, "pembayaran") Then GoTo ErrorResult
        If costumFormMin(txtSisaPembayaran, 0, "pembayaran") Then GoTo ErrorResult

        If FormIsNumeric(txtTotalHarga, "total harga") Then GoTo ErrorResult
        If FormIsNull(txtTotalHarga, "total harga") Then GoTo ErrorResult
        If costumFormMin(txtTotalHarga, 0, "total harga") Then GoTo ErrorResult

        If FormIsNumeric(txtDibayarkan, "dibayarkan") Then GoTo ErrorResult
        If FormIsNull(txtDibayarkan, "dibayarkan") Then GoTo ErrorResult
        If costumFormMin(txtSisaPembayaran, 0, "dibayarkan") Then GoTo ErrorResult

        Exit Function
ErrorResult:
        formValidation = False
        Exit Function
    End Function


    Function formValidationDetail() As Boolean
        formValidationDetail = True

        If FormIsNull(txtPerihal, "perihal") Then GoTo ErrorResult

        If FormIsNumeric(txtSatuan, "satuan") Then GoTo ErrorResult
        If FormIsNull(txtSatuan, "satuan") Then GoTo ErrorResult
        If costumFormMin(txtSatuan, 0, "satuan") Then GoTo ErrorResult

        If FormIsNumeric(txtHarga, "harga") Then GoTo ErrorResult
        If FormIsNull(txtHarga, "harga") Then GoTo ErrorResult
        If costumFormMin(txtHarga, 0, "harga") Then GoTo ErrorResult

        Exit Function
ErrorResult:
        formValidationDetail = False
        Exit Function
    End Function

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnHapus1.Click
        Dim jawab As String = MsgBox("Anda yakin menghapus data transaksi ini", vbYesNo, "Konfirmasi")

        If jawab = vbYes Then
            transaksi.delete()
            Me.formDaftarKerusakan.remove(baris)
            Me.Close()
        End If
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
End Class