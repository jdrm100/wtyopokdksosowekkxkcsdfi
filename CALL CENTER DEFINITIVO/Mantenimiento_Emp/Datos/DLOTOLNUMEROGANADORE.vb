
Imports System.Data.SqlClient



Public Class DLOTOLNUMEROGANADORE
    Inherits Conexion1
    Dim _Cmd As New SqlCommand

    Public Function numeroGanadore()

        Try
            Conetado()
            _Cmd = New SqlCommand("ENVIO_QJM_LNUMEROS")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.Connection = (_ccn)
            _Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Problema con la coneccion BD.No encuentra el Procedimiento Almacenado")

        End Try


        Return False



    End Function



End Class
