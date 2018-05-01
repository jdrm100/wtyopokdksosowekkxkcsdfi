<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cct_motivos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_selec = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_mot = New System.Windows.Forms.TextBox()
        Me.btn_agregar_g = New System.Windows.Forms.Button()
        Me.btn_quitar_g = New System.Windows.Forms.Button()
        Me.dgv_m = New System.Windows.Forms.DataGridView()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_tp = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_m, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_aceptar)
        Me.Panel1.Location = New System.Drawing.Point(10, 360)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 44)
        Me.Panel1.TabIndex = 8
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
        Me.btn_cancelar.Location = New System.Drawing.Point(8, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(98, 37)
        Me.btn_cancelar.TabIndex = 54
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
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
        Me.btn_aceptar.Location = New System.Drawing.Point(193, 2)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(98, 37)
        Me.btn_aceptar.TabIndex = 53
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_aceptar, "Asignar motivos seleccionados")
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_selec)
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Controls.Add(Me.txt_mot)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_g)
        Me.GroupBox1.Controls.Add(Me.btn_quitar_g)
        Me.GroupBox1.Controls.Add(Me.dgv_m)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(10, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 324)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creacion / Modificación"
        '
        'lbl_selec
        '
        Me.lbl_selec.AutoSize = True
        Me.lbl_selec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_selec.ForeColor = System.Drawing.Color.Black
        Me.lbl_selec.Location = New System.Drawing.Point(103, 307)
        Me.lbl_selec.Name = "lbl_selec"
        Me.lbl_selec.Size = New System.Drawing.Size(14, 13)
        Me.lbl_selec.TabIndex = 62
        Me.lbl_selec.Text = "1"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(3, 307)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(94, 13)
        Me.lbl_total.TabIndex = 61
        Me.lbl_total.Text = "Seleccionados:"
        '
        'txt_mot
        '
        Me.txt_mot.Location = New System.Drawing.Point(8, 15)
        Me.txt_mot.Name = "txt_mot"
        Me.txt_mot.Size = New System.Drawing.Size(255, 20)
        Me.txt_mot.TabIndex = 59
        '
        'btn_agregar_g
        '
        Me.btn_agregar_g.BackColor = System.Drawing.Color.White
        Me.btn_agregar_g.BackgroundImage = Global.My.Resources.Resources.accept
        Me.btn_agregar_g.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar_g.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_g.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar_g.Location = New System.Drawing.Point(266, 11)
        Me.btn_agregar_g.Name = "btn_agregar_g"
        Me.btn_agregar_g.Size = New System.Drawing.Size(25, 26)
        Me.btn_agregar_g.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.btn_agregar_g, "Aceptar")
        Me.btn_agregar_g.UseVisualStyleBackColor = False
        '
        'btn_quitar_g
        '
        Me.btn_quitar_g.BackColor = System.Drawing.Color.White
        Me.btn_quitar_g.BackgroundImage = Global.My.Resources.Resources.Delete1
        Me.btn_quitar_g.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_g.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_quitar_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar_g.ForeColor = System.Drawing.Color.Black
        Me.btn_quitar_g.Location = New System.Drawing.Point(266, 43)
        Me.btn_quitar_g.Name = "btn_quitar_g"
        Me.btn_quitar_g.Size = New System.Drawing.Size(25, 26)
        Me.btn_quitar_g.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.btn_quitar_g, "Desactivar motivo")
        Me.btn_quitar_g.UseVisualStyleBackColor = False
        '
        'dgv_m
        '
        Me.dgv_m.AllowUserToAddRows = False
        Me.dgv_m.AllowUserToDeleteRows = False
        Me.dgv_m.AllowUserToOrderColumns = True
        Me.dgv_m.AllowUserToResizeRows = False
        Me.dgv_m.BackgroundColor = System.Drawing.Color.White
        Me.dgv_m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_m.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_m.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION})
        Me.dgv_m.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_m.Location = New System.Drawing.Point(6, 43)
        Me.dgv_m.Name = "dgv_m"
        Me.dgv_m.ReadOnly = True
        Me.dgv_m.RowHeadersVisible = False
        Me.dgv_m.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_m.Size = New System.Drawing.Size(258, 261)
        Me.dgv_m.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.dgv_m, "Doble click para modificar")
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Width = 225
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 300
        Me.ToolTip1.AutoPopDelay = 9000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 15)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Asignación a llamada:"
        '
        'lbl_tp
        '
        Me.lbl_tp.AutoSize = True
        Me.lbl_tp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tp.ForeColor = System.Drawing.Color.Black
        Me.lbl_tp.Location = New System.Drawing.Point(174, 9)
        Me.lbl_tp.Name = "lbl_tp"
        Me.lbl_tp.Size = New System.Drawing.Size(22, 15)
        Me.lbl_tp.TabIndex = 63
        Me.lbl_tp.Text = "---"
        '
        'cct_motivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(316, 407)
        Me.Controls.Add(Me.lbl_tp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cct_motivos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de motivos"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_m, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_m As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_g As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_g As System.Windows.Forms.Button
    Friend WithEvents txt_mot As System.Windows.Forms.TextBox
    Friend WithEvents lbl_selec As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_tp As System.Windows.Forms.Label
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
