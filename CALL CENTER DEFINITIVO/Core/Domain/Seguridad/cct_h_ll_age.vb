Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_h_ll_age
        Inherits DomainObject(Of String)
        Dim _AGENTE As String
        Dim _DESCRIPCION As String
        Dim _FECHA As String
        Dim _HORA As String
        Dim _HORA_FIN As String
        Dim _TK_ABIERTOS As Integer
        Dim _TK_CERRADOS As Integer
        Dim _POR_REVISAR As Integer
        Dim _REVISADOS As Integer
        Dim _USUARIO As String
        Dim _TIKCETS As String
        Dim _TIPO_CONTACTO As String
        Dim _CONTACTO As String
        Dim _FEC_TK_A As String
        Dim _FEC_TK_VER As String
        Public Property AGENTE() As String
            Get
                Return _AGENTE
            End Get
            Set(value As String)
                _AGENTE = value
            End Set
        End Property
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Public Property FECHA() As String
            Get
                Return _FECHA
            End Get
            Set(value As String)
                _FECHA = value
            End Set
        End Property
        Public Property HORA() As String
            Get
                Return _HORA
            End Get
            Set(value As String)
                _HORA = value
            End Set
        End Property
        Public Property HORA_FIN() As String
            Get
                Return _HORA_FIN
            End Get
            Set(value As String)
                _HORA_FIN = value
            End Set
        End Property
        Public Property TK_ABIERTOS() As Integer
            Get
                Return _TK_ABIERTOS
            End Get
            Set(value As Integer)
                _TK_ABIERTOS = value
            End Set
        End Property
        Public Property TK_CERRADOS() As Integer
            Get
                Return _TK_CERRADOS
            End Get
            Set(value As Integer)
                _TK_CERRADOS = value
            End Set
        End Property
        Public Property POR_REVISAR() As Integer
            Get
                Return _POR_REVISAR
            End Get
            Set(value As Integer)
                _POR_REVISAR = value
            End Set
        End Property
        Public Property REVISADOS() As Integer
            Get
                Return _REVISADOS
            End Get
            Set(value As Integer)
                _REVISADOS = value
            End Set
        End Property
        Public Property USUARIO() As String
            Get
                Return _USUARIO
            End Get
            Set(value As String)
                _USUARIO = value
            End Set
        End Property
        Public Property TIKCETS() As String
            Get
                Return _TIKCETS
            End Get
            Set(value As String)
                _TIKCETS = value
            End Set
        End Property
        Public Property TIPO_CONTACTO() As String
            Get
                Return _TIPO_CONTACTO
            End Get
            Set(value As String)
                _TIPO_CONTACTO = value
            End Set
        End Property
        Public Property CONTACTO() As String
            Get
                Return _CONTACTO
            End Get
            Set(value As String)
                _CONTACTO = value
            End Set
        End Property
        Public Property FEC_TK_A() As String
            Get
                Return _FEC_TK_A
            End Get
            Set(value As String)
                _FEC_TK_A = value
            End Set
        End Property
        Public Property FEC_TK_VER() As String
            Get
                Return _FEC_TK_VER
            End Get
            Set(value As String)
                _FEC_TK_VER = value
            End Set
        End Property
    End Class
End Namespace
