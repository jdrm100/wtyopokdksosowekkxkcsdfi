Public Class Retiro_Vista
    Dim _Origen As New List(Of EReporteRetiro)

    Sub New(_Datos As List(Of EReporteRetiro))
        _Origen = _Datos

        InitializeComponent()

    End Sub
    Private Sub Crystalretiro_Load(sender As Object, e As EventArgs) Handles Crystalretiro.Load
        Dim _Reporte As New Retirado
        _Reporte.SetDataSource(_Origen)
        Crystalretiro.ReportSource = _Reporte
    End Sub
End Class