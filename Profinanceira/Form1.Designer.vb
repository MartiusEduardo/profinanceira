<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_calculos_financeiros
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_calculos_financeiros))
        Me.texto_vp_cfin = New System.Windows.Forms.Label
        Me.texto_taxa_cfin = New System.Windows.Forms.Label
        Me.texto_tempo_cfin = New System.Windows.Forms.Label
        Me.texto_vf_cfin = New System.Windows.Forms.Label
        Me.texto_pmt_cfin = New System.Windows.Forms.Label
        Me.caixatexto_vp_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_taxa_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_tempo_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_pmt_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_vf_cfin = New System.Windows.Forms.TextBox
        Me.btn_calcular_vp_cfin = New System.Windows.Forms.Button
        Me.btn_calcular_juros_simples_cfin = New System.Windows.Forms.Button
        Me.btn_calcular_juros_composto_cfin = New System.Windows.Forms.Button
        Me.btn_calcular_tempo_cfin = New System.Windows.Forms.Button
        Me.btn_calcular_pmt_cfin = New System.Windows.Forms.Button
        Me.btn_calcular_vf_cfin = New System.Windows.Forms.Button
        Me.texto_eq_taxa_cfin = New System.Windows.Forms.Label
        Me.caixatexto_eq_taxa_cfin = New System.Windows.Forms.TextBox
        Me.texto_eq_i_cfin = New System.Windows.Forms.Label
        Me.caixatexto_eq_i_cfin = New System.Windows.Forms.TextBox
        Me.btn_calcular_eq_taxa_cfin = New System.Windows.Forms.Button
        Me.GrupoTaxaCalculosFinanceiros = New System.Windows.Forms.GroupBox
        Me.rdo_trimestre_taxa_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_bimestre_taxa_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_mes_taxa_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_semestre_taxa_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_ano_taxa_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_dia_taxa_cfin = New System.Windows.Forms.RadioButton
        Me.GrupoTempoCalculosFinanceiros = New System.Windows.Forms.GroupBox
        Me.rdo_trimestre_tempo_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_bimestre_tempo_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_mes_tempo_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_semestre_tempo_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_ano_tempo_cfin = New System.Windows.Forms.RadioButton
        Me.rdo_dia_tempo_cfin = New System.Windows.Forms.RadioButton
        Me.texto_decimais_cfin = New System.Windows.Forms.Label
        Me.caixacombo_casas_decimais_cfin = New System.Windows.Forms.ComboBox
        Me.caixatexto_juros_simples_cfin = New System.Windows.Forms.TextBox
        Me.texto_juros_simples_cfin = New System.Windows.Forms.Label
        Me.btn_calcular_vf_simples_cfin = New System.Windows.Forms.Button
        Me.btn_calcular_tempo_simples_cfin = New System.Windows.Forms.Button
        Me.btn_calcular_vp_simples_cfin = New System.Windows.Forms.Button
        Me.caixatexto_vf_simples_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_tempo_simples_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_vp_simples_cfin = New System.Windows.Forms.TextBox
        Me.texto_vf_simples_cfin = New System.Windows.Forms.Label
        Me.texto_tempo_simples_cfin = New System.Windows.Forms.Label
        Me.texto_vp_simples_cfin = New System.Windows.Forms.Label
        Me.GrupoJurosCompostos = New System.Windows.Forms.GroupBox
        Me.GrupoJurosSimples = New System.Windows.Forms.GroupBox
        Me.btn_calcular_montante_juros_cfin = New System.Windows.Forms.Button
        Me.texto_montante_juros_cfin = New System.Windows.Forms.Label
        Me.caixatexto_montante_juros_cfin = New System.Windows.Forms.TextBox
        Me.GrupoEqJurosCompostos = New System.Windows.Forms.GroupBox
        Me.btn_transformar_percentual = New System.Windows.Forms.Button
        Me.caixatexto_transformar_percentual = New System.Windows.Forms.TextBox
        Me.texto_transformar_percentual = New System.Windows.Forms.Label
        Me.GrupoEqJurosSimples = New System.Windows.Forms.GroupBox
        Me.btn_transformar_percentual_simples = New System.Windows.Forms.Button
        Me.caixatexto_transformar_percentual_simples = New System.Windows.Forms.TextBox
        Me.texto_transformar_percentual_simples = New System.Windows.Forms.Label
        Me.caixacombo_casas_decimais_simples_cfin = New System.Windows.Forms.ComboBox
        Me.texto_casas_decimais_simples_cfin = New System.Windows.Forms.Label
        Me.btn_calcular_taxa_simples_cfin = New System.Windows.Forms.Button
        Me.caixatexto_eq_i_simples_cfin = New System.Windows.Forms.TextBox
        Me.texto_eq_i_simples_cfin = New System.Windows.Forms.Label
        Me.caixatexto_eq_taxa_simples_cfin = New System.Windows.Forms.TextBox
        Me.texto_eq_taxa_simples_cfin = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_calcular_ano_bissexto = New System.Windows.Forms.Button
        Me.caixacombo_exatos_i_ecb_cfin = New System.Windows.Forms.ComboBox
        Me.texto_casas_decimais_ecb_cfin = New System.Windows.Forms.Label
        Me.btn_exatos_n_ecb_cfin = New System.Windows.Forms.Button
        Me.caixatexto_exatos_i_ecb_cfin = New System.Windows.Forms.TextBox
        Me.texto_bancarios_ecb_cfin = New System.Windows.Forms.Label
        Me.texto_comercial_ecb_cfin = New System.Windows.Forms.Label
        Me.texto_exatos_ecb_cfin = New System.Windows.Forms.Label
        Me.texto_n_ecb_cfin = New System.Windows.Forms.Label
        Me.texto_juros_ecb_cfin = New System.Windows.Forms.Label
        Me.texto_i_ecb_cfin = New System.Windows.Forms.Label
        Me.caixatexto_comercial_i_ecb_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_comercial_n_ecb_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_bancarios_i_ecb_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_bancarios_n_ecb_cfin = New System.Windows.Forms.TextBox
        Me.caixatexto_exatos_n_ecb_cfin = New System.Windows.Forms.TextBox
        Me.btn_exatos_i_ecb_cfin = New System.Windows.Forms.Button
        Me.btn_comercial_i_ecb_cfin = New System.Windows.Forms.Button
        Me.btn_bancarios_i_ecb_cfin = New System.Windows.Forms.Button
        Me.btn_comercial_n_ecb_cfin = New System.Windows.Forms.Button
        Me.btn_bancarios_n_ecb_cfin = New System.Windows.Forms.Button
        Me.btn_limpar_ecb_cfin = New System.Windows.Forms.Button
        Me.caixacombo_comercial_i_ecb_cfin = New System.Windows.Forms.ComboBox
        Me.caixacombo_bancarios_i_ecb_cfin = New System.Windows.Forms.ComboBox
        Me.caixatexto_inserir_i_ecb_cfin = New System.Windows.Forms.TextBox
        Me.texto_inserir_i_ecb_cfin = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GrupoJurosECB = New System.Windows.Forms.GroupBox
        Me.data_ate = New System.Windows.Forms.DateTimePicker
        Me.data_de = New System.Windows.Forms.DateTimePicker
        Me.checkbox_ano_bissexto_ecb_cfin = New System.Windows.Forms.CheckBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Coluna_data = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Coluna_tipo = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Coluna_entrada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Coluna_saldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Coluna_juros = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Coluna_n = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GrupoConvercaoTaxa = New System.Windows.Forms.GroupBox
        Me.ToolTipCfin = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrupoTaxaCalculosFinanceiros.SuspendLayout()
        Me.GrupoTempoCalculosFinanceiros.SuspendLayout()
        Me.GrupoJurosCompostos.SuspendLayout()
        Me.GrupoJurosSimples.SuspendLayout()
        Me.GrupoEqJurosCompostos.SuspendLayout()
        Me.GrupoEqJurosSimples.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GrupoJurosECB.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoConvercaoTaxa.SuspendLayout()
        Me.SuspendLayout()
        '
        'texto_vp_cfin
        '
        Me.texto_vp_cfin.AutoSize = True
        Me.texto_vp_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vp_cfin.Location = New System.Drawing.Point(6, 16)
        Me.texto_vp_cfin.Name = "texto_vp_cfin"
        Me.texto_vp_cfin.Size = New System.Drawing.Size(90, 13)
        Me.texto_vp_cfin.TabIndex = 0
        Me.texto_vp_cfin.Text = "Valor Presente"
        '
        'texto_taxa_cfin
        '
        Me.texto_taxa_cfin.AutoSize = True
        Me.texto_taxa_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_taxa_cfin.Location = New System.Drawing.Point(6, 49)
        Me.texto_taxa_cfin.Name = "texto_taxa_cfin"
        Me.texto_taxa_cfin.Size = New System.Drawing.Size(35, 13)
        Me.texto_taxa_cfin.TabIndex = 1
        Me.texto_taxa_cfin.Text = "Taxa"
        '
        'texto_tempo_cfin
        '
        Me.texto_tempo_cfin.AutoSize = True
        Me.texto_tempo_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tempo_cfin.Location = New System.Drawing.Point(6, 81)
        Me.texto_tempo_cfin.Name = "texto_tempo_cfin"
        Me.texto_tempo_cfin.Size = New System.Drawing.Size(75, 13)
        Me.texto_tempo_cfin.TabIndex = 2
        Me.texto_tempo_cfin.Text = "Parcelas (n)"
        '
        'texto_vf_cfin
        '
        Me.texto_vf_cfin.AutoSize = True
        Me.texto_vf_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vf_cfin.Location = New System.Drawing.Point(6, 151)
        Me.texto_vf_cfin.Name = "texto_vf_cfin"
        Me.texto_vf_cfin.Size = New System.Drawing.Size(76, 13)
        Me.texto_vf_cfin.TabIndex = 3
        Me.texto_vf_cfin.Text = "Valor Futuro"
        '
        'texto_pmt_cfin
        '
        Me.texto_pmt_cfin.AutoSize = True
        Me.texto_pmt_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_pmt_cfin.Location = New System.Drawing.Point(6, 115)
        Me.texto_pmt_cfin.Name = "texto_pmt_cfin"
        Me.texto_pmt_cfin.Size = New System.Drawing.Size(33, 13)
        Me.texto_pmt_cfin.TabIndex = 4
        Me.texto_pmt_cfin.Text = "PMT"
        '
        'caixatexto_vp_cfin
        '
        Me.caixatexto_vp_cfin.Location = New System.Drawing.Point(102, 13)
        Me.caixatexto_vp_cfin.Name = "caixatexto_vp_cfin"
        Me.caixatexto_vp_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vp_cfin.TabIndex = 5
        '
        'caixatexto_taxa_cfin
        '
        Me.caixatexto_taxa_cfin.Location = New System.Drawing.Point(102, 46)
        Me.caixatexto_taxa_cfin.Name = "caixatexto_taxa_cfin"
        Me.caixatexto_taxa_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_taxa_cfin.TabIndex = 6
        '
        'caixatexto_tempo_cfin
        '
        Me.caixatexto_tempo_cfin.Location = New System.Drawing.Point(102, 78)
        Me.caixatexto_tempo_cfin.Name = "caixatexto_tempo_cfin"
        Me.caixatexto_tempo_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_tempo_cfin.TabIndex = 7
        '
        'caixatexto_pmt_cfin
        '
        Me.caixatexto_pmt_cfin.Location = New System.Drawing.Point(102, 112)
        Me.caixatexto_pmt_cfin.Name = "caixatexto_pmt_cfin"
        Me.caixatexto_pmt_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_pmt_cfin.TabIndex = 8
        '
        'caixatexto_vf_cfin
        '
        Me.caixatexto_vf_cfin.Location = New System.Drawing.Point(102, 148)
        Me.caixatexto_vf_cfin.Name = "caixatexto_vf_cfin"
        Me.caixatexto_vf_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vf_cfin.TabIndex = 9
        '
        'btn_calcular_vp_cfin
        '
        Me.btn_calcular_vp_cfin.Location = New System.Drawing.Point(228, 11)
        Me.btn_calcular_vp_cfin.Name = "btn_calcular_vp_cfin"
        Me.btn_calcular_vp_cfin.Size = New System.Drawing.Size(137, 23)
        Me.btn_calcular_vp_cfin.TabIndex = 10
        Me.btn_calcular_vp_cfin.Text = "Calcular Valor Presente"
        Me.btn_calcular_vp_cfin.UseVisualStyleBackColor = True
        '
        'btn_calcular_juros_simples_cfin
        '
        Me.btn_calcular_juros_simples_cfin.Location = New System.Drawing.Point(250, 42)
        Me.btn_calcular_juros_simples_cfin.Name = "btn_calcular_juros_simples_cfin"
        Me.btn_calcular_juros_simples_cfin.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_juros_simples_cfin.TabIndex = 11
        Me.btn_calcular_juros_simples_cfin.Text = "Calcular Juros Simples"
        Me.btn_calcular_juros_simples_cfin.UseVisualStyleBackColor = True
        '
        'btn_calcular_juros_composto_cfin
        '
        Me.btn_calcular_juros_composto_cfin.Location = New System.Drawing.Point(228, 44)
        Me.btn_calcular_juros_composto_cfin.Name = "btn_calcular_juros_composto_cfin"
        Me.btn_calcular_juros_composto_cfin.Size = New System.Drawing.Size(137, 23)
        Me.btn_calcular_juros_composto_cfin.TabIndex = 12
        Me.btn_calcular_juros_composto_cfin.Text = "Calcular Juros Compostos"
        Me.btn_calcular_juros_composto_cfin.UseVisualStyleBackColor = True
        '
        'btn_calcular_tempo_cfin
        '
        Me.btn_calcular_tempo_cfin.Location = New System.Drawing.Point(228, 76)
        Me.btn_calcular_tempo_cfin.Name = "btn_calcular_tempo_cfin"
        Me.btn_calcular_tempo_cfin.Size = New System.Drawing.Size(137, 23)
        Me.btn_calcular_tempo_cfin.TabIndex = 13
        Me.btn_calcular_tempo_cfin.Text = "Calcular Parcelas"
        Me.btn_calcular_tempo_cfin.UseVisualStyleBackColor = True
        '
        'btn_calcular_pmt_cfin
        '
        Me.btn_calcular_pmt_cfin.Location = New System.Drawing.Point(228, 110)
        Me.btn_calcular_pmt_cfin.Name = "btn_calcular_pmt_cfin"
        Me.btn_calcular_pmt_cfin.Size = New System.Drawing.Size(137, 23)
        Me.btn_calcular_pmt_cfin.TabIndex = 14
        Me.btn_calcular_pmt_cfin.Text = "Calcular PMT"
        Me.btn_calcular_pmt_cfin.UseVisualStyleBackColor = True
        '
        'btn_calcular_vf_cfin
        '
        Me.btn_calcular_vf_cfin.Location = New System.Drawing.Point(228, 146)
        Me.btn_calcular_vf_cfin.Name = "btn_calcular_vf_cfin"
        Me.btn_calcular_vf_cfin.Size = New System.Drawing.Size(137, 23)
        Me.btn_calcular_vf_cfin.TabIndex = 15
        Me.btn_calcular_vf_cfin.Text = "Calcular Valor Futuro"
        Me.btn_calcular_vf_cfin.UseVisualStyleBackColor = True
        '
        'texto_eq_taxa_cfin
        '
        Me.texto_eq_taxa_cfin.AutoSize = True
        Me.texto_eq_taxa_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_eq_taxa_cfin.Location = New System.Drawing.Point(6, 44)
        Me.texto_eq_taxa_cfin.Name = "texto_eq_taxa_cfin"
        Me.texto_eq_taxa_cfin.Size = New System.Drawing.Size(126, 13)
        Me.texto_eq_taxa_cfin.TabIndex = 16
        Me.texto_eq_taxa_cfin.Text = "Equivalência de taxa"
        '
        'caixatexto_eq_taxa_cfin
        '
        Me.caixatexto_eq_taxa_cfin.Location = New System.Drawing.Point(138, 41)
        Me.caixatexto_eq_taxa_cfin.Name = "caixatexto_eq_taxa_cfin"
        Me.caixatexto_eq_taxa_cfin.ReadOnly = True
        Me.caixatexto_eq_taxa_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_eq_taxa_cfin.TabIndex = 17
        Me.caixatexto_eq_taxa_cfin.Text = "0"
        '
        'texto_eq_i_cfin
        '
        Me.texto_eq_i_cfin.AutoSize = True
        Me.texto_eq_i_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_eq_i_cfin.Location = New System.Drawing.Point(6, 16)
        Me.texto_eq_i_cfin.Name = "texto_eq_i_cfin"
        Me.texto_eq_i_cfin.Size = New System.Drawing.Size(10, 13)
        Me.texto_eq_i_cfin.TabIndex = 18
        Me.texto_eq_i_cfin.Text = "i"
        '
        'caixatexto_eq_i_cfin
        '
        Me.caixatexto_eq_i_cfin.Location = New System.Drawing.Point(22, 13)
        Me.caixatexto_eq_i_cfin.Name = "caixatexto_eq_i_cfin"
        Me.caixatexto_eq_i_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_eq_i_cfin.TabIndex = 20
        '
        'btn_calcular_eq_taxa_cfin
        '
        Me.btn_calcular_eq_taxa_cfin.Enabled = False
        Me.btn_calcular_eq_taxa_cfin.Location = New System.Drawing.Point(258, 39)
        Me.btn_calcular_eq_taxa_cfin.Name = "btn_calcular_eq_taxa_cfin"
        Me.btn_calcular_eq_taxa_cfin.Size = New System.Drawing.Size(159, 23)
        Me.btn_calcular_eq_taxa_cfin.TabIndex = 22
        Me.btn_calcular_eq_taxa_cfin.Text = "Calcular Equivalência de Taxa"
        Me.btn_calcular_eq_taxa_cfin.UseVisualStyleBackColor = True
        '
        'GrupoTaxaCalculosFinanceiros
        '
        Me.GrupoTaxaCalculosFinanceiros.Controls.Add(Me.rdo_trimestre_taxa_cfin)
        Me.GrupoTaxaCalculosFinanceiros.Controls.Add(Me.rdo_bimestre_taxa_cfin)
        Me.GrupoTaxaCalculosFinanceiros.Controls.Add(Me.rdo_mes_taxa_cfin)
        Me.GrupoTaxaCalculosFinanceiros.Controls.Add(Me.rdo_semestre_taxa_cfin)
        Me.GrupoTaxaCalculosFinanceiros.Controls.Add(Me.rdo_ano_taxa_cfin)
        Me.GrupoTaxaCalculosFinanceiros.Controls.Add(Me.rdo_dia_taxa_cfin)
        Me.GrupoTaxaCalculosFinanceiros.Location = New System.Drawing.Point(6, 19)
        Me.GrupoTaxaCalculosFinanceiros.Name = "GrupoTaxaCalculosFinanceiros"
        Me.GrupoTaxaCalculosFinanceiros.Size = New System.Drawing.Size(417, 40)
        Me.GrupoTaxaCalculosFinanceiros.TabIndex = 23
        Me.GrupoTaxaCalculosFinanceiros.TabStop = False
        Me.GrupoTaxaCalculosFinanceiros.Text = "Taxa"
        '
        'rdo_trimestre_taxa_cfin
        '
        Me.rdo_trimestre_taxa_cfin.AutoSize = True
        Me.rdo_trimestre_taxa_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_trimestre_taxa_cfin.Location = New System.Drawing.Point(209, 18)
        Me.rdo_trimestre_taxa_cfin.Name = "rdo_trimestre_taxa_cfin"
        Me.rdo_trimestre_taxa_cfin.Size = New System.Drawing.Size(70, 17)
        Me.rdo_trimestre_taxa_cfin.TabIndex = 48
        Me.rdo_trimestre_taxa_cfin.Text = "Trimestral"
        Me.rdo_trimestre_taxa_cfin.UseVisualStyleBackColor = True
        '
        'rdo_bimestre_taxa_cfin
        '
        Me.rdo_bimestre_taxa_cfin.AutoSize = True
        Me.rdo_bimestre_taxa_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_bimestre_taxa_cfin.Location = New System.Drawing.Point(136, 18)
        Me.rdo_bimestre_taxa_cfin.Name = "rdo_bimestre_taxa_cfin"
        Me.rdo_bimestre_taxa_cfin.Size = New System.Drawing.Size(67, 17)
        Me.rdo_bimestre_taxa_cfin.TabIndex = 10
        Me.rdo_bimestre_taxa_cfin.Text = "Bimestral"
        Me.rdo_bimestre_taxa_cfin.UseVisualStyleBackColor = True
        '
        'rdo_mes_taxa_cfin
        '
        Me.rdo_mes_taxa_cfin.AutoSize = True
        Me.rdo_mes_taxa_cfin.Checked = True
        Me.rdo_mes_taxa_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_mes_taxa_cfin.Location = New System.Drawing.Point(71, 18)
        Me.rdo_mes_taxa_cfin.Name = "rdo_mes_taxa_cfin"
        Me.rdo_mes_taxa_cfin.Size = New System.Drawing.Size(59, 17)
        Me.rdo_mes_taxa_cfin.TabIndex = 9
        Me.rdo_mes_taxa_cfin.TabStop = True
        Me.rdo_mes_taxa_cfin.Text = "Mensal"
        Me.rdo_mes_taxa_cfin.UseVisualStyleBackColor = True
        '
        'rdo_semestre_taxa_cfin
        '
        Me.rdo_semestre_taxa_cfin.AutoSize = True
        Me.rdo_semestre_taxa_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_semestre_taxa_cfin.Location = New System.Drawing.Point(285, 18)
        Me.rdo_semestre_taxa_cfin.Name = "rdo_semestre_taxa_cfin"
        Me.rdo_semestre_taxa_cfin.Size = New System.Drawing.Size(71, 17)
        Me.rdo_semestre_taxa_cfin.TabIndex = 8
        Me.rdo_semestre_taxa_cfin.Text = "Semestral"
        Me.rdo_semestre_taxa_cfin.UseVisualStyleBackColor = True
        '
        'rdo_ano_taxa_cfin
        '
        Me.rdo_ano_taxa_cfin.AutoSize = True
        Me.rdo_ano_taxa_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_ano_taxa_cfin.Location = New System.Drawing.Point(362, 18)
        Me.rdo_ano_taxa_cfin.Name = "rdo_ano_taxa_cfin"
        Me.rdo_ano_taxa_cfin.Size = New System.Drawing.Size(52, 17)
        Me.rdo_ano_taxa_cfin.TabIndex = 7
        Me.rdo_ano_taxa_cfin.Text = "Anual"
        Me.rdo_ano_taxa_cfin.UseVisualStyleBackColor = True
        '
        'rdo_dia_taxa_cfin
        '
        Me.rdo_dia_taxa_cfin.AutoSize = True
        Me.rdo_dia_taxa_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_dia_taxa_cfin.Location = New System.Drawing.Point(13, 18)
        Me.rdo_dia_taxa_cfin.Name = "rdo_dia_taxa_cfin"
        Me.rdo_dia_taxa_cfin.Size = New System.Drawing.Size(52, 17)
        Me.rdo_dia_taxa_cfin.TabIndex = 6
        Me.rdo_dia_taxa_cfin.Text = "Diária"
        Me.rdo_dia_taxa_cfin.UseVisualStyleBackColor = True
        '
        'GrupoTempoCalculosFinanceiros
        '
        Me.GrupoTempoCalculosFinanceiros.Controls.Add(Me.rdo_trimestre_tempo_cfin)
        Me.GrupoTempoCalculosFinanceiros.Controls.Add(Me.rdo_bimestre_tempo_cfin)
        Me.GrupoTempoCalculosFinanceiros.Controls.Add(Me.rdo_mes_tempo_cfin)
        Me.GrupoTempoCalculosFinanceiros.Controls.Add(Me.rdo_semestre_tempo_cfin)
        Me.GrupoTempoCalculosFinanceiros.Controls.Add(Me.rdo_ano_tempo_cfin)
        Me.GrupoTempoCalculosFinanceiros.Controls.Add(Me.rdo_dia_tempo_cfin)
        Me.GrupoTempoCalculosFinanceiros.Location = New System.Drawing.Point(6, 65)
        Me.GrupoTempoCalculosFinanceiros.Name = "GrupoTempoCalculosFinanceiros"
        Me.GrupoTempoCalculosFinanceiros.Size = New System.Drawing.Size(417, 40)
        Me.GrupoTempoCalculosFinanceiros.TabIndex = 24
        Me.GrupoTempoCalculosFinanceiros.TabStop = False
        Me.GrupoTempoCalculosFinanceiros.Text = "Parcelas"
        '
        'rdo_trimestre_tempo_cfin
        '
        Me.rdo_trimestre_tempo_cfin.AutoSize = True
        Me.rdo_trimestre_tempo_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_trimestre_tempo_cfin.Location = New System.Drawing.Point(208, 17)
        Me.rdo_trimestre_tempo_cfin.Name = "rdo_trimestre_tempo_cfin"
        Me.rdo_trimestre_tempo_cfin.Size = New System.Drawing.Size(70, 17)
        Me.rdo_trimestre_tempo_cfin.TabIndex = 48
        Me.rdo_trimestre_tempo_cfin.Text = "Trimestral"
        Me.rdo_trimestre_tempo_cfin.UseVisualStyleBackColor = True
        '
        'rdo_bimestre_tempo_cfin
        '
        Me.rdo_bimestre_tempo_cfin.AutoSize = True
        Me.rdo_bimestre_tempo_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_bimestre_tempo_cfin.Location = New System.Drawing.Point(136, 17)
        Me.rdo_bimestre_tempo_cfin.Name = "rdo_bimestre_tempo_cfin"
        Me.rdo_bimestre_tempo_cfin.Size = New System.Drawing.Size(67, 17)
        Me.rdo_bimestre_tempo_cfin.TabIndex = 10
        Me.rdo_bimestre_tempo_cfin.Text = "Bimestral"
        Me.rdo_bimestre_tempo_cfin.UseVisualStyleBackColor = True
        '
        'rdo_mes_tempo_cfin
        '
        Me.rdo_mes_tempo_cfin.AutoSize = True
        Me.rdo_mes_tempo_cfin.Checked = True
        Me.rdo_mes_tempo_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_mes_tempo_cfin.Location = New System.Drawing.Point(71, 17)
        Me.rdo_mes_tempo_cfin.Name = "rdo_mes_tempo_cfin"
        Me.rdo_mes_tempo_cfin.Size = New System.Drawing.Size(59, 17)
        Me.rdo_mes_tempo_cfin.TabIndex = 9
        Me.rdo_mes_tempo_cfin.TabStop = True
        Me.rdo_mes_tempo_cfin.Text = "Mensal"
        Me.rdo_mes_tempo_cfin.UseVisualStyleBackColor = True
        '
        'rdo_semestre_tempo_cfin
        '
        Me.rdo_semestre_tempo_cfin.AutoSize = True
        Me.rdo_semestre_tempo_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_semestre_tempo_cfin.Location = New System.Drawing.Point(284, 17)
        Me.rdo_semestre_tempo_cfin.Name = "rdo_semestre_tempo_cfin"
        Me.rdo_semestre_tempo_cfin.Size = New System.Drawing.Size(71, 17)
        Me.rdo_semestre_tempo_cfin.TabIndex = 8
        Me.rdo_semestre_tempo_cfin.Text = "Semestral"
        Me.rdo_semestre_tempo_cfin.UseVisualStyleBackColor = True
        '
        'rdo_ano_tempo_cfin
        '
        Me.rdo_ano_tempo_cfin.AutoSize = True
        Me.rdo_ano_tempo_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_ano_tempo_cfin.Location = New System.Drawing.Point(361, 17)
        Me.rdo_ano_tempo_cfin.Name = "rdo_ano_tempo_cfin"
        Me.rdo_ano_tempo_cfin.Size = New System.Drawing.Size(52, 17)
        Me.rdo_ano_tempo_cfin.TabIndex = 7
        Me.rdo_ano_tempo_cfin.Text = "Anual"
        Me.rdo_ano_tempo_cfin.UseVisualStyleBackColor = True
        '
        'rdo_dia_tempo_cfin
        '
        Me.rdo_dia_tempo_cfin.AutoSize = True
        Me.rdo_dia_tempo_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_dia_tempo_cfin.Location = New System.Drawing.Point(13, 17)
        Me.rdo_dia_tempo_cfin.Name = "rdo_dia_tempo_cfin"
        Me.rdo_dia_tempo_cfin.Size = New System.Drawing.Size(52, 17)
        Me.rdo_dia_tempo_cfin.TabIndex = 6
        Me.rdo_dia_tempo_cfin.Text = "Diária"
        Me.rdo_dia_tempo_cfin.UseVisualStyleBackColor = True
        '
        'texto_decimais_cfin
        '
        Me.texto_decimais_cfin.AutoSize = True
        Me.texto_decimais_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_decimais_cfin.Location = New System.Drawing.Point(423, 44)
        Me.texto_decimais_cfin.Name = "texto_decimais_cfin"
        Me.texto_decimais_cfin.Size = New System.Drawing.Size(58, 13)
        Me.texto_decimais_cfin.TabIndex = 25
        Me.texto_decimais_cfin.Text = "Decimais"
        '
        'caixacombo_casas_decimais_cfin
        '
        Me.caixacombo_casas_decimais_cfin.FormattingEnabled = True
        Me.caixacombo_casas_decimais_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_casas_decimais_cfin.Location = New System.Drawing.Point(487, 41)
        Me.caixacombo_casas_decimais_cfin.Name = "caixacombo_casas_decimais_cfin"
        Me.caixacombo_casas_decimais_cfin.Size = New System.Drawing.Size(62, 21)
        Me.caixacombo_casas_decimais_cfin.TabIndex = 26
        '
        'caixatexto_juros_simples_cfin
        '
        Me.caixatexto_juros_simples_cfin.Location = New System.Drawing.Point(124, 44)
        Me.caixatexto_juros_simples_cfin.Name = "caixatexto_juros_simples_cfin"
        Me.caixatexto_juros_simples_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_juros_simples_cfin.TabIndex = 27
        '
        'texto_juros_simples_cfin
        '
        Me.texto_juros_simples_cfin.AutoSize = True
        Me.texto_juros_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_juros_simples_cfin.Location = New System.Drawing.Point(6, 47)
        Me.texto_juros_simples_cfin.Name = "texto_juros_simples_cfin"
        Me.texto_juros_simples_cfin.Size = New System.Drawing.Size(35, 13)
        Me.texto_juros_simples_cfin.TabIndex = 28
        Me.texto_juros_simples_cfin.Text = "Taxa"
        '
        'btn_calcular_vf_simples_cfin
        '
        Me.btn_calcular_vf_simples_cfin.Location = New System.Drawing.Point(250, 134)
        Me.btn_calcular_vf_simples_cfin.Name = "btn_calcular_vf_simples_cfin"
        Me.btn_calcular_vf_simples_cfin.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_vf_simples_cfin.TabIndex = 43
        Me.btn_calcular_vf_simples_cfin.Text = "Calcular Valor Futuro"
        Me.btn_calcular_vf_simples_cfin.UseVisualStyleBackColor = True
        '
        'btn_calcular_tempo_simples_cfin
        '
        Me.btn_calcular_tempo_simples_cfin.Location = New System.Drawing.Point(250, 73)
        Me.btn_calcular_tempo_simples_cfin.Name = "btn_calcular_tempo_simples_cfin"
        Me.btn_calcular_tempo_simples_cfin.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_tempo_simples_cfin.TabIndex = 41
        Me.btn_calcular_tempo_simples_cfin.Text = "Calcular Parcelas"
        Me.btn_calcular_tempo_simples_cfin.UseVisualStyleBackColor = True
        '
        'btn_calcular_vp_simples_cfin
        '
        Me.btn_calcular_vp_simples_cfin.Location = New System.Drawing.Point(250, 11)
        Me.btn_calcular_vp_simples_cfin.Name = "btn_calcular_vp_simples_cfin"
        Me.btn_calcular_vp_simples_cfin.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_vp_simples_cfin.TabIndex = 39
        Me.btn_calcular_vp_simples_cfin.Text = "Calcular Valor Presente"
        Me.btn_calcular_vp_simples_cfin.UseVisualStyleBackColor = True
        '
        'caixatexto_vf_simples_cfin
        '
        Me.caixatexto_vf_simples_cfin.Location = New System.Drawing.Point(124, 136)
        Me.caixatexto_vf_simples_cfin.Name = "caixatexto_vf_simples_cfin"
        Me.caixatexto_vf_simples_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vf_simples_cfin.TabIndex = 38
        '
        'caixatexto_tempo_simples_cfin
        '
        Me.caixatexto_tempo_simples_cfin.Location = New System.Drawing.Point(124, 75)
        Me.caixatexto_tempo_simples_cfin.Name = "caixatexto_tempo_simples_cfin"
        Me.caixatexto_tempo_simples_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_tempo_simples_cfin.TabIndex = 36
        '
        'caixatexto_vp_simples_cfin
        '
        Me.caixatexto_vp_simples_cfin.Location = New System.Drawing.Point(124, 13)
        Me.caixatexto_vp_simples_cfin.Name = "caixatexto_vp_simples_cfin"
        Me.caixatexto_vp_simples_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vp_simples_cfin.TabIndex = 34
        '
        'texto_vf_simples_cfin
        '
        Me.texto_vf_simples_cfin.AutoSize = True
        Me.texto_vf_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vf_simples_cfin.Location = New System.Drawing.Point(6, 139)
        Me.texto_vf_simples_cfin.Name = "texto_vf_simples_cfin"
        Me.texto_vf_simples_cfin.Size = New System.Drawing.Size(76, 13)
        Me.texto_vf_simples_cfin.TabIndex = 32
        Me.texto_vf_simples_cfin.Text = "Valor Futuro"
        '
        'texto_tempo_simples_cfin
        '
        Me.texto_tempo_simples_cfin.AutoSize = True
        Me.texto_tempo_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tempo_simples_cfin.Location = New System.Drawing.Point(6, 78)
        Me.texto_tempo_simples_cfin.Name = "texto_tempo_simples_cfin"
        Me.texto_tempo_simples_cfin.Size = New System.Drawing.Size(75, 13)
        Me.texto_tempo_simples_cfin.TabIndex = 31
        Me.texto_tempo_simples_cfin.Text = "Parcelas (n)"
        '
        'texto_vp_simples_cfin
        '
        Me.texto_vp_simples_cfin.AutoSize = True
        Me.texto_vp_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vp_simples_cfin.Location = New System.Drawing.Point(6, 16)
        Me.texto_vp_simples_cfin.Name = "texto_vp_simples_cfin"
        Me.texto_vp_simples_cfin.Size = New System.Drawing.Size(90, 13)
        Me.texto_vp_simples_cfin.TabIndex = 29
        Me.texto_vp_simples_cfin.Text = "Valor Presente"
        '
        'GrupoJurosCompostos
        '
        Me.GrupoJurosCompostos.Controls.Add(Me.texto_vp_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.texto_taxa_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.texto_tempo_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.texto_vf_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.texto_pmt_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.caixatexto_vp_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.caixatexto_taxa_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.caixatexto_tempo_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.caixatexto_pmt_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.caixatexto_vf_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.btn_calcular_vp_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.btn_calcular_juros_composto_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.btn_calcular_tempo_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.btn_calcular_pmt_cfin)
        Me.GrupoJurosCompostos.Controls.Add(Me.btn_calcular_vf_cfin)
        Me.GrupoJurosCompostos.Location = New System.Drawing.Point(441, 4)
        Me.GrupoJurosCompostos.Name = "GrupoJurosCompostos"
        Me.GrupoJurosCompostos.Size = New System.Drawing.Size(377, 174)
        Me.GrupoJurosCompostos.TabIndex = 44
        Me.GrupoJurosCompostos.TabStop = False
        Me.GrupoJurosCompostos.Text = "Juros Compostos"
        '
        'GrupoJurosSimples
        '
        Me.GrupoJurosSimples.Controls.Add(Me.btn_calcular_montante_juros_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.texto_vp_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.btn_calcular_juros_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.texto_montante_juros_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.caixatexto_montante_juros_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.btn_calcular_vf_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.caixatexto_juros_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.btn_calcular_tempo_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.texto_juros_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.btn_calcular_vp_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.texto_tempo_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.caixatexto_vf_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.texto_vf_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.caixatexto_tempo_simples_cfin)
        Me.GrupoJurosSimples.Controls.Add(Me.caixatexto_vp_simples_cfin)
        Me.GrupoJurosSimples.Location = New System.Drawing.Point(12, 12)
        Me.GrupoJurosSimples.Name = "GrupoJurosSimples"
        Me.GrupoJurosSimples.Size = New System.Drawing.Size(415, 166)
        Me.GrupoJurosSimples.TabIndex = 45
        Me.GrupoJurosSimples.TabStop = False
        Me.GrupoJurosSimples.Text = "Juros Simples"
        '
        'btn_calcular_montante_juros_cfin
        '
        Me.btn_calcular_montante_juros_cfin.Location = New System.Drawing.Point(250, 103)
        Me.btn_calcular_montante_juros_cfin.Name = "btn_calcular_montante_juros_cfin"
        Me.btn_calcular_montante_juros_cfin.Size = New System.Drawing.Size(150, 23)
        Me.btn_calcular_montante_juros_cfin.TabIndex = 46
        Me.btn_calcular_montante_juros_cfin.Text = "Calcular Montante de Juros"
        Me.btn_calcular_montante_juros_cfin.UseVisualStyleBackColor = True
        '
        'texto_montante_juros_cfin
        '
        Me.texto_montante_juros_cfin.AutoSize = True
        Me.texto_montante_juros_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_montante_juros_cfin.Location = New System.Drawing.Point(6, 108)
        Me.texto_montante_juros_cfin.Name = "texto_montante_juros_cfin"
        Me.texto_montante_juros_cfin.Size = New System.Drawing.Size(112, 13)
        Me.texto_montante_juros_cfin.TabIndex = 44
        Me.texto_montante_juros_cfin.Text = "Montante de Juros"
        '
        'caixatexto_montante_juros_cfin
        '
        Me.caixatexto_montante_juros_cfin.Location = New System.Drawing.Point(124, 105)
        Me.caixatexto_montante_juros_cfin.Name = "caixatexto_montante_juros_cfin"
        Me.caixatexto_montante_juros_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_montante_juros_cfin.TabIndex = 45
        '
        'GrupoEqJurosCompostos
        '
        Me.GrupoEqJurosCompostos.Controls.Add(Me.btn_transformar_percentual)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.caixacombo_casas_decimais_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.caixatexto_transformar_percentual)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.texto_decimais_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.texto_transformar_percentual)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.btn_calcular_eq_taxa_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.caixatexto_eq_i_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.texto_eq_i_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.caixatexto_eq_taxa_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.texto_eq_taxa_cfin)
        Me.GrupoEqJurosCompostos.Location = New System.Drawing.Point(6, 182)
        Me.GrupoEqJurosCompostos.Name = "GrupoEqJurosCompostos"
        Me.GrupoEqJurosCompostos.Size = New System.Drawing.Size(562, 66)
        Me.GrupoEqJurosCompostos.TabIndex = 46
        Me.GrupoEqJurosCompostos.TabStop = False
        Me.GrupoEqJurosCompostos.Text = "Juros Compostos"
        '
        'btn_transformar_percentual
        '
        Me.btn_transformar_percentual.Location = New System.Drawing.Point(423, 11)
        Me.btn_transformar_percentual.Name = "btn_transformar_percentual"
        Me.btn_transformar_percentual.Size = New System.Drawing.Size(99, 23)
        Me.btn_transformar_percentual.TabIndex = 32
        Me.btn_transformar_percentual.Text = "Transformar"
        Me.btn_transformar_percentual.UseVisualStyleBackColor = True
        '
        'caixatexto_transformar_percentual
        '
        Me.caixatexto_transformar_percentual.Location = New System.Drawing.Point(292, 13)
        Me.caixatexto_transformar_percentual.Name = "caixatexto_transformar_percentual"
        Me.caixatexto_transformar_percentual.ReadOnly = True
        Me.caixatexto_transformar_percentual.Size = New System.Drawing.Size(125, 20)
        Me.caixatexto_transformar_percentual.TabIndex = 31
        '
        'texto_transformar_percentual
        '
        Me.texto_transformar_percentual.AutoSize = True
        Me.texto_transformar_percentual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_transformar_percentual.Location = New System.Drawing.Point(128, 16)
        Me.texto_transformar_percentual.Name = "texto_transformar_percentual"
        Me.texto_transformar_percentual.Size = New System.Drawing.Size(158, 13)
        Me.texto_transformar_percentual.TabIndex = 30
        Me.texto_transformar_percentual.Text = "Transformar em percentual"
        '
        'GrupoEqJurosSimples
        '
        Me.GrupoEqJurosSimples.Controls.Add(Me.btn_transformar_percentual_simples)
        Me.GrupoEqJurosSimples.Controls.Add(Me.caixatexto_transformar_percentual_simples)
        Me.GrupoEqJurosSimples.Controls.Add(Me.texto_transformar_percentual_simples)
        Me.GrupoEqJurosSimples.Controls.Add(Me.caixacombo_casas_decimais_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.texto_casas_decimais_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.btn_calcular_taxa_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.caixatexto_eq_i_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.texto_eq_i_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.caixatexto_eq_taxa_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.texto_eq_taxa_simples_cfin)
        Me.GrupoEqJurosSimples.Location = New System.Drawing.Point(6, 109)
        Me.GrupoEqJurosSimples.Name = "GrupoEqJurosSimples"
        Me.GrupoEqJurosSimples.Size = New System.Drawing.Size(562, 67)
        Me.GrupoEqJurosSimples.TabIndex = 47
        Me.GrupoEqJurosSimples.TabStop = False
        Me.GrupoEqJurosSimples.Text = "Juros Simples"
        '
        'btn_transformar_percentual_simples
        '
        Me.btn_transformar_percentual_simples.Location = New System.Drawing.Point(423, 11)
        Me.btn_transformar_percentual_simples.Name = "btn_transformar_percentual_simples"
        Me.btn_transformar_percentual_simples.Size = New System.Drawing.Size(99, 23)
        Me.btn_transformar_percentual_simples.TabIndex = 29
        Me.btn_transformar_percentual_simples.Text = "Transformar"
        Me.btn_transformar_percentual_simples.UseVisualStyleBackColor = True
        '
        'caixatexto_transformar_percentual_simples
        '
        Me.caixatexto_transformar_percentual_simples.Location = New System.Drawing.Point(292, 13)
        Me.caixatexto_transformar_percentual_simples.Name = "caixatexto_transformar_percentual_simples"
        Me.caixatexto_transformar_percentual_simples.ReadOnly = True
        Me.caixatexto_transformar_percentual_simples.Size = New System.Drawing.Size(125, 20)
        Me.caixatexto_transformar_percentual_simples.TabIndex = 28
        '
        'texto_transformar_percentual_simples
        '
        Me.texto_transformar_percentual_simples.AutoSize = True
        Me.texto_transformar_percentual_simples.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_transformar_percentual_simples.Location = New System.Drawing.Point(128, 16)
        Me.texto_transformar_percentual_simples.Name = "texto_transformar_percentual_simples"
        Me.texto_transformar_percentual_simples.Size = New System.Drawing.Size(158, 13)
        Me.texto_transformar_percentual_simples.TabIndex = 27
        Me.texto_transformar_percentual_simples.Text = "Transformar em percentual"
        '
        'caixacombo_casas_decimais_simples_cfin
        '
        Me.caixacombo_casas_decimais_simples_cfin.FormattingEnabled = True
        Me.caixacombo_casas_decimais_simples_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_casas_decimais_simples_cfin.Location = New System.Drawing.Point(487, 41)
        Me.caixacombo_casas_decimais_simples_cfin.Name = "caixacombo_casas_decimais_simples_cfin"
        Me.caixacombo_casas_decimais_simples_cfin.Size = New System.Drawing.Size(62, 21)
        Me.caixacombo_casas_decimais_simples_cfin.TabIndex = 26
        '
        'texto_casas_decimais_simples_cfin
        '
        Me.texto_casas_decimais_simples_cfin.AutoSize = True
        Me.texto_casas_decimais_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_casas_decimais_simples_cfin.Location = New System.Drawing.Point(423, 44)
        Me.texto_casas_decimais_simples_cfin.Name = "texto_casas_decimais_simples_cfin"
        Me.texto_casas_decimais_simples_cfin.Size = New System.Drawing.Size(58, 13)
        Me.texto_casas_decimais_simples_cfin.TabIndex = 25
        Me.texto_casas_decimais_simples_cfin.Text = "Decimais"
        '
        'btn_calcular_taxa_simples_cfin
        '
        Me.btn_calcular_taxa_simples_cfin.Enabled = False
        Me.btn_calcular_taxa_simples_cfin.Location = New System.Drawing.Point(269, 39)
        Me.btn_calcular_taxa_simples_cfin.Name = "btn_calcular_taxa_simples_cfin"
        Me.btn_calcular_taxa_simples_cfin.Size = New System.Drawing.Size(148, 23)
        Me.btn_calcular_taxa_simples_cfin.TabIndex = 22
        Me.btn_calcular_taxa_simples_cfin.Text = "Calcular Taxa"
        Me.btn_calcular_taxa_simples_cfin.UseVisualStyleBackColor = True
        '
        'caixatexto_eq_i_simples_cfin
        '
        Me.caixatexto_eq_i_simples_cfin.Location = New System.Drawing.Point(22, 13)
        Me.caixatexto_eq_i_simples_cfin.Name = "caixatexto_eq_i_simples_cfin"
        Me.caixatexto_eq_i_simples_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_eq_i_simples_cfin.TabIndex = 20
        '
        'texto_eq_i_simples_cfin
        '
        Me.texto_eq_i_simples_cfin.AutoSize = True
        Me.texto_eq_i_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_eq_i_simples_cfin.Location = New System.Drawing.Point(6, 16)
        Me.texto_eq_i_simples_cfin.Name = "texto_eq_i_simples_cfin"
        Me.texto_eq_i_simples_cfin.Size = New System.Drawing.Size(10, 13)
        Me.texto_eq_i_simples_cfin.TabIndex = 18
        Me.texto_eq_i_simples_cfin.Text = "i"
        '
        'caixatexto_eq_taxa_simples_cfin
        '
        Me.caixatexto_eq_taxa_simples_cfin.Location = New System.Drawing.Point(149, 41)
        Me.caixatexto_eq_taxa_simples_cfin.Name = "caixatexto_eq_taxa_simples_cfin"
        Me.caixatexto_eq_taxa_simples_cfin.ReadOnly = True
        Me.caixatexto_eq_taxa_simples_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_eq_taxa_simples_cfin.TabIndex = 17
        Me.caixatexto_eq_taxa_simples_cfin.Text = "0"
        '
        'texto_eq_taxa_simples_cfin
        '
        Me.texto_eq_taxa_simples_cfin.AutoSize = True
        Me.texto_eq_taxa_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_eq_taxa_simples_cfin.Location = New System.Drawing.Point(6, 44)
        Me.texto_eq_taxa_simples_cfin.Name = "texto_eq_taxa_simples_cfin"
        Me.texto_eq_taxa_simples_cfin.Size = New System.Drawing.Size(137, 13)
        Me.texto_eq_taxa_simples_cfin.TabIndex = 16
        Me.texto_eq_taxa_simples_cfin.Text = "Transformação de taxa"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_calcular_ano_bissexto, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.caixacombo_exatos_i_ecb_cfin, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.texto_casas_decimais_ecb_cfin, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_exatos_n_ecb_cfin, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.caixatexto_exatos_i_ecb_cfin, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.texto_bancarios_ecb_cfin, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.texto_comercial_ecb_cfin, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.texto_exatos_ecb_cfin, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.texto_n_ecb_cfin, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.texto_juros_ecb_cfin, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.texto_i_ecb_cfin, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.caixatexto_comercial_i_ecb_cfin, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.caixatexto_comercial_n_ecb_cfin, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.caixatexto_bancarios_i_ecb_cfin, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.caixatexto_bancarios_n_ecb_cfin, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.caixatexto_exatos_n_ecb_cfin, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_exatos_i_ecb_cfin, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_comercial_i_ecb_cfin, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_bancarios_i_ecb_cfin, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_comercial_n_ecb_cfin, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_bancarios_n_ecb_cfin, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_limpar_ecb_cfin, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.caixacombo_comercial_i_ecb_cfin, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.caixacombo_bancarios_i_ecb_cfin, 5, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 65)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.64286!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.35714!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(559, 141)
        Me.TableLayoutPanel1.TabIndex = 48
        '
        'btn_calcular_ano_bissexto
        '
        Me.btn_calcular_ano_bissexto.Location = New System.Drawing.Point(402, 6)
        Me.btn_calcular_ano_bissexto.Name = "btn_calcular_ano_bissexto"
        Me.btn_calcular_ano_bissexto.Size = New System.Drawing.Size(76, 22)
        Me.btn_calcular_ano_bissexto.TabIndex = 67
        Me.btn_calcular_ano_bissexto.Text = "Ano Bissexto"
        Me.btn_calcular_ano_bissexto.UseVisualStyleBackColor = True
        '
        'caixacombo_exatos_i_ecb_cfin
        '
        Me.caixacombo_exatos_i_ecb_cfin.FormattingEnabled = True
        Me.caixacombo_exatos_i_ecb_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_exatos_i_ecb_cfin.Location = New System.Drawing.Point(488, 37)
        Me.caixacombo_exatos_i_ecb_cfin.Name = "caixacombo_exatos_i_ecb_cfin"
        Me.caixacombo_exatos_i_ecb_cfin.Size = New System.Drawing.Size(61, 21)
        Me.caixacombo_exatos_i_ecb_cfin.TabIndex = 27
        '
        'texto_casas_decimais_ecb_cfin
        '
        Me.texto_casas_decimais_ecb_cfin.AutoSize = True
        Me.texto_casas_decimais_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_casas_decimais_ecb_cfin.Location = New System.Drawing.Point(488, 3)
        Me.texto_casas_decimais_ecb_cfin.Name = "texto_casas_decimais_ecb_cfin"
        Me.texto_casas_decimais_ecb_cfin.Size = New System.Drawing.Size(58, 13)
        Me.texto_casas_decimais_ecb_cfin.TabIndex = 27
        Me.texto_casas_decimais_ecb_cfin.Text = "Decimais"
        '
        'btn_exatos_n_ecb_cfin
        '
        Me.btn_exatos_n_ecb_cfin.Location = New System.Drawing.Point(402, 37)
        Me.btn_exatos_n_ecb_cfin.Name = "btn_exatos_n_ecb_cfin"
        Me.btn_exatos_n_ecb_cfin.Size = New System.Drawing.Size(75, 22)
        Me.btn_exatos_n_ecb_cfin.TabIndex = 50
        Me.btn_exatos_n_ecb_cfin.Text = "Calcular n"
        Me.btn_exatos_n_ecb_cfin.UseVisualStyleBackColor = True
        '
        'caixatexto_exatos_i_ecb_cfin
        '
        Me.caixatexto_exatos_i_ecb_cfin.Location = New System.Drawing.Point(89, 37)
        Me.caixatexto_exatos_i_ecb_cfin.Name = "caixatexto_exatos_i_ecb_cfin"
        Me.caixatexto_exatos_i_ecb_cfin.ReadOnly = True
        Me.caixatexto_exatos_i_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_exatos_i_ecb_cfin.TabIndex = 49
        '
        'texto_bancarios_ecb_cfin
        '
        Me.texto_bancarios_ecb_cfin.AutoSize = True
        Me.texto_bancarios_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_bancarios_ecb_cfin.Location = New System.Drawing.Point(6, 108)
        Me.texto_bancarios_ecb_cfin.Name = "texto_bancarios_ecb_cfin"
        Me.texto_bancarios_ecb_cfin.Size = New System.Drawing.Size(63, 13)
        Me.texto_bancarios_ecb_cfin.TabIndex = 49
        Me.texto_bancarios_ecb_cfin.Text = "Bancários"
        '
        'texto_comercial_ecb_cfin
        '
        Me.texto_comercial_ecb_cfin.AutoSize = True
        Me.texto_comercial_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_comercial_ecb_cfin.Location = New System.Drawing.Point(6, 71)
        Me.texto_comercial_ecb_cfin.Name = "texto_comercial_ecb_cfin"
        Me.texto_comercial_ecb_cfin.Size = New System.Drawing.Size(68, 13)
        Me.texto_comercial_ecb_cfin.TabIndex = 49
        Me.texto_comercial_ecb_cfin.Text = "Comerciais"
        '
        'texto_exatos_ecb_cfin
        '
        Me.texto_exatos_ecb_cfin.AutoSize = True
        Me.texto_exatos_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_exatos_ecb_cfin.Location = New System.Drawing.Point(6, 34)
        Me.texto_exatos_ecb_cfin.Name = "texto_exatos_ecb_cfin"
        Me.texto_exatos_ecb_cfin.Size = New System.Drawing.Size(45, 13)
        Me.texto_exatos_ecb_cfin.TabIndex = 49
        Me.texto_exatos_ecb_cfin.Text = "Exatos"
        '
        'texto_n_ecb_cfin
        '
        Me.texto_n_ecb_cfin.AutoSize = True
        Me.texto_n_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_n_ecb_cfin.Location = New System.Drawing.Point(203, 3)
        Me.texto_n_ecb_cfin.Name = "texto_n_ecb_cfin"
        Me.texto_n_ecb_cfin.Size = New System.Drawing.Size(14, 13)
        Me.texto_n_ecb_cfin.TabIndex = 49
        Me.texto_n_ecb_cfin.Text = "n"
        '
        'texto_juros_ecb_cfin
        '
        Me.texto_juros_ecb_cfin.AutoSize = True
        Me.texto_juros_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_juros_ecb_cfin.Location = New System.Drawing.Point(6, 3)
        Me.texto_juros_ecb_cfin.Name = "texto_juros_ecb_cfin"
        Me.texto_juros_ecb_cfin.Size = New System.Drawing.Size(37, 13)
        Me.texto_juros_ecb_cfin.TabIndex = 27
        Me.texto_juros_ecb_cfin.Text = "Juros"
        '
        'texto_i_ecb_cfin
        '
        Me.texto_i_ecb_cfin.AutoSize = True
        Me.texto_i_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_i_ecb_cfin.Location = New System.Drawing.Point(89, 3)
        Me.texto_i_ecb_cfin.Name = "texto_i_ecb_cfin"
        Me.texto_i_ecb_cfin.Size = New System.Drawing.Size(10, 13)
        Me.texto_i_ecb_cfin.TabIndex = 28
        Me.texto_i_ecb_cfin.Text = "i"
        '
        'caixatexto_comercial_i_ecb_cfin
        '
        Me.caixatexto_comercial_i_ecb_cfin.Location = New System.Drawing.Point(89, 74)
        Me.caixatexto_comercial_i_ecb_cfin.Name = "caixatexto_comercial_i_ecb_cfin"
        Me.caixatexto_comercial_i_ecb_cfin.ReadOnly = True
        Me.caixatexto_comercial_i_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_comercial_i_ecb_cfin.TabIndex = 51
        '
        'caixatexto_comercial_n_ecb_cfin
        '
        Me.caixatexto_comercial_n_ecb_cfin.Location = New System.Drawing.Point(203, 74)
        Me.caixatexto_comercial_n_ecb_cfin.Name = "caixatexto_comercial_n_ecb_cfin"
        Me.caixatexto_comercial_n_ecb_cfin.ReadOnly = True
        Me.caixatexto_comercial_n_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_comercial_n_ecb_cfin.TabIndex = 52
        '
        'caixatexto_bancarios_i_ecb_cfin
        '
        Me.caixatexto_bancarios_i_ecb_cfin.Location = New System.Drawing.Point(89, 111)
        Me.caixatexto_bancarios_i_ecb_cfin.Name = "caixatexto_bancarios_i_ecb_cfin"
        Me.caixatexto_bancarios_i_ecb_cfin.ReadOnly = True
        Me.caixatexto_bancarios_i_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_bancarios_i_ecb_cfin.TabIndex = 53
        '
        'caixatexto_bancarios_n_ecb_cfin
        '
        Me.caixatexto_bancarios_n_ecb_cfin.Location = New System.Drawing.Point(203, 111)
        Me.caixatexto_bancarios_n_ecb_cfin.Name = "caixatexto_bancarios_n_ecb_cfin"
        Me.caixatexto_bancarios_n_ecb_cfin.ReadOnly = True
        Me.caixatexto_bancarios_n_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_bancarios_n_ecb_cfin.TabIndex = 54
        '
        'caixatexto_exatos_n_ecb_cfin
        '
        Me.caixatexto_exatos_n_ecb_cfin.Location = New System.Drawing.Point(203, 37)
        Me.caixatexto_exatos_n_ecb_cfin.Name = "caixatexto_exatos_n_ecb_cfin"
        Me.caixatexto_exatos_n_ecb_cfin.ReadOnly = True
        Me.caixatexto_exatos_n_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_exatos_n_ecb_cfin.TabIndex = 50
        '
        'btn_exatos_i_ecb_cfin
        '
        Me.btn_exatos_i_ecb_cfin.Location = New System.Drawing.Point(316, 37)
        Me.btn_exatos_i_ecb_cfin.Name = "btn_exatos_i_ecb_cfin"
        Me.btn_exatos_i_ecb_cfin.Size = New System.Drawing.Size(75, 23)
        Me.btn_exatos_i_ecb_cfin.TabIndex = 49
        Me.btn_exatos_i_ecb_cfin.Text = "Calcular i"
        Me.btn_exatos_i_ecb_cfin.UseVisualStyleBackColor = True
        '
        'btn_comercial_i_ecb_cfin
        '
        Me.btn_comercial_i_ecb_cfin.Location = New System.Drawing.Point(316, 74)
        Me.btn_comercial_i_ecb_cfin.Name = "btn_comercial_i_ecb_cfin"
        Me.btn_comercial_i_ecb_cfin.Size = New System.Drawing.Size(75, 22)
        Me.btn_comercial_i_ecb_cfin.TabIndex = 58
        Me.btn_comercial_i_ecb_cfin.Text = "Calcular i"
        Me.btn_comercial_i_ecb_cfin.UseVisualStyleBackColor = True
        '
        'btn_bancarios_i_ecb_cfin
        '
        Me.btn_bancarios_i_ecb_cfin.Location = New System.Drawing.Point(316, 111)
        Me.btn_bancarios_i_ecb_cfin.Name = "btn_bancarios_i_ecb_cfin"
        Me.btn_bancarios_i_ecb_cfin.Size = New System.Drawing.Size(75, 22)
        Me.btn_bancarios_i_ecb_cfin.TabIndex = 59
        Me.btn_bancarios_i_ecb_cfin.Text = "Calcular i"
        Me.btn_bancarios_i_ecb_cfin.UseVisualStyleBackColor = True
        '
        'btn_comercial_n_ecb_cfin
        '
        Me.btn_comercial_n_ecb_cfin.Location = New System.Drawing.Point(402, 74)
        Me.btn_comercial_n_ecb_cfin.Name = "btn_comercial_n_ecb_cfin"
        Me.btn_comercial_n_ecb_cfin.Size = New System.Drawing.Size(75, 22)
        Me.btn_comercial_n_ecb_cfin.TabIndex = 61
        Me.btn_comercial_n_ecb_cfin.Text = "Calcular n"
        Me.btn_comercial_n_ecb_cfin.UseVisualStyleBackColor = True
        '
        'btn_bancarios_n_ecb_cfin
        '
        Me.btn_bancarios_n_ecb_cfin.Location = New System.Drawing.Point(402, 111)
        Me.btn_bancarios_n_ecb_cfin.Name = "btn_bancarios_n_ecb_cfin"
        Me.btn_bancarios_n_ecb_cfin.Size = New System.Drawing.Size(75, 22)
        Me.btn_bancarios_n_ecb_cfin.TabIndex = 62
        Me.btn_bancarios_n_ecb_cfin.Text = "Calcular n"
        Me.btn_bancarios_n_ecb_cfin.UseVisualStyleBackColor = True
        '
        'btn_limpar_ecb_cfin
        '
        Me.btn_limpar_ecb_cfin.Location = New System.Drawing.Point(316, 6)
        Me.btn_limpar_ecb_cfin.Name = "btn_limpar_ecb_cfin"
        Me.btn_limpar_ecb_cfin.Size = New System.Drawing.Size(75, 22)
        Me.btn_limpar_ecb_cfin.TabIndex = 63
        Me.btn_limpar_ecb_cfin.Text = "Limpar"
        Me.btn_limpar_ecb_cfin.UseVisualStyleBackColor = True
        '
        'caixacombo_comercial_i_ecb_cfin
        '
        Me.caixacombo_comercial_i_ecb_cfin.FormattingEnabled = True
        Me.caixacombo_comercial_i_ecb_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_comercial_i_ecb_cfin.Location = New System.Drawing.Point(488, 74)
        Me.caixacombo_comercial_i_ecb_cfin.Name = "caixacombo_comercial_i_ecb_cfin"
        Me.caixacombo_comercial_i_ecb_cfin.Size = New System.Drawing.Size(61, 21)
        Me.caixacombo_comercial_i_ecb_cfin.TabIndex = 64
        '
        'caixacombo_bancarios_i_ecb_cfin
        '
        Me.caixacombo_bancarios_i_ecb_cfin.FormattingEnabled = True
        Me.caixacombo_bancarios_i_ecb_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_bancarios_i_ecb_cfin.Location = New System.Drawing.Point(488, 111)
        Me.caixacombo_bancarios_i_ecb_cfin.Name = "caixacombo_bancarios_i_ecb_cfin"
        Me.caixacombo_bancarios_i_ecb_cfin.Size = New System.Drawing.Size(61, 21)
        Me.caixacombo_bancarios_i_ecb_cfin.TabIndex = 65
        '
        'caixatexto_inserir_i_ecb_cfin
        '
        Me.caixatexto_inserir_i_ecb_cfin.Location = New System.Drawing.Point(26, 12)
        Me.caixatexto_inserir_i_ecb_cfin.Name = "caixatexto_inserir_i_ecb_cfin"
        Me.caixatexto_inserir_i_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_inserir_i_ecb_cfin.TabIndex = 57
        '
        'texto_inserir_i_ecb_cfin
        '
        Me.texto_inserir_i_ecb_cfin.AutoSize = True
        Me.texto_inserir_i_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_inserir_i_ecb_cfin.Location = New System.Drawing.Point(7, 16)
        Me.texto_inserir_i_ecb_cfin.Name = "texto_inserir_i_ecb_cfin"
        Me.texto_inserir_i_ecb_cfin.Size = New System.Drawing.Size(10, 13)
        Me.texto_inserir_i_ecb_cfin.TabIndex = 63
        Me.texto_inserir_i_ecb_cfin.Text = "i"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "n de:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "até"
        '
        'GrupoJurosECB
        '
        Me.GrupoJurosECB.Controls.Add(Me.data_ate)
        Me.GrupoJurosECB.Controls.Add(Me.data_de)
        Me.GrupoJurosECB.Controls.Add(Me.checkbox_ano_bissexto_ecb_cfin)
        Me.GrupoJurosECB.Controls.Add(Me.texto_inserir_i_ecb_cfin)
        Me.GrupoJurosECB.Controls.Add(Me.TableLayoutPanel1)
        Me.GrupoJurosECB.Controls.Add(Me.caixatexto_inserir_i_ecb_cfin)
        Me.GrupoJurosECB.Controls.Add(Me.Label2)
        Me.GrupoJurosECB.Controls.Add(Me.Label3)
        Me.GrupoJurosECB.Location = New System.Drawing.Point(12, 444)
        Me.GrupoJurosECB.Name = "GrupoJurosECB"
        Me.GrupoJurosECB.Size = New System.Drawing.Size(577, 214)
        Me.GrupoJurosECB.TabIndex = 66
        Me.GrupoJurosECB.TabStop = False
        '
        'data_ate
        '
        Me.data_ate.Location = New System.Drawing.Point(300, 38)
        Me.data_ate.Name = "data_ate"
        Me.data_ate.Size = New System.Drawing.Size(215, 20)
        Me.data_ate.TabIndex = 67
        '
        'data_de
        '
        Me.data_de.Location = New System.Drawing.Point(48, 38)
        Me.data_de.Name = "data_de"
        Me.data_de.Size = New System.Drawing.Size(215, 20)
        Me.data_de.TabIndex = 66
        '
        'checkbox_ano_bissexto_ecb_cfin
        '
        Me.checkbox_ano_bissexto_ecb_cfin.AutoSize = True
        Me.checkbox_ano_bissexto_ecb_cfin.Location = New System.Drawing.Point(132, 14)
        Me.checkbox_ano_bissexto_ecb_cfin.Name = "checkbox_ano_bissexto_ecb_cfin"
        Me.checkbox_ano_bissexto_ecb_cfin.Size = New System.Drawing.Size(87, 17)
        Me.checkbox_ano_bissexto_ecb_cfin.TabIndex = 27
        Me.checkbox_ano_bissexto_ecb_cfin.Text = "Ano Bissexto"
        Me.checkbox_ano_bissexto_ecb_cfin.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Coluna_data, Me.Coluna_tipo, Me.Coluna_entrada, Me.Coluna_saldo, Me.Coluna_juros, Me.Coluna_n})
        Me.DataGridView1.Location = New System.Drawing.Point(595, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(413, 474)
        Me.DataGridView1.TabIndex = 67
        '
        'Coluna_data
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Coluna_data.DefaultCellStyle = DataGridViewCellStyle1
        Me.Coluna_data.HeaderText = "Data"
        Me.Coluna_data.Name = "Coluna_data"
        Me.Coluna_data.Width = 70
        '
        'Coluna_tipo
        '
        Me.Coluna_tipo.HeaderText = "Tipo"
        Me.Coluna_tipo.Items.AddRange(New Object() {"Depósito", "Cheque"})
        Me.Coluna_tipo.Name = "Coluna_tipo"
        Me.Coluna_tipo.Width = 80
        '
        'Coluna_entrada
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Coluna_entrada.DefaultCellStyle = DataGridViewCellStyle2
        Me.Coluna_entrada.HeaderText = "Entrada"
        Me.Coluna_entrada.Name = "Coluna_entrada"
        Me.Coluna_entrada.Width = 70
        '
        'Coluna_saldo
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Coluna_saldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Coluna_saldo.HeaderText = "Saldo"
        Me.Coluna_saldo.Name = "Coluna_saldo"
        Me.Coluna_saldo.Width = 70
        '
        'Coluna_juros
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Coluna_juros.DefaultCellStyle = DataGridViewCellStyle4
        Me.Coluna_juros.HeaderText = "Juros"
        Me.Coluna_juros.Name = "Coluna_juros"
        Me.Coluna_juros.ToolTipText = "Montante de Juros"
        Me.Coluna_juros.Width = 50
        '
        'Coluna_n
        '
        Me.Coluna_n.HeaderText = "n"
        Me.Coluna_n.Name = "Coluna_n"
        Me.Coluna_n.Width = 40
        '
        'GrupoConvercaoTaxa
        '
        Me.GrupoConvercaoTaxa.Controls.Add(Me.GrupoTaxaCalculosFinanceiros)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.GrupoEqJurosCompostos)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.GrupoEqJurosSimples)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.GrupoTempoCalculosFinanceiros)
        Me.GrupoConvercaoTaxa.Location = New System.Drawing.Point(12, 184)
        Me.GrupoConvercaoTaxa.Name = "GrupoConvercaoTaxa"
        Me.GrupoConvercaoTaxa.Size = New System.Drawing.Size(577, 254)
        Me.GrupoConvercaoTaxa.TabIndex = 68
        Me.GrupoConvercaoTaxa.TabStop = False
        Me.GrupoConvercaoTaxa.Text = "Transformação de taxas"
        Me.ToolTipCfin.SetToolTip(Me.GrupoConvercaoTaxa, "Transformação do tempo da taxa para o tempo da parcela")
        '
        'form_calculos_financeiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 661)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GrupoJurosSimples)
        Me.Controls.Add(Me.GrupoJurosCompostos)
        Me.Controls.Add(Me.GrupoJurosECB)
        Me.Controls.Add(Me.GrupoConvercaoTaxa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_calculos_financeiros"
        Me.Text = "Cálculos Financeiros"
        Me.GrupoTaxaCalculosFinanceiros.ResumeLayout(False)
        Me.GrupoTaxaCalculosFinanceiros.PerformLayout()
        Me.GrupoTempoCalculosFinanceiros.ResumeLayout(False)
        Me.GrupoTempoCalculosFinanceiros.PerformLayout()
        Me.GrupoJurosCompostos.ResumeLayout(False)
        Me.GrupoJurosCompostos.PerformLayout()
        Me.GrupoJurosSimples.ResumeLayout(False)
        Me.GrupoJurosSimples.PerformLayout()
        Me.GrupoEqJurosCompostos.ResumeLayout(False)
        Me.GrupoEqJurosCompostos.PerformLayout()
        Me.GrupoEqJurosSimples.ResumeLayout(False)
        Me.GrupoEqJurosSimples.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GrupoJurosECB.ResumeLayout(False)
        Me.GrupoJurosECB.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoConvercaoTaxa.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents texto_vp_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_taxa_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_tempo_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_vf_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_pmt_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_vp_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_taxa_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_tempo_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_pmt_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_vf_cfin As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular_vp_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_juros_simples_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_juros_composto_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_tempo_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_pmt_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_vf_cfin As System.Windows.Forms.Button
    Friend WithEvents texto_eq_taxa_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_eq_taxa_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_eq_i_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_eq_i_cfin As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular_eq_taxa_cfin As System.Windows.Forms.Button
    Friend WithEvents GrupoTaxaCalculosFinanceiros As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_mes_taxa_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_semestre_taxa_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_ano_taxa_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_dia_taxa_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoTempoCalculosFinanceiros As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_mes_tempo_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_semestre_tempo_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_ano_tempo_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_dia_tempo_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents texto_decimais_cfin As System.Windows.Forms.Label
    Friend WithEvents caixacombo_casas_decimais_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents caixatexto_juros_simples_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_juros_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents btn_calcular_vf_simples_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_tempo_simples_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_calcular_vp_simples_cfin As System.Windows.Forms.Button
    Friend WithEvents caixatexto_vf_simples_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_tempo_simples_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_vp_simples_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_vf_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_tempo_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_vp_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents GrupoJurosCompostos As System.Windows.Forms.GroupBox
    Friend WithEvents GrupoJurosSimples As System.Windows.Forms.GroupBox
    Friend WithEvents btn_calcular_montante_juros_cfin As System.Windows.Forms.Button
    Friend WithEvents texto_montante_juros_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_montante_juros_cfin As System.Windows.Forms.TextBox
    Friend WithEvents GrupoEqJurosCompostos As System.Windows.Forms.GroupBox
    Friend WithEvents GrupoEqJurosSimples As System.Windows.Forms.GroupBox
    Friend WithEvents caixacombo_casas_decimais_simples_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents texto_casas_decimais_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents btn_calcular_taxa_simples_cfin As System.Windows.Forms.Button
    Friend WithEvents caixatexto_eq_i_simples_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_eq_i_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_eq_taxa_simples_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_eq_taxa_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents texto_n_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_i_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_juros_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_bancarios_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_comercial_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_exatos_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_exatos_i_ecb_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_exatos_n_ecb_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_comercial_i_ecb_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_comercial_n_ecb_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_bancarios_i_ecb_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_bancarios_n_ecb_cfin As System.Windows.Forms.TextBox
    Friend WithEvents btn_exatos_i_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents caixatexto_inserir_i_ecb_cfin As System.Windows.Forms.TextBox
    Friend WithEvents btn_exatos_n_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_comercial_i_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_bancarios_i_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_comercial_n_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_bancarios_n_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents texto_inserir_i_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GrupoJurosECB As System.Windows.Forms.GroupBox
    Friend WithEvents btn_limpar_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents caixacombo_exatos_i_ecb_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents texto_casas_decimais_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents caixacombo_comercial_i_ecb_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents caixacombo_bancarios_i_ecb_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents btn_calcular_ano_bissexto As System.Windows.Forms.Button
    Friend WithEvents checkbox_ano_bissexto_ecb_cfin As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_transformar_percentual_simples As System.Windows.Forms.Button
    Friend WithEvents caixatexto_transformar_percentual_simples As System.Windows.Forms.TextBox
    Friend WithEvents texto_transformar_percentual_simples As System.Windows.Forms.Label
    Friend WithEvents btn_transformar_percentual As System.Windows.Forms.Button
    Friend WithEvents caixatexto_transformar_percentual As System.Windows.Forms.TextBox
    Friend WithEvents texto_transformar_percentual As System.Windows.Forms.Label
    Friend WithEvents Coluna_data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_tipo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Coluna_entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_juros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_n As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data_de As System.Windows.Forms.DateTimePicker
    Friend WithEvents data_ate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrupoConvercaoTaxa As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_trimestre_taxa_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_bimestre_taxa_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_trimestre_tempo_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_bimestre_tempo_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTipCfin As System.Windows.Forms.ToolTip
End Class
