Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class facperiodo
        Inherits DomainObject(Of String)
        Dim _codage As String
        Dim _fecfin As String
        Dim _monto As Decimal

        Public Property codage() As String
            Get
                Return _codage
            End Get
            Set(ByVal value As String)
                _codage = value
            End Set
        End Property
        Public Property fecfin() As String
            Get
                Return _fecfin
            End Get
            Set(ByVal value As String)
                _fecfin = value
            End Set
        End Property
        Public Property monto() As Decimal
            Get
                Return _monto
            End Get
            Set(ByVal value As Decimal)
                _monto = value
            End Set
        End Property

    End Class
End Namespace
