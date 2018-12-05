Imports Microsoft.Office.Interop.Word 'Control de office
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports System.Net
Imports clases

Public Class frm_menu_principal_VII
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

    Sub RellenarCboObras()
        cboObrasModificaciones.DataSource = nue_obra5.listar5(id_obra)
        cboObrasModificaciones.DisplayMember = "nombre_faena"
        cboObrasModificaciones.ValueMember = "Id_identificacion"
        cboObrasModificacion.Text = Module1.Nombre_Obra

        cboObrasContratoOriginal.DataSource = nue_obra5.listar5(id_obra)
        cboObrasContratoOriginal.DisplayMember = "nombre_faena"
        cboObrasContratoOriginal.ValueMember = "Id_identificacion"
        cboObrasContratoOriginal.Text = Module1.Nombre_Obra

        cboObrasModificacion.DataSource = nue_obra5.listar5(id_obra)
        cboObrasModificacion.DisplayMember = "nombre_faena"
        cboObrasModificacion.ValueMember = "Id_identificacion"
        cboObrasModificacion.Text = Module1.Nombre_Obra

        cboObrasListadoFiltro.DataSource = nue_obra5.listar5(id_obra)
        cboObrasListadoFiltro.DisplayMember = "nombre_faena"
        cboObrasListadoFiltro.ValueMember = "Id_identificacion"
        cboObrasListadoFiltro.Text = Module1.Nombre_Obra

    End Sub


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
        'Se bloquean las cajas de texto
        BloquearListado()
        RellenarCboObras()
        Actualizar_dgvModificacion()
        Actualizar_dgvContrato()
        actualizar_dgvListado()

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
            TabControl11.SelectedTab = TabPage7
            TabControl6.SelectedIndex = 0
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 2 Then
            TabControl11.SelectedTab = TabPage7
            TabControl6.SelectedIndex = 1
            Me.TabPage52.Parent = Nothing
        ElseIf num_tab = 3 Then
            TabControl11.SelectedTab = TabPage7
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

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim idModificaciones As Integer
            Dim obras As String
            Dim nromodificacion As Integer
            Dim fecha As DateTime
            Dim aumentoObra As Integer
            Dim disminucionObra As Integer
            Dim obraExtraordinaria As Integer
            Dim aumentoDisminucion As Integer
            Dim retencion As Integer
            Dim proforma As Integer

            obras = cboObrasModificaciones.Text
            nromodificacion = txtNroModificacion.Text
            fecha = dtFecha.Value.Date
            aumentoObra = txtAumentoObra.Text
            disminucionObra = txtDisminucionObra.Text
            obraExtraordinaria = txtObraExtraordinaria.Text
            aumentoDisminucion = txtAumentoDisminucion.Text
            retencion = txtRetenciones.Text
            proforma = txtProformas.Text

            If TipoBoton = 1 Then
                If txtNroModificacion.Text >= 0 Or txtAumentoObra.Text >= 0 Or txtDisminucionObra.Text >= 0 Or txtObraExtraordinaria.Text >= 0 Or txtAumentoDisminucion.Text >= 0 Then
                    If modificaciones.RegistroExistente(obras, nromodificacion) = False Then
                        modificaciones.InsertarlistadoModificaciones(obras, nromodificacion, fecha, aumentoObra, disminucionObra, obraExtraordinaria, aumentoDisminucion, retencion, proforma)

                        actualizar_dgvListado()
                        LimpiarListado()
                        BloquearListado()
                        btnAgregar.Enabled = False
                        btnCancelar.Enabled = False
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnEliminar.Enabled = True
                    Else
                        MsgBox("Registro ya existente", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                If txtNroModificacion.Text > 0 Or txtAumentoObra.Text > 0 Or txtDisminucionObra.Text > 0 Or txtObraExtraordinaria.Text > 0 Or txtAumentoDisminucion.Text > 0 Then
                    If modificaciones.RegistroExistente(obras, nromodificacion) = True Then
                        idModificaciones = txtIdModificaciones.Text
                        modificaciones.ModificarListado(idModificaciones, obras, nromodificacion, fecha, aumentoObra, disminucionObra, obraExtraordinaria, aumentoDisminucion, retencion, proforma)

                        actualizar_dgvListado()
                        LimpiarListado()
                        BloquearListado()
                        btnAgregar.Enabled = False
                        btnCancelar.Enabled = False
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnEliminar.Enabled = True
                    Else
                        MsgBox("Registro ya existente", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Verifique los datos ingresados", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub actualizar_dgvListado()
        Try
            Dim total As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim obrasFiltrolistado As String
            obrasFiltrolistado = cboObrasListadoFiltro.Text
            dgvListadoModificaciones.DataSource = modificaciones.LeerDgvListadoModificaciones(obrasFiltrolistado)
            With dgvListadoModificaciones
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra"
                .Columns(2).HeaderCell.Value = "N° Modificación"
                .Columns(3).HeaderCell.Value = "Fecha"
                .Columns(4).HeaderCell.Value = "Aumento Obra ($)"
                .Columns(5).HeaderCell.Value = "Disminución Obra ($)"
                .Columns(6).HeaderCell.Value = "Obra Extraordinaria ($)"
                .Columns(7).HeaderCell.Value = "Aumento/Disminución de Plazo"
                .Columns(8).HeaderCell.Value = "Aumento/Disminución Retenciones"
                .Columns(9).HeaderCell.Value = "Aumento/Disminución Proformas"


            End With
            dgvListadoModificaciones.Columns(4).DefaultCellStyle.Format = "C"
            dgvListadoModificaciones.Columns(5).DefaultCellStyle.Format = "C"
            dgvListadoModificaciones.Columns(6).DefaultCellStyle.Format = "C"
            dgvListadoModificaciones.Columns(7).DefaultCellStyle.Format = "C"
            dgvListadoModificaciones.Columns(8).DefaultCellStyle.Format = "C"
            dgvListadoModificaciones.Columns(9).DefaultCellStyle.Format = "C"

            'Metodo para contar el total de una fila
            'For Each fila In dgvEstadoPago.Rows
            ' total += Convert.ToDouble(fila.Cells(7).Value)
            ' Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        TipoBoton = 1
        btnAgregar.Enabled = True
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False

        DesbloquearListado()
    End Sub

    Private Sub DesbloquearListado()
        cboObrasModificaciones.Enabled = True
        txtNroModificacion.Enabled = True
        dtFecha.Enabled = True
        txtAumentoObra.Enabled = True
        txtDisminucionObra.Enabled = True
        txtObraExtraordinaria.Enabled = True
        txtAumentoDisminucion.Enabled = True
        txtRetenciones.Enabled = True
        txtProformas.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnAgregar.Enabled = False
        btnCancelar.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        LimpiarListado()
        cboObrasModificaciones.Text = lbl_nombre_obra.Text
        BloquearListado()
    End Sub

    Private Sub LimpiarListado()
        txtNroModificacion.Text = ""
        txtAumentoObra.Text = ""
        txtDisminucionObra.Text = ""
        txtObraExtraordinaria.Text = ""
        txtAumentoDisminucion.Text = ""
        txtRetenciones.Text = ""
        txtProformas.Text = ""
    End Sub

    Private Sub BloquearListado()
        cboObrasModificaciones.Enabled = False
        txtNroModificacion.Enabled = False
        dtFecha.Enabled = False
        txtAumentoObra.Enabled = False
        txtDisminucionObra.Enabled = False
        txtObraExtraordinaria.Enabled = False
        txtAumentoDisminucion.Enabled = False
        txtRetenciones.Enabled = False
        txtProformas.Enabled = False
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs)
        OpenFileDialog4.Title = "Escoje un archivo"
        OpenFileDialog4.ShowDialog()
        TextBox3.Text = OpenFileDialog4.FileName
        lblNombreArchivo.Text = OpenFileDialog4.SafeFileName
    End Sub

    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargar.Click
        Try
            lblRutaDescarga.Text.ToString()
            If txtidContratoOriginal.Text <> "" Then
                SaveFileDialog3.FileName = txtNombreArchivo.Text
                If SaveFileDialog3.ShowDialog = DialogResult.OK Then
                    SaveFileDialog3.Title = "Escoje la ruta para descargar"
                    SaveFileDialog3.InitialDirectory = "Descargas"
                    lblRutaDescarga.Text = SaveFileDialog3.FileName

                    FTPDownloadFile(lblRutaDescarga.Text + "", "ftp://201.148.105.75/Contrato_Original_Modificaciones_Obras/Contrato_Original/" + txtNombreArchivo.Text + "", "cfv@constructorafv.com", "gsolis2013")
                    lblRutaDescarga.Text = ""
                    SaveFileDialog3.FileName = ""
                End If
            Else
                MsgBox("Debe seleccionar un registro", MsgBoxStyle.Exclamation)
                lblRutaDescarga.Text = ""
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
            MessageBox.Show("Archivo descargado")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try



    End Sub

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

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        num_tab = 0
        frm_menu_principal.Show()
        Me.Close()
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        Me.Close()
    End Sub

    Private Sub cboObras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboObrasModificaciones.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idModificaciones As Integer
        If txtNroModificacion.Text <> "" Or txtAumentoObra.Text <> "" Or txtDisminucionObra.Text <> "" Or txtObraExtraordinaria.Text <> "" Or txtAumentoDisminucion.Text <> "" Then
            Dim resultado As Integer = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "caption", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                Try
                    idModificaciones = txtIdModificaciones.Text
                    modificaciones.Eliminar(idModificaciones)

                    actualizar_dgvListado()
                    LimpiarListado()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf resultado = DialogResult.No Then
            End If
        Else
            MsgBox("Debe selecionar un registro antes de eliminar", MsgBoxStyle.Exclamation)
        End If
    End Sub

    'Metodo prueba Eliminar
    Public Function Eliminar(ByVal Modificacion As Integer)
        Try
            modificaciones.Eliminar(Modificacion)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub dgvListadoModificaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoModificaciones.CellContentClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvListadoModificaciones.Rows(index)
            txtIdModificaciones.Text = selectRow.Cells(0).Value.ToString()
            cboObrasModificaciones.Text = selectRow.Cells(1).Value.ToString()
            txtNroModificacion.Text = selectRow.Cells(2).Value.ToString()
            dtFecha.Value = selectRow.Cells(3).Value
            txtAumentoObra.Text = selectRow.Cells(4).Value.ToString()
            txtDisminucionObra.Text = selectRow.Cells(5).Value.ToString()
            txtObraExtraordinaria.Text = selectRow.Cells(6).Value.ToString()
            txtAumentoDisminucion.Text = selectRow.Cells(7).Value.ToString()
            txtRetenciones.Text = selectRow.Cells(8).Value.ToString()
            txtProformas.Text = selectRow.Cells(9).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgvListadoModificaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoModificaciones.CellContentDoubleClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvListadoModificaciones.Rows(index)
            txtIdModificaciones.Text = selectRow.Cells(0).Value.ToString()
            cboObrasModificaciones.Text = selectRow.Cells(1).Value.ToString()
            txtNroModificacion.Text = selectRow.Cells(2).Value.ToString()
            dtFecha.Value = selectRow.Cells(3).Value
            txtAumentoObra.Text = selectRow.Cells(4).Value.ToString()
            txtDisminucionObra.Text = selectRow.Cells(5).Value.ToString()
            txtObraExtraordinaria.Text = selectRow.Cells(6).Value.ToString()
            txtAumentoDisminucion.Text = selectRow.Cells(7).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        TipoBoton = 2

        If txtNroModificacion.Text <> "" Or txtAumentoObra.Text <> "" Or txtDisminucionObra.Text <> "" Or txtObraExtraordinaria.Text <> "" Or txtAumentoDisminucion.Text <> "" Then
            DesbloquearListado()
            btnAgregar.Enabled = True
            btnCancelar.Enabled = True
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        Else
            MsgBox("Debe seleccionar un registro", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub dgvListadoModificaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvListadoModificaciones.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        Try
            Dim obras As String
            Dim adjunto As String
            OpenFileDialog6.FileName = ""
            If OpenFileDialog6.ShowDialog = DialogResult.OK Then
                OpenFileDialog6.Title = "Escoje un archivo"
                TextBox3.Text = OpenFileDialog6.FileName
                lblNombreArchivo.Text = OpenFileDialog6.SafeFileName

                obras = cboObrasContratoOriginal.Text
                adjunto = obras + "_" + "Contrato_Original.pdf"
                If lblNombreArchivo.Text <> "" Then
                    If modificaciones.RegistroAdjuntoContratoExistente(adjunto, obras) = False Then
                        InsertarFtpContrato()
                        My.Computer.Network.UploadFile(TextBox3.Text, "ftp://201.148.105.75/Contrato_Original_Modificaciones_Obras/Contrato_Original/" + adjunto, "cfv@constructorafv.com", "gsolis2013", True, 500)
                        Actualizar_dgvContrato()
                        TextBox3.Text = ""
                        lblNombreArchivo.Text = ""
                        OpenFileDialog6.Reset()
                        Actualizar_dgvContrato()
                    Else
                        MsgBox("Ya existe un contrato original adjuntado", MsgBoxStyle.Information)
                    End If
                Else
                    TextBox3.Text = ""
                    lblNombreArchivo.Text = ""
                    OpenFileDialog6.Reset()
                End If
            End If
            TextBox3.Text = ""
            lblNombreArchivo.Text = ""
            OpenFileDialog6.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
            OpenFileDialog6.Reset()
        End Try
    End Sub

    Private Sub Actualizar_dgvContrato()
        Try
            'Dim total As Double = 0
            'Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim obra As String
            obra = cboObrasContratoOriginal.Text
            dgvContratoOriginal.DataSource = Contrato.LeerDgvContrato(obra)
            With dgvContratoOriginal
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra"
                .Columns(2).HeaderCell.Value = "Adjunto"
                .Columns(3).HeaderCell.Value = "Usuario"
                .Columns(4).HeaderCell.Value = "Fecha"
                .Columns(5).HeaderCell.Value = "Adjunto"
                .Columns(5).Visible = False
            End With
            dgvContratoOriginal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvContratoOriginal.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvContratoOriginal.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvContratoOriginal.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvContratoOriginal.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells



            'Metodo para contar el total de una fila
            'For Each fila In dgvEstadoPago.Rows
            ' total += Convert.ToDouble(fila.Cells(7).Value)
            ' Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertarFtpContrato()
        Try
            Dim obra As String
            Dim adjunto As String
            Dim usuario As String
            Dim fecha As DateTime
            obra = cboObrasContratoOriginal.Text
            adjunto = obra.ToString + "_" + "Contrato_Original.pdf"
            usuario = Nombre_Usuario
            fecha = DateTime.Now
            Contrato.InsertarIngresodeContratoOriginal(obra, adjunto, usuario, fecha)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarAdjunto_Click(sender As Object, e As EventArgs) Handles btnEliminarAdjunto.Click
        If txtidContratoOriginal.Text <> "" Then
            Dim id_ContratoOriginal As Integer
            Dim resultado As Integer = MessageBox.Show("¿Desea eliminar este adjunto?", "caption", MessageBoxButtons.YesNo)
            Dim mReq As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://201.148.105.75/Contrato_Original_Modificaciones_Obras/Contrato_Original/" + txtNombreArchivo.Text), System.Net.FtpWebRequest)
            If resultado = DialogResult.Yes Then
                Try
                    mReq.Credentials = New System.Net.NetworkCredential("cfv@constructorafv.com", "gsolis2013")
                    mReq.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
                    mReq.GetResponse()
                    id_ContratoOriginal = txtidContratoOriginal.Text
                    Contrato.EliminarContrato(id_ContratoOriginal)

                    Actualizar_dgvContrato()
                    LimpiarContrato()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf resultado = DialogResult.No Then
                MessageBox.Show("Procedimiento cancelado por el usuario")
            End If
        Else
            MsgBox("Debe seleccionar un archivo", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub LimpiarContrato()
        txtidContratoOriginal.Text = ""
        txtNombreObraArchivo.Text = ""
        txtNombreArchivo.Text = ""
        txtUsuarioArchivo.Text = ""
        txtFechaAdjuntadoArchivo.Text = ""
        TextBox3.Text = ""
        lblNombreArchivo.Text = ""
    End Sub

    Private Sub btnSubirFtp_Click(sender As Object, e As EventArgs) Handles btnSubirFtp.Click
        Try
            If cboObrasModificacion.SelectedValue <> Nothing And cboNroModificacionContrato.SelectedValue <> Nothing Then
                Dim obra As String
                Dim nroModificacion As Integer
                obra = cboObrasModificacion.Text
                nroModificacion = cboNroModificacionContrato.SelectedValue
                OpenFileDialog8.FileName = ""
                If modificaciones.RegistroExistenteModificaciones(obra, nroModificacion) = False Then
                    If OpenFileDialog8.ShowDialog = DialogResult.OK Then
                        OpenFileDialog8.Title = "Escoje un archivo"
                        TextBox9.Text = OpenFileDialog8.FileName
                        lblNombreArchivoModificaciones.Text = OpenFileDialog8.SafeFileName
                        InsertarFtpModificaciones()
                        My.Computer.Network.UploadFile(TextBox9.Text, "ftp://201.148.105.75/Contrato_Original_Modificaciones_Obras/Modificaciones/" + obra.ToString + "_" + cboNroModificacionContrato.Text + "_" + lblNombreArchivoModificaciones.Text, "cfv@constructorafv.com", "gsolis2013", True, 500)
                        Actualizar_dgvModificacion()
                        OpenFileDialog8.FileName = ""
                        TextBox9.Text = ""
                        lblNombreArchivoModificaciones.Text = ""
                    End If
                Else
                    MsgBox("Registro ya existente", MsgBoxStyle.Exclamation)
                    OpenFileDialog8.FileName = ""
                    TextBox9.Text = ""
                    lblNombreArchivoModificaciones.Text = ""
                    Actualizar_dgvModificacion()
                End If
            Else
                MsgBox("Verifique los datos", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Actualizar_dgvModificacion()
        Try
            Dim fila As DataGridViewRow = New DataGridViewRow()
            DgvModificaciones.DataSource = modificacionesIngresos.LeerDgvModificaciones(cboObrasModificacion.Text)
            With DgvModificaciones
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra Adjunto"
                .Columns(2).HeaderCell.Value = "N° Modificación"
                .Columns(3).HeaderCell.Value = "Adjunto"
                .Columns(3).Visible = False
                .Columns(4).HeaderCell.Value = "Usuario"
                .Columns(5).HeaderCell.Value = "Fecha de subida"
                .Columns(6).HeaderCell.Value = "Adjunto"
                .Columns(7).HeaderCell.Value = "Obra"
                .Columns(7).Visible = False
                DgvModificaciones.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DgvModificaciones.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DgvModificaciones.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DgvModificaciones.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DgvModificaciones.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertarFtpModificaciones()
        Try
            Dim obra As String
            Dim nro_modificacion As Integer
            Dim adjunto As String
            Dim usuario As String
            Dim fecha As DateTime


            obra = cboObrasModificacion.Text
            nro_modificacion = cboNroModificacionContrato.SelectedValue
            adjunto = obra.ToString + "_" + cboNroModificacionContrato.Text + "_" + lblNombreArchivoModificaciones.Text
            usuario = Nombre_Usuario
            fecha = DateTime.Now

            modificacionesIngresos.InsertarModificaciones(obra, nro_modificacion, adjunto, usuario, fecha)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button65_Click_1(sender As Object, e As EventArgs) Handles Button65.Click
        Try
            If txtObraModificaciones.Text <> "" And txtFechaAdjuntoModificaciones.Text <> "" And txtxNroModificacionModificaciones.Text <> "" Then

                SaveFileDialog3.FileName = txtNombreAdjuntoModificaciones.Text
                SaveFileDialog3.Title = "Escoje la ruta para descargar"
                SaveFileDialog3.InitialDirectory = "Descargas"
                If SaveFileDialog3.ShowDialog = DialogResult.OK Then
                    lblRutaDescarga.Text = SaveFileDialog3.FileName
                    FTPDownloadFile(lblRutaDescarga.Text + "", "ftp://201.148.105.75/Contrato_Original_Modificaciones_Obras/Modificaciones/" + txtNombreAdjuntoModificaciones.Text + "", "cfv@constructorafv.com", "gsolis2013")
                    SaveFileDialog3.FileName = ""
                    lblRutaDescarga.Text = ""
                End If
            Else
                MsgBox("Debe seleccionar un archivo", MsgBoxStyle.Exclamation)
                SaveFileDialog3.FileName = ""


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        Try
            If txtObraModificaciones.Text <> "" And txtFechaAdjuntoModificaciones.Text <> "" And txtxNroModificacionModificaciones.Text <> "" Then

                Dim id_modificacionesContrato As Integer
                Dim resultado As Integer = MessageBox.Show("¿Desea eliminar este adjunto?", "", MessageBoxButtons.YesNo)
                Dim mReq As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://201.148.105.75/Contrato_Original_Modificaciones_Obras/Modificaciones/" + txtNombreAdjuntoModificaciones.Text), System.Net.FtpWebRequest)
                If resultado = DialogResult.Yes Then
                    Try
                        mReq.Credentials = New System.Net.NetworkCredential("cfv@constructorafv.com", "gsolis2013")
                        mReq.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
                        mReq.GetResponse()
                        id_modificacionesContrato = txtIdModificacionesContrato.Text
                        modificacionesIngresos.EliminarModificacion(id_modificacionesContrato)

                        Actualizar_dgvModificacion()
                        LimpiarModificacion()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf resultado = DialogResult.No Then
                    MessageBox.Show("Procedimiento cancelado por el usuario")
                End If

            Else
                MsgBox("Debe seleccionar un archivo", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarModificacion()
        txtObraModificaciones.Text = ""
        txtFechaAdjuntoModificaciones.Text = ""
        txtxNroModificacionModificaciones.Text = ""
        txtUsuarioModificaciones.Text = ""
        txtNombreAdjuntoModificaciones.Text = ""
    End Sub

    Private Sub cboObrasListadoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboObrasListadoFiltro.SelectedIndexChanged
        actualizar_dgvListado()
        LimpiarListado()
    End Sub

    Private Sub cboObrasContratoOriginal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboObrasContratoOriginal.SelectedIndexChanged
        Actualizar_dgvContrato()
    End Sub

    Private Sub cboObrasModificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboObrasModificacion.SelectedIndexChanged

        Dim obraModificacion As String
        obraModificacion = cboObrasModificacion.Text.ToString
        If obraModificacion = "System.Data.DataRowView" Then
            obraModificacion = Nombre_Obra
        End If

        cboNroModificacionContrato.DataSource = modificacionesIngresos.LeerModificacionesExistente(obraModificacion)
        cboNroModificacionContrato.DisplayMember = "nro_modificacion"
        cboNroModificacionContrato.ValueMember = "id_modificaciones"


        Actualizar_dgvModificacion()
    End Sub

    Private Sub cboObrasListadoFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboObrasListadoFiltro.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboObrasContratoOriginal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboObrasContratoOriginal.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboObrasModificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboObrasModificacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboNroModificacionContrato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboNroModificacionContrato.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtNroModificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroModificacion.KeyPress
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

    Private Sub txtAumentoObra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAumentoObra.KeyPress
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

    Private Sub txtDisminucionObra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisminucionObra.KeyPress
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

    Private Sub txtObraExtraordinaria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObraExtraordinaria.KeyPress
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

    Private Sub DgvModificaciones_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvModificaciones.CellMouseClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = DgvModificaciones.Rows(index)
            txtIdModificacionesContrato.Text = selectRow.Cells(0).Value.ToString()
            If txtIdModificacionesContrato.Text <> "" Then
                txtObraModificaciones.Text = selectRow.Cells(1).Value.ToString()
                txtxNroModificacionModificaciones.Text = selectRow.Cells(2).Value.ToString()
                txtNombreAdjuntoModificaciones.Text = selectRow.Cells(3).Value.ToString()
                txtUsuarioModificaciones.Text = selectRow.Cells(4).Value.ToString()
                txtFechaAdjuntoModificaciones.Text = selectRow.Cells(5).Value.ToString()
            Else
                MsgBox("No se encuentra registro de adjuntos", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvContratoOriginal_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvContratoOriginal.CellMouseClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvContratoOriginal.Rows(index)
            txtidContratoOriginal.Text = selectRow.Cells(0).Value.ToString()
            txtNombreObraArchivo.Text = selectRow.Cells(1).Value.ToString()
            txtNombreArchivo.Text = selectRow.Cells(5).Value.ToString()
            txtUsuarioArchivo.Text = selectRow.Cells(3).Value.ToString()
            txtFechaAdjuntadoArchivo.Text = selectRow.Cells(4).Value()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtAumentoDisminucion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAumentoDisminucion.KeyPress
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

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If



        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números
        'Metodo comentado, ya que no logro encontrar la forma que reciba el simbolo "-"
        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSymbol(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else : e.Handled = True
        'End If
    End Sub

    Private Sub txtProformas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProformas.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        'Condicional que evalua que la tecla pulsada sea un número si no lo es mostrará un MSGBOX con una orden de que teclées sólo números
        'Metodo comentado, ya que no logro encontrar la forma que reciba el simbolo "-"
        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else : e.Handled = True
        'End If
    End Sub
End Class