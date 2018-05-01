<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_antiguedadgestor
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
        Me.crl_antiguedadgestor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crl_antiguedadgestor
        '
        Me.crl_antiguedadgestor.ActiveViewIndex = -1
        Me.crl_antiguedadgestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crl_antiguedadgestor.CachedPageNumberPerDoc = 10
        Me.crl_antiguedadgestor.Cursor = System.Windows.Forms.Cursors.Default
        Me.crl_antiguedadgestor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crl_antiguedadgestor.Location = New System.Drawing.Point(0, 0)
        Me.crl_antiguedadgestor.Name = "crl_antiguedadgestor"
        Me.crl_antiguedadgestor.Size = New System.Drawing.Size(964, 456)
        Me.crl_antiguedadgestor.TabIndex = 0
        '
        'frm_antiguedadgestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 456)
        Me.Controls.Add(Me.crl_antiguedadgestor)
        Me.Name = "frm_antiguedadgestor"
        Me.Text = "Antiguedad Gestor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crl_antiguedadgestor As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
