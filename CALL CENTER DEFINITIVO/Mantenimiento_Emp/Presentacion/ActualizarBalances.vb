Public Class ActualizarBalances
    Dim Count As Integer = 100
  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BackgroundWorker1.RunWorkerAsync()
        Button1.Enabled = False
        MSGLABEL.Text = "ACTUALIZANDO ESPERE UN MOMENTO..."

    End Sub
 
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim ActualizarBalances As New Ccc_ActualizarBalance
        ActualizarBalances.ActualizarBalanceAgentes()
 
        'For i = 0 To Count  
        '    System.Threading.Thread.Sleep(500)
        '    BackgroundWorker1.ReportProgress(CInt((i / Count) * 100))
        'Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
      
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Button1.Enabled = True
        MSGLABEL.Text = "¡SE HA ACTUALIZADO CORRECTAMENTE!"
        MsgBox("¡SE HA ACTUALIZADO CORRECTAMENTE!")
    End Sub

    Private Sub ActualizarBalances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MSGLABEL.Text = ""
       
    End Sub
 
End Class