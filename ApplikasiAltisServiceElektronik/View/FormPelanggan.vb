Public Class FormPelanggan
    Dim barisListView As Integer

    Dim formCheckAndRepair As FormCheckAndRepair
    Dim formMenuUtama As FormMenuUtama
    Dim formPerbaikan As FormPerbaikan

    Dim ambildata As Boolean = False

    Sub New(ByVal inst As FormPerbaikan)
        InitializeComponent()
        ambildata = True
        Me.formPerbaikan = inst
        kosong()
    End Sub
    Sub New(ByVal inst As FormMenuUtama)
        InitializeComponent()
        Me.formMenuUtama = inst
        kosong()
    End Sub

    Sub New(ByVal inst As FormCheckAndRepair)
        InitializeComponent()
        ambildata = True
        Me.formCheckAndRepair = inst
        kosong()
    End Sub

    Sub disableText()
        txtNama.Enabled = False
        txtAlamat.Enabled = False
        txtNoTelepon.Enabled = False
        txtNoKtp.Enabled = False
    End Sub

    Sub enableText()
        txtNama.Enabled = True
        txtAlamat.Enabled = True
        txtNoTelepon.Enabled = True
        txtNoKtp.Enabled = True
    End Sub

    Sub LoadDataTable()
        Dim pelanggans As List(Of Pelanggan) = Pelanggan.all

        For Each pelanggan As Pelanggan In pelanggans
            addListView(pelanggan)
        Next
    End Sub


    Sub LoadTable()
        With Me
            ListView1.View = View.Details
            ListView1.GridLines = True
            ListView1.HideSelection = False
            ListView1.MultiSelect = False
            ListView1.FullRowSelect = True

            ListView1.Columns.Add("No")
            ListView1.Columns.Add("ID")
            ListView1.Columns.Add("Nama")
            ListView1.Columns.Add("Alamat")
            ListView1.Columns.Add("No KTP")
            ListView1.Columns.Add("No Telepon")
        End With
    End Sub

    Sub kosong()
        txtID.Text = ""
        txtNama.Text = ""
        txtNoKtp.Text = ""
        txtAlamat.Text = ""
        txtNoTelepon.Text = ""

        disableText()
        ListView1.SelectedItems.Clear()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If txtNama.Enabled Then
            If formValidationPelanggan() Then
                Dim pelanggan As New Pelanggan

                pelanggan.nama = txtNama.Text
                pelanggan.alamat = txtAlamat.Text
                pelanggan.noKtp = txtNoKtp.Text
                pelanggan.noTelepon = txtNoTelepon.Text

                If Not pelanggan.save = -1 Then
                    addListView(pelanggan)

                    kosong()
                Else
                    MsgBox("Tidak dapat memasukan pelanggan baru")
                End If
            End If
        Else
            enableText()
        End If

    End Sub

    Private Sub FormPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadTable()
        LoadDataTable()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If Me.ListView1.SelectedItems.Count > 0 Then
            enableText()
            Me.txtID.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.txtNama.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
            Me.txtAlamat.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
            Me.txtNoTelepon.Text = Me.ListView1.SelectedItems(0).SubItems(4).Text
            Me.txtNoKtp.Text = Me.ListView1.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnHapus_Click_1(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Me.ListView1.SelectedItems.Count = 0 Then
            MsgBox("Data pelanggan harus dipilih")
            Exit Sub
        End If

        Dim id As Integer = Integer.Parse(txtID.Text)
        Dim index As Integer = ListView1.FocusedItem.Index

        Dim pelanggan As Pelanggan = Pelanggan.show(Integer.Parse(ListView1.Items(index).SubItems(1).Text))
        Dim jawab As String = MsgBox("Anda yakin menghapus data pelanggan ini ?", vbYesNo, "Konfirmasi")

        If jawab = vbYes Then
            If pelanggan Is Nothing Then
                MsgBox("Data pelanggan tidak ditemukan")
            Else
                If pelanggan.delete Then
                    ListView1.Items(index).Remove()

                    MsgBox("Data Pelanggan telah dihapus")
                    kosong()
                End If
            End If
        End If
    End Sub

    Private Sub btnUbah_Click_1(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Me.ListView1.SelectedItems.Count = 0 Then
            MsgBox("Data pelanggan harus dipilih")
            Exit Sub
        End If

        If formValidationPelanggan() Then
            Dim pelanggan As New Pelanggan

            pelanggan.ID = txtID.Text
            pelanggan.nama = txtNama.Text
            pelanggan.alamat = txtAlamat.Text
            pelanggan.noKtp = txtNoKtp.Text
            pelanggan.noTelepon = txtNoTelepon.Text

            If pelanggan.update(Integer.Parse(txtID.Text)) Then
                MsgBox("Berhasil mengubah data pelanggan")

                Dim index As Integer = ListView1.FocusedItem.Index()
                changeListView(index, pelanggan)
                kosong()
            Else
                MsgBox("Tidak dapat merubah data pelanggan")
            End If
        End If
    End Sub

    Sub changeListView(index As Integer, pelanggan As Pelanggan)
        With Me.ListView1
            .Items(index).SubItems(1).Text = pelanggan.ID.ToString
            .Items(index).SubItems(2).Text = pelanggan.nama
            .Items(index).SubItems(3).Text = pelanggan.alamat
            .Items(index).SubItems(4).Text = pelanggan.noKtp
            .Items(index).SubItems(5).Text = pelanggan.noTelepon
        End With
    End Sub

    Sub addListView(pelanggan As Pelanggan)
        With Me.ListView1
            Dim baris As Integer = Me.ListView1.Items.Count + 1

            .Items.Add(baris)
            .Items(baris - 1).SubItems.Add(pelanggan.ID.ToString)
            .Items(baris - 1).SubItems.Add(pelanggan.nama)
            .Items(baris - 1).SubItems.Add(pelanggan.alamat)
            .Items(baris - 1).SubItems.Add(pelanggan.noKtp)
            .Items(baris - 1).SubItems.Add(pelanggan.noTelepon)
        End With
    End Sub

    Function formValidationPelanggan() As Boolean
        formValidationPelanggan = True

        If FormIsNull(txtNama, "nama pelanggan") Then GoTo errorResult
        If FormIsNull(txtNoTelepon, "no telepon") Then GoTo errorResult

        Exit Function
errorResult:
        formValidationPelanggan = False
    End Function

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        cari()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            cari()
        End If
    End Sub

    Sub cari()
        Dim pelanggans As List(Of Pelanggan) = Pelanggan.search(txtCari.Text.ToString)

        Me.ListView1.Items.Clear()

        For Each pelanggan As Pelanggan In pelanggans
            addListView(pelanggan)
        Next
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            If Not formPerbaikan Is Nothing Then
                Dim id As Integer = Integer.Parse(ListView1.SelectedItems(0).SubItems(1).Text.ToString.Trim)
                Dim nama As String = ListView1.SelectedItems(0).SubItems(2).Text.ToString.Trim

                formPerbaikan.idPelanggan = id
                formPerbaikan.lblNamaPelanggan.Text = id.ToString.Trim & " - " & nama

                Me.Close()
            End If

            If Not formCheckAndRepair Is Nothing Then
                Dim id As Integer = Integer.Parse(ListView1.SelectedItems(0).SubItems(1).Text.ToString.Trim)
                Dim nama As String = ListView1.SelectedItems(0).SubItems(2).Text.ToString.Trim

                formCheckAndRepair.idPelanggan = id
                formCheckAndRepair.lblNamaPelanggan.Text = id.ToString.Trim & " - " & nama

                Me.Close()
            End If
        Else
            MsgBox("Data pelanggan belum dipilih")
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class