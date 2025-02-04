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
        'COME�A DESCONTO DE T�TULOS
        If rdo_dt_dt.Checked = True Then
            'VALOR DO T�TULO
            If rdo_vt_dt.Checked = True Then
                If caixatexto_desconto_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_vt_dt.Text = caixatexto_desconto_dt.Text + caixatexto_vd_dt.Text
                ElseIf caixatexto_desconto_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" _
                And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_vt_dt.Text = caixatexto_desconto_dt.Text / ((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text)
                ElseIf caixatexto_vd_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_vt_dt.Text = caixatexto_vd_dt.Text / (1 - ((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text))
                Else
                    MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
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
                    MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'PARCELAS(N)
            ElseIf rdo_tempo_dt.Checked = True Then
                If caixatexto_desconto_dt.Text <> "" And caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" Then
                    caixatexto_tempo_dt.Text = caixatexto_desconto_dt.Text / (caixatexto_vt_dt.Text * (caixatexto_taxa_dt.Text / 100))
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_tempo_dt.Text = (caixatexto_vd_dt.Text - caixatexto_vt_dt.Text) / (-1 * caixatexto_vt_dt.Text * (caixatexto_taxa_dt.Text / 100))
                Else
                    MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
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
                    MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
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
                    MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'VALOR DESCONTADO SEM ENCARGOS
            ElseIf rdo_sem_encargos_dt.Checked = True Then
                If caixatexto_vd_dt.Text <> "" And caixatexto_iof_dt.Text <> "" And caixatexto_tarifa_dt.Text <> "" _
                And caixatexto_tac_dt.Text <> "" And caixatexto_outros_encargos_dt.Text <> "" Then
                    Dim num1 As Double = caixatexto_iof_dt.Text
                    caixatexto_vd_sem_encargos_dt.Text = caixatexto_vd_dt.Text - (num1 + caixatexto_tarifa_dt.Text + caixatexto_tac_dt.Text + caixatexto_outros_encargos_dt.Text)
                Else
                    MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'C�LCULO DO IOF
            ElseIf rdo_iof_dt.Checked = True Then
                If caixatexto_vd_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" And caixatexto_taxa_iof_dt.Text <> "" Then
                    caixatexto_iof_dt.Text = caixatexto_vd_dt.Text * (caixatexto_taxa_iof_dt.Text / 100) * caixatexto_tempo_dt.Text
                Else
                    MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
                'CUSTO EFETIVO DA OPERA��O
            ElseIf rdo_custo_efetivo_dt.Checked = True Then
                If caixatexto_vt_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_custo_efetivo_dt.Text = ((caixatexto_vt_dt.Text - caixatexto_vd_dt.Text) / caixatexto_vd_dt.Text) * 100
                Else
                    MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                    Exit Sub
                End If
            End If
                'TERMINA DESCONTO DE T�TULOS
                'COME�A TAXA
            ElseIf rdo_taxa_ari_dt.Checked = True Then
                'TAXA APARENTE
                If rdo_taxa_aparente_dt.Checked = True Then
                    If caixatexto_real_dt.Text <> "" And caixatexto_inflacao_dt.Text <> "" Then
                        caixatexto_aparente_dt.Text = (((1 + (caixatexto_real_dt.Text / 100)) * (1 + (caixatexto_inflacao_dt.Text / 100))) - 1) * 100
                    Else
                        MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                        Exit Sub
                    End If
                    'TAXA REAL
                ElseIf rdo_taxa_real_dt.Checked = True Then
                    If caixatexto_aparente_dt.Text <> "" And caixatexto_inflacao_dt.Text <> "" Then
                        caixatexto_real_dt.Text = (((1 + (caixatexto_aparente_dt.Text / 100)) / (1 + (caixatexto_inflacao_dt.Text / 100))) - 1) * 100
                    Else
                        MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
                        Exit Sub
                    End If
                    'TAXA DE INFLA��O
                ElseIf rdo_taxa_inflacao_dt.Checked = True Then
                    If caixatexto_real_dt.Text <> "" And caixatexto_aparente_dt.Text <> "" Then
                        caixatexto_inflacao_dt.Text = (((1 + (caixatexto_aparente_dt.Text / 100)) / (1 + (caixatexto_real_dt.Text / 100))) - 1) * 100
                    Else
                        MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
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
                    MsgBox("H� valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
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
            RichTextBox_leitura_dt.Text = "F�rmulas para calcular o valor do t�tulo:" & vbNewLine & vbNewLine _
            & "1. Desconto + Valor Descontado" & vbNewLine _
            & "2. Desconto / (taxa * n)" & vbNewLine _
            & "3. Valor Descontado / (1 - (taxa * n))" & vbNewLine & vbNewLine _
                & "F�rmulas para calcular a taxa de desconto:" & vbNewLine & vbNewLine _
                & "1. Desconto / (Valor do T�tulo * n)" & vbNewLine _
                & "2. (Valor Descontado - Valor do T�tulo) / (-(Valor do T�tulo * n))" & vbNewLine & vbNewLine _
                & "F�rmula para calcular o custo efetivo da opera��o:" & vbNewLine & vbNewLine _
                & "1. (Valor do T�tulo - Valor Descontado) / Valor Descontado" & vbNewLine & vbNewLine _
                & "F�rmulas para calcular as parcelas:" & vbNewLine & vbNewLine _
                & "1. Desconto / (Valor do T�tulo * taxa)" & vbNewLine _
                & "2. (Valor Descontado - Valor do T�tulo) / (-Valor do T�tulo * taxa)" & vbNewLine & vbNewLine _
                & "F�rmulas para calcular o desconto:" & vbNewLine & vbNewLine _
                & "1. Valor do T�tulo * ((taxa * n) + taxa de administra��o)" & vbNewLine _
                & "2. Valor do T�tulo * taxa * n" & vbNewLine _
                & "3. Valor do T�tulo - Valor Descontado" & vbNewLine & vbNewLine _
                & "F�rmulas para calcular o valor descontado:" & vbNewLine & vbNewLine _
                & "1. Valor do T�tulo * (1 - ((taxa * n) + taxa de administra��o))" & vbNewLine _
                & "2. Valor do T�tulo - Desconto" & vbNewLine _
                & "3. Valor do T�tulo * (1 - (taxa * n))" & vbNewLine _
                & "4. Valor Descontado sem encargos + (IOF + Tarifa + TAC + Outros encargos)" & vbNewLine & vbNewLine _
                & "F�rmula para calcular o valor descontado sem encargos:" & vbNewLine & vbNewLine _
                & "1. Valor Descontado - (IOF + Tarifa + TAC + Outros encargos)" & vbNewLine & vbNewLine _
                & "F�rmula para calcular o IOF:" & vbNewLine & vbNewLine _
                & "1. Valor Descontado * taxa do IOF * n"
        End If
    End Sub

    Private Sub rdo_taxa_ari_dt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_taxa_ari_dt.CheckedChanged
        If rdo_taxa_ari_dt.Checked = True Then
            RichTextBox_leitura_dt.Text = "F�rmula para calcular a taxa aprarente, real e de infla��o:" & vbNewLine & vbNewLine _
            & "(1 + taxa aparente) = (1 + taxa real) * (1 + taxa de infla��o)" & vbNewLine & vbNewLine _
            & "F�rmula para calcular a taxa acumulada:" & vbNewLine & vbNewLine _
            & "(1 + taxa acumulada) = (1 + taxa) * (1 + taxa) ... * (1 + taxa)" & vbNewLine & vbNewLine _
            & "Observa��o: A tabela de rentabilidade come�a pelo n�mero 0 (zero), ent�o se houver 4 per�odos ser� preciso inserir 3 como n�mero de taxas."
        End If
    End Sub

    Private Sub caixatexto_taxa_administracao_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_administracao_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_adicionar_taxas_dt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_taxas_dt.Click
        Dim n As Integer
        n = InputBox("Quantos s�o as taxas?", "ProFinanceira")
        Dim item(0 To n + 1) As ListViewItem, i As Integer
        Dim valor As Double
        For i = 0 To n
            valor = InputBox("Qual � a rentabilidade do per�odo" & " " & i & "?", "ProFinanceira")
            item(i) = lista_rentabilidade_dt.Items.Add(valor)
        Next i
    End Sub

    Private Sub btn_limpar_taxas_dt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpar_taxas_dt.Click
        lista_rentabilidade_dt.Items.Clear()
    End Sub
End Class