
Public Class CR_EstadoPagoMandante

    Private Sub CR_EstadoPagoMandante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New EstadoPagoMandante
        'Se insertan los valores de paramemtros que definimos en el procedimiento almacenado
        objreporte.SetParameterValue("nombreobra", Module1.Nombre_Faena)
        CrystalReportViewer1.ReportSource = objreporte
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class