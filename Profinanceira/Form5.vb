Public Class form_inserir_periodos

    Private Sub form_inserir_periodos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case form_adicionar_periodos_principal.caixacombo_le_add_periodos.Text
            Case "Sistema Francês"
                If form_ef_sistemas.Coluna_periodos_frances.Text = caixatexto_n_periodos.Text Then
                    caixatexto_periodos.Text = form_ef_sistemas.Coluna_indices_frances.Text
                End If
            Case "Sistema PRICE"
                If form_ef_sistemas.Coluna_periodos_price.Text = caixatexto_n_periodos.Text Then
                    caixatexto_periodos.Text = form_ef_sistemas.Coluna_indices_price.Text
                End If
            Case "Sistema Alemão"
                If form_ef_sistemas.Coluna_periodos_alemao.Text = caixatexto_n_periodos.Text Then
                    caixatexto_periodos.Text = form_ef_sistemas.Coluna_indices_alemao.Text
                End If
            Case "Sistema de Amortização Misto"
                If form_ef_sistemas.Coluna_periodos_sam.Text = caixatexto_n_periodos.Text Then
                    caixatexto_periodos.Text = form_ef_sistemas.Coluna_indices_sam.Text
                End If
            Case "Sistema de Pagamentos Variáveis"
                If form_ef_sistemas.Coluna_periodos_spv.Text = caixatexto_n_periodos.Text Then
                    caixatexto_periodos.Text = form_ef_sistemas.Coluna_indices_spv.Text
                End If
        End Select
    End Sub

    Private Sub btn_mudar_periodo_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mudar_periodo_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_mudar_periodo_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mudar_periodo_ok.Click
        Dim item As ListViewItem
        Dim n As Integer
        n = caixatexto_n_periodos.Text
        Select Case form_adicionar_periodos_principal.caixacombo_le_add_periodos.Text
            Case "Sistema Francês"
                If (form_ef_sistemas.lista_emprestimos_periodos_frances.Items.Count - 1) < caixatexto_n_periodos.Text Then
                    MsgBox("Não é possível inserir este período", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_frances.Items.Insert(n, n)
                    item.Text = caixatexto_periodos.Text
                End If
            Case "Sistema PRICE"
                If (form_ef_sistemas.lista_emprestimos_periodos_price.Items.Count - 1) < caixatexto_n_periodos.Text Then
                    MsgBox("Não é possível inserir este período", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_price.Items.Insert(n, n)
                    item.Text = caixatexto_periodos.Text
                End If
            Case "Sistema Alemão"
                If (form_ef_sistemas.lista_emprestimos_periodos_alemao.Items.Count - 1) < caixatexto_n_periodos.Text Then
                    MsgBox("Não é possível inserir este período", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_alemao.Items.Insert(n, n)
                    item.Text = caixatexto_periodos.Text
                End If
            Case "Sistema de Amortização Misto"
                If (form_ef_sistemas.lista_emprestimos_periodos_sam.Items.Count - 1) < caixatexto_n_periodos.Text Then
                    MsgBox("Não é possível inserir este período", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_sam.Items.Insert(n, n)
                    item.Text = caixatexto_periodos.Text
                End If
            Case "Sistema de Pagamentos Variáveis"
                If (form_ef_sistemas.lista_emprestimos_periodos_spv.Items.Count - 1) < caixatexto_n_periodos.Text Then
                    MsgBox("Não é possível inserir este período", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    item = form_ef_sistemas.lista_emprestimos_periodos_spv.Items.Insert(n, n)
                    item.Text = caixatexto_periodos.Text
                End If
        End Select
    End Sub

    Private Sub caixatexto_periodos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_periodos.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class