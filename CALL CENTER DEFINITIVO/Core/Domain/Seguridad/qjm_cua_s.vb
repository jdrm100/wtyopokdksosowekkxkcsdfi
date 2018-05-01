Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class qjm_cua_s
        Inherits DomainObject(Of String)
        Dim _agente As String
        Dim _monto As Decimal
        Dim _fec_fin As String
        Public Property agente() As String
            Get
                Return _agente
            End Get
            Set(ByVal value As String)
                _agente = value
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
        Public Property fec_fin() As String
            Get
                Return _fec_fin
            End Get
            Set(ByVal value As String)
                _fec_fin = value
            End Set
        End Property


    End Class


End Namespace
