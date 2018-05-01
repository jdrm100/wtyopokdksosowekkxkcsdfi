Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad
    Public Class promesa_pag
        Inherits DomainObject(Of String)
        Dim _codage As String
        Dim _fecha As String
        Dim _codges As String
        Public Property codage() As String
            Get
                Return _codage
            End Get
            Set(value As String)
                _codage = value
            End Set
        End Property

        Public Property fecha() As String
            Get
                Return _fecha
            End Get
            Set(value As String)
                _fecha = value
            End Set
        End Property
        Public Property codges() As String
            Get
                Return _codges
            End Get
            Set(value As String)
                _codges = value
            End Set
        End Property
    End Class

End Namespace

