Public Class FormDaftarKerusakan
    Dim formMenuUtama As FormMenuUtama

    Sub New(ByVal form As FormMenuUtama)
        InitializeComponent()
        formMenuUtama = form
    End Sub

    Sub loadTable()
        With Me.ListView1
            .Items.Clear()
            .View = View.Details
            .GridLines = True
            .MultiSelect = False
            .FullRowSelect = True

            .Columns.Add("No")
            .Columns.Add("ID Transaksi")
            .Columns.Add("Pelanggan")
            .Columns.Add("Merek")
            .Columns.Add("Type")
            .Columns.Add("Serial Number")
            .Columns.Add("Jenis Kerusakan")
            .Columns.Add("Keluhan")
            .Columns.Add("Catatan")
            .Columns.Add("Tanggal Masuk")
        End With
    End Sub

    Sub loadDataTable()
        Dim transaksis As List(Of Transaksi) = Transaksi.all

        For i = 0 To transaksis.Count - 1
            Dim transaksi As Transaksi = transaksis.Item(i)
            addList(transaksi)
        Next
    End Sub

    Private Sub FormDaftarKerusakan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTable()
        loadDataTable()
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
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.id_pelanggan)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.merek)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.type)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.serial_number)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.jenis_kerusakan)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.keluhan)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.catatan)
        Me.ListView1.Items(baris - 1).SubItems.Add(transaksi.tanggal_masuk.ToString)
    End Sub

    Sub changeList(baris As Integer, transaksi As Transaksi)
        Me.ListView1.Items(baris).SubItems(1).Text = transaksi.id
        Me.ListView1.Items(baris).SubItems(2).Text = transaksi.id_pelanggan
        Me.ListView1.Items(baris).SubItems(3).Text = transaksi.merek
        Me.ListView1.Items(baris).SubItems(4).Text = transaksi.type
        Me.ListView1.Items(baris).SubItems(5).Text = transaksi.serial_number
        Me.ListView1.Items(baris).SubItems(6).Text = transaksi.jenis_kerusakan
        Me.ListView1.Items(baris).SubItems(7).Text = transaksi.keluhan
        Me.ListView1.Items(baris).SubItems(8).Text = transaksi.catatan
        Me.ListView1.Items(baris).SubItems(9).Text = transaksi.tanggal_masuk.ToString
    End Sub
End Class