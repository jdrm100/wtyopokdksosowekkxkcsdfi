Imports System.Data.SqlClient

Public Class Conexion
    Protected _cnn As New SqlConnection




    Public Function Conectado()
        Try
            _cnn = New SqlConnection("Data Source=10.0.0.8\SERVERR2;Initial Catalog=lrc_r4;User ID=lrc;password=lrc12345")
            _cnn.Open()

            Return True
        Catch ex As Exception
            MsgBox("Ha fallado la Coneccion de la Base de Datos")
            Return False

        End Try
    End Function



    Public Function Desconetado()
        Try
            If _cnn.State = ConnectionState.Open Then
                _cnn.Close()
                Return True
            End If
        Catch ex As Exception
            MsgBox("No se ha cerrado la coneccion.Deberia Cerrarse")
        End Try
        Return False


    End Function

    Public Function GetConexion() As SqlConnection
        Return _cnn
    End Function

End Class
