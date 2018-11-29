Public Class CR_Estado_de_pago_Local

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Report1 As New Estado_de_pago_Local
        Dim fecha_inicial As Date
        Dim mes_final As Integer

        'fecha_inicial = frm_menu_principal_III.dtp_8_fecha_inicial.Text
        'fecha_inicial = fecha_inicial.AddMonths(-1)
        'mes_final = Month(frm_menu_principal_III.dtp_8_fecha_inicial.Text) + 1

        'Report1.SetParameterValue("Fecha_in", CDate("24/" & Month(fecha_inicial) & "/" & Year(fecha_inicial)))
        'Report1.SetParameterValue("Fecha_fin", CDate("23/" & Month(frm_menu_principal_III.dtp_8_fecha_inicial.Text) & "/" & Year(frm_menu_principal_III.dtp_8_fecha_inicial.Text)))
        Report1.SetParameterValue("id_obra", id_obra)
        Report1.SetParameterValue("rut", frm_menu_principal_III.cmb_8_arrendador.SelectedValue.ToString())
        Report1.SetParameterValue("n_ep", frm_menu_principal_III.txt_8_ep.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class