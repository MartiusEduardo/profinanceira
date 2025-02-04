Public Class form_adicionar_indices

    Private Sub btn_adicionar_indices_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_indices_cancelar.Click
        On Error GoTo Err_adicionar_indices_cancelar_Click
        Me.Close()
Exit_adicionar_indices_cancelar_Click:
        Exit Sub

Err_adicionar_indices_cancelar_Click:
        MsgBox(Err.Description)
        Resume Exit_adicionar_indices_cancelar_Click
    End Sub

    Private Sub btn_adicionar_indices_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_indices_ok.Click
        On Error GoTo Err_adicionar_indices_ok_Click
        Dim subitem As ListViewItem.ListViewSubItem, n As Double, indices As Double
        n = caixatexto_adicionar_n_indices.Text
        indices = form_sistema_price.caixatexto_tempo_indices_price.Text
        Select Case form_sistema_price.caixacombo_le_add_indices.Text
            Case "Sistema Francês"
                If caixatexto_adicionar_n_indices.Text > indices Then
                    MsgBox("Não é necessário adicionar mais índices", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    subitem = form_ef_sistemas.lista_emprestimos_indices_frances.Items.Add(n).SubItems.Add(n)
                    subitem.Text = caixatexto_adicionar_indices.Text
                    caixatexto_adicionar_n_indices.Text = caixatexto_adicionar_n_indices.Text + 1
                End If
            Case "Sistema PRICE"
                If caixatexto_adicionar_n_indices.Text > indices Then
                    MsgBox("Não é necessário adicionar mais índices", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    subitem = form_ef_sistemas.lista_emprestimos_indices_price.Items.Add(n).SubItems.Add(n)
                    subitem.Text = caixatexto_adicionar_indices.Text
                    caixatexto_adicionar_n_indices.Text = caixatexto_adicionar_n_indices.Text + 1
                End If
            Case "Sistema Alemão"
                If caixatexto_adicionar_n_indices.Text > indices Then
                    MsgBox("Não é necessário adicionar mais índices", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    subitem = form_ef_sistemas.lista_emprestimos_indices_alemao.Items.Add(n).SubItems.Add(n)
                    subitem.Text = caixatexto_adicionar_indices.Text
                    caixatexto_adicionar_n_indices.Text = caixatexto_adicionar_n_indices.Text + 1
                End If
            Case "Sistema de Amortização Misto"
                If caixatexto_adicionar_n_indices.Text > indices Then
                    MsgBox("Não é necessário adicionar mais índices", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    subitem = form_ef_sistemas.lista_emprestimos_indices_sam.Items.Add(n).SubItems.Add(n)
                    subitem.Text = caixatexto_adicionar_indices.Text
                    caixatexto_adicionar_n_indices.Text = caixatexto_adicionar_n_indices.Text + 1
                End If
            Case "Sistema de Pagamentos Variáveis"
                If caixatexto_adicionar_n_indices.Text > indices Then
                    MsgBox("Não é necessário adicionar mais índices", MsgBoxStyle.Exclamation, "ProFinanceira")
                Else
                    subitem = form_ef_sistemas.lista_emprestimos_indices_spv.Items.Add(n).SubItems.Add(n)
                    subitem.Text = caixatexto_adicionar_indices.Text
                    caixatexto_adicionar_n_indices.Text = caixatexto_adicionar_n_indices.Text + 1
                End If
        End Select
Exit_adicionar_indices_ok_Click:
        Exit Sub

Err_adicionar_indices_ok_Click:
        MsgBox(Err.Description)
        Resume Exit_adicionar_indices_ok_Click
    End Sub

    Private Sub caixatexto_adicionar_indices_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_adicionar_indices.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub form_adicionar_indices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err_adicionar_indices_Click
        Select Case form_sistema_price.caixacombo_le_add_indices.Text
            Case "Sistema Francês"
                If form_ef_sistemas.lista_emprestimos_indices_frances.Items.Count >= 0 Then
                    caixatexto_adicionar_n_indices.Text = form_ef_sistemas.lista_emprestimos_indices_frances.Items.Count
                Else
                    caixatexto_adicionar_n_indices.Text = 0
                End If
            Case "Sistema PRICE"
                If form_ef_sistemas.lista_emprestimos_indices_price.Items.Count >= 0 Then
                    caixatexto_adicionar_n_indices.Text = form_ef_sistemas.lista_emprestimos_indices_price.Items.Count
                Else
                    caixatexto_adicionar_n_indices.Text = 0
                End If
            Case "Sistema Alemão"
                If form_ef_sistemas.lista_emprestimos_indices_alemao.Items.Count >= 0 Then
                    caixatexto_adicionar_n_indices.Text = form_ef_sistemas.lista_emprestimos_indices_alemao.Items.Count
                Else
                    caixatexto_adicionar_n_indices.Text = 0
                End If
            Case "Sistema de Amortização Misto"
                If form_ef_sistemas.lista_emprestimos_indices_sam.Items.Count >= 0 Then
                    caixatexto_adicionar_n_indices.Text = form_ef_sistemas.lista_emprestimos_indices_sam.Items.Count
                Else
                    caixatexto_adicionar_n_indices.Text = 0
                End If
            Case "Sistema de Pagamentos Variáveis"
                If form_ef_sistemas.lista_emprestimos_indices_spv.Items.Count >= 0 Then
                    caixatexto_adicionar_n_indices.Text = form_ef_sistemas.lista_emprestimos_indices_spv.Items.Count
                Else
                    caixatexto_adicionar_n_indices.Text = 0
                End If
        End Select
Exit_adicionar_indices_Click:
        Exit Sub

Err_adicionar_indices_Click:
        MsgBox(Err.Description)
        Resume Exit_adicionar_indices_Click
    End Sub
End Class