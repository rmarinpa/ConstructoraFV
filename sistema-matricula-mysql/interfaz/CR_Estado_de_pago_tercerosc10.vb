Public Class CR_Estado_de_pago_tercerosc10

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New Resumen_Estado_de_pago_v2_fechas_terc
            Dim fecha_inicial As Date
            Dim fecha_final As Date

            fecha_inicial = frm_menu_principal_X.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_X.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("n_ep", frm_menu_principal_X.txt_10_ep.Text)
            Report1.SetParameterValue("iva", "SI")
            CrystalReportViewer1.ReportSource = Report1
        ElseIf sincroniza = 1 Then
            Dim Report1 As New Resumen_Estado_de_pago_v2_fechas_ter_localc
            Dim fecha_inicial As Date
            Dim fecha_final As Date

            fecha_inicial = frm_menu_principal_X.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_X.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("n_ep", frm_menu_principal_X.txt_10_ep.Text)
            Report1.SetParameterValue("iva", "SI")
            CrystalReportViewer1.ReportSource = Report1
        End If
    End Sub
End Class