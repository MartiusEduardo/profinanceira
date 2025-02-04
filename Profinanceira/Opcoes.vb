Public Class form_opcoes

    Private caminho As String = My.Application.Info.DirectoryPath & "\LoansAndFinancing.accdb"

    Private Sub Opcoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TreeView_opcoes.Nodes(0).Expand()
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub TreeView_opcoes_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_opcoes.AfterSelect
        On Error GoTo Err_TreeView_opcoes_AfterSelect
        Dim index As Integer
        index = TreeView_opcoes.SelectedNode.Index
        If TreeView_opcoes.SelectedNode Is Nothing Then
            Exit Sub
        ElseIf index = 0 Then
            LoadIndices()
        ElseIf index = 1 Then
            LoadPeriodos()
        End If
Exit_TreeView_opcoes_AfterSelect:
        Exit Sub

Err_TreeView_opcoes_AfterSelect:
        MsgBox(Err.Description)
        Resume Exit_TreeView_opcoes_AfterSelect
    End Sub

    Private Sub LoadIndices()
        Try
            Me.IndicesTableAdapter.Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & caminho
            DataGridView_opcoes.DataSource = IndicesBindingSource
            Me.IndicesTableAdapter.Fill(Me.LoansAndFinancingDataSet.Indices)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub LoadPeriodos()
        Try
            Me.PeriodosTableAdapter.Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & caminho
            DataGridView_opcoes.DataSource = PeriodosBindingSource
            Me.PeriodosTableAdapter.Fill(Me.LoansAndFinancingDataSet.Periodos)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_carregar_opcoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carregar_opcoes.Click
        Try
            Dim valores(0 To caixatexto_carregar_n_periodos.Text + 1) As Double
            Dim i As Integer, index As Integer, n As Integer
            index = TreeView_opcoes.SelectedNode.Index
            If index = 0 Then
                n = 1
            ElseIf index = 1 Then
                n = 0
            End If
            For i = 0 To caixatexto_carregar_n_periodos.Text - 1
                valores(i) = DataGridView_opcoes.Rows.Item(i).Cells.Item(n).Value
            Next
            If index = 0 Then
                For i = 0 To caixatexto_carregar_n_periodos.Text - 1
                    form_ef_sistemas.dgv_emprestimos_indices.Rows.Item(i).Cells.Item(1).Value = valores(i)
                Next
            ElseIf index = 1 Then
                For i = 0 To caixatexto_carregar_n_periodos.Text - 1
                    form_ef_sistemas.dgv_emprestimos_periodo.Rows.Item(i).Cells.Item(1).Value = valores(i)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_cancelar_opcoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar_opcoes.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_salvar_tabela_opcoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salvar_tabela_opcoes.Click
        Try
            Dim index As Integer
            index = TreeView_opcoes.SelectedNode.Index
            If index = 0 Then
                Me.ValidateChildren()
                Me.IndicesBindingSource.EndEdit()
                Me.IndicesTableAdapter.Update(Me.LoansAndFinancingDataSet.Indices)
            ElseIf index = 1 Then
                Me.ValidateChildren()
                Me.PeriodosBindingSource.EndEdit()
                Me.PeriodosTableAdapter.Update(Me.LoansAndFinancingDataSet.Periodos)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_ok_opcoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok_opcoes.Click
        Try
            Dim index As Integer
            index = TreeView_opcoes.SelectedNode.Index
            If index = 0 Then
                Me.ValidateChildren()
                Me.IndicesBindingSource.EndEdit()
                Me.IndicesTableAdapter.Update(Me.LoansAndFinancingDataSet.Indices)
            ElseIf index = 1 Then
                Me.ValidateChildren()
                Me.PeriodosBindingSource.EndEdit()
                Me.PeriodosTableAdapter.Update(Me.LoansAndFinancingDataSet.Periodos)
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class