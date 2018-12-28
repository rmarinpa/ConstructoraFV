Imports Microsoft.Office.Interop.Word 'Control de office
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Globalization

Public Class frm_menu_principal_VI
    Dim nue_obra2 As New clases.Registro_petroleo
    Dim nue_obra3 As New clases.Compras_petroleo
    Dim nue_obra7 As New clases.Storage
    Dim nue_obra5 As New clases.Ingreso_contratos
    Dim nue_obra6 As New clases.EstadoPagoMandante
    Dim Obra As New clases.Identificacion_obra
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
    Dim Boton As Integer
    Dim ObraFiltro As String
    Dim obraNroEstadoPago As String
    Dim obraFacturaFirmada As String

    Sub LeerRetencion()
        Try
            Dim total As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim obraFiltro As String
            obraFiltro = cboObrasFiltro.Text
            If obraFiltro = "System.Data.DataRowView" Then
                cboObrasFiltro.Text = Nombre_Obra
            End If
            dgRetencionesProforma.DataSource = Obra.LeerRetencionesProformas(cboObrasFiltro.Text)
            With dgRetencionesProforma
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Retenciones Contrato"
                .Columns(1).HeaderCell.Value = "Proformas Contrato"

                dgRetencionesProforma.Columns(0).DefaultCellStyle.Format = "C"
                dgRetencionesProforma.Columns(1).DefaultCellStyle.Format = "C"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RellenarCboObras()
        cboObrasPagoFirmado.DataSource = nue_obra5.listar5(id_obra)
        cboObrasPagoFirmado.DisplayMember = "nombre_faena"
        cboObrasPagoFirmado.ValueMember = "Id_identificacion"


        cboObrasFiltro.DataSource = nue_obra5.listar5(id_obra)
        cboObrasFiltro.DisplayMember = "nombre_faena"
        cboObrasFiltro.ValueMember = "Id_identificacion"


        cboObrasFacturasPago.DataSource = nue_obra5.listar5(id_obra)
        cboObrasFacturasPago.DisplayMember = "nombre_faena"
        cboObrasFacturasPago.ValueMember = "Id_identificacion"


        cboObras.DataSource = nue_obra5.listar5(id_obra)
        cboObras.DisplayMember = "nombre_faena"
        cboObras.ValueMember = "Id_identificacion"


    End Sub

    Private Sub frm_menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoriza_2_1 = 1
        autoriza_2_2 = 1
        autoriza_2_3 = 1
        rtn = Date.Now
        rtn = rtn.AddDays(-rtn.Day + 24).AddMonths(-2)
        'Se bloquean las cajas de texto
        BloquearEstado()
        RellenarCboObras()
        LeerRetencion()
        Actualizar_dgvEstadosPagoFirmado()
        dgvFiltroEstadoPagoMandante()

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
            TabControl11.SelectedTab = TabPage6
            TabControl5.SelectedIndex = 0
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 2 Then
            TabControl11.SelectedTab = TabPage6
            TabControl5.SelectedIndex = 1
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 3 Then
            TabControl11.SelectedTab = TabPage6
            TabControl5.SelectedIndex = 2
            Me.TabPage52.Parent = Nothing
        End If
        Me.WindowState = FormWindowState.Maximized
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
    Private Sub TabPage10_Enter(sender As Object, e As EventArgs) Handles TabPage10.Enter
        num_tab = 1
        frm_menu_principal_X.Show()
        Me.Close()
    End Sub
    Private Sub TabPage8_Enter(sender As Object, e As EventArgs) Handles TabPage7.Enter
        num_tab = 1
        frm_menu_principal_VII.Show()
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

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Boton = 1 Then
            Try
                Dim obra As String
                Dim nro_estadoPago As Decimal
                Dim fecha As Date
                Dim nro_factura As Decimal
                Dim valor_obra As Decimal
                Dim reajuste As Decimal
                Dim retenciones As Decimal
                Dim retenciones_canjeadas As Decimal
                Dim multas As Decimal
                Dim valor_estado_pago As Decimal
                Dim valor_estado_pago_neto As Decimal
                Dim obras_neto As Decimal
                Dim reajuste_neto As Decimal
                Dim observaciones As String
                obra = cboObras.Text
                nro_estadoPago = txtNroEstadoPago.Text
                fecha = dtFecha.Value.Date
                nro_factura = txtNroFactura.Text
                valor_obra = txtValorObra.Text
                reajuste = txtReajuste.Text
                retenciones = txtRetenciones.Text
                retenciones_canjeadas = txtRetencionesCanjeadas.Text
                multas = txtMultas.Text
                valor_estado_pago = txtValorEstadoPago.Text
                valor_estado_pago_neto = txtValorEstadoPagoNeto.Text
                obras_neto = txtObrasNeto.Text
                reajuste_neto = txtReajusteNeto.Text
                observaciones = txtObservaciones.Text


                If nue_obra6.RegistroExistente(obra, nro_estadoPago) = False Then
                    If txtNroEstadoPago.Text >= 0 And txtNroFactura.Text >= 0 And txtValorObra.Text >= 0 And txtReajuste.Text >= 0 And txtRetenciones.Text >= 0 And
                    txtRetencionesCanjeadas.Text >= 0 And txtMultas.Text >= 0 And txtValorEstadoPago.Text >= 0 And txtValorEstadoPagoNeto.Text >= 0 And txtObrasNeto.Text >= 0 And txtReajusteNeto.Text >= 0 And txtObservaciones.Text <> "" Then
                        nue_obra6.Insertar(nro_estadoPago, obra, fecha, nro_factura, valor_obra, reajuste, retenciones, retenciones_canjeadas, multas, valor_estado_pago, valor_estado_pago_neto, obras_neto, reajuste_neto, observaciones)
                        LimpiarEstado()
                        BloquearEstado()
                        btnAgregar.Enabled = False
                        btnCancelar.Enabled = False
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnEliminar.Enabled = True
                        cboObras.Text = obra
                        dgvFiltroEstadoPagoMandante()
                        Actualizar_dgvEstadosPagoFirmado()
                        actualizar_dgvFacturasAdjunto()
                        ActualizarCbo()

                    Else
                        MsgBox("Falta ingresar datos", MsgBoxStyle.Exclamation)

                    End If
                Else
                    MsgBox("Registro ya existente", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox("Verifique los datos ingresados", MsgBoxStyle.Exclamation)
            End Try
        Else
            Try
                Dim idestadopago As Decimal
                Dim sincroniza1 As String
                Dim version As Integer
                Dim obra As String
                Dim nro_estadoPago As Decimal
                Dim fecha As Date
                Dim nro_factura As Decimal
                Dim valor_obra As Decimal
                Dim reajuste As Decimal
                Dim retenciones As Decimal
                Dim retenciones_canjeadas As Decimal
                Dim multas As Decimal
                Dim valor_estado_pago As Decimal
                Dim valor_estado_pago_neto As Decimal
                Dim obras_neto As Decimal
                Dim reajuste_neto As Decimal
                Dim observaciones As String


                idestadopago = txtIdEstadoPago.Text
                sincroniza1 = sincroniza.ToString
                version = version.ToString
                obra = cboObras.Text
                nro_estadoPago = txtNroEstadoPago.Text
                fecha = dtFecha.Value.Date
                nro_factura = txtNroFactura.Text
                valor_obra = txtValorObra.Text
                reajuste = txtReajuste.Text
                retenciones = txtRetenciones.Text
                retenciones_canjeadas = txtRetencionesCanjeadas.Text
                multas = txtMultas.Text
                valor_estado_pago = txtValorEstadoPago.Text
                valor_estado_pago_neto = txtValorEstadoPagoNeto.Text
                obras_neto = txtObrasNeto.Text
                reajuste_neto = txtReajusteNeto.Text
                observaciones = txtObservaciones.Text
                If idestadopago.ToString <> "" Then
                    nue_obra6.modificar(idestadopago, nro_estadoPago, obra, fecha, nro_factura, valor_obra, reajuste, retenciones, retenciones_canjeadas, multas, valor_estado_pago, valor_estado_pago_neto, obras_neto, reajuste_neto, observaciones)

                    btnAgregar.Enabled = False
                    btnCancelar.Enabled = False
                    btnNuevo.Enabled = True
                    btnModificar.Enabled = True
                    btnEliminar.Enabled = True
                    LimpiarEstado()
                    cboObras.Text = lbl_nombre_obra.Text
                    BloquearEstado()
                    dgvFiltroEstadoPagoMandante()
                    Actualizar_dgvEstadosPagoFirmado()
                    actualizar_dgvFacturasAdjunto()
                    ActualizarCbo()

                Else
                    MsgBox("Verifique los datos")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DesbloquearEstado()
        txtNroEstadoPago.Enabled = True
        txtObservaciones.Enabled = True
        cboObras.Enabled = True
        txtNroEstadoPago.Enabled = True
        dtFecha.Enabled = True
        txtNroFactura.Enabled = True
        txtValorObra.Enabled = True
        txtReajuste.Enabled = True
        txtRetenciones.Enabled = True
        txtRetencionesCanjeadas.Enabled = True
        txtMultas.Enabled = True
        txtValorEstadoPago.Enabled = True
        txtValorEstadoPagoNeto.Enabled = True
        txtObrasNeto.Enabled = True
        txtReajusteNeto.Enabled = True
        txtObservaciones.Enabled = True
    End Sub
    Sub BloquearEstado()
        txtNroEstadoPago.Enabled = False
        txtObservaciones.Enabled = False
        cboObras.Enabled = False
        txtNroEstadoPago.Enabled = False
        dtFecha.Enabled = False
        txtNroFactura.Enabled = False
        txtValorObra.Enabled = False
        txtReajuste.Enabled = False
        txtRetenciones.Enabled = False
        txtRetencionesCanjeadas.Enabled = False
        txtMultas.Enabled = False
        txtValorEstadoPago.Enabled = False
        txtValorEstadoPagoNeto.Enabled = False
        txtObrasNeto.Enabled = False
        txtReajusteNeto.Enabled = False
        txtObservaciones.Enabled = False
    End Sub
    Sub LimpiarEstado()
        txtNroEstadoPago.Text = ""
        txtObservaciones.Text = ""
        cboObras.Text = ""
        txtNroEstadoPago.Text = ""
        dtFecha.Value = DateTime.Now
        txtNroFactura.Text = ""
        txtValorObra.Text = ""
        txtReajuste.Text = ""
        txtRetenciones.Text = ""
        txtRetencionesCanjeadas.Text = ""
        txtMultas.Text = ""
        txtValorEstadoPago.Text = ""
        txtValorEstadoPagoNeto.Text = ""
        txtObrasNeto.Text = ""
        txtReajusteNeto.Text = ""
        txtObservaciones.Text = ""
    End Sub
    Sub LimpiarEstadosPago()
        txtIdEstadoPagoFirmado.Text = ""
        txtNombreObraArchivo.Text = ""
        txtNroEstadoPagoArchivo.Text = ""
        txtNombreArchivo.Text = ""
        txtUsuarioArchivo.Text = ""
        txtFechaAdjuntadoArchivo.Text = ""
        lblRutaDescarga.Text = ""
        TextBox3.Text = ""
        lblNombreArchivo.Text = ""
    End Sub

    Sub LimpiarFacturas()
        txtIdEstadoPagoFacturasFirmadas.Text = ""
        txtInfoObra.Text = ""
        txtInfoNroEstadoPago.Text = ""
        txtInfoNroFactura.Text = ""
        txtInfoFechaAdjunto.Text = ""
    End Sub

    Public Function DesformateoValores(ByVal val As Double)
        Try
            val = FormatNumber(val, 0)
            Return val
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Sub actualizar_dgvestados()
        Try
            Dim total As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            dgvEstadoPago.DataSource = nue_obra6.Leer(Nombre_Obra)
            With dgvEstadoPago
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "N° Estado de Pago"
                .Columns(2).HeaderCell.Value = "Obra"
                .Columns(3).HeaderCell.Value = "Fecha"
                .Columns(4).HeaderCell.Value = "N° Factura"
                .Columns(5).HeaderCell.Value = "Obras ($)"
                .Columns(6).HeaderCell.Value = "Reajuste ($)"
                .Columns(7).HeaderCell.Value = "Retenciones ($)"
                .Columns(8).HeaderCell.Value = "Retenciones Canjeadas ($)"
                .Columns(9).HeaderCell.Value = "Multas ($)"
                .Columns(10).HeaderCell.Value = "Valor Estado de Pago ($)"
                .Columns(11).HeaderCell.Value = "Valor Estado de Pago Neto ($)"
                .Columns(12).HeaderCell.Value = "Obras Neto ($)"
                .Columns(13).HeaderCell.Value = "Reajuste Neto ($)"
                .Columns(14).HeaderCell.Value = "Observaciones"

            End With
            dgvEstadoPago.Columns(4).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(5).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(6).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(7).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(8).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(9).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(10).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(11).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(12).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            'Metodo para contar el total de una fila
            'For Each fila In dgvEstadoPago.Rows
            ' total += Convert.ToDouble(fila.Cells(7).Value)
            ' Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarEstadosPago()
        btnAgregar.Enabled = True
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        DesbloquearEstado()
        Boton = 1
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnAgregar.Enabled = False
        btnCancelar.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        LimpiarEstado()
        cboObras.Text = lbl_nombre_obra.Text
        BloquearEstado()
    End Sub



    Private Sub dgvEstadoPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstadoPago.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvEstadoPago.Rows(index)
            LimpiarEstado()
            txtIdEstadoPago.Text = selectRow.Cells(0).Value.ToString()
            txtNroEstadoPago.Text = selectRow.Cells(1).Value.ToString()
            cboObras.Text = selectRow.Cells(2).Value.ToString()
            dtFecha.Value = selectRow.Cells(3).Value
            txtNroFactura.Text = selectRow.Cells(4).Value.ToString()
            txtValorObra.Text = selectRow.Cells(5).Value.ToString()
            txtReajuste.Text = selectRow.Cells(6).Value.ToString()
            txtRetenciones.Text = selectRow.Cells(7).Value.ToString()
            txtRetencionesCanjeadas.Text = selectRow.Cells(8).Value.ToString()
            txtMultas.Text = selectRow.Cells(9).Value.ToString()
            txtValorEstadoPago.Text = selectRow.Cells(10).Value.ToString()
            txtValorEstadoPagoNeto.Text = selectRow.Cells(11).Value.ToString()
            txtObrasNeto.Text = selectRow.Cells(12).Value.ToString()
            txtReajusteNeto.Text = selectRow.Cells(13).Value.ToString()
            txtObservaciones.Text = selectRow.Cells(14).Value.ToString()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarEstado()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdEstadoPago.Text <> "" Then
            btnAgregar.Enabled = True
            btnCancelar.Enabled = True
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            DesbloquearEstado()
            Boton = 2
        Else
            MsgBox("Debes seleccionar un registro", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idestadopago As Integer
        If txtIdEstadoPago.Text <> "" Then
            Dim resultado As Integer = MessageBox.Show("¿Desea eliminar este registro?", "caption", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                Try
                    idestadopago = txtIdEstadoPago.Text
                    nue_obra6.Eliminar(idestadopago)
                    dgvFiltroEstadoPagoMandante()
                    LimpiarEstado()
                    Actualizar_dgvEstadosPagoFirmado()
                    actualizar_dgvFacturasAdjunto()
                    cboObras.Text = Nombre_Obra
                    ActualizarCbo()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf resultado = DialogResult.No Then
                MessageBox.Show("Procedimiento cancelado por el usuario")
            End If
        Else
            MsgBox("Debes seleccionar un registro", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        Try
            Dim obra As String
            Dim nro_estadoPago As Integer
            obra = cboObrasPagoFirmado.Text
            nro_estadoPago = cboEstadoPagoFirmado.SelectedValue
            If nro_estadoPago <> Nothing Then
                If nue_obra6.VerificarEstadoPagoExistente(obra, nro_estadoPago) = False Then
                    OpenFileDialog4.FileName = ""
                    If OpenFileDialog4.ShowDialog = DialogResult.OK Then
                        OpenFileDialog4.Title = "Escoje un archivo"
                        TextBox3.Text = OpenFileDialog4.FileName
                        lblNombreArchivo.Text = OpenFileDialog4.SafeFileName
                        My.Computer.Network.UploadFile(TextBox3.Text, "ftp://201.148.105.75/Estado_De_Pago_Mandante/Estados_De_Pago_Firmados" + "/" + cboObrasPagoFirmado.Text + "_" + cboEstadoPagoFirmado.Text + "_" + lblNombreArchivo.Text + "", "cfv@constructorafv.com", "gsolis2013", True, 500)
                        InsertarFtp()

                        Actualizar_dgvEstadosPagoFirmado()
                        LimpiarEstadosPago()
                    Else
                    End If
                    lblNombreArchivo.Text = ""
                    TextBox3.Text = ""
                    OpenFileDialog4.FileName = ""
                Else
                    MsgBox("Número estado pago, ya existente", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Verifique los datos", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs)
        OpenFileDialog4.Title = "Escoje un archivo"
        OpenFileDialog4.ShowDialog()
        TextBox3.Text = OpenFileDialog4.FileName
        lblNombreArchivo.Text = OpenFileDialog4.SafeFileName
    End Sub

    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargar.Click
        Try
            Dim idestadopagofirmado As Integer
            txtIdEstadoPagoFirmado.Text = idestadopagofirmado
            If txtNombreArchivo.Text <> "" Then
                Dim nombreArchivo As String
                nombreArchivo = txtNombreArchivo.Text
                SaveFileDialog3.FileName = txtNombreArchivo.Text
                If SaveFileDialog3.ShowDialog = DialogResult.OK Then
                    SaveFileDialog3.Title = "Escoje la ruta para descargar"
                    SaveFileDialog3.InitialDirectory = "Descargas"
                    lblRutaDescarga.Text = SaveFileDialog3.FileName
                    FTPDownloadFile(lblRutaDescarga.Text + "", "ftp://201.148.105.75/Estado_De_Pago_Mandante/Estados_De_Pago_Firmados" + "/" + txtNombreArchivo.Text + "", "cfv@constructorafv.com", "gsolis2013")
                    lblRutaDescarga.Text = ""
                    SaveFileDialog3.FileName = ""
                Else
                    SaveFileDialog3.FileName = ""
                End If
            Else
                MsgBox("Debe seleccionar un registro", MsgBoxStyle.Exclamation)
                SaveFileDialog3.FileName = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FTPDownloadFile(ByVal downloadpath As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
        'Create a WebClient.
        Dim request As New WebClient()

        ' Confirm the Network credentials based on the user name and password passed in.
        request.Credentials = New NetworkCredential(ftpusername, ftppassword)

        'Read the file data into a Byte array
        Dim bytes() As Byte = request.DownloadData(ftpuri)

        Try
            '  Create a FileStream to read the file into
            Dim DownloadStream As FileStream = IO.File.Create(downloadpath)
            '  Stream this data into the file
            DownloadStream.Write(bytes, 0, bytes.Length)
            '  Close the FileStream
            DownloadStream.Close()
            MsgBox("Archivo guardado en: " + downloadpath.ToString, MsgBoxStyle.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Public Function Descargar(ByVal downloadpath As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)

        Try
            'Create a WebClient.
            Dim request As New WebClient()

            ' Confirm the Network credentials based on the user name and password passed in.
            request.Credentials = New NetworkCredential(ftpusername, ftppassword)

            'Read the file data into a Byte array
            Dim bytes() As Byte = request.DownloadData(ftpuri)
            '  Create a FileStream to read the file into
            Dim DownloadStream As FileStream = IO.File.Create(downloadpath)
            '  Stream this data into the file
            DownloadStream.Write(bytes, 0, bytes.Length)
            '  Close the FileStream
            DownloadStream.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
            Exit Function
        End Try

    End Function

    Private Sub FTPEliminarFile(ByVal downloadpath As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
        'Create a WebClient.
        Dim request As New WebClient()

        ' Confirm the Network credentials based on the user name and password passed in.
        request.Credentials = New NetworkCredential(ftpusername, ftppassword)

        'Read the file data into a Byte array
        Dim bytes() As Byte = request.DownloadData(ftpuri)

        Try
            '  Create a FileStream to read the file into
            Dim DownloadStream As FileStream = IO.File.Create(downloadpath)
            '  Stream this data into the file
            DownloadStream.Write(bytes, 0, bytes.Length)
            '  Close the FileStream
            DownloadStream.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show("Proceso Completo")

    End Sub

    Public Sub InsertarFtp()
        Try
            Dim obra As String
            Dim Estado_Pago_Nro_Estado_Pago As Integer
            Dim adjunto As String
            Dim usuario As String
            Dim fecha As DateTime
            obra = cboObrasPagoFirmado.Text
            Estado_Pago_Nro_Estado_Pago = cboEstadoPagoFirmado.SelectedValue.ToString
            adjunto = obra + "_" + cboEstadoPagoFirmado.Text + "_" + lblNombreArchivo.Text.ToString
            usuario = Nombre_Usuario
            fecha = DateTime.Now
            nue_obra6.InsertarEstadoPagoFirmado(obra, Estado_Pago_Nro_Estado_Pago, adjunto, usuario, fecha)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertarFacturaFTP()
        Try
            Dim obra As String
            Dim nroEstadoPagoAsociado As Integer
            Dim nroFactura As Integer
            Dim adjunto As String
            Dim usuario As String
            Dim fecha As DateTime
            obra = cboObrasFacturasPago.Text
            nroEstadoPagoAsociado = cboEstadoPagoAsociado.SelectedValue.ToString
            nroFactura = txtNroFacturaEstado.Text
            adjunto = obra + "_" + cboEstadoPagoAsociado.Text.ToString + "_" + nroFactura.ToString + "_" + lblAdjuntoFacturas.Text
            usuario = Nombre_Usuario
            fecha = DateTime.Now

            nue_obra6.InsertarFacturaFirmada(obra, nroEstadoPagoAsociado, nroFactura, adjunto, usuario, fecha)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub actualizar_dgvFacturasAdjunto()
        Try
            Dim total As Double = 0
            Dim obrasFiltro As String

            obrasFiltro = cboObrasFacturasPago.Text
            If obrasFiltro = "System.Data.DataRowView" Then
                obrasFiltro = Nombre_Obra
            End If

            Dim fila As DataGridViewRow = New DataGridViewRow()
            dgvFacturasAdjunto.DataSource = nue_obra6.LeerAdjuntoFacturas(obrasFiltro)
            With dgvFacturasAdjunto
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra Adjunto"
                .Columns(2).HeaderCell.Value = "Obra"
                .Columns(2).Visible = False
                .Columns(3).HeaderCell.Value = "N° Estado de Pago Asociado"
                .Columns(4).HeaderCell.Value = "N° Factura"
                .Columns(5).HeaderCell.Value = "Adjunto"
                .Columns(6).HeaderCell.Value = "Usuario"
                .Columns(7).HeaderCell.Value = "Fecha de subida"
                .Columns(8).HeaderCell.Value = "Adjunto"
                .Columns(8).Visible = False

                dgvFacturasAdjunto.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function ActualizarGrid(ByVal obra As String)
        Try
            Dim total As Double = 0
            Dim obrasFiltro As String

            obrasFiltro = cboObrasFacturasPago.Text

            Dim fila As DataGridViewRow = New DataGridViewRow()
            dgvFacturasAdjunto.DataSource = nue_obra6.LeerAdjuntoFacturas(obrasFiltro)
            With dgvFacturasAdjunto
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra"
                .Columns(2).HeaderCell.Value = "N° Estado de Pago Asociado"
                .Columns(3).HeaderCell.Value = "N° Factura"
                .Columns(4).HeaderCell.Value = "Adjunto"
                .Columns(5).HeaderCell.Value = "Usuario"
                .Columns(6).HeaderCell.Value = "Fecha de subida"
                .Columns(7).HeaderCell.Value = "Adjunto"
                .Columns(7).Visible = False
                dgvFacturasAdjunto.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFacturasAdjunto.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Sub Actualizar_dgvEstadosPagoFirmado()
        Try
            Dim total As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim obraFiltro As String
            obraFiltro = cboObrasPagoFirmado.Text
            If obraFiltro = "System.Data.DataRowView" Then
                obraFiltro = Nombre_Obra
            End If

            dgvAdjuntosPagosFirmados.DataSource = nue_obra6.LeerAdjuntoPagosFirmados(obraFiltro)
            With dgvAdjuntosPagosFirmados
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(6).HeaderCell.Value = "Obra"
                .Columns(2).HeaderCell.Value = "Nro Estado de Pago"
                .Columns(3).HeaderCell.Value = "Adjunto"
                .Columns(3).Visible = False
                .Columns(4).HeaderCell.Value = "Usuario"
                .Columns(5).HeaderCell.Value = "Fecha de subida"
                'Obra que realiza el filtro para realizar la conexión con el left Join
                .Columns(1).HeaderCell.Value = "Obras"
                .Columns(1).Visible = False
                .Columns(7).HeaderCell.Value = "Adjunto"
                dgvAdjuntosPagosFirmados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarAdjunto_Click(sender As Object, e As EventArgs) Handles btnEliminarAdjunto.Click
        If txtIdEstadoPagoFirmado.Text <> "" And txtNombreObraArchivo.Text <> "" Then
            Dim idestadopagofirmado As Integer
            Dim obra As String
            Dim Estado_Pago_Nro_Estado_Pago As String
            Dim adjunto As String
            Dim nombreArchivo As String
            obra = txtNombreObraArchivo.Text
            idestadopagofirmado = txtIdEstadoPagoFirmado.Text
            Estado_Pago_Nro_Estado_Pago = txtNroEstadoPagoArchivo.Text
            nombreArchivo = txtNombreArchivo.Text
            adjunto = obra + "_" + Estado_Pago_Nro_Estado_Pago.ToString + "_" + nombreArchivo

            Dim resultado As Integer = MessageBox.Show("¿Desea eliminar este adjunto?", "caption", MessageBoxButtons.YesNo)
            Dim mReq As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://201.148.105.75/Estado_De_Pago_Mandante/Estados_De_Pago_Firmados" + "/" + txtNombreArchivo.Text + ""), System.Net.FtpWebRequest)

            If resultado = DialogResult.Yes Then
                Try
                    nue_obra6.EliminarAdjunto(idestadopagofirmado)
                    mReq.Credentials = New System.Net.NetworkCredential("cfv@constructorafv.com", "gsolis2013")
                    mReq.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
                    mReq.GetResponse()
                    LimpiarEstadosPago()
                    Actualizar_dgvEstadosPagoFirmado()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf resultado = DialogResult.No Then
            End If
        Else
            MsgBox("Debe seleccionar un registro", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Function Eliminar(ByVal archivo As String)
        Try
            Dim mReq As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://201.148.105.75/Estado_De_Pago_Mandante/Estados_De_Pago_Firmados" + "/" + archivo + ""), System.Net.FtpWebRequest)
            mReq.Credentials = New System.Net.NetworkCredential("cfv@constructorafv.com", "gsolis2013")
            mReq.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
            mReq.GetResponse()
            Return True
        Catch ex As Exception
            ex.Message.ToString()
            Return False
        End Try
    End Function
    Private Sub btnSubirFacturasAdjuntas_Click(sender As Object, e As EventArgs) Handles btnSubirFacturasAdjuntas.Click
        Try

            Dim obra As String
            Dim nro_estadoPago As String


            If txtNroFacturaEstado.Text <> "" And cboEstadoPagoAsociado.SelectedValue <> Nothing Then
                obra = cboObrasFacturasPago.Text
                nro_estadoPago = cboEstadoPagoAsociado.SelectedValue.ToString
                If nue_obra6.VerificarFacturaFirmadaExistente(obra, nro_estadoPago) = False Then
                    OpenFileDialog7.FileName = ""
                    If OpenFileDialog7.ShowDialog = DialogResult.OK Then
                        OpenFileDialog7.Title = "Escoje un archivo"
                        txtSubidaFacturas.Text = OpenFileDialog7.FileName
                        lblAdjuntoFacturas.Text = OpenFileDialog7.SafeFileName
                        My.Computer.Network.UploadFile(txtSubidaFacturas.Text, "ftp://201.148.105.75/Estado_De_Pago_Mandante/Facturas_Firmadas" + "/" + cboObrasFacturasPago.Text + "_" + cboEstadoPagoAsociado.Text + "_" + txtNroFacturaEstado.Text + "_" + lblAdjuntoFacturas.Text, "cfv@constructorafv.com", "gsolis2013", True, 500)
                        InsertarFacturaFTP()
                        actualizar_dgvFacturasAdjunto()
                        LimpiarFacturasFirmada()
                        OpenFileDialog7.FileName = ""
                    Else
                        LimpiarFacturasFirmada()
                        OpenFileDialog7.FileName = ""
                    End If
                Else
                    MsgBox("Factura ya ingresada", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Verifique los datos ingresados", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LimpiarFacturasFirmada()
        txtInfoObra.Text = ""
        txtInfoNroEstadoPago.Text = ""
        txtInfoNroFactura.Text = ""
        txtInfoFechaAdjunto.Text = ""
        txtAdjuntoFacturasFirmadas.Text = ""
        txtIdEstadoPagoFacturasFirmadas.Text = ""
        txtNroFacturaEstado.Text = ""
        txtSubidaFacturas.Text = ""
        lblAdjuntoFacturas.Text = ""

    End Sub


    Private Sub btnEliminarFacturasAdjuntas_Click(sender As Object, e As EventArgs) Handles btnEliminarFacturasAdjuntas.Click
        Try
            If txtIdEstadoPagoFacturasFirmadas.Text <> "" Then
                Dim idEstadoPagoFacturasFirmadas As Integer
                Dim resultado As Integer = MessageBox.Show("¿Desea eliminar este adjunto?", "", MessageBoxButtons.YesNo)
                Dim mReq As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://201.148.105.75/Estado_De_Pago_Mandante/Facturas_Firmadas/" + txtAdjuntoFacturasFirmadas.Text), System.Net.FtpWebRequest)

                If resultado = DialogResult.Yes Then
                    idEstadoPagoFacturasFirmadas = txtIdEstadoPagoFacturasFirmadas.Text
                    nue_obra6.EliminarAdjuntoFacturasFirmadas(idEstadoPagoFacturasFirmadas)
                    mReq.Credentials = New System.Net.NetworkCredential("cfv@constructorafv.com", "gsolis2013")
                    mReq.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
                    mReq.GetResponse()
                    actualizar_dgvFacturasAdjunto()
                    LimpiarFacturasFirmada()
                ElseIf resultado = DialogResult.No Then
                End If
            Else
                MsgBox("Debe seleccionar un archivo", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDescargarFacturasAdjuntas_Click(sender As Object, e As EventArgs) Handles btnDescargarFacturasAdjuntas.Click
        Try
            If txtIdEstadoPagoFacturasFirmadas.Text <> "" Then
                SaveFileDialog3.FileName = txtAdjuntoFacturasFirmadas.Text
                If SaveFileDialog3.ShowDialog = DialogResult.OK Then
                    SaveFileDialog3.Title = "Escoje la ruta para descargar"
                    SaveFileDialog3.InitialDirectory = "Descargas"
                    lblAdjuntoFacturas.Text = SaveFileDialog3.FileName
                    FTPDownloadFile(lblAdjuntoFacturas.Text + "", "ftp://201.148.105.75/Estado_De_Pago_Mandante/Facturas_Firmadas/" + txtAdjuntoFacturasFirmadas.Text, "cfv@constructorafv.com", "gsolis2013")
                    SaveFileDialog3.FileName = ""
                    LimpiarFacturasFirmada()
                    lblAdjuntoFacturas.Text = ""
                End If
                SaveFileDialog3.FileName = ""
            Else
                MsgBox("Debes seleccionar un registro", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        num_tab = 0
        frm_menu_principal.Show()
        Me.Close()
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        Me.Close()
    End Sub

    Private Sub cboObras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboObras.KeyPress
        e.Handled = True
    End Sub
    Private Sub cboObrasFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboObrasFiltro.SelectedIndexChanged
        dgvFiltroEstadoPagoMandante()
        LeerRetencion()
        ObraFiltro = cboObrasFiltro.Text
        ActualizarCbo()
    End Sub
    Private Sub ActualizarCbo()
        cboObrasPagoFirmado.Text = ObraFiltro
        cboObrasPagoFirmado.Text = ObraFiltro
        cboObrasFacturasPago.Text = ObraFiltro
        cboObras.Text = ObraFiltro

        cboEstadoPagoFirmado.DataSource = nue_obra6.LeerNroEstadoPago(obraNroEstadoPago)
        cboEstadoPagoFirmado.DisplayMember = "Nro_Estado_Pago"
        cboEstadoPagoFirmado.ValueMember = "Id_Estado_Pago"

        cboEstadoPagoAsociado.DataSource = nue_obra6.LeerNroEstadoPagoFactura(obraFacturaFirmada)
        cboEstadoPagoAsociado.DisplayMember = "Nro_Estado_Pago"
        cboEstadoPagoAsociado.ValueMember = "Id_Estado_Pago"

    End Sub

    Private Sub dgvFiltroEstadoPagoMandante()
        Try
            Dim total As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim obraFiltro As String
            obraFiltro = cboObrasFiltro.Text
            If obraFiltro = "System.Data.DataRowView" Then
                cboObrasFiltro.Text = Nombre_Obra
            End If

            dgvEstadoPago.DataSource = nue_obra6.Leer(obraFiltro)
            With dgvEstadoPago
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Nro Estado Pago"
                .Columns(2).HeaderCell.Value = "Obra"
                .Columns(3).HeaderCell.Value = "Fecha"
                .Columns(4).HeaderCell.Value = "N° Factura"
                .Columns(5).HeaderCell.Value = "Obras ($)"
                .Columns(6).HeaderCell.Value = "Reajuste ($)"
                .Columns(7).HeaderCell.Value = "Retenciones ($)"
                .Columns(8).HeaderCell.Value = "Retenciones Canjeadas ($)"
                .Columns(9).HeaderCell.Value = "Multas ($)"
                .Columns(10).HeaderCell.Value = "Valor Estado de Pago ($)"
                .Columns(11).HeaderCell.Value = "Valor Estado de Pago Neto ($)"
                .Columns(12).HeaderCell.Value = "Obras Neto ($)"
                .Columns(13).HeaderCell.Value = "Reajuste Neto ($)"
                .Columns(14).HeaderCell.Value = "Observaciones"

            End With

            dgvEstadoPago.Columns(5).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(6).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(7).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(8).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(9).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(10).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(11).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(12).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(13).DefaultCellStyle.Format = "C"
            dgvEstadoPago.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvEstadoPago.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvEstadoPago.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvEstadoPago.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvEstadoPago.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvEstadoPago.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvEstadoPago.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvEstadoPago.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            'Metodo para contar el total de una fila
            'For Each fila In dgvEstadoPago.Rows
            ' total += Convert.ToDouble(fila.Cells(7).Value)
            ' Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboObrasFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboObrasFiltro.KeyPress
        e.Handled = True
    End Sub

    Private Sub dgvEstadoPago_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstadoPago.CellContentDoubleClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvEstadoPago.Rows(index)
            LimpiarEstado()
            txtIdEstadoPago.Text = selectRow.Cells(0).Value.ToString()
            txtNroEstadoPago.Text = selectRow.Cells(1).Value.ToString()
            cboObras.Text = selectRow.Cells(2).Value.ToString()
            dtFecha.Value = selectRow.Cells(3).Value
            txtNroFactura.Text = selectRow.Cells(4).Value.ToString()
            txtValorObra.Text = selectRow.Cells(5).Value.ToString()
            txtReajuste.Text = selectRow.Cells(6).Value.ToString()
            txtRetenciones.Text = selectRow.Cells(7).Value.ToString()
            txtRetencionesCanjeadas.Text = selectRow.Cells(8).Value.ToString()
            txtMultas.Text = selectRow.Cells(9).Value.ToString()
            txtValorEstadoPago.Text = selectRow.Cells(10).Value.ToString()
            txtValorEstadoPagoNeto.Text = selectRow.Cells(11).Value.ToString()
            txtObrasNeto.Text = selectRow.Cells(12).Value.ToString()
            txtReajusteNeto.Text = selectRow.Cells(13).Value.ToString()
            txtObservaciones.Text = selectRow.Cells(14).Value.ToString()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgvEstadoPago_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEstadoPago.CellMouseClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvEstadoPago.Rows(index)
            LimpiarEstado()
            txtIdEstadoPago.Text = selectRow.Cells(0).Value.ToString()
            txtNroEstadoPago.Text = selectRow.Cells(1).Value.ToString()
            cboObras.Text = selectRow.Cells(2).Value.ToString()
            dtFecha.Value = selectRow.Cells(3).Value
            txtNroFactura.Text = selectRow.Cells(4).Value.ToString()
            txtValorObra.Text = selectRow.Cells(5).Value.ToString()
            txtReajuste.Text = selectRow.Cells(6).Value.ToString()
            txtRetenciones.Text = selectRow.Cells(7).Value.ToString()
            txtRetencionesCanjeadas.Text = selectRow.Cells(8).Value.ToString()
            txtMultas.Text = selectRow.Cells(9).Value.ToString()
            txtValorEstadoPago.Text = selectRow.Cells(10).Value.ToString()
            txtValorEstadoPagoNeto.Text = selectRow.Cells(11).Value.ToString()
            txtObrasNeto.Text = selectRow.Cells(12).Value.ToString()
            txtReajusteNeto.Text = selectRow.Cells(13).Value.ToString()
            txtObservaciones.Text = selectRow.Cells(14).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cboObrasPagoFirmado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboObrasPagoFirmado.SelectedIndexChanged

        obraNroEstadoPago = cboObrasPagoFirmado.Text.ToString
        If obraNroEstadoPago = "System.Data.DataRowView" Then
            obraNroEstadoPago = Nombre_Obra
        End If
        cboEstadoPagoFirmado.DataSource = nue_obra6.LeerNroEstadoPago(obraNroEstadoPago)
        cboEstadoPagoFirmado.DisplayMember = "Nro_Estado_Pago"
        cboEstadoPagoFirmado.ValueMember = "Id_Estado_Pago"
        Actualizar_dgvEstadosPagoFirmado()


    End Sub

    Private Sub dgvFiltroEstadosPagoFirmado()
        Try
            Dim total As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim obraFiltro As String
            obraFiltro = cboObrasPagoFirmado.Text

            dgvAdjuntosPagosFirmados.DataSource = nue_obra6.LeerEstadosPagoFirmadoObra(obraFiltro)
            With dgvAdjuntosPagosFirmados
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(1).HeaderCell.Value = "Obra"
                .Columns(2).HeaderCell.Value = "Nro Estado Pago"
                .Columns(3).HeaderCell.Value = "Adjunto"
                .Columns(4).HeaderCell.Value = "Usuario"
                .Columns(5).HeaderCell.Value = "Fecha"

            End With
            dgvAdjuntosPagosFirmados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAdjuntosPagosFirmados.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAdjuntosPagosFirmados.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAdjuntosPagosFirmados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAdjuntosPagosFirmados.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvAdjuntosPagosFirmados.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            'Metodo para contar el total de una fila
            'For Each fila In dgvEstadoPago.Rows
            ' total += Convert.ToDouble(fila.Cells(7).Value)
            ' Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboObrasFacturasPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboObrasFacturasPago.SelectedIndexChanged

        obraFacturaFirmada = cboObrasFacturasPago.Text.ToString
        If cboObrasFacturasPago.Text.ToString = "System.Data.DataRowView" Then
            obraFacturaFirmada = Nombre_Obra
        End If
        cboEstadoPagoAsociado.DataSource = nue_obra6.LeerNroEstadoPagoFactura(obraFacturaFirmada)
        cboEstadoPagoAsociado.DisplayMember = "Nro_Estado_Pago"
        cboEstadoPagoAsociado.ValueMember = "Id_Estado_Pago"

        actualizar_dgvFacturasAdjunto()
    End Sub

    Private Sub txtNroEstadoPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroEstadoPago.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtNroFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroFactura.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtValorObra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorObra.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números
        Try
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else : e.Handled = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cboObrasPagoFirmado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboObrasPagoFirmado.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboEstadoPagoFirmado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboEstadoPagoFirmado.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboObrasFacturasPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboObrasFacturasPago.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboEstadoPagoAsociado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboEstadoPagoAsociado.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtReajuste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReajuste.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtRetenciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRetenciones.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtRetencionesCanjeadas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRetencionesCanjeadas.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtMultas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMultas.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtValorEstadoPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorEstadoPago.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtValorEstadoPagoNeto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorEstadoPagoNeto.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtObrasNeto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObrasNeto.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtReajusteNeto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReajusteNeto.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub txtNroFacturaEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroFacturaEstado.KeyPress
        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Private Sub dgvAdjuntosPagosFirmados_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAdjuntosPagosFirmados.CellMouseClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvAdjuntosPagosFirmados.Rows(index)
            txtIdEstadoPagoFirmado.Text = selectRow.Cells(0).Value.ToString()
            If txtIdEstadoPagoFirmado.Text <> "" Then
                txtNombreObraArchivo.Text = selectRow.Cells(1).Value.ToString()
                txtNroEstadoPagoArchivo.Text = selectRow.Cells(2).Value.ToString()
                txtNombreArchivo.Text = selectRow.Cells(3).Value.ToString()
                txtUsuarioArchivo.Text = selectRow.Cells(4).Value.ToString()
                txtFechaAdjuntadoArchivo.Text = selectRow.Cells(5).Value
            Else
                MsgBox("No se encuentra registro de adjuntos", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub dgvFacturasAdjunto_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvFacturasAdjunto.CellMouseClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvFacturasAdjunto.Rows(index)

            txtIdEstadoPagoFacturasFirmadas.Text = selectRow.Cells(0).Value.ToString()
            If txtIdEstadoPagoFacturasFirmadas.Text <> "" Then
                txtInfoObra.Text = selectRow.Cells(1).Value.ToString()
                txtInfoNroEstadoPago.Text = selectRow.Cells(3).Value.ToString()
                txtInfoNroFactura.Text = selectRow.Cells(4).Value.ToString()
                txtAdjuntoFacturasFirmadas.Text = selectRow.Cells(8).Value.ToString()
                txtInfoFechaAdjunto.Text = selectRow.Cells(7).Value
            Else
                MsgBox("No se encuentra registro de adjuntos", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class