Public Class FRMReporte_Recarga
    Private _Dt As New DataTable
    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click

        reporteRecargaResumido()
        reporteRecargaDetallada()
        reporteRecargaTrans()
    End Sub

    Public Sub reporteRecargaDetallada()
        If rd_detalla.Checked = True Then
            Try

                If txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then

                    Dim _Buscar As New CCCRecargaDetallado
                    Dim _Lista As List(Of Erecargadetalla) = _Buscar.recargarDetallada(Dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))


                    Dim _Mostar As New frm_Sistema_de_Facturacion_Reporte_de_Recargas(_Lista)
                    _Mostar.Show()
                End If

            Catch ex As Exception
                MessageBox.Show("Error al  llamar el Procedimiento,No se puede ingresar LETRAS", "Llamar los Metodos y Validar campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Public Sub reporteRecargaResumido()
        If Me.ValidateChildren = True And txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then


            Try
                If rd_resumida.Checked = True Then
                    If txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then
                        Dim _Buscar As New CccReporteRecargaResumido
                        Dim _Lista As List(Of Ereporterecargaresumido) = _Buscar.reporteRecargaResumido(Dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))

                        Dim _Mostrar As New frmSistema_de_Facturacion_Reporte_de_Recarga(_Lista)
                        _Mostrar.Show()

                    End If

                End If


            Catch ex As Exception
                MessageBox.Show("Error al  llamar el Procedimiento,No se puede ingresar LETRAS", "Llamar los Metodos y Validar campos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else
            MessageBox.Show("Introduzca el numero del agente por favor,Este campo es obligatorio", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Public Sub reporteRecargaTrans()

        If rd_transacciones.Checked = True Then
            Try


                If txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then


                    Dim _Buscar As New CCCReporteRecargaTrancciones
                    Dim _Lista As List(Of Ereporterecargatran) = _Buscar.reporteRecargaTran(Dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))

                    Dim _Mostar As New Ssitema_de_Facturacion_Transanciones(_Lista)
                    _Mostar.Show()
                End If

            Catch ex As Exception
                MessageBox.Show("Error al  llamar el Procedimiento,No se puede ingresar LETRAS", "Llamar los Metodos y Validar campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    'Public Sub mostrar()


    '    Try
    '        Dim _Buscar As New CCCRecargaTransCombo
    '        _Dt = _Buscar.mostrar
    '        cbo_operadora.DataSource = _Dt
    '        cbo_operadora.DisplayMember = "PROVEEDOR"

    '    Catch ex As Exception
    '        MessageBox.Show("Error al llamar al Metodo", "Error al Cargar ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub


    '    Private Sub Reporte_Recarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        'mostrar()
    '        txt_agente.Select()
    '        cargarCmbRecarga()
    '    End Sub

<<<<<<< HEAD
    '<<<<<<< HEAD


    '=======


    '    Private Sub cargarCmbRecarga()
    '        Dim _Buscar As New CCCRecargaDetallado
    '        Dim lista As DataTable = _Buscar.CargarProveedor()
    '        cbo_operadora.DataSource = lista
    '        cbo_operadora.DisplayMember = "d"
    '        cbo_operadora.ValueMember = "codigojuego"
    '    End Sub
    '>>>>>>> fba4313757a01fbcfa618eb7d27c660b135ca147
=======





    Private Sub cargarCmbRecarga()
        Dim _Buscar As New CCCRecargaDetallado
        Dim lista As DataTable = _Buscar.CargarProveedor()
        cbo_operadora.DataSource = lista
        cbo_operadora.DisplayMember = "d"
        cbo_operadora.ValueMember = "codigojuego"
    End Sub

>>>>>>> 20bb5bce5300bece0528d56bd4b9ef558bf253cf

    Private Sub txt_agente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_agente.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                'txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then
                Errorvalicion.SetError(sender, "")
            Else
                Errorvalicion.SetError(sender, "introduzca el numero del agente por favor,Este campo es obligatorio")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al valida los CAMPOS", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub cbo_operadora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_operadora.SelectedIndexChanged

    End Sub

    Private Sub rd_transacciones_CheckedChanged(sender As Object, e As EventArgs) Handles rd_transacciones.CheckedChanged

    End Sub

    Private Sub rd_detalla_CheckedChanged(sender As Object, e As EventArgs) Handles rd_detalla.CheckedChanged

    End Sub
End Class