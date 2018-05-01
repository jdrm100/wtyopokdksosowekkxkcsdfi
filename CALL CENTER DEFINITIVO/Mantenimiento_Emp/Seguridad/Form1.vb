Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad

Public Class Form1

    Dim factoria As IDaoFactory
    Dim UsuarioDao As IUsuarioDao


    Dim Flag As Boolean = True
    Dim Flag2 As Boolean = True

    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'NHibernateSessionManager.Instancia.BeginTransaction()
            factoria = New NHibernateDaoFactory

            UsuarioDao = factoria.GetUsuarioDao
            Me.tt1.SetToolTip(Me.btn_desb, "Desbloquear Usuario.")
            Me.tt1.SetToolTip(Me.btn_agregar_grupo, "Agregar Grupo.")
            Me.tt1.SetToolTip(Me.btn_quitar_grupo, "Quitar Grupo.")
            Me.tt1.SetToolTip(Me.btn_agregar_rol, "Agregar Rol.")
            Me.tt1.SetToolTip(Me.btn_quitar_rol, "Quitar Rol.")

        Catch ex As Exception
            MsgBox("Error al cargar formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Permisos Usuario")
        End Try



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim usuario As New List(Of Usuario)
            usuario = UsuarioDao.GetAll
            configurar_dg_usuario(usuario)
            Me.Flag = True
            Me.txt_id_user.Text = ""
            Me.txt_nombre.Text = ""
        Catch ex As Exception
            MsgBox("Error al traer usuarios: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Permisos Usuario")
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim usuario As New Usuario
        If Me.DataGridView1.RowCount > 0 Then
            Try
                usuario = UsuarioDao.GetById(Me.DataGridView1.CurrentRow.Cells("ID").Value, False)

                NHibernateSessionManager.Instancia.BeginTransaction()
                usuario = UsuarioDao.SaveOrUpdate(usuario)
                NHibernateSessionManager.Instancia.CommitTransaction()
                Flag = False
            Catch ex As Exception
                MsgBox("Error al modificar datos de usuario: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Permisos Usuario")
            End Try

        End If

    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged



    End Sub

    Private Sub DataGridView2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView2.DataError

    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Call DataGridView2_SelectionChanged(sender, e)
    End Sub

    Private Sub DataGridView2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.SelectionChanged
        If Flag2 = True Then
            Try

            Catch ex As Exception
                MsgBox("Error al traer el rol en el grupo: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Permisos Usuario")
            End Try

        End If
    End Sub

    Private Sub DataGridView3_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView3.DataError

    End Sub

    Private Sub txt_nombre_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombre.KeyUp
        If e.KeyCode = Keys.Enter Then
            Call txt_id_user_KeyUp(sender, e)
        End If
    End Sub

    Private Sub txt_id_user_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_id_user.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try

                Dim Usuario As List(Of Usuario)
                Usuario = UsuarioDao.GetLikeIdUserNombre(txt_id_user.Text, txt_nombre.Text)
                configurar_dg_usuario(Usuario)
                If Not IsNothing(Usuario) And Usuario.Count > 0 Then

                End If
                Me.Flag = True

                DataGridView3.DataSource = Nothing
                txt_id_user.Text = ""
                txt_nombre.Text = ""
            Catch ex As Exception
                MsgBox("Error al traer usuario: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Permisos Usuario")
            End Try
        End If
    End Sub

    Private Sub btn_agregar_grupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar_grupo.Click

    End Sub



    Private Sub btn_quitar_grupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar_grupo.Click


    End Sub

    Private Sub configurar_dg_usuario(ByVal usuario As List(Of Usuario))
        Me.DataGridView1.DataSource = usuario
        With Me.DataGridView1.Columns
            .Item("CCONTABLE").Visible = False
            .Item("GRUPOS").Visible = False
            .Item("IP_USER_ERR").Visible = False
            .Item("PASS_CHANGE").Visible = False
            .Item("USUARIO_UPDATE").Visible = False
            .Item("USUARIO_INSERT").Visible = False
            .Item("FEC_REG").Visible = False
        End With
    End Sub

    Private Sub btn_quitar_rol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar_rol.Click
        If Me.DataGridView3.Rows.Count > 0 Then
            Try
                NHibernateSessionManager.Instancia.BeginTransaction()
                If Me.DataGridView3.RowCount > 0 Then

                End If

                NHibernateSessionManager.Instancia.CommitTransaction()

            Catch ex As Exception
                MsgBox("Error al quitar el rol de usuario: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Permisos Usuario")
            End Try
        End If

    End Sub

    Private Sub btn_desb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_desb.Click
        Try
            If Me.DataGridView1.Rows.Count > 0 Then
                Me.DataGridView1.CurrentRow.Cells("SW_BLOQUEO").Value = "0"
                Me.DataGridView1.CurrentRow.Cells("CONT_BLOQ").Value = "0"
            End If
        Catch ex As Exception
            MsgBox("Error al desbloquear usuario: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Permisos Usuario")
        End Try
    End Sub

End Class
