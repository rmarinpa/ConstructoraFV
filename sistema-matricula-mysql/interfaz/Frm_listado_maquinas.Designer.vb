<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_listado_maquinas
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
        Me.cmb_ordenar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_obra = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tipo_equipo = New System.Windows.Forms.ComboBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.btn_detalle_ep = New System.Windows.Forms.Button()
        Me.btn_detalle_obra = New System.Windows.Forms.Button()
        Me.cmb_activo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbx_liquidacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_liquidacion
        '
        Me.gbx_liquidacion.Controls.Add(Me.Label3)
        Me.gbx_liquidacion.Controls.Add(Me.cmb_activo)
        Me.gbx_liquidacion.Controls.Add(Me.cmb_ordenar)
        Me.gbx_liquidacion.Controls.Add(Me.Label2)
        Me.gbx_liquidacion.Controls.Add(Me.cmb_obra)
        Me.gbx_liquidacion.Controls.Add(Me.Label1)
        Me.gbx_liquidacion.Controls.Add(Me.cmb_tipo_equipo)
        Me.gbx_liquidacion.Controls.Add(Me.Label80)
        Me.gbx_liquidacion.Location = New System.Drawing.Point(12, 11)
        Me.gbx_liquidacion.Name = "gbx_liquidacion"
        Me.gbx_liquidacion.Size = New System.Drawing.Size(508, 139)
        Me.gbx_liquidacion.TabIndex = 1085
        Me.gbx_liquidacion.TabStop = False
        '
        'cmb_ordenar
        '
        Me.cmb_ordenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ordenar.FormattingEnabled = True
        Me.cmb_ordenar.Items.AddRange(New Object() {"Tipo de Equipo", "Arrendador"})
        Me.cmb_ordenar.Location = New System.Drawing.Point(91, 68)
        Me.cmb_ordenar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_ordenar.Name = "cmb_ordenar"
        Me.cmb_ordenar.Size = New System.Drawing.Size(402, 21)
        Me.cmb_ordenar.TabIndex = 1215
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1216
        Me.Label2.Text = "Ordenar por"
        '
        'cmb_obra
        '
        Me.cmb_obra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_obra.FormattingEnabled = True
        Me.cmb_obra.Location = New System.Drawing.Point(91, 18)
        Me.cmb_obra.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_obra.Name = "cmb_obra"
        Me.cmb_obra.Size = New System.Drawing.Size(402, 21)
        Me.cmb_obra.TabIndex = 1213
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1214
        Me.Label1.Text = "Obra"
        '
        'cmb_tipo_equipo
        '
        Me.cmb_tipo_equipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_equipo.FormattingEnabled = True
        Me.cmb_tipo_equipo.Items.AddRange(New Object() {"Todos", "Bulldozer", "Excavadora", "Retroexcavadora", "Cargador Frontal", "Motoniveladora", "Rodillo Liso  Movimiento de Tierra", "Rodillo Liso Asfalto", "Rodillo Neumático", "Finisher", "Camión Tolva", "Camión 3/4", "Camión Aljibe", "Barredora", "Planta de Asfalto", "Chancador", "Seleccionadora", "Generador", "Pavimentadora", "Camión Pluma-Grúa", "Camión Imprimador", "Equipo Menor", "Camioneta", "Batea", "Rampla", "Rampla plana", "Grúa", "Mixer", "Bus", "Minibus", "Dosificadora de hormigon", "Otros"})
        Me.cmb_tipo_equipo.Location = New System.Drawing.Point(91, 43)
        Me.cmb_tipo_equipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipo_equipo.Name = "cmb_tipo_equipo"
        Me.cmb_tipo_equipo.Size = New System.Drawing.Size(402, 21)
        Me.cmb_tipo_equipo.TabIndex = 1207
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(3, 46)
        Me.Label80.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(79, 13)
        Me.Label80.TabIndex = 1211
        Me.Label80.Text = "Tipo de Equipo"
        '
        'btn_detalle_ep
        '
        Me.btn_detalle_ep.BackColor = System.Drawing.Color.Yellow
        Me.btn_detalle_ep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_detalle_ep.Location = New System.Drawing.Point(12, 155)
        Me.btn_detalle_ep.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_detalle_ep.Name = "btn_detalle_ep"
        Me.btn_detalle_ep.Size = New System.Drawing.Size(155, 45)
        Me.btn_detalle_ep.TabIndex = 1086
        Me.btn_detalle_ep.Text = "Volver"
        Me.btn_detalle_ep.UseVisualStyleBackColor = False
        '
        'btn_detalle_obra
        '
        Me.btn_detalle_obra.BackColor = System.Drawing.Color.Yellow
        Me.btn_detalle_obra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_detalle_obra.Location = New System.Drawing.Point(290, 155)
        Me.btn_detalle_obra.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_detalle_obra.Name = "btn_detalle_obra"
        Me.btn_detalle_obra.Size = New System.Drawing.Size(230, 45)
        Me.btn_detalle_obra.TabIndex = 1087
        Me.btn_detalle_obra.Text = "Generar Listado"
        Me.btn_detalle_obra.UseVisualStyleBackColor = False
        '
        'cmb_activo
        '
        Me.cmb_activo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_activo.FormattingEnabled = True
        Me.cmb_activo.Items.AddRange(New Object() {"Todos", "SI", "NO"})
        Me.cmb_activo.Location = New System.Drawing.Point(91, 93)
        Me.cmb_activo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_activo.Name = "cmb_activo"
        Me.cmb_activo.Size = New System.Drawing.Size(402, 21)
        Me.cmb_activo.TabIndex = 1217
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-1, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 1218
        Me.Label3.Text = "Equipos Activos"
        '
        'Frm_listado_maquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 216)
        Me.Controls.Add(Me.btn_detalle_obra)
        Me.Controls.Add(Me.btn_detalle_ep)
        Me.Controls.Add(Me.gbx_liquidacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_listado_maquinas"
        Me.Text = "Listado Maquinaria"
        Me.gbx_liquidacion.ResumeLayout(False)
        Me.gbx_liquidacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbx_liquidacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_obra As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_equipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents btn_detalle_ep As System.Windows.Forms.Button
    Friend WithEvents btn_detalle_obra As System.Windows.Forms.Button
    Friend WithEvents cmb_ordenar As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_activo As System.Windows.Forms.ComboBox
End Class
