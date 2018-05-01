<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ID_ROL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESC_ROL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.ID_ACCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESC_ACCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.txt_Desc_Rol = New System.Windows.Forms.TextBox
        Me.btn_quitar_grupo = New System.Windows.Forms.Button
        Me.btn_agregar_grupo = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ROL, Me.DESC_ROL})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 36)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(318, 253)
        Me.DataGridView1.TabIndex = 4
        '
        'ID_ROL
        '
        Me.ID_ROL.DataPropertyName = "ID"
        Me.ID_ROL.HeaderText = "ID_ROL"
        Me.ID_ROL.Name = "ID_ROL"
        Me.ID_ROL.Width = 50
        '
        'DESC_ROL
        '
        Me.DESC_ROL.DataPropertyName = "DESC_ROL"
        Me.DESC_ROL.HeaderText = "DESC_ROL"
        Me.DESC_ROL.Name = "DESC_ROL"
        Me.DESC_ROL.Width = 200
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ACCION, Me.DESC_ACCION})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(322, 270)
        Me.DataGridView2.TabIndex = 2
        '
        'ID_ACCION
        '
        Me.ID_ACCION.DataPropertyName = "ID"
        Me.ID_ACCION.HeaderText = "ID_ACCION"
        Me.ID_ACCION.Name = "ID_ACCION"
        Me.ID_ACCION.Width = 50
        '
        'DESC_ACCION
        '
        Me.DESC_ACCION.DataPropertyName = "DESC_ACCION"
        Me.DESC_ACCION.HeaderText = "DESC_ACCION"
        Me.DESC_ACCION.Name = "DESC_ACCION"
        Me.DESC_ACCION.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txt_Desc_Rol)
        Me.GroupBox1.Controls.Add(Me.btn_quitar_grupo)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_grupo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 299)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Roles"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = Global.My.Resources.Resources.magnifier
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Location = New System.Drawing.Point(7, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 20)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_Desc_Rol
        '
        Me.txt_Desc_Rol.Location = New System.Drawing.Point(40, 14)
        Me.txt_Desc_Rol.Name = "txt_Desc_Rol"
        Me.txt_Desc_Rol.Size = New System.Drawing.Size(174, 20)
        Me.txt_Desc_Rol.TabIndex = 0
        '
        'btn_quitar_grupo
        '
        Me.btn_quitar_grupo.BackColor = System.Drawing.Color.White
        Me.btn_quitar_grupo.BackgroundImage = Global.My.Resources.Resources.Delete
        Me.btn_quitar_grupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_grupo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_quitar_grupo.Location = New System.Drawing.Point(297, 0)
        Me.btn_quitar_grupo.Name = "btn_quitar_grupo"
        Me.btn_quitar_grupo.Size = New System.Drawing.Size(27, 22)
        Me.btn_quitar_grupo.TabIndex = 2
        Me.btn_quitar_grupo.UseVisualStyleBackColor = False
        '
        'btn_agregar_grupo
        '
        Me.btn_agregar_grupo.BackColor = System.Drawing.Color.White
        Me.btn_agregar_grupo.BackgroundImage = Global.My.Resources.Resources.Add
        Me.btn_agregar_grupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar_grupo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_agregar_grupo.Location = New System.Drawing.Point(264, 0)
        Me.btn_agregar_grupo.Name = "btn_agregar_grupo"
        Me.btn_agregar_grupo.Size = New System.Drawing.Size(27, 22)
        Me.btn_agregar_grupo.TabIndex = 1
        Me.btn_agregar_grupo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 299)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.My.Resources.Resources.Delete
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(302, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.My.Resources.Resources.Add
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(269, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 22)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 320)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roles/Acciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ID_ROL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_ROL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ACCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_ACCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_quitar_grupo As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_grupo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_Desc_Rol As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
