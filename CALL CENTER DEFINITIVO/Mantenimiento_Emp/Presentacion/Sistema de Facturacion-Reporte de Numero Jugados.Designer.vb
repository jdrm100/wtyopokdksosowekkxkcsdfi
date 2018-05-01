<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sistema_de_Facturacion_Reporte_de_Numero_Jugados
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
        Me.CrystalReporteotnumerojugado = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReporteotnumerojugado
        '
        Me.CrystalReporteotnumerojugado.ActiveViewIndex = -1
        Me.CrystalReporteotnumerojugado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReporteotnumerojugado.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReporteotnumerojugado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReporteotnumerojugado.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReporteotnumerojugado.Name = "CrystalReporteotnumerojugado"
        Me.CrystalReporteotnumerojugado.Size = New System.Drawing.Size(575, 401)
        Me.CrystalReporteotnumerojugado.TabIndex = 0
        '
        'Sistema_de_Facturacion_Reporte_de_Numero_Jugados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 401)
        Me.Controls.Add(Me.CrystalReporteotnumerojugado)
        Me.Name = "Sistema_de_Facturacion_Reporte_de_Numero_Jugados"
        Me.Text = "Sistema_de_Facturacion_Reporte_de_Numero_Jugados"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReporteotnumerojugado As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
