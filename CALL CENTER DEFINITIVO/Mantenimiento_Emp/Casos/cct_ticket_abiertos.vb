Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Public Class cct_ticket_abiertos
    Dim fact_tk As IDaoFactory
    Dim cct_tksDao As I_cct_tks
    Dim cct_r_tkDao As I_cct_reg_tk
    Dim tk_bind As New BindingSource
    Private Sub cct_ticket_abiertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fact_tk = New NHibernateDaoFactory
            cct_tksDao = fact_tk.Getcct_tksDao
            cct_r_tkDao = fact_tk.Getcct_reg_tkDao

            'cargamos los tickets
            Dim l_tk As New List(Of cct_tks)
            l_tk = cct_tksDao.GetByEst(LTrim(RTrim(Split(Me.lbl_age.Text, "-")(0))), CInt(Me.lbl_tipo.Text))
            If Not l_tk Is Nothing Then
                If l_tk.Count > 0 Then
                    carga_dgv_tks(l_tk)
                Else
                    If Me.lbl_cerrar.Text <> "-" And lbl_tipo.Text = "1" Then
                        MsgBox("Este agente no tiene tickets abiertos", MsgBoxStyle.Information, "Call Center")
                        Me.lbl_cerrar.Text = "cerrando"
                    ElseIf Me.lbl_cerrar.Text <> "-" And lbl_tipo.Text = "2" Then
                        MsgBox("Este agente no tiene tickets por verificar", MsgBoxStyle.Information, "Call Center")
                        Me.lbl_cerrar.Text = "cerrando"
                    End If
                    Me.Close()
                End If
            Else
                If Me.lbl_cerrar.Text <> "-" And lbl_tipo.Text = "1" Then
                    MsgBox("Este agente no tiene tickets por abiertos", MsgBoxStyle.Information, "Call Center")
                    Me.lbl_cerrar.Text = "cerrando"
                ElseIf Me.lbl_cerrar.Text <> "-" And lbl_tipo.Text = "2" Then
                    MsgBox("Este agente no tiene tickets por verificar", MsgBoxStyle.Information, "Call Center")
                    Me.lbl_cerrar.Text = "cerrando"
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar el formulario " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_tks(ByVal li As List(Of cct_tks))
        Try
            tk_bind.DataSource = li
            dgv_tks.DataSource = tk_bind
            With dgv_tks.Columns
                .Item("USUARIO_UPDATE").Visible = False
                .Item("USUARIO_INSERT").Visible = False
                .Item("FORM").Visible = False
                .Item("TB_CTRL").Visible = False
                .Item("ID_MOTIVO").Visible = False
                .Item("ID_INCIDENCIA").Visible = False
                .Item("CTRL").Visible = False
                .Item("ID").Visible = False
            End With
        Catch ex As Exception
            MsgBox("DataGrid: Error al cargar el listado de tickets " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Try
            If Me.lbl_tipo.Text = "1" Then 'tickets abiertos
                Dim childform As New comp_age
                childform.lbl_reg_age.Text = Me.lbl_age.Text
                childform.lbl_cont.Text = "1-ISAAC" 'NOMBRE DE CONTACTO
                childform.ShowDialog()

                If childform.lbl_cerrar.Text = "cerrar_tk" Then
                    'Dim l_tk As New List(Of cct_reg_tk)
                    'l_tk = cct_r_tkDao.ActRegTk(Me.dgv_tks.CurrentRow.Cells("ID").Value, 2)
                    'If Not l_tk Is Nothing Then
                    '    If l_tk.Count > 0 Then
                    '        'tk cerrado correctamente
                    Me.lbl_cerrar.Text = "-"
                    MsgBox("Registros guardados con exito!" & Chr(13), MsgBoxStyle.Information, "Call Center")
                    Me.Close()
                    'Else
                    '    MsgBox("No fue posible cerrar el ticket seleccionado ", MsgBoxStyle.Critical, "Call Center")
                    'End If
                    'End If
                End If
            ElseIf Me.lbl_tipo.Text = "2" Then 'tickets por verificar
                Me.lbl_cerrar.Text = "-"
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("DataGrid: Error al seleccionar ticket " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.lbl_cerrar.Text = "cerrando"
        Me.Close()
    End Sub

    Private Sub dgv_tks_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tks.CellDoubleClick
        If Me.btn_cerrar.Enabled = True Then
            Call btn_cerrar_Click(sender, e)
        End If
    End Sub

End Class