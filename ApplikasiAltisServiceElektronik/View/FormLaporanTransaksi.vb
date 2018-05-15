Public Class FormLaporanTransaksi
    Dim formMenuUtama As FormMenuUtama

    Sub New(form As FormMenuUtama)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.formMenuUtama = form
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim form As New LaporanTransaksi(Me.formMenuUtama, CInt(cmbTahun.Text), CInt(cmbBulan.Text))
        form.MdiParent = formMenuUtama
        form.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormLaporanTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tahuns As List(Of String) = Transaksi.getYearAllTransaksi

        cmbTahun.Items.Clear()

        For Each tahun As String In tahuns
            cmbTahun.Items.Add(tahun)
        Next
        If tahuns.Count > 0 Then
            cmbTahun.Text = tahuns.Item(0)
        End If
    End Sub

    Private Sub cmbTahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTahun.SelectedIndexChanged
        Dim bulans As List(Of Int16) = Transaksi.getMonthTransaksi(cmbTahun.Text)

        If bulans.Count > 0 Then
            cmbBulan.Items.Clear()

            For Each bulan As Int16 In bulans
                cmbBulan.Items.Add(CStr(bulan))
            Next

            cmbBulan.Text = CStr(bulans.Item(0))
        End If
    End Sub
End Class