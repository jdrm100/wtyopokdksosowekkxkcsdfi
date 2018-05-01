Public Class FRMReporte_Recarga

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click

        reporteRecargaResumido()
        reporteRecargaDetallada()
        reporteRecargaTrans()
    End Sub

    Public Sub reporteRecargaDetallada()

        Try
            If rd_detalla.Checked = True Then
                If txt_agente.Text <> "" Then

                    Dim _Buscar As New CCCRecargaDetallado
                    Dim _Lista As List(Of Erecargadetalla) = _Buscar.recargarDetallada(Dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))


                    Dim _Mostar As New frm_Sistema_de_Facturacion_Reporte_de_Recargas(_Lista)
                    _Mostar.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al Cargar el Metodo")
        End Try



    End Sub

    Public Sub reporteRecargaResumido()
        Try
            If rd_resumida.Checked = True Then
                If txt_agente.Text <> "" Then
                    Dim _Buscar As New CccReporteRecargaResumido
                    Dim _Lista As List(Of Ereporterecargaresumido) = _Buscar.reporteRecargaResumido(Dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))

                    Dim _Mostrar As New frmSistema_de_Facturacion_Reporte_de_Recarga(_Lista)
                    _Mostrar.Show()
                End If


            End If


        Catch ex As Exception
            MsgBox("Error al Cargar el Metodo")
        End Try

    End Sub

    Public Sub reporteRecargaTrans()
        Try
            If rd_transacciones.Checked = True Then
                Dim _Buscar As New CCCReporteRecargaTrancciones
                Dim _Lista As List(Of Ereporterecargatran) = _Buscar.reporteRecargaTran(Dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))

                Dim _Mostar As New Ssitema_de_Facturacion_Transanciones(_Lista)
                _Mostar.Show()
            End If
        Catch ex As Exception
            MsgBox("Error al Cargar el Metodo")
        End Try
    End Sub



    Private Sub rd_resumida_CheckedChanged(sender As Object, e As EventArgs) Handles rd_resumida.CheckedChanged

    End Sub

    Private Sub Reporte_Recarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_agente.Select()
    End Sub
End Class