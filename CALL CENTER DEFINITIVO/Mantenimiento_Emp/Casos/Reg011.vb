Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms

Public Class Reg011

    Dim factoria As IDaoFactory
    Dim usuarioDao As IUsuarioDao
    Dim agenteDao As IAgenteDao
    Dim gestoresDao As IGestoresDao
    Dim callcenteradmDao As ICallcenteradmDao
    Dim empleadoDao As IEmpleadoDao
    Dim tp_llamaDao As I_tp_llamada_Dao
    Dim gestor_usuarioDao As Igestor_usuarioDao
    Dim estado_cuentaDao As IEstado_Cuenta
    Dim usu_llamadasDao As IUsu_LLamadasDao
    Dim venta_cursoDao As IVenta_CursoDao
    Dim QJM_cua_sDao As IQJM_cua_sDao
    Dim FacperiodoDao As IFacperiodoDao
    Dim SoliajusteDao As ISoli_asjuteDao
    Dim PromesaPagDao As IPromesa_PagDao
    Dim SolnoblotiposDao As ISol_noblo_tiposDao
    Dim Filtros As Ccc_FiltroAgentesCobros
    Dim bloq As String 'Controla la busqueda de agentes bloqueados
    Dim bala As String 'Controla la busqueda de agentes con banlance positivo o negativo o todos
    Dim tini As String
    Dim tfin As String
    Dim agesele As String
    Public codusu_reg As String
    Public codusu_ccc As String
    Public flag As Boolean = True
    Public enviar As Boolean = False
    Public c_a As String = "" 'Variable para controlar el comentario de los ajustes solicitados
    Public lf As Boolean = False 'Variable para limpiar los filtros
    Dim reg_bind As New BindingSource
    Dim cont As String = ""
    Private Sub Reg01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'NHibernateSessionManager.Instancia.BeginTransaction()
            factoria = New NHibernateDaoFactory
            ''
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
            tp_llamaDao = factoria.Get_tp_llamada_Dao

            'Me.tt1.SetToolTip(Me.txt_agente, "Consulte por Retailer o Nombre de Agente.")
            'Me.tt1.SetToolTip(Me.btn_guardar, "Iniciar llamada")
            'Me.btn_guardar.BackgroundImage = My.Resources.Skype_Phone_Green
            'Me.btn_guardar.Tag = 1
            'Me.cmb_tip.SelectedIndex = 0
            'Me.lbl_nom.Text = Login.nomusu
            codusu_reg = Login.codusu

            ' LLamadas count de hoy
            '---------------------------------------------------------
            llamadas_hoy()
            '---------------------------------------------------------


            ' Cargar agentes de gestor logueado
            '---------------------------------------------------------
            'Cargar_Agentes_Logueado()
            '---------------------------------------------------------


            ' Cargar motivos
            '---------------------------------------------------------
            CargarMotivos(sender, e)
            '---------------------------------------------------------

            'cargamos los tipos de llamadas
            '---------------------------------------------------------
            Dim l_tp_llama As New List(Of cct_tp_llamda)
            l_tp_llama = tp_llamaDao.GetByEstado(0, "", 1)
            If Not l_tp_llama Is Nothing Then
                Me.cmb_tip_cc.DataSource = l_tp_llama
                Me.cmb_tip_cc.DisplayMember = "DESCRIPCION"
                Me.cmb_tip_cc.ValueMember = "ID"
            End If
            cmb_tip_cc.SelectedIndex = 1

            '---------------------------------------------------------
            'Carga de tipo de contactos
            '---------------------------------------------------------

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

            'viejo
            'Dim items(Me.ImageList1.Images.Count - 1) As String
            'For i As Int32 = 0 To Me.ImageList1.Images.Count - 1
            '    items(i) = "item " & i.ToString
            'Next
            'Me.cmb_icon_cc.Items.AddRange(items)
            'Me.cmb_icon_cc.DropDownStyle = ComboBoxStyle.DropDownList
            'Me.cmb_icon_cc.DrawMode = DrawMode.OwnerDrawVariable
            'Me.cmb_icon_cc.ItemHeight = Me.ImageList1.ImageSize.Height
            'Me.cmb_icon_cc.Width = Me.ImageList1.ImageSize.Width + 25
            'Me.cmb_icon_cc.MaxDropDownItems = Me.ImageList1.Images.Count
            'Me.cmb_icon_cc.SelectedIndex() = 0
            '---------------------------------------------------------

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
                    Dim GesLogueado As New List(Of Egestor)
                    Filtros = New Ccc_FiltroAgentesCobros
                    GesLogueado = Filtros.GetGestorLogueado(codusu_reg.ToString)

                    If GesLogueado.Count > 0 Then
                        Dim s As String = GesLogueado.Item(0).codges & "-" & GesLogueado.Item(0).nomges
                        'MsgBox(s)
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
            cargarEjecutivos()
            '---------------------------------------------------------


            If Me.lbl_nom.Text <> "---" Then
                carga_llamadas()
            End If

            'Me.btn_guardar_cc.BackgroundImage = My.Resources.phone

        Catch ex As Exception
            MsgBox("Error al cargar formulario. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try


        'Dim items(Me.ImageList1.Images.Count - 1) As String
        'For i As Int32 = 0 To Me.ImageList1.Images.Count - 1
        '    items(i) = "item " & i.ToString
        'Next
        'Me.cmb_icon.Items.AddRange(items)
        'Me.cmb_icon.DropDownStyle = ComboBoxStyle.DropDownList
        'Me.cmb_icon.DrawMode = DrawMode.OwnerDrawVariable
        'Me.cmb_icon.ItemHeight = Me.ImageList1.ImageSize.Height
        'Me.cmb_icon.Width = Me.ImageList1.ImageSize.Width + 25
        'Me.cmb_icon.MaxDropDownItems = Me.ImageList1.Images.Count
        'Me.cmb_icon.SelectedIndex() = 0


        ' ocultamos la segunda ventana
        Me.pag_reg.Parent = Nothing
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

    Private Sub txt_agente_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_agente.KeyUp
        Try

            'Me.dtp_con_prom.Checked = False
            'Me.chb_bloq.Checked = False
            'Me.chk_neg.Checked = False
            'bloq = ""
            'bala = ""
            If e.KeyCode = Keys.Enter Then

                cargar_agentesD(sender, e)

            End If
        Catch ex As Exception
            MsgBox("Error al traer total de Agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

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

    Private Sub cargar_agentesD(sender As Object, e As EventArgs)
        Filtros = New Ccc_FiltroAgentesCobros
        Dim age As New List(Of Eagentes)
        Dim codges As String = ""
        Dim codEje As String = ""
        Dim fec_prom As String = ""
     

        flag = False

        If cmb_gest.Text <> "" Then
            Dim arr_gestor As Array
            arr_gestor = Me.cmb_gest.Text.Split("-")
            codges = arr_gestor(0)
        End If


        If cmb_ejec.Text <> "" Then
            Dim arr_Eje As Array
            arr_Eje = Me.cmb_ejec.Text.Split("-")
            codEje = arr_Eje(0)
        End If
        'MsgBox("Getor: " & arr_gestor(1) & " ejecutivo: " & arr_Eje(1))

        ''age = Filtros.GetByCodgtech(bloq, codges, codEje, fec_prom, bala)

        'MsgBox(
        '    vbNewLine &
        '       " txt_agente: " & Me.txt_agente.Text & vbNewLine & " bloq: " & bloq & vbNewLine & " codges: " & codges & vbNewLine & " codEje: " & codEje & vbNewLine & " bala: " & bala & vbNewLine & " cmb_clasi: " & Me.cmb_clasi.Text)
        If Me.txt_agente.Text <> "" Then
            age = Filtros.GetByCodgtech(Me.txt_agente.Text, bloq, codges, codEje, "", bala, Me.cmb_clasi.Text)
        Else
            age = Filtros.GetByCodgtech("", bloq, codges, codEje, "", bala, Me.cmb_clasi.Text)
        End If
        'age = Filtros.GetByCodgtech(Me.txt_agente.Text.ToString, bloq, codges, codEje, "", bala, Me.cmb_clasi.Text)

        Dim list_vacia As New List(Of Eagentes)
        Me.dgv_agentes.DataSource = list_vacia

        If age.Count > 0 Then
            carga_dgv_agentesD(age)

            'dgv_agentes_SelectionChanged(sender, e)
        End If


        If age.Count = 0 Then

            If bloq = "1" Then
                MsgBox("El agente consultado no esta bloqueado!" & Chr(13), MsgBoxStyle.Critical, "Call Center")
            Else
                MsgBox("Agente no econtrado! " & Chr(13), MsgBoxStyle.Critical, "Call Center")
            End If

            'limpia_campos()
        ElseIf age.Count = 1 Then
            
            'carga_datos_agensD(age)
        ElseIf age.Count > 1 Then
            'carga_dgv_agentesD(age)
            'carga_datos_agensD(age)
            'Me.txt_agente.AutoCompleteCustomSource=Me.dgv_agentes.
        End If

    End Sub
    Private Sub carga_agentes()
        'Try
        '    Dim age As New List(Of agente)
        '    Dim codges As String = ""
        '    Dim fec_prom As String = ""
        '    If dtp_con_prom.Checked = True Then
        '        fec_prom = Me.dtp_con_prom.Value.Date.ToString.Substring(0, 10)
        '    End If

        '    flag = False

        '    If cmb_gest.Text <> "" Then
        '        Dim arr_gestor As Array
        '        arr_gestor = Me.cmb_gest.Text.Split("-")
        '        codges = arr_gestor(0)
        '    End If

        '    If IsNumeric(Me.txt_agente.Text) Then
        '        age = agenteDao.GetByCodgtech(Me.txt_agente.Text, bloq, codges, fec_prom, bala)
        '    Else
        '        age = agenteDao.GetLikeCodgtech("", Me.txt_agente.Text, bloq, codges, fec_prom, bala)
        '    End If

        '    If age.Count = 0 Then
        '        If bloq = "1" Then
        '            MsgBox("El agente consultado no esta bloqueado!" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        '        Else
        '            MsgBox("Agente no econtrado! " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        '        End If
        '        limpia_campos()
        '    ElseIf age.Count = 1 Then
        '        carga_datos_agens(age)
        '        'carga_dgv_agentes(age)
        '    ElseIf age.Count > 1 Then
        '        'carga_dgv_agentes(age)
        '        'Me.txt_agente.AutoCompleteCustomSource=Me.dgv_agentes.
        '    End If
        'Catch ex As Exception
        '    MsgBox("Error al cargar agentes" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        'End Try

    End Sub

    Private Sub limpia_campos()
        'Me.txt_bal.Text = ""
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
        'Me.txt_fac_loto.Text = ""
        'Me.txt_qjm_cua.Text = ""
        Me.dgv_agentes.DataSource = ""

        Me.dgv_historial.DataSource = ""
        ''Me.dgv_historial.DataSource = Nothing

        Me.dgv_agentes.DataSource = ""
        ' Me.dgv_agentes.DataSource = Nothing

    End Sub

    Private Sub inicializar_registro()
     
        'Me.tt1.SetToolTip(Me.btn_guardar_cc, "Iniciar llamada")
        'Me.btn_guardar_cc.BackgroundImage = My.Resources.phone

        Timer1.Enabled = False
        lbl_seg.Text = 0
        lbl_min.Text = 0
        lbl_hor.Text = 0


    End Sub

    Private Sub carga_facturacion_date(agente As String)

        Dim factDataVacia As New List(Of Eagentes)
        Dim factData As New List(Of Eagentes)
        factData = factDataVacia
        txt_FacLR.Text = ""
        txt_FacQJM.Text = ""
        txt_BalGralLR.Text = ""
        txt_BalGralLR.Text = ""
        txt_baldia.Text = ""
        txt_BalDiaLRC.Text = ""
        txt_balcurso.Text = ""

        Filtros = New Ccc_FiltroAgentesCobros
        factData = Filtros.GetFacturacion(agente)

        If factData.Count > 0 Then
            txt_FacLR.Text = factData.Item(0)._UltimaFactLRC
            txt_FacQJM.Text = factData.Item(0)._UltimaFactQJM

            txt_BalGralLR.Text = factData.Item(0)._BalGralLRC
            'txt_BalGralQJM.Text = factData.Item(0)._BalGralQJM
            txt_baldia.Text = factData.Item(0)._Baldia
            txt_BalDiaLRC.Text = factData.Item(0)._BalanceAlDiaLRC
            'txt_BalDiaQJM.Text = factData.Item(0)._BalanceAlDiaQJM
            txt_balcurso.Text = factData.Item(0).BALANCE_CURSO
        End If
      
    End Sub

    Public Sub llamadas_hoy()
        Dim HoyCount As String
        Filtros = New Ccc_FiltroAgentesCobros
        HoyCount = Filtros.GetLlamadasHoy(codusu_reg.ToString)

        lbl_llamadas.Text = HoyCount
    End Sub

    Public Sub Cargar_Agentes_Logueado()
        'Dim GesLogueado As String
        'Filtros = New Ccc_FiltroAgentesCobros
        'GesLogueado = Filtros.GetGestorLogueado(codusu_reg.ToString)

        'Dim lisAge As IList(Of Eagentes)

        'lisAge = Filtros.GetByCodgtech("", "", GesLogueado, "", "", "", "")
        'carga_dgv_agentesD(lisAge)
    End Sub

    Private Sub LimpiarCamposDatosAge()
        Me.lbl_t_ll.Text = ""
        Me.TEXT_PROVINCIA.Text = ""
        Me.TEXT_MUNICIPIO.Text = ""
        Me.TXT_SECTOR.Text = ""
        Me.txt_eje.Text = ""
        Me.txt_ruta.Text = ""
        Me.txt_ges.Text = ""

        txt_FacLR.Text = ""
        txt_FacQJM.Text = ""
        txt_BalGralLR.Text = ""
        txt_BalGralLR.Text = ""
        txt_baldia.Text = ""
        txt_BalDiaLRC.Text = ""
        txt_balcurso.Text = ""

        Me.lbl_reg_age.Text = ""

        'Me.txt_bal.Text = list_agentes.Item(0)._balTemp.ToString("C")
        Me.txt_ciudad.Text = ""
        Me.txt_tel1.Text = ""
        Me.txt_tel2.Text = ""
        Me.txt_telcon1.Text = ""
        Me.txt_dir.Text = ""
        Me.txt_rep.Text = ""
        Me.txt_ruta.Text = ""
        Me.txt_fax.Text = ""


      
        'If list_agentes.Item(0)._Bloq = "1" Then
        '    ret = "Bloqueada"
        'End If
        'If list_agentes.Item(0)._Bloq = "0" Then
        '    ret = "Activa"
        'End If
        'If list_agentes.Item(0)._Retirada = "1" Then
        '    ret = "Retirada"
        'End If
        Me.txt_bloq.Text = ""

        Me.txt_bloq.Text = ""
        Me.txt_clas.Text = ""
    End Sub
    Private Sub carga_datos_agensD(list_agentes As List(Of Eagentes))
        Dim ret As String = ""

        LimpiarCamposDatosAge()

        'MsgBox(list_agentes.Item(0)._Agente)
        carga_facturacion_date(list_agentes.Item(0)._Agente)

        Me.lbl_reg_age.Text = list_agentes.Item(0)._Agente & " - " & list_agentes.Item(0)._Nombre
        Me.TEXT_PROVINCIA.Text = list_agentes.Item(0)._Provincia
        Me.TEXT_MUNICIPIO.Text = list_agentes.Item(0)._Municipio
        Me.TXT_SECTOR.Text = list_agentes.Item(0)._Sector
        Me.txt_eje.Text = list_agentes.Item(0)._Ejecutivo
        Me.txt_ruta.Text = list_agentes.Item(0)._Ruta
        Me.txt_ges.Text = list_agentes.Item(0)._Gestor

        'Me.txt_bal.Text = list_agentes.Item(0)._balTemp.ToString("C")
        Me.txt_ciudad.Text = list_agentes.Item(0)._Ciudad
        Me.txt_tel1.Text = list_agentes.Item(0)._Tel1
        Me.txt_tel2.Text = list_agentes.Item(0)._Tel2
        Me.txt_telcon1.Text = list_agentes.Item(0)._Telcon1
        Me.txt_dir.Text = list_agentes.Item(0)._Dir
        Me.txt_rep.Text = list_agentes.Item(0)._NomRep
        Me.txt_ruta.Text = list_agentes.Item(0)._Ruta
        Me.txt_fax.Text = list_agentes.Item(0)._Fax


        'If list_agentes.Item(0)._Bloq = "1" Then
        '    ret = "Bloqueada"
        'End If
        'If list_agentes.Item(0)._Bloq = "0" Then
        '    ret = "Activa"
        'End If
        'If list_agentes.Item(0)._Retirada = "1" Then
        '    ret = "Retirada"
        'End If
        Me.txt_bloq.Text = ret
        ret = IIf(list_agentes.Item(0)._Retirada = "1", "/Retirada", "")
        Me.txt_bloq.Text = IIf(list_agentes.Item(0)._Bloq = "1", "Bloqueada" & ret, "Activa" & ret)
        Me.txt_clas.Text = list_agentes.Item(0)._Clasif

        'Me.txt_agente.Text = Me.txt_agente.Text & " - " & list_agentes.Item(0)._Nombre

        ''Carga cuadre semanal QJM
        'Dim list_cua As New List(Of qjm_cua_s)
        'list_cua = QJM_cua_sDao.GetByAgente(list_agentes.Item(0).ID)
        'If Not list_cua Is Nothing Then
        '    If list_cua.Count > 0 Then
        '        Me.txt_qjm_cua.Text = list_cua.Item(0).monto.ToString("C")
        '        Me.tt1.SetToolTip(Me.txt_qjm_cua, "QJM - Al corte del: " & list_cua.Item(0).fec_fin)
        '    Else
        '        Me.txt_qjm_cua.Text = "---"
        '        Me.tt1.SetToolTip(Me.txt_qjm_cua, "---")
        '    End If
        'End If

        ''Carga Factura Loto Real
        'Dim list_fac As New List(Of facperiodo)
        'list_fac = FacperiodoDao.GetByCodage(list_agentes.Item(0).ID)
        'If Not list_fac Is Nothing Then
        '    If list_fac.Count > 0 Then
        '        Me.txt_fac_loto.Text = list_fac.Item(0).monto.ToString("C")
        '        Me.tt1.SetToolTip(Me.txt_fac_loto, "LR - Al corte del: " & list_fac.Item(0).fecfin)
        '    Else
        '        Me.txt_fac_loto.Text = "---"
        '        Me.tt1.SetToolTip(Me.txt_fac_loto, "---")
        '    End If
        'End If



    End Sub
    Private Sub carga_datos_agens(ByVal list_agentes As List(Of agente))
        Dim ret As String = ""

        'Me.txt_bal.Text = list_agentes.Item(0).baldia.ToString("C")
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
                'Me.txt_qjm_cua.Text = list_cua.Item(0).monto.ToString("C")
                'Me.tt1.SetToolTip(Me.txt_qjm_cua, "QJM - Al corte del: " & list_cua.Item(0).fec_fin)
            Else
                'Me.txt_qjm_cua.Text = "---"
                'Me.tt1.SetToolTip(Me.txt_qjm_cua, "---")
            End If
        End If

        'Carga Factura Loto Real
        Dim list_fac As New List(Of facperiodo)
        list_fac = FacperiodoDao.GetByCodage(list_agentes.Item(0).ID)
        If Not list_fac Is Nothing Then
            If list_fac.Count > 0 Then
                'Me.txt_fac_loto.Text = list_fac.Item(0).monto.ToString("C")
                'Me.tt1.SetToolTip(Me.txt_fac_loto, "LR - Al corte del: " & list_fac.Item(0).fecfin)
            Else
                'Me.txt_fac_loto.Text = "---"
                'Me.tt1.SetToolTip(Me.txt_fac_loto, "---")
            End If
        End If



    End Sub

    Private Sub CargarLlamadas(agente As String)
        'Dim lista_ll As New List(Of Ellmada)
        'LlenarDgvLlamadas(lista_ll)
        Dim ccc_llamadas_cobros As New Ccc_LlamadasCobros
        Dim lista_llamadas As New List(Of Ellmada)

        Dim lista_vacia As New List(Of Ellmada)
        Me.dgv_hist.DataSource = lista_vacia

        Dim lista_vaciad As New List(Of ELlamadaDetalle)
        Me.dgv_historial.DataSource = lista_vaciad

        lista_llamadas = ccc_llamadas_cobros.CargarLLamadaPorAgente(agente)

       

        If Not lista_llamadas Is Nothing Then
            If lista_llamadas.Count > 0 Then
                LlenarDgvLlamadas(lista_llamadas)
            End If
        End If




        'Dim list_hist As New List(Of callcenteradm)
        'list_hist = callcenteradmDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value, Me.cmb_hist.SelectedItem)
        'If Not list_hist Is Nothing Then
        '    If list_hist.Count > 0 Then
        '        carga_dgv_historial(list_hist)
        '    Else
        '        Dim l_v As New List(Of callcenteradm)
        '        carga_dgv_historial(l_v)
        '    End If
        'Else
        '    Dim l_v As New List(Of callcenteradm)
        '    carga_dgv_historial(l_v)
        'End If

    End Sub

    Private Sub LlenarDgvLlamadas(lista_llamadas As List(Of Ellmada))
        'Me.dgv_hist.DataSource = Nothing
        'Me.dgv_hist.Rows.Clear()
      

        If lista_llamadas.Count > 0 Then
            Me.dgv_hist.DataSource = lista_llamadas

            '_Datos.AGENTE = _Leer("AGENTE").ToString
            '_Datos.TIPO_LLAMADA_DESP = _Leer("TIPO_LLAMADA_DESP").ToString
            '_Datos.CODUSU = _Leer("CODUSU").ToString
            '_Datos.FECHA = _Leer("FECHA").ToString
            '_Datos.H_FIN = _Leer("H_FIN").ToString
            '_Datos.H_INI = _Leer("H_INI").ToString
            '_Datos.ID_TP_CONT = _Leer("ID_TP_CONT").ToString
            '_Datos.ID_TP_LLAMADA = _Leer("ID_TP_LLAMADA").ToString
            '_Datos.NOM_CONT = _Leer("NOM_CONT").ToString
            '_Datos.ACTIVO = _Leer("ACTIVO").ToString


            Dim col As Integer
            For col = 0 To Me.dgv_hist.Columns.Count - 1
                Me.dgv_hist.Columns.Item(col).Visible = False
            Next
            With Me.dgv_hist.Columns
                .Item("ID_LLAMADA").DataPropertyName = "ID_LLAMADA"
                .Item("LLAMADA").Visible = False

                .Item("LLAMADA").DataPropertyName = "TIPO_LLAMADA_DESP"
                .Item("LLAMADA").Visible = True

                .Item("FECHA").DataPropertyName = "FECHA"
                .Item("FECHA").Visible = True

                .Item("HORA_INICIO").DataPropertyName = "H_INI"
                .Item("HORA_INICIO").Visible = True


                .Item("HORA_FIN").DataPropertyName = "H_FIN"
                .Item("HORA_FIN").Visible = True

                .Item("CONTACTO").DataPropertyName = "NOM_CONT"
                .Item("CONTACTO").Visible = True

                .Item("GESTOR").DataPropertyName = "GESTOR"
                .Item("GESTOR").Visible = True



            End With
            Me.lbl_t_ll.Text = lista_llamadas.Count
        End If

    End Sub
    Private Sub carga_dgv_agentesD(ByVal list_agentes As List(Of Eagentes))

        'If (Me.dgv_agentes.Rows.Count > 0) Then
        '    Me.dgv_agentes.Rows.Clear()
        'End If
        'Me.dgv_agentes.DataSource = ""
     


        If Not list_agentes Is Nothing Then
            If list_agentes.Count > 0 Then
                Me.dgv_agentes.DataSource = list_agentes

                Dim col As Integer
                For col = 0 To Me.dgv_agentes.Columns.Count - 1
                    Me.dgv_agentes.Columns.Item(col).Visible = False
                Next
                With Me.dgv_agentes.Columns
                    .Item("ID").HeaderText = "RETAILER"
                    .Item("ID").DataPropertyName = "_Agente"
                    .Item("ID").Name = "ID"
                    .Item("ID").Width = 70
                    .Item("ID").Visible = True

                    .Item("nombre").HeaderText = "NOMBRE"
                    .Item("nombre").DataPropertyName = "_Nombre"
                    .Item("nombre").Name = "nombre"
                    .Item("nombre").Width = 225
                    .Item("nombre").Visible = True
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

                'If list_agentes.Count > 0 Or list_agentes.Count = 1 Then 
                '    dgv_agentes.Rows(0).Selected = True
                'End If



            End If
        End If
        'carga_datos_agensD(list_agentes)

    End Sub
    Private Sub carga_dgv_agentes(ByVal list_agentes As List(Of Eagentes))

        Me.dgv_agentes.DataSource = list_agentes
        If list_agentes.Count > 0 Then

            Dim col As Integer
            For col = 0 To Me.dgv_agentes.Columns.Count - 1
                Me.dgv_agentes.Columns.Item(col).Visible = False
            Next
            With Me.dgv_agentes.Columns
                .Item("ID").HeaderText = "RETAILER"
                .Item("ID").DataPropertyName = "_Agente"
                .Item("ID").Name = "ID"
                .Item("ID").Width = 70
                .Item("ID").DisplayIndex = 0
                .Item("ID").Visible = True

                .Item("nombre").HeaderText = "NOMBRE"
                .Item("nombre").DataPropertyName = "_Nombre"
                .Item("nombre").Name = "nombre"
                .Item("nombre").Width = 225
                .Item("nombre").Visible = True
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
        End If
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

    Private Sub dgv_agentes_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgv_agentes.DataError

    End Sub

    Private Sub dgv_agentes_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_agentes.SelectionChanged
        Try
            'If Me.dgv_agentes.RowCount > 0 And flag = True Then
            If Me.dgv_agentes.RowCount > 0 Then
                If Not Me.dgv_agentes.CurrentRow.Cells(0).Value Is Nothing Then
                    agesele = Me.dgv_agentes.CurrentRow.Cells("ID").Value
                    Dim age As New List(Of Eagentes)

                    Filtros = New Ccc_FiltroAgentesCobros
                    'MsgBox("Agente: " & Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                    age = Filtros.GetByCodgtech(Me.dgv_agentes.CurrentRow.Cells("ID").Value, "", "", "", "", "", "")

                    If age.Count > 0 Then
                        carga_datos_agensD(age)

                        CargarLlamadas(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                    End If

                    'If IsNumeric(Me.txt_ruta.Text) Then
                    '    Dim emp As New List(Of empleado)
                    '    emp = empleadoDao.GetByCodemp(Me.txt_ruta.Text)
                    '    If Not emp Is Nothing Then
                    '        If emp.Count > 0 Then
                    '            Me.txt_eje.Text = emp.Item(0).nomemp & " " & emp.Item(0).apeemp
                    '        End If
                    '    End If
                    'End If

                    'Dim ges As New List(Of gestores)
                    'ges = gestoresDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                    'If ges.Count > 0 Then
                    '    Me.txt_ges.Text = ges.Item(0).nomges
                    'End If

                    'If Me.cmb_hist.SelectedIndex = 0 Then
                    '    Dim list_hist As New List(Of callcenteradm)
                    '    list_hist = callcenteradmDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value, Me.cmb_hist.SelectedItem)
                    '    If Not list_hist Is Nothing Then
                    '        If list_hist.Count > 0 Then
                    '            carga_dgv_historial(list_hist)
                    '        Else
                    '            Dim l_v As New List(Of callcenteradm)
                    '            carga_dgv_historial(l_v)
                    '        End If
                    '    Else
                    '        Dim l_v As New List(Of callcenteradm)
                    '        carga_dgv_historial(l_v)
                    '    End If
                    'Else
                    '    Me.cmb_hist.SelectedIndex = 0
                    'End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalle de Agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub


    Private Sub chb_bloq_CheckedChanged(sender As Object, e As EventArgs) Handles chb_bloq.CheckedChanged
        If chb_bloq.Checked Then
            Me.txt_agente.Text = ""
            lf = True
            'Me.dtp_con_prom.Checked = False
            Me.chk_pos.Checked = False
            Me.chk_neg.Checked = False
            lf = False
            bala = ""
            bloq = "1"
        Else
            bloq = "0"
        End If
        If lf = False Then
            cargar_agentesD(sender, e)
        End If

    End Sub


    Private Sub cmb_gest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_gest.SelectedIndexChanged
        Me.txt_agente.Text = ""
        lf = True
        'Me.dtp_con_prom.Checked = False
        Me.chb_bloq.Checked = False
        Me.chk_pos.Checked = False
        Me.chk_neg.Checked = False
        bloq = ""
        bala = ""
        lf = False
        cargar_agentesD(sender, e)

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


        'Cagar los ejecutivos-empleados por gestor
        '---------------------------------------------------------
        Filtros = New Ccc_FiltroAgentesCobros
        If cmb_gest.Text = "-TODOS" Then
            cargarEjecutivos()
        Else
            cargarEjecutivosGestor(codges)
        End If

        '---------------------------------------------------------


        cantn = cantt - cantp
        chk_pos.Text = "Bal. (+) " & cantp & " / " & Convert.ToInt32((cantp / cantt * 100)) & "%"
        chk_neg.Text = "Bal. (--) " & cantn & " / " & Convert.ToInt32((cantn / cantt * 100)) & "%"
        chb_bloq.Text = "Bloq. " & cantb & " / " & Convert.ToInt32((cantb / cantt * 100)) & "%"
    End Sub

    Private Sub cargarEjecutivosGestor(gestor As String)

        'Cagar los ejecutivos-empleados por gestor
        '---------------------------------------------------------
        Filtros = New Ccc_FiltroAgentesCobros
        Try
            Me.cmb_ejec.Items.Clear()
            Dim emple As New List(Of Eempleado)
            emple = Filtros.GetEjeByGestor(gestor)
            Me.cmb_ejec.Items.Add("-TODOS")

            If emple.Count = 0 Then
                MsgBox("Ejecutivos no cargados! " & Chr(13), MsgBoxStyle.Critical, "Call Center")
            Else
                Dim i As Integer
                For i = 0 To emple.Count - 1
                    Me.cmb_ejec.Items.Add(emple.Item(i).codasi & "-" & emple.Item(i).nomemp & " " & emple.Item(i).apeemp)
                Next
            End If

        Catch ex As Exception
            MsgBox("Error en la carga de ejecutivos: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub cargarEjecutivos()

        'Carga de ejecutivos-empleado
        '---------------------------------------------------------
        Try
            Me.cmb_ejec.Items.Clear()
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


    Private Sub dgv_agentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agentes.CellContentClick

    End Sub



    'Private Sub dgv_agentes_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_agentes.DataSourceChanged
    '    flag = True
    '    dgv_agentes_SelectionChanged(sender, e)
    'End Sub

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

    'Private Sub cmb_hist_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Try
    '        If Me.dgv_agentes.RowCount > 0 Then
    '            Dim list_hist As New List(Of callcenteradm)
    '            list_hist = callcenteradmDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value, Me.cmb_hist.SelectedItem)
    '            If list_hist.Count > 0 Then
    '                carga_dgv_historial(list_hist)
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MsgBox("Error en la carga de historial de llamadas " & Chr(13), MsgBoxStyle.Critical, "Call Center")
    '    End Try


    'End Sub



    Private Sub lbl_llamadas_Click(sender As Object, e As EventArgs) Handles lbl_llamadas.Click
        Dim age_list As New List(Of agente)
        If lbl_llamadas.Text <> "0" Then
            Me.txt_agente.Text = ""
            lf = True
            'Me.dtp_con_prom.Checked = False
            Me.chb_bloq.Checked = False
            Me.chk_pos.Checked = False
            Me.chk_neg.Checked = False
            lf = False
            age_list = agenteDao.GetByllamadahoy(Me.lbl_nom.Text)
            If age_list.Count = 0 Then
                limpia_campos()
            ElseIf age_list.Count = 1 Then
                carga_datos_agens(age_list)
                'carga_dgv_agentes(age_list)
            ElseIf age_list.Count > 1 Then
                'carga_dgv_agentes(age_list)
            End If
        Else
            MsgBox("Usted no ha realizado llamadas!" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End If
    End Sub

    Private Sub dtp_con_prom_KeyUp(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'Me.txt_agente.Text = "" 
            'Me.dtp_con_prom.Checked = False
            'Me.chb_bloq.Checked = False
            'Me.chk_pos.Checked = False
            'Me.chk_neg.Checked = False

            bloq = ""
            bala = ""
            cargar_agentesD(sender, e)
        End If
    End Sub

    Private Sub chk_neg_CheckedChanged(sender As Object, e As EventArgs) Handles chk_neg.CheckedChanged
        If chk_neg.Checked Then
            bloq = ""
            Me.txt_agente.Text = ""
            lf = True
            'Me.dtp_con_prom.Checked = False
            Me.chb_bloq.Checked = False
            Me.chk_pos.Checked = False
            lf = False
            bala = "n"
        Else
            bala = ""
        End If
        If lf = False Then
            cargar_agentesD(sender, e)
        End If
    End Sub

    Private Sub chk_pos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_pos.CheckedChanged
        If chk_pos.Checked Then
            bloq = ""
            Me.txt_agente.Text = ""
            lf = True
            'Me.dtp_con_prom.Checked = False
            Me.chb_bloq.Checked = False
            Me.chk_neg.Checked = False
            lf = False
            bala = "p"
        Else
            bala = ""
        End If
        If lf = False Then
            cargar_agentesD(sender, e)
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

    Private Sub cmb_ejec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ejec.SelectedIndexChanged
        Me.txt_agente.Text = ""
        lf = True
        'Me.dtp_con_prom.Checked = False
        Me.chb_bloq.Checked = False
        Me.chk_pos.Checked = False
        Me.chk_neg.Checked = False
        bloq = ""
        bala = ""
        lf = False

        cargar_agentesD(sender, e)
    End Sub



    Private Sub dtp_con_prom_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_clasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_clasi.SelectedIndexChanged

        Me.txt_agente.Text = ""
        lf = True
        'Me.dtp_con_prom.Checked = False
        Me.chk_pos.Checked = False
        Me.chk_neg.Checked = False
        lf = False
        bala = ""
        bloq = ""

        cargar_agentesD(sender, e)
    End Sub


    Private Sub btn_guardar_cc_Click(sender As Object, e As EventArgs) Handles btn_guardar_cc.Click
        Try
            If Me.btn_guardar_cc.Tag = 1 Then
                Me.btn_guardar_cc.Text = "FINALIZAR LLAMADA"
                Me.CONTEO.Visible = True
                Me.btn_guardar_cc.ForeColor = Color.Red
                Me.btn_guardar_cc.Width = 179
                Me.btn_guardar_cc.Tag = 2
                Me.pag_reg.Parent = Me.tb_reg
                Me.tb_reg.SelectedIndex = 1
                Me.cmb_tip_cc.Focus()
                'Me.gb_time.Visible = True
                Timer1.Enabled = True
                tini = Date.Now.TimeOfDay.ToString.Substring(0, 8)
                Me.reg_bind.Clear()
                Me.dgv_reg.DataSource = reg_bind
            Else
                'If Me.dgv_reg.RowCount > 0 Then
                If Me.txt_cont.Text <> "" Then
                    tfin = Date.Now.TimeOfDay.ToString.Substring(0, 8)
                    Dim comen As String = ""
                    'VERIFICAR CLASIFICACION PARA ENVIO DE CORREO
                    'If Me.txt_clas.Text = "A" Or Me.txt_clas.Text = "B" Then
                    '    comen = "enviar"
                    'End If

                    'INSERTAMOS LA LLAMADA
                    Dim CCC_Cobros As New Ccc_LlamadasCobros
                    Dim llamada_list As New ELlamadaHeader
                    Dim id_Llamada As String


                    If codusu_reg = "" Or codusu_reg Is Nothing Then
                        codusu_reg = "0"
                    End If

                    'llamada_list = llamadaDao.SetLlamada(cmb_tip.SelectedValue, Me.dgv_agentes.CurrentRow.Cells("ID").Value, codusu_cct, Me.cmb_icon.SelectedIndex, cont, 1, 1, 1, "", "", tini, tfin, 1)
                    'MsgBox(
                    ' vbNewLine & " dgv_agentes: " & Me.dgv_agentes.CurrentRow.Cells("ID").Value &
                    ' vbNewLine & " codusu: " & codusu_reg &
                    ' vbNewLine & " fecha: " & Date.Now.Date.ToString.Substring(0, 10) &
                    ' vbNewLine & " hf: " & tfin &
                    'vbNewLine & " hi: " & tini &
                    'vbNewLine & " tipo_lla: " & Me.cmb_tip_cc.SelectedValue.ToString &
                    'vbNewLine & " contacto: " & Me.txt_cont.Text &
                    ' vbNewLine & " icon_tpc: " & Me.cmb_icon.SelectedIndex.ToString
                    '    )
                    id_Llamada = CCC_Cobros.InsertarLlamadaHeader(
                        Me.dgv_agentes.CurrentRow.Cells("ID").Value,
                        Me.txt_ges.Text,
                        codusu_reg,
                        Date.Now.Date.ToString.Substring(0, 10),
                        tfin,
                        tini,
                         Me.cmb_tip_cc.SelectedValue,
                         Me.txt_cont.Text.ToString,
                         Me.cmb_icon.SelectedIndex,
                         "1")



                    'MsgBox("id_Llamada: " & id_Llamada)
                    'INSERTAMOS CADA UNO DE LOS REGISTROS
                    Dim reg_list As New List(Of cct_reg_llamada)
                    For Each row As DataGridViewRow In dgv_reg.Rows

                        ''Cerramos el ticket
                        'If row.Cells("ID_TK").Value <> "0" And row.Cells("ID_MOTIVO").Value = "31" Then
                        '    Dim l_tk As New List(Of cct_reg_tk)
                        '    l_tk = r_tkDao.ActRegTk(row.Cells("ID_TK").Value, 2, 0)
                        '    If Not l_tk Is Nothing Then
                        '        If l_tk.Count > 0 Then
                        '            'tk cerrado correctamente
                        '        Else
                        '            MsgBox("No fue posible cerrar el ticket seleccionado ", MsgBoxStyle.Critical, "Call Center")
                        '        End If
                        '    End If
                        'ElseIf row.Cells("ID_TK").Value <> "0" And row.Cells("ID_MOTIVO").Value = "34" Then
                        '    Dim l_tk As New List(Of cct_reg_tk)
                        '    l_tk = r_tkDao.GetEstTk(row.Cells("ID_TK").Value)
                        '    If Not l_tk Is Nothing Then
                        '        If l_tk.Count > 0 Then
                        '            If l_tk.Item(0).ID = 2 Then
                        '                l_tk = r_tkDao.ActRegTk(row.Cells("ID_TK").Value, 2, 1)
                        '                If Not l_tk Is Nothing Then
                        '                    If l_tk.Count > 0 Then
                        '                        'tk verificado correctamente
                        '                    Else
                        '                        MsgBox("No fue posible verificar el ticket seleccionado ", MsgBoxStyle.Critical, "Call Center")
                        '                    End If
                        '                End If
                        '            End If
                        '        End If
                        '    End If
                        'End If


                        'AGENTE As String,
                        'CODUSU As String, 
                        'H_FIN As String,
                        'H_INI As String,
                        'ID_TP_LLAMADA As String,
                        'NOM_CONT As String,
                        'ID_CONT As String, 
                        'ID_LLAMADA As String,
                        'ID_MOTIVO As String,
                        'ID_INCIDENCIA As String,
                        'ID_CONCLUSION As String,
                        'NOTA As String  

                        CCC_Cobros.InsertarLlamadaDetalle(
                            Me.dgv_agentes.CurrentRow.Cells("ID").Value,
                           codusu_reg,
                         tfin,
                          tini,
                         Me.cmb_tip_cc.SelectedValue,
                         Me.txt_cont.Text,
                          Me.cmb_icon.SelectedIndex,
                          id_Llamada,
                          row.Cells("ID_MOTIVO").Value,
                          row.Cells("ID_INCIDENCIA").Value,
                          row.Cells("ID_CONCLUSION").Value,
                          row.Cells("NOTA").Value
                          )

                        'Me.dgv_agentes.CurrentRow.Cells("ID").Value, 0, cont, cmb_tip.SelectedValue, row.Cells("ID_MOTIVO").Value, row.Cells("ID_INCIDENCIA").Value, row.Cells("ID_CONCLUSION").Value, row.Cells("NOTA").Value, "", "", tini, tfin, codusu_cct, llamada_list.Item(0).ID, row.Cells("ID_TK").Value)

                        ''VERIFICAMOS SI HAY TK
                        'If row.Cells("ID_CONCLUSION").Value = "1" Then
                        '    Dim reg_tk As New List(Of cct_reg_tk)
                        '    reg_tk = r_tkDao.SetRegTk(1, 0, reg_list.Item(0).ID, comen, 0, codusu_cct)

                        '    'INSERTAMOS EL TICKET CREADO EN EL REGISTRO DE LLAMADA
                        '    reg_list = R_llamaDao.ActRegLlama(reg_list.Item(0).ID, reg_tk.Item(0).ID)
                        'End If
                    Next
                    CargarLlamadas(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                    'LIMPIAR CAMPOS
                    cerrar_llamada()
                    llamadas_hoy()

                    'Cargar las llamadas de nuevo
                    '--------------------------------------------------------

                    '--------------------------------------------------------


                    'Me.gb_time.Visible = False
                    'Me.gb_agente.Enabled = True
                Else
                    MsgBox("Especifique el nombre del contacto" & Chr(13), MsgBoxStyle.Information, "Call Center")
                End If

                'Else
                '    MsgBox("Por favor complete el registro correctamente" & Chr(13), MsgBoxStyle.Information, "Call Center")
                'End If
            End If
        Catch ex As Exception
            MsgBox("Error en registro de llamada" & Chr(13), MsgBoxStyle.Information, "Call Center")
        End Try
    End Sub
    Private Sub cerrar_llamada()
        Timer1.Enabled = False
        lbl_seg.Text = 0
        lbl_min.Text = 0
        lbl_hor.Text = 0
        Me.txt_cont.Text = ""
        'Me.cmb_eje.SelectedIndex = 0
        Me.cmb_icon.SelectedIndex = 0
        Me.cmb_top.SelectedIndex = 0
        Me.txt_cont.Text = ""
        'Me.dgv_agentes.ClearSelection()

        Me.txt_coment_cc.Text = ""
        Me.btn_guardar_cc.Text = ""
        Me.CONTEO.Visible = False
        Me.btn_guardar_cc.ForeColor = Color.Green
        Me.btn_guardar_cc.Width = 45
        Me.btn_guardar_cc.Tag = 1
        Me.pag_reg.Parent = Nothing
        Me.tb_reg.TabPages(0).Focus()
        inicializar_registro()


    End Sub
    Private Sub btn_agrega_act_Click(sender As Object, e As EventArgs) Handles btn_agrega_act.Click
        Try
            Dim reg As Boolean
            ''MsgBox("cmb_tip_cc: " & cmb_tip_cc.Text & " cmb_mov: " & cmb_mov.Text & " cmb_inc: " & cmb_inc.Text & " cmb_con: " & cmb_con.Text & " cont: " & txt_cont)
            If cmb_tip_cc.Text <> "" And cmb_mov.Text <> "" And cmb_inc.Text <> "" And cmb_con.Text <> "" And txt_cont.Text <> "" Then
                If Me.dgv_agentes.RowCount > 0 Then
                    reg = True
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
                        'MsgBox(Me.dgv_agentes.CurrentRow.Cells("ID").Value.ToString & "," & cmb_mov.Text & "," & cmb_mov.SelectedValue & "," & cmb_inc.Text & "," & cmb_inc.SelectedValue & "," & cmb_con.Text & "," & cmb_con.SelectedValue & "," & txt_coment_cc.Text)


                        Agrega_reg(Me.dgv_agentes.CurrentRow.Cells("ID").Value, cmb_mov.Text, cmb_mov.SelectedValue, cmb_inc.Text, cmb_inc.SelectedValue, cmb_con.Text, cmb_con.SelectedValue, txt_coment_cc.Text)
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
    Private Sub Agrega_reg(age As String, mot As String, id_mot As String, inc As String, id_inc As String, con As String, id_con As String, nota As String)
        Me.reg_bind.AddNew()
        Me.dgv_reg.CurrentRow.Cells("RETAILER").Value = age
        Me.dgv_reg.CurrentRow.Cells("MOTIVO").Value = mot
        Me.dgv_reg.CurrentRow.Cells("ID_MOTIVO").Value = id_mot
        Me.dgv_reg.CurrentRow.Cells("INCIDENCIA").Value = inc
        Me.dgv_reg.CurrentRow.Cells("ID_INCIDENCIA").Value = id_inc
        Me.dgv_reg.CurrentRow.Cells("CONCLUSION").Value = con
        Me.dgv_reg.CurrentRow.Cells("ID_CONCLUSION").Value = id_con
        Me.dgv_reg.CurrentRow.Cells("NOTA").Value = nota


        'inicializar_registro() ' vovler a inicar todo lo deese action

        Me.cmb_mov.Focus()
        Me.txt_coment_cc.Text = ""
        'Me.gb_agente.Enabled = False
    End Sub

    Private Sub cmb_mov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mov.SelectedIndexChanged
        Try
            Dim ccc_LlamadasCobros = New Ccc_LlamadasCobros
            If IsNumeric(cmb_mov.SelectedValue) Then

                Dim list_incidencia As New List(Of Eincidencia)
                list_incidencia = ccc_LlamadasCobros.CargarIncidencia(cmb_mov.SelectedValue)
                If Not list_incidencia Is Nothing Then
                    Me.cmb_inc.DataSource = list_incidencia
                    Me.cmb_inc.DisplayMember = "descripcion"
                    Me.cmb_inc.ValueMember = "codigo"
                End If
                cmb_inc_SelectedIndexChanged(sender, e)
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las incidencias. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub CargarMotivos(sender As Object, e As EventArgs)
        Dim ccc_LlamadasCobros = New Ccc_LlamadasCobros
        Dim list_motivos As New List(Of Emotivo)
        list_motivos = ccc_LlamadasCobros.CargarMotivos()
        If Not list_motivos Is Nothing Then
            Me.cmb_mov.DataSource = list_motivos
            Me.cmb_mov.DisplayMember = "descripcion"
            Me.cmb_mov.ValueMember = "codigo"
            cmb_mov_SelectedIndexChanged(sender, e)
        End If
    End Sub
    Private Sub cmb_mov_TextChanged(sender As Object, e As EventArgs) Handles cmb_mov.TextChanged
        'Try
        '    Dim ccc_LlamadasCobros = New Ccc_LlamadasCobros
        '    If IsNumeric(cmb_mov.SelectedValue) Then

        '        Dim list_incidencia As New List(Of Eincidencia)
        '        list_incidencia = ccc_LlamadasCobros.CargarIncidencia(cmb_mov.SelectedValue)
        '        If Not list_incidencia Is Nothing Then
        '            Me.cmb_inc.DataSource = list_incidencia
        '            Me.cmb_inc.DisplayMember = "descripcion"
        '            Me.cmb_inc.ValueMember = "codigo"
        '        End If

        '    End If

        'Catch ex As Exception
        '    MsgBox("Error al cargar las incidencias. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        'End Try
    End Sub

    Private Sub cmb_inc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_inc.SelectedIndexChanged
        Try
            Dim ccc_LlamadasCobros = New Ccc_LlamadasCobros
            If IsNumeric(cmb_inc.SelectedValue) Then

                Dim list_conclucion As New List(Of Econclucion)
                list_conclucion = ccc_LlamadasCobros.CargarConclucion(cmb_inc.SelectedValue)
                If Not list_conclucion Is Nothing Then
                    Me.cmb_con.DataSource = list_conclucion
                    Me.cmb_con.DisplayMember = "descripcion"
                    Me.cmb_con.ValueMember = "codigo"
                End If

            End If

        Catch ex As Exception
            MsgBox("Error al cargar las concluciones. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub cmb_inc_TextChanged(sender As Object, e As EventArgs) Handles cmb_inc.TextChanged

    End Sub

    Private Sub tt1_Popup(sender As Object, e As PopupEventArgs) Handles tt1.Popup

    End Sub

    Private Sub txt_agente_TextChanged(sender As Object, e As EventArgs) Handles txt_agente.TextChanged

    End Sub

    Private Sub dgv_agentes_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_agentes.MouseClick
        Try
            'If Me.dgv_agentes.RowCount > 0 And flag = True Then
            If Me.dgv_agentes.RowCount > 0 Then
                If Not Me.dgv_agentes.CurrentRow.Cells(0).Value Is Nothing Then
                    agesele = Me.dgv_agentes.CurrentRow.Cells("ID").Value
                    Dim age As New List(Of Eagentes)

                    Filtros = New Ccc_FiltroAgentesCobros
                    age = Filtros.GetByCodgtech(Me.dgv_agentes.CurrentRow.Cells("ID").Value, "", "", "", "", "", "")

                    If age.Count > 0 Then
                        carga_datos_agensD(age)
                        CargarLlamadas(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                    End If

                    '            'If IsNumeric(Me.txt_ruta.Text) Then
                    '            '    Dim emp As New List(Of empleado)
                    '            '    emp = empleadoDao.GetByCodemp(Me.txt_ruta.Text)
                    '            '    If Not emp Is Nothing Then
                    '            '        If emp.Count > 0 Then
                    '            '            Me.txt_eje.Text = emp.Item(0).nomemp & " " & emp.Item(0).apeemp
                    '            '        End If
                    '            '    End If
                    '            'End If

                    '            'Dim ges As New List(Of gestores)
                    '            'ges = gestoresDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value)
                    '            'If ges.Count > 0 Then
                    '            '    Me.txt_ges.Text = ges.Item(0).nomges
                    '            'End If

                    '            'If Me.cmb_hist.SelectedIndex = 0 Then
                    '            '    Dim list_hist As New List(Of callcenteradm)
                    '            '    list_hist = callcenteradmDao.GetByCodage(Me.dgv_agentes.CurrentRow.Cells("ID").Value, Me.cmb_hist.SelectedItem)
                    '            '    If Not list_hist Is Nothing Then
                    '            '        If list_hist.Count > 0 Then
                    '            '            carga_dgv_historial(list_hist)
                    '            '        Else
                    '            '            Dim l_v As New List(Of callcenteradm)
                    '            '            carga_dgv_historial(l_v)
                    '            '        End If
                    '            '    Else
                    '            '        Dim l_v As New List(Of callcenteradm)
                    '            '        carga_dgv_historial(l_v)
                    '            '    End If
                    '            'Else
                    '            '    Me.cmb_hist.SelectedIndex = 0
                    '            'End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalle de Agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub


    Private Sub dgv_hist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_hist.CellContentClick

    End Sub

    Private Sub CargarDetalleLlamada(llamada As String)
        Dim List_det_llamadas As New List(Of ELlamadaDetalle)
        Dim ccc_llamadaCobros As New Ccc_LlamadasCobros
        List_det_llamadas = ccc_llamadaCobros.CargarLLamadaDetalle(llamada)

        If Not List_det_llamadas Is Nothing Then
            LlenarDgvDetalleLlamada(List_det_llamadas)
        End If


    End Sub
    Private Sub LlenarDgvDetalleLlamada(List_det_llamadas As List(Of ELlamadaDetalle))
        Dim lista_vacia As New List(Of ELlamadaDetalle)
        Me.dgv_historial.DataSource = lista_vacia

        If List_det_llamadas.Count > 0 Then
            Me.dgv_historial.DataSource = List_det_llamadas


            Dim col As Integer
            For col = 0 To Me.dgv_historial.Columns.Count - 1
                Me.dgv_historial.Columns.Item(col).Visible = False
            Next
            With Me.dgv_historial.Columns

                .Item("H_INICIO").DataPropertyName = "H_INI"
                .Item("H_INICIO").Visible = True


                .Item("H_FIN").DataPropertyName = "H_FIN"
                .Item("H_FIN").Visible = True

                .Item("MOTIVOD").DataPropertyName = "DES_MOTIVO"
                .Item("MOTIVOD").Visible = True

                .Item("INCIDENCIAD").DataPropertyName = "DES_INCIDENCIA"
                .Item("INCIDENCIAD").Visible = True

                .Item("CONCLUCIOND").DataPropertyName = "DES_CONCLUSION"
                .Item("CONCLUCIOND").Visible = True

                .Item("NOTAD").DataPropertyName = "NOTA"
                .Item("NOTAD").Visible = True



            End With
            Me.lbtllamadadet.Text = List_det_llamadas.Count
        End If

    End Sub

    Private Sub dgv_hist_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_hist.MouseClick
        Try
            If Me.dgv_hist.RowCount > 0 Then
                Dim LLamada As String = Me.dgv_hist.CurrentRow.Cells("ID_LLAMADA").Value
                'MsgBox(LLamada)
                CargarDetalleLlamada(LLamada)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalle de llamadas: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub dgv_hist_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_hist.SelectionChanged
        Try
            If Me.dgv_hist.RowCount > 0 Then
                Dim LLamada As String = Me.dgv_hist.CurrentRow.Cells("ID_LLAMADA").Value
                'MsgBox(LLamada)
                CargarDetalleLlamada(LLamada)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalle de llamadas: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

 
End Class