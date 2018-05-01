<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class est_cuenta
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
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_agente = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_balance = New System.Windows.Forms.Label()
        Me.dgv_estado = New System.Windows.Forms.DataGridView()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.efecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_venta_curso = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fecha_v = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ventas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ventasr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comisiones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_v = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_venta_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_agente
        '
        Me.lbl_agente.AutoSize = True
        Me.lbl_agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agente.ForeColor = System.Drawing.Color.Black
        Me.lbl_agente.Location = New System.Drawing.Point(75, 16)
        Me.lbl_agente.Name = "lbl_agente"
        Me.lbl_agente.Size = New System.Drawing.Size(81, 16)
        Me.lbl_agente.TabIndex = 0
        Me.lbl_agente.Text = "lbl_agente"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Azure
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.lb_balance)
        Me.GroupBox4.Controls.Add(Me.lbl_agente)
        Me.GroupBox4.Controls.Add(Me.dgv_estado)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(636, 368)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ESTADO DE CUENTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Agente:"
        '
        'lb_balance
        '
        Me.lb_balance.AutoSize = True
        Me.lb_balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_balance.Location = New System.Drawing.Point(493, 344)
        Me.lb_balance.Name = "lb_balance"
        Me.lb_balance.Size = New System.Drawing.Size(89, 16)
        Me.lb_balance.TabIndex = 3
        Me.lb_balance.Text = "lbl_balance"
        Me.ToolTip1.SetToolTip(Me.lb_balance, "Balance al corte")
        '
        'dgv_estado
        '
        Me.dgv_estado.AllowUserToAddRows = False
        Me.dgv_estado.AllowUserToDeleteRows = False
        Me.dgv_estado.AllowUserToOrderColumns = True
        Me.dgv_estado.AllowUserToResizeRows = False
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.OldLace
        Me.dgv_estado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle40
        Me.dgv_estado.BackgroundColor = System.Drawing.Color.White
        Me.dgv_estado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_estado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.documento, Me.entidad, Me.fecha, Me.periodo, Me.efecto, Me.monto, Me.balance})
        Me.dgv_estado.Location = New System.Drawing.Point(11, 35)
        Me.dgv_estado.MultiSelect = False
        Me.dgv_estado.Name = "dgv_estado"
        Me.dgv_estado.ReadOnly = True
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_estado.RowHeadersDefaultCellStyle = DataGridViewCellStyle43
        Me.dgv_estado.RowHeadersVisible = False
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_estado.RowsDefaultCellStyle = DataGridViewCellStyle44
        Me.dgv_estado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_estado.Size = New System.Drawing.Size(614, 306)
        Me.dgv_estado.TabIndex = 1
        '
        'documento
        '
        Me.documento.DataPropertyName = "documento"
        Me.documento.HeaderText = "DOCUMENTO"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        Me.documento.Width = 80
        '
        'entidad
        '
        Me.entidad.DataPropertyName = "entidad"
        Me.entidad.HeaderText = "ENTIDAD"
        Me.entidad.Name = "entidad"
        Me.entidad.ReadOnly = True
        Me.entidad.Width = 80
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "FECHA"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 80
        '
        'periodo
        '
        Me.periodo.DataPropertyName = "periodo"
        Me.periodo.HeaderText = "PERIODO"
        Me.periodo.Name = "periodo"
        Me.periodo.ReadOnly = True
        Me.periodo.Width = 130
        '
        'efecto
        '
        Me.efecto.DataPropertyName = "efecto"
        Me.efecto.HeaderText = "EFECTO"
        Me.efecto.Name = "efecto"
        Me.efecto.ReadOnly = True
        Me.efecto.Width = 60
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle41.Format = "C2"
        DataGridViewCellStyle41.NullValue = Nothing
        Me.monto.DefaultCellStyle = DataGridViewCellStyle41
        Me.monto.HeaderText = "MONTO"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        Me.monto.Width = 80
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle42.Format = "C2"
        DataGridViewCellStyle42.NullValue = Nothing
        Me.balance.DefaultCellStyle = DataGridViewCellStyle42
        Me.balance.HeaderText = "BALANCE"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        Me.balance.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Azure
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dgv_venta_curso)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 386)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 199)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BALANCE EN CURSO LOTO REAL"
        '
        'dgv_venta_curso
        '
        Me.dgv_venta_curso.AllowUserToAddRows = False
        Me.dgv_venta_curso.AllowUserToDeleteRows = False
        Me.dgv_venta_curso.AllowUserToOrderColumns = True
        Me.dgv_venta_curso.AllowUserToResizeRows = False
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.OldLace
        Me.dgv_venta_curso.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle45
        Me.dgv_venta_curso.BackgroundColor = System.Drawing.Color.White
        Me.dgv_venta_curso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_venta_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_venta_curso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_v, Me.ventas, Me.ventasr, Me.pagos, Me.comisiones, Me.total_v})
        Me.dgv_venta_curso.Location = New System.Drawing.Point(11, 19)
        Me.dgv_venta_curso.MultiSelect = False
        Me.dgv_venta_curso.Name = "dgv_venta_curso"
        Me.dgv_venta_curso.ReadOnly = True
        DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_venta_curso.RowHeadersDefaultCellStyle = DataGridViewCellStyle51
        Me.dgv_venta_curso.RowHeadersVisible = False
        DataGridViewCellStyle52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_venta_curso.RowsDefaultCellStyle = DataGridViewCellStyle52
        Me.dgv_venta_curso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_venta_curso.Size = New System.Drawing.Size(614, 155)
        Me.dgv_venta_curso.TabIndex = 1
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
        Me.Button3.Location = New System.Drawing.Point(45, 343)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 24)
        Me.Button3.TabIndex = 55
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
        Me.Button2.Location = New System.Drawing.Point(11, 343)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 24)
        Me.Button2.TabIndex = 54
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(493, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "lbl_balance"
        Me.ToolTip1.SetToolTip(Me.Label4, "Balance en curso")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.My.Resources.Resources.page_white_acrobat
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(45, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 24)
        Me.Button1.TabIndex = 57
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = Global.My.Resources.Resources.page_white_excel
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(11, 174)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(28, 24)
        Me.Button4.TabIndex = 56
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(354, 588)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Balance general:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(504, 588)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "lbl_balance"
        '
        'fecha_v
        '
        Me.fecha_v.DataPropertyName = "fecha"
        DataGridViewCellStyle46.NullValue = Nothing
        Me.fecha_v.DefaultCellStyle = DataGridViewCellStyle46
        Me.fecha_v.HeaderText = "FECHA"
        Me.fecha_v.Name = "fecha_v"
        Me.fecha_v.ReadOnly = True
        Me.fecha_v.Width = 80
        '
        'ventas
        '
        Me.ventas.DataPropertyName = "ventas"
        DataGridViewCellStyle47.Format = "C2"
        Me.ventas.DefaultCellStyle = DataGridViewCellStyle47
        Me.ventas.HeaderText = "VENTAS LOT."
        Me.ventas.Name = "ventas"
        Me.ventas.ReadOnly = True
        Me.ventas.ToolTipText = "VENTAS DE LOTERIA"
        '
        'ventasr
        '
        Me.ventasr.HeaderText = "RECARGAS"
        Me.ventasr.Name = "ventasr"
        Me.ventasr.ReadOnly = True
        Me.ventasr.ToolTipText = "VENTAS DE RECARGA"
        '
        'pagos
        '
        Me.pagos.DataPropertyName = "pagos"
        DataGridViewCellStyle48.Format = "C2"
        Me.pagos.DefaultCellStyle = DataGridViewCellStyle48
        Me.pagos.HeaderText = "PAGOS"
        Me.pagos.Name = "pagos"
        Me.pagos.ReadOnly = True
        '
        'comisiones
        '
        Me.comisiones.DataPropertyName = "comisiones"
        DataGridViewCellStyle49.NullValue = "C2"
        Me.comisiones.DefaultCellStyle = DataGridViewCellStyle49
        Me.comisiones.HeaderText = "PART."
        Me.comisiones.Name = "comisiones"
        Me.comisiones.ReadOnly = True
        Me.comisiones.ToolTipText = "PARTICIPACION"
        Me.comisiones.Width = 80
        '
        'total_v
        '
        Me.total_v.DataPropertyName = "total"
        DataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle50.Format = "C2"
        DataGridViewCellStyle50.NullValue = Nothing
        Me.total_v.DefaultCellStyle = DataGridViewCellStyle50
        Me.total_v.HeaderText = "BALANCE"
        Me.total_v.Name = "total_v"
        Me.total_v.ReadOnly = True
        Me.total_v.Width = 110
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(97, 183)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(14, 13)
        Me.lbl_total.TabIndex = 58
        Me.lbl_total.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(196, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(295, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(401, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "0"
        '
        'est_cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(651, 615)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "est_cuenta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Estado de Cuenta"
        Me.TopMost = True
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgv_estado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_venta_curso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_agente As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_estado As System.Windows.Forms.DataGridView
    Friend WithEvents lb_balance As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_venta_curso As System.Windows.Forms.DataGridView
    Friend WithEvents documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents entidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents efecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fecha_v As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ventas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ventasr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pagos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comisiones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_v As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
