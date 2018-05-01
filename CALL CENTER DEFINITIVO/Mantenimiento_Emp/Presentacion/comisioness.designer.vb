<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comisioness
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
        Me.ComisionesReprotControl = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComisionesReprotControl
        '
        Me.ComisionesReprotControl.ActiveViewIndex = -1
        Me.ComisionesReprotControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ComisionesReprotControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComisionesReprotControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComisionesReprotControl.Location = New System.Drawing.Point(0, 0)
        Me.ComisionesReprotControl.Name = "ComisionesReprotControl"
        Me.ComisionesReprotControl.Size = New System.Drawing.Size(593, 397)
        Me.ComisionesReprotControl.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'comisioness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 397)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComisionesReprotControl)
        Me.Name = "comisioness"
        Me.Text = "comisioness"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComisionesReprotControl As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
