<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inc_mant01
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
        Me.TT1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_agregar_c = New System.Windows.Forms.Button()
        Me.btn_agregar_i = New System.Windows.Forms.Button()
        Me.btn_agregar_m = New System.Windows.Forms.Button()
        Me.btn_quitar_c = New System.Windows.Forms.Button()
        Me.btn_quitar_i = New System.Windows.Forms.Button()
        Me.btn_quitar_m = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_tp_llamada = New System.Windows.Forms.DataGridView()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_motivo = New System.Windows.Forms.DataGridView()
        Me.DESCRIPCION_MOTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_incidencia = New System.Windows.Forms.DataGridView()
        Me.DESCRIPCION_INCIDENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgv_conclusion = New System.Windows.Forms.DataGridView()
        Me.DESCRIPCION_CONCLUSION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_tp_llamada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_motivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_incidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_conclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TT1
        '
        Me.TT1.AutomaticDelay = 300
        Me.TT1.AutoPopDelay = 9000
        Me.TT1.InitialDelay = 300
        Me.TT1.IsBalloon = True
        Me.TT1.ReshowDelay = 60
        '
        'btn_agregar_c
        '
        Me.btn_agregar_c.BackColor = System.Drawing.Color.White
        Me.btn_agregar_c.BackgroundImage = Global.My.Resources.Resources.Add1
        Me.btn_agregar_c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar_c.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_c.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar_c.Location = New System.Drawing.Point(957, 28)
        Me.btn_agregar_c.Name = "btn_agregar_c"
        Me.btn_agregar_c.Size = New System.Drawing.Size(25, 26)
        Me.btn_agregar_c.TabIndex = 54
        Me.TT1.SetToolTip(Me.btn_agregar_c, "Agregar Conclusion")
        Me.btn_agregar_c.UseVisualStyleBackColor = False
        '
        'btn_agregar_i
        '
        Me.btn_agregar_i.BackColor = System.Drawing.Color.White
        Me.btn_agregar_i.BackgroundImage = Global.My.Resources.Resources.Add1
        Me.btn_agregar_i.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar_i.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_i.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar_i.Location = New System.Drawing.Point(699, 28)
        Me.btn_agregar_i.Name = "btn_agregar_i"
        Me.btn_agregar_i.Size = New System.Drawing.Size(25, 26)
        Me.btn_agregar_i.TabIndex = 52
        Me.TT1.SetToolTip(Me.btn_agregar_i, "Agregar Incidencia")
        Me.btn_agregar_i.UseVisualStyleBackColor = False
        '
        'btn_agregar_m
        '
        Me.btn_agregar_m.BackColor = System.Drawing.Color.White
        Me.btn_agregar_m.BackgroundImage = Global.My.Resources.Resources.Add1
        Me.btn_agregar_m.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar_m.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_m.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar_m.Location = New System.Drawing.Point(440, 28)
        Me.btn_agregar_m.Name = "btn_agregar_m"
        Me.btn_agregar_m.Size = New System.Drawing.Size(25, 26)
        Me.btn_agregar_m.TabIndex = 50
        Me.TT1.SetToolTip(Me.btn_agregar_m, "Agregar Motivo")
        Me.btn_agregar_m.UseVisualStyleBackColor = False
        '
        'btn_quitar_c
        '
        Me.btn_quitar_c.BackColor = System.Drawing.Color.White
        Me.btn_quitar_c.BackgroundImage = Global.My.Resources.Resources.Delete1
        Me.btn_quitar_c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_c.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quitar_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar_c.ForeColor = System.Drawing.Color.Black
        Me.btn_quitar_c.Location = New System.Drawing.Point(957, 59)
        Me.btn_quitar_c.Name = "btn_quitar_c"
        Me.btn_quitar_c.Size = New System.Drawing.Size(25, 26)
        Me.btn_quitar_c.TabIndex = 55
        Me.TT1.SetToolTip(Me.btn_quitar_c, "Quitar Conclusion")
        Me.btn_quitar_c.UseVisualStyleBackColor = False
        '
        'btn_quitar_i
        '
        Me.btn_quitar_i.BackColor = System.Drawing.Color.White
        Me.btn_quitar_i.BackgroundImage = Global.My.Resources.Resources.Delete1
        Me.btn_quitar_i.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_i.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quitar_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar_i.ForeColor = System.Drawing.Color.Black
        Me.btn_quitar_i.Location = New System.Drawing.Point(699, 59)
        Me.btn_quitar_i.Name = "btn_quitar_i"
        Me.btn_quitar_i.Size = New System.Drawing.Size(25, 26)
        Me.btn_quitar_i.TabIndex = 53
        Me.TT1.SetToolTip(Me.btn_quitar_i, "Quitar Incidencia")
        Me.btn_quitar_i.UseVisualStyleBackColor = False
        '
        'btn_quitar_m
        '
        Me.btn_quitar_m.BackColor = System.Drawing.Color.White
        Me.btn_quitar_m.BackgroundImage = Global.My.Resources.Resources.Delete1
        Me.btn_quitar_m.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_m.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quitar_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar_m.ForeColor = System.Drawing.Color.Black
        Me.btn_quitar_m.Location = New System.Drawing.Point(440, 59)
        Me.btn_quitar_m.Name = "btn_quitar_m"
        Me.btn_quitar_m.Size = New System.Drawing.Size(25, 26)
        Me.btn_quitar_m.TabIndex = 51
        Me.TT1.SetToolTip(Me.btn_quitar_m, "Quitar Motivo")
        Me.btn_quitar_m.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_tp_llamada)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO DE LLAMADA"
        '
        'dgv_tp_llamada
        '
        Me.dgv_tp_llamada.AllowUserToAddRows = False
        Me.dgv_tp_llamada.AllowUserToDeleteRows = False
        Me.dgv_tp_llamada.AllowUserToOrderColumns = True
        Me.dgv_tp_llamada.AllowUserToResizeRows = False
        Me.dgv_tp_llamada.BackgroundColor = System.Drawing.Color.White
        Me.dgv_tp_llamada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_tp_llamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tp_llamada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION})
        Me.dgv_tp_llamada.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_tp_llamada.Location = New System.Drawing.Point(6, 19)
        Me.dgv_tp_llamada.MultiSelect = False
        Me.dgv_tp_llamada.Name = "dgv_tp_llamada"
        Me.dgv_tp_llamada.ReadOnly = True
        Me.dgv_tp_llamada.RowHeadersVisible = False
        Me.dgv_tp_llamada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tp_llamada.Size = New System.Drawing.Size(152, 78)
        Me.dgv_tp_llamada.TabIndex = 2
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION.HeaderText = "TIPOS DE LLAMADAS"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Width = 140
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_motivo)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 247)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MOTIVO"
        '
        'dgv_motivo
        '
        Me.dgv_motivo.AllowUserToAddRows = False
        Me.dgv_motivo.AllowUserToDeleteRows = False
        Me.dgv_motivo.AllowUserToOrderColumns = True
        Me.dgv_motivo.AllowUserToResizeRows = False
        Me.dgv_motivo.BackgroundColor = System.Drawing.Color.White
        Me.dgv_motivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_motivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_motivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION_MOTIVO})
        Me.dgv_motivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_motivo.Location = New System.Drawing.Point(6, 19)
        Me.dgv_motivo.MultiSelect = False
        Me.dgv_motivo.Name = "dgv_motivo"
        Me.dgv_motivo.ReadOnly = True
        Me.dgv_motivo.RowHeadersVisible = False
        Me.dgv_motivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_motivo.Size = New System.Drawing.Size(209, 222)
        Me.dgv_motivo.TabIndex = 2
        '
        'DESCRIPCION_MOTIVO
        '
        Me.DESCRIPCION_MOTIVO.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION_MOTIVO.HeaderText = "MOTIVOS"
        Me.DESCRIPCION_MOTIVO.Name = "DESCRIPCION_MOTIVO"
        Me.DESCRIPCION_MOTIVO.ReadOnly = True
        Me.DESCRIPCION_MOTIVO.Width = 180
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_incidencia)
        Me.GroupBox3.Location = New System.Drawing.Point(479, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(219, 247)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INCIDENCIA"
        '
        'dgv_incidencia
        '
        Me.dgv_incidencia.AllowUserToAddRows = False
        Me.dgv_incidencia.AllowUserToDeleteRows = False
        Me.dgv_incidencia.AllowUserToOrderColumns = True
        Me.dgv_incidencia.AllowUserToResizeRows = False
        Me.dgv_incidencia.BackgroundColor = System.Drawing.Color.White
        Me.dgv_incidencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_incidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_incidencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION_INCIDENCIA})
        Me.dgv_incidencia.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_incidencia.Location = New System.Drawing.Point(6, 19)
        Me.dgv_incidencia.MultiSelect = False
        Me.dgv_incidencia.Name = "dgv_incidencia"
        Me.dgv_incidencia.ReadOnly = True
        Me.dgv_incidencia.RowHeadersVisible = False
        Me.dgv_incidencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_incidencia.Size = New System.Drawing.Size(209, 222)
        Me.dgv_incidencia.TabIndex = 2
        '
        'DESCRIPCION_INCIDENCIA
        '
        Me.DESCRIPCION_INCIDENCIA.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION_INCIDENCIA.HeaderText = "INCIDENCIAS"
        Me.DESCRIPCION_INCIDENCIA.Name = "DESCRIPCION_INCIDENCIA"
        Me.DESCRIPCION_INCIDENCIA.ReadOnly = True
        Me.DESCRIPCION_INCIDENCIA.Width = 180
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgv_conclusion)
        Me.GroupBox4.Location = New System.Drawing.Point(737, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(219, 247)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CONCLUSION"
        '
        'dgv_conclusion
        '
        Me.dgv_conclusion.AllowUserToAddRows = False
        Me.dgv_conclusion.AllowUserToDeleteRows = False
        Me.dgv_conclusion.AllowUserToOrderColumns = True
        Me.dgv_conclusion.AllowUserToResizeRows = False
        Me.dgv_conclusion.BackgroundColor = System.Drawing.Color.White
        Me.dgv_conclusion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_conclusion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_conclusion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION_CONCLUSION})
        Me.dgv_conclusion.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_conclusion.Location = New System.Drawing.Point(6, 19)
        Me.dgv_conclusion.MultiSelect = False
        Me.dgv_conclusion.Name = "dgv_conclusion"
        Me.dgv_conclusion.ReadOnly = True
        Me.dgv_conclusion.RowHeadersVisible = False
        Me.dgv_conclusion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_conclusion.Size = New System.Drawing.Size(209, 222)
        Me.dgv_conclusion.TabIndex = 2
        '
        'DESCRIPCION_CONCLUSION
        '
        Me.DESCRIPCION_CONCLUSION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION_CONCLUSION.HeaderText = "CONCLUSIONES"
        Me.DESCRIPCION_CONCLUSION.Name = "DESCRIPCION_CONCLUSION"
        Me.DESCRIPCION_CONCLUSION.ReadOnly = True
        Me.DESCRIPCION_CONCLUSION.Width = 180
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.My.Resources.Resources.Blue_Play
        Me.PictureBox3.Location = New System.Drawing.Point(699, 114)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.My.Resources.Resources.Blue_Play
        Me.PictureBox2.Location = New System.Drawing.Point(440, 114)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.My.Resources.Resources.Blue_Play
        Me.PictureBox1.Location = New System.Drawing.Point(176, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'inc_mant01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(991, 265)
        Me.Controls.Add(Me.btn_agregar_c)
        Me.Controls.Add(Me.btn_agregar_i)
        Me.Controls.Add(Me.btn_agregar_m)
        Me.Controls.Add(Me.btn_quitar_c)
        Me.Controls.Add(Me.btn_quitar_i)
        Me.Controls.Add(Me.btn_quitar_m)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "inc_mant01"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento - Soporte"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_tp_llamada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_motivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_incidencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgv_conclusion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TT1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_tp_llamada As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_motivo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_incidencia As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_conclusion As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_quitar_m As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_m As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_i As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_i As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_c As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_c As System.Windows.Forms.Button
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION_MOTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION_INCIDENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION_CONCLUSION As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
