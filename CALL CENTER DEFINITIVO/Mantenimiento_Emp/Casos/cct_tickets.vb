Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Public Class cct_tickets
    Dim fact_h_tks As IDaoFactory
    Dim hist_tksDao As I_cct_h_tks

    Private Sub cct_tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fact_h_tks = New NHibernateDaoFactory
            hist_tksDao = fact_h_tks.Getcct_h_tksDao
            Dim age As String

            If lbl_reg_age.Text <> "" Then
                Dim arr_age As Array
                arr_age = Me.lbl_reg_age.Text.Split("-")
                age = arr_age(0)

                Dim h_tks As New List(Of cct_h_tks)
                h_tks = hist_tksDao.GetByAge(age)

                If Not h_tks Is Nothing Then
                    If h_tks.Count > 0 Then
                        dgv_tks_a.DataSource = h_tks
                        lbl_total.Text = h_tks.Count
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al cargar el formulario " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub dgv_tks_a_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tks_a.CellContentClick

    End Sub

    Private Sub dgv_tks_a_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_tks_a.SelectionChanged
        Try
            If Me.dgv_tks_a.RowCount > 0 Then
                If Not Me.dgv_tks_a.CurrentRow.Cells(0).Value Is Nothing Then
                    Me.txt_cont_cie.Text = Me.dgv_tks_a.CurrentRow.Cells("CONTACTO_CIERRE").Value
                    Me.txt_inc_cie.Text = Me.dgv_tks_a.CurrentRow.Cells("INCIDENCIA_CIERRE").Value
                    Me.txt_inc_verif.Text = Me.dgv_tks_a.CurrentRow.Cells("VERIFICACION").Value
                    Me.txt_fec_cie.Text = Me.dgv_tks_a.CurrentRow.Cells("FECHA_CIERRE").Value & " " & Me.dgv_tks_a.CurrentRow.Cells("HORA_CIERRE").Value
                    Me.txt_fec_verif.Text = Me.dgv_tks_a.CurrentRow.Cells("FECHA_VERIFICACION").Value & " " & Me.dgv_tks_a.CurrentRow.Cells("HORA_VERIFICACION").Value
                    Me.txt_ges_cie.Text = Me.dgv_tks_a.CurrentRow.Cells("GESTOR_CIERRE").Value
                    Me.txt_ges_verif.Text = Me.dgv_tks_a.CurrentRow.Cells("VERIFICADO_POR").Value
                    Me.txt_nota_cie.Text = Me.dgv_tks_a.CurrentRow.Cells("NOTA_CIERRE").Value
                    Me.txt_nota_verif.Text = Me.dgv_tks_a.CurrentRow.Cells("NOTA_VERIFICACION").Value
                    Me.txt_nota_abierto.Text = Me.dgv_tks_a.CurrentRow.Cells("NOTA").Value
                    lbl_dias_abie.Text = Me.dgv_tks_a.CurrentRow.Cells("DIAS_ABIERTO").Value & " dias abierto"
                    lbl_dias_verif.Text = Me.dgv_tks_a.CurrentRow.Cells("DIAS_POR_VERIFICACION").Value & " dias pendiente de verificacion"
                    lbl_comp.Text = Me.dgv_tks_a.CurrentRow.Cells("COMPARACION_INCIDENCIA").Value
                    lbl_dias_abie.Visible = IIf(Me.dgv_tks_a.CurrentRow.Cells("DIAS_ABIERTO").Value <> "0", True, False)
                    lbl_dias_verif.Visible = IIf(Me.dgv_tks_a.CurrentRow.Cells("DIAS_POR_VERIFICACION").Value <> "0", True, False)
                    lbl_comp.Visible = IIf(Me.dgv_tks_a.CurrentRow.Cells("COMPARACION_INCIDENCIA").Value <> "0", True, False)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al cargar datos de DataGrid" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class