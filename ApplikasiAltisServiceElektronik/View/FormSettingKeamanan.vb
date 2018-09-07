Public Class FormSetttingKeamanan
    Dim form As FormMenuUtama

    Sub New(ByVal form As FormMenuUtama)
        InitializeComponent()
        form = form

        txtPengguna.Text = Konfigurasi.selectKonfiguration(usernameKonf)
        txtPassword.Text = Konfigurasi.selectKonfiguration(passwordKonf)
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        Dim sukses As Boolean = False

        Konfigurasi.insertConfig(usernameKonf, txtPengguna.Text.Trim)
        Konfigurasi.insertConfig(passwordKonf, txtPassword.Text.Trim)

        MsgBox("Sistem keamanan berhasil terubah")
    End Sub

    Private Sub FormSetttingKeamanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class