Public Class CR_listado_equipos

    Private Sub CR_Estado_de_pago_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim activo As String

        If Frm_listado_maquinas.cmb_activo.Text = "Todos" Then
            activo = "%"
        Else
            activo = Frm_listado_maquinas.cmb_activo.Text
        End If

        If sincroniza = 0 Then

            If Frm_listado_maquinas.cmb_obra.Text = "Todas" Then
                If Frm_listado_maquinas.cmb_tipo_equipo.Text = "Todos" Then
                    If Frm_listado_maquinas.cmb_ordenar.Text = "Tipo de Equipo" Then

                        Dim Report1 As New Listado_equipos_tet

                        Report1.SetParameterValue("tipo_equipo", "%")
                        Report1.SetParameterValue("activo", activo)
                        CrystalReportViewer1.ReportSource = Report1
                    Else
                        Dim Report1 As New Listado_equipost

                        Report1.SetParameterValue("tipo_equipo", "%")
                        Report1.SetParameterValue("activo", activo)
                        CrystalReportViewer1.ReportSource = Report1
                    End If

                Else
                    If Frm_listado_maquinas.cmb_ordenar.Text = "Tipo de Equipo" Then
                        Dim Report1 As New Listado_equipos_tet

                        Report1.SetParameterValue("tipo_equipo", Frm_listado_maquinas.cmb_tipo_equipo.Text)
                        Report1.SetParameterValue("activo", activo)
                        CrystalReportViewer1.ReportSource = Report1
                    Else
                        Dim Report1 As New Listado_equipost

                        Report1.SetParameterValue("tipo_equipo", Frm_listado_maquinas.cmb_tipo_equipo.Text)
                        Report1.SetParameterValue("activo", activo)
                        CrystalReportViewer1.ReportSource = Report1
                    End If
                End If
            Else
                If Frm_listado_maquinas.cmb_tipo_equipo.Text = "Todos" Then
                    If Frm_listado_maquinas.cmb_ordenar.Text = "Tipo de Equipo" Then
                        Dim Report1 As New Listado_equipos_te

                        Report1.SetParameterValue("id_obra", Frm_listado_maquinas.cmb_obra.SelectedValue.ToString())
                        Report1.SetParameterValue("tipo_equipo", "%")
                        Report1.SetParameterValue("activo", activo)
                        CrystalReportViewer1.ReportSource = Report1
                    Else
                        Dim Report1 As New Listado_equipos

                        Report1.SetParameterValue("id_obra", Frm_listado_maquinas.cmb_obra.SelectedValue.ToString())
                        Report1.SetParameterValue("tipo_equipo", "%")
                        Report1.SetParameterValue("activo", activo)
                        CrystalReportViewer1.ReportSource = Report1
                    End If

                Else
                    If Frm_listado_maquinas.cmb_ordenar.Text = "Tipo de Equipo" Then
                        Dim Report1 As New Listado_equipos_te

                        Report1.SetParameterValue("id_obra", Frm_listado_maquinas.cmb_obra.SelectedValue.ToString())
                        Report1.SetParameterValue("tipo_equipo", Frm_listado_maquinas.cmb_tipo_equipo.Text)
                        Report1.SetParameterValue("activo", activo)
                        CrystalReportViewer1.ReportSource = Report1
                    Else
                        Dim Report1 As New Listado_equipos

                        Report1.SetParameterValue("id_obra", Frm_listado_maquinas.cmb_obra.SelectedValue.ToString())
                        Report1.SetParameterValue("tipo_equipo", Frm_listado_maquinas.cmb_tipo_equipo.Text)
                        Report1.SetParameterValue("activo", activo)
                        CrystalReportViewer1.ReportSource = Report1
                    End If
                End If
            End If
        End If
    End Sub
End Class