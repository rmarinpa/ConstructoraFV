<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informe_EstadoPagoMandante_VerEP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informe_EstadoPagoMandante_VerEP))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboObra = New System.Windows.Forms.ComboBox()
        Me.lblObra = New System.Windows.Forms.Label()
        Me.dgvAdjuntosPagosFirmados = New System.Windows.Forms.DataGridView()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.lblRutaDescarga = New System.Windows.Forms.Label()
        Me.txtUsuarioArchivo = New System.Windows.Forms.TextBox()
        Me.txtFechaAdjuntadoArchivo = New System.Windows.Forms.TextBox()
        Me.txtNroEstadoPagoArchivo = New System.Windows.Forms.TextBox()
        Me.txtNombreObraArchivo = New System.Windows.Forms.TextBox()
        Me.lblFechaAdjuntado = New System.Windows.Forms.Label()
        Me.lblNroEstadoPago = New System.Windows.Forms.Label()
        Me.lblObra2 = New System.Windows.Forms.Label()
        Me.txtNombreArchivo = New System.Windows.Forms.TextBox()
        Me.btnDescargar = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAdjuntosPagosFirmados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvAdjuntosPagosFirmados)
        Me.Panel1.Controls.Add(Me.GroupBox12)
        Me.Panel1.Controls.Add(Me.btnDescargar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 460)
        Me.Panel1.TabIndex = 0
        '
        'cboObra
        '
        Me.cboObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboObra.FormattingEnabled = True
        Me.cboObra.Location = New System.Drawing.Point(152, 40)
        Me.cboObra.Name = "cboObra"
        Me.cboObra.Size = New System.Drawing.Size(195, 26)
        Me.cboObra.TabIndex = 22
        '
        'lblObra
        '
        Me.lblObra.AutoSize = True
        Me.lblObra.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObra.Location = New System.Drawing.Point(9, 40)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(38, 18)
        Me.lblObra.TabIndex = 21
        Me.lblObra.Text = "Obra"
        '
        'dgvAdjuntosPagosFirmados
        '
        Me.dgvAdjuntosPagosFirmados.AllowUserToAddRows = False
        Me.dgvAdjuntosPagosFirmados.AllowUserToDeleteRows = False
        Me.dgvAdjuntosPagosFirmados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdjuntosPagosFirmados.Location = New System.Drawing.Point(76, 301)
        Me.dgvAdjuntosPagosFirmados.Name = "dgvAdjuntosPagosFirmados"
        Me.dgvAdjuntosPagosFirmados.ReadOnly = True
        Me.dgvAdjuntosPagosFirmados.Size = New System.Drawing.Size(400, 150)
        Me.dgvAdjuntosPagosFirmados.TabIndex = 20
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.lblObra)
        Me.GroupBox12.Controls.Add(Me.cboObra)
        Me.GroupBox12.Controls.Add(Me.lblRutaDescarga)
        Me.GroupBox12.Controls.Add(Me.txtUsuarioArchivo)
        Me.GroupBox12.Controls.Add(Me.txtFechaAdjuntadoArchivo)
        Me.GroupBox12.Controls.Add(Me.txtNroEstadoPagoArchivo)
        Me.GroupBox12.Controls.Add(Me.txtNombreObraArchivo)
        Me.GroupBox12.Controls.Add(Me.lblFechaAdjuntado)
        Me.GroupBox12.Controls.Add(Me.lblNroEstadoPago)
        Me.GroupBox12.Controls.Add(Me.lblObra2)
        Me.GroupBox12.Controls.Add(Me.txtNombreArchivo)
        Me.GroupBox12.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.GroupBox12.Location = New System.Drawing.Point(76, 46)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(592, 233)
        Me.GroupBox12.TabIndex = 19
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Estados de Pago Firmados Adjuntos"
        '
        'lblRutaDescarga
        '
        Me.lblRutaDescarga.AutoSize = True
        Me.lblRutaDescarga.Location = New System.Drawing.Point(403, 175)
        Me.lblRutaDescarga.Name = "lblRutaDescarga"
        Me.lblRutaDescarga.Size = New System.Drawing.Size(0, 18)
        Me.lblRutaDescarga.TabIndex = 25
        Me.lblRutaDescarga.Visible = False
        '
        'txtUsuarioArchivo
        '
        Me.txtUsuarioArchivo.Enabled = False
        Me.txtUsuarioArchivo.Location = New System.Drawing.Point(522, 157)
        Me.txtUsuarioArchivo.Name = "txtUsuarioArchivo"
        Me.txtUsuarioArchivo.Size = New System.Drawing.Size(36, 26)
        Me.txtUsuarioArchivo.TabIndex = 24
        Me.txtUsuarioArchivo.Visible = False
        '
        'txtFechaAdjuntadoArchivo
        '
        Me.txtFechaAdjuntadoArchivo.Enabled = False
        Me.txtFechaAdjuntadoArchivo.Location = New System.Drawing.Point(152, 157)
        Me.txtFechaAdjuntadoArchivo.Name = "txtFechaAdjuntadoArchivo"
        Me.txtFechaAdjuntadoArchivo.Size = New System.Drawing.Size(195, 26)
        Me.txtFechaAdjuntadoArchivo.TabIndex = 22
        '
        'txtNroEstadoPagoArchivo
        '
        Me.txtNroEstadoPagoArchivo.Enabled = False
        Me.txtNroEstadoPagoArchivo.Location = New System.Drawing.Point(152, 125)
        Me.txtNroEstadoPagoArchivo.Name = "txtNroEstadoPagoArchivo"
        Me.txtNroEstadoPagoArchivo.Size = New System.Drawing.Size(195, 26)
        Me.txtNroEstadoPagoArchivo.TabIndex = 21
        '
        'txtNombreObraArchivo
        '
        Me.txtNombreObraArchivo.Enabled = False
        Me.txtNombreObraArchivo.Location = New System.Drawing.Point(152, 93)
        Me.txtNombreObraArchivo.Name = "txtNombreObraArchivo"
        Me.txtNombreObraArchivo.Size = New System.Drawing.Size(195, 26)
        Me.txtNombreObraArchivo.TabIndex = 20
        '
        'lblFechaAdjuntado
        '
        Me.lblFechaAdjuntado.AutoSize = True
        Me.lblFechaAdjuntado.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.lblFechaAdjuntado.Location = New System.Drawing.Point(10, 163)
        Me.lblFechaAdjuntado.Name = "lblFechaAdjuntado"
        Me.lblFechaAdjuntado.Size = New System.Drawing.Size(112, 18)
        Me.lblFechaAdjuntado.TabIndex = 19
        Me.lblFechaAdjuntado.Text = "Fecha Adjuntado"
        '
        'lblNroEstadoPago
        '
        Me.lblNroEstadoPago.AutoSize = True
        Me.lblNroEstadoPago.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.lblNroEstadoPago.Location = New System.Drawing.Point(9, 128)
        Me.lblNroEstadoPago.Name = "lblNroEstadoPago"
        Me.lblNroEstadoPago.Size = New System.Drawing.Size(108, 18)
        Me.lblNroEstadoPago.TabIndex = 18
        Me.lblNroEstadoPago.Text = "Nro Estado Pago"
        '
        'lblObra2
        '
        Me.lblObra2.AutoSize = True
        Me.lblObra2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObra2.Location = New System.Drawing.Point(9, 93)
        Me.lblObra2.Name = "lblObra2"
        Me.lblObra2.Size = New System.Drawing.Size(38, 18)
        Me.lblObra2.TabIndex = 17
        Me.lblObra2.Text = "Obra"
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Enabled = False
        Me.txtNombreArchivo.Location = New System.Drawing.Point(353, 157)
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        Me.txtNombreArchivo.Size = New System.Drawing.Size(127, 26)
        Me.txtNombreArchivo.TabIndex = 16
        Me.txtNombreArchivo.Visible = False
        '
        'btnDescargar
        '
        Me.btnDescargar.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnDescargar.Location = New System.Drawing.Point(579, 301)
        Me.btnDescargar.Name = "btnDescargar"
        Me.btnDescargar.Size = New System.Drawing.Size(89, 26)
        Me.btnDescargar.TabIndex = 13
        Me.btnDescargar.Text = "Descargar"
        Me.btnDescargar.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf"
        '
        'Informe_VerEP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 460)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Informe_VerEP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estados de Pago Firmados"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvAdjuntosPagosFirmados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRutaDescarga As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioArchivo As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaAdjuntadoArchivo As System.Windows.Forms.TextBox
    Friend WithEvents txtNroEstadoPagoArchivo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreObraArchivo As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaAdjuntado As System.Windows.Forms.Label
    Friend WithEvents lblNroEstadoPago As System.Windows.Forms.Label
    Friend WithEvents lblObra2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreArchivo As System.Windows.Forms.TextBox
    Friend WithEvents btnDescargar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dgvAdjuntosPagosFirmados As System.Windows.Forms.DataGridView
    Friend WithEvents cboObra As System.Windows.Forms.ComboBox
    Friend WithEvents lblObra As System.Windows.Forms.Label
End Class
