<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informe_EstadoPagoMandante_VerFFvb
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNroEstadoDePago = New System.Windows.Forms.Label()
        Me.lblFechaAdjunto = New System.Windows.Forms.Label()
        Me.txtInfoObra = New System.Windows.Forms.TextBox()
        Me.txtInfoNroEstadoPago = New System.Windows.Forms.TextBox()
        Me.lblNroFactura = New System.Windows.Forms.Label()
        Me.txtAdjuntoFacturasFirmadas = New System.Windows.Forms.TextBox()
        Me.dgvFacturasAdjunto = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAdjuntoFacturas = New System.Windows.Forms.Label()
        Me.cboObra = New System.Windows.Forms.ComboBox()
        Me.lblObra = New System.Windows.Forms.Label()
        Me.txtInfoNroFactura = New System.Windows.Forms.TextBox()
        Me.txtInfoFechaAdjunto = New System.Windows.Forms.TextBox()
        Me.lblObra2 = New System.Windows.Forms.Label()
        Me.btnDescargarFacturasAdjuntas = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgvFacturasAdjunto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNroEstadoDePago
        '
        Me.lblNroEstadoDePago.AutoSize = True
        Me.lblNroEstadoDePago.Location = New System.Drawing.Point(6, 121)
        Me.lblNroEstadoDePago.Name = "lblNroEstadoDePago"
        Me.lblNroEstadoDePago.Size = New System.Drawing.Size(178, 18)
        Me.lblNroEstadoDePago.TabIndex = 30
        Me.lblNroEstadoDePago.Text = "N° Estado de Pago Asociado"
        '
        'lblFechaAdjunto
        '
        Me.lblFechaAdjunto.AutoSize = True
        Me.lblFechaAdjunto.Location = New System.Drawing.Point(6, 185)
        Me.lblFechaAdjunto.Name = "lblFechaAdjunto"
        Me.lblFechaAdjunto.Size = New System.Drawing.Size(112, 18)
        Me.lblFechaAdjunto.TabIndex = 32
        Me.lblFechaAdjunto.Text = "Fecha Adjuntado"
        '
        'txtInfoObra
        '
        Me.txtInfoObra.Enabled = False
        Me.txtInfoObra.Location = New System.Drawing.Point(190, 89)
        Me.txtInfoObra.Name = "txtInfoObra"
        Me.txtInfoObra.Size = New System.Drawing.Size(195, 26)
        Me.txtInfoObra.TabIndex = 33
        '
        'txtInfoNroEstadoPago
        '
        Me.txtInfoNroEstadoPago.Enabled = False
        Me.txtInfoNroEstadoPago.Location = New System.Drawing.Point(190, 121)
        Me.txtInfoNroEstadoPago.Name = "txtInfoNroEstadoPago"
        Me.txtInfoNroEstadoPago.Size = New System.Drawing.Size(195, 26)
        Me.txtInfoNroEstadoPago.TabIndex = 34
        '
        'lblNroFactura
        '
        Me.lblNroFactura.AutoSize = True
        Me.lblNroFactura.Location = New System.Drawing.Point(6, 153)
        Me.lblNroFactura.Name = "lblNroFactura"
        Me.lblNroFactura.Size = New System.Drawing.Size(71, 18)
        Me.lblNroFactura.TabIndex = 36
        Me.lblNroFactura.Text = "N° Factura"
        '
        'txtAdjuntoFacturasFirmadas
        '
        Me.txtAdjuntoFacturasFirmadas.Location = New System.Drawing.Point(554, 182)
        Me.txtAdjuntoFacturasFirmadas.Name = "txtAdjuntoFacturasFirmadas"
        Me.txtAdjuntoFacturasFirmadas.Size = New System.Drawing.Size(56, 26)
        Me.txtAdjuntoFacturasFirmadas.TabIndex = 38
        Me.txtAdjuntoFacturasFirmadas.Visible = False
        '
        'dgvFacturasAdjunto
        '
        Me.dgvFacturasAdjunto.AllowUserToAddRows = False
        Me.dgvFacturasAdjunto.AllowUserToDeleteRows = False
        Me.dgvFacturasAdjunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturasAdjunto.Location = New System.Drawing.Point(74, 251)
        Me.dgvFacturasAdjunto.Name = "dgvFacturasAdjunto"
        Me.dgvFacturasAdjunto.ReadOnly = True
        Me.dgvFacturasAdjunto.Size = New System.Drawing.Size(502, 207)
        Me.dgvFacturasAdjunto.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dgvFacturasAdjunto)
        Me.Panel1.Controls.Add(Me.btnDescargarFacturasAdjuntas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 470)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAdjuntoFacturas)
        Me.GroupBox1.Controls.Add(Me.cboObra)
        Me.GroupBox1.Controls.Add(Me.lblObra)
        Me.GroupBox1.Controls.Add(Me.txtInfoObra)
        Me.GroupBox1.Controls.Add(Me.txtInfoNroEstadoPago)
        Me.GroupBox1.Controls.Add(Me.txtAdjuntoFacturasFirmadas)
        Me.GroupBox1.Controls.Add(Me.txtInfoNroFactura)
        Me.GroupBox1.Controls.Add(Me.txtInfoFechaAdjunto)
        Me.GroupBox1.Controls.Add(Me.lblNroFactura)
        Me.GroupBox1.Controls.Add(Me.lblFechaAdjunto)
        Me.GroupBox1.Controls.Add(Me.lblObra2)
        Me.GroupBox1.Controls.Add(Me.lblNroEstadoDePago)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 215)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas Firmadas"
        '
        'lblAdjuntoFacturas
        '
        Me.lblAdjuntoFacturas.AutoSize = True
        Me.lblAdjuntoFacturas.Location = New System.Drawing.Point(554, 133)
        Me.lblAdjuntoFacturas.Name = "lblAdjuntoFacturas"
        Me.lblAdjuntoFacturas.Size = New System.Drawing.Size(0, 18)
        Me.lblAdjuntoFacturas.TabIndex = 41
        Me.lblAdjuntoFacturas.Visible = False
        '
        'cboObra
        '
        Me.cboObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboObra.FormattingEnabled = True
        Me.cboObra.Location = New System.Drawing.Point(190, 41)
        Me.cboObra.Name = "cboObra"
        Me.cboObra.Size = New System.Drawing.Size(195, 26)
        Me.cboObra.TabIndex = 40
        '
        'lblObra
        '
        Me.lblObra.AutoSize = True
        Me.lblObra.Location = New System.Drawing.Point(9, 41)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(38, 18)
        Me.lblObra.TabIndex = 39
        Me.lblObra.Text = "Obra"
        '
        'txtInfoNroFactura
        '
        Me.txtInfoNroFactura.Enabled = False
        Me.txtInfoNroFactura.Location = New System.Drawing.Point(190, 153)
        Me.txtInfoNroFactura.Name = "txtInfoNroFactura"
        Me.txtInfoNroFactura.Size = New System.Drawing.Size(195, 26)
        Me.txtInfoNroFactura.TabIndex = 37
        '
        'txtInfoFechaAdjunto
        '
        Me.txtInfoFechaAdjunto.Enabled = False
        Me.txtInfoFechaAdjunto.Location = New System.Drawing.Point(190, 185)
        Me.txtInfoFechaAdjunto.Name = "txtInfoFechaAdjunto"
        Me.txtInfoFechaAdjunto.Size = New System.Drawing.Size(195, 26)
        Me.txtInfoFechaAdjunto.TabIndex = 35
        '
        'lblObra2
        '
        Me.lblObra2.AutoSize = True
        Me.lblObra2.Location = New System.Drawing.Point(6, 95)
        Me.lblObra2.Name = "lblObra2"
        Me.lblObra2.Size = New System.Drawing.Size(38, 18)
        Me.lblObra2.TabIndex = 29
        Me.lblObra2.Text = "Obra"
        '
        'btnDescargarFacturasAdjuntas
        '
        Me.btnDescargarFacturasAdjuntas.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnDescargarFacturasAdjuntas.Location = New System.Drawing.Point(615, 251)
        Me.btnDescargarFacturasAdjuntas.Name = "btnDescargarFacturasAdjuntas"
        Me.btnDescargarFacturasAdjuntas.Size = New System.Drawing.Size(84, 26)
        Me.btnDescargarFacturasAdjuntas.TabIndex = 28
        Me.btnDescargarFacturasAdjuntas.Text = "Descargar"
        Me.btnDescargarFacturasAdjuntas.UseVisualStyleBackColor = True
        '
        'Informe_EstadoPagoMandante_VerFFvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 470)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Informe_EstadoPagoMandante_VerFFvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas Firmadas"
        CType(Me.dgvFacturasAdjunto,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lblNroEstadoDePago As System.Windows.Forms.Label
    Friend WithEvents lblFechaAdjunto As System.Windows.Forms.Label
    Friend WithEvents txtInfoObra As System.Windows.Forms.TextBox
    Friend WithEvents txtInfoNroEstadoPago As System.Windows.Forms.TextBox
    Friend WithEvents lblNroFactura As System.Windows.Forms.Label
    Friend WithEvents txtAdjuntoFacturasFirmadas As System.Windows.Forms.TextBox
    Friend WithEvents dgvFacturasAdjunto As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDescargarFacturasAdjuntas As System.Windows.Forms.Button
    Friend WithEvents txtInfoNroFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtInfoFechaAdjunto As System.Windows.Forms.TextBox
    Friend WithEvents lblObra2 As System.Windows.Forms.Label
    Friend WithEvents cboObra As System.Windows.Forms.ComboBox
    Friend WithEvents lblObra As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblAdjuntoFacturas As System.Windows.Forms.Label
End Class
