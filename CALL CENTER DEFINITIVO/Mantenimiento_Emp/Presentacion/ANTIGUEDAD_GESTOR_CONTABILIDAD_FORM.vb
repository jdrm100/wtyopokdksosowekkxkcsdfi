Public Class ANTIGUEDAD_GESTOR_CONTABILIDAD_FORM

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        AntiguedadContabilidad()
    End Sub

    Private Sub AntiguedadContabilidad()
        Dim _Buscar As New Ccc_AntiguedadGestor
        Dim _Lista As List(Of Eantiguedadsaldogestor) = _Buscar.AntiguedaContabilidad(dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date)

        Dim _Mostrar As New ANTIGUEDAD_GESTOR_CONTABILIDAD_VIEWER(_Lista)
        _Mostrar.Show()
    End Sub

    Private Sub ANTIGUEDAD_GESTOR_CONTABILIDAD_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_FechaInicial.Value = "19/06/2009"
    End Sub
End Class