Imports Word = Microsoft.Office.Interop.Word 'Control de office
Imports Microsoft.Office.Core
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop
Imports System.Net

Public Class frm_menu_principal_X
    Dim nue_obra6 As New clases.EstadoPagoMandante
    Dim nue_obra8 As New clases.Generacion_ep
    Dim nue_report As New clases.listado_maquinas
    Dim nue_obra5 As New clases.Ingreso_subcontratos
    Dim nue_var As New clases.variables
    Dim modificacionesIngresos As New clases.Modificaciones
    Dim Contrato As New clases.Contratos_Originales
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

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        RellenarCboObra()
        gbPagoFirmadoAdjunto.Visible = False
        gbFacturasFirmadas.Visible = False
        gbContratoOriginal.Visible = False
        gbModificacionesFirmadas.Visible = False
        LlenarDataGridView()
        actualizar_dgvFacturasAdjunto()
        Actualizar_dgvModificacion()
        Actualizar_dgvContrato()
        LlenarDataGridView()
        If sincroniza = 0 Then
            btn_5_ingresar.Visible = True
            btn_7_ingresar.Visible = True
            btn_eliminar5.Visible = True
            btn_eliminar7.Visible = True
            btn_descargar7.Visible = True
            btn_descargar5.Visible = True
        Else
            btn_5_ingresar.Visible = False
            btn_7_ingresar.Visible = False
            btn_eliminar5.Visible = False
            btn_eliminar7.Visible = False
            btn_descargar7.Visible = False
            btn_descargar5.Visible = False
        End If
        chk_iva.Checked = True
        Dim rtn As New Date

        actualizar_obras()
        actualiza_arrendador8()
        actualiza_arrendador10()
        actualizar_check_empresa()

        var_in1 = 0
        var_in2 = 0
        var_in3 = 0
        var_in4 = 0
        var_in5 = 0
        var_in6 = 0
        var_in7 = 0
        var_in8 = 0

        cmb_activo.Text = "Todos"
        lbl_nombre_obra.Text = Nombre_Obra
        lbl_usuario.Text = Nombre_Usuario
        Me.WindowState = FormWindowState.Maximized
        txt_1_nom_obra.Enabled = False
        txt_1_nom_obra.Text = Nombre_Obra
        cmb_1_gerente.Text = ""
        consulta_datos = 0
        consulta_datos_local = 0
        Timer1.Enabled = True
        txt_10_ep.Text = 1

        autoriza_2_1 = 1
        autoriza_2_2 = 1
        autoriza_2_3 = 1

        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 24).AddMonths(-2)

        With dtp_fecha_in
            .MaxDate = Today.AddMonths(1).AddDays(23 - Today.Day)
            .MinDate = Today.AddMonths(-2)
        End With
        With dtp_fecha_fin
            .MaxDate = Today.AddMonths(1).AddDays(23 - Today.Day)
            .MinDate = Today.AddMonths(-2)
        End With
        With dtp_10_fecha_inicial
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "23 MMMM yyyy"
            .MaxDate = Today.AddMonths(1).AddDays(23 - Today.Day)
            .MinDate = Today.AddMonths(-2)
        End With

        If sincroniza = 0 Then
            btn_sincronizar.Visible = False
            pb_list.Visible = False
            lbl_sincroniza.Text = "Trabajando con Internet"

        ElseIf sincroniza = 1 Then
            btn_sincronizar.Visible = True
            pb_list.Visible = True
            lbl_sincroniza.Text = "Trabajando sin Internet"
        End If


        If num_tab = 1 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 0
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 2 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 1
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 3 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 2
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 4 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 3
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 5 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 4
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 6 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 5
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 7 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 6
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 8 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 7
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 9 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 8
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 10 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 9
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 11 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 10
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 12 Then
            TabControl11.SelectedTab = TabPage10
            TabControl1.SelectedIndex = 11
            Me.TabPage52.Parent = Nothing
        End If

        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        num_tab = 1
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        num_tab = 0
        frm_menu_principal.Show()
        Me.Close()

    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        End
    End Sub

    Private Sub btn_10_detalle_ep_Click(sender As Object, e As EventArgs) Handles btn_10_detalle_ep.Click
        If txt_10_ep.Text <> "" Then
            CR_Estado_de_pago10.Show()

        Else
            MsgBox("FALTA INGRESAR EL N° DEL ESTADO DE PAGO")
        End If
    End Sub

    Private Sub btn_10_terceros_ep_Click(sender As Object, e As EventArgs) Handles btn_10_terceros_ep.Click
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

        CR_Estado_de_pago_terceros10.Show()
    End Sub

    Private Sub btn_10_resumen_ep_Click(sender As Object, e As EventArgs) Handles btn_10_resumen_ep.Click
        If txt_10_ep.Text <> "" Then
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
            dgv_8_minimos.DataSource = nue_obra8.listar4(id_obra, cmb_10_arrendador.SelectedValue.ToString(), Fecha_inicio, fecha_final)

            If dgv_8_minimos.Rows.Count > 0 Then
                For i = 0 To dgv_8_minimos.Rows.Count - 1
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


            CR_Resumen_Estado_Pago10.Show()
        Else
            MsgBox("FALTA INGRESAR EL N° DEL ESTADO DE PAGO")
        End If
    End Sub

    Private Sub btn_10_terceros_epc_Click(sender As Object, e As EventArgs) Handles btn_10_terceros_epc.Click
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

        CR_Estado_de_pago_tercerosc10.Show()
    End Sub

    Private Sub btn_10_horas_maq_Click(sender As Object, e As EventArgs) Handles btn_10_horas_maq.Click
        CR_Detalle_Horas10.Show()
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
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

        CR_Estado_de_pago_terceros_selec10.Show()
    End Sub

    Public Sub actualizar_obras()
        cmb_obra.DataSource = nue_report.listar()
        cmb_obra.DisplayMember = "Nombre"
        cmb_obra.ValueMember = "Id_obras"
    End Sub

    Private Sub btn_detalle_obra_Click(sender As Object, e As EventArgs) Handles btn_detalle_obra.Click
        If cmb_obra.Text <> "" And cmb_ordenar.Text <> "" And cmb_tipo_equipo.Text <> "" Then
            CR_listado_equipos10.Show()
        Else
            MsgBox("FALTA COMPLETAR LOS DATOS")
        End If
    End Sub

    Public Sub actualiza_arrendador8()
        cmb_10_arrendador.DataSource = nue_obra8.listar3(id_obra)
        cmb_10_arrendador.DisplayMember = "razon_social"
        cmb_10_arrendador.ValueMember = "rut"
    End Sub

    Private Sub btn_8_libro_compras_Click(sender As Object, e As EventArgs) Handles btn_8_libro_compras.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Libro_Compras10.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_compras_y_cons_Click(sender As Object, e As EventArgs) Handles btn_8_compras_y_cons.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) And IsNumeric(txt_8_stock_anterior.Text) Then
            CR_Informe_compras_y_consumo210.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_cuentas_contables_Click(sender As Object, e As EventArgs) Handles btn_8_cuentas_contables.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Cuentas_Petroleo10.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_storage_Click(sender As Object, e As EventArgs) Handles btn_8_storage.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Informe_Storage10.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_diesel_mensual_Click(sender As Object, e As EventArgs) Handles btn_8_diesel_mensual.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Diesel_Mensual10.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_diesel_completo_Click(sender As Object, e As EventArgs) Handles btn_8_diesel_completo.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Diesel_Completo10.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_libro_combustible_Click(sender As Object, e As EventArgs) Handles btn_8_libro_combustible.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Libro_combustible_diesel210.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_rendimiento_Click(sender As Object, e As EventArgs) Handles btn_8_rendimiento.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            Frm_menu_rendimientos10.ShowDialog()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_detalle_ep_Click(sender As Object, e As EventArgs) Handles btn_8_detalle_ep.Click
        If txt_8_ep.Text <> "" And cmb_8_subcontrato.Text <> "" Then
            CR_Estado_de_pago_subcontrato10.Show()
        Else
            MsgBox("FALTA INGRESAR EL N° DEL ESTADO DE PAGO O EL SUBCONTRATISTA")
        End If
    End Sub

    Private Sub btn_8_resumen_ep_Click(sender As Object, e As EventArgs) Handles btn_8_resumen_ep.Click
        If txt_8_ep.Text <> "" And cmb_8_subcontrato.Text <> "" Then
            CR_Resumen_Estado_Pago_subcontrato10.Show()
        Else
            MsgBox("FALTA INGRESAR EL N° DEL ESTADO DE PAGO O EL SUBCONTRATISTA")
        End If
    End Sub

    Public Sub actualiza_arrendador10()
        cmb_8_subcontrato.DataSource = nue_obra5.listar1(id_obra)
        cmb_8_subcontrato.DisplayMember = "nombre_subcon"
        cmb_8_subcontrato.ValueMember = "rut"
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
    Private Sub TabPage6_Enter(sender As Object, e As EventArgs) Handles TabPage6.Enter
        num_tab = 1
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub
    Private Sub TabPage7_Enter(sender As Object, e As EventArgs) Handles TabPage7.Enter
        num_tab = 1
        frm_menu_principal_VII.Show()
        Me.Close()
    End Sub
    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter
        num_tab = 1
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
        num_tab = 1
        frm_menu_principal_V.Show()
        Me.Close()
    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        num_tab = 1
        frm_menu_principal_II.Show()
        Me.Close()
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        num_tab = 1
        frm_menu_principal.Show()
        Me.Close()
    End Sub
    Private Sub btnEpFirmado_Click(sender As Object, e As EventArgs) Handles btnEpFirmado.Click
        gbPagoFirmadoAdjunto.Visible = True
        gbFacturasFirmadas.Visible = False
    End Sub

    Private Sub btnFacturasFirmadas_Click(sender As Object, e As EventArgs) Handles btnFacturasFirmadas.Click
        gbFacturasFirmadas.Visible = True
        gbPagoFirmadoAdjunto.Visible = False
    End Sub

    Private Sub dgvAdjuntosPagosFirmados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdjuntosPagosFirmados.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvAdjuntosPagosFirmados.Rows(index)

            txtNombreObraArchivo.Text = selectRow.Cells(1).Value.ToString()
            If txtNombreObraArchivo.Text <> "" Then
                txtNroEstadoPagoArchivo.Text = selectRow.Cells(2).Value.ToString()
                txtNombreArchivo.Text = selectRow.Cells(3).Value.ToString()
                txtUsuarioArchivo.Text = selectRow.Cells(4).Value.ToString()
                txtFechaAdjuntadoArchivo.Text = selectRow.Cells(5).Value
            Else
                MsgBox("No se encuentra registro de adjuntos", MsgBoxStyle.Information)
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargar.Click
        Try
            If txtNombreArchivo.Text <> "" Then
                Dim nombreArchivo As String
                nombreArchivo = txtNombreArchivo.Text
                SaveFileDialogEP.FileName = txtNombreArchivo.Text
                If SaveFileDialogEP.ShowDialog = DialogResult.OK Then
                    SaveFileDialogEP.Title = "Escoje la ruta para descargar"
                    SaveFileDialogEP.InitialDirectory = "Descargas"
                    lblRutaDescarga.Text = SaveFileDialogEP.FileName
                    FTPDownloadFile(lblRutaDescarga.Text + "", "ftp://201.148.105.75/Estado_De_Pago_Mandante/Estados_De_Pago_Firmados" + "/" + txtNombreArchivo.Text + "", "cfv@constructorafv.com", "gsolis2013")
                    lblRutaDescarga.Text = ""
                    SaveFileDialogEP.FileName = ""
                Else
                    SaveFileDialogEP.FileName = ""
                End If
            Else
                MsgBox("Debe seleccionar un registro", MsgBoxStyle.Exclamation)
                SaveFileDialogEP.FileName = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboObra_SelectionChangeCommitted(sender As Object, e As EventArgs)
        LlenarDataGridView()
    End Sub
    Public Function Limpiar()
        txtNombreObraArchivo.Text = ""
        txtNroEstadoPagoArchivo.Text = ""
        txtNombreArchivo.Text = ""
        txtUsuarioArchivo.Text = ""
        txtFechaAdjuntadoArchivo.Text = ""
    End Function
    Public Function RellenarCboObra()
        Try
            cboObras.DataSource = nue_obra5.listar5(id_obra)
            cboObras.DisplayMember = "nombre_faena"
            cboObras.ValueMember = "Id_identificacion"
            cboObras.Text = Module1.Nombre_Obra

            cboObrasModificacion.DataSource = nue_obra5.listar5(id_obra)
            cboObrasModificacion.DisplayMember = "nombre_faena"
            cboObrasModificacion.ValueMember = "Id_identificacion"
            cboObrasModificacion.Text = Module1.Nombre_Obra


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    'Rellenar GridView
    Sub LlenarDataGridView()
        Try
            Dim total As Double = 0
            Dim obrasFiltro As String

            obrasFiltro = cboObras.Text
            If obrasFiltro = "System.Data.DataRowView" Then
                obrasFiltro = Nombre_Obra
            End If

            Dim fila As DataGridViewRow = New DataGridViewRow()
            dgvFacturasAdjunto.DataSource = nue_obra6.LeerAdjuntoFacturas(obrasFiltro)
            With dgvFacturasAdjunto
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra Adjunto"
                .Columns(2).HeaderCell.Value = "Obra"
                .Columns(2).Visible = False
                .Columns(3).HeaderCell.Value = "N° Estado de Pago Asociado"
                .Columns(4).HeaderCell.Value = "N° Factura"
                .Columns(5).HeaderCell.Value = "Adjunto"
                .Columns(6).HeaderCell.Value = "Usuario"
                .Columns(7).HeaderCell.Value = "Fecha de subida"
                .Columns(8).HeaderCell.Value = "Adjunto"
                .Columns(8).Visible = False

                dgvFacturasAdjunto.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Metodos
    'Descarga desde FTP

    Private Sub FTPDownloadFile(ByVal downloadpath As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
        'Create a WebClient.
        Dim request As New WebClient()

        ' Confirm the Network credentials based on the user name and password passed in.
        request.Credentials = New NetworkCredential(ftpusername, ftppassword)

        'Read the file data into a Byte array
        Dim bytes() As Byte = request.DownloadData(ftpuri)

        Try
            '  Create a FileStream to read the file into
            Dim DownloadStream As FileStream = IO.File.Create(downloadpath)
            '  Stream this data into the file
            DownloadStream.Write(bytes, 0, bytes.Length)
            '  Close the FileStream
            DownloadStream.Close()
            MsgBox("Se ha descargado el archivo ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub btnDescargarFacturasAdjuntas_Click(sender As Object, e As EventArgs) Handles btnDescargarFacturasAdjuntas.Click
        Try
            If txtAdjuntoFacturasFirmadas.Text <> "" Then
                SaveFileDialogFacturasFirmadas.FileName = txtAdjuntoFacturasFirmadas.Text
                If SaveFileDialogFacturasFirmadas.ShowDialog = DialogResult.OK Then
                    SaveFileDialogFacturasFirmadas.Title = "Escoje la ruta para descargar"
                    SaveFileDialogFacturasFirmadas.InitialDirectory = "Descargas"
                    lblAdjuntoFacturas.Text = SaveFileDialogFacturasFirmadas.FileName
                    FTPDownloadFile(lblAdjuntoFacturas.Text + "", "ftp://201.148.105.75/Estado_De_Pago_Mandante/Facturas_Firmadas/" + txtAdjuntoFacturasFirmadas.Text, "cfv@constructorafv.com", "gsolis2013")
                    SaveFileDialog1.FileName = ""
                    lblAdjuntoFacturas.Text = ""
                End If
                SaveFileDialogFacturasFirmadas.FileName = ""
            Else
                MsgBox("Debes seleccionar un registro", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvFacturasAdjunto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturasAdjunto.CellClick
        Try

            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvFacturasAdjunto.Rows(index)


            txtInfoObra.Text = selectRow.Cells(2).Value.ToString()
            If txtInfoObra.Text <> "" Then

                txtInfoNroEstadoPago.Text = selectRow.Cells(3).Value.ToString()
                txtInfoNroFactura.Text = selectRow.Cells(4).Value.ToString()
                txtAdjuntoFacturasFirmadas.Text = selectRow.Cells(8).Value.ToString()
                txtInfoFechaAdjunto.Text = selectRow.Cells(7).Value
            Else
                MsgBox("No se encuentra registro de adjuntos", MsgBoxStyle.Information)
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboObraFactura_SelectionChangeCommitted(sender As Object, e As EventArgs)
        actualizar_dgvFacturasAdjunto()
        Limpiar()
    End Sub
    Sub actualizar_dgvFacturasAdjunto()
        Try
            Dim total As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim obraFiltro As String
            obraFiltro = cboObras.Text
            If obraFiltro = "System.Data.DataRowView" Then
                obraFiltro = Nombre_Obra
            End If

            dgvAdjuntosPagosFirmados.DataSource = nue_obra6.LeerAdjuntoPagosFirmados(obraFiltro)
            With dgvAdjuntosPagosFirmados
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(6).HeaderCell.Value = "Obra"

                .Columns(2).HeaderCell.Value = "Nro Estado de Pago"
                .Columns(3).HeaderCell.Value = "Adjunto"
                .Columns(3).Visible = False
                .Columns(4).HeaderCell.Value = "Usuario"
                .Columns(5).HeaderCell.Value = "Fecha de subida"
                'Obra que realiza el filtro para realizar la conexión con el left Join
                .Columns(1).HeaderCell.Value = "Obras"
                .Columns(1).Visible = False
                .Columns(7).HeaderCell.Value = "Adjunto"
                dgvAdjuntosPagosFirmados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboObras_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboObras.SelectionChangeCommitted
        actualizar_dgvFacturasAdjunto()
        LlenarDataGridView()
    End Sub

    Private Sub btnEstadoPago_Click(sender As Object, e As EventArgs) Handles btnEstadoPago.Click
        Try
            If cboObras.Text <> "" Then
                Module1.Nombre_Faena = cboObras.Text
                CR_EstadoPagoMandante.Show()
            Else
                MsgBox("Debe selecionar una obra", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Favor, contacte al administrador", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        gbContratoOriginal.Visible = True
        gbModificacionesFirmadas.Visible = False
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        gbContratoOriginal.Visible = False
        gbModificacionesFirmadas.Visible = True
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        Try
            If cboObras.Text <> "" Then
                Module1.Nombre_Faena = cboObrasModificacion.Text
                CR_ListadoContratoModificaciones.Show()
            Else
                MsgBox("Debe selecionar una obra", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Favor, contacte al administrador", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs)
        Try
            lblRutaDescarga.Text.ToString()
            If txtidContratoOriginal.Text <> "" Then
                SaveFileDialog3.FileName = txtNombreArchivo.Text
                If SaveFileDialog3.ShowDialog = DialogResult.OK Then
                    SaveFileDialog3.Title = "Escoje la ruta para descargar"
                    SaveFileDialog3.InitialDirectory = "Descargas"
                    lblRutaDescarga.Text = SaveFileDialog3.FileName

                    FTPDownloadFile(lblRutaDescarga.Text + "", "ftp://201.148.105.75/Contrato_Original_Modificaciones_Obras/Contrato_Original/" + txtNombreArchivo.Text + "", "cfv@constructorafv.com", "gsolis2013")
                    lblRutaDescarga.Text = ""
                    SaveFileDialog3.FileName = ""
                End If
            Else
                MsgBox("Debe seleccionar un registro", MsgBoxStyle.Exclamation)
                lblRutaDescarga.Text = ""
                SaveFileDialog3.FileName = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub DgvModificaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvModificaciones.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = DgvModificaciones.Rows(index)
            txtIdModificacionesContrato.Text = selectRow.Cells(0).Value.ToString()
            If txtIdModificacionesContrato.Text <> "" Then
                txtObraModificaciones.Text = selectRow.Cells(1).Value.ToString()
                txtxNroModificacionModificaciones.Text = selectRow.Cells(2).Value.ToString()
                txtNombreAdjuntoModificaciones.Text = selectRow.Cells(3).Value.ToString()
                txtUsuarioModificaciones.Text = selectRow.Cells(4).Value.ToString()
                txtFechaAdjuntoModificaciones.Text = selectRow.Cells(5).Value
            Else
                MsgBox("No se encuentra registro de adjuntos", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        Try
            If txtObraModificaciones.Text <> "" And txtFechaAdjuntoModificaciones.Text <> "" And txtxNroModificacionModificaciones.Text <> "" Then

                SaveFileDialog3.FileName = txtNombreAdjuntoModificaciones.Text
                SaveFileDialog3.Title = "Escoje la ruta para descargar"
                SaveFileDialog3.InitialDirectory = "Descargas"
                If SaveFileDialog3.ShowDialog = DialogResult.OK Then
                    lblRutaDescarga.Text = SaveFileDialog3.FileName
                    FTPDownloadFile(lblRutaDescarga.Text + "", "ftp://201.148.105.75/Contrato_Original_Modificaciones_Obras/Modificaciones/" + txtNombreAdjuntoModificaciones.Text + "", "cfv@constructorafv.com", "gsolis2013")
                    SaveFileDialog3.FileName = ""
                    lblRutaDescarga.Text = ""
                End If
            Else
                MsgBox("Debe seleccionar un archivo", MsgBoxStyle.Exclamation)
                SaveFileDialog3.FileName = ""


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cboFiltroContrato_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboObrasModificacion.SelectionChangeCommitted
        Actualizar_dgvModificacion()
        Actualizar_dgvContrato()
    End Sub

    Private Sub Actualizar_dgvModificacion()
        Try
            Dim fila As DataGridViewRow = New DataGridViewRow()
            DgvModificaciones.DataSource = modificacionesIngresos.LeerDgvModificaciones(cboObrasModificacion.Text)
            With DgvModificaciones
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra Adjunto"
                .Columns(2).HeaderCell.Value = "N° Modificación"
                .Columns(3).HeaderCell.Value = "Adjunto"
                .Columns(3).Visible = False
                .Columns(4).HeaderCell.Value = "Usuario"
                .Columns(5).HeaderCell.Value = "Fecha de subida"
                .Columns(6).HeaderCell.Value = "Adjunto"
                .Columns(7).HeaderCell.Value = "Obra"
                .Columns(7).Visible = False
                DgvModificaciones.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DgvModificaciones.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DgvModificaciones.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DgvModificaciones.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DgvModificaciones.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Actualizar_dgvContrato()
        Try
            'Dim total As Double = 0
            'Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim obra As String
            obra = cboObrasModificacion.Text
            dgvContratoOriginal.DataSource = Contrato.LeerDgvContrato(obra)
            With dgvContratoOriginal
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra"
                .Columns(2).HeaderCell.Value = "Adjunto"
                .Columns(3).HeaderCell.Value = "Usuario"
                .Columns(4).HeaderCell.Value = "Fecha"
                .Columns(5).HeaderCell.Value = "Adjunto"
                .Columns(5).Visible = False
            End With
            dgvContratoOriginal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvContratoOriginal.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvContratoOriginal.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvContratoOriginal.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvContratoOriginal.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells



            'Metodo para contar el total de una fila
            'For Each fila In dgvEstadoPago.Rows
            ' total += Convert.ToDouble(fila.Cells(7).Value)
            ' Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvContratoOriginal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvContratoOriginal.Rows(index)
            txtidContratoOriginal.Text = selectRow.Cells(0).Value.ToString()
            txtNombreObraArchivo.Text = selectRow.Cells(1).Value.ToString()
            txtNombreArchivo.Text = selectRow.Cells(5).Value.ToString()
            txtUsuarioArchivo.Text = selectRow.Cells(3).Value.ToString()
            txtFechaAdjuntadoArchivo.Text = selectRow.Cells(4).Value()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgvContratoOriginal_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvContratoOriginal.CellMouseClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvContratoOriginal.Rows(index)
            txtidContratoOriginal.Text = selectRow.Cells(0).Value.ToString()
            txtObraContrato.Text = selectRow.Cells(1).Value.ToString()
            txtNombreContrato.Text = selectRow.Cells(5).Value.ToString()
            txtContratoResponsable.Text = selectRow.Cells(3).Value.ToString()
            txtFechaContrato.Text = selectRow.Cells(4).Value()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDescargarContrato_Click(sender As Object, e As EventArgs) Handles btnDescargarContrato.Click
        Try
            lblRutaDescarga.Text.ToString()
            If txtidContratoOriginal.Text <> "" Then
                SaveFileDialog3.FileName = txtNombreContrato.Text
                If SaveFileDialog3.ShowDialog = DialogResult.OK Then
                    SaveFileDialog3.Title = "Escoje la ruta para descargar"
                    SaveFileDialog3.InitialDirectory = "Descargas"
                    lblRutaDescarga.Text = SaveFileDialog3.FileName

                    FTPDownloadFile(lblRutaDescarga.Text + "", "ftp://201.148.105.75/Contrato_Original_Modificaciones_Obras/Contrato_Original/" + txtNombreContrato.Text + "", "cfv@constructorafv.com", "gsolis2013")
                    lblRutaDescarga.Text = ""
                    SaveFileDialog3.FileName = ""
                End If
            Else
                MsgBox("Debe seleccionar un registro", MsgBoxStyle.Exclamation)
                lblRutaDescarga.Text = ""
                SaveFileDialog3.FileName = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class