Public Class frmReporte_Loteria

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        reporteLotNumeroJug()
    End Sub



    Sub reporteLotNumeroJug()
        Try
            If txt_agente.Text <> "" Then
                Dim _Buscar As New CCCReporteLoteria
                Dim _Lista As List(Of EReporteLoteria) = _Buscar.reporteLoteria(dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))

                Dim _Mostar As New Sistema_de_Facturacion_Reporte_de_Numero_Jugados(_Lista)
                _Mostar.Show()
            End If
        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub

End Class