Imports CrystalDecisions.CrystalReports.Engine

Public Class FormLaporanPelanggan
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        Dim pathLaporan As String = getLaporanPath("CrystalReport2.rpt")

        If Not pathLaporan = "" Then
            cryRpt.Load(pathLaporan)
            Me.CrystalReportViewer1.ReportSource = cryRpt
            Me.CrystalReportViewer1.Refresh()
        Else
            Me.Close()
        End If
    End Sub
End Class