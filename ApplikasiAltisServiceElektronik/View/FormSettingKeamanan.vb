Public Class FormSetttingKeamanan
    Dim form As FormMenuUtama

    Sub New(ByVal form As FormMenuUtama)
        InitializeComponent()
        form = form

        txtPengguna.Text = selectKonfiguration(usernameKonf)
        txtPassword.Text = selectKonfiguration(passwordKonf)
        RadioButtonMenggunakanKeamanan.Checked = selectKonfigurationBoolean(keamananKonf)
        RadioButtonTanpaKeamanan.Checked = Not RadioButtonMenggunakanKeamanan.Checked
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        Dim sukses As Boolean = False

        If RadioButtonMenggunakanKeamanan.Checked Then
            insertConfig(keamananKonf, True)

            If txtPengguna.Text = "" Then
                If RadioButtonMenggunakanKeamanan.Enabled Then
                    MsgBox("username tidak boleh kosong")
                End If
            Else
                insertConfig(usernameKonf, txtPengguna.Text.Trim)
            End If

            If txtPassword.Text = "" Then
                If RadioButtonMenggunakanKeamanan.Enabled Then
                    MsgBox("username tidak boleh kosong")
                End If
            Else
                insertConfig(passwordKonf, txtPassword.Text.Trim)
            End If
        Else
            insertConfig(keamananKonf, False)
        End If
    End Sub

    Private Sub FormSetttingKeamanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub RadioButtonTanpaKeamanan_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTanpaKeamanan.CheckedChanged
        If RadioButtonMenggunakanKeamanan.Checked Then
            txtPengguna.Enabled = True
            txtPassword.Enabled = True
        Else
            txtPengguna.Enabled = False
            txtPassword.Enabled = False
        End If
    End Sub
End Class