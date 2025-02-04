Imports System.Windows.Forms
Public Class form_descontos_titulos

    Private Sub caixatexto_vt_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vt_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_taxa_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tempo_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tempo_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_desconto_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_desconto_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vd_sem_encargos_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vd_sem_encargos_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vd_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vd_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_aparente_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_aparente_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_real_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_real_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_inflacao_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_inflacao_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_calcular_dt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_dt.Click
        'COMEÇA DESCONTO DE TÍTULOS
        If rdo_dt_dt.Checked = True Then
            'VALOR DO TÍTULO
            If rdo_vt_dt.Checked = True Then
                If caixatexto_desconto_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_vt_dt.Text = caixatexto_desconto_dt.Text + caixatexto_vd_dt.Text
                ElseIf caixatexto_desconto_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" _
                And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_vt_dt.Text = caixatexto_desconto_dt.Text / ((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text)
                ElseIf caixatexto_vd_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_vt_dt.Text = caixatexto_vd_dt.Text / (1 - ((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text))
                Else
                    MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'TAXA DE DESCONTO
            ElseIf rdo_taxa_dt.Checked = True Then
                If caixatexto_desconto_dt.Text <> "" And caixatexto_vt_dt.Text <> "" _
                And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_taxa_dt.Text = (caixatexto_desconto_dt.Text / (caixatexto_vt_dt.Text * caixatexto_tempo_dt.Text)) * 100
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_vd_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_taxa_dt.Text = ((caixatexto_vd_dt.Text - caixatexto_vt_dt.Text) / (-1 * (caixatexto_vt_dt.Text * caixatexto_tempo_dt.Text))) * 100
                Else
                    MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'PARCELAS(N)
            ElseIf rdo_tempo_dt.Checked = True Then
                If caixatexto_desconto_dt.Text <> "" And caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" Then
                    caixatexto_tempo_dt.Text = caixatexto_desconto_dt.Text / (caixatexto_vt_dt.Text * (caixatexto_taxa_dt.Text / 100))
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_tempo_dt.Text = (caixatexto_vd_dt.Text - caixatexto_vt_dt.Text) / (-1 * caixatexto_vt_dt.Text * (caixatexto_taxa_dt.Text / 100))
                Else
                    MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'DESCONTO
            ElseIf rdo_desconto_dt.Checked = True Then
                If caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" And caixatexto_taxa_administracao_dt.Text <> "" Then
                    caixatexto_desconto_dt.Text = caixatexto_vt_dt.Text * ((caixatexto_taxa_dt.Text * caixatexto_tempo_dt.Text) + (caixatexto_taxa_administracao_dt.Text / 100))
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_desconto_dt.Text = caixatexto_vt_dt.Text * (caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_desconto_dt.Text = caixatexto_vt_dt.Text - caixatexto_vd_dt.Text
                Else
                    MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'VALOR DESCONTADO
            ElseIf rdo_vd_dt.Checked = True Then
                If caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" And caixatexto_taxa_administracao_dt.Text <> "" Then
                    caixatexto_vd_dt.Text = caixatexto_vt_dt.Text * (1 - (((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text) + (caixatexto_taxa_administracao_dt.Text / 100)))
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_desconto_dt.Text <> "" Then
                    caixatexto_vd_dt.Text = caixatexto_vt_dt.Text - caixatexto_desconto_dt.Text
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_vd_dt.Text = caixatexto_vt_dt.Text * (1 - ((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text))
                ElseIf caixatexto_vd_sem_encargos_dt.Text <> "" And caixatexto_iof_dt.Text <> "" _
                And caixatexto_tarifa_dt.Text <> "" And caixatexto_tac_dt.Text <> "" And caixatexto_outros_encargos_dt.Text <> "" Then
                    caixatexto_vd_dt.Text = caixatexto_vd_sem_encargos_dt.Text + (caixatexto_iof_dt.Text + caixatexto_tarifa_dt.Text + caixatexto_tac_dt.Text + caixatexto_outros_encargos_dt.Text)
                Else
                    MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'VALOR DESCONTADO SEM ENCARGOS
            ElseIf rdo_sem_encargos_dt.Checked = True Then
                If caixatexto_vd_dt.Text <> "" And caixatexto_iof_dt.Text <> "" And caixatexto_tarifa_dt.Text <> "" _
                And caixatexto_tac_dt.Text <> "" And caixatexto_outros_encargos_dt.Text <> "" Then
                    Dim num1 As Double = caixatexto_iof_dt.Text
                    caixatexto_vd_sem_encargos_dt.Text = caixatexto_vd_dt.Text - (num1 + caixatexto_tarifa_dt.Text + caixatexto_tac_dt.Text + caixatexto_outros_encargos_dt.Text)
                Else
                    MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'CÁLCULO DO IOF
            ElseIf rdo_iof_dt.Checked = True Then
                If caixatexto_vd_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" And caixatexto_taxa_iof_dt.Text <> "" Then
                    caixatexto_iof_dt.Text = caixatexto_vd_dt.Text * (caixatexto_taxa_iof_dt.Text / 100) * caixatexto_tempo_dt.Text
                Else
                    MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'CUSTO EFETIVO DA OPERAÇÃO
            ElseIf rdo_custo_efetivo_dt.Checked = True Then
                If caixatexto_vt_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_custo_efetivo_dt.Text = ((caixatexto_vt_dt.Text - caixatexto_vd_dt.Text) / caixatexto_vd_dt.Text) * 100
                Else
                    MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
            End If
                'TERMINA DESCONTO DE TÍTULOS
                'COMEÇA TAXA
            ElseIf rdo_taxa_ari_dt.Checked = True Then
                'TAXA APARENTE
                If rdo_taxa_aparente_dt.Checked = True Then
                    If caixatexto_real_dt.Text <> "" And caixatexto_inflacao_dt.Text <> "" Then
                        caixatexto_aparente_dt.Text = (((1 + (caixatexto_real_dt.Text / 100)) * (1 + (caixatexto_inflacao_dt.Text / 100))) - 1) * 100
                    Else
                        MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                        Exit Sub
                    End If
                    'TAXA REAL
                ElseIf rdo_taxa_real_dt.Checked = True Then
                    If caixatexto_aparente_dt.Text <> "" And caixatexto_inflacao_dt.Text <> "" Then
                        caixatexto_real_dt.Text = (((1 + (caixatexto_aparente_dt.Text / 100)) / (1 + (caixatexto_inflacao_dt.Text / 100))) - 1) * 100
                    Else
                        MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                        Exit Sub
                    End If
                    'TAXA DE INFLAÇÃO
                ElseIf rdo_taxa_inflacao_dt.Checked = True Then
                    If caixatexto_real_dt.Text <> "" And caixatexto_aparente_dt.Text <> "" Then
                        caixatexto_inflacao_dt.Text = (((1 + (caixatexto_aparente_dt.Text / 100)) / (1 + (caixatexto_real_dt.Text / 100))) - 1) * 100
                    Else
                        MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                        Exit Sub
                End If
                'TAXA ACUMULADA
            ElseIf rdo_taxa_acumulada_dt.Checked = True Then
                If lista_rentabilidade_dt.Items.Count <> 0 Then
                    Dim item(0 To lista_rentabilidade_dt.Items.Count) As ListViewItem
                    Dim i As Integer, item2 As Double
                    For i = 0 To lista_rentabilidade_dt.Items.Count - 1
                        item(i) = lista_rentabilidade_dt.Items.Item(i)
                    Next
                    item2 = 1 + (item(0).Text / 100)
                    For i = 1 To lista_rentabilidade_dt.Items.Count - 1
                        item2 = item2 * (1 + (item(i).Text / 100))
                    Next
                    caixatexto_acumulada_dt.Text = (item2 - 1) * 100
                Else
                    MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                End If
            End If
    End Sub

    Private Sub caixatexto_iof_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_iof_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tarifa_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tarifa_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tac_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tac_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_outros_encargos_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_outros_encargos_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_taxa_iof_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_iof_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub rdo_dt_dt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_dt_dt.CheckedChanged
        If rdo_dt_dt.Checked = True Then
            RichTextBox_leitura_dt.Text = "Fórmulas para calcular o valor do título:" & vbNewLine & vbNewLine _
            & "1. Desconto + Valor Descontado" & vbNewLine _
            & "2. Desconto / (taxa * n)" & vbNewLine _
            & "3. Valor Descontado / (1 - (taxa * n))" & vbNewLine & vbNewLine _
                & "Fórmulas para calcular a taxa de desconto:" & vbNewLine & vbNewLine _
                & "1. Desconto / (Valor do Título * n)" & vbNewLine _
                & "2. (Valor Descontado - Valor do Título) / (-(Valor do Título * n))" & vbNewLine & vbNewLine _
                & "Fórmula para calcular o custo efetivo da operação:" & vbNewLine & vbNewLine _
                & "1. (Valor do Título - Valor Descontado) / Valor Descontado" & vbNewLine & vbNewLine _
                & "Fórmulas para calcular as parcelas:" & vbNewLine & vbNewLine _
                & "1. Desconto / (Valor do Título * taxa)" & vbNewLine _
                & "2. (Valor Descontado - Valor do Título) / (-Valor do Título * taxa)" & vbNewLine & vbNewLine _
                & "Fórmulas para calcular o desconto:" & vbNewLine & vbNewLine _
                & "1. Valor do Título * ((taxa * n) + taxa de administração)" & vbNewLine _
                & "2. Valor do Título * taxa * n" & vbNewLine _
                & "3. Valor do Título - Valor Descontado" & vbNewLine & vbNewLine _
                & "Fórmulas para calcular o valor descontado:" & vbNewLine & vbNewLine _
                & "1. Valor do Título * (1 - ((taxa * n) + taxa de administração))" & vbNewLine _
                & "2. Valor do Título - Desconto" & vbNewLine _
                & "3. Valor do Título * (1 - (taxa * n))" & vbNewLine _
                & "4. Valor Descontado sem encargos + (IOF + Tarifa + TAC + Outros encargos)" & vbNewLine & vbNewLine _
                & "Fórmula para calcular o valor descontado sem encargos:" & vbNewLine & vbNewLine _
                & "1. Valor Descontado - (IOF + Tarifa + TAC + Outros encargos)" & vbNewLine & vbNewLine _
                & "Fórmula para calcular o IOF:" & vbNewLine & vbNewLine _
                & "1. Valor Descontado * taxa do IOF * n"
        End If
    End Sub

    Private Sub rdo_taxa_ari_dt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_taxa_ari_dt.CheckedChanged
        If rdo_taxa_ari_dt.Checked = True Then
            RichTextBox_leitura_dt.Text = "Fórmula para calcular a taxa aprarente, real e de inflação:" & vbNewLine & vbNewLine _
            & "(1 + taxa aparente) = (1 + taxa real) * (1 + taxa de inflação)" & vbNewLine & vbNewLine _
            & "Fórmula para calcular a taxa acumulada:" & vbNewLine & vbNewLine _
            & "(1 + taxa acumulada) = (1 + taxa) * (1 + taxa) ... * (1 + taxa)" & vbNewLine & vbNewLine _
            & "Observação: A tabela de rentabilidade começa pelo número 0 (zero), então se houver 4 períodos será preciso inserir 3 como número de taxas."
        End If
    End Sub

    Private Sub caixatexto_taxa_administracao_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_administracao_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_adicionar_taxas_dt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_taxas_dt.Click
        Dim n As Integer
        n = InputBox("Quantos são as taxas?", "ProFinanceira")
        Dim item(0 To n + 1) As ListViewItem, i As Integer
        Dim valor As Double
        For i = 0 To n
            valor = InputBox("Qual é a rentabilidade do período" & " " & i & "?", "ProFinanceira")
            item(i) = lista_rentabilidade_dt.Items.Add(valor)
        Next i
    End Sub

    Private Sub btn_limpar_taxas_dt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpar_taxas_dt.Click
        lista_rentabilidade_dt.Items.Clear()
    End Sub
End Class