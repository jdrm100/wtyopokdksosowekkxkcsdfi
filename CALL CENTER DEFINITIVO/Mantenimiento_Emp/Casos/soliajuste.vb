Public Class soliajuste
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Reg001.enviar = False
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Reg001.c_a = txt_comentario.Text
        Reg001.enviar = True
        Me.Close()
    End Sub

End Class