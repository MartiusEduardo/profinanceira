<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_sistema_price
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_sistema_price))
        Me.texto_tempo_indices_price = New System.Windows.Forms.Label
        Me.caixatexto_tempo_indices_price = New System.Windows.Forms.TextBox
        Me.btn_adicionar_indices_price = New System.Windows.Forms.Button
        Me.btn_remover_indices_price = New System.Windows.Forms.Button
        Me.texto_remover_indices_price = New System.Windows.Forms.Label
        Me.caixatexto_remover_indices_price = New System.Windows.Forms.TextBox
        Me.texto_inserir_indices_price = New System.Windows.Forms.Label
        Me.caixatexto_inserir_indices_price = New System.Windows.Forms.TextBox
        Me.btn_inserir_indices_price = New System.Windows.Forms.Button
        Me.caixacombo_le_add_indices = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'texto_tempo_indices_price
        '
        Me.texto_tempo_indices_price.AutoSize = True
        Me.texto_tempo_indices_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tempo_indices_price.Location = New System.Drawing.Point(12, 9)
        Me.texto_tempo_indices_price.Name = "texto_tempo_indices_price"
        Me.texto_tempo_indices_price.Size = New System.Drawing.Size(75, 13)
        Me.texto_tempo_indices_price.TabIndex = 0
        Me.texto_tempo_indices_price.Text = "Parcelas (n)"
        '
        'caixatexto_tempo_indices_price
        '
        Me.caixatexto_tempo_indices_price.Location = New System.Drawing.Point(118, 6)
        Me.caixatexto_tempo_indices_price.Name = "caixatexto_tempo_indices_price"
        Me.caixatexto_tempo_indices_price.ReadOnly = True
        Me.caixatexto_tempo_indices_price.Size = New System.Drawing.Size(60, 20)
        Me.caixatexto_tempo_indices_price.TabIndex = 1
        Me.caixatexto_tempo_indices_price.Text = "0"
        '
        'btn_adicionar_indices_price
        '
        Me.btn_adicionar_indices_price.BackColor = System.Drawing.SystemColors.Control
        Me.btn_adicionar_indices_price.Enabled = False
        Me.btn_adicionar_indices_price.Location = New System.Drawing.Point(93, 32)
        Me.btn_adicionar_indices_price.Name = "btn_adicionar_indices_price"
        Me.btn_adicionar_indices_price.Size = New System.Drawing.Size(99, 23)
        Me.btn_adicionar_indices_price.TabIndex = 4
        Me.btn_adicionar_indices_price.Text = "Adicionar índices"
        Me.btn_adicionar_indices_price.UseVisualStyleBackColor = False
        '
        'btn_remover_indices_price
        '
        Me.btn_remover_indices_price.BackColor = System.Drawing.SystemColors.Control
        Me.btn_remover_indices_price.Location = New System.Drawing.Point(93, 87)
        Me.btn_remover_indices_price.Name = "btn_remover_indices_price"
        Me.btn_remover_indices_price.Size = New System.Drawing.Size(99, 23)
        Me.btn_remover_indices_price.TabIndex = 5
        Me.btn_remover_indices_price.Text = "Remover índices"
        Me.btn_remover_indices_price.UseVisualStyleBackColor = False
        '
        'texto_remover_indices_price
        '
        Me.texto_remover_indices_price.AutoSize = True
        Me.texto_remover_indices_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_remover_indices_price.Location = New System.Drawing.Point(12, 64)
        Me.texto_remover_indices_price.Name = "texto_remover_indices_price"
        Me.texto_remover_indices_price.Size = New System.Drawing.Size(88, 13)
        Me.texto_remover_indices_price.TabIndex = 6
        Me.texto_remover_indices_price.Text = """N"" a remover"
        '
        'caixatexto_remover_indices_price
        '
        Me.caixatexto_remover_indices_price.Location = New System.Drawing.Point(118, 61)
        Me.caixatexto_remover_indices_price.Name = "caixatexto_remover_indices_price"
        Me.caixatexto_remover_indices_price.Size = New System.Drawing.Size(60, 20)
        Me.caixatexto_remover_indices_price.TabIndex = 7
        '
        'texto_inserir_indices_price
        '
        Me.texto_inserir_indices_price.AutoSize = True
        Me.texto_inserir_indices_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_inserir_indices_price.Location = New System.Drawing.Point(12, 123)
        Me.texto_inserir_indices_price.Name = "texto_inserir_indices_price"
        Me.texto_inserir_indices_price.Size = New System.Drawing.Size(77, 13)
        Me.texto_inserir_indices_price.TabIndex = 8
        Me.texto_inserir_indices_price.Text = """N"" a inserir"
        '
        'caixatexto_inserir_indices_price
        '
        Me.caixatexto_inserir_indices_price.Location = New System.Drawing.Point(118, 116)
        Me.caixatexto_inserir_indices_price.Name = "caixatexto_inserir_indices_price"
        Me.caixatexto_inserir_indices_price.Size = New System.Drawing.Size(60, 20)
        Me.caixatexto_inserir_indices_price.TabIndex = 9
        '
        'btn_inserir_indices_price
        '
        Me.btn_inserir_indices_price.BackColor = System.Drawing.SystemColors.Control
        Me.btn_inserir_indices_price.Location = New System.Drawing.Point(93, 142)
        Me.btn_inserir_indices_price.Name = "btn_inserir_indices_price"
        Me.btn_inserir_indices_price.Size = New System.Drawing.Size(99, 23)
        Me.btn_inserir_indices_price.TabIndex = 10
        Me.btn_inserir_indices_price.Text = "Inserir índices"
        Me.btn_inserir_indices_price.UseVisualStyleBackColor = False
        '
        'caixacombo_le_add_indices
        '
        Me.caixacombo_le_add_indices.FormattingEnabled = True
        Me.caixacombo_le_add_indices.Items.AddRange(New Object() {"Sistema Francês", "Sistema PRICE", "Sistema Alemão", "Sistema de Amortização Misto", "Sistema de Pagamentos Variáveis"})
        Me.caixacombo_le_add_indices.Location = New System.Drawing.Point(15, 184)
        Me.caixacombo_le_add_indices.Name = "caixacombo_le_add_indices"
        Me.caixacombo_le_add_indices.Size = New System.Drawing.Size(177, 21)
        Me.caixacombo_le_add_indices.TabIndex = 11
        Me.caixacombo_le_add_indices.Text = "Sistema Francês"
        '
        'form_sistema_price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(210, 208)
        Me.Controls.Add(Me.caixacombo_le_add_indices)
        Me.Controls.Add(Me.btn_inserir_indices_price)
        Me.Controls.Add(Me.caixatexto_inserir_indices_price)
        Me.Controls.Add(Me.texto_inserir_indices_price)
        Me.Controls.Add(Me.caixatexto_remover_indices_price)
        Me.Controls.Add(Me.texto_remover_indices_price)
        Me.Controls.Add(Me.btn_remover_indices_price)
        Me.Controls.Add(Me.btn_adicionar_indices_price)
        Me.Controls.Add(Me.caixatexto_tempo_indices_price)
        Me.Controls.Add(Me.texto_tempo_indices_price)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_sistema_price"
        Me.Text = "Adicionar índices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents texto_tempo_indices_price As System.Windows.Forms.Label
    Friend WithEvents caixatexto_tempo_indices_price As System.Windows.Forms.TextBox
    Friend WithEvents btn_adicionar_indices_price As System.Windows.Forms.Button
    Friend WithEvents btn_remover_indices_price As System.Windows.Forms.Button
    Friend WithEvents texto_remover_indices_price As System.Windows.Forms.Label
    Friend WithEvents caixatexto_remover_indices_price As System.Windows.Forms.TextBox
    Friend WithEvents texto_inserir_indices_price As System.Windows.Forms.Label
    Friend WithEvents caixatexto_inserir_indices_price As System.Windows.Forms.TextBox
    Friend WithEvents btn_inserir_indices_price As System.Windows.Forms.Button
    Friend WithEvents caixacombo_le_add_indices As System.Windows.Forms.ComboBox
End Class
