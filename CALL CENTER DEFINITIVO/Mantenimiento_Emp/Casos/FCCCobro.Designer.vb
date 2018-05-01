<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCCCobro
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTN_cobro = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(369, 190)
        Me.DataGridView1.TabIndex = 0
        '
        'BTN_cobro
        '
        Me.BTN_cobro.Location = New System.Drawing.Point(274, 30)
        Me.BTN_cobro.Name = "BTN_cobro"
        Me.BTN_cobro.Size = New System.Drawing.Size(107, 40)
        Me.BTN_cobro.TabIndex = 1
        Me.BTN_cobro.Text = "&Mostrar"
        Me.BTN_cobro.UseVisualStyleBackColor = True
        '
        'FCCCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(418, 332)
        Me.Controls.Add(Me.BTN_cobro)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FCCCobro"
        Me.Text = "FCCCobro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_cobro As System.Windows.Forms.Button
End Class
