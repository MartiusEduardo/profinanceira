<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_descontos_titulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_descontos_titulos))
        Me.texto_vt_dt = New System.Windows.Forms.Label
        Me.texto_taxa_desconto_dt = New System.Windows.Forms.Label
        Me.texto_tempo_dt = New System.Windows.Forms.Label
        Me.texto_vd_dt = New System.Windows.Forms.Label
        Me.texto_desconto_dt = New System.Windows.Forms.Label
        Me.caixatexto_vt_dt = New System.Windows.Forms.TextBox
        Me.caixatexto_taxa_dt = New System.Windows.Forms.TextBox
        Me.caixatexto_tempo_dt = New System.Windows.Forms.TextBox
        Me.caixatexto_desconto_dt = New System.Windows.Forms.TextBox
        Me.caixatexto_vd_dt = New System.Windows.Forms.TextBox
        Me.btn_calcular_vt_dt = New System.Windows.Forms.Button
        Me.btn_calcular_taxa_desconto_dt = New System.Windows.Forms.Button
        Me.btn_calcular_tempo_dt = New System.Windows.Forms.Button
        Me.btn_calcular_desconto_dt = New System.Windows.Forms.Button
        Me.btn_calcular_vd_dt = New System.Windows.Forms.Button
        Me.texto_vd_sem_encargos_dt = New System.Windows.Forms.Label
        Me.caixatexto_vd_sem_encargos_dt = New System.Windows.Forms.TextBox
        Me.btn_calcular_vd_sem_encargos_dt = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'texto_vt_dt
        '
        Me.texto_vt_dt.AutoSize = True
        Me.texto_vt_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vt_dt.Location = New System.Drawing.Point(12, 9)
        Me.texto_vt_dt.Name = "texto_vt_dt"
        Me.texto_vt_dt.Size = New System.Drawing.Size(88, 13)
        Me.texto_vt_dt.TabIndex = 16
        Me.texto_vt_dt.Text = "Valor do t�tulo"
        '
        'texto_taxa_desconto_dt
        '
        Me.texto_taxa_desconto_dt.AutoSize = True
        Me.texto_taxa_desconto_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_taxa_desconto_dt.Location = New System.Drawing.Point(12, 42)
        Me.texto_taxa_desconto_dt.Name = "texto_taxa_desconto_dt"
        Me.texto_taxa_desconto_dt.Size = New System.Drawing.Size(109, 13)
        Me.texto_taxa_desconto_dt.TabIndex = 17
        Me.texto_taxa_desconto_dt.Text = "Taxa de desconto"
        '
        'texto_tempo_dt
        '
        Me.texto_tempo_dt.AutoSize = True
        Me.texto_tempo_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tempo_dt.Location = New System.Drawing.Point(12, 74)
        Me.texto_tempo_dt.Name = "texto_tempo_dt"
        Me.texto_tempo_dt.Size = New System.Drawing.Size(75, 13)
        Me.texto_tempo_dt.TabIndex = 18
        Me.texto_tempo_dt.Text = "Parcelas (n)"
        '
        'texto_vd_dt
        '
        Me.texto_vd_dt.AutoSize = True
        Me.texto_vd_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vd_dt.Location = New System.Drawing.Point(12, 143)
        Me.texto_vd_dt.Name = "texto_vd_dt"
        Me.texto_vd_dt.Size = New System.Drawing.Size(106, 13)
        Me.texto_vd_dt.TabIndex = 19
        Me.texto_vd_dt.Text = "Valor descontado"
        '
        'texto_desconto_dt
        '
        Me.texto_desconto_dt.AutoSize = True
        Me.texto_desconto_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_desconto_dt.Location = New System.Drawing.Point(12, 108)
        Me.texto_desconto_dt.Name = "texto_desconto_dt"
        Me.texto_desconto_dt.Size = New System.Drawing.Size(61, 13)
        Me.texto_desconto_dt.TabIndex = 20
        Me.texto_desconto_dt.Text = "Desconto"
        '
        'caixatexto_vt_dt
        '
        Me.caixatexto_vt_dt.Location = New System.Drawing.Point(136, 6)
        Me.caixatexto_vt_dt.Name = "caixatexto_vt_dt"
        Me.caixatexto_vt_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vt_dt.TabIndex = 21
        '
        'caixatexto_taxa_dt
        '
        Me.caixatexto_taxa_dt.Location = New System.Drawing.Point(136, 39)
        Me.caixatexto_taxa_dt.Name = "caixatexto_taxa_dt"
        Me.caixatexto_taxa_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_taxa_dt.TabIndex = 22
        '
        'caixatexto_tempo_dt
        '
        Me.caixatexto_tempo_dt.Location = New System.Drawing.Point(136, 71)
        Me.caixatexto_tempo_dt.Name = "caixatexto_tempo_dt"
        Me.caixatexto_tempo_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_tempo_dt.TabIndex = 23
        '
        'caixatexto_desconto_dt
        '
        Me.caixatexto_desconto_dt.Location = New System.Drawing.Point(136, 105)
        Me.caixatexto_desconto_dt.Name = "caixatexto_desconto_dt"
        Me.caixatexto_desconto_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_desconto_dt.TabIndex = 24
        '
        'caixatexto_vd_dt
        '
        Me.caixatexto_vd_dt.Location = New System.Drawing.Point(136, 140)
        Me.caixatexto_vd_dt.Name = "caixatexto_vd_dt"
        Me.caixatexto_vd_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vd_dt.TabIndex = 25
        '
        'btn_calcular_vt_dt
        '
        Me.btn_calcular_vt_dt.Location = New System.Drawing.Point(262, 4)
        Me.btn_calcular_vt_dt.Name = "btn_calcular_vt_dt"
        Me.btn_calcular_vt_dt.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_vt_dt.TabIndex = 26
        Me.btn_calcular_vt_dt.Text = "Calcular Valor do T�tulo"
        Me.btn_calcular_vt_dt.UseVisualStyleBackColor = True
        '
        'btn_calcular_taxa_desconto_dt
        '
        Me.btn_calcular_taxa_desconto_dt.Location = New System.Drawing.Point(262, 37)
        Me.btn_calcular_taxa_desconto_dt.Name = "btn_calcular_taxa_desconto_dt"
        Me.btn_calcular_taxa_desconto_dt.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_taxa_desconto_dt.TabIndex = 27
        Me.btn_calcular_taxa_desconto_dt.Text = "Calcular Taxa"
        Me.btn_calcular_taxa_desconto_dt.UseVisualStyleBackColor = True
        '
        'btn_calcular_tempo_dt
        '
        Me.btn_calcular_tempo_dt.Location = New System.Drawing.Point(262, 69)
        Me.btn_calcular_tempo_dt.Name = "btn_calcular_tempo_dt"
        Me.btn_calcular_tempo_dt.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_tempo_dt.TabIndex = 28
        Me.btn_calcular_tempo_dt.Text = "Calcular Parcelas"
        Me.btn_calcular_tempo_dt.UseVisualStyleBackColor = True
        '
        'btn_calcular_desconto_dt
        '
        Me.btn_calcular_desconto_dt.Location = New System.Drawing.Point(262, 103)
        Me.btn_calcular_desconto_dt.Name = "btn_calcular_desconto_dt"
        Me.btn_calcular_desconto_dt.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_desconto_dt.TabIndex = 29
        Me.btn_calcular_desconto_dt.Text = "Calcular Desconto"
        Me.btn_calcular_desconto_dt.UseVisualStyleBackColor = True
        '
        'btn_calcular_vd_dt
        '
        Me.btn_calcular_vd_dt.Location = New System.Drawing.Point(262, 138)
        Me.btn_calcular_vd_dt.Name = "btn_calcular_vd_dt"
        Me.btn_calcular_vd_dt.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_vd_dt.TabIndex = 30
        Me.btn_calcular_vd_dt.Text = "Calcular Valor Descontado"
        Me.btn_calcular_vd_dt.UseVisualStyleBackColor = True
        '
        'texto_vd_sem_encargos_dt
        '
        Me.texto_vd_sem_encargos_dt.AutoSize = True
        Me.texto_vd_sem_encargos_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vd_sem_encargos_dt.Location = New System.Drawing.Point(12, 178)
        Me.texto_vd_sem_encargos_dt.Name = "texto_vd_sem_encargos_dt"
        Me.texto_vd_sem_encargos_dt.Size = New System.Drawing.Size(118, 13)
        Me.texto_vd_sem_encargos_dt.TabIndex = 31
        Me.texto_vd_sem_encargos_dt.Text = "Valor sem encargos"
        '
        'caixatexto_vd_sem_encargos_dt
        '
        Me.caixatexto_vd_sem_encargos_dt.Location = New System.Drawing.Point(136, 175)
        Me.caixatexto_vd_sem_encargos_dt.Name = "caixatexto_vd_sem_encargos_dt"
        Me.caixatexto_vd_sem_encargos_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vd_sem_encargos_dt.TabIndex = 32
        '
        'btn_calcular_vd_sem_encargos_dt
        '
        Me.btn_calcular_vd_sem_encargos_dt.Location = New System.Drawing.Point(262, 173)
        Me.btn_calcular_vd_sem_encargos_dt.Name = "btn_calcular_vd_sem_encargos_dt"
        Me.btn_calcular_vd_sem_encargos_dt.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_vd_sem_encargos_dt.TabIndex = 33
        Me.btn_calcular_vd_sem_encargos_dt.Text = "Calcular Valor sem Encargos"
        Me.btn_calcular_vd_sem_encargos_dt.UseVisualStyleBackColor = True
        '
        'form_descontos_titulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 658)
        Me.Controls.Add(Me.texto_vd_sem_encargos_dt)
        Me.Controls.Add(Me.caixatexto_vd_sem_encargos_dt)
        Me.Controls.Add(Me.btn_calcular_vd_sem_encargos_dt)
        Me.Controls.Add(Me.texto_vt_dt)
        Me.Controls.Add(Me.texto_taxa_desconto_dt)
        Me.Controls.Add(Me.texto_tempo_dt)
        Me.Controls.Add(Me.texto_vd_dt)
        Me.Controls.Add(Me.texto_desconto_dt)
        Me.Controls.Add(Me.caixatexto_vt_dt)
        Me.Controls.Add(Me.caixatexto_taxa_dt)
        Me.Controls.Add(Me.caixatexto_tempo_dt)
        Me.Controls.Add(Me.caixatexto_desconto_dt)
        Me.Controls.Add(Me.caixatexto_vd_dt)
        Me.Controls.Add(Me.btn_calcular_vt_dt)
        Me.Controls.Add(Me.btn_calcular_taxa_desconto_dt)
        Me.Controls.Add(Me.btn_calcular_tempo_dt)
        Me.Controls.Add(Me.btn_calcular_desconto_dt)
        Me.Controls.Add(Me.btn_calcular_vd_dt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_descontos_titulos"
        Me.Text = "Desconto de T�tulos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents texto_vt_dt As System.Windows.Forms.Label
    Friend WithEvents texto_taxa_desconto_dt As System.Windows.Forms.Label
    Friend WithEvents texto_tempo_dt As System.Windows.Forms.Label
    Friend WithEvents texto_vd_dt As System.Windows.Forms.Label
    Friend WithEvents texto_desconto_dt As System.Windows.Forms.Label
    Friend WithEvents caixatexto_vt_dt As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_taxa_dt As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_tempo_dt As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_desconto_dt As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_vd_dt As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular_vt_dt As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_taxa_desconto_dt As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_tempo_dt As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_desconto_dt As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_vd_dt As System.Windows.Forms.Button
    Friend WithEvents texto_vd_sem_encargos_dt As System.Windows.Forms.Label
    Friend WithEvents caixatexto_vd_sem_encargos_dt As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular_vd_sem_encargos_dt As System.Windows.Forms.Button
End Class
