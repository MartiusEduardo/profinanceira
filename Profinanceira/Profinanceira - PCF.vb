Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class profinanceira_inicio

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        On Error GoTo Err_SairToolStripMenuItem_Click
        Global.System.Windows.Forms.Application.Exit()
Exit_SairToolStripMenuItem_Click:
        Exit Sub

Err_SairToolStripMenuItem_Click:
        MsgBox(Err.Description)
        Resume Exit_SairToolStripMenuItem_Click
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        On Error GoTo Err_CloseAllToolStripMenuItem_Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
Exit_CloseAllToolStripMenuItem_Click:
        Exit Sub

Err_CloseAllToolStripMenuItem_Click:
        MsgBox(Err.Description)
        Resume Exit_CloseAllToolStripMenuItem_Click
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub submenu_calculos_financeiros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_calculos_financeiros.Click
        On Error GoTo Err_submenu_calculos_financeiros_Click
        form_calculos_financeiros.TopLevel = False
        form_calculos_financeiros.MdiParent = Me
        form_calculos_financeiros.Show()
Exit_submenu_calculos_financeiros_Click:
        Exit Sub

Err_submenu_calculos_financeiros_Click:
        MsgBox(Err.Description)
        Resume Exit_submenu_calculos_financeiros_Click
    End Sub

    Private Sub submenu_ef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_ef.Click
        On Error GoTo Err_submenu_ef_Click
        form_ef_sistemas.TopLevel = False
        form_ef_sistemas.MdiParent = Me
        form_ef_sistemas.Show()
Exit_submenu_ef_Click:
        Exit Sub

Err_submenu_ef_Click:
        MsgBox(Err.Description)
        Resume Exit_submenu_ef_Click
    End Sub

    Private Sub submenu_descontos_titulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_descontos_titulos.Click
        On Error GoTo Err_submenu_descontos_titulos_Click
        form_descontos_titulos.TopLevel = False
        form_descontos_titulos.MdiParent = Me
        form_descontos_titulos.Show()
Exit_submenu_descontos_titulos_Click:
        Exit Sub

Err_submenu_descontos_titulos_Click:
        MsgBox(Err.Description)
        Resume Exit_submenu_descontos_titulos_Click
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        On Error GoTo Err_AboutToolStripMenuItem_Click
        caixadescricao_profinanceira.ShowDialog()
Exit_AboutToolStripMenuItem_Click:
        Exit Sub

Err_AboutToolStripMenuItem_Click:
        MsgBox(Err.Description)
        Resume Exit_AboutToolStripMenuItem_Click
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        On Error GoTo Err_ContentsToolStripMenuItem_Click
        'Dim messageOutput As String
        'messageOutput = My.Application.Info.DirectoryPath & "\Help ProFinanceira\HelpProFinanceira.chm"
        'Help.ShowHelp(Me, messageOutput)
        System.Diagnostics.Process.Start("http://www.profinanceira.com.br/Biblioteca/Biblioteca.aspx")
Exit_ContentsToolStripMenuItem_Click:
        Exit Sub

Err_ContentsToolStripMenuItem_Click:
        MsgBox(Err.Description)
        Resume Exit_ContentsToolStripMenuItem_Click
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        On Error GoTo Err_CalculadoraToolStripMenuItem_Click
        Shell("calc.exe", AppWinStyle.NormalFocus)
Exit_CalculadoraToolStripMenuItem_Click:
        Exit Sub

Err_CalculadoraToolStripMenuItem_Click:
        MsgBox(Err.Description)
        Resume Exit_CalculadoraToolStripMenuItem_Click
    End Sub

    Private Sub OpçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpçõesToolStripMenuItem.Click
        On Error GoTo Exit_OpçõesToolStripMenuItem_Click
        form_opcoes.TopLevel = False
        form_opcoes.MdiParent = Me
        form_opcoes.Show()
Exit_OpçõesToolStripMenuItem_Click:
        Exit Sub

Err_OpçõesToolStripMenuItem_Click:
        MsgBox(Err.Description)
        Resume Err_OpçõesToolStripMenuItem_Click
    End Sub

    Private Sub MétodoHamburguêsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MétodoHamburguêsToolStripMenuItem.Click
        On Error GoTo Exit_MétodoHamburguêsToolStripMenuItem_Click
        form_metodo_hamburgues.TopLevel = False
        form_metodo_hamburgues.MdiParent = Me
        form_metodo_hamburgues.Show()
Exit_MétodoHamburguêsToolStripMenuItem_Click:
        Exit Sub

Err_MétodoHamburguêsToolStripMenuItem_Click:
        MsgBox(Err.Description)
        Resume Err_MétodoHamburguêsToolStripMenuItem_Click
    End Sub
End Class