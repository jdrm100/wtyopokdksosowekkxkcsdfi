
Imports System.Data.SqlClient
Public Class CCCRecargaTransCombo


    Inherits Coneccion_Recarga

    Protected _Cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            _Cmd = New SqlCommand("CARGA_COMBOZ_RECARGARTRAN")
            _Cmd.CommandType = CommandType.StoredProcedure

            _Cmd.Connection = _cnn

            If _Cmd.ExecuteNonQuery Then
                Dim _Dt As New DataTable
                Dim _Da As New SqlDataAdapter(_Cmd)
                _Da.Fill(_Dt)
                Return _Dt
            End If



            Return Nothing






        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
            desconectarme()
        End Try




    End Function



End Class
