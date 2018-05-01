Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad

Public Class Form2

    Dim factoria As IDaoFactory
    Dim UsuarioDao As IUsuarioDao

    Dim Flag As Boolean = False

    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'NHibernateSessionManager.Instancia.CommitTransaction()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' NHibernateSessionManager.Instancia.BeginTransaction()
        factoria = New NHibernateDaoFactory
        UsuarioDao = factoria.GetUsuarioDao
        Call Button3_Click(sender, e)

    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView2.DataError

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged

        If Flag = True Then
            Try

            Catch ex As Exception
                ex = ex
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

        Catch ex As Exception
            ex = ex
        End Try
    End Sub


    Private Sub txt_Desc_Rol_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Desc_Rol.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
            Catch ex As Exception
                ex = ex
            End Try
        End If
    End Sub


    Private Sub btn_agregar_grupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar_grupo.Click
        If txt_Desc_Rol.Text <> "" Then
        Else
            MsgBox("Digite el rol qu desea agregar.", MsgBoxStyle.Information)
            Me.txt_Desc_Rol.Focus()
        End If
    End Sub

 

    Private Sub btn_quitar_grupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar_grupo.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            If MsgBox("¿Está seguro que desea quitar el role " & Me.DataGridView1.CurrentRow.Cells("DESC_ROL").Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try

                Catch ex As Exception
                    MsgBox("ERRO AL QUITAR GRUPO", MsgBoxStyle.Information)
                End Try
            End If

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DataGridView2.Rows.Count > 0 Then
            If MsgBox("¿Está seguro que desea quitar la acción " & Me.DataGridView2.CurrentRow.Cells("DESC_ACCION").Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try

                Catch ex As Exception
                    MsgBox("ERROR AL QUITAR ACCIÓN", MsgBoxStyle.Information)
                End Try
            End If
        End If

    End Sub
End Class