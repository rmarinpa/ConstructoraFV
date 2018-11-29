Imports Microsoft.Office.Interop.Word 'Control de office
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop

Public Class frm_menu_principal_III
    Dim nue_obra1 As New clases.Identificacion_equipos
    Dim nue_obra2 As New clases.Registro_reports
    Dim nue_obra3 As New clases.Trabajos_adicionales
    Dim nue_obra4 As New clases.Generacion_contratos
    Dim nue_obra5 As New clases.Ingreso_contratos
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
    Dim sincroniza_local2 As Integer
    Dim sincroniza_local3 As Integer
    Dim sincroniza_local_1 As Integer
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
    Dim var_in1 As Integer
    Dim var_in2 As Integer
    Dim var_in3 As Integer
    Dim var_in4 As Integer
    Dim var_in5 As Integer
    Dim var_in6 As Integer
    Dim var_in7 As Integer
    Dim var_in8 As Integer
    Dim obra As String

    Sub bloquear1()
        txt_1_rut.Enabled = False
        txt_1_domicilio.Enabled = False
        'txt_1_razon_social.Enabled = False
        txt_1_representante.Enabled = False
        txt_1_rut_representante.Enabled = False
        cmb_1_forma.Enabled = False
        txt_1_dia_cierre.Enabled = False
        txt_1_dia_cierre_ep.Enabled = False
        cmb_1_codigo.Enabled = False
        cmb_1_tipo_equipo.Enabled = False
        txt_1_detalle_equipo.Enabled = False
        txt_1_marca.Enabled = False
        txt_1_modelo.Enabled = False
        txt_1_patente.Enabled = False
        txt_1_num_motor.Enabled = False
        txt_1_capacidad.Enabled = False
        cmb_1_obra.Enabled = False
        cmb_1_operador.Enabled = False
        cmb_1_horometro.Enabled = False
        cmb_1_un_pago.Enabled = False
        txt_1_precio_un.Enabled = False
        cmb_1_cuenta_maq.Enabled = False
        cmb_1_cuenta_petro.Enabled = False
        cmb_1_recupera.Enabled = False
        txt_1_max_dias.Enabled = False
        cmb_1_jornada.Enabled = False
        txt_1_min.Enabled = False
        txt_1_desc.Enabled = False
        txt_1_material.Enabled = False
        cmb_1_turno.Enabled = False
        txt_1_rendimientos.Enabled = False


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

        btn_cancelar11.Enabled = False
        btn_guardar11.Enabled = False
        btn_editar11.Enabled = True
        btn_nuevo11.Enabled = True
        btn_eliminar11.Enabled = True
    End Sub
    Sub desbloquear1()
        txt_1_rut.Enabled = True
        txt_1_domicilio.Enabled = True
        'txt_1_razon_social.Enabled = True
        txt_1_representante.Enabled = True
        txt_1_rut_representante.Enabled = True
        cmb_1_forma.Enabled = True
        txt_1_dia_cierre.Enabled = True
        txt_1_dia_cierre_ep.Enabled = True
        cmb_1_codigo.Enabled = True
        cmb_1_tipo_equipo.Enabled = True
        txt_1_detalle_equipo.Enabled = True
        txt_1_marca.Enabled = True
        txt_1_modelo.Enabled = True
        txt_1_patente.Enabled = True
        txt_1_num_motor.Enabled = True
        txt_1_capacidad.Enabled = True
        txt_1_rendimientos.Enabled = True
        cmb_1_obra.Enabled = True
        cmb_1_operador.Enabled = True
        cmb_1_horometro.Enabled = True
        cmb_1_un_pago.Enabled = True
        txt_1_precio_un.Enabled = True
        cmb_1_cuenta_maq.Enabled = True
        cmb_1_cuenta_petro.Enabled = True
        cmb_1_recupera.Enabled = True
        txt_1_max_dias.Enabled = True
        cmb_1_jornada.Enabled = True
        txt_1_min.Enabled = True
        txt_1_desc.Enabled = True
        txt_1_material.Enabled = True
        cmb_1_turno.Enabled = True


        btn_cancelar1.Enabled = True
        btn_guardar1.Enabled = True
        btn_editar1.Enabled = False
        btn_nuevo1.Enabled = False
        btn_eliminar1.Enabled = False
    End Sub
    Sub desbloquear11()
        txt_1_rut.Enabled = True
        txt_1_domicilio.Enabled = True
        'txt_1_razon_social.Enabled = True
        txt_1_representante.Enabled = True
        txt_1_rut_representante.Enabled = True

        btn_cancelar11.Enabled = True
        btn_guardar11.Enabled = True
        btn_editar11.Enabled = False
        btn_nuevo11.Enabled = False
        btn_eliminar11.Enabled = False
    End Sub
    Sub limpiar1()
        txt_1_rut.Clear()
        txt_1_domicilio.Clear()
        txt_1_razon_social.Text = ""
        txt_1_representante.Clear()
        txt_1_rut_representante.Clear()
        cmb_1_forma.Text = ""
        cmb_1_codigo.Clear()
        cmb_1_tipo_equipo.Text = ""
        txt_1_detalle_equipo.Clear()
        txt_1_marca.Clear()
        txt_1_modelo.Clear()
        txt_1_patente.Clear()
        txt_1_num_motor.Clear()
        txt_1_capacidad.Clear()
        txt_1_rendimientos.Clear()
        cmb_1_obra.Text = ""
        cmb_1_operador.Text = ""
        cmb_1_horometro.Text = ""
        cmb_1_un_pago.Text = ""
        txt_1_precio_un.Text = ""
        cmb_1_cuenta_maq.Text = ""
        cmb_1_cuenta_petro.Text = ""
        cmb_1_recupera.Text = ""
        txt_1_max_dias.Clear()
        cmb_1_jornada.Text = ""
        txt_1_min.Clear()
        txt_1_desc.Clear()
        txt_1_material.Clear()
        txt_1_dia_cierre.Clear()
        txt_1_dia_cierre_ep.Clear()
        cmb_1_turno.Text = ""

        Cod_1 = ""
        version_mod1 = 0

        gp_1_identificacion.Visible = False
    End Sub

    Sub limpiar11()
        txt_1_rut.Clear()
        txt_1_domicilio.Clear()
        txt_1_razon_social.Text = ""
        txt_1_representante.Clear()
        txt_1_rut_representante.Clear()

        Cod_11 = ""
        version_mod11 = 0

        'gp_1_identificacion.Visible = False
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
        cmb_3_arrendador.Enabled = False
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
        cmb_3_arrendador.Enabled = True
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
        cmb_3_arrendador.Text = ""
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
        If sincroniza = 0 Then
            btn_m3_km.Visible = True
            btn_5_ingresar.Visible = True
            btn_7_ingresar.Visible = True
            btn_eliminar5.Visible = True
            btn_eliminar7.Visible = True
            btn_descargar7.Visible = True
            btn_descargar5.Visible = True
        Else
            btn_m3_km.Visible = False
            btn_5_ingresar.Visible = False
            btn_7_ingresar.Visible = False
            btn_eliminar5.Visible = False
            btn_eliminar7.Visible = False
            btn_descargar7.Visible = False
            btn_descargar5.Visible = False
        End If
        chk_iva.Checked = True
        btn_configurar.Visible = False
        Dim rtn As New Date

        actualizar_obras()
        var_in1 = 0
        var_in2 = 0
        var_in3 = 0
        var_in4 = 0
        var_in5 = 0
        var_in6 = 0
        var_in7 = 0
        var_in8 = 0
        ''actualiza_arrendador()
        ''actualiza_arrendador4()
        ''actualiza_arrendador5()
        ''actualiza_arrendador6()
        ''actualiza_arrendador7()
        ''actualiza_arrendador8()
        ''actualiza_obras()
        ''actualiza_obras4()
        ''actualiza_obras5()
        ''actualiza_obras6()
        ''actualiza_obras7()
        ''actualiza_equipos()
        ''actualiza_cuentas_maquinaria()
        ''actualiza_cuentas_petroleo()
        ''actualiza_cuentas_trabajo()
        ''actualiza_arrendador3()
        ''actualizar_5_adjuntos()
        ''actualizar_7_adjuntos()
        lbl_nombre_obra.Text = Nombre_Obra
        lbl_usuario.Text = Nombre_Usuario
        Me.WindowState = FormWindowState.Maximized
        txt_1_nom_obra.Enabled = False
        txt_1_nom_obra.Text = Nombre_Obra
        cmb_1_gerente.Text = ""
        gp_1_identificacion.Visible = False
        consulta_datos = 0
        consulta_datos_local = 0
        Timer1.Enabled = True
        txt_8_ep.Text = 1

        bloquear1()
        bloquear11()
        bloquear2()
        bloquear3()
        autoriza_2_1 = 1
        autoriza_2_2 = 1
        autoriza_2_3 = 1
        autoriza1()
        autoriza2()
        autoriza3()
        ''actualizar_dgv1()
        ''actualizar_dgv2()
        ''actualizar_dgv3()
        'sincroniza = 0
        dtp_fecha.MaxDate = Today
        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 24).AddMonths(-2)
        dtp_fecha.MinDate = rtn
        With dtp_fecha_in
            .MaxDate = Today.AddMonths(1).AddDays(23 - Today.Day)
            .MinDate = Today.AddMonths(-2)
        End With
        With dtp_fecha_fin
            .MaxDate = Today.AddMonths(1).AddDays(23 - Today.Day)
            .MinDate = Today.AddMonths(-2)
        End With

        'With dtp_3_fecha
        '    .Format = DateTimePickerFormat.Custom
        '    .CustomFormat = "23 MMMM yyyy"
        '    .MaxDate = Today.AddMonths(1).AddDays(23 - Today.Day)
        '    .MinDate = Today.AddMonths(-2)
        'End With

        If sincroniza = 0 Then
            btn_sincronizar.Visible = False
            pb_list.Visible = False
            lbl_sincroniza.Text = "Trabajando con Internet"
            'btn_editar1.Visible = True
            'btn_eliminar1.Visible = True

            'btn_editar11.Visible = True
            'btn_eliminar11.Visible = True

            'btn_tabla.Visible = True

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

            'btn_editar11.Visible = False
            'btn_eliminar11.Visible = False

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

        actualizar_check_empresa()

        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        num_tab = 0
        Dim consultar As MsgBoxResult
        If consulta_datos <> 0 Then
            consultar = MsgBox("Usted no ha guardado los reports, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
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
        Try
            If num_tab <> 0 Then
                num_tab = 0
                Dim consultar As MsgBoxResult
                If consulta_datos <> 0 Then
                    consultar = MsgBox("Usted no ha guardado los reports, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

                    If consultar = MsgBoxResult.Yes Then
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
        Catch
        End Try
    End Sub
    Private Sub btn_nuevo1_Click(sender As Object, e As EventArgs) Handles btn_nuevo1.Click
        actualiza_arrendador()
        desbloquear1()
        limpiar1()
        sw1 = 0
        Cod_1 = ""
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
        bloquear1()
    End Sub
    Private Sub btn_guardar1_Click(sender As Object, e As EventArgs) Handles btn_guardar1.Click
        Dim rut, domicilio, razon_social, representante, representante_rut, forma, codigo, tipo_equipo, detalle_equipo, marca, modelo, patente, num_motor, capacidad, obra, operador, horometro, un_pago, cuenta_maq, cuenta_petro, recupera, jornada, material As String
        Dim precio_un, dias_fallas, min, desc As Double
        Dim num_resolucion, fecha_ep, fecha_ep2, turno As Integer
        Dim fecha_fin As Date
        Dim rendimiento As Double

        If nue_obra2.verificar_codigo(id_obra, cmb_1_codigo.Text) = 1 And sw1 = 0 Then
            MsgBox("Este código ya esta asignado a una máquina.")
            cmb_1_codigo.Text = ""
        ElseIf cmb_1_codigo.Text = "AA-EL" Then
            MsgBox("Código reservado para el Sistema.")
            cmb_1_codigo.Text = ""
        Else

            If (txt_1_rut.Text <> "" And txt_1_razon_social.Text <> "" And cmb_1_forma.Text <> "" And cmb_1_codigo.Text <> "" And cmb_1_tipo_equipo.Text <> "" And txt_1_capacidad.Text <> "" And cmb_1_horometro.Text <> "" And cmb_1_un_pago.Text <> "" And txt_1_precio_un.Text <> "" And cmb_1_cuenta_maq.Text <> "" And cmb_1_cuenta_petro.Text <> "" And cmb_1_recupera.Text <> "" And cmb_1_jornada.Text <> "" And cmb_1_turno.Text <> "") Then
                If (cmb_1_forma.Text <> "Mes" And cmb_1_forma.Text <> "Dia" And txt_1_min.Text <> "" And txt_1_desc.Text <> "") Or cmb_1_forma.Text = "Mes" Or cmb_1_forma.Text = "Dia" Then

                    'sincroniza_local = 1

                    domicilio = txt_1_domicilio.Text
                    razon_social = txt_1_razon_social.Text
                    representante = txt_1_representante.Text
                    representante_rut = txt_1_rut_representante.Text
                    rut = txt_1_rut.Text

                    If Not IsNumeric(txt_1_precio_un.Text) Then
                        precio_un = 0
                    Else
                        precio_un = CDbl(txt_1_precio_un.Text)
                    End If

                    If Not IsNumeric(txt_1_max_dias.Text) Then
                        dias_fallas = 0
                    Else
                        dias_fallas = CDbl(txt_1_max_dias.Text)
                    End If

                    If Not IsNumeric(txt_1_min.Text) Then
                        min = 0
                    Else
                        min = CDbl(txt_1_min.Text)
                    End If

                    If Not IsNumeric(txt_1_desc.Text) Then
                        desc = 0
                    Else
                        desc = CDbl(txt_1_desc.Text)
                    End If
                    If Not IsNumeric(txt_1_dia_cierre.Text) Then
                        fecha_ep = 0
                    Else
                        fecha_ep = CInt(txt_1_dia_cierre.Text)
                    End If
                    If Not IsNumeric(txt_1_dia_cierre_ep.Text) Then
                        fecha_ep2 = 0
                    Else
                        fecha_ep2 = CInt(txt_1_dia_cierre_ep.Text)
                    End If

                    If Not IsNumeric(txt_1_rendimientos.Text) Then
                        rendimiento = 0
                    Else
                        rendimiento = CDbl(txt_1_rendimientos.Text)
                    End If


                    forma = cmb_1_forma.Text
                    codigo = cmb_1_codigo.Text
                    tipo_equipo = cmb_1_tipo_equipo.Text
                    detalle_equipo = txt_1_detalle_equipo.Text
                    marca = txt_1_marca.Text
                    modelo = txt_1_modelo.Text
                    patente = txt_1_patente.Text
                    num_motor = txt_1_num_motor.Text
                    capacidad = txt_1_capacidad.Text
                    obra = cmb_1_obra.Text
                    operador = cmb_1_operador.Text
                    horometro = cmb_1_horometro.Text
                    un_pago = cmb_1_un_pago.Text
                    cuenta_maq = cmb_1_cuenta_maq.Text
                    cuenta_petro = cmb_1_cuenta_petro.Text
                    recupera = cmb_1_recupera.Text
                    jornada = cmb_1_jornada.Text
                    material = txt_1_material.Text

                    If cmb_1_turno.Text = "Jornada Simple" Then
                        turno = 1
                    ElseIf cmb_1_turno.Text = "Jornada Doble" Then
                        turno = 2
                    End If

                    If sw1 = 0 Then
                        If existe_rut = 1 Then
                            If nue_obra1.verificar_arrendador(id_obra, rut) = 0 Then
                                nue_obra1.insertar_cabecera(1, 0, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut)
                                actualiza_arrendador()
                            Else
                                MessageBox.Show("ESTE ARRENDADOR YA ESTA CREADO")
                            End If
                        End If
                        nue_obra1.insertar_posicion(1, 0, Nombre_Obra, id_obra, rut, forma, fecha_ep, fecha_ep2, codigo, tipo_equipo, detalle_equipo, marca, modelo, patente, num_motor, capacidad, obra, operador, horometro, un_pago, precio_un, cuenta_maq, cuenta_petro, recupera, dias_fallas, jornada, min, desc, material, turno, rendimiento)

                        actualizar_dgv1()
                        actualiza_equipos()

                    ElseIf sincroniza_local_1 = 1 And sincroniza = 1 And sw1 <> 0 Then
                        If existe_rut = 1 Then
                            If nue_obra1.verificar_arrendador(id_obra, rut) = 0 Then
                                nue_obra1.insertar_cabecera(1, 0, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut)
                                actualiza_arrendador()
                            Else
                                MessageBox.Show("ESTE ARRENDADOR YA ESTA CREADO")
                            End If
                        End If
                        nue_obra1.modificar_posicion(CInt(Cod_1), 1, 0, Nombre_Obra, id_obra, rut, forma, fecha_ep, fecha_ep2, codigo, tipo_equipo, detalle_equipo, marca, modelo, patente, num_motor, capacidad, obra, operador, horometro, un_pago, precio_un, cuenta_maq, cuenta_petro, recupera, dias_fallas, jornada, min, desc, material, turno, rendimiento)
                        actualizar_dgv1()
                        actualiza_equipos()

                    ElseIf sw1 <> 0 And sincroniza = 0 Then
                        If existe_rut = 1 Then
                            If nue_obra1.verificar_arrendador(id_obra, rut) = 0 Then
                                nue_obra1.insertar_cabecera(1, 0, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut)
                                actualiza_arrendador()
                            Else
                                MessageBox.Show("ESTE ARRENDADOR YA ESTA CREADO")
                            End If
                        End If
                        version_mod1 = version_mod1 + 1
                        nue_obra1.modificar_posicion(CInt(Cod_1), 2, version_mod1, Nombre_Obra, id_obra, rut, forma, fecha_ep, fecha_ep2, codigo, tipo_equipo, detalle_equipo, marca, modelo, patente, num_motor, capacidad, obra, operador, horometro, un_pago, precio_un, cuenta_maq, cuenta_petro, recupera, dias_fallas, jornada, min, desc, material, turno, rendimiento)
                        actualizar_dgv1()
                        actualiza_equipos()
                    Else
                        version_mod1 = version_mod1 + 1
                        nue_obra1.modificar_posicion(CInt(Cod_1), 2, version_mod1, Nombre_Obra, id_obra, rut, forma, fecha_ep, fecha_ep2, codigo, tipo_equipo, detalle_equipo, marca, modelo, patente, num_motor, capacidad, obra, operador, horometro, un_pago, precio_un, cuenta_maq, cuenta_petro, recupera, dias_fallas, jornada, min, desc, material, turno, rendimiento)
                        actualizar_dgv1()
                        actualiza_equipos()
                    End If
                    limpiar1()
                    bloquear1()
                Else
                    MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                End If
            Else
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
            End If
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
    Private Sub btn_eliminar1_Click(sender As Object, e As EventArgs) Handles btn_eliminar1.Click
        Dim eliminar1 As MsgBoxResult
        If (Cod_1 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar1 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.YesNo, "Confirmar")

            If eliminar1 = MsgBoxResult.Yes And sincroniza = 0 Then
                version_mod1 = version_mod1 + 1
                nue_obra1.eliminar_sincro(CInt(Cod_1), 3, version_mod1)
                actualizar_dgv1()
                bloquear1()
                limpiar1()
                actualiza_equipos()

            ElseIf sincroniza_local_1 = 1 And sincroniza = 1 And eliminar1 = MsgBoxResult.Yes Then
                nue_obra1.eliminar_equipo(CInt(Cod_1))
                actualizar_dgv1()
                bloquear1()
                limpiar1()
                actualiza_equipos()

            ElseIf eliminar1 = MsgBoxResult.Yes Then
                version_mod1 = version_mod1 + 1
                nue_obra1.eliminar_sincro(CInt(Cod_1), 3, version_mod1)
                actualizar_dgv1()
                bloquear1()
                limpiar1()
                actualiza_equipos()
            End If
        End If
    End Sub
    Private Sub btn_eliminar3_Click(sender As Object, e As EventArgs) Handles btn_eliminar3.Click
        Dim eliminar3 As MsgBoxResult
        If (Cod_3 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar3 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.YesNo, "Confirmar")

            If eliminar3 = MsgBoxResult.Yes And sincroniza = 0 Then
                version_mod3 = version_mod3 + 1
                nue_obra3.eliminar_sincro(CInt(Cod_3), 3, version_mod3)
                actualizar_dgv3()
                bloquear3()
                limpiar3()

            ElseIf sincroniza_local3 = 1 And sincroniza = 1 And eliminar3 = MsgBoxResult.Yes Then
                nue_obra3.eliminar(CInt(Cod_3))
                actualizar_dgv3()
                bloquear3()
                limpiar3()

            ElseIf eliminar3 = MsgBoxResult.Yes Then
                version_mod3 = version_mod3 + 1
                nue_obra3.eliminar_sincro(CInt(Cod_3), 3, version_mod3)
                actualizar_dgv3()
                bloquear3()
                limpiar3()
            End If
        End If
    End Sub

    Private Sub btn_guardar3_Click(sender As Object, e As EventArgs) Handles btn_guardar3.Click
        Dim nombre_representante, rut, clasificacion, descripcion, unidad, cuenta_contable As String
        Dim Cantidad, precio_unitario, Total As Double
        Dim fecha_adicional As Date
        Dim mes_adicional As Date

        If (txt_3_descripcion.Text <> "" And txt_3_precio.Text <> "" And txt_3_cantidad.Text <> "") Then

            nombre_representante = cmb_3_arrendador.Text
            rut = cmb_3_arrendador.SelectedValue.ToString()
            clasificacion = cmb_3_clasificacion.Text
            cuenta_contable = cmb_3_cuenta_contable.Text
            descripcion = txt_3_descripcion.Text
            unidad = cmb_3_un_pago.Text
            Cantidad = CDbl(txt_3_cantidad.Text)
            precio_unitario = CDbl(txt_3_precio.Text)
            Total = CDbl(txt_3_total.Text)
            'fecha_adicional = CDate("23/" & Month(dtp_3_fecha.Text) & "/" & Year(dtp_3_fecha.Text))
            fecha_adicional = CDate(dtp_3_fecha.Text)
            If sw3 = 0 Then
                nue_obra3.insertar(1, 0, Nombre_Obra, id_obra, nombre_representante, rut, clasificacion, descripcion, Cantidad, unidad, precio_unitario, Total, cuenta_contable, fecha_adicional)
                actualizar_dgv3()

            ElseIf sincroniza_local3 = 1 And sincroniza = 1 And sw3 <> 0 Then
                nue_obra3.modificar(CInt(Cod_3), 1, 0, Nombre_Obra, id_obra, nombre_representante, rut, clasificacion, descripcion, Cantidad, unidad, precio_unitario, Total, cuenta_contable, fecha_adicional)
                actualizar_dgv3()

            ElseIf sw3 <> 0 And sincroniza = 0 Then
                version_mod3 = version_mod3 + 1
                nue_obra3.modificar(CInt(Cod_3), 2, version_mod3, Nombre_Obra, id_obra, nombre_representante, rut, clasificacion, descripcion, Cantidad, unidad, precio_unitario, Total, cuenta_contable, fecha_adicional)
                actualizar_dgv3()
            Else
                version_mod3 = version_mod3 + 1
                nue_obra3.modificar(CInt(Cod_3), 2, version_mod3, Nombre_Obra, id_obra, nombre_representante, rut, clasificacion, descripcion, Cantidad, unidad, precio_unitario, Total, cuenta_contable, fecha_adicional)
                actualizar_dgv3()
            End If
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
            'txt_1_razon_social.Enabled = False
            txt_1_representante.Enabled = False
            txt_1_rut_representante.Enabled = False
            cmb_1_forma.Text = dgv_1_maquinas.CurrentRow.Cells(10).Value.ToString()
        End If
    End Sub
    Sub actualizar_dgv1()
        dgv_1_maquinas.DataSource = nue_obra1.listar2(id_obra)
        dgv_1_maquinas.Columns(0).Visible = False
        dgv_1_maquinas.Columns(1).Visible = False
        dgv_1_maquinas.Columns(2).Visible = False
        dgv_1_maquinas.Columns(3).Visible = False
        dgv_1_maquinas.Columns(4).Visible = False
        dgv_1_maquinas.Columns(5).Visible = False
        dgv_1_maquinas.Columns(6).Visible = False
        dgv_1_maquinas.Columns(7).Visible = False
        dgv_1_maquinas.Columns(8).Visible = False
        dgv_1_maquinas.Columns(9).Visible = False
        dgv_1_maquinas.Columns(10).Visible = False
        dgv_1_maquinas.Columns(11).Visible = False
        dgv_1_maquinas.Columns(12).Visible = False
        dgv_1_maquinas.Columns(13).HeaderText = "Código"
        dgv_1_maquinas.Columns(13).Width = 100
        dgv_1_maquinas.Columns(14).Visible = False
        dgv_1_maquinas.Columns(15).Visible = False
        dgv_1_maquinas.Columns(15).Width = 150
        dgv_1_maquinas.Columns(16).Visible = False
        dgv_1_maquinas.Columns(17).Visible = False
        dgv_1_maquinas.Columns(18).Visible = False
        dgv_1_maquinas.Columns(19).Visible = False
        dgv_1_maquinas.Columns(20).Visible = False
        dgv_1_maquinas.Columns(21).Visible = False
        dgv_1_maquinas.Columns(22).Visible = False
        dgv_1_maquinas.Columns(23).Visible = False
        dgv_1_maquinas.Columns(24).Visible = False
        dgv_1_maquinas.Columns(25).Visible = False
        dgv_1_maquinas.Columns(26).Visible = False
        dgv_1_maquinas.Columns(27).Visible = False
        dgv_1_maquinas.Columns(28).Visible = False
        dgv_1_maquinas.Columns(29).Visible = False
        dgv_1_maquinas.Columns(30).Visible = False
        dgv_1_maquinas.Columns(31).Visible = False
        dgv_1_maquinas.Columns(32).Visible = False
        dgv_1_maquinas.Columns(33).Visible = False
        dgv_1_maquinas.Columns(34).Visible = False
        dgv_1_maquinas.Columns(35).Visible = False

        'dgv_1_maquinas.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_1_maquinas.AllowUserToOrderColumns = True
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
            consultar = MsgBox("Usted no ha guardado los reports, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
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

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles cmb_1_forma.TextChanged
        If (cmb_1_forma.Text = "Dia") Then
            txt_1_identificacion.Text = "Identificación Equipos y Arrendadores (Pago por Día)"
            gp_1_identificacion.Visible = True
            gp_parametros.Visible = True

            lbl_1_mes.Visible = True
            cmb_1_jornada.Visible = True
            txt_1_mes.Visible = True

            txt_1_precio.Visible = False

            lbl_1_precio.Visible = False
            txt_1_min.Visible = False

            lbl_1_precio1.Visible = False
            txt_1_desc.Visible = False

            lbl_1_precio2.Visible = False
            txt_1_material.Visible = False

            btn_configurar.Visible = False

        ElseIf (cmb_1_forma.Text = "Mes") Then
            txt_1_identificacion.Text = "Identificación Equipos y Arrendadores (Pago por Mes)"
            gp_1_identificacion.Visible = True
            gp_parametros.Visible = True

            lbl_1_mes.Visible = True
            cmb_1_jornada.Visible = True
            txt_1_mes.Visible = True

            txt_1_precio.Visible = False

            lbl_1_precio.Visible = False
            txt_1_min.Visible = False

            lbl_1_precio1.Visible = False
            txt_1_desc.Visible = False

            lbl_1_precio2.Visible = False
            txt_1_material.Visible = False

            btn_configurar.Visible = False

        ElseIf (cmb_1_forma.Text = "Hora") Then
            txt_1_identificacion.Text = "Identificación Equipos y Arrendadores (Pago por Hora)"

            gp_1_identificacion.Visible = True
            gp_parametros.Visible = True

            lbl_1_mes.Visible = True
            cmb_1_jornada.Visible = True
            txt_1_mes.Visible = True

            txt_1_precio.Visible = True

            lbl_1_precio.Visible = True
            txt_1_min.Visible = True
            lbl_1_precio1.Text = "% Descuento por Horas Superiores al Mínimo *"

            lbl_1_precio1.Visible = True
            txt_1_desc.Visible = True
            lbl_1_precio.Text = "Horas Mínimas *"

            lbl_1_precio2.Visible = False
            txt_1_material.Visible = False

            btn_configurar.Visible = False

        ElseIf (cmb_1_forma.Text = "M3") Then
            txt_1_identificacion.Text = "Identificación Equipos y Arrendadores (Pago por Producción)"
            gp_1_identificacion.Visible = True

            lbl_1_mes.Visible = True
            cmb_1_jornada.Visible = True
            txt_1_mes.Visible = True

            txt_1_precio.Visible = True

            lbl_1_precio.Visible = True
            txt_1_min.Visible = True
            lbl_1_precio1.Text = "% Descuento por M3 Superiores al Mínimo *"

            lbl_1_precio1.Visible = True
            txt_1_desc.Visible = True
            lbl_1_precio.Text = "M3 Mínimos *"

            lbl_1_precio2.Visible = True
            txt_1_material.Visible = True
            lbl_1_precio2.Text = "Material Extraido"

            btn_configurar.Visible = False

        ElseIf (cmb_1_forma.Text = "M2") Then
            txt_1_identificacion.Text = "Identificación Equipos y Arrendadores (Pago por Producción)"
            gp_1_identificacion.Visible = True

            lbl_1_mes.Visible = True
            cmb_1_jornada.Visible = True
            txt_1_mes.Visible = True

            txt_1_precio.Visible = True

            lbl_1_precio.Visible = True
            txt_1_min.Visible = True
            lbl_1_precio1.Text = "% Descuento por M2 Superiores al Mínimo *"

            lbl_1_precio1.Visible = True
            txt_1_desc.Visible = True
            lbl_1_precio.Text = "M2 Mínimos *"

            lbl_1_precio2.Visible = True
            txt_1_material.Visible = True
            lbl_1_precio2.Text = "Material Extraido"

            btn_configurar.Visible = False

        ElseIf (cmb_1_forma.Text = "M3-KM") Then
            txt_1_identificacion.Text = "Identificación Equipos y Arrendadores (Pago por M3-KM)"
            gp_1_identificacion.Visible = True

            lbl_1_mes.Visible = True
            cmb_1_jornada.Visible = True
            txt_1_mes.Visible = True

            txt_1_precio.Visible = True

            lbl_1_precio.Visible = True
            txt_1_min.Visible = True
            lbl_1_precio1.Text = "% Descuento por KM Superiores al Mínimo *"

            lbl_1_precio1.Visible = True
            txt_1_desc.Visible = True
            lbl_1_precio.Text = "KM Mínimos *"

            lbl_1_precio2.Visible = True
            txt_1_material.Visible = True
            lbl_1_precio2.Text = "Material Transportado"

            btn_configurar.Visible = True

        ElseIf (cmb_1_forma.Text = "Viajes") Then
            txt_1_identificacion.Text = "Identificación Equipos y Arrendadores (Pago por Viaje)"
            gp_1_identificacion.Visible = True

            lbl_1_mes.Visible = True
            cmb_1_jornada.Visible = True
            txt_1_mes.Visible = True

            txt_1_precio.Visible = True

            lbl_1_precio.Visible = True
            txt_1_min.Visible = True
            lbl_1_precio1.Text = "% Descuento por Viajes Superiores al Mínimo *"

            lbl_1_precio1.Visible = True
            txt_1_desc.Visible = True
            lbl_1_precio.Text = "Viajes Mínimos *"

            lbl_1_precio2.Visible = True
            txt_1_material.Visible = True
            lbl_1_precio2.Text = "Material Transportado"

            btn_configurar.Visible = True

        Else
            gp_1_identificacion.Visible = False

            lbl_1_mes.Visible = True
            cmb_1_jornada.Visible = True
            txt_1_mes.Visible = True

            txt_1_precio.Visible = True

            lbl_1_precio.Visible = True
            txt_1_min.Visible = True
            lbl_1_precio1.Text = "% Descuento por Km Superiores al Mínimo *"

            lbl_1_precio1.Visible = True
            txt_1_desc.Visible = True
            lbl_1_precio.Text = "Km Mínimos *"

            lbl_1_precio2.Visible = True
            txt_1_material.Visible = True
            lbl_1_precio2.Text = "Material Transportado"

            btn_configurar.Visible = False
        End If
        If cmb_1_forma.Text = "M3-KM" And Not IsNumeric(txt_1_capacidad.Text) Then
            txt_1_capacidad.Clear()
            MsgBox("Para el tipo de pago seleccionado tiene que agregar una capacidad sólo en formato numérico.")
        End If
    End Sub
    Private Sub cmb_1_tipo_equipo_TextChanged(sender As Object, e As EventArgs) Handles cmb_1_tipo_equipo.TextChanged
        If cmb_1_tipo_equipo.Text = "Otros" Then
            txt_1_detalle_equipo.Clear()
            txt_1_detalle_equipo.Enabled = True
        Else
            txt_1_detalle_equipo.Text = cmb_1_tipo_equipo.Text
            txt_1_detalle_equipo.Enabled = False
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
        cmb_4_arrendador.DataSource = nue_obra4.listar3(id_obra)
        cmb_4_arrendador.DisplayMember = "razon_social"
        cmb_4_arrendador.ValueMember = "rut"
    End Sub
    Public Sub actualiza_arrendador5()
        cmb_5_arrendador.DataSource = nue_obra5.listar3(id_obra)
        cmb_5_arrendador.DisplayMember = "razon_social"
        cmb_5_arrendador.ValueMember = "rut"
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
        cmb_8_arrendador.DataSource = nue_obra8.listar3(id_obra)
        cmb_8_arrendador.DisplayMember = "razon_social"
        cmb_8_arrendador.ValueMember = "rut"
    End Sub
    Private Sub txt_1_razon_social_TextChanged(sender As Object, e As EventArgs) Handles txt_1_razon_social.TextChanged
        If Len(txt_1_razon_social.Text) > 0 Then
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

                txt_1_rut.Text = dgv_arrendador.Rows(0).Cells(5).Value.ToString()
                txt_1_domicilio.Text = dgv_arrendador.Rows(0).Cells(6).Value.ToString()
                txt_1_representante.Text = dgv_arrendador.Rows(0).Cells(8).Value.ToString()
                txt_1_rut_representante.Text = dgv_arrendador.Rows(0).Cells(9).Value.ToString()
                Cod_11 = dgv_arrendador.Rows(0).Cells(0).Value.ToString()
                version_mod11 = CInt(dgv_arrendador.Rows(0).Cells(2).Value.ToString())
                existe_rut = 0
                sincroniza_local = CInt(dgv_arrendador.Rows(0).Cells(1).Value.ToString())

            Else
                txt_1_rut.Clear()
                txt_1_rut.Enabled = True

                txt_1_domicilio.Clear()
                txt_1_domicilio.Enabled = True

                txt_1_representante.Clear()
                txt_1_representante.Enabled = True

                txt_1_rut_representante.Clear()
                txt_1_rut_representante.Enabled = True
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
            existe_rut = 1
        End If
    End Sub
    Private Sub dgv_1_maquinas_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_1_maquinas.MouseClick
        Cod_1 = dgv_1_maquinas.CurrentRow.Cells(4).Value.ToString()

        txt_1_domicilio.Text = dgv_1_maquinas.CurrentRow.Cells(0).Value.ToString()
        txt_1_razon_social.Text = dgv_1_maquinas.CurrentRow.Cells(1).Value.ToString()
        txt_1_representante.Text = dgv_1_maquinas.CurrentRow.Cells(2).Value.ToString()
        txt_1_rut_representante.Text = dgv_1_maquinas.CurrentRow.Cells(3).Value.ToString()
        txt_1_rut.Text = dgv_1_maquinas.CurrentRow.Cells(9).Value.ToString()

        txt_1_precio_un.Text = dgv_1_maquinas.CurrentRow.Cells(25).Value.ToString()
        txt_1_max_dias.Text = dgv_1_maquinas.CurrentRow.Cells(29).Value.ToString()
        txt_1_min.Text = dgv_1_maquinas.CurrentRow.Cells(31).Value.ToString()
        txt_1_desc.Text = dgv_1_maquinas.CurrentRow.Cells(32).Value.ToString()
        txt_1_dia_cierre.Text = dgv_1_maquinas.CurrentRow.Cells(11).Value.ToString()
        txt_1_dia_cierre_ep.Text = dgv_1_maquinas.CurrentRow.Cells(12).Value.ToString()

        'cmb_1_forma.Text = dgv_1_maquinas.CurrentRow.Cells(10).Value.ToString()
        cmb_1_codigo.Text = dgv_1_maquinas.CurrentRow.Cells(13).Value.ToString()
        cmb_1_tipo_equipo.Text = dgv_1_maquinas.CurrentRow.Cells(14).Value.ToString()
        txt_1_detalle_equipo.Text = dgv_1_maquinas.CurrentRow.Cells(15).Value.ToString()
        txt_1_marca.Text = dgv_1_maquinas.CurrentRow.Cells(16).Value.ToString()
        txt_1_modelo.Text = dgv_1_maquinas.CurrentRow.Cells(17).Value.ToString()
        txt_1_patente.Text = dgv_1_maquinas.CurrentRow.Cells(18).Value.ToString()
        txt_1_num_motor.Text = dgv_1_maquinas.CurrentRow.Cells(19).Value.ToString()
        txt_1_capacidad.Text = dgv_1_maquinas.CurrentRow.Cells(20).Value.ToString()
        cmb_1_obra.Text = dgv_1_maquinas.CurrentRow.Cells(21).Value.ToString()
        cmb_1_operador.Text = dgv_1_maquinas.CurrentRow.Cells(22).Value.ToString()
        cmb_1_horometro.Text = dgv_1_maquinas.CurrentRow.Cells(23).Value.ToString()
        cmb_1_un_pago.Text = dgv_1_maquinas.CurrentRow.Cells(24).Value.ToString()
        cmb_1_cuenta_maq.Text = dgv_1_maquinas.CurrentRow.Cells(26).Value.ToString()
        cmb_1_cuenta_petro.Text = dgv_1_maquinas.CurrentRow.Cells(27).Value.ToString()
        cmb_1_recupera.Text = dgv_1_maquinas.CurrentRow.Cells(28).Value.ToString()
        cmb_1_jornada.Text = dgv_1_maquinas.CurrentRow.Cells(30).Value.ToString()
        txt_1_material.Text = dgv_1_maquinas.CurrentRow.Cells(33).Value.ToString()
        cmb_1_forma.Text = dgv_1_maquinas.CurrentRow.Cells(10).Value.ToString()
        If CInt(dgv_1_maquinas.CurrentRow.Cells(34).Value.ToString()) = 1 Then
            cmb_1_turno.Text = "Jornada Simple"
        ElseIf CInt(dgv_1_maquinas.CurrentRow.Cells(34).Value.ToString()) = 2 Then
            cmb_1_turno.Text = "Jornada Doble"
        End If

        txt_1_rendimientos.Text = dgv_1_maquinas.CurrentRow.Cells(35).Value.ToString()

        sincroniza_local_1 = CInt(dgv_1_maquinas.CurrentRow.Cells(5).Value.ToString())
        version_mod1 = CInt(dgv_1_maquinas.CurrentRow.Cells(6).Value.ToString())
        sincroniza_mod1 = 2
    End Sub

    Private Sub txt_1_dia_cierre_ep_TextChanged(sender As Object, e As EventArgs) Handles txt_1_dia_cierre_ep.TextChanged
        If Not IsNumeric(txt_1_dia_cierre_ep.Text) Then
            txt_1_dia_cierre_ep.Clear()
        End If
    End Sub

    Private Sub txt_1_dia_cierre_TextChanged(sender As Object, e As EventArgs) Handles txt_1_dia_cierre.TextChanged
        If Not IsNumeric(txt_1_dia_cierre.Text) Then
            txt_1_dia_cierre.Clear()
        End If
    End Sub
    Public Sub actualiza_obras()
        cmb_1_obra.DataSource = nue_obra1.listar5(id_obra)
        cmb_1_obra.DisplayMember = "nombre_faena"
        cmb_1_obra.ValueMember = "nombre_faena"
    End Sub
    ''Public Sub actualiza_obras4()
    ''    cmb_4_obra.DataSource = nue_obra4.listar5(id_obra)
    ''    cmb_4_obra.DisplayMember = "nombre_faena"
    ''    cmb_4_obra.ValueMember = "nombre_faena"
    ''End Sub
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
        fecha_consulta = Me.dtp_fecha.Value
        fecha_consulta_str = Format(fecha_consulta, "yyyy/MM/dd")

        dgv_equipos.DataSource = Nothing

        dgv_equipos.DataSource = nue_obra2.listar6(fecha_consulta_str, id_obra)
    End Sub
    Private Sub dgv_datosAgregados_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados.CellEndEdit
        If dgv_datosAgregados.Rows.Count > 1 Then
            If e.ColumnIndex = 6 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column4").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column4").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 7 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 8 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 9 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 10 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 11 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 12 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 13 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column13").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column13").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 14 Then
                Dim num_observacion2 As Integer

                num_observacion2 = Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("operador").Value)

                If Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("operador").Value) <> num_observacion2 And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("operador").Value) <> num_observacion2 And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                ElseIf Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("operador").Value) = num_observacion2 And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column4").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("operador").Value) = num_observacion2 And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column4").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
            If e.ColumnIndex = 15 Then
                Dim num_observacion As Integer

                num_observacion = Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Value)

                If Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Value) <> num_observacion And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Value) <> num_observacion And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                ElseIf Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Value) = num_observacion And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column4").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf Len(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Value) = num_observacion And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column4").Value) Then
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
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Column7" Then
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
            consultar = MsgBox("Usted no ha guardado los reports, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
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
            consultar = MsgBox("Usted no ha guardado los reports, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
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
        Dim fecha_inicio_consulta, fecha_final_consulta As Date
        Dim fecha_inicio_str, fecha_final_str As String
        Dim rtn As New Date
        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 24).AddMonths(-2)

        fecha_inicio_consulta = rtn
        fecha_final_consulta = Today
        fecha_inicio_str = Format(fecha_inicio_consulta, "yyyy/MM/dd")
        fecha_final_str = Format(fecha_final_consulta, "yyyy/MM/dd")

        dgv_equipos.DataSource = Nothing

        dgv_equipos.DataSource = nue_obra2.listar7(fecha_inicio_str, fecha_final_str, id_obra, CInt(cmb_equipo.SelectedValue.ToString()))
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
                dgv_datosAgregados.Rows(i).Cells(8).Value = dgv_equipos.Rows(i).Cells(8).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(9).Value = dgv_equipos.Rows(i).Cells(9).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(10).Value = dgv_equipos.Rows(i).Cells(10).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(11).Value = dgv_equipos.Rows(i).Cells(11).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(12).Value = dgv_equipos.Rows(i).Cells(12).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(13).Value = dgv_equipos.Rows(i).Cells(13).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(14).Value = dgv_equipos.Rows(i).Cells(14).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(15).Value = dgv_equipos.Rows(i).Cells(15).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(17).Value = dgv_equipos.Rows(i).Cells(17).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(18).Value = dgv_equipos.Rows(i).Cells(18).Value.ToString()
                dgv_datosAgregados.Rows(i).Cells(19).Value = dgv_equipos.Rows(i).Cells(19).Value.ToString()
            Next i
        End If
        For Each r As DataGridViewRow In dgv_datosAgregados.Rows
            If r.Cells(3).Value.ToString = "No Tiene" Then
                r.Cells(8).ReadOnly = True
                r.Cells(8).Style.BackColor = Color.Gray
                r.Cells(9).ReadOnly = True
                r.Cells(9).Style.BackColor = Color.Gray
                r.Cells(10).ReadOnly = True
                r.Cells(10).Style.BackColor = Color.Gray
                r.Cells(11).ReadOnly = False
                r.Cells(11).Style.BackColor = Color.White
            Else
                r.Cells(8).ReadOnly = False
                r.Cells(8).Style.BackColor = Color.White
                r.Cells(9).ReadOnly = False
                r.Cells(9).Style.BackColor = Color.White
                r.Cells(10).ReadOnly = False
                r.Cells(10).Style.BackColor = Color.White
                r.Cells(11).ReadOnly = True
                r.Cells(11).Style.BackColor = Color.Gray
            End If
        Next

        For Each r As DataGridViewRow In dgv_datosAgregados.Rows
            If r.Cells(4).Value.ToString = "Hora" Or r.Cells(4).Value.ToString = "Mes" Or r.Cells(4).Value.ToString = "Dia" Then
                r.Cells(12).ReadOnly = True
                r.Cells(12).Style.BackColor = Color.Gray
                r.Cells(13).ReadOnly = True
                r.Cells(13).Style.BackColor = Color.Gray
            ElseIf r.Cells(4).Value.ToString = "M3-KM" Then
                r.Cells(12).ReadOnly = True
                r.Cells(12).Style.BackColor = Color.Gray
                r.Cells(13).ReadOnly = False
                r.Cells(13).Style.BackColor = Color.White
            ElseIf r.Cells(4).Value.ToString = "M3" Then
                r.Cells(13).ReadOnly = True
                r.Cells(13).Style.BackColor = Color.Gray
                r.Cells(12).ReadOnly = False
                r.Cells(12).Style.BackColor = Color.White
            Else
                r.Cells(12).ReadOnly = False
                r.Cells(12).Style.BackColor = Color.White
                r.Cells(13).ReadOnly = False
                r.Cells(13).Style.BackColor = Color.White
            End If
        Next

        'If sincroniza = 1 Then
        '    For Each r As DataGridViewRow In dgv_datosAgregados.Rows
        '        If IsNumeric(r.Cells(0).Value.ToString) And IsNumeric(r.Cells(19).Value.ToString) Then
        '            If CInt(r.Cells(19).Value.ToString) <> 1 Then
        '                r.Cells(5).ReadOnly = True
        '                r.Cells(5).Style.BackColor = Color.Gray
        '                r.Cells(6).ReadOnly = True
        '                r.Cells(6).Style.BackColor = Color.Gray
        '                r.Cells(7).ReadOnly = True
        '                r.Cells(7).Style.BackColor = Color.Gray
        '                r.Cells(8).ReadOnly = True
        '                r.Cells(8).Style.BackColor = Color.Gray
        '                r.Cells(9).ReadOnly = True
        '                r.Cells(9).Style.BackColor = Color.Gray
        '                r.Cells(10).ReadOnly = True
        '                r.Cells(10).Style.BackColor = Color.Gray
        '                r.Cells(11).ReadOnly = True
        '                r.Cells(11).Style.BackColor = Color.Gray
        '                r.Cells(12).ReadOnly = True
        '                r.Cells(12).Style.BackColor = Color.Gray
        '                r.Cells(13).ReadOnly = True
        '                r.Cells(13).Style.BackColor = Color.Gray
        '                r.Cells(14).ReadOnly = True
        '                r.Cells(14).Style.BackColor = Color.Gray
        '                r.Cells(15).ReadOnly = True
        '                r.Cells(15).Style.BackColor = Color.Gray
        '            End If
        '        End If
        '    Next
        'End If

        If sincroniza = 1 And modifica_local = 1 Then
            For Each r As DataGridViewRow In dgv_datosAgregados.Rows
                If IsNumeric(r.Cells(0).Value.ToString) And IsNumeric(r.Cells(19).Value.ToString) Then
                    If CInt(r.Cells(19).Value.ToString) <> 1 Then
                        ' r.Cells(5).ReadOnly = True
                        r.Cells(5).Style.BackColor = Color.LightGreen
                        'r.Cells(6).ReadOnly = True
                        r.Cells(6).Style.BackColor = Color.LightGreen
                        ' r.Cells(7).ReadOnly = True
                        r.Cells(7).Style.BackColor = Color.LightGreen
                        'r.Cells(8).ReadOnly = True
                        r.Cells(8).Style.BackColor = Color.LightGreen
                        ' r.Cells(9).ReadOnly = True
                        r.Cells(9).Style.BackColor = Color.LightGreen
                        'r.Cells(10).ReadOnly = True
                        r.Cells(10).Style.BackColor = Color.LightGreen
                        'r.Cells(11).ReadOnly = True
                        r.Cells(11).Style.BackColor = Color.LightGreen
                        ' r.Cells(12).ReadOnly = True
                        r.Cells(12).Style.BackColor = Color.LightGreen
                        'r.Cells(13).ReadOnly = True
                        r.Cells(13).Style.BackColor = Color.LightGreen
                        'r.Cells(14).ReadOnly = True
                        r.Cells(14).Style.BackColor = Color.LightGreen
                        'r.Cells(15).ReadOnly = True
                        r.Cells(15).Style.BackColor = Color.LightGreen
                    End If
                End If
            Next
        End If
    End Sub
    Public Sub actualiza_equipos()
        cmb_equipo.DataSource = nue_obra1.listar2(id_obra)
        cmb_equipo.DisplayMember = "codigo"
        cmb_equipo.ValueMember = "id_equipo"
    End Sub
    Public Sub actualiza_cuentas_maquinaria()
        cmb_1_cuenta_maq.DataSource = nue_obra1.listar6(id_obra)
        cmb_1_cuenta_maq.DisplayMember = "Cuenta_costo"
        cmb_1_cuenta_maq.ValueMember = "Cuenta_costo"
    End Sub
    Public Sub actualiza_cuentas_petroleo()
        cmb_1_cuenta_petro.DataSource = nue_obra1.listar7(id_obra)
        cmb_1_cuenta_petro.DisplayMember = "Cuenta_costo"
        cmb_1_cuenta_petro.ValueMember = "Cuenta_costo"
    End Sub

    Private Sub dgv_datosAgregados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados.CellValueChanged
        If dgv_datosAgregados.Rows.Count > 1 Then
            If e.ColumnIndex = 8 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) Then
                    If (dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) <= 24 And (dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) >= 0 Then
                        If Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value) Then
                            dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value = 0
                        End If
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value

                        If (dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value) < 0 Then
                            dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = "NULO"
                            dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                        End If
                    Else
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = "NULO"
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                    End If
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = ""
                End If
            ElseIf e.ColumnIndex = 9 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) Then
                    If (dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) <= 24 And (dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) >= 0 Then
                        If Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value) Then
                            dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value = 0
                        End If

                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value
                        If (dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value) < 0 Then
                            dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = "NULO"
                            dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                        End If
                    Else
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = "NULO"
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                    End If
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = ""
                End If
            ElseIf e.ColumnIndex = 10 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) Then
                    If (dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) <= 24 And (dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value) >= 0 Then
                        If Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value) Then
                            dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value = 0
                        End If

                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value
                        If (dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Value - dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Value) < 0 Then
                            dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = "NULO"
                            dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                        End If
                    Else
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = "NULO"
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                    End If
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Value = ""
                End If
            ElseIf e.ColumnIndex = 6 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column4").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Value = 1
                End If

            End If
        End If
    End Sub

    Private Sub btn_tabla_Click(sender As Object, e As EventArgs) Handles btn_tabla.Click

        If dgv_datosAgregados.Rows.Count > 0 Then
            For i = 0 To dgv_datosAgregados.Rows.Count - 1
                Dim fecha As Date
                Dim num_report, dia, hor_inicial, hor_final, horas_desc, horas_efec, m3, distancia, horas_totales As Double
                Dim obs, codigo, operador As String
                Dim id, id_equipo, turno, verificar_registro As Integer
                Dim version As Integer

                If IsNumeric(dgv_datosAgregados.Rows(i).Cells(16).Value) And IsNumeric(dgv_datosAgregados.Rows(i).Cells(6).Value) Then
                    fecha = CDate(dgv_datosAgregados.Rows(i).Cells(1).Value.ToString())

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(5).Value.ToString()) Then
                        turno = CInt(dgv_datosAgregados.Rows(i).Cells(5).Value.ToString())
                    Else
                        turno = 0
                    End If

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(6).Value.ToString()) Then
                        num_report = CDbl(dgv_datosAgregados.Rows(i).Cells(6).Value.ToString())
                    Else
                        num_report = 0
                    End If

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(7).Value.ToString()) Then
                        dia = CDbl(dgv_datosAgregados.Rows(i).Cells(7).Value.ToString())
                    Else
                        dia = 1
                    End If

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(8).Value.ToString()) Then
                        hor_inicial = CDbl(dgv_datosAgregados.Rows(i).Cells(8).Value.ToString())
                    Else
                        hor_inicial = 0
                    End If

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(9).Value.ToString()) Then
                        hor_final = CDbl(dgv_datosAgregados.Rows(i).Cells(9).Value.ToString())
                    Else
                        hor_final = 0
                    End If

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(10).Value.ToString()) Then
                        horas_desc = CDbl(dgv_datosAgregados.Rows(i).Cells(10).Value.ToString())
                    Else
                        horas_desc = 0
                    End If

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(11).Value.ToString()) Then
                        horas_efec = CDbl(dgv_datosAgregados.Rows(i).Cells(11).Value.ToString())
                    Else
                        horas_efec = 0
                    End If

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(12).Value.ToString()) Then
                        m3 = CDbl(dgv_datosAgregados.Rows(i).Cells(12).Value.ToString())
                    Else
                        m3 = 0
                    End If

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(13).Value.ToString()) Then
                        distancia = CDbl(dgv_datosAgregados.Rows(i).Cells(13).Value.ToString())
                    Else
                        distancia = 0
                    End If

                    If IsNothing(dgv_datosAgregados.Rows(i).Cells(14).Value) Then
                        operador = ""
                    Else
                        operador = dgv_datosAgregados.Rows(i).Cells(14).Value.ToString()
                    End If

                    If IsNothing(dgv_datosAgregados.Rows(i).Cells(15).Value) Then
                        obs = ""
                    Else
                        obs = dgv_datosAgregados.Rows(i).Cells(15).Value.ToString()
                    End If

                    horas_totales = horas_efec + horas_desc

                    id_equipo = CInt(dgv_datosAgregados.Rows(i).Cells(17).Value.ToString())
                    codigo = dgv_datosAgregados.Rows(i).Cells(2).Value.ToString()

                    If dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 1 Then
                        verificar_registro = nue_obra2.verificar_registro(id_obra, fecha, codigo, num_report, turno)
                    Else
                        verificar_registro = 1
                    End If

                    If verificar_registro = 0 Or dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 2 Or dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 3 Then

                        If dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 1 Then
                            nue_obra2.insertar_report(1, 0, Nombre_Obra, id_obra, fecha, codigo, num_report, dia, hor_inicial, hor_final, horas_totales, horas_desc, horas_efec, m3, distancia, obs, id_equipo, operador, turno)

                        ElseIf dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 2 And sincroniza = 0 Then
                            id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                            version_mod2 = CInt(dgv_datosAgregados.Rows(i).Cells(18).Value.ToString()) + 1
                            nue_obra2.modificar_report(CInt(id), 2, version_mod2, Nombre_Obra, id_obra, fecha, codigo, num_report, dia, hor_inicial, hor_final, horas_totales, horas_desc, horas_efec, m3, distancia, obs, id_equipo, operador, turno)

                        ElseIf dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 3 And sincroniza = 0 Then

                            id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                            version_mod2 = CInt(dgv_datosAgregados.Rows(i).Cells(18).Value.ToString()) + 1
                            nue_obra2.modificar_report(CInt(id), 3, version_mod2, Nombre_Obra, id_obra, fecha, "AA-EL", num_report, dia, hor_inicial, hor_final, horas_totales, horas_desc, horas_efec, m3, distancia, obs + "-" + codigo, id_equipo, operador, turno)


                            ElseIf dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 2 And dgv_datosAgregados.Rows(i).Cells(19).Value.ToString() = 1 And sincroniza = 1 Then
                                id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                                nue_obra2.modificar_report(CInt(id), 1, 0, Nombre_Obra, id_obra, fecha, codigo, num_report, dia, hor_inicial, hor_final, horas_totales, horas_desc, horas_efec, m3, distancia, obs, id_equipo, operador, turno)

                            ElseIf dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 2 And dgv_datosAgregados.Rows(i).Cells(19).Value.ToString() <> 1 And sincroniza = 1 Then
                                id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                                version_mod2 = CInt(dgv_datosAgregados.Rows(i).Cells(18).Value.ToString()) + 1
                                nue_obra2.modificar_report(CInt(id), 2, version_mod2, Nombre_Obra, id_obra, fecha, codigo, num_report, dia, hor_inicial, hor_final, horas_totales, horas_desc, horas_efec, m3, distancia, obs, id_equipo, operador, turno)

                            ElseIf dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 3 And dgv_datosAgregados.Rows(i).Cells(19).Value.ToString() = 1 And sincroniza = 1 Then
                                id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                                nue_obra2.eliminar_report(CInt(id))

                            ElseIf dgv_datosAgregados.Rows(i).Cells(16).Value.ToString() = 3 And dgv_datosAgregados.Rows(i).Cells(19).Value.ToString() <> 1 And sincroniza = 1 Then

                            id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                            version_mod2 = CInt(dgv_datosAgregados.Rows(i).Cells(18).Value.ToString()) + 1
                            nue_obra2.modificar_report(CInt(id), 3, version_mod2, Nombre_Obra, id_obra, fecha, "AA-EL", num_report, dia, hor_inicial, hor_final, horas_totales, horas_desc, horas_efec, m3, distancia, obs + "-" + codigo, id_equipo, operador, turno)

                        End If
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
        dgv_3_trabajos_adicionales.Columns(5).HeaderText = "Nombre Arrendador"
        dgv_3_trabajos_adicionales.Columns(5).Width = 150
        dgv_3_trabajos_adicionales.Columns(6).Visible = False
        dgv_3_trabajos_adicionales.Columns(7).HeaderText = "Clasificación"
        dgv_3_trabajos_adicionales.Columns(7).Width = 130
        dgv_3_trabajos_adicionales.Columns(8).HeaderText = "Descripción"
        dgv_3_trabajos_adicionales.Columns(8).Width = 200
        dgv_3_trabajos_adicionales.Columns(9).HeaderText = "Cant."
        dgv_3_trabajos_adicionales.Columns(9).Width = 60
        dgv_3_trabajos_adicionales.Columns(9).DefaultCellStyle.Format = "##,###.##"
        dgv_3_trabajos_adicionales.Columns(10).Visible = False
        'dgv_3_trabajos_adicionales.Columns(10).HeaderText = "Unidad"
        'dgv_3_trabajos_adicionales.Columns(10).Width = 100
        dgv_3_trabajos_adicionales.Columns(11).HeaderText = "Precio Unitario"
        dgv_3_trabajos_adicionales.Columns(11).Width = 90
        dgv_3_trabajos_adicionales.Columns(11).DefaultCellStyle.Format = "##,###.##"
        dgv_3_trabajos_adicionales.Columns(12).HeaderText = "Total"
        dgv_3_trabajos_adicionales.Columns(12).Width = 100
        dgv_3_trabajos_adicionales.Columns(12).DefaultCellStyle.Format = "##,###.##"
        dgv_3_trabajos_adicionales.Columns(13).Visible = False
        dgv_3_trabajos_adicionales.Columns(14).HeaderText = "Fecha"
        dgv_3_trabajos_adicionales.Columns(14).Width = 100

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

        cmb_3_arrendador.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(5).Value.ToString()
        cmb_3_clasificacion.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(7).Value.ToString()
        txt_3_descripcion.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(8).Value.ToString()
        txt_3_cantidad.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(9).Value.ToString()
        cmb_3_un_pago.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(10).Value.ToString()
        txt_3_precio.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(11).Value.ToString()
        txt_3_total.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(12).Value.ToString()
        cmb_3_cuenta_contable.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(13).Value.ToString()
        dtp_3_fecha.Text = dgv_3_trabajos_adicionales.CurrentRow.Cells(14).Value.ToString()

        txt_3_total.Text = FormatNumber(txt_3_total.Text, 0)
        sincroniza_local3 = CInt(dgv_3_trabajos_adicionales.CurrentRow.Cells(1).Value.ToString())
        version_mod3 = CInt(dgv_3_trabajos_adicionales.CurrentRow.Cells(2).Value.ToString())
        sincroniza_mod3 = 2
    End Sub
    Public Sub actualiza_cuentas_trabajo()
        cmb_3_cuenta_contable.DataSource = nue_obra3.listar6(id_obra)
        cmb_3_cuenta_contable.DisplayMember = "Cuenta_costo"
        cmb_3_cuenta_contable.ValueMember = "Cuenta_costo"
    End Sub

    Public Sub actualiza_arrendador3()
        cmb_3_arrendador.DataSource = nue_obra3.listar7(id_obra)
        cmb_3_arrendador.DisplayMember = "razon_social"
        cmb_3_arrendador.ValueMember = "rut"
    End Sub

    Private Sub btn_4_generar_Click(sender As Object, e As EventArgs) Handles btn_4_generar.Click
        Dim verificar As Integer
        verificar = 0

        For i = 0 To check_empresa.Items.Count - 1
            If (check_empresa.GetItemChecked(i)) Then
                verificar = contador + 1
            End If
        Next

        If txt_4_lugar.Text <> "" And cmb_4_tipo_pago.Text <> "" And cmb_4_arrendador.Text <> "" And verificar > 0 Then
            extrae_datos()
            If dgv_4_equipos2.Rows.Count > 0 And dgv_4_obras.Rows.Count > 0 Then
                Dim contador As Integer
                contador = 0
                For i = 0 To dgv_4_obras.Rows.Count - 2
                    If chk_4_obras.GetItemChecked(i) Then
                        obra = chk_4_obras.Items(i)
                        Genera_word()
                        contador = 1
                    Else
                    End If
                Next i
                If contador = 0 Then
                    MessageBox.Show("TIENE QUE SELECCIONAR MÍNIMO UNA OBRA")
                End If
            Else
                MessageBox.Show("FALTAN DATOS PARA GENERAR EL CONTRATO")
            End If
        Else
            MessageBox.Show("FALTAN DATOS PARA GENERAR EL CONTRATO")
        End If
    End Sub
    Public Sub actualizar_check()
        Dim equipo As String
        Dim operador As String
        If cmb_4_operador.Text = "Con Operador" Then
            operador = "Si"
        Else
            operador = "No"
        End If
        check_empresa.Items.Clear()
        dgv_4_equipos.DataSource = nue_obra4.listar2(id_obra, cmb_4_tipo_pago.Text, operador, cmb_4_arrendador.SelectedValue.ToString())

        If dgv_4_equipos.Rows.Count > 0 Then
            For i = 0 To dgv_4_equipos.Rows.Count - 2
                equipo = dgv_4_equipos.Rows(i).Cells(6).Value.ToString()
                check_empresa.Items.Add(equipo)
            Next i
        End If
    End Sub
    Public Sub actualizar_obras()
        Dim obra4 As String
        chk_4_obras.Items.Clear()
        dgv_4_obras.DataSource = nue_obra4.listar14(id_obra)

        If dgv_4_obras.Rows.Count > 0 Then
            For i = 0 To dgv_4_obras.Rows.Count - 2
                obra4 = dgv_4_obras.Rows(i).Cells(5).Value.ToString()
                chk_4_obras.Items.Add(obra4)
            Next i
        End If
    End Sub

    Public Sub actualizar_check2()
        Dim equipo As String
        Dim operador As String
        If cmb_5_operador.Text = "Con Operador" Then
            operador = "Si"
        Else
            operador = "No"
        End If
        check_5_empresa.Items.Clear()
        dgv_5_equipos.DataSource = nue_obra5.listar2(id_obra, cmb_5_tipo_pago.Text, operador, cmb_5_obra.Text, cmb_5_arrendador.SelectedValue.ToString())

        If dgv_5_equipos.Rows.Count > 0 Then
            For i = 0 To dgv_5_equipos.Rows.Count - 2
                equipo = dgv_5_equipos.Rows(i).Cells(6).Value.ToString()
                check_5_empresa.Items.Add(equipo)
            Next i
        End If
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
    Public Sub extrae_datos()
        Dim i As Integer
        'Dim Z As Integer
        Dim equipo1, equipo2, equipo3, equipo4, equipo5, equipo6, equipo7, equipo8 As Integer

        contador = 0


        'For Z = 0 To 19
        '    valor(Z) = ""
        'Next

        For i = 0 To check_empresa.Items.Count - 1
            If (check_empresa.GetItemChecked(i)) Then
                contador = contador + 1
                valor(i) = check_empresa.Items(i)
                Dim Cadena As String = valor(i)
                Dim ArrCadena As String() = Cadena.Split(" / ")

                If contador = 1 Then
                    equipo1 = CInt(ArrCadena(0))
                ElseIf contador = 2 Then
                    equipo2 = CInt(ArrCadena(0))
                ElseIf contador = 3 Then
                    equipo3 = CInt(ArrCadena(0))
                ElseIf contador = 4 Then
                    equipo4 = CInt(ArrCadena(0))
                ElseIf contador = 5 Then
                    equipo5 = CInt(ArrCadena(0))
                ElseIf contador = 6 Then
                    equipo6 = CInt(ArrCadena(0))
                ElseIf contador = 7 Then
                    equipo7 = CInt(ArrCadena(0))
                ElseIf contador = 8 Then
                    equipo8 = CInt(ArrCadena(0))
                End If
            End If
        Next
        dgv_4_equipos2.DataSource = Nothing

        If contador = 1 Then
            dgv_4_equipos2.DataSource = nue_obra4.listar6(id_obra, equipo1)
        ElseIf contador = 2 Then
            dgv_4_equipos2.DataSource = nue_obra4.listar7(id_obra, equipo1, equipo2)
        ElseIf contador = 3 Then
            dgv_4_equipos2.DataSource = nue_obra4.listar8(id_obra, equipo1, equipo2, equipo3)
        ElseIf contador = 4 Then
            dgv_4_equipos2.DataSource = nue_obra4.listar9(id_obra, equipo1, equipo2, equipo3, equipo4)
        ElseIf contador = 5 Then
            dgv_4_equipos2.DataSource = nue_obra4.listar10(id_obra, equipo1, equipo2, equipo3, equipo4, equipo5)
        ElseIf contador = 6 Then
            dgv_4_equipos2.DataSource = nue_obra4.listar11(id_obra, equipo1, equipo2, equipo3, equipo4, equipo5, equipo6)
        ElseIf contador = 7 Then
            dgv_4_equipos2.DataSource = nue_obra4.listar12(id_obra, equipo1, equipo2, equipo3, equipo4, equipo5, equipo6, equipo7)
        ElseIf contador = 8 Then
            dgv_4_equipos2.DataSource = nue_obra4.listar13(id_obra, equipo1, equipo2, equipo3, equipo4, equipo5, equipo6, equipo7, equipo8)
        End If


    End Sub
    Public Sub Genera_word()
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim ruta_destino As String
        Dim extension_destino As String
        Dim num_dias As Integer
        Dim minimo As Integer
        Dim dias_jornada As Double
        Dim string_dias As String

        If SaveFileDialog2.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ruta_destino = SaveFileDialog2.FileName
            extension_destino = System.IO.Path.GetExtension(SaveFileDialog2.FileName)


            If cmb_4_tipo_pago.Text = "Hora" And cmb_4_operador.Text = "Con Operador" Then
                nombre1 = "Con-Hor"
            ElseIf cmb_4_tipo_pago.Text = "Hora" And cmb_4_operador.Text = "Sin Operador" Then
                nombre1 = "Sin-Hor"
            ElseIf cmb_4_tipo_pago.Text = "Dia" And cmb_4_operador.Text = "Con Operador" Then
                nombre1 = "Con-Dia"
            ElseIf cmb_4_tipo_pago.Text = "Dia" And cmb_4_operador.Text = "Sin Operador" Then
                nombre1 = "Sin-Dia"
            ElseIf cmb_4_tipo_pago.Text = "Mes" And cmb_4_operador.Text = "Con Operador" Then
                nombre1 = "Con-Mes"
            ElseIf cmb_4_tipo_pago.Text = "Mes" And cmb_4_operador.Text = "Sin Operador" Then
                nombre1 = "Sin-Mes"
            ElseIf cmb_4_tipo_pago.Text = "M3" And cmb_4_operador.Text = "Con Operador" Then
                nombre1 = "Con-M3"
            ElseIf cmb_4_tipo_pago.Text = "M3" And cmb_4_operador.Text = "Sin Operador" Then
                nombre1 = "Sin-M3"
            End If

            FileCopy("C:\ArchivosProgramaFV\Contratos\" & nombre1 & ".doc", ruta_destino & extension_destino)
            Documento = MSWord.Documents.Open(ruta_destino & extension_destino)

            'Documento.Bookmarks.Item("nombre_obra").Range.Text = dgv_4_equipos2.Rows(0).Cells(2).Value.ToString
            Documento.Bookmarks.Item("nombre_obra").Range.Text = obra

            Try
                Documento.Bookmarks.Item("mandante").Range.Text = dgv_4_equipos2.Rows(0).Cells(7).Value.ToString()
            Catch ex As Exception
                Documento.Bookmarks.Item("mandante").Range.Text = ""
            End Try

            Try
                Documento.Bookmarks.Item("lugar").Range.Text = txt_4_lugar.Text
            Catch ex As Exception
                Documento.Bookmarks.Item("lugar").Range.Text = ""
            End Try

            Try
                Documento.Bookmarks.Item("rep_fv").Range.Text = dgv_4_equipos2.Rows(0).Cells(6).Value.ToString()
            Catch ex As Exception
                Documento.Bookmarks.Item("rep_fv").Range.Text = ""
            End Try

            Try
                Documento.Bookmarks.Item("razon_social5").Range.Text = dgv_4_equipos2.Rows(0).Cells(16).Value.ToString()
            Catch ex As Exception
                Documento.Bookmarks.Item("razon_social5").Range.Text = ""
            End Try

            Documento.Bookmarks.Item("fecha_celebracion").Range.Text = dtp_4_fecha_cel.Text
            Documento.Bookmarks.Item("rut_rep_fv").Range.Text = ""
            Documento.Bookmarks.Item("rut_empresa").Range.Text = dgv_4_equipos2.Rows(0).Cells(14).Value.ToString()
            Documento.Bookmarks.Item("nombre_representante").Range.Text = dgv_4_equipos2.Rows(0).Cells(17).Value.ToString()
            Documento.Bookmarks.Item("rut_representante").Range.Text = dgv_4_equipos2.Rows(0).Cells(18).Value.ToString()
            Documento.Bookmarks.Item("domicilio_representante").Range.Text = dgv_4_equipos2.Rows(0).Cells(15).Value.ToString()

            Documento.Bookmarks.Item("obra").Range.Text = dgv_4_equipos2.Rows(0).Cells(2).Value.ToString()
            Documento.Bookmarks.Item("un_pago").Range.Text = dgv_4_equipos2.Rows(0).Cells(35).Value.ToString()
            Documento.Bookmarks.Item("fecha_ep").Range.Text = dgv_4_equipos2.Rows(0).Cells(22).Value.ToString()
            Documento.Bookmarks.Item("fecha_ep2").Range.Text = dgv_4_equipos2.Rows(0).Cells(23).Value.ToString()
            Documento.Bookmarks.Item("dias_fallas").Range.Text = dgv_4_equipos2.Rows(0).Cells(40).Value.ToString()
            Documento.Bookmarks.Item("razon_social4").Range.Text = dgv_4_equipos2.Rows(0).Cells(16).Value.ToString()
            Documento.Bookmarks.Item("rut_2").Range.Text = dgv_4_equipos2.Rows(0).Cells(14).Value.ToString()

            If nombre1 = "Con-M3" Or nombre1 = "Sin-M3" Then
                Documento.Bookmarks.Item("material").Range.Text = dgv_4_equipos2.Rows(0).Cells(44).Value.ToString()
                Documento.Bookmarks.Item("material2").Range.Text = dgv_4_equipos2.Rows(0).Cells(44).Value.ToString()
                Documento.Bookmarks.Item("material3").Range.Text = dgv_4_equipos2.Rows(0).Cells(44).Value.ToString()
                Documento.Bookmarks.Item("material4").Range.Text = dgv_4_equipos2.Rows(0).Cells(44).Value.ToString()
            End If

            If nombre1 = "Con-M3" Or nombre1 = "Sin-M3" Or nombre1 = "Con-Hor" Or nombre1 = "Sin-Hor" Then
                Documento.Bookmarks.Item("min_obra").Range.Text = dgv_4_equipos2.Rows(0).Cells(42).Value.ToString()
                Documento.Bookmarks.Item("desc_obra").Range.Text = dgv_4_equipos2.Rows(0).Cells(43).Value.ToString()

                string_dias = dgv_4_equipos2.Rows(0).Cells(41).Value.ToString()

                If string_dias = "Mes Completo (30)" Then
                    num_dias = 30
                ElseIf string_dias = "Lun-Sab (26)" Then
                    num_dias = 26
                ElseIf string_dias = "Lun-Sab mediodia (24)" Then
                    num_dias = 24
                ElseIf string_dias = "Lun-Sab por medio (24)" Then
                    num_dias = 24
                ElseIf string_dias = "Lun-Vie (22)" Then
                    num_dias = 22
                ElseIf string_dias = "20x10 (20)" Then
                    num_dias = 20

                End If
                If num_dias <> 0 Then
                    minimo = CDbl(dgv_4_equipos2.Rows(0).Cells(42).Value.ToString())
                    dias_jornada = minimo / num_dias
                    dias_jornada = FormatNumber(dias_jornada, 2)
                Else
                    dias_jornada = 0
                End If
                Documento.Bookmarks.Item("jornada").Range.Text = dias_jornada

            End If

            Documento.Bookmarks.Item("detalle_equipo1").Range.Text = dgv_4_equipos2.Rows(0).Cells(26).Value.ToString()
            Documento.Bookmarks.Item("marca1").Range.Text = dgv_4_equipos2.Rows(0).Cells(27).Value.ToString()
            Documento.Bookmarks.Item("modelo1").Range.Text = dgv_4_equipos2.Rows(0).Cells(28).Value.ToString()
            Documento.Bookmarks.Item("patente1").Range.Text = dgv_4_equipos2.Rows(0).Cells(29).Value.ToString()
            Documento.Bookmarks.Item("num_motor1").Range.Text = dgv_4_equipos2.Rows(0).Cells(30).Value.ToString()
            Documento.Bookmarks.Item("capacidad1").Range.Text = dgv_4_equipos2.Rows(0).Cells(31).Value.ToString()

            Documento.Bookmarks.Item("detalle_equipo1_1").Range.Text = dgv_4_equipos2.Rows(0).Cells(26).Value.ToString()
            Documento.Bookmarks.Item("marca1_1").Range.Text = dgv_4_equipos2.Rows(0).Cells(27).Value.ToString()
            Documento.Bookmarks.Item("modelo1_1").Range.Text = dgv_4_equipos2.Rows(0).Cells(28).Value.ToString()
            Documento.Bookmarks.Item("patente1_1").Range.Text = dgv_4_equipos2.Rows(0).Cells(29).Value.ToString()
            Documento.Bookmarks.Item("num_motor1_1").Range.Text = dgv_4_equipos2.Rows(0).Cells(30).Value.ToString()
            If InStr(dgv_4_equipos2.Rows(0).Cells(36).Value.ToString(), ".") = 0 Then
                Documento.Bookmarks.Item("precio_un1_1").Range.Text = dgv_4_equipos2.Rows(0).Cells(36).Value.ToString()
            Else
                Documento.Bookmarks.Item("precio_un1_1").Range.Text = FormatNumber(dgv_4_equipos2.Rows(0).Cells(36).Value.ToString(), 2)
            End If
            If contador >= 2 Then
                Documento.Bookmarks.Item("detalle_equipo2").Range.Text = dgv_4_equipos2.Rows(1).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca2").Range.Text = dgv_4_equipos2.Rows(1).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo2").Range.Text = dgv_4_equipos2.Rows(1).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente2").Range.Text = dgv_4_equipos2.Rows(1).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor2").Range.Text = dgv_4_equipos2.Rows(1).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("capacidad2").Range.Text = dgv_4_equipos2.Rows(1).Cells(31).Value.ToString()

                Documento.Bookmarks.Item("detalle_equipo2_1").Range.Text = dgv_4_equipos2.Rows(1).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca2_1").Range.Text = dgv_4_equipos2.Rows(1).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo2_1").Range.Text = dgv_4_equipos2.Rows(1).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente2_1").Range.Text = dgv_4_equipos2.Rows(1).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor2_1").Range.Text = dgv_4_equipos2.Rows(1).Cells(30).Value.ToString()
                If InStr(dgv_4_equipos2.Rows(1).Cells(36).Value.ToString(), ".") = 0 Then
                    Documento.Bookmarks.Item("precio_un2_1").Range.Text = dgv_4_equipos2.Rows(1).Cells(36).Value.ToString()
                Else
                    Documento.Bookmarks.Item("precio_un2_1").Range.Text = FormatNumber(dgv_4_equipos2.Rows(1).Cells(36).Value.ToString(), 2)
                End If
            End If

            If contador >= 3 Then
                Documento.Bookmarks.Item("detalle_equipo3").Range.Text = dgv_4_equipos2.Rows(2).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca3").Range.Text = dgv_4_equipos2.Rows(2).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo3").Range.Text = dgv_4_equipos2.Rows(2).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente3").Range.Text = dgv_4_equipos2.Rows(2).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor3").Range.Text = dgv_4_equipos2.Rows(2).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("capacidad3").Range.Text = dgv_4_equipos2.Rows(2).Cells(31).Value.ToString()

                Documento.Bookmarks.Item("detalle_equipo3_1").Range.Text = dgv_4_equipos2.Rows(2).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca3_1").Range.Text = dgv_4_equipos2.Rows(2).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo3_1").Range.Text = dgv_4_equipos2.Rows(2).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente3_1").Range.Text = dgv_4_equipos2.Rows(2).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor3_1").Range.Text = dgv_4_equipos2.Rows(2).Cells(30).Value.ToString()
                If InStr(dgv_4_equipos2.Rows(2).Cells(36).Value.ToString(), ".") = 0 Then
                    Documento.Bookmarks.Item("precio_un3_1").Range.Text = dgv_4_equipos2.Rows(2).Cells(36).Value.ToString()
                Else
                    Documento.Bookmarks.Item("precio_un3_1").Range.Text = FormatNumber(dgv_4_equipos2.Rows(2).Cells(36).Value.ToString(), 2)
                End If
            End If

            If contador >= 4 Then
                Documento.Bookmarks.Item("detalle_equipo4").Range.Text = dgv_4_equipos2.Rows(3).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca4").Range.Text = dgv_4_equipos2.Rows(3).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo4").Range.Text = dgv_4_equipos2.Rows(3).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente4").Range.Text = dgv_4_equipos2.Rows(3).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor4").Range.Text = dgv_4_equipos2.Rows(3).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("capacidad4").Range.Text = dgv_4_equipos2.Rows(3).Cells(31).Value.ToString()

                Documento.Bookmarks.Item("detalle_equipo4_1").Range.Text = dgv_4_equipos2.Rows(3).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca4_1").Range.Text = dgv_4_equipos2.Rows(3).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo4_1").Range.Text = dgv_4_equipos2.Rows(3).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente4_1").Range.Text = dgv_4_equipos2.Rows(3).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor4_1").Range.Text = dgv_4_equipos2.Rows(3).Cells(30).Value.ToString()
                If InStr(dgv_4_equipos2.Rows(3).Cells(36).Value.ToString(), ".") = 0 Then
                    Documento.Bookmarks.Item("precio_un4_1").Range.Text = dgv_4_equipos2.Rows(3).Cells(36).Value.ToString()
                Else
                    Documento.Bookmarks.Item("precio_un4_1").Range.Text = FormatNumber(dgv_4_equipos2.Rows(3).Cells(36).Value.ToString(), 2)
                End If

            End If

            If contador >= 5 Then
                Documento.Bookmarks.Item("detalle_equipo5").Range.Text = dgv_4_equipos2.Rows(4).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca5").Range.Text = dgv_4_equipos2.Rows(4).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo5").Range.Text = dgv_4_equipos2.Rows(4).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente5").Range.Text = dgv_4_equipos2.Rows(4).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor5").Range.Text = dgv_4_equipos2.Rows(4).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("capacidad5").Range.Text = dgv_4_equipos2.Rows(4).Cells(31).Value.ToString()

                Documento.Bookmarks.Item("detalle_equipo5_1").Range.Text = dgv_4_equipos2.Rows(4).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca5_1").Range.Text = dgv_4_equipos2.Rows(4).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo5_1").Range.Text = dgv_4_equipos2.Rows(4).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente5_1").Range.Text = dgv_4_equipos2.Rows(4).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor5_1").Range.Text = dgv_4_equipos2.Rows(4).Cells(30).Value.ToString()
                If InStr(dgv_4_equipos2.Rows(4).Cells(36).Value.ToString(), ".") = 0 Then
                    Documento.Bookmarks.Item("precio_un5_1").Range.Text = dgv_4_equipos2.Rows(4).Cells(36).Value.ToString()
                Else
                    Documento.Bookmarks.Item("precio_un5_1").Range.Text = FormatNumber(dgv_4_equipos2.Rows(4).Cells(36).Value.ToString(), 2)
                End If

            End If

            If contador >= 6 Then
                Documento.Bookmarks.Item("detalle_equipo6").Range.Text = dgv_4_equipos2.Rows(5).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca6").Range.Text = dgv_4_equipos2.Rows(5).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo6").Range.Text = dgv_4_equipos2.Rows(5).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente6").Range.Text = dgv_4_equipos2.Rows(5).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor6").Range.Text = dgv_4_equipos2.Rows(5).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("capacidad6").Range.Text = dgv_4_equipos2.Rows(5).Cells(31).Value.ToString()

                Documento.Bookmarks.Item("detalle_equipo6_1").Range.Text = dgv_4_equipos2.Rows(5).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca6_1").Range.Text = dgv_4_equipos2.Rows(5).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo6_1").Range.Text = dgv_4_equipos2.Rows(5).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente6_1").Range.Text = dgv_4_equipos2.Rows(5).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor6_1").Range.Text = dgv_4_equipos2.Rows(5).Cells(30).Value.ToString()
                If InStr(dgv_4_equipos2.Rows(5).Cells(36).Value.ToString(), ".") = 0 Then
                    Documento.Bookmarks.Item("precio_un6_1").Range.Text = dgv_4_equipos2.Rows(5).Cells(36).Value.ToString()
                Else
                    Documento.Bookmarks.Item("precio_un6_1").Range.Text = FormatNumber(dgv_4_equipos2.Rows(5).Cells(36).Value.ToString(), 2)
                End If

            End If

            If contador >= 7 Then
                Documento.Bookmarks.Item("detalle_equipo7").Range.Text = dgv_4_equipos2.Rows(6).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca7").Range.Text = dgv_4_equipos2.Rows(6).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo7").Range.Text = dgv_4_equipos2.Rows(6).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente7").Range.Text = dgv_4_equipos2.Rows(6).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor7").Range.Text = dgv_4_equipos2.Rows(6).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("capacidad7").Range.Text = dgv_4_equipos2.Rows(6).Cells(31).Value.ToString()

                Documento.Bookmarks.Item("detalle_equipo7_1").Range.Text = dgv_4_equipos2.Rows(6).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca7_1").Range.Text = dgv_4_equipos2.Rows(6).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo7_1").Range.Text = dgv_4_equipos2.Rows(6).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente7_1").Range.Text = dgv_4_equipos2.Rows(6).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor7_1").Range.Text = dgv_4_equipos2.Rows(6).Cells(30).Value.ToString()
                If InStr(dgv_4_equipos2.Rows(6).Cells(36).Value.ToString(), ".") = 0 Then
                    Documento.Bookmarks.Item("precio_un7_1").Range.Text = dgv_4_equipos2.Rows(6).Cells(36).Value.ToString()
                Else
                    Documento.Bookmarks.Item("precio_un7_1").Range.Text = FormatNumber(dgv_4_equipos2.Rows(6).Cells(36).Value.ToString(), 2)
                End If

            End If

            If contador >= 8 Then
                Documento.Bookmarks.Item("detalle_equipo8").Range.Text = dgv_4_equipos2.Rows(7).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca8").Range.Text = dgv_4_equipos2.Rows(7).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo8").Range.Text = dgv_4_equipos2.Rows(7).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente8").Range.Text = dgv_4_equipos2.Rows(7).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor8").Range.Text = dgv_4_equipos2.Rows(7).Cells(30).Value.ToString()
                Documento.Bookmarks.Item("capacidad8").Range.Text = dgv_4_equipos2.Rows(7).Cells(31).Value.ToString()

                Documento.Bookmarks.Item("detalle_equipo8_1").Range.Text = dgv_4_equipos2.Rows(7).Cells(26).Value.ToString()
                Documento.Bookmarks.Item("marca8_1").Range.Text = dgv_4_equipos2.Rows(7).Cells(27).Value.ToString()
                Documento.Bookmarks.Item("modelo8_1").Range.Text = dgv_4_equipos2.Rows(7).Cells(28).Value.ToString()
                Documento.Bookmarks.Item("patente8_1").Range.Text = dgv_4_equipos2.Rows(7).Cells(29).Value.ToString()
                Documento.Bookmarks.Item("num_motor8_1").Range.Text = dgv_4_equipos2.Rows(7).Cells(30).Value.ToString()
                If InStr(dgv_4_equipos2.Rows(7).Cells(36).Value.ToString(), ".") = 0 Then
                    Documento.Bookmarks.Item("precio_un8_1").Range.Text = dgv_4_equipos2.Rows(7).Cells(36).Value.ToString()
                Else
                    Documento.Bookmarks.Item("precio_un8_1").Range.Text = FormatNumber(dgv_4_equipos2.Rows(7).Cells(36).Value.ToString(), 2)
                End If

            End If

            Documento.Save()
            Documento.Close()
            MsgBox("DOCUMENTO GENERADO SATISFACTORIAMENTE")
            'MSWord.Visible = True
        End If
    End Sub

    Private Sub cmb_4_tipo_pago_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_4_tipo_pago.MouseClick
        actualiza_pago4()
    End Sub

    Private Sub cmb_4_tipo_pago_TextChanged(sender As Object, e As EventArgs) Handles cmb_4_tipo_pago.TextChanged
        If cmb_4_operador.Text <> "" And cmb_4_arrendador.Text <> "" Then
            actualizar_check()
        End If
    End Sub
    Sub actualizar_adjunto()
        Dim ruta1 As String
        Dim extension1 As String

        SaveFileDialog1.FileName = "C:\ArchivosProgramaFV\Contratos\Sin-Mes.doc"
        ruta1 = SaveFileDialog1.FileName
        My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contratos/Sin-Mes.doc", ruta1, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

        SaveFileDialog1.FileName = "C:\ArchivosProgramaFV\Contratos\Sin-M3.doc"
        ruta1 = SaveFileDialog1.FileName
        My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contratos/Sin-M3.doc", ruta1, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

        SaveFileDialog1.FileName = "C:\ArchivosProgramaFV\Contratos\Sin-Hor.doc"
        ruta1 = SaveFileDialog1.FileName
        My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contratos/Sin-Hor.doc", ruta1, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

        SaveFileDialog1.FileName = "C:\ArchivosProgramaFV\Contratos\Sin-Dia.doc"
        ruta1 = SaveFileDialog1.FileName
        My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contratos/Sin-Dia.doc", ruta1, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

        SaveFileDialog1.FileName = "C:\ArchivosProgramaFV\Contratos\Con-Mes.doc"
        ruta1 = SaveFileDialog1.FileName
        My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contratos/Con-Mes.doc", ruta1, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

        SaveFileDialog1.FileName = "C:\ArchivosProgramaFV\Contratos\Con-M3.doc"
        ruta1 = SaveFileDialog1.FileName
        My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contratos/Con-M3.doc", ruta1, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

        SaveFileDialog1.FileName = "C:\ArchivosProgramaFV\Contratos\Con-Hor.doc"
        ruta1 = SaveFileDialog1.FileName
        My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contratos/Con-Hor.doc", ruta1, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

        SaveFileDialog1.FileName = "C:\ArchivosProgramaFV\Contratos\Con-Dia.doc"
        ruta1 = SaveFileDialog1.FileName
        My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contratos/Con-Dia.doc", ruta1, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

        MsgBox("SINCRONIZACIÓN DE DOCUMENTOS REALIZADA SATISFACTORIAMENTE")
    End Sub

    Private Sub txt_4_contrato_TextChanged(sender As Object, e As EventArgs) Handles txt_5_contrato.TextChanged
        If Not IsNumeric(txt_5_contrato.Text) Then
            txt_5_contrato.Clear()
        End If
    End Sub

    Private Sub cmb_4_operador_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_4_operador.MouseClick
        actualiza_operador4()
    End Sub
    Private Sub ComboBox1_TextChanged1(sender As Object, e As EventArgs) Handles cmb_4_operador.TextChanged
        If cmb_4_tipo_pago.Text <> "" And cmb_4_arrendador.Text <> "" Then
            actualizar_check()
        End If
    End Sub

    Private Sub cmb_4_obra_TextChanged(sender As Object, e As EventArgs)
        If cmb_4_tipo_pago.Text <> "" And cmb_4_arrendador.Text <> "" And cmb_4_operador.Text <> "" Then
            actualizar_check()
        End If
    End Sub
    Private Sub cmb_4_arrendador_TextChanged(sender As Object, e As EventArgs) Handles cmb_4_arrendador.TextChanged
        If cmb_4_tipo_pago.Text <> "" And cmb_4_operador.Text <> "" Then
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

    Private Sub cmb_5_arrendador_TextChanged(sender As Object, e As EventArgs) Handles cmb_5_arrendador.TextChanged
        If cmb_5_tipo_pago.Text <> "" And cmb_5_obra.Text <> "" And cmb_5_operador.Text <> "" Then
            actualizar_check2()
        End If
    End Sub

    Private Sub cmb_5_tipo_pago_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_5_tipo_pago.MouseClick
        actualiza_pago5()
    End Sub
    Private Sub cmb_5_tipo_pago_TextChanged(sender As Object, e As EventArgs) Handles cmb_5_tipo_pago.TextChanged
        If cmb_5_operador.Text <> "" And cmb_5_arrendador.Text <> "" And cmb_5_obra.Text <> "" Then
            actualizar_check2()
        End If
    End Sub

    Private Sub cmb_5_operador_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_5_operador.MouseClick
        actualiza_operador5()
    End Sub
    Private Sub cmb_5_operador_TextChanged(sender As Object, e As EventArgs) Handles cmb_5_operador.TextChanged
        If cmb_5_tipo_pago.Text <> "" And cmb_5_arrendador.Text <> "" And cmb_5_obra.Text <> "" Then
            actualizar_check2()
        End If
    End Sub
    Private Sub cmb_5_obra_TextChanged(sender As Object, e As EventArgs) Handles cmb_5_obra.TextChanged
        If cmb_5_tipo_pago.Text <> "" And cmb_5_arrendador.Text <> "" And cmb_5_operador.Text <> "" Then
            actualizar_check2()
        End If
    End Sub
    Private Sub cmb_6_arrendador_TextChanged(sender As Object, e As EventArgs) Handles cmb_6_arrendador.TextChanged
        If cmb_6_tipo_pago.Text <> "" And cmb_6_obra.Text <> "" And cmb_6_operador.Text <> "" Then
            actualizar_check6()
        End If
    End Sub

    Private Sub cmb_6_tipo_pago_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_6_tipo_pago.MouseClick
        actualiza_pago6()
    End Sub

    Private Sub cmb_6_tipo_pago_TextChanged(sender As Object, e As EventArgs) Handles cmb_6_tipo_pago.TextChanged
        If cmb_6_operador.Text <> "" And cmb_6_arrendador.Text <> "" And cmb_6_obra.Text <> "" Then
            actualizar_check6()
        End If
    End Sub

    Private Sub cmb_6_operador_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_6_operador.MouseClick
        actualiza_operador6()
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

    Private Sub cmb_7_tipo_pago_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_7_tipo_pago.MouseClick
        actualiza_pago7()
    End Sub

    Private Sub cmb_7_tipo_pago_TextChanged(sender As Object, e As EventArgs) Handles cmb_7_tipo_pago.TextChanged
        If cmb_7_operador.Text <> "" And cmb_7_arrendador.Text <> "" And cmb_7_obra.Text <> "" Then
            actualizar_check7()
        End If
    End Sub

    Private Sub cmb_7_operador_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_7_operador.MouseClick
        actualiza_operador7()
    End Sub

    Private Sub cmb_7_operador_TextChanged(sender As Object, e As EventArgs) Handles cmb_7_operador.TextChanged
        If cmb_7_tipo_pago.Text <> "" And cmb_7_arrendador.Text <> "" And cmb_7_obra.Text <> "" Then
            actualizar_check7()
        End If
    End Sub

    Private Sub cmb_7_obra_TextChanged(sender As Object, e As EventArgs) Handles cmb_7_obra.TextChanged
        If cmb_7_tipo_pago.Text <> "" And cmb_7_arrendador.Text <> "" And cmb_7_operador.Text <> "" Then
            actualizar_check7()
        End If
    End Sub

    Private Sub txt_1_capacidad_TextChanged(sender As Object, e As EventArgs) Handles txt_1_capacidad.TextChanged
        If cmb_1_forma.Text = "M3-KM" And Not IsNumeric(txt_1_capacidad.Text) Then
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
        dgv_5_empresa.Columns(5).Visible = False
        dgv_5_empresa.Columns(6).HeaderText = "Equipo"
        dgv_5_empresa.Columns(6).Width = 80
        dgv_5_empresa.Columns(7).HeaderText = "Número Contrato"
        dgv_5_empresa.Columns(7).Width = 80
        dgv_5_empresa.Columns(8).HeaderText = "Adjunto"
        dgv_5_empresa.Columns(8).Width = 70
        dgv_5_empresa.Columns(9).HeaderText = "Usuario"
        dgv_5_empresa.Columns(9).Width = 70
        dgv_5_empresa.Columns(10).HeaderText = "Fecha"
        dgv_5_empresa.Columns(10).Width = 80
        dgv_5_empresa.Columns(11).HeaderText = "Hora"
        dgv_5_empresa.Columns(11).Width = 70
        dgv_5_empresa.Columns(12).Visible = False
        dgv_5_empresa.Columns(13).Visible = False
        dgv_5_empresa.Columns(14).Visible = False
        dgv_5_empresa.Columns(15).Visible = False
        dgv_5_empresa.Columns(16).Visible = False
        dgv_5_empresa.Columns(17).Visible = False
        dgv_5_empresa.Columns(18).Visible = False
        dgv_5_empresa.Columns(19).Visible = False
        dgv_5_empresa.Columns(20).Visible = False
        dgv_5_empresa.AllowUserToOrderColumns = True
    End Sub
    Private Sub btn_5_ingresar_Click(sender As Object, e As EventArgs) Handles btn_5_ingresar.Click
        Dim verificar As Integer
        Dim verificar2 As Integer
        Dim verificar3 As Integer
        verificar = 0
        verificar2 = 0
        verificar3 = 0

        For i = 0 To check_5_empresa.Items.Count - 1
            If (check_5_empresa.GetItemChecked(i)) Then
                verificar = contador + 1
            End If
        Next

        If dgv_5_empresa.Rows.Count > 0 Then
            For j = 0 To dgv_5_empresa.Rows.Count - 1
                If txt_5_contrato.Text = dgv_5_empresa.Rows(j).Cells(7).Value.ToString() Then
                    verificar2 = 1
                End If
            Next j
        End If

        If dgv_5_empresa.Rows.Count > 0 Then
            For k = 0 To check_5_empresa.Items.Count - 1
                For l = 0 To dgv_5_empresa.Rows.Count - 1
                    If (check_5_empresa.GetItemChecked(k)) Then
                        valor(k) = check_5_empresa.Items(k)
                        Dim Cadena As String = valor(k)
                        Dim ArrCadena As String() = Cadena.Split(" / ")

                        If ArrCadena(0) = dgv_5_empresa.Rows(l).Cells(5).Value.ToString() And dgv_5_empresa.Rows(l).Cells(7).Value.ToString() <> "" Then
                            verificar3 = 1
                        End If
                    End If
                Next l
            Next
        End If

        If txt_5_contrato.Text <> "" And verificar > 0 Then
            If verificar2 = 1 Then
                MessageBox.Show("EL N° DE CONTRATO " & txt_5_contrato.Text & " YA ESTA ADJUNTADO")
            Else
                If verificar3 = 1 Then
                    MessageBox.Show("YA HAY UN CONTRATO ADJUNTO A UNO DE LOS EQUIPOS SELECCIONADOS")
                Else
                    extrae_datos2()
                    actualizar_5_adjuntos()
                    txt_5_contrato.Clear()
                End If
            End If
        Else
            MessageBox.Show("FALTAN DATOS PARA INGRESAR EL CONTRATO")
        End If
    End Sub
    Public Sub extrae_datos2()
        Dim i As Integer
        Dim Z As Integer
        Dim equipo1, equipo2, equipo3, equipo4, equipo5, equipo6, equipo7, equipo8 As Integer
        Dim ruta As String
        Dim nombre As String
        Dim extension As String

        If OpenFileDialog2.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ruta = OpenFileDialog2.FileName
            nombre = txt_5_contrato.Text & "-" & id_obra
            'extension = System.IO.Path.GetExtension(OpenFileDialog2.FileName)
            extension = ".pdf"

            My.Computer.Network.UploadFile(ruta, "ftp://cfv%2540constructorafv.com@201.148.105.75/Contrato_equipos/" & nombre & extension & "", "cfv@constructorafv.com", "gsolis2013", True, 500)
            MessageBox.Show("CONTRATO ADJUNTO")
            contador = 0

            For i = 0 To check_5_empresa.Items.Count - 1
                If (check_5_empresa.GetItemChecked(i)) Then
                    contador = contador + 1
                    valor(i) = check_5_empresa.Items(i)
                    Dim Cadena As String = valor(i)
                    Dim ArrCadena As String() = Cadena.Split(" / ")
                    nue_obra5.insertar(1, 0, Nombre_Obra, id_obra, ArrCadena(0), ArrCadena(2), CInt(txt_5_contrato.Text), "SI", Nombre_Usuario, CDate(txt_fecha_act.Text), CDate(txt_hora.Text), cmb_5_obra.SelectedValue.ToString(), cmb_5_obra.Text, "", CDate(txt_fecha_act.Text), cmb_5_arrendador.SelectedValue.ToString(), cmb_5_arrendador.Text, cmb_5_tipo_pago.Text, cmb_5_operador.Text)
                End If
            Next
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

                My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Contrato_equipos/" & nombre & extension & "", ruta_destino, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MessageBox.Show("DESCARGA EXITOSA")
        End If
    End Sub

    Public Sub descargar_finiquito()
        Dim ruta_destino As String
        Dim nombre As String
        Dim extension As String

        If SaveFileDialog3.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            ruta_destino = SaveFileDialog3.FileName
            nombre = txt_7_finiquito2.Text & "-" & id_obra
            extension = ".pdf"
            Try

                My.Computer.Network.DownloadFile("ftp://cfv%2540constructorafv.com@201.148.105.75/Finiquito_equipos/" & nombre & extension & "", ruta_destino, "cfv@constructorafv.com", "gsolis2013", True, 100000, True)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            MessageBox.Show("DESCARGA EXITOSA")
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
            txt_5_equipo2.Text = dgv_5_empresa.CurrentRow.Cells(6).Value.ToString()
            version_mod5 = CInt(dgv_5_empresa.CurrentRow.Cells(2).Value.ToString())
        Else
            txt_5_contrato2.Clear()
            txt_5_equipo2.Clear()
            Cod_5 = ""
            version_mod5 = 0
        End If
    End Sub

    Private Sub btn_eliminar5_Click(sender As Object, e As EventArgs) Handles btn_eliminar5.Click
        Dim eliminar5 As MsgBoxResult
        If (Cod_5 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar5 = MsgBox("¿Realmente desea eliminar el contrato designado al equipo?", MsgBoxStyle.YesNo, "Confirmar")

            If eliminar5 = MsgBoxResult.Yes Then
                nue_obra5.eliminar_sincro(CInt(Cod_5), 3, version_mod5)
                txt_5_contrato2.Clear()
                txt_5_equipo2.Clear()
                Cod_5 = ""
                actualizar_5_adjuntos()
            Else
                txt_5_contrato2.Clear()
                txt_5_equipo2.Clear()
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
            MessageBox.Show("FINIQUITO ADJUNTO")
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
        dgv_7_empresa.Columns(6).Width = 80
        dgv_7_empresa.Columns(7).HeaderText = "Número Finiquito"
        dgv_7_empresa.Columns(7).Width = 80
        dgv_7_empresa.Columns(8).HeaderText = "Adjunto"
        dgv_7_empresa.Columns(8).Width = 70
        dgv_7_empresa.Columns(9).HeaderText = "Usuario"
        dgv_7_empresa.Columns(9).Width = 70
        dgv_7_empresa.Columns(10).HeaderText = "Fecha"
        dgv_7_empresa.Columns(10).Width = 80
        dgv_7_empresa.Columns(11).HeaderText = "Hora"
        dgv_7_empresa.Columns(11).Width = 70
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
            eliminar7 = MsgBox("¿Realmente desea eliminar el contrato designado al equipo?", MsgBoxStyle.YesNo, "Confirmar")

            If eliminar7 = MsgBoxResult.Yes Then
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
        If txt_8_ep.Text <> "" Then
            CR_Estado_de_pago.Show()

        Else
            MsgBox("FALTA INGRESAR EL N° DEL ESTADO DE PAGO")
        End If
    End Sub

    Private Sub btn_8_resumen_ep_Click(sender As Object, e As EventArgs) Handles btn_8_resumen_ep.Click
        If txt_8_ep.Text <> "" Then
            Dim fecha_in, fecha_fin As Date
            Dim Fecha_inicio As String
            Dim fecha_final As String

            Dim dia_inicial As Date
            Dim dia_final As Date
            Dim dias_mes As Integer
            Dim Minimo_proporcional As Double
            Dim diff_dias

            dia_inicial = CDate(dtp_fecha_in.Text)
            dia_final = CDate(dtp_fecha_fin.Text)

            dias_mes = DateTime.DaysInMonth(Year(dia_inicial), Month(dia_inicial))

            Fecha_inicio = Me.dtp_fecha_in.Value.ToShortDateString
            fecha_in = Fecha_inicio
            Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")

            fecha_final = Me.dtp_fecha_fin.Value.ToShortDateString
            fecha_fin = fecha_final
            fecha_final = Format(CDate(fecha_final), "yyyy/MM/dd")

            diff_dias = DateDiff(DateInterval.Day, fecha_in, fecha_fin) + 1

            nue_obra8.listar5(id_obra)
            dgv_8_minimos.DataSource = nue_obra8.listar4(id_obra, cmb_8_arrendador.SelectedValue.ToString(), Fecha_inicio, fecha_final)

            If dgv_8_minimos.Rows.Count > 1 Then
                For i = 0 To dgv_8_minimos.Rows.Count - 2
                    Dim SumaDeMinimo, SumaDeExpr2 As Double
                    If IsNumeric(dgv_8_minimos.Rows(i).Cells(3).Value.ToString()) Then
                        SumaDeMinimo = dgv_8_minimos.Rows(i).Cells(3).Value.ToString()
                    Else
                        SumaDeMinimo = 0
                    End If

                    If IsNumeric(dgv_8_minimos.Rows(i).Cells(4).Value.ToString()) Then
                        SumaDeExpr2 = dgv_8_minimos.Rows(i).Cells(4).Value.ToString()
                    Else
                        SumaDeExpr2 = 0
                    End If

                    If IsNumeric(dgv_8_minimos.Rows(i).Cells(7).Value.ToString()) Then
                        Minimo_proporcional = dgv_8_minimos.Rows(i).Cells(7).Value.ToString()
                    Else
                        Minimo_proporcional = 0
                    End If

                    nue_obra8.insertar_minimos(dgv_8_minimos.Rows(i).Cells(0).Value.ToString(), dgv_8_minimos.Rows(i).Cells(1).Value.ToString(), dgv_8_minimos.Rows(i).Cells(2).Value.ToString(), SumaDeMinimo, SumaDeExpr2, dgv_8_minimos.Rows(i).Cells(5).Value.ToString(), dgv_8_minimos.Rows(i).Cells(6).Value.ToString(), dias_mes, Minimo_proporcional, diff_dias, dgv_8_minimos.Rows(i).Cells(8).Value.ToString())
                Next i
            End If


            CR_Resumen_Estado_Pago.Show()
        Else
            MsgBox("FALTA INGRESAR EL N° DEL ESTADO DE PAGO")
        End If
    End Sub

    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter
        num_tab = 1
        Dim consultar As MsgBoxResult
        If consulta_datos <> 0 Then
            consultar = MsgBox("Usted no ha guardado los reports, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
                btn_tabla.PerformClick()
            Else
            End If
            frm_menu_principal_IV_V2.Show()
            Me.Close()
        ElseIf consulta_datos = 0 Then
            frm_menu_principal_IV_V2.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btn_8_terceros_ep_Click(sender As Object, e As EventArgs) Handles btn_8_terceros_ep.Click
        Dim fecha_in, fecha_fin As Date
        Dim Fecha_inicio As String
        Dim fecha_final As String

        Dim dia_inicial As Date
        Dim dia_final As Date
        Dim dias_mes As Integer
        Dim Minimo_proporcional As Double
        Dim diff_dias

        dia_inicial = CDate(dtp_fecha_in.Text)
        dia_final = CDate(dtp_fecha_fin.Text)

        dias_mes = DateTime.DaysInMonth(Year(dia_inicial), Month(dia_inicial))


        Fecha_inicio = Me.dtp_fecha_in.Value.ToShortDateString
        fecha_in = Fecha_inicio
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        fecha_final = Me.dtp_fecha_fin.Value.ToShortDateString
        fecha_fin = fecha_final
        fecha_final = Format(CDate(fecha_final), "yyyy/MM/dd")

        diff_dias = DateDiff(DateInterval.Day, fecha_in, fecha_fin) + 1

        nue_obra8.listar5(id_obra)
        dgv_8_minimos.DataSource = nue_obra8.listar6(id_obra, Fecha_inicio, fecha_final)

        If dgv_8_minimos.Rows.Count > 1 Then
            For i = 0 To dgv_8_minimos.Rows.Count - 2
                Dim SumaDeMinimo, SumaDeExpr2 As Double
                If IsNumeric(dgv_8_minimos.Rows(i).Cells(3).Value.ToString()) Then
                    SumaDeMinimo = dgv_8_minimos.Rows(i).Cells(3).Value.ToString()
                Else
                    SumaDeMinimo = 0
                End If

                If IsNumeric(dgv_8_minimos.Rows(i).Cells(4).Value.ToString()) Then
                    SumaDeExpr2 = dgv_8_minimos.Rows(i).Cells(4).Value.ToString()
                Else
                    SumaDeExpr2 = 0
                End If

                If IsNumeric(dgv_8_minimos.Rows(i).Cells(7).Value.ToString()) Then
                    Minimo_proporcional = dgv_8_minimos.Rows(i).Cells(7).Value.ToString()
                Else
                    Minimo_proporcional = 0
                End If

                nue_obra8.insertar_minimos(dgv_8_minimos.Rows(i).Cells(0).Value.ToString(), dgv_8_minimos.Rows(i).Cells(1).Value.ToString(), dgv_8_minimos.Rows(i).Cells(2).Value.ToString(), SumaDeMinimo, SumaDeExpr2, dgv_8_minimos.Rows(i).Cells(5).Value.ToString(), dgv_8_minimos.Rows(i).Cells(6).Value.ToString(), dias_mes, Minimo_proporcional, diff_dias, dgv_8_minimos.Rows(i).Cells(8).Value.ToString())
            Next i
        End If

        CR_Estado_de_pago_terceros.Show()

    End Sub

    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
        num_tab = 1
        frm_menu_principal_V.Show()
        Me.Close()
    End Sub

    Private Sub cmb_1_codigo_LostFocus(sender As Object, e As EventArgs) Handles cmb_1_codigo.LostFocus
        If nue_obra2.verificar_codigo(id_obra, cmb_1_codigo.Text) = 1 And sw1 = 0 Then
            MsgBox("Este código ya esta asignado a una máquina")
            cmb_1_codigo.Text = ""
        Else

        End If
    End Sub

    Private Sub TabPage14_Enter(sender As Object, e As EventArgs) Handles TabPage14.Enter
        If var_in1 = 0 Then
            actualiza_obras()
            actualiza_arrendador()
            actualiza_cuentas_maquinaria()
            actualiza_cuentas_petroleo()
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
            actualiza_arrendador3()
            actualiza_cuentas_trabajo()
            actualizar_dgv3()
            var_in3 = 1
        End If
    End Sub

    Private Sub TabPage17_Enter(sender As Object, e As EventArgs) Handles TabPage17.Enter
        If var_in4 = 0 Then
            actualiza_arrendador4()
            'actualiza_obras4()
            var_in4 = 1
        End If
    End Sub

    Private Sub TabPage18_Enter(sender As Object, e As EventArgs) Handles TabPage18.Enter
        If var_in5 = 0 Then
            actualiza_arrendador5()
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
            actualiza_arrendador8()
            var_in8 = 1
        End If
    End Sub

    Private Sub btn_8_horas_maq_Click(sender As Object, e As EventArgs) Handles btn_8_horas_maq.Click
        CR_Detalle_Horas.Show()

    End Sub


    Private Sub btn_nuevo11_Click(sender As Object, e As EventArgs) Handles btn_nuevo11.Click
        desbloquear11()
        limpiar11()
        sw11 = 0
        Cod_11 = ""
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
            eliminar11 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.YesNo, "Confirmar")

            If eliminar11 = MsgBoxResult.Yes And sincroniza = 0 Then
                version_mod11 = version_mod11 + 1
                nue_obra1.eliminar_sincro11(CInt(Cod_11), 3, version_mod11)
                bloquear11()
                limpiar11()
                actualiza_arrendador()

            ElseIf sincroniza_local = 1 And sincroniza = 1 And eliminar11 = MsgBoxResult.Yes Then
                nue_obra1.eliminar(CInt(Cod_11))
                bloquear11()
                limpiar11()
                actualiza_arrendador()
            ElseIf eliminar11 = MsgBoxResult.Yes Then
                version_mod11 = version_mod11 + 1
                nue_obra1.eliminar_sincro11(CInt(Cod_11), 3, version_mod11)
                bloquear11()
                limpiar11()
                actualiza_arrendador()
            End If
        End If
    End Sub

    Private Sub btn_cancelar11_Click(sender As Object, e As EventArgs) Handles btn_cancelar11.Click
        bloquear11()
    End Sub

    Private Sub btn_guardar11_Click(sender As Object, e As EventArgs) Handles btn_guardar11.Click
        Dim rut, domicilio, razon_social, representante, representante_rut As String
        Dim existe_rut2 As Integer

        If (txt_1_rut.Text <> "" And txt_1_razon_social.Text <> "") Then
            domicilio = txt_1_domicilio.Text
            razon_social = txt_1_razon_social.Text
            representante = txt_1_representante.Text
            representante_rut = txt_1_rut_representante.Text
            rut = txt_1_rut.Text

            If sw11 = 0 Then
                If nue_obra1.verificar_arrendador(id_obra, rut) = 0 Then
                    nue_obra1.insertar_cabecera(1, 0, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut)
                    actualiza_arrendador()
                Else
                    MessageBox.Show("ESTE ARRENDADOR YA ESTA CREADO")
                End If

            ElseIf sincroniza_local = 1 And sincroniza = 1 And sw11 <> 0 Then
                nue_obra1.modificar_cabecera(CInt(Cod_11), 1, 0, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut)

            ElseIf sincroniza = 0 And sw11 <> 0 Then
                version_mod11 = version_mod11 + 1
                nue_obra1.modificar_cabecera(CInt(Cod_11), 2, version_mod11, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut)

            Else
                version_mod11 = version_mod11 + 1
                nue_obra1.modificar_cabecera(CInt(Cod_11), 2, version_mod11, Nombre_Obra, id_obra, rut, domicilio, razon_social, representante, representante_rut)
            End If
            limpiar11()
            bloquear11()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If

    End Sub

    Private Sub txt_1_rut_TextChanged(sender As Object, e As EventArgs) Handles txt_1_rut.TextChanged
        Dim rut_ver As String
        rut_ver = Limpiar(txt_1_rut.Text)
        If Len(rut_ver) < 8 Then
            txt_1_rut.Mask = ""
        End If
    End Sub

    Private Sub btn_configurar_Click(sender As Object, e As EventArgs) Handles btn_configurar.Click
        Frm_viajes.ShowDialog()
    End Sub

    Private Sub Button64_Click_1(sender As Object, e As EventArgs) Handles btn_m3_km.Click
        Frm_liquidacion_maq.ShowDialog()
    End Sub

    Private Sub Button64_Click_2(sender As Object, e As EventArgs) Handles btn_8_terceros_epc.Click
        Dim fecha_in, fecha_fin As Date
        Dim Fecha_inicio As String
        Dim fecha_final As String

        Dim dia_inicial As Date
        Dim dia_final As Date
        Dim dias_mes As Integer
        Dim Minimo_proporcional As Double
        Dim diff_dias

        dia_inicial = CDate(dtp_fecha_in.Text)
        dia_final = CDate(dtp_fecha_fin.Text)

        dias_mes = DateTime.DaysInMonth(Year(dia_inicial), Month(dia_inicial))


        Fecha_inicio = Me.dtp_fecha_in.Value.ToShortDateString
        fecha_in = Fecha_inicio
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        fecha_final = Me.dtp_fecha_fin.Value.ToShortDateString
        fecha_fin = fecha_final
        fecha_final = Format(CDate(fecha_final), "yyyy/MM/dd")

        diff_dias = DateDiff(DateInterval.Day, fecha_in, fecha_fin) + 1

        nue_obra8.listar5(id_obra)
        dgv_8_minimos.DataSource = nue_obra8.listar6(id_obra, Fecha_inicio, fecha_final)

        If dgv_8_minimos.Rows.Count > 1 Then
            For i = 0 To dgv_8_minimos.Rows.Count - 2
                Dim SumaDeMinimo, SumaDeExpr2 As Double
                If IsNumeric(dgv_8_minimos.Rows(i).Cells(3).Value.ToString()) Then
                    SumaDeMinimo = dgv_8_minimos.Rows(i).Cells(3).Value.ToString()
                Else
                    SumaDeMinimo = 0
                End If

                If IsNumeric(dgv_8_minimos.Rows(i).Cells(4).Value.ToString()) Then
                    SumaDeExpr2 = dgv_8_minimos.Rows(i).Cells(4).Value.ToString()
                Else
                    SumaDeExpr2 = 0
                End If

                If IsNumeric(dgv_8_minimos.Rows(i).Cells(7).Value.ToString()) Then
                    Minimo_proporcional = dgv_8_minimos.Rows(i).Cells(7).Value.ToString()
                Else
                    Minimo_proporcional = 0
                End If

                nue_obra8.insertar_minimos(dgv_8_minimos.Rows(i).Cells(0).Value.ToString(), dgv_8_minimos.Rows(i).Cells(1).Value.ToString(), dgv_8_minimos.Rows(i).Cells(2).Value.ToString(), SumaDeMinimo, SumaDeExpr2, dgv_8_minimos.Rows(i).Cells(5).Value.ToString(), dgv_8_minimos.Rows(i).Cells(6).Value.ToString(), dias_mes, Minimo_proporcional, diff_dias, dgv_8_minimos.Rows(i).Cells(8).Value.ToString())
            Next i
        End If

        CR_Estado_de_pago_tercerosc.Show()
    End Sub
    Private Sub dgv_datosAgregados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados.CellContentClick
        If dgv_datosAgregados.Rows.Count > 1 Then
            If e.ColumnIndex = 20 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 3
                ElseIf Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Fecha").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column1").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column2").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column3").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column7").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column4").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column13").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("operador").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").Style.BackColor = Color.Salmon

                dgv_datosAgregados.Rows(e.RowIndex).Cells("Fecha").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column1").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column2").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column3").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column7").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column4").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column5").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column13").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("operador").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column6").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column9").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column10").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column11").ReadOnly = True
            End If
        End If
    End Sub

    Private Sub txt_1_rendimientos_TextChanged(sender As Object, e As EventArgs) Handles txt_1_rendimientos.TextChanged
        If Not IsNumeric(txt_1_rendimientos.Text) Then
            txt_1_rendimientos.Clear()
        End If
    End Sub

    Private Sub Button64_Click_3(sender As Object, e As EventArgs) Handles Button64.Click
        Dim fecha_in, fecha_fin As Date
        Dim Fecha_inicio As String
        Dim fecha_final As String

        Dim dia_inicial As Date
        Dim dia_final As Date
        Dim dias_mes As Integer
        Dim Minimo_proporcional As Double
        Dim diff_dias

        dia_inicial = CDate(dtp_fecha_in.Text)
        dia_final = CDate(dtp_fecha_fin.Text)

        dias_mes = DateTime.DaysInMonth(Year(dia_inicial), Month(dia_inicial))

        Fecha_inicio = Me.dtp_fecha_in.Value.ToShortDateString
        fecha_in = Fecha_inicio
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        fecha_final = Me.dtp_fecha_fin.Value.ToShortDateString
        fecha_fin = fecha_final
        fecha_final = Format(CDate(fecha_final), "yyyy/MM/dd")

        diff_dias = DateDiff(DateInterval.Day, fecha_in, fecha_fin) + 1

        nue_obra8.listar5(id_obra)
        dgv_8_minimos.DataSource = nue_obra8.listar6_2(id_obra, Fecha_inicio, fecha_final)

        If dgv_8_minimos.Rows.Count > 1 Then
            For i = 0 To dgv_8_minimos.Rows.Count - 2
                Dim SumaDeMinimo, SumaDeExpr2 As Double
                If IsNumeric(dgv_8_minimos.Rows(i).Cells(3).Value.ToString()) Then
                    SumaDeMinimo = dgv_8_minimos.Rows(i).Cells(3).Value.ToString()
                Else
                    SumaDeMinimo = 0
                End If

                If IsNumeric(dgv_8_minimos.Rows(i).Cells(4).Value.ToString()) Then
                    SumaDeExpr2 = dgv_8_minimos.Rows(i).Cells(4).Value.ToString()
                Else
                    SumaDeExpr2 = 0
                End If

                If IsNumeric(dgv_8_minimos.Rows(i).Cells(7).Value.ToString()) Then
                    Minimo_proporcional = dgv_8_minimos.Rows(i).Cells(7).Value.ToString()
                Else
                    Minimo_proporcional = 0
                End If

                nue_obra8.insertar_minimos(dgv_8_minimos.Rows(i).Cells(0).Value.ToString(), dgv_8_minimos.Rows(i).Cells(1).Value.ToString(), dgv_8_minimos.Rows(i).Cells(2).Value.ToString(), SumaDeMinimo, SumaDeExpr2, dgv_8_minimos.Rows(i).Cells(5).Value.ToString(), dgv_8_minimos.Rows(i).Cells(6).Value.ToString(), dias_mes, Minimo_proporcional, diff_dias, dgv_8_minimos.Rows(i).Cells(8).Value.ToString())
            Next i
        End If

        Dim Y As Integer
        Dim Z As Integer
        For Z = 0 To 19
            terceros(Z) = ""
        Next
        For Y = 0 To check_empresa2.Items.Count - 1
            If (check_empresa2.GetItemChecked(Y)) Then

                Dim Cadena As String = check_empresa2.Items(Y)
                Dim ArrCadena As String() = Cadena.Split(" / ")
                terceros(Y) = ArrCadena(0)
            End If
        Next

        CR_Estado_de_pago_terceros_selec.Show()

    End Sub
    Public Sub actualizar_check_empresa()
        Dim empresa As String
        Dim rut As String
        Dim rut_empresa As String

        dgv_emp.DataSource = nue_obra8.listar7(id_obra)

        If dgv_emp.Rows.Count > 0 Then
            For i = 0 To dgv_emp.Rows.Count - 2
                rut = dgv_emp.Rows(i).Cells(5).Value.ToString()
                empresa = dgv_emp.Rows(i).Cells(7).Value.ToString()
                rut_empresa = rut + " / " + empresa
                check_empresa2.Items.Add(rut_empresa)
            Next i
        End If
    End Sub

    Private Sub btn_listado_Click(sender As Object, e As EventArgs) Handles btn_listado.Click
        CR_listado_equipos.Show()
    End Sub

    Public Sub actualiza_pago4()
        cmb_4_tipo_pago.DataSource = nue_obra4.listar_pago4(id_obra, cmb_4_arrendador.SelectedValue.ToString())
        cmb_4_tipo_pago.DisplayMember = "forma"
        cmb_4_tipo_pago.ValueMember = "forma"
    End Sub

    Public Sub actualiza_operador4()
        cmb_4_operador.DataSource = nue_obra4.listar_operador4(id_obra, cmb_4_arrendador.SelectedValue.ToString(), cmb_4_tipo_pago.Text)
        cmb_4_operador.DisplayMember = "operador2"
        cmb_4_operador.ValueMember = "operador2"
    End Sub

    Public Sub actualiza_pago5()
        cmb_5_tipo_pago.DataSource = nue_obra4.listar_pago4(id_obra, cmb_5_arrendador.SelectedValue.ToString())
        cmb_5_tipo_pago.DisplayMember = "forma"
        cmb_5_tipo_pago.ValueMember = "forma"
    End Sub

    Public Sub actualiza_operador5()
        cmb_5_operador.DataSource = nue_obra4.listar_operador4(id_obra, cmb_5_arrendador.SelectedValue.ToString(), cmb_5_tipo_pago.Text)
        cmb_5_operador.DisplayMember = "operador2"
        cmb_5_operador.ValueMember = "operador2"
    End Sub

    Public Sub actualiza_pago6()
        cmb_6_tipo_pago.DataSource = nue_obra4.listar_pago4(id_obra, cmb_6_arrendador.SelectedValue.ToString())
        cmb_6_tipo_pago.DisplayMember = "forma"
        cmb_6_tipo_pago.ValueMember = "forma"
    End Sub

    Public Sub actualiza_operador6()
        cmb_6_operador.DataSource = nue_obra4.listar_operador4(id_obra, cmb_6_arrendador.SelectedValue.ToString(), cmb_6_tipo_pago.Text)
        cmb_6_operador.DisplayMember = "operador2"
        cmb_6_operador.ValueMember = "operador2"
    End Sub

    Public Sub actualiza_pago7()
        cmb_7_tipo_pago.DataSource = nue_obra4.listar_pago4(id_obra, cmb_7_arrendador.SelectedValue.ToString())
        cmb_7_tipo_pago.DisplayMember = "forma"
        cmb_7_tipo_pago.ValueMember = "forma"
    End Sub

    Public Sub actualiza_operador7()
        cmb_7_operador.DataSource = nue_obra4.listar_operador4(id_obra, cmb_7_arrendador.SelectedValue.ToString(), cmb_7_tipo_pago.Text)
        cmb_7_operador.DisplayMember = "operador2"
        cmb_7_operador.ValueMember = "operador2"
    End Sub

    Private Sub btn_descargar5_Click(sender As Object, e As EventArgs) Handles btn_descargar5.Click
        If (Cod_5 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            descargar_archivo()
        End If
    End Sub

    Private Sub btn_descargar7_Click(sender As Object, e As EventArgs) Handles btn_descargar7.Click
        If (Cod_7 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            descargar_finiquito()
        End If
    End Sub

    Private Sub TabPage7_Enter(sender As Object, e As EventArgs) Handles TabPage6.Enter, TabPage7.Enter
        num_tab = 1
        frm_menu_principal_VII.Show()
        Me.Close()
    End Sub
End Class