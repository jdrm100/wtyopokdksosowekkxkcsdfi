

Imports System.Data.SqlClient
Imports Core.Domain.Seguridad

Public Class Ccc_FiltroAgentesCobros
    Inherits Conexion
    Dim _Cmd As SqlCommand


    Public Function GetLlamadasHoy(codusu As String) As String
        Conectado()

        Dim datos As String = ""
        _Cmd = New SqlCommand("select count(*) as hoy from CCC_LLAMADAS where convert(date,fecha) = convert(date,getdate()) and CODUSU = " & codusu & " ", _cnn)
      

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read 
            datos = _Leer("hoy")
        End While
        
        Desconetado()

        Return datos

    End Function

    Public Function GetGestorLogueado(codusu As String) As List(Of Egestor)
        Conectado()
        Dim list_ges As New List(Of Egestor)

        _Cmd = New SqlCommand("SELECT  gu.codges, g.nomges FROM [lrc_r4].[dbo].[gestor_usuario] gu LEFT JOIN gestor g on g.codges = gu.codges  where codusu =  " & codusu & " ", _cnn)


        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim datos As New Egestor
            datos.codges = _Leer("codges")
            datos.nomges = _Leer("nomges")

            list_ges.Add(datos)
        End While

        Desconetado()

        Return list_ges

    End Function

    Public Function GetByCodgtech(agente As String, bloq As String, gestor As String, ejecutivo As String, fec_prom As String, bala As String, clasi As String) As List(Of Eagentes)
        Try

            Conectado()

            ' @Bloqueadas varchar(10),@Gestor varchar(10),@Ejecutivo varchar(10), @Fec_prom varchar(15),@BalTemp varchar(50) 
            Dim _AgenList As New List(Of Eagentes)
            _Cmd = New SqlCommand("SELECT_CCC_LISTA_AGES")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.Connection = _cnn

            ''MsgBox("bloq: " & bloq & "gestor: " & gestor & " ejecutivo: " & ejecutivo & " fec_prom: " & fec_prom & " bala: " & bala)
            If bala = "" Then
                bala = "0"
            End If

            If bloq = "" Then
                bloq = "0"
            End If



            _Cmd.Parameters.Add("@Agente", SqlDbType.VarChar, 250).Value = agente
            _Cmd.Parameters.Add("@Bloqueadas", SqlDbType.VarChar, 10).Value = bloq
            _Cmd.Parameters.Add("@Gestor", SqlDbType.VarChar, 10).Value = gestor
            _Cmd.Parameters.Add("@Ejecutivo", SqlDbType.VarChar, 10).Value = ejecutivo
            _Cmd.Parameters.Add("@BalTemp", SqlDbType.VarChar, 50).Value = bala
            _Cmd.Parameters.Add("@Class", SqlDbType.VarChar, 10).Value = clasi



            Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

            While _Leer.Read
                Dim _Registro As New Eagentes
                If _Leer("codgtech") IsNot DBNull.Value Then
                    _Registro._Agente = _Leer("codgtech").ToString
                End If


                If _Leer("nombre") IsNot DBNull.Value Then
                    _Registro._Nombre = _Leer("nombre").ToString
                End If

                If _Leer("ejecutivo") IsNot DBNull.Value Then
                    _Registro._Ejecutivo = _Leer("ejecutivo").ToString
                End If


                If _Leer("codasi") IsNot DBNull.Value Then
                    _Registro._Ruta = _Leer("codasi").ToString
                End If


                If _Leer("retirada") IsNot DBNull.Value Then
                    _Registro._Retirada = _Leer("retirada").ToString
                End If

                If _Leer("bloqueada") IsNot DBNull.Value Then
                    _Registro._Bloq = _Leer("bloqueada").ToString
                End If


                If _Leer("class") IsNot DBNull.Value Then
                    _Registro._Clasif = _Leer("class").ToString
                End If

                If _Leer("class") IsNot DBNull.Value Then
                    _Registro._Clasif = _Leer("class").ToString
                End If

                If _Leer("baldia") IsNot DBNull.Value Then
                    _Registro._Baldia = _Leer("baldia").ToString
                End If

                If _Leer("balance_temp") IsNot DBNull.Value Then
                    _Registro._balTemp = _Leer("balance_temp").ToString
                End If

                If _Leer("nomrep") IsNot DBNull.Value Then
                    _Registro._NomRep = _Leer("nomrep").ToString
                End If

                If _Leer("ciudad") IsNot DBNull.Value Then
                    _Registro._Ciudad = _Leer("ciudad").ToString
                End If

                If _Leer("cedrep") IsNot DBNull.Value Then
                    _Registro._Cedula = _Leer("cedrep").ToString
                End If

                If _Leer("telefono1") IsNot DBNull.Value Then
                    _Registro._Tel1 = _Leer("telefono1").ToString
                End If

                If _Leer("telefono2") IsNot DBNull.Value Then
                    _Registro._Tel2 = _Leer("telefono2").ToString
                End If

                If _Leer("telcon1") IsNot DBNull.Value Then
                    _Registro._Telcon1 = _Leer("telcon1").ToString
                End If

                If _Leer("telcon2") IsNot DBNull.Value Then
                    _Registro._Telcon2 = _Leer("telcon2").ToString
                End If

                If _Leer("fax") IsNot DBNull.Value Then
                    _Registro._Fax = _Leer("fax").ToString
                End If

                If _Leer("email") IsNot DBNull.Value Then
                    _Registro._Email = _Leer("email").ToString
                End If

                If _Leer("cx") IsNot DBNull.Value Then
                    _Registro._Cx = _Leer("cx").ToString
                End If

                If _Leer("cy") IsNot DBNull.Value Then
                    _Registro._Cy = _Leer("cy").ToString
                End If

                If _Leer("direccion") IsNot DBNull.Value Then
                    _Registro._Dir = _Leer("direccion").ToString
                End If

                If _Leer("descpro") IsNot DBNull.Value Then
                    _Registro._Provincia = _Leer("descpro").ToString
                End If

                If _Leer("desmun") IsNot DBNull.Value Then
                    _Registro._Municipio = _Leer("desmun").ToString
                End If

                If _Leer("dessec") IsNot DBNull.Value Then
                    _Registro._Sector = _Leer("dessec").ToString
                End If

                If _Leer("nomges") IsNot DBNull.Value Then
                    _Registro._Gestor = _Leer("nomges").ToString
                End If



                _AgenList.Add(_Registro)

            End While

            Return _AgenList



        Catch ex As Exception
            Throw New Exception("Error en consulta de agentes", ex)
        End Try
    End Function

    Public Function GetEjeByGestor(gestor As String) As List(Of Eempleado)
        Try
            Conectado()
            Dim _EjeList As New List(Of Eempleado)
            _Cmd = New SqlCommand("CCC_SELECT_EJECUTIVO_POR_GESTOR")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.Connection = _cnn
            _Cmd.Parameters.Add("@gestor", SqlDbType.VarChar, 8).Value = gestor
            Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

            While _Leer.Read
                Dim _Registro As New Eempleado
                _Registro.codasi = _Leer("codasi").ToString
                _Registro.nomemp = _Leer("nomemp").ToString
                _Registro.nomemp = _Leer("apeemp").ToString

                _EjeList.Add(_Registro)

            End While

            Return _EjeList



        Catch ex As Exception
            Throw New Exception("Error en consulta de agentes", ex)
        End Try

    End Function
    Public Function GetFacturacion(agente As String) As List(Of Eagentes)
        Try
            Conectado()
            Dim _AgenList As New List(Of Eagentes)
            _Cmd = New SqlCommand("SelectInfFinAge")
            _Cmd.CommandType = CommandType.StoredProcedure
            _Cmd.Connection = _cnn
            _Cmd.Parameters.Add("@age", SqlDbType.VarChar, 8).Value = agente
            Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

            While _Leer.Read
                Dim _Registro As New Eagentes
                _Registro._Agente = _Leer("AGENTE")
                _Registro._UltimaFactLRC = _Leer("FacLR")
                _Registro._UltimaFactQJM = _Leer("FacQJM")

                _Registro._BalanceAlDiaLRC = _Leer("BalDiaLR")
                _Registro._Baldia = _Leer("baldia")
                _Registro.BALANCE_CURSO = _Leer("balance_curso")
                _Registro._BalGralQJM = _Leer("BalGralQJM")
                _Registro._BalGralLRC = _Leer("BalGralLR")

                _AgenList.Add(_Registro)

            End While

            Return _AgenList



        Catch ex As Exception
            Throw New Exception("Error en consulta de agentes", ex)
        End Try
    End Function

End Class
