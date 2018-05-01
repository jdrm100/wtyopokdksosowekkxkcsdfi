<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comp_age_aux
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_reg_age = New System.Windows.Forms.Label()
        Me.chk_selec = New System.Windows.Forms.CheckBox()
        Me.lbl_selected = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgv_comp = New System.Windows.Forms.DataGridView()
        Me.selec = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_comp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_aceptar)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Location = New System.Drawing.Point(3, 371)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 44)
        Me.Panel1.TabIndex = 8
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
        Me.btn_aceptar.Location = New System.Drawing.Point(192, 3)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(98, 37)
        Me.btn_aceptar.TabIndex = 53
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btn_cancelar.Location = New System.Drawing.Point(11, 3)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(98, 37)
        Me.btn_cancelar.TabIndex = 52
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_reg_age)
        Me.GroupBox1.Controls.Add(Me.chk_selec)
        Me.GroupBox1.Controls.Add(Me.lbl_selected)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.dgv_comp)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 353)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCION DE COMPONENTE"
        '
        'lbl_reg_age
        '
        Me.lbl_reg_age.AutoSize = True
        Me.lbl_reg_age.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_reg_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reg_age.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_reg_age.Location = New System.Drawing.Point(218, 21)
        Me.lbl_reg_age.Name = "lbl_reg_age"
        Me.lbl_reg_age.Size = New System.Drawing.Size(73, 16)
        Me.lbl_reg_age.TabIndex = 80
        Me.lbl_reg_age.Text = "Agente !!!"
        '
        'chk_selec
        '
        Me.chk_selec.AutoSize = True
        Me.chk_selec.Location = New System.Drawing.Point(11, 21)
        Me.chk_selec.Name = "chk_selec"
        Me.chk_selec.Size = New System.Drawing.Size(111, 17)
        Me.chk_selec.TabIndex = 43
        Me.chk_selec.Text = "Seleccionar todos"
        Me.chk_selec.UseVisualStyleBackColor = True
        '
        'lbl_selected
        '
        Me.lbl_selected.AutoSize = True
        Me.lbl_selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_selected.ForeColor = System.Drawing.Color.Black
        Me.lbl_selected.Location = New System.Drawing.Point(96, 337)
        Me.lbl_selected.Name = "lbl_selected"
        Me.lbl_selected.Size = New System.Drawing.Size(14, 13)
        Me.lbl_selected.TabIndex = 57
        Me.lbl_selected.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(6, 337)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 13)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Seleccionados:"
        '
        'dgv_comp
        '
        Me.dgv_comp.AllowUserToAddRows = False
        Me.dgv_comp.AllowUserToDeleteRows = False
        Me.dgv_comp.AllowUserToOrderColumns = True
        Me.dgv_comp.AllowUserToResizeRows = False
        Me.dgv_comp.BackgroundColor = System.Drawing.Color.White
        Me.dgv_comp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_comp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selec, Me.comp})
        Me.dgv_comp.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_comp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_comp.Location = New System.Drawing.Point(5, 42)
        Me.dgv_comp.Name = "dgv_comp"
        Me.dgv_comp.RowHeadersVisible = False
        Me.dgv_comp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_comp.Size = New System.Drawing.Size(286, 292)
        Me.dgv_comp.TabIndex = 1
        '
        'selec
        '
        Me.selec.HeaderText = ""
        Me.selec.Name = "selec"
        Me.selec.ReadOnly = True
        Me.selec.Width = 30
        '
        'comp
        '
        Me.comp.DataPropertyName = "descripcion"
        Me.comp.HeaderText = "COMPONENTE"
        Me.comp.Name = "comp"
        Me.comp.ReadOnly = True
        Me.comp.Width = 215
        '
        'comp_age_aux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(301, 416)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "comp_age_aux"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LISTA DE COMPONENTES"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_comp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_selected As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chk_selec As System.Windows.Forms.CheckBox
    Public WithEvents dgv_comp As System.Windows.Forms.DataGridView
    Friend WithEvents selec As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_reg_age As System.Windows.Forms.Label
End Class
