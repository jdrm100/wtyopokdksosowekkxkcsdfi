Imports System.Data.SqlClient

Public Class Contabreportepega3
    Inherits Conexion1
    Dim _cmd As New SqlCommand


    'Public Function ReportePega3(_Fechainicial As Date, _Fechafinal As Date, _Codigoagente As Integer) As List(Of EreportePega3)

    '    '    Try
    '    '        Conetado()
    '    '        Dim _ReportePegaTre As New EreportePega3
    '    '        _cmd = New SqlCommand("REPORTE_PAGOSPEGA3")
    '    '        _cmd.CommandType = CommandType.StoredProcedure
    '    '        _cmd.Connection = _ccn

    '    '        _cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = _Fechainicial
    '    '        _cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = _Fechafinal
    '    '        _cmd.Parameters.Add("@Agente", SqlDbType.VarChar, 50).Value = _Codigoagente


    '    '        Dim _leer As SqlDataReader = _cmd.ExecuteReader
    '    '        Dim _Registro As New EreportePega3
    '    '        While _leer.Read

    '    '            _Registro._CodigoAgente = _leer("AGENTE")
    '    '            _Registro._Mes = _leer("Mes")
    '    '            _Registro._QuinielaPega3 = _leer("QuinielaPega3")
    '    '            _Registro._PalePega3 = _leer("PalePega3")
    '    '            _Registro._TripletaPega3 = _leer("TripletaPega3")
    '    '            '_Registro._Total = _leer("AGENTE")


    '    '            If _Registro._Mes = "Enero" Then

    '    '                _Registro._EneroPaleT += _Registro._PalePega3

    '    '            End If

    '    '            If _Registro._Mes = "Febreo" Then

    '    '                _Registro._FebreroPaleT += _Registro._PalePega3

    '    '            End If
    '    '            If _Registro._Mes = "Marzo" Then

    '    '                _Registro._MarzoPaleT += _Registro._PalePega3

    '    '            End If
    '    '            If _Registro._Mes = "Abril" Then

    '    '                _Registro._AbrilPaleT += _Registro._PalePega3

    '    '            End If
    '    '            If _Registro._Mes = "Mayo" Then

    '    '                _Registro._MayoPaleT += _Registro._PalePega3

    '    '            End If
    '    '            If _Registro._Mes = "Junio" Then

    '    '                _Registro._JunioPalet += _Registro._PalePega3

    '    '            End If

    '    '            If _Registro._Mes = "Julio" Then

    '    '                _Registro._JulioPaleT += _Registro._PalePega3

    '    '            End If

    '    '            If _Registro._Mes = "Agosto" Then

    '    '                _Registro._AgostoPaleT += _Registro._PalePega3

    '    '            End If
    '    '            If _Registro._Mes = "Septiembre" Then

    '    '                _Registro._SeptiembrePaleT += _Registro._PalePega3

    '    '            End If
    '    '            If _Registro._Mes = "Octumbre" Then

    '    '                _Registro._OctumbrePaleT += _Registro._PalePega3

    '    '            End If
    '    '            If _Registro._Mes = "Nomviembre" Then

    '    '                _Registro._NomviembrePaleT += _Registro._PalePega3

    '    '            End If
    '    '            If _Registro._Mes = "Diciembre" Then

    '    '                _Registro._DiciembrePaleT += _Registro._PalePega3

    '    '            End If





    '    '        End While

    '    '    Catch ex As Exception

    '    '    End Try





    '    'End Function


    'End Function
End Class
