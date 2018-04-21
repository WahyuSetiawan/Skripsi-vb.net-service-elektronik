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
            .Columns.Add("Nama Barang")
            .Columns.Add("Serial Number")
            .Columns.Add("Jenis Kerusakan")
            .Columns.Add("Keluhan")
            .Columns.Add("Catatan")
            .Columns.Add("Tanggal Masuk")
        End With
    End Sub

    Sub loadDataTable()
        Dim baris As Integer = 1

        Try
            Dim myConnecion As New OleDbConnection(appPathDatabase)
            myConnecion.Open()

            Dim myCommand As New OleDbCommand("Select id, pelanggan, nama_barang, serial_number, jenis, keluhan, catatan, tanggal_masuk from transaksi_masuk", myConnecion)

            Dim myReader As OleDbDataReader = myCommand.ExecuteReader

            While (myReader.Read())
                Me.ListView1.Items.Add(baris)

                Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetInt32(myReader.GetOrdinal("id")).ToString.Trim)
                Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetInt32(myReader.GetOrdinal("pelanggan")).ToString.Trim)
                Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("nama_barang")).ToString.Trim)
                Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("serial_number")).ToString.Trim)
                Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("jenis")).ToString.Trim)
                Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("keluhan")).ToString.Trim)
                Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetString(myReader.GetOrdinal("catatan")).ToString.Trim)
                Me.ListView1.Items(baris - 1).SubItems.Add(myReader.GetDateTime(myReader.GetOrdinal("tanggal_masuk")).ToString.Trim)

                baris = baris + 1
            End While

            myConnecion.Close()
        Catch ex As Exception
            MsgBox("Terdapat Kesalahan : " & ex.Message)
        End Try
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
            Dim form As New FormPerbaikan(Me, Integer.Parse(Me.ListView1.SelectedItems(0).SubItems(1).Text))
            form.MdiParent = formMenuUtama
            form.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksiBaru.Click
        Dim form As New FormCheckAndRepair(Me)
        form.MdiParent = formMenuUtama
        form.Show()
    End Sub
End Class