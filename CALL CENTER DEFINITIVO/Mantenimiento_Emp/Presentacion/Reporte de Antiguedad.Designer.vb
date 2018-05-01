<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_de_Antiguedad
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
        Me.reporV_Antiguedad = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'reporV_Antiguedad
        '
        Me.reporV_Antiguedad.ActiveViewIndex = -1
        Me.reporV_Antiguedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reporV_Antiguedad.CachedPageNumberPerDoc = 10
        Me.reporV_Antiguedad.Cursor = System.Windows.Forms.Cursors.Default
        Me.reporV_Antiguedad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reporV_Antiguedad.Location = New System.Drawing.Point(0, 0)
        Me.reporV_Antiguedad.Name = "reporV_Antiguedad"
        Me.reporV_Antiguedad.Size = New System.Drawing.Size(929, 489)
        Me.reporV_Antiguedad.TabIndex = 0
        '
        'Reporte_de_Antiguedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 489)
        Me.Controls.Add(Me.reporV_Antiguedad)
        Me.Name = "Reporte_de_Antiguedad"
        Me.Text = "Reporte de Antiguedad"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reporV_Antiguedad As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
