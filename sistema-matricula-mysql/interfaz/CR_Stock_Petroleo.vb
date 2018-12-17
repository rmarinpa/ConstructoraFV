Public Class CR_Stock_Petroleo

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New Informe_Stock_v2

            Report1.SetParameterValue("Fecha_in", frm_menu_principal_V_V2.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("Fecha_fin", frm_menu_principal_V_V2.dtp_8_fecha_final.Text)
            Report1.SetParameterValue("Obra", id_obra)
            CrystalReportViewer1.ReportSource = Report1
        ElseIf sincroniza = 1 Then
            Dim Report1 As New CR_Cuentas_Contables4_local

            Report1.SetParameterValue("Fecha_in", frm_menu_principal_V.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("Fecha_fin", frm_menu_principal_V.dtp_8_fecha_final.Text)
            Report1.SetParameterValue("Obra", id_obra)
            CrystalReportViewer1.ReportSource = Report1
        End If
    End Sub
End Class