 
Imports System.Data.SqlClient

Public Class Ccc_AntiguedadGestor
    Inherits Conexion
    Dim _Cmd As New SqlCommand

    Public Function AntiguedaddeSaldoGestor(Fi As String, Ff As String) As List(Of Eantiguedadsaldogestor)
        Conectado()

        Dim _Antiguedad As New List(Of Eantiguedadsaldogestor)
        _Cmd = New SqlCommand("[ANTIGUEDAD_GESTOR]")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = Fi
        _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = Ff

        '_Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = TranformarFecha(_FechaInicial)
        '_Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = TranformarFecha(_FechaFinal)
        'M/d/yyyy H:mm
        ' Dim f As Long = DateDiff(DateInterval.Day, Convert.ToDateTime("20/10/2017"), Convert.ToDateTime("23/10/2017"))
        ' MsgBox(f)

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Registro As New Eantiguedadsaldogestor
            _Registro._Agente = _Leer("agente").ToString
            _Registro._SemanaCurso = _Leer("venta_curso")
            _Registro._Fecha7 = _Leer("de_1_7")
            _Registro._Fecha8 = _Leer("de_8_14")
            _Registro._Fecha15 = _Leer("de_15_21")
            _Registro._Fecha22 = _Leer("de_22_28")
            _Registro._Fecha29 = _Leer("de_29_mas")
            _Registro._Balance = _Leer("balance")
            _Registro._nombre = _Leer("nombre")
            _Registro._bloqueada = _Leer("bloqueada")
            _Registro._telefono1 = _Leer("telefono1")
            _Registro._SumaR = _Leer("sumaR")
            _Registro._estdata = _Leer("estdata")
            _Registro._FechaActual = _Leer("fechaActual")
            _Registro._per7 = _Leer("per7")
            _Registro._per8 = _Leer("per8")
            _Registro._per15 = _Leer("per15")
            _Registro._per22 = _Leer("per22")
            _Registro._per29 = _Leer("per29")
            _Registro._gestor = _Leer("gestor")
            _Registro._codges = _Leer("codges")

            _Registro._FI = Fi
            _Registro._FF = Ff
            '_Registro._AntDia = _Leer("_AntDia")



            '  MsgBox(" " + _Registro._per29)


            If _Registro._bloqueada = 0 Then
                _Registro._bloqueada = "Activa"
            Else
                _Registro._bloqueada = "Bloqueada"
            End If
            If _Registro._Fecha29 <> 0 Then

                _Registro._Fecha29 = _Registro._Fecha29 + _Registro._SumaR
                _Registro._SumaR = _Registro._Fecha29
                If _Registro._Fecha29 > 0 Then
                    _Registro._SumaR = 0
                End If

                If _Registro._Fecha29 < 0 Then
                    _Registro._Fecha29 = 0
                End If
            End If

            If _Registro._Fecha22 <> 0 Then

                _Registro._Fecha22 = _Registro._Fecha22 + _Registro._SumaR
                _Registro._SumaR = _Registro._Fecha22

                If _Registro._Fecha22 > 0 Then
                    _Registro._SumaR = 0
                End If

                If _Registro._Fecha22 < 0 Then
                    _Registro._Fecha22 = 0
                End If

            End If

            If _Registro._Fecha15 <> 0 Then

                _Registro._Fecha15 = _Registro._Fecha15 + _Registro._SumaR
                _Registro._SumaR = _Registro._Fecha15

                If _Registro._Fecha15 > 0 Then
                    _Registro._SumaR = 0
                End If

                If _Registro._Fecha15 < 0 Then
                    _Registro._Fecha15 = 0
                End If

            End If

            If _Registro._Fecha8 <> 0 Then

                _Registro._Fecha8 = _Registro._Fecha8 + _Registro._SumaR
                _Registro._SumaR = _Registro._Fecha8

                If _Registro._Fecha8 > 0 Then
                    _Registro._SumaR = 0
                End If

                If _Registro._Fecha8 < 0 Then
                    _Registro._Fecha8 = 0
                End If

            End If

            If _Registro._Fecha7 <> 0 Then

                _Registro._Fecha7 = _Registro._Fecha7 + _Registro._SumaR
                _Registro._SumaR = _Registro._Fecha7

                If _Registro._Fecha7 > 0 Then
                    _Registro._SumaR = 0
                End If

                If _Registro._Fecha7 < 0 Then
                    _Registro._Fecha7 = 0
                End If
            End If


            Dim sumt As Decimal = 0
            While _Registro._SumaR < 0

                sumt = (_Registro._Fecha29 + _Registro._Fecha22 + _Registro._Fecha15 + _Registro._Fecha8 + _Registro._Fecha7)
                If sumt = 0 Then
                    _Registro._Fecha29 = _Registro._SumaR
                    _Registro._SumaR = 0

                End If
                If sumt <> 0 Then

                    If _Registro._Fecha29 <> 0 Then

                        _Registro._Fecha29 = _Registro._Fecha29 + _Registro._SumaR
                        _Registro._SumaR = _Registro._Fecha29

                        If _Registro._Fecha29 > 0 Then
                            _Registro._SumaR = 0
                        End If

                        If _Registro._Fecha29 < 0 Then
                            _Registro._Fecha29 = 0
                        End If
                    End If

                    If _Registro._Fecha22 <> 0 Then

                        _Registro._Fecha22 = _Registro._Fecha22 + _Registro._SumaR
                        _Registro._SumaR = _Registro._Fecha22

                        If _Registro._Fecha22 > 0 Then
                            _Registro._SumaR = 0
                        End If

                        If _Registro._Fecha22 < 0 Then
                            _Registro._Fecha22 = 0
                        End If

                    End If

                    If _Registro._Fecha15 <> 0 Then

                        _Registro._Fecha15 = _Registro._Fecha15 + _Registro._SumaR
                        _Registro._SumaR = _Registro._Fecha15

                        If _Registro._Fecha15 > 0 Then
                            _Registro._SumaR = 0
                        End If


                        If _Registro._Fecha15 < 0 Then
                            _Registro._Fecha15 = 0
                        End If

                    End If

                    If _Registro._Fecha8 <> 0 Then

                        _Registro._Fecha8 = _Registro._Fecha8 + _Registro._SumaR
                        _Registro._SumaR = _Registro._Fecha8

                        If _Registro._Fecha8 > 0 Then
                            _Registro._SumaR = 0
                        End If


                        If _Registro._Fecha8 < 0 Then
                            _Registro._Fecha8 = 0
                        End If

                    End If


                    If _Registro._Fecha7 <> 0 Then

                        _Registro._Fecha7 = _Registro._Fecha7 + _Registro._SumaR
                        _Registro._SumaR = _Registro._Fecha7

                        If _Registro._Fecha7 > 0 Then
                            _Registro._SumaR = 0
                        End If


                        If _Registro._Fecha7 < 0 Then
                            _Registro._Fecha7 = 0
                        End If
                    End If
                End If


                'con = con + 1
            End While
            _Registro._Balance = (_Registro._Fecha29 + _Registro._Fecha22 + _Registro._Fecha15 + _Registro._Fecha8 + _Registro._Fecha7 + _Registro._SemanaCurso)

            'If _Registro._Fecha29 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per29), Convert.ToDateTime(_Registro._FechaActual))
            'ElseIf _Registro._Fecha22 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per22), Convert.ToDateTime(_Registro._FechaActual))
            'ElseIf _Registro._Fecha15 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per15), Convert.ToDateTime(_Registro._FechaActual))
            'ElseIf _Registro._Fecha8 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per8), Convert.ToDateTime(_Registro._FechaActual))
            'ElseIf _Registro._Fecha7 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per7), Convert.ToDateTime(_Registro._FechaActual))

            'End If

            ' MsgBox(_Registro._dias.ToString)
            '2
            ' Dim con As Integer = 0 

            If _Registro._Balance < 0 Then
            Else
                _Antiguedad.Add(_Registro)
            End If

        End While
        _Leer.Close()
        Desconetado()
        Return _Antiguedad
    End Function
    Public Function AntCXC(vcurso As Boolean, Fi As String, Ff As String) As List(Of Eantiguedadsaldogestor)
        Conectado()

        Dim _Antiguedad As New List(Of Eantiguedadsaldogestor)
        _Cmd = New SqlCommand("[ANTIGUEDAD_CXC]")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.CommandTimeout = 1000000
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@fecha_ini", SqlDbType.VarChar, 15).Value = Fi
        _Cmd.Parameters.Add("@fecha_fin", SqlDbType.VarChar, 15).Value = Ff

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Registro As New Eantiguedadsaldogestor
            _Registro._Agente = _Leer("RETAILER").ToString
            If vcurso = True Then
                _Registro._SemanaCurso = _Leer("VENTA_EN_CURSO")
            Else
                _Registro._SemanaCurso = 0
            End If

            _Registro._telefono1 = _Leer("TELEFONO")
            _Registro._cxc = _Leer("ANTIGUEDAD")
            _Registro._nombre = _Leer("NOMBRE")
            _Registro._Balance = _Leer("BALANCE")
            _Registro._gestor = _Leer("GESTOR")
            _Registro._estdata = _Leer("ESTADO")
            _Registro.OTROS_BANCOS = _Leer("otros_bancos")
            _Registro.AJUSTES = _Leer("ajustes")

            _Registro._FI = Fi
            _Registro._FF = Ff

            _Antiguedad.Add(_Registro)

        End While
        _Leer.Close()
        Desconetado()
        Return _Antiguedad
    End Function

    Public Function AntCXCGestor(vcurso As Boolean, Fi As String, Ff As String) As List(Of Eantiguedadsaldogestor)
        Conectado()

        Dim _Antiguedad As New List(Of Eantiguedadsaldogestor)
        _Cmd = New SqlCommand("[ANTIGUEDAD_CXC]")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.CommandTimeout = 1000000
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@fecha_fin", SqlDbType.VarChar, 15).Value = Ff
        _Cmd.Parameters.Add("@fecha_ini", SqlDbType.VarChar, 15).Value = Fi
        Dim T_VC_ACTIVA As Decimal = 0
        Dim T_VC_BLOQUEADA As Decimal = 0
        Dim T_VC_RETIRADA As Decimal = 0
        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Registro As New Eantiguedadsaldogestor
            _Registro._Agente = _Leer("RETAILER").ToString
            If vcurso = True Then
                _Registro._SemanaCurso = _Leer("VENTA_EN_CURSO")
                _Registro._Balance = _Leer("BALANCE")
            Else
                _Registro._SemanaCurso = 0
                _Registro._Balance = _Leer("BALANCE") - _Leer("VENTA_EN_CURSO")
            End If


            _Registro._telefono1 = _Leer("TELEFONO")
            _Registro._cxc = _Leer("ANTIGUEDAD") - _Leer("ajustes")
            _Registro._nombre = _Leer("NOMBRE")

            _Registro._gestor = _Leer("GESTOR")
            _Registro._estdata = _Leer("ESTADO")

            If _Leer("ESTADO") = "RETIRADA" Then
                T_VC_RETIRADA += _Leer("VENTA_EN_CURSO")
            End If

            If _Leer("ESTADO") = "BLOQUEADA" Then
                T_VC_BLOQUEADA += _Leer("VENTA_EN_CURSO")
            End If

            If _Leer("ESTADO") = "ACTIVA" Then
                T_VC_ACTIVA += _Leer("ANTIGUEDAD")
            End If
            '_Registro.T_CXC_RETIRADA = _Leer("T_CXC_RETIRADA")
            '_Registro.T_CXC_BLOQUEADA = _Leer("T_CXC_BLOQUEADA")
            '_Registro.T_CXC_ACTIVA = _Leer("T_CXC_ACTIVA")


            '_Registro.T_VC_RETIRADA = _Leer("T_VC_RETIRADA")
            '_Registro.T_VC_BLOQUEADA = _Leer("T_VC_BLOQUEADA")
            '_Registro.T_VC_ACTIVA = _Leer("T_VC_ACTIVA")

            _Registro._FI = Fi
            _Registro._FF = Ff

            _Registro.T_VC_RETIRADA = T_VC_RETIRADA
            _Registro.T_VC_BLOQUEADA = T_VC_BLOQUEADA
            _Registro.T_VC_ACTIVA = T_VC_ACTIVA

            _Antiguedad.Add(_Registro)

        End While

        _Leer.Close()
        Desconetado()
        Return _Antiguedad
    End Function

    Public Sub ActualizarVentasCursoCXC(Fi As String, Ff As String)
        Conectado()


        _Cmd = New SqlCommand("[CALCULO_VENTAS_CURSO]")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.CommandTimeout = 1000000
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@fecini", SqlDbType.VarChar, 15).Value = Fi
        _Cmd.Parameters.Add("@fecfin", SqlDbType.VarChar, 15).Value = Ff

        _Cmd.ExecuteNonQuery()

    End Sub


    Public Function AntiguedaContabilidad(Fi As String, Ff As String) As List(Of Eantiguedadsaldogestor)
        Conectado()

        Dim _Antiguedad As New List(Of Eantiguedadsaldogestor)
        _Cmd = New SqlCommand("[ANTIGUEDAD_GESTOR_CONTABILIDAD]")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = Fi
        _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = Ff

        '_Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = TranformarFecha(_FechaInicial)
        '_Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = TranformarFecha(_FechaFinal)
        'M/d/yyyy H:mm
        ' Dim f As Long = DateDiff(DateInterval.Day, Convert.ToDateTime("20/10/2017"), Convert.ToDateTime("23/10/2017"))
        ' MsgBox(f)

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Registro As New Eantiguedadsaldogestor
            _Registro._Agente = _Leer("agente").ToString
            _Registro._SemanaCurso = _Leer("venta_curso")
            _Registro._Fecha7 = _Leer("de_1_7")
            _Registro._Fecha8 = _Leer("de_8_14")
            _Registro._Fecha15 = _Leer("de_15_21")
            _Registro._Fecha22 = _Leer("de_22_28")
            _Registro._Fecha29 = _Leer("de_29_mas")
            _Registro._Balance = _Leer("balance")
            _Registro._nombre = _Leer("nombre")
            _Registro._bloqueada = _Leer("bloqueada")
            _Registro._telefono1 = _Leer("telefono1")
            _Registro._SumaR = _Leer("sumaR")
            _Registro._estdata = _Leer("estdata")
            _Registro._FechaActual = _Leer("fechaActual")
            _Registro._per7 = _Leer("per7")
            _Registro._per8 = _Leer("per8")
            _Registro._per15 = _Leer("per15")
            _Registro._per22 = _Leer("per22")
            _Registro._per29 = _Leer("per29")
            _Registro._gestor = _Leer("gestor")
            _Registro._codges = _Leer("codges")

            _Registro._FI = Fi
            _Registro._FF = Ff
            '_Registro._AntDia = _Leer("_AntDia")



            '  MsgBox(" " + _Registro._per29)


            If _Registro._bloqueada = 0 Then
                _Registro._bloqueada = "Activa"
            Else
                _Registro._bloqueada = "Bloqueada"
            End If
            'If _Registro._Fecha29 <> 0 Then

            '    _Registro._Fecha29 = _Registro._Fecha29 + _Registro._SumaR
            '    _Registro._SumaR = _Registro._Fecha29
            '    If _Registro._Fecha29 > 0 Then
            '        _Registro._SumaR = 0
            '    End If

            '    If _Registro._Fecha29 < 0 Then
            '        _Registro._Fecha29 = 0
            '    End If
            'End If

            'If _Registro._Fecha22 <> 0 Then

            '    _Registro._Fecha22 = _Registro._Fecha22 + _Registro._SumaR
            '    _Registro._SumaR = _Registro._Fecha22

            '    If _Registro._Fecha22 > 0 Then
            '        _Registro._SumaR = 0
            '    End If

            '    If _Registro._Fecha22 < 0 Then
            '        _Registro._Fecha22 = 0
            '    End If

            'End If

            'If _Registro._Fecha15 <> 0 Then

            '    _Registro._Fecha15 = _Registro._Fecha15 + _Registro._SumaR
            '    _Registro._SumaR = _Registro._Fecha15

            '    If _Registro._Fecha15 > 0 Then
            '        _Registro._SumaR = 0
            '    End If

            '    If _Registro._Fecha15 < 0 Then
            '        _Registro._Fecha15 = 0
            '    End If

            'End If

            'If _Registro._Fecha8 <> 0 Then

            '    _Registro._Fecha8 = _Registro._Fecha8 + _Registro._SumaR
            '    _Registro._SumaR = _Registro._Fecha8

            '    If _Registro._Fecha8 > 0 Then
            '        _Registro._SumaR = 0
            '    End If

            '    If _Registro._Fecha8 < 0 Then
            '        _Registro._Fecha8 = 0
            '    End If

            'End If

            'If _Registro._Fecha7 <> 0 Then

            '    _Registro._Fecha7 = _Registro._Fecha7 + _Registro._SumaR
            '    _Registro._SumaR = _Registro._Fecha7

            '    If _Registro._Fecha7 > 0 Then
            '        _Registro._SumaR = 0
            '    End If

            '    If _Registro._Fecha7 < 0 Then
            '        _Registro._Fecha7 = 0
            '    End If
            'End If


            'Dim sumt As Decimal = 0
            'While _Registro._SumaR < 0

            '    sumt = (_Registro._Fecha29 + _Registro._Fecha22 + _Registro._Fecha15 + _Registro._Fecha8 + _Registro._Fecha7)
            '    If sumt = 0 Then
            '        _Registro._Fecha29 = _Registro._SumaR
            '        _Registro._SumaR = 0

            '    End If
            '    If sumt <> 0 Then

            '        If _Registro._Fecha29 <> 0 Then

            '            _Registro._Fecha29 = _Registro._Fecha29 + _Registro._SumaR
            '            _Registro._SumaR = _Registro._Fecha29

            '            If _Registro._Fecha29 > 0 Then
            '                _Registro._SumaR = 0
            '            End If

            '            If _Registro._Fecha29 < 0 Then
            '                _Registro._Fecha29 = 0
            '            End If
            '        End If

            '        If _Registro._Fecha22 <> 0 Then

            '            _Registro._Fecha22 = _Registro._Fecha22 + _Registro._SumaR
            '            _Registro._SumaR = _Registro._Fecha22

            '            If _Registro._Fecha22 > 0 Then
            '                _Registro._SumaR = 0
            '            End If

            '            If _Registro._Fecha22 < 0 Then
            '                _Registro._Fecha22 = 0
            '            End If

            '        End If

            '        If _Registro._Fecha15 <> 0 Then

            '            _Registro._Fecha15 = _Registro._Fecha15 + _Registro._SumaR
            '            _Registro._SumaR = _Registro._Fecha15

            '            If _Registro._Fecha15 > 0 Then
            '                _Registro._SumaR = 0
            '            End If


            '            If _Registro._Fecha15 < 0 Then
            '                _Registro._Fecha15 = 0
            '            End If

            '        End If

            '        If _Registro._Fecha8 <> 0 Then

            '            _Registro._Fecha8 = _Registro._Fecha8 + _Registro._SumaR
            '            _Registro._SumaR = _Registro._Fecha8

            '            If _Registro._Fecha8 > 0 Then
            '                _Registro._SumaR = 0
            '            End If


            '            If _Registro._Fecha8 < 0 Then
            '                _Registro._Fecha8 = 0
            '            End If

            '        End If


            '        If _Registro._Fecha7 <> 0 Then

            '            _Registro._Fecha7 = _Registro._Fecha7 + _Registro._SumaR
            '            _Registro._SumaR = _Registro._Fecha7

            '            If _Registro._Fecha7 > 0 Then
            '                _Registro._SumaR = 0
            '            End If


            '            If _Registro._Fecha7 < 0 Then
            '                _Registro._Fecha7 = 0
            '            End If
            '        End If
            '    End If


            '    'con = con + 1
            'End While
            _Registro._Balance = (_Registro._Fecha29 + _Registro._Fecha22 + _Registro._Fecha15 + _Registro._Fecha8 + _Registro._Fecha7)

            'If _Registro._Fecha29 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per29), Convert.ToDateTime(_Registro._FechaActual))
            'ElseIf _Registro._Fecha22 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per22), Convert.ToDateTime(_Registro._FechaActual))
            'ElseIf _Registro._Fecha15 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per15), Convert.ToDateTime(_Registro._FechaActual))
            'ElseIf _Registro._Fecha8 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per8), Convert.ToDateTime(_Registro._FechaActual))
            'ElseIf _Registro._Fecha7 <> 0 Then
            '    _Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per7), Convert.ToDateTime(_Registro._FechaActual))

            'End If

            ' MsgBox(_Registro._dias.ToString)
            '2
            ' Dim con As Integer = 0 

            If _Registro._Balance < 0 Then
            Else
                _Antiguedad.Add(_Registro)
            End If

        End While
        _Leer.Close()
        Desconetado()
        Return _Antiguedad
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

End Class
