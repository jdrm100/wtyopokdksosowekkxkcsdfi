Imports System.Windows.Forms
Imports Data.NHibernateDaoFactory
Imports Core.Domain.Seguridad

Public Class Principal
    Dim codusu As String
    Dim nomusu As String
    Dim nivel As String

    'rrrrrrr'  
    Private Sub show_mnu_Reg01(ByVal sender As Object, ByVal e As EventArgs) Handles mnu_Reg01.Click
        Try
            abrir_formulario(Reg011)
        Catch ex As Exception
            ex = ex
        End Try
    End Sub

    Private Sub show_mnu_bloqueos(ByVal sender As Object, ByVal e As EventArgs) Handles mnu_bloqueos.Click
        Try
            abrir_formulario(bloqueos)
        Catch ex As Exception
            ex = ex
        End Try
    End Sub
    Private Sub mnu_sol_nobloqueo_Click(sender As Object, e As EventArgs) Handles mnu_sol_nobloqueo.Click
        Try
            abrir_formulario(solinobloaprob)
        Catch ex As Exception
            ex = ex
        End Try
    End Sub
    Private Sub show_mnu_cc_tecnico(sender As Object, e As EventArgs) Handles mnu_Form5.Click
        Try
            abrir_formulario(cc_tecnico)
        Catch ex As Exception
            ex = ex
        End Try
    End Sub
    Private Sub show_mnu_inc_mant01(sender As Object, e As EventArgs) Handles mnu_Form7.Click
        Try
            abrir_formulario(inc_mant01)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub show_mnu_Form3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Form3.Click
        Try
            abrir_formulario(Form3)
        Catch ex As Exception
            ex = ex
        End Try
    End Sub
    Private Sub show_mnu_Salir(ByVal sender As Object, ByVal e As EventArgs) Handles mnu_Salir.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub abrir_formulario(ByRef formulario As Form)
        Try
            If formulario.Visible = False Then
                'formulario = New Form
                formulario.MdiParent = Me
                formulario.Show()

            Else
                formulario.Focus()
            End If
        Catch ex As Exception
            ex = ex
        End Try
    End Sub

    'Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.LayoutMdi(MdiLayout.ArrangeIcons)
    'End Sub

    'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Cierre todos los formularios secundarios del primario.
    '    For Each ChildForm As Form In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    'End Sub

    Private Sub show_tsl_Form1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsl_Form1.Click
        Call show_mnu_Reg01(sender, e)
    End Sub
    Private Sub show_tsl_cc_tecnico(sender As Object, e As EventArgs) Handles tsl_gastos.Click
        Call show_mnu_cc_tecnico(sender, e)
    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Global.System.Windows.Forms.Application.Exit()
    End Sub
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'privilegioUsuario()


    End Sub

    Private Sub ProspeccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProspeccionesToolStripMenuItem.Click
        Try
            abrir_formulario(Reg02)
        Catch ex As Exception
            ex = ex
        End Try
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Try
            abrir_formulario(empl)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MantComponentesCaracteristicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantComponentesCaracteristicasToolStripMenuItem.Click
        


    End Sub

    Private Sub SolDesbloqueoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolDesbloqueoToolStripMenuItem.Click

    End Sub

    Private Sub ACToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACToolStripMenuItem.Click

    End Sub

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub AdministracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionToolStripMenuItem.Click
        
       

    End Sub

    Private Sub PruebaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PruebaToolStripMenuItem_Disposed(sender As Object, e As EventArgs)

    End Sub

    Private Sub PruebaToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs)

    End Sub

    Private Sub PruebaToolStripMenuItem_EnabledChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PruebaToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PruebaToolStripMenuItem_VisibleChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SeguridadMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguridadMenuToolStripMenuItem.Click

    End Sub


    Private Sub privilegioUsuario()
        'Permisos de usuarios

        ' Gestor TECNICO  NIVEL 0
        'Gestor COBROS NIVEL 1
        'Opciones de los Encargados de Soporte Tecnico alos Gestores Tecnico NIVEL 2
        'Opciones de los Encargados de Soporte Cobros alos Gestores Cobros NIVEL 3
        'Administradores ,Encargados Call Center Cobros,Tecnicos y Tecnologia NIVEL 4




        If Login.nivel = 0 Then
            'Gestor Tecnico'
            AdministracionToolStripMenuItem.Visible = False 'Menu principal Administracion contiene
            ' Propecciones y Empleados  
            tsl_Form1.Visible = False 'Barra de Call Center Cobros'
            FileMenu.Visible = False 'Menu de Call Center Cobros
            mnu_Form7.Visible = False 'Mantemientos de 4 pasos Componentes
            MantComponentesCaracteristicasToolStripMenuItem.Visible = False 'Mantenimiento componentes y caracteristicas

        End If
        If Login.nivel = 1 Then
            'Gestor Cobros'
            AdministracionToolStripMenuItem.Visible = False 'Menu principal Administracion contiene
            ' Propecciones y Empleados Call Center Tecnico
            tsl_gastos.Visible = False 'Barra de Call Center Tecnicos'
            SeguridadMenuToolStripMenuItem.Visible = False 'Menu de Soporte de Call Center Tecnicos
            mnu_bloqueos.Visible = False 'Bloquear
            mnu_Form3.Visible = False 'Desbloquear
            mnu_sol_nobloqueo.Visible = False 'No Bloquear
            SolDesbloqueoToolStripMenuItem.Visible = False 'Sol-Desbloqueo
            ACToolStripMenuItem.Visible = False 'Acuerdo de Pago
            SolAjusteToolStripMenuItem.Visible = False 'Ajuste

        End If

        'Opciones de los Encargados de Soporte Tecnico alos Gestores Tecnico NIVEL 2
        If Login.nivel = 2 Then
            'Gestor Tecnico Privilegio al Call Center Cobros'
            AdministracionToolStripMenuItem.Visible = False 'Menu principal Administracion contiene
            ' Propecciones y Empleados  
            mnu_bloqueos.Visible = False 'Bloquear
            mnu_Form3.Visible = False 'Desbloquear
            mnu_sol_nobloqueo.Visible = False 'No Bloquear
            SolDesbloqueoToolStripMenuItem.Visible = False 'Sol-Desbloqueo
            ACToolStripMenuItem.Visible = False 'Acuerdo de Pago
            SolAjusteToolStripMenuItem.Visible = False 'Ajuste
            mnu_Form7.Visible = False 'Mantemientos de 4 pasos Componentes
            MantComponentesCaracteristicasToolStripMenuItem.Visible = False 'Mantenimiento componentes y caracteristicas

            mnu_Form7.Visible = False 'Mantemientos de 4 pasos Componentes
        End If

        'Opciones de los Encargados de Soporte Cobros alos Gestores Cobros NIVEL 3
        If Login.nivel = 3 Then
            'Gestor Cobros Privilegio al Call Center Tecnicos'
            AdministracionToolStripMenuItem.Visible = False 'Menu principal Administracion contiene
            ' Propecciones y Empleados  
            mnu_bloqueos.Visible = False 'Bloquear
            mnu_Form3.Visible = False 'Desbloquear
            mnu_sol_nobloqueo.Visible = False 'No Bloquear
            SolDesbloqueoToolStripMenuItem.Visible = False 'Sol-Desbloqueo
            ACToolStripMenuItem.Visible = False 'Acuerdo de Pago
            SolAjusteToolStripMenuItem.Visible = False 'Ajuste
            mnu_Form7.Visible = False 'Mantemientos de 4 pasos Componentes
            MantComponentesCaracteristicasToolStripMenuItem.Visible = False 'Mantenimiento componentes y caracteristicas

            mnu_Form7.Visible = False 'Mantemientos de 4 pasos Componentes
        End If

        'Administradores ,Encargados Call Center Cobros,Tecnicos y Tecnologia NIVEL 4
        If Login.nivel = 4 Then
            'Administradores ,Encargados Call Center Cobros,Tecnicos y Tecnologia NIVEL 4

            FileMenu.Visible = True 'Menu de Call Center Cobros
            AdministracionToolStripMenuItem.Visible = True 'Menu principal Administracion contiene
            ' Propecciones y Empleados Call Center Tecnico
            SeguridadMenuToolStripMenuItem.Visible = True 'Menu de Soporte de Call Center Tecnicos
        End If
    End Sub

    Private Sub RepctToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepctToolStripMenuItem.Click
        ''Reg011.Show()
    End Sub

    Private Sub ActualizarBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarBalanceToolStripMenuItem.Click
        ActualizarBalances.Show()
    End Sub

    Private Sub ReporteDeAntiguedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAntiguedadToolStripMenuItem.Click
        Filtrar.Show()
    End Sub

    Private Sub ReporteDeAntiguedadDetalladoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAntiguedadDetalladoToolStripMenuItem.Click
        ReporteAntiguedadResumido.Show()
    End Sub


    Private Sub ReporteDeComisionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeComisionesToolStripMenuItem.Click
        ReproteComisionesForm.Show()
    End Sub

    Private Sub ReporteCxcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteCxcToolStripMenuItem.Click
        ProcesoCXC.Show()
    End Sub

    Private Sub ReporteContabilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteContabilidadToolStripMenuItem.Click
        ANTIGUEDAD_GESTOR_CONTABILIDAD_FORM.Show()
    End Sub
End Class
