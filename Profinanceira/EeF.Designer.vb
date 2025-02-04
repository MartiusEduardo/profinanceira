<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_ef_sistemas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_ef_sistemas))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HelpProvider_ef = New System.Windows.Forms.HelpProvider()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip_ef = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument_ef = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog_ef = New System.Windows.Forms.PrintDialog()
        Me.GrupoSistemas = New System.Windows.Forms.GroupBox()
        Me.rdo_sistema_spv = New System.Windows.Forms.RadioButton()
        Me.rdo_sistema_sam = New System.Windows.Forms.RadioButton()
        Me.rdo_sistema_americano = New System.Windows.Forms.RadioButton()
        Me.rdo_sistema_alemao = New System.Windows.Forms.RadioButton()
        Me.rdo_sistema_price = New System.Windows.Forms.RadioButton()
        Me.rdo_sistema_frances = New System.Windows.Forms.RadioButton()
        Me.rdo_sistema_sac = New System.Windows.Forms.RadioButton()
        Me.btn_remover_amortizacao = New System.Windows.Forms.Button()
        Me.btn_adicionar_amortizacao = New System.Windows.Forms.Button()
        Me.GrupoIntermediaria = New System.Windows.Forms.GroupBox()
        Me.caixatexto_valor_intermediaria = New System.Windows.Forms.TextBox()
        Me.texto_valor_intermediaria = New System.Windows.Forms.Label()
        Me.caixatexto_periodo_intermediaria = New System.Windows.Forms.TextBox()
        Me.texto_periodo_intermediaria = New System.Windows.Forms.Label()
        Me.rdo_nao_intermediaria = New System.Windows.Forms.RadioButton()
        Me.rdo_sim_intermediaria = New System.Windows.Forms.RadioButton()
        Me.GrupoResiduo = New System.Windows.Forms.GroupBox()
        Me.caixatexto_valor_pagamento = New System.Windows.Forms.TextBox()
        Me.texto_valor_pagamento = New System.Windows.Forms.Label()
        Me.rdo_sem_residuo = New System.Windows.Forms.RadioButton()
        Me.rdo_com_residuo = New System.Windows.Forms.RadioButton()
        Me.GrupoPgtoForaPrazo = New System.Windows.Forms.GroupBox()
        Me.rdo_nao_fora_prazo = New System.Windows.Forms.RadioButton()
        Me.rdo_sim_fora_prazo = New System.Windows.Forms.RadioButton()
        Me.GrupoPosFixado = New System.Windows.Forms.GroupBox()
        Me.btn_ok_ef = New System.Windows.Forms.Button()
        Me.rdo_pos_fixado_nao = New System.Windows.Forms.RadioButton()
        Me.caixatexto_tr_ef = New System.Windows.Forms.TextBox()
        Me.rdo_pos_fixado_sim = New System.Windows.Forms.RadioButton()
        Me.texto_tr_ef = New System.Windows.Forms.Label()
        Me.texto_dias_uteis = New System.Windows.Forms.Label()
        Me.caixatexto_dias_uteis = New System.Windows.Forms.TextBox()
        Me.combo_impressao = New System.Windows.Forms.ComboBox()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_visualizar_impressao = New System.Windows.Forms.Button()
        Me.caixacombo_tempo = New System.Windows.Forms.ComboBox()
        Me.caixacombo_taxa = New System.Windows.Forms.ComboBox()
        Me.caixacombo_casas_decimais = New System.Windows.Forms.ComboBox()
        Me.texto_casas_decimais = New System.Windows.Forms.Label()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.lista_emprestimos = New System.Windows.Forms.ListView()
        Me.Coluna_n = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Coluna_amortizacao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Coluna_juros = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Coluna_prestacao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Coluna_saldo_devedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Coluna_saldo_devedor_corrigido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.GrupoCarencia = New System.Windows.Forms.GroupBox()
        Me.GrupoTipoDeCarencia = New System.Windows.Forms.GroupBox()
        Me.caixatexto_total_n = New System.Windows.Forms.TextBox()
        Me.texto_total_n = New System.Windows.Forms.Label()
        Me.caixatexto_tempo_carencia = New System.Windows.Forms.TextBox()
        Me.texto_tempo_carencia = New System.Windows.Forms.Label()
        Me.rdo_juros_cdc_asd = New System.Windows.Forms.RadioButton()
        Me.rdo_juros_cdc_ppa = New System.Windows.Forms.RadioButton()
        Me.rdo_juros_pdc = New System.Windows.Forms.RadioButton()
        Me.rdo_com_carencia = New System.Windows.Forms.RadioButton()
        Me.rdo_sem_carencia = New System.Windows.Forms.RadioButton()
        Me.btn_calcular_eq_taxa = New System.Windows.Forms.Button()
        Me.caixatexto_eq_taxa = New System.Windows.Forms.TextBox()
        Me.texto_eq_taxa = New System.Windows.Forms.Label()
        Me.GrupoNegociacao = New System.Windows.Forms.GroupBox()
        Me.rdo_negociado_nao = New System.Windows.Forms.RadioButton()
        Me.rdo_negociado_sim = New System.Windows.Forms.RadioButton()
        Me.texto_vp_negociado = New System.Windows.Forms.Label()
        Me.caixatexto_vp_negociado = New System.Windows.Forms.TextBox()
        Me.caixatexto_tempo = New System.Windows.Forms.TextBox()
        Me.texto_n = New System.Windows.Forms.Label()
        Me.caixatexto_taxa = New System.Windows.Forms.TextBox()
        Me.texto_taxa = New System.Windows.Forms.Label()
        Me.caixatexto_vp = New System.Windows.Forms.TextBox()
        Me.texto_vp = New System.Windows.Forms.Label()
        Me.dgv_emprestimos_amortizacao = New System.Windows.Forms.DataGridView()
        Me.Coluna_n_amortizacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coluna_amortizacao2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_emprestimos_indices = New System.Windows.Forms.DataGridView()
        Me.Coluna_n_indices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coluna_indices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_adicionar_indices = New System.Windows.Forms.Button()
        Me.btn_remover_indices = New System.Windows.Forms.Button()
        Me.dgv_emprestimos_periodo = New System.Windows.Forms.DataGridView()
        Me.Coluna_n_periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coluna_periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_adicionar_periodo = New System.Windows.Forms.Button()
        Me.btn_remover_periodo = New System.Windows.Forms.Button()
        Me.lista_emprestimos_2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrupoEscolherTabela = New System.Windows.Forms.GroupBox()
        Me.GrupoSalvarTabelaComo = New System.Windows.Forms.GroupBox()
        Me.btn_salvar_excel = New System.Windows.Forms.Button()
        Me.rdo_tabela_2 = New System.Windows.Forms.RadioButton()
        Me.rdo_tabela_1 = New System.Windows.Forms.RadioButton()
        Me.EmpFinSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.GrupoSistemas.SuspendLayout()
        Me.GrupoIntermediaria.SuspendLayout()
        Me.GrupoResiduo.SuspendLayout()
        Me.GrupoPgtoForaPrazo.SuspendLayout()
        Me.GrupoPosFixado.SuspendLayout()
        Me.GrupoCarencia.SuspendLayout()
        Me.GrupoTipoDeCarencia.SuspendLayout()
        Me.GrupoNegociacao.SuspendLayout()
        CType(Me.dgv_emprestimos_amortizacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_emprestimos_indices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_emprestimos_periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoEscolherTabela.SuspendLayout()
        Me.GrupoSalvarTabelaComo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(105, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Inserir índices"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Não"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(57, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.Text = "Sim"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Períodos"
        Me.ColumnHeader1.Width = 58
        '
        'HelpProvider_ef
        '
        Me.HelpProvider_ef.HelpNamespace = "C:\Documents and Settings\Eduardo\My Documents\Visual Studio 2005\Projects\Profin" & _
            "anceira\Profinanceira\Help ProFinanceira\HelpProFinanceira.chm"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "n"
        Me.ColumnHeader2.Width = 43
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Amortização"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 104
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Juros"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 112
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Prestação"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 121
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Saldo Devedor"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 123
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "n"
        Me.ColumnHeader7.Width = 44
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Amortização"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 91
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Juros"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 81
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Prestação"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 90
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Saldo Devedor"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 98
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Saldo Corrigido"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 100
        '
        'ToolTip_ef
        '
        Me.ToolTip_ef.AutoPopDelay = 30000
        Me.ToolTip_ef.InitialDelay = 500
        Me.ToolTip_ef.ReshowDelay = 100
        '
        'PrintDocument_ef
        '
        '
        'PrintDialog_ef
        '
        Me.PrintDialog_ef.UseEXDialog = True
        '
        'GrupoSistemas
        '
        Me.GrupoSistemas.Controls.Add(Me.rdo_sistema_spv)
        Me.GrupoSistemas.Controls.Add(Me.rdo_sistema_sam)
        Me.GrupoSistemas.Controls.Add(Me.rdo_sistema_americano)
        Me.GrupoSistemas.Controls.Add(Me.rdo_sistema_alemao)
        Me.GrupoSistemas.Controls.Add(Me.rdo_sistema_price)
        Me.GrupoSistemas.Controls.Add(Me.rdo_sistema_frances)
        Me.GrupoSistemas.Controls.Add(Me.rdo_sistema_sac)
        Me.GrupoSistemas.Location = New System.Drawing.Point(260, 114)
        Me.GrupoSistemas.Name = "GrupoSistemas"
        Me.GrupoSistemas.Size = New System.Drawing.Size(238, 184)
        Me.GrupoSistemas.TabIndex = 163
        Me.GrupoSistemas.TabStop = False
        Me.GrupoSistemas.Text = "Sistemas"
        '
        'rdo_sistema_spv
        '
        Me.rdo_sistema_spv.AutoSize = True
        Me.rdo_sistema_spv.Location = New System.Drawing.Point(6, 156)
        Me.rdo_sistema_spv.Name = "rdo_sistema_spv"
        Me.rdo_sistema_spv.Size = New System.Drawing.Size(149, 17)
        Me.rdo_sistema_spv.TabIndex = 25
        Me.rdo_sistema_spv.Text = "Payment System Variables"
        Me.rdo_sistema_spv.UseVisualStyleBackColor = True
        '
        'rdo_sistema_sam
        '
        Me.rdo_sistema_sam.AutoSize = True
        Me.rdo_sistema_sam.Location = New System.Drawing.Point(6, 133)
        Me.rdo_sistema_sam.Name = "rdo_sistema_sam"
        Me.rdo_sistema_sam.Size = New System.Drawing.Size(144, 17)
        Me.rdo_sistema_sam.TabIndex = 24
        Me.rdo_sistema_sam.Text = "Amortization System Joint"
        Me.rdo_sistema_sam.UseVisualStyleBackColor = True
        '
        'rdo_sistema_americano
        '
        Me.rdo_sistema_americano.AutoSize = True
        Me.rdo_sistema_americano.Location = New System.Drawing.Point(6, 42)
        Me.rdo_sistema_americano.Name = "rdo_sistema_americano"
        Me.rdo_sistema_americano.Size = New System.Drawing.Size(106, 17)
        Me.rdo_sistema_americano.TabIndex = 20
        Me.rdo_sistema_americano.Text = "American System"
        Me.rdo_sistema_americano.UseVisualStyleBackColor = True
        '
        'rdo_sistema_alemao
        '
        Me.rdo_sistema_alemao.AutoSize = True
        Me.rdo_sistema_alemao.Location = New System.Drawing.Point(6, 110)
        Me.rdo_sistema_alemao.Name = "rdo_sistema_alemao"
        Me.rdo_sistema_alemao.Size = New System.Drawing.Size(99, 17)
        Me.rdo_sistema_alemao.TabIndex = 23
        Me.rdo_sistema_alemao.Text = "German System"
        Me.rdo_sistema_alemao.UseVisualStyleBackColor = True
        '
        'rdo_sistema_price
        '
        Me.rdo_sistema_price.AutoSize = True
        Me.rdo_sistema_price.Location = New System.Drawing.Point(6, 88)
        Me.rdo_sistema_price.Name = "rdo_sistema_price"
        Me.rdo_sistema_price.Size = New System.Drawing.Size(86, 17)
        Me.rdo_sistema_price.TabIndex = 22
        Me.rdo_sistema_price.Text = "Price System"
        Me.rdo_sistema_price.UseVisualStyleBackColor = True
        '
        'rdo_sistema_frances
        '
        Me.rdo_sistema_frances.AutoSize = True
        Me.rdo_sistema_frances.Location = New System.Drawing.Point(6, 65)
        Me.rdo_sistema_frances.Name = "rdo_sistema_frances"
        Me.rdo_sistema_frances.Size = New System.Drawing.Size(95, 17)
        Me.rdo_sistema_frances.TabIndex = 21
        Me.rdo_sistema_frances.Text = "French System"
        Me.rdo_sistema_frances.UseVisualStyleBackColor = True
        '
        'rdo_sistema_sac
        '
        Me.rdo_sistema_sac.AutoSize = True
        Me.rdo_sistema_sac.Checked = True
        Me.rdo_sistema_sac.Location = New System.Drawing.Point(6, 19)
        Me.rdo_sistema_sac.Name = "rdo_sistema_sac"
        Me.rdo_sistema_sac.Size = New System.Drawing.Size(164, 17)
        Me.rdo_sistema_sac.TabIndex = 19
        Me.rdo_sistema_sac.TabStop = True
        Me.rdo_sistema_sac.Text = "Constant Amortization System"
        Me.rdo_sistema_sac.UseVisualStyleBackColor = True
        '
        'btn_remover_amortizacao
        '
        Me.btn_remover_amortizacao.Enabled = False
        Me.btn_remover_amortizacao.Location = New System.Drawing.Point(322, 584)
        Me.btn_remover_amortizacao.Name = "btn_remover_amortizacao"
        Me.btn_remover_amortizacao.Size = New System.Drawing.Size(176, 23)
        Me.btn_remover_amortizacao.TabIndex = 40
        Me.btn_remover_amortizacao.Text = "Remove Amortizations"
        Me.btn_remover_amortizacao.UseVisualStyleBackColor = True
        '
        'btn_adicionar_amortizacao
        '
        Me.btn_adicionar_amortizacao.Enabled = False
        Me.btn_adicionar_amortizacao.Location = New System.Drawing.Point(322, 555)
        Me.btn_adicionar_amortizacao.Name = "btn_adicionar_amortizacao"
        Me.btn_adicionar_amortizacao.Size = New System.Drawing.Size(176, 23)
        Me.btn_adicionar_amortizacao.TabIndex = 39
        Me.btn_adicionar_amortizacao.Text = "Add Amortizations"
        Me.btn_adicionar_amortizacao.UseVisualStyleBackColor = True
        '
        'GrupoIntermediaria
        '
        Me.GrupoIntermediaria.Controls.Add(Me.caixatexto_valor_intermediaria)
        Me.GrupoIntermediaria.Controls.Add(Me.texto_valor_intermediaria)
        Me.GrupoIntermediaria.Controls.Add(Me.caixatexto_periodo_intermediaria)
        Me.GrupoIntermediaria.Controls.Add(Me.texto_periodo_intermediaria)
        Me.GrupoIntermediaria.Controls.Add(Me.rdo_nao_intermediaria)
        Me.GrupoIntermediaria.Controls.Add(Me.rdo_sim_intermediaria)
        Me.GrupoIntermediaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoIntermediaria.Location = New System.Drawing.Point(9, 281)
        Me.GrupoIntermediaria.Name = "GrupoIntermediaria"
        Me.GrupoIntermediaria.Size = New System.Drawing.Size(245, 105)
        Me.GrupoIntermediaria.TabIndex = 159
        Me.GrupoIntermediaria.TabStop = False
        Me.GrupoIntermediaria.Text = "Are there intermediate?"
        '
        'caixatexto_valor_intermediaria
        '
        Me.caixatexto_valor_intermediaria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.caixatexto_valor_intermediaria.Location = New System.Drawing.Point(143, 75)
        Me.caixatexto_valor_intermediaria.Name = "caixatexto_valor_intermediaria"
        Me.caixatexto_valor_intermediaria.ReadOnly = True
        Me.caixatexto_valor_intermediaria.Size = New System.Drawing.Size(89, 20)
        Me.caixatexto_valor_intermediaria.TabIndex = 18
        Me.caixatexto_valor_intermediaria.Text = "0"
        '
        'texto_valor_intermediaria
        '
        Me.texto_valor_intermediaria.AutoSize = True
        Me.texto_valor_intermediaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_valor_intermediaria.Location = New System.Drawing.Point(6, 78)
        Me.texto_valor_intermediaria.Name = "texto_valor_intermediaria"
        Me.texto_valor_intermediaria.Size = New System.Drawing.Size(113, 13)
        Me.texto_valor_intermediaria.TabIndex = 27
        Me.texto_valor_intermediaria.Text = "Intermediate Value"
        '
        'caixatexto_periodo_intermediaria
        '
        Me.caixatexto_periodo_intermediaria.Location = New System.Drawing.Point(100, 41)
        Me.caixatexto_periodo_intermediaria.Name = "caixatexto_periodo_intermediaria"
        Me.caixatexto_periodo_intermediaria.ReadOnly = True
        Me.caixatexto_periodo_intermediaria.Size = New System.Drawing.Size(46, 20)
        Me.caixatexto_periodo_intermediaria.TabIndex = 17
        Me.caixatexto_periodo_intermediaria.Text = "0"
        '
        'texto_periodo_intermediaria
        '
        Me.texto_periodo_intermediaria.AutoSize = True
        Me.texto_periodo_intermediaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_periodo_intermediaria.Location = New System.Drawing.Point(6, 44)
        Me.texto_periodo_intermediaria.Name = "texto_periodo_intermediaria"
        Me.texto_periodo_intermediaria.Size = New System.Drawing.Size(89, 13)
        Me.texto_periodo_intermediaria.TabIndex = 26
        Me.texto_periodo_intermediaria.Text = "Which period?"
        '
        'rdo_nao_intermediaria
        '
        Me.rdo_nao_intermediaria.AutoSize = True
        Me.rdo_nao_intermediaria.Checked = True
        Me.rdo_nao_intermediaria.Location = New System.Drawing.Point(6, 19)
        Me.rdo_nao_intermediaria.Name = "rdo_nao_intermediaria"
        Me.rdo_nao_intermediaria.Size = New System.Drawing.Size(39, 17)
        Me.rdo_nao_intermediaria.TabIndex = 15
        Me.rdo_nao_intermediaria.TabStop = True
        Me.rdo_nao_intermediaria.Text = "No"
        Me.rdo_nao_intermediaria.UseVisualStyleBackColor = True
        '
        'rdo_sim_intermediaria
        '
        Me.rdo_sim_intermediaria.AutoSize = True
        Me.rdo_sim_intermediaria.Location = New System.Drawing.Point(51, 19)
        Me.rdo_sim_intermediaria.Name = "rdo_sim_intermediaria"
        Me.rdo_sim_intermediaria.Size = New System.Drawing.Size(43, 17)
        Me.rdo_sim_intermediaria.TabIndex = 16
        Me.rdo_sim_intermediaria.Text = "Yes"
        Me.rdo_sim_intermediaria.UseVisualStyleBackColor = True
        '
        'GrupoResiduo
        '
        Me.GrupoResiduo.Controls.Add(Me.caixatexto_valor_pagamento)
        Me.GrupoResiduo.Controls.Add(Me.texto_valor_pagamento)
        Me.GrupoResiduo.Controls.Add(Me.rdo_sem_residuo)
        Me.GrupoResiduo.Controls.Add(Me.rdo_com_residuo)
        Me.GrupoResiduo.Location = New System.Drawing.Point(9, 193)
        Me.GrupoResiduo.Name = "GrupoResiduo"
        Me.GrupoResiduo.Size = New System.Drawing.Size(245, 82)
        Me.GrupoResiduo.TabIndex = 158
        Me.GrupoResiduo.TabStop = False
        Me.GrupoResiduo.Text = "Are there residue?"
        '
        'caixatexto_valor_pagamento
        '
        Me.caixatexto_valor_pagamento.Location = New System.Drawing.Point(132, 51)
        Me.caixatexto_valor_pagamento.Name = "caixatexto_valor_pagamento"
        Me.caixatexto_valor_pagamento.ReadOnly = True
        Me.caixatexto_valor_pagamento.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_valor_pagamento.TabIndex = 14
        Me.caixatexto_valor_pagamento.Text = "0"
        '
        'texto_valor_pagamento
        '
        Me.texto_valor_pagamento.AutoSize = True
        Me.texto_valor_pagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_valor_pagamento.Location = New System.Drawing.Point(6, 54)
        Me.texto_valor_pagamento.Name = "texto_valor_pagamento"
        Me.texto_valor_pagamento.Size = New System.Drawing.Size(100, 13)
        Me.texto_valor_pagamento.TabIndex = 24
        Me.texto_valor_pagamento.Text = "Payment amount"
        '
        'rdo_sem_residuo
        '
        Me.rdo_sem_residuo.AutoSize = True
        Me.rdo_sem_residuo.Checked = True
        Me.rdo_sem_residuo.Location = New System.Drawing.Point(6, 19)
        Me.rdo_sem_residuo.Name = "rdo_sem_residuo"
        Me.rdo_sem_residuo.Size = New System.Drawing.Size(76, 17)
        Me.rdo_sem_residuo.TabIndex = 12
        Me.rdo_sem_residuo.TabStop = True
        Me.rdo_sem_residuo.Text = "No residue"
        Me.rdo_sem_residuo.UseVisualStyleBackColor = True
        '
        'rdo_com_residuo
        '
        Me.rdo_com_residuo.AutoSize = True
        Me.rdo_com_residuo.Location = New System.Drawing.Point(92, 19)
        Me.rdo_com_residuo.Name = "rdo_com_residuo"
        Me.rdo_com_residuo.Size = New System.Drawing.Size(84, 17)
        Me.rdo_com_residuo.TabIndex = 13
        Me.rdo_com_residuo.Text = "With residue"
        Me.rdo_com_residuo.UseVisualStyleBackColor = True
        '
        'GrupoPgtoForaPrazo
        '
        Me.GrupoPgtoForaPrazo.Controls.Add(Me.rdo_nao_fora_prazo)
        Me.GrupoPgtoForaPrazo.Controls.Add(Me.rdo_sim_fora_prazo)
        Me.GrupoPgtoForaPrazo.Location = New System.Drawing.Point(322, 357)
        Me.GrupoPgtoForaPrazo.Name = "GrupoPgtoForaPrazo"
        Me.GrupoPgtoForaPrazo.Size = New System.Drawing.Size(176, 53)
        Me.GrupoPgtoForaPrazo.TabIndex = 155
        Me.GrupoPgtoForaPrazo.TabStop = False
        Me.GrupoPgtoForaPrazo.Text = "No payment after the deadline?"
        '
        'rdo_nao_fora_prazo
        '
        Me.rdo_nao_fora_prazo.AutoSize = True
        Me.rdo_nao_fora_prazo.Checked = True
        Me.rdo_nao_fora_prazo.Location = New System.Drawing.Point(6, 19)
        Me.rdo_nao_fora_prazo.Name = "rdo_nao_fora_prazo"
        Me.rdo_nao_fora_prazo.Size = New System.Drawing.Size(39, 17)
        Me.rdo_nao_fora_prazo.TabIndex = 26
        Me.rdo_nao_fora_prazo.TabStop = True
        Me.rdo_nao_fora_prazo.Text = "No"
        Me.rdo_nao_fora_prazo.UseVisualStyleBackColor = True
        '
        'rdo_sim_fora_prazo
        '
        Me.rdo_sim_fora_prazo.AutoSize = True
        Me.rdo_sim_fora_prazo.Location = New System.Drawing.Point(51, 19)
        Me.rdo_sim_fora_prazo.Name = "rdo_sim_fora_prazo"
        Me.rdo_sim_fora_prazo.Size = New System.Drawing.Size(43, 17)
        Me.rdo_sim_fora_prazo.TabIndex = 27
        Me.rdo_sim_fora_prazo.Text = "Yes"
        Me.rdo_sim_fora_prazo.UseVisualStyleBackColor = True
        '
        'GrupoPosFixado
        '
        Me.GrupoPosFixado.Controls.Add(Me.btn_ok_ef)
        Me.GrupoPosFixado.Controls.Add(Me.rdo_pos_fixado_nao)
        Me.GrupoPosFixado.Controls.Add(Me.caixatexto_tr_ef)
        Me.GrupoPosFixado.Controls.Add(Me.rdo_pos_fixado_sim)
        Me.GrupoPosFixado.Controls.Add(Me.texto_tr_ef)
        Me.GrupoPosFixado.Location = New System.Drawing.Point(260, 304)
        Me.GrupoPosFixado.Name = "GrupoPosFixado"
        Me.GrupoPosFixado.Size = New System.Drawing.Size(238, 47)
        Me.GrupoPosFixado.TabIndex = 154
        Me.GrupoPosFixado.TabStop = False
        Me.GrupoPosFixado.Text = "Post-Fixed System?"
        '
        'btn_ok_ef
        '
        Me.btn_ok_ef.Enabled = False
        Me.btn_ok_ef.Location = New System.Drawing.Point(199, 16)
        Me.btn_ok_ef.Name = "btn_ok_ef"
        Me.btn_ok_ef.Size = New System.Drawing.Size(33, 23)
        Me.btn_ok_ef.TabIndex = 26
        Me.btn_ok_ef.Text = "OK"
        Me.btn_ok_ef.UseVisualStyleBackColor = True
        '
        'rdo_pos_fixado_nao
        '
        Me.rdo_pos_fixado_nao.AutoSize = True
        Me.rdo_pos_fixado_nao.Checked = True
        Me.rdo_pos_fixado_nao.Location = New System.Drawing.Point(6, 19)
        Me.rdo_pos_fixado_nao.Name = "rdo_pos_fixado_nao"
        Me.rdo_pos_fixado_nao.Size = New System.Drawing.Size(39, 17)
        Me.rdo_pos_fixado_nao.TabIndex = 30
        Me.rdo_pos_fixado_nao.TabStop = True
        Me.rdo_pos_fixado_nao.Text = "No"
        Me.rdo_pos_fixado_nao.UseVisualStyleBackColor = True
        '
        'caixatexto_tr_ef
        '
        Me.caixatexto_tr_ef.Location = New System.Drawing.Point(133, 18)
        Me.caixatexto_tr_ef.Name = "caixatexto_tr_ef"
        Me.caixatexto_tr_ef.Size = New System.Drawing.Size(60, 20)
        Me.caixatexto_tr_ef.TabIndex = 29
        Me.caixatexto_tr_ef.Text = "0"
        '
        'rdo_pos_fixado_sim
        '
        Me.rdo_pos_fixado_sim.AutoSize = True
        Me.rdo_pos_fixado_sim.Location = New System.Drawing.Point(57, 19)
        Me.rdo_pos_fixado_sim.Name = "rdo_pos_fixado_sim"
        Me.rdo_pos_fixado_sim.Size = New System.Drawing.Size(43, 17)
        Me.rdo_pos_fixado_sim.TabIndex = 31
        Me.rdo_pos_fixado_sim.Text = "Yes"
        Me.rdo_pos_fixado_sim.UseVisualStyleBackColor = True
        '
        'texto_tr_ef
        '
        Me.texto_tr_ef.AutoSize = True
        Me.texto_tr_ef.Location = New System.Drawing.Point(105, 21)
        Me.texto_tr_ef.Name = "texto_tr_ef"
        Me.texto_tr_ef.Size = New System.Drawing.Size(22, 13)
        Me.texto_tr_ef.TabIndex = 28
        Me.texto_tr_ef.Text = "TR"
        '
        'texto_dias_uteis
        '
        Me.texto_dias_uteis.AutoSize = True
        Me.texto_dias_uteis.Location = New System.Drawing.Point(336, 65)
        Me.texto_dias_uteis.Name = "texto_dias_uteis"
        Me.texto_dias_uteis.Size = New System.Drawing.Size(60, 13)
        Me.texto_dias_uteis.TabIndex = 153
        Me.texto_dias_uteis.Text = "Day useful:"
        '
        'caixatexto_dias_uteis
        '
        Me.caixatexto_dias_uteis.Location = New System.Drawing.Point(402, 62)
        Me.caixatexto_dias_uteis.Name = "caixatexto_dias_uteis"
        Me.caixatexto_dias_uteis.Size = New System.Drawing.Size(48, 20)
        Me.caixatexto_dias_uteis.TabIndex = 5
        Me.caixatexto_dias_uteis.Text = "22"
        '
        'combo_impressao
        '
        Me.combo_impressao.FormattingEnabled = True
        Me.combo_impressao.Items.AddRange(New Object() {"PV, Rate, n, FV", "Table"})
        Me.combo_impressao.Location = New System.Drawing.Point(403, 620)
        Me.combo_impressao.Name = "combo_impressao"
        Me.combo_impressao.Size = New System.Drawing.Size(95, 21)
        Me.combo_impressao.TabIndex = 52
        Me.combo_impressao.Text = "PV, Rate, n, FV"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Location = New System.Drawing.Point(322, 620)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(75, 23)
        Me.btn_imprimir.TabIndex = 51
        Me.btn_imprimir.Text = "Print"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_visualizar_impressao
        '
        Me.btn_visualizar_impressao.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_visualizar_impressao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_visualizar_impressao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_visualizar_impressao.Location = New System.Drawing.Point(206, 620)
        Me.btn_visualizar_impressao.Name = "btn_visualizar_impressao"
        Me.btn_visualizar_impressao.Size = New System.Drawing.Size(110, 23)
        Me.btn_visualizar_impressao.TabIndex = 50
        Me.btn_visualizar_impressao.Text = "Print Preview"
        Me.btn_visualizar_impressao.UseVisualStyleBackColor = True
        '
        'caixacombo_tempo
        '
        Me.caixacombo_tempo.FormattingEnabled = True
        Me.caixacombo_tempo.Items.AddRange(New Object() {"By day useful", "Daily", "Monthly", "Bimonthly", "Quarterly", "4 months", "Semester", "Annual (Civil)", "Annual (Commercial)", "Annual (Bissextile)"})
        Me.caixacombo_tempo.Location = New System.Drawing.Point(214, 62)
        Me.caixacombo_tempo.Name = "caixacombo_tempo"
        Me.caixacombo_tempo.Size = New System.Drawing.Size(116, 21)
        Me.caixacombo_tempo.TabIndex = 4
        Me.caixacombo_tempo.Text = "Monthly"
        '
        'caixacombo_taxa
        '
        Me.caixacombo_taxa.FormattingEnabled = True
        Me.caixacombo_taxa.Items.AddRange(New Object() {"By day useful", "Daily", "Monthly", "Bimonthly", "Quarterly", "4 months", "Semester", "Annual (Civil)", "Annual (Commercial)", "Annual (Bissextile)"})
        Me.caixacombo_taxa.Location = New System.Drawing.Point(214, 35)
        Me.caixacombo_taxa.Name = "caixacombo_taxa"
        Me.caixacombo_taxa.Size = New System.Drawing.Size(116, 21)
        Me.caixacombo_taxa.TabIndex = 2
        Me.caixacombo_taxa.Text = "Monthly"
        '
        'caixacombo_casas_decimais
        '
        Me.caixacombo_casas_decimais.FormattingEnabled = True
        Me.caixacombo_casas_decimais.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.caixacombo_casas_decimais.Location = New System.Drawing.Point(400, 86)
        Me.caixacombo_casas_decimais.Name = "caixacombo_casas_decimais"
        Me.caixacombo_casas_decimais.Size = New System.Drawing.Size(56, 21)
        Me.caixacombo_casas_decimais.TabIndex = 8
        '
        'texto_casas_decimais
        '
        Me.texto_casas_decimais.AutoSize = True
        Me.texto_casas_decimais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_casas_decimais.Location = New System.Drawing.Point(342, 89)
        Me.texto_casas_decimais.Name = "texto_casas_decimais"
        Me.texto_casas_decimais.Size = New System.Drawing.Size(52, 13)
        Me.texto_casas_decimais.TabIndex = 146
        Me.texto_casas_decimais.Text = "Decimal"
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(105, 620)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(95, 23)
        Me.btn_limpar.TabIndex = 49
        Me.btn_limpar.Text = "Clear Table"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'lista_emprestimos
        '
        Me.lista_emprestimos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Coluna_n, Me.Coluna_amortizacao, Me.Coluna_juros, Me.Coluna_prestacao, Me.Coluna_saldo_devedor, Me.Coluna_saldo_devedor_corrigido})
        Me.lista_emprestimos.FullRowSelect = True
        Me.lista_emprestimos.GridLines = True
        Me.lista_emprestimos.Location = New System.Drawing.Point(504, 12)
        Me.lista_emprestimos.Name = "lista_emprestimos"
        Me.lista_emprestimos.Size = New System.Drawing.Size(508, 446)
        Me.lista_emprestimos.TabIndex = 53
        Me.lista_emprestimos.UseCompatibleStateImageBehavior = False
        Me.lista_emprestimos.View = System.Windows.Forms.View.Details
        '
        'Coluna_n
        '
        Me.Coluna_n.Text = "n"
        Me.Coluna_n.Width = 43
        '
        'Coluna_amortizacao
        '
        Me.Coluna_amortizacao.Text = "Amortization"
        Me.Coluna_amortizacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Coluna_amortizacao.Width = 91
        '
        'Coluna_juros
        '
        Me.Coluna_juros.Text = "Interest"
        Me.Coluna_juros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Coluna_juros.Width = 82
        '
        'Coluna_prestacao
        '
        Me.Coluna_prestacao.Text = "Instalment"
        Me.Coluna_prestacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Coluna_prestacao.Width = 87
        '
        'Coluna_saldo_devedor
        '
        Me.Coluna_saldo_devedor.Text = "Balance Debtor"
        Me.Coluna_saldo_devedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Coluna_saldo_devedor.Width = 100
        '
        'Coluna_saldo_devedor_corrigido
        '
        Me.Coluna_saldo_devedor_corrigido.Text = "Balance Corrected"
        Me.Coluna_saldo_devedor_corrigido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Coluna_saldo_devedor_corrigido.Width = 100
        '
        'btn_calcular
        '
        Me.btn_calcular.Enabled = False
        Me.btn_calcular.Location = New System.Drawing.Point(9, 620)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(90, 23)
        Me.btn_calcular.TabIndex = 48
        Me.btn_calcular.Text = "Calculate"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'GrupoCarencia
        '
        Me.GrupoCarencia.Controls.Add(Me.GrupoTipoDeCarencia)
        Me.GrupoCarencia.Controls.Add(Me.rdo_com_carencia)
        Me.GrupoCarencia.Controls.Add(Me.rdo_sem_carencia)
        Me.GrupoCarencia.Location = New System.Drawing.Point(504, 464)
        Me.GrupoCarencia.Name = "GrupoCarencia"
        Me.GrupoCarencia.Size = New System.Drawing.Size(508, 177)
        Me.GrupoCarencia.TabIndex = 142
        Me.GrupoCarencia.TabStop = False
        Me.GrupoCarencia.Text = "Are there shortage?"
        '
        'GrupoTipoDeCarencia
        '
        Me.GrupoTipoDeCarencia.Controls.Add(Me.caixatexto_total_n)
        Me.GrupoTipoDeCarencia.Controls.Add(Me.texto_total_n)
        Me.GrupoTipoDeCarencia.Controls.Add(Me.caixatexto_tempo_carencia)
        Me.GrupoTipoDeCarencia.Controls.Add(Me.texto_tempo_carencia)
        Me.GrupoTipoDeCarencia.Controls.Add(Me.rdo_juros_cdc_asd)
        Me.GrupoTipoDeCarencia.Controls.Add(Me.rdo_juros_cdc_ppa)
        Me.GrupoTipoDeCarencia.Controls.Add(Me.rdo_juros_pdc)
        Me.GrupoTipoDeCarencia.Enabled = False
        Me.GrupoTipoDeCarencia.Location = New System.Drawing.Point(6, 42)
        Me.GrupoTipoDeCarencia.Name = "GrupoTipoDeCarencia"
        Me.GrupoTipoDeCarencia.Size = New System.Drawing.Size(483, 126)
        Me.GrupoTipoDeCarencia.TabIndex = 2
        Me.GrupoTipoDeCarencia.TabStop = False
        Me.GrupoTipoDeCarencia.Text = "How will be calculated the interest?"
        '
        'caixatexto_total_n
        '
        Me.caixatexto_total_n.Location = New System.Drawing.Point(271, 91)
        Me.caixatexto_total_n.Name = "caixatexto_total_n"
        Me.caixatexto_total_n.ReadOnly = True
        Me.caixatexto_total_n.Size = New System.Drawing.Size(54, 20)
        Me.caixatexto_total_n.TabIndex = 47
        Me.caixatexto_total_n.Text = "0"
        '
        'texto_total_n
        '
        Me.texto_total_n.AutoSize = True
        Me.texto_total_n.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_total_n.Location = New System.Drawing.Point(189, 98)
        Me.texto_total_n.Name = "texto_total_n"
        Me.texto_total_n.Size = New System.Drawing.Size(76, 13)
        Me.texto_total_n.TabIndex = 25
        Me.texto_total_n.Text = "Total Period"
        '
        'caixatexto_tempo_carencia
        '
        Me.caixatexto_tempo_carencia.Location = New System.Drawing.Point(132, 91)
        Me.caixatexto_tempo_carencia.Name = "caixatexto_tempo_carencia"
        Me.caixatexto_tempo_carencia.ReadOnly = True
        Me.caixatexto_tempo_carencia.Size = New System.Drawing.Size(51, 20)
        Me.caixatexto_tempo_carencia.TabIndex = 46
        Me.caixatexto_tempo_carencia.Text = "0"
        '
        'texto_tempo_carencia
        '
        Me.texto_tempo_carencia.AutoSize = True
        Me.texto_tempo_carencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_tempo_carencia.Location = New System.Drawing.Point(10, 98)
        Me.texto_tempo_carencia.Name = "texto_tempo_carencia"
        Me.texto_tempo_carencia.Size = New System.Drawing.Size(102, 13)
        Me.texto_tempo_carencia.TabIndex = 23
        Me.texto_tempo_carencia.Text = "Time of shortage"
        '
        'rdo_juros_cdc_asd
        '
        Me.rdo_juros_cdc_asd.AutoSize = True
        Me.rdo_juros_cdc_asd.Location = New System.Drawing.Point(13, 65)
        Me.rdo_juros_cdc_asd.Name = "rdo_juros_cdc_asd"
        Me.rdo_juros_cdc_asd.Size = New System.Drawing.Size(397, 17)
        Me.rdo_juros_cdc_asd.TabIndex = 45
        Me.rdo_juros_cdc_asd.TabStop = True
        Me.rdo_juros_cdc_asd.Text = "Interest capitalized during the shortage period and added to the balance debtor"
        Me.rdo_juros_cdc_asd.UseVisualStyleBackColor = True
        '
        'rdo_juros_cdc_ppa
        '
        Me.rdo_juros_cdc_ppa.AutoSize = True
        Me.rdo_juros_cdc_ppa.Location = New System.Drawing.Point(13, 42)
        Me.rdo_juros_cdc_ppa.Name = "rdo_juros_cdc_ppa"
        Me.rdo_juros_cdc_ppa.Size = New System.Drawing.Size(390, 17)
        Me.rdo_juros_cdc_ppa.TabIndex = 44
        Me.rdo_juros_cdc_ppa.TabStop = True
        Me.rdo_juros_cdc_ppa.Text = "Interest capitalized during the shortage period and paid in the first amortizatio" & _
            "n"
        Me.rdo_juros_cdc_ppa.UseVisualStyleBackColor = True
        '
        'rdo_juros_pdc
        '
        Me.rdo_juros_pdc.AutoSize = True
        Me.rdo_juros_pdc.Checked = True
        Me.rdo_juros_pdc.Location = New System.Drawing.Point(13, 19)
        Me.rdo_juros_pdc.Name = "rdo_juros_pdc"
        Me.rdo_juros_pdc.Size = New System.Drawing.Size(177, 17)
        Me.rdo_juros_pdc.TabIndex = 43
        Me.rdo_juros_pdc.TabStop = True
        Me.rdo_juros_pdc.Text = "Interest paid during the shortage"
        Me.rdo_juros_pdc.UseVisualStyleBackColor = True
        '
        'rdo_com_carencia
        '
        Me.rdo_com_carencia.AutoSize = True
        Me.rdo_com_carencia.Location = New System.Drawing.Point(118, 19)
        Me.rdo_com_carencia.Name = "rdo_com_carencia"
        Me.rdo_com_carencia.Size = New System.Drawing.Size(91, 17)
        Me.rdo_com_carencia.TabIndex = 42
        Me.rdo_com_carencia.Text = "With shortage"
        Me.rdo_com_carencia.UseVisualStyleBackColor = True
        '
        'rdo_sem_carencia
        '
        Me.rdo_sem_carencia.AutoSize = True
        Me.rdo_sem_carencia.Checked = True
        Me.rdo_sem_carencia.Location = New System.Drawing.Point(6, 19)
        Me.rdo_sem_carencia.Name = "rdo_sem_carencia"
        Me.rdo_sem_carencia.Size = New System.Drawing.Size(106, 17)
        Me.rdo_sem_carencia.TabIndex = 41
        Me.rdo_sem_carencia.TabStop = True
        Me.rdo_sem_carencia.Text = "Without shortage"
        Me.rdo_sem_carencia.UseVisualStyleBackColor = True
        '
        'btn_calcular_eq_taxa
        '
        Me.btn_calcular_eq_taxa.Enabled = False
        Me.btn_calcular_eq_taxa.Location = New System.Drawing.Point(214, 85)
        Me.btn_calcular_eq_taxa.Name = "btn_calcular_eq_taxa"
        Me.btn_calcular_eq_taxa.Size = New System.Drawing.Size(122, 23)
        Me.btn_calcular_eq_taxa.TabIndex = 6
        Me.btn_calcular_eq_taxa.Text = "Calculate Equity Rate"
        Me.btn_calcular_eq_taxa.UseVisualStyleBackColor = True
        '
        'caixatexto_eq_taxa
        '
        Me.caixatexto_eq_taxa.Location = New System.Drawing.Point(102, 87)
        Me.caixatexto_eq_taxa.Name = "caixatexto_eq_taxa"
        Me.caixatexto_eq_taxa.ReadOnly = True
        Me.caixatexto_eq_taxa.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_eq_taxa.TabIndex = 6
        Me.caixatexto_eq_taxa.Text = "0"
        '
        'texto_eq_taxa
        '
        Me.texto_eq_taxa.AutoSize = True
        Me.texto_eq_taxa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_eq_taxa.Location = New System.Drawing.Point(6, 89)
        Me.texto_eq_taxa.Name = "texto_eq_taxa"
        Me.texto_eq_taxa.Size = New System.Drawing.Size(68, 13)
        Me.texto_eq_taxa.TabIndex = 139
        Me.texto_eq_taxa.Text = "Equity rate"
        '
        'GrupoNegociacao
        '
        Me.GrupoNegociacao.Controls.Add(Me.rdo_negociado_nao)
        Me.GrupoNegociacao.Controls.Add(Me.rdo_negociado_sim)
        Me.GrupoNegociacao.Controls.Add(Me.texto_vp_negociado)
        Me.GrupoNegociacao.Controls.Add(Me.caixatexto_vp_negociado)
        Me.GrupoNegociacao.Location = New System.Drawing.Point(9, 114)
        Me.GrupoNegociacao.Name = "GrupoNegociacao"
        Me.GrupoNegociacao.Size = New System.Drawing.Size(245, 73)
        Me.GrupoNegociacao.TabIndex = 138
        Me.GrupoNegociacao.TabStop = False
        Me.GrupoNegociacao.Text = "Present Value Traded?"
        '
        'rdo_negociado_nao
        '
        Me.rdo_negociado_nao.AutoSize = True
        Me.rdo_negociado_nao.Checked = True
        Me.rdo_negociado_nao.Location = New System.Drawing.Point(89, 19)
        Me.rdo_negociado_nao.Name = "rdo_negociado_nao"
        Me.rdo_negociado_nao.Size = New System.Drawing.Size(79, 17)
        Me.rdo_negociado_nao.TabIndex = 10
        Me.rdo_negociado_nao.TabStop = True
        Me.rdo_negociado_nao.Text = "Not Traded"
        Me.rdo_negociado_nao.UseVisualStyleBackColor = True
        '
        'rdo_negociado_sim
        '
        Me.rdo_negociado_sim.AutoSize = True
        Me.rdo_negociado_sim.Location = New System.Drawing.Point(6, 19)
        Me.rdo_negociado_sim.Name = "rdo_negociado_sim"
        Me.rdo_negociado_sim.Size = New System.Drawing.Size(59, 17)
        Me.rdo_negociado_sim.TabIndex = 9
        Me.rdo_negociado_sim.Text = "Traded"
        Me.rdo_negociado_sim.UseVisualStyleBackColor = True
        '
        'texto_vp_negociado
        '
        Me.texto_vp_negociado.AutoSize = True
        Me.texto_vp_negociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vp_negociado.Location = New System.Drawing.Point(6, 45)
        Me.texto_vp_negociado.Name = "texto_vp_negociado"
        Me.texto_vp_negociado.Size = New System.Drawing.Size(130, 13)
        Me.texto_vp_negociado.TabIndex = 17
        Me.texto_vp_negociado.Text = "Present Value Traded"
        '
        'caixatexto_vp_negociado
        '
        Me.caixatexto_vp_negociado.Location = New System.Drawing.Point(167, 42)
        Me.caixatexto_vp_negociado.Name = "caixatexto_vp_negociado"
        Me.caixatexto_vp_negociado.ReadOnly = True
        Me.caixatexto_vp_negociado.Size = New System.Drawing.Size(72, 20)
        Me.caixatexto_vp_negociado.TabIndex = 11
        Me.caixatexto_vp_negociado.Text = "0"
        '
        'caixatexto_tempo
        '
        Me.caixatexto_tempo.Location = New System.Drawing.Point(102, 61)
        Me.caixatexto_tempo.Name = "caixatexto_tempo"
        Me.caixatexto_tempo.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_tempo.TabIndex = 3
        '
        'texto_n
        '
        Me.texto_n.AutoSize = True
        Me.texto_n.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_n.Location = New System.Drawing.Point(6, 68)
        Me.texto_n.Name = "texto_n"
        Me.texto_n.Size = New System.Drawing.Size(35, 13)
        Me.texto_n.TabIndex = 137
        Me.texto_n.Text = "NPer"
        '
        'caixatexto_taxa
        '
        Me.caixatexto_taxa.Location = New System.Drawing.Point(102, 35)
        Me.caixatexto_taxa.Name = "caixatexto_taxa"
        Me.caixatexto_taxa.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_taxa.TabIndex = 1
        '
        'texto_taxa
        '
        Me.texto_taxa.AutoSize = True
        Me.texto_taxa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_taxa.Location = New System.Drawing.Point(6, 42)
        Me.texto_taxa.Name = "texto_taxa"
        Me.texto_taxa.Size = New System.Drawing.Size(34, 13)
        Me.texto_taxa.TabIndex = 134
        Me.texto_taxa.Text = "Rate"
        '
        'caixatexto_vp
        '
        Me.caixatexto_vp.Location = New System.Drawing.Point(102, 12)
        Me.caixatexto_vp.Name = "caixatexto_vp"
        Me.caixatexto_vp.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_vp.TabIndex = 0
        '
        'texto_vp
        '
        Me.texto_vp.AutoSize = True
        Me.texto_vp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto_vp.Location = New System.Drawing.Point(6, 19)
        Me.texto_vp.Name = "texto_vp"
        Me.texto_vp.Size = New System.Drawing.Size(86, 13)
        Me.texto_vp.TabIndex = 131
        Me.texto_vp.Text = "Present Value"
        '
        'dgv_emprestimos_amortizacao
        '
        Me.dgv_emprestimos_amortizacao.AllowUserToAddRows = False
        Me.dgv_emprestimos_amortizacao.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_emprestimos_amortizacao.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_emprestimos_amortizacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_emprestimos_amortizacao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Coluna_n_amortizacao, Me.Coluna_amortizacao2})
        Me.dgv_emprestimos_amortizacao.Location = New System.Drawing.Point(322, 416)
        Me.dgv_emprestimos_amortizacao.Name = "dgv_emprestimos_amortizacao"
        Me.dgv_emprestimos_amortizacao.RowHeadersVisible = False
        Me.dgv_emprestimos_amortizacao.RowHeadersWidth = 30
        Me.dgv_emprestimos_amortizacao.Size = New System.Drawing.Size(176, 133)
        Me.dgv_emprestimos_amortizacao.TabIndex = 38
        '
        'Coluna_n_amortizacao
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        Me.Coluna_n_amortizacao.DefaultCellStyle = DataGridViewCellStyle2
        Me.Coluna_n_amortizacao.HeaderText = "n"
        Me.Coluna_n_amortizacao.Name = "Coluna_n_amortizacao"
        Me.Coluna_n_amortizacao.ReadOnly = True
        Me.Coluna_n_amortizacao.Width = 30
        '
        'Coluna_amortizacao2
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Coluna_amortizacao2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Coluna_amortizacao2.HeaderText = "Amortization"
        Me.Coluna_amortizacao2.Name = "Coluna_amortizacao2"
        Me.Coluna_amortizacao2.Width = 120
        '
        'dgv_emprestimos_indices
        '
        Me.dgv_emprestimos_indices.AllowUserToAddRows = False
        Me.dgv_emprestimos_indices.AllowUserToDeleteRows = False
        Me.dgv_emprestimos_indices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_emprestimos_indices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Coluna_n_indices, Me.Coluna_indices})
        Me.dgv_emprestimos_indices.Location = New System.Drawing.Point(9, 392)
        Me.dgv_emprestimos_indices.Name = "dgv_emprestimos_indices"
        Me.dgv_emprestimos_indices.RowHeadersVisible = False
        Me.dgv_emprestimos_indices.Size = New System.Drawing.Size(174, 157)
        Me.dgv_emprestimos_indices.TabIndex = 32
        '
        'Coluna_n_indices
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        Me.Coluna_n_indices.DefaultCellStyle = DataGridViewCellStyle4
        Me.Coluna_n_indices.HeaderText = "n"
        Me.Coluna_n_indices.Name = "Coluna_n_indices"
        Me.Coluna_n_indices.ReadOnly = True
        Me.Coluna_n_indices.Width = 30
        '
        'Coluna_indices
        '
        DataGridViewCellStyle5.NullValue = "0"
        Me.Coluna_indices.DefaultCellStyle = DataGridViewCellStyle5
        Me.Coluna_indices.HeaderText = "Indexes"
        Me.Coluna_indices.Name = "Coluna_indices"
        '
        'btn_adicionar_indices
        '
        Me.btn_adicionar_indices.Enabled = False
        Me.btn_adicionar_indices.Location = New System.Drawing.Point(9, 555)
        Me.btn_adicionar_indices.Name = "btn_adicionar_indices"
        Me.btn_adicionar_indices.Size = New System.Drawing.Size(174, 23)
        Me.btn_adicionar_indices.TabIndex = 33
        Me.btn_adicionar_indices.Text = "Add Indexes"
        Me.btn_adicionar_indices.UseVisualStyleBackColor = True
        '
        'btn_remover_indices
        '
        Me.btn_remover_indices.Enabled = False
        Me.btn_remover_indices.Location = New System.Drawing.Point(9, 584)
        Me.btn_remover_indices.Name = "btn_remover_indices"
        Me.btn_remover_indices.Size = New System.Drawing.Size(174, 23)
        Me.btn_remover_indices.TabIndex = 34
        Me.btn_remover_indices.Text = "Remove Indexes"
        Me.btn_remover_indices.UseVisualStyleBackColor = True
        '
        'dgv_emprestimos_periodo
        '
        Me.dgv_emprestimos_periodo.AllowUserToAddRows = False
        Me.dgv_emprestimos_periodo.AllowUserToDeleteRows = False
        Me.dgv_emprestimos_periodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_emprestimos_periodo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Coluna_n_periodo, Me.Coluna_periodo})
        Me.dgv_emprestimos_periodo.Location = New System.Drawing.Point(189, 392)
        Me.dgv_emprestimos_periodo.Name = "dgv_emprestimos_periodo"
        Me.dgv_emprestimos_periodo.RowHeadersVisible = False
        Me.dgv_emprestimos_periodo.Size = New System.Drawing.Size(127, 157)
        Me.dgv_emprestimos_periodo.TabIndex = 35
        '
        'Coluna_n_periodo
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        Me.Coluna_n_periodo.DefaultCellStyle = DataGridViewCellStyle6
        Me.Coluna_n_periodo.HeaderText = "n"
        Me.Coluna_n_periodo.Name = "Coluna_n_periodo"
        Me.Coluna_n_periodo.ReadOnly = True
        Me.Coluna_n_periodo.Width = 30
        '
        'Coluna_periodo
        '
        DataGridViewCellStyle7.NullValue = "0"
        Me.Coluna_periodo.DefaultCellStyle = DataGridViewCellStyle7
        Me.Coluna_periodo.HeaderText = "Period"
        Me.Coluna_periodo.Name = "Coluna_periodo"
        Me.Coluna_periodo.Width = 70
        '
        'btn_adicionar_periodo
        '
        Me.btn_adicionar_periodo.Enabled = False
        Me.btn_adicionar_periodo.Location = New System.Drawing.Point(189, 555)
        Me.btn_adicionar_periodo.Name = "btn_adicionar_periodo"
        Me.btn_adicionar_periodo.Size = New System.Drawing.Size(127, 23)
        Me.btn_adicionar_periodo.TabIndex = 36
        Me.btn_adicionar_periodo.Text = "Add Periods"
        Me.btn_adicionar_periodo.UseVisualStyleBackColor = True
        '
        'btn_remover_periodo
        '
        Me.btn_remover_periodo.Enabled = False
        Me.btn_remover_periodo.Location = New System.Drawing.Point(189, 584)
        Me.btn_remover_periodo.Name = "btn_remover_periodo"
        Me.btn_remover_periodo.Size = New System.Drawing.Size(127, 23)
        Me.btn_remover_periodo.TabIndex = 37
        Me.btn_remover_periodo.Text = "Remove Periods"
        Me.btn_remover_periodo.UseVisualStyleBackColor = True
        '
        'lista_emprestimos_2
        '
        Me.lista_emprestimos_2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.lista_emprestimos_2.FullRowSelect = True
        Me.lista_emprestimos_2.GridLines = True
        Me.lista_emprestimos_2.Location = New System.Drawing.Point(1018, 12)
        Me.lista_emprestimos_2.Name = "lista_emprestimos_2"
        Me.lista_emprestimos_2.Size = New System.Drawing.Size(508, 446)
        Me.lista_emprestimos_2.TabIndex = 164
        Me.lista_emprestimos_2.UseCompatibleStateImageBehavior = False
        Me.lista_emprestimos_2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "n"
        Me.ColumnHeader12.Width = 43
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Amortization"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 91
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Interest"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 82
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Instalment"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader16.Width = 87
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Balance Debtor"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Balance Corrected"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 100
        '
        'GrupoEscolherTabela
        '
        Me.GrupoEscolherTabela.Controls.Add(Me.GrupoSalvarTabelaComo)
        Me.GrupoEscolherTabela.Controls.Add(Me.rdo_tabela_2)
        Me.GrupoEscolherTabela.Controls.Add(Me.rdo_tabela_1)
        Me.GrupoEscolherTabela.Location = New System.Drawing.Point(1018, 464)
        Me.GrupoEscolherTabela.Name = "GrupoEscolherTabela"
        Me.GrupoEscolherTabela.Size = New System.Drawing.Size(505, 177)
        Me.GrupoEscolherTabela.TabIndex = 166
        Me.GrupoEscolherTabela.TabStop = False
        Me.GrupoEscolherTabela.Text = "Use, to calculation and printing, the table:"
        '
        'GrupoSalvarTabelaComo
        '
        Me.GrupoSalvarTabelaComo.Controls.Add(Me.btn_salvar_excel)
        Me.GrupoSalvarTabelaComo.Location = New System.Drawing.Point(6, 43)
        Me.GrupoSalvarTabelaComo.Name = "GrupoSalvarTabelaComo"
        Me.GrupoSalvarTabelaComo.Size = New System.Drawing.Size(493, 125)
        Me.GrupoSalvarTabelaComo.TabIndex = 2
        Me.GrupoSalvarTabelaComo.TabStop = False
        Me.GrupoSalvarTabelaComo.Text = "Save as:"
        '
        'btn_salvar_excel
        '
        Me.btn_salvar_excel.Location = New System.Drawing.Point(6, 18)
        Me.btn_salvar_excel.Name = "btn_salvar_excel"
        Me.btn_salvar_excel.Size = New System.Drawing.Size(75, 23)
        Me.btn_salvar_excel.TabIndex = 1
        Me.btn_salvar_excel.Text = "Excel"
        Me.btn_salvar_excel.UseVisualStyleBackColor = True
        '
        'rdo_tabela_2
        '
        Me.rdo_tabela_2.AutoSize = True
        Me.rdo_tabela_2.Location = New System.Drawing.Point(79, 19)
        Me.rdo_tabela_2.Name = "rdo_tabela_2"
        Me.rdo_tabela_2.Size = New System.Drawing.Size(61, 17)
        Me.rdo_tabela_2.TabIndex = 1
        Me.rdo_tabela_2.Text = "Table 2"
        Me.rdo_tabela_2.UseVisualStyleBackColor = True
        '
        'rdo_tabela_1
        '
        Me.rdo_tabela_1.AutoSize = True
        Me.rdo_tabela_1.Checked = True
        Me.rdo_tabela_1.Location = New System.Drawing.Point(6, 19)
        Me.rdo_tabela_1.Name = "rdo_tabela_1"
        Me.rdo_tabela_1.Size = New System.Drawing.Size(61, 17)
        Me.rdo_tabela_1.TabIndex = 0
        Me.rdo_tabela_1.TabStop = True
        Me.rdo_tabela_1.Text = "Table 1"
        Me.rdo_tabela_1.UseVisualStyleBackColor = True
        '
        'form_ef_sistemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1537, 651)
        Me.Controls.Add(Me.GrupoEscolherTabela)
        Me.Controls.Add(Me.lista_emprestimos_2)
        Me.Controls.Add(Me.btn_remover_periodo)
        Me.Controls.Add(Me.btn_adicionar_periodo)
        Me.Controls.Add(Me.dgv_emprestimos_periodo)
        Me.Controls.Add(Me.GrupoPgtoForaPrazo)
        Me.Controls.Add(Me.btn_remover_indices)
        Me.Controls.Add(Me.btn_adicionar_indices)
        Me.Controls.Add(Me.dgv_emprestimos_indices)
        Me.Controls.Add(Me.btn_remover_amortizacao)
        Me.Controls.Add(Me.btn_adicionar_amortizacao)
        Me.Controls.Add(Me.dgv_emprestimos_amortizacao)
        Me.Controls.Add(Me.GrupoSistemas)
        Me.Controls.Add(Me.GrupoIntermediaria)
        Me.Controls.Add(Me.GrupoResiduo)
        Me.Controls.Add(Me.GrupoPosFixado)
        Me.Controls.Add(Me.texto_dias_uteis)
        Me.Controls.Add(Me.caixatexto_dias_uteis)
        Me.Controls.Add(Me.combo_impressao)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_visualizar_impressao)
        Me.Controls.Add(Me.caixacombo_tempo)
        Me.Controls.Add(Me.caixacombo_taxa)
        Me.Controls.Add(Me.caixacombo_casas_decimais)
        Me.Controls.Add(Me.texto_casas_decimais)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.lista_emprestimos)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.GrupoCarencia)
        Me.Controls.Add(Me.btn_calcular_eq_taxa)
        Me.Controls.Add(Me.caixatexto_eq_taxa)
        Me.Controls.Add(Me.texto_eq_taxa)
        Me.Controls.Add(Me.GrupoNegociacao)
        Me.Controls.Add(Me.caixatexto_tempo)
        Me.Controls.Add(Me.texto_n)
        Me.Controls.Add(Me.caixatexto_taxa)
        Me.Controls.Add(Me.texto_taxa)
        Me.Controls.Add(Me.caixatexto_vp)
        Me.Controls.Add(Me.texto_vp)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HelpProvider_ef.SetHelpKeyword(Me, "ef.htm")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_ef_sistemas"
        Me.HelpProvider_ef.SetShowHelp(Me, True)
        Me.Text = "Loans and Financing"
        Me.GrupoSistemas.ResumeLayout(False)
        Me.GrupoSistemas.PerformLayout()
        Me.GrupoIntermediaria.ResumeLayout(False)
        Me.GrupoIntermediaria.PerformLayout()
        Me.GrupoResiduo.ResumeLayout(False)
        Me.GrupoResiduo.PerformLayout()
        Me.GrupoPgtoForaPrazo.ResumeLayout(False)
        Me.GrupoPgtoForaPrazo.PerformLayout()
        Me.GrupoPosFixado.ResumeLayout(False)
        Me.GrupoPosFixado.PerformLayout()
        Me.GrupoCarencia.ResumeLayout(False)
        Me.GrupoCarencia.PerformLayout()
        Me.GrupoTipoDeCarencia.ResumeLayout(False)
        Me.GrupoTipoDeCarencia.PerformLayout()
        Me.GrupoNegociacao.ResumeLayout(False)
        Me.GrupoNegociacao.PerformLayout()
        CType(Me.dgv_emprestimos_amortizacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_emprestimos_indices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_emprestimos_periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoEscolherTabela.ResumeLayout(False)
        Me.GrupoEscolherTabela.PerformLayout()
        Me.GrupoSalvarTabelaComo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents HelpProvider_ef As System.Windows.Forms.HelpProvider
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip_ef As System.Windows.Forms.ToolTip
    Friend WithEvents PrintDocument_ef As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog_ef As System.Windows.Forms.PrintDialog
    Friend WithEvents GrupoSistemas As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_sistema_spv As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sistema_sam As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sistema_americano As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sistema_alemao As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sistema_price As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sistema_frances As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sistema_sac As System.Windows.Forms.RadioButton
    Friend WithEvents btn_remover_amortizacao As System.Windows.Forms.Button
    Friend WithEvents btn_adicionar_amortizacao As System.Windows.Forms.Button
    Friend WithEvents GrupoIntermediaria As System.Windows.Forms.GroupBox
    Friend WithEvents caixatexto_valor_intermediaria As System.Windows.Forms.TextBox
    Friend WithEvents texto_valor_intermediaria As System.Windows.Forms.Label
    Friend WithEvents caixatexto_periodo_intermediaria As System.Windows.Forms.TextBox
    Friend WithEvents texto_periodo_intermediaria As System.Windows.Forms.Label
    Friend WithEvents rdo_nao_intermediaria As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sim_intermediaria As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoResiduo As System.Windows.Forms.GroupBox
    Friend WithEvents caixatexto_valor_pagamento As System.Windows.Forms.TextBox
    Friend WithEvents texto_valor_pagamento As System.Windows.Forms.Label
    Friend WithEvents rdo_sem_residuo As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_com_residuo As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoPgtoForaPrazo As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_nao_fora_prazo As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sim_fora_prazo As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoPosFixado As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_pos_fixado_nao As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_pos_fixado_sim As System.Windows.Forms.RadioButton
    Friend WithEvents texto_dias_uteis As System.Windows.Forms.Label
    Friend WithEvents caixatexto_dias_uteis As System.Windows.Forms.TextBox
    Friend WithEvents combo_impressao As System.Windows.Forms.ComboBox
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_visualizar_impressao As System.Windows.Forms.Button
    Friend WithEvents caixacombo_tempo As System.Windows.Forms.ComboBox
    Friend WithEvents caixacombo_taxa As System.Windows.Forms.ComboBox
    Friend WithEvents caixacombo_casas_decimais As System.Windows.Forms.ComboBox
    Friend WithEvents texto_casas_decimais As System.Windows.Forms.Label
    Friend WithEvents btn_limpar As System.Windows.Forms.Button
    Friend WithEvents lista_emprestimos As System.Windows.Forms.ListView
    Friend WithEvents Coluna_n As System.Windows.Forms.ColumnHeader
    Friend WithEvents Coluna_amortizacao As System.Windows.Forms.ColumnHeader
    Friend WithEvents Coluna_juros As System.Windows.Forms.ColumnHeader
    Friend WithEvents Coluna_prestacao As System.Windows.Forms.ColumnHeader
    Friend WithEvents Coluna_saldo_devedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Coluna_saldo_devedor_corrigido As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents GrupoCarencia As System.Windows.Forms.GroupBox
    Friend WithEvents GrupoTipoDeCarencia As System.Windows.Forms.GroupBox
    Friend WithEvents caixatexto_total_n As System.Windows.Forms.TextBox
    Friend WithEvents texto_total_n As System.Windows.Forms.Label
    Friend WithEvents caixatexto_tempo_carencia As System.Windows.Forms.TextBox
    Friend WithEvents texto_tempo_carencia As System.Windows.Forms.Label
    Friend WithEvents rdo_juros_cdc_asd As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_juros_cdc_ppa As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_juros_pdc As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_com_carencia As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_sem_carencia As System.Windows.Forms.RadioButton
    Friend WithEvents btn_calcular_eq_taxa As System.Windows.Forms.Button
    Friend WithEvents caixatexto_eq_taxa As System.Windows.Forms.TextBox
    Friend WithEvents texto_eq_taxa As System.Windows.Forms.Label
    Friend WithEvents GrupoNegociacao As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_negociado_nao As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_negociado_sim As System.Windows.Forms.RadioButton
    Friend WithEvents texto_vp_negociado As System.Windows.Forms.Label
    Friend WithEvents caixatexto_vp_negociado As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_tempo As System.Windows.Forms.TextBox
    Friend WithEvents texto_n As System.Windows.Forms.Label
    Friend WithEvents caixatexto_taxa As System.Windows.Forms.TextBox
    Friend WithEvents texto_taxa As System.Windows.Forms.Label
    Friend WithEvents caixatexto_vp As System.Windows.Forms.TextBox
    Friend WithEvents texto_vp As System.Windows.Forms.Label
    Friend WithEvents dgv_emprestimos_amortizacao As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_emprestimos_indices As System.Windows.Forms.DataGridView
    Friend WithEvents btn_adicionar_indices As System.Windows.Forms.Button
    Friend WithEvents btn_remover_indices As System.Windows.Forms.Button
    Friend WithEvents dgv_emprestimos_periodo As System.Windows.Forms.DataGridView
    Friend WithEvents btn_adicionar_periodo As System.Windows.Forms.Button
    Friend WithEvents btn_remover_periodo As System.Windows.Forms.Button
    Friend WithEvents btn_ok_ef As System.Windows.Forms.Button
    Friend WithEvents caixatexto_tr_ef As System.Windows.Forms.TextBox
    Friend WithEvents texto_tr_ef As System.Windows.Forms.Label
    Friend WithEvents Coluna_n_amortizacao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_amortizacao2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_n_indices As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_indices As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_n_periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coluna_periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lista_emprestimos_2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GrupoEscolherTabela As System.Windows.Forms.GroupBox
    Friend WithEvents GrupoSalvarTabelaComo As System.Windows.Forms.GroupBox
    Friend WithEvents btn_salvar_excel As System.Windows.Forms.Button
    Friend WithEvents rdo_tabela_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_tabela_1 As System.Windows.Forms.RadioButton
    Friend WithEvents EmpFinSaveFileDialog As System.Windows.Forms.SaveFileDialog
End Class
