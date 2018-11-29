<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CR_Informe_rendimiento
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Libro_compras1 = New Constructora_FV.Libro_compras()
        Me.Crrevision_petroleo1 = New Constructora_FV.Crrevision_petroleo()
        Me.Estado_de_pago1 = New Constructora_FV.Estado_de_pago()
        Me.Crrevision_rendimiento_Los_marios1 = New Constructora_FV.Crrevision_rendimiento_Los_marios()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.CachedPageNumberPerDoc = 10
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Crrevision_rendimiento_Los_marios1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1079, 541)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'CR_Informe_rendimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 541)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "CR_Informe_rendimiento"
        Me.Text = "Informe Rendimiento"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Estado_de_pago1 As Constructora_FV.Estado_de_pago
    Friend WithEvents Crrevision_petroleo1 As Constructora_FV.Crrevision_petroleo
    Friend WithEvents Libro_compras1 As Constructora_FV.Libro_compras
    Friend WithEvents Crrevision_rendimiento_Los_marios1 As Constructora_FV.Crrevision_rendimiento_Los_marios
End Class
