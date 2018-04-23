Public Class FormMenuUtama
    Private Sub LogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOut.Click
        If selectKonfigurationBoolean(keamananKonf) Then
            FormLogin.Show()
        End If

        Me.Close()
    End Sub

    Private Sub PelangganToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem1.Click
        Try
            Dim form As New FormPelanggan
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

    Private Sub LapornaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapornaToolStripMenuItem.Click
        Try
            Dim form As New FormLaporanPelanggan
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
