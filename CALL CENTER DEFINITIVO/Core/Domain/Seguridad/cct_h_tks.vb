Imports System
Imports System.Collections
Imports NHibernate
Imports Core.DataInterfaces
Imports Core.Domain.Seguridad
Namespace Core.Domain.Seguridad
    Public Class cct_h_tks
        Inherits DomainObject(Of String)
        Dim _FECHA As String
        Dim _ESTADO_TICKET As String
        Dim _MOTIVO_APERTURA As String
        Dim _INCIDENCIA_APERTURA As String
        Dim _CONTACTO_APERTURA As String
        Dim _NOTA As String
        Dim _GESTOR As String
        Dim _HORA As String
        Dim _INCIDENCIA_CIERRE As String
        Dim _CONTACTO_CIERRE As String
        Dim _NOTA_CIERRE As String
        Dim _GESTOR_CIERRE As String
        Dim _FECHA_CIERRE As String
        Dim _HORA_CIERRE As String
        Dim _DIAS_ABIERTO As String
        Dim _COMPARACION_INCIDENCIA As String
        Dim _VERIFICACION As String
        Dim _VERIFICADO_POR As String
        Dim _NOTA_VERIFICACION As String
        Dim _FECHA_VERIFICACION As String
        Dim _HORA_VERIFICACION As String
        Dim _DIAS_POR_VERIFICACION As String

        Public Property DIAS_POR_VERIFICACION() As String
            Get
                Return _DIAS_POR_VERIFICACION
            End Get
            Set(value As String)
                _DIAS_POR_VERIFICACION = value
            End Set
        End Property
        Public Property HORA_VERIFICACION() As String
            Get
                Return _HORA_VERIFICACION
            End Get
            Set(value As String)
                _HORA_VERIFICACION = value
            End Set
        End Property
        Public Property FECHA_VERIFICACION() As String
            Get
                Return _FECHA_VERIFICACION
            End Get
            Set(value As String)
                _FECHA_VERIFICACION = value
            End Set
        End Property
        Public Property NOTA_VERIFICACION() As String
            Get
                Return _NOTA_VERIFICACION
            End Get
            Set(value As String)
                _NOTA_VERIFICACION = value
            End Set
        End Property
        Public Property VERIFICADO_POR() As String
            Get
                Return _VERIFICADO_POR
            End Get
            Set(value As String)
                _VERIFICADO_POR = value
            End Set
        End Property
        Public Property VERIFICACION() As String
            Get
                Return _VERIFICACION
            End Get
            Set(value As String)
                _VERIFICACION = value
            End Set
        End Property
        Public Property COMPARACION_INCIDENCIA() As String
            Get
                Return _COMPARACION_INCIDENCIA
            End Get
            Set(value As String)
                _COMPARACION_INCIDENCIA = value
            End Set
        End Property
        Public Property DIAS_ABIERTO() As String
            Get
                Return _DIAS_ABIERTO
            End Get
            Set(value As String)
                _DIAS_ABIERTO = value
            End Set
        End Property
        Public Property HORA_CIERRE() As String
            Get
                Return _HORA_CIERRE
            End Get
            Set(value As String)
                _HORA_CIERRE = value
            End Set
        End Property
        Public Property FECHA_CIERRE() As String
            Get
                Return _FECHA_CIERRE
            End Get
            Set(value As String)
                _FECHA_CIERRE = value
            End Set
        End Property
        Public Property GESTOR_CIERRE() As String
            Get
                Return _GESTOR_CIERRE
            End Get
            Set(value As String)
                _GESTOR_CIERRE = value
            End Set
        End Property
        Public Property NOTA_CIERRE() As String
            Get
                Return _NOTA_CIERRE
            End Get
            Set(value As String)
                _NOTA_CIERRE = value
            End Set
        End Property
        Public Property CONTACTO_CIERRE() As String
            Get
                Return _CONTACTO_CIERRE
            End Get
            Set(value As String)
                _CONTACTO_CIERRE = value
            End Set
        End Property
        Public Property INCIDENCIA_CIERRE() As String
            Get
                Return _INCIDENCIA_CIERRE
            End Get
            Set(value As String)
                _INCIDENCIA_CIERRE = value
            End Set
        End Property
        Public Property HORA() As String
            Get
                Return _HORA
            End Get
            Set(value As String)
                _HORA = value
            End Set
        End Property
        Public Property GESTOR() As String
            Get
                Return _GESTOR
            End Get
            Set(value As String)
                _GESTOR = value
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
        Public Property CONTACTO_APERTURA() As String
            Get
                Return _CONTACTO_APERTURA
            End Get
            Set(value As String)
                _CONTACTO_APERTURA = value
            End Set
        End Property
        Public Property INCIDENCIA_APERTURA() As String
            Get
                Return _INCIDENCIA_APERTURA
            End Get
            Set(value As String)
                _INCIDENCIA_APERTURA = value
            End Set
        End Property
        Public Property MOTIVO_APERTURA() As String
            Get
                Return _MOTIVO_APERTURA
            End Get
            Set(value As String)
                _MOTIVO_APERTURA = value
            End Set
        End Property
        Public Property ESTADO_TICKET() As String
            Get
                Return _ESTADO_TICKET
            End Get
            Set(value As String)
                _ESTADO_TICKET = value
            End Set
        End Property
        Public Property FECHA() As String
            Get
                Return _FECHA
            End Get
            Set(value As String)
                _FECHA = value
            End Set
        End Property

    End Class
End Namespace
