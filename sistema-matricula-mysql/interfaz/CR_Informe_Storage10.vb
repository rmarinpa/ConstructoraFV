Public Class CR_Informe_Storage10

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New Informe_Storage_final

            Report1.SetParameterValue("Fecha_in", frm_menu_principal_X.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("Fecha_fin", frm_menu_principal_X.dtp_8_fecha_final.Text)
            Report1.SetParameterValue("Obra", id_obra)
            Report1.SetParameterValue("stock_anterior", frm_menu_principal_X.txt_8_stock_anterior.Text)
            CrystalReportViewer1.ReportSource = Report1
        ElseIf sincroniza = 1 Then
            Dim Report1 As New Informe_Storage_final_local

            Report1.SetParameterValue("Fecha_in", frm_menu_principal_X.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("Fecha_fin", frm_menu_principal_X.dtp_8_fecha_final.Text)
            Report1.SetParameterValue("Obra", id_obra)
            Report1.SetParameterValue("stock_anterior", frm_menu_principal_X.txt_8_stock_anterior.Text)
            CrystalReportViewer1.ReportSource = Report1
        End If
    End Sub
End Class