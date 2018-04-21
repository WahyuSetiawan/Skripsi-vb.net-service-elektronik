Public Class FormMenuUtama
    Dim formLogin As FormLogin

    Sub New(ByVal form As FormLogin)
        InitializeComponent()
        formLogin = form
        formLogin.Visible = False
    End Sub

    Private Sub LogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOut.Click
        Me.Close()
    End Sub

    Private Sub PelangganToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem1.Click
        Try
            Dim form As New FormPelanggan
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan dalam penampilan form " & ex.Message)
        End Try
    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FormBarang.Show()
    End Sub

    Private Sub JenisKerusakanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisKerusakanToolStripMenuItem.Click
        FormJenisKerusakan.Show()
    End Sub

    Private Sub KerusakanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim form As New FormDaftarKerusakan(Me)
            form.MdiParent = Me
            form.StartPosition = FormStartPosition.CenterParent
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Sub

    Private Sub PengeluaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormTransaksi.Show()
    End Sub

    Private Sub TransaksiMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim form As New FormCheckAndRepair(Me)
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan dalam penampilan form " & ex.Message)
        End Try
    End Sub

    Private Sub FormMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LapornaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapornaToolStripMenuItem.Click
        FormLaporanPelanggan.Show()
    End Sub

    Private Sub KonfigusiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KonfigusiToolStripMenuItem.Click
        Try
            Dim formsetting As New FormSetttingKeamanan(Me)
            formsetting.MdiParent = Me
            formsetting.Show()
        Catch ex As Exception
            MsgBox("Terjadi keaslaahan dalam menampilkan form keamanan")
        End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        Try
            Dim form As New FormDaftarKerusakan(Me)
            form.MdiParent = Me
            form.StartPosition = FormStartPosition.CenterParent
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Sub
End Class
