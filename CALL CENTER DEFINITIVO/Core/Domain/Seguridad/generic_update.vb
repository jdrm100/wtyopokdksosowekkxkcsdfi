Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class generic_update
        Inherits DomainObject(Of String)
        Dim _descr As String

        Public Property descr() As String
            Get
                Return _descr
            End Get
            Set(ByVal value As String)
                _descr = value
            End Set
        End Property
    End Class
End Namespace
