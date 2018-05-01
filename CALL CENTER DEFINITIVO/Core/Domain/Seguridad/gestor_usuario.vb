Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class gestor_usuario
        Inherits DomainObject(Of String)
        Dim _codusu As String
        Dim _codges As String


        Public Property codusu() As String
            Get
                Return _codusu
            End Get
            Set(ByVal value As String)
                _codusu = value
            End Set
        End Property

        Public Property codges() As String
            Get
                Return _codges
            End Get
            Set(ByVal value As String)
                _codges = value
            End Set
        End Property

    End Class


End Namespace