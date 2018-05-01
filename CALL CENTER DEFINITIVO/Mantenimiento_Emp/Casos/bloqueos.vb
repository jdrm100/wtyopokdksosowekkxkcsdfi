Imports System
Imports System.IO
Imports System.Text
Imports Data
Imports Core.DataInterfaces
Imports Core.Domain
Imports Core.Domain.Seguridad
Imports System.Windows.Forms
Imports Microsoft.Office.Interop

Public Class bloqueos
    Dim factoria As IDaoFactory
    Dim bloquearDao As IBloquearDao
    Dim gestoresDao As IGestoresDao

    Dim excep1 As String = "0"
    Dim excep2 As String = "0"
    Dim excep3 As String = "0"
    Dim excep4 As String = "0"
    Dim excep5 As String = ""
    Dim excep6 As String = "0"
    Dim l_bind As New BindingSource
    Dim l_bind_e As New BindingSource
    Public list_ges As String
    Dim list_cons_a As New List(Of Integer)
    Dim list_cons_a_e As New List(Of Integer)
    'Dim list_manual As New List(Of bloquear)
    Private Sub bloqueos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'NHibernateSessionManager.Instancia.BeginTransaction()
            factoria = New NHibernateDaoFactory
            bloquearDao = factoria.GetBloquearDao
            gestoresDao = factoria.GetGestoresDao

            Dim a_bloq As New List(Of bloquear)
            a_bloq = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)

            If IsNothing(a_bloq) Then
                MsgBox("Agentes no cargados! " & Chr(13), MsgBoxStyle.Critical, "Call Center")
            Else
                'CARGA DE CONDICIONES
                '*********************************************************

                '*********************************************************

                'CARGA DE EXCEPCIONES
                '*********************************************************

                '*********************************************************

                'CARGA DE AGENTES
                '*********************************************************
                carga_dgv_agentes(a_bloq)
                '*********************************************************
            End If

        Catch ex As Exception
            MsgBox("Error al cargar el formulario de bloqueo. " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub

    Private Sub carga_dgv_agentes(ByVal list_agentes As List(Of bloquear))
        l_bind.DataSource = list_agentes
        Me.dgv_agentes.DataSource = l_bind

        With Me.dgv_agentes.Columns
            '.Item("ID").HeaderText = "RETAILER"
            '.Item("ID").DataPropertyName = "ID"
            '.Item("ID").Name = "ID"
            '.Item("ID").Width = 70
            '.Item("ID").DisplayIndex = 0

            .Item("usuario_update").Visible = False
            .Item("usuario_insert").Visible = False
            .Item("ejecutivo").Visible = False
            .Item("gestor").Visible = False
            .Item("excep").Visible = False
        End With
        Me.lbl_sele.Text = list_agentes.Count
        Dim i As Integer
        Dim t_bal As Decimal = 0
        Dim t_bal_curso As Decimal = 0
        For i = 1 To list_agentes.Count - 1
            t_bal = t_bal + list_agentes.Item(i).BAL
            t_bal_curso = t_bal_curso + list_agentes.Item(i).BAL_CURSO
        Next

        Me.lbl_total_bal.Text = t_bal.ToString("C")
        Me.lbl_total_bal_curso.Text = t_bal_curso.ToString("C")

    End Sub

    Private Sub carga_dgv_agentes_e(ByVal list_agentes As List(Of bloquear))
        l_bind_e.DataSource = list_agentes
        Me.dgv_agentes_e.DataSource = l_bind_e

        With Me.dgv_agentes_e.Columns
            .Item("ID_E").HeaderText = "RETAILER"
            .Item("ID_E").DataPropertyName = "ID"
            .Item("ID_E").Name = "ID_E"
            .Item("ID_E").Width = 100
            .Item("ID_E").DisplayIndex = 0

            .Item("NOMBRE_E").HeaderText = "NOMBRE"
            .Item("NOMBRE_E").DataPropertyName = "nombre"
            .Item("NOMBRE_E").Name = "NOMBRE_E"
            .Item("NOMBRE_E").Width = 265
            .Item("NOMBRE_E").DisplayIndex = 1

            .Item("usuario_update").Visible = False
            .Item("usuario_insert").Visible = False
            .Item("ejecutivo").Visible = False
            .Item("clasif").Visible = False
            .Item("bal").Visible = False
            .Item("bal_curso").Visible = False
            .Item("factura").Visible = False
            .Item("gestor").Visible = False
            .Item("excep").Visible = False
        End With
        Me.lbl_exep.Text = list_agentes.Count


    End Sub

    Private Sub carga_dgv_gestores(ByVal list_gestores As List(Of gestores))
        dgv_gestores.DataSource = list_gestores
        With dgv_gestores.Columns
            .Item("USUARIO_UPDATE").Visible = False
            .Item("USUARIO_INSERT").Visible = False
            .Item("telges").Visible = False
            .Item("ID").Visible = False
        End With
        list_ges = ""
        For Each row As DataGridViewRow In dgv_gestores.Rows
            If LTrim(RTrim(list_ges)) = "" Then
                list_ges = dgv_gestores.Rows(row.Index).Cells("ID").Value
            Else
                list_ges = list_ges & "," & dgv_gestores.Rows(row.Index).Cells("ID").Value
            End If
        Next
        excep4 = list_ges
        Dim a_bloq_ges As New List(Of bloquear)
        Dim a_bloq_execp As New List(Of bloquear)
        a_bloq_ges = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
        carga_dgv_agentes(a_bloq_ges)

        a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
        If Not a_bloq_execp Is Nothing Then
            carga_dgv_agentes_e(a_bloq_execp)
        Else
            l_bind_e.Clear()
            'dgv_agentes_e.DataSource = ""
            lbl_exep.Text = "0"
        End If
    End Sub

    Private Sub txt_busca_a_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_busca_a.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txt_busca_a.Focused Then
                    Call btn_busca_a_Click(sender, e)

                End If
            End If
            If dgv_agentes.RowCount > 0 Then
                If e.KeyCode = Keys.Down Then
                    If Me.txt_busca_a.Focused Then
                        If dgv_agentes.Rows.Count > 0 Then
                            If dgv_agentes.SelectedRows(0).Index + 1 < dgv_agentes.Rows.Count Then
                                dgv_agentes.Rows(dgv_agentes.SelectedRows(0).Index + 1).Cells(0).Selected = True
                            End If
                        End If
                    End If
                End If
                If e.KeyCode = Keys.Up Then
                    If Me.txt_busca_a.Focused Then
                        If dgv_agentes.Rows.Count > 0 Then
                            If dgv_agentes.SelectedRows(0).Index > 0 Then
                                dgv_agentes.Rows(dgv_agentes.SelectedRows(0).Index - 1).Cells(0).Selected = True
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al buscar agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub txt_busca_a_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_a.TextChanged
        ' Dim match As DataGridViewCell() = (From row As DataGridViewRow In Me.dgv_agentes.Rows From cell As DataGridViewCell In row.Cells Select cell Where CStr(cell.FormattedValue).Contains(Me.txt_busca_a.Text)).ToArray()
    End Sub

    Private Sub btn_busca_a_Click(sender As Object, e As EventArgs) Handles btn_busca_a.Click
        list_cons_a.Clear()
        If LTrim(RTrim(Me.txt_busca_a.Text)) <> "" Then
            Try
                For Each row As DataGridViewRow In dgv_agentes.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.ColumnIndex = 8 Or cell.ColumnIndex = 0 Then
                            If CStr(cell.Value).Contains(txt_busca_a.Text) Then
                                list_cons_a.Add(row.Index)
                            End If
                        End If
                    Next
                Next
                If list_cons_a.Count > 0 Then
                    lbl_n_cons.Text = "1"
                    l_bind.Position() = list_cons_a(0)
                Else
                    lbl_n_cons.Text = "0"
                    MsgBox("Agente no encontrado en la lista", MsgBoxStyle.Information, "Call Center")
                End If
                lbl_t_cons.Text = list_cons_a.Count
            Catch ex As Exception
                MsgBox("Error al buscar agente: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
            End Try
        End If
    End Sub

    Private Sub txt_bal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_bal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call txt_bal_LostFocus(sender, e)
        End If
    End Sub
    Private Sub txt_curso_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_curso.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call txt_curso_LostFocus(sender, e)
        End If
    End Sub
    Private Sub txt_bal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bal.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then 'Allows only numbers
            e.KeyChar = e.KeyChar 'Allows only numbers
        ElseIf Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar 'Allows "Backspace" to be used
        ElseIf e.KeyChar = " "c Then
            e.KeyChar = " "c 'Allows "Spacebar" to be used
        ElseIf e.KeyChar = ","c Then
            e.KeyChar = ","c
        ElseIf e.KeyChar = "." Then
            If txt_bal.Text.IndexOf(".") > -1 Then 'Allows " . " and prevents more than 1 " . "
                e.Handled = True
                Beep()
            End If
        Else
            e.Handled = True  'Disallows all other characters from being used on txtNights.Text
            Beep()
        End If
    End Sub
    Private Sub txt_curso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_curso.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then 'Allows only numbers
            e.KeyChar = e.KeyChar 'Allows only numbers
        ElseIf Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar 'Allows "Backspace" to be used
        ElseIf e.KeyChar = " "c Then
            e.KeyChar = " "c 'Allows "Spacebar" to be used
        ElseIf e.KeyChar = ","c Then
            e.KeyChar = ","c
        ElseIf e.KeyChar = "." Then
            If txt_curso.Text.IndexOf(".") > -1 Then 'Allows " . " and prevents more than 1 " . "
                e.Handled = True
                Beep()
            End If
        Else
            e.Handled = True  'Disallows all other characters from being used on txtNights.Text
            Beep()
        End If
    End Sub
    Private Sub txt_bal_LostFocus(sender As Object, e As EventArgs) Handles txt_bal.LostFocus
        Dim i As Double = Me.txt_bal.Text
        If i > 0.0 Then
            chb_bal.Checked = True
            Call chb_bal_CheckedChanged(sender, e)
        Else
            chb_bal.Checked = False
        End If
    End Sub
    Private Sub txt_curso_LostFocus(sender As Object, e As EventArgs) Handles txt_curso.LostFocus
        Dim i As Double = Me.txt_curso.Text
        If i > 0.0 Then
            chb_curso.Checked = True
            Call chb_curso_CheckedChanged(sender, e)
        Else
            chb_curso.Checked = False
        End If
    End Sub
    Private Sub txt_bal_TextChanged(sender As Object, e As EventArgs) Handles txt_bal.TextChanged

        If IsNumeric(txt_bal.Text) Then
            Dim temp As Double = txt_bal.Text
            txt_bal.Text = Format(temp, "N")
            txt_bal.SelectionStart = txt_bal.TextLength - 3
        End If

    End Sub
    Private Sub txt_curso_TextChanged(sender As Object, e As EventArgs) Handles txt_curso.TextChanged
        If IsNumeric(txt_curso.Text) Then
            Dim temp As Double = txt_curso.Text
            txt_curso.Text = Format(temp, "N")
            txt_curso.SelectionStart = txt_curso.TextLength - 3
        End If
    End Sub
    Private Sub chb_bal_CheckedChanged(sender As Object, e As EventArgs) Handles chb_bal.CheckedChanged
        Dim a_bloq_bal As New List(Of bloquear)
        Dim a_bloq_execp As New List(Of bloquear)
        If chb_bal.Checked = False Then
            txt_bal.Text = 0.0
            excep1 = "0"
            a_bloq_bal = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            carga_dgv_agentes(a_bloq_bal)

            a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            If Not a_bloq_execp Is Nothing Then
                carga_dgv_agentes_e(a_bloq_execp)
            Else
                l_bind_e.Clear()
                'dgv_agentes_e.DataSource = ""
                lbl_exep.Text = "0"
            End If
        Else
            Dim i As Double = txt_bal.Text
            If i = 0.0 Then
                txt_bal.Focus()
            Else
                excep1 = CType(txt_bal.Text, Integer)
                a_bloq_bal = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
                carga_dgv_agentes(a_bloq_bal)

                a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
                If Not a_bloq_execp Is Nothing Then
                    carga_dgv_agentes_e(a_bloq_execp)
                Else
                    l_bind_e.Clear()
                    'dgv_agentes_e.DataSource = ""
                    lbl_exep.Text = "0"
                End If
            End If
        End If
        limpia_consulta()

    End Sub
    Private Sub chb_curso_CheckedChanged(sender As Object, e As EventArgs) Handles chb_curso.CheckedChanged
        Dim a_bloq_curso As New List(Of bloquear)
        Dim a_bloq_execp As New List(Of bloquear)
        If chb_curso.Checked = False Then
            txt_curso.Text = 0.0
            excep2 = "0"
            a_bloq_curso = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            carga_dgv_agentes(a_bloq_curso)

            a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            If Not a_bloq_execp Is Nothing Then
                carga_dgv_agentes_e(a_bloq_execp)
            Else
                l_bind_e.Clear()
                'dgv_agentes_e.DataSource = ""
                lbl_exep.Text = "0"
            End If
        Else
            Dim i As Double = txt_curso.Text
            'If i = 0.0 Then
            '    txt_curso.Focus()
            'Else
            'excep2 = CType(txt_curso.Text, Integer)
            If i = 0.0 Then
                excep2 = "-1"
            End If

            a_bloq_curso = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            carga_dgv_agentes(a_bloq_curso)

            a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            If Not a_bloq_execp Is Nothing Then
                carga_dgv_agentes_e(a_bloq_execp)
            Else
                l_bind_e.Clear()
                'dgv_agentes_e.DataSource = ""
                lbl_exep.Text = "0"
            End If
            'End If
        End If
        limpia_consulta()

    End Sub
    Private Sub chk_aprobados_CheckedChanged(sender As Object, e As EventArgs) Handles chk_aprobados.CheckedChanged
        Dim a_bloq_curso As New List(Of bloquear)
        Dim a_bloq_execp As New List(Of bloquear)

        If Me.chk_aprobados.Checked = True Then
            excep3 = "1"
        Else
            excep3 = "0"
        End If
        a_bloq_curso = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
        carga_dgv_agentes(a_bloq_curso)

        a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
        If Not a_bloq_execp Is Nothing Then
            carga_dgv_agentes_e(a_bloq_execp)
        Else
            l_bind_e.Clear()
            'dgv_agentes_e.DataSource = ""
            lbl_exep.Text = "0"
        End If
        limpia_consulta()

    End Sub
    Private Sub btn_agregar_g_Click(sender As Object, e As EventArgs) Handles btn_agregar_g.Click
        'Me.Opacity = 0.8
        Try

            Dim ges_list As New List(Of gestores)
            ges_list = gestoresDao.GetByCodges("")
            If ges_list.Count = 0 Then
                MsgBox("Gestores no cargados! " & Chr(13), MsgBoxStyle.Critical, "Call Center")
            Else
                Dim childform As New ges_aux

                With childform
                    .dgv_ges.DataSource = ges_list
                End With

                With childform.dgv_ges.Columns
                    .Item("USUARIO_UPDATE").Visible = False
                    .Item("USUARIO_INSERT").Visible = False
                    .Item("telges").Visible = False
                    .Item("ID").Visible = False
                End With
                list_ges = ""
                childform.ShowDialog()
                If LTrim(RTrim(list_ges)) <> "" Then

                    For Each row As DataGridViewRow In dgv_gestores.Rows
                        If LTrim(RTrim(list_ges)) <> "" Then
                            list_ges = list_ges & ",'" & dgv_gestores.Rows(row.Index).Cells("ID").Value & "'"
                        End If
                    Next
                    ges_list = gestoresDao.GetByCodges(list_ges)
                    If ges_list.Count > 0 Then
                        carga_dgv_gestores(ges_list)
                    End If
                End If
            End If
            limpia_consulta()

        Catch ex As Exception
            MsgBox("Error al cargar el listado de gestores " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
        'Me.Opacity = 1
    End Sub


    Private Sub btn_quitar_g_Click(sender As Object, e As EventArgs) Handles btn_quitar_g.Click
        Try
            list_ges = ""
            For Each row As DataGridViewRow In dgv_gestores.Rows
                If dgv_gestores.Rows(row.Index).Cells(0).Selected = False Then
                    If LTrim(RTrim(list_ges)) = "" Then
                        list_ges = "'" & dgv_gestores.Rows(row.Index).Cells("ID").Value & "'"
                    Else
                        list_ges = list_ges & ",'" & dgv_gestores.Rows(row.Index).Cells("ID").Value & "'"
                    End If
                End If
            Next

            Dim ges_list As New List(Of gestores)
            If list_ges = "" Then
                dgv_gestores.DataSource = ges_list
                excep4 = "0"
                Dim a_bloq_ges As New List(Of bloquear)
                Dim a_bloq_execp As New List(Of bloquear)
                a_bloq_ges = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
                carga_dgv_agentes(a_bloq_ges)

                a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
                If Not a_bloq_execp Is Nothing Then
                    carga_dgv_agentes_e(a_bloq_execp)
                Else
                    l_bind_e.Clear()
                    'dgv_agentes_e.DataSource = ""
                    lbl_exep.Text = "0"
                End If

            Else
                ges_list = gestoresDao.GetByCodges(list_ges)
                If ges_list.Count > 0 Then
                    carga_dgv_gestores(ges_list)
                End If
            End If
            limpia_consulta()

        Catch ex As Exception
            MsgBox("Error al quitar el gestor del listado " & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try


    End Sub


    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click
        Dim xlApp As New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        xlWorkBook = xlApp.Workbooks.Add(misValue)

        Try
            Dim i As Integer
            Dim j As Integer

            xlWorkSheet = xlWorkBook.Sheets("Hoja1")

            For i = 0 To dgv_agentes.RowCount - 2
                For j = 0 To dgv_agentes.ColumnCount - 5

                    If j = 0 Then
                        xlWorkSheet.Cells(1, j + 1) = "RETAILER"
                        xlWorkSheet.Cells(i + 2, j + 1) = dgv_agentes("ID", i).Value.ToString()
                        xlWorkSheet.Cells(1, j + 2) = dgv_agentes.Columns(j).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 2) = dgv_agentes(j, i).Value.ToString()
                    Else
                        xlWorkSheet.Cells(1, j + 2) = dgv_agentes.Columns(j).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 2) = dgv_agentes(j, i).Value.ToString()
                    End If
                    
                Next
            Next

            xlWorkSheet.SaveAs("C:\compartido\vbexcel.xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("Archivo generado en C:\compartido\vbexcel.xlsx")

        Catch ex As Exception
            MsgBox("Error al cargar excel " & Chr(13), MsgBoxStyle.Critical, "Call Center")
            xlApp.Quit()
        End Try

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

    Private Sub btn_bloq_Click(sender As Object, e As EventArgs) Handles btn_bloq.Click
        Try
            ' Creamos o sobreescribimos el archivo
            Dim path As String = "c:\compartido\MiArchivo.txt"
            Dim fs As FileStream = File.Create(path)

            ' Agregamos los agentes.
            Dim st As String = ""
            Dim i As Integer
            For i = 0 To dgv_agentes.RowCount - 2
                If i = 0 Then
                    st = dgv_agentes(5, i).Value.ToString().Substring(0, 6)
                Else
                    st = st & vbCrLf & dgv_agentes(5, i).Value.ToString().Substring(0, 6)
                End If
            Next
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(st)
            fs.Write(info, 0, info.Length)
            fs.Close()
            MsgBox("Archivo generado en " & path)
        Catch ex As Exception
            MsgBox("Error al cargar archivo de bloqueo" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        Try
            If excep5 = "" Then
                excep5 = Me.dgv_agentes.CurrentRow.Cells("ID").Value
            Else
                excep5 = excep5 & "," & Me.dgv_agentes.CurrentRow.Cells("ID").Value
            End If

            'Quitando desde el datagrid
            'If Me.dgv_agentes.Rows.Count > 0 Then
            '    Dim bal, bal_cur As Decimal
            '    bal = Me.dgv_agentes.CurrentRow.Cells("BAL").Value
            '    bal_cur = Me.dgv_agentes.CurrentRow.Cells("BAL_CURSO").Value
            '    l_bind.RemoveAt(l_bind.Position)
            '    l_bind.ResetCurrentItem()
            '    lbl_sele.Text = lbl_sele.Text - 1
            '    lbl_total_bal.Text = (lbl_total_bal.Text - bal).ToString("C")
            '    lbl_total_bal_curso.Text = (lbl_total_bal_curso.Text - bal_cur).ToString("C")
            '    'Me.dgv_agentes.AllowUserToDeleteRows = True
            '    'Me.dgv_agentes.Rows.RemoveAt(Me.dgv_agentes.CurrentRow.Index)
            'End If

            'Quitando y cargando desde el procedimiento
            Dim a_bloq_bal As New List(Of bloquear)
            Dim a_bloq_excep As New List(Of bloquear)
            a_bloq_bal = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            carga_dgv_agentes(a_bloq_bal)

            a_bloq_excep = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            If Not a_bloq_excep Is Nothing Then
                carga_dgv_agentes_e(a_bloq_excep)
            Else
                l_bind_e.Clear()
                lbl_exep.Text = "0"
            End If
        Catch ex As Exception
            MsgBox("Error quitar Agente del listado." & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try


    End Sub

    Private Sub chb_fac_CheckedChanged(sender As Object, e As EventArgs) Handles chb_fac.CheckedChanged
        Dim a_bloq_bal As New List(Of bloquear)
        Dim a_bloq_execp As New List(Of bloquear)
        If chb_fac.Checked = False Then
            txt_fac.Text = 0.0
            excep6 = "0"
            a_bloq_bal = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            carga_dgv_agentes(a_bloq_bal)

            a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            If Not a_bloq_execp Is Nothing Then
                carga_dgv_agentes_e(a_bloq_execp)
            Else
                l_bind_e.Clear()
                'dgv_agentes_e.DataSource = ""
                lbl_exep.Text = "0"
            End If
        Else
            Dim i As Double = txt_fac.Text
            If i = 0.0 Then
                txt_fac.Focus()
            Else
                excep6 = CType(txt_fac.Text, Integer)
                a_bloq_bal = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
                carga_dgv_agentes(a_bloq_bal)

                a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
                If Not a_bloq_execp Is Nothing Then
                    carga_dgv_agentes_e(a_bloq_execp)
                Else
                    l_bind_e.Clear()
                    'dgv_agentes_e.DataSource = ""
                    lbl_exep.Text = "0"
                End If
            End If
        End If
        limpia_consulta()

    End Sub

    Private Sub txt_fac_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fac.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call txt_fac_LostFocus(sender, e)
        End If
    End Sub

    Private Sub txt_fac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fac.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then 'Allows only numbers
            e.KeyChar = e.KeyChar 'Allows only numbers
        ElseIf Asc(e.KeyChar) = 8 Then
            e.KeyChar = e.KeyChar 'Allows "Backspace" to be used
        ElseIf e.KeyChar = " "c Then
            e.KeyChar = " "c 'Allows "Spacebar" to be used
        ElseIf e.KeyChar = ","c Then
            e.KeyChar = ","c
        ElseIf e.KeyChar = "." Then
            If txt_fac.Text.IndexOf(".") > -1 Then 'Allows " . " and prevents more than 1 " . "
                e.Handled = True
                Beep()
            End If
        Else
            e.Handled = True  'Disallows all other characters from being used on txtNights.Text
            Beep()
        End If
    End Sub

    Private Sub txt_fac_LostFocus(sender As Object, e As EventArgs) Handles txt_fac.LostFocus
        Dim i As Double = Me.txt_fac.Text
        If i > 0.0 Then
            chb_fac.Checked = True
            Call chb_fac_CheckedChanged(sender, e)
        Else
            chb_fac.Checked = False
        End If
    End Sub

    Private Sub txt_fac_TextChanged(sender As Object, e As EventArgs) Handles txt_fac.TextChanged
        If IsNumeric(txt_fac.Text) Then
            Dim temp As Double = txt_fac.Text
            txt_fac.Text = Format(temp, "N")
            txt_fac.SelectionStart = txt_fac.TextLength - 3
        End If
    End Sub

    Private Sub txt_busca_a_e_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_busca_a_e.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txt_busca_a_e.Focused Then
                    Call btn_busca_a_e_Click(sender, e)
                End If
            End If
            If dgv_agentes_e.RowCount > 0 Then
                If e.KeyCode = Keys.Down Then
                    If Me.txt_busca_a_e.Focused Then
                        If dgv_agentes_e.Rows.Count > 0 Then
                            If dgv_agentes_e.SelectedRows(0).Index + 1 < dgv_agentes_e.Rows.Count Then
                                dgv_agentes_e.Rows(dgv_agentes_e.SelectedRows(0).Index + 1).Cells(0).Selected = True
                            End If
                        End If
                    End If
                End If
                If e.KeyCode = Keys.Up Then
                    If Me.txt_busca_a_e.Focused Then
                        If dgv_agentes_e.Rows.Count > 0 Then
                            If dgv_agentes_e.SelectedRows(0).Index > 0 Then
                                dgv_agentes_e.Rows(dgv_agentes_e.SelectedRows(0).Index - 1).Cells(0).Selected = True
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al buscar agente en el listado de excepciones: " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub

    Private Sub txt_busca_a_e_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_a_e.TextChanged

    End Sub


    Private Sub btn_excel_e_Click(sender As Object, e As EventArgs) Handles btn_excel_e.Click
        Dim xlApp As New Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        xlWorkBook = xlApp.Workbooks.Add(misValue)

        Try
            Dim i As Integer
            Dim j As Integer

            xlWorkSheet = xlWorkBook.Sheets("Hoja1")

            For i = 0 To dgv_agentes_e.RowCount - 2
                For j = 0 To dgv_agentes_e.ColumnCount - 5

                    If j = 0 Then
                        xlWorkSheet.Cells(1, j + 1) = "RETAILER"
                        xlWorkSheet.Cells(i + 2, j + 1) = dgv_agentes_e("ID_E", i).Value.ToString()
                        xlWorkSheet.Cells(1, j + 2) = dgv_agentes_e.Columns(j).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 2) = dgv_agentes_e(j, i).Value.ToString()
                    Else
                        xlWorkSheet.Cells(1, j + 2) = dgv_agentes_e.Columns(j).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 2) = dgv_agentes_e(j, i).Value.ToString()
                    End If

                Next
            Next

            xlWorkSheet.SaveAs("C:\compartido\vbexcel_excepcion.xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("Archivo generado en C:\compartido\vbexcel_excepcion.xlsx")

        Catch ex As Exception
            MsgBox("Error al cargar excel " & Chr(13), MsgBoxStyle.Critical, "Call Center")
            xlApp.Quit()
        End Try
    End Sub

    Private Sub btn_quitar_e_Click(sender As Object, e As EventArgs) Handles btn_quitar_e.Click
        Try
            If excep5.Length > 8 Then
                excep5 = excep5.Replace(Me.dgv_agentes_e.CurrentRow.Cells("ID_E").Value & ",", "")
            Else
                excep5 = ""
            End If

            Dim a_bloq_bal As New List(Of bloquear)
            Dim a_bloq_excep As New List(Of bloquear)
            a_bloq_bal = bloquearDao.GetByExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            carga_dgv_agentes(a_bloq_bal)

            a_bloq_excep = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)
            If Not a_bloq_excep Is Nothing Then
                carga_dgv_agentes_e(a_bloq_excep)
            Else
                l_bind_e.Clear()
                lbl_exep.Text = "0"
            End If
        Catch ex As Exception
            MsgBox("Error quitar Agente del listado de excepciones." & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try
    End Sub


    Private Sub btn_aprobados_Click(sender As Object, e As EventArgs) Handles btn_aprobados.Click
        Try

            If solinobloaprob.Visible = True Then
                solinobloaprob.cmb_est.SelectedIndex = 2
                solinobloaprob.Focus()
            Else
                Dim openform As New solinobloaprob
                With openform
                    .cmb_est.SelectedIndex() = 1
                End With
                openform.MdiParent = Principal
                openform.Show()
            End If

        Catch ex As Exception
            MsgBox("Error en la carga de aprobacion de NO BLOQUEO" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub

    Private Sub dgv_agentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgv_agentes_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_agentes.CellContentClick

    End Sub

    Private Sub cmb_e_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_e.SelectedIndexChanged
        Try
            Dim a_bloq_execp As New List(Of bloquear)
            If cmb_e.SelectedIndex = 0 Then
                If chb_curso.Checked = True Then
                    Dim i As Double = txt_curso.Text
                    If i = 0.0 Then
                        excep2 = "-1"
                    End If
                End If

                a_bloq_execp = bloquearDao.GetExcep(excep1, excep2, excep3, excep4, excep5, excep6)

            ElseIf cmb_e.SelectedIndex = 1 Then
                a_bloq_execp = bloquearDao.GetExcep(excep1, "0", "0", "0", "", "0")
            ElseIf cmb_e.SelectedIndex = 2 Then
                a_bloq_execp = bloquearDao.GetExcep("0", excep2, "0", "0", "", "0")
            ElseIf cmb_e.SelectedIndex = 3 Then
                a_bloq_execp = bloquearDao.GetExcep("0", "0", "0", "0", "", excep6)
            ElseIf cmb_e.SelectedIndex = 4 Then
                a_bloq_execp = bloquearDao.GetExcep("0", "0", excep3, "0", "", "0")
            ElseIf cmb_e.SelectedIndex = 5 Then
                list_ges = ""
                For Each row As DataGridViewRow In dgv_gestores.Rows
                    If LTrim(RTrim(list_ges)) = "" Then
                        list_ges = dgv_gestores.Rows(row.Index).Cells("ID").Value
                    Else
                        list_ges = list_ges & "," & dgv_gestores.Rows(row.Index).Cells("ID").Value
                    End If
                Next
                excep4 = IIf(list_ges = "", "0", list_ges)
                a_bloq_execp = bloquearDao.GetExcep("0", "0", "0", excep4, "", "0")
            ElseIf cmb_e.SelectedIndex = 6 Then
                a_bloq_execp = bloquearDao.GetExcep("0", "0", "0", "0", excep5, "0")
            End If

            If Not a_bloq_execp Is Nothing Then
                carga_dgv_agentes_e(a_bloq_execp)
            Else
                l_bind_e.Clear()
                'dgv_agentes_e.DataSource = ""
                lbl_exep.Text = "0"
            End If
            limpia_consulta()

        Catch ex As Exception
            MsgBox("Error al filtrar datos de excepcion" & Chr(13), MsgBoxStyle.Critical, "Call Center")
        End Try

    End Sub
    Private Sub btn_sig_Click(sender As Object, e As EventArgs) Handles btn_sig.Click
        Try
            If list_cons_a.Count > 0 Then
                If lbl_n_cons.Text < list_cons_a.Count Then
                    lbl_n_cons.Text = (CInt(lbl_n_cons.Text) + 1).ToString
                    l_bind.Position() = list_cons_a(CInt(lbl_n_cons.Text) - 1)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_ant_Click(sender As Object, e As EventArgs) Handles btn_ant.Click
        Try
            If list_cons_a.Count > 0 Then
                If CInt(lbl_n_cons.Text) > 1 Then
                    lbl_n_cons.Text = (CInt(lbl_n_cons.Text) - 1).ToString
                    l_bind.Position() = list_cons_a(CInt(lbl_n_cons.Text) - 1)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_busca_a_e_Click(sender As Object, e As EventArgs) Handles btn_busca_a_e.Click
        list_cons_a_e.Clear()
        If LTrim(RTrim(Me.txt_busca_a_e.Text)) <> "" Then
            Try
                For Each row As DataGridViewRow In dgv_agentes_e.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.ColumnIndex = 8 Or cell.ColumnIndex = 0 Then
                            If CStr(cell.Value).Contains(txt_busca_a_e.Text) Then
                                list_cons_a_e.Add(row.Index)
                            End If
                        End If
                    Next
                Next
                If list_cons_a_e.Count > 0 Then
                    lbl_n_cons_e.Text = "1"
                    l_bind_e.Position() = list_cons_a_e(0)
                Else
                    lbl_n_cons.Text = "0"
                    MsgBox("Agente no encontrado en la lista", MsgBoxStyle.Information, "Call Center")
                End If
                lbl_t_cons_e.Text = list_cons_a_e.Count


            Catch ex As Exception
                MsgBox("Error al buscar agente en el listado de excepciones " & Chr(13) & ex.Message & "", MsgBoxStyle.Critical, "Call Center")
            End Try
        End If
    End Sub

    Private Sub btn_sig_e_Click(sender As Object, e As EventArgs) Handles btn_sig_e.Click
        Try
            If list_cons_a_e.Count > 0 Then
                If lbl_n_cons_e.Text < list_cons_a_e.Count Then
                    lbl_n_cons_e.Text = (CInt(lbl_n_cons_e.Text) + 1).ToString
                    l_bind_e.Position() = list_cons_a_e(CInt(lbl_n_cons_e.Text) - 1)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_ant_e_Click(sender As Object, e As EventArgs) Handles btn_ant_e.Click
        Try
            If list_cons_a_e.Count > 0 Then
                If CInt(lbl_n_cons_e.Text) > 1 Then
                    lbl_n_cons_e.Text = (CInt(lbl_n_cons_e.Text) - 1).ToString
                    l_bind_e.Position() = list_cons_a_e(CInt(lbl_n_cons_e.Text) - 1)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub limpia_consulta()
        list_cons_a.Clear()
        list_cons_a_e.Clear()
        lbl_n_cons.Text = "0"
        lbl_n_cons_e.Text = "0"
        lbl_t_cons.Text = "0"
        lbl_t_cons_e.Text = "0"
        txt_busca_a.Text = ""
        txt_busca_a_e.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.bloqueos_Load(sender, e)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

    End Sub
End Class