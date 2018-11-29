Imports Microsoft.Office.Interop.Word 'Control de office
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop

Public Class frm_menu_principal_IV_V2
    Dim nue_obra1 As New clases.Identificacion_subcontratos
    Dim nue_obra2 As New clases.Registro_subcontratos
    Dim nue_obra3 As New clases.Trabajos_adicionales_subcontratos
    Dim nue_obra4 As New clases.Generacion_subcontratos
    Dim nue_obra5 As New clases.Ingreso_subcontratos
    Dim nue_obra6 As New clases.Generacion_finiquitos
    Dim nue_obra7 As New clases.Ingreso_finiquitos
    Dim nue_obra8 As New clases.Generacion_ep
    Dim nue_var As New clases.variables
    Dim Cod_1 As String = ""
    Dim Cod_11 As String = ""
    Dim Cod_2 As String = ""
    Dim Cod_3 As String = ""
    Dim Cod_5 As String = ""
    Dim Cod_7 As String = ""
    Dim sw1 As Integer
    Dim sw11 As Integer
    Dim sw2 As Integer
    Dim sw3 As Integer
    Dim sincroniza_local As Integer
    Dim sincroniza_local_1 As Integer
    Dim sincroniza_local2 As Integer
    Dim sincroniza_local3 As Integer
    Dim sincroniza_mod1 As Integer
    Dim sincroniza_mod2 As Integer
    Dim sincroniza_mod3 As Integer
    Dim version_mod1 As Integer
    Dim version_mod11 As Integer
    Dim version_mod2 As Integer
    Dim version_mod3 As Integer
    Dim version_mod5 As Integer
    Dim version_mod7 As Integer
    Dim existe_rut As Integer
    Dim nombre1 As String
    Dim contador As Integer
    Dim consulta_datos_local As Integer
    Dim activa4 As Integer
    Dim activa5 As Integer
    Dim var_in1 As Integer
    Dim var_in2 As Integer
    Dim var_in3 As Integer
    Dim var_in4 As Integer
    Dim var_in5 As Integer
    Dim var_in6 As Integer
    Dim var_in7 As Integer
    Dim var_in8 As Integer

    Sub bloquear1()
        txt_1_rut.Enabled = False
        txt_1_domicilio.Enabled = False
        'txt_1_razon_social.Enabled = False
        txt_1_representante.Enabled = False
        txt_1_rut_representante.Enabled = False
        txt_1_servicio.Enabled = False
        txt_1_comuna.Enabled = False
        txt_1_ciudad.Enabled = False
        txt_1_valor_seguro.Enabled = False
        txt_1_capacidad.Enabled = False
        cmb_1_obra.Enabled = False
        txt_1_plazo_dias.Enabled = False
        txt_1_valor_pesos.Enabled = False
        txt_1_valor_contrato.Enabled = False
        txt_1_servicio.Enabled = False
        dgv_datosAgregados1.Visible = False
        btn_1_agregar_linea.Visible = False
        dgv_datosAgregados1.Enabled = False
        btn_guardar2.Visible = False
        cmb_4_cuenta_maq.Visible = False
        Label29.Visible = False



        btn_cancelar1.Enabled = False
        btn_guardar1.Enabled = False
        btn_editar1.Enabled = True
        btn_nuevo1.Enabled = True
        btn_eliminar1.Enabled = True
    End Sub
    Sub bloquear11()
        txt_1_rut.Enabled = False
        txt_1_domicilio.Enabled = False
        'txt_1_razon_social.Enabled = False
        txt_1_representante.Enabled = False
        txt_1_rut_representante.Enabled = False
        txt_1_comuna.Enabled = False
        txt_1_ciudad.Enabled = False

        btn_cancelar11.Enabled = False
        btn_guardar11.Enabled = False
        btn_editar11.Enabled = True
        btn_nuevo11.Enabled = True
        btn_eliminar11.Enabled = True
    End Sub
    Sub desbloquear1()
        'txt_1_rut.Enabled = True
        'txt_1_domicilio.Enabled = True
        'txt_1_representante.Enabled = True
        'txt_1_rut_representante.Enabled = True
        'txt_1_comuna.Enabled = True
        'txt_1_ciudad.Enabled = True

        txt_1_valor_seguro.Enabled = True
        txt_1_capacidad.Enabled = True
        cmb_1_obra.Enabled = True
        txt_1_plazo_dias.Enabled = True
        txt_1_valor_contrato.Enabled = True
        txt_1_servicio.Enabled = True
        dgv_datosAgregados1.Visible = True
        btn_1_agregar_linea.Visible = True
        btn_guardar2.Visible = True
        cmb_4_cuenta_maq.Visible = True
        Label29.Visible = True

        dgv_datosAgregados1.Enabled = True

        btn_cancelar1.Enabled = True
        btn_guardar1.Enabled = True
        btn_editar1.Enabled = False
        btn_nuevo1.Enabled = False
        btn_eliminar1.Enabled = False
    End Sub
    Sub desbloquear11()
        txt_1_rut.Enabled = True
        txt_1_domicilio.Enabled = True
        txt_1_representante.Enabled = True
        txt_1_rut_representante.Enabled = True
        txt_1_comuna.Enabled = True
        txt_1_ciudad.Enabled = True

        btn_cancelar11.Enabled = True
        btn_guardar11.Enabled = True
        btn_editar11.Enabled = False
        btn_nuevo11.Enabled = False
        btn_eliminar11.Enabled = False
    End Sub
    Sub limpiar1()

        txt_1_servicio.Text = ""
        txt_1_valor_seguro.Clear()
        txt_1_capacidad.Clear()
        cmb_1_obra.Text = ""
        txt_1_plazo_dias.Clear()
        txt_1_valor_pesos.Clear()
        txt_1_valor_contrato.Clear()
        txt_1_servicio.Clear()
        dgv_datosAgregados1.Rows.Clear()
        txt_id_subcontrato.Clear()

        Cod_1 = ""
        version_mod1 = 0

        gp_1_identificacion.Visible = False
        gp_1_general.Visible = False
    End Sub

    Sub limpiar11()
        txt_1_rut.Clear()
        txt_1_domicilio.Clear()
        txt_1_razon_social.Text = ""
        txt_1_representante.Clear()
        txt_1_rut_representante.Clear()

        txt_1_comuna.Clear()
        txt_1_ciudad.Clear()

        Cod_11 = ""
        version_mod11 = 0

    End Sub
    Sub bloquear2()
        'txt_2_cuenta.Enabled = False
        'txt_2_descripcion.Enabled = False

        'btn_cancelar2.Enabled = False
        'btn_guardar2.Enabled = False
        'btn_editar2.Enabled = True
        'btn_nuevo2.Enabled = True
        'btn_eliminar2.Enabled = True
    End Sub

    Sub desbloquear2()
        'txt_2_cuenta.Enabled = True
        'txt_2_descripcion.Enabled = True

        'btn_cancelar2.Enabled = True
        'btn_guardar2.Enabled = True
        'btn_editar2.Enabled = False
        'btn_nuevo2.Enabled = False
        'btn_eliminar2.Enabled = False
    End Sub
    Sub limpiar2()
        'txt_2_cuenta.Clear()
        'txt_2_descripcion.Clear()
        'Cod_2 = ""
    End Sub
    Sub bloquear3()
        cmb_3_subcontrato.Enabled = False
        dtp_3_fecha.Enabled = False
        cmb_3_clasificacion.Enabled = False
        txt_3_descripcion.Enabled = False
        cmb_3_un_pago.Enabled = False
        txt_3_precio.Enabled = False
        txt_3_cantidad.Enabled = False
        txt_3_total.Enabled = False
        cmb_3_cuenta_contable.Enabled = False

        btn_cancelar3.Enabled = False
        btn_guardar3.Enabled = False
        btn_editar3.Enabled = True
        btn_nuevo3.Enabled = True
        btn_eliminar3.Enabled = True
    End Sub
    Sub desbloquear3()
        cmb_3_subcontrato.Enabled = True
        dtp_3_fecha.Enabled = True
        cmb_3_clasificacion.Enabled = True
        txt_3_descripcion.Enabled = True
        cmb_3_un_pago.Enabled = True
        txt_3_precio.Enabled = True
        txt_3_cantidad.Enabled = True
        'txt_3_total.Enabled = False
        cmb_3_cuenta_contable.Enabled = True

        btn_cancelar3.Enabled = True
        btn_guardar3.Enabled = True
        btn_editar3.Enabled = False
        btn_nuevo3.Enabled = False
        btn_eliminar3.Enabled = False
    End Sub
    Sub limpiar3()
        cmb_3_subcontrato.Text = ""
        cmb_3_clasificacion.Text = ""
        cmb_3_cuenta_contable.Text = ""
        txt_3_descripcion.Clear()
        cmb_3_un_pago.Text = ""
        txt_3_precio.Clear()
        txt_3_cantidad.Clear()
        'txt_3_total.Enabled = False
    End Sub
    Sub autoriza1()
        If autoriza_2_1 = 1 Then
            btn_cancelar1.Visible = True
            btn_guardar1.Visible = True
            btn_editar1.Visible = True
            btn_nuevo1.Visible = True
            btn_eliminar1.Visible = True
        ElseIf autoriza_2_1 = 0 Then
            btn_cancelar1.Visible = False
            btn_guardar1.Visible = False
            btn_editar1.Visible = False
            btn_nuevo1.Visible = False
            btn_eliminar1.Visible = False
        End If
    End Sub
    Sub autoriza2()
        If autoriza_2_2 = 1 Then
            'btn_cancelar2.Visible = True
            'btn_guardar2.Visible = True
            'btn_editar2.Visible = True
            'btn_nuevo2.Visible = True
            'btn_eliminar2.Visible = True
            btn_tabla.Visible = True
        ElseIf autoriza_2_2 = 0 Then
            'btn_cancelar2.Visible = False
            'btn_guardar2.Visible = False
            'btn_editar2.Visible = False
            'btn_nuevo2.Visible = False
            'btn_eliminar2.Visible = False
            btn_tabla.Visible = False
        End If
    End Sub
    Sub autoriza3()
        If autoriza_2_3 = 1 Then
            btn_cancelar3.Visible = True
            btn_guardar3.Visible = True
            btn_editar3.Visible = True
            btn_nuevo3.Visible = True
            btn_eliminar3.Visible = True
        ElseIf autoriza_2_3 = 0 Then
            btn_cancelar3.Visible = False
            btn_guardar3.Visible = False
            btn_editar3.Visible = False
            btn_nuevo3.Visible = False
            btn_eliminar3.Visible = False
        End If
    End Sub

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim rtn As New Date
        activa4 = 0
        activa5 = 0
        var_in1 = 0
        var_in2 = 0
        var_in3 = 0
        var_in4 = 0
        var_in5 = 0
        var_in6 = 0
        var_in7 = 0
        var_in8 = 0
        'actualiza_arrendador()
        'actualiza_arrendador4()
        'actualiza_arrendador5()
        'actualiza_arrendador6()
        'actualiza_arrendador7()
        'actualiza_arrendador8()
        'actualiza_obras()
        'actualiza_obras5()
        'actualiza_obras6()
        'actualiza_obras7()
        'actualiza_equipos()
        actualiza_cuentas_maquinaria()
        actualiza_cuentas_maquinaria_2()
        'actualiza_cuentas_trabajo()
        'actualiza_arrendador3()
        'actualizar_5_adjuntos()
        'actualizar_7_adjuntos()
        lbl_nombre_obra.Text = Nombre_Obra
        lbl_usuario.Text = Nombre_Usuario
        Me.WindowState = FormWindowState.Maximized
        txt_1_nom_obra.Enabled = False
        txt_1_nom_obra.Text = Nombre_Obra
        cmb_1_gerente.Text = ""
        gp_1_identificacion.Visible = False
        gp_1_general.Visible = False
        consulta_datos = 0
        consulta_datos_local = 0
        Timer1.Enabled = True
        txt_8_ep.Text = 1

        bloquear1()
        bloquear2()
        bloquear3()
        autoriza_2_1 = 1
        autoriza_2_2 = 1
        autoriza_2_3 = 1
        autoriza1()
        autoriza2()
        autoriza3()
        'actualizar_dgv1()
        'actualizar_dgv2()
        actualizar_dgv3()
        'sincroniza = 0
        dtp_fecha.MaxDate = Today
        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 24).AddMonths(-1)
        dtp_fecha.MinDate = rtn
        With dtp_8_fecha_inicial
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "23 MMMM yyyy"
            .MaxDate = Today.AddMonths(1).AddDays(23 - Today.Day)
            .MinDate = Today.AddMonths(-2)
        End With

        With dtp_3_fecha
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "23 MMMM yyyy"
            .MaxDate = Today.AddMonths(1).AddDays(23 - Today.Day)
            .MinDate = Today.AddMonths(-2)
        End With

        With dtp_fecha
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "23 MMMM yyyy"
            .MaxDate = Today.AddMonths(1).AddDays(23 - Today.Day)
            .MinDate = Today.AddMonths(-2)
        End With

        If sincroniza = 0 Then
            btn_sincronizar.Visible = False
            pb_list.Visible = False
            lbl_sincroniza.Text = "Trabajando con Internet"
            'btn_editar1.Visible = True
            'btn_eliminar1.Visible = True

            btn_tabla.Visible = True

            'btn_editar3.Visible = True
            'btn_eliminar3.Visible = True
            'btn_4_sincronizar.Visible = True
            'btn_7_ingresar.Visible = True
            'btn_5_ingresar.Visible = True
            'btn_eliminar7.Visible = True
            'btn_eliminar5.Visible = True
            'btn_6_sincronizar.Visible = True

        ElseIf sincroniza = 1 Then
            btn_sincronizar.Visible = True
            pb_list.Visible = True
            lbl_sincroniza.Text = "Trabajando sin Internet"
            'btn_editar1.Visible = False
            'btn_eliminar1.Visible = False

            'btn_editar3.Visible = False
            'btn_eliminar3.Visible = False
            'btn_4_sincronizar.Visible = False
            'btn_7_ingresar.Visible = False
            'btn_5_ingresar.Visible = False
            'btn_eliminar7.Visible = False
            'btn_eliminar5.Visible = False
            'btn_6_sincronizar.Visible = False
        End If

        If num_tab = 1 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 0
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 2 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 1
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 3 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 2
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 4 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 3
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 5 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 4
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 6 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 5
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 7 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 6
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 8 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 7
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 9 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 8
            Me.TabPage52.Parent = Nothing
        End If

        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        num_tab = 0
        Dim consultar As MsgBoxResult
        If consulta_datos <> 0 Then
            consultar = MsgBox("Usted no ha guardado los avances, ¿Desea guardarlos?", MsgBoxStyle.OkCancel, "Confirmar")

            If consultar = MsgBoxResult.Ok Then
                btn_tabla.PerformClick()
            Else
            End If
            frm_menu_principal.Show()
            Me.Close()
        ElseIf consulta_datos = 0 Then
            frm_menu_principal.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        End
    End Sub
    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        If num_tab <> 0 Then
            num_tab = 0
            Dim consultar As MsgBoxResult
            If consulta_datos <> 0 Then
                consultar = MsgBox("Usted no ha guardado los avances, ¿Desea guardarlos?", MsgBoxStyle.OkCancel, "Confirmar")

                If consultar = MsgBoxResult.Ok Then
                    btn_tabla.PerformClick()
                Else
                End If
                frm_menu_principal.Show()
                Me.Close()
            ElseIf consulta_datos = 0 Then
                frm_menu_principal.Show()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btn_nuevo1_Click(sender As Object, e As EventArgs) Handles btn_nuevo1.Click
        actualiza_arrendador()
        desbloquear1()
        limpiar1()
        sw1 = 0
        Cod_1 = ""

        If sw11 = 1 Then
            btn_cancelar11.PerformClick()
        End If
    End Sub
    Private Sub btn_nuevo2_Click(sender As Object, e As EventArgs)
        desbloquear2()
        limpiar2()
        sw2 = 0
        Cod_2 = ""
    End Sub
    Private Sub btn_nuevo3_Click(sender As Object, e As EventArgs) Handles btn_nuevo3.Click
        desbloquear3()
        limpiar3()
        sw3 = 0
        Cod_3 = ""
    End Sub
    Private Sub btn_cancelar3_Click(sender As Object, e As EventArgs) Handles btn_cancelar3.Click
        bloquear3()
    End Sub
    Private Sub btn_cancelar2_Click(sender As Object, e As EventArgs)
        bloquear2()
    End Sub
    Private Sub btn_cancelar1_Click(sender As Object, e As EventArgs) Handles btn_cancelar1.Click
        'btn_nuevo1.PerformClick()
        bloquear1()
    End Sub
    Private Sub btn_guardar1_Click(sender As Object, e As EventArgs) Handles btn_guardar1.Click
        Dim rut, domicilio, obra, razon_social, representante, representante_rut, servicio, comuna, ciudad As String
        Dim valor_pesos, plazo_dias, valor_contrato, valor_seguro As Double

        If (txt_1_rut.Text <> "" And txt_1_razon_social.Text <> "" And txt_1_servicio.Text <> "") Then
            sincroniza_local = 1

            domicilio = txt_1_domicilio.Text
            razon_social = txt_1_razon_social.Text
            representante = txt_1_representante.Text
            representante_rut = txt_1_rut_representante.Text
            rut = txt_1_rut.Text
            comuna = txt_1_comuna.Text
            ciudad = txt_1_ciudad.Text
            servicio = txt_1_servicio.Text
            obra = cmb_1_obra.Text

            If Not IsNumeric(txt_1_plazo_dias.Text) Then
                plazo_dias = 0
            Else
                plazo_dias = CDbl(txt_1_plazo_dias.Text)
            End If

            If Not IsNumeric(txt_1_valor_pesos.Text) Then
                valor_pesos = 0
            Else
                valor_pesos = CDbl(txt_1_valor_pesos.Text)
            End If

            If Not IsNumeric(txt_1_valor_contrato.Text) Then
                valor_contrato = 0
            Else
                valor_contrato = CDbl(txt_1_valor_contrato.Text)
            End If

            If Not IsNumeric(txt_1_valor_seguro.Text) Then
                valor_seguro = 0
            Else
                valor_seguro = CDbl(txt_1_valor_seguro.Text)
            End If

            If sw1 = 0 Then
                If existe_rut = 1 Then
                    nue_obra1.insertar_cabecera(1, 0, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut, comuna, ciudad)
                End If

                nue_obra1.insertar_posicion(1, 0, Nombre_Obra, id_obra, rut, servicio, obra, plazo_dias, valor_contrato, valor_pesos, valor_seguro)

            ElseIf sincroniza_local = 1 And sincroniza = 1 And sw1 <> 0 Then
                nue_obra1.modificar_posicion(CInt(Cod_1), 1, 0, Nombre_Obra, id_obra, rut, servicio, obra, plazo_dias, valor_contrato, valor_pesos, valor_seguro)

            ElseIf sincroniza = 0 And sw1 <> 0 Then
                version_mod1 = version_mod1 + 1
                nue_obra1.modificar_posicion(CInt(Cod_1), 2, version_mod1, Nombre_Obra, id_obra, rut, servicio, obra, plazo_dias, valor_contrato, valor_pesos, valor_seguro)

            Else
                version_mod1 = version_mod1 + 1
                nue_obra1.modificar_posicion(CInt(Cod_1), 2, version_mod1, Nombre_Obra, id_obra, rut, servicio, obra, plazo_dias, valor_contrato, valor_pesos, valor_seguro)
            End If

            actualizar_dgv1()
            actualiza_equipos()

            limpiar1()
            bloquear1()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub
    Private Sub btn_editar2_Click(sender As Object, e As EventArgs)
        If (Cod_2 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear2()
            sw2 = 1
        End If
    End Sub
    Private Sub btn_editar3_Click(sender As Object, e As EventArgs) Handles btn_editar3.Click
        If (Cod_3 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear3()
            sw3 = 1
        End If
    End Sub

    Public Sub actualiza_cuentas_maquinaria_2()
        cmb_4_cuenta_maq.DataSource = nue_obra1.listar6(id_obra)
        cmb_4_cuenta_maq.DisplayMember = "cuenta_desc"
        cmb_4_cuenta_maq.ValueMember = "Cuenta_costo"
    End Sub
    Private Sub btn_eliminar1_Click(sender As Object, e As EventArgs) Handles btn_eliminar1.Click
        Dim eliminar1 As MsgBoxResult
        If (Cod_1 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar1 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If dgv_datosAgregados1.Rows.Count > 0 Then
                For i = 0 To dgv_datosAgregados1.Rows.Count - 1

                    If dgv_datosAgregados1.Rows(i).Cells(0).Value.ToString() <> 0 Then

                        Cod_1 = dgv_datosAgregados1.Rows(i).Cells(0).Value.ToString()
                        version_mod1 = dgv_datosAgregados1.Rows(i).Cells(8).Value.ToString()

                        If eliminar1 = MsgBoxResult.Ok Then
                            version_mod1 = version_mod1 + 1
                            nue_obra1.eliminar_sincro(CInt(Cod_1), 3, version_mod1)
                            actualizar_dgv1()
                            bloquear1()
                            limpiar1()
                            actualiza_equipos()

                        ElseIf sincroniza_local_1 = 1 And sincroniza = 1 And eliminar1 = MsgBoxResult.Ok Then
                            nue_obra1.eliminar_equipo(CInt(Cod_1))
                            actualizar_dgv1()
                            bloquear1()
                            limpiar1()
                            actualiza_equipos()
                        ElseIf eliminar1 = MsgBoxResult.Ok Then
                            version_mod1 = version_mod1 + 1
                            nue_obra1.eliminar_sincro(CInt(Cod_1), 3, version_mod1)
                            actualizar_dgv1()
                            bloquear1()
                            limpiar1()
                            actualiza_equipos()
                        End If
                    End If
                Next i
            End If
            End If
    End Sub
    Private Sub btn_eliminar3_Click(sender As Object, e As EventArgs) Handles btn_eliminar3.Click
        Dim eliminar3 As MsgBoxResult
        If (Cod_3 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar3 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar3 = MsgBoxResult.Ok And sincroniza = 0 Then
                version_mod3 = version_mod3 + 1
                nue_obra3.eliminar_sincro(CInt(Cod_3), 3, version_mod3)
                actualizar_dgv3()
                bloquear3()
                limpiar3()

            ElseIf sincroniza_local = 1 And sincroniza = 1 And eliminar3 = MsgBoxResult.Yes Then
                nue_obra3.eliminar(CInt(Cod_3))
                actualizar_dgv3()
                bloquear3()
                limpiar3()

            ElseIf eliminar3 = MsgBoxResult.Ok Then
                version_mod3 = version_mod3 + 1
                nue_obra3.eliminar_sincro(CInt(Cod_3), 3, version_mod3)
                actualizar_dgv3()
                bloquear3()
                limpiar3()
            End If
        End If
    End Sub

    Private Sub btn_guardar3_Click(sender As Object, e As EventArgs) Handles btn_guardar3.Click
        Dim subcontratista, subcontrato, rut, clasificacion, descripcion, unidad, cuenta_contable As String
        Dim Cantidad, precio_unitario, Total As Double
        Dim fecha_adicional As Date
        'Dim codigo_subcontrato As Integer

        If (txt_3_descripcion.Text <> "" And txt_3_precio.Text <> "" And txt_3_cantidad.Text <> "") Then

            Dim Cadena As String = cmb_3_subcontrato.Text
            Dim ArrCadena As String() = Cadena.Split("/")
            subcontratista = ArrCadena(0)
            subcontrato = ArrCadena(1)

            'subcontratista = cmb_3_subcontrato.Text
            'subcontrato = cmb_3_subcontrato.Text
            rut = cmb_3_subcontrato.SelectedValue.ToString()
            clasificacion = cmb_3_clasificacion.Text
            cuenta_contable = cmb_3_cuenta_contable.SelectedValue.ToString()
            descripcion = txt_3_descripcion.Text
            unidad = cmb_3_un_pago.Text
            Cantidad = CDbl(txt_3_cantidad.Text)
            precio_unitario = CDbl(txt_3_precio.Text)
            Total = CDbl(txt_3_total.Text)
            fecha_adicional = CDate("23/" & Month(dtp_3_fecha.Text) & "/" & Year(dtp_3_fecha.Text))

            If sw3 = 0 Then
                nue_obra3.insertar(1, 0, Nombre_Obra, id_obra, subcontratista, subcontrato, rut, clasificacion, descripcion, Cantidad, unidad, precio_unitario, Total, cuenta_contable, fecha_adicional)
            ElseIf sincroniza_local = 1 And sincroniza = 1 And sw11 <> 0 Then
                nue_obra3.modificar(CInt(Cod_3), 1, 0, Nombre_Obra, id_obra, subcontratista, subcontrato, rut, clasificacion, descripcion, Cantidad, unidad, precio_unitario, Total, cuenta_contable, fecha_adicional)
            ElseIf sincroniza = 0 And sw11 <> 0 Then
                version_mod3 = version_mod3 + 1
                nue_obra3.modificar(CInt(Cod_3), 2, version_mod3, Nombre_Obra, id_obra, subcontratista, subcontrato, rut, clasificacion, descripcion, Cantidad, unidad, precio_unitario, Total, cuenta_contable, fecha_adicional)
            Else
                version_mod3 = version_mod3 + 1
                nue_obra3.modificar(CInt(Cod_3), 2, version_mod3, Nombre_Obra, id_obra, subcontratista, subcontrato, rut, clasificacion, descripcion, Cantidad, unidad, precio_unitario, Total, cuenta_contable, fecha_adicional)
            End If
            actualizar_dgv3()
            limpiar3()
            bloquear3()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_editar1_Click(sender As Object, e As EventArgs) Handles btn_editar1.Click
        If (Cod_1 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear1()
            sw1 = 1
            txt_1_rut.Enabled = False
            txt_1_domicilio.Enabled = False
            txt_1_representante.Enabled = False
            txt_1_rut_representante.Enabled = False
            txt_1_comuna.Enabled = False
            txt_1_ciudad.Enabled = False
        End If
    End Sub
    Sub actualizar_dgv1()
        dgv_1_subcontratos.DataSource = nue_obra1.listar2(id_obra)
        dgv_1_subcontratos.Columns(0).Visible = False
        dgv_1_subcontratos.Columns(1).HeaderText = "Subcontratista"
        dgv_1_subcontratos.Columns(1).Width = 150
        dgv_1_subcontratos.Columns(2).HeaderText = "Subcontrato"
        dgv_1_subcontratos.Columns(2).Width = 150
        dgv_1_subcontratos.Columns(3).Visible = False
        dgv_1_subcontratos.Columns(4).Visible = False
        dgv_1_subcontratos.Columns(5).Visible = False
        dgv_1_subcontratos.Columns(6).Visible = False
        dgv_1_subcontratos.Columns(7).Visible = False
        dgv_1_subcontratos.Columns(8).Visible = False
        dgv_1_subcontratos.Columns(9).Visible = False
        dgv_1_subcontratos.Columns(10).Visible = False
        dgv_1_subcontratos.Columns(11).Visible = False
        dgv_1_subcontratos.Columns(12).Visible = False

        dgv_1_subcontratos.AllowUserToOrderColumns = True
    End Sub

    Private Sub txt_1_plazo_TextChanged(sender As Object, e As EventArgs) Handles txt_1_plazo.TextChanged
        Dim fecha_inicial As Date
        If IsNumeric(txt_1_plazo.Text) Then
            fecha_inicial = dtp_1_inicio.Text
            dtp_1_final.Text = fecha_inicial.AddDays(CInt(txt_1_plazo.Text))
        Else
            dtp_1_final.Text = dtp_1_inicio.Text
        End If
    End Sub

    Private Sub dtp_1_inicio_ValueChanged(sender As Object, e As EventArgs) Handles dtp_1_inicio.ValueChanged
        Dim fecha_inicial As Date
        If IsNumeric(txt_1_plazo.Text) Then
            fecha_inicial = dtp_1_inicio.Text
            dtp_1_final.Text = fecha_inicial.AddDays(CInt(txt_1_plazo.Text))
        Else
            dtp_1_final.Text = dtp_1_inicio.Text
        End If
    End Sub
    Sub actualizar_dgv2()
        'dgv_2_cuentas.DataSource = nue_obra2.listar(id_obra)
        'dgv_2_cuentas.Columns(0).Visible = False
        'dgv_2_cuentas.Columns(1).Visible = False
        'dgv_2_cuentas.Columns(2).Visible = False
        'dgv_2_cuentas.Columns(3).Visible = False
        'dgv_2_cuentas.Columns(4).Visible = False
        'dgv_2_cuentas.Columns(5).HeaderText = "Cuenta"
        'dgv_2_cuentas.Columns(5).Width = 150
        'dgv_2_cuentas.Columns(6).HeaderText = "Descripción"
        'dgv_2_cuentas.Columns(6).Width = 250

        'dgv_2_cuentas.AllowUserToOrderColumns = True
    End Sub
    Private Sub dgv_2_cuentas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_2_cuentas.CellMouseClick
        'Cod_2 = dgv_2_cuentas.CurrentRow.Cells(0).Value.ToString()
        'txt_2_cuenta.Text = dgv_2_cuentas.CurrentRow.Cells(5).Value.ToString()
        'txt_2_descripcion.Text = dgv_2_cuentas.CurrentRow.Cells(6).Value.ToString()
        'sincroniza_local = CInt(dgv_1_faenas.CurrentRow.Cells(1).Value.ToString())
        'version_mod2 = CInt(dgv_1_faenas.CurrentRow.Cells(2).Value.ToString())
        'sincroniza_mod2 = 2
    End Sub
    Private Sub btn_sincronizar_Click(sender As Object, e As EventArgs) Handles btn_sincronizar.Click
        num_tab = 0
        frm_menu_principal.Show()
        Me.Close()
        frm_menu_principal.btn_sincronizar.PerformClick()
    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        num_tab = 1
        Dim consultar As MsgBoxResult
        If consulta_datos <> 0 Then
            consultar = MsgBox("Usted no ha guardado los avances, ¿Desea guardarlos?", MsgBoxStyle.OkCancel, "Confirmar")

            If consultar = MsgBoxResult.Ok Then
                btn_tabla.PerformClick()
            Else
            End If
            frm_menu_principal_II.Show()
            Me.Close()
        ElseIf consulta_datos = 0 Then
            frm_menu_principal_II.Show()
            Me.Close()
        End If

    End Sub
    Private Sub txt_1_rut_GotFocus(sender As Object, e As EventArgs) Handles txt_1_rut.GotFocus
        txt_1_rut.Mask = ""
    End Sub
    Private Sub txt_1_rut_LostFocus(sender As Object, e As EventArgs) Handles txt_1_rut.LostFocus
        Dim rut_ver As String
        rut_ver = Limpiar(txt_1_rut.Text)
        If Len(rut_ver) < 8 Then
            txt_1_rut.Mask = ""
        ElseIf Len(rut_ver) = 9 Then
            txt_1_rut.Mask = "00,000,000->a"
        ElseIf Len(rut_ver) = 8 Then
            txt_1_rut.Mask = "0,000,000->a"
        Else
            txt_1_rut.Mask = ""
            txt_1_rut.Clear()
        End If
    End Sub
    Function Limpiar(ByVal dato As String) As String
        If (dato.Length >= 1) Then
            dato = dato.Trim()
            dato = dato.Replace(" ", String.Empty)
            dato = dato.Replace(".", "")
            dato = dato.Replace("-", "")
            dato = dato.Replace("/", "")
            dato = dato.Replace("_", "")
        End If
        Return dato
    End Function
    Private Sub txt_1_rut_representante_GotFocus(sender As Object, e As EventArgs) Handles txt_1_rut_representante.GotFocus
        txt_1_rut_representante.Mask = ""
    End Sub

    Private Sub txt_1_rut_representante_LostFocus(sender As Object, e As EventArgs) Handles txt_1_rut_representante.LostFocus
        Dim rut_ver As String
        rut_ver = Limpiar(txt_1_rut_representante.Text)
        If Len(rut_ver) < 8 Then
            txt_1_rut_representante.Mask = ""
        ElseIf Len(rut_ver) = 9 Then
            txt_1_rut_representante.Mask = "00,000,000->a"
        ElseIf Len(rut_ver) = 8 Then
            txt_1_rut_representante.Mask = "0,000,000->a"
        Else
            txt_1_rut_representante.Mask = ""
            txt_1_rut_representante.Clear()
        End If
    End Sub

    Public Sub actualiza_arrendador()
        txt_1_razon_social.DataSource = nue_obra1.listar3(id_obra)
        txt_1_razon_social.DisplayMember = "razon_social"
        txt_1_razon_social.ValueMember = "rut"
    End Sub
    Public Sub actualiza_arrendador4()
        cmb_4_subcontrato.DataSource = nue_obra4.listar14(id_obra)
        cmb_4_subcontrato.DisplayMember = "nombre_subcon"
        cmb_4_subcontrato.ValueMember = "rut"
    End Sub
    Public Sub actualiza_arrendador5()
        cmb_5_subcontrato.DataSource = nue_obra5.listar1(id_obra)
        cmb_5_subcontrato.DisplayMember = "nombre_subcon"
        cmb_5_subcontrato.ValueMember = "rut"
    End Sub
    Public Sub actualiza_arrendador6()
        cmb_6_arrendador.DataSource = nue_obra6.listar3(id_obra)
        cmb_6_arrendador.DisplayMember = "razon_social"
        cmb_6_arrendador.ValueMember = "rut"
    End Sub
    Public Sub actualiza_arrendador7()
        cmb_7_arrendador.DataSource = nue_obra7.listar3(id_obra)
        cmb_7_arrendador.DisplayMember = "razon_social"
        cmb_7_arrendador.ValueMember = "rut"
    End Sub
    Public Sub actualiza_arrendador8()
        cmb_8_subcontrato.DataSource = nue_obra5.listar1(id_obra)
        cmb_8_subcontrato.DisplayMember = "nombre_subcon"
        cmb_8_subcontrato.ValueMember = "id_subcontrato"
    End Sub
    Private Sub txt_1_razon_social_TextChanged(sender As Object, e As EventArgs) Handles txt_1_razon_social.TextChanged
        If Len(txt_1_razon_social.Text) > 0 Then
            dgv_arrendador.DataSource = Nothing
            dgv_arrendador.DataSource = nue_obra1.listar4(txt_1_razon_social.Text, id_obra)

            If dgv_arrendador.Rows.Count > 1 Then
                txt_1_rut.Clear()
                txt_1_rut.Enabled = False

                txt_1_domicilio.Clear()
                txt_1_domicilio.Enabled = False

                txt_1_representante.Clear()
                txt_1_representante.Enabled = False

                txt_1_rut_representante.Clear()
                txt_1_rut_representante.Enabled = False

                txt_1_comuna.Clear()
                txt_1_comuna.Enabled = False

                txt_1_ciudad.Clear()
                txt_1_ciudad.Enabled = False

                txt_1_rut.Text = dgv_arrendador.Rows(0).Cells(5).Value.ToString()
                txt_1_domicilio.Text = dgv_arrendador.Rows(0).Cells(6).Value.ToString()
                txt_1_representante.Text = dgv_arrendador.Rows(0).Cells(8).Value.ToString()
                txt_1_rut_representante.Text = dgv_arrendador.Rows(0).Cells(9).Value.ToString()
                Cod_11 = dgv_arrendador.Rows(0).Cells(0).Value.ToString()
                txt_1_ciudad.Text = dgv_arrendador.Rows(0).Cells(11).Value.ToString()
                txt_1_comuna.Text = dgv_arrendador.Rows(0).Cells(10).Value.ToString()

                existe_rut = 0

            Else
                txt_1_rut.Clear()
                txt_1_rut.Enabled = True

                txt_1_domicilio.Clear()
                txt_1_domicilio.Enabled = True

                txt_1_representante.Clear()
                txt_1_representante.Enabled = True

                txt_1_rut_representante.Clear()
                txt_1_rut_representante.Enabled = True

                txt_1_comuna.Clear()
                txt_1_comuna.Enabled = True

                txt_1_ciudad.Clear()
                txt_1_ciudad.Enabled = True

                existe_rut = 1
            End If
        Else
            txt_1_rut.Clear()
            txt_1_rut.Enabled = True

            txt_1_domicilio.Clear()
            txt_1_domicilio.Enabled = True

            txt_1_representante.Clear()
            txt_1_representante.Enabled = True

            txt_1_rut_representante.Clear()
            txt_1_rut_representante.Enabled = True

            txt_1_comuna.Clear()
            txt_1_comuna.Enabled = True

            txt_1_ciudad.Clear()
            txt_1_ciudad.Enabled = True

            existe_rut = 1
        End If
    End Sub
    Private Sub dgv_1_maquinas_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_1_subcontratos.MouseClick
        dgv_1_items.DataSource = nue_obra1.listar2_items(id_obra, dgv_1_subcontratos.CurrentRow.Cells(0).Value.ToString(), dgv_1_subcontratos.CurrentRow.Cells(3).Value.ToString())

        btn_cancelar1.PerformClick()
        btn_cancelar11.PerformClick()

        dgv_datosAgregados1.Rows.Clear()
        dgv_datosAgregados1.Visible = True

        Cod_1 = dgv_1_subcontratos.CurrentRow.Cells(3).Value.ToString()
        sincroniza_local = CInt(dgv_1_subcontratos.CurrentRow.Cells(4).Value.ToString())
        version_mod1 = CInt(dgv_1_subcontratos.CurrentRow.Cells(5).Value.ToString())



        txt_1_razon_social.Text = dgv_1_subcontratos.CurrentRow.Cells(1).Value.ToString()
        txt_1_servicio.Text = dgv_1_subcontratos.CurrentRow.Cells(2).Value.ToString()
        txt_id_subcontrato.Text = dgv_1_subcontratos.CurrentRow.Cells(3).Value.ToString()

        txt_1_plazo_dias.Text = dgv_1_subcontratos.CurrentRow.Cells(9).Value.ToString()
        txt_1_valor_contrato.Text = dgv_1_subcontratos.CurrentRow.Cells(10).Value.ToString()
        txt_1_valor_seguro.Text = dgv_1_subcontratos.CurrentRow.Cells(12).Value.ToString()
        cmb_1_obra.Text = dgv_1_subcontratos.CurrentRow.Cells(8).Value.ToString()

        If dgv_1_items.Rows.Count > 0 Then
            dgv_datosAgregados1.Rows.Add(dgv_1_items.RowCount)
        End If

        sincroniza_mod1 = 2


        If dgv_1_items.RowCount > 0 Then
            For i = 0 To dgv_1_items.Rows.Count - 1

                dgv_datosAgregados1.Rows(i).Cells(0).Value = dgv_1_items.Rows(i).Cells(27).Value.ToString()
                dgv_datosAgregados1.Rows(i).Cells(8).Value = dgv_1_items.Rows(i).Cells(8).Value.ToString()
                dgv_datosAgregados1.Rows(i).Cells(1).Value = dgv_1_items.Rows(i).Cells(13).Value.ToString()
                dgv_datosAgregados1.Rows(i).Cells(2).Value = dgv_1_items.Rows(i).Cells(14).Value.ToString()
                dgv_datosAgregados1.Rows(i).Cells(3).Value = dgv_1_items.Rows(i).Cells(15).Value.ToString()
                dgv_datosAgregados1.Rows(i).Cells(4).Value = dgv_1_items.Rows(i).Cells(16).Value.ToString()

                dgv_datosAgregados1.Rows(i).Cells(6).Value = dgv_1_items.Rows(i).Cells(19).Value.ToString()

                dgv_datosAgregados1.Rows(i).Cells(8).Value = dgv_1_items.Rows(i).Cells(25).Value.ToString()
                dgv_datosAgregados1.Rows(i).Cells(9).Value = dgv_1_items.Rows(i).Cells(26).Value.ToString()
                dgv_datosAgregados1.Rows(i).Cells(10).Value = dgv_1_items.Rows(i).Cells(6).Value.ToString()
            Next i
        End If
    End Sub
    Public Sub actualiza_obras()
        cmb_1_obra.DataSource = nue_obra1.listar5(id_obra)
        cmb_1_obra.DisplayMember = "nombre_faena"
        cmb_1_obra.ValueMember = "nombre_faena"
    End Sub
    'Public Sub actualiza_obras4()
    '    cmb_4_obra.DataSource = nue_obra4.listar5(id_obra)
    '    cmb_4_obra.DisplayMember = "nombre_faena"
    '    cmb_4_obra.ValueMember = "nombre_faena"
    'End Sub
    Public Sub actualiza_obras5()
        cmb_5_obra.DataSource = nue_obra5.listar5(id_obra)
        cmb_5_obra.DisplayMember = "nombre_faena"
        cmb_5_obra.ValueMember = "Id_identificacion"
    End Sub
    Public Sub actualiza_obras6()
        cmb_6_obra.DataSource = nue_obra6.listar5(id_obra)
        cmb_6_obra.DisplayMember = "nombre_faena"
        cmb_6_obra.ValueMember = "nombre_faena"
    End Sub
    Public Sub actualiza_obras7()
        cmb_7_obra.DataSource = nue_obra7.listar5(id_obra)
        cmb_7_obra.DisplayMember = "nombre_faena"
        cmb_7_obra.ValueMember = "Id_identificacion"
    End Sub
    Sub actualizar_dgv()
        Dim fecha_consulta As Date
        Dim fecha_consulta_str As String

        fecha_consulta = CDate("23/" & Month(dtp_fecha.Text) & "/" & Year(dtp_fecha.Text))
        fecha_consulta_str = Format(fecha_consulta, "yyyy/MM/dd")
        'fecha_consulta = Me.dtp_fecha.Value

        dgv_equipos.DataSource = nue_obra2.listar6(fecha_consulta_str, id_obra)
    End Sub
    Private Sub dgv_datosAgregados_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados.CellEndEdit
        If dgv_datosAgregados.Rows.Count > 1 Then
            If e.ColumnIndex = 6 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 7 Then
                If dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value <> "" And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value <> "" And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                ElseIf dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value = "" And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value = "" And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
        End If
    End Sub

    Private Sub dgv_datosAgregados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_datosAgregados.CellFormatting
        Try
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Column2" Then
                Dim valor As String = e.Value
                e.CellStyle.BackColor = Color.LightBlue
            End If
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Column3" Then
                Dim valor As String = e.Value
                e.CellStyle.BackColor = Color.LightBlue
            End If
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Fecha" Then
                Dim valor As String = e.Value
                e.CellStyle.BackColor = Color.LightBlue
            End If
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Column1" Then
                Dim valor As String = e.Value
                e.CellStyle.BackColor = Color.LightBlue
            End If
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Column4" Then
                Dim valor As String = e.Value
                e.CellStyle.BackColor = Color.LightBlue
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Tipo_horometro(ByVal fila As Integer)
        For index As Integer = 0 To dgv_datosAgregados.RowCount - 1
            If (fila = dgv_datosAgregados.Rows(index).Cells(0).Value) Then
                dgv_datosAgregados.Rows(index).DefaultCellStyle.BackColor = Color.Yellow
                Exit For
            End If
        Next
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles btn_fecha.Click
        Dim consultar As MsgBoxResult
        If consulta_datos_local <> 0 Then
            consultar = MsgBox("Usted no ha guardado los avances, ¿Desea guardarlos?", MsgBoxStyle.OkCancel, "Confirmar")

            If consultar = MsgBoxResult.Ok Then
                btn_tabla.PerformClick()
            Else
            End If
            actualizar_dgv()
            actualiza_columnas()
            consulta_datos = 1
            consulta_datos_local = 1
        ElseIf consulta_datos_local = 0 Then
            actualizar_dgv()
            actualiza_columnas()
            consulta_datos = 1
            consulta_datos_local = 1
        End If
    End Sub

    Private Sub btn_equipo_Click(sender As Object, e As EventArgs) Handles btn_equipo.Click
        Dim consultar As MsgBoxResult
        If consulta_datos_local <> 0 Then
            consultar = MsgBox("Usted no ha guardado los avances, ¿Desea guardarlos?", MsgBoxStyle.OkCancel, "Confirmar")

            If consultar = MsgBoxResult.Ok Then
                btn_tabla.PerformClick()
            Else
            End If
            actualizar_dgv_equipo()
            actualiza_columnas()
            consulta_datos = 2
            consulta_datos_local = 2
        ElseIf consulta_datos_local = 0 Then
            actualizar_dgv_equipo()
            actualiza_columnas()
            consulta_datos = 2
            consulta_datos_local = 2
        End If
    End Sub
    Sub actualizar_dgv_equipo()
        Dim fecha_consulta1_1, fecha_consulta2_1, fecha_consulta3_1 As Date
        Dim fecha_consulta_str1, fecha_consulta_str2, fecha_consulta_str3, servicio As String
        Dim rtn1, rtn2, rtn3 As New Date

        rtn1 = Date.Now
        rtn1 = rtn1.AddMonths(-1)

        rtn2 = Date.Now

        rtn3 = Date.Now
        rtn3 = rtn3.AddMonths(+1)

        fecha_consulta1_1 = CDate("23/" & Month(rtn1) & "/" & Year(rtn1))
        fecha_consulta2_1 = CDate("23/" & Month(rtn2) & "/" & Year(rtn2))
        fecha_consulta3_1 = CDate("23/" & Month(rtn3) & "/" & Year(rtn3))

        fecha_consulta_str1 = Format(fecha_consulta1_1, "yyyy/MM/dd")
        fecha_consulta_str2 = Format(fecha_consulta2_1, "yyyy/MM/dd")
        fecha_consulta_str3 = Format(fecha_consulta3_1, "yyyy/MM/dd")

        Dim Cadena As String = cmb_2_subcontrato.Text
        Dim ArrCadena As String() = Cadena.Split("/")
        servicio = ArrCadena(1)

        dgv_equipos.DataSource = nue_obra2.listar7(fecha_consulta_str1, fecha_consulta_str2, fecha_consulta_str3, id_obra, cmb_2_subcontrato.SelectedValue.ToString(), servicio)
    End Sub
    Sub actualiza_columnas()
        dgv_datosAgregados.Rows.Clear()
        Dim cantDatosAgregados As Integer = dgv_datosAgregados.RowCount - 1
        If dgv_equipos.Rows.Count > 1 Then
            dgv_datosAgregados.Rows.Add(dgv_equipos.Rows.Count - 1)
            For i = 0 To dgv_equipos.Rows.Count - 2
                dgv_datosAgregados.Rows(i).Cells(0).Value = dgv_equipos.Rows(i).Cells(0).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(1).Value = dgv_equipos.Rows(i).Cells(1).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(2).Value = dgv_equipos.Rows(i).Cells(2).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(3).Value = dgv_equipos.Rows(i).Cells(3).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(4).Value = dgv_equipos.Rows(i).Cells(4).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(5).Value = dgv_equipos.Rows(i).Cells(5).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(6).Value = dgv_equipos.Rows(i).Cells(6).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(7).Value = dgv_equipos.Rows(i).Cells(7).Value.ToString()
                'dgv_datosAgregados.Rows(i).Cells(8).Value = dgv_equipos.Rows(i).Cells(8).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(9).Value = dgv_equipos.Rows(i).Cells(9).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(10).Value = dgv_equipos.Rows(i).Cells(14).Value.ToString()
            Next i
        End If



        'For Each r As DataGridViewRow In dgv_datosAgregados.Rows
        '    If r.Cells(3).Value.ToString = "No Tiene" Then
        '        r.Cells(7).ReadOnly = True
        '        r.Cells(7).Style.BackColor = Color.Gray
        '        r.Cells(8).ReadOnly = True
        '        r.Cells(8).Style.BackColor = Color.Gray
        '        r.Cells(9).ReadOnly = True
        '        r.Cells(9).Style.BackColor = Color.Gray
        '        r.Cells(10).ReadOnly = False
        '        r.Cells(10).Style.BackColor = Color.White
        '    Else
        '        r.Cells(7).ReadOnly = False
        '        r.Cells(7).Style.BackColor = Color.White
        '        r.Cells(8).ReadOnly = False
        '        r.Cells(8).Style.BackColor = Color.White
        '        r.Cells(9).ReadOnly = False
        '        r.Cells(9).Style.BackColor = Color.White
        '        r.Cells(10).ReadOnly = True
        '        r.Cells(10).Style.BackColor = Color.Gray
        '    End If
        'Next

        'For Each r As DataGridViewRow In dgv_datosAgregados.Rows
        '    If r.Cells(4).Value.ToString = "Hora" Or r.Cells(4).Value.ToString = "Mes" Or r.Cells(4).Value.ToString = "Día" Then
        '        r.Cells(11).ReadOnly = True
        '        r.Cells(11).Style.BackColor = Color.Gray
        '        r.Cells(12).ReadOnly = True
        '        r.Cells(12).Style.BackColor = Color.Gray
        '    ElseIf r.Cells(4).Value.ToString = "M3-KM" Then
        '        r.Cells(11).ReadOnly = True
        '        r.Cells(11).Style.BackColor = Color.Gray
        '        r.Cells(12).ReadOnly = False
        '        r.Cells(12).Style.BackColor = Color.White
        '    ElseIf r.Cells(4).Value.ToString = "M3" Then
        '        r.Cells(12).ReadOnly = True
        '        r.Cells(12).Style.BackColor = Color.Gray
        '        r.Cells(11).ReadOnly = False
        '        r.Cells(11).Style.BackColor = Color.White
        '    Else
        '        r.Cells(11).ReadOnly = False
        '        r.Cells(11).Style.BackColor = Color.White
        '        r.Cells(12).ReadOnly = False
        '        r.Cells(12).Style.BackColor = Color.White
        '    End If
        'Next

        If sincroniza = 1 Then
            For Each r As DataGridViewRow In dgv_datosAgregados.Rows
                If IsNumeric(r.Cells(0).Value.ToString) Then
                    r.Cells(6).ReadOnly = True
                    r.Cells(6).Style.BackColor = Color.Gray
                    r.Cells(7).ReadOnly = True
                    r.Cells(7).Style.BackColor = Color.Gray
                End If
            Next
        End If
    End Sub
    Public Sub actualiza_equipos()
        cmb_2_subcontrato.DataSource = nue_obra2.listar2(id_obra)
        cmb_2_subcontrato.DisplayMember = "nombre_subcon"
        cmb_2_subcontrato.ValueMember = "rut"
    End Sub
    Public Sub actualiza_cuentas_maquinaria()
        Column17.DataSource = nue_obra1.listar6(id_obra)
        Column17.DisplayMember = "Cuenta_costo"
        Column17.ValueMember = "Cuenta_costo"
    End Sub
    Private Sub dgv_datosAgregados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados.CellValueChanged
        If dgv_datosAgregados.Rows.Count > 1 Then
            If Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value) Then
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value = ""
            End If
        End If
    End Sub

    Private Sub btn_tabla_Click(sender As Object, e As EventArgs) Handles btn_tabla.Click

        If dgv_datosAgregados.Rows.Count > 0 Then
            For i = 0 To dgv_datosAgregados.Rows.Count - 1
                Dim fecha As Date
                Dim avance As Double
                Dim total_contratado, total_avance As Double
                Dim obs As String
                Dim id, id_subcontrato As Integer

                If IsNumeric(dgv_datosAgregados.Rows(i).Cells(8).Value) Then
                    fecha = CDate(dgv_datosAgregados.Rows(i).Cells(4).Value.ToString())

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(6).Value.ToString()) Then
                        avance = CDbl(dgv_datosAgregados.Rows(i).Cells(6).Value.ToString())
                    Else
                        avance = 0
                    End If

                    If IsNothing(dgv_datosAgregados.Rows(i).Cells(7).Value) Then
                        obs = ""
                    Else
                        obs = dgv_datosAgregados.Rows(i).Cells(7).Value.ToString()
                    End If

                    id_subcontrato = CInt(dgv_datosAgregados.Rows(i).Cells(9).Value.ToString())
                    MsgBox(id_subcontrato)

                    total_contratado = nue_obra2.total_contratado(id_obra, id_subcontrato)
                    total_contratado = CDbl(total_contratado)

                    If dgv_datosAgregados.Rows(i).Cells(8).Value.ToString() = 1 Then
                        total_avance = nue_obra2.total_avance(id_obra, id_subcontrato)
                    ElseIf dgv_datosAgregados.Rows(i).Cells(8).Value.ToString() = 2 Then
                        id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                        total_avance = nue_obra2.total_avance_mod(id_obra, id_subcontrato)
                    End If

                    total_avance = total_avance + avance
                    total_avance = CDbl(total_avance)

                    If total_contratado >= total_avance Then
                        If dgv_datosAgregados.Rows(i).Cells(8).Value.ToString() = 1 Then
                            nue_obra2.insertar_report(1, 0, Nombre_Obra, id_obra, id_subcontrato, fecha, "", "", "", avance, "", obs)

                        ElseIf dgv_datosAgregados.Rows(i).Cells(8).Value.ToString() = 2 Then
                            id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                            version_mod2 = CInt(dgv_datosAgregados.Rows(i).Cells(10).Value.ToString()) + 1
                            nue_obra2.modificar_report(CInt(id), 2, version_mod2, Nombre_Obra, id_obra, id_subcontrato, fecha, "", "", "", avance, "", obs)
                        End If
                    Else

                        MsgBox("TOTAL AVANCE (" & total_avance & ") ES MAYOR QUE EL TOTAL CONTRATADO (" & total_contratado & ") PARA EL ÍTEM " + dgv_datosAgregados.Rows(i).Cells(3).Value.ToString() + " DEL SUBCONTRATO " + dgv_datosAgregados.Rows(i).Cells(2).Value.ToString())
                    End If
                End If
            Next i

            actualizar_dgv()
            actualiza_columnas()

            consulta_datos = 0
            consulta_datos_local = 0
            MsgBox("DATOS REGISTRADOS EXITOSAMENTE")

        Else
            MsgBox("NO FUERON ENCONTRADOS DATOS RELEVANTES")
        End If

    End Sub
    Sub actualizar_dgv3()
        dgv_3_trabajos_adicionales.DataSource = nue_obra3.listar(id_obra)
        dgv_3_trabajos_adicionales.Columns(0).Visible = False
        dgv_3_trabajos_adicionales.Columns(1).Visible = False
        dgv_3_trabajos_adicionales.Columns(2).Visible = False
        dgv_3_trabajos_adicionales.Columns(3).Visible = False
        dgv_3_trabajos_adicionales.Columns(4).Visible = False
        dgv_3_trabajos_adicionales.Columns(5).HeaderText = "Subcontratista"
        dgv_3_trabajos_adicionales.Columns(5).Width = 200
        dgv_3_trabajos_adicionales.Columns(6).HeaderText = "Subcontrato"
        dgv_3_trabajos_adicionales.Columns(6).Width = 200
        dgv_3_trabajos_adicionales.Columns(7).Visible = False
        dgv_3_trabajos_adicionales.Columns(8).HeaderText = "Clasificación"
        dgv_3_trabajos_adicionales.Columns(8).Width = 130
        dgv_3_trabajos_adicionales.Columns(9).HeaderText = "Descripción"
        dgv_3_trabajos_adicionales.Columns(9).Width = 200
        dgv_3_trabajos_adicionales.Columns(10).HeaderText = "Cant."
        dgv_3_trabajos_adicionales.Columns(10).Width = 40
        dgv_3_trabajos_adicionales.Columns(10).DefaultCellStyle.Format = "##,###.##"
        dgv_3_trabajos_adicionales.Columns(11).Visible = False
        dgv_3_trabajos_adicionales.Columns(12).HeaderText = "Precio Unitario"
        dgv_3_trabajos_adicionales.Columns(12).Width = 100
        dgv_3_trabajos_adicionales.Columns(12).DefaultCellStyle.Format = "##,###.##"
        dgv_3_trabajos_adicionales.Columns(13).HeaderText = "Total"
        dgv_3_trabajos_adicionales.Columns(13).Width = 100
        dgv_3_trabajos_adicionales.Columns(13).DefaultCellStyle.Format = "##,###.##"
        dgv_3_trabajos_adicionales.Columns(14).Visible = False
        dgv_3_trabajos_adicionales.Columns(15).HeaderText = "Fecha"
        dgv_3_trabajos_adicionales.Columns(15).Width = 100

        dgv_3_trabajos_adicionales.AllowUserToOrderColumns = True
    End Sub


    Private Sub txt_3_precio_TextChanged(sender As Object, e As EventArgs) Handles txt_3_precio.TextChanged
        Dim total As Double
        If Not IsNumeric(txt_3_precio.Text) Then
            txt_3_precio.Clear()
            txt_3_total.Clear()
        End If
        If IsNumeric(txt_3_precio.Text) And IsNumeric(txt_3_cantidad.Text) Then

            txt_3_total.Text = txt_3_precio.Text * txt_3_cantidad.Text
            total = txt_3_total.Text
            txt_3_total.Text = FormatNumber(total, 0)
        End If

    End Sub

    Private Sub txt_3_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_3_cantidad.TextChanged
        Dim total As Double
        If Not IsNumeric(txt_3_cantidad.Text) Then
            txt_3_cantidad.Clear()
            txt_3_total.Clear()
        End If
        If IsNumeric(txt_3_precio.Text) And IsNumeric(txt_3_cantidad.Text) Then

            txt_3_total.Text = txt_3_precio.Text * txt_3_cantidad.Text
            total = txt_3_total.Text
            txt_3_total.Text = FormatNumber(total, 0)
        End If
    End Sub

    Private Sub dgv_3_trabajos_adicionales_CellStyleContentChanged(sender As Object, e As DataGridViewCellStyleContentChangedEventArgs) Handles dgv_3_trabajos_adicionales.CellStyleContentChanged

    End Sub

    Private Sub dgv_3_trabajos_adicionales_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_3_trabajos_adicionales.MouseClick
        Cod_3 = dgv_3_trabajos_adicionales.CurrentRow.Cells(0).Value.ToString()


        cmb_3_subcontrato.SelectedValue = dgv_3_trabajos_adicionales.CurrentRow.Cells(7).Value.ToString()
        cmb_3_clasificacion.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(8).Value.ToString()
        txt_3_descripcion.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(9).Value.ToString()
        txt_3_cantidad.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(10).Value.ToString()
        cmb_3_un_pago.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(11).Value.ToString()
        txt_3_precio.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(12).Value.ToString()
        txt_3_total.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(13).Value.ToString()
        cmb_3_cuenta_contable.SelectedValue = dgv_3_trabajos_adicionales.CurrentRow.Cells(14).Value.ToString()
        dtp_3_fecha.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(15).Value.ToString()

        txt_3_total.Text = FormatNumber(txt_3_total.Text, 0)
        sincroniza_local3 = CInt(dgv_3_trabajos_adicionales.CurrentRow.Cells(1).Value.ToString())
        version_mod3 = CInt(dgv_3_trabajos_adicionales.CurrentRow.Cells(2).Value.ToString())
        sincroniza_mod3 = 2
    End Sub
    Public Sub actualiza_cuentas_trabajo()
        cmb_3_cuenta_contable.DataSource = nue_obra3.listar6(id_obra)
        cmb_3_cuenta_contable.DisplayMember = "cuenta_desc"
        cmb_3_cuenta_contable.ValueMember = "Cuenta_costo"
    End Sub

    Public Sub actualiza_arrendador3()
        cmb_3_subcontrato.DataSource = nue_obra3.listar2(id_obra)
        cmb_3_subcontrato.DisplayMember = "nombre_subcon"
        cmb_3_subcontrato.ValueMember = "rut"
    End Sub

    Private Sub btn_4_generar_Click(sender As Object, e As EventArgs) Handles btn_4_generar.Click
        If txt_4_lugar.Text <> "" And cmb_4_obra.Text <> "" And cmb_4_subcontrato.Text <> "" Then
            If dgv_4_equipos.Rows.Count > 0 Then
                Genera_word()
            Else
                MessageBox.Show("FALTAN DATOS PARA GENERAR EL CONTRATO")
            End If
        Else
            MessageBox.Show("FALTAN DATOS PARA GENERAR EL CONTRATO")
        End If
    End Sub
    Public Sub actualizar_check()
        Dim subcontratista4 As String
        Dim subcontrato4 As String

        Dim Cadena4 As String = cmb_4_subcontrato.Text
        Dim ArrCadena4 As String() = Cadena4.Split("/")

        subcontratista4 = ArrCadena4(0)
        subcontrato4 = ArrCadena4(1)

        dgv_4_equipos.DataSource = nue_obra4.listar2(id_obra, cmb_4_subcontrato.SelectedValue.ToString(), subcontrato4)
        cmb_4_obra.Text = dgv_4_equipos.Rows(0).Cells(32).Value.ToString()
    End Sub
    Public Sub actualizar_check2()
        'Dim equipo As String
        'Dim operador As String
        'If cmb_5_operador.Text = "Con Operador" Then
        '    operador = "Si"
        'Else
        '    operador = "No"
        'End If
        'check_5_empresa.Items.Clear()
        'dgv_5_equipos.DataSource = nue_obra5.listar2(id_obra, cmb_5_tipo_pago.Text, operador, cmb_5_obra.Text, cmb_5_arrendador.SelectedValue.ToString())

        'If dgv_5_equipos.Rows.Count > 0 Then
        '    For i = 0 To dgv_5_equipos.Rows.Count - 2
        '        equipo = dgv_5_equipos.Rows(i).Cells(6).Value.ToString()
        '        check_5_empresa.Items.Add(equipo)
        '    Next i
        'End If
    End Sub
    Public Sub actualizar_check6()
        Dim equipo As String
        Dim operador As String
        If cmb_6_operador.Text = "Con Operador" Then
            operador = "Si"
        Else
            operador = "No"
        End If
        check_6_empresa.Items.Clear()
        dgv_6_equipos.DataSource = nue_obra6.listar2(id_obra, cmb_6_tipo_pago.Text, operador, cmb_6_obra.Text, cmb_6_arrendador.SelectedValue.ToString())

        If dgv_6_equipos.Rows.Count > 0 Then
            For i = 0 To dgv_6_equipos.Rows.Count - 2
                equipo = dgv_6_equipos.Rows(i).Cells(6).Value.ToString()
                check_6_empresa.Items.Add(equipo)
            Next i
        End If
    End Sub
    Public Sub actualizar_check7()
        Dim equipo As String
        Dim operador As String
        If cmb_7_operador.Text = "Con Operador" Then
            operador = "Si"
        Else
            operador = "No"
        End If
        check_7_empresa.Items.Clear()
        dgv_7_equipos.DataSource = nue_obra7.listar2(id_obra, cmb_7_tipo_pago.Text, operador, cmb_7_obra.Text, cmb_7_arrendador.SelectedValue.ToString())

        If dgv_7_equipos.Rows.Count > 0 Then
            For i = 0 To dgv_7_equipos.Rows.Count - 2
                equipo = dgv_7_equipos.Rows(i).Cells(6).Value.ToString()
                check_7_empresa.Items.Add(equipo)
            Next i
        End If
    End Sub
    Public Sub Genera_word()
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim ruta_destino As String
        Dim extension_destino As String

        If SaveFileDialog2.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ruta_destino = SaveFileDialog2.FileName
            extension_destino = System.IO.Path.GetExtension(SaveFileDialog2.FileName)

            FileCopy("C:\ArchivosProgramaFV\Contrato_subcontratos\Contrato_subcontrato.doc", ruta_destino & extension_destino)
            Documento = MSWord.Documents.Open(ruta_destino & extension_destino)



            Documento.Bookmarks.Item("razon_social").Range.Text = dgv_4_equipos.Rows(0).Cells(16).Value.ToString()
            Documento.Bookmarks.Item("razon2").Range.Text = dgv_4_equipos.Rows(0).Cells(16).Value.ToString()
            Documento.Bookmarks.Item("representante").Range.Text = dgv_4_equipos.Rows(0).Cells(17).Value.ToString()
            Documento.Bookmarks.Item("representante2").Range.Text = dgv_4_equipos.Rows(0).Cells(17).Value.ToString()
            Documento.Bookmarks.Item("rut_razon").Range.Text = dgv_4_equipos.Rows(0).Cells(14).Value.ToString()
            Documento.Bookmarks.Item("rut_razon2").Range.Text = dgv_4_equipos.Rows(0).Cells(14).Value.ToString()
            Documento.Bookmarks.Item("rut_representante").Range.Text = dgv_4_equipos.Rows(0).Cells(18).Value.ToString()
            Documento.Bookmarks.Item("rut_representante2").Range.Text = dgv_4_equipos.Rows(0).Cells(18).Value.ToString()

            Documento.Bookmarks.Item("porcentaje_garantia").Range.Text = dgv_4_equipos.Rows(0).Cells(35).Value.ToString()
            Documento.Bookmarks.Item("cantidad_garantia").Range.Text = dgv_4_equipos.Rows(0).Cells(36).Value.ToString()
            Documento.Bookmarks.Item("ciudad").Range.Text = dgv_4_equipos.Rows(0).Cells(20).Value.ToString()
            Documento.Bookmarks.Item("comuna").Range.Text = dgv_4_equipos.Rows(0).Cells(19).Value.ToString()
            Documento.Bookmarks.Item("detalle_obra").Range.Text = dgv_4_equipos.Rows(0).Cells(13).Value.ToString()
            Documento.Bookmarks.Item("domicilio").Range.Text = dgv_4_equipos.Rows(0).Cells(15).Value.ToString()
            Documento.Bookmarks.Item("fecha").Range.Text = dtp_4_fecha_cel.Text
            Documento.Bookmarks.Item("fecha_resolucion").Range.Text = dgv_4_equipos.Rows(0).Cells(8).Value.ToString()
            Documento.Bookmarks.Item("gerente_cargo").Range.Text = dgv_4_equipos.Rows(0).Cells(5).Value.ToString()
            Documento.Bookmarks.Item("Lugar").Range.Text = txt_4_lugar.Text
            Documento.Bookmarks.Item("num_resolucion").Range.Text = dgv_4_equipos.Rows(0).Cells(7).Value.ToString()
            Documento.Bookmarks.Item("obra_servicio").Range.Text = dgv_4_equipos.Rows(0).Cells(26).Value.ToString()
            Documento.Bookmarks.Item("plazo1").Range.Text = dgv_4_equipos.Rows(0).Cells(34).Value.ToString()
            Documento.Bookmarks.Item("porcentaje_responsabilidad").Range.Text = dgv_4_equipos.Rows(0).Cells(37).Value.ToString()

            contador = dgv_4_equipos.Rows.Count - 1

            Documento.Bookmarks.Item("item1").Range.Text = dgv_4_equipos.Rows(1).Cells(27).Value.ToString()
            Documento.Bookmarks.Item("precio1").Range.Text = dgv_4_equipos.Rows(1).Cells(29).Value.ToString()
            Documento.Bookmarks.Item("cantidad1").Range.Text = dgv_4_equipos.Rows(1).Cells(30).Value.ToString()
            Documento.Bookmarks.Item("total1").Range.Text = dgv_4_equipos.Rows(1).Cells(31).Value.ToString()


            If contador >= 2 Then
                Documento.Bookmarks.Item("item2").Range.Text = dgv_4_equipos.Rows(1).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("precio2").Range.Text = dgv_4_equipos.Rows(1).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("cantidad2").Range.Text = dgv_4_equipos.Rows(1).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("total2").Range.Text = dgv_4_equipos.Rows(1).Cells(31).Value.ToString()
            End If

            If contador >= 3 Then
                Documento.Bookmarks.Item("item3").Range.Text = dgv_4_equipos.Rows(1).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("precio3").Range.Text = dgv_4_equipos.Rows(1).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("cantidad3").Range.Text = dgv_4_equipos.Rows(1).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("total3").Range.Text = dgv_4_equipos.Rows(1).Cells(31).Value.ToString()
            End If

            If contador >= 4 Then
                Documento.Bookmarks.Item("item4").Range.Text = dgv_4_equipos.Rows(1).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("precio4").Range.Text = dgv_4_equipos.Rows(1).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("cantidad4").Range.Text = dgv_4_equipos.Rows(1).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("total4").Range.Text = dgv_4_equipos.Rows(1).Cells(31).Value.ToString()
            End If

            If contador >= 5 Then
                Documento.Bookmarks.Item("item5").Range.Text = dgv_4_equipos.Rows(1).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("precio5").Range.Text = dgv_4_equipos.Rows(1).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("cantidad5").Range.Text = dgv_4_equipos.Rows(1).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("total5").Range.Text = dgv_4_equipos.Rows(1).Cells(31).Value.ToString()
            End If

            If contador >= 6 Then
                Documento.Bookmarks.Item("item6").Range.Text = dgv_4_equipos.Rows(1).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("precio6").Range.Text = dgv_4_equipos.Rows(1).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("cantidad6").Range.Text = dgv_4_equipos.Rows(1).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("total6").Range.Text = dgv_4_equipos.Rows(1).Cells(31).Value.ToString()
            End If

            If contador >= 7 Then
                Documento.Bookmarks.Item("item7").Range.Text = dgv_4_equipos.Rows(1).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("precio7").Range.Text = dgv_4_equipos.Rows(1).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("cantidad7").Range.Text = dgv_4_equipos.Rows(1).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("total7").Range.Text = dgv_4_equipos.Rows(1).Cells(31).Value.ToString()
            End If

            Documento.Save()
            Documento.Close()
            MsgBox("DOCUMENTO GENERADO SATISFACTORIAMENTE")
            'MSWord.Visible = True
        End If
    End Sub

    Private Sub cmb_4_tipo_pago_TextChanged(sender As Object, e As EventArgs)
        If cmb_4_subcontrato.Text <> "" And cmb_4_obra.Text <> "" Then
            actualizar_check()
        End If
    End Sub
    Sub actualizar_adjunto()
        Dim ruta1 As String
        'Dim extension1 As String

        SaveFileDialog1.FileName = "C:\ArchivosProgramaFV\Contrato_subcontratos\Contrato_subcontrato.doc"
        ruta1 = SaveFileDialog1.FileName
        My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contrato_subcontratos/Contrato_subcontrato.doc", ruta1, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

        MsgBox("SINCRONIZACIÓN DE DOCUMENTO REALIZADA SATISFACTORIAMENTE")
    End Sub

    Private Sub txt_4_contrato_TextChanged(sender As Object, e As EventArgs) Handles txt_5_contrato.TextChanged
        If Not IsNumeric(txt_5_contrato.Text) Then
            txt_5_contrato.Clear()
        End If
    End Sub
    Private Sub ComboBox1_TextChanged1(sender As Object, e As EventArgs)
        If cmb_4_subcontrato.Text <> "" And cmb_4_obra.Text <> "" Then
            actualizar_check()
        End If
    End Sub

    Private Sub cmb_4_arrendador_TextChanged(sender As Object, e As EventArgs) Handles cmb_4_subcontrato.TextChanged
        If cmb_4_subcontrato.Text <> "" And activa4 = 1 Then
            actualizar_check()
        End If
    End Sub
    Private Sub btn_4_sincronizar_Click(sender As Object, e As EventArgs) Handles btn_4_sincronizar.Click
        actualizar_adjunto()
    End Sub

    Private Sub cmb_3_un_pago_TextChanged(sender As Object, e As EventArgs) Handles cmb_3_un_pago.TextChanged
        If cmb_3_un_pago.Text = "Global" Then
            txt_3_cantidad.Text = 1
        ElseIf cmb_3_un_pago.Text = "Unitario" And txt_3_cantidad.Text = "1" Then
            txt_3_cantidad.Clear()
        Else
        End If
    End Sub
    Private Sub cmb_6_arrendador_TextChanged(sender As Object, e As EventArgs) Handles cmb_6_arrendador.TextChanged
        If cmb_6_tipo_pago.Text <> "" And cmb_6_obra.Text <> "" And cmb_6_operador.Text <> "" Then
            actualizar_check6()
        End If
    End Sub

    Private Sub cmb_6_tipo_pago_TextChanged(sender As Object, e As EventArgs) Handles cmb_6_tipo_pago.TextChanged
        If cmb_6_operador.Text <> "" And cmb_6_arrendador.Text <> "" And cmb_6_obra.Text <> "" Then
            actualizar_check6()
        End If
    End Sub

    Private Sub cmb_6_operador_TextChanged(sender As Object, e As EventArgs) Handles cmb_6_operador.TextChanged
        If cmb_6_tipo_pago.Text <> "" And cmb_6_arrendador.Text <> "" And cmb_6_obra.Text <> "" Then
            actualizar_check6()
        End If
    End Sub

    Private Sub cmb_6_obra_TextChanged(sender As Object, e As EventArgs) Handles cmb_6_obra.TextChanged
        If cmb_6_tipo_pago.Text <> "" And cmb_6_arrendador.Text <> "" And cmb_6_operador.Text <> "" Then
            actualizar_check6()
        End If
    End Sub

    Private Sub cmb_7_arrendador_TextChanged(sender As Object, e As EventArgs) Handles cmb_7_arrendador.TextChanged
        If cmb_7_tipo_pago.Text <> "" And cmb_7_obra.Text <> "" And cmb_7_operador.Text <> "" Then
            actualizar_check7()
        End If
    End Sub

    Private Sub cmb_7_tipo_pago_TextChanged(sender As Object, e As EventArgs) Handles cmb_7_tipo_pago.TextChanged
        If cmb_7_operador.Text <> "" And cmb_7_arrendador.Text <> "" And cmb_7_obra.Text <> "" Then
            actualizar_check7()
        End If
    End Sub

    Private Sub cmb_7_operador_TextChanged(sender As Object, e As EventArgs) Handles cmb_7_operador.TextChanged
        If cmb_7_tipo_pago.Text <> "" And cmb_7_arrendador.Text <> "" And cmb_7_obra.Text <> "" Then
            actualizar_check7()
        End If
    End Sub

    Private Sub cmb_7_obra_TextChanged(sender As Object, e As EventArgs) Handles cmb_7_obra.TextChanged
        If cmb_6_tipo_pago.Text <> "" And cmb_7_arrendador.Text <> "" And cmb_7_operador.Text <> "" Then
            actualizar_check7()
        End If
    End Sub

    Private Sub txt_1_capacidad_TextChanged(sender As Object, e As EventArgs) Handles txt_1_capacidad.TextChanged
        If txt_1_servicio.Text = "M3-KM" And Not IsNumeric(txt_1_capacidad.Text) Then
            txt_1_capacidad.Clear()
            MsgBox("Para el tipo de pago seleccionado tiene que agregar una capacidad sólo en formato numérico.")
        End If
    End Sub
    Sub actualizar_5_adjuntos()
        dgv_5_empresa.DataSource = nue_obra5.listar14(id_obra)
        dgv_5_empresa.Columns(0).Visible = False
        dgv_5_empresa.Columns(1).Visible = False
        dgv_5_empresa.Columns(2).Visible = False
        dgv_5_empresa.Columns(3).Visible = False
        dgv_5_empresa.Columns(4).Visible = False
        dgv_5_empresa.Columns(5).HeaderText = "Subcontratista"
        dgv_5_empresa.Columns(5).Width = 120
        dgv_5_empresa.Columns(6).HeaderText = "Subcontrato"
        dgv_5_empresa.Columns(6).Width = 120
        dgv_5_empresa.Columns(7).HeaderText = "Número Contrato"
        dgv_5_empresa.Columns(7).Width = 80
        dgv_5_empresa.Columns(8).HeaderText = "Adjunto"
        dgv_5_empresa.Columns(8).Width = 80
        dgv_5_empresa.Columns(9).HeaderText = "Usuario"
        dgv_5_empresa.Columns(9).Width = 80
        dgv_5_empresa.Columns(10).HeaderText = "Fecha"
        dgv_5_empresa.Columns(10).Width = 100
        dgv_5_empresa.Columns(11).HeaderText = "Hora"
        dgv_5_empresa.Columns(11).Width = 80
        dgv_5_empresa.Columns(12).Visible = False
        dgv_5_empresa.Columns(13).Visible = False
        dgv_5_empresa.Columns(14).Visible = False
        dgv_5_empresa.Columns(15).Visible = False
        dgv_5_empresa.Columns(16).Visible = False
        dgv_5_empresa.AllowUserToOrderColumns = True
    End Sub
    Private Sub btn_5_ingresar_Click(sender As Object, e As EventArgs) Handles btn_5_ingresar.Click
        If cmb_5_obra.Visible = True Then
            Dim verificar As Integer
            Dim verificar2 As Integer
            Dim verificar3 As Integer
            Dim subcontratista, subcontrato As String
            verificar = 0
            verificar2 = 0
            verificar3 = 0

            For l = 0 To dgv_5_empresa.Rows.Count - 1
                Dim Cadena As String = cmb_5_subcontrato.Text
                Dim ArrCadena As String() = Cadena.Split("/")
                subcontratista = ArrCadena(0)
                subcontrato = ArrCadena(1)

                If txt_5_contrato.Text = dgv_5_empresa.Rows(l).Cells(7).Value.ToString() And dgv_5_empresa.Rows(l).Cells(8).Value.ToString() <> "" Then
                    verificar2 = 1
                ElseIf subcontrato = dgv_5_empresa.Rows(l).Cells(6).Value.ToString() And dgv_5_empresa.Rows(l).Cells(8).Value.ToString() <> "" Then
                    verificar3 = 1
                End If
            Next l

            If txt_5_contrato.Text <> "" Then
                If verificar2 = 1 Then
                    MessageBox.Show("EL N° DE CONTRATO " & txt_5_contrato.Text & " YA ESTA ADJUNTADO")
                Else
                    If verificar3 = 1 Then
                        MessageBox.Show("YA HAY UN CONTRATO ADJUNTO AL SUBCONTRATO SELECCIONADO")
                    Else
                        extrae_datos2()
                        actualizar_5_adjuntos()
                        txt_5_contrato.Clear()
                    End If
                End If
            Else
                MessageBox.Show("FALTAN DATOS PARA INGRESAR EL CONTRATO")
            End If
        Else
            MessageBox.Show("LA OBRA TIENE QUE ESTAR VISIBLE")
        End If
    End Sub
    Public Sub extrae_datos2()
        Dim ruta As String
        Dim nombre As String
        Dim extension As String
        Dim subcontratista, subcontrato As String

        If OpenFileDialog2.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ruta = OpenFileDialog2.FileName
            nombre = txt_5_contrato.Text & "-" & id_obra
            'extension = System.IO.Path.GetExtension(OpenFileDialog2.FileName)
            extension = ".pdf"

            My.Computer.Network.UploadFile(ruta, "ftp://cfv%2540constructorafv.com@201.148.105.75/Subcontratos_adjuntos/" & nombre & extension & "", "cfv@constructorafv.com", "gsolis2013", True, 500)
            MessageBox.Show("Contrato adjunto")

            contador = 0

            Dim Cadena As String = cmb_5_subcontrato.Text
            Dim ArrCadena As String() = Cadena.Split("/")
            subcontratista = ArrCadena(0)
            subcontrato = ArrCadena(1)

            nue_obra5.insertar(1, 0, Nombre_Obra, id_obra, subcontratista, subcontrato, CInt(txt_5_contrato.Text), "SI", Nombre_Usuario, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), cmb_5_obra.SelectedValue.ToString(), cmb_5_obra.Text, "", CDate(txt_fecha_act.Text), cmb_5_subcontrato.SelectedValue.ToString())
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txt_fecha_act.Text = Today
        Me.txt_hora.Text = TimeOfDay
        Me.txt_fecha_act7.Text = Today
        Me.txt_hora7.Text = TimeOfDay
    End Sub

    Private Sub dgv_5_empresa_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_5_empresa.MouseClick
        If IsNumeric(dgv_5_empresa.CurrentRow.Cells(0).Value.ToString()) Then
            Cod_5 = dgv_5_empresa.CurrentRow.Cells(0).Value.ToString()
            txt_5_contrato2.Text = dgv_5_empresa.CurrentRow.Cells(7).Value.ToString()
            txt_5_subcontrato2.Text = dgv_5_empresa.CurrentRow.Cells(6).Value.ToString()
            version_mod5 = CInt(dgv_5_empresa.CurrentRow.Cells(2).Value.ToString())
        Else
            txt_5_contrato2.Clear()
            txt_5_subcontrato2.Clear()
            Cod_5 = ""
            version_mod5 = 0
        End If
    End Sub

    Private Sub btn_eliminar5_Click(sender As Object, e As EventArgs) Handles btn_eliminar5.Click
        Dim eliminar5 As MsgBoxResult
        If (Cod_5 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar5 = MsgBox("¿Realmente desea eliminar el contrato designado al Subcontrato?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar5 = MsgBoxResult.Ok Then
                nue_obra5.eliminar_sincro(CInt(Cod_5), 3, version_mod5)
                txt_5_contrato2.Clear()
                txt_5_subcontrato2.Clear()
                Cod_5 = ""
                actualizar_5_adjuntos()
            Else
                txt_5_contrato2.Clear()
                txt_5_subcontrato2.Clear()
                Cod_5 = ""
                actualizar_5_adjuntos()
            End If
        End If
    End Sub
    Private Sub btn_7_ingresar_Click(sender As Object, e As EventArgs) Handles btn_7_ingresar.Click
        Dim verificar As Integer
        Dim verificar2 As Integer
        Dim verificar3 As Integer
        verificar = 0
        verificar2 = 0
        verificar3 = 0

        For i = 0 To check_7_empresa.Items.Count - 1
            If (check_7_empresa.GetItemChecked(i)) Then
                verificar = contador + 1
            End If
        Next

        If dgv_7_empresa.Rows.Count > 0 Then
            For j = 0 To dgv_7_empresa.Rows.Count - 1
                If txt_7_finiquito.Text = dgv_7_empresa.Rows(j).Cells(7).Value.ToString() Then
                    verificar2 = 1
                End If
            Next j
        End If

        If dgv_7_empresa.Rows.Count > 0 Then
            For k = 0 To check_7_empresa.Items.Count - 1
                For l = 0 To dgv_7_empresa.Rows.Count - 1
                    If (check_7_empresa.GetItemChecked(k)) Then
                        valor(k) = check_7_empresa.Items(k)
                        Dim Cadena As String = valor(k)
                        Dim ArrCadena As String() = Cadena.Split(" / ")

                        If ArrCadena(0) = dgv_7_empresa.Rows(l).Cells(5).Value.ToString() And dgv_7_empresa.Rows(l).Cells(7).Value.ToString() <> "" Then
                            verificar3 = 1
                        End If
                    End If
                Next l
            Next
        End If

        If txt_7_finiquito.Text <> "" And txt_7_contrato.Text <> "" And verificar > 0 Then
            If verificar2 = 1 Then
                MessageBox.Show("EL N° DE FINIQUITO " & txt_7_finiquito.Text & " YA ESTA ADJUNTADO")
            Else
                If verificar3 = 1 Then
                    MessageBox.Show("YA HAY UN FINIQUITO ADJUNTO A UNO DE LOS EQUIPOS SELECCIONADOS")
                Else
                    extrae_datos7()
                    actualizar_7_adjuntos()
                    txt_7_contrato.Clear()
                    txt_7_finiquito.Clear()
                End If
            End If
        Else
            MessageBox.Show("FALTAN DATOS PARA INGRESAR EL FINIQUITO")
        End If
    End Sub
    Public Sub extrae_datos7()
        Dim i As Integer
        Dim Z As Integer
        Dim ruta As String
        Dim nombre As String
        Dim extension As String

        If OpenFileDialog7.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ruta = OpenFileDialog7.FileName
            nombre = txt_7_finiquito.Text & "-" & id_obra
            extension = ".pdf"

            My.Computer.Network.UploadFile(ruta, "ftp://cfv%2540constructorafv.com@201.148.105.75/Finiquito_equipos/" & nombre & extension & "", "cfv@constructorafv.com", "gsolis2013", True, 500)
            MessageBox.Show("Finiquito adjunto")
            contador = 0

            For i = 0 To check_7_empresa.Items.Count - 1
                If (check_7_empresa.GetItemChecked(i)) Then
                    contador = contador + 1
                    valor(i) = check_7_empresa.Items(i)
                    Dim Cadena As String = valor(i)
                    Dim ArrCadena As String() = Cadena.Split(" / ")
                    nue_obra7.insertar(1, 0, Nombre_Obra, id_obra, ArrCadena(0), ArrCadena(2), CInt(txt_7_finiquito.Text), "SI", Nombre_Usuario, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), cmb_7_obra.SelectedValue.ToString(), cmb_7_obra.Text, "", CDate(txt_fecha_act.Text), cmb_7_arrendador.SelectedValue.ToString(), cmb_7_arrendador.Text, cmb_7_tipo_pago.Text, cmb_7_operador.Text, CDate(txt_fecha_act.Text), CInt(txt_7_contrato.Text))
                End If
            Next
        End If
    End Sub

    Private Sub txt_7_contrato_TextChanged(sender As Object, e As EventArgs) Handles txt_7_contrato.TextChanged
        If Not IsNumeric(txt_7_contrato.Text) Then
            txt_7_contrato.Clear()
        End If
    End Sub

    Private Sub txt_7_finiquito_TextChanged(sender As Object, e As EventArgs) Handles txt_7_finiquito.TextChanged
        If Not IsNumeric(txt_7_finiquito.Text) Then
            txt_7_finiquito.Clear()
        End If
    End Sub
    Sub actualizar_7_adjuntos()
        dgv_7_empresa.DataSource = nue_obra7.listar14(id_obra)
        dgv_7_empresa.Columns(0).Visible = False
        dgv_7_empresa.Columns(1).Visible = False
        dgv_7_empresa.Columns(2).Visible = False
        dgv_7_empresa.Columns(3).Visible = False
        dgv_7_empresa.Columns(4).Visible = False
        dgv_7_empresa.Columns(5).Visible = False
        dgv_7_empresa.Columns(6).HeaderText = "Equipo"
        dgv_7_empresa.Columns(6).Width = 100
        dgv_7_empresa.Columns(7).HeaderText = "Número Finiquito"
        dgv_7_empresa.Columns(7).Width = 100
        dgv_7_empresa.Columns(8).HeaderText = "Adjunto"
        dgv_7_empresa.Columns(8).Width = 80
        dgv_7_empresa.Columns(9).HeaderText = "Usuario"
        dgv_7_empresa.Columns(9).Width = 80
        dgv_7_empresa.Columns(10).HeaderText = "Fecha"
        dgv_7_empresa.Columns(10).Width = 100
        dgv_7_empresa.Columns(11).HeaderText = "Hora"
        dgv_7_empresa.Columns(11).Width = 80
        dgv_7_empresa.Columns(12).Visible = False
        dgv_7_empresa.Columns(13).Visible = False
        dgv_7_empresa.Columns(14).Visible = False
        dgv_7_empresa.Columns(15).Visible = False
        dgv_7_empresa.Columns(16).Visible = False
        dgv_7_empresa.Columns(17).Visible = False
        dgv_7_empresa.Columns(18).Visible = False
        dgv_7_empresa.Columns(19).Visible = False
        dgv_7_empresa.Columns(20).Visible = False
        dgv_7_empresa.AllowUserToOrderColumns = True
    End Sub

    Private Sub dgv_7_empresa_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_7_empresa.MouseClick
        If IsNumeric(dgv_7_empresa.CurrentRow.Cells(0).Value.ToString()) Then
            Cod_7 = dgv_7_empresa.CurrentRow.Cells(0).Value.ToString()
            txt_7_finiquito2.Text = dgv_7_empresa.CurrentRow.Cells(7).Value.ToString()
            txt_7_equipo2.Text = dgv_7_empresa.CurrentRow.Cells(6).Value.ToString()
            version_mod7 = CInt(dgv_7_empresa.CurrentRow.Cells(2).Value.ToString())
        Else
            txt_7_finiquito2.Clear()
            txt_7_equipo2.Clear()
            Cod_7 = ""
            version_mod7 = 0
        End If
    End Sub

    Private Sub btn_eliminar7_Click(sender As Object, e As EventArgs) Handles btn_eliminar7.Click
        Dim eliminar7 As MsgBoxResult
        If (Cod_7 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar7 = MsgBox("¿Realmente desea eliminar el contrato designado al equipo?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar7 = MsgBoxResult.Ok Then
                nue_obra7.eliminar_sincro(CInt(Cod_7), 3, version_mod7)
                txt_7_finiquito2.Clear()
                txt_7_equipo2.Clear()
                Cod_7 = ""
                actualizar_7_adjuntos()
            Else
                txt_7_finiquito2.Clear()
                txt_7_equipo2.Clear()
                Cod_7 = ""
                actualizar_7_adjuntos()
            End If
        End If
    End Sub

    Private Sub txt_8_ep_TextChanged(sender As Object, e As EventArgs) Handles txt_8_ep.TextChanged
        If Not IsNumeric(txt_8_ep.Text) Then
            txt_8_ep.Clear()
        End If
    End Sub

    Private Sub Button93_Click(sender As Object, e As EventArgs) Handles btn_8_detalle_ep.Click
        If txt_8_ep.Text <> "" And cmb_8_subcontrato.Text <> "" Then
            CR_Estado_de_pago_subcontrato.Show()
        Else
            MsgBox("FALTA INGRESAR EL N° DEL ESTADO DE PAGO O EL SUBCONTRATISTA")
        End If
    End Sub

    Private Sub btn_8_resumen_ep_Click(sender As Object, e As EventArgs) Handles btn_8_resumen_ep.Click
        If txt_8_ep.Text <> "" And cmb_8_subcontrato.Text <> "" Then
            CR_Resumen_Estado_Pago_subcontrato.Show()
        Else
            MsgBox("FALTA INGRESAR EL N° DEL ESTADO DE PAGO O EL SUBCONTRATISTA")
        End If
    End Sub

    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter
        num_tab = 1
        Dim consultar As MsgBoxResult
        If consulta_datos <> 0 Then
            consultar = MsgBox("Usted no ha guardado los avances, ¿Desea guardarlos?", MsgBoxStyle.OkCancel, "Confirmar")

            If consultar = MsgBoxResult.Ok Then
                btn_tabla.PerformClick()
            Else
            End If
            frm_menu_principal_III.Show()
            Me.Close()
        ElseIf consulta_datos = 0 Then
            frm_menu_principal_III.Show()
            Me.Close()
        End If
    End Sub
    Private Sub txt_1_max_dias_TextChanged(sender As Object, e As EventArgs) Handles txt_1_plazo_dias.TextChanged
        If Not IsNumeric(txt_1_plazo_dias.Text) Then
            txt_1_plazo_dias.Clear()
        End If
    End Sub
    'Private Sub txt_1_precio_un_TextChanged(sender As Object, e As EventArgs) Handles txt_1_precio_un.TextChanged
    '    Dim precio_total As Double
    '    If Not IsNumeric(dgv_datosAgregados1.Rows(0).Cells(3).Value.ToString()) Then
    '        txt_1_precio_un.Clear()
    '    End If
    '    If IsNumeric(dgv_datosAgregados1.Rows(0).Cells(3).Value.ToString()) And IsNumeric(dgv_datosAgregados1.Rows(0).Cells(4).Value.ToString()) Then
    '        precio_total = dgv_datosAgregados1.Rows(0).Cells(3).Value.ToString() * dgv_datosAgregados1.Rows(0).Cells(4).Value.ToString()
    '        dgv_datosAgregados1.Rows(0).Cells(5).Value.ToString() = FormatNumber(precio_total, 0)
    '    Else
    '    End If
    'End Sub

    'Private Sub txt_1_cant_cont_TextChanged(sender As Object, e As EventArgs)
    '    Dim precio_total As Double
    '    If Not IsNumeric(dgv_datosAgregados1.Rows(0).Cells(4).Value.ToString()) Then
    '        txt_1_cant_cont.Clear()
    '    End If
    '    If IsNumeric(dgv_datosAgregados1.Rows(0).Cells(3).Value.ToString()) And IsNumeric(dgv_datosAgregados1.Rows(0).Cells(4).Value.ToString()) Then
    '        precio_total = dgv_datosAgregados1.Rows(0).Cells(3).Value.ToString() * dgv_datosAgregados1.Rows(0).Cells(4).Value.ToString()
    '        dgv_datosAgregados1.Rows(0).Cells(5).Value.ToString() = FormatNumber(precio_total, 0)
    '    Else
    '    End If
    'End Sub

    'Private Sub txt_1_valor_contrato_TextChanged(sender As Object, e As EventArgs) Handles txt_1_valor_contrato.TextChanged
    '    If Not IsNumeric(txt_1_valor_contrato.Text) Then
    '        txt_1_valor_contrato.Clear()
    '    End If
    '    Dim valor_garantia As Double
    '    If Not IsNumeric(dgv_datosAgregados1.Rows(0).Cells(4).Value.ToString()) Then
    '        txt_1_cant_cont.Clear()
    '    End If
    '    If IsNumeric(txt_1_valor_contrato.Text) And IsNumeric(dgv_datosAgregados1.Rows(0).Cells(5).Value.ToString()) Then
    '        valor_garantia = (dgv_datosAgregados1.Rows(0).Cells(5).Value.ToString() * txt_1_valor_contrato.Text) / 100
    '        txt_1_valor_pesos.Text = FormatNumber(valor_garantia, 0)
    '    Else
    '    End If
    'End Sub

    Private Sub txt_1_valor_pesos_TextChanged(sender As Object, e As EventArgs) Handles txt_1_valor_pesos.TextChanged
        If Not IsNumeric(txt_1_valor_pesos.Text) Then
            txt_1_valor_pesos.Clear()
        End If
    End Sub

    Private Sub txt_1_valor_seguro_TextChanged(sender As Object, e As EventArgs) Handles txt_1_valor_seguro.TextChanged
        If Not IsNumeric(txt_1_valor_seguro.Text) Then
            txt_1_valor_seguro.Clear()
        End If
    End Sub

    Private Sub cmb_5_subcontrato_TextChanged(sender As Object, e As EventArgs) Handles cmb_5_subcontrato.TextChanged

        If activa5 = 1 Then
            Dim subcontratista5, subcontrato5 As String

            Dim Cadena5 As String = cmb_5_subcontrato.Text
            Dim ArrCadena5 As String() = Cadena5.Split("/")
            subcontratista5 = ArrCadena5(0)
            subcontrato5 = ArrCadena5(1)
            cmb_5_obra.Text = nue_obra5.verificar_obra(id_obra, cmb_5_subcontrato.SelectedValue.ToString(), subcontrato5)
            cmb_5_obra.Visible = True
        Else
            cmb_5_obra.Visible = False

        End If
    End Sub

    Private Sub cmb_5_subcontrato_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_5_subcontrato.MouseClick
        actualiza_arrendador5()
        activa5 = 1
    End Sub

    Private Sub cmb_4_subcontrato_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_4_subcontrato.MouseClick
        actualiza_arrendador4()
        activa4 = 1
    End Sub
    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
        num_tab = 1
        frm_menu_principal_V.Show()
        Me.Close()
    End Sub

    Private Sub TabPage14_Enter(sender As Object, e As EventArgs) Handles TabPage14.Enter
        If var_in1 = 0 Then
            actualiza_arrendador()
            actualiza_obras()
            'actualiza_cuentas_maquinaria()
            actualizar_dgv1()
            var_in1 = 1
        End If
    End Sub

    Private Sub TabPage15_Enter(sender As Object, e As EventArgs) Handles TabPage15.Enter
        If var_in2 = 0 Then
            actualiza_equipos()
            var_in2 = 1
        End If
    End Sub

    Private Sub TabPage16_Enter(sender As Object, e As EventArgs) Handles TabPage16.Enter
        If var_in3 = 0 Then
            actualiza_cuentas_trabajo()
            actualiza_arrendador3()
            var_in3 = 1
        End If
    End Sub

    Private Sub TabPage17_Enter(sender As Object, e As EventArgs) Handles TabPage17.Enter
        If var_in4 = 0 Then
            var_in4 = 1
        End If
    End Sub

    Private Sub TabPage18_Enter(sender As Object, e As EventArgs) Handles TabPage18.Enter
        If var_in5 = 0 Then
            actualiza_obras5()
            actualizar_5_adjuntos()
            var_in5 = 1
        End If

    End Sub

    Private Sub TabPage19_Enter(sender As Object, e As EventArgs) Handles TabPage19.Enter
        If var_in6 = 0 Then
            actualiza_arrendador6()
            actualiza_obras6()
            var_in6 = 1
        End If

    End Sub

    Private Sub TabPage20_Enter(sender As Object, e As EventArgs) Handles TabPage20.Enter
        If var_in7 = 0 Then
            actualiza_arrendador7()
            actualiza_obras7()
            actualizar_7_adjuntos()
            var_in7 = 1
        End If
    End Sub

    Private Sub TabPage21_Enter(sender As Object, e As EventArgs) Handles TabPage21.Enter
        If var_in8 = 0 Then
            var_in8 = 1
        End If
    End Sub

    Private Sub btn_nuevo11_Click(sender As Object, e As EventArgs) Handles btn_nuevo11.Click
        desbloquear1()
        limpiar1()
        sw1 = 0
        Cod_1 = ""

        desbloquear11()
        limpiar11()
        sw11 = 0
        Cod_11 = ""

        If sw1 = 0 Then
            btn_cancelar1.PerformClick()
        End If
    End Sub

    Private Sub btn_editar11_Click(sender As Object, e As EventArgs) Handles btn_editar11.Click
        If (Cod_11 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear11()
            sw11 = 1
            'cmb_1_forma.Text = dgv_1_maquinas.CurrentRow.Cells(10).Value.ToString()
        End If
    End Sub

    Private Sub btn_eliminar11_Click(sender As Object, e As EventArgs) Handles btn_eliminar11.Click
        Dim eliminar11 As MsgBoxResult
        If (Cod_11 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar11 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar11 = MsgBoxResult.Ok And sincroniza = 0 Then
                version_mod11 = version_mod11 + 1
                nue_obra1.eliminar_sincro11(CInt(Cod_11), 3, version_mod11)
                bloquear11()
                limpiar11()
                actualiza_arrendador()

            ElseIf sincroniza_local = 1 And sincroniza = 1 And eliminar11 = MsgBoxResult.Ok Then
                nue_obra1.eliminar(CInt(Cod_11))
                bloquear11()
                limpiar11()
                actualiza_arrendador()
            ElseIf eliminar11 = MsgBoxResult.Ok Then
                version_mod11 = version_mod11 + 1
                nue_obra1.eliminar_sincro11(CInt(Cod_11), 3, version_mod11)
                bloquear11()
                limpiar11()
                actualiza_arrendador()
            End If
        End If
    End Sub

    Private Sub btn_guardar11_Click(sender As Object, e As EventArgs) Handles btn_guardar11.Click
        Dim rut, domicilio, razon_social, representante, representante_rut As String
        Dim existe_rut2 As Integer
        Dim comuna, ciudad As String

        If (txt_1_rut.Text <> "" And txt_1_razon_social.Text <> "") Then
            domicilio = txt_1_domicilio.Text
            razon_social = txt_1_razon_social.Text
            representante = txt_1_representante.Text
            representante_rut = txt_1_rut_representante.Text
            rut = txt_1_rut.Text
            comuna = txt_1_comuna.Text
            ciudad = txt_1_ciudad.Text

            If sw11 = 0 Then
                If nue_obra1.verificar_arrendador(id_obra, rut) = 0 Then
                    nue_obra1.insertar_cabecera(1, 0, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut, comuna, ciudad)
                    actualiza_arrendador()
                Else
                    MessageBox.Show("ESTE ARRENDADOR YA ESTA CREADO")
                End If

            ElseIf sincroniza_local = 1 And sincroniza = 1 And sw11 <> 0 Then
                nue_obra1.modificar_cabecera(CInt(Cod_11), 1, 0, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut, comuna, ciudad)

            ElseIf sincroniza = 0 And sw11 <> 0 Then
                version_mod11 = version_mod11 + 1
                nue_obra1.modificar_cabecera(CInt(Cod_11), 2, version_mod11, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut, comuna, ciudad)

            Else
                version_mod11 = version_mod11 + 1
                nue_obra1.modificar_cabecera(CInt(Cod_11), 2, version_mod11, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut, comuna, ciudad)
            End If
            limpiar11()
            bloquear11()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_cancelar11_Click(sender As Object, e As EventArgs) Handles btn_cancelar11.Click
        bloquear11()
    End Sub

    Private Sub btn_1_agregar_linea_Click(sender As Object, e As EventArgs) Handles btn_1_agregar_linea.Click
        If txt_id_subcontrato.Text <> "" Then

            Dim cantDatosAgregados As Integer = dgv_datosAgregados1.RowCount - 1
            dgv_datosAgregados1.Rows.Add(1)

            dgv_datosAgregados1.Rows(dgv_datosAgregados1.RowCount - 1).Cells(7).Value = 1
        Else

            MsgBox("PARA PODER AGREGAR ÍTEMS PRIMERO DEBE CREAR EL SUBCONTRATO")
        End If

    End Sub

    Private Sub dgv_datosAgregados1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados1.CellValueChanged

        'Dim nombrecolumna As String
        'nombrecolumna = dgv_datosAgregados1.Columns(e.ColumnIndex).Index
        'MsgBox(nombrecolumna)

        If dgv_datosAgregados1.Rows.Count > 0 Then

            If e.ColumnIndex = 3 Then
                If IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column14").Value) And IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column15").Value) Then

                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column16").Value = dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column15").Value * dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column14").Value
                Else
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column16").Value = ""
                End If
            ElseIf e.ColumnIndex = 4 Then

                If IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column14").Value) And IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column15").Value) Then

                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column16").Value = dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column15").Value * dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column14").Value
                Else
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column16").Value = ""
                End If
            End If
        End If

    End Sub

    Private Sub txt_1_servicio_TextChanged(sender As Object, e As EventArgs) Handles txt_1_servicio.TextChanged
        If txt_1_servicio.Text <> "" And txt_1_razon_social.Text <> "" Then
            gp_1_identificacion.Visible = True
            gp_1_general.Visible = True
        Else
            gp_1_identificacion.Visible = False
            gp_1_general.Visible = False
        End If
    End Sub

    Private Sub btn_descargar5_Click(sender As Object, e As EventArgs) Handles btn_descargar5.Click
        If (Cod_5 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            descargar_archivo()
        End If
    End Sub

    Public Sub descargar_archivo()
        Dim ruta_destino As String
        Dim nombre As String
        Dim extension As String

        If SaveFileDialog3.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ruta_destino = SaveFileDialog3.FileName
            nombre = txt_5_contrato2.Text & "-" & id_obra
            extension = ".pdf"
            Try

                My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Subcontratos_adjuntos/" & nombre & extension & "", ruta_destino, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MessageBox.Show("DESCARGA EXITOSA")
        End If
    End Sub

    Private Sub cmb_8_subcontrato_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_8_subcontrato.MouseClick
        actualiza_arrendador8()
    End Sub

    Private Sub TabPage10_Enter(sender As Object, e As EventArgs) Handles TabPage10.Enter
        num_tab = 1
        frm_menu_principal_X.Show()
        Me.Close()
    End Sub

    Private Sub dgv_datosAgregados1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados1.CellEndEdit
        If dgv_datosAgregados1.Rows.Count > 0 Then
            If e.ColumnIndex = 1 Then
                If dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column12").Value <> "" And IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 2
                ElseIf dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column12").Value <> "" And Not IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 1
                Else
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 0
                End If
            End If

            If e.ColumnIndex = 2 Then
                If dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column13").Value <> "" And IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 2
                ElseIf dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column13").Value <> "" And Not IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 1
                Else
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 0
                End If
            End If

            If e.ColumnIndex = 6 Then
                If dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column17").Value <> "" And IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 2
                ElseIf dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column17").Value <> "" And Not IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 1
                Else
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 0
                End If
            End If

            If e.ColumnIndex = 3 Then
                If IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column14").Value) And IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column14").Value) And Not IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 1
                Else
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 0
                End If
            End If

            If e.ColumnIndex = 4 Then
                If IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column15").Value) And IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Column15").Value) And Not IsNumeric(dgv_datosAgregados1.Rows(e.RowIndex).Cells("Id2").Value) Then
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 1
                Else
                    dgv_datosAgregados1.Rows(e.RowIndex).Cells("id_modifica2").Value = 0
                End If
            End If

        End If
    End Sub

    Private Sub btn_guardar2_Click(sender As Object, e As EventArgs) Handles btn_guardar2.Click
        Dim rut, cuenta_contable, item, unidad_pago As String
        Dim precio_un, cantidad, precio_total As Double
        Dim Id_subcontrato As Integer

        If dgv_datosAgregados1.RowCount > 0 Then

            If (dgv_datosAgregados1.Rows(0).Cells(1).Value.ToString() <> "" And dgv_datosAgregados1.Rows(0).Cells(2).Value.ToString() <> "" And dgv_datosAgregados1.Rows(0).Cells(3).Value.ToString() <> "" And dgv_datosAgregados1.Rows(0).Cells(4).Value.ToString() <> "" And dgv_datosAgregados1.Rows(0).Cells(6).Value.ToString() <> "") Then

                sincroniza_local = 1

                rut = txt_1_rut.Text
                Id_subcontrato = txt_id_subcontrato.Text

                If dgv_datosAgregados1.Rows.Count > 0 Then
                    For i = 0 To dgv_datosAgregados1.Rows.Count - 1

                        If IsNumeric(dgv_datosAgregados1.Rows(i).Cells(7).Value) Then

                        
                        If Not IsNumeric(dgv_datosAgregados1.Rows(i).Cells(4).Value.ToString()) Then
                            cantidad = 0
                        Else
                            cantidad = CDbl(dgv_datosAgregados1.Rows(i).Cells(4).Value.ToString())
                        End If

                        If Not IsNumeric(dgv_datosAgregados1.Rows(i).Cells(5).Value.ToString()) Then
                            precio_total = 0
                        Else
                            precio_total = CDbl(dgv_datosAgregados1.Rows(i).Cells(5).Value.ToString())
                        End If

                        If Not IsNumeric(dgv_datosAgregados1.Rows(i).Cells(3).Value.ToString()) Then
                            precio_un = 0
                        Else
                            precio_un = CDbl(dgv_datosAgregados1.Rows(i).Cells(3).Value.ToString())
                        End If

                        item = dgv_datosAgregados1.Rows(i).Cells(1).Value.ToString()
                        unidad_pago = dgv_datosAgregados1.Rows(i).Cells(2).Value.ToString()
                        cuenta_contable = dgv_datosAgregados1.Rows(i).Cells(6).Value.ToString()

                        If dgv_datosAgregados1.Rows(i).Cells(7).Value.ToString() = 1 Then
                            nue_obra1.insertar_item(1, 0, Nombre_Obra, id_obra, rut, Id_subcontrato, item, unidad_pago, precio_un, cantidad, precio_total, cuenta_contable)

                        ElseIf dgv_datosAgregados1.Rows(i).Cells(7).Value.ToString() = 2 And dgv_datosAgregados1.Rows(i).Cells(9).Value.ToString() = 1 And sincroniza = 1 Then
                            Cod_1 = dgv_datosAgregados1.Rows(i).Cells(0).Value.ToString()
                            nue_obra1.modificar_item(CInt(Cod_1), 1, 0, Nombre_Obra, id_obra, rut, Id_subcontrato, item, unidad_pago, precio_un, cantidad, precio_total, cuenta_contable)

                        ElseIf dgv_datosAgregados1.Rows(i).Cells(7).Value.ToString() = 2 And sincroniza = 0 Then
                            Cod_1 = dgv_datosAgregados1.Rows(i).Cells(0).Value.ToString()
                            version_mod1 = CInt(dgv_datosAgregados1.Rows(i).Cells(8).Value.ToString()) + 1
                            nue_obra1.modificar_item(CInt(Cod_1), 2, version_mod1, Nombre_Obra, id_obra, rut, Id_subcontrato, item, unidad_pago, precio_un, cantidad, precio_total, cuenta_contable)

                            'ElseIf dgv_datosAgregados1.Rows(i).Cells(6).Value.ToString() = 3 And dgv_datosAgregados1.Rows(i).Cells(9).Value.ToString() = 1 And sincroniza = 1 Then

                            'ElseIf dgv_datosAgregados1.Rows(i).Cells(6).Value.ToString() = 3 And dgv_datosAgregados1.Rows(i).Cells(9).Value.ToString() <> 1 And sincroniza = 1 Then

                        End If

                        actualizar_dgv1()
                        actualiza_equipos()

                        End If
                    Next i

                    limpiar1()
                    bloquear1()
                Else
                    MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                End If
            End If
        Else
            MsgBox("TIENE QUE INGRESAR POR LO MENOS UN ÍTEM")
        End If
    End Sub
End Class