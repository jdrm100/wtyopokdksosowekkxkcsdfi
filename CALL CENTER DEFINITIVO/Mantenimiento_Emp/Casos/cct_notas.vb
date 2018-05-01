Imports System
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports System.IO
Public Class cct_notas_frm
    Dim fac_cct_n As IDaoFactory
    Dim cct_r_nDao As I_cct_reg_nota
    Dim cct_nDao As I_cct_notas

    Dim l_bind As New BindingSource
    Private Sub cct_notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fac_cct_n = New NHibernateDaoFactory
            cct_r_nDao = fac_cct_n.Getcct_reg_notaDao
            cct_nDao = fac_cct_n.Getcct_notasDao

            Dim ln As New List(Of cct_notas)
            ln = cct_nDao.GetNotaByAge(LTrim(RTrim(Split(Me.lbl_age.Text, "-")(0))), "", "", "", "")
            If Not ln Is Nothing Then
                If ln.Count > 0 Then
                    carga_dgv_notas(ln)
                End If
            End If

            Me.txt_usub.Text = Me.txt_usub.Tag
            Me.txt_usub.ForeColor = Color.Gray
            Me.txt_notb.Text = Me.txt_notb.Tag
            Me.txt_notb.ForeColor = Color.Gray
        Catch ex As Exception
            MsgBox("Error al cargar el formulario " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub carga_dgv_notas(ByVal l As List(Of cct_notas))
        Try
            l_bind.DataSource = l
            Me.dgv_notas.DataSource = l_bind
            With Me.dgv_notas.Columns
                .Item("usuario_update").Visible = False
                .Item("usuario_insert").Visible = False
                .Item("ID").Visible = False
                .Item("AGENTE").Visible = False
            End With
        Catch ex As Exception
            MsgBox("Error al cargar notas (DataGrid)." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_a_Click(sender As Object, e As EventArgs) Handles btn_a.Click
        Try
            Dim reg As New List(Of cct_reg_nota)
            Dim f_a As String = ""
            If dtp_fec_a.Checked Then
                f_a = dtp_fec_a.Text
            End If
            reg = cct_r_nDao.SetRegNota(LTrim(RTrim(Split(Me.lbl_age.Text, "-")(0))), Login.codusu, Me.txt_nota.Text, f_a)
            If Not reg Is Nothing Then
                If reg.Count > 0 Then
                    Me.txt_nota.Text = ""
                    Me.dtp_fec_a.Value = Today
                    Me.dtp_fec_a.Checked = False
                    Me.txt_usub.Text = Me.txt_usub.Tag
                    Me.txt_notb.TabIndex = Me.txt_notb.Tag
                    Me.txt_usub.ForeColor = Color.Gray
                    Me.txt_notb.ForeColor = Color.Gray
                    Dim ln As New List(Of cct_notas)
                    ln = cct_nDao.GetNotaByAge(LTrim(RTrim(Split(Me.lbl_age.Text, "-")(0))), "", "", "", "")
                    If Not ln Is Nothing Then
                        If ln.Count > 0 Then
                            carga_dgv_notas(ln)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registros " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub txt_usub_GotFocus(sender As Object, e As EventArgs) Handles txt_usub.GotFocus
        If Me.txt_usub.Text = Me.txt_usub.Tag.ToString.ToUpper Then
            Me.txt_usub.Text = ""
            Me.txt_usub.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_usub_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_usub.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btn_buscar_Click(sender, e)
        End If
    End Sub

    Private Sub txt_usub_LostFocus(sender As Object, e As EventArgs) Handles txt_usub.LostFocus
        If Me.txt_usub.Text = "" Then
            Me.txt_usub.Text = Me.txt_usub.Tag
            Me.txt_usub.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txt_notb_GotFocus(sender As Object, e As EventArgs) Handles txt_notb.GotFocus
        If Me.txt_notb.Text = Me.txt_notb.Tag.ToString.ToUpper Then
            Me.txt_notb.Text = ""
            Me.txt_notb.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_notb_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_notb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btn_buscar_Click(sender, e)
        End If
    End Sub

    Private Sub txt_notb_LostFocus(sender As Object, e As EventArgs) Handles txt_notb.LostFocus
        If Me.txt_notb.Text = "" Then
            Me.txt_notb.Text = Me.txt_notb.Tag
            Me.txt_notb.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            Dim ln As New List(Of cct_notas)
            ln = cct_nDao.GetNotaByAge(LTrim(RTrim(Split(Me.lbl_age.Text, "-")(0))), _
                                       IIf(Me.dtp_fecb.Checked, Me.dtp_fecb.Text, ""), _
                                       IIf(Me.txt_usub.Text <> Me.txt_usub.Tag, Me.txt_usub.Text, ""), _
                                       IIf(Me.txt_notb.Text <> Me.txt_notb.Tag, Me.txt_notb.Text, ""), _
                                       IIf(Me.dtp_fec_a.Checked, Me.dtp_fec_a.Text, ""))
            If Not ln Is Nothing Then
                If ln.Count > 0 Then
                    carga_dgv_notas(ln)
                Else
                    l_bind.Clear()
                End If
            Else
                l_bind.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error en la consulta de notas " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub

    Private Sub dgv_notas_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_notas.SelectionChanged
        If Me.l_bind.Count > 0 Then
            Me.txt_not.Text = Me.dgv_notas.CurrentRow.Cells("NOTA").Value
        Else
            Me.txt_not.Text = ""
        End If
    End Sub
End Class