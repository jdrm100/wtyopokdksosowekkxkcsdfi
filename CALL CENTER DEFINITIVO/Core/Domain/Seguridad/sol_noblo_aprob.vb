Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad
    Public Class sol_noblo_aprob
        Inherits DomainObject(Of String)

        Dim _fecha As String
        Dim _estado As String
        Dim _agente As String
        Dim _nombre As String
        Dim _no_bloq As String
        Dim _solicita As String
        Dim _autoriza As String

        Public Property fecha() As String
            Get
                Return _fecha
            End Get
            Set(value As String)
                _fecha = value
            End Set
        End Property
        Public Property estado() As String
            Get
                Return _estado
            End Get
            Set(value As String)
                _estado = value
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
        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property no_blo() As String
            Get
                Return _no_bloq
            End Get
            Set(value As String)
                _no_bloq = value
            End Set
        End Property

        Public Property solicita() As String
            Get
                Return _solicita
            End Get
            Set(value As String)
                _solicita = value
            End Set
        End Property

        Public Property autoriza() As String
            Get
                Return _autoriza
            End Get
            Set(value As String)
                _autoriza = value
            End Set
        End Property

        
      
    End Class
End Namespace

