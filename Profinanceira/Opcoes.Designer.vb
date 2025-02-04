<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_opcoes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Indexes")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Periods")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Loans and Financing", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_opcoes))
        Me.TreeView_opcoes = New System.Windows.Forms.TreeView
        Me.painel_opcoes = New System.Windows.Forms.Panel
        Me.DataGridView_opcoes = New System.Windows.Forms.DataGridView
        Me.texto_carregar_n_periodos = New System.Windows.Forms.Label
        Me.caixatexto_carregar_n_periodos = New System.Windows.Forms.TextBox
        Me.btn_carregar_opcoes = New System.Windows.Forms.Button
        Me.btn_ok_opcoes = New System.Windows.Forms.Button
        Me.btn_cancelar_opcoes = New System.Windows.Forms.Button
        Me.btn_salvar_tabela_opcoes = New System.Windows.Forms.Button
        Me.texto_explicacao_opçoes = New System.Windows.Forms.Label
        Me.LoansAndFinancingDataSet = New Martius.LoansAndFinancingDataSet
        Me.IndicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IndicesTableAdapter = New Martius.LoansAndFinancingDataSetTableAdapters.IndicesTableAdapter
        Me.PeriodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodosTableAdapter = New Martius.LoansAndFinancingDataSetTableAdapters.PeriodosTableAdapter
        Me.painel_opcoes.SuspendLayout()
        CType(Me.DataGridView_opcoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoansAndFinancingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IndicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView_opcoes
        '
        Me.TreeView_opcoes.Location = New System.Drawing.Point(12, 12)
        Me.TreeView_opcoes.Name = "TreeView_opcoes"
        TreeNode1.Checked = True
        TreeNode1.Name = "ChildIndices"
        TreeNode1.Text = "Indexes"
        TreeNode2.Name = "ChildPeriodos"
        TreeNode2.Text = "Periods"
        TreeNode3.Name = "RootEmpFin"
        TreeNode3.Text = "Loans and Financing"
        Me.TreeView_opcoes.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.TreeView_opcoes.Size = New System.Drawing.Size(195, 307)
        Me.TreeView_opcoes.TabIndex = 0
        '
        'painel_opcoes
        '
        Me.painel_opcoes.Controls.Add(Me.DataGridView_opcoes)
        Me.painel_opcoes.Location = New System.Drawing.Point(240, 12)
        Me.painel_opcoes.Name = "painel_opcoes"
        Me.painel_opcoes.Size = New System.Drawing.Size(387, 278)
        Me.painel_opcoes.TabIndex = 7
        '
        'DataGridView_opcoes
        '
        Me.DataGridView_opcoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_opcoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_opcoes.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_opcoes.Name = "DataGridView_opcoes"
        Me.DataGridView_opcoes.Size = New System.Drawing.Size(387, 278)
        Me.DataGridView_opcoes.TabIndex = 0
        '
        'texto_carregar_n_periodos
        '
        Me.texto_carregar_n_periodos.AutoSize = True
        Me.texto_carregar_n_periodos.Location = New System.Drawing.Point(240, 301)
        Me.texto_carregar_n_periodos.Name = "texto_carregar_n_periodos"
        Me.texto_carregar_n_periodos.Size = New System.Drawing.Size(78, 13)
        Me.texto_carregar_n_periodos.TabIndex = 1
        Me.texto_carregar_n_periodos.Text = "Load up period"
        '
        'caixatexto_carregar_n_periodos
        '
        Me.caixatexto_carregar_n_periodos.Location = New System.Drawing.Point(324, 298)
        Me.caixatexto_carregar_n_periodos.Name = "caixatexto_carregar_n_periodos"
        Me.caixatexto_carregar_n_periodos.Size = New System.Drawing.Size(64, 20)
        Me.caixatexto_carregar_n_periodos.TabIndex = 2
        '
        'btn_carregar_opcoes
        '
        Me.btn_carregar_opcoes.Enabled = False
        Me.btn_carregar_opcoes.Location = New System.Drawing.Point(394, 296)
        Me.btn_carregar_opcoes.Name = "btn_carregar_opcoes"
        Me.btn_carregar_opcoes.Size = New System.Drawing.Size(75, 23)
        Me.btn_carregar_opcoes.TabIndex = 3
        Me.btn_carregar_opcoes.Text = "Load"
        Me.btn_carregar_opcoes.UseVisualStyleBackColor = True
        '
        'btn_ok_opcoes
        '
        Me.btn_ok_opcoes.Location = New System.Drawing.Point(471, 377)
        Me.btn_ok_opcoes.Name = "btn_ok_opcoes"
        Me.btn_ok_opcoes.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok_opcoes.TabIndex = 8
        Me.btn_ok_opcoes.Text = "OK"
        Me.btn_ok_opcoes.UseVisualStyleBackColor = True
        '
        'btn_cancelar_opcoes
        '
        Me.btn_cancelar_opcoes.Location = New System.Drawing.Point(552, 377)
        Me.btn_cancelar_opcoes.Name = "btn_cancelar_opcoes"
        Me.btn_cancelar_opcoes.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar_opcoes.TabIndex = 9
        Me.btn_cancelar_opcoes.Text = "Cancel"
        Me.btn_cancelar_opcoes.UseVisualStyleBackColor = True
        '
        'btn_salvar_tabela_opcoes
        '
        Me.btn_salvar_tabela_opcoes.Location = New System.Drawing.Point(543, 296)
        Me.btn_salvar_tabela_opcoes.Name = "btn_salvar_tabela_opcoes"
        Me.btn_salvar_tabela_opcoes.Size = New System.Drawing.Size(84, 23)
        Me.btn_salvar_tabela_opcoes.TabIndex = 10
        Me.btn_salvar_tabela_opcoes.Text = "Save table"
        Me.btn_salvar_tabela_opcoes.UseVisualStyleBackColor = True
        '
        'texto_explicacao_opçoes
        '
        Me.texto_explicacao_opçoes.AutoSize = True
        Me.texto_explicacao_opçoes.Location = New System.Drawing.Point(208, 341)
        Me.texto_explicacao_opçoes.Name = "texto_explicacao_opçoes"
        Me.texto_explicacao_opçoes.Size = New System.Drawing.Size(419, 13)
        Me.texto_explicacao_opçoes.TabIndex = 11
        Me.texto_explicacao_opçoes.Text = "Save the values and load them in the table of loans and financing (indexes and pe" & _
            "riods)"
        '
        'LoansAndFinancingDataSet
        '
        Me.LoansAndFinancingDataSet.DataSetName = "LoansAndFinancingDataSet"
        Me.LoansAndFinancingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IndicesBindingSource
        '
        Me.IndicesBindingSource.DataMember = "Indices"
        Me.IndicesBindingSource.DataSource = Me.LoansAndFinancingDataSet
        '
        'IndicesTableAdapter
        '
        Me.IndicesTableAdapter.ClearBeforeFill = True
        '
        'PeriodosBindingSource
        '
        Me.PeriodosBindingSource.DataMember = "Periodos"
        Me.PeriodosBindingSource.DataSource = Me.LoansAndFinancingDataSet
        '
        'PeriodosTableAdapter
        '
        Me.PeriodosTableAdapter.ClearBeforeFill = True
        '
        'form_opcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 409)
        Me.Controls.Add(Me.texto_explicacao_opçoes)
        Me.Controls.Add(Me.btn_salvar_tabela_opcoes)
        Me.Controls.Add(Me.btn_cancelar_opcoes)
        Me.Controls.Add(Me.btn_ok_opcoes)
        Me.Controls.Add(Me.btn_carregar_opcoes)
        Me.Controls.Add(Me.painel_opcoes)
        Me.Controls.Add(Me.caixatexto_carregar_n_periodos)
        Me.Controls.Add(Me.TreeView_opcoes)
        Me.Controls.Add(Me.texto_carregar_n_periodos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_opcoes"
        Me.Text = "Options"
        Me.painel_opcoes.ResumeLayout(False)
        CType(Me.DataGridView_opcoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoansAndFinancingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IndicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView_opcoes As System.Windows.Forms.TreeView
    Friend WithEvents painel_opcoes As System.Windows.Forms.Panel
    Friend WithEvents DataGridView_opcoes As System.Windows.Forms.DataGridView
    Friend WithEvents caixatexto_carregar_n_periodos As System.Windows.Forms.TextBox
    Friend WithEvents texto_carregar_n_periodos As System.Windows.Forms.Label
    Friend WithEvents btn_carregar_opcoes As System.Windows.Forms.Button
    Friend WithEvents btn_ok_opcoes As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar_opcoes As System.Windows.Forms.Button
    Friend WithEvents btn_salvar_tabela_opcoes As System.Windows.Forms.Button
    Friend WithEvents texto_explicacao_opçoes As System.Windows.Forms.Label
    Friend WithEvents LoansAndFinancingDataSet As Martius.LoansAndFinancingDataSet
    Friend WithEvents IndicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IndicesTableAdapter As Martius.LoansAndFinancingDataSetTableAdapters.IndicesTableAdapter
    Friend WithEvents PeriodosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodosTableAdapter As Martius.LoansAndFinancingDataSetTableAdapters.PeriodosTableAdapter
End Class
