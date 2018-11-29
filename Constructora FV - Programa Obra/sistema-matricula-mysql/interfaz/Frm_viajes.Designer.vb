<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_viajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_viajes))
        Me.dgv_viajes = New System.Windows.Forms.DataGridView()
        Me.gbx_viajes = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_1_cuenta = New System.Windows.Forms.ComboBox()
        Me.txt_km = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_m3_km = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ida_vuelta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.rdbtn_m3_km = New System.Windows.Forms.RadioButton()
        Me.rdbtn_viaje = New System.Windows.Forms.RadioButton()
        Me.gpb_tipo = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_viajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_viajes.SuspendLayout()
        Me.gpb_tipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_viajes
        '
        Me.dgv_viajes.AllowUserToAddRows = False
        Me.dgv_viajes.AllowUserToDeleteRows = False
        Me.dgv_viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_viajes.Location = New System.Drawing.Point(383, 12)
        Me.dgv_viajes.Name = "dgv_viajes"
        Me.dgv_viajes.ReadOnly = True
        Me.dgv_viajes.RowHeadersVisible = False
        Me.dgv_viajes.Size = New System.Drawing.Size(520, 232)
        Me.dgv_viajes.TabIndex = 1086
        '
        'gbx_viajes
        '
        Me.gbx_viajes.Controls.Add(Me.Label2)
        Me.gbx_viajes.Controls.Add(Me.cmb_1_cuenta)
        Me.gbx_viajes.Controls.Add(Me.txt_km)
        Me.gbx_viajes.Controls.Add(Me.Label1)
        Me.gbx_viajes.Controls.Add(Me.txt_m3_km)
        Me.gbx_viajes.Controls.Add(Me.Label3)
        Me.gbx_viajes.Controls.Add(Me.txt_ida_vuelta)
        Me.gbx_viajes.Controls.Add(Me.Label4)
        Me.gbx_viajes.Location = New System.Drawing.Point(-6, 61)
        Me.gbx_viajes.Name = "gbx_viajes"
        Me.gbx_viajes.Size = New System.Drawing.Size(383, 125)
        Me.gbx_viajes.TabIndex = 1085
        Me.gbx_viajes.TabStop = False
        Me.gbx_viajes.Text = "Viajes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 1146
        Me.Label2.Text = "CUENTA CONTABLE:"
        Me.Label2.Visible = False
        '
        'cmb_1_cuenta
        '
        Me.cmb_1_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_1_cuenta.FormattingEnabled = True
        Me.cmb_1_cuenta.Location = New System.Drawing.Point(137, 96)
        Me.cmb_1_cuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_1_cuenta.Name = "cmb_1_cuenta"
        Me.cmb_1_cuenta.Size = New System.Drawing.Size(240, 21)
        Me.cmb_1_cuenta.TabIndex = 1145
        Me.cmb_1_cuenta.Visible = False
        '
        'txt_km
        '
        Me.txt_km.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_km.Location = New System.Drawing.Point(137, 71)
        Me.txt_km.MaxLength = 15
        Me.txt_km.Name = "txt_km"
        Me.txt_km.Size = New System.Drawing.Size(240, 20)
        Me.txt_km.TabIndex = 1143
        Me.txt_km.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1144
        Me.Label1.Text = "KILOMETRAJE:"
        '
        'txt_m3_km
        '
        Me.txt_m3_km.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_m3_km.Location = New System.Drawing.Point(137, 45)
        Me.txt_m3_km.MaxLength = 15
        Me.txt_m3_km.Name = "txt_m3_km"
        Me.txt_m3_km.Size = New System.Drawing.Size(240, 20)
        Me.txt_m3_km.TabIndex = 1141
        Me.txt_m3_km.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 1142
        Me.Label3.Text = "PRECIO M3-KM:"
        '
        'txt_ida_vuelta
        '
        Me.txt_ida_vuelta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_ida_vuelta.Location = New System.Drawing.Point(137, 19)
        Me.txt_ida_vuelta.MaxLength = 50
        Me.txt_ida_vuelta.Name = "txt_ida_vuelta"
        Me.txt_ida_vuelta.Size = New System.Drawing.Size(240, 20)
        Me.txt_ida_vuelta.TabIndex = 6
        Me.txt_ida_vuelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 1088
        Me.Label4.Text = "NOMBRE VIAJE:"
        '
        'btn_editar
        '
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(82, 192)
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
        Me.btn_cancelar.Location = New System.Drawing.Point(283, 192)
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
        Me.btn_nuevo.Location = New System.Drawing.Point(15, 192)
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
        Me.btn_guardar.Location = New System.Drawing.Point(216, 190)
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
        Me.btnEliminar.Location = New System.Drawing.Point(149, 192)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(61, 52)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'rdbtn_m3_km
        '
        Me.rdbtn_m3_km.AutoSize = True
        Me.rdbtn_m3_km.Location = New System.Drawing.Point(21, 19)
        Me.rdbtn_m3_km.Name = "rdbtn_m3_km"
        Me.rdbtn_m3_km.Size = New System.Drawing.Size(59, 17)
        Me.rdbtn_m3_km.TabIndex = 1147
        Me.rdbtn_m3_km.TabStop = True
        Me.rdbtn_m3_km.Text = "M3-KM"
        Me.rdbtn_m3_km.UseVisualStyleBackColor = True
        '
        'rdbtn_viaje
        '
        Me.rdbtn_viaje.AutoSize = True
        Me.rdbtn_viaje.Location = New System.Drawing.Point(117, 19)
        Me.rdbtn_viaje.Name = "rdbtn_viaje"
        Me.rdbtn_viaje.Size = New System.Drawing.Size(67, 17)
        Me.rdbtn_viaje.TabIndex = 1148
        Me.rdbtn_viaje.TabStop = True
        Me.rdbtn_viaje.Text = "Por Viaje"
        Me.rdbtn_viaje.UseVisualStyleBackColor = True
        '
        'gpb_tipo
        '
        Me.gpb_tipo.Controls.Add(Me.rdbtn_m3_km)
        Me.gpb_tipo.Controls.Add(Me.rdbtn_viaje)
        Me.gpb_tipo.Location = New System.Drawing.Point(5, 7)
        Me.gpb_tipo.Name = "gpb_tipo"
        Me.gpb_tipo.Size = New System.Drawing.Size(220, 48)
        Me.gpb_tipo.TabIndex = 1149
        Me.gpb_tipo.TabStop = False
        Me.gpb_tipo.Text = "Tipo de Cobro"
        '
        'Frm_viajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 254)
        Me.Controls.Add(Me.gpb_tipo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgv_viajes)
        Me.Controls.Add(Me.gbx_viajes)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_viajes"
        Me.Text = "DEFINICIÓN VIAJES"
        CType(Me.dgv_viajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_viajes.ResumeLayout(False)
        Me.gbx_viajes.PerformLayout()
        Me.gpb_tipo.ResumeLayout(False)
        Me.gpb_tipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgv_viajes As System.Windows.Forms.DataGridView
    Private WithEvents gbx_viajes As System.Windows.Forms.GroupBox
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txt_ida_vuelta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_m3_km As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_km As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_1_cuenta As System.Windows.Forms.ComboBox
    Friend WithEvents rdbtn_m3_km As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn_viaje As System.Windows.Forms.RadioButton
    Friend WithEvents gpb_tipo As System.Windows.Forms.GroupBox
End Class
