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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.menu_arquivo = New System.Windows.Forms.ToolStripMenuItem
        Me.submenu_exportar_dados = New System.Windows.Forms.ToolStripMenuItem
        Me.submenu2_excel = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.submenu_visualizar_impressao = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.submenu_imprimir = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_financas = New System.Windows.Forms.ToolStripMenuItem
        Me.submenu_calculos_financeiros = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.submenu_descontos_titulos = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.submenu_series = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.submenu_ef = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_ajuda = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.PrintPreviewDialog_principal = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument_principal = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog_principal = New System.Windows.Forms.PrintDialog
        Me.SaveFileDialog_principal = New System.Windows.Forms.SaveFileDialog
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_arquivo, Me.menu_financas, Me.menu_ajuda})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(700, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'menu_arquivo
        '
        Me.menu_arquivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_exportar_dados, Me.ToolStripSeparator1, Me.submenu_visualizar_impressao, Me.ToolStripSeparator2, Me.submenu_imprimir, Me.ToolStripSeparator6, Me.SairToolStripMenuItem})
        Me.menu_arquivo.Name = "menu_arquivo"
        Me.menu_arquivo.Size = New System.Drawing.Size(56, 20)
        Me.menu_arquivo.Text = "Arquivo"
        '
        'submenu_exportar_dados
        '
        Me.submenu_exportar_dados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu2_excel})
        Me.submenu_exportar_dados.Enabled = False
        Me.submenu_exportar_dados.Name = "submenu_exportar_dados"
        Me.submenu_exportar_dados.Size = New System.Drawing.Size(180, 22)
        Me.submenu_exportar_dados.Text = "Exportar dados"
        '
        'submenu2_excel
        '
        Me.submenu2_excel.Name = "submenu2_excel"
        Me.submenu2_excel.Size = New System.Drawing.Size(110, 22)
        Me.submenu2_excel.Text = "Excel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'submenu_visualizar_impressao
        '
        Me.submenu_visualizar_impressao.Enabled = False
        Me.submenu_visualizar_impressao.Name = "submenu_visualizar_impressao"
        Me.submenu_visualizar_impressao.Size = New System.Drawing.Size(180, 22)
        Me.submenu_visualizar_impressao.Text = "Visualizar impressão"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'submenu_imprimir
        '
        Me.submenu_imprimir.Enabled = False
        Me.submenu_imprimir.Name = "submenu_imprimir"
        Me.submenu_imprimir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.submenu_imprimir.Size = New System.Drawing.Size(180, 22)
        Me.submenu_imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(177, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'menu_financas
        '
        Me.menu_financas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_calculos_financeiros, Me.ToolStripSeparator3, Me.submenu_descontos_titulos, Me.ToolStripSeparator4, Me.submenu_series, Me.ToolStripSeparator5, Me.submenu_ef})
        Me.menu_financas.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.menu_financas.Name = "menu_financas"
        Me.menu_financas.Size = New System.Drawing.Size(61, 20)
        Me.menu_financas.Text = "Finanças"
        '
        'submenu_calculos_financeiros
        '
        Me.submenu_calculos_financeiros.ImageTransparentColor = System.Drawing.Color.Black
        Me.submenu_calculos_financeiros.Name = "submenu_calculos_financeiros"
        Me.submenu_calculos_financeiros.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.submenu_calculos_financeiros.ShowShortcutKeys = False
        Me.submenu_calculos_financeiros.Size = New System.Drawing.Size(213, 22)
        Me.submenu_calculos_financeiros.Text = "Cálculos Financeiros"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(210, 6)
        '
        'submenu_descontos_titulos
        '
        Me.submenu_descontos_titulos.Enabled = False
        Me.submenu_descontos_titulos.ImageTransparentColor = System.Drawing.Color.Black
        Me.submenu_descontos_titulos.Name = "submenu_descontos_titulos"
        Me.submenu_descontos_titulos.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.submenu_descontos_titulos.ShowShortcutKeys = False
        Me.submenu_descontos_titulos.Size = New System.Drawing.Size(213, 22)
        Me.submenu_descontos_titulos.Text = "Descontos de Títulos"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(210, 6)
        '
        'submenu_series
        '
        Me.submenu_series.Enabled = False
        Me.submenu_series.Name = "submenu_series"
        Me.submenu_series.Size = New System.Drawing.Size(213, 22)
        Me.submenu_series.Text = "Séries"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(210, 6)
        '
        'submenu_ef
        '
        Me.submenu_ef.ImageTransparentColor = System.Drawing.Color.Black
        Me.submenu_ef.Name = "submenu_ef"
        Me.submenu_ef.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.submenu_ef.ShowShortcutKeys = False
        Me.submenu_ef.Size = New System.Drawing.Size(213, 22)
        Me.submenu_ef.Text = "Empréstimos e Financiamentos"
        '
        'menu_ajuda
        '
        Me.menu_ajuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.menu_ajuda.Name = "menu_ajuda"
        Me.menu_ajuda.Size = New System.Drawing.Size(47, 20)
        Me.menu_ajuda.Text = "Ajuda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(145, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
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
        'PrintPreviewDialog_principal
        '
        Me.PrintPreviewDialog_principal.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog_principal.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog_principal.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog_principal.Document = Me.PrintDocument_principal
        Me.PrintPreviewDialog_principal.Enabled = True
        Me.PrintPreviewDialog_principal.Icon = CType(resources.GetObject("PrintPreviewDialog_principal.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog_principal.Name = "PrintPreviewDialog_principal"
        Me.PrintPreviewDialog_principal.Visible = False
        '
        'PrintDocument_principal
        '
        '
        'PrintDialog_principal
        '
        Me.PrintDialog_principal.UseEXDialog = True
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
        Me.Text = "Profinanceira - Programa de cálculos financeiros"
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
    Friend WithEvents submenu_series As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menu_financas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents submenu_calculos_financeiros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents submenu_ef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents submenu_descontos_titulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_arquivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents submenu_exportar_dados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents submenu2_excel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents submenu_visualizar_impressao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents submenu_imprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewDialog_principal As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument_principal As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog_principal As System.Windows.Forms.PrintDialog
    Friend WithEvents SaveFileDialog_principal As System.Windows.Forms.SaveFileDialog

End Class
