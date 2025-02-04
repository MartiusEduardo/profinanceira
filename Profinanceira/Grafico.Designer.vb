<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_grafico_price
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_grafico_price))
        Me.grafico_price = New System.Windows.Forms.PictureBox
        Me.btn_gerar_dfc = New System.Windows.Forms.Button
        Me.texto_legenda_price = New System.Windows.Forms.Label
        Me.texto_azul_price = New System.Windows.Forms.Label
        Me.texto_vermelho_price = New System.Windows.Forms.Label
        Me.texto_legenda_amortizacao_price = New System.Windows.Forms.Label
        Me.texto_legenda_juros_price = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.grafico_price, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grafico_price
        '
        Me.grafico_price.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grafico_price.BackColor = System.Drawing.SystemColors.Window
        Me.grafico_price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grafico_price.Location = New System.Drawing.Point(12, 12)
        Me.grafico_price.Name = "grafico_price"
        Me.grafico_price.Size = New System.Drawing.Size(916, 399)
        Me.grafico_price.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.grafico_price.TabIndex = 0
        Me.grafico_price.TabStop = False
        '
        'btn_gerar_dfc
        '
        Me.btn_gerar_dfc.Location = New System.Drawing.Point(213, 458)
        Me.btn_gerar_dfc.Name = "btn_gerar_dfc"
        Me.btn_gerar_dfc.Size = New System.Drawing.Size(90, 23)
        Me.btn_gerar_dfc.TabIndex = 1
        Me.btn_gerar_dfc.Text = "Gerar Diagrama"
        Me.btn_gerar_dfc.UseVisualStyleBackColor = True
        '
        'texto_legenda_price
        '
        Me.texto_legenda_price.AutoSize = True
        Me.texto_legenda_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_legenda_price.Location = New System.Drawing.Point(3, 15)
        Me.texto_legenda_price.Name = "texto_legenda_price"
        Me.texto_legenda_price.Size = New System.Drawing.Size(60, 13)
        Me.texto_legenda_price.TabIndex = 2
        Me.texto_legenda_price.Text = "Legenda:"
        '
        'texto_azul_price
        '
        Me.texto_azul_price.AutoSize = True
        Me.texto_azul_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_azul_price.ForeColor = System.Drawing.Color.Blue
        Me.texto_azul_price.Location = New System.Drawing.Point(69, 15)
        Me.texto_azul_price.Name = "texto_azul_price"
        Me.texto_azul_price.Size = New System.Drawing.Size(35, 13)
        Me.texto_azul_price.TabIndex = 3
        Me.texto_azul_price.Text = "Azul:"
        '
        'texto_vermelho_price
        '
        Me.texto_vermelho_price.AutoSize = True
        Me.texto_vermelho_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vermelho_price.ForeColor = System.Drawing.Color.Red
        Me.texto_vermelho_price.Location = New System.Drawing.Point(69, 38)
        Me.texto_vermelho_price.Name = "texto_vermelho_price"
        Me.texto_vermelho_price.Size = New System.Drawing.Size(63, 13)
        Me.texto_vermelho_price.TabIndex = 4
        Me.texto_vermelho_price.Text = "Vermelho:"
        '
        'texto_legenda_amortizacao_price
        '
        Me.texto_legenda_amortizacao_price.AutoSize = True
        Me.texto_legenda_amortizacao_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_legenda_amortizacao_price.Location = New System.Drawing.Point(110, 15)
        Me.texto_legenda_amortizacao_price.Name = "texto_legenda_amortizacao_price"
        Me.texto_legenda_amortizacao_price.Size = New System.Drawing.Size(76, 13)
        Me.texto_legenda_amortizacao_price.TabIndex = 5
        Me.texto_legenda_amortizacao_price.Text = "Amortização"
        '
        'texto_legenda_juros_price
        '
        Me.texto_legenda_juros_price.AutoSize = True
        Me.texto_legenda_juros_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_legenda_juros_price.Location = New System.Drawing.Point(138, 38)
        Me.texto_legenda_juros_price.Name = "texto_legenda_juros_price"
        Me.texto_legenda_juros_price.Size = New System.Drawing.Size(37, 13)
        Me.texto_legenda_juros_price.TabIndex = 6
        Me.texto_legenda_juros_price.Text = "Juros"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.texto_legenda_juros_price)
        Me.Panel1.Controls.Add(Me.texto_legenda_price)
        Me.Panel1.Controls.Add(Me.texto_legenda_amortizacao_price)
        Me.Panel1.Controls.Add(Me.texto_azul_price)
        Me.Panel1.Controls.Add(Me.texto_vermelho_price)
        Me.Panel1.Location = New System.Drawing.Point(12, 417)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(195, 64)
        Me.Panel1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Gráfico de Barras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'form_grafico_price
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(940, 493)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_gerar_dfc)
        Me.Controls.Add(Me.grafico_price)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_grafico_price"
        Me.Text = "Gráfico"
        CType(Me.grafico_price, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grafico_price As System.Windows.Forms.PictureBox
    Friend WithEvents btn_gerar_dfc As System.Windows.Forms.Button
    Friend WithEvents texto_legenda_price As System.Windows.Forms.Label
    Friend WithEvents texto_azul_price As System.Windows.Forms.Label
    Friend WithEvents texto_vermelho_price As System.Windows.Forms.Label
    Friend WithEvents texto_legenda_amortizacao_price As System.Windows.Forms.Label
    Friend WithEvents texto_legenda_juros_price As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
