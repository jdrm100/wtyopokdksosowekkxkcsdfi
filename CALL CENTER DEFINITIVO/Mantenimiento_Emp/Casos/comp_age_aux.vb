Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms

Public Class comp_age_aux
    Dim fact_comp_aux As IDaoFactory

    Dim cct_compoDao As I_cct_componentes_Dao
    Dim cct_rcDao As I_cct_reg_comp
    Dim l_bind As New BindingSource
    Private Sub comp_age_aux_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fact_comp_aux = New NHibernateDaoFactory
            cct_compoDao = fact_comp_aux.Getcct_componentesDao
            cct_rcDao = fact_comp_aux.Getcct_reg_compDao
            Dim li_comp As New List(Of cct_componentes)
            li_comp = cct_compoDao.GetByID_Comp("", "", 1, 1, LTrim(RTrim(Me.lbl_reg_age.Text)))
            If Not li_comp Is Nothing Then
                If li_comp.Count > 0 Then
                    carga_dgv_ccomp(li_comp)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar el formulario." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_ccomp(ByVal li As List(Of cct_componentes))
        l_bind.DataSource = li
        Me.dgv_comp.DataSource = l_bind
        With dgv_comp.Columns
            .Item("USUARIO_UPDATE").Visible = False
            .Item("USUARIO_INSERT").Visible = False
            .Item("ID").Visible = False
            .Item("obl_sn").Visible = False
            .Item("activo").Visible = False
        End With
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try
            If Me.lbl_selected.Text = "0" Then
                Dim ms As MsgBoxResult = MsgBox("No ha seleccionado ningun componente. ¿Desea salir?", MsgBoxStyle.YesNo, "Call Center")
                If ms = MsgBoxResult.Yes Then
                    Me.Close()
                End If
            Else
                'Agregar los componentes seleccionados
                Dim ids As String = ""
                For Each fila As DataGridViewRow In Me.dgv_comp.Rows
                    If Me.dgv_comp.Rows(fila.Index).Cells("selec").Value Then
                        Dim reg_c As New List(Of cct_reg_comp)
                        Dim id_comp As Integer = Me.dgv_comp.Rows(fila.Index).Cells("ID").Value
                        reg_c = cct_rcDao.SetRegComp(Me.lbl_reg_age.Text, id_comp, 1)
                    End If
                Next
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error agregando componentes." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub dgv_comp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_comp.CellContentClick
        Try
            If Me.dgv_comp.RowCount > 0 Then
                If Me.dgv_comp.CurrentRow.Cells("selec").Value = True Then
                    Me.dgv_comp.CurrentRow.Cells("selec").Value = False
                Else
                    Me.dgv_comp.CurrentRow.Cells("selec").Value = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion de componente." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub dgv_comp_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_comp.CellValueChanged
        Try
            If dgv_comp.RowCount > 0 Then
                If dgv_comp.Rows(e.RowIndex).Cells("selec").Value() Then
                    Me.lbl_selected.Text = Me.lbl_selected.Text + 1
                Else
                    Me.lbl_selected.Text = Me.lbl_selected.Text - 1
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al sumar componente." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub chk_selec_CheckedChanged(sender As Object, e As EventArgs) Handles chk_selec.CheckedChanged
        Try
            Dim val As Boolean = Me.chk_selec.CheckState
            For Each fila As DataGridViewRow In Me.dgv_comp.Rows
                If Me.dgv_comp.Rows(fila.Index).Cells("selec").Value <> val Then
                    Me.dgv_comp.Rows(fila.Index).Cells("selec").Value = val
                End If
            Next
        Catch ex As Exception
            MsgBox("Error en la seleccion de componente." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
End Class