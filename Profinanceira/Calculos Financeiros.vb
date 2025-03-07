Public Class form_calculos_financeiros

    Private Sub caixatexto_vp_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vp_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tempo_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tempo_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_pmt_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_pmt_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vf_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vf_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_eq_i_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_eq_i_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_dias_uteis_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_dias_uteis_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_taxa_reinvestimento_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_reinvestimento_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vpl2_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vpl2_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tir2_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tir2_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tirm_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tirm_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_il_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_il_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_payback_simples_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_payback_simples_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_payback_descontado_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_payback_descontado_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_calcular_eq_taxa_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_eq_taxa_cfin.Click
        On Error GoTo Err_calcular_eq_taxa_cfin_Click
        Dim compostos As New EquivalenciaDeTaxa()
        Dim taxa As Double, tempo1 As String, tempo2 As String, dia_util As Double
        tempo1 = combo_taxa_cfin.SelectedItem
        tempo2 = combo_tempo_cfin.SelectedItem
        taxa = caixatexto_eq_i_cfin.Text
        dia_util = caixatexto_dias_uteis_cfin.Text
        caixatexto_eq_taxa_cfin.Text = compostos.JurosCompostos(taxa, tempo1, tempo2, dia_util)
        caixatexto_transformar_percentual.Text = (caixatexto_eq_taxa_cfin.Text * 100)
Exit_calcular_eq_taxa_cfin_Click:
        Exit Sub

Err_calcular_eq_taxa_cfin_Click:
        MsgBox(Err.Description)
        Resume Exit_calcular_eq_taxa_cfin_Click
    End Sub

    Private Sub caixacombo_decimais_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_casas_decimais_cfin.SelectedIndexChanged
        If caixatexto_eq_taxa_cfin.Text <> "" Then
            If caixacombo_casas_decimais_cfin.Text <> "" Then
                Dim num1 As Integer
                num1 = caixacombo_casas_decimais_cfin.Text
                caixatexto_eq_taxa_cfin.Text = Decimal.Round(caixatexto_eq_taxa_cfin.Text, num1, MidpointRounding.ToEven)
                caixatexto_transformar_percentual.Text = Decimal.Round(caixatexto_transformar_percentual.Text, num1, MidpointRounding.ToEven)
            End If
        End If
    End Sub

    Private Sub caixatexto_eq_i_cfin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_eq_i_cfin.TextChanged
        Try
            If caixatexto_eq_i_cfin.Text <> "" Then
                btn_calcular_eq_taxa_cfin.Enabled = True
            Else
                btn_calcular_eq_taxa_cfin.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_calcular_taxa_simples_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_taxa_simples_cfin.Click
        On Error GoTo Err_calcular_taxa_simples_cfin_Click
        Dim simples As New EquivalenciaDeTaxa()
        Dim taxa As Double, tempo1 As String, tempo2 As String, dia_util As Double
        tempo1 = combo_taxa_cfin.SelectedItem
        tempo2 = combo_tempo_cfin.SelectedItem
        taxa = caixatexto_eq_i_simples_cfin.Text
        dia_util = caixatexto_dias_uteis_cfin.Text
        caixatexto_eq_taxa_simples_cfin.Text = simples.JurosSimples(taxa, tempo1, tempo2, dia_util)
        caixatexto_transformar_percentual_simples.Text = (caixatexto_eq_taxa_simples_cfin.Text * 100)
Exit_calcular_taxa_simples_cfin_Click:
        Exit Sub

Err_calcular_taxa_simples_cfin_Click:
        MsgBox(Err.Description)
        Resume Exit_calcular_taxa_simples_cfin_Click
    End Sub

    Private Sub caixatexto_eq_i_simples_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_eq_i_simples_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_eq_i_simples_cfin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_eq_i_simples_cfin.TextChanged
        Try
            If caixatexto_eq_i_simples_cfin.Text <> "" Then
                btn_calcular_taxa_simples_cfin.Enabled = True
            Else
                btn_calcular_taxa_simples_cfin.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixacombo_casas_decimais_simples_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_casas_decimais_simples_cfin.SelectedIndexChanged
        Try
            If caixatexto_eq_taxa_simples_cfin.Text <> "" Then
                If caixacombo_casas_decimais_simples_cfin.Text <> "" Then
                    Dim num1 As Integer
                    num1 = caixacombo_casas_decimais_simples_cfin.Text
                    caixatexto_eq_taxa_simples_cfin.Text = Decimal.Round(caixatexto_eq_taxa_simples_cfin.Text, num1, MidpointRounding.ToEven)
                    caixatexto_transformar_percentual_simples.Text = Decimal.Round(caixatexto_transformar_percentual_simples.Text, num1, MidpointRounding.ToEven)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_montante_juros_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_montante_juros_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_exatos_i_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exatos_i_ecb_cfin.Click
        On Error GoTo Err_exatos_i_ecb_cfin_Click
        If caixatexto_inserir_i_ecb_cfin.Text <> "" Then
            If checkbox_ano_bissexto_ecb_cfin.Checked = True Then
                'EXATOS
                caixatexto_exatos_i_ecb_cfin.Text = ((caixatexto_inserir_i_ecb_cfin.Text / 100) / 366)
                'COMERCIAIS
                caixatexto_comercial_i_ecb_cfin.Text = ((caixatexto_inserir_i_ecb_cfin.Text / 100) / 360)
                'BANCÁRIOS
                caixatexto_bancarios_i_ecb_cfin.Text = ((caixatexto_inserir_i_ecb_cfin.Text / 100) / 360)
                Exit Sub
            End If
            'EXATOS
            caixatexto_exatos_i_ecb_cfin.Text = ((caixatexto_inserir_i_ecb_cfin.Text / 100) / 365)
            'COMERCIAIS
            caixatexto_comercial_i_ecb_cfin.Text = ((caixatexto_inserir_i_ecb_cfin.Text / 100) / 360)
            'BANCÁRIOS
            caixatexto_bancarios_i_ecb_cfin.Text = ((caixatexto_inserir_i_ecb_cfin.Text / 100) / 360)
        Else
            MsgBox("There is no value to be calculated!", MsgBoxStyle.OkOnly, "ProFinanceira")
        End If
Exit_exatos_i_ecb_cfin_Click:
        Exit Sub

Err_exatos_i_ecb_cfin_Click:
        MsgBox(Err.Description)
        Resume Exit_exatos_i_ecb_cfin_Click
    End Sub

    Private Sub btn_comercial_n_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comercial_n_ecb_cfin.Click
        On Error GoTo Err_comercial_n_ecb_cfin_Click
        'EXATOS
        Dim ate As DateTime = data_ate.Text
        Dim de As DateTime = data_de.Text
        Dim subtracao As TimeSpan
        subtracao = ate.Subtract(data_de.Text)
        caixatexto_exatos_n_ecb_cfin.Text = subtracao.Days
        'COMERCIAIS
        Dim subtracao_mes As Integer, subtracao_dia As Integer
        Dim subtracao_ano As Integer
        Dim mes1 As Integer, dia1 As Integer, ano1 As Integer
        Dim mes2 As Integer, dia2 As Integer, ano2 As Integer
        mes1 = de.Month
        mes2 = ate.Month
        dia1 = de.Day
        dia2 = ate.Day
        ano1 = de.Year
        ano2 = ate.Year
        subtracao_mes = mes2 - mes1
        subtracao_dia = dia2 - dia1
        subtracao_ano = ano2 - ano1
        caixatexto_comercial_n_ecb_cfin.Text = (subtracao_mes * 30) + subtracao_dia + (subtracao_ano * 360)
        'BANCÁRIOS
        subtracao = ate.Subtract(data_de.Text)
        caixatexto_bancarios_n_ecb_cfin.Text = subtracao.Days
Exit_comercial_n_ecb_cfin_Click:
        Exit Sub

Err_comercial_n_ecb_cfin_Click:
        MsgBox(Err.Description)
        Resume Exit_comercial_n_ecb_cfin_Click
    End Sub

    Private Sub btn_bancarios_n_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bancarios_juros_ecb_cfin.Click
        On Error GoTo Err_bancarios_n_ecb_cfin_Click
        If caixatexto_vp_cfin.Text = "" Or caixatexto_exatos_i_ecb_cfin.Text = "" _
        Or caixatexto_exatos_n_ecb_cfin.Text = "" Or caixatexto_comercial_i_ecb_cfin.Text = "" _
        Or caixatexto_comercial_n_ecb_cfin.Text = "" Or caixatexto_bancarios_i_ecb_cfin.Text = "" _
        Or caixatexto_bancarios_n_ecb_cfin.Text = "" Then
            MsgBox("There is no present value filled", MsgBoxStyle.OkOnly, "Present Value")
            Exit Sub
        End If
        'EXATOS
        caixatexto_juros_exatos_cfin.Text = caixatexto_vp_cfin.Text * caixatexto_exatos_i_ecb_cfin.Text * caixatexto_exatos_n_ecb_cfin.Text
        'COMERCIAIS
        caixatexto_juros_comerciais_cfin.Text = caixatexto_vp_cfin.Text * caixatexto_comercial_i_ecb_cfin.Text * caixatexto_comercial_n_ecb_cfin.Text
        'BANCÁRIOS
        caixatexto_juros_bancarios_cfin.Text = caixatexto_vp_cfin.Text * caixatexto_bancarios_i_ecb_cfin.Text * caixatexto_bancarios_n_ecb_cfin.Text
Exit_bancarios_n_ecb_cfin_Click:
        Exit Sub

Err_bancarios_n_ecb_cfin_Click:
        MsgBox(Err.Description)
        Resume Exit_bancarios_n_ecb_cfin_Click
    End Sub

    Private Sub btn_limpar_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpar_ecb_cfin.Click
        On Error GoTo Err_limpar_ecb_cfin_Click
        caixatexto_exatos_i_ecb_cfin.Text = ""
        caixatexto_exatos_n_ecb_cfin.Text = ""
        caixatexto_comercial_i_ecb_cfin.Text = ""
        caixatexto_comercial_n_ecb_cfin.Text = ""
        caixatexto_bancarios_i_ecb_cfin.Text = ""
        caixatexto_bancarios_n_ecb_cfin.Text = ""
        caixatexto_juros_exatos_cfin.Text = ""
        caixatexto_juros_comerciais_cfin.Text = ""
        caixatexto_juros_bancarios_cfin.Text = ""
Exit_limpar_ecb_cfin_Click:
        Exit Sub

Err_limpar_ecb_cfin_Click:
        MsgBox(Err.Description)
        Resume Exit_limpar_ecb_cfin_Click
    End Sub

    Private Sub caixacombo_exatos_i_ecb_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_exatos_i_ecb_cfin.SelectedIndexChanged
        Try
            If caixatexto_exatos_i_ecb_cfin.Text <> "" Then
                Dim num1 As Integer
                If caixacombo_exatos_i_ecb_cfin.Text <> "" Then
                    num1 = caixacombo_exatos_i_ecb_cfin.Text
                    caixatexto_exatos_i_ecb_cfin.Text = Decimal.Round(caixatexto_exatos_i_ecb_cfin.Text, num1, MidpointRounding.ToEven)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixacombo_comercial_i_ecb_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_comercial_i_ecb_cfin.SelectedIndexChanged
        Try
            If caixatexto_comercial_i_ecb_cfin.Text <> "" Then
                Dim num1 As Integer
                If caixacombo_comercial_i_ecb_cfin.Text <> "" Then
                    num1 = caixacombo_comercial_i_ecb_cfin.Text
                    caixatexto_comercial_i_ecb_cfin.Text = Decimal.Round(caixatexto_comercial_i_ecb_cfin.Text, num1, MidpointRounding.ToEven)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixacombo_bancarios_i_ecb_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_bancarios_i_ecb_cfin.SelectedIndexChanged
        Try
            If caixatexto_bancarios_i_ecb_cfin.Text <> "" Then
                Dim num1 As Integer
                If caixacombo_bancarios_i_ecb_cfin.Text <> "" Then
                    num1 = caixacombo_bancarios_i_ecb_cfin.Text
                    caixatexto_bancarios_i_ecb_cfin.Text = Decimal.Round(caixatexto_bancarios_i_ecb_cfin.Text, num1, MidpointRounding.ToEven)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_calcular_ano_bissexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_ano_bissexto.Click
        On Error GoTo Err_calcular_ano_bissexto_Click
        Dim ate As DateTime = data_ate.Text
        Dim de As DateTime = data_de.Text
        Dim ano_bissexto As Boolean = Date.IsLeapYear(ate.Year)
        Dim ano2_bissexto As Boolean = Date.IsLeapYear(de.Year)
        Dim bissexto As Integer, i As Integer
        bissexto = de.Year
        For i = de.Year To ate.Year
            If ano2_bissexto = False Then
                MsgBox("The year " & bissexto & " " & "is not a leap year")
            ElseIf ano2_bissexto = True Then
                MsgBox("The year " & bissexto & " " & "is a leap year")
            End If
            bissexto += +1
            ano2_bissexto = Date.IsLeapYear(bissexto)
        Next
Exit_calcular_ano_bissexto_Click:
        Exit Sub

Err_calcular_ano_bissexto_Click:
        MsgBox(Err.Description)
        Resume Exit_calcular_ano_bissexto_Click
    End Sub

    Private Sub btn_calcular_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_cfin.Click
        On Error GoTo Err_calcular_cfin_Click
        'COMEÇA JUROS SIMPLES
        If rdo_juros_simples_cfin.Checked = True Then
            'VALOR PRESENTE
            If rdo_vp_cfin.Checked = True Then
                If caixatexto_montante_juros_cfin.Text <> "" And caixatexto_eq_taxa_simples_cfin.Text <> 0 _
        And caixatexto_tempo_cfin.Text <> "" Then
                    caixatexto_vp_cfin.Text = caixatexto_montante_juros_cfin.Text / (caixatexto_eq_taxa_simples_cfin.Text * caixatexto_tempo_cfin.Text)
                ElseIf caixatexto_vf_cfin.Text <> "" And caixatexto_eq_taxa_simples_cfin.Text <> 0 _
                And caixatexto_tempo_cfin.Text <> "" Then
                    caixatexto_vp_cfin.Text = -1 * (caixatexto_vf_cfin.Text / (1 + (caixatexto_eq_taxa_simples_cfin.Text * caixatexto_tempo_cfin.Text)))
                ElseIf caixatexto_montante_juros_cfin.Text <> "" And caixatexto_vf_cfin.Text <> "" Then
                    caixatexto_vp_cfin.Text = caixatexto_vf_cfin.Text - caixatexto_montante_juros_cfin.Text
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'TAXA DE DESCONTO
            ElseIf rdo_taxa_cfin.Checked = True Then
                If caixatexto_montante_juros_cfin.Text <> "" And caixatexto_vp_cfin.Text <> "" _
        And caixatexto_tempo_cfin.Text <> "" Then
                    caixatexto_eq_i_simples_cfin.Text = (caixatexto_montante_juros_cfin.Text / (caixatexto_vp_cfin.Text * caixatexto_tempo_cfin.Text)) * 100
                ElseIf caixatexto_vf_cfin.Text <> "" And caixatexto_vp_cfin.Text <> "" _
                And caixatexto_tempo_cfin.Text <> "" Then
                    caixatexto_transformar_percentual_simples.Text = (((caixatexto_vf_cfin.Text / caixatexto_vp_cfin.Text) - 1) * (1 / caixatexto_tempo_cfin.Text)) * 100
                    caixatexto_eq_taxa_simples_cfin.Text = caixatexto_transformar_percentual_simples.Text / 100
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'NÚMERO DE PERÍODOS
            ElseIf rdo_n_cfin.Checked = True Then
                If caixatexto_montante_juros_cfin.Text <> "" And caixatexto_vp_cfin.Text <> "" _
        And caixatexto_eq_taxa_simples_cfin.Text <> 0 Then
                    caixatexto_tempo_cfin.Text = caixatexto_montante_juros_cfin.Text / (caixatexto_vp_cfin.Text * caixatexto_eq_taxa_simples_cfin.Text)
                ElseIf caixatexto_vf_cfin.Text <> "" And caixatexto_vp_cfin.Text <> "" _
                And caixatexto_eq_taxa_simples_cfin.Text <> 0 Then
                    caixatexto_tempo_cfin.Text = ((caixatexto_vf_cfin.Text / caixatexto_vp_cfin.Text) - 1) * (1 / caixatexto_eq_taxa_simples_cfin.Text)
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'MONTANTE DE JUROS
            ElseIf rdo_montante_cfin.Checked = True Then
                If caixatexto_eq_taxa_simples_cfin.Text <> 0 And caixatexto_vp_cfin.Text <> "" _
        And caixatexto_tempo_cfin.Text <> "" Then
                    caixatexto_montante_juros_cfin.Text = caixatexto_vp_cfin.Text * caixatexto_eq_taxa_simples_cfin.Text * caixatexto_tempo_cfin.Text
                ElseIf caixatexto_vf_cfin.Text <> "" And caixatexto_vp_cfin.Text <> "" Then
                    caixatexto_montante_juros_cfin.Text = caixatexto_vf_cfin.Text - caixatexto_vp_cfin.Text
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'VALOR FUTURO
            ElseIf rdo_vf_cfin.Checked = True Then
                Dim num1 As Double, num2 As Double
                If caixatexto_montante_juros_cfin.Text <> "" And caixatexto_vp_cfin.Text <> "" Then
                    num1 = caixatexto_vp_cfin.Text
                    num2 = caixatexto_montante_juros_cfin.Text
                    caixatexto_vf_cfin.Text = num1 + num2
                ElseIf caixatexto_eq_taxa_simples_cfin.Text <> 0 And caixatexto_vp_cfin.Text <> "" _
                And caixatexto_tempo_cfin.Text <> "" Then
                    caixatexto_vf_cfin.Text = -1 * (caixatexto_vp_cfin.Text * (1 + (caixatexto_eq_taxa_simples_cfin.Text * caixatexto_tempo_cfin.Text)))
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
                'CÁLCULO DO VPL (JUROS SIMPLES)
            ElseIf rdo_vpl2_cfin.Checked = True Then
                Dim j As Integer
                If rdo_fluxo1.Checked = True Then
                    j = 0
                ElseIf rdo_fluxo2.Checked = True Then
                    j = 1
                ElseIf rdo_fluxo3.Checked = True Then
                    j = 2
                ElseIf rdo_fluxo4.Checked = True Then
                    j = 3
                End If
                If caixatexto_eq_taxa_simples_cfin.Text <> 0 And caixatexto_investimento_cfin.Text <> "" _
                And dgv_fluxos_cf.Rows.Count > 1 Then
                    Dim varFluxos(dgv_fluxos_cf.Rows.Count) As Double
                    Dim investimento As Double = caixatexto_investimento_cfin.Text
                    fluxosVPL(varFluxos, j)
                    If j = 0 Or j = 2 Then
                        caixatexto_vpl_cfin.Text = NPV(caixatexto_eq_taxa_simples_cfin.Text, varFluxos) + investimento
                    ElseIf j = 1 Or j = 3 Then
                        caixatexto_vpl2_cfin.Text = NPV(caixatexto_eq_taxa_simples_cfin.Text, varFluxos) + investimento
                    End If
                Else
                    MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                    Exit Sub
                End If
            End If
            'COMEÇA JUROS COMPOSTOS
        ElseIf rdo_juros_compostos_cfin.Checked = True Then
            'COMEÇA FIM DO PERÍODO
            If rdo_fim_periodo_cfin.Checked = True Then
                'VALOR PRESENTE
                If rdo_vp_cfin.Checked = True Then
                    If caixatexto_tempo_cfin.Text = "" Then
                        caixatexto_tempo_cfin.Text = 0
                    End If
                    If caixatexto_pmt_cfin.Text = "" Then
                        caixatexto_pmt_cfin.Text = 0
                    End If
                    If caixatexto_vf_cfin.Text = "" Then
                        caixatexto_vf_cfin.Text = 0
                    End If
                    caixatexto_vp_cfin.Text = PV(caixatexto_eq_taxa_cfin.Text, caixatexto_tempo_cfin.Text, caixatexto_pmt_cfin.Text, caixatexto_vf_cfin.Text, DueDate.EndOfPeriod)
                    'TAXA DE JUROS
                ElseIf rdo_taxa_cfin.Checked = True Then
                    If caixatexto_tempo_cfin.Text = "" Then
                        caixatexto_tempo_cfin.Text = 0
                    End If
                    If caixatexto_pmt_cfin.Text = "" Then
                        caixatexto_pmt_cfin.Text = 0
                    End If
                    If caixatexto_vf_cfin.Text = "" Then
                        caixatexto_vf_cfin.Text = 0
                    End If
                    If caixatexto_vp_cfin.Text = "" Then
                        caixatexto_vp_cfin.Text = 0
                    End If
                    caixatexto_eq_taxa_cfin.Text = Rate(caixatexto_tempo_cfin.Text, caixatexto_pmt_cfin.Text, caixatexto_vp_cfin.Text, caixatexto_vf_cfin.Text, DueDate.EndOfPeriod)
                    caixatexto_transformar_percentual.Text = caixatexto_eq_taxa_cfin.Text * 100
                    'NÚMERO DE PERÍODOS
                ElseIf rdo_n_cfin.Checked = True Then
                    If caixatexto_pmt_cfin.Text = "" Then
                        caixatexto_pmt_cfin.Text = 0
                    End If
                    If caixatexto_vf_cfin.Text = "" Then
                        caixatexto_vf_cfin.Text = 0
                    End If
                    If caixatexto_vp_cfin.Text = "" Then
                        caixatexto_vp_cfin.Text = 0
                    End If
                    caixatexto_tempo_cfin.Text = NPer(caixatexto_eq_taxa_cfin.Text, caixatexto_pmt_cfin.Text, caixatexto_vp_cfin.Text, caixatexto_vf_cfin.Text, DueDate.EndOfPeriod)
                    'CÁLCULO DO PMT
                ElseIf rdo_pmt_cfin.Checked = True Then
                    If caixatexto_tempo_cfin.Text = "" Then
                        caixatexto_tempo_cfin.Text = 0
                    End If
                    If caixatexto_vf_cfin.Text = "" Then
                        caixatexto_vf_cfin.Text = 0
                    End If
                    If caixatexto_vp_cfin.Text = "" Then
                        caixatexto_vp_cfin.Text = 0
                    End If
                    caixatexto_pmt_cfin.Text = Pmt(caixatexto_eq_taxa_cfin.Text, caixatexto_tempo_cfin.Text, caixatexto_vp_cfin.Text, caixatexto_vf_cfin.Text, DueDate.EndOfPeriod)
                    'VALOR FUTURO
                ElseIf rdo_vf_cfin.Checked = True Then
                    If caixatexto_tempo_cfin.Text = "" Then
                        caixatexto_tempo_cfin.Text = 0
                    End If
                    If caixatexto_pmt_cfin.Text = "" Then
                        caixatexto_pmt_cfin.Text = 0
                    End If
                    If caixatexto_vp_cfin.Text = "" Then
                        caixatexto_vp_cfin.Text = 0
                    End If
                    caixatexto_vf_cfin.Text = FV(caixatexto_eq_taxa_cfin.Text, caixatexto_tempo_cfin.Text, caixatexto_pmt_cfin.Text, caixatexto_vp_cfin.Text, DueDate.EndOfPeriod)
                    'CÁLCULO DO VPL
                ElseIf rdo_vpl2_cfin.Checked = True Then
                    Dim j As Integer
                    If rdo_fluxo1.Checked = True Then
                        j = 0
                    ElseIf rdo_fluxo2.Checked = True Then
                        j = 1
                    ElseIf rdo_fluxo3.Checked = True Then
                        j = 2
                    ElseIf rdo_fluxo4.Checked = True Then
                        j = 3
                    End If
                    If caixatexto_eq_taxa_cfin.Text <> 0 And caixatexto_investimento_cfin.Text <> "" _
                    And dgv_fluxos_cf.Rows.Count > 1 Then
                        Dim varFluxos(dgv_fluxos_cf.Rows.Count) As Double
                        Dim investimento As Double = caixatexto_investimento_cfin.Text
                        fluxosVPL(varFluxos, j)
                        If j = 0 Or j = 2 Then
                            caixatexto_vpl_cfin.Text = NPV(caixatexto_eq_taxa_cfin.Text, varFluxos) + investimento
                        ElseIf j = 1 Or j = 3 Then
                            caixatexto_vpl2_cfin.Text = NPV(caixatexto_eq_taxa_cfin.Text, varFluxos) + investimento
                        End If
                    Else
                        MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                        Exit Sub
                    End If
                End If
                'COMEÇA INÍCIO DO PERÍODO
            ElseIf rdo_inicio_periodo_cfin.Checked = True Then
                'VALOR PRESENTE
                If rdo_vp_cfin.Checked = True Then
                    If caixatexto_tempo_cfin.Text = "" Then
                        caixatexto_tempo_cfin.Text = 0
                    End If
                    If caixatexto_pmt_cfin.Text = "" Then
                        caixatexto_pmt_cfin.Text = 0
                    End If
                    If caixatexto_vf_cfin.Text = "" Then
                        caixatexto_vf_cfin.Text = 0
                    End If
                    caixatexto_vp_cfin.Text = PV(caixatexto_eq_taxa_cfin.Text, caixatexto_tempo_cfin.Text, caixatexto_pmt_cfin.Text, caixatexto_vf_cfin.Text, DueDate.BegOfPeriod)
                    'TAXA DE JUROS
                ElseIf rdo_taxa_cfin.Checked = True Then
                    If caixatexto_tempo_cfin.Text = "" Then
                        caixatexto_tempo_cfin.Text = 0
                    End If
                    If caixatexto_pmt_cfin.Text = "" Then
                        caixatexto_pmt_cfin.Text = 0
                    End If
                    If caixatexto_vf_cfin.Text = "" Then
                        caixatexto_vf_cfin.Text = 0
                    End If
                    If caixatexto_vp_cfin.Text = "" Then
                        caixatexto_vp_cfin.Text = 0
                    End If
                    caixatexto_eq_taxa_cfin.Text = Rate(caixatexto_tempo_cfin.Text, caixatexto_pmt_cfin.Text, caixatexto_vp_cfin.Text, caixatexto_vf_cfin.Text, DueDate.BegOfPeriod)
                    caixatexto_transformar_percentual.Text = caixatexto_eq_taxa_cfin.Text * 100
                    'NÚMERO DE PERÍODOS
                ElseIf rdo_n_cfin.Checked = True Then
                    If caixatexto_pmt_cfin.Text = "" Then
                        caixatexto_pmt_cfin.Text = 0
                    End If
                    If caixatexto_vf_cfin.Text = "" Then
                        caixatexto_vf_cfin.Text = 0
                    End If
                    If caixatexto_vp_cfin.Text = "" Then
                        caixatexto_vp_cfin.Text = 0
                    End If
                    caixatexto_tempo_cfin.Text = NPer(caixatexto_eq_taxa_cfin.Text, caixatexto_pmt_cfin.Text, caixatexto_vp_cfin.Text, caixatexto_vf_cfin.Text, DueDate.BegOfPeriod)
                    'CÁLCULO DO PMT
                ElseIf rdo_pmt_cfin.Checked = True Then
                    If caixatexto_tempo_cfin.Text = "" Then
                        caixatexto_tempo_cfin.Text = 0
                    End If
                    If caixatexto_vf_cfin.Text = "" Then
                        caixatexto_vf_cfin.Text = 0
                    End If
                    If caixatexto_vp_cfin.Text = "" Then
                        caixatexto_vp_cfin.Text = 0
                    End If
                    caixatexto_pmt_cfin.Text = Pmt(caixatexto_eq_taxa_cfin.Text, caixatexto_tempo_cfin.Text, caixatexto_vp_cfin.Text, caixatexto_vf_cfin.Text, DueDate.BegOfPeriod)
                    'VALOR FUTURO
                ElseIf rdo_vf_cfin.Checked = True Then
                    If caixatexto_tempo_cfin.Text = "" Then
                        caixatexto_tempo_cfin.Text = 0
                    End If
                    If caixatexto_pmt_cfin.Text = "" Then
                        caixatexto_pmt_cfin.Text = 0
                    End If
                    If caixatexto_vp_cfin.Text = "" Then
                        caixatexto_vp_cfin.Text = 0
                    End If
                    caixatexto_vf_cfin.Text = FV(caixatexto_eq_taxa_cfin.Text, caixatexto_tempo_cfin.Text, caixatexto_pmt_cfin.Text, caixatexto_vp_cfin.Text, DueDate.BegOfPeriod)
                End If
            End If
        End If
Exit_calcular_cfin_Click:
        Exit Sub

Err_calcular_cfin_Click:
        MsgBox(Err.Description)
        Resume Exit_calcular_cfin_Click
    End Sub

    Private Sub rdo_juros_simples_cfin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_juros_simples_cfin.CheckedChanged
        Try
            If rdo_juros_simples_cfin.Checked = False Then
                rdo_montante_cfin.Enabled = False
                rdo_pmt_cfin.Enabled = True
                GrupoInicioFim.Enabled = True
            ElseIf rdo_juros_simples_cfin.Checked = True Then
                RichTextBox_leitura_cfin.Text = "Formulas to calculate the Present Value:" & vbNewLine & vbNewLine _
                & "1. Interest / (rate * n)" & vbNewLine _
                & "2 : .Future Value / (1 + (rate * n)))" & vbNewLine _
                & "3. Future Value - Interest" & vbNewLine & vbNewLine _
                & "Formulas to calculate the Interest Rate:" & vbNewLine & vbNewLine _
                & "1. Interest / (Present Value * n)" & vbNewLine _
                & "2. ((Future Value / Present Value) - 1) * (1 / n)" & vbNewLine & vbNewLine _
                & "Formulas to calculate the period:" & vbNewLine & vbNewLine _
                & "1. Interest / (Present Value * rate)" & vbNewLine _
                & "2. ((Future Value / Present Value) - 1) (1 / rate)" & vbNewLine & vbNewLine _
                & "Formulas to calculate the Value of Interest:" & vbNewLine & vbNewLine _
                & "1. Present Value * rate * n" & vbNewLine _
                & "2. Future Value - Present Value" & vbNewLine & vbNewLine _
                & "Formulas to calculate the Future Value:" & vbNewLine & vbNewLine _
                & "1. Present Value + Interest" & vbNewLine _
                & "2. Present Value * (1 + (rate * n))" & vbNewLine & vbNewLine _
                & "Formula to calculate the NPV:" & vbNewLine & vbNewLine _
                & "1. -Investment + ∑(CFj / (1 + (rate * n)))" & vbNewLine & vbNewLine _
                & "Equity rate (Simple Interest):" & vbNewLine & vbNewLine _
                & "rate * n or rate / n" & vbNewLine & vbNewLine _
                & "Accurate Interest: both the rate and the period are calculated by calendar year. Ie: i per year / 365" & vbNewLine & vbNewLine _
                & "Accurate Interest = Present Value * ((i/100)/365) * n" & vbNewLine & vbNewLine _
                & "Commercial Interest: both are calculated by the business year. Ie: i per year / 360 and all months are considered as if they had 30 days." & vbNewLine & vbNewLine _
                & "Commercial Interest = Present Value * ((i/100)/360) * n" & vbNewLine & vbNewLine _
                & "Banking Interest: the rate is calculated by the business year and the deadline for calendar year." & vbNewLine & vbNewLine _
                & "Banking Interest = Present Value * ((i/100)/360) * n"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_juros_compostos_cfin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_juros_compostos_cfin.CheckedChanged
        Try
            If rdo_juros_compostos_cfin.Checked = False Then
                rdo_montante_cfin.Enabled = True
                rdo_pmt_cfin.Enabled = False
                GrupoInicioFim.Enabled = False
            ElseIf rdo_juros_compostos_cfin.Checked = True Then
                RichTextBox_leitura_cfin.Text = "To calculate the Present Value, the rate, the deadline, the PMT and the Future Value." & vbNewLine & vbNewLine _
                & "Future Value = Present Value * ((1 + rate) ^ n)" & vbNewLine & vbNewLine _
                & "PMT = (Present Value - (Future Value / ((1 + rate) ^ n))) * ((((1 + rate) ^ n) * rate) / (((1 + rate) ^ n) - 1))" & vbNewLine & vbNewLine _
                & "Formula to calculate the NPV:" & vbNewLine & vbNewLine _
                & "1. -Investment + ∑(CFj / ((1 + rate) ^ n)" & vbNewLine & vbNewLine _
                & "Equity rate (Compound Interest):" & vbNewLine & vbNewLine _
                & "(1 + rate1) ^ n = (1 + rate2) ^ n" & vbNewLine & vbNewLine _
                & "Exemple: rate2 = 2,9809% per month" & vbNewLine & vbNewLine _
                & "(1 + rate1 per year) ^ 1 = (1 + 0,029809) ^ 12" & vbNewLine & vbNewLine _
                & "((1 + 0,029809) ^ 12) - 1 = 42,259146% per year ano"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub caixatexto_parte_fracionaria_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_vpl_tir_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vpl_tir_cfin.Click
        On Error GoTo Err_vpl_tir_cfin_Click
        Dim j As Integer
        If rdo_fluxo1.Checked = True Then
            j = 0
        ElseIf rdo_fluxo2.Checked = True Then
            j = 1
        ElseIf rdo_fluxo3.Checked = True Then
            j = 2
        ElseIf rdo_fluxo4.Checked = True Then
            j = 3
        End If
        If rdo_vpl_cfin.Checked = True Then 'Valor Presente Líquido (SOMA)
            If caixatexto_vp_cfin.Text <> "" And caixatexto_investimento_cfin.Text <> "" Then
                Dim num1 As Integer = caixatexto_vp_cfin.Text
                Dim num2 As Integer = caixatexto_investimento_cfin.Text
                caixatexto_vpl_cfin.Text = num1 + num2
            Else
                MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                Exit Sub
            End If
        ElseIf rdo_tir_cfin.Checked = True Then 'Taxa Interna de Retorno
            If caixatexto_investimento_cfin.Text <> "" And dgv_fluxos_cf.Rows.Count > 1 Then
                Dim varFluxos(dgv_fluxos_cf.Rows.Count) As Double
                fluxos(varFluxos, j)
                If j = 0 Or j = 2 Then
                    caixatexto_tir_cfin.Text = IRR(varFluxos) * 100
                ElseIf j = 1 Or j = 3 Then
                    caixatexto_tir2_cfin.Text = IRR(varFluxos) * 100
                End If
            Else
                MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
                Exit Sub
            End If
        ElseIf rdo_vpl_il.Checked = True Then 'Valor Presente Líquido (Índice de Lucratividade)
            If caixatexto_il_cfin.Text <> "" And caixatexto_investimento_cfin.Text <> "" Then
                caixatexto_vpl_cfin.Text = (caixatexto_il_cfin.Text - 1) * caixatexto_investimento_cfin.Text
            Else
                MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
            End If
        ElseIf rdo_tirm.Checked = True Then 'Taxa Interna de Retorno Modificada
            If caixatexto_transformar_percentual.Text <> "" And caixatexto_taxa_reinvestimento_cfin.Text <> "" _
                And dgv_fluxos_cf.Rows.Count > 1 Then
                Dim varFluxos(dgv_fluxos_cf.Rows.Count) As Double
                fluxos(varFluxos, j)
                caixatexto_tirm_cfin.Text = MIRR(varFluxos, caixatexto_transformar_percentual.Text, caixatexto_taxa_reinvestimento_cfin.Text)
            Else
                MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        ElseIf rdo_il.Checked = True Then 'Índice de Lucratividade
            If caixatexto_vpl_cfin.Text <> "" And caixatexto_investimento_cfin.Text <> "" Then
                caixatexto_il_cfin.Text = 1 + (caixatexto_vpl_cfin.Text / caixatexto_investimento_cfin.Text)
            ElseIf caixatexto_vpl2_cfin.Text <> "" And caixatexto_investimento_cfin.Text <> "" Then
                caixatexto_il_cfin.Text = 1 + (caixatexto_vpl2_cfin.Text / caixatexto_investimento_cfin.Text)
            Else
                MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
            End If
        ElseIf rdo_payback_simples.Checked = True Then 'Payback Simples
            Dim ps As Double, i As Integer
            Dim investimento As Double = caixatexto_investimento_cfin.Text * -1
            If caixatexto_investimento_cfin.Text <> "" Then
                i = 0
                While investimento > dgv_fluxos_cf.Rows.Item(i).Cells.Item(j).Value
                    investimento -= dgv_fluxos_cf.Rows.Item(i).Cells.Item(j).Value
                    i += 1
                End While
                ps = i + (investimento / dgv_fluxos_cf.Rows.Item(i).Cells.Item(j).Value)
                caixatexto_payback_simples_cfin.Text = ps
            Else
                MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
            End If
        ElseIf rdo_payback_descontado.Checked = True Then 'Payback Descontado
            Dim ps As Double, i As Integer
            Dim investimento As Double = caixatexto_investimento_cfin.Text * -1
            If caixatexto_investimento_cfin.Text <> "" And caixatexto_eq_taxa_cfin.Text <> "" Then
                i = 0
                While investimento > dgv_fluxos_cf.Rows.Item(i).Cells.Item(j).Value
                    investimento -= (dgv_fluxos_cf.Rows.Item(i).Cells.Item(j).Value / ((1 + caixatexto_eq_taxa_cfin.Text) ^ (i + 1)))
                    i += 1
                End While
                ps = i + (investimento / dgv_fluxos_cf.Rows.Item(i).Cells.Item(j).Value)
                caixatexto_payback_descontado_cfin.Text = ps
            Else
                MsgBox("There is value(s) incorrect(s) or unfilled.", MsgBoxStyle.OkOnly, "ProFinanceira")
            End If
        End If
Exit_vpl_tir_cfin_Click:
        Exit Sub

Err_vpl_tir_cfin_Click:
        MsgBox(Err.Description)
        Resume Exit_vpl_tir_cfin_Click
    End Sub

    Private Sub fluxos(ByRef varFluxos() As Double, ByVal j As Integer)
        Dim i As Integer
        varFluxos(0) = caixatexto_investimento_cfin.Text
        For i = 0 To dgv_fluxos_cf.Rows.Count - 1
            varFluxos(i + 1) = dgv_fluxos_cf.Rows.Item(i).Cells.Item(j).Value
        Next
    End Sub

    Private Sub fluxosVPL(ByRef varFluxos() As Double, ByVal j As Integer)
        Dim i As Integer
        For i = 0 To dgv_fluxos_cf.Rows.Count - 1
            varFluxos(i) = dgv_fluxos_cf.Rows.Item(i).Cells.Item(j).Value
        Next
    End Sub

    Private Sub caixatexto_vpl_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vpl_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_investimento_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_investimento_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tir_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tir_cfin.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub rdo_vpl2_cfin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_vpl2_cfin.CheckedChanged
        Try
            If rdo_vpl2_cfin.Checked = True Then
                rdo_inicio_periodo_cfin.Enabled = False
            Else
                rdo_inicio_periodo_cfin.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub form_calculos_financeiros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err_calculos_financeiros_Load
        RichTextBox_informacoes_adicionais.Text = My.Settings.Informacoes_adicionais
Exit_calculos_financeiros_Load:
        Exit Sub

Err_calculos_financeiros_Load:
        MsgBox(Err.Description)
        Resume Exit_calculos_financeiros_Load
    End Sub

    Private Sub btn_visualizar_impressao_cf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_visualizar_impressao_cf.Click
        Dim documento As New profinanceira_inicio
        Try
            Dim printPreviewDialog_principal As New PrintPreviewDialog()
            With printPreviewDialog_principal
                .Document = PrintDocument_cf
                .Text = "ProFinanceira - Visualization"
                .WindowState = FormWindowState.Maximized
                .PrintPreviewControl.Zoom = 1
                .ShowDialog()
            End With
        Catch exp As Exception
            MsgBox(exp.Message.ToString, MsgBoxStyle.Critical, "Error in print preview")
        End Try
    End Sub

    Private Sub btn_imprimir_cf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir_cf.Click
        Try
            If PrintDialog_cf.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PrintDialog_cf.Document = PrintDocument_cf
                PrintDocument_cf.Print()
            Else
                Dim canelado As String = "cancelado"
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "Error printing")
        End Try
    End Sub

    Private Sub PrintDocument_principal_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument_cf.PrintPage
        On Error GoTo Err_PrintDocument_principal_PrintPage
        Dim imprimir As New Impressao

        imprimir.ImpressaoCalculosFinanceiros(sender, e)

Exit_PrintDocument_principal_PrintPage:
        Exit Sub

Err_PrintDocument_principal_PrintPage:
        MsgBox(Err.Description)
        Resume Exit_PrintDocument_principal_PrintPage
    End Sub

    Private Sub RichTextBox_informacoes_adicionais_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox_informacoes_adicionais.TextChanged
        Try
            My.Settings.Informacoes_adicionais = RichTextBox_informacoes_adicionais.Text
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class