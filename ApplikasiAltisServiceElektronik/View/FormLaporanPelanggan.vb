Public Class FormLaporanPelanggan
    Dim formmenuutama As FormMenuUtama
    Sub New(form As FormMenuUtama)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.formmenuutama = form
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            Dim form As New LaporanPelanggan
            form.MdiParent = Me.formmenuutama
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " + ex.Message)
        End Try

    End Sub
End Class