Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_mat_hist
        Inherits DomainObject(Of String)
        Dim _ID_MAT As Integer
        Dim _DESCRIPCION As String
        Dim _CANTIDAD As Decimal
        Dim _RECIBE As String
        Dim _FECHA As String
        Dim _FEC_REG As String
        Public Property ID_MAT() As Integer
            Get
                Return _ID_MAT
            End Get
            Set(ByVal value As Integer)
                _ID_MAT = value
            End Set
        End Property
        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property
        Public Property CANTIDAD() As Decimal
            Get
                Return _CANTIDAD
            End Get
            Set(ByVal value As Decimal)
                _CANTIDAD = value
            End Set
        End Property
        Public Property RECIBE() As String
            Get
                Return _RECIBE
            End Get
            Set(ByVal value As String)
                _RECIBE = value
            End Set
        End Property
        Public Property FECHA() As String
            Get
                Return _FECHA
            End Get
            Set(ByVal value As String)
                _FECHA = value
            End Set
        End Property
        Public Property FEC_REG() As String
            Get
                Return _FEC_REG
            End Get
            Set(ByVal value As String)
                _FEC_REG = value
            End Set
        End Property
    End Class
End Namespace
