Public Class CR_Diesel_Completo10

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New CrDiesel_Completo

            Report1.SetParameterValue("Fecha_in", frm_menu_principal_X.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("Fecha_fin", frm_menu_principal_X.dtp_8_fecha_final.Text)
            Report1.SetParameterValue("Obra", id_obra)
            CrystalReportViewer1.ReportSource = Report1
        ElseIf sincroniza = 1 Then
            Dim Report1 As New CrDiesel_Completo_local

            Report1.SetParameterValue("Fecha_in", frm_menu_principal_X.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("Fecha_fin", frm_menu_principal_X.dtp_8_fecha_final.Text)
            Report1.SetParameterValue("Obra", id_obra)
            CrystalReportViewer1.ReportSource = Report1
        End If

    End Sub
End Class