Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad

Public Class Form3

    Dim factoria As IDaoFactory

    Dim Flag As Boolean = False

    Private Sub Form3_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        ' NHibernateSessionManager.Instancia.CommitTransaction()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' NHibernateSessionManager.Instancia.BeginTransaction()
        factoria = New NHibernateDaoFactory
        Call Button1_Click(sender, e)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

        Catch ex As Exception
            ex = ex
        End Try

    End Sub


    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView2.DataError

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged

        If Flag = True Then
            Try
                If Not Me.DataGridView1.CurrentRow.Cells(0).Value Is Nothing Then

                    With Me.DataGridView2.Columns
                        .Item("SW_APLICACION").Visible = False
                        .Item("USUARIO_INSERT").Visible = False
                        .Item("USUARIO_UPDATE").Visible = False
                        .Item("FEC_REGISTRO").Visible = False
                    End With
                End If
            Catch ex As Exception
                ex = ex
            End Try


        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class