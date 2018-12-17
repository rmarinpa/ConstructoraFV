Public Class CR_ListadoContratoModificaciones

    Private Sub CR_ListadoContratoModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New ListadoContratoModificaciones2
        'Se insertan los valores de paramemtros que definimos en el procedimiento almacenado
        objreporte.SetParameterValue("nombreobra", Module1.Nombre_Faena)
        CrystalReportViewer1.ReportSource = objreporte
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class