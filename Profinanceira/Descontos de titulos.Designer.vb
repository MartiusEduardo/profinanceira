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
        Me.btn_calcular_dt = New System.Windows.Forms.Button
        Me.texto_vd_sem_encargos_dt = New System.Windows.Forms.Label
        Me.caixatexto_vd_sem_encargos_dt = New System.Windows.Forms.TextBox
        Me.rdo_vt_dt = New System.Windows.Forms.RadioButton
        Me.rdo_taxa_dt = New System.Windows.Forms.RadioButton
        Me.rdo_tempo_dt = New System.Windows.Forms.RadioButton
        Me.rdo_desconto_dt = New System.Windows.Forms.RadioButton
        Me.rdo_vd_dt = New System.Windows.Forms.RadioButton
        Me.rdo_sem_encargos_dt = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdo_custo_efetivo_dt = New System.Windows.Forms.RadioButton
        Me.rdo_iof_dt = New System.Windows.Forms.RadioButton
        Me.texto_aparente_dt = New System.Windows.Forms.Label
        Me.caixatexto_aparente_dt = New System.Windows.Forms.TextBox
        Me.caixatexto_real_dt = New System.Windows.Forms.TextBox
        Me.texto_real_dt = New System.Windows.Forms.Label
        Me.texto_inflacao_dt = New System.Windows.Forms.Label
        Me.caixatexto_inflacao_dt = New System.Windows.Forms.TextBox
        Me.texto_acumulada_dt = New System.Windows.Forms.Label
        Me.caixatexto_acumulada_dt = New System.Windows.Forms.TextBox
        Me.rdo_taxa_real_dt = New System.Windows.Forms.RadioButton
        Me.rdo_taxa_inflacao_dt = New System.Windows.Forms.RadioButton
        Me.rdo_taxa_aparente_dt = New System.Windows.Forms.RadioButton
        Me.GrupoTaxaDT = New System.Windows.Forms.GroupBox
        Me.rdo_taxa_acumulada_dt = New System.Windows.Forms.RadioButton
        Me.caixatexto_iof_dt = New System.Windows.Forms.TextBox
        Me.texto_iof_dt = New System.Windows.Forms.Label
        Me.texto_tarifa_dt = New System.Windows.Forms.Label
        Me.caixatexto_tarifa_dt = New System.Windows.Forms.TextBox
        Me.caixatexto_tac_dt = New System.Windows.Forms.TextBox
        Me.texto_tac_dt = New System.Windows.Forms.Label
        Me.caixatexto_outros_encargos_dt = New System.Windows.Forms.TextBox
        Me.texto_outros_encargos_dt = New System.Windows.Forms.Label
        Me.texto_taxa_iof_dt = New System.Windows.Forms.Label
        Me.caixatexto_taxa_iof_dt = New System.Windows.Forms.TextBox
        Me.GrupoDTeTaxa = New System.Windows.Forms.GroupBox
        Me.btn_limpar_taxas_dt = New System.Windows.Forms.Button
        Me.btn_adicionar_taxas_dt = New System.Windows.Forms.Button
        Me.lista_rentabilidade_dt = New System.Windows.Forms.ListView
        Me.Coluna_rentabilidade_dt = New System.Windows.Forms.ColumnHeader
        Me.caixatexto_taxa_administracao_dt = New System.Windows.Forms.TextBox
        Me.texto_taxa_administracao_dt = New System.Windows.Forms.Label
        Me.rdo_taxa_ari_dt = New System.Windows.Forms.RadioButton
        Me.rdo_dt_dt = New System.Windows.Forms.RadioButton
        Me.caixatexto_custo_efetivo_dt = New System.Windows.Forms.TextBox
        Me.texto_custo_efetivo_dt = New System.Windows.Forms.Label
        Me.RichTextBox_leitura_dt = New System.Windows.Forms.RichTextBox
        Me.GroupBox1.SuspendLayout()
        Me.GrupoTaxaDT.SuspendLayout()
        Me.GrupoDTeTaxa.SuspendLayout()
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
        Me.texto_taxa_desconto_dt.Location = New System.Drawing.Point(12, 35)
        Me.texto_taxa_desconto_dt.Name = "texto_taxa_desconto_dt"
        Me.texto_taxa_desconto_dt.Size = New System.Drawing.Size(130, 13)
        Me.texto_taxa_desconto_dt.TabIndex = 17
        Me.texto_taxa_desconto_dt.Text = "Taxa de desconto (%)"
        '
        'texto_tempo_dt
        '
        Me.texto_tempo_dt.AutoSize = True
        Me.texto_tempo_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tempo_dt.Location = New System.Drawing.Point(12, 61)
        Me.texto_tempo_dt.Name = "texto_tempo_dt"
        Me.texto_tempo_dt.Size = New System.Drawing.Size(75, 13)
        Me.texto_tempo_dt.TabIndex = 18
        Me.texto_tempo_dt.Text = "Parcelas (n)"
        '
        'texto_vd_dt
        '
        Me.texto_vd_dt.AutoSize = True
        Me.texto_vd_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vd_dt.Location = New System.Drawing.Point(12, 113)
        Me.texto_vd_dt.Name = "texto_vd_dt"
        Me.texto_vd_dt.Size = New System.Drawing.Size(106, 13)
        Me.texto_vd_dt.TabIndex = 19
        Me.texto_vd_dt.Text = "Valor descontado"
        '
        'texto_desconto_dt
        '
        Me.texto_desconto_dt.AutoSize = True
        Me.texto_desconto_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_desconto_dt.Location = New System.Drawing.Point(12, 87)
        Me.texto_desconto_dt.Name = "texto_desconto_dt"
        Me.texto_desconto_dt.Size = New System.Drawing.Size(61, 13)
        Me.texto_desconto_dt.TabIndex = 20
        Me.texto_desconto_dt.Text = "Desconto"
        '
        'caixatexto_vt_dt
        '
        Me.caixatexto_vt_dt.Location = New System.Drawing.Point(148, 6)
        Me.caixatexto_vt_dt.Name = "caixatexto_vt_dt"
        Me.caixatexto_vt_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vt_dt.TabIndex = 21
        '
        'caixatexto_taxa_dt
        '
        Me.caixatexto_taxa_dt.Location = New System.Drawing.Point(148, 32)
        Me.caixatexto_taxa_dt.Name = "caixatexto_taxa_dt"
        Me.caixatexto_taxa_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_taxa_dt.TabIndex = 22
        '
        'caixatexto_tempo_dt
        '
        Me.caixatexto_tempo_dt.Location = New System.Drawing.Point(148, 58)
        Me.caixatexto_tempo_dt.Name = "caixatexto_tempo_dt"
        Me.caixatexto_tempo_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_tempo_dt.TabIndex = 23
        '
        'caixatexto_desconto_dt
        '
        Me.caixatexto_desconto_dt.Location = New System.Drawing.Point(148, 84)
        Me.caixatexto_desconto_dt.Name = "caixatexto_desconto_dt"
        Me.caixatexto_desconto_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_desconto_dt.TabIndex = 24
        '
        'caixatexto_vd_dt
        '
        Me.caixatexto_vd_dt.Location = New System.Drawing.Point(148, 110)
        Me.caixatexto_vd_dt.Name = "caixatexto_vd_dt"
        Me.caixatexto_vd_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vd_dt.TabIndex = 25
        '
        'btn_calcular_dt
        '
        Me.btn_calcular_dt.Location = New System.Drawing.Point(26, 306)
        Me.btn_calcular_dt.Name = "btn_calcular_dt"
        Me.btn_calcular_dt.Size = New System.Drawing.Size(134, 23)
        Me.btn_calcular_dt.TabIndex = 26
        Me.btn_calcular_dt.Text = "Calcular"
        Me.btn_calcular_dt.UseVisualStyleBackColor = True
        '
        'texto_vd_sem_encargos_dt
        '
        Me.texto_vd_sem_encargos_dt.AutoSize = True
        Me.texto_vd_sem_encargos_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vd_sem_encargos_dt.Location = New System.Drawing.Point(12, 139)
        Me.texto_vd_sem_encargos_dt.Name = "texto_vd_sem_encargos_dt"
        Me.texto_vd_sem_encargos_dt.Size = New System.Drawing.Size(118, 13)
        Me.texto_vd_sem_encargos_dt.TabIndex = 31
        Me.texto_vd_sem_encargos_dt.Text = "Valor sem encargos"
        '
        'caixatexto_vd_sem_encargos_dt
        '
        Me.caixatexto_vd_sem_encargos_dt.Location = New System.Drawing.Point(148, 136)
        Me.caixatexto_vd_sem_encargos_dt.Name = "caixatexto_vd_sem_encargos_dt"
        Me.caixatexto_vd_sem_encargos_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vd_sem_encargos_dt.TabIndex = 32
        '
        'rdo_vt_dt
        '
        Me.rdo_vt_dt.AutoSize = True
        Me.rdo_vt_dt.Checked = True
        Me.rdo_vt_dt.Location = New System.Drawing.Point(6, 19)
        Me.rdo_vt_dt.Name = "rdo_vt_dt"
        Me.rdo_vt_dt.Size = New System.Drawing.Size(95, 17)
        Me.rdo_vt_dt.TabIndex = 35
        Me.rdo_vt_dt.TabStop = True
        Me.rdo_vt_dt.Text = "Valor do T�tulo"
        Me.rdo_vt_dt.UseVisualStyleBackColor = True
        '
        'rdo_taxa_dt
        '
        Me.rdo_taxa_dt.AutoSize = True
        Me.rdo_taxa_dt.Location = New System.Drawing.Point(6, 42)
        Me.rdo_taxa_dt.Name = "rdo_taxa_dt"
        Me.rdo_taxa_dt.Size = New System.Drawing.Size(111, 17)
        Me.rdo_taxa_dt.TabIndex = 36
        Me.rdo_taxa_dt.Text = "Taxa de desconto"
        Me.rdo_taxa_dt.UseVisualStyleBackColor = True
        '
        'rdo_tempo_dt
        '
        Me.rdo_tempo_dt.AutoSize = True
        Me.rdo_tempo_dt.Location = New System.Drawing.Point(6, 88)
        Me.rdo_tempo_dt.Name = "rdo_tempo_dt"
        Me.rdo_tempo_dt.Size = New System.Drawing.Size(66, 17)
        Me.rdo_tempo_dt.TabIndex = 37
        Me.rdo_tempo_dt.Text = "Parcelas"
        Me.rdo_tempo_dt.UseVisualStyleBackColor = True
        '
        'rdo_desconto_dt
        '
        Me.rdo_desconto_dt.AutoSize = True
        Me.rdo_desconto_dt.Location = New System.Drawing.Point(6, 111)
        Me.rdo_desconto_dt.Name = "rdo_desconto_dt"
        Me.rdo_desconto_dt.Size = New System.Drawing.Size(71, 17)
        Me.rdo_desconto_dt.TabIndex = 38
        Me.rdo_desconto_dt.Text = "Desconto"
        Me.rdo_desconto_dt.UseVisualStyleBackColor = True
        '
        'rdo_vd_dt
        '
        Me.rdo_vd_dt.AutoSize = True
        Me.rdo_vd_dt.Location = New System.Drawing.Point(6, 134)
        Me.rdo_vd_dt.Name = "rdo_vd_dt"
        Me.rdo_vd_dt.Size = New System.Drawing.Size(108, 17)
        Me.rdo_vd_dt.TabIndex = 39
        Me.rdo_vd_dt.Text = "Valor descontado"
        Me.rdo_vd_dt.UseVisualStyleBackColor = True
        '
        'rdo_sem_encargos_dt
        '
        Me.rdo_sem_encargos_dt.AutoSize = True
        Me.rdo_sem_encargos_dt.Location = New System.Drawing.Point(6, 157)
        Me.rdo_sem_encargos_dt.Name = "rdo_sem_encargos_dt"
        Me.rdo_sem_encargos_dt.Size = New System.Drawing.Size(118, 17)
        Me.rdo_sem_encargos_dt.TabIndex = 40
        Me.rdo_sem_encargos_dt.Text = "Valor sem encargos"
        Me.rdo_sem_encargos_dt.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo_custo_efetivo_dt)
        Me.GroupBox1.Controls.Add(Me.rdo_iof_dt)
        Me.GroupBox1.Controls.Add(Me.rdo_vt_dt)
        Me.GroupBox1.Controls.Add(Me.rdo_sem_encargos_dt)
        Me.GroupBox1.Controls.Add(Me.rdo_taxa_dt)
        Me.GroupBox1.Controls.Add(Me.rdo_vd_dt)
        Me.GroupBox1.Controls.Add(Me.rdo_tempo_dt)
        Me.GroupBox1.Controls.Add(Me.rdo_desconto_dt)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 206)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descontos de T�tulos"
        '
        'rdo_custo_efetivo_dt
        '
        Me.rdo_custo_efetivo_dt.AutoSize = True
        Me.rdo_custo_efetivo_dt.Location = New System.Drawing.Point(6, 65)
        Me.rdo_custo_efetivo_dt.Name = "rdo_custo_efetivo_dt"
        Me.rdo_custo_efetivo_dt.Size = New System.Drawing.Size(150, 17)
        Me.rdo_custo_efetivo_dt.TabIndex = 42
        Me.rdo_custo_efetivo_dt.Text = "Custo efetivo da opera��o"
        Me.rdo_custo_efetivo_dt.UseVisualStyleBackColor = True
        '
        'rdo_iof_dt
        '
        Me.rdo_iof_dt.AutoSize = True
        Me.rdo_iof_dt.Location = New System.Drawing.Point(6, 180)
        Me.rdo_iof_dt.Name = "rdo_iof_dt"
        Me.rdo_iof_dt.Size = New System.Drawing.Size(42, 17)
        Me.rdo_iof_dt.TabIndex = 41
        Me.rdo_iof_dt.Text = "IOF"
        Me.rdo_iof_dt.UseVisualStyleBackColor = True
        '
        'texto_aparente_dt
        '
        Me.texto_aparente_dt.AutoSize = True
        Me.texto_aparente_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_aparente_dt.Location = New System.Drawing.Point(544, 13)
        Me.texto_aparente_dt.Name = "texto_aparente_dt"
        Me.texto_aparente_dt.Size = New System.Drawing.Size(110, 13)
        Me.texto_aparente_dt.TabIndex = 44
        Me.texto_aparente_dt.Text = "Taxa aparente (%)"
        '
        'caixatexto_aparente_dt
        '
        Me.caixatexto_aparente_dt.Location = New System.Drawing.Point(671, 6)
        Me.caixatexto_aparente_dt.Name = "caixatexto_aparente_dt"
        Me.caixatexto_aparente_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_aparente_dt.TabIndex = 45
        '
        'caixatexto_real_dt
        '
        Me.caixatexto_real_dt.Location = New System.Drawing.Point(671, 32)
        Me.caixatexto_real_dt.Name = "caixatexto_real_dt"
        Me.caixatexto_real_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_real_dt.TabIndex = 46
        '
        'texto_real_dt
        '
        Me.texto_real_dt.AutoSize = True
        Me.texto_real_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_real_dt.Location = New System.Drawing.Point(544, 39)
        Me.texto_real_dt.Name = "texto_real_dt"
        Me.texto_real_dt.Size = New System.Drawing.Size(81, 13)
        Me.texto_real_dt.TabIndex = 47
        Me.texto_real_dt.Text = "Taxa real (%)"
        '
        'texto_inflacao_dt
        '
        Me.texto_inflacao_dt.AutoSize = True
        Me.texto_inflacao_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_inflacao_dt.Location = New System.Drawing.Point(544, 65)
        Me.texto_inflacao_dt.Name = "texto_inflacao_dt"
        Me.texto_inflacao_dt.Size = New System.Drawing.Size(123, 13)
        Me.texto_inflacao_dt.TabIndex = 49
        Me.texto_inflacao_dt.Text = "Taxa de infla��o (%)"
        '
        'caixatexto_inflacao_dt
        '
        Me.caixatexto_inflacao_dt.Location = New System.Drawing.Point(671, 58)
        Me.caixatexto_inflacao_dt.Name = "caixatexto_inflacao_dt"
        Me.caixatexto_inflacao_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_inflacao_dt.TabIndex = 48
        '
        'texto_acumulada_dt
        '
        Me.texto_acumulada_dt.AutoSize = True
        Me.texto_acumulada_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_acumulada_dt.Location = New System.Drawing.Point(544, 91)
        Me.texto_acumulada_dt.Name = "texto_acumulada_dt"
        Me.texto_acumulada_dt.Size = New System.Drawing.Size(121, 13)
        Me.texto_acumulada_dt.TabIndex = 51
        Me.texto_acumulada_dt.Text = "Taxa acumulada (%)"
        '
        'caixatexto_acumulada_dt
        '
        Me.caixatexto_acumulada_dt.Location = New System.Drawing.Point(671, 84)
        Me.caixatexto_acumulada_dt.Name = "caixatexto_acumulada_dt"
        Me.caixatexto_acumulada_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_acumulada_dt.TabIndex = 50
        '
        'rdo_taxa_real_dt
        '
        Me.rdo_taxa_real_dt.AutoSize = True
        Me.rdo_taxa_real_dt.Location = New System.Drawing.Point(6, 42)
        Me.rdo_taxa_real_dt.Name = "rdo_taxa_real_dt"
        Me.rdo_taxa_real_dt.Size = New System.Drawing.Size(69, 17)
        Me.rdo_taxa_real_dt.TabIndex = 41
        Me.rdo_taxa_real_dt.Text = "Taxa real"
        Me.rdo_taxa_real_dt.UseVisualStyleBackColor = True
        '
        'rdo_taxa_inflacao_dt
        '
        Me.rdo_taxa_inflacao_dt.AutoSize = True
        Me.rdo_taxa_inflacao_dt.Location = New System.Drawing.Point(6, 65)
        Me.rdo_taxa_inflacao_dt.Name = "rdo_taxa_inflacao_dt"
        Me.rdo_taxa_inflacao_dt.Size = New System.Drawing.Size(104, 17)
        Me.rdo_taxa_inflacao_dt.TabIndex = 55
        Me.rdo_taxa_inflacao_dt.Text = "Taxa de infla��o"
        Me.rdo_taxa_inflacao_dt.UseVisualStyleBackColor = True
        '
        'rdo_taxa_aparente_dt
        '
        Me.rdo_taxa_aparente_dt.AutoSize = True
        Me.rdo_taxa_aparente_dt.Checked = True
        Me.rdo_taxa_aparente_dt.Location = New System.Drawing.Point(6, 19)
        Me.rdo_taxa_aparente_dt.Name = "rdo_taxa_aparente_dt"
        Me.rdo_taxa_aparente_dt.Size = New System.Drawing.Size(94, 17)
        Me.rdo_taxa_aparente_dt.TabIndex = 57
        Me.rdo_taxa_aparente_dt.TabStop = True
        Me.rdo_taxa_aparente_dt.Text = "Taxa aparente"
        Me.rdo_taxa_aparente_dt.UseVisualStyleBackColor = True
        '
        'GrupoTaxaDT
        '
        Me.GrupoTaxaDT.Controls.Add(Me.rdo_taxa_acumulada_dt)
        Me.GrupoTaxaDT.Controls.Add(Me.rdo_taxa_aparente_dt)
        Me.GrupoTaxaDT.Controls.Add(Me.rdo_taxa_real_dt)
        Me.GrupoTaxaDT.Controls.Add(Me.rdo_taxa_inflacao_dt)
        Me.GrupoTaxaDT.Location = New System.Drawing.Point(187, 42)
        Me.GrupoTaxaDT.Name = "GrupoTaxaDT"
        Me.GrupoTaxaDT.Size = New System.Drawing.Size(134, 206)
        Me.GrupoTaxaDT.TabIndex = 58
        Me.GrupoTaxaDT.TabStop = False
        Me.GrupoTaxaDT.Text = "Taxa"
        '
        'rdo_taxa_acumulada_dt
        '
        Me.rdo_taxa_acumulada_dt.AutoSize = True
        Me.rdo_taxa_acumulada_dt.Location = New System.Drawing.Point(6, 88)
        Me.rdo_taxa_acumulada_dt.Name = "rdo_taxa_acumulada_dt"
        Me.rdo_taxa_acumulada_dt.Size = New System.Drawing.Size(104, 17)
        Me.rdo_taxa_acumulada_dt.TabIndex = 58
        Me.rdo_taxa_acumulada_dt.Text = "Taxa acumulada"
        Me.rdo_taxa_acumulada_dt.UseVisualStyleBackColor = True
        '
        'caixatexto_iof_dt
        '
        Me.caixatexto_iof_dt.Location = New System.Drawing.Point(438, 32)
        Me.caixatexto_iof_dt.Name = "caixatexto_iof_dt"
        Me.caixatexto_iof_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_iof_dt.TabIndex = 60
        '
        'texto_iof_dt
        '
        Me.texto_iof_dt.AutoSize = True
        Me.texto_iof_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_iof_dt.Location = New System.Drawing.Point(254, 39)
        Me.texto_iof_dt.Name = "texto_iof_dt"
        Me.texto_iof_dt.Size = New System.Drawing.Size(27, 13)
        Me.texto_iof_dt.TabIndex = 59
        Me.texto_iof_dt.Text = "IOF"
        '
        'texto_tarifa_dt
        '
        Me.texto_tarifa_dt.AutoSize = True
        Me.texto_tarifa_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tarifa_dt.Location = New System.Drawing.Point(254, 91)
        Me.texto_tarifa_dt.Name = "texto_tarifa_dt"
        Me.texto_tarifa_dt.Size = New System.Drawing.Size(40, 13)
        Me.texto_tarifa_dt.TabIndex = 62
        Me.texto_tarifa_dt.Text = "Tarifa"
        '
        'caixatexto_tarifa_dt
        '
        Me.caixatexto_tarifa_dt.Location = New System.Drawing.Point(438, 84)
        Me.caixatexto_tarifa_dt.Name = "caixatexto_tarifa_dt"
        Me.caixatexto_tarifa_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_tarifa_dt.TabIndex = 61
        '
        'caixatexto_tac_dt
        '
        Me.caixatexto_tac_dt.Location = New System.Drawing.Point(438, 110)
        Me.caixatexto_tac_dt.Name = "caixatexto_tac_dt"
        Me.caixatexto_tac_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_tac_dt.TabIndex = 64
        '
        'texto_tac_dt
        '
        Me.texto_tac_dt.AutoSize = True
        Me.texto_tac_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tac_dt.Location = New System.Drawing.Point(254, 117)
        Me.texto_tac_dt.Name = "texto_tac_dt"
        Me.texto_tac_dt.Size = New System.Drawing.Size(167, 13)
        Me.texto_tac_dt.TabIndex = 63
        Me.texto_tac_dt.Text = "Taxa de Abertura de Cr�dito"
        '
        'caixatexto_outros_encargos_dt
        '
        Me.caixatexto_outros_encargos_dt.Location = New System.Drawing.Point(438, 136)
        Me.caixatexto_outros_encargos_dt.Name = "caixatexto_outros_encargos_dt"
        Me.caixatexto_outros_encargos_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_outros_encargos_dt.TabIndex = 66
        '
        'texto_outros_encargos_dt
        '
        Me.texto_outros_encargos_dt.AutoSize = True
        Me.texto_outros_encargos_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_outros_encargos_dt.Location = New System.Drawing.Point(254, 143)
        Me.texto_outros_encargos_dt.Name = "texto_outros_encargos_dt"
        Me.texto_outros_encargos_dt.Size = New System.Drawing.Size(100, 13)
        Me.texto_outros_encargos_dt.TabIndex = 65
        Me.texto_outros_encargos_dt.Text = "Outros encargos"
        '
        'texto_taxa_iof_dt
        '
        Me.texto_taxa_iof_dt.AutoSize = True
        Me.texto_taxa_iof_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_taxa_iof_dt.Location = New System.Drawing.Point(254, 65)
        Me.texto_taxa_iof_dt.Name = "texto_taxa_iof_dt"
        Me.texto_taxa_iof_dt.Size = New System.Drawing.Size(98, 13)
        Me.texto_taxa_iof_dt.TabIndex = 68
        Me.texto_taxa_iof_dt.Text = "Taxa de IOF (%)"
        '
        'caixatexto_taxa_iof_dt
        '
        Me.caixatexto_taxa_iof_dt.Location = New System.Drawing.Point(438, 58)
        Me.caixatexto_taxa_iof_dt.Name = "caixatexto_taxa_iof_dt"
        Me.caixatexto_taxa_iof_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_taxa_iof_dt.TabIndex = 67
        '
        'GrupoDTeTaxa
        '
        Me.GrupoDTeTaxa.Controls.Add(Me.btn_limpar_taxas_dt)
        Me.GrupoDTeTaxa.Controls.Add(Me.btn_adicionar_taxas_dt)
        Me.GrupoDTeTaxa.Controls.Add(Me.lista_rentabilidade_dt)
        Me.GrupoDTeTaxa.Controls.Add(Me.caixatexto_taxa_administracao_dt)
        Me.GrupoDTeTaxa.Controls.Add(Me.texto_taxa_administracao_dt)
        Me.GrupoDTeTaxa.Controls.Add(Me.rdo_taxa_ari_dt)
        Me.GrupoDTeTaxa.Controls.Add(Me.rdo_dt_dt)
        Me.GrupoDTeTaxa.Controls.Add(Me.GroupBox1)
        Me.GrupoDTeTaxa.Controls.Add(Me.GrupoTaxaDT)
        Me.GrupoDTeTaxa.Controls.Add(Me.btn_calcular_dt)
        Me.GrupoDTeTaxa.Location = New System.Drawing.Point(15, 162)
        Me.GrupoDTeTaxa.Name = "GrupoDTeTaxa"
        Me.GrupoDTeTaxa.Size = New System.Drawing.Size(327, 383)
        Me.GrupoDTeTaxa.TabIndex = 69
        Me.GrupoDTeTaxa.TabStop = False
        '
        'btn_limpar_taxas_dt
        '
        Me.btn_limpar_taxas_dt.Location = New System.Drawing.Point(26, 344)
        Me.btn_limpar_taxas_dt.Name = "btn_limpar_taxas_dt"
        Me.btn_limpar_taxas_dt.Size = New System.Drawing.Size(134, 23)
        Me.btn_limpar_taxas_dt.TabIndex = 75
        Me.btn_limpar_taxas_dt.Text = "Limpar tabela"
        Me.btn_limpar_taxas_dt.UseVisualStyleBackColor = True
        '
        'btn_adicionar_taxas_dt
        '
        Me.btn_adicionar_taxas_dt.Location = New System.Drawing.Point(187, 344)
        Me.btn_adicionar_taxas_dt.Name = "btn_adicionar_taxas_dt"
        Me.btn_adicionar_taxas_dt.Size = New System.Drawing.Size(134, 23)
        Me.btn_adicionar_taxas_dt.TabIndex = 74
        Me.btn_adicionar_taxas_dt.Text = "Adicionar taxas"
        Me.btn_adicionar_taxas_dt.UseVisualStyleBackColor = True
        '
        'lista_rentabilidade_dt
        '
        Me.lista_rentabilidade_dt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Coluna_rentabilidade_dt})
        Me.lista_rentabilidade_dt.GridLines = True
        Me.lista_rentabilidade_dt.Location = New System.Drawing.Point(187, 254)
        Me.lista_rentabilidade_dt.Name = "lista_rentabilidade_dt"
        Me.lista_rentabilidade_dt.Size = New System.Drawing.Size(134, 75)
        Me.lista_rentabilidade_dt.TabIndex = 73
        Me.lista_rentabilidade_dt.UseCompatibleStateImageBehavior = False
        Me.lista_rentabilidade_dt.View = System.Windows.Forms.View.Details
        '
        'Coluna_rentabilidade_dt
        '
        Me.Coluna_rentabilidade_dt.Text = "Rentabilidade"
        Me.Coluna_rentabilidade_dt.Width = 107
        '
        'caixatexto_taxa_administracao_dt
        '
        Me.caixatexto_taxa_administracao_dt.Location = New System.Drawing.Point(45, 280)
        Me.caixatexto_taxa_administracao_dt.Name = "caixatexto_taxa_administracao_dt"
        Me.caixatexto_taxa_administracao_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_taxa_administracao_dt.TabIndex = 73
        '
        'texto_taxa_administracao_dt
        '
        Me.texto_taxa_administracao_dt.AutoSize = True
        Me.texto_taxa_administracao_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_taxa_administracao_dt.Location = New System.Drawing.Point(26, 264)
        Me.texto_taxa_administracao_dt.Name = "texto_taxa_administracao_dt"
        Me.texto_taxa_administracao_dt.Size = New System.Drawing.Size(136, 13)
        Me.texto_taxa_administracao_dt.TabIndex = 73
        Me.texto_taxa_administracao_dt.Text = "Taxa de Administra��o"
        '
        'rdo_taxa_ari_dt
        '
        Me.rdo_taxa_ari_dt.AutoSize = True
        Me.rdo_taxa_ari_dt.Location = New System.Drawing.Point(139, 19)
        Me.rdo_taxa_ari_dt.Name = "rdo_taxa_ari_dt"
        Me.rdo_taxa_ari_dt.Size = New System.Drawing.Size(49, 17)
        Me.rdo_taxa_ari_dt.TabIndex = 42
        Me.rdo_taxa_ari_dt.Text = "Taxa"
        Me.rdo_taxa_ari_dt.UseVisualStyleBackColor = True
        '
        'rdo_dt_dt
        '
        Me.rdo_dt_dt.AutoSize = True
        Me.rdo_dt_dt.Checked = True
        Me.rdo_dt_dt.Location = New System.Drawing.Point(6, 19)
        Me.rdo_dt_dt.Name = "rdo_dt_dt"
        Me.rdo_dt_dt.Size = New System.Drawing.Size(127, 17)
        Me.rdo_dt_dt.TabIndex = 42
        Me.rdo_dt_dt.TabStop = True
        Me.rdo_dt_dt.Text = "Descontos de T�tulos"
        Me.rdo_dt_dt.UseVisualStyleBackColor = True
        '
        'caixatexto_custo_efetivo_dt
        '
        Me.caixatexto_custo_efetivo_dt.Location = New System.Drawing.Point(438, 6)
        Me.caixatexto_custo_efetivo_dt.Name = "caixatexto_custo_efetivo_dt"
        Me.caixatexto_custo_efetivo_dt.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_custo_efetivo_dt.TabIndex = 71
        '
        'texto_custo_efetivo_dt
        '
        Me.texto_custo_efetivo_dt.AutoSize = True
        Me.texto_custo_efetivo_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_custo_efetivo_dt.Location = New System.Drawing.Point(254, 13)
        Me.texto_custo_efetivo_dt.Name = "texto_custo_efetivo_dt"
        Me.texto_custo_efetivo_dt.Size = New System.Drawing.Size(178, 13)
        Me.texto_custo_efetivo_dt.TabIndex = 70
        Me.texto_custo_efetivo_dt.Text = "Custo efetivo da opera��o (%)"
        '
        'RichTextBox_leitura_dt
        '
        Me.RichTextBox_leitura_dt.Location = New System.Drawing.Point(380, 162)
        Me.RichTextBox_leitura_dt.Name = "RichTextBox_leitura_dt"
        Me.RichTextBox_leitura_dt.Size = New System.Drawing.Size(391, 383)
        Me.RichTextBox_leitura_dt.TabIndex = 72
        Me.RichTextBox_leitura_dt.Text = resources.GetString("RichTextBox_leitura_dt.Text")
        '
        'form_descontos_titulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 557)
        Me.Controls.Add(Me.RichTextBox_leitura_dt)
        Me.Controls.Add(Me.caixatexto_custo_efetivo_dt)
        Me.Controls.Add(Me.texto_custo_efetivo_dt)
        Me.Controls.Add(Me.GrupoDTeTaxa)
        Me.Controls.Add(Me.texto_taxa_iof_dt)
        Me.Controls.Add(Me.caixatexto_taxa_iof_dt)
        Me.Controls.Add(Me.caixatexto_outros_encargos_dt)
        Me.Controls.Add(Me.texto_outros_encargos_dt)
        Me.Controls.Add(Me.caixatexto_tac_dt)
        Me.Controls.Add(Me.texto_tac_dt)
        Me.Controls.Add(Me.texto_tarifa_dt)
        Me.Controls.Add(Me.caixatexto_tarifa_dt)
        Me.Controls.Add(Me.caixatexto_iof_dt)
        Me.Controls.Add(Me.texto_iof_dt)
        Me.Controls.Add(Me.texto_acumulada_dt)
        Me.Controls.Add(Me.caixatexto_acumulada_dt)
        Me.Controls.Add(Me.texto_inflacao_dt)
        Me.Controls.Add(Me.caixatexto_inflacao_dt)
        Me.Controls.Add(Me.texto_real_dt)
        Me.Controls.Add(Me.caixatexto_real_dt)
        Me.Controls.Add(Me.caixatexto_aparente_dt)
        Me.Controls.Add(Me.texto_aparente_dt)
        Me.Controls.Add(Me.texto_vd_sem_encargos_dt)
        Me.Controls.Add(Me.caixatexto_vd_sem_encargos_dt)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_descontos_titulos"
        Me.Text = "Desconto de T�tulos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrupoTaxaDT.ResumeLayout(False)
        Me.GrupoTaxaDT.PerformLayout()
        Me.GrupoDTeTaxa.ResumeLayout(False)
        Me.GrupoDTeTaxa.PerformLayout()
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
    Friend WithEvents btn_calcular_dt As System.Windows.Forms.Button
    Friend WithEvents texto_vd_sem_encargos_dt As System.Windows.Forms.Label
    Friend WithEvents caixatexto_vd_sem_encargos_dt As System.Windows.Forms.TextBox
    Friend WithEvents rdo_vt_dt As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_taxa_dt As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_tempo_dt As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_desconto_dt As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_vd_dt As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sem_encargos_dt As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents texto_aparente_dt As System.Windows.Forms.Label
    Friend WithEvents caixatexto_aparente_dt As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_real_dt As System.Windows.Forms.TextBox
    Friend WithEvents texto_real_dt As System.Windows.Forms.Label
    Friend WithEvents texto_inflacao_dt As System.Windows.Forms.Label
    Friend WithEvents caixatexto_inflacao_dt As System.Windows.Forms.TextBox
    Friend WithEvents texto_acumulada_dt As System.Windows.Forms.Label
    Friend WithEvents caixatexto_acumulada_dt As System.Windows.Forms.TextBox
    Friend WithEvents rdo_taxa_real_dt As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_taxa_inflacao_dt As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_taxa_aparente_dt As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoTaxaDT As System.Windows.Forms.GroupBox
    Friend WithEvents caixatexto_iof_dt As System.Windows.Forms.TextBox
    Friend WithEvents texto_iof_dt As System.Windows.Forms.Label
    Friend WithEvents rdo_iof_dt As System.Windows.Forms.RadioButton
    Friend WithEvents texto_tarifa_dt As System.Windows.Forms.Label
    Friend WithEvents caixatexto_tarifa_dt As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_tac_dt As System.Windows.Forms.TextBox
    Friend WithEvents texto_tac_dt As System.Windows.Forms.Label
    Friend WithEvents caixatexto_outros_encargos_dt As System.Windows.Forms.TextBox
    Friend WithEvents texto_outros_encargos_dt As System.Windows.Forms.Label
    Friend WithEvents texto_taxa_iof_dt As System.Windows.Forms.Label
    Friend WithEvents caixatexto_taxa_iof_dt As System.Windows.Forms.TextBox
    Friend WithEvents GrupoDTeTaxa As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_taxa_ari_dt As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_dt_dt As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_custo_efetivo_dt As System.Windows.Forms.RadioButton
    Friend WithEvents caixatexto_custo_efetivo_dt As System.Windows.Forms.TextBox
    Friend WithEvents texto_custo_efetivo_dt As System.Windows.Forms.Label
    Friend WithEvents RichTextBox_leitura_dt As System.Windows.Forms.RichTextBox
    Friend WithEvents caixatexto_taxa_administracao_dt As System.Windows.Forms.TextBox
    Friend WithEvents texto_taxa_administracao_dt As System.Windows.Forms.Label
    Friend WithEvents lista_rentabilidade_dt As System.Windows.Forms.ListView
    Friend WithEvents rdo_taxa_acumulada_dt As System.Windows.Forms.RadioButton
    Friend WithEvents Coluna_rentabilidade_dt As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_limpar_taxas_dt As System.Windows.Forms.Button
    Friend WithEvents btn_adicionar_taxas_dt As System.Windows.Forms.Button
End Class
