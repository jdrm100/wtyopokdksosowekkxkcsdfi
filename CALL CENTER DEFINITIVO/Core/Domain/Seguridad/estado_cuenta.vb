Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class estado_cuenta
        Inherits DomainObject(Of String)

        Dim _agente As String
        Dim _documento As String
        Dim _entidad As String
        Dim _fecha As String
        Dim _periodo As String
        Dim _efecto As String
        Dim _monto As Decimal
        Dim _balance As Decimal
        Public Property agente() As String
            Get
                Return _agente

            End Get
            Set(value As String)
                _agente = value
            End Set
        End Property
        Public Property documento() As String
            Get
                Return _documento

            End Get
            Set(value As String)
                _documento = value
            End Set
        End Property
        Public Property entidad() As String
            Get
                Return _entidad

            End Get
            Set(value As String)
                _entidad = value
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

        Public Property periodo() As String
            Get
                Return _periodo
            End Get
            Set(value As String)
                _periodo = value
            End Set
        End Property

        Public Property efecto() As String
            Get
                Return _efecto
            End Get
            Set(value As String)
                _efecto = value
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

        Public Property balance() As Decimal
            Get
                Return _balance
            End Get
            Set(ByVal value As Decimal)
                _balance = value
            End Set
        End Property

    End Class


End Namespace
