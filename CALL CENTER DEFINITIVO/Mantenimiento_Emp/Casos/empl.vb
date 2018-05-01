Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Public Class empl
    Dim factory_empl As IDaoFactory
    Dim emplDao As I_empl_Dao
    Public flag As Boolean = True
    Private Sub empl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            factory_empl = New NHibernateDaoFactory
            emplDao = factory_empl.Get_emplDao
        Catch ex As Exception
            MsgBox("Error al cargar el formulario." & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Registor de Empleados")
        End Try
    End Sub
    Private Sub txt_empl_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_empl.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txt_empl.Focused Then
                    carga_empl()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al traer total de Empleados: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Registor de Empleados")
        End Try
    End Sub
    Private Sub carga_empl()
        Try
            flag = False
            Dim li_empl As New List(Of Seguridad.empl)
            Dim tip As String = ""
            If Me.cmb_tipo.Text <> "" Then
                tip = IIf(Me.cmb_tipo.SelectedIndex <> 2, Me.cmb_tipo.Text.Substring(0, 2), "")
            End If

            If IsNumeric(txt_empl.Text) Then
                li_empl = emplDao.GetByempl(txt_empl.Text, "", tip, 1)
            Else
                li_empl = emplDao.GetByempl("", txt_empl.Text, tip, 1)
            End If

            If Not li_empl Is Nothing Then
                carga_dgv_e(li_empl)
                If li_empl.Count = 0 Then
                    limpia_campos()
                    MsgBox("No se encontro el empleado! " & Chr(13), MsgBoxStyle.Critical, "Registor de Empleados")
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al cargar agentes" & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Registor de Empleados")
        End Try
    End Sub
    Private Sub carga_dgv_e(ByVal lista As List(Of Seguridad.empl))
        Me.dgv_empl.DataSource = lista
        With Me.dgv_empl.Columns
            .Item("CORREO").Visible = False
            .Item("FLOTA").Visible = False
            .Item("ACTIVO").Visible = False
            .Item("RUTA").Visible = False
            .Item("usuario_update").Visible = False
            .Item("usuario_insert").Visible = False
        End With
        Me.lbl_total.Text = lista.Count
    End Sub
    Private Sub limpia_campos()
        Me.txt_flota.Text = ""
        Me.txt_correo.Text = ""
        Me.txt_ruta.Text = ""
    End Sub
    Private Sub dgv_empl_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_empl.DataSourceChanged
        flag = True
        dgv_empl_SelectionChanged(sender, e)
    End Sub
    Private Sub dgv_empl_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_empl.SelectionChanged
        Try
            If Me.dgv_empl.RowCount > 0 And flag = True Then
                If Not Me.dgv_empl.CurrentRow.Cells(0).Value Is Nothing Then
                    carga_datos_empl()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalle de Empleado: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Registor de Empleados")
        End Try
    End Sub
    Private Sub carga_datos_empl()
        Me.txt_flota.Text = Me.dgv_empl.CurrentRow.Cells("FLOTA").Value
        Me.txt_correo.Text = Me.dgv_empl.CurrentRow.Cells("CORREO").Value
        Me.txt_ruta.Text = Me.dgv_empl.CurrentRow.Cells("RUTA").Value
    End Sub
End Class