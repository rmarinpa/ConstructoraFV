Public Class frm_menu_principal_II
    Dim nue_obra1 As New clases.Identificacion_obra
    Dim nue_obra2 As New clases.Tabla_Plan_de_Cuentas
    Dim nue_obra3 As New clases.Tabla_UF
    Dim nue_var As New clases.variables
    Dim Cod_1 As String = ""
    Dim Cod_2 As String = ""
    Dim Cod_3 As String = ""
    Dim sw1 As Integer
    Dim sw2 As Integer
    Dim sw3 As Integer
    Dim sincroniza_local As Integer
    Dim sincroniza_local2 As Integer
    Dim sincroniza_local3 As Integer
    Dim sincroniza_mod1 As Integer
    Dim sincroniza_mod2 As Integer
    Dim sincroniza_mod3 As Integer
    Dim version_mod1 As Integer
    Dim version_mod2 As Integer
    Dim version_mod3 As Integer

    Sub bloquear1()
        txt_1_nom_obra.Enabled = False
        txt_1_nom_faena.Enabled = False
        txt_1_prof_residente.Enabled = False
        txt_1_rut_prof.Enabled = False
        txt_1_jefe.Enabled = False
        cmb_1_gerente.Enabled = False
        txt_1_mandante.Enabled = False
        txt_1_resol.Enabled = False
        dtp_1_res.Enabled = False
        dtp_1_inicio.Enabled = False
        txt_1_plazo.Enabled = False
        dtp_1_final.Enabled = False
        txt_1_monto.Enabled = False
        txt_1_det_obra.Enabled = False
        txt_1_retenciones.Enabled = False
        txt_1_proforma.Enabled = False

        btn_cancelar1.Enabled = False
        btn_guardar1.Enabled = False
        btn_editar1.Enabled = True
        btn_nuevo1.Enabled = True
        btn_eliminar1.Enabled = True
    End Sub
    Sub desbloquear1()
        txt_1_nom_faena.Enabled = True
        txt_1_prof_residente.Enabled = True
        txt_1_rut_prof.Enabled = True
        txt_1_jefe.Enabled = True
        cmb_1_gerente.Enabled = True
        txt_1_mandante.Enabled = True
        txt_1_resol.Enabled = True
        dtp_1_res.Enabled = True
        dtp_1_inicio.Enabled = True
        txt_1_plazo.Enabled = True
        txt_1_monto.Enabled = True
        txt_1_det_obra.Enabled = True
        txt_1_retenciones.Enabled = True
        txt_1_proforma.Enabled = True

        btn_cancelar1.Enabled = True
        btn_guardar1.Enabled = True
        btn_editar1.Enabled = False
        btn_nuevo1.Enabled = False
        btn_eliminar1.Enabled = False
    End Sub
    Sub limpiar1()
        txt_1_nom_faena.Clear()
        txt_1_prof_residente.Clear()
        txt_1_rut_prof.Clear()
        txt_1_jefe.Clear()
        cmb_1_gerente.Text = ""
        txt_1_mandante.Clear()
        txt_1_resol.Clear()
        txt_1_plazo.Clear()
        txt_1_monto.Clear()
        txt_1_det_obra.Clear()
        txt_1_retenciones.Clear()
        txt_1_proforma.Clear()
        Cod_1 = ""
        version_mod1 = 0
    End Sub
    Sub bloquear2()
        txt_2_cuenta.Enabled = False
        txt_2_descripcion.Enabled = False

        btn_cancelar2.Enabled = False
        btn_guardar2.Enabled = False
        btn_editar2.Enabled = True
        btn_nuevo2.Enabled = True
        btn_eliminar2.Enabled = True
    End Sub

    Sub desbloquear2()
        txt_2_cuenta.Enabled = True
        txt_2_descripcion.Enabled = True

        btn_cancelar2.Enabled = True
        btn_guardar2.Enabled = True
        btn_editar2.Enabled = False
        btn_nuevo2.Enabled = False
        btn_eliminar2.Enabled = False
    End Sub
    Sub limpiar2()
        txt_2_cuenta.Clear()
        txt_2_descripcion.Clear()
        Cod_2 = ""
    End Sub
    Sub bloquear3()
        txt_3_uf.Enabled = False
        dtp_3_actual.Enabled = False

        btn_cancelar3.Enabled = False
        btn_guardar3.Enabled = False
        btn_editar3.Enabled = True
        btn_nuevo3.Enabled = True
        btn_eliminar3.Enabled = True
    End Sub

    Sub desbloquear3()
        txt_3_uf.Enabled = True
        dtp_3_actual.Enabled = True

        btn_cancelar3.Enabled = True
        btn_guardar3.Enabled = True
        btn_editar3.Enabled = False
        btn_nuevo3.Enabled = False
        btn_eliminar3.Enabled = False
    End Sub
    Sub limpiar3()
        txt_3_uf.Clear()
        Cod_3 = ""
    End Sub
    Sub autoriza1()
        If autoriza_1 = 1 Then
            btn_cancelar1.Visible = True
            btn_guardar1.Visible = True
            btn_editar1.Visible = True
            btn_nuevo1.Visible = True
            btn_eliminar1.Visible = True
        ElseIf autoriza_1 = 0 Then
            btn_cancelar1.Visible = False
            btn_guardar1.Visible = False
            btn_editar1.Visible = False
            btn_nuevo1.Visible = False
            btn_eliminar1.Visible = False
        End If
    End Sub
    Sub autoriza2()
        If autoriza_2 = 1 Then
            btn_cancelar2.Visible = True
            btn_guardar2.Visible = True
            btn_editar2.Visible = True
            btn_nuevo2.Visible = True
            btn_eliminar2.Visible = True
        ElseIf autoriza_2 = 0 Then
            btn_cancelar2.Visible = False
            btn_guardar2.Visible = False
            btn_editar2.Visible = False
            btn_nuevo2.Visible = False
            btn_eliminar2.Visible = False
        End If
    End Sub
    Sub autoriza3()
        If autoriza_3 = 1 Then
            btn_cancelar3.Visible = True
            btn_guardar3.Visible = True
            btn_editar3.Visible = True
            btn_nuevo3.Visible = True
            btn_eliminar3.Visible = True
        ElseIf autoriza_3 = 0 Then
            btn_cancelar3.Visible = False
            btn_guardar3.Visible = False
            btn_editar3.Visible = False
            btn_nuevo3.Visible = False
            btn_eliminar3.Visible = False
        End If
    End Sub

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_nombre_obra.Text = Nombre_Obra
        lbl_usuario.Text = Nombre_Usuario
        Me.WindowState = FormWindowState.Maximized
        txt_1_nom_obra.Enabled = False
        txt_1_nom_obra.Text = Nombre_Obra
        cmb_1_gerente.Text = ""
        bloquear1()
        bloquear2()
        bloquear3()
        autoriza1()
        autoriza2()
        autoriza3()
        actualizar_dgv1()
        actualizar_dgv2()
        actualizar_dgv3()

        'With dtp_3_actual
        '    .Format = DateTimePickerFormat.Custom
        '    .CustomFormat = "23 MMMM yyyy"
        '    .MaxDate = Today.AddMonths(+1).AddDays(23 - Today.Day)
        '    .MinDate = Today.AddMonths(-2)
        'End With

        If sincroniza = 0 Then
            btn_sincronizar.Visible = False
            pb_list.Visible = False
            lbl_sincroniza.Text = "Trabajando con Internet"
            'btn_editar1.Visible = True
            'btn_eliminar1.Visible = True

            'btn_editar2.Visible = True
            'btn_eliminar2.Visible = True

            'btn_editar3.Visible = True
            'btn_eliminar3.Visible = True
        ElseIf sincroniza = 1 Then
            btn_sincronizar.Visible = True
            pb_list.Visible = True
            lbl_sincroniza.Text = "Trabajando sin Internet"
            'btn_editar1.Visible = False
            'btn_eliminar1.Visible = False

            'btn_editar2.Visible = False
            'btn_eliminar2.Visible = False

            'btn_editar3.Visible = False
            'btn_eliminar3.Visible = False
        End If

        If num_tab = 1 Then
            TabControl11.SelectedTab = TabPage2
            Panel.SelectedIndex = 0
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 2 Then
            TabControl11.SelectedTab = TabPage2
            Panel.SelectedIndex = 1
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 3 Then
            TabControl11.SelectedTab = TabPage2
            Panel.SelectedIndex = 2
            Me.TabPage52.Parent = Nothing
        End If
    End Sub
    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        num_tab = 0
        frm_menu_principal.Show()
        Me.Close()
    End Sub
    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        End
    End Sub
    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        If num_tab <> 0 Then
            num_tab = 0
            frm_menu_principal.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btn_nuevo1_Click(sender As Object, e As EventArgs) Handles btn_nuevo1.Click
        desbloquear1()
        limpiar1()
        sw1 = 0
        Cod_1 = ""
    End Sub
    Private Sub btn_nuevo2_Click(sender As Object, e As EventArgs) Handles btn_nuevo2.Click
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
    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles btn_cancelar3.Click
        bloquear3()
    End Sub
    Private Sub btn_cancelar2_Click(sender As Object, e As EventArgs) Handles btn_cancelar2.Click
        bloquear2()
    End Sub
    Private Sub btn_cancelar1_Click(sender As Object, e As EventArgs) Handles btn_cancelar1.Click
        bloquear1()
    End Sub
    Private Sub btn_guardar1_Click(sender As Object, e As EventArgs) Handles btn_guardar1.Click
        Dim nombre_faena, prof_residente, rut_prof_residente, jefe_oficina, gerente_cargo, mandante, detalle_obra As String
        Dim plazo, monto, retenciones, proforma As Double
        Dim num_resolucion As String
        Dim fecha_resol, fecha_inicio, fecha_fin As Date

        If (txt_1_nom_obra.Text <> "" And txt_1_nom_faena.Text <> "" And txt_1_prof_residente.Text <> "") Then

            nombre_faena = txt_1_nom_faena.Text
            prof_residente = txt_1_prof_residente.Text
            rut_prof_residente = txt_1_rut_prof.Text
            jefe_oficina = txt_1_jefe.Text
            gerente_cargo = cmb_1_gerente.Text
            mandante = txt_1_mandante.Text
            detalle_obra = txt_1_det_obra.Text

            'sincroniza_local = 1

            If Not IsNumeric(txt_1_plazo.Text) Then
                plazo = 0
            Else
                plazo = CDbl(txt_1_plazo.Text)
            End If

            If Not IsNumeric(txt_1_monto.Text) Then
                monto = 0
            Else
                monto = CDbl(txt_1_monto.Text)
            End If

            If Not IsNumeric(txt_1_retenciones.Text) Then
                retenciones = 0
            Else
                retenciones = CDbl(txt_1_retenciones.Text)
            End If

            If Not IsNumeric(txt_1_proforma.Text) Then
                proforma = 0
            Else
                proforma = CDbl(txt_1_proforma.Text)
            End If

            num_resolucion = txt_1_resol.Text

            fecha_resol = CDate(dtp_1_res.Text)
            fecha_inicio = CDate(dtp_1_inicio.Text)
            fecha_fin = CDate(dtp_1_final.Text)

            If sw1 = 0 Then
                nue_obra1.insertar(1, 0, Nombre_Obra, id_obra, nombre_faena, prof_residente, rut_prof_residente, jefe_oficina, gerente_cargo, mandante, num_resolucion, fecha_resol, fecha_inicio, plazo, fecha_fin, monto, detalle_obra, retenciones, proforma)
                actualizar_dgv1()

            ElseIf sincroniza_local = 1 And sincroniza = 1 And sw1 <> 0 Then
                nue_obra1.modificar(CInt(Cod_1), 1, 0, Nombre_Obra, id_obra, nombre_faena, prof_residente, rut_prof_residente, jefe_oficina, gerente_cargo, mandante, num_resolucion, fecha_resol, fecha_inicio, plazo, fecha_fin, monto, detalle_obra, retenciones, proforma)
                actualizar_dgv1()

            ElseIf sincroniza = 0 And sw1 <> 0 Then
                version_mod1 = version_mod1 + 1
                nue_obra1.modificar(CInt(Cod_1), 2, version_mod1, Nombre_Obra, id_obra, nombre_faena, prof_residente, rut_prof_residente, jefe_oficina, gerente_cargo, mandante, num_resolucion, fecha_resol, fecha_inicio, plazo, fecha_fin, monto, detalle_obra, retenciones, proforma)
                actualizar_dgv1()
            Else
                version_mod1 = version_mod1 + 1
                nue_obra1.modificar(CInt(Cod_1), 2, version_mod1, Nombre_Obra, id_obra, nombre_faena, prof_residente, rut_prof_residente, jefe_oficina, gerente_cargo, mandante, num_resolucion, fecha_resol, fecha_inicio, plazo, fecha_fin, monto, detalle_obra, retenciones, proforma)
                actualizar_dgv1()
            End If
            limpiar1()
            bloquear1()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub btn_editar2_Click(sender As Object, e As EventArgs) Handles btn_editar2.Click
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
            eliminar1 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar1 = MsgBoxResult.Ok And sincroniza = 0 Then
                version_mod1 = version_mod1 + 1
                nue_obra1.eliminar_sincro(CInt(Cod_1), 3, version_mod1)
                actualizar_dgv1()
                bloquear1()
                limpiar1()
            ElseIf sincroniza_local = 1 And sincroniza = 1 And eliminar1 = MsgBoxResult.Ok Then
                nue_obra1.eliminar(CInt(Cod_1))
                actualizar_dgv1()
                bloquear1()
                limpiar1()
            ElseIf eliminar1 = MsgBoxResult.Ok Then
                version_mod1 = version_mod1 + 1
                nue_obra1.eliminar_sincro(CInt(Cod_1), 3, version_mod1)
                actualizar_dgv1()
                bloquear1()
                limpiar1()
            End If
        End If
    End Sub

    Private Sub btn_eliminar2_Click(sender As Object, e As EventArgs) Handles btn_eliminar2.Click
        Dim eliminar2 As MsgBoxResult
        If (Cod_2 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar2 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.OkCancel, "Confirmar")

            If eliminar2 = MsgBoxResult.Ok And sincroniza = 0 Then
                version_mod2 = version_mod2 + 1
                nue_obra2.eliminar_sincro(CInt(Cod_2), 3, version_mod2)
                actualizar_dgv2()
                bloquear2()
                limpiar2()

            ElseIf sincroniza_local2 = 1 And sincroniza = 1 And eliminar2 = MsgBoxResult.Ok Then
                nue_obra2.eliminar(CInt(Cod_2))
                actualizar_dgv2()
                bloquear2()
                limpiar2()

            ElseIf eliminar2 = MsgBoxResult.Ok Then
                version_mod2 = version_mod2 + 1
                nue_obra2.eliminar_sincro(CInt(Cod_2), 3, version_mod2)
                actualizar_dgv2()
                bloquear2()
                limpiar2()
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

            ElseIf sincroniza_local3 = 1 And sincroniza = 1 And eliminar3 = MsgBoxResult.Ok Then
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
        Dim valor_uf As Double
        Dim fecha_actual As Date

        If (dtp_3_actual.Text <> "" And txt_3_uf.Text <> "") Then

            valor_uf = CDbl(txt_3_uf.Text)
            fecha_actual = CDate(dtp_3_actual.Text)
            'fecha_actual = CDate("23/" & Month(dtp_3_actual.Text) & "/" & Year(dtp_3_actual.Text))


            If sw3 = 0 Then
                If nue_obra3.verificar_uf(id_obra, fecha_actual) = 1 Then
                    MsgBox("LA UF PARA ESTA FECHA YA ESTA INGRESADA")
                Else
                    nue_obra3.insertar(1, 0, Nombre_Obra, id_obra, fecha_actual, valor_uf)
                    actualizar_dgv3()
                End If

            ElseIf sincroniza_local3 = 1 And sincroniza = 1 And sw3 <> 0 Then
                nue_obra3.modificar(CInt(Cod_3), 1, 0, Nombre_Obra, id_obra, fecha_actual, valor_uf)
                actualizar_dgv3()

            ElseIf sw3 <> 0 And sincroniza = 0 Then
                version_mod3 = version_mod3 + 1
                nue_obra3.modificar(CInt(Cod_3), 2, version_mod3, Nombre_Obra, id_obra, fecha_actual, valor_uf)
                actualizar_dgv3()

            Else
                version_mod3 = version_mod3 + 1
                nue_obra3.modificar(CInt(Cod_3), 2, version_mod3, Nombre_Obra, id_obra, fecha_actual, valor_uf)
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
            txt_1_nom_faena.Enabled = False
            sw1 = 1
        End If
    End Sub

    Private Sub btn_guardar2_Click(sender As Object, e As EventArgs) Handles btn_guardar2.Click
        Dim Cuenta_costo, Descripcion As String

        If (txt_2_cuenta.Text <> "" And txt_2_descripcion.Text <> "") Then

            Cuenta_costo = txt_2_cuenta.Text
            Descripcion = txt_2_descripcion.Text
            'sincroniza_local2 = 1

            If sw2 = 0 Then
                nue_obra2.insertar(1, 0, Nombre_Obra, id_obra, Cuenta_costo, Descripcion)
                actualizar_dgv2()

            ElseIf sincroniza_local2 = 1 And sincroniza = 1 And sw2 <> 0 Then
                nue_obra2.modificar(CInt(Cod_2), 1, 0, Nombre_Obra, id_obra, Cuenta_costo, Descripcion)
                actualizar_dgv2()

            ElseIf sw2 <> 0 And sincroniza = 0 Then
                version_mod2 = version_mod2 + 1
                nue_obra2.modificar(CInt(Cod_2), 2, version_mod2, Nombre_Obra, id_obra, Cuenta_costo, Descripcion)
                actualizar_dgv2()
            Else
                version_mod2 = version_mod2 + 1
                nue_obra2.modificar(CInt(Cod_2), 2, version_mod2, Nombre_Obra, id_obra, Cuenta_costo, Descripcion)
                actualizar_dgv2()
            End If
            limpiar2()
            bloquear2()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub
    Sub actualizar_dgv1()
        dgv_1_faenas.DataSource = nue_obra1.listar2(id_obra)
        dgv_1_faenas.Columns(0).Visible = False
        dgv_1_faenas.Columns(1).Visible = False
        dgv_1_faenas.Columns(2).Visible = False
        dgv_1_faenas.Columns(3).Visible = False
        dgv_1_faenas.Columns(4).Visible = False
        dgv_1_faenas.Columns(5).HeaderText = "Faena"
        dgv_1_faenas.Columns(5).Width = 150
        dgv_1_faenas.Columns(6).HeaderText = "Residente"
        dgv_1_faenas.Columns(6).Width = 150
        dgv_1_faenas.Columns(7).Visible = False
        dgv_1_faenas.Columns(8).HeaderText = "O. Técnica"
        dgv_1_faenas.Columns(8).Width = 150
        dgv_1_faenas.Columns(9).HeaderText = "Gerente a Cargo"
        dgv_1_faenas.Columns(9).Width = 150
        dgv_1_faenas.Columns(10).Visible = False
        dgv_1_faenas.Columns(11).HeaderText = "N° Resolución"
        dgv_1_faenas.Columns(11).Width = 100
        dgv_1_faenas.Columns(11).DefaultCellStyle.Format = "##,###.##"
        dgv_1_faenas.Columns(12).HeaderText = "Fecha Resolución"
        dgv_1_faenas.Columns(12).Width = 100
        dgv_1_faenas.Columns(13).HeaderText = "Fecha Inicio"
        dgv_1_faenas.Columns(13).Width = 100
        dgv_1_faenas.Columns(14).HeaderText = "Plazo"
        dgv_1_faenas.Columns(14).Width = 100
        dgv_1_faenas.Columns(15).HeaderText = "Fecha Término"
        dgv_1_faenas.Columns(15).Width = 100
        dgv_1_faenas.Columns(16).HeaderText = "Monto"
        dgv_1_faenas.Columns(16).DefaultCellStyle.Format = "##,###.##"
        dgv_1_faenas.Columns(16).Width = 150
        dgv_1_faenas.Columns(17).Visible = False
        dgv_1_faenas.Columns(18).Visible = False
        dgv_1_faenas.Columns(19).Visible = False

        dgv_1_faenas.AllowUserToOrderColumns = True
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
    Private Sub dgv_1_faenas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_1_faenas.CellClick
        Try
            Cod_1 = dgv_1_faenas.CurrentRow.Cells(0).Value.ToString()
            txt_1_nom_faena.Text = dgv_1_faenas.CurrentRow.Cells(5).Value.ToString()
            txt_1_prof_residente.Text = dgv_1_faenas.CurrentRow.Cells(6).Value.ToString()
            txt_1_rut_prof.Text = dgv_1_faenas.CurrentRow.Cells(7).Value.ToString()
            txt_1_jefe.Text = dgv_1_faenas.CurrentRow.Cells(8).Value.ToString()
            cmb_1_gerente.Text = dgv_1_faenas.CurrentRow.Cells(9).Value.ToString()
            txt_1_mandante.Text = dgv_1_faenas.CurrentRow.Cells(10).Value.ToString()
            txt_1_resol.Text = dgv_1_faenas.CurrentRow.Cells(11).Value.ToString()
            dtp_1_res.Text = dgv_1_faenas.CurrentRow.Cells(12).Value.ToString()
            dtp_1_inicio.Text = dgv_1_faenas.CurrentRow.Cells(13).Value.ToString()
            txt_1_plazo.Text = dgv_1_faenas.CurrentRow.Cells(14).Value.ToString()
            txt_1_monto.Text = dgv_1_faenas.CurrentRow.Cells(16).Value.ToString()
            txt_1_det_obra.Text = dgv_1_faenas.CurrentRow.Cells(17).Value.ToString()
            txt_1_retenciones.Text = dgv_1_faenas.CurrentRow.Cells(18).Value.ToString()
            txt_1_proforma.Text = dgv_1_faenas.CurrentRow.Cells(19).Value.ToString()

            sincroniza_local = CInt(dgv_1_faenas.CurrentRow.Cells(1).Value.ToString())
            version_mod1 = CInt(dgv_1_faenas.CurrentRow.Cells(2).Value.ToString())
            sincroniza_mod1 = 2


            If IsNumeric(txt_1_monto.Text) Then
                txt_1_monto.Text = FormatNumber(txt_1_monto.Text, 0)
            Else
                txt_1_monto.Clear()
            End If

            If IsNumeric(txt_1_retenciones.Text) Then
                txt_1_retenciones.Text = FormatNumber(txt_1_retenciones.Text, 0)
            Else
                txt_1_retenciones.Clear()
            End If

            If IsNumeric(txt_1_proforma.Text) Then
                txt_1_proforma.Text = FormatNumber(txt_1_proforma.Text, 0)
            Else
                txt_1_proforma.Clear()
            End If

            Dim rut_ver As String
            rut_ver = Limpiar(txt_1_rut_prof.Text)
            If Len(rut_ver) < 8 Then
                txt_1_rut_prof.Mask = ""
            ElseIf Len(rut_ver) = 9 Then
                txt_1_rut_prof.Mask = "00,000,000->a"
            ElseIf Len(rut_ver) = 8 Then
                txt_1_rut_prof.Mask = "0,000,000->a"
            Else
                txt_1_rut_prof.Mask = ""
                txt_1_rut_prof.Clear()
            End If
        Catch

        End Try
    End Sub

    Sub actualizar_dgv2()
        dgv_2_cuentas.DataSource = nue_obra2.listar(id_obra)
        dgv_2_cuentas.Columns(0).Visible = False
        dgv_2_cuentas.Columns(1).Visible = False
        dgv_2_cuentas.Columns(2).Visible = False
        dgv_2_cuentas.Columns(3).Visible = False
        dgv_2_cuentas.Columns(4).Visible = False
        dgv_2_cuentas.Columns(5).HeaderText = "Cuenta"
        dgv_2_cuentas.Columns(5).Width = 150
        dgv_2_cuentas.Columns(6).HeaderText = "Descripción"
        dgv_2_cuentas.Columns(6).Width = 250

        dgv_2_cuentas.AllowUserToOrderColumns = True
    End Sub
    Sub actualizar_dgv3()
        dgv_3_uf.DataSource = nue_obra3.listar(id_obra)
        dgv_3_uf.Columns(0).Visible = False
        dgv_3_uf.Columns(1).Visible = False
        dgv_3_uf.Columns(2).Visible = False
        dgv_3_uf.Columns(3).Visible = False
        dgv_3_uf.Columns(4).Visible = False
        dgv_3_uf.Columns(5).HeaderText = "Fecha Actual"
        dgv_3_uf.Columns(5).Width = 150
        dgv_3_uf.Columns(6).HeaderText = "Valor UF"
        dgv_3_uf.Columns(6).DefaultCellStyle.Format = "##,###.##"
        dgv_3_uf.Columns(6).Width = 250

        dgv_3_uf.AllowUserToOrderColumns = True
    End Sub
    Private Sub dgv_2_cuentas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_2_cuentas.CellMouseClick
        Try
            Cod_2 = dgv_2_cuentas.CurrentRow.Cells(0).Value.ToString()
            txt_2_cuenta.Text = dgv_2_cuentas.CurrentRow.Cells(5).Value.ToString()
            txt_2_descripcion.Text = dgv_2_cuentas.CurrentRow.Cells(6).Value.ToString()
            sincroniza_local2 = CInt(dgv_2_cuentas.CurrentRow.Cells(1).Value.ToString())
            version_mod2 = CInt(dgv_2_cuentas.CurrentRow.Cells(2).Value.ToString())
            sincroniza_mod2 = 2

        Catch
        End Try
    End Sub
    Private Sub btn_sincronizar_Click(sender As Object, e As EventArgs) Handles btn_sincronizar.Click
        num_tab = 0
        frm_menu_principal.Show()
        Me.Close()
        frm_menu_principal.btn_sincronizar.PerformClick()
    End Sub
    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        num_tab = 1
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub txt_3_uf_TextChanged(sender As Object, e As EventArgs) Handles txt_3_uf.TextChanged
        If Not IsNumeric(txt_3_uf.Text) Then
            txt_3_uf.Clear()
        End If
    End Sub

    Private Sub dgv_3_uf_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_3_uf.MouseClick
        Try
            Cod_3 = dgv_3_uf.CurrentRow.Cells(0).Value.ToString()
            dtp_3_actual.Text = dgv_3_uf.CurrentRow.Cells(5).Value.ToString()
            txt_3_uf.Text = dgv_3_uf.CurrentRow.Cells(6).Value.ToString()
            sincroniza_local3 = CInt(dgv_3_uf.CurrentRow.Cells(1).Value.ToString())
            version_mod3 = CInt(dgv_3_uf.CurrentRow.Cells(2).Value.ToString())
            sincroniza_mod3 = 2
        Catch

        End Try
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

    Private Sub txt_1_monto_GotFocus(sender As Object, e As EventArgs) Handles txt_1_monto.GotFocus
        If IsNumeric(txt_1_monto.Text) Then
            txt_1_monto.Text = FormatNumber(txt_1_monto.Text, 0)
        Else
            txt_1_monto.Clear()
        End If
    End Sub

    Private Sub txt_1_monto_LostFocus(sender As Object, e As EventArgs) Handles txt_1_monto.LostFocus
        If IsNumeric(txt_1_monto.Text) Then
            txt_1_monto.Text = FormatNumber(txt_1_monto.Text, 0)
        Else
            txt_1_monto.Clear()
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

    Private Sub txt_1_rut_prof_LostFocus1(sender As Object, e As EventArgs) Handles txt_1_rut_prof.LostFocus
        Dim rut_ver As String
        rut_ver = Limpiar(txt_1_rut_prof.Text)
        If Len(rut_ver) < 8 Then
            txt_1_rut_prof.Mask = ""
        ElseIf Len(rut_ver) = 9 Then
            txt_1_rut_prof.Mask = "00,000,000->a"
        ElseIf Len(rut_ver) = 8 Then
            txt_1_rut_prof.Mask = "0,000,000->a"
        Else
            txt_1_rut_prof.Mask = ""
            txt_1_rut_prof.Clear()
        End If
    End Sub

    Private Sub txt_1_rut_prof_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_1_rut_prof.MaskInputRejected

    End Sub

    Private Sub txt_1_rut_prof_TextChanged(sender As Object, e As EventArgs) Handles txt_1_rut_prof.TextChanged
        Dim rut_ver As String
        rut_ver = Limpiar(txt_1_rut_prof.Text)
        If Len(rut_ver) < 8 Then
            txt_1_rut_prof.Mask = ""
        End If
    End Sub


    Private Sub TabPage10_Enter(sender As Object, e As EventArgs) Handles TabPage10.Enter
        num_tab = 1
        frm_menu_principal_X.Show()
        Me.Close()
    End Sub

    Private Sub txt_1_retenciones_GotFocus(sender As Object, e As EventArgs) Handles txt_1_retenciones.GotFocus
        If IsNumeric(txt_1_retenciones.Text) Then
            txt_1_retenciones.Text = FormatNumber(txt_1_retenciones.Text, 0)
        Else
            txt_1_retenciones.Clear()
        End If
    End Sub

    Private Sub txt_1_retenciones_LostFocus(sender As Object, e As EventArgs) Handles txt_1_retenciones.LostFocus
        If IsNumeric(txt_1_retenciones.Text) Then
            txt_1_retenciones.Text = FormatNumber(txt_1_retenciones.Text, 0)
        Else
            txt_1_retenciones.Clear()
        End If
    End Sub

    Private Sub txt_1_proforma_GotFocus(sender As Object, e As EventArgs) Handles txt_1_proforma.GotFocus
        If IsNumeric(txt_1_proforma.Text) Then
            txt_1_proforma.Text = FormatNumber(txt_1_proforma.Text, 0)
        Else
            txt_1_proforma.Clear()
        End If
    End Sub

    Private Sub txt_1_proforma_LostFocus(sender As Object, e As EventArgs) Handles txt_1_proforma.LostFocus
        If IsNumeric(txt_1_proforma.Text) Then
            txt_1_proforma.Text = FormatNumber(txt_1_proforma.Text, 0)
        Else
            txt_1_proforma.Clear()
        End If
    End Sub

End Class