<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ges_aux
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_selected = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgv_ges = New System.Windows.Forms.DataGridView()
        Me.nomges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.tt_ges = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_ges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_selected)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.dgv_ges)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 318)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCION DE GESTOR"
        '
        'lbl_selected
        '
        Me.lbl_selected.AutoSize = True
        Me.lbl_selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_selected.ForeColor = System.Drawing.Color.Black
        Me.lbl_selected.Location = New System.Drawing.Point(96, 302)
        Me.lbl_selected.Name = "lbl_selected"
        Me.lbl_selected.Size = New System.Drawing.Size(14, 13)
        Me.lbl_selected.TabIndex = 57
        Me.lbl_selected.Text = "1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(6, 302)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 13)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Seleccionados:"
        '
        'dgv_ges
        '
        Me.dgv_ges.AllowUserToAddRows = False
        Me.dgv_ges.AllowUserToDeleteRows = False
        Me.dgv_ges.AllowUserToOrderColumns = True
        Me.dgv_ges.AllowUserToResizeRows = False
        Me.dgv_ges.BackgroundColor = System.Drawing.Color.White
        Me.dgv_ges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_ges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ges.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomges})
        Me.dgv_ges.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_ges.Location = New System.Drawing.Point(6, 19)
        Me.dgv_ges.Name = "dgv_ges"
        Me.dgv_ges.ReadOnly = True
        Me.dgv_ges.RowHeadersVisible = False
        Me.dgv_ges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ges.Size = New System.Drawing.Size(279, 280)
        Me.dgv_ges.TabIndex = 1
        '
        'nomges
        '
        Me.nomges.DataPropertyName = "nomges"
        Me.nomges.HeaderText = "NOMBRE DE GESTOR"
        Me.nomges.Name = "nomges"
        Me.nomges.ReadOnly = True
        Me.nomges.Width = 225
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_aceptar)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Location = New System.Drawing.Point(12, 332)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 44)
        Me.Panel1.TabIndex = 6
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.White
        Me.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = Global.My.Resources.Resources.Clear_Green_Button
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.Location = New System.Drawing.Point(27, 3)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(98, 37)
        Me.btn_aceptar.TabIndex = 53
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tt_ges.SetToolTip(Me.btn_aceptar, "Cancelar")
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.White
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar.Image = Global.My.Resources.Resources.Cancel_Red_Button
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_cancelar.Location = New System.Drawing.Point(166, 3)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(98, 37)
        Me.btn_cancelar.TabIndex = 52
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tt_ges.SetToolTip(Me.btn_cancelar, "Cancelar")
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'ges_aux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(319, 377)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ges_aux"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_ges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_ges As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents tt_ges As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_selected As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents nomges As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
