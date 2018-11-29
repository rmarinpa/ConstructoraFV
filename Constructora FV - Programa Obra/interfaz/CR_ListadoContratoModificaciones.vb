Public Class CR_ListadoContratoModificaciones

    Private Sub CR_ListadoContratoModificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objreporte As New ListadoContratoModificaciones
            'Se insertan los valores de paramemtros que definimos en el procedimiento almacenado
            'objreporte.SetParameterValue("nombreobra", Module1.Nombre_Faena)
            CrystalReportViewer1.ReportSource = objreporte
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class