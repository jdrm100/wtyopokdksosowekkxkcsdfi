﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Bloqueo_vista
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
        Me.CrystalBloqueo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalBloqueo
        '
        Me.CrystalBloqueo.ActiveViewIndex = -1
        Me.CrystalBloqueo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalBloqueo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalBloqueo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalBloqueo.Location = New System.Drawing.Point(0, 0)
        Me.CrystalBloqueo.Name = "CrystalBloqueo"
        Me.CrystalBloqueo.Size = New System.Drawing.Size(533, 408)
        Me.CrystalBloqueo.TabIndex = 0
        '
        'Reporte_Bloqueo_vista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 408)
        Me.Controls.Add(Me.CrystalBloqueo)
        Me.Name = "Reporte_Bloqueo_vista"
        Me.Text = "Reporte_Bloqueo_vista"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalBloqueo As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
