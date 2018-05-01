Imports System.Data.SqlClient

Public Class CccReporteRecargaResumido
    Inherits Coneccion_Recarga
    Protected _Cmd As New SqlCommand



    Public Function reporteRecargaResumido(_FechaInicial As Date, _FechaFinal As Date, _Codigo As Integer)

        Try
            conectado()
            Dim _TipoListaReporteResumido As New List(Of Ereporterecargaresumido)

            _Cmd = New SqlCommand("REPORTE_RECARGA_RESUMIDO")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.CommandTimeout = 12000
            _Cmd.Connection = _cnn

            _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = tranformarFecha(_FechaInicial)
            _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = tranformarFecha(_FechaFinal)
            _Cmd.Parameters.Add("@CodigoAgente", SqlDbType.VarChar, 50).Value = _Codigo

            Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
            Dim _Total As Decimal = 0
            While _Leer.Read

                Dim _ListaRecarga As New Ereporterecargaresumido

                If _Leer("Agente") IsNot DBNull.Value Then
                    _ListaRecarga._Agente = _Leer("Agente")
                End If
                _ListaRecarga._Claro = _Leer("Claro")
                _ListaRecarga._Digicel = _Leer("Orange")
                _ListaRecarga._Orange = _Leer("Viva")
                _ListaRecarga._Tricom = _Leer("Tricom")
                _ListaRecarga._Viva = _Leer("Digicel")

                _Total += _ListaRecarga._Claro + _ListaRecarga._Digicel + _ListaRecarga._Orange + _ListaRecarga._Tricom + _ListaRecarga._Viva
                _ListaRecarga._Total = _Total


                _ListaRecarga._FI = _FechaInicial
                _ListaRecarga._FD = _FechaFinal

                _TipoListaReporteResumido.Add(_ListaRecarga)

               
            End While
            _Leer.Close()
            desconectarme()
            Return _TipoListaReporteResumido



        Catch ex As Exception
            MsgBox("Error al executar Procedimientos o Dataset")
        End Try

        Return False



    End Function
    Public Function tranformarFecha(_Fecha As Date) As String

        Dim _ano, _mes, _dias As String

        _ano = _Fecha.Year
        _mes = _Fecha.Month.ToString.PadLeft(2, "0")
        _dias = _Fecha.Day.ToString.PadLeft(2, "0")

        Return _ano & _mes & _dias


    End Function



End Class
