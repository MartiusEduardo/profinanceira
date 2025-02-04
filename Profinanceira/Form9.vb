Public Class form_descontos_titulos

    Private Sub caixatexto_vt_dt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles caixatexto_vt_dt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class