Public Class Filtrar

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        If porRepresRbt.Checked = True Then
            Antiguedad("Todos", represent.SelectedValue)
        End If

        If porGestorRbt.Checked = True Then
            AntiguedadPorGestor()
        End If


        If PorRepresentanteRadio.Checked = True Then
            Antiguedad("unRepresentante", represent.SelectedValue)

        End If

        'If rdb_cxc.Checked = True Then
        ''    cxcAntiguedad()

        'End If


    End Sub

    'Public Sub cxcAntiguedad()
    '    Dim _Buscar As New Ccc_AntiguedadGestor
    '    Dim _Lista As List(Of Eantiguedadsaldogestor) = _Buscar.AntCXC(dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date)

    '    Dim _Mostrar As New CXC_GESTOR_VIWER(_Lista)
    '    _Mostrar.Show()
    'End Sub
    Public Sub Antiguedad(tipo As String, repre As String)
        Dim _Buscar As New Ccc_Antiguedad
        Dim _Lista As List(Of Eantiguedadsaldo) = _Buscar.AntiguedaddeSaldo(dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date, tipo, repre)

        Dim _Mostrar As New Reporte_de_Antiguedad(_Lista)
        _Mostrar.Show()

    End Sub

    Public Sub AntiguedadPorGestor()
        Dim _Buscar As New Ccc_AntiguedadGestor
        Dim _Lista As List(Of Eantiguedadsaldogestor) = _Buscar.AntiguedaddeSaldoGestor(dtp_FechaInicial.Value.Date, dtp_FechaFinal.Value.Date)

        Dim _Mostrar As New frm_antiguedadgestor(_Lista)
        _Mostrar.Show()

    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles porGestorRbt.CheckedChanged

    End Sub

    Private Sub Filtrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        porRepresRbt.Checked = True
        dtp_FechaInicial.Value = "19/06/2009"
        cargarRepresentantes()
    End Sub

    Private Sub cargarRepresentantes()
        Dim _buscar As New CccAntiguedadDetalladovb
        Dim lista As DataTable = _buscar.GetRepresentantes()
        represent.DataSource = lista
        represent.DisplayMember = "nombre"
        represent.ValueMember = "ruta"


        'For Each item As Erepresentante In _Lista
        '    representatanteCMB.Items.Add(item.ToString)
        '    MsgBox("hola")
        'Next

        'For indice As Integer = 0 To _Lista.Count - 1 Step 1

        '    representatanteCMB.Items.Add(_Lista(indice).ToString)
        'Next



    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub represent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles represent.SelectedIndexChanged

    End Sub
End Class