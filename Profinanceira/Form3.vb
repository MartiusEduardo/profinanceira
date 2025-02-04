Public Class form_inserir_indice

    Private Sub form_inserir_indice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case form_sistema_price.caixacombo_le_add_indices.Text
            Case "Sistema Francês"
                If form_ef_sistemas.Coluna_n_indices_frances.Text = caixatexto_n_indice.Text Then
                    caixatexto_indice.Text = form_ef_sistemas.Coluna_indices_frances.Text
                End If
            Case "Sistema PRICE"
                If form_ef_sistemas.Coluna_n_indices_price.Text = caixatexto_n_indice.Text Then
                    caixatexto_indice.Text = form_ef_sistemas.Coluna_indices_price.Text
                End If
        End Select
    End Sub

    Private Sub btn_mudar_indice_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mudar_indice_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_mudar_indice_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mudar_indice_ok.Click
        Dim subitem As System.Windows.Forms.ListViewItem.ListViewSubItem
        Dim n As Integer
        n = caixatexto_n_indice.Text
        Select Case form_sistema_price.caixacombo_le_add_indices.Text
            Case "Sistema Francês"
                If (form_ef_sistemas.lista_emprestimos_indices_frances.Items.Count - 1) < caixatexto_n_indice.Text Then
                    MsgBox("Não é possível inserir este índice", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    subitem = form_ef_sistemas.lista_emprestimos_indices_frances.Items.Insert(n, n).SubItems.Add(n)
                    subitem.Text = caixatexto_indice.Text
                End If
            Case "Sistema PRICE"
                If (form_ef_sistemas.lista_emprestimos_indices_price.Items.Count - 1) < caixatexto_n_indice.Text Then
                    MsgBox("Não é possível inserir este índice", MsgBoxStyle.Critical, "ProFinanceira")
                Else
                    subitem = form_ef_sistemas.lista_emprestimos_indices_price.Items.Insert(n, n).SubItems.Add(n)
                    subitem.Text = caixatexto_indice.Text
                End If
        End Select
    End Sub

    Private Sub caixatexto_indice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_indice.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class