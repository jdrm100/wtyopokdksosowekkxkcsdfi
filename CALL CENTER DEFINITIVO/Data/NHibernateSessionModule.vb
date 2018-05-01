Imports System
Imports System.Web
Imports Data

Public Class NHibernateSessionModule
    Implements IHttpModule


    Public Sub Dispose() Implements System.Web.IHttpModule.Dispose

    End Sub

    Public Sub Init(ByVal context As System.Web.HttpApplication) Implements System.Web.IHttpModule.Init
        AddHandler context.BeginRequest, AddressOf BeginTransation
        AddHandler context.EndRequest, AddressOf CommitAndCloseSession
    End Sub

    Private Sub BeginTransation(ByVal sender As Object, ByVal e As EventArgs)
        NHibernateSessionManager.Instancia.BeginTransaction()
    End Sub

    Private Sub CommitAndCloseSession(ByVal sender As Object, ByVal e As EventArgs)
        Try
            NHibernateSessionManager.Instancia.CommitTransaction()
        Catch ex As Exception
            NHibernateSessionManager.Instancia.CloseSession()
        End Try
    End Sub
End Class
