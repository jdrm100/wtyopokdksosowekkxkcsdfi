
Imports System.Data.SqlClient

Public Class CCCReporteRecargaTrancciones


    Inherits Conexion

    Protected _Cmd As New SqlCommand



    Public Function reporteRecargaTran(_FechaInicial As Date, _FechaFinal As Date, _Codigo As Integer)

        Try

            Conectado()

            Dim _ListaTran As New List(Of Ereporterecargatran)

            _Cmd = New SqlCommand("REPORTE_RECARGAR_TRANSACCIONES")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.Connection = _cnn


            _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = tranformaFecha(_FechaInicial)
            _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = tranformaFecha(_FechaFinal)
            _Cmd.Parameters.Add("@NumeroAgente", SqlDbType.VarChar, 20).Value = _Codigo

            Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

            While _Leer.Read

                Dim _Entidad As New Ereporterecargatran
                _Entidad._Agente = _Leer("AGENTE")
                _Entidad._FechaS = _Leer("FECHA").ToString
                _Entidad._Hora = _Leer("HORA").ToString
                _Entidad._Monto = _Leer("MONTO")
                _Entidad._Nombre = _Leer("NOMBRE")
                _Entidad._Provedoor = _Leer("PROVEDOOR")
                _Entidad._Serial = _Leer("SERIAL")
                _Entidad._Telefono = _Leer("TELEFONO")
                '_Entidad._FI = _FechaInicial
                '_Entidad._FD = _FechaFinal

                _ListaTran.Add(_Entidad)

            End While
          




            _Leer.Close()
            Desconetado()
            Return _ListaTran


        Catch ex As Exception
            MsgBox("Error al Executar el Procedimiento")
        End Try
        Return False

    End Function

    Public Function tranformaFecha(_Fecha As Date) As String
        Dim _Ano, _Mes, _Dia As String


        _Ano = _Fecha.Year
        _Mes = _Fecha.Month.ToString.PadLeft(2, "0")
        _Dia = _Fecha.Day.ToString.PadLeft(2, "0")

        Return _Ano & _Mes & _Dia




    End Function

End Class
