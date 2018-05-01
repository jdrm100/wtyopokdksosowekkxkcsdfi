Imports System.Data.SqlClient

Public Class Coneccion_Recarga
    Protected _cnn As New SqlConnection


    Protected Function conectado()
        Try
            _cnn = New SqlConnection("Data Source=10.0.0.8\SERVERR2;Initial Catalog=recarga;User ID=lrc;Password=lrc12345")
            _cnn.Open()            ' "Data Source=10.0.0.8\SERVERR2;Initial Catalog=lrc_r4;User ID=lrc;password=lrc12345") 
            Return True
        Catch ex As Exception
            MsgBox("No esta conectado al Servidor de la Base de Datos o Problema con la Base de Datos")
        End Try

        Return False




    End Function


    Protected Function desconectarme()

        Try
            If _cnn.State = ConnectionState.Open = True Then
                _cnn.Close()
                Return True

            End If
        Catch ex As Exception
            MsgBox("Nos se ha Cerrado la Coneccion y lo mas recomendable es que este Cerrada la Coneccion")
        End Try
        Return False
    End Function




End Class
