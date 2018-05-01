
Imports System.Data.SqlClient

Public Class CCCReporteRecargaTrancciones


    Inherits Coneccion_Recarga

    Protected _Cmd As New SqlCommand



    Public Function reporteRecargaTran(_FechaInicial As Date, _FechaFinal As Date, _Codigo As Integer)

        Try

            Conectado()

            Dim _ListaTran As New List(Of Ereporterecargatran)

            _Cmd = New SqlCommand("REPORTE_RECARGA_TRANSACCIONES")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.Connection = _cnn


            _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = tranformaFecha(_FechaInicial)
            _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = tranformaFecha(_FechaFinal)
            _Cmd.Parameters.Add("@CodigoAgente", SqlDbType.VarChar, 10).Value = _Codigo

            Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

            While _Leer.Read

                Dim _Entidad As New Ereporterecargatran
                If _Leer("agente") IsNot DBNull.Value Then
                    _Entidad._Agente = _Leer("agente")
                End If

                If _Leer("fecha") IsNot DBNull.Value Then
                    _Entidad._FechaS = _Leer("fecha")
                End If

                _Entidad._Hora = _Leer("hora").ToString

                _Entidad._Monto = _Leer("Monto")

                If _Leer("nombre") IsNot DBNull.Value Then
                    _Entidad._Nombre = _Leer("nombre")
                End If
                If _Leer("PROVEEDOR") IsNot DBNull.Value Then
                    _Entidad._Provedoor = _Leer("PROVEEDOR")
                End If

                If _Leer("transacion") IsNot DBNull.Value Then
                    _Entidad._Serial = _Leer("transacion")
                End If
                If _Leer("telefono") IsNot DBNull.Value Then
                    _Entidad._Telefono = _Leer("telefono")
                End If
                _Entidad._FI = _FechaInicial
                _Entidad._FD = _FechaFinal

                _ListaTran.Add(_Entidad)

            End While
          




            _Leer.Close()
            desconectarme()
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
