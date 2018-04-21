<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPelanggan = New System.Windows.Forms.Label()
        Me.lblKerusakan = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCetakNota = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Kerusakan"
        '
        'lblPelanggan
        '
        Me.lblPelanggan.AutoSize = True
        Me.lblPelanggan.Location = New System.Drawing.Point(12, 35)
        Me.lblPelanggan.Name = "lblPelanggan"
        Me.lblPelanggan.Size = New System.Drawing.Size(73, 13)
        Me.lblPelanggan.TabIndex = 2
        Me.lblPelanggan.Text = "lbl_pelanggan"
        '
        'lblKerusakan
        '
        Me.lblKerusakan.AutoSize = True
        Me.lblKerusakan.Location = New System.Drawing.Point(215, 35)
        Me.lblKerusakan.Name = "lblKerusakan"
        Me.lblKerusakan.Size = New System.Drawing.Size(68, 13)
        Me.lblKerusakan.TabIndex = 3
        Me.lblKerusakan.Text = "lblKerusakan"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(439, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'btnCetakNota
        '
        Me.btnCetakNota.Location = New System.Drawing.Point(355, 227)
        Me.btnCetakNota.Name = "btnCetakNota"
        Me.btnCetakNota.Size = New System.Drawing.Size(99, 31)
        Me.btnCetakNota.TabIndex = 5
        Me.btnCetakNota.Text = "Cetak Nota"
        Me.btnCetakNota.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 270)
        Me.Controls.Add(Me.btnCetakNota)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblKerusakan)
        Me.Controls.Add(Me.lblPelanggan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPelanggan As System.Windows.Forms.Label
    Friend WithEvents lblKerusakan As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCetakNota As System.Windows.Forms.Button
End Class
