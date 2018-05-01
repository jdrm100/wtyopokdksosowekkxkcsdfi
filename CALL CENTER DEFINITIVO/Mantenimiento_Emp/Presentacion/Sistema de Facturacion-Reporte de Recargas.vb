Public Class frm_Sistema_de_Facturacion_Reporte_de_Recargas
    Dim _Origen As New List(Of Erecargadetalla)

    Sub New(_Datos As List(Of Erecargadetalla))
        _Origen = _Datos
        InitializeComponent()
    End Sub





    

    Private Sub Crystal_reporterecargadetallada_Load(sender As Object, e As EventArgs) Handles Crystal_reporterecargadetallada.Load
        Dim _Reporte As New RecargaDetallada
        _Reporte.SetDataSource(_Origen)
        Crystal_reporterecargadetallada.ReportSource = _Reporte

    End Sub

    Private Sub frm_Sistema_de_Facturacion_Reporte_de_Recargas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class