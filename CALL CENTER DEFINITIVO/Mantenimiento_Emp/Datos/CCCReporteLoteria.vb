Imports System.Data.SqlClient

Public Class CCCReporteLoteria

    Inherits Conexion

    Protected _Cmd As New SqlCommand



    'jdfjhfhkf
    Public Function reporteLoteria(juego As String, _FechaInicial As Date, _FechaFinal As Date, _Agente As String) As List(Of EReporteLoteria)

        'cual es lo que te falta? el procedimento dinamico cuando elija una lotoria el comboz aparesca el resultado
        Conectado()
        Dim _ListaLotoria As New List(Of EReporteLoteria)

        _Cmd = New SqlCommand("REPORTE_LOTERIA")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.CommandTimeout = 120000
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@FechaIniial", SqlDbType.VarChar, 20).Value = tranformarFecha(_FechaInicial)
        _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 20).Value = tranformarFecha(_FechaFinal)
        _Cmd.Parameters.Add("@CodigoAgente", SqlDbType.VarChar, 50).Value = _Agente
        _Cmd.Parameters.Add("@loteria", SqlDbType.VarChar, 20).Value = juego
        '_Cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 10).Value = _Codigo

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

        While _Leer.Read
            Dim _ReporteLot As New EReporteLoteria
            Dim _TotalMonto As Decimal = 0
            Dim _AcumularMonto As Decimal = 0

            If _Leer("AGENTE") IsNot DBNull.Value Then
                _ReporteLot._Agente = _Leer("AGENTE")
            End If

            If _Leer("FECHA") IsNot DBNull.Value Then
                _ReporteLot._Fecha = _Leer("FECHA")
            End If

            If _Leer("HORA") IsNot DBNull.Value Then
                _ReporteLot._Hora = _Leer("HORA")
            End If

            If _Leer("MONTO") IsNot DBNull.Value Then
                _ReporteLot._Monto = _Leer("MONTO")
            End If

            If _Leer("JUEGO") IsNot DBNull.Value Then


                _ReporteLot._Juego = _Leer("JUEGO")
            End If

            If _Leer("NUMEROJUG") IsNot DBNull.Value Then


                _ReporteLot._NumeroJUG = _Leer("NUMEROJUG")
            End If

            If _Leer("Tanda") IsNot DBNull.Value Then

                _ReporteLot._Tanda = _Leer("Tanda")
            End If


            If _Leer("TICKET") IsNot DBNull.Value Then


                _ReporteLot._Ticket = _Leer("TICKET")
            End If

            If _Leer("Nombre") IsNot DBNull.Value Then
                _ReporteLot._Nombre = _Leer("Nombre")
            End If
            _ReporteLot._FI = _FechaInicial
            _ReporteLot._FD = _FechaFinal




            _ListaLotoria.Add(_ReporteLot)


        End While
        Dim i As Decimal
        Dim _Total As Decimal = 0

        For i = 0 To _ListaLotoria.Count - 1
            '``Calcular  contribuccion al Jackpot por ciento


            _Total += _ListaLotoria.Item(i)._Monto
            _ListaLotoria.Item(i)._TotalMonto = _Total

        Next
        _Leer.Close()
        Desconetado()
        Return _ListaLotoria
        'Catch ex As Exception
        '    MsgBox("Error al cargar el Procedimiento")

        '    Return False
        'End Try




    End Function

    Public Function tranformarFecha(_Fecha As Date) As String

        Try
            Dim _ano, _mes, _dia As String
            _ano = _Fecha.Year
            _mes = _Fecha.Month.ToString.PadLeft(2, "0")
            _dia = _Fecha.Day.ToString.PadLeft(2, "0")

            Return _ano & _mes & _dia
            Return True
        Catch ex As Exception
            MsgBox("Error  ha Tranformar la Fecha")
        End Try
        Return False

    End Function

End Class
