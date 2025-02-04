<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_adicionar_periodos_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_adicionar_periodos_principal))
        Me.btn_inserir_periodos_price = New System.Windows.Forms.Button
        Me.caixatexto_inserir_periodos_price = New System.Windows.Forms.TextBox
        Me.texto_inserir_periodos_price = New System.Windows.Forms.Label
        Me.caixatexto_remover_periodos_price = New System.Windows.Forms.TextBox
        Me.texto_remover_periodos_price = New System.Windows.Forms.Label
        Me.btn_remover_periodos_price = New System.Windows.Forms.Button
        Me.btn_adicionar_periodos_price = New System.Windows.Forms.Button
        Me.caixatexto_tempo_periodos = New System.Windows.Forms.TextBox
        Me.texto_tempo_periodos_price = New System.Windows.Forms.Label
        Me.caixacombo_le_add_periodos = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btn_inserir_periodos_price
        '
        Me.btn_inserir_periodos_price.BackColor = System.Drawing.SystemColors.Control
        Me.btn_inserir_periodos_price.Location = New System.Drawing.Point(101, 144)
        Me.btn_inserir_periodos_price.Name = "btn_inserir_periodos_price"
        Me.btn_inserir_periodos_price.Size = New System.Drawing.Size(106, 23)
        Me.btn_inserir_periodos_price.TabIndex = 19
        Me.btn_inserir_periodos_price.Text = "Inserir períodos"
        Me.btn_inserir_periodos_price.UseVisualStyleBackColor = False
        '
        'caixatexto_inserir_periodos_price
        '
        Me.caixatexto_inserir_periodos_price.Location = New System.Drawing.Point(133, 118)
        Me.caixatexto_inserir_periodos_price.Name = "caixatexto_inserir_periodos_price"
        Me.caixatexto_inserir_periodos_price.Size = New System.Drawing.Size(60, 20)
        Me.caixatexto_inserir_periodos_price.TabIndex = 18
        '
        'texto_inserir_periodos_price
        '
        Me.texto_inserir_periodos_price.AutoSize = True
        Me.texto_inserir_periodos_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_inserir_periodos_price.Location = New System.Drawing.Point(12, 121)
        Me.texto_inserir_periodos_price.Name = "texto_inserir_periodos_price"
        Me.texto_inserir_periodos_price.Size = New System.Drawing.Size(77, 13)
        Me.texto_inserir_periodos_price.TabIndex = 17
        Me.texto_inserir_periodos_price.Text = """N"" a inserir"
        '
        'caixatexto_remover_periodos_price
        '
        Me.caixatexto_remover_periodos_price.Location = New System.Drawing.Point(133, 63)
        Me.caixatexto_remover_periodos_price.Name = "caixatexto_remover_periodos_price"
        Me.caixatexto_remover_periodos_price.Size = New System.Drawing.Size(60, 20)
        Me.caixatexto_remover_periodos_price.TabIndex = 16
        '
        'texto_remover_periodos_price
        '
        Me.texto_remover_periodos_price.AutoSize = True
        Me.texto_remover_periodos_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_remover_periodos_price.Location = New System.Drawing.Point(12, 66)
        Me.texto_remover_periodos_price.Name = "texto_remover_periodos_price"
        Me.texto_remover_periodos_price.Size = New System.Drawing.Size(88, 13)
        Me.texto_remover_periodos_price.TabIndex = 15
        Me.texto_remover_periodos_price.Text = """N"" a remover"
        '
        'btn_remover_periodos_price
        '
        Me.btn_remover_periodos_price.BackColor = System.Drawing.SystemColors.Control
        Me.btn_remover_periodos_price.Location = New System.Drawing.Point(101, 89)
        Me.btn_remover_periodos_price.Name = "btn_remover_periodos_price"
        Me.btn_remover_periodos_price.Size = New System.Drawing.Size(106, 23)
        Me.btn_remover_periodos_price.TabIndex = 14
        Me.btn_remover_periodos_price.Text = "Remover períodos"
        Me.btn_remover_periodos_price.UseVisualStyleBackColor = False
        '
        'btn_adicionar_periodos_price
        '
        Me.btn_adicionar_periodos_price.BackColor = System.Drawing.SystemColors.Control
        Me.btn_adicionar_periodos_price.Enabled = False
        Me.btn_adicionar_periodos_price.Location = New System.Drawing.Point(101, 34)
        Me.btn_adicionar_periodos_price.Name = "btn_adicionar_periodos_price"
        Me.btn_adicionar_periodos_price.Size = New System.Drawing.Size(106, 23)
        Me.btn_adicionar_periodos_price.TabIndex = 13
        Me.btn_adicionar_periodos_price.Text = "Adicionar períodos"
        Me.btn_adicionar_periodos_price.UseVisualStyleBackColor = False
        '
        'caixatexto_tempo_periodos
        '
        Me.caixatexto_tempo_periodos.Location = New System.Drawing.Point(133, 8)
        Me.caixatexto_tempo_periodos.Name = "caixatexto_tempo_periodos"
        Me.caixatexto_tempo_periodos.ReadOnly = True
        Me.caixatexto_tempo_periodos.Size = New System.Drawing.Size(60, 20)
        Me.caixatexto_tempo_periodos.TabIndex = 12
        Me.caixatexto_tempo_periodos.Text = "0"
        '
        'texto_tempo_periodos_price
        '
        Me.texto_tempo_periodos_price.AutoSize = True
        Me.texto_tempo_periodos_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tempo_periodos_price.Location = New System.Drawing.Point(12, 11)
        Me.texto_tempo_periodos_price.Name = "texto_tempo_periodos_price"
        Me.texto_tempo_periodos_price.Size = New System.Drawing.Size(115, 13)
        Me.texto_tempo_periodos_price.TabIndex = 11
        Me.texto_tempo_periodos_price.Text = "Quantos períodos?"
        '
        'caixacombo_le_add_periodos
        '
        Me.caixacombo_le_add_periodos.FormattingEnabled = True
        Me.caixacombo_le_add_periodos.Items.AddRange(New Object() {"Sistema Francês", "Sistema PRICE", "Sistema Alemão", "Sistema de Amortização Misto", "Sistema de Pagamentos Variáveis"})
        Me.caixacombo_le_add_periodos.Location = New System.Drawing.Point(15, 182)
        Me.caixacombo_le_add_periodos.Name = "caixacombo_le_add_periodos"
        Me.caixacombo_le_add_periodos.Size = New System.Drawing.Size(192, 21)
        Me.caixacombo_le_add_periodos.TabIndex = 20
        Me.caixacombo_le_add_periodos.Text = "Sistema Francês"
        '
        'form_adicionar_periodos_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 210)
        Me.Controls.Add(Me.caixacombo_le_add_periodos)
        Me.Controls.Add(Me.btn_inserir_periodos_price)
        Me.Controls.Add(Me.caixatexto_inserir_periodos_price)
        Me.Controls.Add(Me.texto_inserir_periodos_price)
        Me.Controls.Add(Me.caixatexto_remover_periodos_price)
        Me.Controls.Add(Me.texto_remover_periodos_price)
        Me.Controls.Add(Me.btn_remover_periodos_price)
        Me.Controls.Add(Me.btn_adicionar_periodos_price)
        Me.Controls.Add(Me.caixatexto_tempo_periodos)
        Me.Controls.Add(Me.texto_tempo_periodos_price)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_adicionar_periodos_principal"
        Me.Text = "Adicionar períodos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_inserir_periodos_price As System.Windows.Forms.Button
    Friend WithEvents caixatexto_inserir_periodos_price As System.Windows.Forms.TextBox
    Friend WithEvents texto_inserir_periodos_price As System.Windows.Forms.Label
    Friend WithEvents caixatexto_remover_periodos_price As System.Windows.Forms.TextBox
    Friend WithEvents texto_remover_periodos_price As System.Windows.Forms.Label
    Friend WithEvents btn_remover_periodos_price As System.Windows.Forms.Button
    Friend WithEvents btn_adicionar_periodos_price As System.Windows.Forms.Button
    Friend WithEvents caixatexto_tempo_periodos As System.Windows.Forms.TextBox
    Friend WithEvents texto_tempo_periodos_price As System.Windows.Forms.Label
    Friend WithEvents caixacombo_le_add_periodos As System.Windows.Forms.ComboBox
End Class
