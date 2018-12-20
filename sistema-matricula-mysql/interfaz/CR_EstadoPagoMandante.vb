Public Class CR_EstadoPagoMandante

    Private Sub CR_EstadoPagoMandante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Nombre_Obra As String

        Nombre_Obra = Module1.Nombre_Faena

        Dim Report1 As New EstadoPagoMandante
        CrystalReportViewer1.Refresh()
        Report1.SetParameterValue("nombreObra", Nombre_Obra)
        CrystalReportViewer1.ReportSource = Report1

    End Sub
End Class