Public Class FormMenuUtama
    Private Sub LogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PelangganToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim form As New FormPelanggan(Me)
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
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

    Private Sub TransaksiMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim form As New FormCheckAndRepair(Me)
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Sub

    Private Sub LapornaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim form As New LaporanPelanggan
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan : " & ex.Message)
        End Try
    End Sub

    Private Sub KonfigusiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KonfigusiToolStripMenuItem.Click
        Try
            Dim formsetting As New FormSetttingKeamanan(Me)
            formsetting.MdiParent = Me
            formsetting.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim form As New FormDaftarKerusakan(Me)
            form.MdiParent = Me
            form.StartPosition = FormStartPosition.CenterParent
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub LaporanPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPelangganToolStripMenuItem.Click
        Try
            Dim form As New FormLaporanPelanggan(Me)
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Sub

    Private Sub LaporanTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanTransaksiToolStripMenuItem.Click
        Try
            Dim form As New FormLaporanTransaksi(Me)
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Sub

    Private Sub FormMenuUtama_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        showFormLogin()
    End Sub

    Private Sub showFormLogin()
        Dim form As New FormLogin(Me)
        form.MdiParent = Me
        MenuStrip1.Enabled = False
        form.Show()
    End Sub

    Sub enableFormMenuUtama()
        MenuStrip1.Enabled = True
    End Sub

    Private Sub JenisKerusakanToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Try
            Dim form As New FormJenisKerusakan(Me)
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Sub

    Private Sub PelangganToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Try
            Dim menuUtama As New FormDaftarKerusakan(Me)
            menuUtama.MdiParent = Me
            menuUtama.Show()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " & ex.Message)
        End Try
    End Sub
End Class
