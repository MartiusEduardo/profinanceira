Public Class form_calculos_financeiros

    Private Sub caixatexto_vp_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vp_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_taxa_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tempo_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tempo_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_pmt_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_pmt_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vf_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vf_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_eq_i_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_eq_i_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_eq_n_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_calcular_vf_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_vf_cfin.Click
        Dim unitaria As Double
        If caixatexto_taxa_cfin.Text <> "" Then
            unitaria = caixatexto_taxa_cfin.Text / 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
        If caixatexto_vp_cfin.Text <> "" And caixatexto_taxa_cfin.Text <> "" _
        And caixatexto_tempo_cfin.Text <> "" Then
            caixatexto_vf_cfin.Text = caixatexto_vp_cfin.Text * ((1 + unitaria) ^ caixatexto_tempo_cfin.Text)
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub btn_calcular_eq_taxa_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_eq_taxa_cfin.Click
        If (((rdo_dia_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True)) Or _
        ((rdo_mes_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True)) Or _
        ((rdo_semestre_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True)) Or _
        ((rdo_ano_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True)) Or _
        ((rdo_bimestre_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True)) Or _
        ((rdo_trimestre_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True))) Then
            caixatexto_eq_taxa_cfin.Text = (caixatexto_eq_i_cfin.Text / 100)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 30) - 1)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 180) - 1)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 362) - 1)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 60) - 1)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 90) - 1)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 6) - 1)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 12) - 1)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 2) - 1)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 3) - 1)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 2) - 1)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 3)) - 1)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 2)) - 1)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 30)) - 1)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 180)) - 1)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 6)) - 1)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 362)) - 1)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 12)) - 1)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 2)) - 1)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 6)) - 1)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 4)) - 1)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 60)) - 1)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 2)) - 1)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 1.5) - 1)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 3) - 1)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 6) - 1)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 90)) - 1)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 3)) - 1)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ (1 / 1.5)) - 1)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 2) - 1)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_cfin.Text = (((1 + (caixatexto_eq_i_cfin.Text / 100)) ^ 4) - 1)
        End If
    End Sub

    Private Sub caixacombo_decimais_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_casas_decimais_cfin.SelectedIndexChanged
        If caixatexto_eq_taxa_cfin.Text <> "" Then
            Dim num1 As Integer
            If caixacombo_casas_decimais_cfin.Text <> "" Then
                num1 = caixacombo_casas_decimais_cfin.Text
                caixatexto_eq_taxa_cfin.Text = Decimal.Round(caixatexto_eq_taxa_cfin.Text, num1, MidpointRounding.ToEven)
            End If
        End If
    End Sub

    Private Sub btn_calcular_pmt_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_pmt_cfin.Click
        Dim unitaria As Double
        If caixatexto_taxa_cfin.Text <> "" Then
            unitaria = caixatexto_taxa_cfin.Text / 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
        If caixatexto_vp_cfin.Text <> "" And caixatexto_taxa_cfin.Text <> "" _
        And caixatexto_tempo_cfin.Text <> "" And caixatexto_vf_cfin.Text <> "" Then
            caixatexto_pmt_cfin.Text = (caixatexto_vp_cfin.Text - (caixatexto_vf_cfin.Text / ((1 + unitaria) ^ caixatexto_tempo_cfin.Text))) * _
                        ((((1 + unitaria) ^ caixatexto_tempo_cfin.Text) * caixatexto_taxa_cfin.Text) _
                        / (((1 + unitaria) ^ caixatexto_tempo_cfin.Text) - 1))
        ElseIf caixatexto_taxa_cfin.Text <> "" And caixatexto_tempo_cfin.Text <> "" _
        And caixatexto_vf_cfin.Text <> "" Then
            MsgBox("Ainda em teste")
        ElseIf caixatexto_vp_cfin.Text <> "" And caixatexto_taxa_cfin.Text <> "" _
        And caixatexto_tempo_cfin.Text <> "" Then
            caixatexto_pmt_cfin.Text = caixatexto_vp_cfin.Text * _
                        ((((1 + unitaria) ^ caixatexto_tempo_cfin.Text) * unitaria) _
                        / (((1 + unitaria) ^ caixatexto_tempo_cfin.Text) - 1))
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub btn_calcular_vp_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_vp_cfin.Click
        Dim unitaria As Double
        If caixatexto_taxa_cfin.Text <> "" Then
            unitaria = caixatexto_taxa_cfin.Text / 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
        If caixatexto_taxa_cfin.Text <> "" And caixatexto_tempo_cfin.Text <> "" _
        And caixatexto_vf_cfin.Text <> "" Then
            caixatexto_vp_cfin.Text = caixatexto_vf_cfin.Text / ((1 + unitaria) ^ caixatexto_tempo_cfin.Text)
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub btn_calcular_tempo_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_tempo_cfin.Click
        Dim unitaria As Double
        If caixatexto_taxa_cfin.Text <> "" Then
            unitaria = caixatexto_taxa_cfin.Text / 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
        If caixatexto_vp_cfin.Text <> "" And caixatexto_taxa_cfin.Text <> "" _
        And caixatexto_vf_cfin.Text <> "" Then
            caixatexto_tempo_cfin.Text = Math.Log(caixatexto_vf_cfin.Text / caixatexto_vp_cfin.Text, 1 + unitaria)
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub btn_calcular_juros_composto_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_juros_composto_cfin.Click
        If caixatexto_vp_cfin.Text <> "" And caixatexto_tempo_cfin.Text <> "" _
        And caixatexto_vf_cfin.Text <> "" Then
            caixatexto_taxa_cfin.Text = (((caixatexto_vf_cfin.Text / caixatexto_vp_cfin.Text) ^ (1 / caixatexto_tempo_cfin.Text)) - 1) * 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub btn_calcular_vp_simples_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_vp_simples_cfin.Click
        Dim unitaria As Double
        If caixatexto_juros_simples_cfin.Text <> "" Then
            unitaria = caixatexto_juros_simples_cfin.Text / 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
        If caixatexto_montante_juros_cfin.Text <> "" And caixatexto_juros_simples_cfin.Text <> "" _
        And caixatexto_tempo_simples_cfin.Text <> "" Then
            caixatexto_vp_simples_cfin.Text = caixatexto_montante_juros_cfin.Text / (unitaria * caixatexto_tempo_simples_cfin.Text)
        ElseIf caixatexto_vf_simples_cfin.Text <> "" And caixatexto_juros_simples_cfin.Text <> "" _
        And caixatexto_tempo_simples_cfin.Text <> "" Then
            caixatexto_vp_simples_cfin.Text = caixatexto_vf_simples_cfin.Text / (1 + (unitaria * caixatexto_tempo_simples_cfin.Text))
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub btn_calcular_juros_simples_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_juros_simples_cfin.Click
        If caixatexto_montante_juros_cfin.Text <> "" And caixatexto_vp_simples_cfin.Text <> "" _
        And caixatexto_tempo_simples_cfin.Text <> "" Then
            caixatexto_juros_simples_cfin.Text = (caixatexto_montante_juros_cfin.Text / (caixatexto_vp_simples_cfin.Text * caixatexto_tempo_simples_cfin.Text)) * 100
        ElseIf caixatexto_vf_simples_cfin.Text <> "" And caixatexto_vp_simples_cfin.Text <> "" _
        And caixatexto_tempo_simples_cfin.Text <> "" Then
            caixatexto_juros_simples_cfin.Text = (((caixatexto_vf_simples_cfin.Text / caixatexto_vp_simples_cfin.Text) - 1) * (1 / caixatexto_tempo_simples_cfin.Text)) * 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub btn_calcular_montante_juros_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_montante_juros_cfin.Click
        Dim unitaria As Double
        If caixatexto_juros_simples_cfin.Text <> "" Then
            unitaria = caixatexto_juros_simples_cfin.Text / 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
        If caixatexto_juros_simples_cfin.Text <> "" And caixatexto_vp_simples_cfin.Text <> "" _
        And caixatexto_tempo_simples_cfin.Text <> "" Then
            caixatexto_montante_juros_cfin.Text = caixatexto_vp_simples_cfin.Text * unitaria * caixatexto_tempo_simples_cfin.Text
        ElseIf caixatexto_vf_simples_cfin.Text <> "" And caixatexto_vp_simples_cfin.Text <> "" Then
            caixatexto_montante_juros_cfin.Text = caixatexto_vf_simples_cfin.Text - caixatexto_vp_simples_cfin.Text
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub btn_calcular_tempo_simples_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_tempo_simples_cfin.Click
        Dim unitaria As Double
        If caixatexto_juros_simples_cfin.Text <> "" Then
            unitaria = caixatexto_juros_simples_cfin.Text / 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
        If caixatexto_montante_juros_cfin.Text <> "" And caixatexto_vp_simples_cfin.Text <> "" _
        And caixatexto_juros_simples_cfin.Text <> "" Then
            caixatexto_tempo_simples_cfin.Text = caixatexto_montante_juros_cfin.Text / (caixatexto_vp_simples_cfin.Text * unitaria)
        ElseIf caixatexto_vf_simples_cfin.Text <> "" And caixatexto_vp_simples_cfin.Text <> "" _
        And caixatexto_juros_simples_cfin.Text <> "" Then
            caixatexto_tempo_simples_cfin.Text = ((caixatexto_vf_simples_cfin.Text / caixatexto_vp_simples_cfin.Text) - 1) * (1 / unitaria)
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub btn_calcular_vf_simples_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_vf_simples_cfin.Click
        Dim unitaria As Double, num1 As Double, num2 As Double
        If caixatexto_juros_simples_cfin.Text <> "" Then
            unitaria = caixatexto_juros_simples_cfin.Text / 100
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
        If caixatexto_montante_juros_cfin.Text <> "" And caixatexto_vp_simples_cfin.Text <> "" Then
            num1 = caixatexto_vp_simples_cfin.Text
            num2 = caixatexto_montante_juros_cfin.Text
            caixatexto_vf_simples_cfin.Text = num1 + num2
        ElseIf caixatexto_juros_simples_cfin.Text <> "" And caixatexto_vp_simples_cfin.Text <> "" _
        And caixatexto_tempo_simples_cfin.Text <> "" Then
            caixatexto_vf_simples_cfin.Text = caixatexto_vp_simples_cfin.Text * (1 + (unitaria * caixatexto_tempo_simples_cfin.Text))
        Else
            MsgBox("Há valor(s) incorreto(s) ou sem preenchimento.", MsgBoxStyle.Exclamation, "ProFinanceira")
            Exit Sub
        End If
    End Sub

    Private Sub caixatexto_eq_i_cfin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_eq_i_cfin.TextChanged
        If caixatexto_eq_i_cfin.Text <> "" Then
            btn_calcular_eq_taxa_cfin.Enabled = True
        Else
            btn_calcular_eq_taxa_cfin.Enabled = False
        End If
    End Sub

    Private Sub btn_calcular_taxa_simples_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_taxa_simples_cfin.Click
        If (((rdo_dia_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True)) Or _
        ((rdo_mes_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True)) Or _
        ((rdo_semestre_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True)) Or _
        ((rdo_ano_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True)) Or _
        ((rdo_bimestre_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True)) Or _
        ((rdo_trimestre_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True))) Then
            caixatexto_eq_taxa_simples_cfin.Text = (caixatexto_eq_i_simples_cfin.Text / 100)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 30) / 100)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 180) / 100)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 360) / 100)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 60) / 100)
        ElseIf (rdo_dia_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 90) / 100)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 6) / 100)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 12) / 100)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 2) / 100)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 3) / 100)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 2) / 100)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 3) / 100)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 2) / 100)
        ElseIf (rdo_mes_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 30) / 100)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 180) / 100)
        ElseIf (rdo_semestre_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 6) / 100)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 360) / 100)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 12) / 100)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 2) / 100)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 6) / 100)
        ElseIf (rdo_ano_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 4) / 100)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 60) / 100)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 2) / 100)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_trimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 1.5) / 100)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 3) / 100)
        ElseIf (rdo_bimestre_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 6) / 100)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_dia_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 90) / 100)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_mes_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 3) / 100)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_bimestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text / 1.5) / 100)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_semestre_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 2) / 100)
        ElseIf (rdo_trimestre_taxa_cfin.Checked = True) And (rdo_ano_tempo_cfin.Checked = True) Then
            caixatexto_eq_taxa_simples_cfin.Text = ((caixatexto_eq_i_simples_cfin.Text * 4) / 100)
        End If
    End Sub

    Private Sub caixatexto_eq_i_simples_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_eq_i_simples_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_eq_i_simples_cfin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixatexto_eq_i_simples_cfin.TextChanged
        If caixatexto_eq_i_simples_cfin.Text <> "" Then
            btn_calcular_taxa_simples_cfin.Enabled = True
        Else
            btn_calcular_taxa_simples_cfin.Enabled = False
        End If
    End Sub

    Private Sub caixacombo_casas_decimais_simples_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_casas_decimais_simples_cfin.SelectedIndexChanged
        If caixatexto_eq_taxa_simples_cfin.Text <> "" Then
            Dim num1 As Integer
            If caixacombo_casas_decimais_simples_cfin.Text <> "" Then
                num1 = caixacombo_casas_decimais_simples_cfin.Text
                caixatexto_eq_taxa_simples_cfin.Text = Decimal.Round(caixatexto_eq_taxa_simples_cfin.Text, num1, MidpointRounding.ToEven)
            End If
        End If
    End Sub

    Private Sub caixatexto_montante_juros_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_montante_juros_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vp_simples_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vp_simples_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_juros_simples_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_juros_simples_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_tempo_simples_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_tempo_simples_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_vf_simples_cfin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vf_simples_cfin.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_exatos_i_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exatos_i_ecb_cfin.Click
        If caixatexto_inserir_i_ecb_cfin.Text <> "" Then
            If checkbox_ano_bissexto_ecb_cfin.Checked = True Then
                caixatexto_exatos_i_ecb_cfin.Text = (caixatexto_inserir_i_ecb_cfin.Text / 366) * 100
                Exit Sub
            End If
            caixatexto_exatos_i_ecb_cfin.Text = (caixatexto_inserir_i_ecb_cfin.Text / 365) * 100
        Else
            MsgBox("Não há valor para ser calculado!", MsgBoxStyle.Exclamation, "ProFinanceira")
        End If
    End Sub

    Private Sub btn_comercial_i_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comercial_i_ecb_cfin.Click
        If caixatexto_inserir_i_ecb_cfin.Text <> "" Then
            If checkbox_ano_bissexto_ecb_cfin.Checked = True Then
                caixatexto_comercial_i_ecb_cfin.Text = (caixatexto_inserir_i_ecb_cfin.Text / 366) * 100
                Exit Sub
            End If
            caixatexto_comercial_i_ecb_cfin.Text = (caixatexto_inserir_i_ecb_cfin.Text / 360) * 100
        Else
            MsgBox("Não há valor para ser calculado!", MsgBoxStyle.Exclamation, "ProFinanceira")
        End If
    End Sub

    Private Sub btn_bancarios_i_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bancarios_i_ecb_cfin.Click
        If caixatexto_inserir_i_ecb_cfin.Text <> "" Then
            If checkbox_ano_bissexto_ecb_cfin.Checked = True Then
                caixatexto_bancarios_i_ecb_cfin.Text = (caixatexto_inserir_i_ecb_cfin.Text / 366) * 100
                Exit Sub
            End If
            caixatexto_bancarios_i_ecb_cfin.Text = (caixatexto_inserir_i_ecb_cfin.Text / 360) * 100
        Else
            MsgBox("Não há valor para ser calculado!", MsgBoxStyle.Exclamation, "ProFinanceira")
        End If
    End Sub

    Private Sub btn_exatos_n_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exatos_n_ecb_cfin.Click
        Dim ate As DateTime = data_ate.Text
        Dim de As DateTime = data_de.Text
        Dim subtracao As TimeSpan
        subtracao = ate.Subtract(data_de.Text)
        caixatexto_exatos_n_ecb_cfin.Text = subtracao.Days
    End Sub

    Private Sub btn_comercial_n_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_comercial_n_ecb_cfin.Click
        Dim ate As DateTime = data_ate.Text
        Dim de As DateTime = data_de.Text
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
        If subtracao_dia >= 0 And subtracao_mes >= 0 And subtracao_ano >= 0 Then
            caixatexto_comercial_n_ecb_cfin.Text = (subtracao_mes * 30) + subtracao_dia + (subtracao_ano * 360)
            Exit Sub
        ElseIf subtracao_dia < 0 Then
            caixatexto_comercial_n_ecb_cfin.Text = (subtracao_mes * 30) - subtracao_dia + (subtracao_ano * 360)
        ElseIf subtracao_mes < 0 Then
            caixatexto_comercial_n_ecb_cfin.Text = (subtracao_mes * -30) + subtracao_dia + (subtracao_ano * 360)
        ElseIf subtracao_ano < 0 Then
            caixatexto_comercial_n_ecb_cfin.Text = (subtracao_mes * 30) + subtracao_dia + (subtracao_ano * -360)
        End If
    End Sub

    Private Sub btn_bancarios_n_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bancarios_n_ecb_cfin.Click
        Dim ate As DateTime = data_ate.Text
        Dim de As DateTime = data_de.Text
        Dim subtracao As TimeSpan
        subtracao = ate.Subtract(data_de.Text)
        caixatexto_bancarios_n_ecb_cfin.Text = subtracao.Days
    End Sub

    Private Sub btn_limpar_ecb_cfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpar_ecb_cfin.Click
        caixatexto_exatos_i_ecb_cfin.Text = ""
        caixatexto_exatos_n_ecb_cfin.Text = ""
        caixatexto_comercial_i_ecb_cfin.Text = ""
        caixatexto_comercial_n_ecb_cfin.Text = ""
        caixatexto_bancarios_i_ecb_cfin.Text = ""
        caixatexto_bancarios_n_ecb_cfin.Text = ""
    End Sub

    Private Sub caixacombo_exatos_i_ecb_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_exatos_i_ecb_cfin.SelectedIndexChanged
        If caixatexto_exatos_i_ecb_cfin.Text <> "" Then
            Dim num1 As Integer
            If caixacombo_exatos_i_ecb_cfin.Text <> "" Then
                num1 = caixacombo_exatos_i_ecb_cfin.Text
                caixatexto_exatos_i_ecb_cfin.Text = Decimal.Round(caixatexto_exatos_i_ecb_cfin.Text, num1, MidpointRounding.ToEven)
            End If
        End If
    End Sub

    Private Sub caixacombo_comercial_i_ecb_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_comercial_i_ecb_cfin.SelectedIndexChanged
        If caixatexto_comercial_i_ecb_cfin.Text <> "" Then
            Dim num1 As Integer
            If caixacombo_comercial_i_ecb_cfin.Text <> "" Then
                num1 = caixacombo_comercial_i_ecb_cfin.Text
                caixatexto_comercial_i_ecb_cfin.Text = Decimal.Round(caixatexto_comercial_i_ecb_cfin.Text, num1, MidpointRounding.ToEven)
            End If
        End If
    End Sub

    Private Sub caixacombo_bancarios_i_ecb_cfin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caixacombo_bancarios_i_ecb_cfin.SelectedIndexChanged
        If caixatexto_bancarios_i_ecb_cfin.Text <> "" Then
            Dim num1 As Integer
            If caixacombo_bancarios_i_ecb_cfin.Text <> "" Then
                num1 = caixacombo_bancarios_i_ecb_cfin.Text
                caixatexto_bancarios_i_ecb_cfin.Text = Decimal.Round(caixatexto_bancarios_i_ecb_cfin.Text, num1, MidpointRounding.ToEven)
            End If
        End If
    End Sub

    Private Sub btn_calcular_ano_bissexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_ano_bissexto.Click
        Dim ate As DateTime = data_ate.Text
        Dim de As DateTime = data_de.Text
        Dim ano_bissexto As Boolean = Date.IsLeapYear(ate.Year)
        Dim ano2_bissexto As Boolean = Date.IsLeapYear(de.Year)
        Dim bissexto As Integer, i As Integer
        bissexto = de.Year
        For i = de.Year To ate.Year
            If ano2_bissexto = False Then
                MsgBox("O ano " & bissexto & " " & "não é um ano bissexto")
            ElseIf ano2_bissexto = True Then
                MsgBox("O ano " & bissexto & " " & "é um ano bissexto")
            End If
            bissexto += +1
            ano2_bissexto = Date.IsLeapYear(bissexto)
        Next
    End Sub

    Private Sub btn_transformar_percentual_simples_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_transformar_percentual_simples.Click
        caixatexto_transformar_percentual_simples.Text = (caixatexto_eq_taxa_simples_cfin.Text * 100) & "%"
    End Sub

    Private Sub btn_transformar_percentual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_transformar_percentual.Click
        caixatexto_transformar_percentual.Text = (caixatexto_eq_taxa_cfin.Text * 100) & "%"
    End Sub
End Class