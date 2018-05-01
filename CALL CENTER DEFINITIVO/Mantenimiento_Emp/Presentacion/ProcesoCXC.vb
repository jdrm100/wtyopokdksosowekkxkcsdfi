Public Class ProcesoCXC

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        btn_Aceptar.Enabled = False
        BackgroundWorker1.RunWorkerAsync()



    End Sub

    Public Sub ActualizaVentasEnCurso()
        Dim _Buscar As New Ccc_AntiguedadGestor
        _Buscar.ActualizarVentasCursoCXC(dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date)

        'Dim _Mostrar As New CXC_GESTOR_VIWER(_Lista)
        '_Mostrar.Show()
    End Sub

    Public Sub AntiguedadCXC()
        Dim _Buscar As New Ccc_AntiguedadGestor
        Dim _Lista As List(Of Eantiguedadsaldogestor) = _Buscar.AntCXC(vcurso_chx.Checked, dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date)

        Dim _Mostrar As New antCXC_VIEWER(_Lista)
        _Mostrar.Show()
    End Sub

    Public Sub AntiguedadCXCGestor()
        Dim _Buscar As New Ccc_AntiguedadGestor

       
        Dim _Lista As List(Of Eantiguedadsaldogestor) = _Buscar.AntCXCGestor(vcurso_chx.Checked, dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date)

        Dim _Mostrar As New CXC_GESTOR_VIWER(_Lista)
        _Mostrar.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cxc_ges_rdb.Checked = True Then
            AntiguedadCXCGestor()
        End If
        If cxc_rdb.Checked = True Then
            AntiguedadCXC()
        End If

    End Sub

 
    Private Sub ProcesoCXC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cxc_ges_rdb.Checked = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ActualizaVentasEnCurso()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        btn_Aceptar.Enabled = True

        MsgBox("¡SE HA ACTUALIZADO CORRECTAMENTE!")
    End Sub
End Class