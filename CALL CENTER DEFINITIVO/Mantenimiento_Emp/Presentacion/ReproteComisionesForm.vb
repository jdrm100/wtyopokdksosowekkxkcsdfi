 
Public Class ReproteComisionesForm

 
    Private Sub ReproteComisionesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLoterias()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

       
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'btn_Aceptar.Enabled = True
    End Sub

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click

        Dim _buscar As New Ccc_Comiciones
        Dim _lista As New List(Of Ecomisiones)

        If AgenteTBOX.Text <> "" Then

            If TodasLoterias.Checked = True Then
                _lista = _buscar.GenerarComiciones("todas", allLoterias.SelectedValue, dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date, Convert.ToInt64(AgenteTBOX.Text))
            End If


            If PorLoteria.Checked = True Then
                _lista = _buscar.GenerarComiciones("una", allLoterias.SelectedValue, dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date, Convert.ToInt64(AgenteTBOX.Text))
            End If

            If porLoteriaAll.Checked = True Then
                _lista = _buscar.GenerarComiciones("unaGlobal", allLoterias.SelectedValue, dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date, Convert.ToInt64(AgenteTBOX.Text))
            End If


            btn_Aceptar.Enabled = False

            'BackgroundWorker1.RunWorkerAsync()

             Dim _Mostrar As New comisioness(_lista)

            _Mostrar.Show()
            btn_Aceptar.Enabled = True
        Else
            MsgBox("Debe llenar el campo Agente")
        End If

    End Sub
    Private Sub cargarLoterias()
        Dim _buscar As New Ccc_Comiciones
        Dim lista As DataTable = _buscar.GetLoterias()
        allLoterias.DataSource = lista
        allLoterias.DisplayMember = "descripcion"
        allLoterias.ValueMember = "cod"


        'For Each item As Erepresentante In _Lista
        '    representatanteCMB.Items.Add(item.ToString)
        '    MsgBox("hola")
        'Next

        'For indice As Integer = 0 To _Lista.Count - 1 Step 1

        '    representatanteCMB.Items.Add(_Lista(indice).ToString)
        'Next



    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub porRepresRbt_CheckedChanged(sender As Object, e As EventArgs) Handles TodasLoterias.CheckedChanged

    End Sub

    Private Sub allLoterias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles allLoterias.SelectedIndexChanged

    End Sub
End Class





 