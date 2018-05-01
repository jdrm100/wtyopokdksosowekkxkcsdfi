Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Public Class cct_conclusiones
    Dim factoria_cct_c As IDaoFactory
    Dim cct_conDao As I_con_cct_Dao
    Dim cct_i_cDao As I_inc_con_Dao
    Dim l_bind_i As New BindingSource
    Dim lista_agrega As String
    Dim l_bind_c As New BindingSource


    Private Sub cct_conclusiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            factoria_cct_c = New NHibernateDaoFactory
            cct_conDao = factoria_cct_c.Get_con_cct_Dao
            cct_i_cDao = factoria_cct_c.Get_inc_con_Dao

            Dim lista_con As New List(Of cct_con)
            lista_con = cct_conDao.GetByEstado("", 1)
            If Not lista_con Is Nothing Then
                If lista_con.Count > 0 Then
                    carga_dgv_c(lista_con)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al cargar el formulario." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub carga_dgv_c(ByVal lista As List(Of cct_con))
        Try
            l_bind_c.DataSource = lista
            Me.dgv_con.DataSource = l_bind_c
            With Me.dgv_con.Columns
                .Item("usuario_update").Visible = False
                .Item("usuario_insert").Visible = False
                .Item("ACTIVO").Visible = False
                .Item("ID").Visible = False
            End With
        Catch ex As Exception
            MsgBox("Error al cargar conclusiones (DataGrid)." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        'Recorremos el datagrid
        Dim add_selec As New List(Of cct_inc_con)
        Dim id_inc As Integer
        If lbl_i.Text <> "" Then
            Dim arr_inc As Array = Me.lbl_i.Text.Split("-")
            id_inc = arr_inc(0)
        End If
        For Each row As DataGridViewRow In dgv_con.Rows
            If dgv_con.Rows(row.Index).Cells(0).Selected Then
                add_selec = cct_i_cDao.SetConclusiones(dgv_con.Rows(row.Index).Cells("ID").Value, id_inc, 1, Login.codusu)
            End If
        Next
        Me.Close()
    End Sub

    Private Sub dgv_con_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_con.SelectionChanged
        lbl_selec.Text = "0"
        For Each row As DataGridViewRow In dgv_con.Rows
            If dgv_con.Rows(row.Index).Cells(0).Selected Then
                lbl_selec.Text = lbl_selec.Text + 1
            End If
        Next
    End Sub

    Private Sub btn_agregar_g_Click(sender As Object, e As EventArgs) Handles btn_agregar_g.Click
        Try
            If LTrim(RTrim(txt_con.Text)) <> "" Then
                Dim l_con As New List(Of cct_con)
                l_con = cct_conDao.SetConclusion(0, txt_con.Text, 1, Login.codusu)
                l_con = cct_conDao.GetByEstado("", 1)
                carga_dgv_c(l_con)
                txt_con.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error agregando conclusion." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_quitar_g_Click(sender As Object, e As EventArgs) Handles btn_quitar_g.Click
        Dim l_c As New List(Of cct_con)
        l_c = cct_conDao.SetConclusion(Me.dgv_con.CurrentRow.Cells("ID").Value, txt_con.Text, 0, Login.codusu)
        l_c = cct_conDao.GetByEstado("", 1)
        carga_dgv_c(l_c)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class