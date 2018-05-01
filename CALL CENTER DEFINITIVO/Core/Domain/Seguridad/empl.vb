Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class empl
        Inherits DomainObject(Of String)
        Dim _NOMBRE As String
        Dim _FLOTA As String
        Dim _CORREO As String
        Dim _RUTA As String
        Dim _ACTIVO As String
        Public Property NOMBRE() As String
            Get
                Return _NOMBRE
            End Get
            Set(ByVal value As String)
                _NOMBRE = value
            End Set
        End Property
        Public Property FLOTA() As String
            Get
                Return _FLOTA
            End Get
            Set(ByVal value As String)
                _FLOTA = value
            End Set
        End Property
        Public Property CORREO() As String
            Get
                Return _CORREO
            End Get
            Set(ByVal value As String)
                _CORREO = value
            End Set
        End Property
        Public Property RUTA() As String
            Get
                Return _RUTA
            End Get
            Set(ByVal value As String)
                _RUTA = value
            End Set
        End Property
        Public Property ACTIVO() As String
            Get
                Return _ACTIVO
            End Get
            Set(ByVal value As String)
                _ACTIVO = value
            End Set
        End Property

    End Class


End Namespace

