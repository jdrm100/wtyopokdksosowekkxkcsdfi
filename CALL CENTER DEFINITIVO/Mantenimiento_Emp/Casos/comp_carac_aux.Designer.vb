<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comp_carac_aux
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
        Me.txt_mac = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dbmv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_prove = New System.Windows.Forms.ComboBox()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.lbl_id_comp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_coment = New System.Windows.Forms.TextBox()
        Me.lbl_comp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_carac = New System.Windows.Forms.ComboBox()
        Me.txt_s2 = New System.Windows.Forms.TextBox()
        Me.txt_s1 = New System.Windows.Forms.TextBox()
        Me.lbl_s2 = New System.Windows.Forms.Label()
        Me.lbl_s1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_cant_img = New System.Windows.Forms.Label()
        Me.btn_sig = New System.Windows.Forms.Button()
        Me.btn_ant = New System.Windows.Forms.Button()
        Me.pb_img = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_mod_red = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Azure
        Me.GroupBox1.Controls.Add(Me.cmb_mod_red)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_mac)
        Me.GroupBox1.Controls.Add(Me.txt_dbmv)
        Me.GroupBox1.Controls.Add(Me.cmb_prove)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmb_carac)
        Me.GroupBox1.Controls.Add(Me.lbl_age)
        Me.GroupBox1.Controls.Add(Me.lbl_id_comp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_coment)
        Me.GroupBox1.Controls.Add(Me.lbl_comp)
        Me.GroupBox1.Controls.Add(Me.lbl_s2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_s2)
        Me.GroupBox1.Controls.Add(Me.txt_s1)
        Me.GroupBox1.Controls.Add(Me.lbl_s1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 246)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCION DE CARACTERISTICA"
        '
        'txt_mac
        '
        Me.txt_mac.BackColor = System.Drawing.Color.White
        Me.txt_mac.Location = New System.Drawing.Point(72, 165)
        Me.txt_mac.Name = "txt_mac"
        Me.txt_mac.Size = New System.Drawing.Size(147, 20)
        Me.txt_mac.TabIndex = 5
        Me.txt_mac.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Mac Add.:"
        Me.Label6.Visible = False
        '
        'txt_dbmv
        '
        Me.txt_dbmv.BackColor = System.Drawing.Color.White
        Me.txt_dbmv.Location = New System.Drawing.Point(274, 216)
        Me.txt_dbmv.Name = "txt_dbmv"
        Me.txt_dbmv.Size = New System.Drawing.Size(59, 20)
        Me.txt_dbmv.TabIndex = 8
        Me.txt_dbmv.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(225, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "dBmV:"
        Me.Label5.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Proveedor:"
        Me.Label2.Visible = False
        '
        'cmb_prove
        '
        Me.cmb_prove.BackColor = System.Drawing.Color.White
        Me.cmb_prove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_prove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_prove.FormattingEnabled = True
        Me.cmb_prove.Location = New System.Drawing.Point(72, 189)
        Me.cmb_prove.Name = "cmb_prove"
        Me.cmb_prove.Size = New System.Drawing.Size(147, 21)
        Me.cmb_prove.TabIndex = 6
        Me.cmb_prove.Visible = False
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.ForeColor = System.Drawing.Color.Black
        Me.lbl_age.Location = New System.Drawing.Point(343, 205)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(40, 13)
        Me.lbl_age.TabIndex = 84
        Me.lbl_age.Text = "agente"
        '
        'lbl_id_comp
        '
        Me.lbl_id_comp.AutoSize = True
        Me.lbl_id_comp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_id_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_comp.ForeColor = System.Drawing.Color.Black
        Me.lbl_id_comp.Location = New System.Drawing.Point(343, 218)
        Me.lbl_id_comp.Name = "lbl_id_comp"
        Me.lbl_id_comp.Size = New System.Drawing.Size(47, 13)
        Me.lbl_id_comp.TabIndex = 83
        Me.lbl_id_comp.Text = "id_comp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Componente:"
        '
        'txt_coment
        '
        Me.txt_coment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_coment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_coment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_coment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_coment.Location = New System.Drawing.Point(72, 90)
        Me.txt_coment.Multiline = True
        Me.txt_coment.Name = "txt_coment"
        Me.txt_coment.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_coment.Size = New System.Drawing.Size(147, 48)
        Me.txt_coment.TabIndex = 3
        '
        'lbl_comp
        '
        Me.lbl_comp.AutoSize = True
        Me.lbl_comp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_comp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_comp.Location = New System.Drawing.Point(85, 20)
        Me.lbl_comp.Name = "lbl_comp"
        Me.lbl_comp.Size = New System.Drawing.Size(43, 13)
        Me.lbl_comp.TabIndex = 81
        Me.lbl_comp.Text = "@@@"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Nota:"
        '
        'cmb_carac
        '
        Me.cmb_carac.BackColor = System.Drawing.Color.White
        Me.cmb_carac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_carac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_carac.FormattingEnabled = True
        Me.cmb_carac.Location = New System.Drawing.Point(9, 40)
        Me.cmb_carac.Name = "cmb_carac"
        Me.cmb_carac.Size = New System.Drawing.Size(210, 21)
        Me.cmb_carac.TabIndex = 1
        '
        'txt_s2
        '
        Me.txt_s2.BackColor = System.Drawing.Color.White
        Me.txt_s2.Location = New System.Drawing.Point(72, 141)
        Me.txt_s2.Name = "txt_s2"
        Me.txt_s2.Size = New System.Drawing.Size(147, 20)
        Me.txt_s2.TabIndex = 4
        Me.txt_s2.Visible = False
        '
        'txt_s1
        '
        Me.txt_s1.BackColor = System.Drawing.Color.White
        Me.txt_s1.Location = New System.Drawing.Point(72, 67)
        Me.txt_s1.Name = "txt_s1"
        Me.txt_s1.Size = New System.Drawing.Size(147, 20)
        Me.txt_s1.TabIndex = 2
        '
        'lbl_s2
        '
        Me.lbl_s2.AutoSize = True
        Me.lbl_s2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_s2.ForeColor = System.Drawing.Color.Black
        Me.lbl_s2.Location = New System.Drawing.Point(18, 144)
        Me.lbl_s2.Name = "lbl_s2"
        Me.lbl_s2.Size = New System.Drawing.Size(54, 13)
        Me.lbl_s2.TabIndex = 69
        Me.lbl_s2.Text = "Numero:"
        Me.lbl_s2.Visible = False
        '
        'lbl_s1
        '
        Me.lbl_s1.AutoSize = True
        Me.lbl_s1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_s1.ForeColor = System.Drawing.Color.Black
        Me.lbl_s1.Location = New System.Drawing.Point(20, 74)
        Me.lbl_s1.Name = "lbl_s1"
        Me.lbl_s1.Size = New System.Drawing.Size(43, 13)
        Me.lbl_s1.TabIndex = 18
        Me.lbl_s1.Text = "Serial:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_aceptar)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Location = New System.Drawing.Point(7, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 44)
        Me.Panel1.TabIndex = 55
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.White
        Me.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = Global.My.Resources.Resources.Clear_Green_Button
        Me.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_aceptar.Location = New System.Drawing.Point(308, 2)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(98, 37)
        Me.btn_aceptar.TabIndex = 9
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_aceptar.UseVisualStyleBackColor = False
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
        Me.btn_cancelar.Location = New System.Drawing.Point(8, 3)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(98, 37)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox2.Controls.Add(Me.lbl_cant_img)
        Me.GroupBox2.Controls.Add(Me.btn_sig)
        Me.GroupBox2.Controls.Add(Me.btn_ant)
        Me.GroupBox2.Controls.Add(Me.pb_img)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(228, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 172)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IMAGEN"
        '
        'lbl_cant_img
        '
        Me.lbl_cant_img.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cant_img.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant_img.ForeColor = System.Drawing.Color.Black
        Me.lbl_cant_img.Location = New System.Drawing.Point(72, 141)
        Me.lbl_cant_img.Name = "lbl_cant_img"
        Me.lbl_cant_img.Size = New System.Drawing.Size(45, 13)
        Me.lbl_cant_img.TabIndex = 86
        Me.lbl_cant_img.Text = "0/0"
        Me.lbl_cant_img.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_sig
        '
        Me.btn_sig.BackColor = System.Drawing.Color.White
        Me.btn_sig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_sig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sig.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_sig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_sig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sig.ForeColor = System.Drawing.Color.Black
        Me.btn_sig.Image = Global.My.Resources.Resources.Fle41
        Me.btn_sig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sig.Location = New System.Drawing.Point(118, 129)
        Me.btn_sig.Name = "btn_sig"
        Me.btn_sig.Size = New System.Drawing.Size(61, 37)
        Me.btn_sig.TabIndex = 85
        Me.btn_sig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sig.UseVisualStyleBackColor = False
        '
        'btn_ant
        '
        Me.btn_ant.BackColor = System.Drawing.Color.White
        Me.btn_ant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ant.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_ant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_ant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ant.ForeColor = System.Drawing.Color.Black
        Me.btn_ant.Image = Global.My.Resources.Resources.Fle39
        Me.btn_ant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ant.Location = New System.Drawing.Point(9, 129)
        Me.btn_ant.Name = "btn_ant"
        Me.btn_ant.Size = New System.Drawing.Size(61, 37)
        Me.btn_ant.TabIndex = 84
        Me.btn_ant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ant.UseVisualStyleBackColor = False
        '
        'pb_img
        '
        Me.pb_img.Location = New System.Drawing.Point(9, 19)
        Me.pb_img.Name = "pb_img"
        Me.pb_img.Size = New System.Drawing.Size(170, 104)
        Me.pb_img.TabIndex = 83
        Me.pb_img.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Modo Red:"
        Me.Label3.Visible = False
        '
        'cmb_mod_red
        '
        Me.cmb_mod_red.BackColor = System.Drawing.Color.White
        Me.cmb_mod_red.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mod_red.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mod_red.FormattingEnabled = True
        Me.cmb_mod_red.Location = New System.Drawing.Point(72, 215)
        Me.cmb_mod_red.Name = "cmb_mod_red"
        Me.cmb_mod_red.Size = New System.Drawing.Size(147, 21)
        Me.cmb_mod_red.TabIndex = 7
        Me.cmb_mod_red.Visible = False
        '
        'comp_carac_aux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 302)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "comp_carac_aux"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ASIGNAR CARACTERISTICA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_s2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_s1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_s2 As System.Windows.Forms.Label
    Friend WithEvents lbl_s1 As System.Windows.Forms.Label
    Friend WithEvents cmb_carac As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_comp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_coment As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_id_comp As System.Windows.Forms.Label
    Friend WithEvents lbl_age As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_prove As System.Windows.Forms.ComboBox
    Friend WithEvents txt_mac As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_dbmv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_cant_img As System.Windows.Forms.Label
    Friend WithEvents btn_sig As System.Windows.Forms.Button
    Friend WithEvents btn_ant As System.Windows.Forms.Button
    Friend WithEvents pb_img As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_mod_red As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
