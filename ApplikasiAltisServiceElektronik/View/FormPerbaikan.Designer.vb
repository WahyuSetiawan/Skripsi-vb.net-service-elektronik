<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerbaikan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPilihPelanggan = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnHapus1 = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        Me.txtKelengkapan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbJenisKerusakan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.txtKeluhan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.ListViewDetailTransaksi = New System.Windows.Forms.ListView()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnTambahDetail = New System.Windows.Forms.Button()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPerihal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSisaPembayaran = New System.Windows.Forms.TextBox()
        Me.txtDibayarkan = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPilihPelanggan
        '
        Me.btnPilihPelanggan.Location = New System.Drawing.Point(116, 16)
        Me.btnPilihPelanggan.Name = "btnPilihPelanggan"
        Me.btnPilihPelanggan.Size = New System.Drawing.Size(25, 23)
        Me.btnPilihPelanggan.TabIndex = 17
        Me.btnPilihPelanggan.Text = "..."
        Me.btnPilihPelanggan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCetak)
        Me.GroupBox2.Controls.Add(Me.btnHapus1)
        Me.GroupBox2.Controls.Add(Me.btnUbah)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 666)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 57)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(348, 20)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(153, 23)
        Me.btnCetak.TabIndex = 13
        Me.btnCetak.Text = "Cetak Selesai Dan Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnHapus1
        '
        Me.btnHapus1.Location = New System.Drawing.Point(93, 19)
        Me.btnHapus1.Name = "btnHapus1"
        Me.btnHapus1.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus1.TabIndex = 11
        Me.btnHapus1.Text = "Hapus"
        Me.btnHapus1.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(12, 19)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 24)
        Me.btnUbah.TabIndex = 10
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Kelengkapan Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Keluhan"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(116, 96)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(385, 20)
        Me.txtSerialNumber.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Serial Number"
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(116, 45)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(195, 20)
        Me.txtMerek.TabIndex = 14
        '
        'lblNamaPelanggan
        '
        Me.lblNamaPelanggan.AutoSize = True
        Me.lblNamaPelanggan.Location = New System.Drawing.Point(147, 21)
        Me.lblNamaPelanggan.Name = "lblNamaPelanggan"
        Me.lblNamaPelanggan.Size = New System.Drawing.Size(35, 13)
        Me.lblNamaPelanggan.TabIndex = 13
        Me.lblNamaPelanggan.Text = "Nama"
        '
        'txtKelengkapan
        '
        Me.txtKelengkapan.Location = New System.Drawing.Point(113, 140)
        Me.txtKelengkapan.Multiline = True
        Me.txtKelengkapan.Name = "txtKelengkapan"
        Me.txtKelengkapan.Size = New System.Drawing.Size(406, 52)
        Me.txtKelengkapan.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Merek"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btnPilihPelanggan)
        Me.GroupBox1.Controls.Add(Me.txtSerialNumber)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMerek)
        Me.GroupBox1.Controls.Add(Me.lblNamaPelanggan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbJenisKerusakan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 122)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Pelanggan"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(116, 70)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(273, 20)
        Me.txtType.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Jenis Kerusakan"
        '
        'cmbJenisKerusakan
        '
        Me.cmbJenisKerusakan.FormattingEnabled = True
        Me.cmbJenisKerusakan.Location = New System.Drawing.Point(366, 18)
        Me.cmbJenisKerusakan.Name = "cmbJenisKerusakan"
        Me.cmbJenisKerusakan.Size = New System.Drawing.Size(135, 21)
        Me.cmbJenisKerusakan.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama"
        '
        'txtCatatan
        '
        Me.txtCatatan.Location = New System.Drawing.Point(113, 257)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(406, 56)
        Me.txtCatatan.TabIndex = 17
        '
        'txtKeluhan
        '
        Me.txtKeluhan.Location = New System.Drawing.Point(113, 199)
        Me.txtKeluhan.Multiline = True
        Me.txtKeluhan.Name = "txtKeluhan"
        Me.txtKeluhan.Size = New System.Drawing.Size(406, 52)
        Me.txtKeluhan.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Catatan"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Controls.Add(Me.ListViewDetailTransaksi)
        Me.GroupBox3.Controls.Add(Me.txtSatuan)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btnTambahDetail)
        Me.GroupBox3.Controls.Add(Me.txtHarga)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtPerihal)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 319)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 263)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Transaksi"
        '
        'btnHapus
        '
        Me.btnHapus.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnHapus.Location = New System.Drawing.Point(426, 234)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 24
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'ListViewDetailTransaksi
        '
        Me.ListViewDetailTransaksi.Location = New System.Drawing.Point(11, 62)
        Me.ListViewDetailTransaksi.Name = "ListViewDetailTransaksi"
        Me.ListViewDetailTransaksi.Size = New System.Drawing.Size(490, 166)
        Me.ListViewDetailTransaksi.TabIndex = 23
        Me.ListViewDetailTransaksi.UseCompatibleStateImageBehavior = False
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(204, 36)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(107, 20)
        Me.txtSatuan.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(201, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Satuan"
        '
        'btnTambahDetail
        '
        Me.btnTambahDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnTambahDetail.Location = New System.Drawing.Point(426, 33)
        Me.btnTambahDetail.Name = "btnTambahDetail"
        Me.btnTambahDetail.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahDetail.TabIndex = 4
        Me.btnTambahDetail.Text = "Tambah"
        Me.btnTambahDetail.UseVisualStyleBackColor = True
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(317, 36)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(103, 20)
        Me.txtHarga.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(314, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Harga"
        '
        'txtPerihal
        '
        Me.txtPerihal.Location = New System.Drawing.Point(13, 36)
        Me.txtPerihal.Name = "txtPerihal"
        Me.txtPerihal.Size = New System.Drawing.Size(185, 20)
        Me.txtPerihal.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Detail Transaksi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 591)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Total Biaya"
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Location = New System.Drawing.Point(277, 588)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Size = New System.Drawing.Size(236, 20)
        Me.txtTotalHarga.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 617)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Bayar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 643)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Sisa Pembayaran"
        '
        'txtSisaPembayaran
        '
        Me.txtSisaPembayaran.Location = New System.Drawing.Point(277, 640)
        Me.txtSisaPembayaran.Name = "txtSisaPembayaran"
        Me.txtSisaPembayaran.Size = New System.Drawing.Size(236, 20)
        Me.txtSisaPembayaran.TabIndex = 29
        '
        'txtDibayarkan
        '
        Me.txtDibayarkan.Location = New System.Drawing.Point(277, 614)
        Me.txtDibayarkan.Name = "txtDibayarkan"
        Me.txtDibayarkan.Size = New System.Drawing.Size(236, 20)
        Me.txtDibayarkan.TabIndex = 30
        '
        'FormPerbaikan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 729)
        Me.Controls.Add(Me.txtDibayarkan)
        Me.Controls.Add(Me.txtSisaPembayaran)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKelengkapan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.txtKeluhan)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FormPerbaikan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPerbaikan"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPilihPelanggan As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents btnHapus1 As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMerek As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaPelanggan As System.Windows.Forms.Label
    Friend WithEvents txtKelengkapan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbJenisKerusakan As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents txtKeluhan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTambahDetail As System.Windows.Forms.Button
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPerihal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents ListViewDetailTransaksi As System.Windows.Forms.ListView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSisaPembayaran As System.Windows.Forms.TextBox
    Friend WithEvents txtDibayarkan As System.Windows.Forms.TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label14 As Label
End Class
