<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistema_de_Facturacion_Reporte_de_Recarga
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
        Me.Crystal_reporterecargaresumido = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Crystal_reporterecargaresumido
        '
        Me.Crystal_reporterecargaresumido.ActiveViewIndex = -1
        Me.Crystal_reporterecargaresumido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crystal_reporterecargaresumido.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crystal_reporterecargaresumido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crystal_reporterecargaresumido.Location = New System.Drawing.Point(0, 0)
        Me.Crystal_reporterecargaresumido.Name = "Crystal_reporterecargaresumido"
        Me.Crystal_reporterecargaresumido.Size = New System.Drawing.Size(844, 476)
        Me.Crystal_reporterecargaresumido.TabIndex = 0
        '
        'frmSistema_de_Facturacion_Reporte_de_Recarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 476)
        Me.Controls.Add(Me.Crystal_reporterecargaresumido)
        Me.Name = "frmSistema_de_Facturacion_Reporte_de_Recarga"
        Me.Text = "Sistema_de_Facturacion_Reporte_de_Recarga"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Crystal_reporterecargaresumido As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
