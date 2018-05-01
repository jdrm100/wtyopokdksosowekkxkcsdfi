<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ssitema_de_Facturacion_Transanciones
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
        Me.Crystal_reporterecargatrans = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Crystal_reporterecargatrans
        '
        Me.Crystal_reporterecargatrans.ActiveViewIndex = -1
        Me.Crystal_reporterecargatrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crystal_reporterecargatrans.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crystal_reporterecargatrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crystal_reporterecargatrans.Location = New System.Drawing.Point(0, 0)
        Me.Crystal_reporterecargatrans.Name = "Crystal_reporterecargatrans"
        Me.Crystal_reporterecargatrans.Size = New System.Drawing.Size(402, 398)
        Me.Crystal_reporterecargatrans.TabIndex = 0
        '
        'Ssitema_de_Facturacion_Transanciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 398)
        Me.Controls.Add(Me.Crystal_reporterecargatrans)
        Me.Name = "Ssitema_de_Facturacion_Transanciones"
        Me.Text = "Ssitema_de_Facturacion_Transanciones"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Crystal_reporterecargatrans As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
