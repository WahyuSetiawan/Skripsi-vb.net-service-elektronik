<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
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
        Me.components = New System.ComponentModel.Container()
        Me.PelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoTelepon = New System.Windows.Forms.TextBox()
        Me.txtNoKtp = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(12, 206)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(573, 148)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNoTelepon)
        Me.GroupBox1.Controls.Add(Me.txtNoKtp)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 154)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pelanggan"
        '
        'txtNoTelepon
        '
        Me.txtNoTelepon.Location = New System.Drawing.Point(112, 123)
        Me.txtNoTelepon.Name = "txtNoTelepon"
        Me.txtNoTelepon.Size = New System.Drawing.Size(284, 20)
        Me.txtNoTelepon.TabIndex = 5
        '
        'txtNoKtp
        '
        Me.txtNoKtp.Location = New System.Drawing.Point(112, 97)
        Me.txtNoKtp.Name = "txtNoKtp"
        Me.txtNoKtp.Size = New System.Drawing.Size(234, 20)
        Me.txtNoKtp.TabIndex = 4
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(112, 71)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(442, 20)
        Me.txtAlamat.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(112, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(284, 20)
        Me.txtID.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(112, 45)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(284, 20)
        Me.txtNama.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "No Telp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "No KTP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nama"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBatal)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnUbah)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 54)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(492, 19)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 9
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(172, 19)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(91, 19)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 7
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(10, 19)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.txtCari)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 28)
        Me.Panel1.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cari"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(38, 4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(449, 20)
        Me.txtCari.TabIndex = 1
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(493, 3)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 421)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "FormPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelanggan"
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PelangganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNoTelepon As TextBox
    Friend WithEvents txtNoKtp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label6 As Label
End Class
