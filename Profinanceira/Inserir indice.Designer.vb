<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_inserir_indice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_inserir_indice))
        Me.texto_n_indice = New System.Windows.Forms.Label
        Me.caixatexto_n_indice = New System.Windows.Forms.TextBox
        Me.texto_indice = New System.Windows.Forms.Label
        Me.caixatexto_indice = New System.Windows.Forms.TextBox
        Me.btn_mudar_indice_ok = New System.Windows.Forms.Button
        Me.btn_mudar_indice_cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'texto_n_indice
        '
        Me.texto_n_indice.AutoSize = True
        Me.texto_n_indice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_n_indice.Location = New System.Drawing.Point(9, 29)
        Me.texto_n_indice.Name = "texto_n_indice"
        Me.texto_n_indice.Size = New System.Drawing.Size(69, 13)
        Me.texto_n_indice.TabIndex = 0
        Me.texto_n_indice.Text = "Parcela (n)"
        '
        'caixatexto_n_indice
        '
        Me.caixatexto_n_indice.Location = New System.Drawing.Point(84, 26)
        Me.caixatexto_n_indice.Name = "caixatexto_n_indice"
        Me.caixatexto_n_indice.ReadOnly = True
        Me.caixatexto_n_indice.Size = New System.Drawing.Size(57, 20)
        Me.caixatexto_n_indice.TabIndex = 1
        '
        'texto_indice
        '
        Me.texto_indice.AutoSize = True
        Me.texto_indice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_indice.Location = New System.Drawing.Point(9, 68)
        Me.texto_indice.Name = "texto_indice"
        Me.texto_indice.Size = New System.Drawing.Size(42, 13)
        Me.texto_indice.TabIndex = 2
        Me.texto_indice.Text = "Índice"
        '
        'caixatexto_indice
        '
        Me.caixatexto_indice.Location = New System.Drawing.Point(84, 65)
        Me.caixatexto_indice.Name = "caixatexto_indice"
        Me.caixatexto_indice.Size = New System.Drawing.Size(57, 20)
        Me.caixatexto_indice.TabIndex = 3
        '
        'btn_mudar_indice_ok
        '
        Me.btn_mudar_indice_ok.Location = New System.Drawing.Point(12, 105)
        Me.btn_mudar_indice_ok.Name = "btn_mudar_indice_ok"
        Me.btn_mudar_indice_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_mudar_indice_ok.TabIndex = 4
        Me.btn_mudar_indice_ok.Text = "Inserir"
        Me.btn_mudar_indice_ok.UseVisualStyleBackColor = True
        '
        'btn_mudar_indice_cancelar
        '
        Me.btn_mudar_indice_cancelar.Location = New System.Drawing.Point(114, 105)
        Me.btn_mudar_indice_cancelar.Name = "btn_mudar_indice_cancelar"
        Me.btn_mudar_indice_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_mudar_indice_cancelar.TabIndex = 5
        Me.btn_mudar_indice_cancelar.Text = "Voltar"
        Me.btn_mudar_indice_cancelar.UseVisualStyleBackColor = True
        '
        'form_inserir_indice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 143)
        Me.Controls.Add(Me.btn_mudar_indice_cancelar)
        Me.Controls.Add(Me.btn_mudar_indice_ok)
        Me.Controls.Add(Me.caixatexto_indice)
        Me.Controls.Add(Me.texto_indice)
        Me.Controls.Add(Me.caixatexto_n_indice)
        Me.Controls.Add(Me.texto_n_indice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_inserir_indice"
        Me.Text = "Inserir índice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents texto_n_indice As System.Windows.Forms.Label
    Friend WithEvents caixatexto_n_indice As System.Windows.Forms.TextBox
    Friend WithEvents texto_indice As System.Windows.Forms.Label
    Friend WithEvents caixatexto_indice As System.Windows.Forms.TextBox
    Friend WithEvents btn_mudar_indice_ok As System.Windows.Forms.Button
    Friend WithEvents btn_mudar_indice_cancelar As System.Windows.Forms.Button
End Class
