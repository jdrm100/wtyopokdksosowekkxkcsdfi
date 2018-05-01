<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class soliajuste
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
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_agente = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.tt_ajuste = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(6, 19)
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_comentario.Size = New System.Drawing.Size(377, 80)
        Me.txt_comentario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Agente:"
        '
        'lbl_agente
        '
        Me.lbl_agente.AutoSize = True
        Me.lbl_agente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agente.ForeColor = System.Drawing.Color.Black
        Me.lbl_agente.Location = New System.Drawing.Point(69, 9)
        Me.lbl_agente.Name = "lbl_agente"
        Me.lbl_agente.Size = New System.Drawing.Size(66, 13)
        Me.lbl_agente.TabIndex = 11
        Me.lbl_agente.Text = "lbl_agente"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_comentario)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(389, 106)
        Me.GroupBox6.TabIndex = 38
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Comentario"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.BackgroundImage = Global.My.Resources.Resources.Action_cancel_icon
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.Location = New System.Drawing.Point(248, 137)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(69, 60)
        Me.btn_cancelar.TabIndex = 40
        Me.tt_ajuste.SetToolTip(Me.btn_cancelar, "Cancelar solicitud")
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.Transparent
        Me.btn_aceptar.BackgroundImage = Global.My.Resources.Resources.mail_forward
        Me.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aceptar.Location = New System.Drawing.Point(334, 137)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(67, 60)
        Me.btn_aceptar.TabIndex = 39
        Me.tt_ajuste.SetToolTip(Me.btn_aceptar, "Enviar solicitud")
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'soliajuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(413, 200)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.lbl_agente)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "soliajuste"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Solicitud de Ajuste"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_comentario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_agente As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents tt_ajuste As System.Windows.Forms.ToolTip
End Class
