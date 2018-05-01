<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empl
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
        Me.tt1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_empl = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_hist = New System.Windows.Forms.Button()
        Me.btn_desac = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_age = New System.Windows.Forms.Button()
        Me.btn_modif = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv_empl = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_flota = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_empl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tt1
        '
        Me.tt1.AutomaticDelay = 300
        Me.tt1.AutoPopDelay = 9000
        Me.tt1.InitialDelay = 300
        Me.tt1.IsBalloon = True
        Me.tt1.ReshowDelay = 60
        Me.tt1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'cmb_tipo
        '
        Me.cmb_tipo.BackColor = System.Drawing.Color.White
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"EJECUTIVOS", "TECNICOS", "TODOS"})
        Me.cmb_tipo.Location = New System.Drawing.Point(50, 19)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(132, 21)
        Me.cmb_tipo.TabIndex = 0
        Me.tt1.SetToolTip(Me.cmb_tipo, "Filtra por el Gestor de cobros")
        '
        'txt_empl
        '
        Me.txt_empl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_empl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_empl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_empl.Location = New System.Drawing.Point(4, 42)
        Me.txt_empl.Name = "txt_empl"
        Me.txt_empl.Size = New System.Drawing.Size(279, 20)
        Me.txt_empl.TabIndex = 1
        Me.tt1.SetToolTip(Me.txt_empl, "Consulte por nombre o apellido")
        '
        'txt_correo
        '
        Me.txt_correo.BackColor = System.Drawing.Color.White
        Me.txt_correo.Location = New System.Drawing.Point(76, 42)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.ReadOnly = True
        Me.txt_correo.Size = New System.Drawing.Size(146, 20)
        Me.txt_correo.TabIndex = 35
        Me.tt1.SetToolTip(Me.txt_correo, "Provincia")
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
        Me.Button3.Location = New System.Drawing.Point(38, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 24)
        Me.Button3.TabIndex = 53
        Me.tt1.SetToolTip(Me.Button3, "Exportar a PDF")
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
        Me.Button2.Location = New System.Drawing.Point(4, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 24)
        Me.Button2.TabIndex = 52
        Me.tt1.SetToolTip(Me.Button2, "Exporta a Excel")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_hist
        '
        Me.btn_hist.BackColor = System.Drawing.Color.White
        Me.btn_hist.BackgroundImage = Global.My.Resources.Resources.table_multiple
        Me.btn_hist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_hist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hist.ForeColor = System.Drawing.Color.Black
        Me.btn_hist.Location = New System.Drawing.Point(97, 19)
        Me.btn_hist.Name = "btn_hist"
        Me.btn_hist.Size = New System.Drawing.Size(36, 38)
        Me.btn_hist.TabIndex = 66
        Me.tt1.SetToolTip(Me.btn_hist, "Historial de empleado")
        Me.btn_hist.UseVisualStyleBackColor = False
        '
        'btn_desac
        '
        Me.btn_desac.BackColor = System.Drawing.Color.White
        Me.btn_desac.BackgroundImage = Global.My.Resources.Resources.Minus_Red_Button
        Me.btn_desac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_desac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_desac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desac.ForeColor = System.Drawing.Color.Black
        Me.btn_desac.Location = New System.Drawing.Point(185, 19)
        Me.btn_desac.Name = "btn_desac"
        Me.btn_desac.Size = New System.Drawing.Size(36, 38)
        Me.btn_desac.TabIndex = 65
        Me.tt1.SetToolTip(Me.btn_desac, "Desactivar Empleado")
        Me.btn_desac.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.White
        Me.btn_nuevo.BackgroundImage = Global.My.Resources.Resources.Add_Green_Button
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo.Location = New System.Drawing.Point(143, 19)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(36, 38)
        Me.btn_nuevo.TabIndex = 64
        Me.tt1.SetToolTip(Me.btn_nuevo, "Nuevo Empleado")
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_age
        '
        Me.btn_age.BackColor = System.Drawing.Color.White
        Me.btn_age.BackgroundImage = Global.My.Resources.Resources.status_online
        Me.btn_age.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_age.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_age.ForeColor = System.Drawing.Color.Black
        Me.btn_age.Image = Global.My.Resources.Resources.user_suit
        Me.btn_age.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btn_age.Location = New System.Drawing.Point(55, 19)
        Me.btn_age.Name = "btn_age"
        Me.btn_age.Size = New System.Drawing.Size(36, 38)
        Me.btn_age.TabIndex = 61
        Me.tt1.SetToolTip(Me.btn_age, "Agentes asignados")
        Me.btn_age.UseVisualStyleBackColor = False
        '
        'btn_modif
        '
        Me.btn_modif.BackColor = System.Drawing.Color.White
        Me.btn_modif.BackgroundImage = Global.My.Resources.Resources.vcard_edit
        Me.btn_modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_modif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modif.ForeColor = System.Drawing.Color.Black
        Me.btn_modif.Location = New System.Drawing.Point(13, 19)
        Me.btn_modif.Name = "btn_modif"
        Me.btn_modif.Size = New System.Drawing.Size(36, 38)
        Me.btn_modif.TabIndex = 48
        Me.tt1.SetToolTip(Me.btn_modif, "Modificar/Agregar datos")
        Me.btn_modif.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo)
        Me.GroupBox1.Controls.Add(Me.dgv_empl)
        Me.GroupBox1.Controls.Add(Me.txt_empl)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 302)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTA DE EMPLEADO"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(8, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Tipo:"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(265, 278)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(14, 13)
        Me.lbl_total.TabIndex = 18
        Me.lbl_total.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(155, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total consulta:"
        '
        'dgv_empl
        '
        Me.dgv_empl.AllowUserToAddRows = False
        Me.dgv_empl.AllowUserToDeleteRows = False
        Me.dgv_empl.AllowUserToOrderColumns = True
        Me.dgv_empl.AllowUserToResizeRows = False
        Me.dgv_empl.BackgroundColor = System.Drawing.Color.White
        Me.dgv_empl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_empl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.nombre})
        Me.dgv_empl.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_empl.Location = New System.Drawing.Point(5, 66)
        Me.dgv_empl.MultiSelect = False
        Me.dgv_empl.Name = "dgv_empl"
        Me.dgv_empl.ReadOnly = True
        Me.dgv_empl.RowHeadersVisible = False
        Me.dgv_empl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_empl.Size = New System.Drawing.Size(278, 202)
        Me.dgv_empl.TabIndex = 1
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "COD."
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 50
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_ruta)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_correo)
        Me.GroupBox2.Controls.Add(Me.txt_flota)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(308, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 98)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Ruta:"
        '
        'txt_ruta
        '
        Me.txt_ruta.BackColor = System.Drawing.Color.White
        Me.txt_ruta.Location = New System.Drawing.Point(76, 68)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.ReadOnly = True
        Me.txt_ruta.Size = New System.Drawing.Size(42, 20)
        Me.txt_ruta.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(14, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Correo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(24, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Flota:"
        '
        'txt_flota
        '
        Me.txt_flota.BackColor = System.Drawing.Color.White
        Me.txt_flota.Location = New System.Drawing.Point(76, 16)
        Me.txt_flota.Name = "txt_flota"
        Me.txt_flota.ReadOnly = True
        Me.txt_flota.Size = New System.Drawing.Size(87, 20)
        Me.txt_flota.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox3.Controls.Add(Me.btn_hist)
        Me.GroupBox3.Controls.Add(Me.btn_desac)
        Me.GroupBox3.Controls.Add(Me.btn_nuevo)
        Me.GroupBox3.Controls.Add(Me.btn_age)
        Me.GroupBox3.Controls.Add(Me.btn_modif)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(308, 116)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 65)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'empl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(550, 320)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "empl"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE EMPLEADOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_empl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tt1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_empl As System.Windows.Forms.DataGridView
    Friend WithEvents txt_empl As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents txt_flota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_hist As System.Windows.Forms.Button
    Friend WithEvents btn_desac As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_age As System.Windows.Forms.Button
    Friend WithEvents btn_modif As System.Windows.Forms.Button
End Class
