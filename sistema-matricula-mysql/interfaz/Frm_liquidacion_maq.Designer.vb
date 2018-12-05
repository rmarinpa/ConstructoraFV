<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_liquidacion_maq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_liquidacion_maq))
        Me.dgv_liquidacion = New System.Windows.Forms.DataGridView()
        Me.gbx_liquidacion = New System.Windows.Forms.GroupBox()
        Me.cmb_viajes = New System.Windows.Forms.ComboBox()
        Me.lbl_viaje = New System.Windows.Forms.Label()
        Me.txt_m3_km = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_equipo = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgv_viajes = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_liquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_liquidacion.SuspendLayout()
        CType(Me.dgv_viajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_liquidacion
        '
        Me.dgv_liquidacion.AllowUserToAddRows = False
        Me.dgv_liquidacion.AllowUserToDeleteRows = False
        Me.dgv_liquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_liquidacion.Location = New System.Drawing.Point(500, 11)
        Me.dgv_liquidacion.Name = "dgv_liquidacion"
        Me.dgv_liquidacion.ReadOnly = True
        Me.dgv_liquidacion.RowHeadersVisible = False
        Me.dgv_liquidacion.Size = New System.Drawing.Size(516, 224)
        Me.dgv_liquidacion.TabIndex = 1086
        '
        'gbx_liquidacion
        '
        Me.gbx_liquidacion.Controls.Add(Me.cmb_viajes)
        Me.gbx_liquidacion.Controls.Add(Me.lbl_viaje)
        Me.gbx_liquidacion.Controls.Add(Me.txt_m3_km)
        Me.gbx_liquidacion.Controls.Add(Me.Label3)
        Me.gbx_liquidacion.Controls.Add(Me.cmb_equipo)
        Me.gbx_liquidacion.Controls.Add(Me.label7)
        Me.gbx_liquidacion.Controls.Add(Me.txt_fecha)
        Me.gbx_liquidacion.Controls.Add(Me.Label1)
        Me.gbx_liquidacion.Location = New System.Drawing.Point(12, 11)
        Me.gbx_liquidacion.Name = "gbx_liquidacion"
        Me.gbx_liquidacion.Size = New System.Drawing.Size(482, 151)
        Me.gbx_liquidacion.TabIndex = 1085
        Me.gbx_liquidacion.TabStop = False
        Me.gbx_liquidacion.Text = "Liquidación de Maquinaria"
        '
        'cmb_viajes
        '
        Me.cmb_viajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_viajes.FormattingEnabled = True
        Me.cmb_viajes.Location = New System.Drawing.Point(142, 86)
        Me.cmb_viajes.Name = "cmb_viajes"
        Me.cmb_viajes.Size = New System.Drawing.Size(334, 21)
        Me.cmb_viajes.TabIndex = 1143
        '
        'lbl_viaje
        '
        Me.lbl_viaje.AutoSize = True
        Me.lbl_viaje.Location = New System.Drawing.Point(26, 85)
        Me.lbl_viaje.Name = "lbl_viaje"
        Me.lbl_viaje.Size = New System.Drawing.Size(85, 13)
        Me.lbl_viaje.TabIndex = 1144
        Me.lbl_viaje.Text = "TIPO DE VIAJE:"
        '
        'txt_m3_km
        '
        Me.txt_m3_km.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_m3_km.Location = New System.Drawing.Point(142, 60)
        Me.txt_m3_km.MaxLength = 15
        Me.txt_m3_km.Name = "txt_m3_km"
        Me.txt_m3_km.Size = New System.Drawing.Size(138, 20)
        Me.txt_m3_km.TabIndex = 1141
        Me.txt_m3_km.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 1142
        Me.Label3.Text = "VIAJES:"
        '
        'cmb_equipo
        '
        Me.cmb_equipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_equipo.FormattingEnabled = True
        Me.cmb_equipo.Location = New System.Drawing.Point(142, 33)
        Me.cmb_equipo.Name = "cmb_equipo"
        Me.cmb_equipo.Size = New System.Drawing.Size(138, 21)
        Me.cmb_equipo.TabIndex = 0
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(293, 36)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(45, 13)
        Me.label7.TabIndex = 1096
        Me.label7.Text = "FECHA:"
        '
        'txt_fecha
        '
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(344, 33)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(132, 20)
        Me.txt_fecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1090
        Me.Label1.Text = "CÓDIGO MÁQUINA:"
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(110, 168)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(61, 52)
        Me.btn_editar.TabIndex = 1
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(311, 168)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(61, 52)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(43, 168)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(61, 52)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(244, 168)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(61, 52)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(177, 168)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(61, 52)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgv_viajes
        '
        Me.dgv_viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_viajes.Location = New System.Drawing.Point(12, -5)
        Me.dgv_viajes.Name = "dgv_viajes"
        Me.dgv_viajes.Size = New System.Drawing.Size(10, 10)
        Me.dgv_viajes.TabIndex = 1087
        Me.dgv_viajes.Visible = False
        '
        'Frm_liquidacion_maq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 247)
        Me.Controls.Add(Me.dgv_viajes)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgv_liquidacion)
        Me.Controls.Add(Me.gbx_liquidacion)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_liquidacion_maq"
        Me.Text = "REGISTRO VIAJES"
        CType(Me.dgv_liquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_liquidacion.ResumeLayout(False)
        Me.gbx_liquidacion.PerformLayout()
        CType(Me.dgv_viajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgv_liquidacion As System.Windows.Forms.DataGridView
    Private WithEvents gbx_liquidacion As System.Windows.Forms.GroupBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_equipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txt_m3_km As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_viajes As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_viaje As System.Windows.Forms.Label
    Friend WithEvents dgv_viajes As System.Windows.Forms.DataGridView
End Class
