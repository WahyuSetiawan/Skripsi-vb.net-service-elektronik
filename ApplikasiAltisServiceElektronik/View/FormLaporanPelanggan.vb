Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormLaporanPelanggan
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        Dim pathLaporan As String = getLaporanPath("CrystalReportPelanggan.rpt")

        If Not pathLaporan = "" Then
            cryRpt.Load(pathLaporan)

            Dim cryParameterFieldDefinitions As ParameterFieldDefinitions
            Dim cryParameterFieldDefinition As ParameterFieldDefinition
            Dim cryParameterValues As New ParameterValues
            Dim cryParameterDiscreteValue As New ParameterDiscreteValue

            cryParameterDiscreteValue.Value = "1"
            cryParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
            cryParameterFieldDefinition = cryParameterFieldDefinitions.Item("idPelanggan")
            cryParameterValues = cryParameterFieldDefinition.CurrentValues

            cryParameterValues.Clear()
            cryParameterValues.Add(cryParameterDiscreteValue)
            cryParameterFieldDefinition.ApplyCurrentValues(cryParameterValues)

            Me.CrystalReportViewer1.ReportSource = cryRpt
            Me.CrystalReportViewer1.Refresh()
        Else
            Me.Close()
        End If
    End Sub
End Class