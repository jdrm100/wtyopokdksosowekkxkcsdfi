Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_notas
        Inherits DomainObject(Of String)
        Dim _AGENTE As String
        Dim _FECHA As String
        Dim _HORA As String
        Dim _USUARIO As String
        Dim _NOTA As String
        Dim _AGENDA As String
        Public Property AGENTE() As String
            Get
                Return _AGENTE
            End Get
            Set(value As String)
                _AGENTE = value
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
        Public Property USUARIO() As String
            Get
                Return _USUARIO
            End Get
            Set(value As String)
                _USUARIO = value
            End Set
        End Property

        Public Property NOTA() As String
            Get
                Return _NOTA
            End Get
            Set(value As String)
                _NOTA = value
            End Set
        End Property
        Public Property AGENDA() As String
            Get
                Return _AGENDA
            End Get
            Set(value As String)
                _AGENDA = value
            End Set
        End Property
    End Class
End Namespace
