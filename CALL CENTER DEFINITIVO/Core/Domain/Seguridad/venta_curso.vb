Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class venta_curso
        Inherits DomainObject(Of String)
        Dim _agente As String
        Dim _fecha As String
        Dim _ventas As Decimal
        Dim _pagos As Decimal
        Dim _comv As Decimal
        Dim _comp As Decimal
        Dim _comr As Decimal
        Dim _comisiones As Decimal
        Dim _total As Decimal

        Public Property agente() As String
            Get
                Return _agente
            End Get
            Set(ByVal value As String)
                _agente = value
            End Set
        End Property

        Public Property fecha() As String
            Get
                Return _fecha
            End Get
            Set(ByVal value As String)
                _fecha = value
            End Set
        End Property

        Public Property ventas() As Decimal
            Get
                Return _ventas
            End Get
            Set(ByVal value As Decimal)
                _ventas = value
            End Set
        End Property
        Public Property pagos() As Decimal
            Get
                Return _pagos
            End Get
            Set(ByVal value As Decimal)
                _pagos = value
            End Set
        End Property
        Public Property comv() As Decimal
            Get
                Return _comv
            End Get
            Set(ByVal value As Decimal)
                _comv = value
            End Set
        End Property
        Public Property comp() As Decimal
            Get
                Return _comp
            End Get
            Set(ByVal value As Decimal)
                _comp = value
            End Set
        End Property
        Public Property comr() As Decimal
            Get
                Return _comr
            End Get
            Set(ByVal value As Decimal)
                _comr = value
            End Set
        End Property
        Public Property comisiones() As Decimal
            Get
                Return comr + comv + comp
            End Get
            Set(ByVal value As Decimal)
                _comisiones = value
            End Set
        End Property

        Public Property total() As Decimal
            Get
                Return _total
            End Get
            Set(ByVal value As Decimal)
                _total = value
            End Set
        End Property

    End Class


End Namespace

