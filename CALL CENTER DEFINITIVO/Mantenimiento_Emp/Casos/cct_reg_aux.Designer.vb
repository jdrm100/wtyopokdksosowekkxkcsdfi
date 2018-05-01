<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cct_reg_aux
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
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.gb_est_tk = New System.Windows.Forms.GroupBox()
        Me.lbl_verif = New System.Windows.Forms.Label()
        Me.lbl_est_tk = New System.Windows.Forms.Label()
        Me.txt_nota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_h_reg = New System.Windows.Forms.DataGridView()
        Me.ID_MOTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_LLAMADA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_INSERT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_UPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_INCIDENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_CONCLUSION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INCIDENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONCLUSION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EST_TK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VERIF_SN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cont = New System.Windows.Forms.TextBox()
        Me.txt_tp_cont = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_llamada = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_dur = New System.Windows.Forms.Label()
        Me.lbl_hf = New System.Windows.Forms.Label()
        Me.lbl_hi = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_tk_pr = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_tk_c = New System.Windows.Forms.Label()
        Me.lbl_tk_a = New System.Windows.Forms.Label()
        Me.lbl_usu = New System.Windows.Forms.Label()
        Me.TT1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox7.SuspendLayout()
        Me.gb_est_tk.SuspendLayout()
        CType(Me.dgv_h_reg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox7.Controls.Add(Me.gb_est_tk)
        Me.GroupBox7.Controls.Add(Me.txt_nota)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.dgv_h_reg)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(6, 90)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(597, 177)
        Me.GroupBox7.TabIndex = 84
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "ACTIVIDADES REGISTRADAS"
        '
        'gb_est_tk
        '
        Me.gb_est_tk.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gb_est_tk.Controls.Add(Me.lbl_verif)
        Me.gb_est_tk.Controls.Add(Me.lbl_est_tk)
        Me.gb_est_tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_est_tk.ForeColor = System.Drawing.Color.Black
        Me.gb_est_tk.Location = New System.Drawing.Point(455, 90)
        Me.gb_est_tk.Name = "gb_est_tk"
        Me.gb_est_tk.Size = New System.Drawing.Size(102, 81)
        Me.gb_est_tk.TabIndex = 97
        Me.gb_est_tk.TabStop = False
        Me.gb_est_tk.Text = "Estado de ticket:"
        '
        'lbl_verif
        '
        Me.lbl_verif.AutoSize = True
        Me.lbl_verif.BackColor = System.Drawing.Color.Transparent
        Me.lbl_verif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_verif.ForeColor = System.Drawing.Color.Navy
        Me.lbl_verif.Location = New System.Drawing.Point(26, 51)
        Me.lbl_verif.Name = "lbl_verif"
        Me.lbl_verif.Size = New System.Drawing.Size(23, 13)
        Me.lbl_verif.TabIndex = 96
        Me.lbl_verif.Text = "##"
        '
        'lbl_est_tk
        '
        Me.lbl_est_tk.AutoSize = True
        Me.lbl_est_tk.BackColor = System.Drawing.Color.Transparent
        Me.lbl_est_tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_est_tk.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_est_tk.Location = New System.Drawing.Point(26, 25)
        Me.lbl_est_tk.Name = "lbl_est_tk"
        Me.lbl_est_tk.Size = New System.Drawing.Size(23, 13)
        Me.lbl_est_tk.TabIndex = 95
        Me.lbl_est_tk.Text = "##"
        '
        'txt_nota
        '
        Me.txt_nota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota.Location = New System.Drawing.Point(416, 33)
        Me.txt_nota.Multiline = True
        Me.txt_nota.Name = "txt_nota"
        Me.txt_nota.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_nota.Size = New System.Drawing.Size(174, 50)
        Me.txt_nota.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(413, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "NOTA:"
        '
        'dgv_h_reg
        '
        Me.dgv_h_reg.AllowUserToAddRows = False
        Me.dgv_h_reg.AllowUserToDeleteRows = False
        Me.dgv_h_reg.AllowUserToOrderColumns = True
        Me.dgv_h_reg.AllowUserToResizeRows = False
        Me.dgv_h_reg.BackgroundColor = System.Drawing.Color.White
        Me.dgv_h_reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_h_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_h_reg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_MOTIVO, Me.ID_LLAMADA, Me.USUARIO_INSERT, Me.USUARIO_UPDATE, Me.ID_INCIDENCIA, Me.ID_CONCLUSION, Me.ID, Me.MOTIVO, Me.INCIDENCIA, Me.CONCLUSION, Me.NOTA, Me.EST_TK, Me.VERIF_SN})
        Me.dgv_h_reg.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_h_reg.Location = New System.Drawing.Point(9, 17)
        Me.dgv_h_reg.MultiSelect = False
        Me.dgv_h_reg.Name = "dgv_h_reg"
        Me.dgv_h_reg.ReadOnly = True
        Me.dgv_h_reg.RowHeadersVisible = False
        Me.dgv_h_reg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_h_reg.Size = New System.Drawing.Size(398, 154)
        Me.dgv_h_reg.TabIndex = 2
        '
        'ID_MOTIVO
        '
        Me.ID_MOTIVO.DataPropertyName = "ID_MOTIVO"
        Me.ID_MOTIVO.HeaderText = "ID_MOTIVO"
        Me.ID_MOTIVO.Name = "ID_MOTIVO"
        Me.ID_MOTIVO.ReadOnly = True
        Me.ID_MOTIVO.Visible = False
        '
        'ID_LLAMADA
        '
        Me.ID_LLAMADA.DataPropertyName = "ID_LLAMADA"
        Me.ID_LLAMADA.HeaderText = "ID_LLAMADA"
        Me.ID_LLAMADA.Name = "ID_LLAMADA"
        Me.ID_LLAMADA.ReadOnly = True
        Me.ID_LLAMADA.Visible = False
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
        'ID_INCIDENCIA
        '
        Me.ID_INCIDENCIA.DataPropertyName = "ID_INCIDENCIA"
        Me.ID_INCIDENCIA.HeaderText = "ID_INCIDENCIA"
        Me.ID_INCIDENCIA.Name = "ID_INCIDENCIA"
        Me.ID_INCIDENCIA.ReadOnly = True
        Me.ID_INCIDENCIA.Visible = False
        '
        'ID_CONCLUSION
        '
        Me.ID_CONCLUSION.DataPropertyName = "ID_CONCLUSION"
        Me.ID_CONCLUSION.HeaderText = "ID_CONCLUSION"
        Me.ID_CONCLUSION.Name = "ID_CONCLUSION"
        Me.ID_CONCLUSION.ReadOnly = True
        Me.ID_CONCLUSION.Visible = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 70
        '
        'MOTIVO
        '
        Me.MOTIVO.DataPropertyName = "DESC_MOTIVO"
        Me.MOTIVO.HeaderText = "MOTIVO"
        Me.MOTIVO.Name = "MOTIVO"
        Me.MOTIVO.ReadOnly = True
        Me.MOTIVO.Width = 120
        '
        'INCIDENCIA
        '
        Me.INCIDENCIA.DataPropertyName = "DESC_INCIDENCIA"
        Me.INCIDENCIA.HeaderText = "INCIDENCIA"
        Me.INCIDENCIA.Name = "INCIDENCIA"
        Me.INCIDENCIA.ReadOnly = True
        Me.INCIDENCIA.Width = 120
        '
        'CONCLUSION
        '
        Me.CONCLUSION.DataPropertyName = "DESC_CONCLUSION"
        Me.CONCLUSION.HeaderText = "CONCLUSION"
        Me.CONCLUSION.Name = "CONCLUSION"
        Me.CONCLUSION.ReadOnly = True
        Me.CONCLUSION.Width = 120
        '
        'NOTA
        '
        Me.NOTA.DataPropertyName = "NOTA"
        Me.NOTA.HeaderText = "NOTA"
        Me.NOTA.Name = "NOTA"
        Me.NOTA.ReadOnly = True
        Me.NOTA.Visible = False
        '
        'EST_TK
        '
        Me.EST_TK.DataPropertyName = "EST_TK"
        Me.EST_TK.HeaderText = "EST_TK"
        Me.EST_TK.Name = "EST_TK"
        Me.EST_TK.ReadOnly = True
        Me.EST_TK.Visible = False
        '
        'VERIF_SN
        '
        Me.VERIF_SN.DataPropertyName = "VERIF_SN"
        Me.VERIF_SN.HeaderText = "VERIF_SN"
        Me.VERIF_SN.Name = "VERIF_SN"
        Me.VERIF_SN.ReadOnly = True
        Me.VERIF_SN.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "LLamada:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Contacto:"
        '
        'txt_cont
        '
        Me.txt_cont.BackColor = System.Drawing.Color.White
        Me.txt_cont.Location = New System.Drawing.Point(58, 37)
        Me.txt_cont.Name = "txt_cont"
        Me.txt_cont.ReadOnly = True
        Me.txt_cont.Size = New System.Drawing.Size(154, 20)
        Me.txt_cont.TabIndex = 85
        '
        'txt_tp_cont
        '
        Me.txt_tp_cont.BackColor = System.Drawing.Color.White
        Me.txt_tp_cont.Location = New System.Drawing.Point(216, 38)
        Me.txt_tp_cont.Name = "txt_tp_cont"
        Me.txt_tp_cont.ReadOnly = True
        Me.txt_tp_cont.Size = New System.Drawing.Size(82, 20)
        Me.txt_tp_cont.TabIndex = 87
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Tickets Abiertos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Tickets Cerrados:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.lbl_llamada)
        Me.GroupBox1.Controls.Add(Me.lbl_fecha)
        Me.GroupBox1.Controls.Add(Me.lbl_dur)
        Me.GroupBox1.Controls.Add(Me.txt_cont)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_hf)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_tp_cont)
        Me.GroupBox1.Controls.Add(Me.lbl_hi)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 80)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION GENERAL"
        '
        'lbl_llamada
        '
        Me.lbl_llamada.AutoSize = True
        Me.lbl_llamada.BackColor = System.Drawing.Color.Transparent
        Me.lbl_llamada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_llamada.ForeColor = System.Drawing.Color.Black
        Me.lbl_llamada.Location = New System.Drawing.Point(55, 19)
        Me.lbl_llamada.Name = "lbl_llamada"
        Me.lbl_llamada.Size = New System.Drawing.Size(115, 13)
        Me.lbl_llamada.TabIndex = 96
        Me.lbl_llamada.Text = "Entrante / Saliente"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecha.Location = New System.Drawing.Point(223, 19)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(75, 13)
        Me.lbl_fecha.TabIndex = 91
        Me.lbl_fecha.Text = "01/01/2016"
        '
        'lbl_dur
        '
        Me.lbl_dur.AutoSize = True
        Me.lbl_dur.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dur.ForeColor = System.Drawing.Color.Black
        Me.lbl_dur.Location = New System.Drawing.Point(223, 64)
        Me.lbl_dur.Name = "lbl_dur"
        Me.lbl_dur.Size = New System.Drawing.Size(57, 13)
        Me.lbl_dur.TabIndex = 95
        Me.lbl_dur.Text = "00:00:00"
        Me.TT1.SetToolTip(Me.lbl_dur, "Duracion")
        '
        'lbl_hf
        '
        Me.lbl_hf.AutoSize = True
        Me.lbl_hf.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hf.ForeColor = System.Drawing.Color.Black
        Me.lbl_hf.Location = New System.Drawing.Point(163, 64)
        Me.lbl_hf.Name = "lbl_hf"
        Me.lbl_hf.Size = New System.Drawing.Size(49, 13)
        Me.lbl_hf.TabIndex = 93
        Me.lbl_hf.Text = "00:00:00"
        '
        'lbl_hi
        '
        Me.lbl_hi.AutoSize = True
        Me.lbl_hi.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hi.ForeColor = System.Drawing.Color.Black
        Me.lbl_hi.Location = New System.Drawing.Point(62, 64)
        Me.lbl_hi.Name = "lbl_hi"
        Me.lbl_hi.Size = New System.Drawing.Size(49, 13)
        Me.lbl_hi.TabIndex = 92
        Me.lbl_hi.Text = "00:00:00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(188, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Fecha:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(117, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Hora Fin:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Hora Inicio:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox2.Controls.Add(Me.lbl_tk_pr)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lbl_tk_c)
        Me.GroupBox2.Controls.Add(Me.lbl_tk_a)
        Me.GroupBox2.Controls.Add(Me.lbl_usu)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(316, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 80)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMACION DE TICKETS"
        '
        'lbl_tk_pr
        '
        Me.lbl_tk_pr.AutoSize = True
        Me.lbl_tk_pr.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tk_pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tk_pr.ForeColor = System.Drawing.Color.Black
        Me.lbl_tk_pr.Location = New System.Drawing.Point(257, 64)
        Me.lbl_tk_pr.Name = "lbl_tk_pr"
        Me.lbl_tk_pr.Size = New System.Drawing.Size(23, 13)
        Me.lbl_tk_pr.TabIndex = 96
        Me.lbl_tk_pr.Text = "##"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(157, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 13)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "Tickets Por Verificar:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(50, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Usuario:"
        '
        'lbl_tk_c
        '
        Me.lbl_tk_c.AutoSize = True
        Me.lbl_tk_c.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tk_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tk_c.ForeColor = System.Drawing.Color.Black
        Me.lbl_tk_c.Location = New System.Drawing.Point(95, 64)
        Me.lbl_tk_c.Name = "lbl_tk_c"
        Me.lbl_tk_c.Size = New System.Drawing.Size(23, 13)
        Me.lbl_tk_c.TabIndex = 94
        Me.lbl_tk_c.Text = "##"
        '
        'lbl_tk_a
        '
        Me.lbl_tk_a.AutoSize = True
        Me.lbl_tk_a.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tk_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tk_a.ForeColor = System.Drawing.Color.Black
        Me.lbl_tk_a.Location = New System.Drawing.Point(95, 40)
        Me.lbl_tk_a.Name = "lbl_tk_a"
        Me.lbl_tk_a.Size = New System.Drawing.Size(23, 13)
        Me.lbl_tk_a.TabIndex = 93
        Me.lbl_tk_a.Text = "##"
        '
        'lbl_usu
        '
        Me.lbl_usu.AutoSize = True
        Me.lbl_usu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usu.ForeColor = System.Drawing.Color.Black
        Me.lbl_usu.Location = New System.Drawing.Point(95, 19)
        Me.lbl_usu.Name = "lbl_usu"
        Me.lbl_usu.Size = New System.Drawing.Size(113, 13)
        Me.lbl_usu.TabIndex = 92
        Me.lbl_usu.Text = "Nombre de usuario"
        '
        'TT1
        '
        Me.TT1.AutomaticDelay = 300
        Me.TT1.AutoPopDelay = 9000
        Me.TT1.InitialDelay = 300
        Me.TT1.IsBalloon = True
        Me.TT1.ReshowDelay = 60
        '
        'cct_reg_aux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(607, 272)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cct_reg_aux"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLE DE LLAMADA"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.gb_est_tk.ResumeLayout(False)
        Me.gb_est_tk.PerformLayout()
        CType(Me.dgv_h_reg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_h_reg As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nota As System.Windows.Forms.TextBox
    Friend WithEvents txt_cont As System.Windows.Forms.TextBox
    Friend WithEvents txt_tp_cont As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_hf As System.Windows.Forms.Label
    Friend WithEvents lbl_hi As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TT1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_tk_c As System.Windows.Forms.Label
    Friend WithEvents lbl_tk_a As System.Windows.Forms.Label
    Friend WithEvents lbl_usu As System.Windows.Forms.Label
    Friend WithEvents lbl_llamada As System.Windows.Forms.Label
    Friend WithEvents lbl_tk_pr As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lbl_dur As System.Windows.Forms.Label
    Friend WithEvents ID_MOTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_LLAMADA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_INSERT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_UPDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_INCIDENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_CONCLUSION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INCIDENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONCLUSION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EST_TK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VERIF_SN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_est_tk As System.Windows.Forms.Label
    Friend WithEvents lbl_verif As System.Windows.Forms.Label
    Friend WithEvents gb_est_tk As System.Windows.Forms.GroupBox
End Class
