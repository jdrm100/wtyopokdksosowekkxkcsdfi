Public Class comisioness
    Private _buscar As New List(Of Ecomisiones)


    Sub New(datos As List(Of Ecomisiones))

        _buscar = datos
        InitializeComponent()

    End Sub
    Private Sub comisioness_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub ComisionesReprotControl_Load(sender As Object, e As EventArgs) Handles ComisionesReprotControl.Load
        Dim _reporte As New ReporteComisiones
        _reporte.SetDataSource(_buscar)
        ComisionesReprotControl.ReportSource = _reporte
    End Sub




    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class