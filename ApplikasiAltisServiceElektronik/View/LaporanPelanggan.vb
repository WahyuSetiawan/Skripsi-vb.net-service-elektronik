Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class LaporanPelanggan
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        Dim pathLaporan As String = getLaporanPath("CRPelanggan.rpt")

        If Not pathLaporan = "" Then
            cryRpt.Load(pathLaporan)

            Dim connection As New ConnectionInfo
            Dim tables As Tables
            Dim table As Table
            Dim logon As New TableLogOnInfo

            connection.ServerName = appPathDatabaseReport
            connection.UserID = ""
            connection.Password = ""
            connection.DatabaseName = ""

            tables = cryRpt.Database.Tables
            For Each table In tables
                logon = table.LogOnInfo
                logon.ConnectionInfo = connection
                table.ApplyLogOnInfo(logon)
            Next

            Me.CrystalReportViewer1.ReportSource = cryRpt
            Me.CrystalReportViewer1.Refresh()
        Else
            Me.Close()
        End If
    End Sub
End Class