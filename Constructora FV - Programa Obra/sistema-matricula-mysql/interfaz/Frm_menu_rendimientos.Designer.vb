<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_menu_rendimientos
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
        Me.check_rendimientos = New System.Windows.Forms.CheckedListBox()
        Me.dgv_datos = New System.Windows.Forms.DataGridView()
        Me.dgv_check = New System.Windows.Forms.DataGridView()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_rendimientos = New System.Windows.Forms.Button()
        Me.pb_list = New System.Windows.Forms.ProgressBar()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_check, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'check_rendimientos
        '
        Me.check_rendimientos.FormattingEnabled = True
        Me.check_rendimientos.Location = New System.Drawing.Point(11, 11)
        Me.check_rendimientos.Margin = New System.Windows.Forms.Padding(2)
        Me.check_rendimientos.Name = "check_rendimientos"
        Me.check_rendimientos.Size = New System.Drawing.Size(403, 394)
        Me.check_rendimientos.TabIndex = 1208
        '
        'dgv_datos
        '
        Me.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos.Location = New System.Drawing.Point(451, 11)
        Me.dgv_datos.Name = "dgv_datos"
        Me.dgv_datos.Size = New System.Drawing.Size(10, 10)
        Me.dgv_datos.TabIndex = 1209
        Me.dgv_datos.Visible = False
        '
        'dgv_check
        '
        Me.dgv_check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_check.Location = New System.Drawing.Point(435, 11)
        Me.dgv_check.Name = "dgv_check"
        Me.dgv_check.Size = New System.Drawing.Size(10, 10)
        Me.dgv_check.TabIndex = 1210
        Me.dgv_check.Visible = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.Red
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(435, 372)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(108, 33)
        Me.btn_cerrar.TabIndex = 1211
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.Location = New System.Drawing.Point(435, 28)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(108, 39)
        Me.btn_seleccionar.TabIndex = 1212
        Me.btn_seleccionar.Text = "Seleccionar Todos"
        Me.btn_seleccionar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(435, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 39)
        Me.Button1.TabIndex = 1213
        Me.Button1.Text = "Deseleccionar Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_rendimientos
        '
        Me.btn_rendimientos.BackColor = System.Drawing.Color.Lime
        Me.btn_rendimientos.ForeColor = System.Drawing.Color.Black
        Me.btn_rendimientos.Location = New System.Drawing.Point(435, 177)
        Me.btn_rendimientos.Name = "btn_rendimientos"
        Me.btn_rendimientos.Size = New System.Drawing.Size(108, 59)
        Me.btn_rendimientos.TabIndex = 1214
        Me.btn_rendimientos.Text = "Generar Informe Rendimientos"
        Me.btn_rendimientos.UseVisualStyleBackColor = False
        '
        'pb_list
        '
        Me.pb_list.Location = New System.Drawing.Point(435, 241)
        Me.pb_list.Margin = New System.Windows.Forms.Padding(2)
        Me.pb_list.Name = "pb_list"
        Me.pb_list.Size = New System.Drawing.Size(108, 19)
        Me.pb_list.TabIndex = 1215
        '
        'Frm_menu_rendimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(561, 447)
        Me.Controls.Add(Me.pb_list)
        Me.Controls.Add(Me.btn_rendimientos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.dgv_check)
        Me.Controls.Add(Me.dgv_datos)
        Me.Controls.Add(Me.check_rendimientos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_menu_rendimientos"
        Me.Text = "Elección Tipo de Máquina"
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_check, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents check_rendimientos As System.Windows.Forms.CheckedListBox
    Friend WithEvents dgv_datos As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_check As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_seleccionar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_rendimientos As System.Windows.Forms.Button
    Friend WithEvents pb_list As System.Windows.Forms.ProgressBar
End Class
