Imports System
Public Class form_sistema_price

    Private Sub btn_adicionar_indices_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_indices_price.Click
        If caixatexto_tempo_indices_price.Text = 0 Then
            MsgBox("O campo está com número incorreto", MsgBoxStyle.Exclamation, "ProFinanceira")
        Else
            form_adicionar_indices.Show()
        End If
    End Sub

    Private Sub btn_remover_indices_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_remover_indices_price.Click
        Select Case caixacombo_le_add_indices.Text
            Case "Sistema Francês"
                If (form_ef_sistemas.lista_emprestimos_indices_frances.Items.Count - 1) < caixatexto_remover_indices_price.Text Then
                    MsgBox("Este ítem não existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_indices_frances.Items.RemoveAt(caixatexto_remover_indices_price.Text)
                End If
            Case "Sistema PRICE"
                If (form_ef_sistemas.lista_emprestimos_indices_price.Items.Count - 1) < caixatexto_remover_indices_price.Text Then
                    MsgBox("Este ítem não existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_indices_price.Items.RemoveAt(caixatexto_remover_indices_price.Text)
                End If
            Case "Sistema Alemão"
                If (form_ef_sistemas.lista_emprestimos_indices_alemao.Items.Count - 1) < caixatexto_remover_indices_price.Text Then
                    MsgBox("Este ítem não existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_indices_alemao.Items.RemoveAt(caixatexto_remover_indices_price.Text)
                End If
            Case "Sistema de Amortização Misto"
                If (form_ef_sistemas.lista_emprestimos_indices_sam.Items.Count - 1) < caixatexto_remover_indices_price.Text Then
                    MsgBox("Este ítem não existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_indices_sam.Items.RemoveAt(caixatexto_remover_indices_price.Text)
                End If
            Case "Sistema de Pagamentos Variáveis"
                If (form_ef_sistemas.lista_emprestimos_indices_spv.Items.Count - 1) < caixatexto_remover_indices_price.Text Then
                    MsgBox("Este ítem não existe", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    form_ef_sistemas.lista_emprestimos_indices_spv.Items.RemoveAt(caixatexto_remover_indices_price.Text)
                End If
        End Select
    End Sub

    Private Sub btn_adicionar_um_indice_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_inserir_indices_price.Click
        If caixatexto_inserir_indices_price.Text <> "" Then
            form_inserir_indice.caixatexto_n_indice.Text = caixatexto_inserir_indices_price.Text
            form_inserir_indice.Show()
        Else
            MsgBox("Precisa dizer qual n irá inserir.", MsgBoxStyle.Exclamation, "ProFinanceira")
        End If
    End Sub

    Private Sub caixatexto_remover_indices_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_remover_indices_price.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_inserir_indices_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_inserir_indices_price.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixacombo_le_add_indices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_le_add_indices.SelectedIndexChanged
        Select Case caixacombo_le_add_indices.Text
            Case "Sistema Francês"
                caixatexto_tempo_indices_price.Text = form_ef_sistemas.caixatexto_total_n_frances.Text
            Case "Sistema PRICE"
                caixatexto_tempo_indices_price.Text = form_ef_sistemas.caixatexto_total_n_price.Text
            Case "Sistema Alemão"
                caixatexto_tempo_indices_price.Text = form_ef_sistemas.caixatexto_total_n_alemao.Text
            Case "Sistema de Amortização Misto"
                caixatexto_tempo_indices_price.Text = form_ef_sistemas.caixatexto_tempo_sam.Text
            Case "Sistema de Pagamentos Variáveis"
                caixatexto_tempo_indices_price.Text = form_ef_sistemas.caixatexto_tempo_spv.Text
        End Select
    End Sub

    Private Sub caixatexto_tempo_indices_price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_tempo_indices_price.TextChanged
        If caixatexto_tempo_indices_price.Text = "" Then
            btn_adicionar_indices_price.Enabled = False
        Else
            btn_adicionar_indices_price.Enabled = True
        End If
    End Sub
End Class