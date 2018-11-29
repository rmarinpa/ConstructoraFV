Public Class Informe_EstadoPagoMandante
    Dim nue_obra5 As New clases.Ingreso_contratos
    Dim nue_obra6 As New clases.EstadoPagoMandante

    Private Sub Informe_EstadoPagoMandante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarCboObra()
    End Sub

    'Botón despliega el reporte de Estado Pago Mandante (Crystal Report)
    Private Sub btnEstadoPago_Click(sender As Object, e As EventArgs) Handles btnEstadoPago.Click
        Try
            If cboObra.Text <> "" Then
                CR_EstadoPagoMandante.Show()
            Else
                MsgBox("Debe selecionar una obra", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Favor, contacte al administrador", MsgBoxStyle.Critical)
        End Try

    End Sub
    'Botón despliega formulario Estados Pagos Firmados
    Private Sub btnEpFirmado_Click(sender As Object, e As EventArgs) Handles btnEpFirmado.Click
        Try
            If cboObra.Text <> "" Then

                Informe_EstadoPagoMandante_VerEP.Show()
            Else
                MsgBox("Debe seleccionar una obra", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Favor, contacte al administrador", MsgBoxStyle.Critical)
        End Try
    End Sub
    'Botón despliega Facturas Firmadas
    Private Sub btnFacturasFirmadas_Click(sender As Object, e As EventArgs) Handles btnFacturasFirmadas.Click
        Informe_EstadoPagoMandante_VerFFvb.Show()
    End Sub
    'Metodos
    Sub RellenarCboObra()
        Try
            cboObra.DataSource = nue_obra5.listar5(id_obra)
            cboObra.DisplayMember = "nombre_faena"
            cboObra.ValueMember = "Id_identificacion"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cboObra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboObra.SelectedIndexChanged
        Module1.Nombre_Faena = cboObra.Text
    End Sub
End Class