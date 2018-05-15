<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarKerusakan
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnTransaksiBaru = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(12, 52)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(676, 237)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(613, 295)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 1
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnTransaksiBaru
        '
        Me.btnTransaksiBaru.Location = New System.Drawing.Point(12, 295)
        Me.btnTransaksiBaru.Name = "btnTransaksiBaru"
        Me.btnTransaksiBaru.Size = New System.Drawing.Size(75, 23)
        Me.btnTransaksiBaru.TabIndex = 2
        Me.btnTransaksiBaru.Text = "Transaksi Baru"
        Me.btnTransaksiBaru.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.txtCari)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 34)
        Me.Panel1.TabIndex = 3
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(51, 7)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(515, 20)
        Me.txtCari.TabIndex = 0
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(574, 6)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(93, 23)
        Me.btnCari.TabIndex = 1
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari :"
        '
        'FormDaftarKerusakan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 335)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnTransaksiBaru)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "FormDaftarKerusakan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Transaksi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnTransaksiBaru As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label1 As Label
End Class
