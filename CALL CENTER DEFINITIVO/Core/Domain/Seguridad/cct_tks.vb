Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_tks
        Inherits DomainObject(Of String)
        Dim _FECHA As String
        Dim _MOTIVO As String
        Dim _ID_MOTIVO As Integer
        Dim _INCIDENCIA As String
        Dim _ID_INCIDENCIA As Integer
        Dim _USUARIO As String
        Dim _FORM As String
        Dim _TB_CTRL As String
        Dim _CTRL As String
        Public Property FECHA() As String
            Get
                Return _FECHA
            End Get
            Set(value As String)
                _FECHA = value
            End Set
        End Property
        Public Property MOTIVO() As String
            Get
                Return _MOTIVO
            End Get
            Set(value As String)
                _MOTIVO = value
            End Set
        End Property
        Public Property ID_MOTIVO() As Integer
            Get
                Return _ID_MOTIVO
            End Get
            Set(value As Integer)
                _ID_MOTIVO = value
            End Set
        End Property
        Public Property INCIDENCIA() As String
            Get
                Return _INCIDENCIA
            End Get
            Set(value As String)
                _INCIDENCIA = value
            End Set
        End Property
        Public Property ID_INCIDENCIA() As Integer
            Get
                Return _ID_INCIDENCIA
            End Get
            Set(value As Integer)
                _ID_INCIDENCIA = value
            End Set
        End Property
        Public Property USUARIO() As String
            Get
                Return _USUARIO
            End Get
            Set(value As String)
                _USUARIO = value
            End Set
        End Property
        Public Property FORM() As String
            Get
                Return _FORM
            End Get
            Set(value As String)
                _FORM = value
            End Set
        End Property
        Public Property TB_CTRL() As String
            Get
                Return _TB_CTRL
            End Get
            Set(value As String)
                _TB_CTRL = value
            End Set
        End Property
        Public Property CTRL() As String
            Get
                Return _CTRL
            End Get
            Set(value As String)
                _CTRL = value
            End Set
        End Property
    End Class
End Namespace
