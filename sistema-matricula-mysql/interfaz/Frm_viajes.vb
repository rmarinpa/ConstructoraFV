Imports System.Globalization
Public Class Frm_viajes

    Dim nue_report As New clases.viajes
    Dim nue_var As New clases.variables
    Dim Cod_viajes As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double
    Dim sincroniza_local As Integer
    Dim version_mod1 As Integer

    Sub bloquear()
        gbx_viajes.Enabled = False
        btn_cancelar.Enabled = False
        btn_guardar.Enabled = False
        btn_editar.Enabled = True
        btn_nuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Sub desbloquear()
        gbx_viajes.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
        btn_editar.Enabled = False
        btn_nuevo.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Sub limpiar()
        txt_ida_vuelta.Clear()
        txt_km.Clear()
        txt_m3_km.Clear()
        Cod_viajes = ""
        version_mod1 = 0
    End Sub

    Sub actualizar_dgv()
        If rdbtn_m3_km.Checked = True Then
            dgv_viajes.DataSource = nue_report.listar(id_obra, 1)
        ElseIf rdbtn_viaje.Checked = True Then
            dgv_viajes.DataSource = nue_report.listar(id_obra, 2)
        End If

        dgv_viajes.Columns(0).Visible = False
        dgv_viajes.AllowUserToOrderColumns = True
        dgv_viajes.Columns(5).HeaderText = "Viaje"

        If rdbtn_m3_km.Checked = True Then
            dgv_viajes.Columns(6).Visible = True
            dgv_viajes.Columns(6).HeaderText = "Kilometraje"
            dgv_viajes.Columns(7).HeaderText = "Precio M3-KM"
        Else
            dgv_viajes.Columns(6).Visible = False
            dgv_viajes.Columns(7).HeaderText = "Precio Viaje"
        End If

        dgv_viajes.Columns(8).HeaderText = "Cuenta Costo"
        dgv_viajes.Columns(5).Width = 270
        dgv_viajes.Columns(6).Width = 80
        dgv_viajes.Columns(7).Width = 80
        dgv_viajes.Columns(8).Width = 80
        dgv_viajes.Columns(0).Visible = False
        dgv_viajes.Columns(1).Visible = False
        dgv_viajes.Columns(2).Visible = False
        dgv_viajes.Columns(3).Visible = False
        dgv_viajes.Columns(4).Visible = False
        dgv_viajes.Columns(8).Visible = False
        dgv_viajes.Columns(9).Visible = False
    End Sub

    Private Sub frm_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'actualizar_dgv()
        actualiza_cuentas_maquinaria()
        bloquear()
        gbx_viajes.Visible = False
        txt_km.Text = 1
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
        Dim ida_vuelta, cuenta_costo As String
        Dim kilometraje, precio_m3_km As Double
        Dim tipo_viaje As Integer

        If (txt_ida_vuelta.Text <> "" And IsNumeric(txt_km.Text) And IsNumeric(txt_m3_km.Text) And rdbtn_m3_km.Checked = True) Or (txt_ida_vuelta.Text <> "" And IsNumeric(txt_m3_km.Text) And rdbtn_viaje.Checked = True) Then

            ida_vuelta = txt_ida_vuelta.Text

            If rdbtn_m3_km.Checked = True Then
                kilometraje = Convert.ToDouble(txt_km.Text)
            ElseIf rdbtn_viaje.Checked = True Then
                kilometraje = 1
            End If

            If rdbtn_m3_km.Checked = True Then
                tipo_viaje = 1
            ElseIf rdbtn_viaje.Checked = True Then
                tipo_viaje = 2
            End If

            precio_m3_km = Convert.ToDouble(txt_m3_km.Text)
            cuenta_costo = cmb_1_cuenta.Text

            If sw = 0 Then
                nue_report.insertar(1, 0, Nombre_Obra, id_obra, ida_vuelta, kilometraje, precio_m3_km, cuenta_costo, tipo_viaje)
                actualizar_dgv()
            ElseIf sincroniza_local = 1 And sincroniza = 1 And sw <> 0 Then
                nue_report.modificar(CInt(Cod_viajes), 1, 0, Nombre_Obra, id_obra, ida_vuelta, kilometraje, precio_m3_km, cuenta_costo, tipo_viaje)
                actualizar_dgv()
            ElseIf sincroniza = 0 And sw <> 0 Then
                version_mod1 = version_mod1 + 1
                nue_report.modificar(CInt(Cod_viajes), 2, version_mod1, Nombre_Obra, id_obra, ida_vuelta, kilometraje, precio_m3_km, cuenta_costo, tipo_viaje)
                actualizar_dgv()
            Else
                version_mod1 = version_mod1 + 1
                nue_report.modificar(CInt(Cod_viajes), 2, version_mod1, Nombre_Obra, id_obra, ida_vuelta, kilometraje, precio_m3_km, cuenta_costo, tipo_viaje)
                actualizar_dgv()
            End If
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        bloquear()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        If (Cod_viajes = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear()
            sw = 1
        End If
    End Sub
    Public Sub actualiza_cuentas_maquinaria()
        cmb_1_cuenta.DataSource = nue_report.listar6(id_obra)
        cmb_1_cuenta.DisplayMember = "Cuenta_costo"
        cmb_1_cuenta.ValueMember = "Cuenta_costo"
    End Sub

    Private Sub dgv_estudiante_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_viajes.CellDoubleClick
        Cod_viajes = dgv_viajes.CurrentRow.Cells(0).Value.ToString()
        txt_ida_vuelta.Text = dgv_viajes.CurrentRow.Cells(5).Value.ToString()
        txt_km.Text = dgv_viajes.CurrentRow.Cells(6).Value.ToString()
        txt_m3_km.Text = dgv_viajes.CurrentRow.Cells(7).Value.ToString()
        sincroniza_local = CInt(dgv_viajes.CurrentRow.Cells(1).Value.ToString())
        version_mod1 = CInt(dgv_viajes.CurrentRow.Cells(2).Value.ToString())
        cmb_1_cuenta.Text = dgv_viajes.CurrentRow.Cells(8).Value.ToString()
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim eliminar As MsgBoxResult
        If (Cod_viajes = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar = MsgBoxResult.Ok And sincroniza = 0 Then
                version_mod1 = version_mod1 + 1
                nue_report.eliminar_sincro(CInt(Cod_viajes), 3, version_mod1)
                actualizar_dgv()
                bloquear()
                limpiar()

            ElseIf sincroniza_local = 1 And sincroniza = 1 And eliminar = MsgBoxResult.Ok Then
                nue_report.eliminar(CInt(Cod_viajes))
                actualizar_dgv()
                bloquear()
                limpiar()

            Else
                version_mod1 = version_mod1 + 1
                nue_report.eliminar_sincro(CInt(Cod_viajes), 3, version_mod1)
                actualizar_dgv()
                bloquear()
                limpiar()
            End If
        End If
    End Sub

    Private Sub rdbtn_m3_km_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtn_m3_km.CheckedChanged
        If rdbtn_m3_km.Checked = True Then
            Label3.Text = "PRECIO M3-KM"
            Label1.Visible = True
            txt_km.Visible = True
            txt_km.Clear()
            gbx_viajes.Visible = True
            limpiar()
            actualizar_dgv()
        ElseIf rdbtn_viaje.Checked = True Then
            Label3.Text = "PRECIO"
            Label1.Visible = False
            txt_km.Text = 1
            txt_km.Visible = False
            gbx_viajes.Visible = True
            limpiar()
            actualizar_dgv()
        End If
    End Sub

End Class