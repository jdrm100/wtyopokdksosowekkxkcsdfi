<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reg02
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_inst = New System.Windows.Forms.Button()
        Me.txt_clas = New System.Windows.Forms.TextBox()
        Me.btn_soli_ac = New System.Windows.Forms.Button()
        Me.txt_mun = New System.Windows.Forms.TextBox()
        Me.txt_bloq = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ciudad = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_rep = New System.Windows.Forms.TextBox()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv_agentes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_agente = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_agentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.btn_inst)
        Me.GroupBox2.Controls.Add(Me.txt_clas)
        Me.GroupBox2.Controls.Add(Me.btn_soli_ac)
        Me.GroupBox2.Controls.Add(Me.txt_mun)
        Me.GroupBox2.Controls.Add(Me.txt_bloq)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_ciudad)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_rep)
        Me.GroupBox2.Controls.Add(Me.txt_dir)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(350, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 253)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(73, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 17)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Dirección:"
        '
        'btn_inst
        '
        Me.btn_inst.BackColor = System.Drawing.Color.White
        Me.btn_inst.BackgroundImage = Global.My.Resources.Resources.monitor
        Me.btn_inst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_inst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inst.ForeColor = System.Drawing.Color.Black
        Me.btn_inst.Image = Global.My.Resources.Resources.status_online
        Me.btn_inst.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_inst.Location = New System.Drawing.Point(6, 209)
        Me.btn_inst.Name = "btn_inst"
        Me.btn_inst.Size = New System.Drawing.Size(36, 38)
        Me.btn_inst.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.btn_inst, "Datos de instalacion")
        Me.btn_inst.UseVisualStyleBackColor = False
        '
        'txt_clas
        '
        Me.txt_clas.BackColor = System.Drawing.Color.White
        Me.txt_clas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_clas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clas.Location = New System.Drawing.Point(169, 112)
        Me.txt_clas.Name = "txt_clas"
        Me.txt_clas.ReadOnly = True
        Me.txt_clas.Size = New System.Drawing.Size(34, 26)
        Me.txt_clas.TabIndex = 58
        Me.txt_clas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_soli_ac
        '
        Me.btn_soli_ac.BackColor = System.Drawing.Color.White
        Me.btn_soli_ac.BackgroundImage = Global.My.Resources.Resources.script_edit
        Me.btn_soli_ac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_soli_ac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_soli_ac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_soli_ac.ForeColor = System.Drawing.Color.Black
        Me.btn_soli_ac.Location = New System.Drawing.Point(48, 209)
        Me.btn_soli_ac.Name = "btn_soli_ac"
        Me.btn_soli_ac.Size = New System.Drawing.Size(36, 38)
        Me.btn_soli_ac.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.btn_soli_ac, "Contrato")
        Me.btn_soli_ac.UseVisualStyleBackColor = False
        '
        'txt_mun
        '
        Me.txt_mun.BackColor = System.Drawing.Color.White
        Me.txt_mun.Location = New System.Drawing.Point(225, 41)
        Me.txt_mun.Name = "txt_mun"
        Me.txt_mun.ReadOnly = True
        Me.txt_mun.Size = New System.Drawing.Size(125, 20)
        Me.txt_mun.TabIndex = 54
        '
        'txt_bloq
        '
        Me.txt_bloq.BackColor = System.Drawing.Color.White
        Me.txt_bloq.Location = New System.Drawing.Point(73, 112)
        Me.txt_bloq.Name = "txt_bloq"
        Me.txt_bloq.ReadOnly = True
        Me.txt_bloq.Size = New System.Drawing.Size(90, 20)
        Me.txt_bloq.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(22, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Estado:"
        '
        'txt_ciudad
        '
        Me.txt_ciudad.BackColor = System.Drawing.Color.White
        Me.txt_ciudad.Location = New System.Drawing.Point(73, 41)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.ReadOnly = True
        Me.txt_ciudad.Size = New System.Drawing.Size(146, 20)
        Me.txt_ciudad.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(-1, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Rep. Legal:"
        '
        'txt_rep
        '
        Me.txt_rep.BackColor = System.Drawing.Color.White
        Me.txt_rep.Location = New System.Drawing.Point(73, 86)
        Me.txt_rep.Name = "txt_rep"
        Me.txt_rep.ReadOnly = True
        Me.txt_rep.Size = New System.Drawing.Size(146, 20)
        Me.txt_rep.TabIndex = 15
        '
        'txt_dir
        '
        Me.txt_dir.BackColor = System.Drawing.Color.White
        Me.txt_dir.Location = New System.Drawing.Point(73, 19)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.ReadOnly = True
        Me.txt_dir.Size = New System.Drawing.Size(277, 20)
        Me.txt_dir.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.My.Resources.Resources.vcard_edit
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(304, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.Button1, "Modificar prospeccion")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dgv_agentes)
        Me.GroupBox1.Controls.Add(Me.txt_agente)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 253)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.BackgroundImage = Global.My.Resources.Resources.Add
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(304, 36)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(23, 22)
        Me.Button11.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.Button11, "Agregar prospeccion")
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = Global.My.Resources.Resources.page_white_acrobat
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(46, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 24)
        Me.Button3.TabIndex = 53
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.My.Resources.Resources.page_white_excel
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 24)
        Me.Button2.TabIndex = 52
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(266, 234)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(17, 17)
        Me.lbl_total.TabIndex = 18
        Me.lbl_total.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(176, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total consulta:"
        '
        'dgv_agentes
        '
        Me.dgv_agentes.AllowUserToAddRows = False
        Me.dgv_agentes.AllowUserToDeleteRows = False
        Me.dgv_agentes.AllowUserToOrderColumns = True
        Me.dgv_agentes.AllowUserToResizeRows = False
        Me.dgv_agentes.BackgroundColor = System.Drawing.Color.White
        Me.dgv_agentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_agentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_agentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.nombre})
        Me.dgv_agentes.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_agentes.Location = New System.Drawing.Point(8, 34)
        Me.dgv_agentes.MultiSelect = False
        Me.dgv_agentes.Name = "dgv_agentes"
        Me.dgv_agentes.ReadOnly = True
        Me.dgv_agentes.RowHeadersVisible = False
        Me.dgv_agentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_agentes.Size = New System.Drawing.Size(290, 187)
        Me.dgv_agentes.TabIndex = 1
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "RETAILER"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 70
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 185
        '
        'txt_agente
        '
        Me.txt_agente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_agente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_agente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_agente.Location = New System.Drawing.Point(7, 10)
        Me.txt_agente.Name = "txt_agente"
        Me.txt_agente.Size = New System.Drawing.Size(319, 20)
        Me.txt_agente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(90, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Estado:"
        '
        'Reg02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(719, 268)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Reg02"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de prospecciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_agentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_inst As System.Windows.Forms.Button
    Friend WithEvents txt_clas As System.Windows.Forms.TextBox
    Friend WithEvents btn_soli_ac As System.Windows.Forms.Button
    Friend WithEvents txt_mun As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_bloq As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_rep As System.Windows.Forms.TextBox
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgv_agentes As System.Windows.Forms.DataGridView
    Friend WithEvents txt_agente As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
