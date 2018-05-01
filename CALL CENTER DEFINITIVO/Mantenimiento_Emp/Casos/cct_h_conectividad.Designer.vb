<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cct_h_conectividad
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
        Me.lbl_reg_age = New System.Windows.Forms.Label()
        Me.gb_cone = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nota_ = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgv_cone = New System.Windows.Forms.DataGridView()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MDO_CONECT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dbmv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAC_ADD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INST_POR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GESTOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_INSERT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_UPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_eje = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gb_cone.SuspendLayout()
        CType(Me.dgv_cone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_reg_age
        '
        Me.lbl_reg_age.AutoSize = True
        Me.lbl_reg_age.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_reg_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reg_age.ForeColor = System.Drawing.Color.Blue
        Me.lbl_reg_age.Location = New System.Drawing.Point(12, 9)
        Me.lbl_reg_age.Name = "lbl_reg_age"
        Me.lbl_reg_age.Size = New System.Drawing.Size(73, 16)
        Me.lbl_reg_age.TabIndex = 80
        Me.lbl_reg_age.Text = "Agente !!!"
        '
        'gb_cone
        '
        Me.gb_cone.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gb_cone.Controls.Add(Me.txt_eje)
        Me.gb_cone.Controls.Add(Me.Label5)
        Me.gb_cone.Controls.Add(Me.Label8)
        Me.gb_cone.Controls.Add(Me.txt_nota_)
        Me.gb_cone.Controls.Add(Me.lbl_total)
        Me.gb_cone.Controls.Add(Me.Label11)
        Me.gb_cone.Controls.Add(Me.dgv_cone)
        Me.gb_cone.ForeColor = System.Drawing.Color.Navy
        Me.gb_cone.Location = New System.Drawing.Point(12, 28)
        Me.gb_cone.Name = "gb_cone"
        Me.gb_cone.Size = New System.Drawing.Size(1290, 223)
        Me.gb_cone.TabIndex = 81
        Me.gb_cone.TabStop = False
        Me.gb_cone.Text = "HISTORIAL DE CONECTIVIDAD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1107, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "NOTA:"
        '
        'txt_nota_
        '
        Me.txt_nota_.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nota_.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nota_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nota_.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota_.Location = New System.Drawing.Point(1110, 36)
        Me.txt_nota_.Multiline = True
        Me.txt_nota_.Name = "txt_nota_"
        Me.txt_nota_.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_nota_.Size = New System.Drawing.Size(174, 61)
        Me.txt_nota_.TabIndex = 87
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(136, 200)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(14, 13)
        Me.lbl_total.TabIndex = 86
        Me.lbl_total.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Total de intalaciones: "
        '
        'dgv_cone
        '
        Me.dgv_cone.AllowUserToAddRows = False
        Me.dgv_cone.AllowUserToDeleteRows = False
        Me.dgv_cone.AllowUserToOrderColumns = True
        Me.dgv_cone.AllowUserToResizeRows = False
        Me.dgv_cone.BackgroundColor = System.Drawing.Color.White
        Me.dgv_cone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_cone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FECHA, Me.HORA, Me.MODEM, Me.PROVE, Me.MDO_CONECT, Me.dbmv, Me.SERIAL, Me.NUMERO, Me.MAC_ADD, Me.INST_POR, Me.GESTOR, Me.USUARIO_INSERT, Me.USUARIO_UPDATE})
        Me.dgv_cone.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_cone.Location = New System.Drawing.Point(6, 19)
        Me.dgv_cone.MultiSelect = False
        Me.dgv_cone.Name = "dgv_cone"
        Me.dgv_cone.ReadOnly = True
        Me.dgv_cone.RowHeadersVisible = False
        Me.dgv_cone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cone.Size = New System.Drawing.Size(1095, 178)
        Me.dgv_cone.TabIndex = 1
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
        Me.btn_cerrar.Location = New System.Drawing.Point(1206, 257)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(96, 37)
        Me.btn_cerrar.TabIndex = 85
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Width = 70
        '
        'HORA
        '
        Me.HORA.DataPropertyName = "HORA"
        Me.HORA.HeaderText = "HORA"
        Me.HORA.Name = "HORA"
        Me.HORA.ReadOnly = True
        Me.HORA.Width = 60
        '
        'MODEM
        '
        Me.MODEM.DataPropertyName = "MODEM"
        Me.MODEM.HeaderText = "MODEM"
        Me.MODEM.Name = "MODEM"
        Me.MODEM.ReadOnly = True
        Me.MODEM.Width = 170
        '
        'PROVE
        '
        Me.PROVE.HeaderText = "PROVEEDOR"
        Me.PROVE.Name = "PROVE"
        Me.PROVE.ReadOnly = True
        '
        'MDO_CONECT
        '
        Me.MDO_CONECT.HeaderText = "MODO"
        Me.MDO_CONECT.Name = "MDO_CONECT"
        Me.MDO_CONECT.ReadOnly = True
        Me.MDO_CONECT.Width = 80
        '
        'dbmv
        '
        Me.dbmv.HeaderText = "dBmV"
        Me.dbmv.Name = "dbmv"
        Me.dbmv.ReadOnly = True
        Me.dbmv.Width = 40
        '
        'SERIAL
        '
        Me.SERIAL.DataPropertyName = "SERIAL"
        Me.SERIAL.HeaderText = "SERIAL"
        Me.SERIAL.Name = "SERIAL"
        Me.SERIAL.ReadOnly = True
        Me.SERIAL.Width = 110
        '
        'NUMERO
        '
        Me.NUMERO.DataPropertyName = "NUMERO"
        Me.NUMERO.HeaderText = "NUMERO"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Width = 80
        '
        'MAC_ADD
        '
        Me.MAC_ADD.HeaderText = "MAC ADD."
        Me.MAC_ADD.Name = "MAC_ADD"
        Me.MAC_ADD.ReadOnly = True
        '
        'INST_POR
        '
        Me.INST_POR.DataPropertyName = "INST_POR"
        Me.INST_POR.HeaderText = "INSTALADO POR"
        Me.INST_POR.Name = "INST_POR"
        Me.INST_POR.ReadOnly = True
        Me.INST_POR.Width = 150
        '
        'GESTOR
        '
        Me.GESTOR.DataPropertyName = "GESTOR"
        Me.GESTOR.HeaderText = "GESTOR"
        Me.GESTOR.Name = "GESTOR"
        Me.GESTOR.ReadOnly = True
        '
        'USUARIO_INSERT
        '
        Me.USUARIO_INSERT.DataPropertyName = "USUARIO_INSERT"
        Me.USUARIO_INSERT.HeaderText = "USUARIO_INSERT"
        Me.USUARIO_INSERT.Name = "USUARIO_INSERT"
        Me.USUARIO_INSERT.ReadOnly = True
        Me.USUARIO_INSERT.Visible = False
        '
        'USUARIO_UPDATE
        '
        Me.USUARIO_UPDATE.DataPropertyName = "USUARIO_UPDATE"
        Me.USUARIO_UPDATE.HeaderText = "USUARIO_UPDATE"
        Me.USUARIO_UPDATE.Name = "USUARIO_UPDATE"
        Me.USUARIO_UPDATE.ReadOnly = True
        Me.USUARIO_UPDATE.Visible = False
        '
        'txt_eje
        '
        Me.txt_eje.BackColor = System.Drawing.Color.White
        Me.txt_eje.Location = New System.Drawing.Point(1110, 133)
        Me.txt_eje.Name = "txt_eje"
        Me.txt_eje.ReadOnly = True
        Me.txt_eje.Size = New System.Drawing.Size(174, 20)
        Me.txt_eje.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1107, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Antena Externa:"
        '
        'cct_h_conectividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1306, 298)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.gb_cone)
        Me.Controls.Add(Me.lbl_reg_age)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cct_h_conectividad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIAL DE CONECTIVIDAD"
        Me.gb_cone.ResumeLayout(False)
        Me.gb_cone.PerformLayout()
        CType(Me.dgv_cone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_reg_age As System.Windows.Forms.Label
    Friend WithEvents gb_cone As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgv_cone As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_nota_ As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MDO_CONECT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dbmv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAC_ADD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INST_POR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GESTOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_INSERT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_UPDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_eje As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
