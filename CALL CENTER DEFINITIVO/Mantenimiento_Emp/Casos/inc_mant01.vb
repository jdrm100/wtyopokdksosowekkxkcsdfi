Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Public Class inc_mant01
    Dim factoria_cct As IDaoFactory
    Dim tp_llamadaDao As I_tp_llamada_Dao
    Dim tp_motivoDao As I_tp_llamada_motivo_Dao
    Dim mot_incDao As I_mot_inc_Dao
    Dim inc_conDao As I_inc_con_Dao
    Dim l_bind_m As New BindingSource
    Dim l_bind_i As New BindingSource
    Dim l_bind_c As New BindingSource
    Public flag_m As Boolean = True
    Public flag_i As Boolean = True
    Public flag_c As Boolean = True
    Private Sub inc_mant01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'NHibernateSessionManager.Instancia.BeginTransaction()
            factoria_cct = New NHibernateDaoFactory
            tp_llamadaDao = factoria_cct.Get_tp_llamada_Dao
            tp_motivoDao = factoria_cct.Get_tp_llamada_motivo_cct_Dao
            mot_incDao = factoria_cct.Get_mot_inc_cct_Dao
            inc_conDao = factoria_cct.Get_inc_con_Dao
            Dim list_tp_llamada As New List(Of cct_tp_llamda)
            list_tp_llamada = tp_llamadaDao.GetByEstado(0, "", 1)
            carga_dgv_tp_llamada(list_tp_llamada)

            pre_carga_dgv_tp_motivo()
            pre_carga_dgv_m_i()
            
        Catch ex As Exception
            MsgBox("Error al cargar el formulario." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_tp_llamada(ByVal lista_tp As List(Of cct_tp_llamda))
        Me.dgv_tp_llamada.DataSource = lista_tp
        With Me.dgv_tp_llamada.Columns
            .Item("usuario_update").Visible = False
            .Item("usuario_insert").Visible = False
            .Item("ACTIVO").Visible = False
            .Item("ID").Visible = False
        End With
    End Sub
    Private Sub pre_carga_dgv_tp_motivo()
        Try
            If Me.dgv_tp_llamada.RowCount > 0 And flag_m = True Then
                flag_m = False
                If Not Me.dgv_tp_llamada Is Nothing Then
                    Dim list_tp_motivo As New List(Of cct_tp_llamada_motivo)
                    list_tp_motivo = tp_motivoDao.GetByEstado(0, Me.dgv_tp_llamada.CurrentRow.Cells("ID").Value, 1)
                    If Not list_tp_motivo Is Nothing Then
                        If list_tp_motivo.Count > 0 Then
                            carga_dgv_tp_motivo(list_tp_motivo)
                        End If
                    Else
                        l_bind_m.Clear()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar de motivo (DataGrid) " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_tp_motivo(ByVal lista_m As List(Of cct_tp_llamada_motivo))
        Try
            l_bind_m.DataSource = lista_m
            Me.dgv_motivo.DataSource = l_bind_m
            With Me.dgv_motivo.Columns
                .Item("usuario_update").Visible = False
                .Item("usuario_insert").Visible = False
                .Item("ACTIVO").Visible = False
                .Item("ID").Visible = False
                .Item("ID_MOTIVO").Visible = False
                .Item("ID_TP_LLAMADA").Visible = False
            End With

        Catch ex As Exception
            MsgBox("Error al cargar motivos (DataGrid)." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub pre_carga_dgv_i_c()
        Try
            If Me.dgv_incidencia.RowCount > 0 And flag_c = True Then
                flag_c = False
                If Not Me.dgv_incidencia Is Nothing Then
                    Dim l_i_c As New List(Of cct_inc_con)
                    l_i_c = inc_conDao.GetByEstado(0, Me.dgv_incidencia.CurrentRow.Cells("ID_INCIDENCIA").Value, 1)
                    If Not l_i_c Is Nothing Then
                        If l_i_c.Count > 0 Then
                            carga_dgv_i_c(l_i_c)
                        End If
                    Else
                        l_bind_c.Clear()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar de conclusion (DataGrid) " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub pre_carga_dgv_m_i()
        Try
            If Me.dgv_motivo.RowCount > 0 And flag_i = True Then
                flag_i = False
                If Not Me.dgv_motivo Is Nothing Then
                    Dim list_mot_inc As New List(Of cct_mot_inc)
                    list_mot_inc = mot_incDao.GetByEstado(0, Me.dgv_motivo.CurrentRow.Cells("ID_MOTIVO").Value, 1)
                    If Not list_mot_inc Is Nothing Then
                        If list_mot_inc.Count > 0 Then
                            carga_dgv_m_i(list_mot_inc)
                        End If
                    Else
                        l_bind_i.Clear()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar de incidencia (DataGrid) " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_i_c(ByVal lista As List(Of cct_inc_con))
        Try
            l_bind_c.DataSource = lista
            Me.dgv_conclusion.DataSource = l_bind_c
            With Me.dgv_conclusion.Columns
                .Item("usuario_update").Visible = False
                .Item("usuario_insert").Visible = False
                .Item("ACTIVO").Visible = False
                .Item("ID_INCIDENCIA").Visible = False
                .Item("ID_CONCLUSION").Visible = False
                .Item("ID").Visible = False
            End With
        Catch ex As Exception
            MsgBox("Error al cargar incidencia (DataGrid)." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_m_i(ByVal lista_i As List(Of cct_mot_inc))
        Try
            l_bind_i.DataSource = lista_i
            Me.dgv_incidencia.DataSource = l_bind_i
            With Me.dgv_incidencia.Columns
                .Item("usuario_update").Visible = False
                .Item("usuario_insert").Visible = False
                .Item("ACTIVO").Visible = False
                .Item("ID_INCIDENCIA").Visible = False
                .Item("ID_MOTIVO").Visible = False
                .Item("ID").Visible = False
            End With
        Catch ex As Exception
            MsgBox("Error al cargar incidencia (DataGrid)." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub btn_agregar_m_Click(sender As Object, e As EventArgs) Handles btn_agregar_m.Click
        Try
            Dim childform As New cct_motivos
            childform.lbl_tp.Text = Me.dgv_tp_llamada.CurrentRow.Cells("ID").Value & "-" & Me.dgv_tp_llamada.CurrentRow.Cells("DESCRIPCION").Value
            childform.ShowDialog()
            pre_carga_dgv_tp_motivo()
        Catch ex As Exception
            MsgBox("Error al cargar el listado de motivos " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_agregar_c_Click(sender As Object, e As EventArgs) Handles btn_agregar_c.Click
        Try
            Dim childform As New cct_conclusiones
            childform.lbl_i.Text = Me.dgv_incidencia.CurrentRow.Cells("ID_INCIDENCIA").Value & "-" & Me.dgv_incidencia.CurrentRow.Cells("DESCRIPCION_INCIDENCIA").Value
            childform.ShowDialog()
            pre_carga_dgv_i_c()
        Catch ex As Exception
            MsgBox("Error al cargar el listado de conclusiones " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_agregar_i_Click(sender As Object, e As EventArgs) Handles btn_agregar_i.Click
        Try
            Dim childform As New cct_incidencias
            childform.lbl_m.Text = Me.dgv_motivo.CurrentRow.Cells("ID_MOTIVO").Value & "-" & Me.dgv_motivo.CurrentRow.Cells("DESCRIPCION_MOTIVO").Value
            childform.ShowDialog()
            pre_carga_dgv_m_i()
        Catch ex As Exception
            MsgBox("Error al cargar el listado de motivos " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_quitar_m_Click(sender As Object, e As EventArgs) Handles btn_quitar_m.Click
        Try
            If Me.dgv_motivo.RowCount > 0 Then
                Dim del_selec As New List(Of cct_tp_llamada_motivo)
                del_selec = tp_motivoDao.Setmotivos(Me.dgv_motivo.CurrentRow.Cells("ID_MOTIVO").Value, Me.dgv_tp_llamada.CurrentRow.Cells("ID").Value, 0, Login.codusu)
                pre_carga_dgv_tp_motivo()
            End If
        Catch ex As Exception
            MsgBox("Error quitando motivo" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_quitar_c_Click(sender As Object, e As EventArgs) Handles btn_quitar_c.Click
        Try
            If Me.dgv_conclusion.RowCount > 0 Then
                Dim del_selec As New List(Of cct_inc_con)
                del_selec = inc_conDao.SetConclusiones(Me.dgv_conclusion.CurrentRow.Cells("ID_CONCLUSION").Value, Me.dgv_incidencia.CurrentRow.Cells("ID_INCIDENCIA").Value, 0, Login.codusu)
                pre_carga_dgv_i_c()
            End If
        Catch ex As Exception
            MsgBox("Error quitando conclusion" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_quitar_i_Click(sender As Object, e As EventArgs) Handles btn_quitar_i.Click
        Try
            If Me.dgv_incidencia.RowCount > 0 Then
                Dim del_selec As New List(Of cct_mot_inc)
                del_selec = mot_incDao.Setincidencias(Me.dgv_incidencia.CurrentRow.Cells("ID_INCIDENCIA").Value, Me.dgv_motivo.CurrentRow.Cells("ID_MOTIVO").Value, 0, Login.codusu)
                pre_carga_dgv_m_i()
            End If
        Catch ex As Exception
            MsgBox("Error quitando incidencia" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub dgv_tp_llamada_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_tp_llamada.DataSourceChanged
        flag_m = True
        pre_carga_dgv_tp_motivo()
    End Sub
    Private Sub dgv_tp_llamada_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_tp_llamada.SelectionChanged
        flag_m = True
        pre_carga_dgv_tp_motivo()
    End Sub

    Private Sub dgv_motivo_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_motivo.DataSourceChanged
        flag_i = True
        pre_carga_dgv_m_i()
    End Sub
    Private Sub dgv_motivo_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_motivo.SelectionChanged
        flag_i = True
        pre_carga_dgv_m_i()
    End Sub

    Private Sub dgv_incidencia_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_incidencia.DataSourceChanged
        flag_c = True
        pre_carga_dgv_i_c()
    End Sub
    Private Sub dgv_incidencia_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_incidencia.SelectionChanged
        flag_c = True
        pre_carga_dgv_i_c()
    End Sub
End Class