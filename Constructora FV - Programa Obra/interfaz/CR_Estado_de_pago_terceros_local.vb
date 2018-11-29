Public Class CR_Estado_de_pago_terceros_local

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Report1 As New Resumen_Estado_de_pago_v2_terceros_local
        Dim mes_final As Integer
        Dim mes_ep1, año_ep2 As String
        Dim fecha_inicial As Date

        'fecha_inicial = frm_menu_principal_III.dtp_8_fecha_inicial.Text
        'fecha_inicial = fecha_inicial.AddMonths(-1)
        'mes_final = Month(frm_menu_principal_III.dtp_8_fecha_inicial.Text) + 1
        'mes_ep1 = Month(frm_menu_principal_III.dtp_8_fecha_inicial.Text) & "-" & Year(frm_menu_principal_III.dtp_8_fecha_inicial.Text)

        'Report1.SetParameterValue("Fecha_in", CDate("24/" & Month(fecha_inicial) & "/" & Year(fecha_inicial)))
        'Report1.SetParameterValue("Fecha_fin", CDate("23/" & Month(frm_menu_principal_III.dtp_8_fecha_inicial.Text) & "/" & Year(frm_menu_principal_III.dtp_8_fecha_inicial.Text)))
        'Report1.SetParameterValue("id_obra", id_obra)
        'Report1.SetParameterValue("rut", frm_menu_principal_III.cmb_8_arrendador.SelectedValue.ToString())
        'Report1.SetParameterValue("n_ep", frm_menu_principal_III.txt_8_ep.Text)
        Report1.SetParameterValue("iva", "SI")
        Report1.SetParameterValue("mes_ep", mes_ep1)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class