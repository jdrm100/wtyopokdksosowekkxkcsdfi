<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cct_notas_frm
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
        Me.gb_na = New System.Windows.Forms.GroupBox()
        Me.txt_nota = New System.Windows.Forms.TextBox()
        Me.dtp_fec_a = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_a = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gb_histn = New System.Windows.Forms.GroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.dtp_ag = New System.Windows.Forms.DateTimePicker()
        Me.txt_notb = New System.Windows.Forms.TextBox()
        Me.txt_usub = New System.Windows.Forms.TextBox()
        Me.dtp_fecb = New System.Windows.Forms.DateTimePicker()
        Me.dgv_notas = New System.Windows.Forms.DataGridView()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGENDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_not = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.gb_nota = New System.Windows.Forms.GroupBox()
        Me.TT1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.gb_na.SuspendLayout()
        Me.gb_histn.SuspendLayout()
        CType(Me.dgv_notas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gb_nota.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_na
        '
        Me.gb_na.BackColor = System.Drawing.Color.Azure
        Me.gb_na.Controls.Add(Me.txt_nota)
        Me.gb_na.Controls.Add(Me.dtp_fec_a)
        Me.gb_na.Controls.Add(Me.Label10)
        Me.gb_na.Controls.Add(Me.btn_a)
        Me.gb_na.Controls.Add(Me.Label3)
        Me.gb_na.ForeColor = System.Drawing.Color.Navy
        Me.gb_na.Location = New System.Drawing.Point(12, 218)
        Me.gb_na.Name = "gb_na"
        Me.gb_na.Size = New System.Drawing.Size(326, 93)
        Me.gb_na.TabIndex = 56
        Me.gb_na.TabStop = False
        '
        'txt_nota
        '
        Me.txt_nota.Location = New System.Drawing.Point(9, 26)
        Me.txt_nota.MaxLength = 300
        Me.txt_nota.Multiline = True
        Me.txt_nota.Name = "txt_nota"
        Me.txt_nota.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_nota.Size = New System.Drawing.Size(200, 61)
        Me.txt_nota.TabIndex = 57
        '
        'dtp_fec_a
        '
        Me.dtp_fec_a.Checked = False
        Me.dtp_fec_a.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fec_a.Location = New System.Drawing.Point(215, 26)
        Me.dtp_fec_a.MaxDate = New Date(2020, 3, 31, 0, 0, 0, 0)
        Me.dtp_fec_a.MinDate = New Date(2016, 6, 1, 0, 0, 0, 0)
        Me.dtp_fec_a.Name = "dtp_fec_a"
        Me.dtp_fec_a.ShowCheckBox = True
        Me.dtp_fec_a.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fec_a.TabIndex = 73
        Me.dtp_fec_a.Value = New Date(2016, 6, 8, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(212, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Agendar:"
        '
        'btn_a
        '
        Me.btn_a.BackColor = System.Drawing.Color.White
        Me.btn_a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_a.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_a.ForeColor = System.Drawing.Color.Black
        Me.btn_a.Image = Global.My.Resources.Resources.Add
        Me.btn_a.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_a.Location = New System.Drawing.Point(229, 62)
        Me.btn_a.Name = "btn_a"
        Me.btn_a.Size = New System.Drawing.Size(83, 25)
        Me.btn_a.TabIndex = 74
        Me.btn_a.Text = "Agregar"
        Me.btn_a.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_a.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Nota:"
        '
        'gb_histn
        '
        Me.gb_histn.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gb_histn.Controls.Add(Me.btn_buscar)
        Me.gb_histn.Controls.Add(Me.dtp_ag)
        Me.gb_histn.Controls.Add(Me.txt_notb)
        Me.gb_histn.Controls.Add(Me.txt_usub)
        Me.gb_histn.Controls.Add(Me.dtp_fecb)
        Me.gb_histn.Controls.Add(Me.dgv_notas)
        Me.gb_histn.ForeColor = System.Drawing.Color.Navy
        Me.gb_histn.Location = New System.Drawing.Point(12, 28)
        Me.gb_histn.Name = "gb_histn"
        Me.gb_histn.Size = New System.Drawing.Size(564, 184)
        Me.gb_histn.TabIndex = 57
        Me.gb_histn.TabStop = False
        Me.gb_histn.Text = "HISTORIAL DE NOTAS"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar.BackgroundImage = Global.My.Resources.Resources.magnifier
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_buscar.Location = New System.Drawing.Point(533, 15)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(23, 21)
        Me.btn_buscar.TabIndex = 80
        Me.TT1.SetToolTip(Me.btn_buscar, "Buscar")
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'dtp_ag
        '
        Me.dtp_ag.Checked = False
        Me.dtp_ag.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ag.Location = New System.Drawing.Point(361, 15)
        Me.dtp_ag.MaxDate = New Date(2020, 3, 31, 0, 0, 0, 0)
        Me.dtp_ag.MinDate = New Date(2016, 6, 1, 0, 0, 0, 0)
        Me.dtp_ag.Name = "dtp_ag"
        Me.dtp_ag.ShowCheckBox = True
        Me.dtp_ag.Size = New System.Drawing.Size(97, 20)
        Me.dtp_ag.TabIndex = 79
        Me.TT1.SetToolTip(Me.dtp_ag, "Fecha de agenda")
        Me.dtp_ag.Value = New Date(2016, 6, 8, 0, 0, 0, 0)
        '
        'txt_notb
        '
        Me.txt_notb.BackColor = System.Drawing.Color.White
        Me.txt_notb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notb.Location = New System.Drawing.Point(206, 15)
        Me.txt_notb.MaxLength = 50
        Me.txt_notb.Name = "txt_notb"
        Me.txt_notb.Size = New System.Drawing.Size(149, 20)
        Me.txt_notb.TabIndex = 78
        Me.txt_notb.Tag = "NOTA"
        Me.TT1.SetToolTip(Me.txt_notb, "Nota")
        '
        'txt_usub
        '
        Me.txt_usub.BackColor = System.Drawing.Color.White
        Me.txt_usub.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_usub.Location = New System.Drawing.Point(112, 15)
        Me.txt_usub.MaxLength = 20
        Me.txt_usub.Name = "txt_usub"
        Me.txt_usub.Size = New System.Drawing.Size(88, 20)
        Me.txt_usub.TabIndex = 77
        Me.txt_usub.Tag = "USUARIO"
        Me.TT1.SetToolTip(Me.txt_usub, "Usuario")
        '
        'dtp_fecb
        '
        Me.dtp_fecb.Checked = False
        Me.dtp_fecb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecb.Location = New System.Drawing.Point(9, 15)
        Me.dtp_fecb.MaxDate = New Date(2020, 3, 31, 0, 0, 0, 0)
        Me.dtp_fecb.MinDate = New Date(2016, 6, 1, 0, 0, 0, 0)
        Me.dtp_fecb.Name = "dtp_fecb"
        Me.dtp_fecb.ShowCheckBox = True
        Me.dtp_fecb.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fecb.TabIndex = 74
        Me.TT1.SetToolTip(Me.dtp_fecb, "Fecha de registro")
        Me.dtp_fecb.Value = New Date(2016, 6, 8, 0, 0, 0, 0)
        '
        'dgv_notas
        '
        Me.dgv_notas.AllowUserToAddRows = False
        Me.dgv_notas.AllowUserToDeleteRows = False
        Me.dgv_notas.AllowUserToOrderColumns = True
        Me.dgv_notas.AllowUserToResizeRows = False
        Me.dgv_notas.BackgroundColor = System.Drawing.Color.White
        Me.dgv_notas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_notas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECHA, Me.HORA, Me.USUARIO, Me.NOTA, Me.AGENDA})
        Me.dgv_notas.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_notas.Location = New System.Drawing.Point(6, 38)
        Me.dgv_notas.MultiSelect = False
        Me.dgv_notas.Name = "dgv_notas"
        Me.dgv_notas.ReadOnly = True
        Me.dgv_notas.RowHeadersVisible = False
        Me.dgv_notas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_notas.Size = New System.Drawing.Size(550, 140)
        Me.dgv_notas.TabIndex = 2
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
        Me.HORA.Width = 65
        '
        'USUARIO
        '
        Me.USUARIO.DataPropertyName = "USUARIO"
        Me.USUARIO.HeaderText = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.ReadOnly = True
        '
        'NOTA
        '
        Me.NOTA.DataPropertyName = "NOTA"
        Me.NOTA.HeaderText = "NOTA"
        Me.NOTA.Name = "NOTA"
        Me.NOTA.ReadOnly = True
        Me.NOTA.Width = 210
        '
        'AGENDA
        '
        Me.AGENDA.DataPropertyName = "AGENDA"
        Me.AGENDA.HeaderText = "AGENDA"
        Me.AGENDA.Name = "AGENDA"
        Me.AGENDA.ReadOnly = True
        Me.AGENDA.Width = 70
        '
        'txt_not
        '
        Me.txt_not.Location = New System.Drawing.Point(6, 26)
        Me.txt_not.Multiline = True
        Me.txt_not.Name = "txt_not"
        Me.txt_not.ReadOnly = True
        Me.txt_not.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_not.Size = New System.Drawing.Size(218, 61)
        Me.txt_not.TabIndex = 64
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 316)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 44)
        Me.Panel1.TabIndex = 58
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
        Me.btn_cerrar.Location = New System.Drawing.Point(471, 3)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(96, 37)
        Me.btn_cerrar.TabIndex = 55
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'gb_nota
        '
        Me.gb_nota.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gb_nota.Controls.Add(Me.txt_not)
        Me.gb_nota.ForeColor = System.Drawing.Color.Navy
        Me.gb_nota.Location = New System.Drawing.Point(344, 218)
        Me.gb_nota.Name = "gb_nota"
        Me.gb_nota.Size = New System.Drawing.Size(232, 93)
        Me.gb_nota.TabIndex = 66
        Me.gb_nota.TabStop = False
        Me.gb_nota.Text = "NOTA SELECCIONADA"
        '
        'TT1
        '
        Me.TT1.AutomaticDelay = 300
        Me.TT1.AutoPopDelay = 9000
        Me.TT1.InitialDelay = 300
        Me.TT1.IsBalloon = True
        Me.TT1.ReshowDelay = 60
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_age.Location = New System.Drawing.Point(18, 9)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(73, 16)
        Me.lbl_age.TabIndex = 80
        Me.lbl_age.Text = "Agente !!!"
        Me.TT1.SetToolTip(Me.lbl_age, "Agente seleccionado")
        '
        'cct_notas_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.gb_nota)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gb_histn)
        Me.Controls.Add(Me.gb_na)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "cct_notas_frm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOTAS DE USUARIOS"
        Me.gb_na.ResumeLayout(False)
        Me.gb_na.PerformLayout()
        Me.gb_histn.ResumeLayout(False)
        Me.gb_histn.PerformLayout()
        CType(Me.dgv_notas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gb_nota.ResumeLayout(False)
        Me.gb_nota.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_na As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fec_a As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_a As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nota As System.Windows.Forms.TextBox
    Friend WithEvents gb_histn As System.Windows.Forms.GroupBox
    Friend WithEvents txt_not As System.Windows.Forms.TextBox
    Friend WithEvents dgv_notas As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_fecb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents dtp_ag As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_notb As System.Windows.Forms.TextBox
    Friend WithEvents txt_usub As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents gb_nota As System.Windows.Forms.GroupBox
    Friend WithEvents TT1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_age As System.Windows.Forms.Label
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AGENDA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
