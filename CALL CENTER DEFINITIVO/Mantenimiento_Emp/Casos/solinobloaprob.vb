Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Public Class solinobloaprob

    Dim factoria_noblo As IDaoFactory
    Dim SolNoBloSelectDao As ISol_noblo_selectDao
    Dim agente_nobloDao As IAgenteDao
    Dim QJM_cua_s_nobloDao As IQJM_cua_sDao
    Dim Facperiodo_nobloDao As IFacperiodoDao
    Dim empleado_nobloDao As IEmpleadoDao
    Dim callcenteradm_nobloDao As ICallcenteradmDao
    Dim gestores_nobloDao As IGestoresDao
    Dim solnoblo_sol2Dao As ISol_nobloDao
    Private Sub solinobloaprob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            factoria_noblo = New NHibernateDaoFactory
            SolNoBloSelectDao = factoria_noblo.GetSol_noblo_selectDao
            agente_nobloDao = factoria_noblo.GetAgenteDao
            QJM_cua_s_nobloDao = factoria_noblo.GetQJM_cua_sDao
            Facperiodo_nobloDao = factoria_noblo.GetFacperiodoDao
            callcenteradm_nobloDao = factoria_noblo.GetCallcenteradmDao
            empleado_nobloDao = factoria_noblo.GetEmpleadoDao
            gestores_nobloDao = factoria_noblo.GetGestoresDao
            solnoblo_sol2Dao = factoria_noblo.GetSol_nobloDao

            consulta_age(Login.nivel, "", "", "")
        Catch ex As Exception
            MsgBox("Error al cargar formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub consulta_age(nivel As Integer, cod_age As String, nom_age As String, est As String)
        Dim list_age As New List(Of sol_noblo_select)
        list_age = SolNoBloSelectDao.SetSolnoblo(nivel, cod_age, nom_age, est)
        If Not list_age Is Nothing Then
            If list_age.Count > 0 Then
                carga_dgv_agentes(list_age)
            End If
        Else
            limpia_campos()
            btn_a.Enabled = False
            btn_r.Enabled = False
       
        End If
    End Sub
    Private Sub carga_dgv_agentes(ByVal list_agentes As List(Of sol_noblo_select))
        Try
            Me.dgv_agentes.DataSource = list_agentes
            With Me.dgv_agentes.Columns
                .Item("usuario_update").Visible = False
                .Item("usuario_insert").Visible = False
                .Item("nomusu").Visible = False
                .Item("comen").Visible = False
                .Item("fecha").Visible = False
                .Item("fecha_fin").Visible = False
                .Item("desc_noblo").Visible = False
                .Item("id").Visible = False
                .Item("ID_NIVEL_PROX").Visible = False
                .Item("DESC_ESTADO").Visible = False
                .Item("id_est").Visible = False
            End With
            If list_agentes.Count > 0 Then
                Me.lbl_solicita.Text = Me.dgv_agentes.CurrentRow.Cells("nomusu").Value
                Me.lbl_fi.Text = Me.dgv_agentes.CurrentRow.Cells("fecha").Value
                Me.lbl_ff.Text = Me.dgv_agentes.CurrentRow.Cells("fecha_fin").Value
                Me.lbl_desc.Text = Me.dgv_agentes.CurrentRow.Cells("DESC_NOBLO").Value
                Me.txt_comen.Text = Me.dgv_agentes.CurrentRow.Cells("COMEN").Value
            End If


            Me.lbl_total.Text = list_agentes.Count
        Catch ex As Exception
            'MsgBox("Error al cargar agentes. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try


    End Sub
    Private Sub carga_dgv_historial(ByVal list_callcenter As List(Of callcenteradm))
        Me.dgv_historial.DataSource = list_callcenter
        With Me.dgv_historial.Columns
            .Item("usuario_update").Visible = False
            .Item("usuario_insert").Visible = False
            .Item("codage").Visible = False
            .Item("ID").Visible = False
            .Item("comcie").Visible = False
            .Item("probsys").Visible = False
            .Item("feccie").Visible = False
            .Item("gescie").Visible = False
            .Item("rescall").Visible = False
            .Item("llamar").Visible = False
            .Item("ticket").Visible = False
            .Item("movcall").Visible = False
            .Item("horrec").Visible = False
            .Item("tipo").Visible = False
            .Item("cerrado").Visible = False
            .Item("codges").Visible = False
            .Item("fecrec").Visible = False
        End With
    End Sub
    Private Sub carga_datos_agens(ByVal list_agentes As List(Of agente))
        Dim ret As String = ""

        Me.txt_bal.Text = list_agentes.Item(0).baldia.ToString("C")
        Me.txt_ciudad.Text = list_agentes.Item(0).ciudad
        Me.txt_tel1.Text = list_agentes.Item(0).telefono1
        Me.txt_tel2.Text = list_agentes.Item(0).telefono2
        Me.txt_telcon1.Text = list_agentes.Item(0).telcon1
        Me.txt_dir.Text = list_agentes.Item(0).direccion
        Me.txt_rep.Text = list_agentes.Item(0).nomrep
        Me.txt_ruta.Text = list_agentes.Item(0).codasi
        Me.txt_fax.Text = list_agentes.Item(0).fax
        ret = IIf(list_agentes.Item(0).retirada = "1", "/Retirada", "")
        Me.txt_bloq.Text = IIf(list_agentes.Item(0).bloqueada = 1, "Bloqueada" & ret, "Activa" & ret)
        Me.txt_clas.Text = list_agentes.Item(0).clasif

        'Me.txt_agente.Text = Me.txt_agente.Text & " - " & list_agentes.Item(0).nombre

        'Carga cuadre semanal QJM
        Dim list_cua As New List(Of qjm_cua_s)
        list_cua = QJM_cua_s_nobloDao.GetByAgente(list_agentes.Item(0).ID)
        If Not list_cua Is Nothing Then
            If list_cua.Count > 0 Then
                Me.txt_qjm_cua.Text = list_cua.Item(0).monto.ToString("C")
                Me.tt1.SetToolTip(Me.txt_qjm_cua, "QJM - Al corte del: " & list_cua.Item(0).fec_fin)
            Else
                Me.txt_qjm_cua.Text = "---"
                Me.tt1.SetToolTip(Me.txt_qjm_cua, "---")
            End If
        End If

        'Carga Factura Loto Real
        Dim list_fac As New List(Of facperiodo)
        list_fac = Facperiodo_nobloDao.GetByCodage(list_agentes.Item(0).ID)
        If Not list_fac Is Nothing Then
            If list_fac.Count > 0 Then
                Me.txt_fac_loto.Text = list_fac.Item(0).monto.ToString("C")
                Me.tt1.SetToolTip(Me.txt_fac_loto, "LR - Al corte del: " & list_fac.Item(0).fecfin)
            Else
                Me.txt_fac_loto.Text = "---"
                Me.tt1.SetToolTip(Me.txt_fac_loto, "---")
            End If
        End If
        


    End Sub

    Private Sub dgv_agentes_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_agentes.SelectionChanged
        Try
            If Me.dgv_agentes.RowCount > 0 Then
                If Not Me.dgv_agentes.CurrentRow.Cells(0).Value Is Nothing Then

                    Me.lbl_solicita.Text = Me.dgv_agentes.CurrentRow.Cells("nomusu").Value
                    Me.lbl_fi.Text = Me.dgv_agentes.CurrentRow.Cells("fecha").Value
                    Me.lbl_ff.Text = Me.dgv_agentes.CurrentRow.Cells("fecha_fin").Value
                    Me.lbl_desc.Text = Me.dgv_agentes.CurrentRow.Cells("DESC_NOBLO").Value
                    Me.txt_comen.Text = Me.dgv_agentes.CurrentRow.Cells("COMEN").Value

                    Dim age As New List(Of agente)
                    age = agente_nobloDao.GetByCodgtech(Me.dgv_agentes.CurrentRow.Cells("AGENTE").Value, "", "", "", "")
                    If Not age Is Nothing Then
                        If age.Count > 0 Then
                            carga_datos_agens(age)
                        End If
                    End If
                    
                    If IsNumeric(Me.txt_ruta.Text) Then
                        Dim emp As New List(Of empleado)
                        emp = empleado_nobloDao.GetByCodemp(Me.txt_ruta.Text)
                        If Not emp Is Nothing Then
                            If emp.Count > 0 Then
                                Me.txt_eje.Text = emp.Item(0).nomemp & " " & emp.Item(0).apeemp
                            End If
                        End If
                    End If

                    Dim ges As New List(Of gestores)
                    ges = gestores_nobloDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("AGENTE").Value)
                    If ges.Count > 0 Then
                        Me.txt_ges.Text = ges.Item(0).nomges
                    End If

                    If Me.cmb_hist.SelectedIndex = 0 Then
                        Dim list_hist As New List(Of callcenteradm)
                        list_hist = callcenteradm_nobloDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("AGENTE").Value, Me.cmb_hist.SelectedItem)
                        If Not list_hist Is Nothing Then
                            If list_hist.Count > 0 Then
                                carga_dgv_historial(list_hist)
                            Else
                                Dim l_v As New List(Of callcenteradm)
                                carga_dgv_historial(l_v)
                            End If
                        Else
                            Dim l_v As New List(Of callcenteradm)
                            carga_dgv_historial(l_v)
                        End If
                    Else
                        Me.cmb_hist.SelectedIndex = 0
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalle de Agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_a_Click(sender As Object, e As EventArgs) Handles btn_a.Click
        If Me.dgv_agentes.RowCount > 0 Then
            Dim sol_noblo_list As New List(Of sol_noblo)
            sol_noblo_list = solnoblo_sol2Dao.SetSolnoblo_a_r(Me.dgv_agentes.CurrentRow.Cells("ID").Value, Login.codusu, Login.nivel, "", 1)
            If Not sol_noblo_list Is Nothing Then
                If sol_noblo_list.Count > 0 Then
                    MsgBox("Solicitud de NO BLOQUEO Aprobada y reeminitda." & Chr(13), MsgBoxStyle.Information, "Call Center")
                    consulta_age(Login.nivel, "", "", "")
                End If
            End If
        Else
            MsgBox("Seleccione el Agente." & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End If

    End Sub

    Private Sub btn_r_Click(sender As Object, e As EventArgs) Handles btn_r.Click
        If Me.dgv_agentes.RowCount > 0 Then
            Dim sol_noblo_list As New List(Of sol_noblo)
            sol_noblo_list = solnoblo_sol2Dao.SetSolnoblo_a_r(Me.dgv_agentes.CurrentRow.Cells("ID").Value, Login.codusu, Login.nivel, "", 0)
            If Not sol_noblo_list Is Nothing Then
                If sol_noblo_list.Count > 0 Then
                    MsgBox("Solicitud de NO BLOQUEO Rechazada." & Chr(13), MsgBoxStyle.Information, "Call Center")
                    consulta_age(Login.nivel, "", "", "")
                End If
            End If
        Else
            MsgBox("Seleccione el Agente." & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End If

    End Sub

    Private Sub lbl_comen_DoubleClick(sender As Object, e As EventArgs) Handles lbl_comen.DoubleClick
        Try
            Dim childform As New comentario
            With childform
                .lbl_contacto.Text = Me.lbl_solicita.Text
                .lbl_fecha.Text = Me.lbl_fi.Text
                .txt_comentario.Text = Me.txt_comen.Text
            End With
            childform.ShowDialog()
        Catch ex As Exception
            MsgBox("Error en la carga el detalle del comentario." & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub dgv_historial_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historial.CellContentDoubleClick
        Try
            If Me.dgv_historial.RowCount > 0 Then
                Dim childform As New comentario

                With childform
                    .lbl_contacto.Text = Me.dgv_historial.CurrentRow.Cells("percon").Value
                    .lbl_fecha.Text = Me.dgv_historial.CurrentRow.Cells("feccall").Value
                    .txt_comentario.Text = Me.dgv_historial.CurrentRow.Cells("comentario").Value
                End With

                childform.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox("Error en la carga el detalle del comentario." & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub dgv_agentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agentes.CellContentClick

    End Sub

    Private Sub btn_hist_nb_Click(sender As Object, e As EventArgs) Handles btn_hist_nb.Click
        Try
            If Me.dgv_agentes.RowCount > 0 Then

                Dim childform As New solinobloq
                
                With childform
                    .lbl_agente.Text = Me.dgv_agentes.CurrentRow.Cells("AGENTE").Value + " - " + Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
                End With

                childform.ShowDialog()

            Else
                MsgBox("Realize una consulta y seleccione el Agente." & Chr(13), MsgBoxStyle.Critical, "Call Center")
                Me.txt_agente.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la carga de Solicitud de NO BLOQUEO" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub limpia_campos()
        Me.txt_bal.Text = ""
        Me.txt_ciudad.Text = ""
        Me.txt_tel1.Text = ""
        Me.txt_tel2.Text = ""
        Me.txt_telcon1.Text = ""
        Me.txt_dir.Text = ""
        Me.txt_rep.Text = ""
        Me.txt_ruta.Text = ""
        Me.txt_bloq.Text = ""
        Me.txt_eje.Text = ""
        Me.txt_fax.Text = ""
        Me.txt_fac_loto.Text = ""
        Me.txt_qjm_cua.Text = ""

        Me.dgv_historial.DataSource = ""
        ''Me.dgv_historial.DataSource = Nothing

        Me.dgv_agentes.DataSource = ""
        ' Me.dgv_agentes.DataSource = Nothing

    End Sub
    Private Sub carga_agentes()
        Try

            Dim list_age As New List(Of sol_noblo_select)
            Dim nivel_a As Integer = 0
            Dim est_a As String = ""
            If cmb_est.SelectedIndex() = 0 Then
                nivel_a = Login.nivel
            ElseIf cmb_est.SelectedIndex() = 1 Then
                nivel_a = 99
                est_a = "a"
            ElseIf cmb_est.SelectedIndex() = 2 Then
                nivel_a = 99
                est_a = "r"
            End If
            If IsNumeric(Me.txt_agente.Text) Then
                list_age = SolNoBloSelectDao.SetSolnoblo(nivel_a, Me.txt_agente.Text, "", est_a)
            Else
                list_age = SolNoBloSelectDao.SetSolnoblo(nivel_a, "", Me.txt_agente.Text, est_a)
            End If

            If Not list_age Is Nothing Then
                If list_age.Count > 0 Then
                    carga_dgv_agentes(list_age)
                End If
            Else

                limpia_campos()
                btn_a.Enabled = False
                btn_r.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error al cargar agentes" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub cmb_est_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_est.SelectedIndexChanged
        If cmb_est.SelectedIndex() = 1 Then
            consulta_age(99, "", "", "a")
            gb_est.Visible = True
            btn_r_apro.Visible = True
            Try
                lbl_estado.Text = Me.dgv_agentes.CurrentRow.Cells("DESC_ESTADO").Value
            Catch ex As Exception

            End Try
        ElseIf cmb_est.SelectedIndex() = 0 Then
            consulta_age(Login.nivel, "", "", "")
            gb_est.Visible = False
        ElseIf cmb_est.SelectedIndex() = 2 Then
            consulta_age(99, "", "", "r")
            gb_est.Visible = True
            btn_r_apro.Visible = False
            Try
                lbl_estado.Text = Me.dgv_agentes.CurrentRow.Cells("DESC_ESTADO").Value
            Catch ex As Exception

            End Try
        End If
        txt_agente.Text = ""
    End Sub

    Private Sub txt_agente_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_agente.KeyUp
        If e.KeyCode = Keys.Enter Then
            If Me.txt_agente.Focused Then
                carga_agentes()
            End If
        End If
    End Sub

    Private Sub txt_agente_TextChanged(sender As Object, e As EventArgs) Handles txt_agente.TextChanged

    End Sub

    Private Sub btn_r_apro_Click(sender As Object, e As EventArgs) Handles btn_r_apro.Click
        If Me.dgv_agentes.RowCount > 0 Then
            Dim sol_noblo_list As New List(Of sol_noblo)
            sol_noblo_list = solnoblo_sol2Dao.SetSolnoblo_a_r(Me.dgv_agentes.CurrentRow.Cells("ID").Value, Login.codusu, Login.nivel, "", 0)
            If Not sol_noblo_list Is Nothing Then
                If sol_noblo_list.Count > 0 Then
                    MsgBox("Solicitud de NO BLOQUEO Rechazada." & Chr(13), MsgBoxStyle.Information, "Call Center")
                    consulta_age(99, "", "", "a")
                End If
            End If
        Else
            MsgBox("Seleccione el Agente." & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End If
    End Sub
End Class