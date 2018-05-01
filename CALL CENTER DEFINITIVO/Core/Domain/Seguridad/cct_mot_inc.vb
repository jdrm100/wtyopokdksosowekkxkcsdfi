
Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_mot_inc
        Inherits DomainObject(Of String)
        Dim _id_incidencia As Integer
        Dim _id_motivo As Integer
        Dim _descripcion As String
        Dim _activo As Integer
        Public Property ID_INCIDENCIA() As Integer
            Get
                Return _id_incidencia
            End Get
            Set(value As Integer)
                _id_incidencia = value
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
