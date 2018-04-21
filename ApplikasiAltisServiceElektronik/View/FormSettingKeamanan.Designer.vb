<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSetttingKeamanan
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
        Me.txtPengguna = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.RadioButtonTanpaKeamanan = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMenggunakanKeamanan = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama Pengguna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'txtPengguna
        '
        Me.txtPengguna.Location = New System.Drawing.Point(102, 62)
        Me.txtPengguna.Name = "txtPengguna"
        Me.txtPengguna.Size = New System.Drawing.Size(156, 20)
        Me.txtPengguna.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(102, 86)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(156, 20)
        Me.txtPassword.TabIndex = 5
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(264, 65)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 37)
        Me.btnUbah.TabIndex = 6
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(264, 127)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'RadioButtonTanpaKeamanan
        '
        Me.RadioButtonTanpaKeamanan.AutoSize = True
        Me.RadioButtonTanpaKeamanan.Location = New System.Drawing.Point(12, 12)
        Me.RadioButtonTanpaKeamanan.Name = "RadioButtonTanpaKeamanan"
        Me.RadioButtonTanpaKeamanan.Size = New System.Drawing.Size(110, 17)
        Me.RadioButtonTanpaKeamanan.TabIndex = 8
        Me.RadioButtonTanpaKeamanan.TabStop = True
        Me.RadioButtonTanpaKeamanan.Text = "Tanpa Keamanan"
        Me.RadioButtonTanpaKeamanan.UseVisualStyleBackColor = True
        '
        'RadioButtonMenggunakanKeamanan
        '
        Me.RadioButtonMenggunakanKeamanan.AutoSize = True
        Me.RadioButtonMenggunakanKeamanan.Location = New System.Drawing.Point(12, 34)
        Me.RadioButtonMenggunakanKeamanan.Name = "RadioButtonMenggunakanKeamanan"
        Me.RadioButtonMenggunakanKeamanan.Size = New System.Drawing.Size(148, 17)
        Me.RadioButtonMenggunakanKeamanan.TabIndex = 9
        Me.RadioButtonMenggunakanKeamanan.TabStop = True
        Me.RadioButtonMenggunakanKeamanan.Text = "Menggunakan Keamanan"
        Me.RadioButtonMenggunakanKeamanan.UseVisualStyleBackColor = True
        '
        'FormSetttingKeamanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 162)
        Me.Controls.Add(Me.RadioButtonMenggunakanKeamanan)
        Me.Controls.Add(Me.RadioButtonTanpaKeamanan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPengguna)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSetttingKeamanan"
        Me.Text = "Settting Keamanan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPengguna As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents RadioButtonTanpaKeamanan As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMenggunakanKeamanan As System.Windows.Forms.RadioButton
End Class
