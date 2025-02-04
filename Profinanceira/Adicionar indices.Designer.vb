<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_adicionar_indices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_adicionar_indices))
        Me.btn_adicionar_indices_cancelar = New System.Windows.Forms.Button
        Me.btn_adicionar_indices_ok = New System.Windows.Forms.Button
        Me.caixatexto_adicionar_indices = New System.Windows.Forms.TextBox
        Me.texto_adicionar_indices = New System.Windows.Forms.Label
        Me.caixatexto_adicionar_n_indices = New System.Windows.Forms.TextBox
        Me.texto_adicionar_n_indices = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_adicionar_indices_cancelar
        '
        Me.btn_adicionar_indices_cancelar.Location = New System.Drawing.Point(115, 101)
        Me.btn_adicionar_indices_cancelar.Name = "btn_adicionar_indices_cancelar"
        Me.btn_adicionar_indices_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_adicionar_indices_cancelar.TabIndex = 23
        Me.btn_adicionar_indices_cancelar.Text = "Voltar"
        Me.btn_adicionar_indices_cancelar.UseVisualStyleBackColor = True
        '
        'btn_adicionar_indices_ok
        '
        Me.btn_adicionar_indices_ok.Location = New System.Drawing.Point(13, 101)
        Me.btn_adicionar_indices_ok.Name = "btn_adicionar_indices_ok"
        Me.btn_adicionar_indices_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_adicionar_indices_ok.TabIndex = 22
        Me.btn_adicionar_indices_ok.Text = "Adicionar"
        Me.btn_adicionar_indices_ok.UseVisualStyleBackColor = True
        '
        'caixatexto_adicionar_indices
        '
        Me.caixatexto_adicionar_indices.Location = New System.Drawing.Point(85, 57)
        Me.caixatexto_adicionar_indices.Name = "caixatexto_adicionar_indices"
        Me.caixatexto_adicionar_indices.Size = New System.Drawing.Size(57, 20)
        Me.caixatexto_adicionar_indices.TabIndex = 21
        '
        'texto_adicionar_indices
        '
        Me.texto_adicionar_indices.AutoSize = True
        Me.texto_adicionar_indices.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_adicionar_indices.Location = New System.Drawing.Point(10, 60)
        Me.texto_adicionar_indices.Name = "texto_adicionar_indices"
        Me.texto_adicionar_indices.Size = New System.Drawing.Size(48, 13)
        Me.texto_adicionar_indices.TabIndex = 20
        Me.texto_adicionar_indices.Text = "Índices"
        '
        'caixatexto_adicionar_n_indices
        '
        Me.caixatexto_adicionar_n_indices.Location = New System.Drawing.Point(85, 18)
        Me.caixatexto_adicionar_n_indices.Name = "caixatexto_adicionar_n_indices"
        Me.caixatexto_adicionar_n_indices.ReadOnly = True
        Me.caixatexto_adicionar_n_indices.Size = New System.Drawing.Size(57, 20)
        Me.caixatexto_adicionar_n_indices.TabIndex = 19
        Me.caixatexto_adicionar_n_indices.Text = "0"
        '
        'texto_adicionar_n_indices
        '
        Me.texto_adicionar_n_indices.AutoSize = True
        Me.texto_adicionar_n_indices.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_adicionar_n_indices.Location = New System.Drawing.Point(10, 21)
        Me.texto_adicionar_n_indices.Name = "texto_adicionar_n_indices"
        Me.texto_adicionar_n_indices.Size = New System.Drawing.Size(69, 13)
        Me.texto_adicionar_n_indices.TabIndex = 18
        Me.texto_adicionar_n_indices.Text = "Parcela (n)"
        '
        'form_adicionar_indices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 143)
        Me.Controls.Add(Me.btn_adicionar_indices_cancelar)
        Me.Controls.Add(Me.btn_adicionar_indices_ok)
        Me.Controls.Add(Me.caixatexto_adicionar_indices)
        Me.Controls.Add(Me.texto_adicionar_indices)
        Me.Controls.Add(Me.caixatexto_adicionar_n_indices)
        Me.Controls.Add(Me.texto_adicionar_n_indices)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_adicionar_indices"
        Me.Text = "Adicionar índices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_adicionar_indices_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_adicionar_indices_ok As System.Windows.Forms.Button
    Friend WithEvents caixatexto_adicionar_indices As System.Windows.Forms.TextBox
    Friend WithEvents texto_adicionar_indices As System.Windows.Forms.Label
    Friend WithEvents caixatexto_adicionar_n_indices As System.Windows.Forms.TextBox
    Friend WithEvents texto_adicionar_n_indices As System.Windows.Forms.Label
End Class
