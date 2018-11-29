<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informe_EstadoPagoMandante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informe_EstadoPagoMandante))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFacturasFirmadas = New System.Windows.Forms.Button()
        Me.btnEpFirmado = New System.Windows.Forms.Button()
        Me.btnEstadoPago = New System.Windows.Forms.Button()
        Me.cboObra = New System.Windows.Forms.ComboBox()
        Me.lblObra = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.btnFacturasFirmadas)
        Me.Panel1.Controls.Add(Me.btnEpFirmado)
        Me.Panel1.Controls.Add(Me.btnEstadoPago)
        Me.Panel1.Controls.Add(Me.cboObra)
        Me.Panel1.Controls.Add(Me.lblObra)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 201)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(410, 26)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Informes Estados de Pago Mandante"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFacturasFirmadas
        '
        Me.btnFacturasFirmadas.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnFacturasFirmadas.Location = New System.Drawing.Point(276, 130)
        Me.btnFacturasFirmadas.Name = "btnFacturasFirmadas"
        Me.btnFacturasFirmadas.Size = New System.Drawing.Size(137, 45)
        Me.btnFacturasFirmadas.TabIndex = 10
        Me.btnFacturasFirmadas.Text = "Ver Facturas Firmadas"
        Me.btnFacturasFirmadas.UseVisualStyleBackColor = True
        '
        'btnEpFirmado
        '
        Me.btnEpFirmado.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnEpFirmado.Location = New System.Drawing.Point(147, 130)
        Me.btnEpFirmado.Name = "btnEpFirmado"
        Me.btnEpFirmado.Size = New System.Drawing.Size(118, 45)
        Me.btnEpFirmado.TabIndex = 9
        Me.btnEpFirmado.Text = "Ver E.P. Firmados"
        Me.btnEpFirmado.UseVisualStyleBackColor = True
        '
        'btnEstadoPago
        '
        Me.btnEstadoPago.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnEstadoPago.Location = New System.Drawing.Point(3, 130)
        Me.btnEstadoPago.Name = "btnEstadoPago"
        Me.btnEstadoPago.Size = New System.Drawing.Size(135, 44)
        Me.btnEstadoPago.TabIndex = 8
        Me.btnEstadoPago.Text = "Generar Resumen E.P. Mandante"
        Me.btnEstadoPago.UseVisualStyleBackColor = True
        '
        'cboObra
        '
        Me.cboObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboObra.FormattingEnabled = True
        Me.cboObra.Location = New System.Drawing.Point(147, 77)
        Me.cboObra.Name = "cboObra"
        Me.cboObra.Size = New System.Drawing.Size(261, 21)
        Me.cboObra.TabIndex = 7
        '
        'lblObra
        '
        Me.lblObra.AutoSize = True
        Me.lblObra.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObra.Location = New System.Drawing.Point(12, 80)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(38, 18)
        Me.lblObra.TabIndex = 6
        Me.lblObra.Text = "Obra"
        '
        'Informe_EstadoPagoMandante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 201)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Informe_EstadoPagoMandante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado Pago Mandante"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFacturasFirmadas As System.Windows.Forms.Button
    Friend WithEvents btnEpFirmado As System.Windows.Forms.Button
    Friend WithEvents btnEstadoPago As System.Windows.Forms.Button
    Friend WithEvents cboObra As System.Windows.Forms.ComboBox
    Friend WithEvents lblObra As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
