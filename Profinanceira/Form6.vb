Public Class form_adicionar_periodos

    Private Sub btn_adicionar_periodo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_periodo_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_adicionar_periodo_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_periodo_ok.Click
        Dim item As ListViewItem, periodos As Double
        periodos = form_adicionar_periodos_principal.caixatexto_tempo_periodos.Text
        Select Case form_adicionar_periodos_principal.caixacombo_le_add_periodos.Text
            Case "Sistema Francês"
                If caixatexto_adicionar_n_periodos.Text > periodos Then
                    MsgBox("Não é necessário adicionar mais períodos", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_frances.Items.Add(caixatexto_adicionar_periodos.Text)
                    item.Text = caixatexto_adicionar_periodos.Text
                    caixatexto_adicionar_n_periodos.Text = caixatexto_adicionar_n_periodos.Text + 1
                End If
            Case "Sistema PRICE"
                If caixatexto_adicionar_n_periodos.Text > periodos Then
                    MsgBox("Não é necessário adicionar mais períodos", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_price.Items.Add(caixatexto_adicionar_periodos.Text)
                    item.Text = caixatexto_adicionar_periodos.Text
                    caixatexto_adicionar_n_periodos.Text = caixatexto_adicionar_n_periodos.Text + 1
                End If
            Case "Sistema Alemão"
                If caixatexto_adicionar_n_periodos.Text > periodos Then
                    MsgBox("Não é necessário adicionar mais períodos", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_alemao.Items.Add(caixatexto_adicionar_periodos.Text)
                    item.Text = caixatexto_adicionar_periodos.Text
                    caixatexto_adicionar_n_periodos.Text = caixatexto_adicionar_n_periodos.Text + 1
                End If
            Case "Sistema de Amortização Misto"
                If caixatexto_adicionar_n_periodos.Text > periodos Then
                    MsgBox("Não é necessário adicionar mais períodos", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_sam.Items.Add(caixatexto_adicionar_periodos.Text)
                    item.Text = caixatexto_adicionar_periodos.Text
                    caixatexto_adicionar_n_periodos.Text = caixatexto_adicionar_n_periodos.Text + 1
                End If
            Case "Sistema de Pagamentos Variáveis"
                If caixatexto_adicionar_n_periodos.Text > periodos Then
                    MsgBox("Não é necessário adicionar mais períodos", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_spv.Items.Add(caixatexto_adicionar_periodos.Text)
                    item.Text = caixatexto_adicionar_periodos.Text
                    caixatexto_adicionar_n_periodos.Text = caixatexto_adicionar_n_periodos.Text + 1
                End If
        End Select
    End Sub

    Private Sub caixatexto_adicionar_periodos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_adicionar_periodos.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub form_adicionar_periodos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case form_adicionar_periodos_principal.caixacombo_le_add_periodos.Text
            Case "Sistema Francês"
                If form_ef_sistemas.lista_emprestimos_periodos_frances.Items.Count >= 0 Then
                    caixatexto_adicionar_n_periodos.Text = form_ef_sistemas.lista_emprestimos_periodos_frances.Items.Count
                Else
                    caixatexto_adicionar_n_periodos.Text = 0
                End If
            Case "Sistema PRICE"
                If form_ef_sistemas.lista_emprestimos_periodos_price.Items.Count >= 0 Then
                    caixatexto_adicionar_n_periodos.Text = form_ef_sistemas.lista_emprestimos_periodos_price.Items.Count
                Else
                    caixatexto_adicionar_n_periodos.Text = 0
                End If
            Case "Sistema Alemão"
                If form_ef_sistemas.lista_emprestimos_periodos_alemao.Items.Count >= 0 Then
                    caixatexto_adicionar_n_periodos.Text = form_ef_sistemas.lista_emprestimos_periodos_alemao.Items.Count
                Else
                    caixatexto_adicionar_n_periodos.Text = 0
                End If
            Case "Sistema de Amortização Misto"
                If form_ef_sistemas.lista_emprestimos_periodos_sam.Items.Count >= 0 Then
                    caixatexto_adicionar_n_periodos.Text = form_ef_sistemas.lista_emprestimos_periodos_sam.Items.Count
                Else
                    caixatexto_adicionar_n_periodos.Text = 0
                End If
            Case "Sistema de Pagamentos Variáveis"
                If form_ef_sistemas.lista_emprestimos_periodos_spv.Items.Count >= 0 Then
                    caixatexto_adicionar_n_periodos.Text = form_ef_sistemas.lista_emprestimos_periodos_spv.Items.Count
                Else
                    caixatexto_adicionar_n_periodos.Text = 0
                End If
        End Select
    End Sub
End Class