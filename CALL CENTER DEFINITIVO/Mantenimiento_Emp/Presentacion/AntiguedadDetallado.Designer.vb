<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AntiguedadDetallado
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
        Me.FVR_AntiguedadDetallado = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'FVR_AntiguedadDetallado
        '
        Me.FVR_AntiguedadDetallado.ActiveViewIndex = -1
        Me.FVR_AntiguedadDetallado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FVR_AntiguedadDetallado.Cursor = System.Windows.Forms.Cursors.Default
        Me.FVR_AntiguedadDetallado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FVR_AntiguedadDetallado.Location = New System.Drawing.Point(0, 0)
        Me.FVR_AntiguedadDetallado.Name = "FVR_AntiguedadDetallado"
        Me.FVR_AntiguedadDetallado.Size = New System.Drawing.Size(974, 487)
        Me.FVR_AntiguedadDetallado.TabIndex = 0
        '
        'AntiguedadDetallado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 487)
        Me.Controls.Add(Me.FVR_AntiguedadDetallado)
        Me.Name = "AntiguedadDetallado"
        Me.Text = "AntiguedadDetallado"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FVR_AntiguedadDetallado As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
