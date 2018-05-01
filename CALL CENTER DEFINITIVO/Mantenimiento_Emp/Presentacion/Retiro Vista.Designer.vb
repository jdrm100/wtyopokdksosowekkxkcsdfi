<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retiro_Vista
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
        Me.Crystalretiro = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Crystalretiro
        '
        Me.Crystalretiro.ActiveViewIndex = -1
        Me.Crystalretiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crystalretiro.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crystalretiro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crystalretiro.Location = New System.Drawing.Point(0, 0)
        Me.Crystalretiro.Name = "Crystalretiro"
        Me.Crystalretiro.Size = New System.Drawing.Size(624, 431)
        Me.Crystalretiro.TabIndex = 0
        '
        'Retiro_Vista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 431)
        Me.Controls.Add(Me.Crystalretiro)
        Me.Name = "Retiro_Vista"
        Me.Text = "Retiro_Vista"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Crystalretiro As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
