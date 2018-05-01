Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms

Public Class cct_mant_comp_cara
    Dim fact_comp_aux As IDaoFactory

    Dim cct_compoDao As I_cct_componentes_Dao
    Dim cct_rcDao As I_cct_reg_comp
    Dim cct_cca_Dao As I_cct_comp_cara_age
    Dim cct_generic_upDao As I_cct_generic_update
    Dim l_bind As New BindingSource
    Dim l_car_bind As New BindingSource
    Dim carga_ini As Boolean = True
    Private Sub cct_mant_comp_cara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fact_comp_aux = New NHibernateDaoFactory
            cct_compoDao = fact_comp_aux.Getcct_componentesDao
            cct_rcDao = fact_comp_aux.Getcct_reg_compDao
            cct_cca_Dao = fact_comp_aux.Getcct_comp_cara_ageDao
            cct_generic_upDao = fact_comp_aux.Getcct_generic_updateDao

            Dim li_comp As New List(Of cct_componentes)
            li_comp = cct_compoDao.GetByIDs_Comp("")
            If Not li_comp Is Nothing Then
                If li_comp.Count > 0 Then
                    carga_dgv_ccomp(li_comp)
                End If
            End If
            carga_ini = False
        Catch ex As Exception
            MsgBox("Error al cargar el formulario." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub dgv_comp_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_comp.SelectionChanged
        Try
            If dgv_comp.RowCount > 0 And carga_ini = False Then
                Dim l_cca As New List(Of cct_comp_cara_age)
                l_cca = cct_cca_Dao.GetCaraByAge("", Me.dgv_comp.CurrentRow.Cells("ID").Value)
                If Not l_cca Is Nothing Then
                    If l_cca.Count > 0 Then
                        carga_dgv_ccara(l_cca)
                    Else
                        l_car_bind.Clear()
                    End If
                Else
                    l_car_bind.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar caracteristicas." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_mod_comp_Click(sender As Object, e As EventArgs) Handles btn_mod_comp.Click
        If dgv_comp.RowCount > 0 Then
            txt_comp.Text = dgv_comp.CurrentRow.Cells("descripcion_comp").Value
            txt_comp.Tag = dgv_comp.CurrentRow.Cells("ID").Value
            dgv_comp.Enabled = False
        End If
    End Sub
    Private Sub btn_mod_cara_Click(sender As Object, e As EventArgs) Handles btn_mod_cara.Click
        If dgv_cara.RowCount > 0 Then
            txt_cara.Text = dgv_cara.CurrentRow.Cells("DESCRIPCION").Value
            txt_cara.Tag = dgv_cara.CurrentRow.Cells("ID").Value
            dgv_cara.Enabled = False
        End If
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
    Private Sub carga_dgv_ccara(ByVal li As List(Of cct_comp_cara_age))
        l_car_bind.DataSource = li
        Me.dgv_cara.DataSource = l_car_bind
        With dgv_cara.Columns
            .Item("USUARIO_UPDATE").Visible = False
            .Item("USUARIO_INSERT").Visible = False
            .Item("AGENTE").Visible = False
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
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_acep_comp_Click(sender As Object, e As EventArgs) Handles btn_acep_comp.Click
        Try
            If txt_comp.Text <> "" Then
                Dim li As New List(Of generic_update)
                li = cct_generic_upDao.SetUpdate(txt_comp.Tag, txt_comp.Text)
                dgv_comp.Enabled = True
                If txt_comp.Tag <> 0 Then
                    dgv_comp.CurrentRow.Cells("descripcion_comp").Value = txt_comp.Text
                Else
                    Me.l_bind.AddNew()
                    Me.dgv_comp.CurrentRow.Cells("ID").Value = li.Item(0).ID
                    Me.dgv_comp.CurrentRow.Cells("descripcion_comp").Value = li.Item(0).descr
                End If
                txt_comp.Text = ""
                txt_comp.Tag = 0
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar componentes." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_acep_cara_Click(sender As Object, e As EventArgs) Handles btn_acep_cara.Click
        Try
            If txt_cara.Text <> "" And dgv_comp.RowCount > 0 Then
                Dim li As New List(Of generic_update)
                li = cct_generic_upDao.SetUpdate_cara(Me.dgv_comp.CurrentRow.Cells("ID").Value, txt_cara.Tag, txt_cara.Text)
                dgv_cara.Enabled = True
                If txt_cara.Tag <> 0 Then
                    dgv_cara.CurrentRow.Cells("DESCRIPCION").Value = txt_cara.Text
                Else
                    Me.l_car_bind.AddNew()
                    Me.dgv_cara.CurrentRow.Cells("ID").Value = li.Item(0).ID
                    Me.dgv_cara.CurrentRow.Cells("DESCRIPCION").Value = li.Item(0).descr
                End If
                txt_cara.Text = ""
                txt_cara.Tag = 0
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar caracteristicas." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
End Class