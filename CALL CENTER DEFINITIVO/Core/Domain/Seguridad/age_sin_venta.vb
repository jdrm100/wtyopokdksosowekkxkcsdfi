Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class age_sin_venta
        Inherits DomainObject(Of String)
        Dim _dias As Integer
        Dim _ultima_venta As String
        Dim _ticket_tec As String

        Public Property dias() As Integer
            Get
                Return _dias
            End Get
            Set(ByVal value As Integer)
                _dias = value
            End Set
        End Property
        Public Property ultima_venta() As String
            Get
                Return _ultima_venta
            End Get
            Set(ByVal value As String)
                _ultima_venta = value
            End Set
        End Property
        Public Property ticket_tec() As String
            Get
                Return _ticket_tec
            End Get
            Set(ByVal value As String)
                _ticket_tec = value
            End Set
        End Property
    End Class
End Namespace