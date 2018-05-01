Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad
    Public Class sol_noblo_select
        Inherits DomainObject(Of String)

        Dim _agente As String
        Dim _nombre As String
        Dim _desc_noblo As String
        Dim _fecha As String
        Dim _fecha_fin As String
        Dim _comen As String
        Dim _nomusu As String
        Dim _ID_EST As Integer
        Dim _DESC_ESTADO As String
        Dim _ID_NIVEL_PROX As String
        Public Property ID_EST() As Integer
            Get
                Return _ID_EST
            End Get
            Set(value As Integer)
                _ID_EST = value
            End Set
        End Property
        Public Property DESC_ESTADO() As String
            Get
                Return _DESC_ESTADO
            End Get
            Set(value As String)
                _DESC_ESTADO = value
            End Set
        End Property
        Public Property ID_NIVEL_PROX() As String
            Get
                Return _ID_NIVEL_PROX
            End Get
            Set(value As String)
                _ID_NIVEL_PROX = value
            End Set
        End Property
        Public Property nomusu() As String
            Get
                Return _nomusu
            End Get
            Set(value As String)
                _nomusu = value
            End Set
        End Property
        Public Property comen() As String
            Get
                Return _comen
            End Get
            Set(value As String)
                _comen = value
            End Set
        End Property
        Public Property fecha_fin() As String
            Get
                Return _fecha_fin
            End Get
            Set(value As String)
                _fecha_fin = value
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
        Public Property desc_noblo() As String
            Get
                Return _desc_noblo
            End Get
            Set(value As String)
                _desc_noblo = value
            End Set
        End Property
        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property
        Public Property agente() As String
            Get
                Return _agente
            End Get
            Set(value As String)
                _agente = value
            End Set
        End Property

    End Class
End Namespace

