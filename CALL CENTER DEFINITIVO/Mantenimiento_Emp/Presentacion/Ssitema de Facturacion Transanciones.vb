Public Class Ssitema_de_Facturacion_Transanciones
    Dim _Origen As New List(Of Ereporterecargatran)
    Sub New(_Dato As List(Of Ereporterecargatran))
        _Origen = _Dato
        InitializeComponent()
    End Sub

    Private Sub Ssitema_de_Facturacion_Transanciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Crystal_reporterecargatrans_Load(sender As Object, e As EventArgs) Handles Crystal_reporterecargatrans.Load
        Dim _Reporte As New ReporteRecargarTrans
        _Reporte.SetDataSource(_Origen)
        Crystal_reporterecargatrans.ReportSource = _Reporte
    End Sub
End Class