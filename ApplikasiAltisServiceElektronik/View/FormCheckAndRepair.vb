Public Class FormCheckAndRepair
    Private formDaftarKerusakan As FormDaftarKerusakan
    Private formMenutUtama As FormMenuUtama

    Public idPelanggan As Integer = 0

    Sub New(ByVal inst As FormDaftarKerusakan, ByVal idPelanggan As Integer)
        InitializeComponent()

        Me.formDaftarKerusakan = inst
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

        If Me.cmbJenisKerusakan.Text = "" Then
            Me.cmbJenisKerusakan.Text = "Kerusakan Ringan"
        End If
    End Sub

    Sub kosong()
        Me.txtCatatan.Text = ""
        Me.txtKeluhan.Text = ""
        Me.txtKelengkapan.Text = ""
        Me.txtMerek.Text = ""
        Me.txtSerialNumber.Text = ""
        Me.cmbJenisKerusakan.ResetText()
    End Sub

    Private Sub FormCheckAndRepair_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadComboBox()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If formValidation() Then
            Dim transaksi As New Transaksi

            transaksi.id_pelanggan = idPelanggan.ToString.Trim
            transaksi.merek = txtMerek.Text
            transaksi.type = txtType.Text
            transaksi.serial_number = txtSerialNumber.Text
            transaksi.jenis_kerusakan = cmbJenisKerusakan.Text
            transaksi.kelengkapan = txtKelengkapan.Text
            transaksi.keluhan = txtKeluhan.Text
            transaksi.catatan = txtCatatan.Text

            If Not transaksi.save = -1 Then
                MsgBox("Berhasil menyimpan data transaksi baru")
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilihPelanggan.Click
        Dim form As New FormPelanggan(Me)
        form.Show()
    End Sub

    Function formValidation() As Boolean
        formValidation = True

        If idPelanggan = 0 Then
            MsgBox("Pelanggan belum dipilih ")
            btnPilihPelanggan.Focus()
            GoTo errorResult
        End If

        If FormIsNull(txtMerek, "merek") Then GoTo errorResult
        If FormIsNull(txtKeluhan, "keluhan") Then GoTo errorResult

errorResult:
        formValidation = False
        Exit Function
    End Function

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class