Imports System.Data.SqlClient

Public Class CCCCargarCombozReporLot
    Inherits Conexion

    Dim _Cmd As New SqlCommand




    Public Function cargarComboLotria()

        Try
            Conectado()
            _Cmd = New SqlCommand("CARGAR_LOTERI")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.Connection = _cnn

            If _Cmd.ExecuteNonQuery Then
                Dim _DT As New DataTable
                Dim _DS As New SqlDataAdapter(_Cmd)
                _DS.Fill(_DT)
                Return _DT
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

            Return Nothing
        End Try


    End Function
End Class
