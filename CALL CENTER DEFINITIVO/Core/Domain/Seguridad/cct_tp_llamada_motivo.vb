
Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_tp_llamada_motivo
        Inherits DomainObject(Of String)
        Dim _id_tp_llamada As Integer
        Dim _id_motivo As Integer
        Dim _descripcion As String
        Dim _activo As Integer
        Public Property ID_TP_LLAMADA() As Integer
            Get
                Return _id_tp_llamada
            End Get
            Set(value As Integer)
                _id_tp_llamada = value
            End Set
        End Property
        Public Property ID_MOTIVO() As Integer
            Get
                Return _id_motivo
            End Get
            Set(value As Integer)
                _id_motivo = value
            End Set
        End Property
        Public Property DESCRIPCION() As String
            Get
                Return _descripcion
            End Get
            Set(value As String)
                _descripcion = value
            End Set
        End Property

        Public Property ACTIVO() As Integer
            Get
                Return _activo
            End Get
            Set(value As Integer)
                _activo = value
            End Set
        End Property
    End Class
End Namespace

