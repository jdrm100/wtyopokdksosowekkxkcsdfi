Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Public Class comp_carac_aux
    Dim factoria_cara As IDaoFactory
    Dim cct_rcara_Dao As I_cct_reg_cara_age
    Private Sub comp_carac_aux_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            factoria_cara = New NHibernateDaoFactory
            cct_rcara_Dao = factoria_cara.Getcct_reg_cara_ageDao
        Catch ex As Exception
            MsgBox("Error al cargar el formulario " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        'Nuevo registro
        Dim l_rca As New List(Of cct_reg_cara_age)
        l_rca = cct_rcara_Dao.SetRegCara(Me.lbl_age.Text, Me.lbl_id_comp.Text, Me.cmb_carac.SelectedValue, IIf(Me.txt_s1.Text = "", 0, Me.txt_s1.Text), 0, 1, 0)
        Me.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mod_red.SelectedIndexChanged

    End Sub
End Class