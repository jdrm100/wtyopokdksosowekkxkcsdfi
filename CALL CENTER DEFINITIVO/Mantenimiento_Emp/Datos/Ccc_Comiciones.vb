
Imports System.Data.SqlClient

Public Class Ccc_Comiciones
    Inherits Conexion
    Dim _Cmd As New SqlCommand
    Dim _Cmd2 As New SqlCommand

    Public Function GenerarComiciones(tipo As String, loteriaCod As String, Fi As String, Ff As String, Agente As String) As List(Of Ecomisiones)
        Conectado()

        Dim _Comisiones As New List(Of Ecomisiones)
        Dim _ComisionesDest As New List(Of Ecomisionesde)
        _Cmd = New SqlCommand("ComisionesRep")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn
        _Cmd.CommandTimeout = 100000000

        'Dim sData1 As String
        'Dim sData2 As String
        'Dim arrData1() As String
        'Dim arrData2() As String
        'Dim i As Long
        'sData1 = "data1:data2|data3:data4|data5:data6|data7:data8"
        'arrData1 = Split(sData1, "|")
        'sData2 = Join(arrData1)
        'arrData2 = Split(sData2, ":")
        'For i = 0 To UBound(arrData2)
        '    MsgBox(arrData2(i))
        'Next
        Dim lotDet() As String
        lotDet = Split(loteriaCod, "-")
        ' MsgBox(lotDet(0) & " " & lotDet(1))
        _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 15).Value = Fi
        _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 15).Value = Ff
        _Cmd.Parameters.Add("@Agente", SqlDbType.VarChar, 15).Value = Agente
        _Cmd.Parameters.Add("@Loteria", SqlDbType.VarChar, 15).Value = lotDet(0)
        _Cmd.Parameters.Add("@Juego", SqlDbType.VarChar, 15).Value = lotDet(1)
        _Cmd.Parameters.Add("@Tipo", SqlDbType.VarChar, 15).Value = tipo


        'M/d/yyyy H:mm
        ' Dim f As Long = DateDiff(DateInterval.Day, Convert.ToDateTime("20/10/2017"), Convert.ToDateTime("23/10/2017"))
        '  MsgBox(f)


        _ComisionesDest = LlenardestalleComisiones(tipo, loteriaCod, Fi, Ff, Agente)

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

        While _Leer.Read
            Dim _Registro As New Ecomisiones

            _Registro._Venta = _Leer("ventas")
            _Registro._Pago = _Leer("pagos")
            _Registro._Fecha = _Leer("fecha")
            _Registro._FechaInicial = Fi
            _Registro._FechaFinal = Ff
            _Registro._Agente = Agente
            _Registro._ComVentas = 0
            Dim comVentasTemp As Decimal = 0

            'MsgBox(_Registro._Venta & " " & _Registro._Pago & " " & _Registro._Fecha & " " )
            For Each cdest As Ecomisionesde In _ComisionesDest
                'Real
                'MsgBox(_Registro._ComVentas.ToString & "")
                'comiVentas
                If cdest._Fecha = _Registro._Fecha Then

                    If cdest._Tipotx = "01" Then
                        comVentasTemp += cdest._ComVent
                    End If

                    'If cdest._Codigo = "31" And cdest._Tipotx = "01" And cdest._NumJuego = "00" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Loto_Real")) / 100

                    'ElseIf cdest._Codigo = "09" And cdest._Tipotx = "01" And cdest._NumJuego = "00" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Quiniela_Real")) / 100

                    'ElseIf cdest._Codigo = "09" And cdest._Tipotx = "01" And cdest._NumJuego = "01" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Pale_Real")) / 100

                    'ElseIf cdest._Codigo = "09" And cdest._Tipotx = "01" And cdest._NumJuego = "02" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Tripleta_Real")) / 100

                    'ElseIf cdest._Codigo = "23" And cdest._Tipotx = "01" And cdest._NumJuego = "03" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Quinielita")) / 100

                    'ElseIf cdest._Codigo = "10" And cdest._Tipotx = "01" And cdest._NumJuego = "10" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Pega4")) / 100


                    '    'ElseIf cdest._Codigo = "60" And cdest._Tipotx = "01" And cdest._NumJuego = "00" Then
                    '    '    comVentasTemp += (cdest._Monto * _Leer("Quiniela_Pega3")) / 100

                    '    'ElseIf cdest._Codigo = "60" And cdest._Tipotx = "01" And cdest._NumJuego = "01" Then
                    '    '    comVentasTemp += (cdest._Monto * _Leer("Pale_Pega3")) / 100

                    '    'ElseIf cdest._Codigo = "60" And cdest._Tipotx = "01" And cdest._NumJuego = "02" Then
                    '    '    comVentasTemp += (cdest._Monto * _Leer("Tripleta_Pega3")) / 100

                    '    'ElseIf cdest._Codigo = "60" And cdest._Tipotx = "01" And cdest._NumJuego = "03" Then
                    '    '    comVentasTemp += (cdest._Monto * _Leer("Acumulado_Pega3")) / 100




                    '    'Leidsa
                    'ElseIf cdest._Codigo = "34" And cdest._Tipotx = "01" And cdest._NumJuego = "00" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Quiniela_Pale_Leidsa")) / 100

                    'ElseIf cdest._Codigo = "34" And cdest._Tipotx = "01" And cdest._NumJuego = "01" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Pale_Pale_Leidsa")) / 100

                    'ElseIf cdest._Codigo = "34" And cdest._Tipotx = "01" And cdest._NumJuego = "02" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Tripleta_Pale_Leidsa")) / 100


                    '    'Nacional
                    'ElseIf cdest._Codigo = "08" And cdest._Tipotx = "01" And cdest._NumJuego = "00" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Quiniela_Nacional")) / 100

                    'ElseIf cdest._Codigo = "08" And cdest._Tipotx = "01" And cdest._NumJuego = "01" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Pale_Nacional")) / 100

                    'ElseIf cdest._Codigo = "08" And cdest._Tipotx = "01" And cdest._NumJuego = "02" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("Tripleta_Nacional")) / 100


                    '    'Real, nacional y leidsa 
                    'ElseIf cdest._Codigo = "27" And cdest._Tipotx = "01" And cdest._NumJuego = "06" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("SP_REAL_T_Y_NACIONAL_T")) / 100

                    'ElseIf cdest._Codigo = "45" And cdest._Tipotx = "01" And cdest._NumJuego = "00" Then
                    '    comVentasTemp += (cdest._Monto * _Leer("SP_NACIONAL_N_Y_LEIDSA_N")) / 100

                    'End If

                    If cdest._Tipotx = "03" And cdest._Codigo = "60" Then
                        _Registro._ComPagos += (cdest._Monto * _Leer("com_p3_pago")) / 100
                    ElseIf cdest._Tipotx = "03" And cdest._Codigo <> "60" Then
                        _Registro._ComPagos += (cdest._Monto * _Leer("com_pago")) / 100

                    End If

                End If

            Next cdest
            _Registro._ComVentas = comVentasTemp

            _Comisiones.Add(_Registro)

        End While

        Return _Comisiones

    End Function
    Public Function GetLoterias()  As DataTable
        Conectado()
        Dim DA As New SqlDataAdapter
        Dim DT As New DataTable
        DA = New SqlDataAdapter("SELECT codigo+'-'+codigojuego as cod, descripcion FROM juegos", _cnn)
        DA.Fill(DT)
        Desconetado()
        Return DT
    End Function


    Public Function LlenardestalleComisiones(tipo As String, loteriaCod As String, Fi As String, Ff As String, Agente As String) As List(Of Ecomisionesde)
        Conectado()

        Dim lotDet() As String
        lotDet = Split(loteriaCod, "-")
        'MsgBox(loteriaCod & " " & tipo & " " & Agente.ToString)
        Dim _ComisionesDes2 As New List(Of Ecomisionesde)
        _Cmd2 = New SqlCommand("ReporteComosiones")
        _Cmd2.CommandType = CommandType.StoredProcedure
        _Cmd2.Connection = _cnn
        _Cmd2.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 15).Value = Fi
        _Cmd2.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 15).Value = Ff
        _Cmd2.Parameters.Add("@Agente", SqlDbType.VarChar, 15).Value = Agente
        _Cmd2.Parameters.Add("@Loteria", SqlDbType.VarChar, 15).Value = lotDet(0)
        _Cmd2.Parameters.Add("@Juego", SqlDbType.VarChar, 15).Value = lotDet(1)
        _Cmd2.Parameters.Add("@Tipo", SqlDbType.VarChar, 15).Value = tipo
        _Cmd.CommandTimeout = 100000000
        Dim _Leer2 As SqlDataReader = _Cmd2.ExecuteReader


        While _Leer2.Read

            'Real
            Dim _Registro2 As New Ecomisionesde
            If _Leer2("calcom") = 1 Then
                'MsgBox(_Leer2("codigo") & " " & _Leer2("numjuego") & " " & _Leer2("tipotx") & " " & _Leer2("monto"))
                _Registro2._Codigo = _Leer2("codigo")
                _Registro2._ComVent = _Leer2("comiVentas")
                _Registro2._NumJuego = _Leer2("numjuego")
                _Registro2._Tipotx = _Leer2("tipotx")
                _Registro2._Monto = _Leer2("monto")
                _Registro2._Fecha = _Leer2("fecha")
                _ComisionesDes2.Add(_Registro2)
            Else
                'MsgBox("Este agente no calcula comiciones")

            End If
        End While

        Return _ComisionesDes2

    End Function


    Public Function TranformarFecha(_Fecha As Date) As String
        Dim _Ano, _Mes, _Dia As String

        _Ano = _Fecha.Year
        _Mes = _Fecha.Month.ToString.PadLeft(2, "0")
        _Dia = _Fecha.Day.ToString.PadLeft(2, "0")

        Return _Ano & _Mes & _Dia

    End Function

    Private Function __Registro() As Object
        Throw New NotImplementedException
    End Function

    Private Function __Registro2() As Object
        Throw New NotImplementedException
    End Function

End Class
