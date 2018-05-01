<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMReporte_Recarga
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_fechafinal = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_fechainicial = New System.Windows.Forms.DateTimePicker()
        Me.txt_agente = New System.Windows.Forms.TextBox()
        Me.cbo_operadora = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rd_detalla = New System.Windows.Forms.RadioButton()
        Me.rd_transacciones = New System.Windows.Forms.RadioButton()
        Me.rd_resumida = New System.Windows.Forms.RadioButton()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Errorvalicion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tt_mensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Errorvalicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_fechafinal)
        Me.GroupBox1.Controls.Add(Me.Dtp_fechainicial)
        Me.GroupBox1.Controls.Add(Me.txt_agente)
        Me.GroupBox1.Controls.Add(Me.cbo_operadora)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametro Generales"
        '
        'dtp_fechafinal
        '
        Me.dtp_fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechafinal.Location = New System.Drawing.Point(122, 110)
        Me.dtp_fechafinal.Name = "dtp_fechafinal"
        Me.dtp_fechafinal.Size = New System.Drawing.Size(172, 22)
        Me.dtp_fechafinal.TabIndex = 7
        '
        'Dtp_fechainicial
        '
        Me.Dtp_fechainicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_fechainicial.Location = New System.Drawing.Point(122, 69)
        Me.Dtp_fechainicial.Name = "Dtp_fechainicial"
        Me.Dtp_fechainicial.Size = New System.Drawing.Size(172, 22)
        Me.Dtp_fechainicial.TabIndex = 6
        '
        'txt_agente
        '
        Me.txt_agente.Location = New System.Drawing.Point(122, 33)
        Me.txt_agente.Name = "txt_agente"
        Me.txt_agente.Size = New System.Drawing.Size(172, 22)
        Me.txt_agente.TabIndex = 5
        '
        'cbo_operadora
        '
        Me.cbo_operadora.FormattingEnabled = True
        Me.cbo_operadora.Items.AddRange(New Object() {"Todas", "Claro", "Viva", "Orange", "Tricom", "Digicel"})
        Me.cbo_operadora.Location = New System.Drawing.Point(122, 156)
        Me.cbo_operadora.Name = "cbo_operadora"
        Me.cbo_operadora.Size = New System.Drawing.Size(228, 24)
        Me.cbo_operadora.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Operadora:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Inicial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rd_detalla)
        Me.GroupBox2.Controls.Add(Me.rd_transacciones)
        Me.GroupBox2.Controls.Add(Me.rd_resumida)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(474, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 132)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salida"
        '
        'rd_detalla
        '
        Me.rd_detalla.AutoSize = True
        Me.rd_detalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_detalla.ForeColor = System.Drawing.Color.Black
        Me.rd_detalla.Location = New System.Drawing.Point(41, 56)
        Me.rd_detalla.Name = "rd_detalla"
        Me.rd_detalla.Size = New System.Drawing.Size(79, 17)
        Me.rd_detalla.TabIndex = 2
        Me.rd_detalla.TabStop = True
        Me.rd_detalla.Text = "Detallada"
        Me.rd_detalla.UseVisualStyleBackColor = True
        '
        'rd_transacciones
        '
        Me.rd_transacciones.AutoSize = True
        Me.rd_transacciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_transacciones.ForeColor = System.Drawing.Color.Black
        Me.rd_transacciones.Location = New System.Drawing.Point(41, 82)
        Me.rd_transacciones.Name = "rd_transacciones"
        Me.rd_transacciones.Size = New System.Drawing.Size(138, 17)
        Me.rd_transacciones.TabIndex = 1
        Me.rd_transacciones.TabStop = True
        Me.rd_transacciones.Text = "Por Transancciones"
        Me.rd_transacciones.UseVisualStyleBackColor = True
        '
        'rd_resumida
        '
        Me.rd_resumida.AutoSize = True
        Me.rd_resumida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_resumida.ForeColor = System.Drawing.Color.Black
        Me.rd_resumida.Location = New System.Drawing.Point(41, 30)
        Me.rd_resumida.Name = "rd_resumida"
        Me.rd_resumida.Size = New System.Drawing.Size(80, 17)
        Me.rd_resumida.TabIndex = 0
        Me.rd_resumida.TabStop = True
        Me.rd_resumida.Text = "Resumida"
        Me.rd_resumida.UseVisualStyleBackColor = True
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.Color.White
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.Location = New System.Drawing.Point(14, 235)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(120, 42)
        Me.btn_imprimir.TabIndex = 2
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.White
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.Location = New System.Drawing.Point(141, 235)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(120, 42)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Errorvalicion
        '
        Me.Errorvalicion.ContainerControl = Me
        '
        'FRMReporte_Recarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(716, 284)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FRMReporte_Recarga"
        Me.Text = "Reporte_Recarga"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Errorvalicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_fechainicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_agente As System.Windows.Forms.TextBox
    Friend WithEvents cbo_operadora As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rd_detalla As System.Windows.Forms.RadioButton
    Friend WithEvents rd_transacciones As System.Windows.Forms.RadioButton
    Friend WithEvents rd_resumida As System.Windows.Forms.RadioButton
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Errorvalicion As System.Windows.Forms.ErrorProvider
    Friend WithEvents tt_mensaje As System.Windows.Forms.ToolTip
End Class
