Imports Microsoft.Office.Interop.Word 'Control de office
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop

Public Class frm_menu_principal_V
    Dim nue_obra2 As New clases.Registro_petroleo
    Dim nue_obra3 As New clases.Compras_petroleo
    Dim nue_obra7 As New clases.Storage
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

    Sub bloquear7()
        txt_7_num_guia.Enabled = False
        dtp_7_fecha.Enabled = False
        txt_7_litros.Enabled = False

        btn_cancelar7.Enabled = False
        btn_guardar7.Enabled = False
        btn_editar7.Enabled = True
        btn_nuevo7.Enabled = True
        btn_eliminar7.Enabled = True
    End Sub
    Sub desbloquear7()
        txt_7_num_guia.Enabled = True
        dtp_7_fecha.Enabled = True
        txt_7_litros.Enabled = True

        btn_cancelar7.Enabled = True
        btn_guardar7.Enabled = True
        btn_editar7.Enabled = False
        btn_nuevo7.Enabled = False
        btn_eliminar7.Enabled = False
    End Sub
    Sub limpiar7()
        txt_7_num_guia.Clear()
        txt_7_litros.Clear()
    End Sub
    Sub bloquear3()
        dtp_3_fecha.Enabled = False
        txt_3_proveedor.Enabled = False
        txt_3_num_factura.Enabled = False
        txt_3_litros.Enabled = False
        txt_3_rut.Enabled = False
        txt_3_precio.Enabled = False
        txt_3_iev.Enabled = False
        txt_3_ief.Enabled = False
        txt_3_descuento.Enabled = False
        txt_3_adm.Enabled = False
        'txt_3_precio_base.Enabled = False

        btn_cancelar3.Enabled = False
        btn_guardar3.Enabled = False
        btn_editar3.Enabled = True
        btn_nuevo3.Enabled = True
        btn_eliminar3.Enabled = True
    End Sub
    Sub desbloquear3()
        dtp_3_fecha.Enabled = True
        txt_3_proveedor.Enabled = True
        txt_3_num_factura.Enabled = True
        txt_3_litros.Enabled = True
        txt_3_rut.Enabled = True
        txt_3_precio.Enabled = True
        txt_3_iev.Enabled = True
        txt_3_ief.Enabled = True
        txt_3_descuento.Enabled = True
        txt_3_adm.Enabled = True
        'txt_3_precio_base.Enabled = True

        btn_cancelar3.Enabled = True
        btn_guardar3.Enabled = True
        btn_editar3.Enabled = False
        btn_nuevo3.Enabled = False
        btn_eliminar3.Enabled = False
    End Sub
    Sub limpiar3()
        txt_3_proveedor.Clear()
        txt_3_num_factura.Clear()
        txt_3_litros.Clear()
        txt_3_rut.Clear()
        txt_3_precio.Clear()
        txt_3_iev.Clear()
        txt_3_ief.Clear()
        txt_3_descuento.Clear()
        txt_3_precio_base.Clear()
        txt_3_adm.Clear()

        txt_3_total.Clear()
        txt_3_total_iev.Clear()
        txt_3_total_ief.Clear()
        txt_3_total_iva.Clear()
        txt_3_total_compra.Clear()
    End Sub
    Sub autoriza2()
        If autoriza_2_2 = 1 Then
            'btn_cancelar2.Visible = True
            'btn_guardar2.Visible = True
            'btn_editar2.Visible = True
            'btn_nuevo2.Visible = True
            'btn_eliminar2.Visible = True
            btn_tabla.Visible = True
        ElseIf autoriza_2_2 = 0 Then
            'btn_cancelar2.Visible = False
            'btn_guardar2.Visible = False
            'btn_editar2.Visible = False
            'btn_nuevo2.Visible = False
            'btn_eliminar2.Visible = False
            btn_tabla.Visible = False
        End If
    End Sub
    Sub autoriza3()
        If autoriza_2_3 = 1 Then
            btn_cancelar3.Visible = True
            btn_guardar3.Visible = True
            btn_editar3.Visible = True
            btn_nuevo3.Visible = True
            btn_eliminar3.Visible = True
        ElseIf autoriza_2_3 = 0 Then
            btn_cancelar3.Visible = False
            btn_guardar3.Visible = False
            btn_editar3.Visible = False
            btn_nuevo3.Visible = False
            btn_eliminar3.Visible = False
        End If
    End Sub

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim rtn As New Date
        lbl_nombre_obra.Text = Nombre_Obra
        lbl_usuario.Text = Nombre_Usuario
        Me.WindowState = FormWindowState.Maximized
        txt_1_nom_obra.Enabled = False
        txt_1_nom_obra.Text = Nombre_Obra
        cmb_1_gerente.Text = ""
        consulta_datos = 0
        consulta_datos_local = 0
        codigo_libre = 0
        Timer1.Enabled = True
        actualiza_equipos()
        txt_3_adm.Text = 0

        txt_8_stock_anterior.Text = 0
        bloquear3()
        bloquear7()
        autoriza_2_1 = 1
        autoriza_2_2 = 1
        autoriza_2_3 = 1
        autoriza2()
        autoriza3()
        actualizar_dgv3()
        actualizar_dgv7()
        dtp_fecha.MaxDate = Today
        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 24).AddMonths(-2)
        dtp_fecha.MinDate = rtn

        If sincroniza = 0 Then
            btn_sincronizar.Visible = False
            pb_list.Visible = False
            lbl_sincroniza.Text = "Trabajando con Internet"

            btn_tabla.Visible = True

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
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 0
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 2 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 1
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 3 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 2
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 4 Then
            TabControl11.SelectedTab = TabPage3
            Panel2.SelectedIndex = 3
            Me.TabPage52.Parent = Nothing
        End If

        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        num_tab = 0
        Dim consultar As MsgBoxResult
        If consulta_datos <> 0 Then
            consultar = MsgBox("Usted no ha guardado los consumos de petróleo, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
                btn_tabla.PerformClick()
            Else
            End If
            frm_menu_principal.Show()
            Me.Close()
        ElseIf consulta_datos = 0 Then
            frm_menu_principal.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        End
    End Sub
    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        If num_tab <> 0 Then
            num_tab = 0
            Dim consultar As MsgBoxResult
            If consulta_datos <> 0 Then
                consultar = MsgBox("Usted no ha guardado los consumos de petróleo, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

                If consultar = MsgBoxResult.Yes Then
                    btn_tabla.PerformClick()
                Else
                End If
                frm_menu_principal.Show()
                Me.Close()
            ElseIf consulta_datos = 0 Then
                frm_menu_principal.Show()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btn_nuevo3_Click(sender As Object, e As EventArgs) Handles btn_nuevo3.Click
        desbloquear3()
        limpiar3()
        sw3 = 0
        Cod_3 = ""
    End Sub
    Private Sub btn_cancelar3_Click(sender As Object, e As EventArgs) Handles btn_cancelar3.Click
        bloquear3()
    End Sub
    Private Sub btn_editar3_Click(sender As Object, e As EventArgs) Handles btn_editar3.Click
        If (Cod_3 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            desbloquear3()
            sw3 = 1
        End If
    End Sub
    Private Sub btn_eliminar3_Click(sender As Object, e As EventArgs) Handles btn_eliminar3.Click
        Dim eliminar3 As MsgBoxResult
        If (Cod_3 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar3 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.YesNo, "Confirmar")

            If eliminar3 = MsgBoxResult.Yes And sincroniza = 0 Then
                version_mod3 = version_mod3 + 1
                nue_obra3.eliminar_sincro(CInt(Cod_3), 3, version_mod3)
                actualizar_dgv3()
                bloquear3()
                limpiar3()

            ElseIf sincroniza_local3 = 1 And sincroniza = 1 And eliminar3 = MsgBoxResult.Yes Then
                nue_obra3.eliminar(CInt(Cod_3))
                actualizar_dgv3()
                bloquear3()
                limpiar3()

            ElseIf eliminar3 = MsgBoxResult.Yes Then
                version_mod3 = version_mod3 + 1
                nue_obra3.eliminar_sincro(CInt(Cod_3), 3, version_mod3)
                actualizar_dgv3()
                bloquear3()
                limpiar3()
            End If
        End If
    End Sub

    Private Sub btn_guardar3_Click(sender As Object, e As EventArgs) Handles btn_guardar3.Click
        Dim Proveedor, Rut, Obra As String
        Dim costo_adm, Descuento, Imp_esp_var, Imp_esp_fijo, Precio_base, Total_neto, Total_Iva, Total_IEV, Total_IEF, Total_Ventas, Precio, Litros As Double
        Dim Fecha As Date
        Dim N_Factura As Integer

        If (txt_3_num_factura.Text <> "" And txt_3_proveedor.Text <> "" And txt_3_rut.Text <> "" And txt_3_litros.Text <> "") Then

            Proveedor = txt_3_proveedor.Text
            Rut = txt_3_rut.Text
            Obra = ""
            Descuento = CDbl(txt_3_descuento.Text)
            Imp_esp_var = CDbl(txt_3_iev.Text)
            Imp_esp_fijo = CDbl(txt_3_ief.Text)
            Precio_base = CDbl(txt_3_precio_base.Text)
            Total_neto = CDbl(txt_3_total.Text)
            Total_Iva = CDbl(txt_3_total_iva.Text)
            Total_IEV = CDbl(txt_3_total_iev.Text)
            Total_IEF = CDbl(txt_3_total_ief.Text)
            Total_Ventas = CDbl(txt_3_total_compra.Text)
            Precio = CDbl(txt_3_precio.Text)
            Litros = CDbl(txt_3_litros.Text)
            Fecha = CDate(dtp_3_fecha.Text)
            N_Factura = CDbl(txt_3_num_factura.Text)
            costo_adm = CDbl(txt_3_adm.Text)

            If sw3 = 0 Then
                nue_obra3.insertar(1, 0, Nombre_Obra, id_obra, Fecha, N_Factura, Proveedor, Rut, Descuento, Imp_esp_var, Imp_esp_fijo, Precio_base, Total_neto, Total_Iva, Total_IEV, Total_IEF, Total_Ventas, Precio, Litros, Obra, costo_adm)
                actualizar_dgv3()

            ElseIf sincroniza_local3 = 1 And sincroniza = 1 And sw3 <> 0 Then
                nue_obra3.modificar(CInt(Cod_3), 1, 0, Nombre_Obra, id_obra, Fecha, N_Factura, Proveedor, Rut, Descuento, Imp_esp_var, Imp_esp_fijo, Precio_base, Total_neto, Total_Iva, Total_IEV, Total_IEF, Total_Ventas, Precio, Litros, Obra, costo_adm)
                actualizar_dgv3()

            ElseIf sincroniza = 0 And sw3 <> 0 Then
                version_mod3 = version_mod3 + 1
                nue_obra3.modificar(CInt(Cod_3), 2, version_mod3, Nombre_Obra, id_obra, Fecha, N_Factura, Proveedor, Rut, Descuento, Imp_esp_var, Imp_esp_fijo, Precio_base, Total_neto, Total_Iva, Total_IEV, Total_IEF, Total_Ventas, Precio, Litros, Obra, costo_adm)
                actualizar_dgv3()
            Else
                version_mod3 = version_mod3 + 1
                nue_obra3.modificar(CInt(Cod_3), 2, version_mod3, Nombre_Obra, id_obra, Fecha, N_Factura, Proveedor, Rut, Descuento, Imp_esp_var, Imp_esp_fijo, Precio_base, Total_neto, Total_Iva, Total_IEV, Total_IEF, Total_Ventas, Precio, Litros, Obra, costo_adm)
                actualizar_dgv3()
            End If
            limpiar3()
            bloquear3()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
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
    Private Sub btn_sincronizar_Click(sender As Object, e As EventArgs) Handles btn_sincronizar.Click
        num_tab = 0
        frm_menu_principal.Show()
        Me.Close()
        frm_menu_principal.btn_sincronizar.PerformClick()
    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        num_tab = 1
        Dim consultar As MsgBoxResult
        If consulta_datos <> 0 Then
            consultar = MsgBox("Usted no ha guardado los consumos de petróleo, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
                btn_tabla.PerformClick()
            Else
            End If
            frm_menu_principal_II.Show()
            Me.Close()
        ElseIf consulta_datos = 0 Then
            frm_menu_principal_II.Show()
            Me.Close()
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
    Sub actualizar_dgv()
        Dim fecha_consulta As Date
        Dim fecha_consulta_str As String
        fecha_consulta = Me.dtp_fecha.Value
        fecha_consulta_str = Format(fecha_consulta, "yyyy/MM/dd")

        dgv_equipos.DataSource = nue_obra2.listar6(fecha_consulta_str, id_obra)
    End Sub
    Private Sub dgv_datosAgregados_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados.CellEndEdit

        If dgv_datosAgregados.Rows.Count > 1 Then
            If e.ColumnIndex = 5 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("id_equipo").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If

                suma_litros = 0
                For Each r As DataGridViewRow In dgv_datosAgregados.Rows
                    r.Cells(2).ReadOnly = False
                    If IsNumeric(r.Cells(5).Value) Then
                        suma_litros = r.Cells(5).Value + suma_litros
                    End If
                Next
                txt_suma_litros.Text = FormatNumber(suma_litros, 0)

            ElseIf e.ColumnIndex = 2 And codigo_libre = 1 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 2
                ElseIf IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").Value) And Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) And IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("id_equipo").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 1
                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
        End If
    End Sub

    Private Sub dgv_datosAgregados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_datosAgregados.CellFormatting
        Try
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Fecha" Then
                Dim valor As String = e.Value
                e.CellStyle.BackColor = Color.LightBlue
            End If
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Column1" Then
                Dim valor As String = e.Value
                e.CellStyle.BackColor = Color.LightBlue
            End If
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Column2" Then
                Dim valor As String = e.Value
                e.CellStyle.BackColor = Color.LightBlue
            End If
            If Me.dgv_datosAgregados.Columns(e.ColumnIndex).Name = "Column14" Then
                Dim valor As String = e.Value
                e.CellStyle.BackColor = Color.LightBlue
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Tipo_horometro(ByVal fila As Integer)
        For index As Integer = 0 To dgv_datosAgregados.RowCount - 1
            If (fila = dgv_datosAgregados.Rows(index).Cells(0).Value) Then
                dgv_datosAgregados.Rows(index).DefaultCellStyle.BackColor = Color.Yellow
                Exit For
            End If
        Next
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles btn_fecha.Click
        Dim consultar As MsgBoxResult
        codigo_libre = 0
        dgv_datosAgregados.DataSource = Nothing

        If consulta_datos_local <> 0 Then
            consultar = MsgBox("Usted no ha guardado los consumos de petróleo, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
                btn_tabla.PerformClick()
            Else
            End If
            actualizar_dgv()
            actualiza_columnas()
            consulta_datos = 1
            consulta_datos_local = 1
        ElseIf consulta_datos_local = 0 Then
            actualizar_dgv()
            actualiza_columnas()
            consulta_datos = 1
            consulta_datos_local = 1
        End If
    End Sub

    Private Sub btn_equipo_Click(sender As Object, e As EventArgs) Handles btn_equipo.Click
        Dim consultar As MsgBoxResult

        dgv_datosAgregados.DataSource = Nothing

        If consulta_datos_local <> 0 Then
            consultar = MsgBox("Usted no ha guardado los consumos de petróleo, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
                btn_tabla.PerformClick()
            Else
            End If
            actualizar_dgv_equipo()
            actualiza_columnas()
            consulta_datos = 2
            consulta_datos_local = 2
        ElseIf consulta_datos_local = 0 Then
            actualizar_dgv_equipo()
            actualiza_columnas()
            consulta_datos = 2
            consulta_datos_local = 2
        End If
    End Sub
    Sub actualizar_dgv_equipo()
        Dim fecha_inicio_consulta, fecha_final_consulta As Date
        Dim fecha_inicio_str, fecha_final_str As String
        Dim rtn As New Date
        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 24).AddMonths(-2)

        fecha_inicio_consulta = rtn
        fecha_final_consulta = Today
        fecha_inicio_str = Format(fecha_inicio_consulta, "yyyy/MM/dd")
        fecha_final_str = Format(fecha_final_consulta, "yyyy/MM/dd")

        dgv_equipos.DataSource = nue_obra2.listar7(fecha_inicio_str, fecha_final_str, id_obra, CInt(cmb_equipo.SelectedValue.ToString()))
    End Sub
    Public Sub actualiza_equipos()
        cmb_equipo.DataSource = nue_obra2.listar2_reports(id_obra)
        cmb_equipo.DisplayMember = "codigo"
        cmb_equipo.ValueMember = "id_equipo"
    End Sub
    Sub actualiza_columnas()
        dgv_datosAgregados.Rows.Clear()

        If codigo_libre = 1 Then
            Dim cantDatosAgregados As Integer = 30
            dgv_datosAgregados.Rows.Add(30)
            For i = 0 To 29
                dgv_datosAgregados.Rows(i).Cells(1).Value = dtp_fecha.Text
            Next i
        Else
            Dim cantDatosAgregados As Integer = dgv_datosAgregados.RowCount - 1
            If dgv_equipos.Rows.Count > 1 Then
                dgv_datosAgregados.Rows.Add(dgv_equipos.Rows.Count - 1)
                For i = 0 To dgv_equipos.Rows.Count - 2
                    dgv_datosAgregados.Rows(i).Cells(0).Value = dgv_equipos.Rows(i).Cells(0).Value.ToString()
                    dgv_datosAgregados.Rows(i).Cells(1).Value = dgv_equipos.Rows(i).Cells(1).Value.ToString()
                    dgv_datosAgregados.Rows(i).Cells(2).Value = dgv_equipos.Rows(i).Cells(2).Value.ToString()
                    dgv_datosAgregados.Rows(i).Cells(3).Value = dgv_equipos.Rows(i).Cells(3).Value.ToString()
                    dgv_datosAgregados.Rows(i).Cells(4).Value = dgv_equipos.Rows(i).Cells(4).Value.ToString()
                    dgv_datosAgregados.Rows(i).Cells(5).Value = dgv_equipos.Rows(i).Cells(5).Value.ToString()
                    'dgv_datosAgregados.Rows(i).Cells(6).Value = dgv_equipos.Rows(i).Cells(6).Value.ToString()
                    dgv_datosAgregados.Rows(i).Cells(7).Value = dgv_equipos.Rows(i).Cells(7).Value.ToString()
                    dgv_datosAgregados.Rows(i).Cells(8).Value = dgv_equipos.Rows(i).Cells(8).Value.ToString()
                    dgv_datosAgregados.Rows(i).Cells(9).Value = dgv_equipos.Rows(i).Cells(9).Value.ToString()
                Next i

                'If sincroniza = 1 Then
                '    For Each r As DataGridViewRow In dgv_datosAgregados.Rows
                '        If IsNumeric(r.Cells(0).Value.ToString) And IsNumeric(r.Cells(9).Value.ToString) Then
                '            If CInt(r.Cells(9).Value.ToString) <> 1 Then
                '                r.Cells(5).ReadOnly = True
                '                r.Cells(5).Style.BackColor = Color.Gray
                '            End If
                '        End If
                '    Next
                'End If

                If sincroniza = 1 And modifica_local = 1 Then
                    For Each r As DataGridViewRow In dgv_datosAgregados.Rows
                        If IsNumeric(r.Cells(0).Value.ToString) And IsNumeric(r.Cells(9).Value.ToString) Then
                            If CInt(r.Cells(9).Value.ToString) <> 1 Then
                                'r.Cells(5).ReadOnly = True
                                r.Cells(5).Style.BackColor = Color.LightGreen
                            End If
                        End If
                    Next
                End If
            End If
        End If

        suma_litros = 0
        For Each r As DataGridViewRow In dgv_datosAgregados.Rows
            If codigo_libre = 1 Then
                r.Cells(2).ReadOnly = False
            ElseIf codigo_libre = 0 Then
                r.Cells(2).ReadOnly = True
            End If
            If IsNumeric(r.Cells(5).Value) Then
                suma_litros = r.Cells(5).Value + suma_litros
            End If
        Next
        txt_suma_litros.Text = FormatNumber(suma_litros, 0)
    End Sub
    Private Sub btn_tabla_Click(sender As Object, e As EventArgs) Handles btn_tabla.Click
        If dgv_datosAgregados.Rows.Count > 0 Then
            For i = 0 To dgv_datosAgregados.Rows.Count - 1
                Dim fecha As Date
                Dim N_de_Vale, Litros_consumo As Double
                Dim Obra, codigo As String
                Dim id, id_equipo As Integer
                Dim codigo_modifica As String
                'Dim contador As Integer
                'contador = 0

                If IsNumeric(dgv_datosAgregados.Rows(i).Cells(5).Value) And IsNumeric(dgv_datosAgregados.Rows(i).Cells(6).Value) And IsNumeric(dgv_datosAgregados.Rows(i).Cells(7).Value) Then

                    fecha = CDate(dgv_datosAgregados.Rows(i).Cells(1).Value.ToString())
                    N_de_Vale = 0

                    If IsNumeric(dgv_datosAgregados.Rows(i).Cells(6).Value.ToString()) Then
                        Litros_consumo = CDbl(dgv_datosAgregados.Rows(i).Cells(5).Value.ToString())
                    Else
                        Litros_consumo = 0
                    End If

                    id_equipo = CInt(dgv_datosAgregados.Rows(i).Cells(7).Value.ToString())
                    codigo = dgv_datosAgregados.Rows(i).Cells(2).Value.ToString()
                    codigo_modifica = dgv_datosAgregados.Rows(i).Cells(6).Value.ToString()

                    'If nue_obra2.verificar_registro(id_obra, fecha, codigo, Litros_consumo) = 0 Or (codigo_modifica = 3 And IsNumeric(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())) Then
                    If nue_obra2.verificar_registro(id_obra, fecha, codigo, Litros_consumo) = 0 Or (codigo_modifica = 3) Then

                        If dgv_datosAgregados.Rows(i).Cells(6).Value.ToString() = 1 Then
                            nue_obra2.insertar_report(1, 0, Nombre_Obra, id_obra, codigo, N_de_Vale, fecha, Litros_consumo, "", id_equipo)
                        ElseIf dgv_datosAgregados.Rows(i).Cells(6).Value.ToString() = 2 And dgv_datosAgregados.Rows(i).Cells(9).Value.ToString() = 1 And sincroniza = 1 Then
                            id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                            nue_obra2.modificar_report(CInt(id), 1, 0, Nombre_Obra, id_obra, codigo, N_de_Vale, fecha, Litros_consumo, "", id_equipo)
                        ElseIf dgv_datosAgregados.Rows(i).Cells(6).Value.ToString() = 2 And sincroniza = 0 Then
                            id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                            version_mod1 = CInt(dgv_datosAgregados.Rows(i).Cells(8).Value.ToString()) + 1
                            nue_obra2.modificar_report(CInt(id), 2, version_mod1, Nombre_Obra, id_obra, codigo, N_de_Vale, fecha, Litros_consumo, "", id_equipo)
                        ElseIf dgv_datosAgregados.Rows(i).Cells(6).Value.ToString() = 3 And sincroniza = 0 Then
                            id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                            version_mod1 = CInt(dgv_datosAgregados.Rows(i).Cells(8).Value.ToString()) + 1
                            nue_obra2.modificar_report(CInt(id), 3, version_mod1, Nombre_Obra, id_obra, "AA-EL", N_de_Vale, fecha, Litros_consumo, codigo, id_equipo)
                        ElseIf dgv_datosAgregados.Rows(i).Cells(6).Value.ToString() = 3 And dgv_datosAgregados.Rows(i).Cells(9).Value.ToString() = 1 And sincroniza = 1 Then
                            id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                            nue_obra2.eliminar_report(CInt(id))
                        ElseIf dgv_datosAgregados.Rows(i).Cells(6).Value.ToString() = 3 And dgv_datosAgregados.Rows(i).Cells(9).Value.ToString() <> 1 And sincroniza = 1 Then
                            id = CInt(dgv_datosAgregados.Rows(i).Cells(0).Value.ToString())
                            version_mod1 = CInt(dgv_datosAgregados.Rows(i).Cells(8).Value.ToString()) + 1
                            nue_obra2.modificar_report(CInt(id), 3, version_mod1, Nombre_Obra, id_obra, "AA-EL", N_de_Vale, fecha, Litros_consumo, codigo, id_equipo)
                        End If

                    End If
                Else
                End If
            Next i

            actualizar_dgv()
            actualiza_columnas()

            consulta_datos = 0
            consulta_datos_local = 0
            MsgBox("DATOS REGISTRADOS EXITOSAMENTE")

        Else
            MsgBox("NO FUERON ENCONTRADOS DATOS RELEVANTES")
        End If

    End Sub
    Sub actualizar_dgv3()
        dgv_3_compras.DataSource = nue_obra3.listar(id_obra)
        dgv_3_compras.Columns(0).Visible = False
        dgv_3_compras.Columns(1).Visible = False
        dgv_3_compras.Columns(2).Visible = False
        dgv_3_compras.Columns(3).Visible = False
        dgv_3_compras.Columns(4).Visible = False
        dgv_3_compras.Columns(5).HeaderText = "Fecha"
        dgv_3_compras.Columns(5).Width = 100
        dgv_3_compras.Columns(6).HeaderText = "N° Factura"
        dgv_3_compras.Columns(6).Width = 100
        dgv_3_compras.Columns(6).DefaultCellStyle.Format = "##,###.##"
        dgv_3_compras.Columns(7).HeaderText = "Proveedor"
        dgv_3_compras.Columns(7).Width = 130
        dgv_3_compras.Columns(8).Visible = False
        dgv_3_compras.Columns(9).Visible = False
        dgv_3_compras.Columns(10).Visible = False
        dgv_3_compras.Columns(11).Visible = False
        dgv_3_compras.Columns(12).Visible = False
        dgv_3_compras.Columns(13).Visible = False
        dgv_3_compras.Columns(14).Visible = False
        dgv_3_compras.Columns(15).Visible = False
        dgv_3_compras.Columns(16).Visible = False
        dgv_3_compras.Columns(17).Visible = False
        dgv_3_compras.Columns(18).Visible = False
        dgv_3_compras.Columns(19).HeaderText = "Litros"
        dgv_3_compras.Columns(19).Width = 100
        dgv_3_compras.Columns(19).DefaultCellStyle.Format = "##,###.##"
        dgv_3_compras.Columns(20).Visible = False

        dgv_3_compras.AllowUserToOrderColumns = True
    End Sub
    Sub actualizar_dgv7()
        dgv_7_storage.DataSource = nue_obra7.listar(id_obra)
        dgv_7_storage.Columns(0).Visible = False
        dgv_7_storage.Columns(1).Visible = False
        dgv_7_storage.Columns(2).Visible = False
        dgv_7_storage.Columns(3).Visible = False
        dgv_7_storage.Columns(4).Visible = False
        dgv_7_storage.Columns(5).HeaderText = "N° Guía"
        dgv_7_storage.Columns(5).Width = 100
        dgv_7_storage.Columns(5).DefaultCellStyle.Format = "##,###.##"
        dgv_7_storage.Columns(6).HeaderText = "Litros"
        dgv_7_storage.Columns(6).Width = 100
        dgv_7_storage.Columns(6).DefaultCellStyle.Format = "##,###.##"
        dgv_7_storage.Columns(7).HeaderText = "Fecha"
        dgv_7_storage.Columns(7).Width = 100
        dgv_7_storage.Columns(8).Visible = False
        dgv_7_storage.AllowUserToOrderColumns = True
    End Sub
    Private Sub txt_3_precio_TextChanged(sender As Object, e As EventArgs) Handles txt_3_num_factura.TextChanged

    End Sub

    Private Sub txt_3_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_3_litros.TextChanged
        If Not IsNumeric(txt_3_litros.Text) Then
            txt_3_litros.Clear()
        End If

        'If (Not IsNumeric(Me.txt_3_litros.Text)) Then
        '    Me.txt_3_litros.Text = 0
        'End If

        'If (Not IsNumeric(Me.txt_3_iev.Text)) Then
        '    Me.txt_3_iev.Text = 0
        'End If
        'If (Not IsNumeric(Me.txt_3_ief.Text)) Then
        '    Me.txt_3_ief.Text = 0
        'End If
        'If (Not IsNumeric(Me.txt_3_precio.Text)) Then
        '    Me.txt_3_precio.Text = 0
        'End If
        'If (Not IsNumeric(Me.txt_3_descuento.Text)) Then
        '    Me.txt_3_descuento.Text = 0
        'End If
        'If (Not IsNumeric(Me.txt_3_precio_base.Text)) Then
        '    Me.txt_3_precio_base.Text = 0
        'End If
        If IsNumeric(Me.txt_3_litros.Text) And IsNumeric(Me.txt_3_iev.Text) And IsNumeric(Me.txt_3_ief.Text) And IsNumeric(Me.txt_3_precio.Text) And IsNumeric(Me.txt_3_descuento.Text) Then
            txt_3_total_iev.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_iev.Text)
            txt_3_total_ief.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_ief.Text)
            txt_3_precio_base.Text = (CDbl(Me.txt_3_precio.Text) - CDbl(Me.txt_3_iev.Text) - CDbl(Me.txt_3_ief.Text) - CDbl(Me.txt_3_descuento.Text)) / 1.19
            txt_3_total.Text = CDbl(Me.txt_3_precio_base.Text) * CDbl(Me.txt_3_litros.Text)
            txt_3_total_iva.Text = 0.19 * CDbl(Me.txt_3_total.Text)
            txt_3_total_compra.Text = CDbl(Me.txt_3_total.Text) + CDbl(Me.txt_3_total_iev.Text) + CDbl(Me.txt_3_total_ief.Text) + CDbl(Me.txt_3_total_iva.Text)

            txt_3_total_iev.Text = FormatNumber(txt_3_total_iev.Text, 0)
            txt_3_total_ief.Text = FormatNumber(txt_3_total_ief.Text, 0)
            txt_3_precio_base.Text = FormatNumber(txt_3_precio_base.Text, 0)
            txt_3_total.Text = FormatNumber(txt_3_total.Text, 0)
            txt_3_total_iva.Text = FormatNumber(txt_3_total_iva.Text, 0)
            txt_3_total_compra.Text = FormatNumber(txt_3_total_compra.Text, 0)
        End If

    End Sub
    Private Sub dgv_3_trabajos_adicionales_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_3_compras.MouseClick
        txt_3_adm.Text = 0
        txt_3_litros.Text = 0
        txt_3_precio.Text = 0
        txt_3_iev.Text = 0
        txt_3_ief.Text = 0
        txt_3_descuento.Text = 0

        Cod_3 = dgv_3_compras.CurrentRow.Cells(0).Value.ToString()

        txt_3_num_factura.Text = dgv_3_compras.CurrentRow.Cells(6).Value.ToString()
        dtp_3_fecha.Text = dgv_3_compras.CurrentRow.Cells(5).Value.ToString()
        txt_3_proveedor.Text = dgv_3_compras.CurrentRow.Cells(7).Value.ToString()
        txt_3_rut.Text = dgv_3_compras.CurrentRow.Cells(8).Value.ToString()

        txt_3_litros.Text = dgv_3_compras.CurrentRow.Cells(19).Value.ToString()
        txt_3_precio.Text = dgv_3_compras.CurrentRow.Cells(18).Value.ToString()
        txt_3_iev.Text = dgv_3_compras.CurrentRow.Cells(10).Value.ToString()
        txt_3_ief.Text = dgv_3_compras.CurrentRow.Cells(11).Value.ToString()
        txt_3_descuento.Text = dgv_3_compras.CurrentRow.Cells(9).Value.ToString()
        txt_3_adm.Text = dgv_3_compras.CurrentRow.Cells(21).Value.ToString()


        'txt_3_total.Text = FormatNumber(txt_3_total.Text, 0)
        sincroniza_local3 = CInt(dgv_3_compras.CurrentRow.Cells(1).Value.ToString())
        version_mod3 = CInt(dgv_3_compras.CurrentRow.Cells(2).Value.ToString())
        sincroniza_mod3 = 2
    End Sub
    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter
        num_tab = 1
        Dim consultar As MsgBoxResult
        If consulta_datos <> 0 Then
            consultar = MsgBox("Usted no ha guardado los consumos de petróleo, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
                btn_tabla.PerformClick()
            Else
            End If
            frm_menu_principal_IV_V2.Show()
            Me.Close()
        ElseIf consulta_datos = 0 Then
            frm_menu_principal_IV_V2.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btn_8_terceros_ep_Click(sender As Object, e As EventArgs)
        CR_Estado_de_pago_terceros.Show()
    End Sub

    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
        num_tab = 1
        frm_menu_principal_III.Show()
        Me.Close()
    End Sub

    Private Sub txt_3_precio_TextChanged_1(sender As Object, e As EventArgs) Handles txt_3_precio.TextChanged
        If Not IsNumeric(txt_3_precio.Text) Then
            txt_3_precio.Clear()
        End If

        If IsNumeric(Me.txt_3_adm.Text) And IsNumeric(Me.txt_3_litros.Text) And IsNumeric(Me.txt_3_iev.Text) And IsNumeric(Me.txt_3_ief.Text) And IsNumeric(Me.txt_3_precio.Text) And IsNumeric(Me.txt_3_descuento.Text) Then
            txt_3_total_iev.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_iev.Text)
            txt_3_total_ief.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_ief.Text)
            txt_3_precio_base.Text = (CDbl(Me.txt_3_precio.Text) - CDbl(Me.txt_3_iev.Text) - CDbl(Me.txt_3_ief.Text) - CDbl(Me.txt_3_descuento.Text)) / 1.19
            txt_3_total.Text = CDbl(Me.txt_3_precio_base.Text) * CDbl(Me.txt_3_litros.Text)
            txt_3_total_iva.Text = 0.19 * CDbl(Me.txt_3_total.Text)
            txt_3_total_compra.Text = CDbl(Me.txt_3_total.Text) + CDbl(Me.txt_3_total_iev.Text) + CDbl(Me.txt_3_total_ief.Text) + CDbl(Me.txt_3_total_iva.Text) + CDbl(Me.txt_3_adm.Text)

            txt_3_total_iev.Text = FormatNumber(txt_3_total_iev.Text, 0)
            txt_3_total_ief.Text = FormatNumber(txt_3_total_ief.Text, 0)
            txt_3_precio_base.Text = FormatNumber(txt_3_precio_base.Text, 0)
            txt_3_total.Text = FormatNumber(txt_3_total.Text, 0)
            txt_3_total_iva.Text = FormatNumber(txt_3_total_iva.Text, 0)
            txt_3_total_compra.Text = FormatNumber(txt_3_total_compra.Text, 0)
        End If
    End Sub

    Private Sub txt_3_iev_TextChanged(sender As Object, e As EventArgs) Handles txt_3_iev.TextChanged
        If Len(txt_3_iev.Text) > 2 And Not IsNumeric(txt_3_iev.Text) Then
            txt_3_iev.Clear()
        End If

        If IsNumeric(Me.txt_3_adm.Text) And IsNumeric(Me.txt_3_litros.Text) And IsNumeric(Me.txt_3_iev.Text) And IsNumeric(Me.txt_3_ief.Text) And IsNumeric(Me.txt_3_precio.Text) And IsNumeric(Me.txt_3_descuento.Text) Then
            txt_3_total_iev.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_iev.Text)
            txt_3_total_ief.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_ief.Text)
            txt_3_precio_base.Text = (CDbl(Me.txt_3_precio.Text) - CDbl(Me.txt_3_iev.Text) - CDbl(Me.txt_3_ief.Text) - CDbl(Me.txt_3_descuento.Text)) / 1.19
            txt_3_total.Text = CDbl(Me.txt_3_precio_base.Text) * CDbl(Me.txt_3_litros.Text)
            txt_3_total_iva.Text = 0.19 * CDbl(Me.txt_3_total.Text)
            txt_3_total_compra.Text = CDbl(Me.txt_3_total.Text) + CDbl(Me.txt_3_total_iev.Text) + CDbl(Me.txt_3_total_ief.Text) + CDbl(Me.txt_3_total_iva.Text) + CDbl(Me.txt_3_adm.Text)

            txt_3_total_iev.Text = FormatNumber(txt_3_total_iev.Text, 0)
            txt_3_total_ief.Text = FormatNumber(txt_3_total_ief.Text, 0)
            txt_3_precio_base.Text = FormatNumber(txt_3_precio_base.Text, 0)
            txt_3_total.Text = FormatNumber(txt_3_total.Text, 0)
            txt_3_total_iva.Text = FormatNumber(txt_3_total_iva.Text, 0)
            txt_3_total_compra.Text = FormatNumber(txt_3_total_compra.Text, 0)
        End If
    End Sub

    Private Sub txt_3_ief_TextChanged(sender As Object, e As EventArgs) Handles txt_3_ief.TextChanged
        If Len(txt_3_ief.Text) > 2 And Not IsNumeric(txt_3_ief.Text) Then
            txt_3_ief.Clear()
        End If

        If IsNumeric(Me.txt_3_adm.Text) And IsNumeric(Me.txt_3_litros.Text) And IsNumeric(Me.txt_3_iev.Text) And IsNumeric(Me.txt_3_ief.Text) And IsNumeric(Me.txt_3_precio.Text) And IsNumeric(Me.txt_3_descuento.Text) Then
            txt_3_total_iev.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_iev.Text)
            txt_3_total_ief.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_ief.Text)
            txt_3_precio_base.Text = (CDbl(Me.txt_3_precio.Text) - CDbl(Me.txt_3_iev.Text) - CDbl(Me.txt_3_ief.Text) - CDbl(Me.txt_3_descuento.Text)) / 1.19
            txt_3_total.Text = CDbl(Me.txt_3_precio_base.Text) * CDbl(Me.txt_3_litros.Text)
            txt_3_total_iva.Text = 0.19 * CDbl(Me.txt_3_total.Text)
            txt_3_total_compra.Text = CDbl(Me.txt_3_total.Text) + CDbl(Me.txt_3_total_iev.Text) + CDbl(Me.txt_3_total_ief.Text) + CDbl(Me.txt_3_total_iva.Text) + CDbl(Me.txt_3_adm.Text)

            txt_3_total_iev.Text = FormatNumber(txt_3_total_iev.Text, 0)
            txt_3_total_ief.Text = FormatNumber(txt_3_total_ief.Text, 0)
            txt_3_precio_base.Text = FormatNumber(txt_3_precio_base.Text, 0)
            txt_3_total.Text = FormatNumber(txt_3_total.Text, 0)
            txt_3_total_iva.Text = FormatNumber(txt_3_total_iva.Text, 0)
            txt_3_total_compra.Text = FormatNumber(txt_3_total_compra.Text, 0)
        End If
    End Sub

    Private Sub txt_3_descuento_TextChanged(sender As Object, e As EventArgs) Handles txt_3_descuento.TextChanged
        If Not IsNumeric(txt_3_descuento.Text) Then
            txt_3_descuento.Clear()
        End If


        If IsNumeric(Me.txt_3_adm.Text) And IsNumeric(Me.txt_3_litros.Text) And IsNumeric(Me.txt_3_iev.Text) And IsNumeric(Me.txt_3_ief.Text) And IsNumeric(Me.txt_3_precio.Text) And IsNumeric(Me.txt_3_descuento.Text) Then
            txt_3_total_iev.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_iev.Text)
            txt_3_total_ief.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_ief.Text)
            txt_3_precio_base.Text = (CDbl(Me.txt_3_precio.Text) - CDbl(Me.txt_3_iev.Text) - CDbl(Me.txt_3_ief.Text) - CDbl(Me.txt_3_descuento.Text)) / 1.19
            txt_3_total.Text = CDbl(Me.txt_3_precio_base.Text) * CDbl(Me.txt_3_litros.Text)
            txt_3_total_iva.Text = 0.19 * CDbl(Me.txt_3_total.Text)
            txt_3_total_compra.Text = CDbl(Me.txt_3_total.Text) + CDbl(Me.txt_3_total_iev.Text) + CDbl(Me.txt_3_total_ief.Text) + CDbl(Me.txt_3_total_iva.Text) + CDbl(Me.txt_3_adm.Text)

            txt_3_total_iev.Text = FormatNumber(txt_3_total_iev.Text, 0)
            txt_3_total_ief.Text = FormatNumber(txt_3_total_ief.Text, 0)
            txt_3_precio_base.Text = FormatNumber(txt_3_precio_base.Text, 2)
            txt_3_total.Text = FormatNumber(txt_3_total.Text, 0)
            txt_3_total_iva.Text = FormatNumber(txt_3_total_iva.Text, 0)
            txt_3_total_compra.Text = FormatNumber(txt_3_total_compra.Text, 0)
        End If
    End Sub

    Private Sub btn_nuevo7_Click(sender As Object, e As EventArgs) Handles btn_nuevo7.Click
        actualiza_facturas()
        desbloquear7()
        limpiar7()
        sw7 = 0
        Cod_7 = ""
    End Sub

    Private Sub btn_editar7_Click(sender As Object, e As EventArgs) Handles btn_editar7.Click
        If (Cod_7 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            actualiza_facturas()
            desbloquear7()
            sw7 = 1
        End If
    End Sub

    Private Sub btn_eliminar7_Click(sender As Object, e As EventArgs) Handles btn_eliminar7.Click
        Dim eliminar7 As MsgBoxResult
        If (Cod_7 = "") Then
            MessageBox.Show("SELECCIONA UN REGISTRO")
        Else
            eliminar7 = MsgBox("¿Realmente desea eliminar el registro?", MsgBoxStyle.YesNo, "Confirmar")

            If eliminar7 = MsgBoxResult.Yes And sincroniza = 0 Then
                version_mod7 = version_mod7 + 1
                nue_obra7.eliminar_sincro(CInt(Cod_7), 3, version_mod7)
                actualizar_dgv7()
                bloquear7()
                limpiar7()


            ElseIf sincroniza_local7 = 1 And sincroniza = 1 And eliminar7 = MsgBoxResult.Yes Then
                nue_obra7.eliminar(CInt(Cod_7))
                actualizar_dgv7()
                bloquear7()
                limpiar7()

            ElseIf eliminar7 = MsgBoxResult.Yes Then
                version_mod7 = version_mod7 + 1
                nue_obra7.eliminar_sincro(CInt(Cod_7), 3, version_mod7)
                actualizar_dgv7()
                bloquear7()
                limpiar7()
            End If
        End If
    End Sub

    Private Sub btn_cancelar7_Click(sender As Object, e As EventArgs) Handles btn_cancelar7.Click
        bloquear7()
    End Sub

    Private Sub btn_guardar7_Click(sender As Object, e As EventArgs) Handles btn_guardar7.Click
        Dim Obra As String
        Dim Litros As Double
        Dim Fecha As Date
        Dim N_Guia As Integer

        If (txt_7_litros.Text <> "" And txt_7_num_guia.Text <> "") Then

            Obra = cmb_7_facturas.Text
            Litros = CDbl(txt_7_litros.Text)
            Fecha = CDate(dtp_7_fecha.Text)
            N_Guia = CDbl(txt_7_num_guia.Text)

            If sw7 = 0 Then
                nue_obra7.insertar(1, 0, Nombre_Obra, id_obra, N_Guia, Litros, Fecha, Obra, 0)
                actualizar_dgv7()

            ElseIf sincroniza_local7 = 1 And sincroniza = 1 And sw7 <> 0 Then
                nue_obra7.modificar(CInt(Cod_7), 1, 0, Nombre_Obra, id_obra, N_Guia, Litros, Fecha, Obra, 0)
                actualizar_dgv7()

            ElseIf sincroniza = 0 And sw7 <> 0 Then
                version_mod7 = version_mod7 + 1
                nue_obra7.modificar(CInt(Cod_7), 2, version_mod7, Nombre_Obra, id_obra, N_Guia, Litros, Fecha, Obra, 0)
                actualizar_dgv7()
            Else
                version_mod7 = version_mod7 + 1
                nue_obra7.modificar(CInt(Cod_7), 2, version_mod7, Nombre_Obra, id_obra, N_Guia, Litros, Fecha, Obra, 0)
                actualizar_dgv7()
            End If
            limpiar7()
            bloquear7()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

    Private Sub txt_7_litros_TextChanged(sender As Object, e As EventArgs) Handles txt_7_litros.TextChanged
        If Not IsNumeric(txt_7_litros.Text) Then
            txt_7_litros.Clear()
        End If
    End Sub

    Private Sub txt_7_num_guia_TextChanged(sender As Object, e As EventArgs) Handles txt_7_num_guia.TextChanged
        If Not IsNumeric(txt_7_num_guia.Text) Then
            txt_7_num_guia.Clear()
        End If
    End Sub

    Private Sub dgv_7_storage_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_7_storage.MouseClick
        Cod_7 = dgv_7_storage.CurrentRow.Cells(0).Value.ToString()

        txt_7_num_guia.Text = dgv_7_storage.CurrentRow.Cells(5).Value.ToString()
        dtp_7_fecha.Text = dgv_7_storage.CurrentRow.Cells(7).Value.ToString()
        txt_7_litros.Text = dgv_7_storage.CurrentRow.Cells(6).Value.ToString()

        sincroniza_local7 = CInt(dgv_7_storage.CurrentRow.Cells(1).Value.ToString())
        version_mod7 = CInt(dgv_7_storage.CurrentRow.Cells(2).Value.ToString())
        sincroniza_mod7 = 2
    End Sub

    Private Sub btn_8_diesel_mensual_Click(sender As Object, e As EventArgs) Handles btn_8_diesel_mensual.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Diesel_Mensual.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_libro_compras_Click(sender As Object, e As EventArgs) Handles btn_8_libro_compras.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Libro_Compras.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub btn_8_diesel_completo_Click(sender As Object, e As EventArgs) Handles btn_8_diesel_completo.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Diesel_Completo.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_compras_y_cons_Click(sender As Object, e As EventArgs) Handles btn_8_compras_y_cons.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) And IsNumeric(txt_8_stock_anterior.Text) Then
            CR_Informe_compras_y_consumo2.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_cuentas_contables_Click(sender As Object, e As EventArgs) Handles btn_8_cuentas_contables.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Cuentas_Petroleo.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_libro_combustible_Click(sender As Object, e As EventArgs) Handles btn_8_libro_combustible.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Libro_combustible_diesel2.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_storage_Click(sender As Object, e As EventArgs) Handles btn_8_storage.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            CR_Informe_Storage.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_8_rendimiento_Click(sender As Object, e As EventArgs) Handles btn_8_rendimiento.Click
        If IsDate(dtp_8_fecha_inicial.Text) And IsDate(dtp_8_fecha_final.Text) Then
            Frm_menu_rendimientos.ShowDialog()
            'CR_Informe_rendimiento.Show()
        Else
            MsgBox("FALTAN DATOS PARA INGRESAR ", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub actualiza_facturas()
        cmb_7_facturas.DataSource = nue_obra7.listar3(id_obra)
        cmb_7_facturas.DisplayMember = "N_Factura"
        cmb_7_facturas.ValueMember = "N_Factura"
    End Sub

    Private Sub dgv_datosAgregados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados.CellValueChanged
        If dgv_datosAgregados.Rows.Count > 0 And codigo_libre = 1 Then
            If e.ColumnIndex = 2 Then
                If dgv_datosAgregados.Rows(e.RowIndex).Cells("Column1").Value <> "" Then
                    Dim codigo As String
                    codigo = dgv_datosAgregados.Rows(e.RowIndex).Cells("Column1").Value
                    'dgv_codigo_libre.Rows.Clear()
                    dgv_codigo_libre.DataSource = nue_obra2.listar3(id_obra, codigo)

                    If dgv_codigo_libre.Rows.Count > 1 Then

                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column2").Value = dgv_codigo_libre.Rows(0).Cells(11).Value.ToString()
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Value = dgv_codigo_libre.Rows(0).Cells(14).Value.ToString()
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("id_equipo").Value = CInt(dgv_codigo_libre.Rows(0).Cells(0).Value.ToString())
                    Else
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column2").Value = ""
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Value = ""
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("id_equipo").Value = ""
                        dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                    End If

                Else
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("Column2").Value = ""
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Value = ""
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_equipo").Value = ""
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
            End If
        End If
    End Sub
    Private Sub txt_3_adm_TextChanged(sender As Object, e As EventArgs) Handles txt_3_adm.TextChanged
        If Not IsNumeric(txt_3_adm.Text) Then
            txt_3_adm.Clear()
        End If

        If IsNumeric(Me.txt_3_adm.Text) And IsNumeric(Me.txt_3_litros.Text) And IsNumeric(Me.txt_3_iev.Text) And IsNumeric(Me.txt_3_ief.Text) And IsNumeric(Me.txt_3_precio.Text) And IsNumeric(Me.txt_3_descuento.Text) Then
            txt_3_total_iev.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_iev.Text)
            txt_3_total_ief.Text = CDbl(Me.txt_3_litros.Text) * CDbl(Me.txt_3_ief.Text)
            txt_3_precio_base.Text = (CDbl(Me.txt_3_precio.Text) - CDbl(Me.txt_3_iev.Text) - CDbl(Me.txt_3_ief.Text) - CDbl(Me.txt_3_descuento.Text)) / 1.19
            txt_3_total.Text = CDbl(Me.txt_3_precio_base.Text) * CDbl(Me.txt_3_litros.Text)
            txt_3_total_iva.Text = 0.19 * CDbl(Me.txt_3_total.Text)
            txt_3_total_compra.Text = CDbl(Me.txt_3_total.Text) + CDbl(Me.txt_3_total_iev.Text) + CDbl(Me.txt_3_total_ief.Text) + CDbl(Me.txt_3_total_iva.Text) + CDbl(Me.txt_3_adm.Text)

            txt_3_total_iev.Text = FormatNumber(txt_3_total_iev.Text, 0)
            txt_3_total_ief.Text = FormatNumber(txt_3_total_ief.Text, 0)
            txt_3_precio_base.Text = FormatNumber(txt_3_precio_base.Text, 2)
            txt_3_total.Text = FormatNumber(txt_3_total.Text, 0)
            txt_3_total_iva.Text = FormatNumber(txt_3_total_iva.Text, 0)
            txt_3_total_compra.Text = FormatNumber(txt_3_total_compra.Text, 0)
        End If
    End Sub

    Private Sub dgv_datosAgregados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_datosAgregados.CellContentClick
        If dgv_datosAgregados.Rows.Count > 1 Then
            If e.ColumnIndex = 10 Then
                If IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 3
                ElseIf Not IsNumeric(dgv_datosAgregados.Rows(e.RowIndex).Cells("Id").Value) Then
                    dgv_datosAgregados.Rows(e.RowIndex).Cells("id_modifica").Value = 0
                End If
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Fecha").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column1").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column2").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").Style.BackColor = Color.Salmon
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").Style.BackColor = Color.Salmon

                dgv_datosAgregados.Rows(e.RowIndex).Cells("Fecha").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column1").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column2").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column14").ReadOnly = True
                dgv_datosAgregados.Rows(e.RowIndex).Cells("Column12").ReadOnly = True
            End If
        End If
    End Sub

    Private Sub TabPage10_Enter(sender As Object, e As EventArgs) Handles TabPage10.Enter
        num_tab = 1
        frm_menu_principal_X.Show()
        Me.Close()
    End Sub

    Private Sub btn_fecha_libre_Click(sender As Object, e As EventArgs) Handles btn_fecha_libre.Click
        Dim consultar As MsgBoxResult
        codigo_libre = 1
        dgv_datosAgregados.DataSource = Nothing

        If consulta_datos_local <> 0 Then
            consultar = MsgBox("Usted no ha guardado los consumos de petróleo, ¿Desea guardarlos?", MsgBoxStyle.YesNo, "Confirmar")

            If consultar = MsgBoxResult.Yes Then
                btn_tabla.PerformClick()
            Else
            End If
            actualizar_dgv()
            actualiza_columnas()
            consulta_datos = 1
            consulta_datos_local = 1
        ElseIf consulta_datos_local = 0 Then
            actualizar_dgv()
            actualiza_columnas()
            consulta_datos = 1
            consulta_datos_local = 1
        End If
    End Sub

    Private Sub dgv_datosAgregados_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_datosAgregados.KeyDown
        Try
            If e.Control And (e.KeyCode = Keys.C) Then
                Dim d As DataObject = dgv_datosAgregados.GetClipboardContent()
                Clipboard.SetDataObject(d)
                e.Handled = True
            ElseIf (e.Control And e.KeyCode = Keys.V) Then
                PasteUnboundRecords()
            End If
        Catch ex As Exception
            'Log Exception
        End Try
    End Sub

    Private Sub PasteUnboundRecords()

        Try
            Dim rowLines As String() = Clipboard.GetText(TextDataFormat.Text).Split(New String(0) {vbCr & vbLf}, StringSplitOptions.None)
            Dim currentRowIndex As Integer = (If(dgv_datosAgregados.CurrentRow IsNot Nothing, dgv_datosAgregados.CurrentRow.Index, 0))
            Dim currentColumnIndex As Integer = (If(dgv_datosAgregados.CurrentCell IsNot Nothing, dgv_datosAgregados.CurrentCell.ColumnIndex, 0))
            Dim currentColumnCount As Integer = dgv_datosAgregados.Columns.Count

            dgv_datosAgregados.AllowUserToAddRows = False
            For rowLine As Integer = 0 To rowLines.Length - 1

                If rowLine = rowLines.Length - 1 AndAlso String.IsNullOrEmpty(rowLines(rowLine)) Then
                    Exit For
                End If

                Dim columnsData As String() = rowLines(rowLine).Split(New String(0) {vbTab}, StringSplitOptions.None)
                If (currentColumnIndex + columnsData.Length) > dgv_datosAgregados.Columns.Count Then
                    For columnCreationCounter As Integer = 0 To ((currentColumnIndex + columnsData.Length) - currentColumnCount) - 1
                        If columnCreationCounter = rowLines.Length - 1 Then
                            Exit For
                        End If
                    Next
                End If
                If dgv_datosAgregados.Rows.Count > (currentRowIndex + rowLine) Then
                    For columnsDataIndex As Integer = 0 To columnsData.Length - 1
                        If currentColumnIndex + columnsDataIndex <= dgv_datosAgregados.Columns.Count - 1 Then
                            dgv_datosAgregados.Rows(currentRowIndex + rowLine).Cells(currentColumnIndex + columnsDataIndex).Value = columnsData(columnsDataIndex)
                        End If
                    Next
                Else
                    Dim pasteCells As String() = New String(dgv_datosAgregados.Columns.Count - 1) {}
                    For cellStartCounter As Integer = currentColumnIndex To dgv_datosAgregados.Columns.Count - 1
                        If columnsData.Length > (cellStartCounter - currentColumnIndex) Then
                            pasteCells(cellStartCounter) = columnsData(cellStartCounter - currentColumnIndex)
                        End If
                    Next
                End If
            Next

        Catch ex As Exception
            'Log Exception
        End Try

    End Sub
End Class