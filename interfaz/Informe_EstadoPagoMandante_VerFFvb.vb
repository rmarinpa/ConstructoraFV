Imports System.IO
Imports System.Net

Public Class Informe_EstadoPagoMandante_VerFFvb
    Dim nue_obra5 As New clases.Ingreso_contratos
    Dim nue_obra6 As New clases.EstadoPagoMandante
    Private Sub Informe_EstadoPagoMandante_VerFFvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarCboObra()
        actualizar_dgvFacturasAdjunto()
    End Sub

    Private Sub cboObra_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboObra.SelectionChangeCommitted
        actualizar_dgvFacturasAdjunto()
        Limpiar()
    End Sub


    Private Sub btnDescargarFacturasAdjuntas_Click(sender As Object, e As EventArgs) Handles btnDescargarFacturasAdjuntas.Click
        Try
            If txtAdjuntoFacturasFirmadas.Text <> "" Then
                SaveFileDialog1.FileName = txtAdjuntoFacturasFirmadas.Text
                If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                    SaveFileDialog1.Title = "Escoje la ruta para descargar"
                    SaveFileDialog1.InitialDirectory = "Descargas"
                    lblAdjuntoFacturas.Text = SaveFileDialog1.FileName
                    FTPDownloadFile(lblAdjuntoFacturas.Text + "", "ftp://201.148.105.75/Estado_De_Pago_Mandante/Facturas_Firmadas/" + txtAdjuntoFacturasFirmadas.Text, "cfv@constructorafv.com", "gsolis2013")
                    SaveFileDialog1.FileName = ""
                    lblAdjuntoFacturas.Text = ""
                End If
                SaveFileDialog1.FileName = ""
            Else
                MsgBox("Debes seleccionar un registro", MsgBoxStyle.Exclamation)
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
            MsgBox("Se ha descargado el archivo ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Sub RellenarCboObra()
        Try
            cboObra.DataSource = nue_obra5.listar5(id_obra)
            cboObra.DisplayMember = "nombre_faena"
            cboObra.ValueMember = "Id_identificacion"
            cboObra.Text = Module1.Nombre_Faena
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub actualizar_dgvFacturasAdjunto()
        Try
            Dim total As Double = 0
            Dim obrasFiltro As String

            obrasFiltro = cboObra.Text

            Dim fila As DataGridViewRow = New DataGridViewRow()
            dgvFacturasAdjunto.DataSource = nue_obra6.LeerAdjuntoFacturas(obrasFiltro)
            With dgvFacturasAdjunto
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Obra Adjunto"
                .Columns(1).Visible = False
                .Columns(2).HeaderCell.Value = "Obra"
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


    Private Sub Limpiar()
        txtInfoObra.Text = ""
        txtInfoNroEstadoPago.Text = ""
        txtInfoNroFactura.Text = ""
        txtAdjuntoFacturasFirmadas.Text = ""
        txtInfoFechaAdjunto.Text = ""
    End Sub

    Private Sub dgvFacturasAdjunto_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvFacturasAdjunto.CellMouseClick
        Try

            Dim index As Integer
            index = e.RowIndex
            Dim selectRow As DataGridViewRow
            selectRow = dgvFacturasAdjunto.Rows(index)


            txtInfoObra.Text = selectRow.Cells(2).Value.ToString()
            If txtInfoObra.Text <> "" Then

                txtInfoNroEstadoPago.Text = selectRow.Cells(3).Value.ToString()
                txtInfoNroFactura.Text = selectRow.Cells(4).Value.ToString()
                txtAdjuntoFacturasFirmadas.Text = selectRow.Cells(8).Value.ToString()
                txtInfoFechaAdjunto.Text = selectRow.Cells(7).Value
            Else
                MsgBox("No se encuentra registro de adjuntos", MsgBoxStyle.Information)
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class