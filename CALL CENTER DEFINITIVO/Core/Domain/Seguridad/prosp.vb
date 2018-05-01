Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class prosp
        Inherits DomainObject(Of String)
        Dim _nombre As String
        Dim _telefono1 As String
        Dim _telefono2 As String
        Dim _telcon1 As String
        Dim _ciudad As String
        Dim _dir As String
        Dim _rep As String
        Dim _baldia As Decimal
        Dim _bloq As String
        Dim _codasi As String
        Dim _fax As String
        Dim _retirada As String
        Dim _clasif As String
        Dim _codgtech As String
        Public Property codgtech() As String
            Get
                Return _codgtech

            End Get
            Set(value As String)
                _codgtech = value
            End Set
        End Property
        Public Property clasif() As String
            Get
                Return _clasif

            End Get
            Set(value As String)
                _clasif = value
            End Set
        End Property
        Public Property retirada() As String
            Get
                Return _retirada

            End Get
            Set(value As String)
                _retirada = value
            End Set
        End Property

        Public Property fax() As String
            Get
                Return _fax

            End Get
            Set(value As String)
                _fax = value
            End Set
        End Property

        Public Property codasi() As String
            Get
                Return _codasi

            End Get
            Set(value As String)
                _codasi = value
            End Set
        End Property
        Public Property bloqueada() As String
            Get
                Return _bloq

            End Get
            Set(value As String)
                _bloq = value
            End Set
        End Property
        Public Property baldia() As Decimal
            Get
                Return _baldia

            End Get
            Set(value As Decimal)
                _baldia = value
            End Set
        End Property

        Public Property nomrep() As String
            Get
                Return _rep
            End Get
            Set(value As String)
                _rep = value
            End Set
        End Property

        Public Property direccion() As String
            Get
                Return _dir
            End Get
            Set(value As String)
                _dir = value
            End Set
        End Property

        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property telefono1() As String
            Get
                Return _telefono1
            End Get
            Set(ByVal value As String)
                _telefono1 = value
            End Set
        End Property

        Public Property telefono2() As String
            Get
                Return _telefono2
            End Get
            Set(ByVal value As String)
                _telefono2 = value
            End Set
        End Property

        Public Property telcon1() As String
            Get
                Return _telcon1
            End Get
            Set(ByVal value As String)
                _telcon1 = value
            End Set
        End Property

        Public Property ciudad() As String
            Get
                Return _ciudad
            End Get
            Set(ByVal value As String)
                _ciudad = value
            End Set
        End Property

    End Class


End Namespace
