<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CXC_GESTOR_VIWER
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
        Me.GESTOR_VIEWER_CXC = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'GESTOR_VIEWER_CXC
        '
        Me.GESTOR_VIEWER_CXC.ActiveViewIndex = -1
        Me.GESTOR_VIEWER_CXC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GESTOR_VIEWER_CXC.Cursor = System.Windows.Forms.Cursors.Default
        Me.GESTOR_VIEWER_CXC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GESTOR_VIEWER_CXC.Location = New System.Drawing.Point(0, 0)
        Me.GESTOR_VIEWER_CXC.Name = "GESTOR_VIEWER_CXC"
        Me.GESTOR_VIEWER_CXC.Size = New System.Drawing.Size(777, 460)
        Me.GESTOR_VIEWER_CXC.TabIndex = 0
        '
        'CXC_GESTOR_VIWER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 460)
        Me.Controls.Add(Me.GESTOR_VIEWER_CXC)
        Me.Name = "CXC_GESTOR_VIWER"
        Me.Text = "CXC_GESTOR_VIWER"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GESTOR_VIEWER_CXC As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
