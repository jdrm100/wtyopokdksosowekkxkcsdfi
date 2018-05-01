Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_comp_age
        Inherits DomainObject(Of String)
        Dim _DESCRIPCION As String
        Dim _OBL_SN As String
        Dim _CLASIF As String
        Dim _ACTIVO As Integer
        Dim _AGENTE As String
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Public Property OBL_SN() As String
            Get
                Return _OBL_SN
            End Get
            Set(ByVal value As String)
                _OBL_SN = value
            End Set
        End Property
        Public Property CLASIF() As String
            Get
                Return _CLASIF
            End Get
            Set(ByVal value As String)
                _CLASIF = value
            End Set
        End Property
        Public Property ACTIVO() As Integer
            Get
                Return _ACTIVO
            End Get
            Set(ByVal value As Integer)
                _ACTIVO = value
            End Set
        End Property
        Public Property AGENTE() As String
            Get
                Return _AGENTE
            End Get
            Set(ByVal value As String)
                _AGENTE = value
            End Set
        End Property
    End Class
End Namespace


