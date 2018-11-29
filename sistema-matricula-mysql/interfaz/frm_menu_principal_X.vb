Imports Word = Microsoft.Office.Interop.Word 'Control de office
Imports Microsoft.Office.Core
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop

Public Class frm_menu_principal_X

    Dim nue_obra8 As New clases.Generacion_ep
    Dim nue_report As New clases.listado_maquinas
    Dim nue_obra5 As New clases.Ingreso_subcontratos
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

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles Me.Load
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
End Class