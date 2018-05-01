Imports System.Data.SqlClient

Public Class CccAntiguedadDetalladovb
    Inherits Conexion
    Dim _Cmd As New SqlCommand
    Public Function GetRepresentantes() As DataTable
        Conectado()
        Dim DA As New SqlDataAdapter
        Dim DT As New DataTable
        DA = New SqlDataAdapter("select codemp as ruta, convert(varchar,codemp)+'-'+nomemp+' '+apeemp as nombre from  empleado", _cnn)
        DA.Fill(DT)
        Desconetado()
        Return DT
    End Function


    Public Function AntiguedadDetallado(Fi As String, Ff As String, Agente As Integer) As List(Of Eestadocuenta)
        Conectado()

        Dim _EstadoCuenta As New List(Of Eestadocuenta)
        _Cmd = New SqlCommand("[ANTIGUEDAD_DETALLADO]")
        _Cmd.CommandType = CommandType.StoredProcedure
        _Cmd.Connection = _cnn

        _Cmd.Parameters.Add("@FechaInicial", SqlDbType.VarChar, 50).Value = Fi
        _Cmd.Parameters.Add("@FechaFinal", SqlDbType.VarChar, 50).Value = Ff
        _Cmd.Parameters.Add("@Agente", SqlDbType.Int).Value = Agente


        'M/d/yyyy H:mm
        ' Dim f As Long = DateDiff(DateInterval.Day, Convert.ToDateTime("20/10/2017"), Convert.ToDateTime("23/10/2017"))
        ' MsgBox(f)

        Dim _Leer As SqlDataReader = _Cmd.ExecuteReader
        While _Leer.Read
            Dim _Registro As New Eestadocuenta
            _Registro._Agente = _Leer("AGENTE")
            _Registro._Monto = _Leer("MONTO")
            _Registro._Fecha = _Leer("FECHA").ToString
            _Registro._Periodo = _Leer("PERIODO")
            _Registro._Entidad = _Leer("ENTIDAD") 
            _Registro._Documento = _Leer("DOCUMENTO")
            _Registro._Balance = _Leer("BALANCE")
            _Registro._gestor = _Leer("gestor")
            _Registro._Tipo = _Leer("tipo")
            If _Registro._Tipo = "FAC" Then
                _Registro._Tipo = "FACTURA"
            End If
            If _Registro._Tipo = "DEP" Then
                _Registro._Tipo = "DEPOSITO"
            End If
            If _Registro._Tipo = "MOV" Then
                _Registro._Tipo = "MOVIMIENTO"
            End If
            If _Registro._Tipo = "RE-" Then
                _Registro._Tipo = "REEMBOLSO"
            End If
            If _Registro._Tipo = "COM" Then
                _Registro._Tipo = "COMISION"
            End If



            _Registro._Efecto = _Leer("Efecto")
            _Registro._representante = _Leer("representante")
            _Registro._FI = Fi
            _Registro._FF = Ff

            _EstadoCuenta.Add(_Registro)
        End While
        _Leer.Close()
        Desconetado()
        Return _EstadoCuenta
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

