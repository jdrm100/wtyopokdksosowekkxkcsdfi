Public Class frmReporte_Loteria
    Dim _Tabla As DataTable
    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        reporteLotNumeroJug()
    End Sub


    'edtydtt
    Sub reporteLotNumeroJug()
        If Me.ValidateChildren = True And txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then
            Try
                If txt_agente.Text <> "" And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then
                    Dim _Buscar As New CCCReporteLoteria
                    'MsgBox(cbo_juegos.SelectedValue)
                    Dim _Lista As List(Of EReporteLoteria) = _Buscar.reporteLoteria(cbo_juegos.SelectedValue, dtp_fechainicial.Value.Date, dtp_fechafinal.Value.Date, Convert.ToInt64(txt_agente.Text))

                    Dim _Mostar As New Sistema_de_Facturacion_Reporte_de_Numero_Jugados(_Lista)
                    _Mostar.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                ' MessageBox.Show("Error al  llamar el Procedimiento,No se puede ingresar LETRAS" , "Llamar los Metodos y Validar campos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Introduzca el numero del agente por favor,Este campo es obligatorio", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Public Sub cargarCombozLoteria()
        Try
            Dim _Buscar As New CCCCargarCombozReporLot
            _Tabla = _Buscar.cargarComboLotria
            cbo_juegos.ValueMember = "codigo"
            cbo_juegos.DisplayMember = "descripcion"
            cbo_juegos.DataSource = _Tabla
        Catch ex As Exception
            MessageBox.Show("Error al llamar al Metodo", "Error al Cargar ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    'hetyert
    Private Sub frmReporte_Loteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombozLoteria()
    End Sub



    Private Sub txt_agente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_agente.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 And Val(txt_agente.Text) - Int(Val(txt_agente.Text)) = 0 Then
                Me.ErrorMensaje.SetError(sender, "")
            Else
                Me.ErrorMensaje.SetError(sender, "introduzca el numero del agente por favor,Este campo es obligatorio")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub cbo_juegos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_juegos.SelectedIndexChanged

    End Sub
End Class