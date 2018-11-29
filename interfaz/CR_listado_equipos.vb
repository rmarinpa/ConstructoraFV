Public Class CR_listado_equipos

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New Listado_equipos

            Report1.SetParameterValue("id_obra", id_obra)
            CrystalReportViewer1.ReportSource = Report1
            'ElseIf sincroniza = 1 Then
            '    Dim Report1 As New CR_Cuentas_Contables4_local

            '    Report1.SetParameterValue("id_obra", id_obra)
            '    CrystalReportViewer1.ReportSource = Report1
        End If
    End Sub
End Class