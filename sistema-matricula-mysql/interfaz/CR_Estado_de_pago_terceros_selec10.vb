Public Class CR_Estado_de_pago_terceros_selec10

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New Resumen_Estado_de_pago_v2_fechas_selec
            Dim fecha_inicial As Date
            Dim fecha_final As Date

            fecha_inicial = frm_menu_principal_X.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_X.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("n_ep", frm_menu_principal_X.txt_10_ep.Text)
            Report1.SetParameterValue("iva", "SI")

            Report1.SetParameterValue("emp1", terceros(0))
            Report1.SetParameterValue("emp2", terceros(1))
            Report1.SetParameterValue("emp3", terceros(2))
            Report1.SetParameterValue("emp4", terceros(3))
            Report1.SetParameterValue("emp5", terceros(4))
            Report1.SetParameterValue("emp6", terceros(5))
            Report1.SetParameterValue("emp7", terceros(6))
            Report1.SetParameterValue("emp8", terceros(7))
            Report1.SetParameterValue("emp9", terceros(8))
            Report1.SetParameterValue("emp10", terceros(9))
            Report1.SetParameterValue("emp11", terceros(10))
            Report1.SetParameterValue("emp12", terceros(11))
            Report1.SetParameterValue("emp13", terceros(12))
            Report1.SetParameterValue("emp14", terceros(13))
            Report1.SetParameterValue("emp15", terceros(14))
            Report1.SetParameterValue("emp16", terceros(15))
            Report1.SetParameterValue("emp17", terceros(16))
            Report1.SetParameterValue("emp18", terceros(17))
            Report1.SetParameterValue("emp19", terceros(18))
            Report1.SetParameterValue("emp20", terceros(19))

            CrystalReportViewer1.ReportSource = Report1
        ElseIf sincroniza = 1 Then
            Dim Report1 As New Resumen_Estado_de_pago_v2_fechas_selec_local
            Dim fecha_inicial As Date
            Dim fecha_final As Date

            fecha_inicial = frm_menu_principal_X.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_X.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            Report1.SetParameterValue("n_ep", frm_menu_principal_X.txt_10_ep.Text)
            Report1.SetParameterValue("iva", "SI")

            Report1.SetParameterValue("emp1", terceros(0))
            Report1.SetParameterValue("emp2", terceros(1))
            Report1.SetParameterValue("emp3", terceros(2))
            Report1.SetParameterValue("emp4", terceros(3))
            Report1.SetParameterValue("emp5", terceros(4))
            Report1.SetParameterValue("emp6", terceros(5))
            Report1.SetParameterValue("emp7", terceros(6))
            Report1.SetParameterValue("emp8", terceros(7))
            Report1.SetParameterValue("emp9", terceros(8))
            Report1.SetParameterValue("emp10", terceros(9))
            Report1.SetParameterValue("emp11", terceros(10))
            Report1.SetParameterValue("emp12", terceros(11))
            Report1.SetParameterValue("emp13", terceros(12))
            Report1.SetParameterValue("emp14", terceros(13))
            Report1.SetParameterValue("emp15", terceros(14))
            Report1.SetParameterValue("emp16", terceros(15))
            Report1.SetParameterValue("emp17", terceros(16))
            Report1.SetParameterValue("emp18", terceros(17))
            Report1.SetParameterValue("emp19", terceros(18))
            Report1.SetParameterValue("emp20", terceros(19))

            CrystalReportViewer1.ReportSource = Report1
        End If
    End Sub
End Class