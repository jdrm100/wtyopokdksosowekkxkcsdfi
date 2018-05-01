Imports System.Windows.Forms

Public Class Dialog1

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tt1.SetToolTip(Me.pb_detalle, "Mostrar/Ocultar detalle.")
    End Sub

    Public Sub mensaje(ByVal texto As String, ByVal tipo As String, ByVal titulo As String, Optional ByVal texto_error As String = "")
        Me.lbl_msg.Text = texto
        Me.Text = titulo
        Select Case tipo
            Case "correcto"
                Me.pb_msg.Image = My.Resources.Smiley
            Case "error"
                Me.pb_msg.Image = My.Resources.Smiley_Sad
                Me.pb_detalle.Visible = True
                Me.txt_error.Text = texto_error
            Case "pregunta"
                Me.pb_msg.Image = My.Resources.Smiley_Oooh
                Me.Cancel_Button.Visible = True
            Case "faltadato"
                Me.pb_msg.Image = My.Resources.Smiley_Angry
            Case Else
                Me.pb_msg.Image = My.Resources.Smiley_Oooh
        End Select
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub pb_detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb_detalle.Click
        If Me.pb_detalle.Tag = "mostrar" Then
            Me.Height = Me.Height + 140
            Me.pb_detalle.Tag = "ocultar"
            Me.pb_detalle.Image = My.Resources.application_get
        ElseIf Me.pb_detalle.Tag = "ocultar" Then
            Me.Height = Me.Height - 140
            Me.pb_detalle.Tag = "mostrar"
            Me.pb_detalle.Image = My.Resources.application_put
        End If

    End Sub


End Class
