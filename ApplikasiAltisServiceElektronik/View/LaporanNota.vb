Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class LaporanNota
    Dim form As FormPerbaikan
    Dim transaksi As Transaksi

    Sub New(form As FormPerbaikan, id As Integer)
        InitializeComponent()
        transaksi = Transaksi.show(id)
        Me.form = form
    End Sub

    Private Sub FormLaporanNota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        Dim pathLaporan As String = getLaporanPath("CRNotaPenjualan.rpt")

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

            Dim cryParameterFieldDefinitions As ParameterFieldDefinitions
            Dim cryParameterFieldDefinition As ParameterFieldDefinition
            Dim cryParameterValues As New ParameterValues
            Dim cryParameterDiscreteValue As New ParameterDiscreteValue

            cryParameterDiscreteValue.Value = transaksi.id
            cryParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
            cryParameterFieldDefinition = cryParameterFieldDefinitions.Item("idTransaksi")
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

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class