Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad

Public Class Login

    Dim factoria As IDaoFactory
    Dim usuarioDao As IUsuarioDao
    Public codusu As String
    Public nomusu As String
    Public nivel As Integer

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txt_usu.Text <> "" Then
            If txt_pass.Text <> "" Then
                Try
                    Dim usu As New List(Of Usuario)
                    usu = usuarioDao.GetByusupass(Me.txt_usu.Text, Me.txt_pass.Text)

                    If usu.Count > 0 Then
                        codusu = usu.Item(0).ID
                        nomusu = usu.Item(0).nomusu
                        nivel = usu.Item(0).ID_NIVEL

                        Principal.Show()
                        Me.Visible = False

                        









                    Else
                        MsgBox("Datos de usuario incorrectos!" & Chr(13) & "", MsgBoxStyle.Critical, "Call Center")
                    End If
                Catch ex As Exception

                    MsgBox("Error en la carga de usuario: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
                End Try
                
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            factoria = New NHibernateDaoFactory
            usuarioDao = factoria.GetUsuarioDao
        Catch ex As Exception
            MsgBox("Error en la carga de usuario: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub txt_usu_TextChanged(sender As Object, e As EventArgs) Handles txt_usu.TextChanged

    End Sub


End Class
