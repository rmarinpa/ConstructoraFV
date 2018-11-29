Imports System.Globalization
Public Class Frm_maquinaria

    Dim nue_report As New clases.Maquinaria
    Dim nue_obra8 As New clases.Generacion_ep
    Dim nue_var As New clases.variables
    Dim Cod_liquidacion As String = ""
    Dim sw As Integer
    Dim hor1, hor2 As Double
    Dim const_dias As Double
    Dim sincroniza_local As Integer
    Dim version_mod1 As Integer
    Dim fecha_in, fecha_fin As Date
    Public Sub actualizar_fechas()
        Fecha_inicio = Me.dtp_fecha_in.Value.ToShortDateString
        fecha_in = Fecha_inicio
        Fecha_inicio = Format(CDate(Fecha_inicio), "yyyy/MM/dd")
        Fecha_final = Me.dtp_fecha_fin.Value.ToShortDateString
        fecha_fin = Fecha_final
        Fecha_final = Format(CDate(Fecha_final), "yyyy/MM/dd")
    End Sub
    Public Sub actualizar_arrendadores()
        actualizar_fechas()
        cmb_8_arrendador.DataSource = nue_report.listar(Fecha_inicio, Fecha_final, cmb_obra.SelectedValue)
        cmb_8_arrendador.DisplayMember = "razon_social"
        cmb_8_arrendador.ValueMember = "rut"
    End Sub
    Public Sub actualizar_obras()
        actualizar_fechas()
        cmb_obra.DataSource = nue_report.listar2(Fecha_inicio, Fecha_final)
        cmb_obra.DisplayMember = "nombre_obra"
        cmb_obra.ValueMember = "id_obra"
    End Sub

    Private Sub cmb_obra_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_obra.MouseClick
        actualizar_obras()
    End Sub
    
    Private Sub cmb_8_arrendador_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_8_arrendador.MouseClick
        actualizar_arrendadores()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        frm_login.Show()
        Me.Close()
    End Sub

    Private Sub btn_detalle_ep_Click(sender As Object, e As EventArgs) Handles btn_detalle_ep.Click
        CR_Estado_de_pago_maq.Show()
    End Sub

    Private Sub btn_detalle_obra_Click(sender As Object, e As EventArgs) Handles btn_detalle_obra.Click
        If cmb_8_arrendador.Text <> "" Then
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

            nue_obra8.listar5(cmb_obra.SelectedValue.ToString())
            dgv_8_minimos.DataSource = nue_obra8.listar4(cmb_obra.SelectedValue.ToString(), cmb_8_arrendador.SelectedValue.ToString(), Fecha_inicio, fecha_final)

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


            CR_Estado_de_pago_maq_ep.Show()
        Else
            MsgBox("FALTA SELECCIONAR A UN ARRENDADOR")
        End If
    End Sub
End Class