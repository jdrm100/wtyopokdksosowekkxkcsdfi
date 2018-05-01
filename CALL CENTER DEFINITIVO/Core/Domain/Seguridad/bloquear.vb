Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad

Namespace Core.Domain.Seguridad
    Public Class bloquear
        Inherits DomainObject(Of String)

        Dim _nombre As String
        Dim _clasif As String
        Dim _factura As Decimal
        Dim _bal As Decimal
        Dim _bal_curso As Decimal
        Dim _ejecutivo As String
        Dim _gestor As String
        Dim _excep As String
      
        Public Property NOMBRE() As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property CLASIF() As String
            Get
                Return _clasif
            End Get
            Set(value As String)
                _clasif = value
            End Set
        End Property
     
        Public Property FACTURA() As Decimal
            Get
                Return _factura
            End Get
            Set(value As Decimal)
                _factura = value
            End Set
        End Property

        Public Property BAL() As Decimal
            Get
                Return _bal
            End Get
            Set(value As Decimal)
                _bal = value
            End Set
        End Property

        Public Property BAL_CURSO() As Decimal
            Get
                Return _bal_curso
            End Get
            Set(value As Decimal)
                _bal_curso = value
            End Set
        End Property
        Public Property GESTOR() As String
            Get
                Return _gestor
            End Get
            Set(value As String)
                _gestor = value
            End Set
        End Property
        Public Property EJECUTIVO() As String
            Get
                Return _ejecutivo
            End Get
            Set(value As String)
                _ejecutivo = value
            End Set
        End Property
        Public Property EXCEP() As String
            Get
                Return _excep
            End Get
            Set(value As String)
                _excep = value
            End Set
        End Property
    End Class

End Namespace

