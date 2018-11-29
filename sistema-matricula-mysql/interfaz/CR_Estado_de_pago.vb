Public Class CR_Estado_de_pago

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New Estado_de_pago_fechas
            Dim fecha_inicial As Date
            Dim fecha_final As Date

            fecha_inicial = frm_menu_principal_III.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_III.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("rut", frm_menu_principal_III.cmb_8_arrendador.SelectedValue.ToString())
            Report1.SetParameterValue("n_ep", frm_menu_principal_III.txt_8_ep.Text)
            CrystalReportViewer1.ReportSource = Report1
        ElseIf sincroniza = 1 Then
            Dim Report1 As New Estado_de_pago_fechas_local
            Dim fecha_inicial As Date
            Dim fecha_final As Date

            fecha_inicial = frm_menu_principal_III.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_III.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("rut", frm_menu_principal_III.cmb_8_arrendador.SelectedValue.ToString())
            Report1.SetParameterValue("n_ep", frm_menu_principal_III.txt_8_ep.Text)
            CrystalReportViewer1.ReportSource = Report1
        End If
    End Sub
End Class