Imports System.Data.SqlClient
Imports Core.Domain.Seguridad


Public Class CCTAgenteSinVENTA
    Inherits Conexion1
    Dim _cmd As New SqlCommand
    Public Function AgenteSinVenta(_Usuario As Integer) As DataTable
        Try
            Conetado()
            'Dim age_list As New List(Of agente)
            _cmd = New SqlCommand("CCT_SELECT_USUARIO_RUTA")
            _cmd.CommandType = CommandType.StoredProcedure
            _cmd.Connection = _ccn

            _cmd.Parameters.Add("@usuario", SqlDbType.Int).Value = _Usuario

            If _cmd.ExecuteNonQuery Then
                Dim _dt As New DataTable
                Dim _da As New SqlDataAdapter(_cmd)
                _da.Fill(_dt)

                Return _dt
            Else
                Return Nothing
            End If

            'Dim _Leer As SqlDataReader = _cmd.ExecuteReader
            'While _Leer.Read
            '    Dim _Registro As New agente
            '    _Registro.ID = _Leer("RETAILER").ToString
            '    _Registro.nombre = _Leer("NOMBRE")
            '    age_list.Add(_Registro)


            'End While

            '_Leer.Close()
            'Desconectado()
            'Return age_list
        Catch ex As Exception
            MsgBox("No Error al executar la tabla temporal !AGENTE_SIN_VENTA!")
        End Try
        Return Nothing
        Try

        Finally
            Desconectado()
        End Try



        End
    End Function
End Class
