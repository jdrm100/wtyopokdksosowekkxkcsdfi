<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cct_mant_comp_cara
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
        Me.gb_agente = New System.Windows.Forms.GroupBox()
        Me.btn_mod_comp = New System.Windows.Forms.Button()
        Me.txt_comp = New System.Windows.Forms.TextBox()
        Me.btn_acep_comp = New System.Windows.Forms.Button()
        Me.btn_quitar_comp = New System.Windows.Forms.Button()
        Me.dgv_comp = New System.Windows.Forms.DataGridView()
        Me.descripcion_comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_mod_cara = New System.Windows.Forms.Button()
        Me.txt_cara = New System.Windows.Forms.TextBox()
        Me.btn_acep_cara = New System.Windows.Forms.Button()
        Me.btn_quitar_cara = New System.Windows.Forms.Button()
        Me.dgv_cara = New System.Windows.Forms.DataGridView()
        Me.AGENTE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.gb_agente.SuspendLayout()
        CType(Me.dgv_comp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_cara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_agente
        '
        Me.gb_agente.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gb_agente.Controls.Add(Me.btn_mod_comp)
        Me.gb_agente.Controls.Add(Me.txt_comp)
        Me.gb_agente.Controls.Add(Me.btn_acep_comp)
        Me.gb_agente.Controls.Add(Me.btn_quitar_comp)
        Me.gb_agente.Controls.Add(Me.dgv_comp)
        Me.gb_agente.ForeColor = System.Drawing.Color.Navy
        Me.gb_agente.Location = New System.Drawing.Point(6, 6)
        Me.gb_agente.Name = "gb_agente"
        Me.gb_agente.Size = New System.Drawing.Size(278, 307)
        Me.gb_agente.TabIndex = 54
        Me.gb_agente.TabStop = False
        Me.gb_agente.Text = "Creacion / Modificacion de Componentes"
        '
        'btn_mod_comp
        '
        Me.btn_mod_comp.BackColor = System.Drawing.Color.White
        Me.btn_mod_comp.BackgroundImage = Global.My.Resources.Resources.Pencil
        Me.btn_mod_comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_mod_comp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mod_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod_comp.ForeColor = System.Drawing.Color.Black
        Me.btn_mod_comp.Location = New System.Drawing.Point(245, 44)
        Me.btn_mod_comp.Name = "btn_mod_comp"
        Me.btn_mod_comp.Size = New System.Drawing.Size(25, 26)
        Me.btn_mod_comp.TabIndex = 62
        Me.btn_mod_comp.UseVisualStyleBackColor = False
        '
        'txt_comp
        '
        Me.txt_comp.Location = New System.Drawing.Point(6, 18)
        Me.txt_comp.Name = "txt_comp"
        Me.txt_comp.Size = New System.Drawing.Size(233, 20)
        Me.txt_comp.TabIndex = 61
        Me.txt_comp.Tag = "0"
        '
        'btn_acep_comp
        '
        Me.btn_acep_comp.BackColor = System.Drawing.Color.White
        Me.btn_acep_comp.BackgroundImage = Global.My.Resources.Resources.accept
        Me.btn_acep_comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_acep_comp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_acep_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acep_comp.ForeColor = System.Drawing.Color.Black
        Me.btn_acep_comp.Location = New System.Drawing.Point(245, 14)
        Me.btn_acep_comp.Name = "btn_acep_comp"
        Me.btn_acep_comp.Size = New System.Drawing.Size(25, 26)
        Me.btn_acep_comp.TabIndex = 60
        Me.btn_acep_comp.UseVisualStyleBackColor = False
        '
        'btn_quitar_comp
        '
        Me.btn_quitar_comp.BackColor = System.Drawing.Color.White
        Me.btn_quitar_comp.BackgroundImage = Global.My.Resources.Resources.Delete1
        Me.btn_quitar_comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_comp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quitar_comp.Enabled = False
        Me.btn_quitar_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar_comp.ForeColor = System.Drawing.Color.Black
        Me.btn_quitar_comp.Location = New System.Drawing.Point(245, 76)
        Me.btn_quitar_comp.Name = "btn_quitar_comp"
        Me.btn_quitar_comp.Size = New System.Drawing.Size(25, 26)
        Me.btn_quitar_comp.TabIndex = 51
        Me.btn_quitar_comp.UseVisualStyleBackColor = False
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
        Me.dgv_comp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descripcion_comp})
        Me.dgv_comp.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_comp.Location = New System.Drawing.Point(6, 44)
        Me.dgv_comp.MultiSelect = False
        Me.dgv_comp.Name = "dgv_comp"
        Me.dgv_comp.ReadOnly = True
        Me.dgv_comp.RowHeadersVisible = False
        Me.dgv_comp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_comp.Size = New System.Drawing.Size(235, 257)
        Me.dgv_comp.TabIndex = 1
        '
        'descripcion_comp
        '
        Me.descripcion_comp.DataPropertyName = "descripcion"
        Me.descripcion_comp.HeaderText = "COMPONENTES"
        Me.descripcion_comp.Name = "descripcion_comp"
        Me.descripcion_comp.ReadOnly = True
        Me.descripcion_comp.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.btn_mod_cara)
        Me.GroupBox1.Controls.Add(Me.txt_cara)
        Me.GroupBox1.Controls.Add(Me.btn_acep_cara)
        Me.GroupBox1.Controls.Add(Me.btn_quitar_cara)
        Me.GroupBox1.Controls.Add(Me.dgv_cara)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(290, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 307)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creacion / Modificacion de Caracteristicas"
        '
        'btn_mod_cara
        '
        Me.btn_mod_cara.BackColor = System.Drawing.Color.White
        Me.btn_mod_cara.BackgroundImage = Global.My.Resources.Resources.Pencil
        Me.btn_mod_cara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_mod_cara.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mod_cara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod_cara.ForeColor = System.Drawing.Color.Black
        Me.btn_mod_cara.Location = New System.Drawing.Point(286, 44)
        Me.btn_mod_cara.Name = "btn_mod_cara"
        Me.btn_mod_cara.Size = New System.Drawing.Size(25, 26)
        Me.btn_mod_cara.TabIndex = 75
        Me.btn_mod_cara.UseVisualStyleBackColor = False
        '
        'txt_cara
        '
        Me.txt_cara.Location = New System.Drawing.Point(6, 20)
        Me.txt_cara.Name = "txt_cara"
        Me.txt_cara.Size = New System.Drawing.Size(274, 20)
        Me.txt_cara.TabIndex = 74
        Me.txt_cara.Tag = "0"
        '
        'btn_acep_cara
        '
        Me.btn_acep_cara.BackColor = System.Drawing.Color.White
        Me.btn_acep_cara.BackgroundImage = Global.My.Resources.Resources.accept
        Me.btn_acep_cara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_acep_cara.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_acep_cara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acep_cara.ForeColor = System.Drawing.Color.Black
        Me.btn_acep_cara.Location = New System.Drawing.Point(286, 14)
        Me.btn_acep_cara.Name = "btn_acep_cara"
        Me.btn_acep_cara.Size = New System.Drawing.Size(25, 26)
        Me.btn_acep_cara.TabIndex = 73
        Me.btn_acep_cara.UseVisualStyleBackColor = False
        '
        'btn_quitar_cara
        '
        Me.btn_quitar_cara.BackColor = System.Drawing.Color.White
        Me.btn_quitar_cara.BackgroundImage = Global.My.Resources.Resources.Delete1
        Me.btn_quitar_cara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_cara.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quitar_cara.Enabled = False
        Me.btn_quitar_cara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar_cara.ForeColor = System.Drawing.Color.Black
        Me.btn_quitar_cara.Location = New System.Drawing.Point(286, 76)
        Me.btn_quitar_cara.Name = "btn_quitar_cara"
        Me.btn_quitar_cara.Size = New System.Drawing.Size(25, 26)
        Me.btn_quitar_cara.TabIndex = 72
        Me.btn_quitar_cara.UseVisualStyleBackColor = False
        '
        'dgv_cara
        '
        Me.dgv_cara.AllowUserToAddRows = False
        Me.dgv_cara.AllowUserToDeleteRows = False
        Me.dgv_cara.AllowUserToOrderColumns = True
        Me.dgv_cara.AllowUserToResizeRows = False
        Me.dgv_cara.BackgroundColor = System.Drawing.Color.White
        Me.dgv_cara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_cara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cara.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AGENTE, Me.DESCRIPCION})
        Me.dgv_cara.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_cara.Location = New System.Drawing.Point(6, 44)
        Me.dgv_cara.MultiSelect = False
        Me.dgv_cara.Name = "dgv_cara"
        Me.dgv_cara.ReadOnly = True
        Me.dgv_cara.RowHeadersVisible = False
        Me.dgv_cara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_cara.Size = New System.Drawing.Size(274, 257)
        Me.dgv_cara.TabIndex = 1
        '
        'AGENTE
        '
        Me.AGENTE.DataPropertyName = "AGENTE"
        Me.AGENTE.HeaderText = ""
        Me.AGENTE.Name = "AGENTE"
        Me.AGENTE.ReadOnly = True
        Me.AGENTE.Visible = False
        Me.AGENTE.Width = 40
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION.HeaderText = "CARACTERISTICA"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Width = 240
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 44)
        Me.Panel1.TabIndex = 56
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.White
        Me.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cerrar.Image = Global.My.Resources.Resources.Clear_Green_Button
        Me.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cerrar.Location = New System.Drawing.Point(513, 2)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(96, 37)
        Me.btn_cerrar.TabIndex = 55
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'cct_mant_comp_cara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(612, 362)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gb_agente)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cct_mant_comp_cara"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Componentes/Caracteristicas"
        Me.gb_agente.ResumeLayout(False)
        Me.gb_agente.PerformLayout()
        CType(Me.dgv_comp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_cara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_agente As System.Windows.Forms.GroupBox
    Friend WithEvents btn_quitar_comp As System.Windows.Forms.Button
    Friend WithEvents dgv_comp As System.Windows.Forms.DataGridView
    Friend WithEvents descripcion_comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_quitar_cara As System.Windows.Forms.Button
    Friend WithEvents dgv_cara As System.Windows.Forms.DataGridView
    Friend WithEvents AGENTE As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents txt_comp As System.Windows.Forms.TextBox
    Friend WithEvents btn_acep_comp As System.Windows.Forms.Button
    Friend WithEvents txt_cara As System.Windows.Forms.TextBox
    Friend WithEvents btn_acep_cara As System.Windows.Forms.Button
    Friend WithEvents btn_mod_comp As System.Windows.Forms.Button
    Friend WithEvents btn_mod_cara As System.Windows.Forms.Button
End Class
