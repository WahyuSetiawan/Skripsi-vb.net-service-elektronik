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
        If Not validasi() Then
            kosong()
            Exit Sub
        End If

        login()
    End Sub

    Sub kosong()
        txtPengguna.Text = ""
        txtPassword.Text = ""
    End Sub

    Function validasi() As Boolean
        validasi = True

        If FormIsNull(txtPengguna, "pengguna") Then GoTo salah
        If FormIsNull(txtPassword, "password") Then GoTo salah

        Exit Function
salah:
        validasi = False
    End Function

    Private Sub txtPassword_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            login()
        End If
    End Sub

    Sub login()

        If Konfigurasi.selectKonfiguration(usernameKonf) = txtPengguna.Text.Trim Then
            If Konfigurasi.selectKonfiguration(passwordKonf) = txtPassword.Text.Trim Then
                If Not formMenuUtama Is Nothing Then
                    Me.formMenuUtama.enableFormMenuUtama()
                End If
                Me.Close()
            Else
                MsgBox("Password tidak sesuai")
                kosong()
            End If
        Else
            MsgBox("Username tidak ditemukan")
            kosong()
        End If
    End Sub
End Class