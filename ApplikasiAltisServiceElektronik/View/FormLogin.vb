Public Class FormLogin
    Dim formMenuUtama As FormMenuUtama

    Sub New(ByVal form As FormMenuUtama)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        formMenuUtama = form
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasuk.Click
        If selectKonfigurationBoolean(keamananKonf) Then
            If selectKonfiguration(usernameKonf) = txtPengguna.Text.Trim Then
                If selectKonfiguration(passwordKonf) = txtPassword.Text.Trim Then
                    If Not formMenuUtama Is Nothing Then
                        Me.formMenuUtama.enableFormMenuUtama()
                    End If
                    Me.Close()
                    Else
                        MsgBox("Password tidak sesuai")
                End If
            Else
                MsgBox("Username tidak ditemukan")
            End If
        End If
    End Sub
End Class