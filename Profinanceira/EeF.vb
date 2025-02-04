Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports Microsoft.Office.Interop

Public Class form_ef_sistemas

    Private FonteMensagem4 As New System.Drawing.Font("Arial", 10, System.Drawing.GraphicsUnit.Point)
    Private FonteMensagem As New System.Drawing.Font("Arial", 15, FontStyle.Bold)
    Private FonteMensagem2 As New System.Drawing.Font("Arial", 8, System.Drawing.GraphicsUnit.Point)
    Private FonteMensagem3 As New System.Drawing.Font("Arial", 12, System.Drawing.GraphicsUnit.Point)
    Private margemEsq As Single
    Private margemSup As Single
    Private margemDir As Single
    Private margemInf As Single
    Private linhasPorPagina As Single
    Private posicaoDaLinha As Single
    Private pagina As Integer = 1
    Private i As Integer = 0
    Private grafico As Graphics

    Private Sub form_ef_sistemas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            form_opcoes.btn_carregar_opcoes.Enabled = True
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub form_ef_sistemas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            form_opcoes.btn_carregar_opcoes.Enabled = False
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_vp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vp.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_vp.TextChanged
        Try
            If caixatexto_vp.Text <> "" And caixatexto_taxa.Text <> "" _
        And caixatexto_tempo.Text <> "" Then
                btn_calcular_eq_taxa.Enabled = True
                If btn_calcular_eq_taxa.Enabled = True And btn_remover_amortizacao.Enabled = True Then
                    btn_adicionar_amortizacao.Enabled = False
                Else
                    btn_adicionar_amortizacao.Enabled = True
                End If
                If btn_calcular_eq_taxa.Enabled = True And btn_remover_indices.Enabled = True Then
                    btn_adicionar_indices.Enabled = False
                Else
                    btn_adicionar_indices.Enabled = True
                End If
                If btn_calcular_eq_taxa.Enabled = True And btn_remover_periodo.Enabled = True Then
                    btn_adicionar_periodo.Enabled = False
                Else
                    btn_adicionar_periodo.Enabled = True
                End If
            Else
                btn_calcular_eq_taxa.Enabled = False
                btn_adicionar_amortizacao.Enabled = False
                btn_adicionar_indices.Enabled = False
                btn_adicionar_periodo.Enabled = False
            End If
            If btn_calcular_eq_taxa.Enabled = True And caixatexto_eq_taxa.Text <> 0 Then
                btn_calcular.Enabled = True
            Else
                btn_calcular.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_taxa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_taxa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_taxa.TextChanged
        Try
            If caixatexto_vp.Text <> "" And caixatexto_taxa.Text <> "" _
        And caixatexto_tempo.Text <> "" Then
                btn_calcular_eq_taxa.Enabled = True
                If btn_calcular_eq_taxa.Enabled = True And btn_remover_amortizacao.Enabled = True Then
                    btn_adicionar_amortizacao.Enabled = False
                Else
                    btn_adicionar_amortizacao.Enabled = True
                End If
                If btn_calcular_eq_taxa.Enabled = True And btn_remover_indices.Enabled = True Then
                    btn_adicionar_indices.Enabled = False
                Else
                    btn_adicionar_indices.Enabled = True
                End If
                If btn_calcular_eq_taxa.Enabled = True And btn_remover_periodo.Enabled = True Then
                    btn_adicionar_periodo.Enabled = False
                Else
                    btn_adicionar_periodo.Enabled = True
                End If
            Else
                btn_calcular_eq_taxa.Enabled = False
                btn_adicionar_amortizacao.Enabled = False
                btn_adicionar_indices.Enabled = False
                btn_adicionar_periodo.Enabled = False
            End If
            If btn_calcular_eq_taxa.Enabled = True And caixatexto_eq_taxa.Text <> 0 Then
                btn_calcular.Enabled = True
            Else
                btn_calcular.Enabled = False
            End If
            If caixatexto_taxa.Text = "" Then
                caixatexto_eq_taxa.Text = 0
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_tempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tempo.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tempo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_tempo.TextChanged
        Try
            If caixatexto_vp.Text <> "" And caixatexto_taxa.Text <> "" _
        And caixatexto_tempo.Text <> "" Then
                btn_calcular_eq_taxa.Enabled = True
                If btn_calcular_eq_taxa.Enabled = True And btn_remover_amortizacao.Enabled = True Then
                    btn_adicionar_amortizacao.Enabled = False
                Else
                    btn_adicionar_amortizacao.Enabled = True
                End If
                If btn_calcular_eq_taxa.Enabled = True And btn_remover_indices.Enabled = True Then
                    btn_adicionar_indices.Enabled = False
                Else
                    btn_adicionar_indices.Enabled = True
                End If
                If btn_calcular_eq_taxa.Enabled = True And btn_remover_periodo.Enabled = True Then
                    btn_adicionar_periodo.Enabled = False
                Else
                    btn_adicionar_periodo.Enabled = True
                End If
            Else
                btn_calcular_eq_taxa.Enabled = False
                btn_adicionar_amortizacao.Enabled = False
                btn_adicionar_indices.Enabled = False
                btn_adicionar_periodo.Enabled = False
            End If
            If btn_calcular_eq_taxa.Enabled = True And caixatexto_eq_taxa.Text <> 0 Then
                btn_calcular.Enabled = True
            Else
                btn_calcular.Enabled = False
            End If
            Dim prazo As String
            prazo = caixatexto_tempo_carencia.Text
            If prazo <> "" Then
                If caixatexto_tempo.Text <> "" And caixatexto_tempo_carencia.Text = 0 Then
                    caixatexto_total_n.Text = caixatexto_tempo.Text
                ElseIf caixatexto_tempo.Text <> "" Then
                    Dim num1 As Double = caixatexto_tempo.Text
                    Dim num2 As Double = caixatexto_tempo_carencia.Text
                    caixatexto_total_n.Text = num1 + num2
                End If
            Else
                caixatexto_total_n.Text = caixatexto_tempo.Text
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_tempo_carencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tempo_carencia.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tempo_carencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_tempo_carencia.TextChanged
        Dim num1 As Double, num2 As Double
        Dim prazo As String, carencia As String
        Try
            prazo = caixatexto_tempo.Text
            If prazo <> "" Then
                carencia = caixatexto_tempo_carencia.Text
                If carencia <> "" Then
                    num1 = caixatexto_tempo_carencia.Text
                    num2 = caixatexto_tempo.Text
                    caixatexto_total_n.Text = num1 + num2
                Else
                    caixatexto_total_n.Text = caixatexto_tempo.Text
                End If
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_nao_intermediaria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_nao_intermediaria.CheckedChanged
        Try
            If rdo_nao_intermediaria.Checked = False Then
                caixatexto_periodo_intermediaria.ReadOnly = False
                caixatexto_valor_intermediaria.ReadOnly = False
                btn_calcular.Enabled = False
            Else
                caixatexto_periodo_intermediaria.ReadOnly = True
                caixatexto_periodo_intermediaria.Text = 0
                caixatexto_valor_intermediaria.ReadOnly = True
                caixatexto_valor_intermediaria.Text = 0
            End If
            If btn_calcular_eq_taxa.Enabled = True And rdo_nao_intermediaria.Checked = True Then
                btn_calcular.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_eq_taxa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_eq_taxa.TextChanged
        Try
            If caixatexto_eq_taxa.Text = 0 Then
                btn_calcular.Enabled = False
            Else
                btn_calcular.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_sem_residuo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_sem_residuo.CheckedChanged
        Try
            If rdo_sem_residuo.Checked = False Then
                caixatexto_valor_pagamento.ReadOnly = False
                btn_calcular.Enabled = False
            Else
                caixatexto_valor_pagamento.ReadOnly = True
                caixatexto_valor_pagamento.Text = 0
            End If
            If btn_calcular_eq_taxa.Enabled = True And rdo_sem_residuo.Checked = True Then
                btn_calcular.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_calcular_eq_taxa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_eq_taxa.Click
        On Error GoTo Err_calcular_eq_taxa_Click
        Dim equivalencia As New EquivalenciaDeTaxa()
        Dim taxa As Double, tempo1 As String, tempo2 As String, dia_util As Double
        tempo1 = caixacombo_taxa.SelectedItem
        tempo2 = caixacombo_tempo.SelectedItem
        taxa = caixatexto_taxa.Text
        dia_util = caixatexto_dias_uteis.Text
        If rdo_sistema_price.Checked = True Then
            caixatexto_eq_taxa.Text = equivalencia.JurosSimples(taxa, tempo1, tempo2, dia_util)
        Else
            caixatexto_eq_taxa.Text = equivalencia.JurosCompostos(taxa, tempo1, tempo2, dia_util)
        End If
Exit_calcular_eq_taxa_Click:
        Exit Sub

Err_calcular_eq_taxa_Click:
        MsgBox(Err.Description)
        Resume Exit_calcular_eq_taxa_Click
    End Sub

    Private Sub caixatexto_valor_pagamento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_valor_pagamento.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_valor_pagamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_valor_pagamento.TextChanged
        Try
            If caixatexto_valor_pagamento.Text <> "" And caixatexto_vp.Text <> "" _
        And caixatexto_taxa.Text <> "" And caixatexto_tempo.Text <> "" Then
                btn_calcular.Enabled = True
            Else
                btn_calcular.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_periodo_intermediaria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_periodo_intermediaria.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_periodo_intermediaria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_periodo_intermediaria.TextChanged
        Try
            If caixatexto_periodo_intermediaria.Text <> "" And caixatexto_valor_intermediaria.Text <> "" _
        And caixatexto_vp.Text <> "" And caixatexto_taxa.Text <> "" _
        And caixatexto_tempo.Text <> "" Then
                btn_calcular.Enabled = True
            Else
                btn_calcular.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_valor_intermediaria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_valor_intermediaria.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_valor_intermediaria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_valor_intermediaria.TextChanged
        Try
            If caixatexto_valor_intermediaria.Text <> "" And caixatexto_periodo_intermediaria.Text <> "" _
        And caixatexto_vp.Text <> "" And caixatexto_taxa.Text <> "" _
        And caixatexto_tempo.Text <> "" Then
                btn_calcular.Enabled = True
            Else
                btn_calcular.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_vp_negociado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vp_negociado.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub rdo_negociado_nao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_negociado_nao.CheckedChanged
        Try
            If rdo_negociado_nao.Checked = False Then
                caixatexto_vp_negociado.ReadOnly = False
            Else
                caixatexto_vp_negociado.ReadOnly = True
                caixatexto_vp_negociado.Text = 0
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_sem_carencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_sem_carencia.CheckedChanged
        Try
            If rdo_sem_carencia.Checked = True Then
                GrupoTipoDeCarencia.Enabled = False
                caixatexto_tempo_carencia.ReadOnly = True
                caixatexto_tempo_carencia.Text = 0
                rdo_juros_pdc.Checked = True
                caixatexto_total_n.Text = caixatexto_tempo.Text
            Else
                GrupoTipoDeCarencia.Enabled = True
                caixatexto_tempo_carencia.ReadOnly = False
                If rdo_sistema_americano.Checked = True Then
                    rdo_juros_cdc_asd.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        On Error GoTo Err_calcular_Click
        Dim sistema As New ClasseEmpFin
        sistema.CalcularEmpFin(caixatexto_vp.Text, caixatexto_taxa.Text, caixatexto_tempo.Text, caixatexto_eq_taxa.Text, caixatexto_tempo_carencia.Text, caixatexto_total_n.Text, caixatexto_vp_negociado.Text, caixatexto_valor_pagamento.Text, caixatexto_periodo_intermediaria.Text, caixatexto_valor_intermediaria.Text)
Exit_calcular_Click:
        Exit Sub

Err_calcular_Click:
        MsgBox(Err.Description)
        Resume Exit_calcular_Click
    End Sub

    Private Sub btn_limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpar.Click
        On Error GoTo Err_limpar_Click
        If rdo_tabela_1.Checked = True Then
            lista_emprestimos.Items.Clear()
        ElseIf rdo_tabela_2.Checked = True Then
            lista_emprestimos_2.Items.Clear()
        End If
Exit_limpar_Click:
        Exit Sub

Err_limpar_Click:
        MsgBox(Err.Description)
        Resume Exit_limpar_Click
    End Sub

    Private Sub caixacombo_casas_decimais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_casas_decimais.SelectedIndexChanged
        Try
            Dim num1 As Integer
            If caixacombo_casas_decimais.Text <> "" Then
                num1 = caixacombo_casas_decimais.Text
                caixatexto_eq_taxa.Text = Decimal.Round(caixatexto_eq_taxa.Text, num1, MidpointRounding.ToEven)
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_visualizar_impressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_visualizar_impressao.Click
        Try
            Dim printPreviewDialog_principal As New PrintPreviewDialog()
            With printPreviewDialog_principal
                .Document = PrintDocument_ef
                .Text = "ProFinanceira - Visualization"
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .ShowDialog()
            End With
        Catch exp As Exception
            MsgBox(exp.Message.ToString, MsgBoxStyle.Critical, "Error in print preview")
        End Try
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        Try
            If PrintDialog_ef.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PrintDialog_ef.Document = PrintDocument_ef
                PrintDocument_ef.Print()
            Else
                Dim cancelado As String = "cancelado"
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error printing")
        End Try
    End Sub

    Private Sub btn_inserir_amortizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_amortizacao.Click
        On Error GoTo Err_inserir_amortizacao_spv_Click
        Dim i As Integer
        For i = 1 To caixatexto_tempo.Text
            dgv_emprestimos_amortizacao.Rows.Add()
        Next
        For i = 0 To caixatexto_tempo.Text - 1
            dgv_emprestimos_amortizacao.Rows.Item(i).Cells.Item(0).Value = i + 1
        Next
        btn_remover_amortizacao.Enabled = True
        btn_adicionar_amortizacao.Enabled = False
Exit_inserir_amortizacao_spv_Click:
        Exit Sub

Err_inserir_amortizacao_spv_Click:
        MsgBox(Err.Description)
        Resume Exit_inserir_amortizacao_spv_Click
    End Sub

    Private Sub btn_remover_amortizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_remover_amortizacao.Click
        On Error GoTo Err_remover_amortizacao_spv_Click
        Dim i As Integer
        For i = 1 To caixatexto_tempo.Text
            dgv_emprestimos_amortizacao.Rows.RemoveAt(0)
        Next
        btn_adicionar_amortizacao.Enabled = True
        btn_remover_amortizacao.Enabled = False
Exit_remover_amortizacao_spv_Click:
        Exit Sub

Err_remover_amortizacao_spv_Click:
        MsgBox(Err.Description)
        Resume Exit_remover_amortizacao_spv_Click
    End Sub

    'IMPRESSÃO TABELA

    Private Sub PrintDocument_ef_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument_ef.PrintPage
        On Error GoTo Err_PrintDocument_ef_PrintPage
        Dim linhaAtual As Single = 19
        Dim caminho As String = My.Application.Info.DirectoryPath & "\logo Profinanceira.JPG"
        Dim imprimir As New Impressao
        linhasPorPagina = e.MarginBounds.Height / FonteMensagem4.GetHeight(e.Graphics) - 10
        grafico = e.Graphics
        margemEsq = e.MarginBounds.Left
        margemSup = e.MarginBounds.Top
        margemDir = e.MarginBounds.Right
        margemInf = e.MarginBounds.Bottom
        If combo_impressao.Text = "PV, Rate, n, FV" Then
            imprimir.ImpressaoEmprestimosFinanciamentos(sender, e)
        ElseIf combo_impressao.Text = "Table" Then
            '
            grafico.DrawLine(Pens.Black, margemEsq, margemSup, margemDir, margemSup)
            grafico.DrawImage(Image.FromFile(caminho), margemEsq, margemSup + 5)
            grafico.DrawLine(Pens.Black, margemEsq, margemSup + 60, margemDir, margemSup + 60)
            linhaAtual = 4
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            grafico.DrawString("n", FonteMensagem3, Brushes.Blue, margemEsq, posicaoDaLinha)
            grafico.DrawString("Amortization", FonteMensagem3, Brushes.Blue, margemEsq + 50, posicaoDaLinha)
            grafico.DrawString("Interest", FonteMensagem3, Brushes.Blue, margemEsq + 160, posicaoDaLinha)
            grafico.DrawString("Instalment", FonteMensagem3, Brushes.Blue, margemEsq + 250, posicaoDaLinha)
            grafico.DrawString("Balance Debtor", FonteMensagem3, Brushes.Blue, margemEsq + 360, posicaoDaLinha)
            grafico.DrawLine(Pens.Black, margemEsq, 197, margemDir, 197)
            linhaAtual = 1
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            If rdo_sistema_sac.Checked = True Then
                grafico.DrawString("Constant Amortization", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
            ElseIf rdo_sistema_americano.Checked = True Then
                grafico.DrawString("American System", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
            ElseIf rdo_sistema_frances.Checked = True Then
                grafico.DrawString("French System", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
            ElseIf rdo_sistema_price.Checked = True Then
                grafico.DrawString("Price System", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
            ElseIf rdo_sistema_alemao.Checked = True Then
                grafico.DrawString("German System", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
            ElseIf rdo_sistema_sam.Checked = True Then
                grafico.DrawString("Amortization Mixed", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
            ElseIf rdo_sistema_spv.Checked = True Then
                grafico.DrawString("Variable Payments", FonteMensagem, Brushes.Blue, ((margemDir - margemEsq) / 2) + 100, posicaoDaLinha)
            End If
            linhaAtual = 4
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            If rdo_sistema_americano.Checked = True Then
                grafico.DrawString("Future Value", FonteMensagem3, Brushes.Blue, margemEsq + 500, posicaoDaLinha)
            Else
                grafico.DrawString("Balance Corrected", FonteMensagem3, Brushes.Blue, margemEsq + 500, posicaoDaLinha)
            End If
            'Títulos
            linhaAtual = 5
            posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
            While linhaAtual < linhasPorPagina
                If rdo_tabela_1.Checked = True Then
                    If i <= lista_emprestimos.Items.Count - 1 Then
                        grafico.DrawString(lista_emprestimos.Items.Item(i).Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos.Items.Item(i).SubItems.Item(1).Text, FonteMensagem3, Brushes.Black, margemEsq + 50, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos.Items.Item(i).SubItems.Item(2).Text, FonteMensagem3, Brushes.Black, margemEsq + 160, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos.Items.Item(i).SubItems.Item(3).Text, FonteMensagem3, Brushes.Black, margemEsq + 250, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos.Items.Item(i).SubItems.Item(4).Text, FonteMensagem3, Brushes.Black, margemEsq + 360, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos.Items.Item(i).SubItems.Item(4).Text, FonteMensagem3, Brushes.Black, margemEsq + 500, posicaoDaLinha)
                    End If
                ElseIf rdo_tabela_2.Checked = True Then
                    If i <= lista_emprestimos_2.Items.Count - 1 Then
                        grafico.DrawString(lista_emprestimos_2.Items.Item(i).Text, FonteMensagem3, Brushes.Black, margemEsq, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos_2.Items.Item(i).SubItems.Item(1).Text, FonteMensagem3, Brushes.Black, margemEsq + 50, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos_2.Items.Item(i).SubItems.Item(2).Text, FonteMensagem3, Brushes.Black, margemEsq + 160, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos_2.Items.Item(i).SubItems.Item(3).Text, FonteMensagem3, Brushes.Black, margemEsq + 250, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos_2.Items.Item(i).SubItems.Item(4).Text, FonteMensagem3, Brushes.Black, margemEsq + 360, posicaoDaLinha)
                        grafico.DrawString(lista_emprestimos_2.Items.Item(i).SubItems.Item(4).Text, FonteMensagem3, Brushes.Black, margemEsq + 500, posicaoDaLinha)
                    End If
                End If

                linhaAtual += 1
                posicaoDaLinha = margemSup + (linhaAtual * FonteMensagem3.GetHeight(e.Graphics))
                i += 1
            End While
            
            e.Graphics.DrawLine(Pens.Black, margemEsq, margemInf, margemDir, margemInf)
            e.Graphics.DrawString(System.DateTime.Now, FonteMensagem2, Brushes.Black, margemEsq, margemInf, New StringFormat())
            e.Graphics.DrawString("Pag. " & pagina.ToString, FonteMensagem2, Brushes.Black, margemDir - 50, margemInf, New StringFormat())

            pagina += 1

            If i <= lista_emprestimos.Items.Count - 1 Then
                e.HasMorePages = True
            Else
                i = 0
                pagina = 1
                e.HasMorePages = False
            End If
        End If
Exit_PrintDocument_ef_PrintPage:
        Exit Sub

Err_PrintDocument_ef_PrintPage:
        MsgBox(Err.Description)
        Resume Exit_PrintDocument_ef_PrintPage
    End Sub

    'IMPRESSÃO TABELA

    Private Sub rdo_sistema_sac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_sistema_sac.CheckedChanged
        Try
            If rdo_sistema_sac.Checked = True Then
                GrupoResiduo.Enabled = True
                GrupoIntermediaria.Enabled = True
                GrupoPosFixado.Enabled = True
                GrupoPgtoForaPrazo.Enabled = True
                rdo_juros_cdc_asd.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_sistema_americano_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_sistema_americano.CheckedChanged
        Try
            If rdo_sistema_americano.Checked = True Then
                GrupoResiduo.Enabled = False
                GrupoIntermediaria.Enabled = False
                GrupoPosFixado.Enabled = False
                GrupoPgtoForaPrazo.Enabled = False
                rdo_juros_cdc_asd.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_sistema_frances_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_sistema_frances.CheckedChanged
        Try
            If rdo_sistema_frances.Checked = True Then
                GrupoResiduo.Enabled = True
                GrupoIntermediaria.Enabled = True
                GrupoPosFixado.Enabled = True
                GrupoPgtoForaPrazo.Enabled = True
                rdo_juros_cdc_asd.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_sistema_price_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_sistema_price.CheckedChanged
        Try
            If rdo_sistema_price.Checked = True Then
                GrupoResiduo.Enabled = True
                GrupoIntermediaria.Enabled = True
                GrupoPosFixado.Enabled = True
                GrupoPgtoForaPrazo.Enabled = True
                rdo_juros_cdc_asd.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_sistema_alemao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_sistema_alemao.CheckedChanged
        Try
            If rdo_sistema_alemao.Checked = True Then
                GrupoResiduo.Enabled = False
                GrupoIntermediaria.Enabled = False
                GrupoPosFixado.Enabled = True
                GrupoPgtoForaPrazo.Enabled = False
                rdo_juros_cdc_asd.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_sistema_sam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_sistema_sam.CheckedChanged
        Try
            If rdo_sistema_sam.Checked = True Then
                GrupoResiduo.Enabled = True
                GrupoIntermediaria.Enabled = True
                GrupoPosFixado.Enabled = True
                GrupoPgtoForaPrazo.Enabled = True
                rdo_juros_cdc_asd.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_sistema_spv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_sistema_spv.CheckedChanged
        Try
            If rdo_sistema_spv.Checked = True Then
                GrupoResiduo.Enabled = True
                GrupoIntermediaria.Enabled = False
                GrupoPosFixado.Enabled = True
                GrupoPgtoForaPrazo.Enabled = True
                rdo_juros_cdc_asd.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_adicionar_indices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_indices.Click
        On Error GoTo Err_adicionar_indices_spv_Click
        Dim i As Integer
        For i = 1 To caixatexto_tempo.Text
            dgv_emprestimos_indices.Rows.Add()
        Next
        For i = 0 To caixatexto_tempo.Text - 1
            dgv_emprestimos_indices.Rows.Item(i).Cells.Item(0).Value = i + 1
        Next
        btn_adicionar_indices.Enabled = False
        btn_remover_indices.Enabled = True
        btn_ok_ef.Enabled = True
Exit_adicionar_indices_spv_Click:
        Exit Sub

Err_adicionar_indices_spv_Click:
        MsgBox(Err.Description)
        Resume Exit_adicionar_indices_spv_Click
    End Sub

    Private Sub btn_remover_indices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_remover_indices.Click
        On Error GoTo Err_remover_indices_spv_Click
        Dim i As Integer
        For i = 1 To caixatexto_tempo.Text
            dgv_emprestimos_indices.Rows.RemoveAt(0)
        Next
        btn_remover_indices.Enabled = False
        btn_adicionar_indices.Enabled = True
        btn_ok_ef.Enabled = False
Exit_remover_indices_spv_Click:
        Exit Sub

Err_remover_indices_spv_Click:
        MsgBox(Err.Description)
        Resume Exit_remover_indices_spv_Click
    End Sub

    Private Sub btn_adicionar_periodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adicionar_periodo.Click
        On Error GoTo Err_adicionar_periodo_spv_Click
        Dim i As Integer
        For i = 0 To caixatexto_total_n.Text
            dgv_emprestimos_periodo.Rows.Add()
        Next
        For i = 0 To caixatexto_total_n.Text
            dgv_emprestimos_periodo.Rows.Item(i).Cells.Item(0).Value = i
        Next
        btn_adicionar_periodo.Enabled = False
        btn_remover_periodo.Enabled = True
Exit_adicionar_periodo_spv_Click:
        Exit Sub

Err_adicionar_periodo_spv_Click:
        MsgBox(Err.Description)
        Resume Exit_adicionar_periodo_spv_Click
    End Sub

    Private Sub btn_remover_periodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_remover_periodo.Click
        On Error GoTo Err_remover_periodo_spv_Click
        Dim i As Integer
        For i = 0 To caixatexto_total_n.Text
            dgv_emprestimos_periodo.Rows.RemoveAt(0)
        Next
        btn_remover_periodo.Enabled = False
        btn_adicionar_periodo.Enabled = True
Exit_remover_periodo_spv_Click:
        Exit Sub

Err_remover_periodo_spv_Click:
        MsgBox(Err.Description)
        Resume Exit_remover_periodo_spv_Click
    End Sub

    Private Sub btn_ok_ef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok_ef.Click
        Try
            Dim i As Integer
            For i = 0 To caixatexto_tempo.Text - 1
                dgv_emprestimos_indices.Rows.Item(i).Cells.Item(1).Value = caixatexto_tr_ef.Text
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_tr_ef_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tr_ef.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_salvar_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salvar_excel.Click
        Try
            Dim n As Double
            If caixatexto_total_n.Text <> "" Then
                n = caixatexto_total_n.Text
            Else
                MsgBox("Prazo não foi inserido.", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            If rdo_tabela_1.Checked = True Then
                If lista_emprestimos.Items.Count <= 0 Then
                    MsgBox("É necessário calcular a tabela 1", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            ElseIf rdo_tabela_2.Checked = True Then
                If lista_emprestimos_2.Items.Count <= 0 Then
                    MsgBox("É necessário calcular a tabela 2", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            End If
            EmpFinSaveFileDialog.Filter = "Excel File (*.xls) |*.xls | Excel Workbook (*.xlsx) |*.xlsx"
            EmpFinSaveFileDialog.Title = "Salvar tabela em excel"
            EmpFinSaveFileDialog.ShowDialog()
            If EmpFinSaveFileDialog.FileName <> "" Then
                EmpFinExcel(EmpFinSaveFileDialog.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Public Sub EmpFinExcel(ByVal nome As String)
        Dim i As Integer
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim EApp As New Microsoft.Office.Interop.Excel.Application
        Dim Ewkb As Microsoft.Office.Interop.Excel.Workbook = EApp.Workbooks.Add
        Dim Ewks As Microsoft.Office.Interop.Excel.Worksheet = Ewkb.Worksheets.Add
        Dim n As Double
        n = caixatexto_total_n.Text
        If n > 0 Then
            EApp.UserControl = True
            If rdo_sistema_sac.Checked = True Then
                Ewks.Name = "CAS"
            ElseIf rdo_sistema_americano.Checked = True Then
                Ewks.Name = "AmericanSystem"
            ElseIf rdo_sistema_frances.Checked = True Then
                Ewks.Name = "FrenchSystem"
            ElseIf rdo_sistema_price.Checked = True Then
                Ewks.Name = "PriceSystem"
            ElseIf rdo_sistema_alemao.Checked = True Then
                Ewks.Name = "GermanSystem"
            ElseIf rdo_sistema_sam.Checked = True Then
                Ewks.Name = "ASJ"
            ElseIf rdo_sistema_spv.Checked = True Then
                Ewks.Name = "PSV"
            End If
            Ewks.Range("A1", "F" & n + 3).Font.Size = 10

            Ewks.Cells(1, 1) = "n"
            Ewks.Cells(1, 2) = "Amortization"
            Ewks.Cells(1, 3) = "Interest"
            Ewks.Cells(1, 4) = "Instalment"
            Ewks.Cells(1, 5) = "Balance Debtor"
            Ewks.Cells(1, 6) = "Balance Corrected"
            For i = 0 To n + 1
                If rdo_tabela_1.Checked = True Then
                    Ewks.Cells(i + 2, 1) = i
                    Ewks.Cells(i + 2, 2) = lista_emprestimos.Items.Item(i).SubItems.Item(1).Text
                    Ewks.Cells(i + 2, 3) = lista_emprestimos.Items.Item(i).SubItems.Item(2).Text
                    Ewks.Cells(i + 2, 4) = lista_emprestimos.Items.Item(i).SubItems.Item(3).Text
                    Ewks.Cells(i + 2, 5) = lista_emprestimos.Items.Item(i).SubItems.Item(4).Text
                    Ewks.Cells(i + 2, 6) = lista_emprestimos.Items.Item(i).SubItems.Item(5).Text
                ElseIf rdo_tabela_2.Checked = True Then
                    Ewks.Cells(i + 2, 1) = i
                    Ewks.Cells(i + 2, 2) = lista_emprestimos_2.Items.Item(i).SubItems.Item(1).Text
                    Ewks.Cells(i + 2, 3) = lista_emprestimos_2.Items.Item(i).SubItems.Item(2).Text
                    Ewks.Cells(i + 2, 4) = lista_emprestimos_2.Items.Item(i).SubItems.Item(3).Text
                    Ewks.Cells(i + 2, 5) = lista_emprestimos_2.Items.Item(i).SubItems.Item(4).Text
                    Ewks.Cells(i + 2, 6) = lista_emprestimos_2.Items.Item(i).SubItems.Item(5).Text
                End If
            Next i
            Ewks.SaveAs(nome)
            EApp.Quit()

            EApp = Nothing
            Ewkb = Nothing
            Ewks = Nothing
            'System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
        Else
            MsgBox("Número da parcela incorreto ou não preenchido.", MsgBoxStyle.OkOnly, "ProFinanceira")
        End If
    End Sub
End Class