Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Reflection
Public Class cc_tecnico
    Dim fac_cct As IDaoFactory
    Dim age_cctDao As IAgenteDao
    Dim empl_cctDao As IEmpleadoDao
    Dim gest_cctsDao As IGestoresDao
    Dim cctDao As ICallcenteradmDao
    Dim tp_llamaDao As I_tp_llamada_Dao
    Dim tp_motDao As I_tp_llamada_motivo_Dao
    Dim mot_incDao As I_mot_inc_Dao
    Dim inc_conDao As I_inc_con_Dao
    Dim R_llamaDao As I_cct_reg_llamada
    Dim r_tkDao As I_cct_reg_tk
    Dim llamadaDao As I_cct_llamadas
    Dim emplDao As I_empl_Dao
    Dim age_sv_cctDao As I_age_sv_Dao
    Dim histDao As I_cct_h_ll_age
    Dim histllaDao As I_cct_h_ll

    Dim cont As String = ""
    Dim codusu_cct As String
    Dim nivelusu As String
    Dim tini As String
    Dim tfin As String
    Dim url_cord As String
    Dim reg_bind As New BindingSource
    Dim h_bind As New BindingSource
    Dim result As String
    Private _dt As New DataTable
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.Enter Then
            Me.btn_guardar.PerformClick()
            'e.Handled = False
        End If
        If e.Control AndAlso e.KeyCode = Keys.A Then
            Me.txt_agente.Focus()
        End If
    End Sub
    Private Sub txt_agente_GotFocus(sender As Object, e As EventArgs) Handles txt_agente.GotFocus
        If txt_agente.Text = txt_agente.Tag.ToString.ToUpper Then
            txt_agente.Text = ""
            Me.txt_agente.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txt_agente_LostFocus(sender As Object, e As EventArgs) Handles txt_agente.LostFocus
        If txt_agente.Text = "" Then
            txt_agente.Text = txt_agente.Tag
            Me.txt_agente.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub cc_tecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            fac_cct = New NHibernateDaoFactory
            age_cctDao = fac_cct.GetAgenteDao
            empl_cctDao = fac_cct.GetEmpleadoDao
            gest_cctsDao = fac_cct.GetGestoresDao
            cctDao = fac_cct.GetCallcenteradmDao
            tp_llamaDao = fac_cct.Get_tp_llamada_Dao
            tp_motDao = fac_cct.Get_tp_llamada_motivo_cct_Dao
            mot_incDao = fac_cct.Get_mot_inc_cct_Dao
            inc_conDao = fac_cct.Get_inc_con_Dao
            R_llamaDao = fac_cct.Getcct_reg_llamadaDao
            r_tkDao = fac_cct.Getcct_reg_tkDao
            llamadaDao = fac_cct.Getcct_llamadaDao
            emplDao = fac_cct.Get_emplDao
            age_sv_cctDao = fac_cct.Get_age_svDao
            histDao = fac_cct.Getcct_h_ll_ageDao
            histllaDao = fac_cct.Getcct_h_llDao

            Me.lbl_nom.Text = Login.nomusu
            codusu_cct = Login.codusu
            nivelusu = Login.nivel
            'cargamos los tipos de llamadas
            Dim l_tp_llama As New List(Of cct_tp_llamda)
            l_tp_llama = tp_llamaDao.GetByEstado(0, "", 1)
            If Not l_tp_llama Is Nothing Then
                Me.cmb_tip.DataSource = l_tp_llama
                Me.cmb_tip.DisplayMember = "DESCRIPCION"
                Me.cmb_tip.ValueMember = "ID"
            End If
            cmb_tip.SelectedIndex = 1
            'cargamos los empleados
            Dim l_emp As New List(Of Seguridad.empl)
            l_emp = emplDao.GetByempl("", "", "", "1")
            cmb_eje.Items.Add("")
            cmb_tec.Items.Add("")
            If Not l_emp Is Nothing Then
                For Each li As Seguridad.empl In l_emp
                    If li.ID.Contains("EJE") Then
                        cmb_eje.Items.Add(li.NOMBRE)
                    Else
                        cmb_tec.Items.Add(li.NOMBRE)
                    End If
                Next
            End If

            Dim items(Me.ImageList1.Images.Count - 1) As String
            For i As Int32 = 0 To Me.ImageList1.Images.Count - 1
                items(i) = "item " & i.ToString
            Next

            Me.cmb_icon.Items.AddRange(items)
            Me.cmb_icon.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmb_icon.DrawMode = DrawMode.OwnerDrawVariable
            Me.cmb_icon.ItemHeight = Me.ImageList1.ImageSize.Height
            Me.cmb_icon.Width = Me.ImageList1.ImageSize.Width + 25
            Me.cmb_icon.MaxDropDownItems = Me.ImageList1.Images.Count
            Me.cmb_icon.SelectedIndex() = 0

            Me.txt_agente.Text = Me.txt_agente.Tag
            Me.txt_agente.ForeColor = Color.Gray

            Me.pag_reg.Parent = Nothing








        Catch ex As Exception
            MsgBox("Error al cargar formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_icon_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmb_icon.DrawItem
        Try
            If e.Index <> -1 Then
                e.Graphics.DrawImage(Me.ImageList1.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar contacto. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_icon_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles cmb_icon.MeasureItem
        e.ItemHeight = Me.ImageList1.ImageSize.Height
        e.ItemWidth = Me.ImageList1.ImageSize.Width
    End Sub
    Private Sub carga_agentes()
        Try
            Dim age As New List(Of agente)
            Dim codges As String = ""
            Dim fec_prom As String = ""

            If IsNumeric(Me.txt_agente.Text) Then
                age = age_cctDao.GetByCodgtech(Me.txt_agente.Text, "0", "", "", "")
            Else
                age = age_cctDao.GetLikeCodgtech("", Me.txt_agente.Text, "0", "", "", "")
            End If

            If age.Count = 0 Then
                limpia_campos()
            ElseIf age.Count = 1 Then
                carga_datos_agens(age)
                carga_dgv_agentes(age)
                Me.dgv_agentes.Focus()
            ElseIf age.Count > 1 Then
                carga_dgv_agentes(age)
                Me.dgv_agentes.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar agentes" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub limpia_campos()
        Me.dgv_agentes.DataSource = ""
        h_bind.Clear()
        Me.lbl_tk.Visible = False
        Me.txt_ciudad.Text = ""
        Me.txt_tel1.Text = ""

        Me.txt_dir.Text = ""
        Me.txt_rep.Text = ""
        Me.txt_ruta.Text = ""
        Me.txt_eje.Text = ""
        Me.txt_ges.Text = ""
        Me.txt_bloq.Text = ""
        Me.txt_clas.Text = ""
        Me.lbl_total.Text = "0"
        Me.lbl_sv.Visible = False
    End Sub
    Private Sub carga_datos_agens(ByVal list_agentes As List(Of agente))
        Dim ret As String = ""
        Me.txt_ciudad.Text = list_agentes.Item(0).ciudad
        Me.txt_tel1.Text = list_agentes.Item(0).telefono1 & " / " & LTrim(RTrim(list_agentes.Item(0).fax)) & " / " & LTrim(RTrim(list_agentes.Item(0).telcon1)) & " / " & LTrim(RTrim(list_agentes.Item(0).telefono2))
        Me.txt_dir.Text = list_agentes.Item(0).direccion
        txt_mun.Text = list_agentes.Item(0).municipio
        txt_sec.Text = list_agentes.Item(0).sector
        Me.txt_rep.Text = list_agentes.Item(0).nomrep
        Me.txt_ruta.Text = list_agentes.Item(0).codasi
        ret = IIf(list_agentes.Item(0).retirada = "1", "/Retirada", "")
        Me.txt_bloq.Text = IIf(list_agentes.Item(0).bloqueada = 1, "Bloqueada" & ret, "Activa" & ret)
        Me.txt_clas.Text = list_agentes.Item(0).clasif
        url_cord = "http://www.latlong.net/c/?lat=" & list_agentes.Item(0).cy & "&long=" & list_agentes.Item(0).cx
        If Me.dgv_agentes.RowCount > 0 Then
            Me.lbl_reg_age.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value & " - " & Me.dgv_agentes.CurrentRow.Cells("nombre").Value
        End If
        Me.lbl_ced.Text = list_agentes.Item(0).cedula
    End Sub
    Private Sub carga_dgv_agentes(ByVal list_agentes As List(Of agente))
        Me.dgv_agentes.DataSource = list_agentes
        Dim col As Integer
        For col = 0 To Me.dgv_agentes.Columns.Count - 1
            Me.dgv_agentes.Columns.Item(col).Visible = False
        Next
        With Me.dgv_agentes.Columns
            .Item("ID").HeaderText = "RETAILER"
            .Item("ID").DataPropertyName = "ID"
            .Item("ID").Name = "ID"
            .Item("ID").Width = 70
            .Item("ID").DisplayIndex = 1
            .Item("ID").Visible = True

            .Item("NOMBRE").HeaderText = "NOMBRE"
            .Item("NOMBRE").DataPropertyName = "nombre"
            .Item("NOMBRE").Name = "nombre"
            .Item("NOMBRE").Width = 225
            .Item("NOMBRE").Visible = True
        End With
        Me.lbl_total.Text = list_agentes.Count
    End Sub
    Private Sub carga_dgv_hist(ByVal lista As List(Of cct_h_ll_age))
        h_bind.DataSource = lista
        Me.dgv_hist.DataSource = h_bind
        With Me.dgv_hist.Columns
            .Item("usuario_update").Visible = False
            .Item("usuario_insert").Visible = False
            .Item("ID").Visible = False
            .Item("AGENTE").Visible = False
            .Item("FEC_TK_A").Visible = False
            .Item("FEC_TK_VER").Visible = False
        End With
        Me.lbl_t_ll.Text = lista.Count
    End Sub
    Private Sub txt_agente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_agente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txt_agente.Focused Then
                    carga_agentes()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al traer total de Agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub dgv_agentes_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agentes.CellLeave

    End Sub
    Private Sub dgv_agentes_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_agentes.DataSourceChanged
        dgv_agentes_SelectionChanged(sender, e)
    End Sub
    Private Sub dgv_agentes_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_agentes.SelectionChanged
        Try
            If Me.dgv_agentes.RowCount > 0 Then
                If Not Me.dgv_agentes.CurrentRow.Cells(0).Value Is Nothing Then
                    Dim age As New List(Of agente)
                    age = age_cctDao.GetByCodgtech(Me.dgv_agentes.CurrentRow.Cells("ID").Value, "", "", "", "")
                    If age.Count > 0 Then
                        carga_datos_agens(age)
                    End If

                    'cargamos datos de ejecutivo
                    If IsNumeric(Me.txt_ruta.Text) Then
                        Dim emp As New List(Of empleado)
                        emp = empl_cctDao.GetByCodemp(Me.txt_ruta.Text)
                        If Not emp Is Nothing Then
                            If emp.Count > 0 Then
                                Me.txt_eje.Text = emp.Item(0).nomemp & " " & emp.Item(0).apeemp
                            End If
                        End If
                    End If
                    'cargamos datos de gestor de cobros
                    Dim ges As New List(Of gestores)
                    ges = gest_cctsDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                    If ges.Count > 0 Then
                        Me.txt_ges.Text = ges.Item(0).nomges
                    End If
                    'cargamos dias sin venta
                    Dim sv As New List(Of age_sin_venta)
                    sv = age_sv_cctDao.GetByAge(Me.dgv_agentes.CurrentRow.Cells("ID").Value, 0, "", "", 0)
                    If sv.Count > 0 Then
                        Me.lbl_sv.Text = sv.Item(0).dias.ToString & Me.lbl_sv.Tag
                        Me.lbl_sv.Visible = True
                    Else
                        Me.lbl_sv.Visible = False
                    End If

                    'cargamos el historial de llamadas
                    Dim h_ll As New List(Of cct_h_ll_age)
                    h_ll = histDao.GetByllAge(Me.dgv_agentes.CurrentRow.Cells("ID").Value, "", 10)
                    If Not h_ll Is Nothing Then
                        If h_ll.Count > 0 Then
                            carga_dgv_hist(h_ll)
                            Me.lbl_tk_ver.Text = h_ll.Item(0).FEC_TK_VER
                            Me.lbl_tk.Text = h_ll.Item(0).FEC_TK_A
                            If Me.lbl_tk.Text <> "" Then
                                Me.lbl_tk.Visible = True
                            Else
                                Me.lbl_tk.Visible = False
                            End If
                        Else
                            h_bind.Clear()
                            Me.lbl_tk.Visible = False
                        End If
                    Else
                        h_bind.Clear()
                        Me.lbl_tk.Visible = False
                        Me.lbl_t_ll.Text = "0"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalle de Agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_tip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tip.SelectedIndexChanged
        Try
            If IsNumeric(cmb_tip.SelectedValue) Then
                Dim l_tp_mot As New List(Of cct_tp_llamada_motivo)
                l_tp_mot = tp_motDao.GetByEstado(0, cmb_tip.SelectedValue, 1)
                If Not l_tp_mot Is Nothing Then
                    Me.cmb_mov.DataSource = l_tp_mot
                    Me.cmb_mov.DisplayMember = "DESCRIPCION"
                    Me.cmb_mov.ValueMember = "ID_MOTIVO"
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los motivos. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_mov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mov.SelectedIndexChanged
        'Try
        '    If IsNumeric(cmb_mov.SelectedValue) Then
        '        If IsNumeric(cmb_mov.SelectedValue) Then
        '            If cmb_mov.SelectedValue = "31" Then 'Cierre de ticket
        '                Call lbl_tk_Click(sender, e)
        '            ElseIf cmb_mov.SelectedValue = "29" Then 'Acceso
        '                If Me.dgv_agentes.RowCount > 0 Then
        '                    If Me.lbl_ced.Text <> "" Then
        '                        Dim chform As New cct_cedula
        '                        chform.txt_rep.Text = Me.txt_rep.Text
        '                        chform.lbl_ced.Text = Me.lbl_ced.Text
        '                        chform.ShowDialog()
        '                        If chform.lbl_apr.Text = "1" Then
        '                            Dim l_mot_inc As New List(Of cct_mot_inc)
        '                            l_mot_inc = mot_incDao.GetByEstado(0, cmb_mov.SelectedValue, 1)
        '                            If Not l_mot_inc Is Nothing Then
        '                                Me.cmb_inc.DataSource = l_mot_inc
        '                                Me.cmb_inc.DisplayMember = "DESCRIPCION"
        '                                Me.cmb_inc.ValueMember = "ID_INCIDENCIA"
        '                            End If
        '                            Dim l_inc_con As New List(Of cct_inc_con)
        '                            l_inc_con = inc_conDao.GetByEstado(0, cmb_inc.SelectedValue, 1)
        '                            If Not l_inc_con Is Nothing Then
        '                                Me.cmb_con.DataSource = l_inc_con
        '                                Me.cmb_con.DisplayMember = "DESCRIPCION"
        '                                Me.cmb_con.ValueMember = "ID_CONCLUSION"
        '                            End If
        '                            cmb_inc.SelectedIndex = 0
        '                            cmb_con.SelectedIndex = 1
        '                            btn_agrega_act_Click(sender, e)
        '                        End If

        '                    Else
        '                        MsgBox("Cedula no registrada" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        '                    End If
        '            Else
        '                MsgBox("Seleccione el Agente" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        '            End If
        '            Else
        '                Dim l_mot_inc As New List(Of cct_mot_inc)
        '                l_mot_inc = mot_incDao.GetByEstado(0, cmb_mov.SelectedValue, 1)
        '                If Not l_mot_inc Is Nothing Then
        '                    Me.cmb_inc.DataSource = l_mot_inc
        '                    Me.cmb_inc.DisplayMember = "DESCRIPCION"
        '                    Me.cmb_inc.ValueMember = "ID_INCIDENCIA"
        '                End If
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox("Error al cargar las incidencias. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        'End Try
    End Sub
    Private Sub cmb_inc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_inc.SelectedIndexChanged
        Try
            If IsNumeric(cmb_inc.SelectedValue) Then
                Dim l_inc_con As New List(Of cct_inc_con)
                If cmb_mov.SelectedValue = 31 Then
                    l_inc_con = inc_conDao.GetByEstado(2, cmb_inc.SelectedValue, 1)
                Else
                    l_inc_con = inc_conDao.GetByEstado(0, cmb_inc.SelectedValue, 1)
                End If
                If Not l_inc_con Is Nothing Then
                    Me.cmb_con.DataSource = l_inc_con
                    Me.cmb_con.DisplayMember = "DESCRIPCION"
                    Me.cmb_con.ValueMember = "ID_CONCLUSION"
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las conclusiones. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub inicializar_registro()
        Try
            Me.txt_coment.Text = ""
            Dim l_tp_mot As New List(Of cct_tp_llamada_motivo)
            l_tp_mot = tp_motDao.GetByEstado(0, cmb_tip.SelectedValue, 1)
            If Not l_tp_mot Is Nothing Then
                Me.cmb_mov.DataSource = l_tp_mot
                Me.cmb_mov.DisplayMember = "DESCRIPCION"
                Me.cmb_mov.ValueMember = "ID_MOTIVO"
            End If
        Catch ex As Exception
            MsgBox("Error inicializando registros. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub
    Private Sub cerrar_llamada()
        Timer1.Enabled = False
        lbl_seg.Text = 0
        lbl_min.Text = 0
        lbl_hor.Text = 0
        Me.cmb_tec.SelectedIndex = 0
        Me.cmb_eje.SelectedIndex = 0
        Me.cmb_icon.SelectedIndex = 0
        Me.cmb_top.SelectedIndex = 0
        Me.txt_cont.Text = ""
        inicializar_registro()
    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = True
    End Sub
    Private Sub BtnStop_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = False
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs)
        lbl_seg.Text = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_seg.Text = Val(lbl_seg.Text) + 1
        If lbl_seg.Text = "60" Then
            BtnReset_Click(sender, e)
            lbl_min.Text = Val(lbl_min.Text) + 1
            If lbl_min.Text = "60" Then
                lbl_min.Text = 0
                lbl_hor.Text = Val(lbl_hor.Text) + 1
            End If
        End If
    End Sub

    Private Sub btn_guardar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles btn_guardar.MouseDoubleClick

    End Sub
    Private Sub btn_guardar_MouseHover(sender As Object, e As EventArgs) Handles btn_guardar.MouseHover
        If Me.btn_guardar.Tag = 1 Then
            Me.btn_guardar.Text = "INICIAR LLAMADA"
            Me.btn_guardar.Width = 159
        End If
    End Sub
    Private Sub btn_guardar_MouseLeave(sender As Object, e As EventArgs) Handles btn_guardar.MouseLeave
        If Me.btn_guardar.Tag = 1 Then
            Me.btn_guardar.Text = ""
            Me.btn_guardar.Width = 45
        End If
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            If Me.btn_guardar.Tag = 1 Then
                Me.btn_guardar.Text = "FINALIZAR LLAMADA"
                Me.btn_guardar.ForeColor = Color.Red
                Me.btn_guardar.Width = 179
                Me.btn_guardar.Tag = 2
                Me.pag_reg.Parent = Me.tb_reg
                Me.tb_reg.SelectedIndex = 1
                Me.cmb_tip.Focus()
                Me.gb_time.Visible = True
                Timer1.Enabled = True
                tini = Date.Now.TimeOfDay.ToString.Substring(0, 8)
                Me.reg_bind.Clear()
                Me.dgv_reg.DataSource = reg_bind
            Else
                If Me.dgv_reg.RowCount > 0 Then
                    If cont <> "" Then
                        tfin = Date.Now.TimeOfDay.ToString.Substring(0, 8)
                        Dim comen As String = ""
                        'VERIFICAR CLASIFICACION PARA ENVIO DE CORREO
                        If Me.txt_clas.Text = "A" Or Me.txt_clas.Text = "B" Then
                            comen = "enviar"
                        End If

                        'INSERTAMOS LA LLAMADA
                        Dim llamada_list As New List(Of cct_llamadas)
                        llamada_list = llamadaDao.SetLlamada(cmb_tip.SelectedValue, Me.dgv_agentes.CurrentRow.Cells("ID").Value, codusu_cct, Me.cmb_icon.SelectedIndex, cont, 1, 1, 1, "", "", tini, tfin, 1)

                        'INSERTAMOS CADA UNO DE LOS REGISTROS
                        Dim reg_list As New List(Of cct_reg_llamada)
                        For Each row As DataGridViewRow In dgv_reg.Rows

                            'Cerramos el ticket
                            If row.Cells("ID_TK").Value <> "0" And row.Cells("ID_MOTIVO").Value = "31" Then
                                Dim l_tk As New List(Of cct_reg_tk)
                                l_tk = r_tkDao.ActRegTk(row.Cells("ID_TK").Value, 2, 0)
                                If Not l_tk Is Nothing Then
                                    If l_tk.Count > 0 Then
                                        'tk cerrado correctamente
                                    Else
                                        MsgBox("No fue posible cerrar el ticket seleccionado ", MsgBoxStyle.Critical, "Call Center")
                                    End If
                                End If
                            ElseIf row.Cells("ID_TK").Value <> "0" And row.Cells("ID_MOTIVO").Value = "34" Then
                                Dim l_tk As New List(Of cct_reg_tk)
                                l_tk = r_tkDao.GetEstTk(row.Cells("ID_TK").Value)
                                If Not l_tk Is Nothing Then
                                    If l_tk.Count > 0 Then
                                        If l_tk.Item(0).ID = 2 Then
                                            l_tk = r_tkDao.ActRegTk(row.Cells("ID_TK").Value, 2, 1)
                                            If Not l_tk Is Nothing Then
                                                If l_tk.Count > 0 Then
                                                    'tk verificado correctamente
                                                Else
                                                    MsgBox("No fue posible verificar el ticket seleccionado ", MsgBoxStyle.Critical, "Call Center")
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If

                            reg_list = R_llamaDao.SetRegLlama(Me.dgv_agentes.CurrentRow.Cells("ID").Value, 0, cont, cmb_tip.SelectedValue, row.Cells("ID_MOTIVO").Value, row.Cells("ID_INCIDENCIA").Value, row.Cells("ID_CONCLUSION").Value, row.Cells("NOTA").Value, "", "", tini, tfin, codusu_cct, llamada_list.Item(0).ID, row.Cells("ID_TK").Value)

                            'VERIFICAMOS SI HAY TK
                            If row.Cells("ID_CONCLUSION").Value = "1" Then
                                Dim reg_tk As New List(Of cct_reg_tk)
                                reg_tk = r_tkDao.SetRegTk(1, 0, reg_list.Item(0).ID, comen, 0, codusu_cct)

                                'INSERTAMOS EL TICKET CREADO EN EL REGISTRO DE LLAMADA
                                reg_list = R_llamaDao.ActRegLlama(reg_list.Item(0).ID, reg_tk.Item(0).ID)
                            End If
                        Next
                        'LIMPIAR CAMPOS
                        cerrar_llamada()
                        Me.btn_guardar.Text = ""
                        Me.btn_guardar.ForeColor = Color.Green
                        Me.btn_guardar.Width = 45
                        Me.btn_guardar.Tag = 1
                        Me.pag_reg.Parent = Nothing
                        Me.tb_reg.TabPages(0).Focus()
                        Me.gb_time.Visible = False
                        Me.gb_agente.Enabled = True
                    Else
                        MsgBox("Especifique el nombre del contacto" & Chr(13), MsgBoxStyle.Information, "Call Center")
                    End If

                Else
                    MsgBox("Por favor complete el registro correctamente" & Chr(13), MsgBoxStyle.Information, "Call Center")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en registro de llamada" & Chr(13), MsgBoxStyle.Information, "Call Center")
        End Try
    End Sub
    Private Sub cmb_icon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_icon.SelectedIndexChanged
        If Me.cmb_icon.SelectedIndex = 0 Then
            cont = Me.txt_cont.Text = ""
            Me.txt_cont.Visible = True
            Me.cmb_tec.Visible = False
            Me.cmb_eje.Visible = False
        ElseIf Me.cmb_icon.SelectedIndex = 1 Then
            Me.cmb_tec.SelectedIndex = 0
            cont = ""
            Me.cmb_tec.Visible = True
            Me.txt_cont.Visible = False
            Me.cmb_eje.Visible = False
            Me.cmb_tec.DroppedDown = True
        Else
            Me.cmb_eje.SelectedIndex = 0
            cont = ""
            Me.cmb_eje.Visible = True
            Me.cmb_tec.Visible = False
            Me.txt_cont.Visible = False
            Me.cmb_eje.DroppedDown = True
        End If
    End Sub
    Private Sub cmb_tec_GotFocus(sender As Object, e As EventArgs) Handles cmb_tec.GotFocus
        Me.cmb_tec.DroppedDown = True
    End Sub
    Private Sub cmb_tec_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tec.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmb_mov.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion del contacto: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_eje_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_eje.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmb_mov.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion del contacto: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub txt_cont_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cont.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmb_mov.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion del contacto: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_icon_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_icon.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.cmb_icon.SelectedIndex = 0 Then
                    Me.txt_cont.Focus()
                ElseIf Me.cmb_icon.SelectedIndex = 1 Then
                    Me.cmb_tec.SelectedIndex = 0
                    Me.cmb_tec.Focus()
                Else
                    Me.cmb_eje.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion del tipo de contacto: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_tip_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_tip.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmb_icon.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion del tipo de llamada: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_mov_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_mov.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmb_inc.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion del motivo: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_inc_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_inc.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmb_con.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion de la incidencia: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub
    Private Sub cmb_con_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_con.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.txt_coment.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion de la conclusion: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_tec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tec.SelectedIndexChanged
        cont = Me.cmb_tec.Text
    End Sub
    Private Sub cmb_eje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_eje.SelectedIndexChanged
        cont = Me.cmb_eje.Text
    End Sub
    Private Sub cmb_tip_GotFocus(sender As Object, e As EventArgs) Handles cmb_tip.GotFocus
        cmb_tip.DroppedDown = True
    End Sub
    Private Sub btn_map_Click(sender As Object, e As EventArgs) Handles btn_map.Click
        Try
            System.Diagnostics.Process.Start(url_cord)
        Catch ex As Exception
            MsgBox("Error en la carga del mapa" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub dgv_agentes_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_agentes.KeyDown
        Try
            If e.KeyCode = Keys.Enter And Me.dgv_agentes.RowCount > 0 Then
                Me.cmb_mov.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la seleccion de del agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filtro.SelectedIndexChanged
        Dim age_list As New List(Of agente)
        Me.txt_agente.Text = Me.txt_agente.Tag


        If Me.cmb_filtro.Text = "Sin venta" Then
            mostrar(codusu_cct)


            'carga_datos_agens(age_list)
            'carga_dgv_agentes(age_list)
            Me.dgv_agentes.Focus()
        ElseIf age_list.Count > 1 Then
            'carga_dgv_agentes(age_list)
            Me.dgv_agentes.Focus()

        ElseIf Me.cmb_filtro.Text = "Tickets abiertos" Then
            age_list = age_cctDao.GetByTkAbiertos("", codusu_cct)
            If age_list.Count = 0 Then
                limpia_campos()
            ElseIf age_list.Count = 1 Then
                carga_datos_agens(age_list)
                carga_dgv_agentes(age_list)
                Me.dgv_agentes.Focus()
            ElseIf age_list.Count > 1 Then
                carga_dgv_agentes(age_list)
                Me.dgv_agentes.Focus()
            End If

        ElseIf Me.cmb_filtro.Text = "Verificar cierre" Then
            verificcionCierre(codusu_cct)

            'age_list = age_cctDao.GetByTkVerif("", "Pendiente", Me.lbl_nom.Text)
            'If age_list.Count = 0 Then
            '    limpia_campos()
            'ElseIf age_list.Count = 1 Then
            '    carga_datos_agens(age_list)
            '    carga_dgv_agentes(age_list)
            '    Me.dgv_agentes.Focus()
            'ElseIf age_list.Count > 1 Then
            '    carga_dgv_agentes(age_list)
            '    Me.dgv_agentes.Focus()
            'End If



        Else
            limpia_campos()

        End If





    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub btn_ex_age_Click(sender As Object, e As EventArgs) Handles btn_ex_age.Click
        'Dim xlApp As New Excel.Application
        'Dim xlWorkBook As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet

        'Dim misValue As Object = System.Reflection.Missing.Value
        'xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlApp.Visible = True
        'Try
        '    xlWorkSheet = xlWorkBook.Sheets("Hoja1")
        '    Dim i As Integer = 0
        '    Dim j As Integer = 0

        '    For i = 0 To dgv_agentes.RowCount - 2
        '        For j = 0 To dgv_agentes.ColumnCount - 5

        '            If j = 0 Then
        '                xlWorkSheet.Cells(1, j + 1) = "RETAILER"
        '                xlWorkSheet.Cells(i + 2, j + 1) = dgv_agentes("ID", i).Value.ToString()
        '                xlWorkSheet.Cells(1, j + 2) = dgv_agentes.Columns(j).HeaderText
        '            Else
        '                xlWorkSheet.Cells(1, j + 2) = dgv_agentes.Columns(j).HeaderText
        '            End If
        '        Next
        '    Next
        '    releaseObject(xlWorkBook)
        '    releaseObject(xlWorkSheet)
        '    releaseObject(xlApp)
        'Catch ex As Exception
        '    MsgBox("Error en la carga de excel " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        '    xlApp.Quit()
        'End Try
    End Sub
    Private Sub btn_agrega_act_Click(sender As Object, e As EventArgs) Handles btn_agrega_act.Click
        Try
            If cmb_tip.Text <> "" And cmb_mov.Text <> "" And cmb_inc.Text <> "" And cmb_con.Text <> "" And cont <> "" Then
                If Me.dgv_agentes.RowCount > 0 Then
                    Dim reg As Boolean = True
                    For Each row As DataGridViewRow In dgv_reg.Rows

                        If dgv_reg.Item("MOTIVO", row.Index).Value = cmb_mov.Text And dgv_reg.Item("INCIDENCIA", row.Index).Value = cmb_inc.Text Then
                            MsgBox("La Incidencia seleccionada ya se encuentra registrada." & Chr(13), MsgBoxStyle.Information, "Call Center")
                            reg = False
                            Exit For
                        End If
                    Next
                    If reg Then
                        ''Cerramos el ticket
                        'If lbl_id_tk_cierre.Text <> "0" And cmb_mov.SelectedValue = "31" Then
                        '    Dim l_tk As New List(Of cct_reg_tk)
                        '    l_tk = r_tkDao.ActRegTk(lbl_id_tk_cierre.Text, 2, 0)
                        '    If Not l_tk Is Nothing Then
                        '        If l_tk.Count > 0 Then
                        '            'tk cerrado correctamente
                        '        Else
                        '            MsgBox("No fue posible cerrar el ticket seleccionado ", MsgBoxStyle.Critical, "Call Center")
                        '        End If
                        '    End If
                        'ElseIf lbl_id_tk_cierre.Text <> "0" And cmb_mov.SelectedValue = "34" Then
                        '    Dim l_tk As New List(Of cct_reg_tk)
                        '    l_tk = r_tkDao.ActRegTk(lbl_id_tk_cierre.Text, 2, 1)
                        '    If Not l_tk Is Nothing Then
                        '        If l_tk.Count > 0 Then
                        '            'tk verificado correctamente
                        '        Else
                        '            MsgBox("No fue posible verificar el ticket seleccionado ", MsgBoxStyle.Critical, "Call Center")
                        '        End If
                        '    End If
                        'End If
                        Agrega_reg(Me.dgv_agentes.CurrentRow.Cells("ID").Value, cmb_mov.Text, cmb_mov.SelectedValue, cmb_inc.Text, cmb_inc.SelectedValue, cmb_con.Text, cmb_con.SelectedValue, txt_coment.Text, lbl_id_tk_cierre.Text)
                        lbl_id_tk_cierre.Text = "0"
                        'Me.reg_bind.AddNew()
                        'Me.dgv_reg.CurrentRow.Cells("RETAILER").Value = Me.dgv_agentes.CurrentRow.Cells("ID").Value
                        'Me.dgv_reg.CurrentRow.Cells("MOTIVO").Value = cmb_mov.Text
                        'Me.dgv_reg.CurrentRow.Cells("ID_MOTIVO").Value = cmb_mov.SelectedValue
                        'Me.dgv_reg.CurrentRow.Cells("INCIDENCIA").Value = cmb_inc.Text
                        'Me.dgv_reg.CurrentRow.Cells("ID_INCIDENCIA").Value = cmb_inc.SelectedValue
                        'Me.dgv_reg.CurrentRow.Cells("CONCLUSION").Value = cmb_con.Text
                        'Me.dgv_reg.CurrentRow.Cells("ID_CONCLUSION").Value = cmb_con.SelectedValue
                        'Me.dgv_reg.CurrentRow.Cells("NOTA").Value = txt_coment.Text
                        'inicializar_registro()
                        'Me.cmb_mov.Focus()
                        'Me.gb_agente.Enabled = False
                    End If
                Else
                    MsgBox("Debe seleccionar el agente para realizar el registro" & Chr(13), MsgBoxStyle.Critical, "Call Center")
                    Me.txt_agente.Focus()
                End If
            Else
                MsgBox("Complete todos los campos para realizar el registro" & Chr(13), MsgBoxStyle.Critical, "Call Center")
            End If

        Catch ex As Exception
            MsgBox("Error al agregar actividad " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub Agrega_reg(age As String, mot As String, id_mot As String, inc As String, id_inc As String, con As String, id_con As String, nota As String, id_tk As String)
        Me.reg_bind.AddNew()
        Me.dgv_reg.CurrentRow.Cells("RETAILER").Value = age
        Me.dgv_reg.CurrentRow.Cells("MOTIVO").Value = mot
        Me.dgv_reg.CurrentRow.Cells("ID_MOTIVO").Value = id_mot
        Me.dgv_reg.CurrentRow.Cells("INCIDENCIA").Value = inc
        Me.dgv_reg.CurrentRow.Cells("ID_INCIDENCIA").Value = id_inc
        Me.dgv_reg.CurrentRow.Cells("CONCLUSION").Value = con
        Me.dgv_reg.CurrentRow.Cells("ID_CONCLUSION").Value = id_con
        Me.dgv_reg.CurrentRow.Cells("NOTA").Value = nota
        Me.dgv_reg.CurrentRow.Cells("ID_TK").Value = id_tk
        inicializar_registro()
        Me.cmb_mov.Focus()
        Me.gb_agente.Enabled = False
    End Sub
    Private Sub btn_quitar_act_Click(sender As Object, e As EventArgs) Handles btn_quitar_act.Click
        Try
            If Me.dgv_reg.RowCount > 0 Then
                Me.reg_bind.RemoveAt(Me.reg_bind.Position)
                If Me.dgv_reg.RowCount = 0 Then
                    Me.gb_agente.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al quitar actividad " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub txt_coment_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_coment.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btn_agrega_act.PerformClick()
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btn_nota.Click
        If Me.dgv_agentes.RowCount > 0 Then
            Dim chform As New cct_notas_frm
            chform.lbl_age.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value & " - " & Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
            chform.ShowDialog()
        Else
            MsgBox("Seleccione el Agente" & Chr(13), MsgBoxStyle.Critical, "Call Center")
            Me.txt_agente.Focus()
        End If
        'Dim frm As Form
        'If True Then
        '    frm = New comp_age
        'Else
        '    frm = New comp_age
        'End If
        'frm.ShowDialog()
    End Sub
    Private Sub lbl_tk_Click(sender As Object, e As EventArgs) Handles lbl_tk.Click
        Try
            If Me.dgv_agentes.RowCount > 0 Then
                If Me.lbl_tk.Visible = True Then
                    Dim chform As New cct_ticket_abiertos
                    chform.lbl_age.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value & " - " & Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
                    chform.lbl_tipo.Text = "1" 'Tickets Abiertos
                    'chform.btn_cerrar.Visible = False
                    If Me.btn_guardar.Tag = 1 Then
                        chform.btn_cerrar.Enabled = False
                    End If
                    chform.ShowDialog()
                    If chform.lbl_cerrar.Text <> "cerrando" Then
                        'agrego el registro y vuelvo y abro
                        'Agrega_reg(Me.dgv_agentes.CurrentRow.Cells("ID").Value, chform.dgv_tks.CurrentRow.Cells("MOTIVO").Value, chform.dgv_tks.CurrentRow.Cells("ID_MOTIVO").Value, chform.dgv_tks.CurrentRow.Cells("INCIDENCIA").Value, chform.dgv_tks.CurrentRow.Cells("ID_INCIDENCIA").Value, "SOLUCIONADO/ RESUELTO", 2, "")
                        'chform.ShowDialog()
                        'Me.cmb_mov.SelectedValue() = chform.dgv_tks.CurrentRow.Cells("ID_MOTIVO").Value
                        'Me.cmb_inc.SelectedValue() = chform.dgv_tks.CurrentRow.Cells("ID_INCIDENCIA").Value
                        Me.lbl_id_tk_cierre.Text = chform.dgv_tks.CurrentRow.Cells("ID").Value
                        Me.gb_agente.Enabled = False
                        'Me.cmb_con.SelectedValue() = 2
                        'Me.txt_coment.Focus()
                    End If

                Else
                    MsgBox("Este Agente no tiene tickets abiertos" & Chr(13), MsgBoxStyle.Critical, "Call Center")
                End If
            Else
                MsgBox("Seleccione el Agente" & Chr(13), MsgBoxStyle.Critical, "Call Center")
                Me.txt_agente.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la consulta de tickets" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub lbl_tk_ver_Click(sender As Object, e As EventArgs) Handles lbl_tk_ver.Click
        Try
            If Me.dgv_agentes.RowCount > 0 Then
                Dim chform As New cct_ticket_abiertos
                chform.lbl_age.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value & " - " & Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
                chform.lbl_tipo.Text = "2" 'Tickets Cerrados por verificar
                If Me.btn_guardar.Tag = 1 Then
                    chform.btn_cerrar.Enabled = False
                End If
                chform.ShowDialog()
            Else
                MsgBox("Seleccione el Agente" & Chr(13), MsgBoxStyle.Critical, "Call Center")
                Me.txt_agente.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la consulta de tickets" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cmb_top_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_top.SelectedIndexChanged
        Dim tope As Integer = 10
        If cmb_top.SelectedIndex = 1 Then
            tope = 30
        ElseIf cmb_top.SelectedIndex = 2 Then
            tope = 1000
        End If
        'cargamos el historial de llamadas
        Dim h_ll As New List(Of cct_h_ll_age)
        h_ll = histDao.GetByllAge(Me.dgv_agentes.CurrentRow.Cells("ID").Value, "", tope)
        If Not h_ll Is Nothing Then
            If h_ll.Count > 0 Then
                carga_dgv_hist(h_ll)
                Me.lbl_tk.Text = h_ll.Item(0).FEC_TK_A
                If Me.lbl_tk.Text <> "" Then
                    Me.lbl_tk.Visible = True
                Else
                    Me.lbl_tk.Visible = False
                End If
            Else
                h_bind.Clear()
                Me.lbl_tk.Visible = False
            End If
        Else
            h_bind.Clear()
            Me.lbl_tk.Visible = False
        End If
    End Sub
    Private Sub btn_comp_Click(sender As Object, e As EventArgs) Handles btn_comp.Click
        If Me.dgv_agentes.RowCount > 0 Then
            Dim childform As New comp_age
            childform.lbl_reg_age.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value & " - " & Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
            childform.lbl_cont.Text = "1-ISAAC" 'NOMBRE DE CONTACTO
            childform.gb_m.Enabled = False
            childform.gb_c.Enabled = False
            childform.txt_s1.ReadOnly = True
            childform.txt_s2.ReadOnly = True
            childform.btn_agregar_g.Enabled = False
            childform.btn_quitar_g.Enabled = False
            'childform.btn_agr_ca.Enabled = False
            childform.btn_qui_ca.Enabled = False
            'childform.dgv_cara.Enabled = False

            childform.ShowDialog()
        Else
            MsgBox("Seleccione el Agente" & Chr(13), MsgBoxStyle.Critical, "Call Center")
            Me.txt_agente.Focus()
        End If
    End Sub

    Private Sub cmb_mov_TextChanged(sender As Object, e As EventArgs) Handles cmb_mov.TextChanged
        Try
            If IsNumeric(cmb_mov.SelectedValue) Then
                If IsNumeric(cmb_mov.SelectedValue) Then
                    If cmb_mov.SelectedValue = "31" Then 'Cierre de ticket
                        Call lbl_tk_Click(sender, e)
                        Dim l_mot_inc As New List(Of cct_mot_inc)
                        l_mot_inc = mot_incDao.GetByEstado(0, cmb_mov.SelectedValue, 1)
                        If Not l_mot_inc Is Nothing Then
                            Me.cmb_inc.DataSource = l_mot_inc
                            Me.cmb_inc.DisplayMember = "DESCRIPCION"
                            Me.cmb_inc.ValueMember = "ID_INCIDENCIA"
                        End If

                    ElseIf cmb_mov.SelectedValue = "34" Then 'Verificacion de cierre
                        Dim chform As New cct_ticket_abiertos
                        chform.lbl_age.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value & " - " & Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
                        chform.lbl_tipo.Text = "2" 'Tickets Cerrados por verificar
                        chform.ShowDialog()
                        If chform.lbl_cerrar.Text <> "cerrando" Then
                            Me.lbl_id_tk_cierre.Text = chform.dgv_tks.CurrentRow.Cells("ID").Value
                            Me.gb_agente.Enabled = False
                            Dim l_mot_inc As New List(Of cct_mot_inc)
                            l_mot_inc = mot_incDao.GetByEstado(0, cmb_mov.SelectedValue, 1)
                            If Not l_mot_inc Is Nothing Then
                                Me.cmb_inc.DataSource = l_mot_inc
                                Me.cmb_inc.DisplayMember = "DESCRIPCION"
                                Me.cmb_inc.ValueMember = "ID_INCIDENCIA"
                            End If

                        End If
                    ElseIf cmb_mov.SelectedValue = "29" Then 'Acceso
                        If Me.dgv_agentes.RowCount > 0 Then
                            If Me.lbl_ced.Text <> "" Then
                                Dim chform As New cct_cedula
                                chform.txt_rep.Text = Me.txt_rep.Text
                                chform.lbl_ced.Text = Me.lbl_ced.Text
                                chform.ShowDialog()
                                If chform.lbl_apr.Text = "1" Then
                                    Dim l_mot_inc As New List(Of cct_mot_inc)
                                    l_mot_inc = mot_incDao.GetByEstado(0, cmb_mov.SelectedValue, 1)
                                    If Not l_mot_inc Is Nothing Then
                                        Me.cmb_inc.DataSource = l_mot_inc
                                        Me.cmb_inc.DisplayMember = "DESCRIPCION"
                                        Me.cmb_inc.ValueMember = "ID_INCIDENCIA"
                                    End If
                                    Dim l_inc_con As New List(Of cct_inc_con)
                                    l_inc_con = inc_conDao.GetByEstado(0, cmb_inc.SelectedValue, 1)
                                    If Not l_inc_con Is Nothing Then
                                        Me.cmb_con.DataSource = l_inc_con
                                        Me.cmb_con.DisplayMember = "DESCRIPCION"
                                        Me.cmb_con.ValueMember = "ID_CONCLUSION"
                                    End If
                                    'cmb_inc.SelectedIndex = 0
                                    'cmb_con.SelectedIndex = 1
                                    btn_agrega_act_Click(sender, e)
                                End If

                            Else
                                MsgBox("Cedula no registrada" & Chr(13), MsgBoxStyle.Critical, "Call Center")
                            End If
                        Else
                            MsgBox("Seleccione el Agente" & Chr(13), MsgBoxStyle.Critical, "Call Center")
                        End If
                    Else
                        Dim l_mot_inc As New List(Of cct_mot_inc)
                        l_mot_inc = mot_incDao.GetByEstado(0, cmb_mov.SelectedValue, 1)
                        If Not l_mot_inc Is Nothing Then
                            Me.cmb_inc.DataSource = l_mot_inc
                            Me.cmb_inc.DisplayMember = "DESCRIPCION"
                            Me.cmb_inc.ValueMember = "ID_INCIDENCIA"
                        End If
                    End If
                End If
            End If
           
        Catch ex As Exception
            MsgBox("Error al cargar las incidencias. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub txt_cont_LostFocus(sender As Object, e As EventArgs) Handles txt_cont.LostFocus
        If cmb_icon.SelectedIndex = 0 Then
            cont = Me.txt_cont.Text
        End If
    End Sub

    Private Sub btn_cerrar_tk_Click(sender As Object, e As EventArgs) Handles btn_cerrar_tk.Click
        Call lbl_tk_Click(sender, e)
    End Sub

    Private Sub dgv_hist_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_hist.CellContentDoubleClick
        Try
            If Me.dgv_hist.RowCount > 0 Then
                Dim childform As New cct_reg_aux
                Dim t0, t1 As Date
                t0 = CType(Me.dgv_hist.CurrentRow.Cells("HORA").Value, Date)
                t1 = CType(Me.dgv_hist.CurrentRow.Cells("HORA_FIN").Value, Date)

                Dim hist_lla As New List(Of cct_h_ll)
                hist_lla = histllaDao.GetByid_lla(Me.dgv_hist.CurrentRow.Cells("ID").Value)

                With childform
                    .lbl_llamada.Text = Me.dgv_hist.CurrentRow.Cells("LLAMADA").Value
                    .lbl_fecha.Text = Me.dgv_hist.CurrentRow.Cells("FECHA").Value
                    .txt_cont.Text = Me.dgv_hist.CurrentRow.Cells("CONTACTO").Value
                    .txt_tp_cont.Text = Me.dgv_hist.CurrentRow.Cells("TIPO_CONTACTO").Value
                    .lbl_hi.Text = Me.dgv_hist.CurrentRow.Cells("HORA").Value
                    .lbl_hf.Text = Me.dgv_hist.CurrentRow.Cells("HORA_FIN").Value
                    .lbl_dur.Text = CType(DateDiff(DateInterval.Minute, t0, t1), String) + " Minutos"
                    .lbl_usu.Text = Me.dgv_hist.CurrentRow.Cells("USUARIO").Value
                    .lbl_tk_a.Text = Me.dgv_hist.CurrentRow.Cells("TK_ABIERTOS").Value
                    .lbl_tk_c.Text = Me.dgv_hist.CurrentRow.Cells("TK_CERRADOS").Value
                    .lbl_tk_pr.Text = Me.dgv_hist.CurrentRow.Cells("POR_REVISAR").Value
                    .dgv_h_reg.DataSource = hist_lla
                End With

                childform.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox("Error en la carga el detalle de la llamada." & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_tks_Click(sender As Object, e As EventArgs) Handles btn_tks.Click
        If Me.dgv_agentes.RowCount > 0 Then
            Dim childform As New cct_tickets
            Me.dgv_agentes.Focus()
            childform.lbl_reg_age.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value & " - " & Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
            childform.ShowDialog()
        Else
            MsgBox("Seleccione el Agente" & Chr(13), MsgBoxStyle.Critical, "Call Center")
            Me.txt_agente.Focus()
        End If
    End Sub
    Public Sub mostrar(codusu_cct)
        Try
            Dim func As New CCTAgenteSinVENTA
            'Dim ageList As List(Of agente)

            'ageList = func.AgenteSinVenta()
            _dt = func.AgenteSinVenta(codusu_cct)

            _dt.Columns(0).ColumnName = "ID"
            'Me.dgv_agentes.Columns("ID"). = _dt.Columns("RETEALER").DefaultValue
            '    .Item("RETAILER").HeaderText
            dgv_agentes.DataSource = _dt

            'c.DataSource = ageList
            'Dim col As Integer
            'For col = 0 To Me.dgv_agentes.Columns.Count - 1
            '    Me.dgv_agentes.Columns.Item(col).Visible = False
            'Next
            'With Me.dgv_agentes.Columns
            '    .Item("RETAILER").HeaderText = "RETAILER"
            '    .Item("RETAILER").DataPropertyName = "ID"
            '    .Item("RETAILER").Name = "ID"
            '    .Item("RETAILER").Width = 70
            '    .Item("RETAILER").DisplayIndex = 1
            '    .Item("RETAILER").Visible = True

            '    .Item("NOMBRE").HeaderText = "NOMBRE"
            '    .Item("NOMBRE").DataPropertyName = "nombre"
            '    .Item("NOMBRE").Name = "nombre"
            '    .Item("NOMBRE").Width = 225
            '    .Item("NOMBRE").Visible = True
            'End With
            lbl_total.Text = _dt.Rows.Count
            Me.lbl_nom.Text = Login.nomusu


        Catch ex As Exception
            MsgBox("Error al mostrar los datos")
        End Try


    End Sub


    Public Sub verificcionCierre(codusu_cct)

        Try
            Dim _Func As New CCTVerificacionCierre
            _dt = _Func.verificacionCierreCCT(codusu_cct)
            _dt.Columns(0).ColumnName = "ID"
            dgv_agentes.DataSource = _dt




            lbl_total.Text = _dt.Rows.Count
            Me.lbl_nom.Text = Login.nomusu
        Catch ex As Exception
            MsgBox("Error al mostrar los datos")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'FCCCobro.Show()
        mostrar(codusu_cct)
    End Sub

    Private Sub gb_agente_Enter(sender As Object, e As EventArgs) Handles gb_agente.Enter

    End Sub

    Private Sub dgv_agentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agentes.CellContentClick

    End Sub

    Private Sub btn_numeroganadore_Click(sender As Object, e As EventArgs) Handles btn_numeroganadore.Click
        Try
            Dim _func As New DLOTOLNUMEROGANADORE
            _func.numeroGanadore()

            MessageBox.Show("Se ha enviado Corretamente", "Envio de numeros ganadores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("No se ha enviado Correctamente.Comunicarse con el departamente de Tecnologuia.BD")
        End Try
    End Sub

   

End Class

