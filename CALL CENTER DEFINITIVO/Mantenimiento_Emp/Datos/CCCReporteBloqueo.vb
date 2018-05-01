Imports System.Data.SqlClient

Public Class CCCReporteBloqueo

    Inherits Conexion

    Protected _Cmd As New SqlCommand




    Public Function reporteBloqueo(_FechaInicial As Date, _FechaFinal As Date) As List(Of Ebloqueado)


        Conectado()
        Dim _ListaBloqueo As New List(Of Ebloqueado)

        _Cmd = New SqlCommand("REPORTE_DESBLOQUE")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 20).Value = tranformarFecha(_FechaInicial)
        _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 20).Value = tranformarFecha(_FechaFinal)


        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

        While _Leer.Read
            Dim _ReporteBloq As New Ebloqueado

            If _Leer("Fecha") IsNot DBNull.Value Then
                _ReporteBloq._Fecha = _Leer("Fecha")
            End If

            If _Leer("Codigo").ToString IsNot DBNull.Value Then
                _ReporteBloq._Agente = _Leer("Codigo")
            End If

            If _Leer("Nombre") IsNot DBNull.Value Then
                _ReporteBloq._Nombre = _Leer("Nombre")
            End If

            If _Leer("Estado") IsNot DBNull.Value Then
                _ReporteBloq._Estado = _Leer("Estado")
            End If

            If _Leer("Direccion") IsNot DBNull.Value Then
                _ReporteBloq._Direccion = _Leer("Direccion")
            End If
            If _Leer("Municipio") IsNot DBNull.Value Then
                _ReporteBloq._Municipio = _Leer("Municipio")
            End If

            If _Leer("Sector") IsNot DBNull.Value Then
                _ReporteBloq._Sector = _Leer("Sector")
            End If
            If _Leer("Representante") IsNot DBNull.Value Then
                _ReporteBloq._Representante = _Leer("Representante")
            End If

            _ReporteBloq._Balance = _Leer("Balance")

            If _Leer("ANT") IsNot DBNull.Value Then
                _ReporteBloq._Ant = _Leer("ANT")

            End If
            If _Leer("Gestor") IsNot DBNull.Value Then
                _ReporteBloq._Gestor = _Leer("Gestor")
            End If
            _ReporteBloq._FI = _FechaInicial
            _ReporteBloq._FD = _FechaFinal


            _ListaBloqueo.Add(_ReporteBloq)


        End While
        _Leer.Close()
        Desconetado()
        Return _ListaBloqueo

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
