Public Class form_metodo_hamburgues

    Private Sub Método_Hamburguês_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ACBInterestDataSet.ACBInterest' table. You can move, or remove it, as needed.
        Me.ACBInterestTableAdapter.Fill(Me.ACBInterestDataSet.ACBInterest)
        Try
            Dim caminho As String = My.Application.Info.DirectoryPath & "\ACBInterest.accdb"
            Me.ACBInterestTableAdapter.Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & caminho
            'TODO: This line of code loads data into the 'ACBInterestDataSet.ACBInterest' table. You can move, or remove it, as needed.
            Me.ACBInterestTableAdapter.Fill(Me.ACBInterestDataSet.ACBInterest)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_calcular_mh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_mh.Click
        On Error GoTo Err_prazo_medio_Load
        Dim i As Integer, soma_produto As Double, soma As Double
        Dim saldo(0 To dgvJurosECB.Rows.Count) As Double
        Dim n(0 To dgvJurosECB.Rows.Count) As Integer
        If dgvJurosECB.Rows.Count <= 1 Then
            MsgBox("There is no operation registered", MsgBoxStyle.OkOnly, "Account")
            Exit Sub
        End If
        For i = 0 To dgvJurosECB.Rows.Count - 1
            saldo(i) = dgvJurosECB.Rows.Item(i).Cells.Item(4).Value
            n(i) = dgvJurosECB.Rows.Item(i).Cells.Item(6).Value
            soma_produto += saldo(i) * n(i)
            soma += saldo(i)
        Next
        caixatexto_prazo_medio_mh.Text = soma_produto / soma
        caixatexto_metodo_hamburgues_mh.Text = soma_produto * (caixatexto_taxa_mh.Text / 100)
Exit_prazo_medio_Load:
        Exit Sub

Err_prazo_medio_Load:
        MsgBox(Err.Description)
        Resume Exit_prazo_medio_Load
    End Sub

    Private Sub caixatexto_taxa_mh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_taxa_mh.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_prazo_medio_mh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_prazo_medio_mh.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub caixatexto_metodo_hamburgues_mh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_metodo_hamburgues_mh.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub ACBInterestBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACBInterestBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ACBInterestBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ACBInterestDataSet)
            MsgBox("Table saved successfully!", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class