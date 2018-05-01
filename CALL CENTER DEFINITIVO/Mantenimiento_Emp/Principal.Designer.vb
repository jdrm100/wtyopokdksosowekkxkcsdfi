<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Reg01 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_bloqueos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Form3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_sol_nobloqueo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolDesbloqueoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolAjusteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Form5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Form7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantComponentesCaracteristicasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProspeccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepctToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeAntiguedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeAntiguedadDetalladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeComisionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeLoteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeRecargasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeLlamadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarBalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsl_Form1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsl_gastos = New System.Windows.Forms.ToolStripLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tsl_estado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.SeguridadMenuToolStripMenuItem, Me.AdministracionToolStripMenuItem, Me.RepctToolStripMenuItem, Me.ActualizarBalanceToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1097, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Reg01, Me.mnu_bloqueos, Me.mnu_Form3, Me.mnu_sol_nobloqueo, Me.SolDesbloqueoToolStripMenuItem, Me.ACToolStripMenuItem, Me.SolAjusteToolStripMenuItem, Me.ToolStripSeparator3, Me.mnu_Salir})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(57, 20)
        Me.FileMenu.Text = "Cobros"
        '
        'mnu_Reg01
        '
        Me.mnu_Reg01.Image = Global.My.Resources.Resources.user_comment
        Me.mnu_Reg01.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnu_Reg01.Name = "mnu_Reg01"
        Me.mnu_Reg01.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnu_Reg01.Size = New System.Drawing.Size(177, 22)
        Me.mnu_Reg01.Text = "&Call Center"
        '
        'mnu_bloqueos
        '
        Me.mnu_bloqueos.Image = Global.My.Resources.Resources.lock
        Me.mnu_bloqueos.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnu_bloqueos.Name = "mnu_bloqueos"
        Me.mnu_bloqueos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnu_bloqueos.Size = New System.Drawing.Size(177, 22)
        Me.mnu_bloqueos.Text = "&Bloquear"
        '
        'mnu_Form3
        '
        Me.mnu_Form3.Image = Global.My.Resources.Resources.lock_open
        Me.mnu_Form3.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnu_Form3.Name = "mnu_Form3"
        Me.mnu_Form3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnu_Form3.Size = New System.Drawing.Size(177, 22)
        Me.mnu_Form3.Text = "&Desbloquer"
        '
        'mnu_sol_nobloqueo
        '
        Me.mnu_sol_nobloqueo.Image = Global.My.Resources.Resources.lock_break
        Me.mnu_sol_nobloqueo.Name = "mnu_sol_nobloqueo"
        Me.mnu_sol_nobloqueo.Size = New System.Drawing.Size(177, 22)
        Me.mnu_sol_nobloqueo.Text = "Sol. NO BLOQUEAR"
        '
        'SolDesbloqueoToolStripMenuItem
        '
        Me.SolDesbloqueoToolStripMenuItem.Image = Global.My.Resources.Resources.lock_delete
        Me.SolDesbloqueoToolStripMenuItem.Name = "SolDesbloqueoToolStripMenuItem"
        Me.SolDesbloqueoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SolDesbloqueoToolStripMenuItem.Text = "Sol. Desbloqueo"
        '
        'ACToolStripMenuItem
        '
        Me.ACToolStripMenuItem.Image = Global.My.Resources.Resources.script_edit
        Me.ACToolStripMenuItem.Name = "ACToolStripMenuItem"
        Me.ACToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ACToolStripMenuItem.Text = "Sol. AC"
        '
        'SolAjusteToolStripMenuItem
        '
        Me.SolAjusteToolStripMenuItem.Image = Global.My.Resources.Resources.money
        Me.SolAjusteToolStripMenuItem.Name = "SolAjusteToolStripMenuItem"
        Me.SolAjusteToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SolAjusteToolStripMenuItem.Text = "Sol. Ajuste"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(174, 6)
        '
        'mnu_Salir
        '
        Me.mnu_Salir.Name = "mnu_Salir"
        Me.mnu_Salir.Size = New System.Drawing.Size(177, 22)
        Me.mnu_Salir.Text = "&Salir"
        '
        'SeguridadMenuToolStripMenuItem
        '
        Me.SeguridadMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Form5, Me.mnu_Form7, Me.MantComponentesCaracteristicasToolStripMenuItem})
        Me.SeguridadMenuToolStripMenuItem.Name = "SeguridadMenuToolStripMenuItem"
        Me.SeguridadMenuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.SeguridadMenuToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SeguridadMenuToolStripMenuItem.Text = "Soporte"
        '
        'mnu_Form5
        '
        Me.mnu_Form5.Name = "mnu_Form5"
        Me.mnu_Form5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnu_Form5.Size = New System.Drawing.Size(264, 22)
        Me.mnu_Form5.Text = "Call Center"
        '
        'mnu_Form7
        '
        Me.mnu_Form7.Name = "mnu_Form7"
        Me.mnu_Form7.Size = New System.Drawing.Size(264, 22)
        Me.mnu_Form7.Text = "Mant. 4 pasos"
        '
        'MantComponentesCaracteristicasToolStripMenuItem
        '
        Me.MantComponentesCaracteristicasToolStripMenuItem.Name = "MantComponentesCaracteristicasToolStripMenuItem"
        Me.MantComponentesCaracteristicasToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.MantComponentesCaracteristicasToolStripMenuItem.Text = "Mant. Componentes/Caracteristicas"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProspeccionesToolStripMenuItem, Me.EmpleadosToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'ProspeccionesToolStripMenuItem
        '
        Me.ProspeccionesToolStripMenuItem.Name = "ProspeccionesToolStripMenuItem"
        Me.ProspeccionesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ProspeccionesToolStripMenuItem.Text = "Prospecciones"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'RepctToolStripMenuItem
        '
        Me.RepctToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeAntiguedadToolStripMenuItem, Me.ReporteDeAntiguedadDetalladoToolStripMenuItem, Me.ReporteDeComisionesToolStripMenuItem, Me.ReporteDeLoteriaToolStripMenuItem, Me.ReporteDeRecargasToolStripMenuItem, Me.ReporteDeLlamadasToolStripMenuItem})
        Me.RepctToolStripMenuItem.Name = "RepctToolStripMenuItem"
        Me.RepctToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RepctToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeAntiguedadToolStripMenuItem
        '
        Me.ReporteDeAntiguedadToolStripMenuItem.Name = "ReporteDeAntiguedadToolStripMenuItem"
        Me.ReporteDeAntiguedadToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeAntiguedadToolStripMenuItem.Text = "Reporte de antiguedad"
        '
        'ReporteDeAntiguedadDetalladoToolStripMenuItem
        '
        Me.ReporteDeAntiguedadDetalladoToolStripMenuItem.Name = "ReporteDeAntiguedadDetalladoToolStripMenuItem"
        Me.ReporteDeAntiguedadDetalladoToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeAntiguedadDetalladoToolStripMenuItem.Text = "Reporte de antiguedad detallado"
        '
        'ReporteDeComisionesToolStripMenuItem
        '
        Me.ReporteDeComisionesToolStripMenuItem.Name = "ReporteDeComisionesToolStripMenuItem"
        Me.ReporteDeComisionesToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeComisionesToolStripMenuItem.Text = "Reporte de comisiones"
        '
        'ReporteDeLoteriaToolStripMenuItem
        '
        Me.ReporteDeLoteriaToolStripMenuItem.Name = "ReporteDeLoteriaToolStripMenuItem"
        Me.ReporteDeLoteriaToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeLoteriaToolStripMenuItem.Text = "Reporte de loteria"
        '
        'ReporteDeRecargasToolStripMenuItem
        '
        Me.ReporteDeRecargasToolStripMenuItem.Name = "ReporteDeRecargasToolStripMenuItem"
        Me.ReporteDeRecargasToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeRecargasToolStripMenuItem.Text = "Reporte de recargas"
        '
        'ReporteDeLlamadasToolStripMenuItem
        '
        Me.ReporteDeLlamadasToolStripMenuItem.Name = "ReporteDeLlamadasToolStripMenuItem"
        Me.ReporteDeLlamadasToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeLlamadasToolStripMenuItem.Text = "Reporte de llamadas"
        '
        'ActualizarBalanceToolStripMenuItem
        '
        Me.ActualizarBalanceToolStripMenuItem.Name = "ActualizarBalanceToolStripMenuItem"
        Me.ActualizarBalanceToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ActualizarBalanceToolStripMenuItem.Text = "Actualizar balance"
        '
        'ReporteDeAntiguedadToolStripMenuItem
        '
        Me.ReporteDeAntiguedadToolStripMenuItem.Name = "ReporteDeAntiguedadToolStripMenuItem"
        Me.ReporteDeAntiguedadToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeAntiguedadToolStripMenuItem.Text = "Reporte de antiguedad"
        '
        'ReporteDeAntiguedadDetalladoToolStripMenuItem
        '
        Me.ReporteDeAntiguedadDetalladoToolStripMenuItem.Name = "ReporteDeAntiguedadDetalladoToolStripMenuItem"
        Me.ReporteDeAntiguedadDetalladoToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeAntiguedadDetalladoToolStripMenuItem.Text = "Reporte de antiguedad detallado"
        '
        'ReporteDeComisionesToolStripMenuItem
        '
        Me.ReporteDeComisionesToolStripMenuItem.Name = "ReporteDeComisionesToolStripMenuItem"
        Me.ReporteDeComisionesToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeComisionesToolStripMenuItem.Text = "Reporte de comisiones"
        '
        'ReporteDeLoteriaToolStripMenuItem
        '
        Me.ReporteDeLoteriaToolStripMenuItem.Name = "ReporteDeLoteriaToolStripMenuItem"
        Me.ReporteDeLoteriaToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeLoteriaToolStripMenuItem.Text = "Reporte de loteria"
        '
        'ReporteDeRecargasToolStripMenuItem
        '
        Me.ReporteDeRecargasToolStripMenuItem.Name = "ReporteDeRecargasToolStripMenuItem"
        Me.ReporteDeRecargasToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeRecargasToolStripMenuItem.Text = "Reporte de recargas"
        '
        'ReporteDeLlamadasToolStripMenuItem
        '
        Me.ReporteDeLlamadasToolStripMenuItem.Name = "ReporteDeLlamadasToolStripMenuItem"
        Me.ReporteDeLlamadasToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ReporteDeLlamadasToolStripMenuItem.Text = "Reporte de llamadas"
        '
        'ActualizarBalanceToolStripMenuItem
        '
        Me.ActualizarBalanceToolStripMenuItem.Name = "ActualizarBalanceToolStripMenuItem"
        Me.ActualizarBalanceToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ActualizarBalanceToolStripMenuItem.Text = "Actualizar balance"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_Form1, Me.ToolStripSeparator1, Me.tsl_gastos})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1097, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'tsl_Form1
        '
        Me.tsl_Form1.Image = Global.My.Resources.Resources.user_comment
        Me.tsl_Form1.Name = "tsl_Form1"
        Me.tsl_Form1.Size = New System.Drawing.Size(126, 22)
        Me.tsl_Form1.Text = "Call Center Cobros"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsl_gastos
        '
        Me.tsl_gastos.Image = Global.My.Resources.Resources.user_go
        Me.tsl_gastos.Name = "tsl_gastos"
        Me.tsl_gastos.Size = New System.Drawing.Size(129, 22)
        Me.tsl_gastos.Text = "Call Center Soporte"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_estado})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 719)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1097, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'tsl_estado
        '
        Me.tsl_estado.Name = "tsl_estado"
        Me.tsl_estado.Size = New System.Drawing.Size(42, 17)
        Me.tsl_estado.Text = "Estado"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 741)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOTO REAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents tsl_estado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents mnu_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Reg01 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_bloqueos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_Form3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tsl_Form1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SeguridadMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Form5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Form7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsl_gastos As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mnu_sol_nobloqueo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolDesbloqueoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolAjusteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProspeccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantComponentesCaracteristicasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepctToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeAntiguedadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeAntiguedadDetalladoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeComisionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeLoteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeRecargasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeLlamadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarBalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
