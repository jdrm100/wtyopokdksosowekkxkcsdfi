Imports System.Data.SqlClient


Public Class CCCHistorialAgenteRetirado
    Inherits Conexion1

    Dim _cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            Conetado()
            _cmd = New SqlCommand("MostrarAgenteRetirado")
            _cmd.CommandType = CommandType.StoredProcedure


            _cmd.Connection = _ccn
            If _cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(_cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox("No se pudo encontra el Procedimiento Almacenado o No hay conecion con la Base de Datos")
            Return Nothing
        Finally
            Desconectado()

        End Try
    End Function

End Class
