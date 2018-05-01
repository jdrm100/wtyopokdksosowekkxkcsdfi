<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_USER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SW_BLOQUEO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONT_BLOQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ID_GRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_GRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_id_user = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_baja = New System.Windows.Forms.Label()
        Me.lbl_agencia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_desb = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_quitar_grupo = New System.Windows.Forms.Button()
        Me.btn_agregar_grupo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_quitar_rol = New System.Windows.Forms.Button()
        Me.btn_agregar_rol = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ID_ROL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc_Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tt1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_USER, Me.Nombre, Me.PASSWORD, Me.SW_BLOQUEO, Me.CONT_BLOQ, Me.ID})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 48)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(734, 264)
        Me.DataGridView1.TabIndex = 3
        '
        'ID_USER
        '
        Me.ID_USER.DataPropertyName = "ID_USER"
        Me.ID_USER.HeaderText = "ID_USER"
        Me.ID_USER.Name = "ID_USER"
        Me.ID_USER.Width = 80
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "NOMBRE"
        Me.Nombre.HeaderText = "NOMBRE"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 250
        '
        'PASSWORD
        '
        Me.PASSWORD.DataPropertyName = "PASSWORD"
        Me.PASSWORD.HeaderText = "PASSWORD"
        Me.PASSWORD.Name = "PASSWORD"
        '
        'SW_BLOQUEO
        '
        Me.SW_BLOQUEO.DataPropertyName = "SW_BLOQUEO"
        Me.SW_BLOQUEO.HeaderText = "SW_BLOQUEO"
        Me.SW_BLOQUEO.Name = "SW_BLOQUEO"
        Me.SW_BLOQUEO.Width = 80
        '
        'CONT_BLOQ
        '
        Me.CONT_BLOQ.DataPropertyName = "CONT_BLOQ"
        Me.CONT_BLOQ.HeaderText = "CONT_BLOQ"
        Me.CONT_BLOQ.Name = "CONT_BLOQ"
        Me.CONT_BLOQ.Width = 80
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.DefaultCellStyle = DataGridViewCellStyle1
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 80
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_GRUPO, Me.DESC_GRUPO})
        Me.DataGridView2.Location = New System.Drawing.Point(9, 19)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(391, 154)
        Me.DataGridView2.TabIndex = 2
        '
        'ID_GRUPO
        '
        Me.ID_GRUPO.DataPropertyName = "ID"
        Me.ID_GRUPO.HeaderText = "ID"
        Me.ID_GRUPO.Name = "ID_GRUPO"
        Me.ID_GRUPO.ReadOnly = True
        Me.ID_GRUPO.Width = 50
        '
        'DESC_GRUPO
        '
        Me.DESC_GRUPO.DataPropertyName = "DESC_GRUPO"
        Me.DESC_GRUPO.HeaderText = "DESC_GRUPO"
        Me.DESC_GRUPO.Name = "DESC_GRUPO"
        Me.DESC_GRUPO.ReadOnly = True
        Me.DESC_GRUPO.Width = 270
        '
        'txt_id_user
        '
        Me.txt_id_user.Location = New System.Drawing.Point(50, 22)
        Me.txt_id_user.Name = "txt_id_user"
        Me.txt_id_user.Size = New System.Drawing.Size(81, 20)
        Me.txt_id_user.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(137, 22)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(248, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_baja)
        Me.GroupBox1.Controls.Add(Me.lbl_agencia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_desb)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_id_user)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 320)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'lbl_baja
        '
        Me.lbl_baja.AutoSize = True
        Me.lbl_baja.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_baja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_baja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_baja.ForeColor = System.Drawing.Color.Red
        Me.lbl_baja.Location = New System.Drawing.Point(597, 24)
        Me.lbl_baja.Name = "lbl_baja"
        Me.lbl_baja.Size = New System.Drawing.Size(147, 17)
        Me.lbl_baja.TabIndex = 7
        Me.lbl_baja.Text = "Usuario dado de baja"
        Me.lbl_baja.Visible = False
        '
        'lbl_agencia
        '
        Me.lbl_agencia.BackColor = System.Drawing.Color.White
        Me.lbl_agencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_agencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agencia.Location = New System.Drawing.Point(546, 24)
        Me.lbl_agencia.Name = "lbl_agencia"
        Me.lbl_agencia.Size = New System.Drawing.Size(36, 17)
        Me.lbl_agencia.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(481, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Agencia:"
        '
        'btn_desb
        '
        Me.btn_desb.BackColor = System.Drawing.Color.White
        Me.btn_desb.BackgroundImage = Global.My.Resources.Resources.lock_open
        Me.btn_desb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_desb.Location = New System.Drawing.Point(391, 21)
        Me.btn_desb.Name = "btn_desb"
        Me.btn_desb.Size = New System.Drawing.Size(27, 22)
        Me.btn_desb.TabIndex = 4
        Me.btn_desb.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.My.Resources.Resources.magnifier
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(17, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_quitar_grupo)
        Me.GroupBox2.Controls.Add(Me.btn_agregar_grupo)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 338)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 179)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grupos"
        '
        'btn_quitar_grupo
        '
        Me.btn_quitar_grupo.BackColor = System.Drawing.Color.White
        Me.btn_quitar_grupo.BackgroundImage = Global.My.Resources.Resources.Delete
        Me.btn_quitar_grupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_grupo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_quitar_grupo.Location = New System.Drawing.Point(373, 0)
        Me.btn_quitar_grupo.Name = "btn_quitar_grupo"
        Me.btn_quitar_grupo.Size = New System.Drawing.Size(27, 22)
        Me.btn_quitar_grupo.TabIndex = 1
        Me.btn_quitar_grupo.UseVisualStyleBackColor = False
        '
        'btn_agregar_grupo
        '
        Me.btn_agregar_grupo.BackColor = System.Drawing.Color.White
        Me.btn_agregar_grupo.BackgroundImage = Global.My.Resources.Resources.Add
        Me.btn_agregar_grupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar_grupo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_agregar_grupo.Location = New System.Drawing.Point(340, 0)
        Me.btn_agregar_grupo.Name = "btn_agregar_grupo"
        Me.btn_agregar_grupo.Size = New System.Drawing.Size(27, 22)
        Me.btn_agregar_grupo.TabIndex = 0
        Me.btn_agregar_grupo.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_quitar_rol)
        Me.GroupBox3.Controls.Add(Me.btn_agregar_rol)
        Me.GroupBox3.Controls.Add(Me.DataGridView3)
        Me.GroupBox3.Location = New System.Drawing.Point(431, 338)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 179)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Roles"
        '
        'btn_quitar_rol
        '
        Me.btn_quitar_rol.BackColor = System.Drawing.Color.White
        Me.btn_quitar_rol.BackgroundImage = Global.My.Resources.Resources.Delete
        Me.btn_quitar_rol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_rol.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_quitar_rol.Location = New System.Drawing.Point(290, 0)
        Me.btn_quitar_rol.Name = "btn_quitar_rol"
        Me.btn_quitar_rol.Size = New System.Drawing.Size(27, 22)
        Me.btn_quitar_rol.TabIndex = 1
        Me.btn_quitar_rol.UseVisualStyleBackColor = False
        '
        'btn_agregar_rol
        '
        Me.btn_agregar_rol.BackColor = System.Drawing.Color.White
        Me.btn_agregar_rol.BackgroundImage = Global.My.Resources.Resources.Add
        Me.btn_agregar_rol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar_rol.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_agregar_rol.Location = New System.Drawing.Point(257, 0)
        Me.btn_agregar_rol.Name = "btn_agregar_rol"
        Me.btn_agregar_rol.Size = New System.Drawing.Size(27, 22)
        Me.btn_agregar_rol.TabIndex = 0
        Me.btn_agregar_rol.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ROL, Me.Desc_Rol})
        Me.DataGridView3.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(311, 154)
        Me.DataGridView3.TabIndex = 10
        '
        'ID_ROL
        '
        Me.ID_ROL.DataPropertyName = "ID_ROL"
        Me.ID_ROL.HeaderText = "ID_ROL"
        Me.ID_ROL.Name = "ID_ROL"
        Me.ID_ROL.ReadOnly = True
        Me.ID_ROL.Width = 50
        '
        'Desc_Rol
        '
        Me.Desc_Rol.DataPropertyName = "DESC_ROL"
        Me.Desc_Rol.HeaderText = "Desc_Rol"
        Me.Desc_Rol.Name = "Desc_Rol"
        Me.Desc_Rol.ReadOnly = True
        Me.Desc_Rol.Width = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 521)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados/Grupos/Roles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_id_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_agregar_grupo As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_grupo As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_rol As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_rol As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_desb As System.Windows.Forms.Button
    Friend WithEvents lbl_agencia As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID_USER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PASSWORD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SW_BLOQUEO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONT_BLOQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_baja As System.Windows.Forms.Label
    Friend WithEvents ID_GRUPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_GRUPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ROL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desc_Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tt1 As System.Windows.Forms.ToolTip

End Class
