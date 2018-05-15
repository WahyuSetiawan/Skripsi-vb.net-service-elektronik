Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class LaporanTransaksi
    Dim tahun As Int32
    Dim bulan As Int32

    Sub New(formparent As FormMenuUtama, tahun As Int32, bulan As Int32)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.tahun = tahun
        Me.bulan = bulan
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        Dim pathLaporan As String = getLaporanPath("CRTransaksi.rpt")

        If Not pathLaporan = "" Then
            cryRpt.Load(pathLaporan)

            Dim cryParameterFieldDefinitions As ParameterFieldDefinitions
            Dim cryParameterFieldDefinitiontahun As ParameterFieldDefinition
            Dim cryParameterFieldDefinitionbulan As ParameterFieldDefinition
            Dim cryParameterValuesTahun As New ParameterValues
            Dim cryParameterValuesBulan As New ParameterValues
            Dim cryParameterDicreteValue As New ParameterDiscreteValue
            Dim cryParameterDicreteBulan As New ParameterDiscreteValue

            cryParameterDicreteValue.Value = tahun
            cryParameterDicreteBulan.Value = bulan

            cryParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields

            cryParameterFieldDefinitiontahun = cryParameterFieldDefinitions.Item("tahun")
            cryParameterValuesTahun = cryParameterFieldDefinitiontahun.CurrentValues

            cryParameterFieldDefinitionbulan = cryParameterFieldDefinitions.Item("bulan")
            cryParameterValuesBulan = cryParameterFieldDefinitionbulan.CurrentValues

            cryParameterValuesBulan.Clear()
            cryParameterValuesBulan.Add(cryParameterDicreteBulan)

            cryParameterValuesTahun.Clear()
            cryParameterValuesTahun.Add(cryParameterDicreteValue)

            cryParameterFieldDefinitiontahun.ApplyCurrentValues(cryParameterValuesTahun)
            cryParameterFieldDefinitionbulan.ApplyCurrentValues(cryParameterValuesBulan)

            Me.CrystalReportViewer1.ReportSource = cryRpt
            Me.CrystalReportViewer1.Refresh()
        Else
            Me.Close()
        End If
    End Sub

End Class