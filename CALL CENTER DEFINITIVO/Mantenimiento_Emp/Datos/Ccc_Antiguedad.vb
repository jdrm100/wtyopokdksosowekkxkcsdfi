Imports System.Data.SqlClient

Public Class Ccc_Antiguedad
    Inherits Conexion
    Dim _Cmd As New SqlCommand

    Public Function AntiguedaddeSaldo(Fi As String, Ff As String, tipo As String, representante As String) As List(Of Eantiguedadsaldo)
        Conectado()

        Dim _Antiguedad As New List(Of Eantiguedadsaldo)
        _Cmd = New SqlCommand("ANTIGUEDAD_REPORTE")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn
        _Cmd.Parameters.Add("@Representante", SqlDbType.VarChar, 250).Value = representante
        If tipo = "unRepresentante" Then
            _Cmd.Parameters.Add("@Tipo", SqlDbType.VarChar, 50).Value = "representante"
        End If
        If tipo = "Todos" Then
            _Cmd.Parameters.Add("@Tipo", SqlDbType.VarChar, 50).Value = "todosRepresentantes"
        End If

        _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = Fi
        _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = Ff

        '_Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = TranformarFecha(_FechaInicial)
        '_Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = TranformarFecha(_FechaFinal)
        'M/d/yyyy H:mm
        ' Dim f As Long = DateDiff(DateInterval.Day, Convert.ToDateTime("20/10/2017"), Convert.ToDateTime("23/10/2017"))
        '  MsgBox(f)

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Registro As New Eantiguedadsaldo
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
            _Registro._Representante = _Leer("representante")
            _Registro._AntDia = _Leer("antdia")

            _Registro._FI = Fi
            _Registro._FF = Ff

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
            '_Registro._dias = DateDiff(DateInterval.Day, Convert.ToDateTime(_Registro._per7), Convert.ToDateTime(_Registro._FechaActual))

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
