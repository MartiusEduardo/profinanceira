<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_metodo_hamburgues
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_metodo_hamburgues))
        Me.dgvJurosECB = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACBInterestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACBInterestDataSet = New Martius.ACBInterestDataSet()
        Me.texto_taxa_mh = New System.Windows.Forms.Label()
        Me.caixatexto_taxa_mh = New System.Windows.Forms.TextBox()
        Me.texto_prazo_medio_mh = New System.Windows.Forms.Label()
        Me.texto_metodo_hamburgues_mh = New System.Windows.Forms.Label()
        Me.caixatexto_prazo_medio_mh = New System.Windows.Forms.TextBox()
        Me.caixatexto_metodo_hamburgues_mh = New System.Windows.Forms.TextBox()
        Me.btn_calcular_mh = New System.Windows.Forms.Button()
        Me.texto_explicacao_mh = New System.Windows.Forms.Label()
        Me.ACBInterestTableAdapter = New Martius.ACBInterestDataSetTableAdapters.ACBInterestTableAdapter()
        Me.TableAdapterManager = New Martius.ACBInterestDataSetTableAdapters.TableAdapterManager()
        Me.ACBInterestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ACBInterestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvJurosECB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACBInterestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACBInterestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACBInterestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ACBInterestBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvJurosECB
        '
        Me.dgvJurosECB.AutoGenerateColumns = False
        Me.dgvJurosECB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJurosECB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.EntryDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.InterestDataGridViewTextBoxColumn, Me.NPerDataGridViewTextBoxColumn})
        Me.dgvJurosECB.DataSource = Me.ACBInterestBindingSource
        Me.dgvJurosECB.Location = New System.Drawing.Point(12, 28)
        Me.dgvJurosECB.Name = "dgvJurosECB"
        Me.dgvJurosECB.Size = New System.Drawing.Size(759, 242)
        Me.dgvJurosECB.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'EntryDataGridViewTextBoxColumn
        '
        Me.EntryDataGridViewTextBoxColumn.DataPropertyName = "Entry"
        Me.EntryDataGridViewTextBoxColumn.HeaderText = "Entry"
        Me.EntryDataGridViewTextBoxColumn.Name = "EntryDataGridViewTextBoxColumn"
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        '
        'InterestDataGridViewTextBoxColumn
        '
        Me.InterestDataGridViewTextBoxColumn.DataPropertyName = "Interest"
        Me.InterestDataGridViewTextBoxColumn.HeaderText = "Interest"
        Me.InterestDataGridViewTextBoxColumn.Name = "InterestDataGridViewTextBoxColumn"
        '
        'NPerDataGridViewTextBoxColumn
        '
        Me.NPerDataGridViewTextBoxColumn.DataPropertyName = "NPer"
        Me.NPerDataGridViewTextBoxColumn.HeaderText = "NPer"
        Me.NPerDataGridViewTextBoxColumn.Name = "NPerDataGridViewTextBoxColumn"
        '
        'ACBInterestBindingSource
        '
        Me.ACBInterestBindingSource.DataMember = "ACBInterest"
        Me.ACBInterestBindingSource.DataSource = Me.ACBInterestDataSet
        '
        'ACBInterestDataSet
        '
        Me.ACBInterestDataSet.DataSetName = "ACBInterestDataSet"
        Me.ACBInterestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'texto_taxa_mh
        '
        Me.texto_taxa_mh.AutoSize = True
        Me.texto_taxa_mh.Location = New System.Drawing.Point(9, 294)
        Me.texto_taxa_mh.Name = "texto_taxa_mh"
        Me.texto_taxa_mh.Size = New System.Drawing.Size(33, 13)
        Me.texto_taxa_mh.TabIndex = 1
        Me.texto_taxa_mh.Text = "Rate:"
        '
        'caixatexto_taxa_mh
        '
        Me.caixatexto_taxa_mh.Location = New System.Drawing.Point(49, 291)
        Me.caixatexto_taxa_mh.Name = "caixatexto_taxa_mh"
        Me.caixatexto_taxa_mh.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_taxa_mh.TabIndex = 2
        '
        'texto_prazo_medio_mh
        '
        Me.texto_prazo_medio_mh.AutoSize = True
        Me.texto_prazo_medio_mh.Location = New System.Drawing.Point(155, 294)
        Me.texto_prazo_medio_mh.Name = "texto_prazo_medio_mh"
        Me.texto_prazo_medio_mh.Size = New System.Drawing.Size(72, 13)
        Me.texto_prazo_medio_mh.TabIndex = 3
        Me.texto_prazo_medio_mh.Text = "Average time:"
        '
        'texto_metodo_hamburgues_mh
        '
        Me.texto_metodo_hamburgues_mh.AutoSize = True
        Me.texto_metodo_hamburgues_mh.Location = New System.Drawing.Point(339, 294)
        Me.texto_metodo_hamburgues_mh.Name = "texto_metodo_hamburgues_mh"
        Me.texto_metodo_hamburgues_mh.Size = New System.Drawing.Size(115, 13)
        Me.texto_metodo_hamburgues_mh.TabIndex = 4
        Me.texto_metodo_hamburgues_mh.Text = "Method Hamburguese:"
        '
        'caixatexto_prazo_medio_mh
        '
        Me.caixatexto_prazo_medio_mh.Location = New System.Drawing.Point(233, 291)
        Me.caixatexto_prazo_medio_mh.Name = "caixatexto_prazo_medio_mh"
        Me.caixatexto_prazo_medio_mh.ReadOnly = True
        Me.caixatexto_prazo_medio_mh.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_prazo_medio_mh.TabIndex = 5
        '
        'caixatexto_metodo_hamburgues_mh
        '
        Me.caixatexto_metodo_hamburgues_mh.Location = New System.Drawing.Point(460, 291)
        Me.caixatexto_metodo_hamburgues_mh.Name = "caixatexto_metodo_hamburgues_mh"
        Me.caixatexto_metodo_hamburgues_mh.ReadOnly = True
        Me.caixatexto_metodo_hamburgues_mh.Size = New System.Drawing.Size(100, 20)
        Me.caixatexto_metodo_hamburgues_mh.TabIndex = 6
        '
        'btn_calcular_mh
        '
        Me.btn_calcular_mh.Location = New System.Drawing.Point(566, 289)
        Me.btn_calcular_mh.Name = "btn_calcular_mh"
        Me.btn_calcular_mh.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular_mh.TabIndex = 7
        Me.btn_calcular_mh.Text = "Calculate"
        Me.btn_calcular_mh.UseVisualStyleBackColor = True
        '
        'texto_explicacao_mh
        '
        Me.texto_explicacao_mh.AutoSize = True
        Me.texto_explicacao_mh.Location = New System.Drawing.Point(9, 323)
        Me.texto_explicacao_mh.Name = "texto_explicacao_mh"
        Me.texto_explicacao_mh.Size = New System.Drawing.Size(189, 52)
        Me.texto_explicacao_mh.TabIndex = 8
        Me.texto_explicacao_mh.Text = "Average time = ∑Si * Ni / ∑Si" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Method Hamburguese = rate * ∑Si * Ni" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Where: Si " & _
    "= Balance; Ni = NPer"
        '
        'ACBInterestTableAdapter
        '
        Me.ACBInterestTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ACBInterestTableAdapter = Me.ACBInterestTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Martius.ACBInterestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ACBInterestBindingNavigator
        '
        Me.ACBInterestBindingNavigator.AddNewItem = Nothing
        Me.ACBInterestBindingNavigator.BindingSource = Me.ACBInterestBindingSource
        Me.ACBInterestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ACBInterestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ACBInterestBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ACBInterestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ACBInterestBindingNavigatorSaveItem})
        Me.ACBInterestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ACBInterestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ACBInterestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ACBInterestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ACBInterestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ACBInterestBindingNavigator.Name = "ACBInterestBindingNavigator"
        Me.ACBInterestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ACBInterestBindingNavigator.Size = New System.Drawing.Size(791, 25)
        Me.ACBInterestBindingNavigator.TabIndex = 9
        Me.ACBInterestBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ACBInterestBindingNavigatorSaveItem
        '
        Me.ACBInterestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ACBInterestBindingNavigatorSaveItem.Image = CType(resources.GetObject("ACBInterestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ACBInterestBindingNavigatorSaveItem.Name = "ACBInterestBindingNavigatorSaveItem"
        Me.ACBInterestBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ACBInterestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'form_metodo_hamburgues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 397)
        Me.Controls.Add(Me.ACBInterestBindingNavigator)
        Me.Controls.Add(Me.texto_explicacao_mh)
        Me.Controls.Add(Me.btn_calcular_mh)
        Me.Controls.Add(Me.caixatexto_metodo_hamburgues_mh)
        Me.Controls.Add(Me.caixatexto_prazo_medio_mh)
        Me.Controls.Add(Me.texto_metodo_hamburgues_mh)
        Me.Controls.Add(Me.texto_prazo_medio_mh)
        Me.Controls.Add(Me.caixatexto_taxa_mh)
        Me.Controls.Add(Me.texto_taxa_mh)
        Me.Controls.Add(Me.dgvJurosECB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_metodo_hamburgues"
        Me.Text = "Method Hamburguese"
        CType(Me.dgvJurosECB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACBInterestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACBInterestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACBInterestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ACBInterestBindingNavigator.ResumeLayout(False)
        Me.ACBInterestBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvJurosECB As System.Windows.Forms.DataGridView
    Friend WithEvents texto_taxa_mh As System.Windows.Forms.Label
    Friend WithEvents caixatexto_taxa_mh As System.Windows.Forms.TextBox
    Friend WithEvents texto_prazo_medio_mh As System.Windows.Forms.Label
    Friend WithEvents texto_metodo_hamburgues_mh As System.Windows.Forms.Label
    Friend WithEvents caixatexto_prazo_medio_mh As System.Windows.Forms.TextBox
    Friend WithEvents caixatexto_metodo_hamburgues_mh As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular_mh As System.Windows.Forms.Button
    Friend WithEvents texto_explicacao_mh As System.Windows.Forms.Label
    Friend WithEvents ACBInterestDataSet As Martius.ACBInterestDataSet
    Friend WithEvents ACBInterestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACBInterestTableAdapter As Martius.ACBInterestDataSetTableAdapters.ACBInterestTableAdapter
    Friend WithEvents TableAdapterManager As Martius.ACBInterestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ACBInterestBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ACBInterestBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterestDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
