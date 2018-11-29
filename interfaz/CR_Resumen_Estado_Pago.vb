Public Class CR_Resumen_Estado_Pago

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New Resumen_Estado_de_pago_v2_fechas
            'Dim mes_final As Integer
            'Dim mes_ep1, año_ep2 As String
            Dim fecha_inicial As Date
            Dim fecha_final As Date
            Dim IVA As String


            If frm_menu_principal_III.chk_iva.Checked = True Then
                IVA = "SI"
            ElseIf frm_menu_principal_III.chk_iva.Checked = False Then
                IVA = "NO"
            End If

            fecha_inicial = frm_menu_principal_III.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_III.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("rut", frm_menu_principal_III.cmb_8_arrendador.SelectedValue.ToString())
            Report1.SetParameterValue("n_ep", frm_menu_principal_III.txt_8_ep.Text)
            Report1.SetParameterValue("iva", IVA)
            Report1.SetParameterValue("nombre", frm_menu_principal_III.cmb_8_arrendador.Text)
            Report1.SetParameterValue("obra", Nombre_Obra)
            CrystalReportViewer1.ReportSource = Report1

        ElseIf sincroniza = 1 Then
            Dim Report1 As New Resumen_Estado_de_pago_v2_fechas_local
            'Dim mes_final As Integer
            'Dim mes_ep1, año_ep2 As String
            Dim fecha_inicial As Date
            Dim fecha_final As Date
            Dim IVA As String


            If frm_menu_principal_III.chk_iva.Checked = True Then
                IVA = "SI"
            ElseIf frm_menu_principal_III.chk_iva.Checked = False Then
                IVA = "NO"
            End If

            fecha_inicial = frm_menu_principal_III.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_III.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("rut", frm_menu_principal_III.cmb_8_arrendador.SelectedValue.ToString())
            Report1.SetParameterValue("n_ep", frm_menu_principal_III.txt_8_ep.Text)
            Report1.SetParameterValue("iva", IVA)
            Report1.SetParameterValue("nombre", frm_menu_principal_III.cmb_8_arrendador.Text)
            Report1.SetParameterValue("obra", Nombre_Obra)
            CrystalReportViewer1.ReportSource = Report1
        End If

    End Sub
End Class