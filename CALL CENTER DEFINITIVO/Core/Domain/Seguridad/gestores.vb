Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class gestores
        Inherits DomainObject(Of String)
        Dim _nomges As String
        Dim _telges As String


        Public Property nomges() As String
            Get
                Return _nomges
            End Get
            Set(ByVal value As String)
                _nomges = value
            End Set
        End Property

        Public Property telges() As String 'Hace referencia al codusu de la tabla usuario
            Get
                Return _telges
            End Get
            Set(ByVal value As String)
                _telges = value
            End Set
        End Property


    End Class


End Namespace


