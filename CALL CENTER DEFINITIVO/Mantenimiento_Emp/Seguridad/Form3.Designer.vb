<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ID_ACCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESC_ACCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESC_APLICACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_Desc_Accion = New System.Windows.Forms.TextBox
        Me.btn_quitar_accion = New System.Windows.Forms.Button
        Me.btn_agregar_accion = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_Desc_Apl = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ACCION, Me.DESC_ACCION})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 43)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(321, 328)
        Me.DataGridView1.TabIndex = 4
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
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DESC_APLICACION})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 43)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(311, 328)
        Me.DataGridView2.TabIndex = 1
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 50
        '
        'DESC_APLICACION
        '
        Me.DESC_APLICACION.DataPropertyName = "DESC_APLICACION"
        Me.DESC_APLICACION.HeaderText = "DESC_APLICACION"
        Me.DESC_APLICACION.Name = "DESC_APLICACION"
        Me.DESC_APLICACION.Width = 200
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.My.Resources.Resources.magnifier
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(8, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_quitar_accion)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_accion)
        Me.GroupBox1.Controls.Add(Me.txt_Desc_Accion)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 378)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'txt_Desc_Accion
        '
        Me.txt_Desc_Accion.Location = New System.Drawing.Point(41, 17)
        Me.txt_Desc_Accion.Name = "txt_Desc_Accion"
        Me.txt_Desc_Accion.Size = New System.Drawing.Size(177, 20)
        Me.txt_Desc_Accion.TabIndex = 0
        '
        'btn_quitar_accion
        '
        Me.btn_quitar_accion.BackColor = System.Drawing.Color.White
        Me.btn_quitar_accion.BackgroundImage = Global.My.Resources.Resources.Delete
        Me.btn_quitar_accion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_quitar_accion.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_quitar_accion.Location = New System.Drawing.Point(300, -1)
        Me.btn_quitar_accion.Name = "btn_quitar_accion"
        Me.btn_quitar_accion.Size = New System.Drawing.Size(27, 22)
        Me.btn_quitar_accion.TabIndex = 2
        Me.btn_quitar_accion.UseVisualStyleBackColor = False
        '
        'btn_agregar_accion
        '
        Me.btn_agregar_accion.BackColor = System.Drawing.Color.White
        Me.btn_agregar_accion.BackgroundImage = Global.My.Resources.Resources.Add
        Me.btn_agregar_accion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar_accion.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_agregar_accion.Location = New System.Drawing.Point(267, 0)
        Me.btn_agregar_accion.Name = "btn_agregar_accion"
        Me.btn_agregar_accion.Size = New System.Drawing.Size(27, 22)
        Me.btn_agregar_accion.TabIndex = 1
        Me.btn_agregar_accion.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_Desc_Apl)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(351, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 378)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aplicaciones"
        '
        'txt_Desc_Apl
        '
        Me.txt_Desc_Apl.Location = New System.Drawing.Point(27, 17)
        Me.txt_Desc_Apl.Name = "txt_Desc_Apl"
        Me.txt_Desc_Apl.Size = New System.Drawing.Size(177, 20)
        Me.txt_Desc_Apl.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.My.Resources.Resources.Delete
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(290, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 22)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = Global.My.Resources.Resources.Add
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(257, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 22)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 396)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acciones/Aplicaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ID_ACCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_ACCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_APLICACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Desc_Accion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_accion As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_accion As System.Windows.Forms.Button
    Friend WithEvents txt_Desc_Apl As System.Windows.Forms.TextBox
End Class
