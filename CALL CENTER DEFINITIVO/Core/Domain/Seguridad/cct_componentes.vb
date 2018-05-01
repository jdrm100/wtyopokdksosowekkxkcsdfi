Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class cct_componentes
        Inherits DomainObject(Of String)
        Dim _descripcion As String
        Dim _obl_sn As Integer
        Dim _activo As Integer

        Public Property descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property

        Public Property obl_sn() As Integer
            Get
                Return _obl_sn
            End Get
            Set(ByVal value As Integer)
                _obl_sn = value
            End Set
        End Property

        Public Property activo() As Integer
            Get
                Return _activo
            End Get
            Set(ByVal value As Integer)
                _activo = value
            End Set
        End Property
    End Class

End Namespace

