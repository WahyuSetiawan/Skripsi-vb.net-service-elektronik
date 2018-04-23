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
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(676, 237)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(613, 255)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 1
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnTransaksiBaru
        '
        Me.btnTransaksiBaru.Location = New System.Drawing.Point(12, 255)
        Me.btnTransaksiBaru.Name = "btnTransaksiBaru"
        Me.btnTransaksiBaru.Size = New System.Drawing.Size(75, 23)
        Me.btnTransaksiBaru.TabIndex = 2
        Me.btnTransaksiBaru.Text = "Transaksi Baru"
        Me.btnTransaksiBaru.UseVisualStyleBackColor = True
        '
        'FormDaftarKerusakan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 285)
        Me.Controls.Add(Me.btnTransaksiBaru)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "FormDaftarKerusakan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDaftarKerusakana"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnTransaksiBaru As System.Windows.Forms.Button
End Class
