Public Class ANTIGUEDAD_GESTOR_CONTABILIDAD_VIEWER
    Private _buscar As New List(Of Eantiguedadsaldogestor)

    Sub New(datos As List(Of Eantiguedadsaldogestor))

        _buscar = datos
        InitializeComponent()

    End Sub

    Private Sub ANT_GES_CONT_VW_Load(sender As Object, e As EventArgs) Handles ANT_GES_CONT_VW.Load
        Dim _reporte As New ANTIGUEDAD_GESTOR_CONTABILIDAD
        _reporte.SetDataSource(_buscar)
        ANT_GES_CONT_VW.ReportSource = _reporte
    End Sub
End Class