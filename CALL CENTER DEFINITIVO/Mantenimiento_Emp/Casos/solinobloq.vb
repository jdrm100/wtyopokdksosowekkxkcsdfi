Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms

Public Class solinobloq

    Dim factoria_sol As IDaoFactory
    Dim Solnoblotipos_solDao As ISol_noblo_tiposDao
    Dim solnoblo_solDao As ISol_nobloDao
    Dim SolNoBloSelect_solDao As ISol_noblo_selectDao
    Dim age As Array

    Private Sub solinobloq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            factoria_sol = New NHibernateDaoFactory
            Solnoblotipos_solDao = factoria_sol.GetSol_noblo_tiposDao
            solnoblo_solDao = factoria_sol.GetSol_nobloDao
            SolNoBloSelect_solDao = factoria_sol.GetSol_noblo_selectDao

            age = Me.lbl_agente.Text.Split("-")

            Dim list_noblo As New List(Of sol_noblo_select)
            list_noblo = SolNoBloSelect_solDao.SetSolnoblo(99, LTrim(RTrim(age(0))), "", "")
            If Not list_noblo Is Nothing Then
                If list_noblo.Count > 0 Then
                    If (list_noblo.Item(0).ID_NIVEL_PROX <> "99") Or (list_noblo.Item(0).ID_NIVEL_PROX = "99" And list_noblo.Item(0).ID_EST < 6 And list_noblo.Item(0).desc_noblo = "Permanentemente") Then
                        Me.lbl_tipo.Text = list_noblo.Item(0).desc_noblo
                        Me.lbl_fecf.Text = list_noblo.Item(0).fecha_fin
                        Me.lbl_id_sol.Text = list_noblo.Item(0).ID
                        Me.txt_comentario.Text = list_noblo.Item(0).comen
                        Me.cmb_noblo.Visible = False
                        Me.dt_fin.Visible = False
                        Me.txt_comentario.ReadOnly = True
                        Me.btn_cancelar.Text = "Anular"
                        Me.btn_cancelar.Visible = False
                        If list_noblo.Item(0).nomusu = Login.nomusu Then
                            Me.btn_cancelar.Visible = True
                        End If
                        Me.tt_nobloq.SetToolTip(Me.btn_cancelar, "Anular la solictud de NO BLOQUEO")

                    End If
                    carga_dgv_noblo(list_noblo)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub
    Private Sub carga_dgv_noblo(ByVal lista As List(Of sol_noblo_select))

        Me.dgv_noblo.DataSource = lista
        With Me.dgv_noblo.Columns
            .Item("usuario_update").Visible = False
            .Item("usuario_insert").Visible = False
            .Item("id").Visible = False
            .Item("fecha_fin").Visible = False
            .Item("nomusu").Visible = False
            .Item("comen").Visible = False
            .Item("desc_noblo").Visible = False
            .Item("nombre").Visible = False
            .Item("agente").Visible = False
            .Item("id_nivel_prox").Visible = False
            .Item("ID_EST").Visible = False
            '.Item("fecha").Visible = False
        End With
        Me.lbl_t_noblo.Text = lista.Count

        Dim i As Integer
        For i = 0 To lista.Count - 1
            If lista.Item(i).ID_NIVEL_PROX = "99" Then
                If lista.Item(i).ID_EST < 6 Then
                    Me.lbl_a_noblo.Text = Me.lbl_a_noblo.Text + 1
                Else
                    Me.lbl_r_noblo.Text = Me.lbl_r_noblo.Text + 1
                End If
            End If
        Next
    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Me.btn_cancelar.Text = "Anular" Then
            Me.Close()
        Else
            Try
                Dim sol_noblo_list As New List(Of sol_noblo)
                If cmb_noblo.Text <> "" Then
                    If dt_fin.Visible = True And (dt_fin.Value = Today.Date Or dt_fin.Value < Today.Date) Then
                        MsgBox("Por favor, indique la fecha final de solicitud." & Chr(13), MsgBoxStyle.Information, "Call Center")
                        dt_fin.Focus()
                    Else
                        Dim arr_tipo As Array
                        arr_tipo = Me.cmb_noblo.Text.Split("-")
                        sol_noblo_list = solnoblo_solDao.SetSolnoblo(arr_tipo(0), Login.codusu, LTrim(RTrim(age(0))), Me.dt_fin.Text, Me.txt_comentario.Text)
                        If Not sol_noblo_list Is Nothing Then
                            If sol_noblo_list.Count > 0 Then
                                MsgBox("Solicitud de NO BLOQUEO enviada." & Chr(13), MsgBoxStyle.Information, "Call Center")
                                Me.Close()
                            End If
                        End If
                    End If

                Else
                    MsgBox("Seleccione el tipo de solicitud." & Chr(13), MsgBoxStyle.Information, "Call Center")
                    cmb_noblo.Focus()
                End If

            Catch ex As Exception
                MsgBox("Error al enviar solicitud. Verifique los datos!" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
            End Try

        End If
    End Sub

    Private Sub cmb_noblo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_noblo.SelectedIndexChanged
        Dim arr_tipo As Array
        arr_tipo = Me.cmb_noblo.Text.Split("-")
        If arr_tipo(0) = "3" Then
            lbl_fin.Visible = False
            dt_fin.Visible = False
        ElseIf arr_tipo(0) = "1" Then
            'dt_fin.Value = Today.AddDays(9 - Today.DayOfWeek)
            lbl_fin.Visible = True
            dt_fin.Visible = True
        End If
    End Sub
    Private Sub limpia_campos()
        Me.cmb_noblo.Enabled = False
        Me.dt_fin.Enabled = False
        Me.txt_comentario.ReadOnly = True
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If Me.btn_cancelar.Text = "Anular" Then
            Dim sol_noblo_list As New List(Of sol_noblo)
            sol_noblo_list = solnoblo_solDao.SetSolnoblo_a_r(Me.lbl_id_sol.Text, Login.codusu, Login.nivel, "", 2)
            If Not sol_noblo_list Is Nothing Then
                If sol_noblo_list.Count > 0 Then
                    MsgBox("Solicitud de NO BLOQUEO anulada." & Chr(13), MsgBoxStyle.Information, "Call Center")
                End If
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub dgv_noblo_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_noblo.SelectionChanged
        Try
            If Me.dgv_noblo.RowCount > 0 Then
                If Not Me.dgv_noblo.CurrentRow.Cells(0).Value Is Nothing Then

                    Me.lbl_solicita.Text = Me.dgv_noblo.CurrentRow.Cells("nomusu").Value
                    Me.lbl_fi.Text = Me.dgv_noblo.CurrentRow.Cells("fecha").Value
                    Me.lbl_ff.Text = Me.dgv_noblo.CurrentRow.Cells("fecha_fin").Value
                    Me.lbl_desc.Text = Me.dgv_noblo.CurrentRow.Cells("DESC_NOBLO").Value
                    Me.txt_comen.Text = Me.dgv_noblo.CurrentRow.Cells("COMEN").Value
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalle de solicitud: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
End Class