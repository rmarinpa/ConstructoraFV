Public Class CR_Libro_combustible_diesel

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New informe_diesel3a_corregido3

            Report1.SetParameterValue("Fecha_in", frm_menu_principal_V.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("Fecha_fin", frm_menu_principal_V.dtp_8_fecha_final.Text)
            Report1.SetParameterValue("Obra", id_obra)
            Report1.SetParameterValue("stock_anterior", frm_menu_principal_V.txt_8_stock_anterior.Text)
            CrystalReportViewer1.ReportSource = Report1
        ElseIf sincroniza = 1 Then
            Dim Report1 As New informe_diesel3a_corregido3_local

            Report1.SetParameterValue("Fecha_in", frm_menu_principal_V.dtp_8_fecha_inicial.Text)
            Report1.SetParameterValue("Fecha_fin", frm_menu_principal_V.dtp_8_fecha_final.Text)
            Report1.SetParameterValue("Obra", id_obra)
            Report1.SetParameterValue("stock_anterior", frm_menu_principal_V.txt_8_stock_anterior.Text)
            CrystalReportViewer1.ReportSource = Report1
        End If

    End Sub
End Class