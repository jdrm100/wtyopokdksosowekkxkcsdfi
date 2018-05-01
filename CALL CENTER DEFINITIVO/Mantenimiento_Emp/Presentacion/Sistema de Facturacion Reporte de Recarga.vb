Public Class frmSistema_de_Facturacion_Reporte_de_Recarga
    Dim _Buscar As New List(Of Ereporterecargaresumido)

    Sub New(_datos As List(Of Ereporterecargaresumido))
        _Buscar = _datos
        InitializeComponent()
    End Sub
    Private Sub Sistema_de_Facturacion_Reporte_de_Recarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles Crystal_reporterecargaresumido.Load
        Dim _Reporte As New ReporteRecargarResumidos
        _Reporte.SetDataSource(_Buscar)
        Crystal_reporterecargaresumido.ReportSource = _Reporte


    End Sub
End Class