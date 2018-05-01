Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad

    Public Class Usuario
        Inherits DomainObject(Of String)
        Dim _nomusu As String
        Dim _login As String
        Dim _clave As String
        Dim _ID_NIVEL As Integer
        Public Property nomusu() As String
            Get
                Return _nomusu
            End Get
            Set(ByVal value As String)
                _nomusu = value
            End Set
        End Property
        Public Property login() As String
            Get
                Return _login
            End Get
            Set(ByVal value As String)
                _login = value
            End Set
        End Property
        Public Property clave() As String
            Get
                Return _clave
            End Get
            Set(ByVal value As String)
                _clave = value
            End Set
        End Property
        Public Property ID_NIVEL() As String
            Get
                Return _ID_NIVEL
            End Get
            Set(ByVal value As String)
                _ID_NIVEL = value
            End Set
        End Property
    End Class


End Namespace

