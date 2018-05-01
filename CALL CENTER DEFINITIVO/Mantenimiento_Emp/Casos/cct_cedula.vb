Public Class cct_cedula
    Private Sub cct_cedula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbl_apr.Text = "0"
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    Private Sub txt_ced_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ced.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call txt_ced_LostFocus(sender, e)
        End If
    End Sub
    Private Sub txt_ced_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ced.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then 'Allows only numbers
            e.KeyChar = e.KeyChar 'Allows only numbers
        ElseIf Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar 'Allows "Backspace" to be used
        ElseIf e.KeyChar = "-"c Then
            e.KeyChar = "-"c
        Else
            e.Handled = True  'Disallows all other characters from being used on txtNights.Text
            Beep()
        End If
    End Sub
    Private Sub txt_ced_LostFocus(sender As Object, e As EventArgs) Handles txt_ced.LostFocus
        If Me.txt_ced.Text <> Me.lbl_ced.Text Then
            Me.lbl_msj.Text = "Cedula incorrecta"
            Me.lbl_msj.ForeColor = Color.Red
            Me.pb_msj.BackgroundImage = My.Resources.Resources.ico_error
            Me.lbl_msj.Visible = True
            Me.pb_msj.Visible = True
        Else
            Me.lbl_msj.Text = "Cedula correcta"
            Me.lbl_msj.ForeColor = Color.Blue
            Me.pb_msj.BackgroundImage = My.Resources.Resources.ico_si
            Me.lbl_msj.Visible = True
            Me.pb_msj.Visible = True
        End If
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        If Me.lbl_msj.Text = "Cedula correcta" Then
            Me.lbl_apr.Text = "1"
            Me.Close()
        Else
            MsgBox("La cedula digitada no es correcta!" & Chr(13), MsgBoxStyle.Information, "Call Center")
        End If
        
    End Sub
End Class