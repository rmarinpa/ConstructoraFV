Imports System.Globalization
Public Class Frm_menu_rendimientos

    Dim nue_report As New clases.Rendimientos
    Dim nue_var As New clases.variables
    Dim Cod_viajes As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double
    Dim sincroniza_local As Integer
    Dim version_mod1 As Integer

    Sub actualizar_check()
        Dim tipo_maquina As String
        check_rendimientos.Items.Clear()
        dgv_check.DataSource = nue_report.listar(id_obra)

        If dgv_check.Rows.Count > 0 Then
            For i = 0 To dgv_check.Rows.Count - 2
                tipo_maquina = dgv_check.Rows(i).Cells(0).Value.ToString()
                check_rendimientos.Items.Add(tipo_maquina)
            Next i
        End If
    End Sub

    Private Sub Frm_menu_rendimientos_Load(sender As Object, e As EventArgs) Handles Me.Load
        actualizar_check()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        For i As Integer = 0 To check_rendimientos.Items.Count - 1

            check_rendimientos.SetItemChecked(i, True)

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To check_rendimientos.Items.Count - 1

            check_rendimientos.SetItemChecked(i, False)

        Next
    End Sub

    Private Sub btn_rendimientos_Click(sender As Object, e As EventArgs) Handles btn_rendimientos.Click
        Dim Fecha_inicio As String
        Dim fecha_final As String

        pb_list.Maximum = 6
        pb_list.Value = 1
        Fecha_inicio = frm_menu_principal_V.dtp_8_fecha_inicial.Value.ToShortDateString
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        fecha_final = frm_menu_principal_V.dtp_8_fecha_final.Value.ToShortDateString
        fecha_final = Format(CDate(fecha_final), "yyyy/MM/dd")
        'MsgBox(Fecha_inicio)
        'MsgBox(fecha_final)
        'MsgBox(id_obra)
        dgv_datos.DataSource = nue_report.listar4(id_obra, Fecha_inicio, fecha_final)
        pb_list.Value = 2
        nue_report.listar2()
        pb_list.Value = 3
        nue_report.listar3()
        pb_list.Value = 4

        If dgv_datos.Rows.Count > 1 Then
            For i = 0 To dgv_datos.Rows.Count - 2

                Dim fecha As Date
                Dim codigo As String

                fecha = CDate(dgv_datos.Rows(i).Cells(0).Value.ToString())
                codigo = dgv_datos.Rows(i).Cells(2).Value.ToString()
                nue_report.insertar_report(1, 0, Nombre_Obra, id_obra, fecha, codigo, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 1, "", 1)
            Next i
        End If
        pb_list.Value = 5

        nue_report.listar5()

        For i = 0 To check_rendimientos.Items.Count - 1
            If (check_rendimientos.GetItemChecked(i)) Then
                nue_report.insertar_tipo_maquina(check_rendimientos.Items(i).ToString)
            End If
        Next
        pb_list.Value = 6
        CR_Informe_rendimiento.Show()
        pb_list.Value = 0
    End Sub
End Class