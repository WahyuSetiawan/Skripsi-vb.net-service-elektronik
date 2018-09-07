<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLaporanTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBulan = New System.Windows.Forms.ComboBox()
        Me.cmbTahun = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(147, 97)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(15, 97)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mencetak laporan untuk semua transaksi pada :"
        '
        'cmbBulan
        '
        Me.cmbBulan.FormattingEnabled = True
        Me.cmbBulan.Location = New System.Drawing.Point(133, 60)
        Me.cmbBulan.Name = "cmbBulan"
        Me.cmbBulan.Size = New System.Drawing.Size(89, 21)
        Me.cmbBulan.TabIndex = 6
        '
        'cmbTahun
        '
        Me.cmbTahun.FormattingEnabled = True
        Me.cmbTahun.Location = New System.Drawing.Point(15, 60)
        Me.cmbTahun.Name = "cmbTahun"
        Me.cmbTahun.Size = New System.Drawing.Size(86, 21)
        Me.cmbTahun.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tahun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Bulan"
        '
        'FormLaporanTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 137)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTahun)
        Me.Controls.Add(Me.cmbBulan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLaporanTransaksi"
        Me.Text = "FormLaporanTransaksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBatal As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbBulan As ComboBox
    Friend WithEvents cmbTahun As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
