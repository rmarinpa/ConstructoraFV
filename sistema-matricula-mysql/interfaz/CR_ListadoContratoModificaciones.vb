Public Class CR_ListadoContratoModificaciones

    Private Sub CR_ListadoContratoModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Nombre_Obra As String

        Nombre_Obra = Module1.Nombre_Faena

        Dim Report1 As New ListadoContratoModificaciones
        CrystalReportViewer1.Refresh()
        Report1.SetParameterValue("nombreObra", Nombre_Obra)
        CrystalReportViewer1.ReportSource = Report1

    End Sub
End Class