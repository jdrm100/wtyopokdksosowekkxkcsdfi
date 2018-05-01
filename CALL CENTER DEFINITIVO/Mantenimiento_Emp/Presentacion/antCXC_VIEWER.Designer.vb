<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class antCXC_VIEWER
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
        Me.AntCXC_v = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'AntCXC_v
        '
        Me.AntCXC_v.ActiveViewIndex = -1
        Me.AntCXC_v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AntCXC_v.Cursor = System.Windows.Forms.Cursors.Default
        Me.AntCXC_v.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AntCXC_v.Location = New System.Drawing.Point(0, 0)
        Me.AntCXC_v.Name = "AntCXC_v"
        Me.AntCXC_v.Size = New System.Drawing.Size(596, 369)
        Me.AntCXC_v.TabIndex = 0
        '
        'antCXC_VIEWER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 369)
        Me.Controls.Add(Me.AntCXC_v)
        Me.Name = "antCXC_VIEWER"
        Me.Text = "antCXC_VIEWER"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AntCXC_v As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
