Imports System.Data.SqlClient
Public Class CCCReporteRetiro

    Inherits Conexion

    Protected _Cmd As New SqlCommand




    Public Function reporteRetiro(_FechaInicial As Date, _FechaFinal As Date) As List(Of EReporteRetiro)


        Conectado()
        Dim _ListaRetiro As New List(Of EReporteRetiro)

        _Cmd = New SqlCommand("[REPORTE_AGENTE_RETIRADOS]")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 20).Value = tranformarFecha(_FechaInicial)
        _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 20).Value = tranformarFecha(_FechaFinal)


        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

        While _Leer.Read
            Dim _ReporteRerirado As New EReporteRetiro

            If _Leer("FECHA") IsNot DBNull.Value Then
                _ReporteRerirado._FechaReirada = _Leer("FECHA")
            End If
            If _Leer("codgtech") IsNot DBNull.Value Then
                _ReporteRerirado._Codgtech = _Leer("codgtech")
            End If

            If _Leer("nombre") IsNot DBNull.Value Then
                _ReporteRerirado._Nombre = _Leer("nombre")
            End If
            If _Leer("Telefono") IsNot DBNull.Value Then
                _ReporteRerirado._Telefonod = _Leer("Telefono")
            End If
            If _Leer("Direccion") IsNot DBNull.Value Then
                _ReporteRerirado._Direccion = _Leer("Direccion")
            End If

            If _Leer("MUNICIPIO") IsNot DBNull.Value Then
                _ReporteRerirado._MUNICIPIO = _Leer("MUNICIPIO")
            End If

            If _Leer("PROVINCIA") IsNot DBNull.Value Then
                _ReporteRerirado._PROVINCIA = _Leer("PROVINCIA")
            End If

            If _Leer("REPRESENTANTE") IsNot DBNull.Value Then
                _ReporteRerirado._Representanted = _Leer("REPRESENTANTE")
            End If

            If _Leer("Motivo") IsNot DBNull.Value Then
                _ReporteRerirado._Motivo = _Leer("Motivo")
            End If
            If _Leer("nomrep") IsNot DBNull.Value Then
                _ReporteRerirado._Nomrep = _Leer("nomrep")
            End If

            _ReporteRerirado._FI = _FechaInicial
            _ReporteRerirado._FD = _FechaFinal


            _ListaRetiro.Add(_ReporteRerirado)


        End While
        _Leer.Close()
        Desconetado()
        Return _ListaRetiro

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
