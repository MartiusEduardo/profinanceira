Public Class form_adicionar_periodos_principal

    Private Sub btn_remover_periodos_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_remover_periodos_price.Click
        Select Case caixacombo_le_add_periodos.Text
            Case "Sistema Franc�s"
                If caixatexto_remover_periodos_price.Text = "" Then
                    MsgBox("� preciso digitar o n para remov�-lo.", MsgBoxStyle.Exclamation, "ProFinanceira")
                ElseIf (form_ef_sistemas.lista_emprestimos_periodos_frances.Items.Count - 1) < caixatexto_remover_periodos_price.Text Then
                    MsgBox("Este �tem n�o existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_periodos_frances.Items.RemoveAt(caixatexto_remover_periodos_price.Text)
                End If
            Case "Sistema PRICE"
                If caixatexto_remover_periodos_price.Text = "" Then
                    MsgBox("� preciso digitar o n para remov�-lo.", MsgBoxStyle.Critical, "ProFinanceira")
                ElseIf (form_ef_sistemas.lista_emprestimos_periodos_price.Items.Count - 1) < caixatexto_remover_periodos_price.Text Then
                    MsgBox("Este �tem n�o existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_periodos_price.Items.RemoveAt(caixatexto_remover_periodos_price.Text)
                End If
            Case "Sistema Alem�o"
                If caixatexto_remover_periodos_price.Text = "" Then
                    MsgBox("� preciso digitar o n para remov�-lo.", MsgBoxStyle.Critical, "ProFinanceira")
                ElseIf (form_ef_sistemas.lista_emprestimos_periodos_alemao.Items.Count - 1) < caixatexto_remover_periodos_price.Text Then
                    MsgBox("Este �tem n�o existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_periodos_alemao.Items.RemoveAt(caixatexto_remover_periodos_price.Text)
                End If
            Case "Sistema de Amortiza��o Misto"
                If caixatexto_remover_periodos_price.Text = "" Then
                    MsgBox("� preciso digitar o n para remov�-lo.", MsgBoxStyle.Critical, "ProFinanceira")
                ElseIf (form_ef_sistemas.lista_emprestimos_periodos_sam.Items.Count - 1) < caixatexto_remover_periodos_price.Text Then
                    MsgBox("Este �tem n�o existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_periodos_sam.Items.RemoveAt(caixatexto_remover_periodos_price.Text)
                End If
            Case "Sistema de Pagamentos Vari�veis"
                If caixatexto_remover_periodos_price.Text = "" Then
                    MsgBox("� preciso digitar o n para remov�-lo.", MsgBoxStyle.Critical, "ProFinanceira")
                ElseIf (form_ef_sistemas.lista_emprestimos_periodos_spv.Items.Count - 1) < caixatexto_remover_periodos_price.Text Then
                    MsgBox("Este �tem n�o existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_periodos_spv.Items.RemoveAt(caixatexto_remover_periodos_price.Text)
                End If
        End Select
    End Sub

    Private Sub btn_inserir_periodos_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_inserir_periodos_price.Click
        If caixatexto_inserir_periodos_price.Text <> "" Then
            form_inserir_periodos.caixatexto_n_periodos.Text = caixatexto_inserir_periodos_price.Text
            form_inserir_periodos.Show()
        Else
            MsgBox("Precisa dizer qual n ir� inserir.", MsgBoxStyle.Exclamation, "ProFinanceira")
        End If
    End Sub

    Private Sub btn_adicionar_periodos_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_periodos_price.Click
        If caixatexto_tempo_periodos.Text = 0 Then
            MsgBox("O campo est� com n�mero incorreto", MsgBoxStyle.Exclamation, "ProFinanceira")
        Else
            form_adicionar_periodos.Show()
        End If
    End Sub

    Private Sub caixatexto_tempo_periodos_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tempo_periodos.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_remover_periodos_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_remover_periodos_price.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_inserir_periodos_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_inserir_periodos_price.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixacombo_le_add_periodos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_le_add_periodos.SelectedIndexChanged
        Select Case caixacombo_le_add_periodos.Text
            Case "Sistema Franc�s"
                caixatexto_tempo_periodos.Text = form_ef_sistemas.caixatexto_total_n_frances.Text
            Case "Sistema PRICE"
                caixatexto_tempo_periodos.Text = form_ef_sistemas.caixatexto_total_n_price.Text
            Case "Sistema Alem�o"
                caixatexto_tempo_periodos.Text = form_ef_sistemas.caixatexto_total_n_alemao.Text
            Case "Sistema de Amortiza��o Misto"
                caixatexto_tempo_periodos.Text = form_ef_sistemas.caixatexto_tempo_sam.Text
            Case "Sistema de Pagamentos Vari�veis"
                caixatexto_tempo_periodos.Text = form_ef_sistemas.caixatexto_tempo_spv.Text
        End Select
    End Sub

    Private Sub caixatexto_tempo_periodos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_tempo_periodos.TextChanged
        If caixatexto_tempo_periodos.Text = "" Then
            btn_adicionar_periodos_price.Enabled = False
        Else
            btn_adicionar_periodos_price.Enabled = True
        End If
    End Sub
End Class