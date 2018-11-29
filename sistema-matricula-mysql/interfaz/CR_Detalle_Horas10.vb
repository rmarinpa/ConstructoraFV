Public Class CR_Detalle_Horas10

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        If sincroniza = 0 Then
            Dim Report1 As New Detalle_horas
            Dim fecha_inicial As Date
            Dim fecha_final As Date

            fecha_inicial = frm_menu_principal_X.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_X.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            CrystalReportViewer1.ReportSource = Report1
        ElseIf sincroniza = 1 Then
            Dim Report1 As New Detalle_horas_local
            Dim fecha_inicial As Date
            Dim fecha_final As Date

            fecha_inicial = frm_menu_principal_X.dtp_fecha_in.Text
            fecha_final = frm_menu_principal_X.dtp_fecha_fin.Text

            Report1.SetParameterValue("Fecha_in", fecha_inicial)
            Report1.SetParameterValue("Fecha_fin", fecha_final)
            Report1.SetParameterValue("id_obra", id_obra)
            CrystalReportViewer1.ReportSource = Report1
        End If

    End Sub
End Class