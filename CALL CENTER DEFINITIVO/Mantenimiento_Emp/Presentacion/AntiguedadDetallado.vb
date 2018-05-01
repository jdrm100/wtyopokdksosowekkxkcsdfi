Public Class AntiguedadDetallado
    Private _buscar As New List(Of Eestadocuenta)


    Sub New(datos As List(Of Eestadocuenta))

        _buscar = datos
        InitializeComponent()

    End Sub
 

    Private Sub FVR_AntiguedadDetallado_Load(sender As Object, e As EventArgs) Handles FVR_AntiguedadDetallado.Load
        Dim _reporte As New ReporteAntDetallado
        _reporte.SetDataSource(_buscar)
        FVR_AntiguedadDetallado.ReportSource = _reporte
    End Sub

    Private Sub AntiguedadDetallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class