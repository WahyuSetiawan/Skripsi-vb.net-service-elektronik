<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckAndRepair
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKeluhan = New System.Windows.Forms.TextBox()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPilihPelanggan = New System.Windows.Forms.Button()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.lblNamaPelanggan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKelengkapan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnJenisKerusakan = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAsumsi = New System.Windows.Forms.Label()
        Me.lblJenisKerusakan = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Keluhan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Catatan"
        '
        'txtKeluhan
        '
        Me.txtKeluhan.Location = New System.Drawing.Point(113, 259)
        Me.txtKeluhan.Multiline = True
        Me.txtKeluhan.Name = "txtKeluhan"
        Me.txtKeluhan.Size = New System.Drawing.Size(406, 52)
        Me.txtKeluhan.TabIndex = 7
        '
        'txtCatatan
        '
        Me.txtCatatan.Location = New System.Drawing.Point(113, 317)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(406, 56)
        Me.txtCatatan.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnPilihPelanggan)
        Me.GroupBox1.Controls.Add(Me.txtSerialNumber)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMerek)
        Me.GroupBox1.Controls.Add(Me.lblNamaPelanggan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 124)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Pelanggan"
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(116, 71)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(371, 20)
        Me.txtType.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Type"
        '
        'btnPilihPelanggan
        '
        Me.btnPilihPelanggan.Location = New System.Drawing.Point(116, 16)
        Me.btnPilihPelanggan.Name = "btnPilihPelanggan"
        Me.btnPilihPelanggan.Size = New System.Drawing.Size(25, 23)
        Me.btnPilihPelanggan.TabIndex = 1
        Me.btnPilihPelanggan.Text = "..."
        Me.btnPilihPelanggan.UseVisualStyleBackColor = True
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(116, 97)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(371, 20)
        Me.txtSerialNumber.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Serial Number"
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(116, 45)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(177, 20)
        Me.txtMerek.TabIndex = 3
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Merek"
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
        'txtKelengkapan
        '
        Me.txtKelengkapan.Location = New System.Drawing.Point(113, 200)
        Me.txtKelengkapan.Multiline = True
        Me.txtKelengkapan.Name = "txtKelengkapan"
        Me.txtKelengkapan.Size = New System.Drawing.Size(406, 52)
        Me.txtKelengkapan.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Kelengkapan Unit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnSimpan)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 379)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 57)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(406, 20)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 10
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(12, 19)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 24)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Jenis Kerusakan"
        '
        'btnJenisKerusakan
        '
        Me.btnJenisKerusakan.Location = New System.Drawing.Point(113, 139)
        Me.btnJenisKerusakan.Name = "btnJenisKerusakan"
        Me.btnJenisKerusakan.Size = New System.Drawing.Size(30, 23)
        Me.btnJenisKerusakan.TabIndex = 15
        Me.btnJenisKerusakan.Text = "..."
        Me.btnJenisKerusakan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Asumsi Perbaikan"
        '
        'lblAsumsi
        '
        Me.lblAsumsi.AutoSize = True
        Me.lblAsumsi.Location = New System.Drawing.Point(113, 175)
        Me.lblAsumsi.Name = "lblAsumsi"
        Me.lblAsumsi.Size = New System.Drawing.Size(45, 13)
        Me.lblAsumsi.TabIndex = 17
        Me.lblAsumsi.Text = "Label11"
        '
        'lblJenisKerusakan
        '
        Me.lblJenisKerusakan.AutoSize = True
        Me.lblJenisKerusakan.Location = New System.Drawing.Point(149, 144)
        Me.lblJenisKerusakan.Name = "lblJenisKerusakan"
        Me.lblJenisKerusakan.Size = New System.Drawing.Size(45, 13)
        Me.lblJenisKerusakan.TabIndex = 18
        Me.lblJenisKerusakan.Text = "Label12"
        '
        'FormCheckAndRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(528, 444)
        Me.Controls.Add(Me.lblJenisKerusakan)
        Me.Controls.Add(Me.lblAsumsi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnJenisKerusakan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtKelengkapan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.txtKeluhan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCheckAndRepair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckAndRepair"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKeluhan As System.Windows.Forms.TextBox
    Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMerek As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaPelanggan As System.Windows.Forms.Label
    Friend WithEvents txtKelengkapan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPilihPelanggan As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnJenisKerusakan As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblAsumsi As Label
    Friend WithEvents lblJenisKerusakan As Label
End Class
