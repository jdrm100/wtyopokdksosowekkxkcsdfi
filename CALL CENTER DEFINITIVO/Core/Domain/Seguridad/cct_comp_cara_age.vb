Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_comp_cara_age
        Inherits DomainObject(Of String)
        Dim _DESCRIPCION As String
        Dim _AGENTE As String
        Dim _FEC As String
        Dim _FEC_UPDATE As String
        Dim _CODUSU_UPDATE As String
        Dim _SERIAL1 As String
        Dim _SERIAL2 As String
        Dim _S1 As Integer
        Dim _OBL_S1 As Integer
        Dim _S2 As Integer
        Dim _OBL_S2 As Integer

        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Public Property AGENTE() As String
            Get
                Return _AGENTE
            End Get
            Set(ByVal value As String)
                _AGENTE = value
            End Set
        End Property
        Public Property FEC() As String
            Get
                Return _FEC
            End Get
            Set(ByVal value As String)
                _FEC = value
            End Set
        End Property
        Public Property FEC_UPDATE() As String
            Get
                Return _FEC_UPDATE
            End Get
            Set(ByVal value As String)
                _FEC_UPDATE = value
            End Set
        End Property
        Public Property CODUSU_UPDATE() As String
            Get
                Return _CODUSU_UPDATE
            End Get
            Set(ByVal value As String)
                _CODUSU_UPDATE = value
            End Set
        End Property
        Public Property SERIAL1() As String
            Get
                Return _SERIAL1
            End Get
            Set(ByVal value As String)
                _SERIAL1 = value
            End Set
        End Property
        Public Property SERIAL2() As String
            Get
                Return _SERIAL2
            End Get
            Set(ByVal value As String)
                _SERIAL2 = value
            End Set
        End Property
        Public Property S1() As Integer
            Get
                Return _S1
            End Get
            Set(ByVal value As Integer)
                _S1 = value
            End Set
        End Property
        Public Property OBL_S1() As Integer
            Get
                Return _OBL_S1
            End Get
            Set(ByVal value As Integer)
                _OBL_S1 = value
            End Set
        End Property
        Public Property S2() As Integer
            Get
                Return _S2
            End Get
            Set(ByVal value As Integer)
                _S2 = value
            End Set
        End Property
        Public Property OBL_S2() As Integer
            Get
                Return _OBL_S2
            End Get
            Set(ByVal value As Integer)
                _OBL_S2 = value
            End Set
        End Property
    End Class
End Namespace