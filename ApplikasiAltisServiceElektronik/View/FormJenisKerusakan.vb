Public Class FormJenisKerusakan
    Dim form As FormMenuUtama
    Dim formCheckAndRepair As FormCheckAndRepair
    Dim formPerbaikan As FormPerbaikan

    Dim id As Integer

    Sub New(ByVal formPerbaikan As FormPerbaikan)
        InitializeComponent()
        Me.formPerbaikan = formPerbaikan
        kosong()
    End Sub

    Sub New(ByVal formCheckAndRepair As FormCheckAndRepair)
        InitializeComponent()
        Me.formCheckAndRepair = formCheckAndRepair
        kosong()
    End Sub

    Sub New(ByVal formMenuUtama As FormMenuUtama)
        InitializeComponent()
        Me.form = formMenuUtama
        kosong()
    End Sub

    Sub LoadDataTable()
        Dim jenisKerusakans As List(Of JenisKerusakan) = JenisKerusakan.all()

        For Each jeniskerusakan As JenisKerusakan In jenisKerusakans
            addListView(jeniskerusakan)
        Next
    End Sub

    Sub LoadTable()
        With Me
            lvJenisKerusakan.View = View.Details
            lvJenisKerusakan.GridLines = True
            lvJenisKerusakan.HideSelection = False
            lvJenisKerusakan.MultiSelect = False
            lvJenisKerusakan.FullRowSelect = True

            lvJenisKerusakan.Columns.Add("No")
            lvJenisKerusakan.Columns.Add("Id")
            lvJenisKerusakan.Columns.Add("Jenis")
            lvJenisKerusakan.Columns.Add("Biaya")
        End With
    End Sub

    Sub kosong()
        txtJenis.Text = ""
        txtBiaya.Text = ""

        btnSimpan.Text = "Tambah"

        lvJenisKerusakan.SelectedItems.Clear()
        disableTextBox()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Select Case btnSimpan.Text
            Case "Tambah"
                enableTextBox()
                btnSimpan.Text = "Simpan"
            Case "Simpan"
                If formValidationJenisKerusakan() Then
                    Dim jeniskerusakan As New JenisKerusakan

                    jeniskerusakan.JenisKerusakana = txtJenis.Text
                    jeniskerusakan.Biaya = txtBiaya.Text

                    If Not jeniskerusakan.save = -1 Then
                        addListView(jeniskerusakan)

                        kosong()
                    Else
                        MsgBox("Tidak dapat memasukan jenis kerusakan baru")
                    End If
                End If
        End Select
    End Sub


    Function formValidationJenisKerusakan() As Boolean
        formValidationJenisKerusakan = True

        If FormIsNull(txtJenis, "Jenis Kerusakan") Then GoTo errorResult
        If FormIsNull(txtBiaya, "biaya perbaikan") Then GoTo errorResult
        If FormIsNumeric(txtBiaya, "biaya perbaikan") Then GoTo errorResult

        Exit Function
errorResult:
        formValidationJenisKerusakan = False
    End Function


    Sub changeListView(index As Integer, jenisKerusakan As JenisKerusakan)
        With Me.lvJenisKerusakan
            .Items(index).SubItems(1).Text = jenisKerusakan.id.ToString
            .Items(index).SubItems(2).Text = jenisKerusakan.JenisKerusakana
            .Items(index).SubItems(3).Text = jenisKerusakan.Biaya
        End With
    End Sub

    Sub addListView(jenisKerusakan As JenisKerusakan)
        With Me.lvJenisKerusakan
            Dim baris As Integer = Me.lvJenisKerusakan.Items.Count + 1

            .Items.Add(baris)
            .Items(baris - 1).SubItems.Add(jenisKerusakan.id.ToString)
            .Items(baris - 1).SubItems.Add(jenisKerusakan.JenisKerusakana)
            .Items(baris - 1).SubItems.Add(jenisKerusakan.Biaya)
        End With
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If lvJenisKerusakan.SelectedItems.Count = 0 Then
            MsgBox("Data Jenis Kerusakan harus dipilih")
            Exit Sub
        End If

        If formValidationJenisKerusakan() Then
            Try
                Dim jenisKerusakan As New JenisKerusakan

                jenisKerusakan.id = id
                jenisKerusakan.JenisKerusakana = txtJenis.Text
                jenisKerusakan.Biaya = txtBiaya.Text

                If jenisKerusakan.update(Integer.Parse(id)) Then
                    MsgBox("Berhasil mengubah data pelanggan")

                    Dim index As Integer = lvJenisKerusakan.FocusedItem.Index
                    changeListView(index, jenisKerusakan)
                    kosong()
                Else
                    MsgBox("Tidak dapat merubah data pelanggan")
                End If

            Catch ex As Exception
                MsgBox("terdapat kesalahan dalam perubahan data pelanggan dengan pesan : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub lvJenisKerusakan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvJenisKerusakan.Click
        If Me.lvJenisKerusakan.SelectedItems.Count > 0 Then

            id = Integer.Parse(Me.lvJenisKerusakan.SelectedItems(0).SubItems(1).Text)
            Me.txtJenis.Text = Me.lvJenisKerusakan.SelectedItems(0).SubItems(2).Text
            Me.txtBiaya.Text = Me.lvJenisKerusakan.SelectedItems(0).SubItems(3).Text

            btnSimpan.Text = "Tambah"
            enableTextBox()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If lvJenisKerusakan.SelectedItems.Count = 0 Then
            MsgBox("Data Jenis Kerusakan harus dipilih")
            Exit Sub
        End If

        Dim index As Integer = lvJenisKerusakan.FocusedItem.Index

        Dim jeniskerusakan As JenisKerusakan = JenisKerusakan.show(Integer.Parse(lvJenisKerusakan.Items(index).SubItems(1).Text))
        Dim jawab As String = MsgBox("Anda yakin menghapus data Jenis Kerusakan ini ?", vbYesNo, "Konfirmasi")

        If jawab = vbYes Then
            If jeniskerusakan Is Nothing Then
                MsgBox("Data Jenis Kerusakan tidak ditemukan")
            Else
                If jeniskerusakan.delete Then
                    lvJenisKerusakan.Items(index).Remove()

                    MsgBox("Data Jenis Kerusakan telah dihapus")
                    kosong()
                End If
            End If
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub FormJenisKerusakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        LoadDataTable()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            cari()
        End If
    End Sub

    Sub cari()
        Dim jenisKerusakans As List(Of JenisKerusakan) = JenisKerusakan.search(txtCari.Text.ToString)

        Me.lvJenisKerusakan.Items.Clear()
        For Each jenisKerusakan As JenisKerusakan In jenisKerusakans
            addListView(jenisKerusakan)
        Next
    End Sub

    Sub disableTextBox()
        txtJenis.Enabled = False
        txtBiaya.Enabled = False
    End Sub

    Sub enableTextBox()
        txtJenis.Enabled = True
        txtBiaya.Enabled = True
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles lvJenisKerusakan.DoubleClick
        If lvJenisKerusakan.SelectedItems.Count > 0 Then
            If Not formPerbaikan Is Nothing Then
                Dim id As Integer = Integer.Parse(lvJenisKerusakan.SelectedItems(0).SubItems(1).Text.ToString.Trim)
                Dim nama As String = lvJenisKerusakan.SelectedItems(0).SubItems(2).Text.ToString.Trim

                formPerbaikan.idPelanggan = id
                formPerbaikan.lblNamaPelanggan.Text = id.ToString.Trim & " - " & nama

                Me.Close()
                Exit Sub
            End If

            If Not formCheckAndRepair Is Nothing Then
                Dim id As Integer = Integer.Parse(lvJenisKerusakan.SelectedItems(0).SubItems(1).Text.ToString.Trim)
                Dim nama As String = Me.lvJenisKerusakan.SelectedItems(0).SubItems(2).Text.ToString.Trim

                formCheckAndRepair.idJenisKerusakan = id
                formCheckAndRepair.lblJenisKerusakan.Text = id.ToString.Trim & " - " & nama

                formCheckAndRepair.lblAsumsi.Text = Me.lvJenisKerusakan.SelectedItems(0).SubItems(3).Text.ToString.Trim

                Me.Close()
                Exit Sub
            End If
        End If
    End Sub

End Class