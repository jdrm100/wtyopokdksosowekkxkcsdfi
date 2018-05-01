Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad
    Public Class sol_noblo_tipos
        Inherits DomainObject(Of String)

        Dim _desc_noblo As String
        Dim _fecha As String
        Dim _id_usu As Integer
        Public Property desc_noblo() As String
            Get
                Return _desc_noblo
            End Get
            Set(value As String)
                _desc_noblo = value
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

        Public Property id_usu() As String
            Get
                Return _id_usu
            End Get
            Set(value As String)
                _id_usu = value
            End Set
        End Property
    End Class


End Namespace

