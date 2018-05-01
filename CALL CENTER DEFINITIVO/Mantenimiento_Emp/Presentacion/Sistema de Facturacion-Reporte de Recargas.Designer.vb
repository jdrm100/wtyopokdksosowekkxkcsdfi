<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Sistema_de_Facturacion_Reporte_de_Recargas
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
        Me.Crystal_reporterecargadetallada = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Crystal_reporterecargadetallada
        '
        Me.Crystal_reporterecargadetallada.ActiveViewIndex = -1
        Me.Crystal_reporterecargadetallada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crystal_reporterecargadetallada.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crystal_reporterecargadetallada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crystal_reporterecargadetallada.Location = New System.Drawing.Point(0, 0)
        Me.Crystal_reporterecargadetallada.Name = "Crystal_reporterecargadetallada"
        Me.Crystal_reporterecargadetallada.Size = New System.Drawing.Size(678, 522)
        Me.Crystal_reporterecargadetallada.TabIndex = 0
        '
        'frm_Sistema_de_Facturacion_Reporte_de_Recargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 522)
        Me.Controls.Add(Me.Crystal_reporterecargadetallada)
        Me.Name = "frm_Sistema_de_Facturacion_Reporte_de_Recargas"
        Me.Text = "Sistema_de_Facturacion_Reporte_de_Recargas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Crystal_reporterecargadetallada As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
