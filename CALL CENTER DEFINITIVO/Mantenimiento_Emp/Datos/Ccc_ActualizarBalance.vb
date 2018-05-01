Imports System.Data.SqlClient

Public Class Ccc_ActualizarBalance
    Inherits Conexion
    Dim _Cmd As New SqlCommand
    Dim _Cmd2 As New SqlCommand

    Dim _Antiguedad As New List(Of Eantiguedadsaldo)

    Public Function ActualizarBalanceAgentes() As String
        Conectado()


        _Cmd = New SqlCommand("SELECT_ACT_BALANCE_AGE")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn



        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

        Dim UPDATE_QUERY = " update agente set balance_temp =  CASE "
        Dim CASE_UPDATE As String = ""
        Dim IN_UPDATE As String = ""
        Dim con As Integer = 0
        Dim TotalAge = 0
        While _Leer.Read
            Dim _Registro As New Eantiguedadsaldo

            _Registro._Balance = _Leer("BALANCE")
            _Registro._Agente = _Leer("AGENTE")
            _Registro.BALANCE_CURSO = _Leer("BALANCE_CURSO")
            '_Registro._Agente = _Leer("agente")
            '_Registro._SemanaCurso = _Leer("venta_curso")
            '_Registro._Fecha7 = _Leer("de_1_7")
            '_Registro._Fecha8 = _Leer("de_8_14")
            '_Registro._Fecha15 = _Leer("de_15_21")
            '_Registro._Fecha22 = _Leer("de_22_28")
            '_Registro._Fecha29 = _Leer("de_29_mas")
            '_Registro._Balance = _Leer("balance")
            '_Registro._nombre = _Leer("nombre")
            '_Registro._bloqueada = _Leer("bloqueada")
            '_Registro._telefono1 = _Leer("telefono1")
            '_Registro._SumaR = _Leer("sumaR")
            '_Registro._estdata = _Leer("estdata")
            '_Registro._FechaActual = _Leer("fechaActual")
            '_Registro._per7 = _Leer("per7")
            '_Registro._per8 = _Leer("per8")
            '_Registro._per15 = _Leer("per15")
            '_Registro._per22 = _Leer("per22")
            '_Registro._per29 = _Leer("per29")
            '_Registro._AntDia = _Leer("antdia")


            'If _Registro._bloqueada = 0 Then
            '    _Registro._bloqueada = "Activa"
            'Else
            '    _Registro._bloqueada = "Bloqueada"
            'End If
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
            'con += 1


            '_Registro._Balance = (_Registro._Fecha29 + _Registro._Fecha22 + _Registro._Fecha15 + _Registro._Fecha8 + _Registro._Fecha7)


            'CASE_UPDATE += " WHEN codgtech = " & _Registro._Agente & " THEN " & _Registro._Balance
            'IN_UPDATE += _Registro._Agente & ","


            _Antiguedad.Add(_Registro)
        End While
        'IN_UPDATE = Mid(IN_UPDATE, 1, Len(IN_UPDATE) - 1)
        _Leer.Close()

        'MsgBox(age & "," & bal)
        For Each ageBal As Eantiguedadsaldo In _Antiguedad

            Dim _Cmd3 = New SqlCommand("UPDATE_BALANCE_AGENTE")
            _Cmd3.CommandType = CommandType.StoredProcedure
            _Cmd3.Connection = _cnn
            '_Cmd2.CommandText = "exec UPDATE_BALANCE_AGENTE " & Agente & ", " & Balance
            _Cmd3.Parameters.Add("@Agente", SqlDbType.VarChar, 10).Value = ageBal._Agente
            _Cmd3.Parameters.Add("@Balance", SqlDbType.Decimal, 18, 2).Value = ageBal._Balance
            _Cmd3.Parameters.Add("@BALANCE_CURSO", SqlDbType.Decimal, 18, 2).Value = ageBal.BALANCE_CURSO

            'MsgBox(ageBal._Agente & "," & ageBal._Balance)


            '_Cmd2.CommandText = UPDATE_QUERY & CASE_UPDATE & "  END  where codgtech in( " & IN_UPDATE & " ) OPTION (FORCE ORDER)"

            If _Cmd3.ExecuteNonQuery Then
                'MsgBox("¡Se han actualizados todos los balance!")
            End If
        Next ageBal

        Desconetado()

        Return "SE ACTUALIZARON TODOS LOS AGENTES"

    End Function

    Public Sub updateBalan()

       

    End Sub



    Public Sub actBalance(Agente As String, Balance As Decimal)

        Conectado()
        _Cmd2 = New SqlCommand("UPDATE_BALANCE_AGENTE")
        _Cmd2.CommandType = CommandType.StoredProcedure
        _Cmd2.Connection = _cnn
        '' _Cmd2.CommandText = "exec UPDATE_BALANCE_AGENTE " & Agente & ", " & Balance
        _Cmd2.Parameters.Add("@agente", SqlDbType.VarChar).Value = Agente
        _Cmd2.Parameters.Add("@balance", SqlDbType.Decimal).Value = Balance


        ''_Cmd2.CommandText = UPDATE_QUERY & CASE_UPDATE & "  END  where codgtech in( " & IN_UPDATE & " ) OPTION (FORCE ORDER)"

        If _Cmd2.ExecuteNonQuery Then
            ''MsgBox("¡Se han actualizados todos los balance!")
        End If


    End Sub

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

    Private Function agentes() As Object
        Throw New NotImplementedException
    End Function

End Class
