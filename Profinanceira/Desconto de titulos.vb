Imports System.Windows.Forms
Public Class form_descontos_titulos

    Private Sub caixatexto_vt_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vt_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_taxa_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tempo_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tempo_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_desconto_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_desconto_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vd_sem_encargos_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vd_sem_encargos_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vd_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vd_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_aparente_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_aparente_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_real_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_real_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_inflacao_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_inflacao_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_calcular_dt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_dt.Click
        On Error GoTo Err_calcular_dt_Click
        'COMEÇA DESCONTO DE TÍTULOS
        If rdo_dt_dt.Checked = True Then
            'VALOR DO TÍTULO
            If rdo_vt_dt.Checked = True Then
                If caixatexto_desconto_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    Dim num1 As Short = caixatexto_desconto_dt.Text
                    Dim num2 As Short = caixatexto_vd_dt.Text
                    caixatexto_vt_dt.Text = num1 + num2
                ElseIf caixatexto_desconto_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" _
                And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_vt_dt.Text = caixatexto_desconto_dt.Text / ((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text)
                ElseIf caixatexto_vd_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_vt_dt.Text = caixatexto_vd_dt.Text / (1 - ((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text))
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
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
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'PARCELAS(N)
            ElseIf rdo_tempo_dt.Checked = True Then
                If caixatexto_desconto_dt.Text <> "" And caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" Then
                    caixatexto_tempo_dt.Text = caixatexto_desconto_dt.Text / (caixatexto_vt_dt.Text * (caixatexto_taxa_dt.Text / 100))
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_tempo_dt.Text = (caixatexto_vd_dt.Text - caixatexto_vt_dt.Text) / (-1 * caixatexto_vt_dt.Text * (caixatexto_taxa_dt.Text / 100))
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'DESCONTO
            ElseIf rdo_desconto_dt.Checked = True Then
                If caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" And caixatexto_taxa_administracao_dt.Text <> "" Then
                    Dim taxa_adm As Double = caixatexto_taxa_administracao_dt.Text
                    caixatexto_desconto_dt.Text = caixatexto_vt_dt.Text * ((caixatexto_taxa_dt.Text * caixatexto_tempo_dt.Text) + (taxa_adm / 100))
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_desconto_dt.Text = caixatexto_vt_dt.Text * (caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_desconto_dt.Text = caixatexto_vt_dt.Text - caixatexto_vd_dt.Text
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'VALOR DESCONTADO
            ElseIf rdo_vd_dt.Checked = True Then
                If caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" And caixatexto_taxa_administracao_dt.Text <> "" Then
                    Dim taxa_adm As Double = caixatexto_taxa_administracao_dt.Text
                    caixatexto_vd_dt.Text = caixatexto_vt_dt.Text * (1 - (((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text) + (taxa_adm / 100)))
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_desconto_dt.Text <> "" Then
                    caixatexto_vd_dt.Text = caixatexto_vt_dt.Text - caixatexto_desconto_dt.Text
                ElseIf caixatexto_vt_dt.Text <> "" And caixatexto_taxa_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" Then
                    caixatexto_vd_dt.Text = caixatexto_vt_dt.Text * (1 - ((caixatexto_taxa_dt.Text / 100) * caixatexto_tempo_dt.Text))
                ElseIf caixatexto_vd_sem_encargos_dt.Text <> "" And caixatexto_iof_dt.Text <> "" _
                And caixatexto_tarifa_dt.Text <> "" And caixatexto_tac_dt.Text <> "" And caixatexto_outros_encargos_dt.Text <> "" Then
                    Dim valor1, valor2, valor3, valor4 As Double
                    valor1 = caixatexto_iof_dt.Text
                    valor2 = caixatexto_tarifa_dt.Text
                    valor3 = caixatexto_tac_dt.Text
                    valor4 = caixatexto_outros_encargos_dt.Text
                    caixatexto_vd_dt.Text = caixatexto_vd_sem_encargos_dt.Text + (valor1 + valor2 + valor3 + valor4)
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'VALOR DESCONTADO SEM ENCARGOS
            ElseIf rdo_sem_encargos_dt.Checked = True Then
                If caixatexto_vd_dt.Text <> "" And caixatexto_iof_dt.Text <> "" And caixatexto_tarifa_dt.Text <> "" _
                And caixatexto_tac_dt.Text <> "" And caixatexto_outros_encargos_dt.Text <> "" Then
                    Dim num1 As Double = caixatexto_iof_dt.Text
                    Dim num2 As Double = caixatexto_tarifa_dt.Text
                    Dim num3 As Double = caixatexto_tac_dt.Text
                    Dim num4 As Double = caixatexto_outros_encargos_dt.Text
                    caixatexto_vd_sem_encargos_dt.Text = caixatexto_vd_dt.Text - (num1 + num2 + num3 + num4)
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'CÁLCULO DO IOF
            ElseIf rdo_iof_dt.Checked = True Then
                If caixatexto_vd_dt.Text <> "" And caixatexto_tempo_dt.Text <> "" And caixatexto_taxa_iof_dt.Text <> "" Then
                    caixatexto_iof_dt.Text = caixatexto_vd_dt.Text * (caixatexto_taxa_iof_dt.Text / 100) * caixatexto_tempo_dt.Text
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'CUSTO EFETIVO DA OPERAÇÃO
            ElseIf rdo_custo_efetivo_dt.Checked = True Then
                If caixatexto_vt_dt.Text <> "" And caixatexto_vd_dt.Text <> "" Then
                    caixatexto_custo_efetivo_dt.Text = ((caixatexto_vt_dt.Text - caixatexto_vd_dt.Text) / caixatexto_vd_dt.Text) * 100
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
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
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'TAXA REAL
            ElseIf rdo_taxa_real_dt.Checked = True Then
                If caixatexto_aparente_dt.Text <> "" And caixatexto_inflacao_dt.Text <> "" Then
                    caixatexto_real_dt.Text = (((1 + (caixatexto_aparente_dt.Text / 100)) / (1 + (caixatexto_inflacao_dt.Text / 100))) - 1) * 100
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'TAXA DE INFLAÇÃO
            ElseIf rdo_taxa_inflacao_dt.Checked = True Then
                If caixatexto_real_dt.Text <> "" And caixatexto_aparente_dt.Text <> "" Then
                    caixatexto_inflacao_dt.Text = (((1 + (caixatexto_aparente_dt.Text / 100)) / (1 + (caixatexto_real_dt.Text / 100))) - 1) * 100
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'TAXA ACUMULADA
            ElseIf rdo_taxa_acumulada_dt.Checked = True Then
                If dgv_rentabilidade_dt.Rows.Count <> 0 Then
                    Dim item(0 To dgv_rentabilidade_dt.Rows.Count) As Double
                    Dim i As Integer, item2 As Double
                    For i = 0 To dgv_rentabilidade_dt.Rows.Count - 2
                        item(i) = dgv_rentabilidade_dt.Rows.Item(i).Cells.Item(0).Value
                    Next
                    item2 = 1 + (item(0) / 100)
                    For i = 1 To dgv_rentabilidade_dt.Rows.Count - 2
                        item2 = item2 * (1 + (item(i) / 100))
                    Next
                    caixatexto_acumulada_dt.Text = (item2 - 1) * 100
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
            End If
        End If
Exit_calcular_dt_Click:
        Exit Sub

Err_calcular_dt_Click:
        MsgBox(Err.Description)
        Resume Exit_calcular_dt_Click
    End Sub

    Private Sub caixatexto_iof_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_iof_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tarifa_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tarifa_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tac_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tac_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_outros_encargos_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_outros_encargos_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_taxa_iof_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_iof_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub rdo_dt_dt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_dt_dt.CheckedChanged
        Try
            If rdo_dt_dt.Checked = True Then
                RichTextBox_leitura_dt.Text = "Formulas to calculate the value title:" & vbNewLine & vbNewLine _
                & "1. Discount + Discounted Value" & vbNewLine _
                & "2. Discount / (rate * n)" & vbNewLine _
                & "3. Discounted Value / (1 - (rate * n))" & vbNewLine & vbNewLine _
                    & "Formulas to calculate the interest rate:" & vbNewLine & vbNewLine _
                    & "1. Discount / (Value Title * n)" & vbNewLine _
                    & "2. (Discounted Value - Value Title) / (-(Value Title * n))" & vbNewLine & vbNewLine _
                    & "Formula to calculate the cost effective operation:" & vbNewLine & vbNewLine _
                    & "1. (Value Title - Discounted Value) / Discounted Value" & vbNewLine & vbNewLine _
                    & "Formulas to calculate the deadline:" & vbNewLine & vbNewLine _
                    & "1. Discount / (Value Title * rate)" & vbNewLine _
                    & "2. (Discounted Value - Value Title) / (-Value Title * rate)" & vbNewLine & vbNewLine _
                    & "Formulas to calculate the discount:" & vbNewLine & vbNewLine _
                    & "1. Value Title * ((rate * n) + management fee)" & vbNewLine _
                    & "2. Value Title * rate * n" & vbNewLine _
                    & "3. Value Title - Discounted Value" & vbNewLine & vbNewLine _
                    & "Formulas to calculate the discounted value:" & vbNewLine & vbNewLine _
                    & "1. Value Title * (1 - ((rate * n) + management fee))" & vbNewLine _
                    & "2. Value Title - Discount" & vbNewLine _
                    & "3. Value Title * (1 - (rate * n))" & vbNewLine _
                    & "4. Discounted Value without charges + (TFT + Tariff + RCO + Other charges)" & vbNewLine & vbNewLine _
                    & "Formula to calculate the Discounted Value without charges:" & vbNewLine & vbNewLine _
                    & "1. Discounted Value - (TFT + Tariff + RCO + Other charges)" & vbNewLine & vbNewLine _
                    & "Formula to calculate the Tax on Financial Transactions (TFT):" & vbNewLine & vbNewLine _
                    & "1. Discounted Value * Rate TFT * n"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_taxa_ari_dt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_taxa_ari_dt.CheckedChanged
        Try
            If rdo_taxa_ari_dt.Checked = True Then
                RichTextBox_leitura_dt.Text = "Formula to calculate the apparent rate, real rate and inflation rate:" & vbNewLine & vbNewLine _
                & "(1 + apparent rate) = (1 + real rate) * (1 + inflation rate)" & vbNewLine & vbNewLine _
                & "Formula to calculate the accumulated rate:" & vbNewLine & vbNewLine _
                & "(1 + accumulated rate) = (1 + rate) * (1 + rate) ... * (1 + rate)"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_taxa_administracao_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_administracao_dt.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_imprimir_dt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir_dt.Click
        Try
            If PrintDialog_dt.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PrintDialog_dt.Document = PrintDocument_dt
                PrintDocument_dt.Print()
            Else
                Dim canelado As String = "cancelado"
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error printing")
        End Try
    End Sub

    Private Sub btn_visualizar_impressao_dt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_visualizar_impressao_dt.Click
        Dim documento As New profinanceira_inicio
        Try
            Dim printPreviewDialog_principal As New PrintPreviewDialog()
            With printPreviewDialog_principal
                .Document = PrintDocument_dt
                .Text = "ProFinanceira - Visualization"
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .ShowDialog()
            End With
        Catch exp As Exception
            MsgBox(exp.Message.ToString, MsgBoxStyle.Critical, "Error in print preview")
        End Try
    End Sub

    Private Sub PrintDocument_principal_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument_dt.PrintPage
        On Error GoTo Err_PrintDocument_principal_PrintPage
        Dim imprimir As New Impressao

        imprimir.impressaoDescontosTitulos(sender, e)

Exit_PrintDocument_principal_PrintPage:
        Exit Sub

Err_PrintDocument_principal_PrintPage:
        MsgBox(Err.Description)
        Resume Exit_PrintDocument_principal_PrintPage
    End Sub
End Class