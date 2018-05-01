Public Class antCXC_VIEWER
    Private _buscar As New List(Of Eantiguedadsaldogestor)
    


    Sub New(datos As List(Of Eantiguedadsaldogestor))

        _buscar = datos
        InitializeComponent()

    End Sub




  
    Private Sub AntCXC_v_Load(sender As Object, e As EventArgs) Handles AntCXC_v.Load
        Dim _reporte As New AntCXC
        _reporte.SetDataSource(_buscar)
        AntCXC_v.ReportSource = _reporte
    End Sub
End Class