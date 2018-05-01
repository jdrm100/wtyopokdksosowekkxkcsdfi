Public Class ges_aux
    Private Sub ges_aux_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgv_ges_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgv_ges.DataError

    End Sub

    Private Sub dgv_ges_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_ges.SelectionChanged
        lbl_selected.Text = "0"
        For Each row As DataGridViewRow In dgv_ges.Rows
            If dgv_ges.Rows(row.Index).Cells(0).Selected Then
                lbl_selected.Text = lbl_selected.Text + 1
            End If
        Next
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        For Each row As DataGridViewRow In dgv_ges.Rows
            If dgv_ges.Rows(row.Index).Cells(0).Selected Then
                If LTrim(RTrim(bloqueos.list_ges)) = "" Then
                    bloqueos.list_ges = "'" & dgv_ges.Rows(row.Index).Cells("ID").Value & "'"
                Else
                    bloqueos.list_ges = bloqueos.list_ges & ",'" & dgv_ges.Rows(row.Index).Cells("ID").Value & "'"
                End If

            End If
        Next
        Me.Close()
    End Sub

    Private Sub dgv_ges_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ges.CellContentClick

    End Sub
End Class