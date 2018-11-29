<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_maquinaria
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
        Me.gbx_liquidacion = New System.Windows.Forms.GroupBox()
        Me.cmb_obra = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.dtp_fecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.cmb_8_arrendador = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha_in = New System.Windows.Forms.DateTimePicker()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.btn_detalle_ep = New System.Windows.Forms.Button()
        Me.btn_detalle_obra = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.dgv_8_minimos = New System.Windows.Forms.DataGridView()
        Me.gbx_liquidacion.SuspendLayout()
        CType(Me.dgv_8_minimos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_liquidacion
        '
        Me.gbx_liquidacion.Controls.Add(Me.cmb_obra)
        Me.gbx_liquidacion.Controls.Add(Me.Label1)
        Me.gbx_liquidacion.Controls.Add(Me.Label102)
        Me.gbx_liquidacion.Controls.Add(Me.dtp_fecha_fin)
        Me.gbx_liquidacion.Controls.Add(Me.Label82)
        Me.gbx_liquidacion.Controls.Add(Me.cmb_8_arrendador)
        Me.gbx_liquidacion.Controls.Add(Me.dtp_fecha_in)
        Me.gbx_liquidacion.Controls.Add(Me.Label80)
        Me.gbx_liquidacion.Location = New System.Drawing.Point(12, 11)
        Me.gbx_liquidacion.Name = "gbx_liquidacion"
        Me.gbx_liquidacion.Size = New System.Drawing.Size(343, 139)
        Me.gbx_liquidacion.TabIndex = 1085
        Me.gbx_liquidacion.TabStop = False
        Me.gbx_liquidacion.Text = "Liquidación de Maquinaria"
        '
        'cmb_obra
        '
        Me.cmb_obra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_obra.FormattingEnabled = True
        Me.cmb_obra.Location = New System.Drawing.Point(92, 70)
        Me.cmb_obra.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_obra.Name = "cmb_obra"
        Me.cmb_obra.Size = New System.Drawing.Size(223, 21)
        Me.cmb_obra.TabIndex = 1213
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1214
        Me.Label1.Text = "Obra"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(9, 51)
        Me.Label102.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(78, 13)
        Me.Label102.TabIndex = 1212
        Me.Label102.Text = "Fecha Termino"
        '
        'dtp_fecha_fin
        '
        Me.dtp_fecha_fin.Location = New System.Drawing.Point(92, 45)
        Me.dtp_fecha_fin.Name = "dtp_fecha_fin"
        Me.dtp_fecha_fin.Size = New System.Drawing.Size(222, 20)
        Me.dtp_fecha_fin.TabIndex = 1209
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(9, 25)
        Me.Label82.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(65, 13)
        Me.Label82.TabIndex = 1210
        Me.Label82.Text = "Fecha Inicio"
        '
        'cmb_8_arrendador
        '
        Me.cmb_8_arrendador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_8_arrendador.FormattingEnabled = True
        Me.cmb_8_arrendador.Location = New System.Drawing.Point(92, 95)
        Me.cmb_8_arrendador.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_8_arrendador.Name = "cmb_8_arrendador"
        Me.cmb_8_arrendador.Size = New System.Drawing.Size(223, 21)
        Me.cmb_8_arrendador.TabIndex = 1207
        '
        'dtp_fecha_in
        '
        Me.dtp_fecha_in.Location = New System.Drawing.Point(92, 19)
        Me.dtp_fecha_in.Name = "dtp_fecha_in"
        Me.dtp_fecha_in.Size = New System.Drawing.Size(222, 20)
        Me.dtp_fecha_in.TabIndex = 1208
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(9, 98)
        Me.Label80.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(59, 13)
        Me.Label80.TabIndex = 1211
        Me.Label80.Text = "Arrendador"
        '
        'btn_detalle_ep
        '
        Me.btn_detalle_ep.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_detalle_ep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_detalle_ep.Location = New System.Drawing.Point(12, 155)
        Me.btn_detalle_ep.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_detalle_ep.Name = "btn_detalle_ep"
        Me.btn_detalle_ep.Size = New System.Drawing.Size(155, 45)
        Me.btn_detalle_ep.TabIndex = 1086
        Me.btn_detalle_ep.Text = "Detalle E.P. por Empresa"
        Me.btn_detalle_ep.UseVisualStyleBackColor = False
        '
        'btn_detalle_obra
        '
        Me.btn_detalle_obra.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_detalle_obra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_detalle_obra.Location = New System.Drawing.Point(173, 155)
        Me.btn_detalle_obra.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_detalle_obra.Name = "btn_detalle_obra"
        Me.btn_detalle_obra.Size = New System.Drawing.Size(155, 45)
        Me.btn_detalle_obra.TabIndex = 1087
        Me.btn_detalle_obra.Text = "Resumen E.P."
        Me.btn_detalle_obra.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.Red
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cerrar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cerrar.Location = New System.Drawing.Point(266, 233)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(112, 45)
        Me.btn_cerrar.TabIndex = 1088
        Me.btn_cerrar.Text = "VOLVER A INGRESAR"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'dgv_8_minimos
        '
        Me.dgv_8_minimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_8_minimos.Location = New System.Drawing.Point(0, -1)
        Me.dgv_8_minimos.Name = "dgv_8_minimos"
        Me.dgv_8_minimos.Size = New System.Drawing.Size(10, 10)
        Me.dgv_8_minimos.TabIndex = 1208
        Me.dgv_8_minimos.Visible = False
        '
        'Frm_maquinaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(389, 289)
        Me.Controls.Add(Me.dgv_8_minimos)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_detalle_obra)
        Me.Controls.Add(Me.btn_detalle_ep)
        Me.Controls.Add(Me.gbx_liquidacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_maquinaria"
        Me.Text = "INFORME REPORTS MAQUINARIA"
        Me.gbx_liquidacion.ResumeLayout(False)
        Me.gbx_liquidacion.PerformLayout()
        CType(Me.dgv_8_minimos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbx_liquidacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_obra As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents cmb_8_arrendador As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_in As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents btn_detalle_ep As System.Windows.Forms.Button
    Friend WithEvents btn_detalle_obra As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents dgv_8_minimos As System.Windows.Forms.DataGridView
End Class
