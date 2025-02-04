<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profinanceira_inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profinanceira_inicio))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.menu_arquivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_financas = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_calculos_financeiros = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.submenu_descontos_titulos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.submenu_ef = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MétodoHamburguêsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_ajuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_arquivo, Me.menu_financas, Me.FerramentasToolStripMenuItem, Me.menu_ajuda})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(700, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'menu_arquivo
        '
        Me.menu_arquivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.menu_arquivo.Name = "menu_arquivo"
        Me.menu_arquivo.Size = New System.Drawing.Size(37, 20)
        Me.menu_arquivo.Text = "File"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.SairToolStripMenuItem.Text = "Exit"
        '
        'menu_financas
        '
        Me.menu_financas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_calculos_financeiros, Me.ToolStripSeparator3, Me.submenu_descontos_titulos, Me.ToolStripSeparator4, Me.submenu_ef, Me.ToolStripSeparator1, Me.MétodoHamburguêsToolStripMenuItem})
        Me.menu_financas.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.menu_financas.Name = "menu_financas"
        Me.menu_financas.Size = New System.Drawing.Size(60, 20)
        Me.menu_financas.Text = "Finance"
        '
        'submenu_calculos_financeiros
        '
        Me.submenu_calculos_financeiros.ImageTransparentColor = System.Drawing.Color.Black
        Me.submenu_calculos_financeiros.Name = "submenu_calculos_financeiros"
        Me.submenu_calculos_financeiros.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.submenu_calculos_financeiros.ShowShortcutKeys = False
        Me.submenu_calculos_financeiros.Size = New System.Drawing.Size(194, 22)
        Me.submenu_calculos_financeiros.Text = "Financial Calculations"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(191, 6)
        '
        'submenu_descontos_titulos
        '
        Me.submenu_descontos_titulos.ImageTransparentColor = System.Drawing.Color.Black
        Me.submenu_descontos_titulos.Name = "submenu_descontos_titulos"
        Me.submenu_descontos_titulos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.submenu_descontos_titulos.ShowShortcutKeys = False
        Me.submenu_descontos_titulos.Size = New System.Drawing.Size(194, 22)
        Me.submenu_descontos_titulos.Text = "Discount of Titles"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(191, 6)
        '
        'submenu_ef
        '
        Me.submenu_ef.ImageTransparentColor = System.Drawing.Color.Black
        Me.submenu_ef.Name = "submenu_ef"
        Me.submenu_ef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.submenu_ef.ShowShortcutKeys = False
        Me.submenu_ef.Size = New System.Drawing.Size(194, 22)
        Me.submenu_ef.Text = "Loans and Financing"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'MétodoHamburguêsToolStripMenuItem
        '
        Me.MétodoHamburguêsToolStripMenuItem.Name = "MétodoHamburguêsToolStripMenuItem"
        Me.MétodoHamburguêsToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.MétodoHamburguêsToolStripMenuItem.Text = "Method Hamburguese"
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.OpçõesToolStripMenuItem})
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.FerramentasToolStripMenuItem.Text = "Tools"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculator"
        '
        'OpçõesToolStripMenuItem
        '
        Me.OpçõesToolStripMenuItem.Name = "OpçõesToolStripMenuItem"
        Me.OpçõesToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.OpçõesToolStripMenuItem.Text = "Options"
        '
        'menu_ajuda
        '
        Me.menu_ajuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.menu_ajuda.Name = "menu_ajuda"
        Me.menu_ajuda.Size = New System.Drawing.Size(44, 20)
        Me.menu_ajuda.Text = "Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(138, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 514)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(700, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'profinanceira_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(700, 536)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "profinanceira_inicio"
        Me.Text = "Profinanceira - Program of financial calculations"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_ajuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menu_financas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents submenu_calculos_financeiros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents submenu_ef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents submenu_descontos_titulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_arquivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FerramentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MétodoHamburguêsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
