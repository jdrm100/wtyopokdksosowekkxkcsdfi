


Imports System.Data.SqlClient
Imports Core.Domain.Seguridad

Public Class Ccc_LlamadasCobros
    Inherits Conexion
    Dim _Cmd As SqlCommand


    Public Function InsertarLlamadaHeader(AGENTE As String, GESTOR As String, CODUSU As String, FECHA As String, H_FIN As String, H_INI As String, ID_TP_LLAMADA As String, NOM_CONT As String, ID_TP_CONT As String, ACTIVO As String) As String

        Conectado()
        Dim ID As String = ""
        _Cmd = New SqlCommand("INSERT_CCC_LLAMADAS_HEADER")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        'Property AGENTE As String
        'Property ID_TP_LLAMADA As String
        'Property CODUSU As String
        'Property ID_TP_CONT As String
        'Property NOM_CONT As String
        'Property FECHA As String
        'Property H_INI As String
        'Property H_FIN As String
        'Property ACTIVO As String

        'MsgBox(
        '            vbNewLine & "  AGENTE: " & AGENTE.ToString &
        '            vbNewLine & " CODUSU: " & CODUSU.ToString &
        '            vbNewLine & " FECHA: " & FECHA.ToString &
        '            vbNewLine & " hf: " & H_FIN.ToString &
        '           vbNewLine & " hi: " & H_INI.ToString &
        '           vbNewLine & " tipo_lla: " & ID_TP_LLAMADA.ToString &
        '           vbNewLine & " contacto: " & NOM_CONT.ToString &
        '            vbNewLine & " icon_tpc: " & ID_TP_CONT.ToString
        '               )


        _Cmd.Parameters.Add("@AGENTE", SqlDbType.VarChar, 8).Value = AGENTE.ToString
        _Cmd.Parameters.Add("@GESTOR", SqlDbType.VarChar, 150).Value = GESTOR.ToString
        _Cmd.Parameters.Add("@CODUSU", SqlDbType.VarChar, 15).Value = CODUSU.ToString
        _Cmd.Parameters.Add("@ID_TP_LLAMADA", SqlDbType.VarChar, 15).Value = ID_TP_LLAMADA.ToString
        _Cmd.Parameters.Add("@ID_TP_CONT", SqlDbType.VarChar, 15).Value = ID_TP_CONT.ToString
        _Cmd.Parameters.Add("@NOM_CONT", SqlDbType.VarChar, 150).Value = NOM_CONT.ToString
        _Cmd.Parameters.Add("@FECHA", SqlDbType.VarChar, 30).Value = FECHA.ToString
        _Cmd.Parameters.Add("@H_INI", SqlDbType.VarChar, 30).Value = H_INI.ToString
        _Cmd.Parameters.Add("@H_FIN", SqlDbType.VarChar, 30).Value = H_FIN.ToString
        _Cmd.Parameters.Add("@ACTIVO", SqlDbType.VarChar, 15).Value = ACTIVO.ToString


        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader

        While _Leer.Read
            ID = _Leer("id").ToString

        End While

        Return ID

    End Function

    Public Sub InsertarLlamadaDetalle(
                                    AGENTE As String,
                                    CODUSU As String,
                                    H_FIN As String,
                                    H_INI As String,
                                    ID_TP_LLAMADA As String,
                                    NOM_CONT As String,
                                    ID_CONT As String,
                                    ID_LLAMADA As String,
                                    ID_MOTIVO As String,
                                    ID_INCIDENCIA As String,
                                    ID_CONCLUSION As String,
                                    NOTA As String
                                              )

        Conectado()
        Dim ID As String = ""
        _Cmd = New SqlCommand("INSERT_CCC_LLAMADAS_DETALLE")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn


        _Cmd.Parameters.Add("@AGENTE", SqlDbType.VarChar, 8).Value = AGENTE.ToString
        _Cmd.Parameters.Add("@CODUSU", SqlDbType.VarChar, 15).Value = CODUSU.ToString
        _Cmd.Parameters.Add("@ID_TP_LLAMADA", SqlDbType.VarChar, 15).Value = ID_TP_LLAMADA.ToString
        _Cmd.Parameters.Add("@ID_CONT", SqlDbType.VarChar, 15).Value = ID_CONT.ToString
        _Cmd.Parameters.Add("@NOM_CONT", SqlDbType.VarChar, 150).Value = NOM_CONT.ToString
        _Cmd.Parameters.Add("@H_INI", SqlDbType.VarChar, 30).Value = H_INI.ToString
        _Cmd.Parameters.Add("@H_FIN", SqlDbType.VarChar, 30).Value = H_FIN.ToString
        _Cmd.Parameters.Add("@ID_LLAMADA", SqlDbType.VarChar, 15).Value = ID_LLAMADA.ToString
        _Cmd.Parameters.Add("@ID_MOTIVO", SqlDbType.VarChar, 15).Value = ID_MOTIVO.ToString
        _Cmd.Parameters.Add("@ID_INCIDENCIA", SqlDbType.VarChar, 15).Value = ID_INCIDENCIA.ToString
        _Cmd.Parameters.Add("@ID_CONCLUSION", SqlDbType.VarChar, 15).Value = ID_CONCLUSION.ToString
        _Cmd.Parameters.Add("@NOTA", SqlDbType.VarChar, 500).Value = NOTA.ToString

        _Cmd.ExecuteNonQuery()



    End Sub

    Public Function CargarMotivos() As List(Of Emotivo)
        Dim list_motivo As New List(Of Emotivo)

        Conectado()
        Dim ID As String = ""
        _Cmd = New SqlCommand("CCC_SELECT_MOTIVOS")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn



        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Datos As New Emotivo
            _Datos.codigo = _Leer("codigo")
            _Datos.descripcion = _Leer("descripcion")

            list_motivo.Add(_Datos)
        End While

        Return list_motivo
    End Function

    Public Function CargarIncidencia(motivo As String) As List(Of Eincidencia)
        Dim list_incidencia As New List(Of Eincidencia)

        Conectado()
        Dim ID As String = ""
        _Cmd = New SqlCommand("CCC_SELECT_INCIDENCIA")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@motivo", SqlDbType.VarChar, 15).Value = motivo

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Datos As New Eincidencia
            _Datos.codigo = _Leer("codigo")
            _Datos.motivo = _Leer("motivo")
            _Datos.descripcion = _Leer("descripcion")

            list_incidencia.Add(_Datos)
        End While

        Return list_incidencia
    End Function

    Public Function CargarConclucion(incidencia As String) As List(Of Econclucion)
        Dim list_conclucion As New List(Of Econclucion)

        Conectado()
        Dim ID As String = ""
        _Cmd = New SqlCommand("CCC_SELECT_CONCLUCION")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@incidencia", SqlDbType.VarChar, 15).Value = incidencia

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Datos As New Econclucion
            _Datos.codigo = _Leer("codigo")
            _Datos.incidencia = _Leer("incidencia")
            _Datos.descripcion = _Leer("descripcion")

            list_conclucion.Add(_Datos)
        End While

        Return list_conclucion
    End Function


    Public Function CargarLLamadaPorAgente(agente As String) As List(Of Ellmada)
        Dim Lista_llamadas As New List(Of Ellmada)

        Conectado()
        Dim ID As String = ""
        _Cmd = New SqlCommand("CCC_SELECT_LLAMADA_AGE")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@agente", SqlDbType.VarChar, 15).Value = agente

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Datos As New Ellmada
            _Datos.AGENTE = _Leer("AGENTE").ToString
            If _Leer("GESTOR") IsNot DBNull.Value Then
                _Datos.GESTOR = _Leer("GESTOR").ToString
            End If 
            _Datos.TIPO_LLAMADA_DESP = _Leer("TIPO_LLAMADA_DESP").ToString
            _Datos.CODUSU = _Leer("CODUSU").ToString
            _Datos.ID_LLAMADA = _Leer("ID_LLAMADA").ToString

            _Datos.FECHA = _Leer("FECHA").ToString
            _Datos.H_FIN = _Leer("H_FIN").ToString
            _Datos.H_INI = _Leer("H_INI").ToString
            _Datos.ID_TP_CONT = _Leer("ID_TP_CONT").ToString
            _Datos.ID_TP_LLAMADA = _Leer("ID_TP_LLAMADA").ToString
            _Datos.NOM_CONT = _Leer("NOM_CONT").ToString
            _Datos.ACTIVO = _Leer("ACTIVO").ToString

            Lista_llamadas.Add(_Datos)
        End While

        Return Lista_llamadas

    End Function



    Public Function CargarLLamadaDetalle(llamada As String) As List(Of ELlamadaDetalle)
        Dim Lista_llamadas As New List(Of ELlamadaDetalle)

        Conectado()
        Dim ID As String = ""
        _Cmd = New SqlCommand("CCC_SELECT_LLAMADA_DETALLE")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@llamada", SqlDbType.VarChar, 15).Value = llamada

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Datos As New ELlamadaDetalle
            _Datos.AGENTE = _Leer("AGENTE").ToString
            _Datos.ID_REG = _Leer("ID_REG").ToString
            _Datos.CODUSU = _Leer("CODUSU").ToString
            _Datos.ID_CONT = _Leer("ID_CONT").ToString
            _Datos.H_FIN = _Leer("H_FIN").ToString
            _Datos.H_INI = _Leer("H_INI").ToString
            _Datos.ID_MOTIVO = _Leer("ID_MOTIVO").ToString
            _Datos.ID_INCIDENCIA = _Leer("ID_INCIDENCIA").ToString
            _Datos.ID_CONCLUSION = _Leer("ID_CONCLUSION").ToString
            _Datos.DES_MOTIVO = _Leer("DES_MOTIVO").ToString
            _Datos.DES_INCIDENCIA = _Leer("DES_INCIDENCIA").ToString
            _Datos.DES_CONCLUSION = _Leer("DES_CONCLUSION").ToString
            _Datos.NOTA = _Leer("NOTA").ToString 
            _Datos.ID_TP_LLAMADA = _Leer("ID_TP_LLAMADA").ToString
            _Datos.ID_LLAMADA = _Leer("ID_LLAMADA").ToString
            _Datos.NOM_CONT = _Leer("NOM_CONT").ToString


            Lista_llamadas.Add(_Datos)
        End While

        Return Lista_llamadas

    End Function





End Class
