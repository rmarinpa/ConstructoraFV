Public Class CR_Estado_de_pago_maq_ep

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Report1 As New Resumen_Estado_de_pago_v2_fechas
        Dim fecha_inicial As Date
        Dim fecha_final As Date
        Dim IVA As String


        IVA = "SI"
        fecha_inicial = Frm_maquinaria.dtp_fecha_in.Text
        fecha_final = Frm_maquinaria.dtp_fecha_fin.Text

        Report1.SetParameterValue("Fecha_in", fecha_inicial)
        Report1.SetParameterValue("Fecha_fin", fecha_final)
        Report1.SetParameterValue("id_obra", Frm_maquinaria.cmb_obra.SelectedValue.ToString())
        Report1.SetParameterValue("rut", Frm_maquinaria.cmb_8_arrendador.SelectedValue.ToString())
        Report1.SetParameterValue("n_ep", 0)
        Report1.SetParameterValue("iva", IVA)
        Report1.SetParameterValue("nombre", Frm_maquinaria.cmb_8_arrendador.Text)
        Report1.SetParameterValue("obra", Frm_maquinaria.cmb_obra.Text)
        CrystalReportViewer1.ReportSource = Report1
    End Sub
End Class