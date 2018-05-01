<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ANTIGUEDAD_GESTOR_CONTABILIDAD_VIEWER
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
        Me.ANT_GES_CONT_VW = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ANT_GES_CONT_VW
        '
        Me.ANT_GES_CONT_VW.ActiveViewIndex = -1
        Me.ANT_GES_CONT_VW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ANT_GES_CONT_VW.Cursor = System.Windows.Forms.Cursors.Default
        Me.ANT_GES_CONT_VW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ANT_GES_CONT_VW.Location = New System.Drawing.Point(0, 0)
        Me.ANT_GES_CONT_VW.Name = "ANT_GES_CONT_VW"
        Me.ANT_GES_CONT_VW.Size = New System.Drawing.Size(796, 410)
        Me.ANT_GES_CONT_VW.TabIndex = 0
        '
        'ANTIGUEDAD_GESTOR_CONTABILIDAD_VIEWER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 410)
        Me.Controls.Add(Me.ANT_GES_CONT_VW)
        Me.Name = "ANTIGUEDAD_GESTOR_CONTABILIDAD_VIEWER"
        Me.Text = "ANTIGUEDAD_GESTOR_CONTABILIDAD_VIEWER"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ANT_GES_CONT_VW As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
