﻿Imports Microsoft.Office.Interop.Word 'Control de office
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports System.Net
Imports clases

Public Class frm_menu_principal_IX
    Dim nue_obra2 As New clases.Registro_petroleo
    Dim nue_obra3 As New clases.Compras_petroleo
    Dim nue_obra7 As New clases.Storage
    Dim nue_obra5 As New clases.Ingreso_contratos
    Dim nue_obra6 As New clases.EstadoPagoMandante
    Dim modificaciones As New clases.listadoModificaciones
    Dim modificacionesIngresos As New clases.Modificaciones
    Dim Contrato As New clases.Contratos_Originales
    Dim nue_var As New clases.variables
    Dim Cod_1 As String = ""
    Dim Cod_2 As String = ""
    Dim Cod_3 As String = ""
    Dim Cod_5 As String = ""
    Dim Cod_7 As String = ""
    Dim sw1 As Integer
    Dim sw2 As Integer
    Dim sw3 As Integer
    Dim sw7 As Integer
    Dim sincroniza_local As Integer
    Dim sincroniza_local2 As Integer
    Dim sincroniza_local3 As Integer
    Dim sincroniza_local7 As Integer
    Dim sincroniza_mod1 As Integer
    Dim sincroniza_mod2 As Integer
    Dim sincroniza_mod3 As Integer
    Dim sincroniza_mod7 As Integer
    Dim version_mod1 As Integer
    Dim version_mod2 As Integer
    Dim version_mod3 As Integer
    Dim version_mod5 As Integer
    Dim version_mod7 As Integer
    Dim existe_rut As Integer
    Dim nombre1 As String
    Dim contador As Integer
    Dim consulta_datos_local As Integer
    Dim codigo_libre As Integer
    Dim suma_litros As Double
    Dim TipoBoton As Integer

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rtn As New Date
        lbl_nombre_obra.Text = Nombre_Obra
        lbl_usuario.Text = Nombre_Usuario
        Me.WindowState = FormWindowState.Maximized
        consulta_datos = 0
        consulta_datos_local = 0
        codigo_libre = 0
        Timer1.Enabled = True
        autoriza_2_1 = 1
        autoriza_2_2 = 1
        autoriza_2_3 = 1
        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 24).AddMonths(-2)


        If sincroniza = 0 Then
            btn_sincronizar.Visible = False
            pb_list.Visible = False
            lbl_sincroniza.Text = "Trabajando con Internet"

            'btn_editar3.Visible = True
            'btn_eliminar3.Visible = True

            'btn_editar7.Visible = True
            'btn_eliminar7.Visible = True

        ElseIf sincroniza = 1 Then
            btn_sincronizar.Visible = True
            pb_list.Visible = True
            lbl_sincroniza.Text = "Trabajando sin Internet"

            'btn_editar3.Visible = False
            'btn_eliminar3.Visible = False

            'btn_editar7.Visible = False
            'btn_eliminar7.Visible = False
        End If

        If num_tab = 1 Then
            TabControl11.SelectedTab = TabPage9
            TabControl6.SelectedIndex = 0
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 2 Then
            TabControl11.SelectedTab = TabPage9
            TabControl6.SelectedIndex = 1
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 3 Then
            TabControl11.SelectedTab = TabPage9
            TabControl6.SelectedIndex = 2
            Me.TabPage52.Parent = Nothing
        End If
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btn_sincronizar_Click(sender As Object, e As EventArgs) Handles btn_sincronizar.Click
        num_tab = 0
        frm_menu_principal.Show()
        Me.Close()
        frm_menu_principal.btn_sincronizar.PerformClick()
    End Sub
    Private Sub TabPage10_Enter(sender As Object, e As EventArgs) Handles TabPage10.Enter
        num_tab = 1
        frm_menu_principal_X.Show()
        Me.Close()
    End Sub
    Private Sub TabPage6_Enter(sender As Object, e As EventArgs) Handles TabPage6.Enter
        num_tab = 1
        frm_menu_principal_VI.Show()
        Me.Close()
    End Sub
    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
        num_tab = 1
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter
        num_tab = 1
        frm_menu_principal_IV_V2.Show()
        Me.Close()
    End Sub
    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter
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

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        num_tab = 0
        frm_menu_principal.Show()
        Me.Close()
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        End
    End Sub


End Class