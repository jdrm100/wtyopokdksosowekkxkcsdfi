Public Class frm_antiguedadgestor
 


    Private _buscar As New List(Of Eantiguedadsaldogestor)


    Sub New(datos As List(Of Eantiguedadsaldogestor))

        _buscar = datos
        InitializeComponent()

    End Sub


    Private Sub Reporte_de_Antiguedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub crl_antiguedadgestor_Load(sender As Object, e As EventArgs) Handles crl_antiguedadgestor.Load
        Dim _reporte As New ReporteAntiguedadGestor
        _reporte.SetDataSource(_buscar)
        crl_antiguedadgestor.ReportSource = _reporte

    End Sub
    Private Sub frm_antiguedadgestor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class