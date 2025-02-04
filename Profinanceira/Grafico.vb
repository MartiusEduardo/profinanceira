Imports System.Drawing

Public Class form_grafico_price
    Private Sub btn_gerar_dfc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gerar_dfc.Click
        Dim dfc As Graphics ' the drawing surface
        Dim pMyPen As New Pen(Color.Black, 3) ' used to draw the lines
        Dim bMyBrush As SolidBrush = New SolidBrush(Color.White) ' used to draw the background
        Dim i As Integer, n As Single, m As Single
        Dim y(0 To form_ef_sistemas.caixatexto_total_n_price.Text) As Integer
        Dim y2(0 To form_ef_sistemas.caixatexto_total_n_price.Text) As Integer
        Dim amortizacao(0 To form_ef_sistemas.caixatexto_total_n_price.Text) As ListViewItem.ListViewSubItem
        Dim juros(0 To form_ef_sistemas.caixatexto_total_n_price.Text) As ListViewItem.ListViewSubItem
        dfc = grafico_price.CreateGraphics
        n = form_ef_sistemas.caixatexto_total_n_price.Text
        m = form_ef_sistemas.caixatexto_vp_price.Text
        If m <= 300 Then
            m = m
        ElseIf m > 100 And m <= 1000 Then
            m = m / 10
        ElseIf m > 1000 And m <= 10000 Then
            m = m / 100
        ElseIf m > 10000 And m <= 100000 Then
            m = m / 1000
        ElseIf m > 100000 And m <= 1000000 Then
            m = m / 10000
        ElseIf m > 1000000 Then
            m = m / 100000
        End If
        If m <= 100 Then
            m = 50 + (m * 3)
        End If
        If form_ef_sistemas.lista_emprestimos_price.Items.Count = 0 Then
            MsgBox("Não há ítems!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        For i = 1 To form_ef_sistemas.caixatexto_total_n_price.Text
            amortizacao(i) = form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(1)
            juros(i) = form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(2)
        Next
        For i = 1 To form_ef_sistemas.caixatexto_total_n_price.Text
            If amortizacao(i).Text <= 100 Then
                y(i) = amortizacao(i).Text
            ElseIf amortizacao(i).Text > 100 And amortizacao(i).Text <= 1000 Then
                y(i) = amortizacao(i).Text / 10
            ElseIf amortizacao(i).Text > 1000 And amortizacao(i).Text <= 10000 Then
                y(i) = amortizacao(i).Text / 100
            ElseIf amortizacao(i).Text > 10000 And amortizacao(i).Text <= 100000 Then
                y(i) = amortizacao(i).Text / 1000
            ElseIf amortizacao(i).Text > 100000 And amortizacao(i).Text <= 1000000 Then
                y(i) = amortizacao(i).Text / 10000
            ElseIf amortizacao(i).Text > 1000000 Then
                y(i) = amortizacao(i).Text / 100000
            End If
            If juros(i).Text <= 100 Then
                y2(i) = juros(i).Text
            ElseIf juros(i).Text > 100 And juros(i).Text <= 1000 Then
                y2(i) = juros(i).Text / 10
            ElseIf juros(i).Text > 1000 And juros(i).Text <= 10000 Then
                y2(i) = juros(i).Text / 100
            ElseIf juros(i).Text > 10000 And juros(i).Text <= 100000 Then
                y2(i) = juros(i).Text / 1000
            ElseIf juros(i).Text > 100000 And juros(i).Text <= 1000000 Then
                y2(i) = juros(i).Text / 10000
            ElseIf juros(i).Text > 1000000 Then
                y2(i) = juros(i).Text / 100000
            End If
        Next
        dfc.DrawLine(pMyPen, 50, m, n * 60, m)
        dfc.DrawLine(pMyPen, 50, 50, 50, m)
        For i = 1 To form_ef_sistemas.caixatexto_total_n_price.Text
            dfc.DrawLine(Pens.Blue, 50 + (i * 50), m, 50 + (i * 50), y(i))
            dfc.DrawLine(Pens.Red, 50 + (i * 50), y(i), 50 + (i * 50), y2(i))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim graficoArea As Graphics
        Dim i As Integer, n As Single, m As Single
        Dim y(0 To form_ef_sistemas.caixatexto_total_n_price.Text) As Integer
        Dim y2(0 To form_ef_sistemas.caixatexto_total_n_price.Text) As Integer
        Dim amortizacao(0 To form_ef_sistemas.caixatexto_total_n_price.Text) As ListViewItem.ListViewSubItem
        Dim juros(0 To form_ef_sistemas.caixatexto_total_n_price.Text) As ListViewItem.ListViewSubItem
        graficoArea = grafico_price.CreateGraphics
        n = form_ef_sistemas.caixatexto_total_n_price.Text
        m = form_ef_sistemas.caixatexto_vp_price.Text
        If m <= 300 Then
            m = m
        ElseIf m > 100 And m <= 1000 Then
            m = m / 10
        ElseIf m > 1000 And m <= 10000 Then
            m = m / 100
        ElseIf m > 10000 And m <= 100000 Then
            m = m / 1000
        ElseIf m > 100000 And m <= 1000000 Then
            m = m / 10000
        ElseIf m > 1000000 Then
            m = m / 100000
        End If
        If m <= 100 Then
            m = 50 + (m * 3)
        End If
        If form_ef_sistemas.lista_emprestimos_price.Items.Count = 0 Then
            MsgBox("Não há ítems!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        For i = 1 To form_ef_sistemas.caixatexto_total_n_price.Text
            amortizacao(i) = form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(1)
            juros(i) = form_ef_sistemas.lista_emprestimos_price.Items.Item(i).SubItems.Item(2)
        Next
        For i = 1 To form_ef_sistemas.caixatexto_total_n_price.Text
            If amortizacao(i).Text <= 100 Then
                y(i) = amortizacao(i).Text
            ElseIf amortizacao(i).Text > 100 And amortizacao(i).Text <= 1000 Then
                y(i) = amortizacao(i).Text / 10
            ElseIf amortizacao(i).Text > 1000 And amortizacao(i).Text <= 10000 Then
                y(i) = amortizacao(i).Text / 100
            ElseIf amortizacao(i).Text > 10000 And amortizacao(i).Text <= 100000 Then
                y(i) = amortizacao(i).Text / 1000
            ElseIf amortizacao(i).Text > 100000 And amortizacao(i).Text <= 1000000 Then
                y(i) = amortizacao(i).Text / 10000
            ElseIf amortizacao(i).Text > 1000000 Then
                y(i) = amortizacao(i).Text / 100000
            End If
            If juros(i).Text <= 100 Then
                y2(i) = juros(i).Text
            ElseIf juros(i).Text > 100 And juros(i).Text <= 1000 Then
                y2(i) = juros(i).Text / 10
            ElseIf juros(i).Text > 1000 And juros(i).Text <= 10000 Then
                y2(i) = juros(i).Text / 100
            ElseIf juros(i).Text > 10000 And juros(i).Text <= 100000 Then
                y2(i) = juros(i).Text / 1000
            ElseIf juros(i).Text > 100000 And juros(i).Text <= 1000000 Then
                y2(i) = juros(i).Text / 10000
            ElseIf juros(i).Text > 1000000 Then
                y2(i) = juros(i).Text / 100000
            End If
        Next
        graficoArea.DrawLine(Pens.Black, 50, m, n * 60, m) 'reta deitada
        graficoArea.DrawLine(Pens.Black, 50, 50, 50, m) 'reta em pé
        For i = 1 To form_ef_sistemas.caixatexto_total_n_price.Text
            graficoArea.FillRectangle(New SolidBrush(Color.Blue), 50 + (i * 50), m - y(i), 20, y(i))
            graficoArea.DrawRectangle(Pens.Blue, 50 + (i * 50), m - y(i), 20, y(i))
            graficoArea.FillRectangle(New SolidBrush(Color.Red), 50 + (i * 50), m - y2(i) - y(i), 20, y2(i))
            graficoArea.DrawRectangle(Pens.Red, 50 + (i * 50), m - y2(i) - y(i), 20, y2(i))
        Next
    End Sub
End Class