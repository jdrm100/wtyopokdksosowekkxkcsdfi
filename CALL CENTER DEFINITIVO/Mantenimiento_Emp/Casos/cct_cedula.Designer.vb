<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cct_cedula
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_apr = New System.Windows.Forms.Label()
        Me.lbl_msj = New System.Windows.Forms.Label()
        Me.lbl_ced = New System.Windows.Forms.Label()
        Me.pb_msj = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ced = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_rep = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_msj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_cerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 44)
        Me.Panel1.TabIndex = 83
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
        Me.btn_cancelar.Location = New System.Drawing.Point(6, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(98, 37)
        Me.btn_cancelar.TabIndex = 58
        Me.btn_cancelar.Text = "Cancelar"
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
        Me.btn_cerrar.Location = New System.Drawing.Point(144, 3)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(96, 37)
        Me.btn_cerrar.TabIndex = 57
        Me.btn_cerrar.Text = "Aceptar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Azure
        Me.GroupBox2.Controls.Add(Me.lbl_apr)
        Me.GroupBox2.Controls.Add(Me.lbl_msj)
        Me.GroupBox2.Controls.Add(Me.lbl_ced)
        Me.GroupBox2.Controls.Add(Me.pb_msj)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_ced)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_rep)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 109)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DE AGENTE"
        '
        'lbl_apr
        '
        Me.lbl_apr.AutoSize = True
        Me.lbl_apr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apr.ForeColor = System.Drawing.Color.Red
        Me.lbl_apr.Location = New System.Drawing.Point(205, 16)
        Me.lbl_apr.Name = "lbl_apr"
        Me.lbl_apr.Size = New System.Drawing.Size(15, 15)
        Me.lbl_apr.TabIndex = 22
        Me.lbl_apr.Text = "0"
        Me.lbl_apr.Visible = False
        '
        'lbl_msj
        '
        Me.lbl_msj.AutoSize = True
        Me.lbl_msj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msj.ForeColor = System.Drawing.Color.Red
        Me.lbl_msj.Location = New System.Drawing.Point(126, 89)
        Me.lbl_msj.Name = "lbl_msj"
        Me.lbl_msj.Size = New System.Drawing.Size(107, 13)
        Me.lbl_msj.TabIndex = 19
        Me.lbl_msj.Text = "Cedula incorrecta"
        Me.lbl_msj.Visible = False
        '
        'lbl_ced
        '
        Me.lbl_ced.AutoSize = True
        Me.lbl_ced.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ced.ForeColor = System.Drawing.Color.Red
        Me.lbl_ced.Location = New System.Drawing.Point(118, 64)
        Me.lbl_ced.Name = "lbl_ced"
        Me.lbl_ced.Size = New System.Drawing.Size(31, 15)
        Me.lbl_ced.TabIndex = 21
        Me.lbl_ced.Text = "031"
        '
        'pb_msj
        '
        Me.pb_msj.BackgroundImage = Global.My.Resources.Resources.ico_error
        Me.pb_msj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pb_msj.InitialImage = Nothing
        Me.pb_msj.Location = New System.Drawing.Point(108, 85)
        Me.pb_msj.Name = "pb_msj"
        Me.pb_msj.Size = New System.Drawing.Size(22, 20)
        Me.pb_msj.TabIndex = 20
        Me.pb_msj.TabStop = False
        Me.pb_msj.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Cedula:"
        '
        'txt_ced
        '
        Me.txt_ced.BackColor = System.Drawing.Color.White
        Me.txt_ced.Location = New System.Drawing.Point(6, 82)
        Me.txt_ced.MaxLength = 15
        Me.txt_ced.Name = "txt_ced"
        Me.txt_ced.Size = New System.Drawing.Size(96, 20)
        Me.txt_ced.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(1, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Representante Legal:"
        '
        'txt_rep
        '
        Me.txt_rep.BackColor = System.Drawing.Color.White
        Me.txt_rep.Location = New System.Drawing.Point(6, 37)
        Me.txt_rep.Name = "txt_rep"
        Me.txt_rep.ReadOnly = True
        Me.txt_rep.Size = New System.Drawing.Size(223, 20)
        Me.txt_rep.TabIndex = 15
        '
        'cct_cedula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(238, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "cct_cedula"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VALIDACION DE ACCESO"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pb_msj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ced As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_rep As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents pb_msj As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_msj As System.Windows.Forms.Label
    Friend WithEvents lbl_ced As System.Windows.Forms.Label
    Friend WithEvents lbl_apr As System.Windows.Forms.Label
End Class
