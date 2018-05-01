Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms

Public Class Reg02
    Dim fac_pro As IDaoFactory
    Dim usu_proDao As IUsuarioDao
    Dim age_proDao As IAgenteDao
    Dim prospDao As I_prosp_dao
    Private Sub Reg02_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fac_pro = New NHibernateDaoFactory
        usu_proDao = fac_pro.GetUsuarioDao
        age_proDao = fac_pro.GetAgenteDao
        prospDao = fac_pro.Get_prospDao
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
    Private Sub carga_agentes()
        Try
            Dim pro As New List(Of prosp)

            If IsNumeric(Me.txt_agente.Text) Then
                pro = prospDao.GetByCodigo(Me.txt_agente.Text, "0", "", "", "")
            Else
                pro = prospDao.GetByNom("0", Me.txt_agente.Text, "0", "", "", "")
            End If

            If pro.Count = 0 Then
                MsgBox("Prospeccion no econtrada! " & Chr(13), MsgBoxStyle.Critical, "Call Center")
                limpia_campos()
            ElseIf pro.Count = 1 Then
                carga_datos_agens(pro)
                carga_dgv_agentes(pro)
            ElseIf pro.Count > 1 Then
                carga_dgv_agentes(pro)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar prospecciones" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub

    Private Sub limpia_campos()
        Me.txt_ciudad.Text = ""
        Me.txt_dir.Text = ""
        Me.txt_rep.Text = ""
        Me.txt_bloq.Text = ""

        Me.dgv_agentes.DataSource = ""
    End Sub
    Private Sub carga_datos_agens(ByVal list_agentes As List(Of prosp))
        Dim ret As String = ""
        Me.txt_ciudad.Text = list_agentes.Item(0).ciudad
        Me.txt_dir.Text = list_agentes.Item(0).direccion
        Me.txt_rep.Text = list_agentes.Item(0).nomrep
        ret = IIf(list_agentes.Item(0).retirada = "1", "/Retirada", "")
        Me.txt_bloq.Text = IIf(list_agentes.Item(0).bloqueada = 1, "Bloqueada" & ret, "Activa" & ret)
        Me.txt_clas.Text = list_agentes.Item(0).clasif

    End Sub

    Private Sub carga_dgv_agentes(ByVal list_agentes As List(Of prosp))

        Me.dgv_agentes.DataSource = list_agentes
        With Me.dgv_agentes.Columns
            .Item("ID").HeaderText = "RETAILER"
            .Item("ID").DataPropertyName = "ID"
            .Item("ID").Name = "ID"
            .Item("ID").Width = 70
            .Item("ID").DisplayIndex = 1

            .Item("NOMBRE").HeaderText = "NOMBRE"
            .Item("NOMBRE").DataPropertyName = "nombre"
            .Item("NOMBRE").Name = "nombre"
            .Item("NOMBRE").Width = 185

            .Item("baldia").Visible = False
            .Item("nomrep").Visible = False
            .Item("usuario_update").Visible = False
            .Item("usuario_insert").Visible = False
            .Item("ciudad").Visible = False
            .Item("telcon1").Visible = False
            .Item("telefono2").Visible = False
            .Item("telefono1").Visible = False
            .Item("direccion").Visible = False
            .Item("bloqueada").Visible = False
            .Item("codasi").Visible = False
            .Item("fax").Visible = False
            .Item("retirada").Visible = False
            .Item("clasif").Visible = False
        End With

        Me.lbl_total.Text = list_agentes.Count

    End Sub

    Private Sub dgv_agentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agentes.CellContentClick

    End Sub

    Private Sub dgv_agentes_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_agentes.SelectionChanged
        Try
            If Me.dgv_agentes.RowCount > 0 Then
                If Not Me.dgv_agentes.CurrentRow.Cells(0).Value Is Nothing Then
                    Dim pro As New List(Of prosp)
                    pro = prospDao.GetByCodigo(Me.dgv_agentes.CurrentRow.Cells("ID").Value, "0", "", "", "")
                    If pro.Count > 0 Then
                        carga_datos_agens(pro)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalle de Agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

End Class