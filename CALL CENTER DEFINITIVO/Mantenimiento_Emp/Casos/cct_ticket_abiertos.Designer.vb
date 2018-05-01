<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cct_ticket_abiertos
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
        Me.gb_agente = New System.Windows.Forms.GroupBox()
        Me.dgv_tks = New System.Windows.Forms.DataGridView()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INCIDENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TT1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.gb_agente.SuspendLayout()
        CType(Me.dgv_tks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_agente
        '
        Me.gb_agente.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gb_agente.Controls.Add(Me.dgv_tks)
        Me.gb_agente.ForeColor = System.Drawing.Color.Navy
        Me.gb_agente.Location = New System.Drawing.Point(3, 28)
        Me.gb_agente.Name = "gb_agente"
        Me.gb_agente.Size = New System.Drawing.Size(471, 241)
        Me.gb_agente.TabIndex = 80
        Me.gb_agente.TabStop = False
        Me.gb_agente.Text = "LISTADO DE TICKETS"
        '
        'dgv_tks
        '
        Me.dgv_tks.AllowUserToAddRows = False
        Me.dgv_tks.AllowUserToDeleteRows = False
        Me.dgv_tks.AllowUserToOrderColumns = True
        Me.dgv_tks.AllowUserToResizeRows = False
        Me.dgv_tks.BackgroundColor = System.Drawing.Color.White
        Me.dgv_tks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_tks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECHA, Me.MOTIVO, Me.INCIDENCIA, Me.USUARIO})
        Me.dgv_tks.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_tks.Location = New System.Drawing.Point(6, 19)
        Me.dgv_tks.MultiSelect = False
        Me.dgv_tks.Name = "dgv_tks"
        Me.dgv_tks.ReadOnly = True
        Me.dgv_tks.RowHeadersVisible = False
        Me.dgv_tks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tks.Size = New System.Drawing.Size(459, 218)
        Me.dgv_tks.TabIndex = 1
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Width = 70
        '
        'MOTIVO
        '
        Me.MOTIVO.DataPropertyName = "MOTIVO"
        Me.MOTIVO.HeaderText = "MOTIVO"
        Me.MOTIVO.Name = "MOTIVO"
        Me.MOTIVO.ReadOnly = True
        Me.MOTIVO.Width = 150
        '
        'INCIDENCIA
        '
        Me.INCIDENCIA.DataPropertyName = "INCIDENCIA"
        Me.INCIDENCIA.HeaderText = "INCIDENCIA"
        Me.INCIDENCIA.Name = "INCIDENCIA"
        Me.INCIDENCIA.ReadOnly = True
        '
        'USUARIO
        '
        Me.USUARIO.DataPropertyName = "USUARIO"
        Me.USUARIO.HeaderText = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.ReadOnly = True
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
        Me.lbl_age.Location = New System.Drawing.Point(7, 7)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(73, 16)
        Me.lbl_age.TabIndex = 83
        Me.lbl_age.Text = "Agente !!!"
        Me.TT1.SetToolTip(Me.lbl_age, "Agente seleccionado")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_tipo)
        Me.Panel1.Controls.Add(Me.lbl_cerrar)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 267)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 44)
        Me.Panel1.TabIndex = 82
        '
        'lbl_cerrar
        '
        Me.lbl_cerrar.AutoSize = True
        Me.lbl_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cerrar.ForeColor = System.Drawing.Color.Black
        Me.lbl_cerrar.Location = New System.Drawing.Point(149, 15)
        Me.lbl_cerrar.Name = "lbl_cerrar"
        Me.lbl_cerrar.Size = New System.Drawing.Size(19, 13)
        Me.lbl_cerrar.TabIndex = 57
        Me.lbl_cerrar.Text = "---"
        Me.lbl_cerrar.Visible = False
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
        Me.btn_cancelar.Location = New System.Drawing.Point(232, 3)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(96, 37)
        Me.btn_cancelar.TabIndex = 56
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
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
        Me.btn_cerrar.Location = New System.Drawing.Point(340, 3)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(120, 37)
        Me.btn_cerrar.TabIndex = 55
        Me.btn_cerrar.Text = "Seleccionar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipo.Location = New System.Drawing.Point(74, 15)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(13, 13)
        Me.lbl_tipo.TabIndex = 58
        Me.lbl_tipo.Text = "0"
        Me.lbl_tipo.Visible = False
        '
        'cct_ticket_abiertos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(470, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gb_agente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "cct_ticket_abiertos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TICKETS"
        Me.gb_agente.ResumeLayout(False)
        CType(Me.dgv_tks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_agente As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_tks As System.Windows.Forms.DataGridView
    Friend WithEvents TT1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_age As System.Windows.Forms.Label
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INCIDENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo As System.Windows.Forms.Label
End Class
