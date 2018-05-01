Imports System.Data.SqlClient
Public Class ReporteAntiguedadDetallado

    Dim _Cmd As New SqlCommand
    Dim _cnn As New Conexion
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReporteAntiguedadDetallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarRepresentantes()
    End Sub

    Private Sub cargarRepresentantes()
        Dim _buscar As New CccAntiguedadDetalladovb
        Dim lista As DataTable = _buscar.GetRepresentantes()
        represent.DataSource = lista
        represent.DisplayMember = "nombre"
        represent.ValueMember = "ruta"


        'For Each item As Erepresentante In _Lista
        '    representatanteCMB.Items.Add(item.ToString)
        '    MsgBox("hola")
        'Next

        'For indice As Integer = 0 To _Lista.Count - 1 Step 1

        '    representatanteCMB.Items.Add(_Lista(indice).ToString)
        'Next



    End Sub

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        If AgenteTBOX.Text <> "" Then

            Dim _buscar As New CccAntiguedadDetalladovb
            Dim _lista As List(Of Eestadocuenta) = _buscar.AntiguedadDetallado(dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date, Convert.ToInt64(AgenteTBOX.Text))

            Dim _Mostrar As New AntiguedadDetallado(_lista)

            _Mostrar.Show()

        End If



    End Sub

    Private Sub AgenteTBOX_TextChanged(sender As Object, e As EventArgs) Handles AgenteTBOX.TextChanged

    End Sub

    Private Sub AgenteTBOX_Validated(sender As Object, e As EventArgs) Handles AgenteTBOX.Validated
      
    End Sub

    Private Sub AgenteTBOX_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AgenteTBOX.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub
End Class