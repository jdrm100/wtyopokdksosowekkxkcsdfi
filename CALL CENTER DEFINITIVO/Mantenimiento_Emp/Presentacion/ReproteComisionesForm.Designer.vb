<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReproteComisionesForm
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.porLoteriaAll = New System.Windows.Forms.RadioButton()
        Me.PorLoteria = New System.Windows.Forms.RadioButton()
        Me.TodasLoterias = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.allLoterias = New System.Windows.Forms.ComboBox()
        Me.AgenteTBOX = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.dtp_FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.porLoteriaAll)
        Me.GroupBox1.Controls.Add(Me.PorLoteria)
        Me.GroupBox1.Controls.Add(Me.TodasLoterias)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.allLoterias)
        Me.GroupBox1.Controls.Add(Me.AgenteTBOX)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 196)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'porLoteriaAll
        '
        Me.porLoteriaAll.AutoSize = True
        Me.porLoteriaAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.porLoteriaAll.Location = New System.Drawing.Point(218, 83)
        Me.porLoteriaAll.Name = "porLoteriaAll"
        Me.porLoteriaAll.Size = New System.Drawing.Size(108, 17)
        Me.porLoteriaAll.TabIndex = 18
        Me.porLoteriaAll.TabStop = True
        Me.porLoteriaAll.Text = "POR LOTERIA"
        Me.porLoteriaAll.UseVisualStyleBackColor = True
        '
        'PorLoteria
        '
        Me.PorLoteria.AutoSize = True
        Me.PorLoteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorLoteria.Location = New System.Drawing.Point(91, 83)
        Me.PorLoteria.Name = "PorLoteria"
        Me.PorLoteria.Size = New System.Drawing.Size(121, 17)
        Me.PorLoteria.TabIndex = 17
        Me.PorLoteria.TabStop = True
        Me.PorLoteria.Text = "POR L.DETALLE"
        Me.PorLoteria.UseVisualStyleBackColor = True
        '
        'TodasLoterias
        '
        Me.TodasLoterias.AutoSize = True
        Me.TodasLoterias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodasLoterias.Location = New System.Drawing.Point(14, 83)
        Me.TodasLoterias.Name = "TodasLoterias"
        Me.TodasLoterias.Size = New System.Drawing.Size(67, 17)
        Me.TodasLoterias.TabIndex = 16
        Me.TodasLoterias.TabStop = True
        Me.TodasLoterias.Text = "TODAS"
        Me.TodasLoterias.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Loterias:"
        '
        'allLoterias
        '
        Me.allLoterias.FormattingEnabled = True
        Me.allLoterias.Location = New System.Drawing.Point(91, 106)
        Me.allLoterias.Name = "allLoterias"
        Me.allLoterias.Size = New System.Drawing.Size(230, 21)
        Me.allLoterias.TabIndex = 11
        '
        'AgenteTBOX
        '
        Me.AgenteTBOX.Location = New System.Drawing.Point(91, 133)
        Me.AgenteTBOX.Name = "AgenteTBOX"
        Me.AgenteTBOX.Size = New System.Drawing.Size(230, 20)
        Me.AgenteTBOX.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Agente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(276, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 7
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(353, 111)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(111, 46)
        Me.btn_Aceptar.TabIndex = 4
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'dtp_FechaFinal
        '
        Me.dtp_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFinal.Location = New System.Drawing.Point(116, 45)
        Me.dtp_FechaFinal.Name = "dtp_FechaFinal"
        Me.dtp_FechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtp_FechaFinal.TabIndex = 3
        '
        'dtp_FechaInicial
        '
        Me.dtp_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicial.Location = New System.Drawing.Point(116, 12)
        Me.dtp_FechaInicial.Name = "dtp_FechaInicial"
        Me.dtp_FechaInicial.Size = New System.Drawing.Size(104, 20)
        Me.dtp_FechaInicial.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicial:"
        '
        'ReproteComisionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 196)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ReproteComisionesForm"
        Me.Text = "ReproteComisionesForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AgenteTBOX As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents dtp_FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents allLoterias As System.Windows.Forms.ComboBox
    Friend WithEvents PorLoteria As System.Windows.Forms.RadioButton
    Friend WithEvents TodasLoterias As System.Windows.Forms.RadioButton
    Friend WithEvents porLoteriaAll As System.Windows.Forms.RadioButton
End Class
