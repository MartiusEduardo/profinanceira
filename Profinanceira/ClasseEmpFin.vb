Public Class ClasseEmpFin

    Private i As Integer, item As ListViewItem
    Private juros(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private amortizacao(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private prestacao(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private saldodevedor(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private saldodevedor_corrigido(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private periodos_fora_prazo(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private pmt1 As Double, novo_vp As Double, novo_vp2 As Double
    Private prestacao_sac(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private prestacao_price(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private prestacao_media(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private amortizacao_spv(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private prestacao2 As Double, soma_spv As Double, cdc_asd As String
    Private MsgIndices As String = "", MsgPeriodos As String = "", MsgSPV As String = ""
    Private z As Integer, n As Integer, y As Integer, k As Integer, p As Integer
    Private nova_prestacao As Double, nova_amortizacao As Double
    Private item2(0 To form_ef_sistemas.caixatexto_total_n.Text) As Double
    Private totalamort As Double, totaljuros As Double, totalprest As Double
    'Valores inseridos
    Private VPInserido, TaxaInserida, PrazoInserido, EqTaxaCalculada, TempoTotalInserido As Double
    Private VPNInserido, PagamentoInserido, IntermValorInserido As Double
    Private IntermPeriodoInserido, TempoCarenciaInserido As Integer

    Public Sub CalcularEmpFin(ByVal VP As Double, ByVal Taxa As Double, ByVal Prazo As Double, ByVal EqTaxa As Double, ByVal TempoCarencia As Integer, ByVal TempoTotal As Double, Optional ByVal VPNegociado As Double = 0, Optional ByVal Pagamento As Double = 0, Optional ByVal IntermPeriodo As Integer = 0, Optional ByVal IntermValor As Double = 0)
        VPInserido = VP
        TaxaInserida = Taxa
        PrazoInserido = Prazo
        EqTaxaCalculada = EqTaxa
        VPNInserido = VPNegociado
        PagamentoInserido = Pagamento
        IntermPeriodoInserido = IntermPeriodo
        IntermValorInserido = IntermValor
        TempoCarenciaInserido = TempoCarencia
        TempoTotalInserido = TempoTotal
        If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
            If PrazoInserido - 1 <> form_ef_sistemas.dgv_emprestimos_indices.Rows.Count - 1 Then
                MsgBox("You must fill correctly the table of indexes.", MsgBoxStyle.OkOnly, "ProFinanceira")
                Exit Sub
            End If
            Me.PreencherTabelaIndices()
        End If
        If form_ef_sistemas.rdo_nao_fora_prazo.Checked = False Then
            If TempoTotalInserido <> form_ef_sistemas.dgv_emprestimos_periodo.Rows.Count - 1 Then
                MsgBox("You must fill correctly the table of periods.", MsgBoxStyle.OkOnly, "ProFinanceira")
                Exit Sub
            End If
            Me.PreencherTabelaPeriodos()
        End If
        If form_ef_sistemas.rdo_sistema_sac.Checked = True Then
            SAC()
        ElseIf form_ef_sistemas.rdo_sistema_americano.Checked = True Then
            SAmericano()
        ElseIf form_ef_sistemas.rdo_sistema_frances.Checked = True Then
            SFrancesEPrice()
        ElseIf form_ef_sistemas.rdo_sistema_price.Checked = True Then
            SFrancesEPrice()
        ElseIf form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
            SAlemao()
        ElseIf form_ef_sistemas.rdo_sistema_sam.Checked = True Then
            SAM()
        ElseIf form_ef_sistemas.rdo_sistema_spv.Checked = True Then
            SPV()
        End If
    End Sub
    Private Sub SAC()
        Dim msg As String = ""
        If form_ef_sistemas.rdo_negociado_nao.Checked = True Then
            saldodevedor(0) = VPInserido
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        Else
            saldodevedor(0) = VPNInserido
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        End If
        z = 0
        p = 0
        If form_ef_sistemas.rdo_sem_carencia.Checked = False Then
            If TempoCarenciaInserido = 0 Then
                MsgBox("You need to tell which time of shortage.", MsgBoxStyle.OkOnly, "ProFinanceira")
                Exit Sub
            End If
            If form_ef_sistemas.rdo_juros_pdc.Checked = True Then
                Me.carenciaPDC(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_ppa.Checked = True Then
                Me.carenciaCDCPPA(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                Me.carenciaCDCASD(saldodevedor(0), saldodevedor_corrigido(0))
            End If
        Else
            n = 1
        End If
        For i = n To TempoTotalInserido
            Me.CalculoAmortizacao()
            Me.CalculoSaldoDevedor()
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                    amortizacao(i) = saldodevedor_corrigido(i - 1) - saldodevedor(i)
                End If
            End If
            Me.CalculoJuros()
            prestacao(i) = amortizacao(i) + juros(i)
            totalamort = totalamort + amortizacao(i)
            totaljuros = totaljuros + juros(i)
            totalprest = totalprest + prestacao(i)
        Next
        If form_ef_sistemas.rdo_nao_intermediaria.Checked = False Then
            For i = n To TempoTotalInserido
                Me.Intermediaria()
                If i >= IntermPeriodoInserido Then
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                        saldodevedor(i) = saldodevedor_corrigido(i - 1) - amortizacao(i)
                        saldodevedor_corrigido(i) = saldodevedor(i) * (1 + (item2(i - TempoCarenciaInserido) / 100))
                    Else
                        saldodevedor(i) = saldodevedor(i - 1) - amortizacao(i)
                    End If
                    prestacao(i) = amortizacao(i) + juros(i)
                End If
            Next
        End If
        If form_ef_sistemas.rdo_nao_fora_prazo.Checked = False Then
            For i = n To TempoTotalInserido
                Me.fora_do_prazo()
                Me.CalculoJuros()
                amortizacao(i) = prestacao(i) - juros(i)
                If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                    saldodevedor(i) = saldodevedor_corrigido(i - 1) - amortizacao(i)
                    saldodevedor_corrigido(i) = saldodevedor(i) * (1 + (item2(i - TempoCarenciaInserido) / 100))
                Else
                    saldodevedor(i) = saldodevedor(i - 1) - amortizacao(i)
                End If
                totalamort = totalamort + amortizacao(i)
                totaljuros = totaljuros + juros(i)
                totalprest = totalprest + prestacao(i)
            Next
        End If
        Me.MostrarResultado()
    End Sub

    Private Sub SAmericano()
        If form_ef_sistemas.rdo_negociado_nao.Checked = True Then
            saldodevedor(0) = VPInserido
        Else
            saldodevedor(0) = VPNInserido
        End If
        If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
            For i = 1 To PrazoInserido
                If i < PrazoInserido Then
                    amortizacao(i) = 0
                    juros(i) = 0
                    prestacao(i) = 0
                    saldodevedor(i) = 0
                ElseIf i = PrazoInserido Then
                    amortizacao(i) = VPInserido * ((1 + EqTaxaCalculada) ^ PrazoInserido)
                    juros(i) = 0
                    prestacao(i) = amortizacao(i) + juros(i)
                    saldodevedor(i) = 0
                    totalamort = totalamort + amortizacao(i)
                    totaljuros = 0
                    totalprest = totalprest + prestacao(i)
                End If
            Next
            Dim item As New ListViewItem
            For i = 0 To PrazoInserido + 1
                If i = PrazoInserido + 1 Then
                    If form_ef_sistemas.rdo_tabela_1.Checked = True Then
                        item = form_ef_sistemas.lista_emprestimos.Items.Add("Total")
                    ElseIf form_ef_sistemas.rdo_tabela_2.Checked = True Then
                        item = form_ef_sistemas.lista_emprestimos_2.Items.Add("Total")
                    End If
                    item.Text = "Total"
                    item.SubItems.Add(Decimal.Round(totalamort, 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(totaljuros, 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(totalprest, 2, MidpointRounding.ToEven))
                    item.SubItems.Add(0)
                    item.SubItems.Add(0)
                Else
                    If form_ef_sistemas.rdo_tabela_1.Checked = True Then
                        item = form_ef_sistemas.lista_emprestimos.Items.Add(i)
                    ElseIf form_ef_sistemas.rdo_tabela_2.Checked = True Then
                        item = form_ef_sistemas.lista_emprestimos_2.Items.Add(i)
                    End If
                    item.Text = i
                    item.SubItems.Add(Decimal.Round(amortizacao(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(juros(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(prestacao(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(saldodevedor(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(0)
                End If
            Next
        ElseIf form_ef_sistemas.rdo_sem_carencia.Checked = False Then
            If form_ef_sistemas.rdo_juros_pdc.Checked = True Then
                For i = 1 To PrazoInserido
                    If i < PrazoInserido Then
                        amortizacao(i) = 0
                        juros(i) = saldodevedor(i - 1) * EqTaxaCalculada
                        prestacao(i) = amortizacao(i) + juros(i)
                        saldodevedor(i) = saldodevedor(0)
                        totalamort = totalamort + amortizacao(i)
                        totaljuros = totaljuros + juros(i)
                        totalprest = totalprest + prestacao(i)
                    ElseIf i = PrazoInserido Then
                        amortizacao(i) = saldodevedor(0)
                        juros(i) = saldodevedor(i - 1) * EqTaxaCalculada
                        prestacao(i) = amortizacao(i) + juros(i)
                        saldodevedor(i) = 0
                        totalamort = totalamort + amortizacao(i)
                        totaljuros = totaljuros + juros(i)
                        totalprest = totalprest + prestacao(i)
                    End If
                Next
                Dim item As New ListViewItem
                For i = 0 To PrazoInserido + 1
                    If i = PrazoInserido + 1 Then
                        If form_ef_sistemas.rdo_tabela_1.Checked = True Then
                            item = form_ef_sistemas.lista_emprestimos.Items.Add("Total")
                        ElseIf form_ef_sistemas.rdo_tabela_2.Checked = True Then
                            item = form_ef_sistemas.lista_emprestimos_2.Items.Add("Total")
                        End If
                        item.Text = "Total"
                        item.SubItems.Add(Decimal.Round(totalamort, 2, MidpointRounding.ToEven))
                        item.SubItems.Add(Decimal.Round(totaljuros, 2, MidpointRounding.ToEven))
                        item.SubItems.Add(Decimal.Round(totalprest, 2, MidpointRounding.ToEven))
                        item.SubItems.Add(0)
                        item.SubItems.Add(0)
                    Else
                        If form_ef_sistemas.rdo_tabela_1.Checked = True Then
                            item = form_ef_sistemas.lista_emprestimos.Items.Add(i)
                        ElseIf form_ef_sistemas.rdo_tabela_2.Checked = True Then
                            item = form_ef_sistemas.lista_emprestimos_2.Items.Add(i)
                        End If
                        item.Text = i
                        item.SubItems.Add(Decimal.Round(amortizacao(i), 2, MidpointRounding.ToEven))
                        item.SubItems.Add(Decimal.Round(juros(i), 2, MidpointRounding.ToEven))
                        item.SubItems.Add(Decimal.Round(prestacao(i), 2, MidpointRounding.ToEven))
                        item.SubItems.Add(Decimal.Round(saldodevedor(i), 2, MidpointRounding.ToEven))
                        item.SubItems.Add(0)
                    End If
                Next
            ElseIf form_ef_sistemas.rdo_juros_cdc_ppa.Checked = True Then
                Dim juroscalc As Double, jurosacum As Double
                For i = 1 To PrazoInserido
                    If i < PrazoInserido Then
                        amortizacao(i) = 0
                        juros(i) = 0
                        prestacao(i) = 0
                        saldodevedor(i) = saldodevedor(i - 1) + (saldodevedor(i - 1) * EqTaxaCalculada)
                        juroscalc = saldodevedor(i - 1) * EqTaxaCalculada
                        jurosacum = jurosacum + juroscalc
                    Else
                        amortizacao(i) = saldodevedor(0)
                        juroscalc = saldodevedor(i - 1) * EqTaxaCalculada
                        jurosacum = jurosacum + juroscalc
                        juros(i) = jurosacum
                        prestacao(i) = amortizacao(i) + juros(i)
                        saldodevedor(i) = saldodevedor(i - 1) + (saldodevedor(i - 1) * EqTaxaCalculada)
                        totalamort = totalamort + amortizacao(i)
                        totaljuros = totaljuros + juros(i)
                        totalprest = totalprest + prestacao(i)
                    End If
                Next
                Dim item As New ListViewItem
                For i = 0 To PrazoInserido + 1
                    If i = PrazoInserido + 1 Then
                        If form_ef_sistemas.rdo_tabela_1.Checked = True Then
                            item = form_ef_sistemas.lista_emprestimos.Items.Add("Total")
                        ElseIf form_ef_sistemas.rdo_tabela_2.Checked = True Then
                            item = form_ef_sistemas.lista_emprestimos_2.Items.Add("Total")
                        End If
                        item.Text = "Total"
                        item.SubItems.Add(Decimal.Round(totalamort, 2, MidpointRounding.ToEven))
                        item.SubItems.Add(Decimal.Round(totaljuros, 2, MidpointRounding.ToEven))
                        item.SubItems.Add(Decimal.Round(totalprest, 2, MidpointRounding.ToEven))
                        item.SubItems.Add(0)
                        item.SubItems.Add(0)
                    Else
                        If form_ef_sistemas.rdo_tabela_1.Checked = True Then
                            item = form_ef_sistemas.lista_emprestimos.Items.Add(i)
                        ElseIf form_ef_sistemas.rdo_tabela_2.Checked = True Then
                            item = form_ef_sistemas.lista_emprestimos_2.Items.Add(i)
                        End If
                        item.Text = i
                        item.SubItems.Add(Decimal.Round(amortizacao(i), 2, MidpointRounding.ToEven))
                        item.SubItems.Add(Decimal.Round(juros(i), 2, MidpointRounding.ToEven))
                        item.SubItems.Add(Decimal.Round(prestacao(i), 2, MidpointRounding.ToEven))
                        If i < PrazoInserido Then
                            item.SubItems.Add(Decimal.Round(saldodevedor(0), 2, MidpointRounding.ToEven))
                        Else
                            item.SubItems.Add(0)
                        End If
                        If i > 0 Then
                            item.SubItems.Add(Decimal.Round(saldodevedor(i), 2, MidpointRounding.ToEven))
                        Else
                            item.SubItems.Add(0)
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub SFrancesEPrice()
        If form_ef_sistemas.rdo_negociado_nao.Checked = True Then
            saldodevedor(0) = VPInserido
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        Else
            saldodevedor(0) = VPNInserido
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        End If
        If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
            nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, saldodevedor(0))
        Else
            novo_vp = IntermValorInserido / _
            ((1 + EqTaxaCalculada) ^ (IntermPeriodoInserido - TempoCarenciaInserido))
            novo_vp2 = saldodevedor(0) - novo_vp
            nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, novo_vp2)
        End If
        If form_ef_sistemas.rdo_sem_carencia.Checked = False Then
            If TempoCarenciaInserido = 0 Then
                MsgBox("You need to tell which time of shortage.", MsgBoxStyle.OkOnly, "ProFinanceira")
                Exit Sub
            End If
            If form_ef_sistemas.rdo_juros_pdc.Checked = True Then
                Me.carenciaPDC(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_ppa.Checked = True Then
                Me.carenciaCDCPPA(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                Me.carenciaCDCASD(saldodevedor(0), saldodevedor_corrigido(0))
            End If
        Else
            n = 1
            k = 0
        End If
        z = 0
        For i = n To TempoTotalInserido
            Me.CalculoJuros()
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                prestacao(i) = saldodevedor_corrigido(i - 1) * _
                ((((1 + EqTaxaCalculada) ^ (PrazoInserido - k)) * EqTaxaCalculada) _
                / (((1 + EqTaxaCalculada) ^ (PrazoInserido - k)) - 1))
                k += 1
            End If
            If form_ef_sistemas.rdo_sem_residuo.Checked = False Then
                prestacao(i) = PagamentoInserido
            ElseIf form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                prestacao(i) = nova_prestacao
            End If
            If form_ef_sistemas.rdo_nao_intermediaria.Checked = False Then
                Me.Intermediaria()
            End If
            amortizacao(i) = prestacao(i) - juros(i)
            Me.CalculoSaldoDevedor()
            totalamort = totalamort + amortizacao(i)
            totaljuros = totaljuros + juros(i)
            totalprest = totalprest + prestacao(i)
        Next
        If form_ef_sistemas.rdo_nao_fora_prazo.Checked = False Then
            For i = n To TempoTotalInserido
                Me.fora_do_prazo()
                Me.CalculoJuros()
                amortizacao(i) = prestacao(i) - juros(i)
                Me.CalculoSaldoDevedor()
                totalamort = totalamort + amortizacao(i)
                totaljuros = totaljuros + juros(i)
                totalprest = totalprest + prestacao(i)
            Next
        End If
        Me.MostrarResultado()
    End Sub

    Private Sub SAlemao()
        If form_ef_sistemas.rdo_negociado_nao.Checked = True Then
            saldodevedor(0) = VPInserido
            If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                juros(0) = saldodevedor(0) * EqTaxaCalculada
            Else
                juros(0) = 0
            End If
            prestacao(0) = juros(0)
            totaljuros = juros(0)
            totalprest = prestacao(0)
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        Else
            saldodevedor(0) = VPNInserido
            If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                juros(0) = saldodevedor(0) * EqTaxaCalculada
            Else
                juros(0) = 0
            End If
            prestacao(0) = juros(0)
            totaljuros = juros(0)
            totalprest = prestacao(0)
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        End If
        If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                nova_prestacao = (saldodevedor(0) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
            Else
                nova_prestacao = (saldodevedor_corrigido(0) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
            End If
        Else
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                nova_prestacao = ((saldodevedor(0) - IntermValorInserido) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
            Else
                nova_prestacao = ((saldodevedor_corrigido(0) - IntermValorInserido) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
            End If
        End If
        If form_ef_sistemas.rdo_sem_carencia.Checked = False Then
            If TempoCarenciaInserido = 0 Then
                MsgBox("You need to tell which time of shortage.", MsgBoxStyle.OkOnly, "ProFinanceira")
                Exit Sub
            End If
            If form_ef_sistemas.rdo_juros_pdc.Checked = True Then
                Me.carenciaPDC(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_ppa.Checked = True Then
                Me.carenciaCDCPPA(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                Me.carenciaCDCASD(saldodevedor(0), saldodevedor_corrigido(0))
            End If
        Else
            n = 1
        End If
        z = 1
        k = 1
        For i = n To TempoTotalInserido
            prestacao(i) = nova_prestacao
            Me.CalculoAmortizacao()
            Me.CalculoSaldoDevedor()
            Me.CalculoJuros()
        Next
        Me.MostrarResultado()
    End Sub

    Private Sub SAM()
        If form_ef_sistemas.rdo_negociado_nao.Checked = True Then
            saldodevedor(0) = VPInserido
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        Else
            saldodevedor(0) = VPNInserido
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        End If
        z = 0
        p = 0
        'COMEÇA SISTEMA SAC
        If form_ef_sistemas.rdo_sem_residuo.Checked = True Then
            cdc_asd = "SAC"
            If form_ef_sistemas.rdo_sem_carencia.Checked = False Then
                If TempoCarenciaInserido = 0 Then
                    MsgBox("You need to tell which time of shortage.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                If form_ef_sistemas.rdo_juros_pdc.Checked = True Then
                    Me.carenciaPDC(saldodevedor(0), saldodevedor_corrigido(0))
                ElseIf form_ef_sistemas.rdo_juros_cdc_ppa.Checked = True Then
                    Me.carenciaCDCPPA(saldodevedor(0), saldodevedor_corrigido(0))
                ElseIf form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                    Me.carenciaCDCASD(saldodevedor(0), saldodevedor_corrigido(0))
                End If
            Else
                n = 1
            End If
            For i = n To TempoTotalInserido
                Me.CalculoAmortizacao()
                Me.CalculoSaldoDevedor()
                If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                    If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                        amortizacao(i) = saldodevedor_corrigido(i - 1) - saldodevedor(i)
                    End If
                End If
                Me.CalculoJuros()
                prestacao_sac(i) = amortizacao(i) + juros(i)
            Next
            If form_ef_sistemas.rdo_nao_intermediaria.Checked = False Then
                For i = n To TempoTotalInserido
                    Me.Intermediaria()
                    If i >= IntermPeriodoInserido Then
                        If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                            saldodevedor(i) = saldodevedor_corrigido(i - 1) - amortizacao(i)
                            saldodevedor_corrigido(i) = saldodevedor(i) * (1 + (item2(i - TempoCarenciaInserido) / 100))
                        Else
                            saldodevedor(i) = saldodevedor(i - 1) - amortizacao(i)
                        End If
                        prestacao_sac(i) = amortizacao(i) + juros(i)
                    End If
                Next
            End If
            If form_ef_sistemas.rdo_nao_intermediaria.Checked = False Then
                prestacao_sac(IntermPeriodoInserido) = prestacao_sac(IntermPeriodoInserido) - IntermValorInserido
            End If
            'TERMINA SISTEMA SAC
            'COMEÇA SISTEMA PRICE
            cdc_asd = "Price"
            If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, saldodevedor(0))
            Else
                novo_vp = IntermValorInserido / _
                ((1 + EqTaxaCalculada) ^ (IntermPeriodoInserido - TempoCarenciaInserido))
                novo_vp2 = saldodevedor(0) - novo_vp
                nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, novo_vp2)
            End If
            If form_ef_sistemas.rdo_sem_carencia.Checked = False Then
                If form_ef_sistemas.rdo_juros_pdc.Checked = True Then
                    Me.carenciaPDC(saldodevedor(0), saldodevedor_corrigido(0))
                ElseIf form_ef_sistemas.rdo_juros_cdc_ppa.Checked = True Then
                    Me.carenciaCDCPPA(saldodevedor(0), saldodevedor_corrigido(0))
                ElseIf form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                    Me.carenciaCDCASD(saldodevedor(0), saldodevedor_corrigido(0))
                End If
            Else
                n = 1
                k = 0
            End If
            z = 0
            For i = n To TempoTotalInserido
                Me.CalculoJuros()
                If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                    prestacao_price(i) = saldodevedor_corrigido(i - 1) * _
                    ((((1 + EqTaxaCalculada) ^ (PrazoInserido - k)) * EqTaxaCalculada) _
                    / (((1 + EqTaxaCalculada) ^ (PrazoInserido - k)) - 1))
                    k += 1
                End If
                If form_ef_sistemas.rdo_sem_residuo.Checked = False Then
                    prestacao_price(i) = PagamentoInserido
                ElseIf form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                    prestacao_price(i) = nova_prestacao
                End If
                amortizacao(i) = prestacao_price(i) - juros(i)
                Me.CalculoSaldoDevedor()
            Next
        End If
        'TERMINA SISTEMA PRICE
        If form_ef_sistemas.rdo_sem_residuo.Checked = True Then
            For i = 1 To TempoTotalInserido
                prestacao_media(i) = (prestacao_sac(i) + prestacao_price(i)) / 2
            Next
        End If
        cdc_asd = "SAM"
        If form_ef_sistemas.rdo_sem_carencia.Checked = False Then
            If form_ef_sistemas.rdo_juros_pdc.Checked = True Then
                Me.carenciaPDC(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_ppa.Checked = True Then
                Me.carenciaCDCPPA(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                Me.carenciaCDCASD(saldodevedor(0), saldodevedor_corrigido(0))
            End If
        Else
            n = 1
        End If
        z = 0
        For i = n To TempoTotalInserido
            If form_ef_sistemas.rdo_sem_residuo.Checked = False Then
                prestacao(i) = PagamentoInserido
            Else
                prestacao(i) = prestacao_media(i)
            End If
            If form_ef_sistemas.rdo_nao_intermediaria.Checked = False Then
                Me.Intermediaria()
            End If
            Me.CalculoJuros()
            amortizacao(i) = prestacao(i) - juros(i)
            Me.CalculoSaldoDevedor()
            totalamort = totalamort + amortizacao(i)
            totaljuros = totaljuros + juros(i)
            totalprest = totalprest + prestacao(i)
        Next
        If form_ef_sistemas.rdo_nao_fora_prazo.Checked = False Then
            For i = n To TempoTotalInserido
                Me.fora_do_prazo()
                Me.CalculoJuros()
                amortizacao(i) = prestacao(i) - juros(i)
                Me.CalculoSaldoDevedor()
                totalamort = totalamort + amortizacao(i)
                totaljuros = totaljuros + juros(i)
                totalprest = totalprest + prestacao(i)
            Next
        End If
        Me.MostrarResultado()
    End Sub

    Private Sub SPV()
        If form_ef_sistemas.rdo_negociado_nao.Checked = True Then
            saldodevedor(0) = VPInserido
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        Else
            saldodevedor(0) = VPNInserido
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                If form_ef_sistemas.rdo_sem_carencia.Checked = True Then
                    saldodevedor_corrigido(0) = saldodevedor(0) * (1 + (item2(0) / 100))
                Else
                    saldodevedor_corrigido(0) = saldodevedor(0)
                End If
            End If
        End If
        amortizacao_spv(0) = 0
        For i = 0 To PrazoInserido - 1
            amortizacao_spv(i + 1) = form_ef_sistemas.dgv_emprestimos_amortizacao.Rows.Item(i).Cells.Item(1).Value
        Next
        If form_ef_sistemas.rdo_sem_carencia.Checked = False Then
            If TempoCarenciaInserido = 0 Then
                MsgBox("You need to tell which time of shortage.", MsgBoxStyle.OkOnly, "ProFinanceira")
                Exit Sub
            End If
            If form_ef_sistemas.rdo_juros_pdc.Checked = True Then
                Me.carenciaPDC(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_ppa.Checked = True Then
                Me.carenciaCDCPPA(saldodevedor(0), saldodevedor_corrigido(0))
            ElseIf form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                Me.carenciaCDCASD(saldodevedor(0), saldodevedor_corrigido(0))
            End If
        Else
            n = 1
        End If
        For i = 0 To TempoTotalInserido
            soma_spv = soma_spv + amortizacao_spv(i)
        Next
        Me.VerificaErroSPV()
        If MsgSPV <> "" Then
            MsgBox(MsgSPV, MsgBoxStyle.OkOnly, "Amortização")
            Exit Sub
        End If
        z = 0
        For i = n To TempoTotalInserido
            amortizacao(i) = amortizacao_spv(i - TempoCarenciaInserido)
            Me.CalculoJuros()
            If form_ef_sistemas.rdo_sem_residuo.Checked = False Then
                prestacao(i) = PagamentoInserido
                amortizacao(i) = prestacao(i) - juros(i)
            Else
                prestacao(i) = amortizacao(i) + juros(i)
            End If
            Me.CalculoSaldoDevedor()
            totalamort = totalamort + amortizacao(i)
            totaljuros = totaljuros + juros(i)
            totalprest = totalprest + prestacao(i)
        Next
        If form_ef_sistemas.rdo_nao_fora_prazo.Checked = False Then
            For i = n To TempoTotalInserido
                Me.fora_do_prazo()
                Me.CalculoJuros()
                amortizacao(i) = prestacao(i) - juros(i)
                Me.CalculoSaldoDevedor()
                totalamort = totalamort + amortizacao(i)
                totaljuros = totaljuros + juros(i)
                totalprest = totalprest + prestacao(i)
            Next
        End If
        Me.MostrarResultado()
    End Sub

    Private Function VerificaErroSPV()
        If form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
            If form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                If Decimal.Round(soma_spv, 2, MidpointRounding.ToEven) <> Decimal.Round(saldodevedor(n - 2) + (saldodevedor(n - 2) * EqTaxaCalculada), 2, MidpointRounding.ToEven) Then
                    MsgSPV = "The sum of amortizations must be equal to " & Decimal.Round(saldodevedor(n - 2) + (saldodevedor(n - 2) * EqTaxaCalculada), 2, MidpointRounding.ToEven)
                End If
            Else
                If Decimal.Round(soma_spv, 2, MidpointRounding.ToEven) <> Decimal.Round(saldodevedor(n - 1), 2, MidpointRounding.ToEven) Then
                    MsgSPV = "The sum of amortizations must be equal to " & Decimal.Round(saldodevedor(n - 1), 2, MidpointRounding.ToEven)
                End If
            End If
        Else
            If form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                If Decimal.Round(soma_spv, 2, MidpointRounding.ToEven) <> Decimal.Round(saldodevedor_corrigido(n - 2) + (saldodevedor_corrigido(n - 2) * EqTaxaCalculada), 2, MidpointRounding.ToEven) Then
                    MsgSPV = "The sum of amortizations must be equal to " & Decimal.Round(saldodevedor_corrigido(n - 2) + (saldodevedor_corrigido(n - 2) * EqTaxaCalculada), 2, MidpointRounding.ToEven)
                End If
            Else
                If Decimal.Round(soma_spv, 2, MidpointRounding.ToEven) <> Decimal.Round(saldodevedor_corrigido(n - 1), 2, MidpointRounding.ToEven) Then
                    MsgSPV = "The sum of amortizations must be equal to " & Decimal.Round(saldodevedor_corrigido(n - 1), 2, MidpointRounding.ToEven)
                End If
            End If
        End If
        Return MsgSPV
    End Function

    Private Function PreencherTabelaIndices()
        For i = 0 To PrazoInserido - 1
            item2(i) = form_ef_sistemas.dgv_emprestimos_indices.Rows.Item(i).Cells.Item(1).Value
        Next
        Return "PTI"
    End Function

    Private Function PreencherTabelaPeriodos()
        For i = 0 To TempoTotalInserido - 1
            periodos_fora_prazo(i) = form_ef_sistemas.dgv_emprestimos_periodo.Rows.Item(i).Cells.Item(1).Value
        Next
        Return "PTP"
    End Function

    Private Function CalculoJuros()
        If form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                juros(i) = saldodevedor_corrigido(i) * EqTaxaCalculada
            Else
                juros(i) = saldodevedor(i) * EqTaxaCalculada
            End If
        Else
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                juros(i) = saldodevedor_corrigido(i - 1) * EqTaxaCalculada
            Else
                juros(i) = saldodevedor(i - 1) * EqTaxaCalculada
            End If
        End If
        Return "Juros"
    End Function

    Private Function CalculoAmortizacao()
        If form_ef_sistemas.rdo_sistema_sac.Checked = True _
        Or cdc_asd = "SAC" Then
            If form_ef_sistemas.rdo_sem_carencia.Checked = False Then
                amortizacao(i) = nova_amortizacao
            Else
                Dim asd_n As Integer
                If form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                    asd_n = 2
                Else
                    asd_n = 1
                End If
                If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                        amortizacao(i) = saldodevedor_corrigido(n - asd_n) / PrazoInserido
                    Else
                        amortizacao(i) = saldodevedor(n - asd_n) / PrazoInserido
                    End If
                Else
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                        amortizacao(i) = (saldodevedor_corrigido(n - asd_n) - IntermValorInserido) / PrazoInserido
                    Else
                        amortizacao(i) = (saldodevedor(n - asd_n) - IntermValorInserido) / PrazoInserido
                    End If
                End If
            End If
            If form_ef_sistemas.rdo_sem_residuo.Checked = False Then
                amortizacao(i) = PagamentoInserido
            End If
        ElseIf form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
            If i = 1 Then
                amortizacao(i) = prestacao(i) * ((1 - EqTaxaCalculada) ^ (TempoTotalInserido - 1))
            ElseIf i > n Then
                amortizacao(i) = amortizacao(n) / ((1 - EqTaxaCalculada) ^ (k - 1))
            End If
            k += 1
        End If
        Return "Cálculo Amortização"
    End Function

    Private Function Intermediaria()
        If form_ef_sistemas.rdo_sistema_sac.Checked = True _
        Or cdc_asd = "SAC" Then
            If IntermPeriodoInserido = i Then
                amortizacao(i) = amortizacao(i) + IntermValorInserido
            End If
        ElseIf form_ef_sistemas.rdo_sistema_frances.Checked = True _
        Or form_ef_sistemas.rdo_sistema_price.Checked = True _
        Or form_ef_sistemas.rdo_sistema_sam.Checked = True Then
            If IntermPeriodoInserido = i Then
                prestacao(i) = prestacao(i) + IntermValorInserido
            End If
        ElseIf form_ef_sistemas.rdo_sistema_spv.Checked = True Then
            If IntermPeriodoInserido = i Then
                prestacao(i) = prestacao(i) + IntermValorInserido
                amortizacao(i) = prestacao(i) - juros(i)
            End If
        ElseIf form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
            If IntermPeriodoInserido = i Then
                amortizacao(i) = amortizacao(i) + IntermValorInserido
            End If
        End If
            Return "Intermediária"
    End Function

    Private Function carenciaPDC(ByVal sd As Double, ByVal sd_corrigido As Double) As Double
        If form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
            juros(0) = saldodevedor(0) * EqTaxaCalculada
            prestacao(0) = amortizacao(0) + juros(0)
        End If
        For i = 1 To TempoCarenciaInserido
            amortizacao(i) = 0
            juros(i) = saldodevedor(i - 1) * EqTaxaCalculada
            prestacao(i) = amortizacao(i) + juros(i)
            saldodevedor(i) = saldodevedor(0)
            If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                saldodevedor_corrigido(i) = saldodevedor(i)
                If i = TempoCarenciaInserido Then
                    saldodevedor_corrigido(i) = saldodevedor(i) * (1 + (item2(i - (TempoCarenciaInserido)) / 100))
                End If
            End If
            totalamort = totalamort + amortizacao(i)
            totaljuros = totaljuros + juros(i)
            totalprest = totalprest + prestacao(i)
            If form_ef_sistemas.rdo_nao_fora_prazo.Checked = False Then
                Me.fora_do_prazo()
            End If
        Next
        Me.CalculoNovaAmortizacao()
        Me.CalculoNovaPrestacao()
        If form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
            amortizacao(i) = nova_prestacao * ((1 - EqTaxaCalculada) ^ (PrazoInserido - 1))
        End If
        n = TempoCarenciaInserido + 1
    End Function

    Private Function carenciaCDCPPA(ByVal sd As Double, ByVal sd_corrigido As Double) As Double
        Dim juroscalc As Double, jurosacum As Double
        For i = 1 To TempoCarenciaInserido
            If i < TempoCarenciaInserido Then
                amortizacao(i) = 0
                juros(i) = 0
                prestacao(i) = 0
                saldodevedor(i) = saldodevedor(i - 1) + (saldodevedor(i - 1) * EqTaxaCalculada)
                If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                    saldodevedor_corrigido(i) = saldodevedor(i)
                End If
                juroscalc = saldodevedor(i - 1) * EqTaxaCalculada
                jurosacum = jurosacum + juroscalc
            ElseIf i = TempoCarenciaInserido Then
                amortizacao(i) = 0
                juroscalc = saldodevedor(i - 1) * EqTaxaCalculada
                jurosacum = jurosacum + juroscalc
                juros(i) = jurosacum
                If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                    saldodevedor(i) = saldodevedor_corrigido(i - 1) - amortizacao(i)
                    saldodevedor_corrigido(i) = saldodevedor(i) * (1 + (item2(i - TempoCarenciaInserido) / 100))
                Else
                    saldodevedor(i) = saldodevedor(i - 1) - amortizacao(i)
                End If
                Me.CalculoNovaPrestacao()
                If form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
                    juros(i - 1) = jurosacum
                    prestacao(i - 1) = juros(i - 1)
                    juros(i) = saldodevedor(i) * EqTaxaCalculada
                End If
                prestacao(i) = amortizacao(i) + juros(i)
                Me.CalculoNovaAmortizacao()
                totalamort = totalamort + amortizacao(i)
                totaljuros = totaljuros + juros(i)
                totalprest = totalprest + prestacao(i)
            End If
            If form_ef_sistemas.rdo_nao_fora_prazo.Checked = False Then
                Me.fora_do_prazo()
            End If
        Next
        n = TempoCarenciaInserido + 1
        Return n
    End Function

    Private Function carenciaCDCASD(ByVal sd As Double, ByVal sd_corrigido As Double) As Double
        k = 1
        p = 1
        For i = 1 To TempoCarenciaInserido + 1
            If i <= TempoCarenciaInserido Then
                amortizacao(i) = 0
                juros(i) = 0
                prestacao(i) = 0
                saldodevedor(i) = saldodevedor(i - 1) + (saldodevedor(i - 1) * EqTaxaCalculada)
                If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                    saldodevedor_corrigido(i) = saldodevedor(i)
                    If i = TempoCarenciaInserido Then
                        saldodevedor_corrigido(i) = saldodevedor(i) * (1 + (item2(i - (TempoCarenciaInserido)) / 100))
                        If form_ef_sistemas.rdo_sistema_sac.Checked = True Then
                            Me.CalculoNovaAmortizacao()
                            prestacao(i) = amortizacao(i)
                        End If
                    End If
                End If
            ElseIf i = TempoCarenciaInserido + 1 Then
                juros(i) = 0
                Me.CalculoNovaAmortizacao()
                Me.CalculoNovaPrestacao()
                If form_ef_sistemas.rdo_sem_residuo.Checked = False Then
                    prestacao(i) = PagamentoInserido
                Else
                    If form_ef_sistemas.rdo_sistema_frances.Checked = True _
                    Or form_ef_sistemas.rdo_sistema_price.Checked = True _
                    Or cdc_asd = "Price" Then
                        prestacao(i) = nova_prestacao
                        prestacao_price(i) = nova_prestacao
                        If form_ef_sistemas.rdo_nao_intermediaria.Checked = False Then
                            Me.Intermediaria()
                        End If
                        amortizacao(i) = prestacao(i) - juros(i)
                    ElseIf form_ef_sistemas.rdo_sistema_sac.Checked = True _
                    Or cdc_asd = "SAC" Then
                        amortizacao(i) = nova_amortizacao
                        prestacao(i) = amortizacao(i)
                        prestacao_sac(i) = amortizacao(i)
                    ElseIf form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
                        Me.CalculoNovaAmortizacao()
                        prestacao(i) = nova_prestacao
                    ElseIf form_ef_sistemas.rdo_sistema_sam.Checked = True _
                    And cdc_asd = "SAM" Then
                        prestacao(i) = prestacao_media(i)
                        amortizacao(i) = prestacao(i) - juros(i)
                    ElseIf form_ef_sistemas.rdo_sistema_spv.Checked = True Then
                        amortizacao(i) = amortizacao_spv(i - (TempoCarenciaInserido))
                        prestacao(i) = amortizacao(i) + juros(i)
                    End If
                End If
                If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                    saldodevedor(i) = (saldodevedor_corrigido(i - 1) + (saldodevedor_corrigido(i - 1) * EqTaxaCalculada)) - amortizacao(i)
                    saldodevedor_corrigido(i) = saldodevedor(i) * (1 + (item2(i - TempoCarenciaInserido) / 100))
                Else
                    saldodevedor(i) = (saldodevedor(i - 1) + (saldodevedor(i - 1) * EqTaxaCalculada)) - amortizacao(i)
                End If
                If form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
                    Me.CalculoJuros()
                    'prestacao(i) = amortizacao(i) + juros(i)
                End If
                totalamort = totalamort + amortizacao(i)
                totaljuros = totaljuros + juros(i)
                totalprest = totalprest + prestacao(i)
            End If
            If form_ef_sistemas.rdo_nao_fora_prazo.Checked = False Then
                Me.fora_do_prazo()
            End If
        Next
        n = TempoCarenciaInserido + 2
        Return n
    End Function

    Private Function CalculoNovaAmortizacao()
        If form_ef_sistemas.rdo_sistema_sac.Checked = True _
        Or form_ef_sistemas.rdo_sistema_sam.Checked = True Then
            If form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                        nova_amortizacao = (saldodevedor(i - 1) + (saldodevedor(i - 1) * EqTaxaCalculada)) / PrazoInserido
                    Else
                        nova_amortizacao = (saldodevedor_corrigido(i - 1) + (saldodevedor_corrigido(i - 1) * EqTaxaCalculada)) / PrazoInserido
                    End If
                Else
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                        nova_amortizacao = ((saldodevedor_corrigido(i - 1) + (saldodevedor_corrigido(i - 1) * EqTaxaCalculada)) - IntermValorInserido) / PrazoInserido
                    Else
                        nova_amortizacao = ((saldodevedor(i - 1) + (saldodevedor(i - 1) * EqTaxaCalculada)) - IntermValorInserido) / PrazoInserido
                    End If
                End If
            Else
                If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                        nova_amortizacao = saldodevedor(i - 1) / PrazoInserido
                    Else
                        nova_amortizacao = saldodevedor_corrigido(i - 1) / PrazoInserido
                    End If
                Else
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                        nova_amortizacao = (saldodevedor_corrigido(i - 1) - IntermValorInserido) / PrazoInserido
                    Else
                        nova_amortizacao = (saldodevedor(i - 1) - IntermValorInserido) / PrazoInserido
                    End If
                End If
            End If
        ElseIf form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
            If form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                amortizacao(i) = nova_prestacao * ((1 - EqTaxaCalculada) ^ (PrazoInserido - 1))
                amortizacao(i + 1) = amortizacao(i) / (1 - EqTaxaCalculada)
            Else
                amortizacao(i + 1) = nova_prestacao * ((1 - EqTaxaCalculada) ^ (PrazoInserido - 1))
            End If
        End If
        Return "Nova Amortização"
    End Function

    Private Function CalculoNovaPrestacao()
        If form_ef_sistemas.rdo_sistema_frances.Checked = True _
        Or form_ef_sistemas.rdo_sistema_price.Checked = True _
        Or cdc_asd = "Price" Then
            If form_ef_sistemas.rdo_juros_cdc_ppa.Checked = True Then
                If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                        nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, saldodevedor_corrigido(i))
                    Else
                        nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, saldodevedor(i))
                    End If
                Else
                    novo_vp = IntermValorInserido / _
            ((1 + EqTaxaCalculada) ^ (IntermPeriodoInserido - TempoCarenciaInserido))
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                        novo_vp2 = saldodevedor_corrigido(i) - novo_vp
                    Else
                        novo_vp2 = saldodevedor(i) - novo_vp
                    End If
                    nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, novo_vp2)
                End If
            ElseIf form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                        nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, saldodevedor_corrigido(i - 1))
                    Else
                        nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, saldodevedor(i - 1))
                    End If
                Else
                    novo_vp = IntermValorInserido / _
            ((1 + EqTaxaCalculada) ^ (IntermPeriodoInserido - TempoCarenciaInserido))
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
                        novo_vp2 = saldodevedor_corrigido(i - 1) - novo_vp
                    Else
                        novo_vp2 = saldodevedor(i - 1) - novo_vp
                    End If
                    nova_prestacao = -1 * Pmt(EqTaxaCalculada, PrazoInserido, novo_vp2)
                End If
            End If
        ElseIf form_ef_sistemas.rdo_sistema_alemao.Checked = True Then
            If form_ef_sistemas.rdo_juros_cdc_asd.Checked = True Then
                If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                        nova_prestacao = ((saldodevedor(i - 1) + (saldodevedor(i - 1) * EqTaxaCalculada)) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
                    Else
                        nova_prestacao = ((saldodevedor_corrigido(i - 1) + (saldodevedor_corrigido(i - 1) * EqTaxaCalculada)) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
                    End If
                Else
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                        nova_prestacao = (((saldodevedor(i - 1) + (saldodevedor(i - 1) * EqTaxaCalculada)) - IntermValorInserido) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
                    Else
                        nova_prestacao = (((saldodevedor_corrigido(i - 1) + (saldodevedor_corrigido(i - 1) * EqTaxaCalculada)) - IntermValorInserido) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
                    End If
                End If
            Else
                If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                        nova_prestacao = (saldodevedor(i - 1) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
                    Else
                        nova_prestacao = (saldodevedor_corrigido(i - 1) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
                    End If
                Else
                    If form_ef_sistemas.rdo_pos_fixado_nao.Checked = True Then
                        nova_prestacao = ((saldodevedor(i - 1) - IntermValorInserido) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
                    Else
                        nova_prestacao = ((saldodevedor_corrigido(i - 1) - IntermValorInserido) * EqTaxaCalculada) / (1 - ((1 - EqTaxaCalculada) ^ PrazoInserido))
                    End If
                End If
            End If
            End If
        Return "Nova Prestação"
    End Function

    Private Function fora_do_prazo()
        If i = periodos_fora_prazo(i) Then
            For y = i To TempoTotalInserido
                If periodos_fora_prazo(y) = y Then
                    z += 1
                Else
                    If periodos_fora_prazo(y - 1) = y - 1 Then
                        Exit For
                    End If
                End If
            Next
            prestacao2 = prestacao2 + (prestacao(i) * ((1 + EqTaxaCalculada) ^ z))
            prestacao(i) = 0
            z = 0
        ElseIf i <> periodos_fora_prazo(i) And periodos_fora_prazo(i - 1) = i - 1 Then
            prestacao(i) = prestacao2 + prestacao(i)
            prestacao2 = 0
        End If
        Return "Fora do Prazo"
    End Function

    Private Function CalculoSaldoDevedor()
        If form_ef_sistemas.rdo_pos_fixado_nao.Checked = False Then
            If form_ef_sistemas.rdo_sem_residuo.Checked = False Then
                saldodevedor(i) = saldodevedor_corrigido(i - 1) - amortizacao(i)
            Else
                If form_ef_sistemas.rdo_sistema_sac.Checked = True _
                Or cdc_asd = "SAC" Then
                    If form_ef_sistemas.rdo_nao_intermediaria.Checked = True Then
                        saldodevedor(i) = saldodevedor_corrigido(i - 1) * (1 - (1 / (PrazoInserido - p)))
                        p += 1
                    Else
                        saldodevedor(i) = saldodevedor_corrigido(i - 1) - amortizacao(i)
                    End If
                Else
                    saldodevedor(i) = saldodevedor_corrigido(i - 1) - amortizacao(i)
                End If
                End If
            saldodevedor_corrigido(i) = saldodevedor(i) * (1 + (item2(i - TempoCarenciaInserido) / 100))
        Else
            saldodevedor(i) = saldodevedor(i - 1) - amortizacao(i)
        End If
        Return "PosFixado"
    End Function

    Private Function MostrarResultado()
        If form_ef_sistemas.rdo_tabela_1.Checked = True Then
            For i = 0 To TempoTotalInserido + 1
                If i = TempoTotalInserido + 1 Then
                    item = form_ef_sistemas.lista_emprestimos.Items.Add("Total")
                    item.Text = "Total"
                    item.SubItems.Add(Decimal.Round(totalamort, 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(totaljuros, 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(totalprest, 2, MidpointRounding.ToEven))
                    item.SubItems.Add(0)
                    item.SubItems.Add(0)
                Else
                    item = form_ef_sistemas.lista_emprestimos.Items.Add(i)
                    item.Text = i
                    item.SubItems.Add(Decimal.Round(amortizacao(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(juros(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(prestacao(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(saldodevedor(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(saldodevedor_corrigido(i), 2, MidpointRounding.ToEven))
                End If
            Next
        ElseIf form_ef_sistemas.rdo_tabela_2.Checked = True Then
            For i = 0 To TempoTotalInserido + 1
                If i = TempoTotalInserido + 1 Then
                    item = form_ef_sistemas.lista_emprestimos_2.Items.Add("Total")
                    item.Text = "Total"
                    item.SubItems.Add(Decimal.Round(totalamort, 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(totaljuros, 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(totalprest, 2, MidpointRounding.ToEven))
                    item.SubItems.Add(0)
                    item.SubItems.Add(0)
                Else
                    item = form_ef_sistemas.lista_emprestimos_2.Items.Add(i)
                    item.Text = i
                    item.SubItems.Add(Decimal.Round(amortizacao(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(juros(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(prestacao(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(saldodevedor(i), 2, MidpointRounding.ToEven))
                    item.SubItems.Add(Decimal.Round(saldodevedor_corrigido(i), 2, MidpointRounding.ToEven))
                End If
            Next
        End If
        Return "Resultado"
    End Function

End Class
