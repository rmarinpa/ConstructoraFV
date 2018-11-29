Imports System.Globalization
Public Class Frm_listado_maquinas

    Dim nue_report As New clases.listado_maquinas
    Dim nue_var As New clases.variables


    Public Sub actualizar_obras()
        cmb_obra.DataSource = nue_report.listar()
        cmb_obra.DisplayMember = "Nombre"
        cmb_obra.ValueMember = "Id_obras"
    End Sub


    Private Sub Frm_listado_maquinas_Load(sender As Object, e As EventArgs) Handles Me.Load
        actualizar_obras()
        cmb_activo.Text = "Todos"
    End Sub

    Private Sub btn_detalle_ep_Click(sender As Object, e As EventArgs) Handles btn_detalle_ep.Click
        Me.Close()
    End Sub

    Private Sub btn_detalle_obra_Click(sender As Object, e As EventArgs) Handles btn_detalle_obra.Click

        If cmb_obra.Text <> "" And cmb_ordenar.Text <> "" And cmb_tipo_equipo.Text <> "" Then
            CR_listado_equipos.Show()
        Else
            MsgBox("FALTA COMPLETAR LOS DATOS")
        End If
    End Sub
End Class