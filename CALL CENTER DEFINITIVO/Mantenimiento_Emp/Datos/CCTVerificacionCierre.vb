Imports System.Data.SqlClient

Public Class CCTVerificacionCierre


    Inherits Conexion

    Protected _Cmd As New SqlCommand


    'ss'
    Public Function verificacionCierreCCT(_ver As Integer) As DataTable
        Try
            Conectado()

            _Cmd = New SqlCommand("Verificarcierre")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = _ver
            _Cmd.Connection = _cnn


            If _Cmd.ExecuteNonQuery Then
                Dim _Dt As New DataTable
                Dim _Ds As New SqlDataAdapter(_Cmd)
                _Ds.Fill(_Dt)
                Return _Dt
            Else
                Return Nothing

            End If


        Catch ex As Exception
            MsgBox("No Error al executar  el procedimiento !Verificarcierre!")
        End Try


        Return Nothing

        Desconetado()
    End Function


End Class
