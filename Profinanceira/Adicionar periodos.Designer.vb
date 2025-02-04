<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_adicionar_periodos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_adicionar_periodos))
        Me.btn_adicionar_periodo_cancelar = New System.Windows.Forms.Button
        Me.btn_adicionar_periodo_ok = New System.Windows.Forms.Button
        Me.caixatexto_adicionar_periodos = New System.Windows.Forms.TextBox
        Me.texto_adicionar_periodos = New System.Windows.Forms.Label
        Me.caixatexto_adicionar_n_periodos = New System.Windows.Forms.TextBox
        Me.texto_adicionar_n_periodos = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_adicionar_periodo_cancelar
        '
        Me.btn_adicionar_periodo_cancelar.Location = New System.Drawing.Point(117, 104)
        Me.btn_adicionar_periodo_cancelar.Name = "btn_adicionar_periodo_cancelar"
        Me.btn_adicionar_periodo_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_adicionar_periodo_cancelar.TabIndex = 17
        Me.btn_adicionar_periodo_cancelar.Text = "Voltar"
        Me.btn_adicionar_periodo_cancelar.UseVisualStyleBackColor = True
        '
        'btn_adicionar_periodo_ok
        '
        Me.btn_adicionar_periodo_ok.Location = New System.Drawing.Point(15, 104)
        Me.btn_adicionar_periodo_ok.Name = "btn_adicionar_periodo_ok"
        Me.btn_adicionar_periodo_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_adicionar_periodo_ok.TabIndex = 16
        Me.btn_adicionar_periodo_ok.Text = "Adicionar"
        Me.btn_adicionar_periodo_ok.UseVisualStyleBackColor = True
        '
        'caixatexto_adicionar_periodos
        '
        Me.caixatexto_adicionar_periodos.Location = New System.Drawing.Point(87, 60)
        Me.caixatexto_adicionar_periodos.Name = "caixatexto_adicionar_periodos"
        Me.caixatexto_adicionar_periodos.Size = New System.Drawing.Size(57, 20)
        Me.caixatexto_adicionar_periodos.TabIndex = 15
        '
        'texto_adicionar_periodos
        '
        Me.texto_adicionar_periodos.AutoSize = True
        Me.texto_adicionar_periodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_adicionar_periodos.Location = New System.Drawing.Point(12, 63)
        Me.texto_adicionar_periodos.Name = "texto_adicionar_periodos"
        Me.texto_adicionar_periodos.Size = New System.Drawing.Size(52, 13)
        Me.texto_adicionar_periodos.TabIndex = 14
        Me.texto_adicionar_periodos.Text = "Período"
        '
        'caixatexto_adicionar_n_periodos
        '
        Me.caixatexto_adicionar_n_periodos.Location = New System.Drawing.Point(87, 21)
        Me.caixatexto_adicionar_n_periodos.Name = "caixatexto_adicionar_n_periodos"
        Me.caixatexto_adicionar_n_periodos.ReadOnly = True
        Me.caixatexto_adicionar_n_periodos.Size = New System.Drawing.Size(57, 20)
        Me.caixatexto_adicionar_n_periodos.TabIndex = 13
        Me.caixatexto_adicionar_n_periodos.Text = "0"
        '
        'texto_adicionar_n_periodos
        '
        Me.texto_adicionar_n_periodos.AutoSize = True
        Me.texto_adicionar_n_periodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_adicionar_n_periodos.Location = New System.Drawing.Point(12, 24)
        Me.texto_adicionar_n_periodos.Name = "texto_adicionar_n_periodos"
        Me.texto_adicionar_n_periodos.Size = New System.Drawing.Size(69, 13)
        Me.texto_adicionar_n_periodos.TabIndex = 12
        Me.texto_adicionar_n_periodos.Text = "Parcela (n)"
        '
        'form_adicionar_periodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 143)
        Me.Controls.Add(Me.btn_adicionar_periodo_cancelar)
        Me.Controls.Add(Me.btn_adicionar_periodo_ok)
        Me.Controls.Add(Me.caixatexto_adicionar_periodos)
        Me.Controls.Add(Me.texto_adicionar_periodos)
        Me.Controls.Add(Me.caixatexto_adicionar_n_periodos)
        Me.Controls.Add(Me.texto_adicionar_n_periodos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_adicionar_periodos"
        Me.Text = "Adicionar períodos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_adicionar_periodo_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_adicionar_periodo_ok As System.Windows.Forms.Button
    Friend WithEvents caixatexto_adicionar_periodos As System.Windows.Forms.TextBox
    Friend WithEvents texto_adicionar_periodos As System.Windows.Forms.Label
    Friend WithEvents caixatexto_adicionar_n_periodos As System.Windows.Forms.TextBox
    Friend WithEvents texto_adicionar_n_periodos As System.Windows.Forms.Label
End Class
