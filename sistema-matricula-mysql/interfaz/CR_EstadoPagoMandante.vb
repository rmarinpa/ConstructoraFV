Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class CR_EstadoPagoMandante

    Private Sub CR_EstadoPagoMandante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim reporte As New EstadoPagoMandante
            reporte.SetParameterValue("nombreObra", Module1.Nombre_Faena)
            CrystalReportViewer1.ReportSource = reporte
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class