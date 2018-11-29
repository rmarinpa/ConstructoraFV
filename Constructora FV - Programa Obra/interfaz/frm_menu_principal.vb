Public Class frm_menu_principal
    Dim nue_report As New clases.Autoriza
    Dim nue_sincroniza As New clases.Sincroniza_cl
    Dim nue_sincroniza2 As New clases.Sincroniza2
    Dim nue_sincroniza3 As New clases.Sincroniza31
    Dim nue_sincroniza4 As New clases.Sincroniza4
    Dim nue_sincroniza5 As New clases.Sincroniza5
    Dim nue_sincroniza6 As New clases.Sincroniza6
    Dim nue_sincroniza7 As New clases.Sincroniza7
    Dim nue_sincroniza8 As New clases.Sincroniza8
    Dim nue_sincroniza9 As New clases.Sincroniza9
    Dim nue_sincroniza10 As New clases.Sincroniza10
    Dim nue_sincroniza11 As New clases.Sincroniza11
    Dim nue_sincroniza12 As New clases.Sincroniza12
    Dim nue_sincroniza20 As New clases.Sincroniza20
    Dim nue_var As New clases.variables
    Dim nue_obra1 As New clases.Identificacion_obra
    Dim actualiza As Integer
    Dim id_actualiza As Integer

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        modifica_local = 1
        chk_registros.Checked = True
        chk_fecha.Checked = False
        num_tab = 0
        lbl_nombre_obra.Text = Nombre_Obra
        lbl_usuario.Text = Nombre_Usuario
        Me.WindowState = FormWindowState.Maximized
        If num_tab = 0 Then
            TabControl11.SelectedTab = TabPage1
        End If
        actualizar_dgv()
        If sincroniza = 0 Then
            btn_sincronizar.Visible = False
            pb_list.Visible = False
            lbl_sincroniza.Text = "Trabajando con Internet"
            GroupBox1.Visible = False
        ElseIf sincroniza = 1 Then
            btn_sincronizar.Visible = True
            pb_list.Visible = True
            lbl_sincroniza.Text = "Trabajando sin Internet"
            GroupBox1.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num_tab = 1
        frm_menu_principal_II.Show()
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        num_tab = 1
        frm_menu_principal_II.Show()
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        num_tab = 2
        frm_menu_principal_II.Show()
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        num_tab = 3
        frm_menu_principal_II.Show()
        Me.Close()
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles btn_menu_inicial.Click
        TabControl11.SelectedTab = TabPage1
    End Sub
    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        num_tab = 1
        frm_menu_principal_II.Show()
        Me.Close()
    End Sub


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        frm_login.Show()
        Me.Close()
    End Sub
    Sub actualizar_dgv()
        dgv_autoriza.DataSource = nue_report.listar(Nombre_Usuario, id_obra)
        autoriza_1 = CInt(dgv_autoriza.Rows(0).Cells(8).Value.ToString())
        autoriza_2 = CInt(dgv_autoriza.Rows(0).Cells(9).Value.ToString())
        autoriza_3 = CInt(dgv_autoriza.Rows(0).Cells(10).Value.ToString())
    End Sub

    Private Sub btn_sincronizar_Click(sender As Object, e As EventArgs) Handles btn_sincronizar.Click
        'Try
        If chk_fecha.Checked = False Then
            fecha_sincroniza = "2010/01/01"
        ElseIf chk_fecha.Checked = True Then
            fecha_sincroniza = Me.dtp_fecha.Value.ToShortDateString
            fecha_sincroniza = Format(CDate(fecha_sincroniza), "yyyy/MM/dd")
        End If
        pb_list.Maximum = 12
        pb_list.Value = 1
        sincroniza_1() 'Sección 1 Identificación de la Obra
        pb_list.Value = 2
        sincroniza_2() 'Sección 2 Plan de Cuentas
        pb_list.Value = 3
        sincroniza_3() 'Sección 3 Arrendador
        pb_list.Value = 4
        sincroniza_4() 'Sección 4 Equipos
        pb_list.Value = 5
        If chk_registros.Checked = True Then
            sincroniza_5() 'Sección 5 Reports Mov. Tierra
            pb_list.Value = 6
            sincroniza_6() 'Sección 6 Descuentos y Trabajos adicionales
            pb_list.Value = 7
            sincroniza_7() 'Sección 7 Petroleo
            pb_list.Value = 8
            sincroniza_8() 'Sección 8 Compra de Petróleo
            pb_list.Value = 9
            sincroniza_9() 'Sección 9 Storage
            pb_list.Value = 10
            sincroniza_10() 'Sección 10 Valor UF
        End If
        pb_list.Value = 11
        'sincroniza_20() 'Sección Configuración Viajes
        pb_list.Value = 12

        MsgBox("SINCRONIZACIÓN REALIZADA SATISFACTORIAMENTE")
        pb_list.Value = 0
        'Catch
        '    pb_list.Value = 0
        '    MsgBox("ERROR CON LA CONEXIÓN A INTERNET")
        'End Try
    End Sub
    Sub sincroniza_1()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza.listar(id_obra)
        seccion = 1
        'Sección 1 Identificación de la Obra
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(15).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(16).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(17).Value.ToString())
                    nue_sincroniza.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)

                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 And modifica_local = 1 Then
                    If nue_sincroniza.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(15).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(16).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(17).Value.ToString())
                            nue_sincroniza.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())

                        End If
                    End If
                    End If
            Next i
        End If

        dgv1_sincroniza_remoto.DataSource = nue_sincroniza.listar_remoto(id_obra)
        dgv_temporal.DataSource = nue_sincroniza.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.   
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(15).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(16).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(17).Value.ToString())
                    nue_sincroniza.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    'nue_sincroniza.modificar_remoto(CInt(dgv1_sincroniza_remoto.Rows(i).Cells(0).Value.ToString()), 0)
                ElseIf actualiza = 2 Then
                    nue_sincroniza.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(15).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(16).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(17).Value.ToString())
                    nue_sincroniza.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Sub sincroniza_2()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza2.listar(id_obra)
        seccion = 2
        'Sección 2 Plan de Cuentas
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza2.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString())
                    nue_sincroniza2.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza2.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)

                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 And modifica_local = 1 Then
                    If nue_sincroniza2.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza2.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza2.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza2.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza2.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString())
                            nue_sincroniza2.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())
                        End If
                    End If
                    End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza2.listar_remoto(id_obra)
        dgv_temporal.DataSource = nue_sincroniza2.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())

                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.     
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza2.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString())
                    nue_sincroniza2.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza2.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString())
                    nue_sincroniza2.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza2.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza2.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub
    Sub sincroniza_3()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza3.listar(id_obra)
        seccion = 3
        'Sección 3 Arrendador
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza3.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString())
                    nue_sincroniza3.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza3.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 Then
                    If nue_sincroniza3.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza3.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza3.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza3.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza3.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString())
                            nue_sincroniza3.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())
                        End If
                    End If
                    End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza3.listar_remoto(id_obra)
        dgv_temporal.DataSource = nue_sincroniza3.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.     
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza3.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString())
                    nue_sincroniza3.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza3.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString())
                    nue_sincroniza3.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza3.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza3.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Sub sincroniza_4()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza4.listar(id_obra)
        seccion = 4
        'Sección 4 Equipos
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza4.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(15).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(16).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(17).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(18).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(19).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(20).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(21).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(22).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(23).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(24).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(25).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(26).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(27).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(28).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(29).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(30).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(31).Value.ToString())
                    nue_sincroniza4.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza4.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)

                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 Then
                    If nue_sincroniza4.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza4.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza4.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza4.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza4.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(15).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(16).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(17).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(18).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(19).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(20).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(21).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(22).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(23).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(24).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(25).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(26).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(27).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(28).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(29).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(30).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(31).Value.ToString())
                            nue_sincroniza4.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())
                        End If
                    End If
                    End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza4.listar_remoto(id_obra)
        dgv_temporal.DataSource = nue_sincroniza4.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.    
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza4.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(15).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(16).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(17).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(18).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(19).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(20).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(21).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(22).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(23).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(24).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(25).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(26).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(27).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(28).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(29).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(30).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(31).Value.ToString())
                    nue_sincroniza4.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza4.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(15).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(16).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(17).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(18).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(19).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(20).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(21).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(22).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(23).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(24).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(25).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(26).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(27).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(28).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(29).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(30).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(31).Value.ToString())
                    nue_sincroniza4.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza4.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza4.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub
    Sub sincroniza_5()
        Dim Id_primario As Integer
        Dim viajes As Double
        Dim viajes1 As Double
        Dim viajes2 As Double
        Dim viajes3 As Double
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza5.listar(id_obra, fecha_sincroniza)
        seccion = 5
        'Sección 5 Reports Mov. Tierra
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    'If IsNothing(dgv_sincroniza1.Rows(i).Cells(33).Value.ToString()) Then
                    '    viajes1 = CDbl(dgv_sincroniza1.Rows(i).Cells(33).Value.ToString())
                    'Else
                    '    viajes1 = 0
                    'End If
                    nue_sincroniza5.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(15).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(16).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(17).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(20).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(35).Value.ToString())
                    nue_sincroniza5.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza5.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)

                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 Then
                    If nue_sincroniza5.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza5.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza5.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza5.verificar_version2(Id_primario, id_obra) Then
                        Else
                            'If CDbl(dgv_sincroniza1.Rows(i).Cells(33).Value.ToString) > 0 Then
                            '    viajes = CDbl(dgv_sincroniza1.Rows(i).Cells(33).Value.ToString)
                            'Else
                            '    viajes = 0
                            'End If
                            nue_sincroniza5.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(15).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(16).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(17).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(20).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(35).Value.ToString())
                            nue_sincroniza5.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())
                        End If
                    End If
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza5.listar_remoto(id_obra, fecha_sincroniza)
        dgv_temporal.DataSource = nue_sincroniza5.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.     
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    'If IsNumeric(CDbl(dgv1_sincroniza_remoto.Rows(z).Cells(33).Value.ToString())) Then
                    '    viajes2 = CDbl(dgv1_sincroniza_remoto.Rows(z).Cells(33).Value.ToString())
                    'Else
                    '    viajes2 = 0
                    'End If
                    nue_sincroniza5.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(15).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(16).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(17).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(20).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(35).Value.ToString())
                    nue_sincroniza5.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    'If IsNumeric(CDbl(dgv1_sincroniza_remoto.Rows(z).Cells(33).Value.ToString())) Then
                    '    viajes3 = CDbl(dgv1_sincroniza_remoto.Rows(z).Cells(33).Value.ToString())
                    'Else
                    '    viajes3 = 0
                    'End If
                    nue_sincroniza5.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(15).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(16).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(17).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(20).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(35).Value.ToString())
                    nue_sincroniza5.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza5.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza5.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Sub sincroniza_6()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza6.listar(id_obra, fecha_sincroniza)
        seccion = 6
        'Sección 6 Descuentos y Trabajos adicionales
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza6.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString())
                    nue_sincroniza6.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza6.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 Then
                    If nue_sincroniza6.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza6.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza6.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza6.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza6.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString())
                            nue_sincroniza6.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())
                        End If
                    End If
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza6.listar_remoto(id_obra, fecha_sincroniza)
        dgv_temporal.DataSource = nue_sincroniza6.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.      
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza6.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString())
                    nue_sincroniza6.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza6.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString())
                    nue_sincroniza6.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza6.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza6.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Sub sincroniza_7()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza7.listar(id_obra, fecha_sincroniza)
        seccion = 7
        'Sección 7 Petroleo
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza7.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString())
                    nue_sincroniza7.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza7.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 Then
                    If nue_sincroniza7.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza7.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza7.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza7.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza7.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString())
                            nue_sincroniza7.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())
                        End If
                    End If
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza7.listar_remoto(id_obra, fecha_sincroniza)
        dgv_temporal.DataSource = nue_sincroniza7.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.    
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza7.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString())
                    nue_sincroniza7.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza7.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString())
                    nue_sincroniza7.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza7.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza7.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub
    Sub sincroniza_8()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza8.listar(id_obra, fecha_sincroniza)
        seccion = 8
        'Sección 8 Compra de Petróleo
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza8.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(15).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(16).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(17).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(18).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(19).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(20).Value.ToString())
                    nue_sincroniza8.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza8.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)

                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 Then
                    If nue_sincroniza8.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza8.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza8.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza8.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza8.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(12).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(13).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(14).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(15).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(16).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(17).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(18).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(19).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(20).Value.ToString())
                            nue_sincroniza8.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())
                        End If
                    End If
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza8.listar_remoto(id_obra, fecha_sincroniza)
        dgv_temporal.DataSource = nue_sincroniza8.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.   
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza8.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(15).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(16).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(17).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(18).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(19).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(20).Value.ToString())
                    nue_sincroniza8.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza8.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(12).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(13).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(14).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(15).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(16).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(17).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(18).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(19).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(20).Value.ToString())
                    nue_sincroniza8.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza8.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza8.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Sub sincroniza_9()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza9.listar(id_obra, fecha_sincroniza)
        seccion = 9
        'Sección 9 Storage
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza9.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString())
                    nue_sincroniza9.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza9.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 Then
                    If nue_sincroniza9.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza9.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza9.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza9.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza9.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString())
                            nue_sincroniza9.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())
                        End If
                    End If
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza9.listar_remoto(id_obra, fecha_sincroniza)
        dgv_temporal.DataSource = nue_sincroniza9.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.    
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza9.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString())
                    nue_sincroniza9.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza9.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString())
                    nue_sincroniza9.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza9.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza9.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub
    Sub sincroniza_10()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza10.listar(id_obra, fecha_sincroniza)
        seccion = 10
        'Sección 10 Valor UF
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza10.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString())
                    nue_sincroniza10.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza10.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 Then
                    If nue_sincroniza10.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza10.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza10.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza10.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza10.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString())
                            nue_sincroniza10.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())
                        End If
                    End If
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza10.listar_remoto(id_obra, fecha_sincroniza)
        dgv_temporal.DataSource = nue_sincroniza10.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If

                'Agregar y modificar los registros desde Remoto a Local.     
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza10.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString())
                    nue_sincroniza10.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza10.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString())
                    nue_sincroniza10.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza10.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza10.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub
    Sub sincroniza_20()
        Dim Id_primario As Integer
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza20.listar(id_obra)
        seccion = 20
        'Sección 20 Viajes
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza20.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString())
                    nue_sincroniza20.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza20.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)

                ElseIf CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 2 Or CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 3 And modifica_local = 1 Then
                    If nue_sincroniza20.verificar_version(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString()) = 1 Then
                        Id_primario = nue_sincroniza20.consultar_id(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString())

                        If nue_sincroniza20.verificar_version3(seccion, id_obra, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()) < nue_sincroniza20.verificar_version2(Id_primario, id_obra) Then
                        Else
                            nue_sincroniza20.modificar_remoto2(Id_primario, dgv_sincroniza1.Rows(i).Cells(1).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(2).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString())
                            nue_sincroniza20.modificar_temporal(seccion, Id_primario, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, dgv_sincroniza1.Rows(i).Cells(2).Value.ToString())

                        End If
                    End If
                End If
            Next i
        End If

        dgv1_sincroniza_remoto.DataSource = nue_sincroniza20.listar_remoto(id_obra)
        dgv_temporal.DataSource = nue_sincroniza20.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If
                'Agregar y modificar los registros desde Remoto a Local.   
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza20.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString())
                    nue_sincroniza20.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    'nue_sincroniza20.modificar_remoto(CInt(dgv1_sincroniza_remoto.Rows(i).Cells(0).Value.ToString()), 0)
                ElseIf actualiza = 2 Then
                    nue_sincroniza20.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString())
                    nue_sincroniza20.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza20.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza20.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Sub sincroniza_11()
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza11.listar(id_obra)
        seccion = 11
        'Sección 11 Subcontratista
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza11.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString())
                    nue_sincroniza11.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza11.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                Else
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza11.listar_remoto(id_obra)
        dgv_temporal.DataSource = nue_sincroniza11.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If

                'Agregar y modificar los registros desde Remoto a Local.     
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza11.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString())
                    nue_sincroniza11.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza11.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza11.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Sub sincroniza_12()
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza12.listar(id_obra)
        seccion = 12
        'Sección 12 Subcontrato
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza12.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(11).Value.ToString())
                    nue_sincroniza12.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), id_obra, 0)
                    nue_sincroniza12.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                Else
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza12.listar_remoto(id_obra)
        dgv_temporal.DataSource = nue_sincroniza12.listar_temporal(seccion, id_obra)

        'Modifico y elimino datos desde Remoto a Local.   
        If dgv1_sincroniza_remoto.Rows.Count > 1 Then
            For z = 0 To dgv1_sincroniza_remoto.Rows.Count - 2
                actualiza = 0
                id_actualiza = 0
                If dgv_temporal.Rows.Count > 1 Then
                    For j = 0 To dgv_temporal.Rows.Count - 2

                        If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) > CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            If CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 2 Then
                                actualiza = 2
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) = 3 Then
                                actualiza = 3
                                id_actualiza = CInt(dgv_temporal.Rows(j).Cells(3).Value.ToString())
                            End If
                        ElseIf CInt(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString()) = CInt(dgv_temporal.Rows(j).Cells(2).Value.ToString()) And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString()) <= CInt(dgv_temporal.Rows(j).Cells(5).Value.ToString()) Then
                            actualiza = 4
                        End If
                    Next j
                End If

                'Agregar y modificar los registros desde Remoto a Local.   
                If actualiza <> 2 And actualiza <> 3 And actualiza <> 4 And CInt(dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString()) <> 3 Then
                    nue_sincroniza12.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString())
                    nue_sincroniza12.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza12.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(11).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza12.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
        num_tab = 1
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num_tab = 1
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        num_tab = 1
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        num_tab = 2
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        num_tab = 3
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        num_tab = 4
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        num_tab = 5
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        num_tab = 6
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        num_tab = 7
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        num_tab = 8
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        num_tab = 9
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num_tab = 1
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        num_tab = 1
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        num_tab = 2
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        num_tab = 3
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        num_tab = 4
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        num_tab = 5
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        num_tab = 6
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        num_tab = 7
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        num_tab = 8
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        num_tab = 9
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter
        num_tab = 1
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num_tab = 1
        frm_menu_principal_V.Show()
        Me.Close()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        num_tab = 1
        frm_menu_principal_V.Show()
        Me.Close()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        num_tab = 2
        frm_menu_principal_V.Show()
        Me.Close()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        num_tab = 3
        frm_menu_principal_V.Show()
        Me.Close()
    End Sub

    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
        num_tab = 1
        frm_menu_principal_V.Show()
        Me.Close()
    End Sub

    Private Sub TabPage6_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter, TabPage6.Enter
        num_tab = 1
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub
    Private Sub TabPage7_Enter(sender As Object, e As EventArgs) Handles TabPage6.Enter, TabPage7.Enter
        num_tab = 1
        frm_menu_principal_VII.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num_tab = 1
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub

    Private Sub Button62_Click_1(sender As Object, e As EventArgs) Handles Button62.Click
        num_tab = 4
        frm_menu_principal_V.Show()
        Me.Close()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs)
        num_tab = 1
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs)
        num_tab = 2
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs)
        num_tab = 3
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub

    Private Sub Button36_Click_1(sender As Object, e As EventArgs) Handles Button36.Click
        num_tab = 1
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub

    Private Sub Button35_Click_1(sender As Object, e As EventArgs) Handles Button35.Click
        num_tab = 2
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub

    Private Sub Button34_Click_1(sender As Object, e As EventArgs) Handles Button34.Click
        num_tab = 3
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        num_tab = 1
        frm_menu_principal_VII.Show()
        Me.Close()
    End Sub
    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        num_tab = 1
        frm_menu_principal_VII.Show()
        Me.Close()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        num_tab = 2
        frm_menu_principal_VII.Show()
        Me.Close()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        num_tab = 3
        frm_menu_principal_VII.Show()
        Me.Close()
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Informe_EstadoPagoMandante.Show()
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        CR_ListadoContratoModificaciones.Show()
    End Sub
End Class