Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class callcenteradm
        Inherits DomainObject(Of String)

        Dim _movcall As String
        Dim _rescall As String
        Dim _codges As String
        Dim _horrec As String
        Dim _fecrec As String
        Dim _llamar As String
        Dim _ticket As String
        Dim _codage As String
        Dim _feccall As String
        Dim _horini As String
        Dim _horfin As String
        Dim _tipcall As String
        Dim _percon As String
        Dim _codusu As String
        Dim _comentario As String
        Dim _tipo As String
        Dim _cerrado As String
        Dim _gescie As String
        Dim _comcie As String
        Dim _feccie As String
        Dim _probsys As String

        Public Property probsys() As String
            Get
                Return _probsys
            End Get
            Set(value As String)
                _probsys = value
            End Set
        End Property

        Public Property feccie() As String
            Get
                Return _feccie
            End Get
            Set(value As String)
                _feccie = value
            End Set
        End Property

        Public Property comcie() As String
            Get
                Return _comcie
            End Get
            Set(value As String)
                _comcie = value
            End Set
        End Property

        Public Property gescie() As String
            Get
                Return _gescie
            End Get
            Set(value As String)
                _gescie = value
            End Set
        End Property

        Public Property cerrado() As String
            Get
                Return _cerrado
            End Get
            Set(value As String)
                _cerrado = value
            End Set
        End Property
        Public Property tipo() As String
            Get
                Return _tipo
            End Get
            Set(value As String)
                _tipo = value
            End Set
        End Property


        Public Property rescall() As String
            Get
                Return _rescall
            End Get
            Set(value As String)
                _rescall = value
            End Set
        End Property
        Public Property codges() As String
            Get
                Return _codges
            End Get
            Set(value As String)
                _codges = value
            End Set
        End Property
        Public Property horrec() As String
            Get
                Return _horrec
            End Get
            Set(value As String)
                _horrec = value
            End Set
        End Property
        Public Property fecrec() As String
            Get
                Return _fecrec
            End Get
            Set(value As String)
                _fecrec = value
            End Set
        End Property
        Public Property llamar() As String
            Get
                Return _llamar
            End Get
            Set(value As String)
                _llamar = value
            End Set
        End Property
        Public Property ticket() As String
            Get
                Return _ticket
            End Get
            Set(value As String)
                _ticket = value
            End Set
        End Property
        Public Property movcall() As String
            Get
                Return _movcall
            End Get
            Set(value As String)
                _movcall = value
            End Set
        End Property
        Public Property codusu() As String
            Get
                Return _codusu
            End Get
            Set(value As String)
                _codusu = value
            End Set
        End Property

        Public Property codage() As String
            Get
                Return _codage
            End Get
            Set(value As String)
                _codage = value
            End Set
        End Property
        Public Property feccall() As String
            Get
                Return _feccall

            End Get
            Set(value As String)
                _feccall = value
            End Set
        End Property

        Public Property horini() As String
            Get
                Return _horini
            End Get
            Set(value As String)
                _horini = value
            End Set
        End Property

        Public Property horfin() As String
            Get
                Return _horfin
            End Get
            Set(value As String)
                _horfin = value
            End Set
        End Property
        Public Property tipcall() As String
            Get
                Return _tipcall
            End Get
            Set(value As String)
                _tipcall = value
            End Set
        End Property

        Public Property percon() As String
            Get
                Return _percon
            End Get
            Set(ByVal value As String)
                _percon = value
            End Set
        End Property

        Public Property comentario() As String
            Get
                Return _comentario
            End Get
            Set(ByVal value As String)
                _comentario = value
            End Set
        End Property


    End Class


End Namespace
