Public Class CR_Resumen_Estado_Pago_subcontrato

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New Estado_de_pago_resumen_subcontrato
            Dim subcontratista, subcontrato As String
            Dim Cadena As String = frm_menu_principal_IV_V2.cmb_8_subcontrato.Text
            Dim ArrCadena As String() = Cadena.Split("/")
            Dim fecha_consulta As Date
            Dim fecha_consulta_str As String
            Dim mes, ano As Integer


            If Month(frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text) = 1 Then
                mes = 12
                ano = Year(frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text) - 1
            Else
                mes = Month(frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text) - 1
                ano = Year(frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text)
            End If

            fecha_consulta = CDate("23/" & mes & "/" & ano)
            fecha_consulta_str = Format(fecha_consulta, "yyyy/MM/dd")

            subcontratista = ArrCadena(0)
            subcontrato = ArrCadena(1)

            Report1.SetParameterValue("fecha_actual", frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("rut", frm_menu_principal_IV_V2.cmb_8_subcontrato.SelectedValue.ToString())
            Report1.SetParameterValue("tipo_subcontrato", subcontrato)
            Report1.SetParameterValue("n_ep", frm_menu_principal_IV_V2.txt_8_ep.Text)
            Report1.SetParameterValue("fecha_ant", fecha_consulta_str)
            Report1.SetParameterValue("nombre2", subcontratista)
            Report1.SetParameterValue("obra", Nombre_Obra)

            CrystalReportViewer1.ReportSource = Report1

        ElseIf sincroniza = 1 Then
            Dim Report1 As New Estado_de_pago_resumen_subcontrato
            Dim subcontratista, subcontrato As String
            Dim Cadena As String = frm_menu_principal_IV_V2.cmb_8_subcontrato.Text
            Dim ArrCadena As String() = Cadena.Split("/")
            Dim fecha_consulta As Date
            Dim fecha_consulta_str As String
            Dim mes, ano As Integer

            If Month(frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text) = 1 Then
                mes = 12
                ano = Year(frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text) - 1
            Else
                mes = Month(frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text) - 1
                ano = Year(frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text)
            End If

            fecha_consulta = CDate("23/" & mes & "/" & ano)
            fecha_consulta_str = Format(fecha_consulta, "yyyy/MM/dd")

            subcontratista = ArrCadena(0)
            subcontrato = ArrCadena(1)

            Report1.SetParameterValue("fecha_actual", frm_menu_principal_IV_V2.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("rut", frm_menu_principal_IV_V2.cmb_8_subcontrato.SelectedValue.ToString())
            Report1.SetParameterValue("tipo_subcontrato", subcontrato)
            Report1.SetParameterValue("n_ep", frm_menu_principal_IV_V2.txt_8_ep.Text)
            Report1.SetParameterValue("fecha_ant", fecha_consulta_str)
            Report1.SetParameterValue("nombre2", subcontratista)
            Report1.SetParameterValue("obra", Nombre_Obra)

            CrystalReportViewer1.ReportSource = Report1
        End If

    End Sub
End Class