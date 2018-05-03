
Imports System.Data.SqlClient
Public Class CCCRecargaDetallado

    Inherits Conexion
    Protected _Cmd As New SqlCommand
    Dim _Mostar As String


    Public Function recargarDetallada(_FechaIncial As Date, _FechaFinal As Date, _Codigo As Integer)

        Try
            Conectado()
            Dim _ListaRecargDetalla As New List(Of Erecargadetalla)

            _Cmd = New SqlCommand("REPORTE_RECARGA_DETALLADO")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.CommandTimeout = 120000
            _Cmd.Connection = _cnn

            _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = tranformarFecha(_FechaIncial)
            _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = tranformarFecha(_FechaFinal)
            _Cmd.Parameters.Add("@CodigoAgente", SqlDbType.VarChar, 26).Value = _Codigo

        


            Dim _Leer As SqlDataReader = _Cmd.ExecuteReader




            While _Leer.Read

                Dim _Recargadetallada As New Erecargadetalla
                _Recargadetallada._FI = _FechaIncial
                _Recargadetallada._FD = _FechaFinal

                If _Leer("Agente") IsNot DBNull.Value Then
                    _Recargadetallada._Agente = _Leer("Agente")
                End If

                If _Leer("Claro") IsNot DBNull.Value Then
                    _Recargadetallada._Claro = _Leer("Claro")
                End If

                If _Leer("Dicitel") IsNot DBNull.Value Then
                    _Recargadetallada._Digicel = _Leer("Dicitel")
                End If

                If _Leer("Gestor") IsNot DBNull.Value Then
                    _Recargadetallada._Gestor = _Leer("Gestor")
                End If

                If _Leer("Nombre") IsNot DBNull.Value Then
                    _Recargadetallada._Nombre = _Leer("Nombre")
                End If

                If _Leer("Orange") IsNot DBNull.Value Then
                    _Recargadetallada._Orange = _Leer("Orange")
                End If
                If _Leer("Viva") IsNot DBNull.Value Then
                    _Recargadetallada._Viva = _Leer("Viva")
                End If

                If _Leer("Tricom") IsNot DBNull.Value Then
                    _Recargadetallada._Tricom = _Leer("Tricom")
                End If
                If _Leer("Total") IsNot DBNull.Value Then
                    _Recargadetallada._Total = _Leer("Total")
                End If
                _Recargadetallada._FI = _FechaIncial
                _Recargadetallada._FD = _FechaFinal

                _ListaRecargDetalla.Add(_Recargadetallada)



            End While
            _Leer.Close()
            Desconetado()
            Return _ListaRecargDetalla

        Catch ex As Exception
            MsgBox("Error al cargar el Procedimiento")
        End Try
        Return False



    End Function

    Public Function tranformarFecha(_Fecha As Date) As String
        Dim _Ano, _Mes, _Dia As String
        _Ano = _Fecha.Year
        _Mes = _Fecha.Month.ToString.PadLeft(2, "0")
        _Dia = _Fecha.Day.ToString.PadLeft(2, "0")

        Return _Ano & _Mes & _Dia

    End Function




End Class
