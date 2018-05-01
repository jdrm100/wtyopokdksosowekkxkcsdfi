Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms

Public Class cct_motivos
    Dim factoria_cct_m As IDaoFactory
    Dim cct_motivoDao As I_motivo_cct_Dao
    Dim cct_tp_mDao As I_tp_llamada_motivo_Dao
    Dim l_bind_mot As New BindingSource

    Dim lista_agrega As String
    Private Sub cct_motivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            factoria_cct_m = New NHibernateDaoFactory
            cct_motivoDao = factoria_cct_m.Get_motivo_cct_Dao
            cct_tp_mDao = factoria_cct_m.Get_tp_llamada_motivo_cct_Dao

            Dim lista_motivos As New List(Of cct_motivo)
            lista_motivos = cct_motivoDao.GetByEstado("", 1)
            If Not lista_motivos Is Nothing Then
                If lista_motivos.Count > 0 Then
                    carga_dgv_m(lista_motivos)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al cargar el formulario." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_m(ByVal lista As List(Of cct_motivo))
        Try
            l_bind_mot.DataSource = lista
            Me.dgv_m.DataSource = l_bind_mot
            With Me.dgv_m.Columns
                .Item("usuario_update").Visible = False
                .Item("usuario_insert").Visible = False
                .Item("ACTIVO").Visible = False
                .Item("ID").Visible = False
            End With
        Catch ex As Exception
            MsgBox("Error al cargar motivos (DataGrid)." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
        
    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        'Recorremos el datagrid
        Dim add_selec As New List(Of cct_tp_llamada_motivo)
        Dim id_tp As Integer
        If lbl_tp.Text <> "" Then
            Dim arr_tp As Array = Me.lbl_tp.Text.Split("-")
            id_tp = arr_tp(0)
        End If
        For Each row As DataGridViewRow In dgv_m.Rows
            If dgv_m.Rows(row.Index).Cells(0).Selected Then
                add_selec = cct_tp_mDao.Setmotivos(dgv_m.Rows(row.Index).Cells("ID").Value, id_tp, 1, Login.codusu)
            End If
        Next
        Me.Close()
    End Sub
    Private Sub dgv_m_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_m.CellContentClick

    End Sub
    Private Sub dgv_m_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_m.SelectionChanged
        lbl_selec.Text = "0"
        For Each row As DataGridViewRow In dgv_m.Rows
            If dgv_m.Rows(row.Index).Cells(0).Selected Then
                lbl_selec.Text = lbl_selec.Text + 1
            End If
        Next
    End Sub

    Private Sub btn_agregar_g_Click(sender As Object, e As EventArgs) Handles btn_agregar_g.Click
        Try
            If LTrim(RTrim(txt_mot.Text)) <> "" Then
                Dim lista_motivos As New List(Of cct_motivo)
                lista_motivos = cct_motivoDao.Setmotivos(0, txt_mot.Text, 1, Login.codusu)
                lista_motivos = cct_motivoDao.GetByEstado("", 1)
                carga_dgv_m(lista_motivos)
                txt_mot.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error agregando motivo." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
        
    End Sub

    Private Sub btn_quitar_g_Click(sender As Object, e As EventArgs) Handles btn_quitar_g.Click
        Dim lista_motivos As New List(Of cct_motivo)
        lista_motivos = cct_motivoDao.Setmotivos(Me.dgv_m.CurrentRow.Cells("ID").Value, txt_mot.Text, 0, Login.codusu)
        lista_motivos = cct_motivoDao.GetByEstado("", 1)
        carga_dgv_m(lista_motivos)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class