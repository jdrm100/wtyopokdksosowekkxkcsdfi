<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filtrar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PorRepresentanteRadio = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.represent = New System.Windows.Forms.ComboBox()
        Me.porRepresRbt = New System.Windows.Forms.RadioButton()
        Me.porGestorRbt = New System.Windows.Forms.RadioButton()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.dtp_FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.PorRepresentanteRadio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.represent)
        Me.GroupBox1.Controls.Add(Me.porRepresRbt)
        Me.GroupBox1.Controls.Add(Me.porGestorRbt)
        Me.GroupBox1.Controls.Add(Me.btn_Aceptar)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 254)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'PorRepresentanteRadio
        '
        Me.PorRepresentanteRadio.AutoSize = True
        Me.PorRepresentanteRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PorRepresentanteRadio.Location = New System.Drawing.Point(14, 140)
        Me.PorRepresentanteRadio.Name = "PorRepresentanteRadio"
        Me.PorRepresentanteRadio.Size = New System.Drawing.Size(163, 17)
        Me.PorRepresentanteRadio.TabIndex = 15
        Me.PorRepresentanteRadio.TabStop = True
        Me.PorRepresentanteRadio.Text = "POR REPRESENTANTE"
        Me.PorRepresentanteRadio.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Representante:"
        '
        'represent
        '
        Me.represent.FormattingEnabled = True
        Me.represent.Location = New System.Drawing.Point(275, 136)
        Me.represent.Name = "represent"
        Me.represent.Size = New System.Drawing.Size(230, 21)
        Me.represent.TabIndex = 11
        '
        'porRepresRbt
        '
        Me.porRepresRbt.AutoSize = True
        Me.porRepresRbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.porRepresRbt.Location = New System.Drawing.Point(14, 94)
        Me.porRepresRbt.Name = "porRepresRbt"
        Me.porRepresRbt.Size = New System.Drawing.Size(208, 17)
        Me.porRepresRbt.TabIndex = 6
        Me.porRepresRbt.TabStop = True
        Me.porRepresRbt.Text = "TODOS LOS REPRESENTANTE"
        Me.porRepresRbt.UseVisualStyleBackColor = True
        '
        'porGestorRbt
        '
        Me.porGestorRbt.AutoSize = True
        Me.porGestorRbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.porGestorRbt.Location = New System.Drawing.Point(14, 117)
        Me.porGestorRbt.Name = "porGestorRbt"
        Me.porGestorRbt.Size = New System.Drawing.Size(159, 17)
        Me.porGestorRbt.TabIndex = 5
        Me.porGestorRbt.TabStop = True
        Me.porGestorRbt.Text = "TODO LOS GESTORES"
        Me.porGestorRbt.UseVisualStyleBackColor = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(266, 19)
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
        Me.dtp_FechaInicial.Enabled = False
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
        'Filtrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 254)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Filtrar"
        Me.Text = "Filtrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents dtp_FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents porRepresRbt As System.Windows.Forms.RadioButton
    Friend WithEvents porGestorRbt As System.Windows.Forms.RadioButton
    Friend WithEvents PorRepresentanteRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents represent As System.Windows.Forms.ComboBox
End Class
