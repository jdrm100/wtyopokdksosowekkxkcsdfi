Public Class Reporte_Bloqueo_vista
    Dim _Origen As New List(Of Ebloqueado)
    Sub New(_Dato As List(Of Ebloqueado))
        _Origen = _Dato
        InitializeComponent()
    End Sub

    Private Sub Reporte_Bloqueo_vista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalBloqueo.Load
        Dim _Reporte As New Bloqueo
        _Reporte.SetDataSource(_Origen)
        CrystalBloqueo.ReportSource = _Reporte
    End Sub
End Class