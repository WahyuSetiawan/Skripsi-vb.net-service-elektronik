Public Class FormLogin
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasuk.Click
        If selectKonfigurationBoolean(keamananKonf) Then
            If selectKonfiguration(usernameKonf) = txtPengguna.Text.Trim Then
                If selectKonfiguration(passwordKonf) = txtPassword.Text.Trim Then
                    Dim form As New FormMenuUtama
                    form.Show()
                    Me.Hide()
                Else
                    MsgBox("Password tidak sesuai")
                End If
            Else
                MsgBox("Username tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not selectKonfigurationBoolean(keamananKonf) Then
            Dim form As New FormMenuUtama
            form.Show()
            Me.Hide()
        End If
    End Sub
End Class