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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_calculos_financeiros))
        Me.texto_pmt_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_vp_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_tempo_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_pmt_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_vf_cfin = New System.Windows.Forms.TextBox()
        Me.texto_eq_taxa_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_eq_taxa_cfin = New System.Windows.Forms.TextBox()
        Me.texto_eq_i_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_eq_i_cfin = New System.Windows.Forms.TextBox()
        Me.btn_calcular_eq_taxa_cfin = New System.Windows.Forms.Button()
        Me.texto_decimais_cfin = New System.Windows.Forms.Label()
        Me.caixacombo_casas_decimais_cfin = New System.Windows.Forms.ComboBox()
        Me.texto_vf_simples_cfin = New System.Windows.Forms.Label()
        Me.texto_tempo_simples_cfin = New System.Windows.Forms.Label()
        Me.texto_vp_simples_cfin = New System.Windows.Forms.Label()
        Me.GrupoCalculosFinanceiros = New System.Windows.Forms.GroupBox()
        Me.btn_visualizar_impressao_cf = New System.Windows.Forms.Button()
        Me.btn_imprimir_cf = New System.Windows.Forms.Button()
        Me.GrupoJurosSC = New System.Windows.Forms.GroupBox()
        Me.GrupoInicioFim = New System.Windows.Forms.GroupBox()
        Me.rdo_fim_periodo_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_inicio_periodo_cfin = New System.Windows.Forms.RadioButton()
        Me.btn_calcular_cfin = New System.Windows.Forms.Button()
        Me.GrupoEscolhaCalculos = New System.Windows.Forms.GroupBox()
        Me.rdo_vpl2_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_vp_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_taxa_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_n_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_vf_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_pmt_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_montante_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_juros_simples_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_juros_compostos_cfin = New System.Windows.Forms.RadioButton()
        Me.texto_montante_juros_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_montante_juros_cfin = New System.Windows.Forms.TextBox()
        Me.GrupoEqJurosCompostos = New System.Windows.Forms.GroupBox()
        Me.caixatexto_transformar_percentual = New System.Windows.Forms.TextBox()
        Me.texto_transformar_percentual = New System.Windows.Forms.Label()
        Me.GrupoEqJurosSimples = New System.Windows.Forms.GroupBox()
        Me.caixatexto_transformar_percentual_simples = New System.Windows.Forms.TextBox()
        Me.texto_transformar_percentual_simples = New System.Windows.Forms.Label()
        Me.caixacombo_casas_decimais_simples_cfin = New System.Windows.Forms.ComboBox()
        Me.texto_casas_decimais_simples_cfin = New System.Windows.Forms.Label()
        Me.btn_calcular_taxa_simples_cfin = New System.Windows.Forms.Button()
        Me.caixatexto_eq_i_simples_cfin = New System.Windows.Forms.TextBox()
        Me.texto_eq_i_simples_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_eq_taxa_simples_cfin = New System.Windows.Forms.TextBox()
        Me.texto_eq_taxa_simples_cfin = New System.Windows.Forms.Label()
        Me.TabelaJurosECB = New System.Windows.Forms.TableLayoutPanel()
        Me.caixatexto_juros_bancarios_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_juros_comerciais_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_juros_exatos_cfin = New System.Windows.Forms.TextBox()
        Me.caixacombo_exatos_i_ecb_cfin = New System.Windows.Forms.ComboBox()
        Me.texto_casas_decimais_ecb_cfin = New System.Windows.Forms.Label()
        Me.texto_bancarios_ecb_cfin = New System.Windows.Forms.Label()
        Me.texto_comercial_ecb_cfin = New System.Windows.Forms.Label()
        Me.texto_exatos_ecb_cfin = New System.Windows.Forms.Label()
        Me.btn_exatos_i_ecb_cfin = New System.Windows.Forms.Button()
        Me.btn_limpar_ecb_cfin = New System.Windows.Forms.Button()
        Me.texto_juros_ecb = New System.Windows.Forms.Label()
        Me.btn_bancarios_juros_ecb_cfin = New System.Windows.Forms.Button()
        Me.caixacombo_comercial_i_ecb_cfin = New System.Windows.Forms.ComboBox()
        Me.caixacombo_bancarios_i_ecb_cfin = New System.Windows.Forms.ComboBox()
        Me.texto_n_ecb_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_exatos_n_ecb_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_comercial_n_ecb_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_bancarios_n_ecb_cfin = New System.Windows.Forms.TextBox()
        Me.texto_i_ecb_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_exatos_i_ecb_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_comercial_i_ecb_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_bancarios_i_ecb_cfin = New System.Windows.Forms.TextBox()
        Me.texto_juros_ecb_cfin = New System.Windows.Forms.Label()
        Me.btn_comercial_n_ecb_cfin = New System.Windows.Forms.Button()
        Me.btn_calcular_ano_bissexto = New System.Windows.Forms.Button()
        Me.caixatexto_inserir_i_ecb_cfin = New System.Windows.Forms.TextBox()
        Me.texto_inserir_i_ecb_cfin = New System.Windows.Forms.Label()
        Me.texto_de = New System.Windows.Forms.Label()
        Me.texto_ate = New System.Windows.Forms.Label()
        Me.GrupoJurosECB = New System.Windows.Forms.GroupBox()
        Me.data_ate = New System.Windows.Forms.DateTimePicker()
        Me.data_de = New System.Windows.Forms.DateTimePicker()
        Me.checkbox_ano_bissexto_ecb_cfin = New System.Windows.Forms.CheckBox()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JurosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoConvercaoTaxa = New System.Windows.Forms.GroupBox()
        Me.texto_dias_uteis_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_dias_uteis_cfin = New System.Windows.Forms.TextBox()
        Me.texto_tempo_combo_cfin = New System.Windows.Forms.Label()
        Me.texto_taxa_combo_cfin = New System.Windows.Forms.Label()
        Me.combo_taxa_cfin = New System.Windows.Forms.ComboBox()
        Me.combo_tempo_cfin = New System.Windows.Forms.ComboBox()
        Me.ToolTipCfin = New System.Windows.Forms.ToolTip(Me.components)
        Me.caixatexto_investimento_cfin = New System.Windows.Forms.TextBox()
        Me.texto_vpl_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_vpl_cfin = New System.Windows.Forms.TextBox()
        Me.texto_investimento_cfin = New System.Windows.Forms.Label()
        Me.texto_tir_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_tir_cfin = New System.Windows.Forms.TextBox()
        Me.rdo_vpl_cfin = New System.Windows.Forms.RadioButton()
        Me.rdo_tir_cfin = New System.Windows.Forms.RadioButton()
        Me.GrupoVPLeTIR = New System.Windows.Forms.GroupBox()
        Me.rdo_payback_descontado = New System.Windows.Forms.RadioButton()
        Me.rdo_payback_simples = New System.Windows.Forms.RadioButton()
        Me.rdo_il = New System.Windows.Forms.RadioButton()
        Me.rdo_tirm = New System.Windows.Forms.RadioButton()
        Me.rdo_vpl_il = New System.Windows.Forms.RadioButton()
        Me.btn_vpl_tir_cfin = New System.Windows.Forms.Button()
        Me.RichTextBox_leitura_cfin = New System.Windows.Forms.RichTextBox()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintDocument_cf = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog_cf = New System.Windows.Forms.PrintDialog()
        Me.dgv_fluxos_cf = New System.Windows.Forms.DataGridView()
        Me.Coluna_fluxo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coluna_fluxo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coluna_fluxo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coluna_fluxo4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RichTextBox_informacoes_adicionais = New System.Windows.Forms.RichTextBox()
        Me.GrupoFluxos = New System.Windows.Forms.GroupBox()
        Me.rdo_fluxo4 = New System.Windows.Forms.RadioButton()
        Me.rdo_fluxo3 = New System.Windows.Forms.RadioButton()
        Me.rdo_fluxo2 = New System.Windows.Forms.RadioButton()
        Me.rdo_fluxo1 = New System.Windows.Forms.RadioButton()
        Me.texto_tir2_cfin = New System.Windows.Forms.Label()
        Me.texto_taxa_reinvestimento_cfin = New System.Windows.Forms.Label()
        Me.texto_vpl2_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_taxa_reinvestimento_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_vpl2_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_tir2_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_tirm_cfin = New System.Windows.Forms.TextBox()
        Me.texto_tirm_cfin = New System.Windows.Forms.Label()
        Me.texto_il_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_il_cfin = New System.Windows.Forms.TextBox()
        Me.texto_payback_descontado_cfin = New System.Windows.Forms.Label()
        Me.texto_payback_simples_cfin = New System.Windows.Forms.Label()
        Me.caixatexto_payback_simples_cfin = New System.Windows.Forms.TextBox()
        Me.caixatexto_payback_descontado_cfin = New System.Windows.Forms.TextBox()
        Me.GrupoCalculosFinanceiros.SuspendLayout()
        Me.GrupoJurosSC.SuspendLayout()
        Me.GrupoInicioFim.SuspendLayout()
        Me.GrupoEscolhaCalculos.SuspendLayout()
        Me.GrupoEqJurosCompostos.SuspendLayout()
        Me.GrupoEqJurosSimples.SuspendLayout()
        Me.TabelaJurosECB.SuspendLayout()
        Me.GrupoJurosECB.SuspendLayout()
        Me.GrupoConvercaoTaxa.SuspendLayout()
        Me.GrupoVPLeTIR.SuspendLayout()
        CType(Me.dgv_fluxos_cf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoFluxos.SuspendLayout()
        Me.SuspendLayout()
        '
        'texto_pmt_cfin
        '
        Me.texto_pmt_cfin.AutoSize = True
        Me.texto_pmt_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_pmt_cfin.Location = New System.Drawing.Point(6, 93)
        Me.texto_pmt_cfin.Name = "texto_pmt_cfin"
        Me.texto_pmt_cfin.Size = New System.Drawing.Size(33, 13)
        Me.texto_pmt_cfin.TabIndex = 4
        Me.texto_pmt_cfin.Text = "PMT"
        Me.ToolTipCfin.SetToolTip(Me.texto_pmt_cfin, "Payment amount periodic")
        '
        'caixatexto_vp_cfin
        '
        Me.caixatexto_vp_cfin.Location = New System.Drawing.Point(124, 12)
        Me.caixatexto_vp_cfin.Name = "caixatexto_vp_cfin"
        Me.caixatexto_vp_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vp_cfin.TabIndex = 1
        '
        'caixatexto_tempo_cfin
        '
        Me.caixatexto_tempo_cfin.Location = New System.Drawing.Point(124, 38)
        Me.caixatexto_tempo_cfin.Name = "caixatexto_tempo_cfin"
        Me.caixatexto_tempo_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_tempo_cfin.TabIndex = 2
        '
        'caixatexto_pmt_cfin
        '
        Me.caixatexto_pmt_cfin.Location = New System.Drawing.Point(124, 90)
        Me.caixatexto_pmt_cfin.Name = "caixatexto_pmt_cfin"
        Me.caixatexto_pmt_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_pmt_cfin.TabIndex = 4
        '
        'caixatexto_vf_cfin
        '
        Me.caixatexto_vf_cfin.Location = New System.Drawing.Point(124, 116)
        Me.caixatexto_vf_cfin.Name = "caixatexto_vf_cfin"
        Me.caixatexto_vf_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vf_cfin.TabIndex = 5
        '
        'texto_eq_taxa_cfin
        '
        Me.texto_eq_taxa_cfin.AutoSize = True
        Me.texto_eq_taxa_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_eq_taxa_cfin.Location = New System.Drawing.Point(6, 44)
        Me.texto_eq_taxa_cfin.Name = "texto_eq_taxa_cfin"
        Me.texto_eq_taxa_cfin.Size = New System.Drawing.Size(68, 13)
        Me.texto_eq_taxa_cfin.TabIndex = 16
        Me.texto_eq_taxa_cfin.Text = "Equity rate"
        '
        'caixatexto_eq_taxa_cfin
        '
        Me.caixatexto_eq_taxa_cfin.Location = New System.Drawing.Point(80, 41)
        Me.caixatexto_eq_taxa_cfin.Name = "caixatexto_eq_taxa_cfin"
        Me.caixatexto_eq_taxa_cfin.ReadOnly = True
        Me.caixatexto_eq_taxa_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_eq_taxa_cfin.TabIndex = 28
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
        Me.caixatexto_eq_i_cfin.TabIndex = 26
        '
        'btn_calcular_eq_taxa_cfin
        '
        Me.btn_calcular_eq_taxa_cfin.Enabled = False
        Me.btn_calcular_eq_taxa_cfin.Location = New System.Drawing.Point(200, 39)
        Me.btn_calcular_eq_taxa_cfin.Name = "btn_calcular_eq_taxa_cfin"
        Me.btn_calcular_eq_taxa_cfin.Size = New System.Drawing.Size(159, 23)
        Me.btn_calcular_eq_taxa_cfin.TabIndex = 29
        Me.btn_calcular_eq_taxa_cfin.Text = "Calculate Equity Rate"
        Me.btn_calcular_eq_taxa_cfin.UseVisualStyleBackColor = True
        '
        'texto_decimais_cfin
        '
        Me.texto_decimais_cfin.AutoSize = True
        Me.texto_decimais_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_decimais_cfin.Location = New System.Drawing.Point(365, 44)
        Me.texto_decimais_cfin.Name = "texto_decimais_cfin"
        Me.texto_decimais_cfin.Size = New System.Drawing.Size(52, 13)
        Me.texto_decimais_cfin.TabIndex = 25
        Me.texto_decimais_cfin.Text = "Decimal"
        '
        'caixacombo_casas_decimais_cfin
        '
        Me.caixacombo_casas_decimais_cfin.FormattingEnabled = True
        Me.caixacombo_casas_decimais_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_casas_decimais_cfin.Location = New System.Drawing.Point(429, 41)
        Me.caixacombo_casas_decimais_cfin.Name = "caixacombo_casas_decimais_cfin"
        Me.caixacombo_casas_decimais_cfin.Size = New System.Drawing.Size(62, 21)
        Me.caixacombo_casas_decimais_cfin.TabIndex = 30
        '
        'texto_vf_simples_cfin
        '
        Me.texto_vf_simples_cfin.AutoSize = True
        Me.texto_vf_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vf_simples_cfin.Location = New System.Drawing.Point(6, 123)
        Me.texto_vf_simples_cfin.Name = "texto_vf_simples_cfin"
        Me.texto_vf_simples_cfin.Size = New System.Drawing.Size(79, 13)
        Me.texto_vf_simples_cfin.TabIndex = 32
        Me.texto_vf_simples_cfin.Text = "Future Value"
        Me.ToolTipCfin.SetToolTip(Me.texto_vf_simples_cfin, "It is the future value of a current commitment. (Receive / Pay)")
        '
        'texto_tempo_simples_cfin
        '
        Me.texto_tempo_simples_cfin.AutoSize = True
        Me.texto_tempo_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tempo_simples_cfin.Location = New System.Drawing.Point(6, 39)
        Me.texto_tempo_simples_cfin.Name = "texto_tempo_simples_cfin"
        Me.texto_tempo_simples_cfin.Size = New System.Drawing.Size(35, 13)
        Me.texto_tempo_simples_cfin.TabIndex = 31
        Me.texto_tempo_simples_cfin.Text = "NPer"
        Me.ToolTipCfin.SetToolTip(Me.texto_tempo_simples_cfin, "It is the period of some financial transaction.")
        '
        'texto_vp_simples_cfin
        '
        Me.texto_vp_simples_cfin.AutoSize = True
        Me.texto_vp_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vp_simples_cfin.Location = New System.Drawing.Point(6, 16)
        Me.texto_vp_simples_cfin.Name = "texto_vp_simples_cfin"
        Me.texto_vp_simples_cfin.Size = New System.Drawing.Size(86, 13)
        Me.texto_vp_simples_cfin.TabIndex = 29
        Me.texto_vp_simples_cfin.Text = "Present Value"
        Me.ToolTipCfin.SetToolTip(Me.texto_vp_simples_cfin, "Is the value applied by some financial transaction. (Investment / Loans)")
        '
        'GrupoCalculosFinanceiros
        '
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.btn_visualizar_impressao_cf)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.btn_imprimir_cf)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.GrupoJurosSC)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.texto_vp_simples_cfin)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.texto_montante_juros_cfin)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.caixatexto_montante_juros_cfin)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.texto_pmt_cfin)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.caixatexto_pmt_cfin)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.texto_tempo_simples_cfin)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.caixatexto_vp_cfin)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.caixatexto_vf_cfin)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.texto_vf_simples_cfin)
        Me.GrupoCalculosFinanceiros.Controls.Add(Me.caixatexto_tempo_cfin)
        Me.GrupoCalculosFinanceiros.Location = New System.Drawing.Point(12, 4)
        Me.GrupoCalculosFinanceiros.Name = "GrupoCalculosFinanceiros"
        Me.GrupoCalculosFinanceiros.Size = New System.Drawing.Size(585, 177)
        Me.GrupoCalculosFinanceiros.TabIndex = 45
        Me.GrupoCalculosFinanceiros.TabStop = False
        '
        'btn_visualizar_impressao_cf
        '
        Me.btn_visualizar_impressao_cf.Location = New System.Drawing.Point(15, 148)
        Me.btn_visualizar_impressao_cf.Name = "btn_visualizar_impressao_cf"
        Me.btn_visualizar_impressao_cf.Size = New System.Drawing.Size(111, 23)
        Me.btn_visualizar_impressao_cf.TabIndex = 50
        Me.btn_visualizar_impressao_cf.Text = "Print Preview"
        Me.btn_visualizar_impressao_cf.UseVisualStyleBackColor = True
        '
        'btn_imprimir_cf
        '
        Me.btn_imprimir_cf.Location = New System.Drawing.Point(144, 148)
        Me.btn_imprimir_cf.Name = "btn_imprimir_cf"
        Me.btn_imprimir_cf.Size = New System.Drawing.Size(75, 23)
        Me.btn_imprimir_cf.TabIndex = 47
        Me.btn_imprimir_cf.Text = "Print"
        Me.btn_imprimir_cf.UseVisualStyleBackColor = True
        '
        'GrupoJurosSC
        '
        Me.GrupoJurosSC.Controls.Add(Me.GrupoInicioFim)
        Me.GrupoJurosSC.Controls.Add(Me.btn_calcular_cfin)
        Me.GrupoJurosSC.Controls.Add(Me.GrupoEscolhaCalculos)
        Me.GrupoJurosSC.Controls.Add(Me.rdo_juros_simples_cfin)
        Me.GrupoJurosSC.Controls.Add(Me.rdo_juros_compostos_cfin)
        Me.GrupoJurosSC.Location = New System.Drawing.Point(230, 12)
        Me.GrupoJurosSC.Name = "GrupoJurosSC"
        Me.GrupoJurosSC.Size = New System.Drawing.Size(349, 159)
        Me.GrupoJurosSC.TabIndex = 46
        Me.GrupoJurosSC.TabStop = False
        '
        'GrupoInicioFim
        '
        Me.GrupoInicioFim.Controls.Add(Me.rdo_fim_periodo_cfin)
        Me.GrupoInicioFim.Controls.Add(Me.rdo_inicio_periodo_cfin)
        Me.GrupoInicioFim.Location = New System.Drawing.Point(212, 44)
        Me.GrupoInicioFim.Name = "GrupoInicioFim"
        Me.GrupoInicioFim.Size = New System.Drawing.Size(131, 86)
        Me.GrupoInicioFim.TabIndex = 80
        Me.GrupoInicioFim.TabStop = False
        '
        'rdo_fim_periodo_cfin
        '
        Me.rdo_fim_periodo_cfin.AutoSize = True
        Me.rdo_fim_periodo_cfin.Checked = True
        Me.rdo_fim_periodo_cfin.Location = New System.Drawing.Point(3, 19)
        Me.rdo_fim_periodo_cfin.Name = "rdo_fim_periodo_cfin"
        Me.rdo_fim_periodo_cfin.Size = New System.Drawing.Size(88, 17)
        Me.rdo_fim_periodo_cfin.TabIndex = 16
        Me.rdo_fim_periodo_cfin.TabStop = True
        Me.rdo_fim_periodo_cfin.Text = "End of period"
        Me.ToolTipCfin.SetToolTip(Me.rdo_fim_periodo_cfin, "Ao fim do primeiro período")
        Me.rdo_fim_periodo_cfin.UseVisualStyleBackColor = True
        '
        'rdo_inicio_periodo_cfin
        '
        Me.rdo_inicio_periodo_cfin.AutoSize = True
        Me.rdo_inicio_periodo_cfin.Location = New System.Drawing.Point(3, 42)
        Me.rdo_inicio_periodo_cfin.Name = "rdo_inicio_periodo_cfin"
        Me.rdo_inicio_periodo_cfin.Size = New System.Drawing.Size(96, 17)
        Me.rdo_inicio_periodo_cfin.TabIndex = 17
        Me.rdo_inicio_periodo_cfin.Text = "Begin of period"
        Me.ToolTipCfin.SetToolTip(Me.rdo_inicio_periodo_cfin, "Ao início do primeiro período")
        Me.rdo_inicio_periodo_cfin.UseVisualStyleBackColor = True
        '
        'btn_calcular_cfin
        '
        Me.btn_calcular_cfin.Location = New System.Drawing.Point(221, 15)
        Me.btn_calcular_cfin.Name = "btn_calcular_cfin"
        Me.btn_calcular_cfin.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular_cfin.TabIndex = 8
        Me.btn_calcular_cfin.Text = "Calculate"
        Me.btn_calcular_cfin.UseVisualStyleBackColor = True
        '
        'GrupoEscolhaCalculos
        '
        Me.GrupoEscolhaCalculos.Controls.Add(Me.rdo_vpl2_cfin)
        Me.GrupoEscolhaCalculos.Controls.Add(Me.rdo_vp_cfin)
        Me.GrupoEscolhaCalculos.Controls.Add(Me.rdo_taxa_cfin)
        Me.GrupoEscolhaCalculos.Controls.Add(Me.rdo_n_cfin)
        Me.GrupoEscolhaCalculos.Controls.Add(Me.rdo_vf_cfin)
        Me.GrupoEscolhaCalculos.Controls.Add(Me.rdo_pmt_cfin)
        Me.GrupoEscolhaCalculos.Controls.Add(Me.rdo_montante_cfin)
        Me.GrupoEscolhaCalculos.Location = New System.Drawing.Point(6, 44)
        Me.GrupoEscolhaCalculos.Name = "GrupoEscolhaCalculos"
        Me.GrupoEscolhaCalculos.Size = New System.Drawing.Size(200, 86)
        Me.GrupoEscolhaCalculos.TabIndex = 78
        Me.GrupoEscolhaCalculos.TabStop = False
        '
        'rdo_vpl2_cfin
        '
        Me.rdo_vpl2_cfin.AutoSize = True
        Me.rdo_vpl2_cfin.Location = New System.Drawing.Point(151, 63)
        Me.rdo_vpl2_cfin.Name = "rdo_vpl2_cfin"
        Me.rdo_vpl2_cfin.Size = New System.Drawing.Size(47, 17)
        Me.rdo_vpl2_cfin.TabIndex = 15
        Me.rdo_vpl2_cfin.Text = "NPV"
        Me.rdo_vpl2_cfin.UseVisualStyleBackColor = True
        '
        'rdo_vp_cfin
        '
        Me.rdo_vp_cfin.AutoSize = True
        Me.rdo_vp_cfin.Checked = True
        Me.rdo_vp_cfin.Location = New System.Drawing.Point(6, 19)
        Me.rdo_vp_cfin.Name = "rdo_vp_cfin"
        Me.rdo_vp_cfin.Size = New System.Drawing.Size(91, 17)
        Me.rdo_vp_cfin.TabIndex = 9
        Me.rdo_vp_cfin.TabStop = True
        Me.rdo_vp_cfin.Text = "Present Value"
        Me.rdo_vp_cfin.UseVisualStyleBackColor = True
        '
        'rdo_taxa_cfin
        '
        Me.rdo_taxa_cfin.AutoSize = True
        Me.rdo_taxa_cfin.Location = New System.Drawing.Point(97, 63)
        Me.rdo_taxa_cfin.Name = "rdo_taxa_cfin"
        Me.rdo_taxa_cfin.Size = New System.Drawing.Size(48, 17)
        Me.rdo_taxa_cfin.TabIndex = 14
        Me.rdo_taxa_cfin.Text = "Rate"
        Me.rdo_taxa_cfin.UseVisualStyleBackColor = True
        '
        'rdo_n_cfin
        '
        Me.rdo_n_cfin.AutoSize = True
        Me.rdo_n_cfin.Location = New System.Drawing.Point(103, 19)
        Me.rdo_n_cfin.Name = "rdo_n_cfin"
        Me.rdo_n_cfin.Size = New System.Drawing.Size(48, 17)
        Me.rdo_n_cfin.TabIndex = 10
        Me.rdo_n_cfin.Text = "Nper"
        Me.rdo_n_cfin.UseVisualStyleBackColor = True
        '
        'rdo_vf_cfin
        '
        Me.rdo_vf_cfin.AutoSize = True
        Me.rdo_vf_cfin.Location = New System.Drawing.Point(6, 63)
        Me.rdo_vf_cfin.Name = "rdo_vf_cfin"
        Me.rdo_vf_cfin.Size = New System.Drawing.Size(85, 17)
        Me.rdo_vf_cfin.TabIndex = 13
        Me.rdo_vf_cfin.Text = "Future Value"
        Me.rdo_vf_cfin.UseVisualStyleBackColor = True
        '
        'rdo_pmt_cfin
        '
        Me.rdo_pmt_cfin.AutoSize = True
        Me.rdo_pmt_cfin.Location = New System.Drawing.Point(114, 42)
        Me.rdo_pmt_cfin.Name = "rdo_pmt_cfin"
        Me.rdo_pmt_cfin.Size = New System.Drawing.Size(48, 17)
        Me.rdo_pmt_cfin.TabIndex = 12
        Me.rdo_pmt_cfin.Text = "PMT"
        Me.rdo_pmt_cfin.UseVisualStyleBackColor = True
        '
        'rdo_montante_cfin
        '
        Me.rdo_montante_cfin.AutoSize = True
        Me.rdo_montante_cfin.Enabled = False
        Me.rdo_montante_cfin.Location = New System.Drawing.Point(6, 42)
        Me.rdo_montante_cfin.Name = "rdo_montante_cfin"
        Me.rdo_montante_cfin.Size = New System.Drawing.Size(102, 17)
        Me.rdo_montante_cfin.TabIndex = 11
        Me.rdo_montante_cfin.Text = "Value of Interest"
        Me.rdo_montante_cfin.UseVisualStyleBackColor = True
        '
        'rdo_juros_simples_cfin
        '
        Me.rdo_juros_simples_cfin.AutoSize = True
        Me.rdo_juros_simples_cfin.Location = New System.Drawing.Point(6, 18)
        Me.rdo_juros_simples_cfin.Name = "rdo_juros_simples_cfin"
        Me.rdo_juros_simples_cfin.Size = New System.Drawing.Size(94, 17)
        Me.rdo_juros_simples_cfin.TabIndex = 6
        Me.rdo_juros_simples_cfin.Text = "Simple Interest"
        Me.rdo_juros_simples_cfin.UseVisualStyleBackColor = True
        '
        'rdo_juros_compostos_cfin
        '
        Me.rdo_juros_compostos_cfin.AutoSize = True
        Me.rdo_juros_compostos_cfin.Checked = True
        Me.rdo_juros_compostos_cfin.Location = New System.Drawing.Point(101, 18)
        Me.rdo_juros_compostos_cfin.Name = "rdo_juros_compostos_cfin"
        Me.rdo_juros_compostos_cfin.Size = New System.Drawing.Size(114, 17)
        Me.rdo_juros_compostos_cfin.TabIndex = 7
        Me.rdo_juros_compostos_cfin.TabStop = True
        Me.rdo_juros_compostos_cfin.Text = "Compound Interest"
        Me.rdo_juros_compostos_cfin.UseVisualStyleBackColor = True
        '
        'texto_montante_juros_cfin
        '
        Me.texto_montante_juros_cfin.AutoSize = True
        Me.texto_montante_juros_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_montante_juros_cfin.Location = New System.Drawing.Point(6, 67)
        Me.texto_montante_juros_cfin.Name = "texto_montante_juros_cfin"
        Me.texto_montante_juros_cfin.Size = New System.Drawing.Size(101, 13)
        Me.texto_montante_juros_cfin.TabIndex = 44
        Me.texto_montante_juros_cfin.Text = "Value of Interest"
        Me.ToolTipCfin.SetToolTip(Me.texto_montante_juros_cfin, "It is the amount borrowed plus the interest charged.")
        '
        'caixatexto_montante_juros_cfin
        '
        Me.caixatexto_montante_juros_cfin.Location = New System.Drawing.Point(124, 64)
        Me.caixatexto_montante_juros_cfin.Name = "caixatexto_montante_juros_cfin"
        Me.caixatexto_montante_juros_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_montante_juros_cfin.TabIndex = 3
        '
        'GrupoEqJurosCompostos
        '
        Me.GrupoEqJurosCompostos.Controls.Add(Me.caixacombo_casas_decimais_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.caixatexto_transformar_percentual)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.texto_decimais_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.texto_transformar_percentual)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.btn_calcular_eq_taxa_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.caixatexto_eq_i_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.texto_eq_i_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.caixatexto_eq_taxa_cfin)
        Me.GrupoEqJurosCompostos.Controls.Add(Me.texto_eq_taxa_cfin)
        Me.GrupoEqJurosCompostos.Location = New System.Drawing.Point(6, 122)
        Me.GrupoEqJurosCompostos.Name = "GrupoEqJurosCompostos"
        Me.GrupoEqJurosCompostos.Size = New System.Drawing.Size(562, 66)
        Me.GrupoEqJurosCompostos.TabIndex = 46
        Me.GrupoEqJurosCompostos.TabStop = False
        Me.GrupoEqJurosCompostos.Text = "Compound Interest"
        '
        'caixatexto_transformar_percentual
        '
        Me.caixatexto_transformar_percentual.Location = New System.Drawing.Point(202, 13)
        Me.caixatexto_transformar_percentual.Name = "caixatexto_transformar_percentual"
        Me.caixatexto_transformar_percentual.ReadOnly = True
        Me.caixatexto_transformar_percentual.Size = New System.Drawing.Size(125, 20)
        Me.caixatexto_transformar_percentual.TabIndex = 27
        '
        'texto_transformar_percentual
        '
        Me.texto_transformar_percentual.AutoSize = True
        Me.texto_transformar_percentual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_transformar_percentual.Location = New System.Drawing.Point(128, 16)
        Me.texto_transformar_percentual.Name = "texto_transformar_percentual"
        Me.texto_transformar_percentual.Size = New System.Drawing.Size(72, 13)
        Me.texto_transformar_percentual.TabIndex = 30
        Me.texto_transformar_percentual.Text = "Percentage"
        '
        'GrupoEqJurosSimples
        '
        Me.GrupoEqJurosSimples.Controls.Add(Me.caixatexto_transformar_percentual_simples)
        Me.GrupoEqJurosSimples.Controls.Add(Me.texto_transformar_percentual_simples)
        Me.GrupoEqJurosSimples.Controls.Add(Me.caixacombo_casas_decimais_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.texto_casas_decimais_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.btn_calcular_taxa_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.caixatexto_eq_i_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.texto_eq_i_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.caixatexto_eq_taxa_simples_cfin)
        Me.GrupoEqJurosSimples.Controls.Add(Me.texto_eq_taxa_simples_cfin)
        Me.GrupoEqJurosSimples.Location = New System.Drawing.Point(6, 49)
        Me.GrupoEqJurosSimples.Name = "GrupoEqJurosSimples"
        Me.GrupoEqJurosSimples.Size = New System.Drawing.Size(562, 67)
        Me.GrupoEqJurosSimples.TabIndex = 47
        Me.GrupoEqJurosSimples.TabStop = False
        Me.GrupoEqJurosSimples.Text = "Simple Interest"
        '
        'caixatexto_transformar_percentual_simples
        '
        Me.caixatexto_transformar_percentual_simples.Location = New System.Drawing.Point(202, 13)
        Me.caixatexto_transformar_percentual_simples.Name = "caixatexto_transformar_percentual_simples"
        Me.caixatexto_transformar_percentual_simples.ReadOnly = True
        Me.caixatexto_transformar_percentual_simples.Size = New System.Drawing.Size(125, 20)
        Me.caixatexto_transformar_percentual_simples.TabIndex = 22
        '
        'texto_transformar_percentual_simples
        '
        Me.texto_transformar_percentual_simples.AutoSize = True
        Me.texto_transformar_percentual_simples.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_transformar_percentual_simples.Location = New System.Drawing.Point(128, 16)
        Me.texto_transformar_percentual_simples.Name = "texto_transformar_percentual_simples"
        Me.texto_transformar_percentual_simples.Size = New System.Drawing.Size(72, 13)
        Me.texto_transformar_percentual_simples.TabIndex = 27
        Me.texto_transformar_percentual_simples.Text = "Percentage"
        '
        'caixacombo_casas_decimais_simples_cfin
        '
        Me.caixacombo_casas_decimais_simples_cfin.FormattingEnabled = True
        Me.caixacombo_casas_decimais_simples_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_casas_decimais_simples_cfin.Location = New System.Drawing.Point(476, 41)
        Me.caixacombo_casas_decimais_simples_cfin.Name = "caixacombo_casas_decimais_simples_cfin"
        Me.caixacombo_casas_decimais_simples_cfin.Size = New System.Drawing.Size(62, 21)
        Me.caixacombo_casas_decimais_simples_cfin.TabIndex = 25
        '
        'texto_casas_decimais_simples_cfin
        '
        Me.texto_casas_decimais_simples_cfin.AutoSize = True
        Me.texto_casas_decimais_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_casas_decimais_simples_cfin.Location = New System.Drawing.Point(412, 44)
        Me.texto_casas_decimais_simples_cfin.Name = "texto_casas_decimais_simples_cfin"
        Me.texto_casas_decimais_simples_cfin.Size = New System.Drawing.Size(52, 13)
        Me.texto_casas_decimais_simples_cfin.TabIndex = 25
        Me.texto_casas_decimais_simples_cfin.Text = "Decimal"
        '
        'btn_calcular_taxa_simples_cfin
        '
        Me.btn_calcular_taxa_simples_cfin.Enabled = False
        Me.btn_calcular_taxa_simples_cfin.Location = New System.Drawing.Point(258, 39)
        Me.btn_calcular_taxa_simples_cfin.Name = "btn_calcular_taxa_simples_cfin"
        Me.btn_calcular_taxa_simples_cfin.Size = New System.Drawing.Size(148, 23)
        Me.btn_calcular_taxa_simples_cfin.TabIndex = 24
        Me.btn_calcular_taxa_simples_cfin.Text = "Calculate rate"
        Me.btn_calcular_taxa_simples_cfin.UseVisualStyleBackColor = True
        '
        'caixatexto_eq_i_simples_cfin
        '
        Me.caixatexto_eq_i_simples_cfin.Location = New System.Drawing.Point(22, 13)
        Me.caixatexto_eq_i_simples_cfin.Name = "caixatexto_eq_i_simples_cfin"
        Me.caixatexto_eq_i_simples_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_eq_i_simples_cfin.TabIndex = 21
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
        Me.caixatexto_eq_taxa_simples_cfin.Location = New System.Drawing.Point(138, 41)
        Me.caixatexto_eq_taxa_simples_cfin.Name = "caixatexto_eq_taxa_simples_cfin"
        Me.caixatexto_eq_taxa_simples_cfin.ReadOnly = True
        Me.caixatexto_eq_taxa_simples_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_eq_taxa_simples_cfin.TabIndex = 23
        Me.caixatexto_eq_taxa_simples_cfin.Text = "0"
        '
        'texto_eq_taxa_simples_cfin
        '
        Me.texto_eq_taxa_simples_cfin.AutoSize = True
        Me.texto_eq_taxa_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_eq_taxa_simples_cfin.Location = New System.Drawing.Point(6, 44)
        Me.texto_eq_taxa_simples_cfin.Name = "texto_eq_taxa_simples_cfin"
        Me.texto_eq_taxa_simples_cfin.Size = New System.Drawing.Size(124, 13)
        Me.texto_eq_taxa_simples_cfin.TabIndex = 16
        Me.texto_eq_taxa_simples_cfin.Text = "Rates transformation"
        '
        'TabelaJurosECB
        '
        Me.TabelaJurosECB.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TabelaJurosECB.ColumnCount = 6
        Me.TabelaJurosECB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4186096!))
        Me.TabelaJurosECB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5813904!))
        Me.TabelaJurosECB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TabelaJurosECB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TabelaJurosECB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TabelaJurosECB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TabelaJurosECB.Controls.Add(Me.caixatexto_juros_bancarios_cfin, 1, 3)
        Me.TabelaJurosECB.Controls.Add(Me.caixatexto_juros_comerciais_cfin, 1, 2)
        Me.TabelaJurosECB.Controls.Add(Me.caixatexto_juros_exatos_cfin, 1, 1)
        Me.TabelaJurosECB.Controls.Add(Me.caixacombo_exatos_i_ecb_cfin, 5, 1)
        Me.TabelaJurosECB.Controls.Add(Me.texto_casas_decimais_ecb_cfin, 5, 0)
        Me.TabelaJurosECB.Controls.Add(Me.texto_bancarios_ecb_cfin, 0, 3)
        Me.TabelaJurosECB.Controls.Add(Me.texto_comercial_ecb_cfin, 0, 2)
        Me.TabelaJurosECB.Controls.Add(Me.texto_exatos_ecb_cfin, 0, 1)
        Me.TabelaJurosECB.Controls.Add(Me.btn_exatos_i_ecb_cfin, 4, 2)
        Me.TabelaJurosECB.Controls.Add(Me.btn_limpar_ecb_cfin, 4, 0)
        Me.TabelaJurosECB.Controls.Add(Me.texto_juros_ecb, 0, 0)
        Me.TabelaJurosECB.Controls.Add(Me.btn_bancarios_juros_ecb_cfin, 4, 3)
        Me.TabelaJurosECB.Controls.Add(Me.caixacombo_comercial_i_ecb_cfin, 5, 2)
        Me.TabelaJurosECB.Controls.Add(Me.caixacombo_bancarios_i_ecb_cfin, 5, 3)
        Me.TabelaJurosECB.Controls.Add(Me.texto_n_ecb_cfin, 3, 0)
        Me.TabelaJurosECB.Controls.Add(Me.caixatexto_exatos_n_ecb_cfin, 3, 1)
        Me.TabelaJurosECB.Controls.Add(Me.caixatexto_comercial_n_ecb_cfin, 3, 2)
        Me.TabelaJurosECB.Controls.Add(Me.caixatexto_bancarios_n_ecb_cfin, 3, 3)
        Me.TabelaJurosECB.Controls.Add(Me.texto_i_ecb_cfin, 2, 0)
        Me.TabelaJurosECB.Controls.Add(Me.caixatexto_exatos_i_ecb_cfin, 2, 1)
        Me.TabelaJurosECB.Controls.Add(Me.caixatexto_comercial_i_ecb_cfin, 2, 2)
        Me.TabelaJurosECB.Controls.Add(Me.caixatexto_bancarios_i_ecb_cfin, 2, 3)
        Me.TabelaJurosECB.Controls.Add(Me.texto_juros_ecb_cfin, 1, 0)
        Me.TabelaJurosECB.Controls.Add(Me.btn_comercial_n_ecb_cfin, 4, 1)
        Me.TabelaJurosECB.Location = New System.Drawing.Point(9, 65)
        Me.TabelaJurosECB.Name = "TabelaJurosECB"
        Me.TabelaJurosECB.RowCount = 4
        Me.TabelaJurosECB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.6428604!))
        Me.TabelaJurosECB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.3571396!))
        Me.TabelaJurosECB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TabelaJurosECB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TabelaJurosECB.Size = New System.Drawing.Size(570, 141)
        Me.TabelaJurosECB.TabIndex = 48
        '
        'caixatexto_juros_bancarios_cfin
        '
        Me.caixatexto_juros_bancarios_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixatexto_juros_bancarios_cfin.Location = New System.Drawing.Point(90, 111)
        Me.caixatexto_juros_bancarios_cfin.Name = "caixatexto_juros_bancarios_cfin"
        Me.caixatexto_juros_bancarios_cfin.ReadOnly = True
        Me.caixatexto_juros_bancarios_cfin.Size = New System.Drawing.Size(76, 20)
        Me.caixatexto_juros_bancarios_cfin.TabIndex = 47
        '
        'caixatexto_juros_comerciais_cfin
        '
        Me.caixatexto_juros_comerciais_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixatexto_juros_comerciais_cfin.Location = New System.Drawing.Point(90, 74)
        Me.caixatexto_juros_comerciais_cfin.Name = "caixatexto_juros_comerciais_cfin"
        Me.caixatexto_juros_comerciais_cfin.ReadOnly = True
        Me.caixatexto_juros_comerciais_cfin.Size = New System.Drawing.Size(76, 20)
        Me.caixatexto_juros_comerciais_cfin.TabIndex = 42
        '
        'caixatexto_juros_exatos_cfin
        '
        Me.caixatexto_juros_exatos_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixatexto_juros_exatos_cfin.Location = New System.Drawing.Point(90, 37)
        Me.caixatexto_juros_exatos_cfin.Name = "caixatexto_juros_exatos_cfin"
        Me.caixatexto_juros_exatos_cfin.ReadOnly = True
        Me.caixatexto_juros_exatos_cfin.Size = New System.Drawing.Size(76, 20)
        Me.caixatexto_juros_exatos_cfin.TabIndex = 37
        '
        'caixacombo_exatos_i_ecb_cfin
        '
        Me.caixacombo_exatos_i_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixacombo_exatos_i_ecb_cfin.FormattingEnabled = True
        Me.caixacombo_exatos_i_ecb_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_exatos_i_ecb_cfin.Location = New System.Drawing.Point(496, 37)
        Me.caixacombo_exatos_i_ecb_cfin.Name = "caixacombo_exatos_i_ecb_cfin"
        Me.caixacombo_exatos_i_ecb_cfin.Size = New System.Drawing.Size(60, 21)
        Me.caixacombo_exatos_i_ecb_cfin.TabIndex = 41
        '
        'texto_casas_decimais_ecb_cfin
        '
        Me.texto_casas_decimais_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.texto_casas_decimais_ecb_cfin.AutoSize = True
        Me.texto_casas_decimais_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_casas_decimais_ecb_cfin.Location = New System.Drawing.Point(500, 3)
        Me.texto_casas_decimais_ecb_cfin.Name = "texto_casas_decimais_ecb_cfin"
        Me.texto_casas_decimais_ecb_cfin.Size = New System.Drawing.Size(52, 13)
        Me.texto_casas_decimais_ecb_cfin.TabIndex = 27
        Me.texto_casas_decimais_ecb_cfin.Text = "Decimal"
        '
        'texto_bancarios_ecb_cfin
        '
        Me.texto_bancarios_ecb_cfin.AutoSize = True
        Me.texto_bancarios_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_bancarios_ecb_cfin.Location = New System.Drawing.Point(6, 108)
        Me.texto_bancarios_ecb_cfin.Name = "texto_bancarios_ecb_cfin"
        Me.texto_bancarios_ecb_cfin.Size = New System.Drawing.Size(53, 13)
        Me.texto_bancarios_ecb_cfin.TabIndex = 49
        Me.texto_bancarios_ecb_cfin.Text = "Banking"
        '
        'texto_comercial_ecb_cfin
        '
        Me.texto_comercial_ecb_cfin.AutoSize = True
        Me.texto_comercial_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_comercial_ecb_cfin.Location = New System.Drawing.Point(6, 71)
        Me.texto_comercial_ecb_cfin.Name = "texto_comercial_ecb_cfin"
        Me.texto_comercial_ecb_cfin.Size = New System.Drawing.Size(71, 13)
        Me.texto_comercial_ecb_cfin.TabIndex = 49
        Me.texto_comercial_ecb_cfin.Text = "Commercial"
        '
        'texto_exatos_ecb_cfin
        '
        Me.texto_exatos_ecb_cfin.AutoSize = True
        Me.texto_exatos_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_exatos_ecb_cfin.Location = New System.Drawing.Point(6, 34)
        Me.texto_exatos_ecb_cfin.Name = "texto_exatos_ecb_cfin"
        Me.texto_exatos_ecb_cfin.Size = New System.Drawing.Size(58, 13)
        Me.texto_exatos_ecb_cfin.TabIndex = 49
        Me.texto_exatos_ecb_cfin.Text = "Accurate"
        '
        'btn_exatos_i_ecb_cfin
        '
        Me.btn_exatos_i_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_exatos_i_ecb_cfin.Location = New System.Drawing.Point(378, 74)
        Me.btn_exatos_i_ecb_cfin.Name = "btn_exatos_i_ecb_cfin"
        Me.btn_exatos_i_ecb_cfin.Size = New System.Drawing.Size(100, 23)
        Me.btn_exatos_i_ecb_cfin.TabIndex = 45
        Me.btn_exatos_i_ecb_cfin.Text = "Calculate i"
        Me.btn_exatos_i_ecb_cfin.UseVisualStyleBackColor = True
        '
        'btn_limpar_ecb_cfin
        '
        Me.btn_limpar_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_limpar_ecb_cfin.Location = New System.Drawing.Point(377, 6)
        Me.btn_limpar_ecb_cfin.Name = "btn_limpar_ecb_cfin"
        Me.btn_limpar_ecb_cfin.Size = New System.Drawing.Size(102, 22)
        Me.btn_limpar_ecb_cfin.TabIndex = 36
        Me.btn_limpar_ecb_cfin.Text = "Clear"
        Me.btn_limpar_ecb_cfin.UseVisualStyleBackColor = True
        '
        'texto_juros_ecb
        '
        Me.texto_juros_ecb.AutoSize = True
        Me.texto_juros_ecb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_juros_ecb.Location = New System.Drawing.Point(6, 3)
        Me.texto_juros_ecb.Name = "texto_juros_ecb"
        Me.texto_juros_ecb.Size = New System.Drawing.Size(50, 13)
        Me.texto_juros_ecb.TabIndex = 27
        Me.texto_juros_ecb.Text = "Interest"
        '
        'btn_bancarios_juros_ecb_cfin
        '
        Me.btn_bancarios_juros_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_bancarios_juros_ecb_cfin.Location = New System.Drawing.Point(378, 111)
        Me.btn_bancarios_juros_ecb_cfin.Name = "btn_bancarios_juros_ecb_cfin"
        Me.btn_bancarios_juros_ecb_cfin.Size = New System.Drawing.Size(100, 22)
        Me.btn_bancarios_juros_ecb_cfin.TabIndex = 50
        Me.btn_bancarios_juros_ecb_cfin.Text = "Calculate Interest"
        Me.btn_bancarios_juros_ecb_cfin.UseVisualStyleBackColor = True
        '
        'caixacombo_comercial_i_ecb_cfin
        '
        Me.caixacombo_comercial_i_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixacombo_comercial_i_ecb_cfin.FormattingEnabled = True
        Me.caixacombo_comercial_i_ecb_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_comercial_i_ecb_cfin.Location = New System.Drawing.Point(496, 74)
        Me.caixacombo_comercial_i_ecb_cfin.Name = "caixacombo_comercial_i_ecb_cfin"
        Me.caixacombo_comercial_i_ecb_cfin.Size = New System.Drawing.Size(60, 21)
        Me.caixacombo_comercial_i_ecb_cfin.TabIndex = 46
        '
        'caixacombo_bancarios_i_ecb_cfin
        '
        Me.caixacombo_bancarios_i_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixacombo_bancarios_i_ecb_cfin.FormattingEnabled = True
        Me.caixacombo_bancarios_i_ecb_cfin.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_bancarios_i_ecb_cfin.Location = New System.Drawing.Point(496, 111)
        Me.caixacombo_bancarios_i_ecb_cfin.Name = "caixacombo_bancarios_i_ecb_cfin"
        Me.caixacombo_bancarios_i_ecb_cfin.Size = New System.Drawing.Size(60, 21)
        Me.caixacombo_bancarios_i_ecb_cfin.TabIndex = 51
        '
        'texto_n_ecb_cfin
        '
        Me.texto_n_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.texto_n_ecb_cfin.AutoSize = True
        Me.texto_n_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_n_ecb_cfin.Location = New System.Drawing.Point(324, 3)
        Me.texto_n_ecb_cfin.Name = "texto_n_ecb_cfin"
        Me.texto_n_ecb_cfin.Size = New System.Drawing.Size(14, 13)
        Me.texto_n_ecb_cfin.TabIndex = 49
        Me.texto_n_ecb_cfin.Text = "n"
        '
        'caixatexto_exatos_n_ecb_cfin
        '
        Me.caixatexto_exatos_n_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixatexto_exatos_n_ecb_cfin.Location = New System.Drawing.Point(296, 37)
        Me.caixatexto_exatos_n_ecb_cfin.Name = "caixatexto_exatos_n_ecb_cfin"
        Me.caixatexto_exatos_n_ecb_cfin.ReadOnly = True
        Me.caixatexto_exatos_n_ecb_cfin.Size = New System.Drawing.Size(69, 20)
        Me.caixatexto_exatos_n_ecb_cfin.TabIndex = 39
        '
        'caixatexto_comercial_n_ecb_cfin
        '
        Me.caixatexto_comercial_n_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixatexto_comercial_n_ecb_cfin.Location = New System.Drawing.Point(296, 74)
        Me.caixatexto_comercial_n_ecb_cfin.Name = "caixatexto_comercial_n_ecb_cfin"
        Me.caixatexto_comercial_n_ecb_cfin.ReadOnly = True
        Me.caixatexto_comercial_n_ecb_cfin.Size = New System.Drawing.Size(69, 20)
        Me.caixatexto_comercial_n_ecb_cfin.TabIndex = 44
        '
        'caixatexto_bancarios_n_ecb_cfin
        '
        Me.caixatexto_bancarios_n_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixatexto_bancarios_n_ecb_cfin.Location = New System.Drawing.Point(296, 111)
        Me.caixatexto_bancarios_n_ecb_cfin.Name = "caixatexto_bancarios_n_ecb_cfin"
        Me.caixatexto_bancarios_n_ecb_cfin.ReadOnly = True
        Me.caixatexto_bancarios_n_ecb_cfin.Size = New System.Drawing.Size(69, 20)
        Me.caixatexto_bancarios_n_ecb_cfin.TabIndex = 49
        '
        'texto_i_ecb_cfin
        '
        Me.texto_i_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.texto_i_ecb_cfin.AutoSize = True
        Me.texto_i_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_i_ecb_cfin.Location = New System.Drawing.Point(225, 3)
        Me.texto_i_ecb_cfin.Name = "texto_i_ecb_cfin"
        Me.texto_i_ecb_cfin.Size = New System.Drawing.Size(10, 13)
        Me.texto_i_ecb_cfin.TabIndex = 28
        Me.texto_i_ecb_cfin.Text = "i"
        '
        'caixatexto_exatos_i_ecb_cfin
        '
        Me.caixatexto_exatos_i_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixatexto_exatos_i_ecb_cfin.Location = New System.Drawing.Point(180, 37)
        Me.caixatexto_exatos_i_ecb_cfin.Name = "caixatexto_exatos_i_ecb_cfin"
        Me.caixatexto_exatos_i_ecb_cfin.ReadOnly = True
        Me.caixatexto_exatos_i_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_exatos_i_ecb_cfin.TabIndex = 38
        '
        'caixatexto_comercial_i_ecb_cfin
        '
        Me.caixatexto_comercial_i_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixatexto_comercial_i_ecb_cfin.Location = New System.Drawing.Point(180, 74)
        Me.caixatexto_comercial_i_ecb_cfin.Name = "caixatexto_comercial_i_ecb_cfin"
        Me.caixatexto_comercial_i_ecb_cfin.ReadOnly = True
        Me.caixatexto_comercial_i_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_comercial_i_ecb_cfin.TabIndex = 43
        '
        'caixatexto_bancarios_i_ecb_cfin
        '
        Me.caixatexto_bancarios_i_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.caixatexto_bancarios_i_ecb_cfin.Location = New System.Drawing.Point(180, 111)
        Me.caixatexto_bancarios_i_ecb_cfin.Name = "caixatexto_bancarios_i_ecb_cfin"
        Me.caixatexto_bancarios_i_ecb_cfin.ReadOnly = True
        Me.caixatexto_bancarios_i_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_bancarios_i_ecb_cfin.TabIndex = 48
        '
        'texto_juros_ecb_cfin
        '
        Me.texto_juros_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.texto_juros_ecb_cfin.AutoSize = True
        Me.texto_juros_ecb_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_juros_ecb_cfin.Location = New System.Drawing.Point(103, 3)
        Me.texto_juros_ecb_cfin.Name = "texto_juros_ecb_cfin"
        Me.texto_juros_ecb_cfin.Size = New System.Drawing.Size(50, 13)
        Me.texto_juros_ecb_cfin.TabIndex = 66
        Me.texto_juros_ecb_cfin.Text = "Interest"
        '
        'btn_comercial_n_ecb_cfin
        '
        Me.btn_comercial_n_ecb_cfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_comercial_n_ecb_cfin.Location = New System.Drawing.Point(377, 37)
        Me.btn_comercial_n_ecb_cfin.Name = "btn_comercial_n_ecb_cfin"
        Me.btn_comercial_n_ecb_cfin.Size = New System.Drawing.Size(102, 22)
        Me.btn_comercial_n_ecb_cfin.TabIndex = 40
        Me.btn_comercial_n_ecb_cfin.Text = "Calculate n"
        Me.btn_comercial_n_ecb_cfin.UseVisualStyleBackColor = True
        '
        'btn_calcular_ano_bissexto
        '
        Me.btn_calcular_ano_bissexto.Location = New System.Drawing.Point(225, 10)
        Me.btn_calcular_ano_bissexto.Name = "btn_calcular_ano_bissexto"
        Me.btn_calcular_ano_bissexto.Size = New System.Drawing.Size(93, 22)
        Me.btn_calcular_ano_bissexto.TabIndex = 33
        Me.btn_calcular_ano_bissexto.Text = "Bissextile Year"
        Me.btn_calcular_ano_bissexto.UseVisualStyleBackColor = True
        '
        'caixatexto_inserir_i_ecb_cfin
        '
        Me.caixatexto_inserir_i_ecb_cfin.Location = New System.Drawing.Point(26, 12)
        Me.caixatexto_inserir_i_ecb_cfin.Name = "caixatexto_inserir_i_ecb_cfin"
        Me.caixatexto_inserir_i_ecb_cfin.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_inserir_i_ecb_cfin.TabIndex = 31
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
        'texto_de
        '
        Me.texto_de.AutoSize = True
        Me.texto_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_de.Location = New System.Drawing.Point(6, 42)
        Me.texto_de.Name = "texto_de"
        Me.texto_de.Size = New System.Drawing.Size(46, 13)
        Me.texto_de.TabIndex = 63
        Me.texto_de.Text = "n from:"
        '
        'texto_ate
        '
        Me.texto_ate.AutoSize = True
        Me.texto_ate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_ate.Location = New System.Drawing.Point(279, 42)
        Me.texto_ate.Name = "texto_ate"
        Me.texto_ate.Size = New System.Drawing.Size(18, 13)
        Me.texto_ate.TabIndex = 63
        Me.texto_ate.Text = "to"
        '
        'GrupoJurosECB
        '
        Me.GrupoJurosECB.Controls.Add(Me.btn_calcular_ano_bissexto)
        Me.GrupoJurosECB.Controls.Add(Me.data_ate)
        Me.GrupoJurosECB.Controls.Add(Me.data_de)
        Me.GrupoJurosECB.Controls.Add(Me.checkbox_ano_bissexto_ecb_cfin)
        Me.GrupoJurosECB.Controls.Add(Me.texto_inserir_i_ecb_cfin)
        Me.GrupoJurosECB.Controls.Add(Me.TabelaJurosECB)
        Me.GrupoJurosECB.Controls.Add(Me.caixatexto_inserir_i_ecb_cfin)
        Me.GrupoJurosECB.Controls.Add(Me.texto_de)
        Me.GrupoJurosECB.Controls.Add(Me.texto_ate)
        Me.GrupoJurosECB.Location = New System.Drawing.Point(12, 388)
        Me.GrupoJurosECB.Name = "GrupoJurosECB"
        Me.GrupoJurosECB.Size = New System.Drawing.Size(585, 214)
        Me.GrupoJurosECB.TabIndex = 66
        Me.GrupoJurosECB.TabStop = False
        '
        'data_ate
        '
        Me.data_ate.CustomFormat = ""
        Me.data_ate.Location = New System.Drawing.Point(310, 38)
        Me.data_ate.Name = "data_ate"
        Me.data_ate.Size = New System.Drawing.Size(215, 20)
        Me.data_ate.TabIndex = 35
        '
        'data_de
        '
        Me.data_de.CustomFormat = ""
        Me.data_de.Location = New System.Drawing.Point(58, 38)
        Me.data_de.Name = "data_de"
        Me.data_de.Size = New System.Drawing.Size(215, 20)
        Me.data_de.TabIndex = 34
        '
        'checkbox_ano_bissexto_ecb_cfin
        '
        Me.checkbox_ano_bissexto_ecb_cfin.AutoSize = True
        Me.checkbox_ano_bissexto_ecb_cfin.Location = New System.Drawing.Point(132, 14)
        Me.checkbox_ano_bissexto_ecb_cfin.Name = "checkbox_ano_bissexto_ecb_cfin"
        Me.checkbox_ano_bissexto_ecb_cfin.Size = New System.Drawing.Size(94, 17)
        Me.checkbox_ano_bissexto_ecb_cfin.TabIndex = 32
        Me.checkbox_ano_bissexto_ecb_cfin.Text = "Bissextile Year"
        Me.checkbox_ano_bissexto_ecb_cfin.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        '
        'EntradaDataGridViewTextBoxColumn
        '
        Me.EntradaDataGridViewTextBoxColumn.Name = "EntradaDataGridViewTextBoxColumn"
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        '
        'JurosDataGridViewTextBoxColumn
        '
        Me.JurosDataGridViewTextBoxColumn.Name = "JurosDataGridViewTextBoxColumn"
        '
        'NDataGridViewTextBoxColumn
        '
        Me.NDataGridViewTextBoxColumn.Name = "NDataGridViewTextBoxColumn"
        '
        'GrupoConvercaoTaxa
        '
        Me.GrupoConvercaoTaxa.Controls.Add(Me.texto_dias_uteis_cfin)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.caixatexto_dias_uteis_cfin)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.texto_tempo_combo_cfin)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.texto_taxa_combo_cfin)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.combo_taxa_cfin)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.combo_tempo_cfin)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.GrupoEqJurosCompostos)
        Me.GrupoConvercaoTaxa.Controls.Add(Me.GrupoEqJurosSimples)
        Me.GrupoConvercaoTaxa.Location = New System.Drawing.Point(12, 184)
        Me.GrupoConvercaoTaxa.Name = "GrupoConvercaoTaxa"
        Me.GrupoConvercaoTaxa.Size = New System.Drawing.Size(585, 198)
        Me.GrupoConvercaoTaxa.TabIndex = 68
        Me.GrupoConvercaoTaxa.TabStop = False
        Me.GrupoConvercaoTaxa.Text = "Rates transformation"
        '
        'texto_dias_uteis_cfin
        '
        Me.texto_dias_uteis_cfin.AutoSize = True
        Me.texto_dias_uteis_cfin.Location = New System.Drawing.Point(324, 25)
        Me.texto_dias_uteis_cfin.Name = "texto_dias_uteis_cfin"
        Me.texto_dias_uteis_cfin.Size = New System.Drawing.Size(57, 13)
        Me.texto_dias_uteis_cfin.TabIndex = 52
        Me.texto_dias_uteis_cfin.Text = "Day useful"
        '
        'caixatexto_dias_uteis_cfin
        '
        Me.caixatexto_dias_uteis_cfin.Location = New System.Drawing.Point(387, 22)
        Me.caixatexto_dias_uteis_cfin.Name = "caixatexto_dias_uteis_cfin"
        Me.caixatexto_dias_uteis_cfin.Size = New System.Drawing.Size(53, 20)
        Me.caixatexto_dias_uteis_cfin.TabIndex = 20
        Me.caixatexto_dias_uteis_cfin.Text = "22"
        '
        'texto_tempo_combo_cfin
        '
        Me.texto_tempo_combo_cfin.AutoSize = True
        Me.texto_tempo_combo_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tempo_combo_cfin.Location = New System.Drawing.Point(163, 25)
        Me.texto_tempo_combo_cfin.Name = "texto_tempo_combo_cfin"
        Me.texto_tempo_combo_cfin.Size = New System.Drawing.Size(35, 13)
        Me.texto_tempo_combo_cfin.TabIndex = 49
        Me.texto_tempo_combo_cfin.Text = "NPer"
        '
        'texto_taxa_combo_cfin
        '
        Me.texto_taxa_combo_cfin.AutoSize = True
        Me.texto_taxa_combo_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_taxa_combo_cfin.Location = New System.Drawing.Point(6, 25)
        Me.texto_taxa_combo_cfin.Name = "texto_taxa_combo_cfin"
        Me.texto_taxa_combo_cfin.Size = New System.Drawing.Size(34, 13)
        Me.texto_taxa_combo_cfin.TabIndex = 47
        Me.texto_taxa_combo_cfin.Text = "Rate"
        '
        'combo_taxa_cfin
        '
        Me.combo_taxa_cfin.FormattingEnabled = True
        Me.combo_taxa_cfin.Items.AddRange(New Object() {"By day useful", "Daily", "Monthly", "Bimonthly", "Quarterly", "4 months", "Semester", "Annual (Civil)", "Annual (Commercial)", "Annual (Bissextile)"})
        Me.combo_taxa_cfin.Location = New System.Drawing.Point(47, 22)
        Me.combo_taxa_cfin.Name = "combo_taxa_cfin"
        Me.combo_taxa_cfin.Size = New System.Drawing.Size(110, 21)
        Me.combo_taxa_cfin.TabIndex = 18
        Me.combo_taxa_cfin.Text = "Monthly"
        '
        'combo_tempo_cfin
        '
        Me.combo_tempo_cfin.FormattingEnabled = True
        Me.combo_tempo_cfin.Items.AddRange(New Object() {"By day useful", "Daily", "Monthly", "Bimonthly", "Quarterly", "4 months", "Semester", "Annual (Civil)", "Annual (Commercial)", "Annual (Bissextile)"})
        Me.combo_tempo_cfin.Location = New System.Drawing.Point(208, 22)
        Me.combo_tempo_cfin.Name = "combo_tempo_cfin"
        Me.combo_tempo_cfin.Size = New System.Drawing.Size(110, 21)
        Me.combo_tempo_cfin.TabIndex = 19
        Me.combo_tempo_cfin.Text = "Monthly"
        '
        'caixatexto_investimento_cfin
        '
        Me.caixatexto_investimento_cfin.Location = New System.Drawing.Point(766, 13)
        Me.caixatexto_investimento_cfin.Name = "caixatexto_investimento_cfin"
        Me.caixatexto_investimento_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_investimento_cfin.TabIndex = 52
        Me.ToolTipCfin.SetToolTip(Me.caixatexto_investimento_cfin, "O investimento é sempre negativo!")
        '
        'texto_vpl_cfin
        '
        Me.texto_vpl_cfin.AutoSize = True
        Me.texto_vpl_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vpl_cfin.Location = New System.Drawing.Point(603, 70)
        Me.texto_vpl_cfin.Name = "texto_vpl_cfin"
        Me.texto_vpl_cfin.Size = New System.Drawing.Size(110, 13)
        Me.texto_vpl_cfin.TabIndex = 49
        Me.texto_vpl_cfin.Text = "Net Present Value"
        '
        'caixatexto_vpl_cfin
        '
        Me.caixatexto_vpl_cfin.Location = New System.Drawing.Point(766, 65)
        Me.caixatexto_vpl_cfin.Name = "caixatexto_vpl_cfin"
        Me.caixatexto_vpl_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_vpl_cfin.TabIndex = 55
        '
        'texto_investimento_cfin
        '
        Me.texto_investimento_cfin.AutoSize = True
        Me.texto_investimento_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_investimento_cfin.Location = New System.Drawing.Point(603, 15)
        Me.texto_investimento_cfin.Name = "texto_investimento_cfin"
        Me.texto_investimento_cfin.Size = New System.Drawing.Size(130, 13)
        Me.texto_investimento_cfin.TabIndex = 69
        Me.texto_investimento_cfin.Text = "Investment (negative)"
        '
        'texto_tir_cfin
        '
        Me.texto_tir_cfin.AutoSize = True
        Me.texto_tir_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tir_cfin.Location = New System.Drawing.Point(603, 120)
        Me.texto_tir_cfin.Name = "texto_tir_cfin"
        Me.texto_tir_cfin.Size = New System.Drawing.Size(138, 13)
        Me.texto_tir_cfin.TabIndex = 72
        Me.texto_tir_cfin.Text = "Internal Rate of Return"
        '
        'caixatexto_tir_cfin
        '
        Me.caixatexto_tir_cfin.Location = New System.Drawing.Point(766, 117)
        Me.caixatexto_tir_cfin.Name = "caixatexto_tir_cfin"
        Me.caixatexto_tir_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_tir_cfin.TabIndex = 57
        '
        'rdo_vpl_cfin
        '
        Me.rdo_vpl_cfin.AutoSize = True
        Me.rdo_vpl_cfin.Checked = True
        Me.rdo_vpl_cfin.Location = New System.Drawing.Point(6, 19)
        Me.rdo_vpl_cfin.Name = "rdo_vpl_cfin"
        Me.rdo_vpl_cfin.Size = New System.Drawing.Size(82, 17)
        Me.rdo_vpl_cfin.TabIndex = 67
        Me.rdo_vpl_cfin.TabStop = True
        Me.rdo_vpl_cfin.Text = "NPV (PV - I)"
        Me.rdo_vpl_cfin.UseVisualStyleBackColor = True
        '
        'rdo_tir_cfin
        '
        Me.rdo_tir_cfin.AutoSize = True
        Me.rdo_tir_cfin.Location = New System.Drawing.Point(6, 65)
        Me.rdo_tir_cfin.Name = "rdo_tir_cfin"
        Me.rdo_tir_cfin.Size = New System.Drawing.Size(44, 17)
        Me.rdo_tir_cfin.TabIndex = 69
        Me.rdo_tir_cfin.Text = "IRR"
        Me.rdo_tir_cfin.UseVisualStyleBackColor = True
        '
        'GrupoVPLeTIR
        '
        Me.GrupoVPLeTIR.Controls.Add(Me.rdo_payback_descontado)
        Me.GrupoVPLeTIR.Controls.Add(Me.rdo_payback_simples)
        Me.GrupoVPLeTIR.Controls.Add(Me.rdo_il)
        Me.GrupoVPLeTIR.Controls.Add(Me.rdo_tirm)
        Me.GrupoVPLeTIR.Controls.Add(Me.rdo_vpl_il)
        Me.GrupoVPLeTIR.Controls.Add(Me.rdo_vpl_cfin)
        Me.GrupoVPLeTIR.Controls.Add(Me.rdo_tir_cfin)
        Me.GrupoVPLeTIR.Controls.Add(Me.btn_vpl_tir_cfin)
        Me.GrupoVPLeTIR.Location = New System.Drawing.Point(6, 67)
        Me.GrupoVPLeTIR.Name = "GrupoVPLeTIR"
        Me.GrupoVPLeTIR.Size = New System.Drawing.Size(143, 188)
        Me.GrupoVPLeTIR.TabIndex = 78
        Me.GrupoVPLeTIR.TabStop = False
        Me.GrupoVPLeTIR.Text = "Assessment Methods"
        '
        'rdo_payback_descontado
        '
        Me.rdo_payback_descontado.AutoSize = True
        Me.rdo_payback_descontado.Location = New System.Drawing.Point(6, 134)
        Me.rdo_payback_descontado.Name = "rdo_payback_descontado"
        Me.rdo_payback_descontado.Size = New System.Drawing.Size(124, 17)
        Me.rdo_payback_descontado.TabIndex = 73
        Me.rdo_payback_descontado.TabStop = True
        Me.rdo_payback_descontado.Text = "Discounted Payback"
        Me.rdo_payback_descontado.UseVisualStyleBackColor = True
        '
        'rdo_payback_simples
        '
        Me.rdo_payback_simples.AutoSize = True
        Me.rdo_payback_simples.Location = New System.Drawing.Point(6, 111)
        Me.rdo_payback_simples.Name = "rdo_payback_simples"
        Me.rdo_payback_simples.Size = New System.Drawing.Size(101, 17)
        Me.rdo_payback_simples.TabIndex = 72
        Me.rdo_payback_simples.TabStop = True
        Me.rdo_payback_simples.Text = "Simple Payback"
        Me.rdo_payback_simples.UseVisualStyleBackColor = True
        '
        'rdo_il
        '
        Me.rdo_il.AutoSize = True
        Me.rdo_il.Location = New System.Drawing.Point(6, 88)
        Me.rdo_il.Name = "rdo_il"
        Me.rdo_il.Size = New System.Drawing.Size(104, 17)
        Me.rdo_il.TabIndex = 71
        Me.rdo_il.TabStop = True
        Me.rdo_il.Text = "Profitability Index"
        Me.rdo_il.UseVisualStyleBackColor = True
        '
        'rdo_tirm
        '
        Me.rdo_tirm.AutoSize = True
        Me.rdo_tirm.Location = New System.Drawing.Point(55, 65)
        Me.rdo_tirm.Name = "rdo_tirm"
        Me.rdo_tirm.Size = New System.Drawing.Size(53, 17)
        Me.rdo_tirm.TabIndex = 70
        Me.rdo_tirm.TabStop = True
        Me.rdo_tirm.Text = "MIRR"
        Me.rdo_tirm.UseVisualStyleBackColor = True
        '
        'rdo_vpl_il
        '
        Me.rdo_vpl_il.AutoSize = True
        Me.rdo_vpl_il.Location = New System.Drawing.Point(6, 42)
        Me.rdo_vpl_il.Name = "rdo_vpl_il"
        Me.rdo_vpl_il.Size = New System.Drawing.Size(66, 17)
        Me.rdo_vpl_il.TabIndex = 68
        Me.rdo_vpl_il.TabStop = True
        Me.rdo_vpl_il.Text = "NPV (PI)"
        Me.rdo_vpl_il.UseVisualStyleBackColor = True
        '
        'btn_vpl_tir_cfin
        '
        Me.btn_vpl_tir_cfin.Location = New System.Drawing.Point(6, 160)
        Me.btn_vpl_tir_cfin.Name = "btn_vpl_tir_cfin"
        Me.btn_vpl_tir_cfin.Size = New System.Drawing.Size(75, 23)
        Me.btn_vpl_tir_cfin.TabIndex = 74
        Me.btn_vpl_tir_cfin.Text = "Calculate"
        Me.btn_vpl_tir_cfin.UseVisualStyleBackColor = True
        '
        'RichTextBox_leitura_cfin
        '
        Me.RichTextBox_leitura_cfin.Location = New System.Drawing.Point(603, 416)
        Me.RichTextBox_leitura_cfin.Name = "RichTextBox_leitura_cfin"
        Me.RichTextBox_leitura_cfin.Size = New System.Drawing.Size(252, 186)
        Me.RichTextBox_leitura_cfin.TabIndex = 76
        Me.RichTextBox_leitura_cfin.Text = resources.GetString("RichTextBox_leitura_cfin.Text")
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintDocument_cf
        '
        '
        'PrintDialog_cf
        '
        Me.PrintDialog_cf.UseEXDialog = True
        '
        'dgv_fluxos_cf
        '
        Me.dgv_fluxos_cf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_fluxos_cf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fluxos_cf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Coluna_fluxo1, Me.Coluna_fluxo2, Me.Coluna_fluxo3, Me.Coluna_fluxo4})
        Me.dgv_fluxos_cf.Location = New System.Drawing.Point(603, 281)
        Me.dgv_fluxos_cf.Name = "dgv_fluxos_cf"
        Me.dgv_fluxos_cf.RowHeadersWidth = 30
        Me.dgv_fluxos_cf.Size = New System.Drawing.Size(413, 129)
        Me.dgv_fluxos_cf.TabIndex = 75
        '
        'Coluna_fluxo1
        '
        Me.Coluna_fluxo1.HeaderText = "Column 1"
        Me.Coluna_fluxo1.Name = "Coluna_fluxo1"
        '
        'Coluna_fluxo2
        '
        Me.Coluna_fluxo2.HeaderText = "Column 2"
        Me.Coluna_fluxo2.Name = "Coluna_fluxo2"
        '
        'Coluna_fluxo3
        '
        Me.Coluna_fluxo3.HeaderText = "Column 3"
        Me.Coluna_fluxo3.Name = "Coluna_fluxo3"
        '
        'Coluna_fluxo4
        '
        Me.Coluna_fluxo4.HeaderText = "Column 4"
        Me.Coluna_fluxo4.Name = "Coluna_fluxo4"
        '
        'RichTextBox_informacoes_adicionais
        '
        Me.RichTextBox_informacoes_adicionais.Location = New System.Drawing.Point(861, 416)
        Me.RichTextBox_informacoes_adicionais.Name = "RichTextBox_informacoes_adicionais"
        Me.RichTextBox_informacoes_adicionais.Size = New System.Drawing.Size(155, 186)
        Me.RichTextBox_informacoes_adicionais.TabIndex = 77
        Me.RichTextBox_informacoes_adicionais.Text = "Here you can make your notes." & Global.Microsoft.VisualBasic.ChrW(10) & "All information will be saved automatically."
        '
        'GrupoFluxos
        '
        Me.GrupoFluxos.Controls.Add(Me.rdo_fluxo4)
        Me.GrupoFluxos.Controls.Add(Me.rdo_fluxo3)
        Me.GrupoFluxos.Controls.Add(Me.rdo_fluxo2)
        Me.GrupoFluxos.Controls.Add(Me.rdo_fluxo1)
        Me.GrupoFluxos.Controls.Add(Me.GrupoVPLeTIR)
        Me.GrupoFluxos.Location = New System.Drawing.Point(861, 12)
        Me.GrupoFluxos.Name = "GrupoFluxos"
        Me.GrupoFluxos.Size = New System.Drawing.Size(155, 263)
        Me.GrupoFluxos.TabIndex = 94
        Me.GrupoFluxos.TabStop = False
        Me.GrupoFluxos.Text = "Columns"
        '
        'rdo_fluxo4
        '
        Me.rdo_fluxo4.AutoSize = True
        Me.rdo_fluxo4.Location = New System.Drawing.Point(81, 42)
        Me.rdo_fluxo4.Name = "rdo_fluxo4"
        Me.rdo_fluxo4.Size = New System.Drawing.Size(69, 17)
        Me.rdo_fluxo4.TabIndex = 66
        Me.rdo_fluxo4.TabStop = True
        Me.rdo_fluxo4.Text = "Column 4"
        Me.rdo_fluxo4.UseVisualStyleBackColor = True
        '
        'rdo_fluxo3
        '
        Me.rdo_fluxo3.AutoSize = True
        Me.rdo_fluxo3.Location = New System.Drawing.Point(6, 44)
        Me.rdo_fluxo3.Name = "rdo_fluxo3"
        Me.rdo_fluxo3.Size = New System.Drawing.Size(69, 17)
        Me.rdo_fluxo3.TabIndex = 65
        Me.rdo_fluxo3.TabStop = True
        Me.rdo_fluxo3.Text = "Column 3"
        Me.rdo_fluxo3.UseVisualStyleBackColor = True
        '
        'rdo_fluxo2
        '
        Me.rdo_fluxo2.AutoSize = True
        Me.rdo_fluxo2.Location = New System.Drawing.Point(81, 19)
        Me.rdo_fluxo2.Name = "rdo_fluxo2"
        Me.rdo_fluxo2.Size = New System.Drawing.Size(69, 17)
        Me.rdo_fluxo2.TabIndex = 64
        Me.rdo_fluxo2.TabStop = True
        Me.rdo_fluxo2.Text = "Column 2"
        Me.rdo_fluxo2.UseVisualStyleBackColor = True
        '
        'rdo_fluxo1
        '
        Me.rdo_fluxo1.AutoSize = True
        Me.rdo_fluxo1.Checked = True
        Me.rdo_fluxo1.Location = New System.Drawing.Point(6, 19)
        Me.rdo_fluxo1.Name = "rdo_fluxo1"
        Me.rdo_fluxo1.Size = New System.Drawing.Size(69, 17)
        Me.rdo_fluxo1.TabIndex = 63
        Me.rdo_fluxo1.TabStop = True
        Me.rdo_fluxo1.Text = "Column 1"
        Me.rdo_fluxo1.UseVisualStyleBackColor = True
        '
        'texto_tir2_cfin
        '
        Me.texto_tir2_cfin.AutoSize = True
        Me.texto_tir2_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tir2_cfin.Location = New System.Drawing.Point(603, 146)
        Me.texto_tir2_cfin.Name = "texto_tir2_cfin"
        Me.texto_tir2_cfin.Size = New System.Drawing.Size(149, 13)
        Me.texto_tir2_cfin.TabIndex = 95
        Me.texto_tir2_cfin.Text = "Internal Rate of Return 2"
        '
        'texto_taxa_reinvestimento_cfin
        '
        Me.texto_taxa_reinvestimento_cfin.AutoSize = True
        Me.texto_taxa_reinvestimento_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_taxa_reinvestimento_cfin.Location = New System.Drawing.Point(603, 42)
        Me.texto_taxa_reinvestimento_cfin.Name = "texto_taxa_reinvestimento_cfin"
        Me.texto_taxa_reinvestimento_cfin.Size = New System.Drawing.Size(110, 13)
        Me.texto_taxa_reinvestimento_cfin.TabIndex = 96
        Me.texto_taxa_reinvestimento_cfin.Text = "Reinvestment rate"
        '
        'texto_vpl2_cfin
        '
        Me.texto_vpl2_cfin.AutoSize = True
        Me.texto_vpl2_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vpl2_cfin.Location = New System.Drawing.Point(603, 94)
        Me.texto_vpl2_cfin.Name = "texto_vpl2_cfin"
        Me.texto_vpl2_cfin.Size = New System.Drawing.Size(121, 13)
        Me.texto_vpl2_cfin.TabIndex = 97
        Me.texto_vpl2_cfin.Text = "Net Present Value 2"
        '
        'caixatexto_taxa_reinvestimento_cfin
        '
        Me.caixatexto_taxa_reinvestimento_cfin.Location = New System.Drawing.Point(766, 39)
        Me.caixatexto_taxa_reinvestimento_cfin.Name = "caixatexto_taxa_reinvestimento_cfin"
        Me.caixatexto_taxa_reinvestimento_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_taxa_reinvestimento_cfin.TabIndex = 54
        '
        'caixatexto_vpl2_cfin
        '
        Me.caixatexto_vpl2_cfin.Location = New System.Drawing.Point(766, 91)
        Me.caixatexto_vpl2_cfin.Name = "caixatexto_vpl2_cfin"
        Me.caixatexto_vpl2_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_vpl2_cfin.TabIndex = 56
        '
        'caixatexto_tir2_cfin
        '
        Me.caixatexto_tir2_cfin.Location = New System.Drawing.Point(766, 143)
        Me.caixatexto_tir2_cfin.Name = "caixatexto_tir2_cfin"
        Me.caixatexto_tir2_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_tir2_cfin.TabIndex = 58
        '
        'caixatexto_tirm_cfin
        '
        Me.caixatexto_tirm_cfin.Location = New System.Drawing.Point(766, 169)
        Me.caixatexto_tirm_cfin.Name = "caixatexto_tirm_cfin"
        Me.caixatexto_tirm_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_tirm_cfin.TabIndex = 59
        '
        'texto_tirm_cfin
        '
        Me.texto_tirm_cfin.AutoSize = True
        Me.texto_tirm_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tirm_cfin.Location = New System.Drawing.Point(603, 172)
        Me.texto_tirm_cfin.Name = "texto_tirm_cfin"
        Me.texto_tirm_cfin.Size = New System.Drawing.Size(81, 13)
        Me.texto_tirm_cfin.TabIndex = 102
        Me.texto_tirm_cfin.Text = "Modified IRR"
        '
        'texto_il_cfin
        '
        Me.texto_il_cfin.AutoSize = True
        Me.texto_il_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_il_cfin.Location = New System.Drawing.Point(603, 198)
        Me.texto_il_cfin.Name = "texto_il_cfin"
        Me.texto_il_cfin.Size = New System.Drawing.Size(105, 13)
        Me.texto_il_cfin.TabIndex = 103
        Me.texto_il_cfin.Text = "Profitability Index"
        '
        'caixatexto_il_cfin
        '
        Me.caixatexto_il_cfin.Location = New System.Drawing.Point(766, 195)
        Me.caixatexto_il_cfin.Name = "caixatexto_il_cfin"
        Me.caixatexto_il_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_il_cfin.TabIndex = 60
        '
        'texto_payback_descontado_cfin
        '
        Me.texto_payback_descontado_cfin.AutoSize = True
        Me.texto_payback_descontado_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_payback_descontado_cfin.Location = New System.Drawing.Point(603, 250)
        Me.texto_payback_descontado_cfin.Name = "texto_payback_descontado_cfin"
        Me.texto_payback_descontado_cfin.Size = New System.Drawing.Size(124, 13)
        Me.texto_payback_descontado_cfin.TabIndex = 105
        Me.texto_payback_descontado_cfin.Text = "Discounted Payback"
        '
        'texto_payback_simples_cfin
        '
        Me.texto_payback_simples_cfin.AutoSize = True
        Me.texto_payback_simples_cfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_payback_simples_cfin.Location = New System.Drawing.Point(603, 224)
        Me.texto_payback_simples_cfin.Name = "texto_payback_simples_cfin"
        Me.texto_payback_simples_cfin.Size = New System.Drawing.Size(97, 13)
        Me.texto_payback_simples_cfin.TabIndex = 106
        Me.texto_payback_simples_cfin.Text = "Simple Payback"
        '
        'caixatexto_payback_simples_cfin
        '
        Me.caixatexto_payback_simples_cfin.Location = New System.Drawing.Point(766, 221)
        Me.caixatexto_payback_simples_cfin.Name = "caixatexto_payback_simples_cfin"
        Me.caixatexto_payback_simples_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_payback_simples_cfin.TabIndex = 61
        '
        'caixatexto_payback_descontado_cfin
        '
        Me.caixatexto_payback_descontado_cfin.Location = New System.Drawing.Point(766, 247)
        Me.caixatexto_payback_descontado_cfin.Name = "caixatexto_payback_descontado_cfin"
        Me.caixatexto_payback_descontado_cfin.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_payback_descontado_cfin.TabIndex = 62
        '
        'form_calculos_financeiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1024, 613)
        Me.Controls.Add(Me.caixatexto_payback_descontado_cfin)
        Me.Controls.Add(Me.caixatexto_payback_simples_cfin)
        Me.Controls.Add(Me.texto_payback_simples_cfin)
        Me.Controls.Add(Me.texto_payback_descontado_cfin)
        Me.Controls.Add(Me.caixatexto_il_cfin)
        Me.Controls.Add(Me.texto_il_cfin)
        Me.Controls.Add(Me.texto_tirm_cfin)
        Me.Controls.Add(Me.caixatexto_tirm_cfin)
        Me.Controls.Add(Me.caixatexto_tir2_cfin)
        Me.Controls.Add(Me.caixatexto_vpl2_cfin)
        Me.Controls.Add(Me.caixatexto_taxa_reinvestimento_cfin)
        Me.Controls.Add(Me.texto_vpl2_cfin)
        Me.Controls.Add(Me.texto_taxa_reinvestimento_cfin)
        Me.Controls.Add(Me.texto_tir2_cfin)
        Me.Controls.Add(Me.GrupoFluxos)
        Me.Controls.Add(Me.RichTextBox_informacoes_adicionais)
        Me.Controls.Add(Me.dgv_fluxos_cf)
        Me.Controls.Add(Me.RichTextBox_leitura_cfin)
        Me.Controls.Add(Me.texto_tir_cfin)
        Me.Controls.Add(Me.caixatexto_tir_cfin)
        Me.Controls.Add(Me.caixatexto_investimento_cfin)
        Me.Controls.Add(Me.texto_investimento_cfin)
        Me.Controls.Add(Me.texto_vpl_cfin)
        Me.Controls.Add(Me.caixatexto_vpl_cfin)
        Me.Controls.Add(Me.GrupoCalculosFinanceiros)
        Me.Controls.Add(Me.GrupoJurosECB)
        Me.Controls.Add(Me.GrupoConvercaoTaxa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_calculos_financeiros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Financial Calculations"
        Me.GrupoCalculosFinanceiros.ResumeLayout(False)
        Me.GrupoCalculosFinanceiros.PerformLayout()
        Me.GrupoJurosSC.ResumeLayout(False)
        Me.GrupoJurosSC.PerformLayout()
        Me.GrupoInicioFim.ResumeLayout(False)
        Me.GrupoInicioFim.PerformLayout()
        Me.GrupoEscolhaCalculos.ResumeLayout(False)
        Me.GrupoEscolhaCalculos.PerformLayout()
        Me.GrupoEqJurosCompostos.ResumeLayout(False)
        Me.GrupoEqJurosCompostos.PerformLayout()
        Me.GrupoEqJurosSimples.ResumeLayout(False)
        Me.GrupoEqJurosSimples.PerformLayout()
        Me.TabelaJurosECB.ResumeLayout(False)
        Me.TabelaJurosECB.PerformLayout()
        Me.GrupoJurosECB.ResumeLayout(False)
        Me.GrupoJurosECB.PerformLayout()
        Me.GrupoConvercaoTaxa.ResumeLayout(False)
        Me.GrupoConvercaoTaxa.PerformLayout()
        Me.GrupoVPLeTIR.ResumeLayout(False)
        Me.GrupoVPLeTIR.PerformLayout()
        CType(Me.dgv_fluxos_cf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoFluxos.ResumeLayout(False)
        Me.GrupoFluxos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents texto_pmt_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_vp_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_tempo_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_pmt_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_vf_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_eq_taxa_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_eq_taxa_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_eq_i_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_eq_i_cfin As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular_eq_taxa_cfin As System.Windows.Forms.Button
    Friend WithEvents texto_decimais_cfin As System.Windows.Forms.Label
    Friend WithEvents caixacombo_casas_decimais_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents texto_vf_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_tempo_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_vp_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents GrupoCalculosFinanceiros As System.Windows.Forms.GroupBox
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
    Friend WithEvents TabelaJurosECB As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents texto_n_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_i_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_juros_ecb As System.Windows.Forms.Label
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
    Friend WithEvents btn_comercial_n_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents btn_bancarios_juros_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents texto_inserir_i_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_de As System.Windows.Forms.Label
    Friend WithEvents texto_ate As System.Windows.Forms.Label
    Friend WithEvents GrupoJurosECB As System.Windows.Forms.GroupBox
    Friend WithEvents btn_limpar_ecb_cfin As System.Windows.Forms.Button
    Friend WithEvents caixacombo_exatos_i_ecb_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents texto_casas_decimais_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents caixacombo_comercial_i_ecb_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents caixacombo_bancarios_i_ecb_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents btn_calcular_ano_bissexto As System.Windows.Forms.Button
    Friend WithEvents checkbox_ano_bissexto_ecb_cfin As System.Windows.Forms.CheckBox
    Friend WithEvents caixatexto_transformar_percentual_simples As System.Windows.Forms.TextBox
    Friend WithEvents texto_transformar_percentual_simples As System.Windows.Forms.Label
    Friend WithEvents caixatexto_transformar_percentual As System.Windows.Forms.TextBox
    Friend WithEvents texto_transformar_percentual As System.Windows.Forms.Label
    Friend WithEvents data_de As System.Windows.Forms.DateTimePicker
    Friend WithEvents data_ate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrupoConvercaoTaxa As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTipCfin As System.Windows.Forms.ToolTip
    Friend WithEvents rdo_vp_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_taxa_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_n_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_montante_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents btn_calcular_cfin As System.Windows.Forms.Button
    Friend WithEvents rdo_pmt_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_vf_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_juros_compostos_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_juros_simples_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoJurosSC As System.Windows.Forms.GroupBox
    Friend WithEvents GrupoEscolhaCalculos As System.Windows.Forms.GroupBox
    Friend WithEvents texto_vpl_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_vpl_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_investimento_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_investimento_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_tir_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_tir_cfin As System.Windows.Forms.TextBox
    Friend WithEvents rdo_vpl_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_tir_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoVPLeTIR As System.Windows.Forms.GroupBox
    Friend WithEvents btn_vpl_tir_cfin As System.Windows.Forms.Button
    Friend WithEvents rdo_vpl2_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_inicio_periodo_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoInicioFim As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_fim_periodo_cfin As System.Windows.Forms.RadioButton
    Friend WithEvents RichTextBox_leitura_cfin As System.Windows.Forms.RichTextBox
    Friend WithEvents combo_taxa_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents combo_tempo_cfin As System.Windows.Forms.ComboBox
    Friend WithEvents texto_tempo_combo_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_taxa_combo_cfin As System.Windows.Forms.Label
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents EntradaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JurosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_imprimir_cf As System.Windows.Forms.Button
    Friend WithEvents btn_visualizar_impressao_cf As System.Windows.Forms.Button
    Friend WithEvents PrintDocument_cf As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog_cf As System.Windows.Forms.PrintDialog
    Friend WithEvents caixatexto_dias_uteis_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_dias_uteis_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_juros_ecb_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_juros_bancarios_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_juros_comerciais_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_juros_exatos_cfin As System.Windows.Forms.TextBox
    Friend WithEvents dgv_fluxos_cf As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox_informacoes_adicionais As System.Windows.Forms.RichTextBox
    Friend WithEvents GrupoFluxos As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_fluxo4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_fluxo3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_fluxo2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_fluxo1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_vpl_il As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_il As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_tirm As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_payback_descontado As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_payback_simples As System.Windows.Forms.RadioButton
    Friend WithEvents texto_tir2_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_taxa_reinvestimento_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_vpl2_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_taxa_reinvestimento_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_vpl2_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_tir2_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_tirm_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_tirm_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_il_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_il_cfin As System.Windows.Forms.TextBox
    Friend WithEvents texto_payback_descontado_cfin As System.Windows.Forms.Label
    Friend WithEvents texto_payback_simples_cfin As System.Windows.Forms.Label
    Friend WithEvents caixatexto_payback_simples_cfin As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_payback_descontado_cfin As System.Windows.Forms.TextBox
    Friend WithEvents Coluna_fluxo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_fluxo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_fluxo3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_fluxo4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
