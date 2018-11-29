Imports System.Globalization
Public Class Frm_liquidacion_maq

    Dim nue_report As New clases.viajes
    Dim nue_var As New clases.variables
    Dim Cod_liquidacion As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double
    Dim sincroniza_local As Integer
    Dim version_mod1 As Integer

    Sub bloquear()
        gbx_liquidacion.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        gbx_liquidacion.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Public Sub actualizar_contratos()
        cmb_equipo.DataSource = nue_report.listar2(id_obra)
        cmb_equipo.DisplayMember = "codigo"
        cmb_equipo.ValueMember = "id_equipo"
    End Sub
    Public Sub actualizar_viajes()
        cmb_viajes.DataSource = nue_report.listar5(id_obra)
        cmb_viajes.DisplayMember = "ida_vuelta"
        cmb_viajes.ValueMember = "Id_viajes"
    End Sub
    Sub limpiar()
        txt_m3_km.Clear()
        Cod_liquidacion = ""
        version_mod1 = 0
    End Sub

    Sub actualizar_dgv()
        dgv_liquidacion.DataSource = nue_report.listar3(id_obra)
        dgv_liquidacion.Columns(0).Visible = False
        dgv_liquidacion.AllowUserToOrderColumns = True

        dgv_liquidacion.Columns(1).Visible = False
        dgv_liquidacion.Columns(2).Visible = False
        dgv_liquidacion.Columns(3).Visible = False
        dgv_liquidacion.Columns(4).Visible = False
        dgv_liquidacion.Columns(6).HeaderText = "Código Máquina"
        dgv_liquidacion.Columns(5).HeaderText = "Fecha"
        dgv_liquidacion.Columns(7).Visible = False
        dgv_liquidacion.Columns(8).Visible = False
        dgv_liquidacion.Columns(9).Visible = False
        dgv_liquidacion.Columns(10).Visible = False
        dgv_liquidacion.Columns(11).Visible = False
        dgv_liquidacion.Columns(12).Visible = False
        dgv_liquidacion.Columns(13).Visible = False
        dgv_liquidacion.Columns(14).Visible = False
        dgv_liquidacion.Columns(15).Visible = False
        dgv_liquidacion.Columns(16).Visible = False
        dgv_liquidacion.Columns(17).Visible = False
        dgv_liquidacion.Columns(18).Visible = False
        dgv_liquidacion.Columns(19).Visible = False
        dgv_liquidacion.Columns(20).Visible = False
        dgv_liquidacion.Columns(21).Visible = False
        dgv_liquidacion.Columns(22).Visible = False
        dgv_liquidacion.Columns(23).Visible = False
        dgv_liquidacion.Columns(24).Visible = False
        dgv_liquidacion.Columns(25).Visible = False
        dgv_liquidacion.Columns(26).Visible = False
        dgv_liquidacion.Columns(27).Visible = False
        dgv_liquidacion.Columns(28).Visible = False
        dgv_liquidacion.Columns(29).Visible = False
        dgv_liquidacion.Columns(30).Visible = False
        dgv_liquidacion.Columns(31).Visible = False
        dgv_liquidacion.Columns(32).Visible = False
        dgv_liquidacion.Columns(33).HeaderText = "Viajes"
        dgv_liquidacion.Columns(34).HeaderText = "Tipo de Viaje"
        dgv_liquidacion.Columns(35).Visible = False

        dgv_liquidacion.Columns(6).Width = 120
        dgv_liquidacion.Columns(5).Width = 70
        dgv_liquidacion.Columns(33).Width = 70
        dgv_liquidacion.Columns(34).Width = 250
    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquear()
        actualizar_dgv()
        actualizar_contratos()
        actualizar_viajes()
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        sw = 0
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim codigo, tipo_viaje As String
        Dim viajes As Double
        Dim id_equipo As Integer
        Dim distancia_recorrida As Double
        Dim Form_3 As String

        If (cmb_equipo.Text <> "" And cmb_viajes.Text <> "" And IsNumeric(txt_m3_km.Text) And dgv_viajes.Rows.Count > 0) Then

            codigo = cmb_equipo.Text
            id_equipo = CInt(cmb_equipo.SelectedValue.ToString())
            viajes = Convert.ToDouble(txt_m3_km.Text)
            tipo_viaje = cmb_viajes.Text
            distancia_recorrida = CDbl(dgv_viajes.Rows(0).Cells(6).Value.ToString()) * CDbl(dgv_viajes.Rows(0).Cells(7).Value.ToString())
            Form_3 = dgv_viajes.Rows(0).Cells(8).Value.ToString()
            'MsgBox(distancia_recorrida)

            If sw = 0 Then
                nue_report.insertar_report(1, 0, Nombre_Obra, id_obra, CDate(txt_fecha.Text), codigo, 0, 1, 0, 0, 0, 0, 0, 0, distancia_recorrida, id_equipo, 1, Form_3, viajes, tipo_viaje, 1)
                actualizar_dgv()

            ElseIf sincroniza_local = 1 And sincroniza = 1 And sw <> 0 Then
                nue_report.modificar_report(CInt(Cod_liquidacion), 1, 0, Nombre_Obra, id_obra, CDate(txt_fecha.Text), codigo, 0, 1, 0, 0, 0, 0, 0, 0, distancia_recorrida, id_equipo, 1, Form_3, viajes, tipo_viaje, 1)
                actualizar_dgv()

            ElseIf sincroniza = 0 And sw <> 0 Then
                version_mod1 = version_mod1 + 1
                nue_report.modificar_report(CInt(Cod_liquidacion), 2, version_mod1, Nombre_Obra, id_obra, CDate(txt_fecha.Text), codigo, 0, 1, 0, 0, 0, 0, 0, 0, distancia_recorrida, id_equipo, 1, Form_3, viajes, tipo_viaje, 1)
                actualizar_dgv()
            Else
                version_mod1 = version_mod1 + 1
                nue_report.modificar_report(CInt(Cod_liquidacion), 2, version_mod1, Nombre_Obra, id_obra, CDate(txt_fecha.Text), codigo, 0, 1, 0, 0, 0, 0, 0, 0, distancia_recorrida, id_equipo, 1, Form_3, viajes, tipo_viaje, 1)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR O VUELVA SELECCIONAR EL VIAJE")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (Cod_liquidacion = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub

    Private Sub dgv_estudiante_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_liquidacion.CellDoubleClick
        Cod_liquidacion = dgv_liquidacion.CurrentRow.Cells(0).Value.ToString()
        cmb_equipo.Text = dgv_liquidacion.CurrentRow.Cells(6).Value.ToString()
        txt_fecha.Text = dgv_liquidacion.CurrentRow.Cells(5).Value.ToString()
        txt_m3_km.Text = dgv_liquidacion.CurrentRow.Cells(33).Value.ToString()
        cmb_viajes.Text = dgv_liquidacion.CurrentRow.Cells(34).Value.ToString()
        sincroniza_local = CInt(dgv_liquidacion.CurrentRow.Cells(1).Value.ToString())
        version_mod1 = CInt(dgv_liquidacion.CurrentRow.Cells(2).Value.ToString())
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (Cod_liquidacion = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.YesNo, "Confirmar")

            If eliminar = MsgBoxResult.Yes And sincroniza = 0 Then
                version_mod1 = version_mod1 + 1
                nue_report.eliminar_sincro_report(CInt(Cod_liquidacion), 3, version_mod1)
                actualizar_dgv()
                bloquear()
                limpiar()

            ElseIf sincroniza_local = 1 And sincroniza = 1 And eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar_report(CInt(Cod_liquidacion))
                actualizar_dgv()
                bloquear()
                limpiar()

            Else
                version_mod1 = version_mod1 + 1
                nue_report.eliminar_sincro_report(CInt(Cod_liquidacion), 3, version_mod1)
                actualizar_dgv()
                bloquear()
                limpiar()
            End If
        End If
    End Sub

    Private Sub cmb_viajes_TextChanged(sender As Object, e As EventArgs) Handles cmb_viajes.TextChanged
        If IsNumeric(cmb_viajes.SelectedValue.ToString()) Then
            dgv_viajes.DataSource = nue_report.listar6(id_obra, CInt(cmb_viajes.SelectedValue.ToString()))
        End If
    End Sub
End Class