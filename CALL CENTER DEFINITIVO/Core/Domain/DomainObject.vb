Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Core.Domain

    Public MustInherit Class DomainObject(Of idT)

        Dim _id As idT
        Dim _usuario_insert As Integer
        Dim _usuario_update As Integer

        Public Property ID() As idT
            Get
                Return _id
            End Get
            Set(ByVal value As idT)
                _id = value
            End Set
        End Property

        Public Property USUARIO_INSERT() As Integer
            Get
                Return _usuario_insert
            End Get
            Set(ByVal value As Integer)
                _usuario_insert = value
            End Set
        End Property

        Public Property USUARIO_UPDATE() As Integer
            Get
                Return _usuario_update
            End Get
            Set(ByVal value As Integer)
                _usuario_update = value
            End Set
        End Property

        Public Function IsTransient() As Boolean

        End Function

    End Class

End Namespace
