Public Class Sistema_de_Facturacion_Reporte_de_Numero_Jugados
    Dim _Origen As New List(Of EReporteLoteria)
    Sub New(_Datos As List(Of EReporteLoteria))
        _Origen = _Datos
        InitializeComponent()
    End Sub



    Private Sub Sistema_de_Facturacion_Reporte_de_Numero_Jugados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReporteotnumerojugado_Load(sender As Object, e As EventArgs) Handles CrystalReporteotnumerojugado.Load
        Dim _Reporte As New ReporteLotNumeJug
        _Reporte.SetDataSource(_Origen)
        CrystalReporteotnumerojugado.ReportSource = _Reporte
    End Sub
End Class