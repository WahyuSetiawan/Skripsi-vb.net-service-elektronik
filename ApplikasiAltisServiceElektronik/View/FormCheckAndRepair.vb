Public Class FormCheckAndRepair
    Private formDaftarKerusakan As FormDaftarKerusakan
    Private formMenutUtama As FormMenuUtama

    Public idPelanggan As Integer = 0

    Sub New(ByVal inst As FormDaftarKerusakan, ByVal idPelanggan As Integer)
        InitializeComponent()

        Me.formDaftarKerusakan = inst
        Me.idPelanggan = idPelanggan

        Me.Text = "Transaksi "

        Try
            Dim connection As New OleDbConnection(appPathDatabase)
            connection.Open()

            Dim cmd1 As New OleDbCommand

            cmd1.Connection = koneksi
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "SELECT * FROM transaksi_masuk WHERE ID = @id"

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
        Catch EX As Exception
            MsgBox("Terjadi kesalahan : " & EX.Message)
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
                Dim koneksi As New OleDbConnection(appPathDatabase)

                Dim myCommand As New OleDbCommand("INSERT into transaksi_masuk (pelanggan, nama_barang, serial_number, jenis, kelengkapan_unit, keluhan, catatan) values  " & _
                     "(@pelanggan, @nama_barang, @serial_number, @jenis, @kelengkapan_unit, @keluhan, @catatan)", koneksi)

                myCommand.Parameters.AddWithValue("@pelanggan", idPelanggan.ToString.Trim)
                myCommand.Parameters.AddWithValue("@nama_barang", txtNamaBarang.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@serial_number", txtSerialNumber.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@jenis", cmbJenisKerusakan.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@kelengkapan_unit", txtKelengkapan.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@keluhan", txtKeluhan.Text.ToString.Trim)
                myCommand.Parameters.AddWithValue("@catatan", txtCatatan.Text.ToString.Trim)

                myCommand.ExecuteNonQuery()

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

End Class