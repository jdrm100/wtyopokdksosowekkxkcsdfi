Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms

Public Class Reg001

    Dim factoria As IDaoFactory
    Dim usuarioDao As IUsuarioDao
    Dim agenteDao As IAgenteDao
    Dim gestoresDao As IGestoresDao
    Dim callcenteradmDao As ICallcenteradmDao
    Dim empleadoDao As IEmpleadoDao
    Dim gestor_usuarioDao As Igestor_usuarioDao
    Dim estado_cuentaDao As IEstado_Cuenta
    Dim usu_llamadasDao As IUsu_LLamadasDao
    Dim venta_cursoDao As IVenta_CursoDao
    Dim QJM_cua_sDao As IQJM_cua_sDao
    Dim FacperiodoDao As IFacperiodoDao
    Dim SoliajusteDao As ISoli_asjuteDao
    Dim PromesaPagDao As IPromesa_PagDao
    Dim SolnoblotiposDao As ISol_noblo_tiposDao
    Dim codusu_ccc As String
    Dim bloq As String 'Controla la busqueda de agentes bloqueados
    Dim bala As String 'Controla la busqueda de agentes con banlance positivo o negativo o todos
    Dim tini As String
    Dim tfin As String
    Dim agesele As String
    Public codusu_reg As String
    Public flag As Boolean = True
    Public enviar As Boolean = False
    Public c_a As String = "" 'Variable para controlar el comentario de los ajustes solicitados
    Public lf As Boolean = False 'Variable para limpiar los filtros

    Private Sub Reg01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'NHibernateSessionManager.Instancia.BeginTransaction()
            factoria = New NHibernateDaoFactory

            usuarioDao = factoria.GetUsuarioDao
            agenteDao = factoria.GetAgenteDao
            gestoresDao = factoria.GetGestoresDao
            callcenteradmDao = factoria.GetCallcenteradmDao
            empleadoDao = factoria.GetEmpleadoDao
            gestor_usuarioDao = factoria.Getgestor_usuarioDao
            estado_cuentaDao = factoria.GetEstado_CuentaDao
            usu_llamadasDao = factoria.GetUsu_LLamadasDao
            venta_cursoDao = factoria.GetVenta_CursoDao
            QJM_cua_sDao = factoria.GetQJM_cua_sDao
            FacperiodoDao = factoria.GetFacperiodoDao
            SoliajusteDao = factoria.GetSoli_ajusteDao
            PromesaPagDao = factoria.GetPromesa_PagDao
            SolnoblotiposDao = factoria.GetSol_noblo_tiposDao

            Me.tt1.SetToolTip(Me.txt_agente, "Consulte por Retailer o Nombre de Agente.")
            Me.tt1.SetToolTip(Me.btn_guardar, "Iniciar llamada")
            Me.btn_guardar.BackgroundImage = My.Resources.Skype_Phone_Green
            Me.btn_guardar.Tag = 1
            Me.cmb_tip.SelectedIndex = 0
            Me.lbl_nom.Text = Login.nomusu
            codusu_reg = Login.codusu
            codusu_ccc = Login.codusu

            'Carga de gestores
            '---------------------------------------------------------
            Try
                Me.cmb_gest.Items.Add("-TODOS")
                Dim gest As New List(Of gestores)
                gest = gestoresDao.GetByCodges("")
                If gest.Count = 0 Then
                    MsgBox("Gestores no cargados! " & Chr(13), MsgBoxStyle.Critical, "Call Center")
                Else
                    Dim i As Integer
                    For i = 0 To gest.Count - 1
                        Me.cmb_gest.Items.Add(gest.Item(i).ID & "-" & gest.Item(i).nomges)
                    Next
                    'Verifica si el usuario es gestor y carga los datos
                    'En la tabla de gestor relaciona el campo telges con el codusu de la tabla de usuario
                    '---------------------------------------------------------
                    gest = gestoresDao.GetByCodusu(codusu_reg)
                    If gest.Count > 0 Then
                        Dim s As String = gest.Item(0).ID & "-" & gest.Item(0).nomges
                        Me.cmb_gest.SelectedIndex = Me.cmb_gest.Items.IndexOf(s)
                    Else
                        'Label11.Visible = False
                        'lbl_llamadas.Visible = False
                        'Dim t As String = "-TODOS"
                        'Me.cmb_gest.SelectedIndex = Me.cmb_gest.Items.IndexOf(t)
                    End If
                    '---------------------------------------------------------
                End If
            Catch ex As Exception
                MsgBox("Error en la carga de gestores: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
            End Try
            '---------------------------------------------------------

            'Carga de ejecutivos-empleado
            '---------------------------------------------------------
            Try
                Me.cmb_ejec.Items.Add("-TODOS")
                Dim emple As New List(Of empleado)
                emple = empleadoDao.GetAll()
                If emple.Count = 0 Then
                    MsgBox("Ejecutivos no cargados! " & Chr(13), MsgBoxStyle.Critical, "Call Center")
                Else
                    Dim i As Integer
                    For i = 0 To emple.Count - 1
                        Me.cmb_ejec.Items.Add(emple.Item(i).ID & "-" & emple.Item(i).nomemp & " " & emple.Item(i).apeemp)
                    Next
                End If

            Catch ex As Exception
                MsgBox("Error en la carga de ejecutivos: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
            End Try
            '---------------------------------------------------------
            Me.dtp_prom.MinDate = Now
            Me.dtp_prom.MaxDate = Now.AddMonths(12)
            Me.dtp_prom.Checked = False

            If Me.lbl_nom.Text <> "---" Then
                carga_llamadas()
            End If

        Catch ex As Exception
            MsgBox("Error al cargar formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try


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



    Private Sub carga_llamadas()
        Try
            Dim llamadas_list As New List(Of usu_llamadas)
            llamadas_list = usu_llamadasDao.GetbyCodusu(Me.lbl_nom.Text)
            If Not llamadas_list Is Nothing Then
                If llamadas_list.Count > 0 Then
                    Me.lbl_llamadas.Text = llamadas_list.Item(0).cant
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al traer LLamadas: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub

    Private Sub carga_agentes()
        Try
            Dim age As New List(Of agente)
            Dim codges As String = ""
            Dim fec_prom As String = ""
            If dtp_con_prom.Checked = True Then
                fec_prom = Me.dtp_con_prom.Value.Date.ToString.Substring(0, 10)
            End If

            flag = False

            If cmb_gest.Text <> "" Then
                Dim arr_gestor As Array
                arr_gestor = Me.cmb_gest.Text.Split("-")
                codges = arr_gestor(0)
            End If

            If IsNumeric(Me.txt_agente.Text) Then
                age = agenteDao.GetByCodgtech(Me.txt_agente.Text, bloq, codges, fec_prom, bala)
            Else
                age = agenteDao.GetLikeCodgtech("", Me.txt_agente.Text, bloq, codges, fec_prom, bala)
            End If

            If age.Count = 0 Then
                If bloq = "1" Then
                    MsgBox("El agente consultado no esta bloqueado!" & Chr(13), MsgBoxStyle.Critical, "Call Center")
                Else
                    MsgBox("Agente no econtrado! " & Chr(13), MsgBoxStyle.Critical, "Call Center")
                End If
                limpia_campos()
            ElseIf age.Count = 1 Then
                carga_datos_agens(age)
                carga_dgv_agentes(age)
            ElseIf age.Count > 1 Then
                carga_dgv_agentes(age)
                'Me.txt_agente.AutoCompleteCustomSource=Me.dgv_agentes.
            End If
        Catch ex As Exception
            MsgBox("Error al cargar agentes" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
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
        Me.dgv_agentes.DataSource = ""

        Me.dgv_historial.DataSource = ""
        ''Me.dgv_historial.DataSource = Nothing

        Me.dgv_agentes.DataSource = ""
        ' Me.dgv_agentes.DataSource = Nothing

    End Sub

    Private Sub inicializar_registro()
        Me.btn_guardar.Tag = 1
        Me.tt1.SetToolTip(Me.btn_guardar, "Iniciar llamada")
        Me.btn_guardar.BackgroundImage = My.Resources.Skype_Phone_Green

        Timer1.Enabled = False
        lbl_seg.Text = 0
        lbl_min.Text = 0
        lbl_hor.Text = 0

        Me.dtp_prom.Checked = False
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
        list_cua = QJM_cua_sDao.GetByAgente(list_agentes.Item(0).ID)
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
        list_fac = FacperiodoDao.GetByCodage(list_agentes.Item(0).ID)
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

        'With Me.dgv_agentes.Columns
        '    .Item("ID").HeaderText = "RETAILER"
        '    .Item("ID").DataPropertyName = "ID"
        '    .Item("ID").Name = "ID"
        '    .Item("ID").Width = 70
        '    .Item("ID").DisplayIndex = 1

        '    .Item("NOMBRE").HeaderText = "NOMBRE"
        '    .Item("NOMBRE").DataPropertyName = "nombre"
        '    .Item("NOMBRE").Name = "nombre"
        '    .Item("NOMBRE").Width = 225

        '    .Item("baldia").Visible = False
        '    .Item("nomrep").Visible = False
        '    .Item("usuario_update").Visible = False
        '    .Item("usuario_insert").Visible = False
        '    .Item("ciudad").Visible = False
        '    .Item("telcon1").Visible = False
        '    .Item("telefono2").Visible = False
        '    .Item("telefono1").Visible = False
        '    .Item("direccion").Visible = False
        '    .Item("bloqueada").Visible = False
        '    .Item("codasi").Visible = False
        '    .Item("fax").Visible = False
        '    .Item("retirada").Visible = False
        '    .Item("clasif").Visible = False
        'End With

        Me.lbl_total.Text = list_agentes.Count

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
    Private Sub txt_cont_TextChanged(sender As Object, e As EventArgs) Handles txt_cont.TextChanged
        'If txt_cont.Text <> "" Then
        '    Timer1.Enabled = True
        '    tini = Date.Now.TimeOfDay.ToString.Substring(0, 8)
        'Else
        '    Timer1.Enabled = False
        '    lbl_seg.Text = 0
        '    lbl_min.Text = 0
        '    lbl_hor.Text = 0
        'End If
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

    Private Sub dgv_agentes_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub dgv_agentes_SelectionChanged(sender As Object, e As EventArgs)
        'Try
        If Me.dgv_agentes.RowCount > 0 And flag = True Then
            If Not Me.dgv_agentes.CurrentRow.Cells(0).Value Is Nothing Then
                agesele = Me.dgv_agentes.CurrentRow.Cells("ID").Value
                Dim age As New List(Of agente)
                age = agenteDao.GetByCodgtech(Me.dgv_agentes.CurrentRow.Cells("ID").Value, bloq, "", "", "")
                If age.Count > 0 Then
                    carga_datos_agens(age)
                End If

                If IsNumeric(Me.txt_ruta.Text) Then
                    Dim emp As New List(Of empleado)
                    emp = empleadoDao.GetByCodemp(Me.txt_ruta.Text)
                    If Not emp Is Nothing Then
                        If emp.Count > 0 Then
                            Me.txt_eje.Text = emp.Item(0).nomemp & " " & emp.Item(0).apeemp
                        End If
                    End If
                End If

                Dim ges As New List(Of gestores)
                ges = gestoresDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                If ges.Count > 0 Then
                    Me.txt_ges.Text = ges.Item(0).nomges
                End If

                If Me.cmb_hist.SelectedIndex = 0 Then
                    Dim list_hist As New List(Of callcenteradm)
                    list_hist = callcenteradmDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value, Me.cmb_hist.SelectedItem)
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
        'Catch ex As Exception
        '    MsgBox("Error al cargar detalle de Agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        'End Try

    End Sub




    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Me.dgv_agentes.Focus()
        If Me.btn_guardar.Tag = 1 Then
            Me.btn_guardar.Tag = 2
            Me.tt1.SetToolTip(Me.btn_guardar, "Finalizar llamada")
            Me.btn_guardar.BackgroundImage = My.Resources.download

            Timer1.Enabled = True
            tini = Date.Now.TimeOfDay.ToString.Substring(0, 8)
        Else
            If txt_cont.Text = "" And txt_coment.Text = "" Then
                inicializar_registro()
            Else
                If txt_cont.Text <> "" Then
                    If txt_coment.Text <> "" Then
                        If cmb_tip.Text <> "" Then
                            If Me.dgv_agentes.RowCount > 0 Then

                                Try
                                    tfin = Date.Now.TimeOfDay.ToString.Substring(0, 8)

                                    Dim gesusu As New List(Of gestor_usuario)
                                    Dim cod_ges As Integer = 11
                                    Dim promesa_pag As String = ""
                                    gesusu = gestor_usuarioDao.GetByCodusu(codusu_reg, 0)

                                    If gesusu.Count > 0 Then

                                        cod_ges = gesusu.Item(0).codges
                                    Else
                                        If dtp_prom.Checked Then
                                            'BUSCAR EL GESTOR ASIGNADO PARA EL AGENTE SELECCIONADO
                                            MsgBox("La promesa de pago se asignara a Yenny Luna!" & Chr(13), MsgBoxStyle.Information, "Call Center")
                                        End If

                                    End If

                                    'Dim Lastcallcenter As New List(Of callcenteradm)
                                    'Lastcallcenter = callcenteradmDao.GetLast(0)
                                    Dim callcenter As New callcenteradm
                                    Dim prompag As New promesa_pag
                                    NHibernateSessionManager.Instancia.BeginTransaction()

                                    If dtp_prom.Checked = True Then
                                        promesa_pag = Me.dtp_prom.Value.Date.ToString.Substring(0, 10)
                                        prompag.codage = Me.dgv_agentes.CurrentRow.Cells("ID").Value
                                        prompag.fecha = promesa_pag
                                        prompag.codges = cod_ges
                                        PromesaPagDao.Save(prompag)
                                    End If

                                    'callcenter.ID = Lastcallcenter.Item(0).ID + 1
                                    callcenter.codges = cod_ges
                                    callcenter.codusu = Me.lbl_nom.Text
                                    callcenter.comentario = Me.txt_coment.Text & IIf(promesa_pag <> "", " - PROMESA DE PAGO: " & promesa_pag, "")
                                    callcenter.feccall = Date.UtcNow.ToString.Substring(0, 10)
                                    callcenter.fecrec = Date.Now.Date.ToString.Substring(0, 10)
                                    callcenter.horfin = Date.Now.TimeOfDay.ToString.Substring(0, 8)
                                    callcenter.horini = tini
                                    callcenter.horrec = Date.Now.TimeOfDay.ToString.Substring(0, 8)
                                    callcenter.llamar = "NO"
                                    callcenter.movcall = "Cobros"
                                    callcenter.percon = Me.txt_cont.Text
                                    callcenter.rescall = ""
                                    callcenter.ticket = "1"
                                    callcenter.tipcall = Me.cmb_tip.Text
                                    callcenter.tipo = IIf(Me.cmb_tip.Text = "SALIENTE", 1, 2)
                                    callcenter.probsys = ""
                                    callcenter.cerrado = ""
                                    callcenter.comcie = ""
                                    callcenter.feccie = ""
                                    callcenter.gescie = ""
                                    callcenter.codage = agesele

                                    callcenteradmDao.Save(callcenter)

                                    NHibernateSessionManager.Instancia.CommitTransaction()
                                    Me.txt_coment.Text = ""
                                    Me.txt_cont.Text = ""
                                    Me.cmb_tip.Text = ""

                                    Dim list_hist As New List(Of callcenteradm)
                                    list_hist = callcenteradmDao.GetByCodage(agesele, Me.cmb_hist.SelectedItem)
                                    If list_hist.Count > 0 Then
                                        carga_dgv_historial(list_hist)
                                        carga_llamadas()
                                    End If

                                    inicializar_registro()

                                Catch ex As Exception
                                    MsgBox("Error al guardar comentario: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Permisos Usuario")
                                End Try

                            Else
                                MsgBox("Usuario sin permiso " & Chr(13), MsgBoxStyle.Critical, "Call Center")
                            End If

                        Else
                            MsgBox("Seleccione el tipo de llamada " & Chr(13), MsgBoxStyle.Critical, "Call Center")
                            cmb_tip.Focus()
                        End If
                    Else
                        MsgBox("Digite el comentario " & Chr(13), MsgBoxStyle.Critical, "Call Center")
                        txt_coment.Focus()
                    End If
                Else
                    MsgBox("Digite el nombre del contacto " & Chr(13), MsgBoxStyle.Critical, "Call Center")
                    txt_cont.Focus()
                End If
            End If
        End If

    End Sub



    Private Sub btn_est_cuenta_Click(sender As Object, e As EventArgs) Handles btn_est_cuenta.Click
        'Me.Opacity = 0.8
        'Me.pwait.Visible = True

        Try
            Me.dgv_agentes.Focus()
            If Me.dgv_agentes.RowCount > 0 Then

                Dim childform As New est_cuenta
                Dim lis_estado As New List(Of estado_cuenta)
                Dim lis_venta_curso As New List(Of venta_curso)

                'NHibernateSessionManager.Instancia.BeginTransaction()
                lis_estado = estado_cuentaDao.GetByAgente(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                lis_venta_curso = venta_cursoDao.GetByAgente(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                'NHibernateSessionManager.Instancia.CommitTransaction()


                With childform
                    .lbl_agente.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value + " - " + Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
                    '.dgv_estado.DataSource = Nothing
                    If lis_estado.Count > 0 Then
                        Dim i As Integer = 0
                        lis_estado.Item(i).balance = lis_estado.Item(i).monto
                        For i = 1 To lis_estado.Count - 1
                            lis_estado.Item(i).balance = lis_estado.Item(i - 1).balance + lis_estado.Item(i).monto
                        Next
                        .dgv_estado.DataSource = lis_estado
                    End If
                    If lis_venta_curso.Count > 0 Then
                        .dgv_venta_curso.DataSource = lis_venta_curso
                    End If
                End With

                If lis_estado.Count > 0 Then
                    With childform.dgv_estado.Columns
                        .Item("USUARIO_UPDATE").Visible = False
                        .Item("USUARIO_INSERT").Visible = False
                        .Item("ID").Visible = False
                        .Item("AGENTE").Visible = False
                    End With
                    childform.lb_balance.Text = lis_estado.Item(lis_estado.Count - 1).balance.ToString("C")
                End If
                If lis_venta_curso.Count > 0 Then
                    With childform.dgv_venta_curso.Columns
                        .Item("USUARIO_UPDATE").Visible = False
                        .Item("USUARIO_INSERT").Visible = False
                        .Item("AGENTE").Visible = False
                        .Item("comv").Visible = False
                        .Item("comr").Visible = False
                        .Item("comp").Visible = False
                        .Item("ID").Visible = False
                    End With
                End If
                childform.ShowDialog()

            Else
                MsgBox("Realize una consulta y seleccione el Agente." & Chr(13), MsgBoxStyle.Critical, "Call Center")
                Me.txt_agente.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en la carga de estado de cuenta" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
        'Me.Opacity = 1
        'Me.pwait.Visible = False

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


    Private Sub dgv_agentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txt_agente_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv_agentes_DataSourceChanged(sender As Object, e As EventArgs)
        flag = True
        dgv_agentes_SelectionChanged(sender, e)
    End Sub

    Private Sub btn_soli_ajuste_Click(sender As Object, e As EventArgs) Handles btn_soli_ajuste.Click
        'Me.Opacity = 0.8
        Try
            If Me.dgv_agentes.RowCount > 0 Then

                Dim childform_ajuste As New soliajuste

                With childform_ajuste
                    .lbl_agente.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value + " - " + Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
                End With
                enviar = False
                c_a = ""
                childform_ajuste.ShowDialog()

                If enviar = True Then
                    Dim soli_ajuste_list As New List(Of soli_ajuste)
                    soli_ajuste_list = SoliajusteDao.SetByAgente(Me.lbl_nom.Text, Me.dgv_agentes.CurrentRow.Cells("ID").Value, c_a)
                    If Not soli_ajuste_list Is Nothing Then
                        If soli_ajuste_list.Count > 0 Then
                            MsgBox("Solicitud de ajuste enviada" & Chr(13), MsgBoxStyle.Information, "Call Center")
                        End If
                    End If
                End If
                enviar = False
                c_a = ""
            Else
                MsgBox("Realize una consulta y seleccione el Agente." & Chr(13), MsgBoxStyle.Critical, "Call Center")
                Me.txt_agente.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error en la carga de solicitud de ajuste" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
        'Me.Opacity = 1
    End Sub

    Private Sub cmb_hist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_hist.SelectedIndexChanged
        Try
            If Me.dgv_agentes.RowCount > 0 Then
                Dim list_hist As New List(Of callcenteradm)
                list_hist = callcenteradmDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value, Me.cmb_hist.SelectedItem)
                If list_hist.Count > 0 Then
                    carga_dgv_historial(list_hist)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en la carga de historial de llamadas " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try


    End Sub

    Private Sub txt_coment_TextChanged(sender As Object, e As EventArgs) Handles txt_coment.TextChanged
        If Me.txt_coment.Text <> "" Then
            If Me.txt_coment.Text.Length > 5 And btn_guardar.Tag = 1 Then
                btn_guardar.PerformClick()
                txt_coment.Focus()
            End If
        Else
            If Me.txt_cont.Text = "" And btn_guardar.Tag = 2 Then
                btn_guardar_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub lbl_llamadas_Click(sender As Object, e As EventArgs) Handles lbl_llamadas.Click
        Dim age_list As New List(Of agente)
        If lbl_llamadas.Text <> "0" Then
            Me.txt_agente.Text = ""
            lf = True
            Me.dtp_con_prom.Checked = False
            Me.chb_bloq.Checked = False
            Me.chk_pos.Checked = False
            Me.chk_neg.Checked = False
            lf = False
            age_list = agenteDao.GetByllamadahoy(Me.lbl_nom.Text)
            If age_list.Count = 0 Then
                limpia_campos()
            ElseIf age_list.Count = 1 Then
                carga_datos_agens(age_list)
                carga_dgv_agentes(age_list)
            ElseIf age_list.Count > 1 Then
                carga_dgv_agentes(age_list)
            End If
        Else
            MsgBox("Usted no ha realizado llamadas!" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End If
    End Sub

    Private Sub dtp_con_prom_KeyUp(sender As Object, e As KeyEventArgs) Handles dtp_con_prom.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.txt_agente.Text = ""
            carga_agentes()
        End If
    End Sub



    Private Sub btn_soli_noblo_Click(sender As Object, e As EventArgs) Handles btn_soli_noblo.Click
        Try
            If Me.dgv_agentes.RowCount > 0 Then

                Dim childform As New solinobloq
                Dim lis_sol_noblo_tipos As New List(Of sol_noblo_tipos)

                lis_sol_noblo_tipos = SolnoblotiposDao.GetByTodos("0")
                Me.dgv_agentes.Focus()
                With childform
                    .lbl_agente.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value
                    .lbl_agente.Text = Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
                    Dim i As Integer
                    For i = 0 To lis_sol_noblo_tipos.Count - 1
                        .cmb_noblo.Items.Add(lis_sol_noblo_tipos.Item(i).ID & "-" & lis_sol_noblo_tipos.Item(i).desc_noblo)
                    Next
                    .lbl_agente.Text = Me.dgv_agentes.CurrentRow.Cells("ID").Value + " - " + Me.dgv_agentes.CurrentRow.Cells("NOMBRE").Value
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TEXT_PROVINCIA.TextChanged

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub txt_eje_TextChanged(sender As Object, e As EventArgs) Handles txt_eje.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub




    Private Sub txt_agente_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_agente.KeyUp
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

    Private Sub txt_agente_TextChanged_1(sender As Object, e As EventArgs) Handles txt_agente.TextChanged

    End Sub

    Private Sub chk_pos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_pos.CheckedChanged
        If chk_pos.Checked Then
            Me.txt_agente.Text = ""
            lf = True
            Me.dtp_con_prom.Checked = False
            Me.chb_bloq.Checked = False
            Me.chk_neg.Checked = False
            lf = False
            bala = "p"
        Else
            bala = ""
        End If
        If lf = False Then
            carga_agentes()
        End If
    End Sub

    Private Sub chk_neg_CheckedChanged(sender As Object, e As EventArgs) Handles chk_neg.CheckedChanged
        If chk_neg.Checked Then
            Me.txt_agente.Text = ""
            lf = True
            Me.dtp_con_prom.Checked = False
            Me.chb_bloq.Checked = False
            Me.chk_pos.Checked = False
            lf = False
            bala = "n"
        Else
            bala = ""
        End If
        If lf = False Then
            carga_agentes()
        End If
    End Sub

    Private Sub chb_bloq_CheckedChanged(sender As Object, e As EventArgs) Handles chb_bloq.CheckedChanged
        If chb_bloq.Checked Then
            Me.txt_agente.Text = ""
            lf = True
            Me.dtp_con_prom.Checked = False
            Me.chk_pos.Checked = False
            Me.chk_neg.Checked = False
            lf = False
            bloq = "1"
        Else
            bloq = "0"
        End If
        If lf = False Then
            carga_agentes()
        End If

    End Sub
    Private Sub cmb_gest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_gest.SelectedIndexChanged
        Me.txt_agente.Text = ""
        lf = True
        Me.dtp_con_prom.Checked = False
        Me.chb_bloq.Checked = False
        Me.chk_pos.Checked = False
        Me.chk_neg.Checked = False
        lf = False
        carga_agentes()

        Dim codges As String
        Dim list_age As New List(Of agente)
        Dim arr_gestor As Array
        Dim cantp As Integer = 0
        Dim cantn As Integer = 0
        Dim cantb As Integer = 0
        Dim cantt As Integer = Me.lbl_total.Text

        arr_gestor = Me.cmb_gest.Text.Split("-")
        codges = arr_gestor(0)

        list_age = agenteDao.GetByBal(codges, "p")
        cantp = list_age.Count()

        list_age = agenteDao.GetByBal(codges, "b")
        cantb = list_age.Count()

        cantn = cantt - cantp
        chk_pos.Text = "Bal. (+) " & cantp & " / " & Convert.ToInt32((cantp / cantt * 100)) & "%"
        chk_neg.Text = "Bal. (--) " & cantn & " / " & Convert.ToInt32((cantn / cantt * 100)) & "%"
        chb_bloq.Text = "Bloq. " & cantb & " / " & Convert.ToInt32((cantb / cantt * 100)) & "%"
    End Sub

End Class