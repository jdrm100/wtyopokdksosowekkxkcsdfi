Public Class CXC_GESTOR_VIWER
    Private _buscar As New List(Of Eantiguedadsaldogestor)


    Sub New(datos As List(Of Eantiguedadsaldogestor))

        _buscar = datos
        InitializeComponent()

    End Sub
    Private Sub CXC_GESTOR_VIWER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CXC_GESTOR
    End Sub


    

    Private Sub GESTOR_VIEWER_CXC_Load(sender As Object, e As EventArgs) Handles GESTOR_VIEWER_CXC.Load
        Dim _reporte As New CXC_GESTOR
        _reporte.SetDataSource(_buscar)
        GESTOR_VIEWER_CXC.ReportSource = _reporte
    End Sub
End Class