Imports System.Windows.Forms.PrintDialog
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.IO

Public Class profinanceira_inicio

    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim z As Integer = 0
    Dim t As Integer = 0
    Dim pagina As Integer = 1

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub submenu_calculos_financeiros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_calculos_financeiros.Click
        form_calculos_financeiros.TopLevel = False
        form_calculos_financeiros.MdiParent = Me
        form_calculos_financeiros.Show()
    End Sub

    Private Sub submenu_ef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_ef.Click
        form_ef_sistemas.TopLevel = False
        form_ef_sistemas.MdiParent = Me
        form_ef_sistemas.Show()
    End Sub

    Private Sub submenu_descontos_titulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_descontos_titulos.Click
        form_descontos_titulos.TopLevel = False
        form_descontos_titulos.MdiParent = Me
        form_descontos_titulos.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        caixadescricao_profinanceira.ShowDialog()
    End Sub

    Private Sub submenu_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_imprimir.Click
        On Error GoTo TrataErro
        PrintDialog_principal.Document = PrintDocument_principal

        If PrintDialog_principal.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.PrintDocument_principal.Print()
        End If

TrataErro:
        Exit Sub
    End Sub

    Private Sub submenu_visualizar_impressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_visualizar_impressao.Click
        Try
            Dim printPreviewDialog_principal As New PrintPreviewDialog()
            With printPreviewDialog_principal
                .Document = Me.PrintDocument_principal
                .Text = "ProFinanceira - Visualizando a impressão"
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .ShowDialog()
            End With
        Catch exp As Exception
            MsgBox(exp.Message.ToString, MsgBoxStyle.Critical, "Erro na visualização da impressão")
        End Try
    End Sub

    Private Sub PrintDocument_principal_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument_principal.PrintPage
        Dim linhasPorPagina As Single = 0
        Dim FonteMensagem4 As New System.Drawing.Font("Verdana", 10, System.Drawing.GraphicsUnit.Point)
        Dim FonteMensagem As New System.Drawing.Font("Verdana", 22, System.Drawing.GraphicsUnit.Point)
        Dim FonteMensagem2 As New System.Drawing.Font("Verdana", 12, System.Drawing.GraphicsUnit.Point)
        Dim FonteMensagem3 As New System.Drawing.Font("Verdana", 16, System.Drawing.GraphicsUnit.Point)
        Dim grafico As Graphics
        Dim ponto As Integer = 0
        grafico = e.Graphics
        grafico.DrawString(form_ef_sistemas.Text, FonteMensagem, Brushes.Blue, 100, 50)
        If form_ef_sistemas.tab_controle.SelectedIndex = 3 Then 'Sistema Price
            If pagina = 1 Then
                grafico.DrawString("Valor Presente: " & form_ef_sistemas.caixatexto_vp_price.Text, FonteMensagem2, Brushes.Black, 100, 150)
                grafico.DrawString("Taxa: " & form_ef_sistemas.caixatexto_taxa_price.Text & "%", FonteMensagem2, Brushes.Black, 100, 180)
                grafico.DrawString("Parcelas (n): " & form_ef_sistemas.caixatexto_tempo_price.Text, FonteMensagem2, Brushes.Black, 100, 210)
                grafico.DrawString("Equivalência de taxa: " & form_ef_sistemas.caixatexto_proporcional_taxa_price.Text, FonteMensagem2, Brushes.Black, 100, 240)
                grafico.DrawString("Valor Presente Negociado: " & form_ef_sistemas.caixatexto_vp_negociado_price.Text, FonteMensagem2, Brushes.Black, 100, 270)
                grafico.DrawString("Porcentagem: " & form_ef_sistemas.caixatexto_porcentagem_price.Text & "%", FonteMensagem2, Brushes.Black, 100, 300)
                grafico.DrawString("Resíduo", FonteMensagem3, Brushes.Blue, 100, 350)
                grafico.DrawString("Valor do pagamento: " & form_ef_sistemas.caixatexto_valor_pagamento_price.Text, FonteMensagem2, Brushes.Black, 100, 400)
                grafico.DrawString("Intermediária", FonteMensagem3, Brushes.Blue, 100, 450)
                grafico.DrawString("Período: " & form_ef_sistemas.caixatexto_periodo_intermediaria_price.Text, FonteMensagem2, Brushes.Black, 100, 500)
                grafico.DrawString("Valor da intermediária: " & form_ef_sistemas.caixatexto_valor_intermediaria_price.Text, FonteMensagem2, Brushes.Black, 100, 530)
                grafico.DrawString("Carência", FonteMensagem3, Brushes.Blue, 100, 580)
                grafico.DrawString("Tempo de carência: " & form_ef_sistemas.caixatexto_tempo_carencia_price.Text, FonteMensagem2, Brushes.Black, 100, 630)
                grafico.DrawString("Total de parcelas: " & form_ef_sistemas.caixatexto_total_n_price.Text, FonteMensagem2, Brushes.Black, 100, 660)
            End If
            If form_ef_sistemas.caixatexto_total_n_price.Text <> "" Then
                'Títulos
                If pagina = 1 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 710)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 710)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 710)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 710)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 710)
                    grafico.DrawString("Saldo Corrigido", FonteMensagem2, Brushes.Blue, 660, 710)
                ElseIf pagina >= 2 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 150)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 150)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 150)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 150)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 150)
                    grafico.DrawString("Saldo Corrigido", FonteMensagem2, Brushes.Blue, 660, 150)
                End If
                i = j
                While i <= form_ef_sistemas.lista_emprestimos_price.Items.Count - 1
                    If pagina = 1 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(5).Text, FonteMensagem4, Brushes.Black, 660, 710 + (i * 30 + 30))
                    ElseIf pagina >= 2 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(5).Text, FonteMensagem4, Brushes.Black, 660, 150 + (ponto * 30 + 30))
                        ponto += 1
                    End If
                    t += 1
                    If i = 13 + z And i <> form_ef_sistemas.caixatexto_total_n_price.Text + 1 Then
                        j = i
                        z += 33
                        pagina += 1
                        i = form_ef_sistemas.lista_emprestimos_price.Items.Count
                        e.HasMorePages = True
                    Else
                        e.HasMorePages = False
                    End If
                    i += 1
                    j += 1
                End While
                If form_ef_sistemas.lista_emprestimos_indices_price.Items.Count - 1 = form_ef_sistemas.caixatexto_total_n_price.Text Then
                    'Valores de n da Lista Empréstimos Índices
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 660, 150)
                    For i = 0 To form_ef_sistemas.caixatexto_total_n_price.Text
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_indices_price.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 660, 150 + (i * 30 + 30))
                    Next
                    'Valores de Índices da Lista Empréstimos Índices
                    grafico.DrawString("Índices", FonteMensagem2, Brushes.Blue, 700, 150)
                    For i = 0 To form_ef_sistemas.caixatexto_total_n_price.Text
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_indices_price.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 700, 150 + (i * 30 + 30))
                    Next
                End If
            End If
            If form_ef_sistemas.caixatexto_total_n_price.Text <> "" Then
                If t = form_ef_sistemas.lista_emprestimos_price.Items.Count Then
                    t = 0
                    i = 0
                    j = 0
                    z = 0
                    pagina = 1
                End If
            End If
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 0 Then 'Sistema de Amortização Constante
            If pagina = 1 Then
                grafico.DrawString("Valor Presente: " & form_ef_sistemas.caixatexto_vp.Text, FonteMensagem2, Brushes.Black, 100, 150)
                grafico.DrawString("Taxa: " & form_ef_sistemas.caixatexto_taxa.Text & "%", FonteMensagem2, Brushes.Black, 100, 180)
                grafico.DrawString("Parcelas (n): " & form_ef_sistemas.caixatexto_tempo.Text, FonteMensagem2, Brushes.Black, 100, 210)
                grafico.DrawString("Equivalência de taxa: " & form_ef_sistemas.caixatexto_eq_taxa.Text, FonteMensagem2, Brushes.Black, 100, 240)
                grafico.DrawString("Valor Presente Negociado: " & form_ef_sistemas.caixatexto_vp_negociado.Text, FonteMensagem2, Brushes.Black, 100, 270)
                grafico.DrawString("Porcentagem: " & form_ef_sistemas.caixatexto_porcentagem.Text & "%", FonteMensagem2, Brushes.Black, 100, 300)
                grafico.DrawString("Carência", FonteMensagem3, Brushes.Blue, 100, 580)
                grafico.DrawString("Tempo de carência: " & form_ef_sistemas.caixatexto_tempo_carencia.Text, FonteMensagem2, Brushes.Black, 100, 630)
                grafico.DrawString("Total de parcelas: " & form_ef_sistemas.caixatexto_total_n.Text, FonteMensagem2, Brushes.Black, 100, 660)
            End If
            If form_ef_sistemas.caixatexto_total_n.Text <> "" Then
                If pagina = 1 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 710)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 710)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 710)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 710)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 710)
                ElseIf pagina >= 2 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 150)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 150)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 150)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 150)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 150)
                End If
                i = j
                While i <= form_ef_sistemas.lista_emprestimos.Items.Count - 1
                    If pagina = 1 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 710 + (i * 30 + 30))
                    ElseIf pagina >= 2 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 150 + (ponto * 30 + 30))
                        ponto += 1
                    End If
                    t += 1
                    If i = 13 + z And i <> form_ef_sistemas.caixatexto_total_n.Text + 1 Then
                        j = i
                        z += 33
                        pagina += 1
                        i = form_ef_sistemas.lista_emprestimos.Items.Count
                        e.HasMorePages = True
                    Else
                        e.HasMorePages = False
                    End If
                    i += 1
                    j += 1
                End While
            End If
            If form_ef_sistemas.caixatexto_total_n.Text <> "" Then
                If t = form_ef_sistemas.lista_emprestimos.Items.Count Then
                    t = 0
                    i = 0
                    j = 0
                    z = 0
                    pagina = 1
                End If
            End If
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 1 Then 'Sistema Americano
            If pagina = 1 Then
                grafico.DrawString("Valor Presente: " & form_ef_sistemas.caixatexto_vp_americano.Text, FonteMensagem2, Brushes.Black, 100, 150)
                grafico.DrawString("Taxa: " & form_ef_sistemas.caixatexto_taxa_americano.Text & "%", FonteMensagem2, Brushes.Black, 100, 180)
                grafico.DrawString("Parcelas (n): " & form_ef_sistemas.caixatexto_tempo_americano.Text, FonteMensagem2, Brushes.Black, 100, 210)
                grafico.DrawString("Equivalência de taxa: " & form_ef_sistemas.caixatexto_eq_taxa_americano.Text, FonteMensagem2, Brushes.Black, 100, 240)
                grafico.DrawString("Valor Presente Negociado: " & form_ef_sistemas.caixatexto_vp_negociado_americano.Text, FonteMensagem2, Brushes.Black, 100, 270)
                grafico.DrawString("Porcentagem: " & form_ef_sistemas.caixatexto_porcentagem_americano.Text & "%", FonteMensagem2, Brushes.Black, 100, 300)
            End If
            If form_ef_sistemas.caixatexto_tempo_americano.Text <> "" Then
                If pagina = 1 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 710)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 710)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 710)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 710)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 710)
                ElseIf pagina >= 2 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 150)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 150)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 150)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 150)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 150)
                End If
                i = j
                While i <= form_ef_sistemas.lista_emprestimos_americano.Items.Count - 1
                    If pagina = 1 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 710 + (i * 30 + 30))
                    ElseIf pagina >= 2 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 150 + (ponto * 30 + 30))
                        ponto += 1
                    End If
                    t += 1
                    If i = 13 + z And i <> form_ef_sistemas.caixatexto_tempo_americano.Text + 1 Then
                        j = i
                        z += 33
                        pagina += 1
                        i = form_ef_sistemas.lista_emprestimos_americano.Items.Count
                        e.HasMorePages = True
                    Else
                        e.HasMorePages = False
                    End If
                    i += 1
                    j += 1
                End While
            End If
            If form_ef_sistemas.caixatexto_tempo_americano.Text <> "" Then
                If t = form_ef_sistemas.lista_emprestimos_americano.Items.Count Then
                    t = 0
                    i = 0
                    j = 0
                    z = 0
                    pagina = 1
                End If
            End If
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 2 Then 'Sistema Francês
            If pagina = 1 Then
                grafico.DrawString("Valor Presente: " & form_ef_sistemas.caixatexto_vp_frances.Text, FonteMensagem2, Brushes.Black, 100, 150)
                grafico.DrawString("Taxa: " & form_ef_sistemas.caixatexto_taxa_frances.Text & "%", FonteMensagem2, Brushes.Black, 100, 180)
                grafico.DrawString("Parcelas (n): " & form_ef_sistemas.caixatexto_tempo_frances.Text, FonteMensagem2, Brushes.Black, 100, 210)
                grafico.DrawString("Equivalência de taxa: " & form_ef_sistemas.caixatexto_eq_taxa_frances.Text, FonteMensagem2, Brushes.Black, 100, 240)
                grafico.DrawString("Valor Presente Negociado: " & form_ef_sistemas.caixatexto_vp_negociado_frances.Text, FonteMensagem2, Brushes.Black, 100, 270)
                grafico.DrawString("Porcentagem: " & form_ef_sistemas.caixatexto_porcentagem_frances.Text & "%", FonteMensagem2, Brushes.Black, 100, 300)
                grafico.DrawString("Resíduo", FonteMensagem3, Brushes.Blue, 100, 350)
                grafico.DrawString("Valor do pagamento: " & form_ef_sistemas.caixatexto_valor_pagamento_frances.Text, FonteMensagem2, Brushes.Black, 100, 400)
                grafico.DrawString("Intermediária", FonteMensagem3, Brushes.Blue, 100, 450)
                grafico.DrawString("Período: " & form_ef_sistemas.caixatexto_periodo_intermediaria_frances.Text, FonteMensagem2, Brushes.Black, 100, 500)
                grafico.DrawString("Valor da intermediária: " & form_ef_sistemas.caixatexto_valor_intermediaria_frances.Text, FonteMensagem2, Brushes.Black, 100, 530)
                grafico.DrawString("Carência", FonteMensagem3, Brushes.Blue, 100, 580)
                grafico.DrawString("Tempo de carência: " & form_ef_sistemas.caixatexto_tempo_carencia_frances.Text, FonteMensagem2, Brushes.Black, 100, 630)
                grafico.DrawString("Total de parcelas: " & form_ef_sistemas.caixatexto_total_n_frances.Text, FonteMensagem2, Brushes.Black, 100, 660)
            End If
            If form_ef_sistemas.caixatexto_total_n_frances.Text <> "" Then
                If pagina = 1 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 710)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 710)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 710)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 710)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 710)
                    grafico.DrawString("Saldo Corrigido", FonteMensagem2, Brushes.Blue, 660, 710)
                ElseIf pagina >= 2 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 150)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 150)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 150)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 150)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 150)
                    grafico.DrawString("Saldo Corrigido", FonteMensagem2, Brushes.Blue, 660, 150)
                End If
                i = j
                While i <= form_ef_sistemas.lista_emprestimos_frances.Items.Count - 1
                    If pagina = 1 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(5).Text, FonteMensagem4, Brushes.Black, 660, 710 + (i * 30 + 30))
                    ElseIf pagina >= 2 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(5).Text, FonteMensagem4, Brushes.Black, 660, 150 + (ponto * 30 + 30))
                        ponto += 1
                    End If
                    t += 1
                    If i = 13 + z And i <> form_ef_sistemas.caixatexto_total_n_frances.Text + 1 Then
                        j = i
                        z += 33
                        pagina += 1
                        i = form_ef_sistemas.lista_emprestimos_frances.Items.Count
                        e.HasMorePages = True
                    Else
                        e.HasMorePages = False
                    End If
                    i += 1
                    j += 1
                End While
            End If
            If form_ef_sistemas.lista_emprestimos_indices_frances.Items.Count - 1 = form_ef_sistemas.caixatexto_total_n_frances.Text Then
                'Valores de n da Lista Empréstimos Índices
                grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 660, 150)
                For i = 0 To form_ef_sistemas.caixatexto_total_n_frances.Text
                    grafico.DrawString(form_ef_sistemas.lista_emprestimos_indices_frances.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 660, 150 + (i * 30 + 30))
                Next
                'Valores de Índices da Lista Empréstimos Índices
                grafico.DrawString("Índices", FonteMensagem2, Brushes.Blue, 700, 150)
                For i = 0 To form_ef_sistemas.caixatexto_total_n_frances.Text
                    grafico.DrawString(form_ef_sistemas.lista_emprestimos_indices_frances.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 700, 150 + (i * 30 + 30))
                Next
            End If
        End If
        If form_ef_sistemas.caixatexto_total_n_frances.Text <> "" Then
            If t = form_ef_sistemas.lista_emprestimos_frances.Items.Count Then
                t = 0
                i = 0
                j = 0
                z = 0
                pagina = 1
            End If
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 4 Then 'Sistema Alemão
            If pagina = 1 Then
                grafico.DrawString("Valor Presente: " & form_ef_sistemas.caixatexto_vp_alemao.Text, FonteMensagem2, Brushes.Black, 100, 150)
                grafico.DrawString("Taxa: " & form_ef_sistemas.caixatexto_taxa_alemao.Text & "%", FonteMensagem2, Brushes.Black, 100, 180)
                grafico.DrawString("Parcelas (n): " & form_ef_sistemas.caixatexto_tempo_alemao.Text, FonteMensagem2, Brushes.Black, 100, 210)
                grafico.DrawString("Equivalência de taxa: " & form_ef_sistemas.caixatexto_eq_taxa_alemao.Text, FonteMensagem2, Brushes.Black, 100, 240)
                grafico.DrawString("Valor Presente Negociado: " & form_ef_sistemas.caixatexto_vp_negociado_alemao.Text, FonteMensagem2, Brushes.Black, 100, 270)
                grafico.DrawString("Porcentagem: " & form_ef_sistemas.caixatexto_porcentagem_alemao.Text & "%", FonteMensagem2, Brushes.Black, 100, 300)
                grafico.DrawString("Resíduo", FonteMensagem3, Brushes.Blue, 100, 350)
                grafico.DrawString("Valor do pagamento: " & form_ef_sistemas.caixatexto_valor_pagamento_alemao.Text, FonteMensagem2, Brushes.Black, 100, 400)
                grafico.DrawString("Intermediária", FonteMensagem3, Brushes.Blue, 100, 450)
                grafico.DrawString("Período: " & form_ef_sistemas.caixatexto_periodo_intermediaria_alemao.Text, FonteMensagem2, Brushes.Black, 100, 500)
                grafico.DrawString("Valor da intermediária: " & form_ef_sistemas.caixatexto_valor_intermediaria_alemao.Text, FonteMensagem2, Brushes.Black, 100, 530)
                grafico.DrawString("Carência", FonteMensagem3, Brushes.Blue, 100, 580)
                grafico.DrawString("Tempo de carência: " & form_ef_sistemas.caixatexto_tempo_carencia_alemao.Text, FonteMensagem2, Brushes.Black, 100, 630)
                grafico.DrawString("Total de parcelas: " & form_ef_sistemas.caixatexto_total_n_alemao.Text, FonteMensagem2, Brushes.Black, 100, 660)
            End If
            If form_ef_sistemas.caixatexto_total_n_alemao.Text <> "" Then
                If pagina = 1 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 710)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 710)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 710)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 710)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 710)
                ElseIf pagina >= 2 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 150)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 150)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 150)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 150)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 150)
                End If
                i = j
                While i <= form_ef_sistemas.lista_emprestimos_alemao.Items.Count - 1
                    If pagina = 1 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 710 + (i * 30 + 30))
                    ElseIf pagina >= 2 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 150 + (ponto * 30 + 30))
                        ponto += 1
                    End If
                    t += 1
                    If i = 13 + z And i <> form_ef_sistemas.caixatexto_total_n_alemao.Text + 1 Then
                        j = i
                        z += 33
                        pagina += 1
                        i = form_ef_sistemas.lista_emprestimos_alemao.Items.Count
                        e.HasMorePages = True
                    Else
                        e.HasMorePages = False
                    End If
                    i += 1
                    j += 1
                End While
            End If
            If form_ef_sistemas.caixatexto_total_n_alemao.Text <> "" Then
                If t = form_ef_sistemas.lista_emprestimos_alemao.Items.Count Then
                    t = 0
                    i = 0
                    j = 0
                    z = 0
                    pagina = 1
                End If
            End If
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 5 Then 'Sistema de Amortização Misto
            If pagina = 1 Then
                grafico.DrawString("Valor Presente: " & form_ef_sistemas.caixatexto_vp_sam.Text, FonteMensagem2, Brushes.Black, 100, 150)
                grafico.DrawString("Taxa: " & form_ef_sistemas.caixatexto_taxa_sam.Text & "%", FonteMensagem2, Brushes.Black, 100, 180)
                grafico.DrawString("Parcelas (n): " & form_ef_sistemas.caixatexto_tempo_sam.Text, FonteMensagem2, Brushes.Black, 100, 210)
                grafico.DrawString("Equivalência de taxa: " & form_ef_sistemas.caixatexto_eq_taxa_sam.Text, FonteMensagem2, Brushes.Black, 100, 240)
                grafico.DrawString("Valor Presente Negociado: " & form_ef_sistemas.caixatexto_vp_negociado_sam.Text, FonteMensagem2, Brushes.Black, 100, 270)
                grafico.DrawString("Porcentagem: " & form_ef_sistemas.caixatexto_porcentagem_sam.Text & "%", FonteMensagem2, Brushes.Black, 100, 300)
                grafico.DrawString("Resíduo", FonteMensagem3, Brushes.Blue, 100, 350)
                grafico.DrawString("Valor do pagamento: " & form_ef_sistemas.caixatexto_valor_pagamento_sam.Text, FonteMensagem2, Brushes.Black, 100, 400)
            End If
            If form_ef_sistemas.caixatexto_tempo_sam.Text <> "" Then
                If pagina = 1 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 710)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 710)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 710)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 710)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 710)
                ElseIf pagina >= 2 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 150)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 150)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 150)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 150)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 150)
                End If
                i = j
                While i <= form_ef_sistemas.lista_emprestimos_sam.Items.Count - 1
                    If pagina = 1 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 710 + (i * 30 + 30))
                    ElseIf pagina >= 2 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 150 + (ponto * 30 + 30))
                        ponto += 1
                    End If
                    t += 1
                    If i = 13 + z And i <> form_ef_sistemas.caixatexto_tempo_sam.Text + 1 Then
                        j = i
                        z += 33
                        pagina += 1
                        i = form_ef_sistemas.lista_emprestimos_sam.Items.Count
                        e.HasMorePages = True
                    Else
                        e.HasMorePages = False
                    End If
                    i += 1
                    j += 1
                End While
            End If
            If form_ef_sistemas.caixatexto_tempo_sam.Text <> "" Then
                If t = form_ef_sistemas.lista_emprestimos_sam.Items.Count Then
                    t = 0
                    i = 0
                    j = 0
                    z = 0
                    pagina = 1
                End If
            End If
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 6 Then 'Sistema de Pagamentos Variáveis
            If pagina = 1 Then
                grafico.DrawString("Valor Presente: " & form_ef_sistemas.caixatexto_vp_spv.Text, FonteMensagem2, Brushes.Black, 100, 150)
                grafico.DrawString("Taxa: " & form_ef_sistemas.caixatexto_taxa_spv.Text & "%", FonteMensagem2, Brushes.Black, 100, 180)
                grafico.DrawString("Parcelas (n): " & form_ef_sistemas.caixatexto_tempo_spv.Text, FonteMensagem2, Brushes.Black, 100, 210)
                grafico.DrawString("Equivalência de taxa: " & form_ef_sistemas.caixatexto_eq_taxa_spv.Text, FonteMensagem2, Brushes.Black, 100, 240)
                grafico.DrawString("Valor Presente Negociado: " & form_ef_sistemas.caixatexto_vp_negociado_spv.Text, FonteMensagem2, Brushes.Black, 100, 270)
                grafico.DrawString("Porcentagem: " & form_ef_sistemas.caixatexto_porcentagem_spv.Text & "%", FonteMensagem2, Brushes.Black, 100, 300)
                grafico.DrawString("Resíduo", FonteMensagem3, Brushes.Blue, 100, 350)
                grafico.DrawString("Valor do pagamento: " & form_ef_sistemas.caixatexto_valor_pagamento_spv.Text, FonteMensagem2, Brushes.Black, 100, 400)
            End If
            If form_ef_sistemas.caixatexto_tempo_spv.Text <> "" Then
                If pagina = 1 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 710)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 710)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 710)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 710)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 710)
                ElseIf pagina >= 2 Then
                    grafico.DrawString("n", FonteMensagem2, Brushes.Blue, 5, 150)
                    grafico.DrawString("Amortização", FonteMensagem2, Brushes.Blue, 50, 150)
                    grafico.DrawString("Juros", FonteMensagem2, Brushes.Blue, 190, 150)
                    grafico.DrawString("Prestação", FonteMensagem2, Brushes.Blue, 340, 150)
                    grafico.DrawString("Saldo Devedor", FonteMensagem2, Brushes.Blue, 490, 150)
                End If
                i = j
                While i <= form_ef_sistemas.lista_emprestimos_spv.Items.Count - 1
                    If pagina = 1 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 710 + (i * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 710 + (i * 30 + 30))
                    ElseIf pagina >= 2 Then
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).Text, FonteMensagem4, Brushes.Black, 5, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(1).Text, FonteMensagem4, Brushes.Black, 50, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(2).Text, FonteMensagem4, Brushes.Black, 190, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(3).Text, FonteMensagem4, Brushes.Black, 340, 150 + (ponto * 30 + 30))
                        grafico.DrawString(form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(4).Text, FonteMensagem4, Brushes.Black, 490, 150 + (ponto * 30 + 30))
                        ponto += 1
                    End If
                    t += 1
                    If i = 13 + z And i <> form_ef_sistemas.caixatexto_tempo_spv.Text + 1 Then
                        j = i
                        z += 33
                        pagina += 1
                        i = form_ef_sistemas.lista_emprestimos_spv.Items.Count
                        e.HasMorePages = True
                    Else
                        e.HasMorePages = False
                    End If
                    i += 1
                    j += 1
                End While
            End If
            If form_ef_sistemas.caixatexto_tempo_spv.Text <> "" Then
                If t = form_ef_sistemas.lista_emprestimos_spv.Items.Count Then
                    t = 0
                    i = 0
                    j = 0
                    z = 0
                    pagina = 1
                End If
            End If
        End If
    End Sub

    Private Sub submenu2_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu2_excel.Click
        Dim i As Integer
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim EApp As New Microsoft.Office.Interop.Excel.Application
        Dim Ewkb As Microsoft.Office.Interop.Excel.Workbook = EApp.Workbooks.Add
        Dim Ewks As Microsoft.Office.Interop.Excel.Worksheet = Ewkb.Worksheets.Add
        Dim Exlc As New Microsoft.Office.Interop.Excel.Chart
        Dim n As Double
        If form_ef_sistemas.tab_controle.SelectedIndex = 0 Then
            n = form_ef_sistemas.caixatexto_total_n.Text
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 1 Then
            n = form_ef_sistemas.caixatexto_tempo_americano.Text
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 2 Then
            n = form_ef_sistemas.caixatexto_total_n_frances.Text
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 3 Then
            n = form_ef_sistemas.caixatexto_total_n_price.Text
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 4 Then
            n = form_ef_sistemas.caixatexto_total_n_alemao.Text
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 5 Then
            n = form_ef_sistemas.caixatexto_tempo_sam.Text
        ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 6 Then
            n = form_ef_sistemas.caixatexto_tempo_spv.Text
        End If
        If n > 0 Then
            Dim amortizacao(0 To n + 1) As Double
            Dim juros(0 To n + 1) As Double
            Dim prestacao(0 To n + 1) As Double
            Dim saldodevedor(0 To n + 1) As Double
            Dim saldodevedor_corrigido(0 To n + 1) As Double
            EApp.UserControl = True
            If form_ef_sistemas.tab_controle.SelectedIndex = 0 Then
                Ewks.Name = "SAC"
                For i = 0 To form_ef_sistemas.caixatexto_total_n.Text + 1
                    amortizacao(i) = form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(1).Text
                    juros(i) = form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(2).Text
                    prestacao(i) = form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(3).Text
                    saldodevedor(i) = form_ef_sistemas.lista_emprestimos.Items.Item(i).SubItems.Item(4).Text
                Next
            ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 1 Then
                Ewks.Name = "Sistema Americano"
                For i = 0 To form_ef_sistemas.caixatexto_tempo_americano.Text + 1
                    amortizacao(i) = form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(1).Text
                    juros(i) = form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(2).Text
                    prestacao(i) = form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(3).Text
                    saldodevedor(i) = form_ef_sistemas.lista_emprestimos_americano.Items.Item(i).SubItems.Item(4).Text
                Next
            ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 2 Then
                Ewks.Name = "Sistema Francês"
                For i = 0 To form_ef_sistemas.caixatexto_total_n_frances.Text + 1
                    amortizacao(i) = form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(1).Text
                    juros(i) = form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(2).Text
                    prestacao(i) = form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(3).Text
                    saldodevedor(i) = form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(4).Text
                    saldodevedor_corrigido(i) = form_ef_sistemas.lista_emprestimos_frances.Items.Item(i).SubItems.Item(5).Text
                Next
            ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 3 Then
                Ewks.Name = "Sistema Price"
                For i = 0 To form_ef_sistemas.caixatexto_total_n_price.Text + 1
                    amortizacao(i) = form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(1).Text
                    juros(i) = form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(2).Text
                    prestacao(i) = form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(3).Text
                    saldodevedor(i) = form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(4).Text
                    saldodevedor_corrigido(i) = form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(5).Text
                Next
            ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 4 Then
                Ewks.Name = "Sistema Alemão"
                For i = 0 To form_ef_sistemas.caixatexto_total_n_alemao.Text + 1
                    amortizacao(i) = form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(1).Text
                    juros(i) = form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(2).Text
                    prestacao(i) = form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(3).Text
                    saldodevedor(i) = form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(4).Text
                    saldodevedor_corrigido(i) = form_ef_sistemas.lista_emprestimos_alemao.Items.Item(i).SubItems.Item(5).Text
                Next
            ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 5 Then
                Ewks.Name = "Sistema de Amortização Misto"
                For i = 0 To form_ef_sistemas.caixatexto_tempo_sam.Text + 1
                    amortizacao(i) = form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(1).Text
                    juros(i) = form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(2).Text
                    prestacao(i) = form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(3).Text
                    saldodevedor(i) = form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(4).Text
                    saldodevedor_corrigido(i) = form_ef_sistemas.lista_emprestimos_sam.Items.Item(i).SubItems.Item(5).Text
                Next
            ElseIf form_ef_sistemas.tab_controle.SelectedIndex = 6 Then
                Ewks.Name = "Sistema de Pagamentos Variáveis"
                For i = 0 To form_ef_sistemas.caixatexto_tempo_spv.Text + 1
                    amortizacao(i) = form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(1).Text
                    juros(i) = form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(2).Text
                    prestacao(i) = form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(3).Text
                    saldodevedor(i) = form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(4).Text
                    saldodevedor_corrigido(i) = form_ef_sistemas.lista_emprestimos_spv.Items.Item(i).SubItems.Item(5).Text
                Next
            End If

            Ewks.Range("A1", "F" & n + 3).Font.Size = 10

            EApp.Visible = True
            Ewks.Cells(1, 1) = "n"
            Ewks.Cells(1, 2) = "Amortização"
            Ewks.Cells(1, 3) = "Juros"
            Ewks.Cells(1, 4) = "Prestação"
            Ewks.Cells(1, 5) = "Saldo Devedor"
            Ewks.Cells(1, 6) = "Saldo Devedor Corrigido"
            For i = 0 To n + 1
                Ewks.Cells(i + 2, 1) = i
                Ewks.Cells(i + 2, 2) = amortizacao(i)
                Ewks.Cells(i + 2, 3) = juros(i)
                Ewks.Cells(i + 2, 4) = prestacao(i)
                Ewks.Cells(i + 2, 5) = saldodevedor(i)
                Ewks.Cells(i + 2, 6) = saldodevedor_corrigido(i)
            Next i

            Ewks.Range("B1:C" & n + 2).Select()

            Exlc = EApp.Charts.Add
            With Exlc
                .ChartType = Microsoft.Office.Interop.Excel.XlChartType.xl3DColumnStacked
            End With

            EApp = Nothing
            Ewkb = Nothing
            Ewks = Nothing
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Else
            MsgBox("Número da parcela incorreto ou não preenchido.", MsgBoxStyle.OkOnly, "ProFinanceira")
        End If
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        Dim messageOutput As String = "um"
        Dim messageOutput2 As String = "dois"
        Dim fileInPath As String = "HelpProFinanceira.chm"
        Dim pathItem As String, pathItem2 As String, pathItem3 As String
        Dim pathItem4 As String
        Dim caminho As String

        caminho = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        If messageOutput2 <> messageOutput Then
            messageOutput2 = ""
            messageOutput = ""
            For Each pathItem In Directory.GetDirectories(caminho)
                If File.Exists(pathItem & "\" & fileInPath) Then
                    messageOutput += pathItem & "\" & fileInPath
                End If
                For Each pathItem2 In Directory.GetDirectories(pathItem)
                    If File.Exists(pathItem2 & "\" & fileInPath) Then
                        messageOutput += pathItem2 & "\" & fileInPath
                    End If
                    For Each pathItem3 In Directory.GetDirectories(pathItem2)
                        If File.Exists(pathItem3 & "\" & fileInPath) Then
                            messageOutput += pathItem3 & "\" & fileInPath
                        End If
                        For Each pathItem4 In Directory.GetDirectories(pathItem3)
                            If File.Exists(pathItem4 & "\" & fileInPath) Then
                                messageOutput += pathItem4 & "\" & fileInPath
                            End If
                        Next
                    Next
                Next
            Next
            messageOutput2 = messageOutput
        End If
        Help.ShowHelp(Me, messageOutput)
    End Sub
End Class