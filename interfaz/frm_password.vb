Imports System.Security.Cryptography
Public Class frm_password

    Dim nue_usua As New clases.usuario
    Dim nue_conex As New clases.conexion
    Public usuario As String = ""
    Public cod_usua As Integer = 0
    Dim PasConMd5 As String
    Dim password As String
    Dim version_mod As Integer

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim sincroniza_usuario As Integer
        If txt_password.Text <> "" And txt_username.Text <> "" Then
            dgv_password.DataSource = nue_usua.listar_usuario(txt_username.Text, txt_password.Text)
            If dgv_password.Rows.Count > 1 Then
                If txt_password_nuevo.Text = txt_password_nuevo2.Text Then

                    Dim contrasena As String = MD5EncryptPass(txt_password_nuevo.Text)
                    If sincroniza = 0 Then
                        version_mod = CInt(dgv_password.Rows(0).Cells(2).Value.ToString())
                        version_mod = version_mod + 1
                        sincroniza_usuario = 2
                    ElseIf sincroniza = 1 Then
                        version_mod = 0
                        sincroniza_usuario = 0
                    End If
                    nue_usua.modificar_contrasena(sincroniza_usuario, version_mod, txt_username.Text, contrasena)

                    MsgBox("CONTRASEÑA MODIFICADA CORRECTAMENTE")
                    Me.Close()
                Else
                    MsgBox("LAS CONTRASEÑA NUEVA INGRESADA EN EL PRIMER CAMPO NO COINCIDE CON LA INGRESADA EN EL SEGUNDO CAMPO")
                End If
            Else
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS")
            End If
        Else
            MessageBox.Show("ESCRIBA SU NOMBRE DE USUARIO Y SU CONTRASEÑA")
        End If
    End Sub
    Function MD5EncryptPass(ByVal StrPass As String)

        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strPassOutput As String
        Dim i As Integer
        strPassOutput = ""

        md5 = New MD5CryptoServiceProvider

        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            strPassOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        PasConMD5 = strPassOutput

        Return PasConMd5
    End Function

    Private Sub txt_password_LostFocus(sender As Object, e As EventArgs) Handles txt_password.LostFocus
        txt_password.Text = UCase(txt_password.Text)
    End Sub
    Private Sub txt_password_nuevo_LostFocus(sender As Object, e As EventArgs) Handles txt_password_nuevo.LostFocus
        txt_password_nuevo.Text = UCase(txt_password_nuevo.Text)
    End Sub

    Private Sub txt_password_nuevo2_LostFocus(sender As Object, e As EventArgs) Handles txt_password_nuevo2.LostFocus
        txt_password_nuevo2.Text = UCase(txt_password_nuevo2.Text)
    End Sub

    Private Sub txt_username_LostFocus(sender As Object, e As EventArgs) Handles txt_username.LostFocus
        txt_username.Text = UCase(txt_username.Text)
    End Sub
End Class