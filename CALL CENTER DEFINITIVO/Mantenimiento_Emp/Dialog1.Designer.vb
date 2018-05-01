<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Me.components = New System.ComponentModel.Container
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.txt_error = New System.Windows.Forms.TextBox
        Me.lbl_msg = New System.Windows.Forms.Label
        Me.tt1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pb_msg = New System.Windows.Forms.PictureBox
        Me.pb_detalle = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pb_msg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(148, 58)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(178, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Image = Global.My.Resources.Resources.accept
        Me.OK_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(83, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = Global.My.Resources.Resources.ico_error
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(92, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(83, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        Me.Cancel_Button.Visible = False
        '
        'txt_error
        '
        Me.txt_error.Location = New System.Drawing.Point(9, 102)
        Me.txt_error.Multiline = True
        Me.txt_error.Name = "txt_error"
        Me.txt_error.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_error.Size = New System.Drawing.Size(302, 94)
        Me.txt_error.TabIndex = 1
        '
        'lbl_msg
        '
        Me.lbl_msg.Location = New System.Drawing.Point(57, 12)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(257, 40)
        Me.lbl_msg.TabIndex = 2
        Me.lbl_msg.Text = "Mensaje"
        Me.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tt1
        '
        Me.tt1.AutoPopDelay = 50000
        Me.tt1.InitialDelay = 500
        Me.tt1.ReshowDelay = 100
        '
        'pb_msg
        '
        Me.pb_msg.Image = Global.My.Resources.Resources.Smiley_Angry
        Me.pb_msg.Location = New System.Drawing.Point(12, 12)
        Me.pb_msg.Name = "pb_msg"
        Me.pb_msg.Size = New System.Drawing.Size(39, 40)
        Me.pb_msg.TabIndex = 4
        Me.pb_msg.TabStop = False
        '
        'pb_detalle
        '
        Me.pb_detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pb_detalle.Image = Global.My.Resources.Resources.application_put
        Me.pb_detalle.Location = New System.Drawing.Point(12, 71)
        Me.pb_detalle.Name = "pb_detalle"
        Me.pb_detalle.Size = New System.Drawing.Size(20, 16)
        Me.pb_detalle.TabIndex = 3
        Me.pb_detalle.TabStop = False
        Me.pb_detalle.Tag = "mostrar"
        Me.pb_detalle.Visible = False
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(326, 99)
        Me.Controls.Add(Me.pb_msg)
        Me.Controls.Add(Me.pb_detalle)
        Me.Controls.Add(Me.lbl_msg)
        Me.Controls.Add(Me.txt_error)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pb_msg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txt_error As System.Windows.Forms.TextBox
    Friend WithEvents lbl_msg As System.Windows.Forms.Label
    Friend WithEvents pb_detalle As System.Windows.Forms.PictureBox
    Friend WithEvents pb_msg As System.Windows.Forms.PictureBox
    Friend WithEvents tt1 As System.Windows.Forms.ToolTip

End Class
