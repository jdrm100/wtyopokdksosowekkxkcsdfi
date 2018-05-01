Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms

Public Class cct_incidencias
    Dim factoria_cct_i As IDaoFactory
    Dim cct_incidenciaDao As I_incidencia_cct_Dao
    Dim cct_m_iDao As I_mot_inc_Dao
    Dim l_bind_inc As New BindingSource
    Dim lista_agrega As String
    Dim l_bind_m As New BindingSource
    Private Sub cct_incidencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            factoria_cct_i = New NHibernateDaoFactory
            cct_incidenciaDao = factoria_cct_i.Get_incidencia_cct_Dao
            cct_m_iDao = factoria_cct_i.Get_mot_inc_cct_Dao

            Dim lista_inc As New List(Of cct_incidencia)
            lista_inc = cct_incidenciaDao.GetByEstado("", 1)
            If Not lista_inc Is Nothing Then
                If lista_inc.Count > 0 Then
                    carga_dgv_i(lista_inc)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al cargar el formulario." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_i(ByVal lista As List(Of cct_incidencia))
        Try
            l_bind_inc.DataSource = lista
            Me.dgv_i.DataSource = l_bind_inc
            With Me.dgv_i.Columns
                .Item("usuario_update").Visible = False
                .Item("usuario_insert").Visible = False
                .Item("ACTIVO").Visible = False
                .Item("ID").Visible = False
            End With
        Catch ex As Exception
            MsgBox("Error al cargar incidencias (DataGrid)." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        'Recorremos el datagrid
        Dim add_selec As New List(Of cct_mot_inc)
        Dim id_mot As Integer
        If lbl_m.Text <> "" Then
            Dim arr_mot As Array = Me.lbl_m.Text.Split("-")
            id_mot = arr_mot(0)
        End If
        For Each row As DataGridViewRow In dgv_i.Rows
            If dgv_i.Rows(row.Index).Cells(0).Selected Then
                add_selec = cct_m_iDao.Setincidencias(dgv_i.Rows(row.Index).Cells("ID").Value, id_mot, 1, Login.codusu)
            End If
        Next
        Me.Close()
    End Sub
    Private Sub dgv_i_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_i.SelectionChanged
        lbl_selec.Text = "0"
        For Each row As DataGridViewRow In dgv_i.Rows
            If dgv_i.Rows(row.Index).Cells(0).Selected Then
                lbl_selec.Text = lbl_selec.Text + 1
            End If
        Next
    End Sub
    Private Sub btn_agregar_g_Click(sender As Object, e As EventArgs) Handles btn_agregar_g.Click
        Try
            If LTrim(RTrim(txt_inc.Text)) <> "" Then
                Dim lista_inc As New List(Of cct_incidencia)
                lista_inc = cct_incidenciaDao.Setincidencias(0, txt_inc.Text, 1, Login.codusu)
                lista_inc = cct_incidenciaDao.GetByEstado("", 1)
                carga_dgv_i(lista_inc)
                txt_inc.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error agregando incidencia." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_quitar_g_Click(sender As Object, e As EventArgs) Handles btn_quitar_g.Click
        Dim lista_inc As New List(Of cct_incidencia)
        lista_inc = cct_incidenciaDao.Setincidencias(Me.dgv_i.CurrentRow.Cells("ID").Value, txt_inc.Text, 0, Login.codusu)
        lista_inc = cct_incidenciaDao.GetByEstado("", 1)
        carga_dgv_i(lista_inc)
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    
End Class