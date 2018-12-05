Imports System.Security.Cryptography
Public Class frm_login

    Dim nue_usua As New clases.usuario
    Dim nue_conex As New clases.conexion
    Public usuario As String = ""
    Public cod_usua As Integer = 0
    Dim PasConMd5 As String
    Dim password As String
    Dim actualiza As Integer
    Dim id_actualiza As Integer
    Dim nue_sincroniza13 As New clases.Sincroniza13
    Dim nue_sincroniza14 As New clases.Sincroniza14
    Dim nue_sincroniza15 As New clases.Sincroniza15

    Public Sub insertar(ByVal conexion As Integer)
        sincroniza = conexion
    End Sub
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub
    Public Sub actualizar_obras()
        cmb_obra.DataSource = nue_usua.listar2(txt_username.Text)
        cmb_obra.DisplayMember = "nombre_obra"
        cmb_obra.ValueMember = "id_obra"

    End Sub
    Public Sub btn_entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_entrar.Click
        If txt_password.Text <> "" And txt_username.Text <> "" Then
            If nue_usua.verificar(txt_username.Text, txt_password.Text, cmb_obra.Text) = True Then
                usuario = txt_username.Text
                cod_usua = nue_usua.cod_usuario(txt_username.Text, password)
                If cmb_obra.Text = "Maquinaria" Then
                    Nombre_Obra = "Maquinaria"
                    id_obra = CInt(cmb_obra.SelectedValue.ToString())
                    Nombre_Usuario = usuario
                    Frm_maquinaria.Enabled = True
                    Frm_maquinaria.Show()
                ElseIf cmb_obra.Text = "Administración" Then
                    Nombre_Obra = ""
                    Nombre_Obra = cmb_obra.Text
                    id_obra = CInt(cmb_obra.SelectedValue.ToString())
                    Nombre_Usuario = usuario
                    'frm_menu_principal_adm.Enabled = True
                    'frm_menu_principal_adm.Show()
                Else
                    Nombre_Obra = ""
                    Nombre_Obra = cmb_obra.Text
                    id_obra = CInt(cmb_obra.SelectedValue.ToString())
                    Nombre_Usuario = usuario
                    frm_menu_principal.Enabled = True
                    frm_menu_principal.Show()
                End If
                'MsgBox(id_obra)
                Me.Hide()

            Else
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS")
            End If
        Else
            MessageBox.Show("ESCRIBA SU NOMBRE DE USUARIO Y SU CONTRASEÑA")
        End If
    End Sub

    Private Sub txt_username_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.LostFocus
        txt_username.Text = UCase(txt_username.Text)
        If txt_username.Text <> "" And cmb_conexion.Text <> " " Then
            actualizar_obras()
        Else
        End If
    End Sub
    Private Sub txt_password_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_password.LostFocus
        txt_password.Text = UCase(txt_password.Text)
    End Sub
    Private Sub frm_login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmb_conexion.Text = " "
        btn_password.Visible = False
        pb_list.Visible = False
        btn_sincronizar.Visible = False
    End Sub
    Private Sub cmb_conexion_TextChanged(sender As Object, e As EventArgs) Handles cmb_conexion.TextChanged
        If cmb_conexion.Text = "Trabajar sin Internet" Then
            nue_conex.insertar(1)
            sincroniza = 1
            pb_list.Visible = True
            btn_sincronizar.Visible = True
        ElseIf cmb_conexion.Text = "Trabajar con Internet" Then
            nue_conex.insertar(0)
            sincroniza = 0
            pb_list.Visible = False
            btn_sincronizar.Visible = False
        End If

        If cmb_conexion.Text <> "" Then
            btn_password.Visible = True
        Else
            btn_password.Visible = False
        End If
    End Sub
    Private Sub cmb_obra_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_obra.MouseClick
        If txt_username.Text <> "" And cmb_conexion.Text <> " " Then
            actualizar_obras()
        Else
            MsgBox("NECESITA INGRESAR UN USUARIO VALIDO")
        End If
    End Sub


    'Funcion de encriptado
    Function MD5EncryptPass(ByVal StrPass As String)
        PasConMd5 = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer

        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            PasConMd5 &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next
        Return PasConMd5
    End Function


    Private Sub btn_password_Click(sender As Object, e As EventArgs) Handles btn_password.Click
        frm_password.Show()
    End Sub
    Private Sub btn_sincronizar_Click(sender As Object, e As EventArgs) Handles btn_sincronizar.Click
        Try
            pb_list.Maximum = 4
            pb_list.Value = 1
            sincroniza_13()
            pb_list.Value = 2
            sincroniza_14()
            pb_list.Value = 3
            'sincroniza_15()
            pb_list.Value = 4
            MsgBox("SINCRONIZACIÓN REALIZADA SATISFACTORIAMENTE")
            pb_list.Value = 0
        Catch
            pb_list.Value = 0
            MsgBox("ERROR CON LA CONEXIÓN A INTERNET")
        End Try
    End Sub
    Sub sincroniza_13()
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza13.listar()
        seccion = 13
        'Sección 13 Obras
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza13.insertar(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), 1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString())
                    nue_sincroniza13.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), 0, 0)
                    nue_sincroniza13.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                Else
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza13.listar_remoto()
        dgv_temporal.DataSource = nue_sincroniza13.listar_temporal(seccion)

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
                    nue_sincroniza13.insertar_remoto(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), 0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString())
                    nue_sincroniza13.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), 0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza13.modificar_tabla(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), id_actualiza)
                    nue_sincroniza13.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza13.modificar_eliminar(dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), id_actualiza)
                    nue_sincroniza13.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Sub sincroniza_14()
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza14.listar()
        seccion = 14
        'Sección 14 Usuarios  
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza14.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(7).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(8).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(9).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(10).Value.ToString())
                    nue_sincroniza14.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), 0)
                    nue_sincroniza14.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                Else
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza14.listar_remoto()
        dgv_temporal.DataSource = nue_sincroniza14.listar_temporal(seccion)

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
                    nue_sincroniza14.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString())
                    nue_sincroniza14.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza14.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(7).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(8).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(9).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(10).Value.ToString())
                    nue_sincroniza14.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza14.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                    nue_sincroniza14.modificar_temporal2(seccion, id_actualiza, id_obra, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub
    Sub sincroniza_15()
        dgv_sincroniza1.DataSource = Nothing
        dgv1_sincroniza_remoto.DataSource = Nothing
        dgv_modifica.DataSource = Nothing
        dgv_temporal.DataSource = Nothing

        dgv_sincroniza1.DataSource = nue_sincroniza15.listar(0)
        seccion = 15
        'Sección 15 Turno
        'Agrego datos desde Local a Remoto. 
        If dgv_sincroniza1.Rows.Count > 1 Then
            For i = 0 To dgv_sincroniza1.Rows.Count - 2
                If CInt(dgv_sincroniza1.Rows(i).Cells(1).Value.ToString()) = 1 Then
                    nue_sincroniza15.insertar(1, 0, dgv_sincroniza1.Rows(i).Cells(3).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(4).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(5).Value.ToString(), dgv_sincroniza1.Rows(i).Cells(6).Value.ToString())
                    nue_sincroniza15.insertar_temporal(seccion, dgv_sincroniza1.Rows(i).Cells(0).Value.ToString(), 0, 0)
                    nue_sincroniza15.modificar(CInt(dgv_sincroniza1.Rows(i).Cells(0).Value.ToString()), 0)
                Else
                End If
            Next i
        End If
        dgv1_sincroniza_remoto.DataSource = nue_sincroniza15.listar_remoto(0)
        dgv_temporal.DataSource = nue_sincroniza15.listar_temporal(seccion, 0)

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
                    nue_sincroniza15.insertar_remoto(0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString())
                    nue_sincroniza15.insertar_temporal_remoto(seccion, dgv1_sincroniza_remoto.Rows(z).Cells(0).Value.ToString(), 0, dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                ElseIf actualiza = 2 Then
                    nue_sincroniza15.modificar_tabla(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(3).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(4).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(5).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(6).Value.ToString())
                ElseIf actualiza = 3 Then
                    nue_sincroniza15.modificar_eliminar(id_actualiza, dgv1_sincroniza_remoto.Rows(z).Cells(1).Value.ToString(), dgv1_sincroniza_remoto.Rows(z).Cells(2).Value.ToString())
                End If
            Next z
        End If
    End Sub

    Private Sub txt_password_Click(sender As Object, e As EventArgs) Handles txt_password.Click

    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub cmb_conexion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_conexion.SelectedIndexChanged

    End Sub

    Private Sub cmb_obra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_obra.SelectedIndexChanged

    End Sub
End Class