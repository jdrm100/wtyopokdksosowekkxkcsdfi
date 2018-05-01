Public Class FCCCobro
    Private _dt As DataTable

    Private Sub FCCCobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub


    Private Sub Mostrar()

        Try
            Dim _AGENTERETIRADO As New CCCHistorialAgenteRetirado
            _dt = _AGENTERETIRADO.mostrar

            If _dt.Rows.Count <> 0 Then
                DataGridView1.DataSource = _dt
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class