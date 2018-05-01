Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_incidencia
        Inherits DomainObject(Of String)
        Dim _descripcion As String
        Dim _activo As Integer
        Public Property DESCRIPCION() As String
            Get
                Return _descripcion
            End Get
            Set(value As String)
                _descripcion = value
            End Set
        End Property
        Public Property ACTIVO() As Integer
            Get
                Return _activo
            End Get
            Set(value As Integer)
                _activo = value
            End Set
        End Property
    End Class
End Namespace

