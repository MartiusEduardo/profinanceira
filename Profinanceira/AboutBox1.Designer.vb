<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class caixadescricao_profinanceira
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents texto_produto_nome As System.Windows.Forms.Label
    Friend WithEvents texto_produto_versao As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents texto_descricao As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents texto_copyright As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(caixadescricao_profinanceira))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.texto_produto_nome = New System.Windows.Forms.Label
        Me.texto_produto_versao = New System.Windows.Forms.Label
        Me.texto_copyright = New System.Windows.Forms.Label
        Me.LabelCompanyName = New System.Windows.Forms.Label
        Me.texto_descricao = New System.Windows.Forms.TextBox
        Me.OKButton = New System.Windows.Forms.Button
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.272727!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.72727!))
        Me.TableLayoutPanel.Controls.Add(Me.texto_produto_nome, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.texto_produto_versao, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.texto_copyright, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.texto_descricao, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 9)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(396, 258)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'texto_produto_nome
        '
        Me.texto_produto_nome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.texto_produto_nome.Location = New System.Drawing.Point(14, 0)
        Me.texto_produto_nome.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.texto_produto_nome.MaximumSize = New System.Drawing.Size(0, 17)
        Me.texto_produto_nome.Name = "texto_produto_nome"
        Me.texto_produto_nome.Size = New System.Drawing.Size(379, 17)
        Me.texto_produto_nome.TabIndex = 0
        Me.texto_produto_nome.Text = "Profinanceira - Programa de Cálculos Financeiros"
        Me.texto_produto_nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'texto_produto_versao
        '
        Me.texto_produto_versao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.texto_produto_versao.Location = New System.Drawing.Point(14, 25)
        Me.texto_produto_versao.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.texto_produto_versao.MaximumSize = New System.Drawing.Size(0, 17)
        Me.texto_produto_versao.Name = "texto_produto_versao"
        Me.texto_produto_versao.Size = New System.Drawing.Size(379, 17)
        Me.texto_produto_versao.TabIndex = 0
        Me.texto_produto_versao.Text = "1.0"
        Me.texto_produto_versao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'texto_copyright
        '
        Me.texto_copyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.texto_copyright.Location = New System.Drawing.Point(14, 50)
        Me.texto_copyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.texto_copyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.texto_copyright.Name = "texto_copyright"
        Me.texto_copyright.Size = New System.Drawing.Size(379, 17)
        Me.texto_copyright.TabIndex = 0
        Me.texto_copyright.Text = "Copyright - Todos dos Direitos Reservados."
        Me.texto_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCompanyName.Location = New System.Drawing.Point(14, 75)
        Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(379, 17)
        Me.LabelCompanyName.TabIndex = 0
        Me.LabelCompanyName.Text = "Martius Eduardo Rodriguez"
        Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'texto_descricao
        '
        Me.texto_descricao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.texto_descricao.Location = New System.Drawing.Point(14, 103)
        Me.texto_descricao.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.texto_descricao.Multiline = True
        Me.texto_descricao.Name = "texto_descricao"
        Me.texto_descricao.ReadOnly = True
        Me.texto_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.texto_descricao.Size = New System.Drawing.Size(379, 123)
        Me.texto_descricao.TabIndex = 0
        Me.texto_descricao.TabStop = False
        Me.texto_descricao.Text = resources.GetString("texto_descricao.Text")
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(318, 232)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        '
        'caixadescricao_profinanceira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(414, 276)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "caixadescricao_profinanceira"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Profinanceira"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

End Class
