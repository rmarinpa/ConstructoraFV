Imports System.Net
Imports System.IO

Public Class Informe_EstadoPagoMandante_VerEP
    Dim nue_obra5 As New clases.Ingreso_contratos
    Dim nue_obra6 As New clases.EstadoPagoMandante

    Private Sub Informe_VerEP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos el DataGridView con Datos
        RellenarCboObra()
        LlenarDataGridView()
    End Sub

    Private Sub dgvAdjuntosPagosFirmados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdjuntosPagosFirmados.CellClick
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvAdjuntosPagosFirmados.Rows(index)

            txtNombreObraArchivo.Text = selectRow.Cells(1).Value.ToString()
            If txtNombreObraArchivo.Text <> "" Then
                txtNroEstadoPagoArchivo.Text = selectRow.Cells(2).Value.ToString()
                txtNombreArchivo.Text = selectRow.Cells(3).Value.ToString()
                txtUsuarioArchivo.Text = selectRow.Cells(4).Value.ToString()
                txtFechaAdjuntadoArchivo.Text = selectRow.Cells(5).Value
            Else
                MsgBox("No se encuentra registro de adjuntos", MsgBoxStyle.Information)
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargar.Click
        Try
            If txtNombreArchivo.Text <> "" Then
                Dim nombreArchivo As String
                nombreArchivo = txtNombreArchivo.Text
                SaveFileDialog1.FileName = txtNombreArchivo.Text
                If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                    SaveFileDialog1.Title = "Escoje la ruta para descargar"
                    SaveFileDialog1.InitialDirectory = "Descargas"
                    lblRutaDescarga.Text = SaveFileDialog1.FileName
                    FTPDownloadFile(lblRutaDescarga.Text + "", "ftp://201.148.105.75/Estado_De_Pago_Mandante/Estados_De_Pago_Firmados" + "/" + txtNombreArchivo.Text + "", "cfv@constructorafv.com", "gsolis2013")
                    lblRutaDescarga.Text = ""
                    SaveFileDialog1.FileName = ""
                Else
                    SaveFileDialog1.FileName = ""
                End If
            Else
                MsgBox("Debe seleccionar un registro", MsgBoxStyle.Exclamation)
                SaveFileDialog1.FileName = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Metodos
    'Descarga desde FTP

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
            MsgBox("Se ha descargado el archivo ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    'Rellenar GridView
    Sub LlenarDataGridView()
        Try
            Dim total As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim obra As String
            obra = cboObra.Text
            dgvAdjuntosPagosFirmados.DataSource = nue_obra6.LeerAdjuntoPagosFirmados(obra)

            With dgvAdjuntosPagosFirmados
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra"
                .Columns(2).HeaderCell.Value = "Nro Estado de Pago"
                .Columns(3).HeaderCell.Value = "Adjunto"
                .Columns(3).Visible = False
                .Columns(4).HeaderCell.Value = "Usuario"
                .Columns(5).HeaderCell.Value = "Fecha de subida"
                .Columns(6).HeaderCell.Value = "Obras Adjunto"
                .Columns(6).Visible = False
                .Columns(7).HeaderCell.Value = "Adjunto"
                dgvAdjuntosPagosFirmados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvAdjuntosPagosFirmados.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function RellenarCboObra()
        Try
            cboObra.DataSource = nue_obra5.listar5(id_obra)
            cboObra.DisplayMember = "nombre_faena"
            cboObra.ValueMember = "Id_identificacion"
            cboObra.Text = Module1.Nombre_Faena
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Private Sub cboObra_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboObra.SelectionChangeCommitted
        LlenarDataGridView()
    End Sub

    Public Function Limpiar()
        txtNombreObraArchivo.Text = ""
        txtNroEstadoPagoArchivo.Text = ""
        txtNombreArchivo.Text = ""
        txtUsuarioArchivo.Text = ""
        txtFechaAdjuntadoArchivo.Text = ""
    End Function
End Class