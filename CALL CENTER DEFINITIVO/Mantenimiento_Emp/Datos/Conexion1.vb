
Imports System.Data.SqlClient
Public Class Conexion1

    Protected _ccn As New SqlConnection




    Protected Function Conetado()

        Try
            _ccn = New SqlConnection("Data Source=10.0.0.8\SERVERR2;Initial Catalog=lrc_r4;User ID=lrc;password=lrc12345")
            _ccn.Open()

            'Return True significa que se abrierto la coneccion
            Return True

        Catch ex As Exception
            MsgBox("No esta conectado al Servidor de la Base de Datos o Problema con la Base de Datos")
            Return False
        End Try





    End Function

    Protected Function Desconectado()

        Try
            If _ccn.State = ConnectionState.Open Then
                _ccn.Close()

                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox("Nos se ha Cerrado la Coneccion y lo mas recomendable es que este Cerrada la Coneccion")
            Return False

        End Try
    End Function


End Class
