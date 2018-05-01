Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad
    Public Class usu_llamadas
        Inherits DomainObject(Of String)

        Dim _fecha As String
        Dim _cant As Integer
        Public Property fecha() As String
            Get
                Return _fecha
            End Get
            Set(value As String)
                _fecha = value
            End Set
        End Property

        Public Property cant() As String
            Get
                Return _cant
            End Get
            Set(value As String)
                _cant = value
            End Set
        End Property

    End Class


End Namespace

