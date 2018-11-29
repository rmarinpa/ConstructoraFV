<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_tablas = New System.Windows.Forms.DataGridView()
        Me.dgv_temporal = New System.Windows.Forms.DataGridView()
        Me.dgv_modifica = New System.Windows.Forms.DataGridView()
        Me.dgv1_sincroniza_remoto = New System.Windows.Forms.DataGridView()
        Me.dgv_sincroniza1 = New System.Windows.Forms.DataGridView()
        Me.pb_list = New System.Windows.Forms.ProgressBar()
        Me.btn_sincronizar = New System.Windows.Forms.Button()
        Me.dgv_login = New System.Windows.Forms.DataGridView()
        Me.btn_password = New System.Windows.Forms.Button()
        Me.cmb_conexion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_obra = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_tablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_temporal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_modifica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1_sincroniza_remoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sincroniza1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgv_tablas)
        Me.Panel1.Controls.Add(Me.dgv_temporal)
        Me.Panel1.Controls.Add(Me.dgv_modifica)
        Me.Panel1.Controls.Add(Me.dgv1_sincroniza_remoto)
        Me.Panel1.Controls.Add(Me.dgv_sincroniza1)
        Me.Panel1.Controls.Add(Me.pb_list)
        Me.Panel1.Controls.Add(Me.btn_sincronizar)
        Me.Panel1.Controls.Add(Me.dgv_login)
        Me.Panel1.Controls.Add(Me.btn_password)
        Me.Panel1.Controls.Add(Me.cmb_conexion)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmb_obra)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Controls.Add(Me.btn_entrar)
        Me.Panel1.Controls.Add(Me.txt_password)
        Me.Panel1.Controls.Add(Me.txt_username)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 304)
        Me.Panel1.TabIndex = 6
        '
        'dgv_tablas
        '
        Me.dgv_tablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tablas.Location = New System.Drawing.Point(393, 14)
        Me.dgv_tablas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_tablas.Name = "dgv_tablas"
        Me.dgv_tablas.RowTemplate.Height = 24
        Me.dgv_tablas.Size = New System.Drawing.Size(9, 8)
        Me.dgv_tablas.TabIndex = 73
        Me.dgv_tablas.Visible = False
        '
        'dgv_temporal
        '
        Me.dgv_temporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_temporal.Location = New System.Drawing.Point(381, 14)
        Me.dgv_temporal.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_temporal.Name = "dgv_temporal"
        Me.dgv_temporal.RowTemplate.Height = 24
        Me.dgv_temporal.Size = New System.Drawing.Size(8, 8)
        Me.dgv_temporal.TabIndex = 72
        Me.dgv_temporal.Visible = False
        '
        'dgv_modifica
        '
        Me.dgv_modifica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_modifica.Location = New System.Drawing.Point(369, 14)
        Me.dgv_modifica.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_modifica.Name = "dgv_modifica"
        Me.dgv_modifica.RowTemplate.Height = 24
        Me.dgv_modifica.Size = New System.Drawing.Size(8, 8)
        Me.dgv_modifica.TabIndex = 71
        Me.dgv_modifica.Visible = False
        '
        'dgv1_sincroniza_remoto
        '
        Me.dgv1_sincroniza_remoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1_sincroniza_remoto.Location = New System.Drawing.Point(357, 14)
        Me.dgv1_sincroniza_remoto.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv1_sincroniza_remoto.Name = "dgv1_sincroniza_remoto"
        Me.dgv1_sincroniza_remoto.RowTemplate.Height = 24
        Me.dgv1_sincroniza_remoto.Size = New System.Drawing.Size(8, 8)
        Me.dgv1_sincroniza_remoto.TabIndex = 70
        Me.dgv1_sincroniza_remoto.Visible = False
        '
        'dgv_sincroniza1
        '
        Me.dgv_sincroniza1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sincroniza1.Location = New System.Drawing.Point(345, 14)
        Me.dgv_sincroniza1.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_sincroniza1.Name = "dgv_sincroniza1"
        Me.dgv_sincroniza1.RowTemplate.Height = 24
        Me.dgv_sincroniza1.Size = New System.Drawing.Size(8, 8)
        Me.dgv_sincroniza1.TabIndex = 69
        Me.dgv_sincroniza1.Visible = False
        '
        'pb_list
        '
        Me.pb_list.Location = New System.Drawing.Point(247, 107)
        Me.pb_list.Margin = New System.Windows.Forms.Padding(2)
        Me.pb_list.Name = "pb_list"
        Me.pb_list.Size = New System.Drawing.Size(156, 19)
        Me.pb_list.TabIndex = 1
        '
        'btn_sincronizar
        '
        Me.btn_sincronizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_sincronizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_sincronizar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sincronizar.ForeColor = System.Drawing.Color.Black
        Me.btn_sincronizar.Location = New System.Drawing.Point(247, 76)
        Me.btn_sincronizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sincronizar.Name = "btn_sincronizar"
        Me.btn_sincronizar.Size = New System.Drawing.Size(156, 26)
        Me.btn_sincronizar.TabIndex = 0
        Me.btn_sincronizar.Text = "SINCRONIZAR USUARIOS"
        Me.btn_sincronizar.UseVisualStyleBackColor = False
        '
        'dgv_login
        '
        Me.dgv_login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_login.Location = New System.Drawing.Point(0, 0)
        Me.dgv_login.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_login.Name = "dgv_login"
        Me.dgv_login.RowTemplate.Height = 24
        Me.dgv_login.Size = New System.Drawing.Size(8, 8)
        Me.dgv_login.TabIndex = 19
        Me.dgv_login.Visible = False
        '
        'btn_password
        '
        Me.btn_password.BackColor = System.Drawing.Color.Yellow
        Me.btn_password.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_password.ForeColor = System.Drawing.Color.Black
        Me.btn_password.Location = New System.Drawing.Point(247, 266)
        Me.btn_password.Name = "btn_password"
        Me.btn_password.Size = New System.Drawing.Size(130, 23)
        Me.btn_password.TabIndex = 8
        Me.btn_password.Text = "Cambiar Contraseña"
        Me.btn_password.UseVisualStyleBackColor = False
        '
        'cmb_conexion
        '
        Me.cmb_conexion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_conexion.FormattingEnabled = True
        Me.cmb_conexion.Items.AddRange(New Object() {"Trabajar con Internet", "Trabajar sin Internet", " "})
        Me.cmb_conexion.Location = New System.Drawing.Point(146, 180)
        Me.cmb_conexion.Name = "cmb_conexion"
        Me.cmb_conexion.Size = New System.Drawing.Size(257, 21)
        Me.cmb_conexion.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "INTERNET:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "CENTRO DE COSTOS:"
        '
        'cmb_obra
        '
        Me.cmb_obra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_obra.FormattingEnabled = True
        Me.cmb_obra.Items.AddRange(New Object() {" "})
        Me.cmb_obra.Location = New System.Drawing.Point(146, 206)
        Me.cmb_obra.Name = "cmb_obra"
        Me.cmb_obra.Size = New System.Drawing.Size(257, 21)
        Me.cmb_obra.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 88)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CONSTRUCTORA FV S.A."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Yellow
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Location = New System.Drawing.Point(121, 266)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(120, 23)
        Me.btn_salir.TabIndex = 7
        Me.btn_salir.Text = "Cerrar Programa"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.Yellow
        Me.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.Black
        Me.btn_entrar.Location = New System.Drawing.Point(30, 266)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(83, 23)
        Me.btn_entrar.TabIndex = 6
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(146, 155)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(257, 20)
        Me.txt_password.TabIndex = 3
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(146, 131)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(257, 20)
        Me.txt_username.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CONTRASEÑA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "USUARIO:"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(432, 312)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_tablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_temporal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_modifica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1_sincroniza_remoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sincroniza1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_entrar As System.Windows.Forms.Button
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_obra As System.Windows.Forms.ComboBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents cmb_conexion As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_password As System.Windows.Forms.Button
    Friend WithEvents dgv_login As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_tablas As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_temporal As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_modifica As System.Windows.Forms.DataGridView
    Friend WithEvents dgv1_sincroniza_remoto As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_sincroniza1 As System.Windows.Forms.DataGridView
    Friend WithEvents pb_list As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_sincronizar As System.Windows.Forms.Button
End Class
