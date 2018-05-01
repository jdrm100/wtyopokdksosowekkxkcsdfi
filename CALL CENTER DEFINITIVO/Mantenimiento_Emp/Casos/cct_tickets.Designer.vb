<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cct_tickets
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
        Me.lbl_dias_abie = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nota_abierto = New System.Windows.Forms.TextBox()
        Me.dgv_tks_a = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO_TICKET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOTIVO_APERTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INCIDENCIA_APERTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTO_APERTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GESTOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_INSERT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_UPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INCIDENCIA_CIERRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTO_CIERRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTA_CIERRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GESTOR_CIERRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_CIERRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA_CIERRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS_ABIERTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPARACION_INCIDENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VERIFICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VERIFICADO_POR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTA_VERIFICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_VERIFICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA_VERIFICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS_POR_VERIFICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_reg_age = New System.Windows.Forms.Label()
        Me.gb_tk_cie = New System.Windows.Forms.GroupBox()
        Me.lbl_comp = New System.Windows.Forms.Label()
        Me.txt_nota_cie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ges_cie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cont_cie = New System.Windows.Forms.TextBox()
        Me.txt_fec_cie = New System.Windows.Forms.TextBox()
        Me.txt_inc_cie = New System.Windows.Forms.TextBox()
        Me.gb_tk_verif = New System.Windows.Forms.GroupBox()
        Me.lbl_dias_verif = New System.Windows.Forms.Label()
        Me.txt_nota_verif = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_ges_verif = New System.Windows.Forms.TextBox()
        Me.txt_fec_verif = New System.Windows.Forms.TextBox()
        Me.txt_inc_verif = New System.Windows.Forms.TextBox()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.gb_agente.SuspendLayout()
        CType(Me.dgv_tks_a, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tk_cie.SuspendLayout()
        Me.gb_tk_verif.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_agente
        '
        Me.gb_agente.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gb_agente.Controls.Add(Me.lbl_total)
        Me.gb_agente.Controls.Add(Me.Label11)
        Me.gb_agente.Controls.Add(Me.lbl_dias_abie)
        Me.gb_agente.Controls.Add(Me.Label8)
        Me.gb_agente.Controls.Add(Me.txt_nota_abierto)
        Me.gb_agente.Controls.Add(Me.dgv_tks_a)
        Me.gb_agente.ForeColor = System.Drawing.Color.Navy
        Me.gb_agente.Location = New System.Drawing.Point(12, 24)
        Me.gb_agente.Name = "gb_agente"
        Me.gb_agente.Size = New System.Drawing.Size(954, 202)
        Me.gb_agente.TabIndex = 38
        Me.gb_agente.TabStop = False
        Me.gb_agente.Text = "HISTORIAL DE TICKETS"
        '
        'lbl_dias_abie
        '
        Me.lbl_dias_abie.AutoSize = True
        Me.lbl_dias_abie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_dias_abie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dias_abie.ForeColor = System.Drawing.Color.Red
        Me.lbl_dias_abie.Location = New System.Drawing.Point(766, 113)
        Me.lbl_dias_abie.Name = "lbl_dias_abie"
        Me.lbl_dias_abie.Size = New System.Drawing.Size(11, 13)
        Me.lbl_dias_abie.TabIndex = 84
        Me.lbl_dias_abie.Text = "f"
        Me.lbl_dias_abie.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(766, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "NOTA:"
        '
        'txt_nota_abierto
        '
        Me.txt_nota_abierto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nota_abierto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nota_abierto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nota_abierto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota_abierto.Location = New System.Drawing.Point(769, 35)
        Me.txt_nota_abierto.Multiline = True
        Me.txt_nota_abierto.Name = "txt_nota_abierto"
        Me.txt_nota_abierto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_nota_abierto.Size = New System.Drawing.Size(174, 61)
        Me.txt_nota_abierto.TabIndex = 75
        '
        'dgv_tks_a
        '
        Me.dgv_tks_a.AllowUserToAddRows = False
        Me.dgv_tks_a.AllowUserToDeleteRows = False
        Me.dgv_tks_a.AllowUserToOrderColumns = True
        Me.dgv_tks_a.AllowUserToResizeRows = False
        Me.dgv_tks_a.BackgroundColor = System.Drawing.Color.White
        Me.dgv_tks_a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_tks_a.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tks_a.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FECHA, Me.HORA, Me.ESTADO_TICKET, Me.MOTIVO_APERTURA, Me.INCIDENCIA_APERTURA, Me.CONTACTO_APERTURA, Me.GESTOR, Me.USUARIO_INSERT, Me.USUARIO_UPDATE, Me.NOTA, Me.INCIDENCIA_CIERRE, Me.CONTACTO_CIERRE, Me.NOTA_CIERRE, Me.GESTOR_CIERRE, Me.FECHA_CIERRE, Me.HORA_CIERRE, Me.DIAS_ABIERTO, Me.COMPARACION_INCIDENCIA, Me.VERIFICACION, Me.VERIFICADO_POR, Me.NOTA_VERIFICACION, Me.FECHA_VERIFICACION, Me.HORA_VERIFICACION, Me.DIAS_POR_VERIFICACION})
        Me.dgv_tks_a.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_tks_a.Location = New System.Drawing.Point(6, 19)
        Me.dgv_tks_a.MultiSelect = False
        Me.dgv_tks_a.Name = "dgv_tks_a"
        Me.dgv_tks_a.ReadOnly = True
        Me.dgv_tks_a.RowHeadersVisible = False
        Me.dgv_tks_a.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tks_a.Size = New System.Drawing.Size(754, 178)
        Me.dgv_tks_a.TabIndex = 1
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
        'ESTADO_TICKET
        '
        Me.ESTADO_TICKET.DataPropertyName = "ESTADO_TICKET"
        Me.ESTADO_TICKET.HeaderText = "ESTADO"
        Me.ESTADO_TICKET.Name = "ESTADO_TICKET"
        Me.ESTADO_TICKET.ReadOnly = True
        Me.ESTADO_TICKET.Width = 90
        '
        'MOTIVO_APERTURA
        '
        Me.MOTIVO_APERTURA.DataPropertyName = "MOTIVO_APERTURA"
        Me.MOTIVO_APERTURA.HeaderText = "MOTIVO"
        Me.MOTIVO_APERTURA.Name = "MOTIVO_APERTURA"
        Me.MOTIVO_APERTURA.ReadOnly = True
        Me.MOTIVO_APERTURA.Width = 150
        '
        'INCIDENCIA_APERTURA
        '
        Me.INCIDENCIA_APERTURA.DataPropertyName = "INCIDENCIA_APERTURA"
        Me.INCIDENCIA_APERTURA.HeaderText = "INCIDENCIA"
        Me.INCIDENCIA_APERTURA.Name = "INCIDENCIA_APERTURA"
        Me.INCIDENCIA_APERTURA.ReadOnly = True
        Me.INCIDENCIA_APERTURA.Width = 150
        '
        'CONTACTO_APERTURA
        '
        Me.CONTACTO_APERTURA.DataPropertyName = "CONTACTO_APERTURA"
        Me.CONTACTO_APERTURA.HeaderText = "CONTACTO"
        Me.CONTACTO_APERTURA.Name = "CONTACTO_APERTURA"
        Me.CONTACTO_APERTURA.ReadOnly = True
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
        'NOTA
        '
        Me.NOTA.DataPropertyName = "NOTA"
        Me.NOTA.HeaderText = "NOTA"
        Me.NOTA.Name = "NOTA"
        Me.NOTA.ReadOnly = True
        Me.NOTA.Visible = False
        '
        'INCIDENCIA_CIERRE
        '
        Me.INCIDENCIA_CIERRE.DataPropertyName = "INCIDENCIA_CIERRE"
        Me.INCIDENCIA_CIERRE.HeaderText = "INCIDENCIA_CIERRE"
        Me.INCIDENCIA_CIERRE.Name = "INCIDENCIA_CIERRE"
        Me.INCIDENCIA_CIERRE.ReadOnly = True
        Me.INCIDENCIA_CIERRE.Visible = False
        '
        'CONTACTO_CIERRE
        '
        Me.CONTACTO_CIERRE.DataPropertyName = "CONTACTO_CIERRE"
        Me.CONTACTO_CIERRE.HeaderText = "CONTACTO_CIERRE"
        Me.CONTACTO_CIERRE.Name = "CONTACTO_CIERRE"
        Me.CONTACTO_CIERRE.ReadOnly = True
        Me.CONTACTO_CIERRE.Visible = False
        '
        'NOTA_CIERRE
        '
        Me.NOTA_CIERRE.DataPropertyName = "NOTA_CIERRE"
        Me.NOTA_CIERRE.HeaderText = "NOTA_CIERRE"
        Me.NOTA_CIERRE.Name = "NOTA_CIERRE"
        Me.NOTA_CIERRE.ReadOnly = True
        Me.NOTA_CIERRE.Visible = False
        '
        'GESTOR_CIERRE
        '
        Me.GESTOR_CIERRE.DataPropertyName = "GESTOR_CIERRE"
        Me.GESTOR_CIERRE.HeaderText = "GESTOR_CIERRE"
        Me.GESTOR_CIERRE.Name = "GESTOR_CIERRE"
        Me.GESTOR_CIERRE.ReadOnly = True
        Me.GESTOR_CIERRE.Visible = False
        '
        'FECHA_CIERRE
        '
        Me.FECHA_CIERRE.DataPropertyName = "FECHA_CIERRE"
        Me.FECHA_CIERRE.HeaderText = "FECHA_CIERRE"
        Me.FECHA_CIERRE.Name = "FECHA_CIERRE"
        Me.FECHA_CIERRE.ReadOnly = True
        Me.FECHA_CIERRE.Visible = False
        '
        'HORA_CIERRE
        '
        Me.HORA_CIERRE.DataPropertyName = "HORA_CIERRE"
        Me.HORA_CIERRE.HeaderText = "HORA_CIERRE"
        Me.HORA_CIERRE.Name = "HORA_CIERRE"
        Me.HORA_CIERRE.ReadOnly = True
        Me.HORA_CIERRE.Visible = False
        '
        'DIAS_ABIERTO
        '
        Me.DIAS_ABIERTO.DataPropertyName = "DIAS_ABIERTO"
        Me.DIAS_ABIERTO.HeaderText = "DIAS_ABIERTO"
        Me.DIAS_ABIERTO.Name = "DIAS_ABIERTO"
        Me.DIAS_ABIERTO.ReadOnly = True
        Me.DIAS_ABIERTO.Visible = False
        '
        'COMPARACION_INCIDENCIA
        '
        Me.COMPARACION_INCIDENCIA.DataPropertyName = "COMPARACION_INCIDENCIA"
        Me.COMPARACION_INCIDENCIA.HeaderText = "COMPARACION_INCIDENCIA"
        Me.COMPARACION_INCIDENCIA.Name = "COMPARACION_INCIDENCIA"
        Me.COMPARACION_INCIDENCIA.ReadOnly = True
        Me.COMPARACION_INCIDENCIA.Visible = False
        '
        'VERIFICACION
        '
        Me.VERIFICACION.DataPropertyName = "VERIFICACION"
        Me.VERIFICACION.HeaderText = "VERIFICACION"
        Me.VERIFICACION.Name = "VERIFICACION"
        Me.VERIFICACION.ReadOnly = True
        Me.VERIFICACION.Visible = False
        '
        'VERIFICADO_POR
        '
        Me.VERIFICADO_POR.DataPropertyName = "VERIFICADO_POR"
        Me.VERIFICADO_POR.HeaderText = "VERIFICADO_POR"
        Me.VERIFICADO_POR.Name = "VERIFICADO_POR"
        Me.VERIFICADO_POR.ReadOnly = True
        Me.VERIFICADO_POR.Visible = False
        '
        'NOTA_VERIFICACION
        '
        Me.NOTA_VERIFICACION.DataPropertyName = "NOTA_VERIFICACION"
        Me.NOTA_VERIFICACION.HeaderText = "NOTA_VERIFICACION"
        Me.NOTA_VERIFICACION.Name = "NOTA_VERIFICACION"
        Me.NOTA_VERIFICACION.ReadOnly = True
        Me.NOTA_VERIFICACION.Visible = False
        '
        'FECHA_VERIFICACION
        '
        Me.FECHA_VERIFICACION.DataPropertyName = "FECHA_VERIFICACION"
        Me.FECHA_VERIFICACION.HeaderText = "FECHA_VERIFICACION"
        Me.FECHA_VERIFICACION.Name = "FECHA_VERIFICACION"
        Me.FECHA_VERIFICACION.ReadOnly = True
        Me.FECHA_VERIFICACION.Visible = False
        '
        'HORA_VERIFICACION
        '
        Me.HORA_VERIFICACION.DataPropertyName = "HORA_VERIFICACION"
        Me.HORA_VERIFICACION.HeaderText = "HORA_VERIFICACION"
        Me.HORA_VERIFICACION.Name = "HORA_VERIFICACION"
        Me.HORA_VERIFICACION.ReadOnly = True
        Me.HORA_VERIFICACION.Visible = False
        '
        'DIAS_POR_VERIFICACION
        '
        Me.DIAS_POR_VERIFICACION.DataPropertyName = "DIAS_POR_VERIFICACION"
        Me.DIAS_POR_VERIFICACION.HeaderText = "DIAS_POR_VERIFICACION"
        Me.DIAS_POR_VERIFICACION.Name = "DIAS_POR_VERIFICACION"
        Me.DIAS_POR_VERIFICACION.ReadOnly = True
        Me.DIAS_POR_VERIFICACION.Visible = False
        '
        'lbl_reg_age
        '
        Me.lbl_reg_age.AutoSize = True
        Me.lbl_reg_age.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_reg_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reg_age.ForeColor = System.Drawing.Color.Blue
        Me.lbl_reg_age.Location = New System.Drawing.Point(12, 5)
        Me.lbl_reg_age.Name = "lbl_reg_age"
        Me.lbl_reg_age.Size = New System.Drawing.Size(73, 16)
        Me.lbl_reg_age.TabIndex = 79
        Me.lbl_reg_age.Text = "Agente !!!"
        '
        'gb_tk_cie
        '
        Me.gb_tk_cie.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gb_tk_cie.Controls.Add(Me.lbl_comp)
        Me.gb_tk_cie.Controls.Add(Me.txt_nota_cie)
        Me.gb_tk_cie.Controls.Add(Me.Label2)
        Me.gb_tk_cie.Controls.Add(Me.Label3)
        Me.gb_tk_cie.Controls.Add(Me.Label4)
        Me.gb_tk_cie.Controls.Add(Me.Label5)
        Me.gb_tk_cie.Controls.Add(Me.txt_ges_cie)
        Me.gb_tk_cie.Controls.Add(Me.Label6)
        Me.gb_tk_cie.Controls.Add(Me.txt_cont_cie)
        Me.gb_tk_cie.Controls.Add(Me.txt_fec_cie)
        Me.gb_tk_cie.Controls.Add(Me.txt_inc_cie)
        Me.gb_tk_cie.ForeColor = System.Drawing.Color.Navy
        Me.gb_tk_cie.Location = New System.Drawing.Point(12, 232)
        Me.gb_tk_cie.Name = "gb_tk_cie"
        Me.gb_tk_cie.Size = New System.Drawing.Size(259, 186)
        Me.gb_tk_cie.TabIndex = 81
        Me.gb_tk_cie.TabStop = False
        Me.gb_tk_cie.Text = "DATOS DE CIERRE"
        '
        'lbl_comp
        '
        Me.lbl_comp.AutoSize = True
        Me.lbl_comp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_comp.ForeColor = System.Drawing.Color.Red
        Me.lbl_comp.Location = New System.Drawing.Point(77, 59)
        Me.lbl_comp.Name = "lbl_comp"
        Me.lbl_comp.Size = New System.Drawing.Size(11, 13)
        Me.lbl_comp.TabIndex = 78
        Me.lbl_comp.Text = "I"
        Me.lbl_comp.Visible = False
        '
        'txt_nota_cie
        '
        Me.txt_nota_cie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nota_cie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nota_cie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nota_cie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota_cie.Location = New System.Drawing.Point(79, 120)
        Me.txt_nota_cie.Multiline = True
        Me.txt_nota_cie.Name = "txt_nota_cie"
        Me.txt_nota_cie.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_nota_cie.Size = New System.Drawing.Size(174, 61)
        Me.txt_nota_cie.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Nota:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(28, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Gestor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Incidencia:"
        '
        'txt_ges_cie
        '
        Me.txt_ges_cie.BackColor = System.Drawing.Color.White
        Me.txt_ges_cie.Location = New System.Drawing.Point(79, 97)
        Me.txt_ges_cie.Name = "txt_ges_cie"
        Me.txt_ges_cie.ReadOnly = True
        Me.txt_ges_cie.Size = New System.Drawing.Size(174, 20)
        Me.txt_ges_cie.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Contacto:"
        '
        'txt_cont_cie
        '
        Me.txt_cont_cie.BackColor = System.Drawing.Color.White
        Me.txt_cont_cie.Location = New System.Drawing.Point(80, 14)
        Me.txt_cont_cie.Name = "txt_cont_cie"
        Me.txt_cont_cie.ReadOnly = True
        Me.txt_cont_cie.Size = New System.Drawing.Size(174, 20)
        Me.txt_cont_cie.TabIndex = 15
        '
        'txt_fec_cie
        '
        Me.txt_fec_cie.BackColor = System.Drawing.Color.White
        Me.txt_fec_cie.Location = New System.Drawing.Point(79, 75)
        Me.txt_fec_cie.Name = "txt_fec_cie"
        Me.txt_fec_cie.ReadOnly = True
        Me.txt_fec_cie.Size = New System.Drawing.Size(174, 20)
        Me.txt_fec_cie.TabIndex = 2
        '
        'txt_inc_cie
        '
        Me.txt_inc_cie.BackColor = System.Drawing.Color.White
        Me.txt_inc_cie.Location = New System.Drawing.Point(80, 36)
        Me.txt_inc_cie.Name = "txt_inc_cie"
        Me.txt_inc_cie.ReadOnly = True
        Me.txt_inc_cie.Size = New System.Drawing.Size(174, 20)
        Me.txt_inc_cie.TabIndex = 1
        '
        'gb_tk_verif
        '
        Me.gb_tk_verif.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gb_tk_verif.Controls.Add(Me.lbl_dias_verif)
        Me.gb_tk_verif.Controls.Add(Me.txt_nota_verif)
        Me.gb_tk_verif.Controls.Add(Me.Label1)
        Me.gb_tk_verif.Controls.Add(Me.Label7)
        Me.gb_tk_verif.Controls.Add(Me.Label9)
        Me.gb_tk_verif.Controls.Add(Me.Label10)
        Me.gb_tk_verif.Controls.Add(Me.txt_ges_verif)
        Me.gb_tk_verif.Controls.Add(Me.txt_fec_verif)
        Me.gb_tk_verif.Controls.Add(Me.txt_inc_verif)
        Me.gb_tk_verif.ForeColor = System.Drawing.Color.Navy
        Me.gb_tk_verif.Location = New System.Drawing.Point(277, 232)
        Me.gb_tk_verif.Name = "gb_tk_verif"
        Me.gb_tk_verif.Size = New System.Drawing.Size(259, 186)
        Me.gb_tk_verif.TabIndex = 82
        Me.gb_tk_verif.TabStop = False
        Me.gb_tk_verif.Text = "DATOS DE VERIFICACION"
        '
        'lbl_dias_verif
        '
        Me.lbl_dias_verif.AutoSize = True
        Me.lbl_dias_verif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_dias_verif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dias_verif.ForeColor = System.Drawing.Color.Red
        Me.lbl_dias_verif.Location = New System.Drawing.Point(7, 16)
        Me.lbl_dias_verif.Name = "lbl_dias_verif"
        Me.lbl_dias_verif.Size = New System.Drawing.Size(11, 13)
        Me.lbl_dias_verif.TabIndex = 77
        Me.lbl_dias_verif.Text = "f"
        Me.lbl_dias_verif.Visible = False
        '
        'txt_nota_verif
        '
        Me.txt_nota_verif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nota_verif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nota_verif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nota_verif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota_verif.Location = New System.Drawing.Point(80, 117)
        Me.txt_nota_verif.Multiline = True
        Me.txt_nota_verif.Name = "txt_nota_verif"
        Me.txt_nota_verif.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_nota_verif.Size = New System.Drawing.Size(174, 61)
        Me.txt_nota_verif.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(39, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Nota:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(29, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Gestor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Incidencia:"
        '
        'txt_ges_verif
        '
        Me.txt_ges_verif.BackColor = System.Drawing.Color.White
        Me.txt_ges_verif.Location = New System.Drawing.Point(80, 94)
        Me.txt_ges_verif.Name = "txt_ges_verif"
        Me.txt_ges_verif.ReadOnly = True
        Me.txt_ges_verif.Size = New System.Drawing.Size(174, 20)
        Me.txt_ges_verif.TabIndex = 35
        '
        'txt_fec_verif
        '
        Me.txt_fec_verif.BackColor = System.Drawing.Color.White
        Me.txt_fec_verif.Location = New System.Drawing.Point(80, 72)
        Me.txt_fec_verif.Name = "txt_fec_verif"
        Me.txt_fec_verif.ReadOnly = True
        Me.txt_fec_verif.Size = New System.Drawing.Size(174, 20)
        Me.txt_fec_verif.TabIndex = 2
        '
        'txt_inc_verif
        '
        Me.txt_inc_verif.BackColor = System.Drawing.Color.White
        Me.txt_inc_verif.Location = New System.Drawing.Point(80, 36)
        Me.txt_inc_verif.Name = "txt_inc_verif"
        Me.txt_inc_verif.ReadOnly = True
        Me.txt_inc_verif.Size = New System.Drawing.Size(174, 20)
        Me.txt_inc_verif.TabIndex = 1
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
        Me.btn_cerrar.Location = New System.Drawing.Point(870, 381)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(96, 37)
        Me.btn_cerrar.TabIndex = 84
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(766, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Total de tickets: "
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(866, 184)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(14, 13)
        Me.lbl_total.TabIndex = 86
        Me.lbl_total.Text = "0"
        '
        'cct_tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(972, 426)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.gb_tk_verif)
        Me.Controls.Add(Me.gb_tk_cie)
        Me.Controls.Add(Me.lbl_reg_age)
        Me.Controls.Add(Me.gb_agente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cct_tickets"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HITORIAL DE TICKETS"
        Me.gb_agente.ResumeLayout(False)
        Me.gb_agente.PerformLayout()
        CType(Me.dgv_tks_a, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tk_cie.ResumeLayout(False)
        Me.gb_tk_cie.PerformLayout()
        Me.gb_tk_verif.ResumeLayout(False)
        Me.gb_tk_verif.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_agente As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_tks_a As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_reg_age As System.Windows.Forms.Label
    Friend WithEvents gb_tk_cie As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_ges_cie As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cont_cie As System.Windows.Forms.TextBox
    Friend WithEvents txt_fec_cie As System.Windows.Forms.TextBox
    Friend WithEvents txt_inc_cie As System.Windows.Forms.TextBox
    Friend WithEvents txt_nota_abierto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_nota_cie As System.Windows.Forms.TextBox
    Friend WithEvents gb_tk_verif As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nota_verif As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_ges_verif As System.Windows.Forms.TextBox
    Friend WithEvents txt_fec_verif As System.Windows.Forms.TextBox
    Friend WithEvents txt_inc_verif As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO_TICKET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOTIVO_APERTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INCIDENCIA_APERTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTACTO_APERTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GESTOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_INSERT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_UPDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INCIDENCIA_CIERRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTACTO_CIERRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTA_CIERRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GESTOR_CIERRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_CIERRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA_CIERRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIAS_ABIERTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMPARACION_INCIDENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VERIFICACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VERIFICADO_POR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTA_VERIFICACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_VERIFICACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA_VERIFICACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIAS_POR_VERIFICACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_dias_verif As System.Windows.Forms.Label
    Friend WithEvents lbl_dias_abie As System.Windows.Forms.Label
    Friend WithEvents lbl_comp As System.Windows.Forms.Label
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
