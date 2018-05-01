Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Public Class comp_age
    Dim factoria_comp As IDaoFactory
    Dim cct_comp_ageDao As I_cct_comp_age
    Dim cct_cca_Dao As I_cct_comp_cara_age
    Dim cct_rc_Dao As I_cct_reg_comp
    Dim cct_rca_Dao As I_cct_reg_cara_age
    Dim cct_mat_Dao As I_cct_materiales
    Dim cct_cap_Dao As I_cct_capacitaciones
    Dim cct_rm_Dao As I_cct_reg_mat
    Dim cct_rcap_Dao As I_cct_reg_cap
    Dim cct_mh_dao As I_cct_mat_hist
    Dim cct_ch_dao As I_cct_cap_hist
    Dim l_b_c As New BindingSource
    Dim l_bind As New BindingSource
    Dim s1 As String
    Public list_comp As String
    Private Sub comp_age_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            factoria_comp = New NHibernateDaoFactory
            cct_comp_ageDao = factoria_comp.Getcct_comp_ageDao
            cct_cca_Dao = factoria_comp.Getcct_comp_cara_ageDao
            cct_rc_Dao = factoria_comp.Getcct_reg_compDao
            cct_rca_Dao = factoria_comp.Getcct_reg_cara_ageDao
            cct_mat_Dao = factoria_comp.Getcct_matDao
            cct_cap_Dao = factoria_comp.Getcct_capDao
            cct_rm_Dao = factoria_comp.Getcct_reg_matDao
            cct_rcap_Dao = factoria_comp.Getcct_reg_capDao
            cct_mh_dao = factoria_comp.Getcct_mat_histDao
            cct_ch_dao = factoria_comp.Getcct_cap_histDao
            Dim l_c As New List(Of cct_comp_age)
            l_c = cct_comp_ageDao.GetCompAge(LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), 1)
            carga_dgv_comp_age(l_c)
            Dim l_m As New List(Of cct_materiales) 'cargamos los materiales
            l_m = cct_mat_Dao.GetByMatAct(0, "", 1)
            If Not l_m Is Nothing Then
                cmb_mat.DataSource = l_m
                cmb_mat.DisplayMember = "DESCRIPCION"
                cmb_mat.ValueMember = "ID"
            End If
            cargar_mat_his()
            Dim l_cap As New List(Of cct_capacitaciones) 'cargamos las capacitaciones
            l_cap = cct_cap_Dao.GetByCapAct(0, "", 1)
            If Not l_cap Is Nothing Then
                cmb_cap.DataSource = l_cap
                cmb_cap.DisplayMember = "DESCRIPCION"
                cmb_cap.ValueMember = "ID"
            End If
            cargar_cap_his()
            Me.dtp_fec.MaxDate = Today()
            Me.dtp_fec_c.MaxDate = Today()

        Catch ex As Exception
            MsgBox("Error al cargar el formulario " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_agregar_g_Click(sender As Object, e As EventArgs) Handles btn_agregar_g.Click
        Try
            Dim childform As New comp_age_aux
            childform.lbl_reg_age.Text = LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0)))
            childform.ShowDialog()
            'Carga componentes de agente
            cargar_comp()
        Catch ex As Exception
            MsgBox("Error al cargar el listado de componentes " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_quitar_g_Click(sender As Object, e As EventArgs) Handles btn_quitar_g.Click
        Try
            If dgv_comp.RowCount > 0 Then
                Dim r_c As New List(Of cct_reg_comp)
                Dim ms As MsgBoxResult = MsgBoxResult.Yes
                For Each f As DataGridViewRow In Me.dgv_cara.Rows
                    If Me.dgv_cara.Rows(f.Index).Cells("AGENTE").Value Then
                        ms = MsgBox("Este componente tiene uno o mas caracteristicas asociadas. ¿Desea continuar quitando este componente?", MsgBoxStyle.YesNo, "Call Center")
                        Exit For
                    End If
                Next
                If ms = MsgBoxResult.Yes Then
                    Dim id_a As String = LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0)))
                    r_c = cct_rc_Dao.SetRegComp(id_a, Me.dgv_comp.CurrentRow.Cells("ID").Value, 0)
                    'Carga componentes de agente
                    cargar_comp()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al quitar componente" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cargar_cap_his()
        Dim l_ch As New List(Of cct_cap_hist)
        l_ch = cct_ch_dao.GetByCapAct(LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), 1)
        If Not l_ch Is Nothing Then
            If l_ch.Count > 0 Then
                carga_dgv_cap(l_ch)
                Me.txt_rec_c.Text = ""
                Me.cmb_cap.SelectedIndex() = 0
                Me.dtp_fec_c.Value = Today()
            End If
        Else
            dgv_cap.DataSource = ""
        End If
    End Sub
    Private Sub cargar_mat_his()
        Dim l_mh As New List(Of cct_mat_hist)
        l_mh = cct_mh_dao.GetByHistAct(LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), 1)
        If Not l_mh Is Nothing Then
            If l_mh.Count > 0 Then
                carga_dgv_mat(l_mh)
                Me.txt_cant.Text = ""
                Me.txt_rec.Text = ""
                Me.cmb_mat.SelectedIndex() = 0
                Me.dtp_fec.Value = Today()
            End If
        Else
            dgv_mat.DataSource = ""
        End If
    End Sub
    Private Sub cargar_comp()
        Dim l_c As New List(Of cct_comp_age)
        l_c = cct_comp_ageDao.GetCompAge(LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), 1)
        If Not l_c Is Nothing Then
            If l_c.Count > 0 Then
                carga_dgv_comp_age(l_c)
            Else
                l_bind.Clear()
                l_b_c.Clear()
                Me.lbl_t_c.Text = "0"
            End If
        Else
            l_bind.Clear()
            l_b_c.Clear()
            Me.lbl_t_c.Text = "0"
        End If
    End Sub
    Private Sub carga_dgv_cap(ByVal li_ch As List(Of cct_cap_hist))
        Try
            dgv_cap.DataSource = li_ch
            With dgv_cap.Columns
                .Item("USUARIO_UPDATE").Visible = False
                .Item("USUARIO_INSERT").Visible = False
                .Item("ID_CAP").Visible = False
                .Item("ID").Visible = False
            End With
        Catch ex As Exception
            MsgBox("DataGrid: Error al cargar el listado de capacitaciones" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_mat(ByVal li_mh As List(Of cct_mat_hist))
        Try
            dgv_mat.DataSource = li_mh
            With dgv_mat.Columns
                .Item("USUARIO_UPDATE").Visible = False
                .Item("USUARIO_INSERT").Visible = False
                .Item("ID_MAT").Visible = False
                .Item("ID").Visible = False
            End With
        Catch ex As Exception
            MsgBox("DataGrid: Error al cargar el listado de materiales " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_comp_age(ByVal li_comp As List(Of cct_comp_age))
        Try
            l_b_c.DataSource = li_comp
            dgv_comp.DataSource = l_b_c
            With dgv_comp.Columns
                .Item("USUARIO_UPDATE").Visible = False
                .Item("USUARIO_INSERT").Visible = False
                .Item("CLASIF").Visible = False
                .Item("ACTIVO").Visible = False
                .Item("OBL_SN").Visible = False
                .Item("AGENTE").Visible = False
                .Item("ID").Visible = False
            End With
            Me.lbl_t_c.Text = l_b_c.Count
        Catch ex As Exception
            MsgBox("DataGrid: Error al cargar el listado de componentes " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_cara(ByVal li As List(Of cct_comp_cara_age))
        Try
            l_bind.DataSource = li
            Me.dgv_cara.DataSource = l_bind
            With dgv_cara.Columns
                .Item("USUARIO_UPDATE").Visible = False
                .Item("USUARIO_INSERT").Visible = False
                .Item("FEC").Visible = False
                .Item("FEC_UPDATE").Visible = False
                .Item("CODUSU_UPDATE").Visible = False
                .Item("SERIAL1").Visible = False
                .Item("SERIAL2").Visible = False
                .Item("S1").Visible = False
                .Item("OBL_S1").Visible = False
                .Item("S2").Visible = False
                .Item("OBL_S2").Visible = False
                .Item("ID").Visible = False
            End With
        Catch ex As Exception
            MsgBox("DataGrid: Error al cargar el listado de caracteristicas " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub dgv_comp_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_comp.SelectionChanged
        Try
            If dgv_comp.RowCount > 0 Then
                Dim l_cca As New List(Of cct_comp_cara_age)
                l_cca = cct_cca_Dao.GetCaraActByAge(LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), Me.dgv_comp.CurrentRow.Cells("ID").Value, 1)
                If Not l_cca Is Nothing Then
                    If l_cca.Count > 0 Then
                        carga_dgv_cara(l_cca)
                    Else
                        l_bind.Clear()
                    End If
                Else
                    l_bind.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("DataGrid: Error al seleccionar componente " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
    Private Sub dgv_cara_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cara.CellContentClick
        'Try
        '    If Me.dgv_cara.RowCount > 0 Then
        '        If Me.dgv_cara.CurrentRow.Cells("AGENTE").Selected Then
        '            If Me.dgv_cara.CurrentRow.Cells("AGENTE").Value = True Then
        '                Me.dgv_cara.CurrentRow.Cells("AGENTE").Value = False
        '            Else
        '                Me.dgv_cara.CurrentRow.Cells("AGENTE").Value = True
        '                If Me.txt_s1.Visible Then
        '                    Me.txt_s1.Focus()
        '                End If
        '            End If
        '        End If

        '    End If
        'Catch ex As Exception
        '    MsgBox("Error en la seleccion de caracteristicas." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        'End Try
    End Sub
    Private Sub dgv_cara_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_cara.SelectionChanged
        If dgv_cara.RowCount > 0 Then
            'Me.lbl_s1.Visible = Me.dgv_cara.CurrentRow.Cells("S1").Value
            'Me.txt_s1.Visible = Me.dgv_cara.CurrentRow.Cells("S1").Value
            Me.lbl_s2.Visible = Me.dgv_cara.CurrentRow.Cells("S2").Value
            Me.txt_s2.Visible = Me.dgv_cara.CurrentRow.Cells("S2").Value

            Me.txt_s1.Text = Me.dgv_cara.CurrentRow.Cells("SERIAL1").Value
            Me.txt_s2.Text = Me.dgv_cara.CurrentRow.Cells("SERIAL2").Value
        Else
            Me.lbl_s2.Visible = Me.txt_s2.Visible = False
        End If
    End Sub
    Private Sub txt_s1_GotFocus(sender As Object, e As EventArgs) Handles txt_s1.GotFocus
        s1 = Me.txt_s1.Text
    End Sub
    Private Sub txt_s1_LostFocus(sender As Object, e As EventArgs) Handles txt_s1.LostFocus
        Try
            If Me.dgv_cara.CurrentRow.Cells("AGENTE").Value = True Then
                'Verificamo si es obligatorio el serial y si no esta vacio, de lo contrario solo se guarda
                If Me.dgv_cara.CurrentRow.Cells("OBL_S1").Value = 1 And Me.txt_s1.Text = "" Then
                    MsgBox("El Serial es obligatorio, debe especificarlo para guardar el registro." & Chr(13), MsgBoxStyle.Exclamation, "Call Center")
                    Me.tb_reg.SelectedIndex() = 0
                    Me.txt_s1.Focus()
                Else
                    'Salvamos el registro
                    'Si cambiamos el Serial el sistema quita el material anterior e inserta el nuevo registro
                    If s1 = "" Or s1 = "0" Then
                        'Nuevo registro
                        Dim l_rca As New List(Of cct_reg_cara_age)
                        l_rca = cct_rca_Dao.SetRegCara(LTrim(RTrim(Split(lbl_reg_age.Text, "-")(0))), Me.dgv_comp.CurrentRow.Cells("ID").Value, Me.dgv_cara.CurrentRow.Cells("ID").Value, Me.txt_s1.Text, 0, 1, 0)
                    ElseIf s1 <> Me.txt_s1.Text Then
                        'Actualiza registro
                        'Mensaje de confirmacion para guardar los cambios en caso de actualizar.
                        Dim l_rca As New List(Of cct_reg_cara_age)
                        l_rca = cct_rca_Dao.SetRegCara(LTrim(RTrim(Split(lbl_reg_age.Text, "-")(0))), Me.dgv_comp.CurrentRow.Cells("ID").Value, Me.dgv_cara.CurrentRow.Cells("ID").Value, Me.txt_s1.Text, 0, 1, 1)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en el campo de Serial" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub txt_s2_LostFocus(sender As Object, e As EventArgs) Handles txt_s2.LostFocus
        Try
            If Me.dgv_cara.CurrentRow.Cells("AGENTE").Value = True Then
                If Me.dgv_cara.CurrentRow.Cells("OBL_S2").Value = 1 And Me.txt_s2.Text = "" Then
                    MsgBox("El Numero es obligatorio, debe especificarlo para guardar el registro." & Chr(13), MsgBoxStyle.Exclamation, "Call Center")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en el campo de Numero" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_a_mat_Click(sender As Object, e As EventArgs) Handles btn_a_mat.Click
        Try
            If Me.cmb_mat.SelectedIndex <> 0 Then
                If IsNumeric(Me.txt_cant.Text) = True Then
                    If Convert.ToDecimal(Me.txt_cant.Text) > 0.0 Then
                        If Me.txt_rec.Text <> "" Then
                            Dim l_rm As New List(Of cct_reg_mat)
                            l_rm = cct_rm_Dao.SetRegMat(Me.cmb_mat.SelectedValue, Me.txt_cant.Text, LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), Me.txt_rec.Text, "", LTrim(RTrim(Split(Me.lbl_cont.Text, "-")(0))), Me.dtp_fec.Text, "", 0, Login.codusu, 1, 0)
                            cargar_mat_his()
                        Else
                            MsgBox("Debe especificar la persona que recibe los materiales", MsgBoxStyle.Information, "Call Center")
                            Me.txt_rec.Focus()
                        End If
                    Else
                        MsgBox("Debe especificar la cantidad entregada", MsgBoxStyle.Information, "Call Center")
                        Me.txt_cant.Focus()
                    End If
                Else
                    MsgBox("Debe especificar la cantidad entregada", MsgBoxStyle.Information, "Call Center")
                    Me.txt_cant.Focus()
                End If
            Else
                MsgBox("Debe seleccionar el material a entregar", MsgBoxStyle.Information, "Call Center")
                Me.cmb_mat.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error al agregar materiales" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_q_mat_Click(sender As Object, e As EventArgs) Handles btn_q_mat.Click
        Try
            If Me.dgv_mat.RowCount > 0 Then
                Dim ms As MsgBoxResult = MsgBoxResult.Yes
                ms = MsgBox("Se anulara el registro seleccionado. ¿Desea continuar?", MsgBoxStyle.YesNo, "Call Center")
                If ms = MsgBoxResult.Yes Then
                    Dim l_rm As New List(Of cct_reg_mat)
                    l_rm = cct_rm_Dao.SetRegMat(0, 0.0, "", "", "", 0, "", "", 0, Login.codusu, 0, Me.dgv_mat.CurrentRow.Cells("ID").Value)
                    cargar_mat_his()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al quitar registro" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_a_c_Click(sender As Object, e As EventArgs) Handles btn_a_c.Click
        Try
            If Me.cmb_cap.SelectedIndex <> 0 Then
                If Me.txt_rec_c.Text <> "" Then
                    Dim l_rcap As New List(Of cct_reg_cap)
                    l_rcap = cct_rcap_Dao.SetRegCap(Me.cmb_cap.SelectedValue, LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), Me.txt_rec_c.Text, "", LTrim(RTrim(Split(Me.lbl_cont.Text, "-")(0))), Me.dtp_fec_c.Text, "", 0, Login.codusu, 1, 0)
                    cargar_cap_his()
                Else
                    MsgBox("Debe especificar la persona que recibe la capacitacion", MsgBoxStyle.Information, "Call Center")
                    Me.txt_rec_c.Focus()
                End If
            Else
                MsgBox("Debe seleccionar el tipo de capacitacion", MsgBoxStyle.Information, "Call Center")
                Me.cmb_cap.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error al agregar capacitacion" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_q_cap_Click(sender As Object, e As EventArgs) Handles btn_q_cap.Click
        Try
            If Me.dgv_cap.RowCount > 0 Then
                Dim ms As MsgBoxResult = MsgBoxResult.Yes
                ms = MsgBox("Se anulara el registro seleccionado. ¿Desea continuar?", MsgBoxStyle.YesNo, "Call Center")
                If ms = MsgBoxResult.Yes Then
                    Dim l_rc As New List(Of cct_reg_cap)
                    l_rc = cct_rcap_Dao.SetRegCap(0, "", "", "", 0, "", "", 0, Login.codusu, 0, Me.dgv_cap.CurrentRow.Cells("ID").Value)
                    cargar_cap_his()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al quitar registro" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_agr_ca_Click(sender As Object, e As EventArgs) Handles btn_agr_ca.Click
        Try
            Dim childform As New comp_carac_aux
            childform.lbl_comp.Text = Me.dgv_comp.CurrentRow.Cells("descripcion_comp").Value
            childform.lbl_id_comp.Text = Me.dgv_comp.CurrentRow.Cells("ID").Value
            childform.lbl_age.Text = LTrim(RTrim(Split(lbl_reg_age.Text, "-")(0)))
            'Cargamos las caracteristicas del componente seleccionado
            If dgv_comp.RowCount > 0 Then

                If dgv_cara.RowCount > 0 And Me.dgv_comp.CurrentRow.Cells("ID").Value <> 8 Then
                    MsgBox("Este componente ya tiene una caracteristica asignada.", MsgBoxStyle.Information, "Call Center")
                Else
                    Dim l_cca As New List(Of cct_comp_cara_age)
                    l_cca = cct_cca_Dao.GetCaraByAge(LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), Me.dgv_comp.CurrentRow.Cells("ID").Value)
                    If Not l_cca Is Nothing Then
                        If l_cca.Count > 0 Then
                            childform.cmb_carac.DataSource = l_cca
                            childform.cmb_carac.DisplayMember = "DESCRIPCION"
                            childform.cmb_carac.ValueMember = "ID"

                            childform.ShowDialog()

                            l_cca = cct_cca_Dao.GetCaraActByAge(LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), Me.dgv_comp.CurrentRow.Cells("ID").Value, 1)
                            If Not l_cca Is Nothing Then
                                If l_cca.Count > 0 Then
                                    carga_dgv_cara(l_cca)
                                Else
                                    l_bind.Clear()
                                End If
                            Else
                                l_bind.Clear()
                            End If

                        End If
                    End If
                End If


            Else
                MsgBox("Debe agregar un componente", MsgBoxStyle.Information, "Call Center")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar el listado de componentes " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub dgv_comp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_comp.CellContentClick

    End Sub

    Private Sub txt_s1_TextChanged(sender As Object, e As EventArgs) Handles txt_s1.TextChanged

    End Sub

    Private Sub btn_qui_ca_Click(sender As Object, e As EventArgs) Handles btn_qui_ca.Click
        Try
            'quitar registro
            Dim l_rcar As New List(Of cct_reg_cara_age)
            l_rcar = cct_rca_Dao.SetRegCara(LTrim(RTrim(Split(lbl_reg_age.Text, "-")(0))), Me.dgv_comp.CurrentRow.Cells("ID").Value, Me.dgv_cara.CurrentRow.Cells("ID").Value, Me.txt_s1.Text, 0, 0, 0)

            Dim l_cca As New List(Of cct_comp_cara_age)
            l_cca = cct_cca_Dao.GetCaraActByAge(LTrim(RTrim(Split(Me.lbl_reg_age.Text, "-")(0))), Me.dgv_comp.CurrentRow.Cells("ID").Value, 1)
            If Not l_cca Is Nothing Then
                If l_cca.Count > 0 Then
                    carga_dgv_cara(l_cca)
                Else
                    l_bind.Clear()
                End If
            Else
                l_bind.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error al quitar caracteristica" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
        
    End Sub
End Class