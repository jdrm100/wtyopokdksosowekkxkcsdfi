Public Class Bloqueado_Retirado

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        reporteRetirado()

        reporteBloq()

    End Sub

    Public Sub reporteBloq()
        If rd_bloqueado.Checked = True Then
            Dim _Buscar As New CCCReporteBloqueo
            Dim _Lista As List(Of Ebloqueado) = _Buscar.reporteBloqueo(dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date)

            Dim _Mostrar As New Reporte_Bloqueo_vista(_Lista)
            _Mostrar.Show()
        End If
        


    End Sub

    Public Sub reporteRetirado()
        If rd_retirado.Checked = True Then
            Dim _Buscar As New CCCReporteRetiro
            Dim _Lista As List(Of EReporteRetiro) = _Buscar.reporteRetiro(dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date)

            Dim _Mostrar As New Retiro_Vista(_Lista)
            _Mostrar.Show()
        End If
        
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class