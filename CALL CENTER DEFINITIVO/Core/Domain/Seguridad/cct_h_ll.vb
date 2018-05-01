Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_h_ll
        Inherits DomainObject(Of String)
        Dim _ID_LLAMADA As Integer
        Dim _ID_MOTIVO As Integer
        Dim _DESC_MOTIVO As String
        Dim _ID_INCIDENCIA As Integer
        Dim _DESC_INCIDENCIA As String
        Dim _ID_CONCLUSION As Integer
        Dim _DESC_CONCLUSION As String
        Dim _NOTA As String
        Dim _EST_TK As String
        Dim _VERIF_SN As String
        Public Property ID_LLAMADA() As Integer
            Get
                Return _ID_LLAMADA
            End Get
            Set(value As Integer)
                _ID_LLAMADA = value
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
        Public Property DESC_MOTIVO() As String
            Get
                Return _DESC_MOTIVO
            End Get
            Set(value As String)
                _DESC_MOTIVO = value
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
        Public Property DESC_INCIDENCIA() As String
            Get
                Return _DESC_INCIDENCIA
            End Get
            Set(value As String)
                _DESC_INCIDENCIA = value
            End Set
        End Property
        Public Property ID_CONCLUSION() As Integer
            Get
                Return _ID_CONCLUSION
            End Get
            Set(value As Integer)
                _ID_CONCLUSION = value
            End Set
        End Property
        Public Property DESC_CONCLUSION() As String
            Get
                Return _DESC_CONCLUSION
            End Get
            Set(value As String)
                _DESC_CONCLUSION = value
            End Set
        End Property
        Public Property NOTA() As String
            Get
                Return _NOTA
            End Get
            Set(value As String)
                _NOTA = value
            End Set
        End Property
        Public Property EST_TK() As String
            Get
                Return _EST_TK
            End Get
            Set(value As String)
                _EST_TK = value
            End Set
        End Property
        Public Property VERIF_SN() As String
            Get
                Return _VERIF_SN
            End Get
            Set(value As String)
                _VERIF_SN = value
            End Set
        End Property
    End Class
End Namespace
