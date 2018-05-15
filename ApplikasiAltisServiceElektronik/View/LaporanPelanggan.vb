Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class LaporanPelanggan
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        Dim pathLaporan As String = getLaporanPath("CRPelanggan.rpt")

        If Not pathLaporan = "" Then
            cryRpt.Load(pathLaporan)

            Me.CrystalReportViewer1.ReportSource = cryRpt
            Me.CrystalReportViewer1.Refresh()
        Else
            Me.Close()
        End If
    End Sub
End Class