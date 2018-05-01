Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class empleado
        Inherits DomainObject(Of String)
        Dim _nomemp As String
        Dim _apeemp As String


        Public Property nomemp() As String
            Get
                Return _nomemp
            End Get
            Set(ByVal value As String)
                _nomemp = value
            End Set
        End Property

        Public Property apeemp() As String
            Get
                Return _apeemp
            End Get
            Set(ByVal value As String)
                _apeemp = value
            End Set
        End Property

    End Class


End Namespace