Public Class Impressao

    Private FonteMensagem4 As New System.Drawing.Font("Arial", 10, System.Drawing.GraphicsUnit.Point)
    Private FonteMensagem As New System.Drawing.Font("Arial", 15, FontStyle.Bold)
    Private FonteMensagem2 As New System.Drawing.Font("Arial", 8, System.Drawing.GraphicsUnit.Point)
    Private FonteMensagem3 As New System.Drawing.Font("Arial", 12, System.Drawing.GraphicsUnit.Point)
    Private margemEsq As Single
    Private margemSup As Single
    Private margemDir As Single
    Private margemInf As Single
    Private pagina As Integer = 1
    Private grafico As Graphics
    Private caminho As String = My.Application.Info.DirectoryPath & "\logo Profinanceira.JPG"
    Private linhaAtual As Integer
    Private linhasPorPagina As Integer
    Private posicaoDaLinha As Integer

    Public Sub ImpressaoEmprestimosFinanciamentos(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        grafico = e.Graphics
        margemEsq = e.MarginBounds.Left
        margemSup = e.MarginBounds.Top
        margemDir = e.MarginBounds.Right
        margemInf = e.MarginBounds.Bottom
        'linhasPorPagina = e.MarginBounds.Height / FonteMensagem3.GetHeight(e.Graphics) - 10
        grafico.DrawLine(Pens.Black, margemEsq, margemSup, margemDir, margemSup)
        grafico.DrawImage(Image.FromFile(caminho), margemEsq, margemSup + 5)
        grafico.DrawLine(Pens.Black, margemEsq, margemSup + 60, margemDir, margemSup + 60)
        linhaAtual = 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        If form_ef_sistemas.rdo_sistema_sac.Checked = True Then 'Sistema de Amortização Constante
            grafico.DrawString("Constant Amortization", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_americano.Checked = True Then 'Sistema Americano
            grafico.DrawString("American System", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_price.Checked = True Then 'Sistema Price
            grafico.DrawString("Price System", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_frances.Checked = True Then 'Sistema Francês
            grafico.DrawString("French System", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_alemao.Checked = True Then 'Sistema Alemão
            grafico.DrawString("German System", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_sam.Checked = True Then 'Sistema de Amortização Misto
            grafico.DrawString("Amortization System Joint", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 80, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_spv.Checked = True Then 'Sistema de Pagamentos Variáveis
            grafico.DrawString("Payment System Variables", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 80, posicaoDaLinha)
        End If
        'INÍCIO
        linhaAtual = 4
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Present Value: " & form_ef_sistemas.caixatexto_vp.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Rate: " & form_ef_sistemas.caixatexto_taxa.Text & "%", FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("NPer: " & form_ef_sistemas.caixatexto_tempo.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Equity rate: " & form_ef_sistemas.caixatexto_eq_taxa.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Present Value Traded: " & form_ef_sistemas.caixatexto_vp_negociado.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 2
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        If form_ef_sistemas.rdo_sistema_sac.Checked = True Then 'Sistema de Amortização Constante
            grafico.DrawString("Shortage", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Time of shortage: " & form_ef_sistemas.caixatexto_tempo_carencia.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Total Period: " & form_ef_sistemas.caixatexto_total_n.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_price.Checked = True Then 'Sistema Price
            grafico.DrawString("Residue", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Payment amount: " & form_ef_sistemas.caixatexto_valor_pagamento.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Intermediate", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Period: " & form_ef_sistemas.caixatexto_periodo_intermediaria.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Intermediate value: " & form_ef_sistemas.caixatexto_valor_intermediaria.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Shortage", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Time of shortage: " & form_ef_sistemas.caixatexto_tempo_carencia.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Total Period: " & form_ef_sistemas.caixatexto_total_n.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_frances.Checked = True Then 'Sistema Francês
            grafico.DrawString("Residue", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Payment amount: " & form_ef_sistemas.caixatexto_valor_pagamento.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Intermediate", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Period: " & form_ef_sistemas.caixatexto_periodo_intermediaria.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Intermediate value: " & form_ef_sistemas.caixatexto_valor_intermediaria.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Shortage", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Time of shortage: " & form_ef_sistemas.caixatexto_tempo_carencia.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_alemao.Checked = True Then 'Sistema Alemão
            grafico.DrawString("Residue", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Payment amount: " & form_ef_sistemas.caixatexto_valor_pagamento.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Intermediate", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Period: " & form_ef_sistemas.caixatexto_periodo_intermediaria.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Intermediate value: " & form_ef_sistemas.caixatexto_valor_intermediaria.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Shortage", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Time of shortage: " & form_ef_sistemas.caixatexto_tempo_carencia.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_sam.Checked = True Then 'Sistema de Amortização Misto
            grafico.DrawString("Residue", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Payment amount: " & form_ef_sistemas.caixatexto_valor_pagamento.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        ElseIf form_ef_sistemas.rdo_sistema_spv.Checked = True Then 'Sistema de Pagamentos Variáveis
            grafico.DrawString("Residue", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
            linhaAtual += 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("Payment amount: " & form_ef_sistemas.caixatexto_valor_pagamento.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        End If
        e.Graphics.DrawLine(Pens.Black, margemEsq - 10, margemInf, margemDir, margemInf)
        e.Graphics.DrawString(System.DateTime.Now, FonteMensagem2, Brushes.Black, margemEsq, margemInf, New StringFormat())
        e.Graphics.DrawString("Pag. " & pagina.ToString, FonteMensagem2, Brushes.Black, margemDir - 50, margemInf, New StringFormat())
    End Sub

    Public Sub ImpressaoCalculosFinanceiros(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
       Dim taxa As String = ""
        Dim tempo As String = ""
        grafico = e.Graphics
        margemEsq = e.MarginBounds.Left
        margemSup = e.MarginBounds.Top
        margemDir = e.MarginBounds.Right
        margemInf = e.MarginBounds.Bottom
        linhaAtual = 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawLine(Pens.Black, margemEsq, margemSup, margemDir, margemSup)
        grafico.DrawImage(Image.FromFile(caminho), margemEsq, margemSup + 5)
        grafico.DrawString("Financial Calculations", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
        grafico.DrawLine(Pens.Black, margemEsq, margemSup + 60, margemDir, margemSup + 60)
        If form_calculos_financeiros.combo_taxa_cfin.SelectedItem = "Daily" Then
            taxa = "% per day"
        ElseIf form_calculos_financeiros.combo_taxa_cfin.SelectedItem = "Monthly" Then
            taxa = "% per month"
        ElseIf form_calculos_financeiros.combo_taxa_cfin.SelectedItem = "Bimonthly" Then
            taxa = "% per bimonth"
        ElseIf form_calculos_financeiros.combo_taxa_cfin.SelectedItem = "Quarterly" Then
            taxa = "% per 3 months"
        ElseIf form_calculos_financeiros.combo_taxa_cfin.SelectedItem = "4 months" Then
            taxa = "% per 4 months"
        ElseIf form_calculos_financeiros.combo_taxa_cfin.SelectedItem = "Semester" Then
            taxa = "% per semester"
        ElseIf form_calculos_financeiros.combo_taxa_cfin.SelectedItem = "Annual (Civil)" Then
            taxa = "% per year"
        ElseIf form_calculos_financeiros.combo_taxa_cfin.SelectedItem = "Annual (Commercial)" Then
            taxa = "% per year"
        ElseIf form_calculos_financeiros.combo_taxa_cfin.SelectedItem = "Annual (Bissextile)" Then
            taxa = "% per year"
        End If
        If form_calculos_financeiros.combo_tempo_cfin.SelectedItem = "Daily" Then
            tempo = " / day"
        ElseIf form_calculos_financeiros.combo_tempo_cfin.SelectedItem = "Monthly" Then
            tempo = " / month"
        ElseIf form_calculos_financeiros.combo_tempo_cfin.SelectedItem = "Bimonthly" Then
            tempo = " / bimonth"
        ElseIf form_calculos_financeiros.combo_tempo_cfin.SelectedItem = "Quarterly" Then
            tempo = " / 3 months"
        ElseIf form_calculos_financeiros.combo_tempo_cfin.SelectedItem = "4 months" Then
            tempo = " / 4 months"
        ElseIf form_calculos_financeiros.combo_tempo_cfin.SelectedItem = "Semester" Then
            tempo = " / semester"
        ElseIf form_calculos_financeiros.combo_tempo_cfin.SelectedItem = "Annual (Civil)" Then
            tempo = " / year"
        ElseIf form_calculos_financeiros.combo_tempo_cfin.SelectedItem = "Annual (Commercial)" Then
            tempo = " / year"
        ElseIf form_calculos_financeiros.combo_tempo_cfin.SelectedItem = "Annual (Bissextile)" Then
            tempo = " / year"
        End If
        linhaAtual = 4
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Present Value: " & form_calculos_financeiros.caixatexto_vp_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("NPer: " & form_calculos_financeiros.caixatexto_tempo_cfin.Text & tempo, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Value of Interest: " & form_calculos_financeiros.caixatexto_montante_juros_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("PMT: " & form_calculos_financeiros.caixatexto_pmt_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Future Value: " & form_calculos_financeiros.caixatexto_vf_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        If form_calculos_financeiros.rdo_juros_simples_cfin.Checked = True Then
            grafico.DrawString("Rate: " & form_calculos_financeiros.caixatexto_eq_i_simples_cfin.Text & taxa, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        Else
            grafico.DrawString("Rate: " & form_calculos_financeiros.caixatexto_eq_i_cfin.Text & taxa, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        End If
        'Inicia VPL ...
        linhaAtual += 2
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Investment: " & form_calculos_financeiros.caixatexto_investimento_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Reinvestment rate: " & form_calculos_financeiros.caixatexto_taxa_reinvestimento_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Net Present Value:" & form_calculos_financeiros.caixatexto_vpl_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Net Present Value 2: " & form_calculos_financeiros.caixatexto_vpl2_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Internal Rate of Return: " & form_calculos_financeiros.caixatexto_tir_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Internal Rate of Return 2: " & form_calculos_financeiros.caixatexto_tir2_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Modified IRR: " & form_calculos_financeiros.caixatexto_tirm_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Profitability Index: " & form_calculos_financeiros.caixatexto_il_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Simple Payback: " & form_calculos_financeiros.caixatexto_payback_simples_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Discounted Payback: " & form_calculos_financeiros.caixatexto_payback_descontado_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        'Termina VPL ...
        'Inicia Juros Exatos, Comericais e Bancários
        'Juros Exatos
        linhaAtual += 2
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Accurate:", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Interest: " & form_calculos_financeiros.caixatexto_juros_exatos_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("i: " & form_calculos_financeiros.caixatexto_exatos_i_ecb_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("n: " & form_calculos_financeiros.caixatexto_exatos_n_ecb_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        'Juros Comerciais
        linhaAtual += 2
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Commercial:", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Interest: " & form_calculos_financeiros.caixatexto_juros_comerciais_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("i: " & form_calculos_financeiros.caixatexto_comercial_i_ecb_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("n: " & form_calculos_financeiros.caixatexto_comercial_n_ecb_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        'Juros Bancários
        linhaAtual += 2
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Banking:", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Interest: " & form_calculos_financeiros.caixatexto_juros_bancarios_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("i: " & form_calculos_financeiros.caixatexto_bancarios_i_ecb_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("n: " & form_calculos_financeiros.caixatexto_bancarios_n_ecb_cfin.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        'Termina Juros Exatos, COmerciais e Bancários
        grafico.DrawLine(Pens.Black, margemEsq - 10, margemInf, margemDir, margemInf)
        grafico.DrawString(System.DateTime.Now, FonteMensagem2, Brushes.Black, margemEsq, margemInf, New StringFormat())
        grafico.DrawString("Pag. " & pagina.ToString, FonteMensagem2, Brushes.Black, margemDir - 50, margemInf, New StringFormat())
    End Sub

    Public Sub impressaoDescontosTitulos(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        grafico = e.Graphics
        margemEsq = e.MarginBounds.Left
        margemSup = e.MarginBounds.Top
        margemDir = e.MarginBounds.Right
        margemInf = e.MarginBounds.Bottom
        linhaAtual = 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawLine(Pens.Black, margemEsq, margemSup, margemDir, margemSup)
        grafico.DrawImage(Image.FromFile(caminho), margemEsq, margemSup + 5)
        grafico.DrawString("Discount of Titles", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
        grafico.DrawLine(Pens.Black, margemEsq, margemSup + 60, margemDir, margemSup + 60)
        'Desconto de Títulos
        linhaAtual = 4
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Value Title: " & form_descontos_titulos.caixatexto_vt_dt.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Interst Rate: " & form_descontos_titulos.caixatexto_taxa_dt.Text & "%", FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("NPer: " & form_descontos_titulos.caixatexto_tempo_dt.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Discount: " & form_descontos_titulos.caixatexto_desconto_dt.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Discounted Value: " & form_descontos_titulos.caixatexto_vd_dt.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Discounted Value without charges: " & form_descontos_titulos.caixatexto_vd_sem_encargos_dt.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Cost effective operation: " & form_descontos_titulos.caixatexto_custo_efetivo_dt.Text & "%", FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("TFT: " & form_descontos_titulos.caixatexto_iof_dt.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Rate TFT: " & form_descontos_titulos.caixatexto_taxa_iof_dt.Text & "%", FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Tariff: " & form_descontos_titulos.caixatexto_tarifa_dt.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Rate of Credit Opening: " & form_descontos_titulos.caixatexto_tac_dt.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Other charges: " & form_descontos_titulos.caixatexto_outros_encargos_dt.Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        'Taxa
        linhaAtual += 2
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Rates", FonteMensagem, Brushes.Blue, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Apparent rate: " & form_descontos_titulos.caixatexto_aparente_dt.Text & "%", FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Real rate: " & form_descontos_titulos.caixatexto_real_dt.Text & "%", FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Inflation rate: " & form_descontos_titulos.caixatexto_inflacao_dt.Text & "%", FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Accumulated rate: " & form_descontos_titulos.caixatexto_custo_efetivo_dt.Text & "%", FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        linhaAtual += 1
        posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
        grafico.DrawString("Management fee: " & form_descontos_titulos.caixatexto_taxa_administracao_dt.Text & "%", FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
        grafico.DrawLine(Pens.Black, margemEsq - 10, margemInf, margemDir, margemInf)
        grafico.DrawString(System.DateTime.Now, FonteMensagem2, Brushes.Black, margemEsq, margemInf, New StringFormat())
        grafico.DrawString("Pag. " & pagina.ToString, FonteMensagem2, Brushes.Black, margemDir - 50, margemInf, New StringFormat())
    End Sub
End Class
