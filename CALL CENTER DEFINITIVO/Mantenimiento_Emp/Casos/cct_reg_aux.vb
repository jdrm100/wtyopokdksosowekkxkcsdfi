Public Class cct_reg_aux

    Private Sub dgv_h_reg_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_h_reg.SelectionChanged
        Try
            If Me.dgv_h_reg.RowCount > 0 Then
                If Not Me.dgv_h_reg.CurrentRow.Cells(0).Value Is Nothing Then
                    Me.txt_nota.Text = Me.dgv_h_reg.CurrentRow.Cells("NOTA").Value

                    If Me.dgv_h_reg.CurrentRow.Cells("EST_TK").Value = 0 Then
                        Me.gb_est_tk.Visible = False
                    Else
                        Me.gb_est_tk.Visible = True
                        Me.lbl_est_tk.Text = IIf(Me.dgv_h_reg.CurrentRow.Cells("EST_TK").Value = 1, "Abierto", "Cerrado")
                        Me.lbl_verif.Text = IIf(Me.dgv_h_reg.CurrentRow.Cells("VERIF_SN").Value = 0, "Por Verificar", "Verificado")
                    End If
                    
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar nota: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub

End Class