Public Class FormDaftarKerusakan
    Dim formMenuUtama As FormMenuUtama

    Sub New(ByVal form As FormMenuUtama)
        InitializeComponent()
        formMenuUtama = form
    End Sub

    Sub loadCMB()
        cmbJenisType.Items.Clear()
        cmbJenisType.DropDownStyle = ComboBoxStyle.DropDownList

        cmbJenisType.Items.Add("Belum Selesai")
        cmbJenisType.Items.Add("Semua")
        cmbJenisType.Items.Add("Hanya Selesai")

        cmbJenisType.Text = "Belum Selesai"
    End Sub

    Sub loadTable()
        With Me.ListView1
            .Items.Clear()
            .View = View.Details
            .GridLines = True
            .MultiSelect = False
            .FullRowSelect = True

            .Columns.Add("No", 50)
            .Columns.Add("ID Transaksi", 90)
            .Columns.Add("Pelanggan", 100)
            .Columns.Add("Merek", 70)
            .Columns.Add("Type", 70)
            .Columns.Add("Serial Number", 100)
            .Columns.Add("Jenis Kerusakan", 100)
            .Columns.Add("Keluhan", 150)
            .Columns.Add("Catatan", 150)
            .Columns.Add("Tanggal Masuk", 110)
            .Columns.Add("Selesai", 150)
        End With
    End Sub

    Sub loadDataTable()
        Dim transaksis As List(Of Transaksi) = Transaksi.showActiveTransaksi

        For i = 0 To transaksis.Count - 1
            Dim transaksi As Transaksi = transaksis.Item(i)
            addList(transaksi)
        Next
    End Sub

    Private Sub FormDaftarKerusakan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTable()
        loadDataTable()
        loadCMB()
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count > 0 Then
            Dim form As New FormPerbaikan(Me, Integer.Parse(Me.ListView1.SelectedItems(0).SubItems(1).Text), ListView1.FocusedItem.Index)
            form.MdiParent = formMenuUtama
            form.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksiBaru.Click
        Dim form As New FormCheckAndRepair(Me)
        form.MdiParent = formMenuUtama
        form.Show()
    End Sub

    Sub remove(baris As Integer)
        Me.ListView1.Items(baris).Remove()
    End Sub

    Sub addList(transaksi As Transaksi)
        Dim baris As Integer = Me.ListView1.Items.Count + 1

        Me.ListView1.Items.Add(baris)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.id)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.pelanggan.nama)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.merek)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.type)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.serial_number)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.jenis_kerusakan.JenisKerusakana)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.keluhan)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.catatan)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.tanggal_masuk.ToString)

        If transaksi.tanggal_keluar = Nothing Then
            Me.ListView1.Items(baris - 1).SubItems.Add("Belum selesai")
            Me.ListView1.Items(baris - 1).BackColor = Color.Yellow
        Else
            Me.ListView1.Items(baris - 1).SubItems.Add("Selesai pada tanggal : " & transaksi.tanggal_keluar.ToString)
            Me.ListView1.Items(baris - 1).BackColor = Color.LightGreen
        End If

    End Sub

    Sub changeList(baris As Integer, transaksi As Transaksi)
        Me.ListView1.Items(baris).SubItems(1).Text = transaksi.id
        Me.ListView1.Items(baris).SubItems(2).Text = transaksi.pelanggan.nama
        Me.ListView1.Items(baris).SubItems(3).Text = transaksi.merek
        Me.ListView1.Items(baris).SubItems(4).Text = transaksi.type
        Me.ListView1.Items(baris).SubItems(5).Text = transaksi.serial_number
        Me.ListView1.Items(baris).SubItems(6).Text = transaksi.jenis_kerusakan.JenisKerusakana
        Me.ListView1.Items(baris).SubItems(7).Text = transaksi.keluhan
        Me.ListView1.Items(baris).SubItems(8).Text = transaksi.catatan
        Me.ListView1.Items(baris).SubItems(9).Text = transaksi.tanggal_masuk.ToString


        If transaksi.tanggal_keluar = Nothing Then
            Me.ListView1.Items(baris).SubItems(10).Text = "Belum selesai"
            Me.ListView1.Items(baris).BackColor = Color.Yellow
        Else
            Me.ListView1.Items(baris).SubItems(10).Text = "Selesai pada tanggal : " & transaksi.tanggal_keluar.ToString
            Me.ListView1.Items(baris).BackColor = Color.LightGreen

            If cmbJenisType.Text = "Belum Selesai" Then
                Me.ListView1.Items(baris).Remove()
            End If
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        cari()
    End Sub

    Private Sub cmbJenisType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisType.SelectedIndexChanged
        If cmbJenisType.Text = "Semua" Then
            Dim transaksis As List(Of Transaksi) = Transaksi.all
            Me.ListView1.Items.Clear()

            For i = 0 To transaksis.Count - 1
                Dim transaksi As Transaksi = transaksis.Item(i)
                addList(transaksi)
            Next
        End If

        If cmbJenisType.Text = "Belum Selesai" Then
            Dim transaksis As List(Of Transaksi) = Transaksi.showActiveTransaksi

            Me.ListView1.Items.Clear()

            For i = 0 To transaksis.Count - 1
                Dim transaksi As Transaksi = transaksis.Item(i)
                addList(transaksi)
            Next
        End If

        If cmbJenisType.Text = "Hanya Selesai" Then
            Dim transaksis As List(Of Transaksi) = Transaksi.showNotActiveTransaksi
            Me.ListView1.Items.Clear()

            For i = 0 To transaksis.Count - 1
                Dim transaksi As Transaksi = transaksis.Item(i)
                addList(transaksi)
            Next
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            cari()
        End If
    End Sub

    Sub cari()
        Dim transaksis As New List(Of Transaksi)

        Select Case cmbJenisType.Text
            Case "Semua"
                transaksis = Transaksi.search(txtCari.Text.ToString)
            Case "Belum Selesai"
                transaksis = Transaksi.searchNotActive(txtCari.Text.ToString)
            Case "Hanya Selesai"
                transaksis = Transaksi.searchActive(txtCari.Text.ToString)
        End Select

        If transaksis.Count = 0 Then
            MsgBox("Tidak terdapat data untuk ditampilkan")
        End If

        Me.ListView1.Items.Clear()

        For Each transaksi As Transaksi In transaksis
            addList(transaksi)
        Next
    End Sub
End Class