<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_inserir_periodos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_inserir_periodos))
        Me.btn_mudar_periodo_cancelar = New System.Windows.Forms.Button
        Me.btn_mudar_periodo_ok = New System.Windows.Forms.Button
        Me.caixatexto_periodos = New System.Windows.Forms.TextBox
        Me.texto_periodos = New System.Windows.Forms.Label
        Me.caixatexto_n_periodos = New System.Windows.Forms.TextBox
        Me.texto_n_periodos = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_mudar_periodo_cancelar
        '
        Me.btn_mudar_periodo_cancelar.Location = New System.Drawing.Point(114, 108)
        Me.btn_mudar_periodo_cancelar.Name = "btn_mudar_periodo_cancelar"
        Me.btn_mudar_periodo_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_mudar_periodo_cancelar.TabIndex = 11
        Me.btn_mudar_periodo_cancelar.Text = "Voltar"
        Me.btn_mudar_periodo_cancelar.UseVisualStyleBackColor = True
        '
        'btn_mudar_periodo_ok
        '
        Me.btn_mudar_periodo_ok.Location = New System.Drawing.Point(12, 108)
        Me.btn_mudar_periodo_ok.Name = "btn_mudar_periodo_ok"
        Me.btn_mudar_periodo_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_mudar_periodo_ok.TabIndex = 10
        Me.btn_mudar_periodo_ok.Text = "Inserir"
        Me.btn_mudar_periodo_ok.UseVisualStyleBackColor = True
        '
        'caixatexto_periodos
        '
        Me.caixatexto_periodos.Location = New System.Drawing.Point(84, 64)
        Me.caixatexto_periodos.Name = "caixatexto_periodos"
        Me.caixatexto_periodos.Size = New System.Drawing.Size(57, 20)
        Me.caixatexto_periodos.TabIndex = 9
        '
        'texto_periodos
        '
        Me.texto_periodos.AutoSize = True
        Me.texto_periodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_periodos.Location = New System.Drawing.Point(9, 67)
        Me.texto_periodos.Name = "texto_periodos"
        Me.texto_periodos.Size = New System.Drawing.Size(52, 13)
        Me.texto_periodos.TabIndex = 8
        Me.texto_periodos.Text = "Período"
        '
        'caixatexto_n_periodos
        '
        Me.caixatexto_n_periodos.Location = New System.Drawing.Point(84, 25)
        Me.caixatexto_n_periodos.Name = "caixatexto_n_periodos"
        Me.caixatexto_n_periodos.ReadOnly = True
        Me.caixatexto_n_periodos.Size = New System.Drawing.Size(57, 20)
        Me.caixatexto_n_periodos.TabIndex = 7
        '
        'texto_n_periodos
        '
        Me.texto_n_periodos.AutoSize = True
        Me.texto_n_periodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_n_periodos.Location = New System.Drawing.Point(9, 28)
        Me.texto_n_periodos.Name = "texto_n_periodos"
        Me.texto_n_periodos.Size = New System.Drawing.Size(69, 13)
        Me.texto_n_periodos.TabIndex = 6
        Me.texto_n_periodos.Text = "Parcela (n)"
        '
        'form_inserir_periodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 143)
        Me.Controls.Add(Me.btn_mudar_periodo_cancelar)
        Me.Controls.Add(Me.btn_mudar_periodo_ok)
        Me.Controls.Add(Me.caixatexto_periodos)
        Me.Controls.Add(Me.texto_periodos)
        Me.Controls.Add(Me.caixatexto_n_periodos)
        Me.Controls.Add(Me.texto_n_periodos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_inserir_periodos"
        Me.Text = "Inserir períodos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_mudar_periodo_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_mudar_periodo_ok As System.Windows.Forms.Button
    Friend WithEvents caixatexto_periodos As System.Windows.Forms.TextBox
    Friend WithEvents texto_periodos As System.Windows.Forms.Label
    Friend WithEvents caixatexto_n_periodos As System.Windows.Forms.TextBox
    Friend WithEvents texto_n_periodos As System.Windows.Forms.Label
End Class
