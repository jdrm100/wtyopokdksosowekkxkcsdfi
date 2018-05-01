Public Class Reporte_de_Antiguedad
    Private _buscar As New List(Of Eantiguedadsaldo)


    Sub New(datos As List(Of Eantiguedadsaldo))

        _buscar = datos
        InitializeComponent()

    End Sub
     

    Private Sub Reporte_de_Antiguedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub reporV_Antiguedad_Load(sender As Object, e As EventArgs) Handles reporV_Antiguedad.Load
        Dim _reporte As New CrystalReport1
        _reporte.SetDataSource(_buscar)
        reporV_Antiguedad.ReportSource = _reporte

    End Sub


End Class