<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pekerjaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pekerjaan))
        Me.BindingNavigatorPekerjaan = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewPekerjaan = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeletePekerjaan = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgPekerjaan = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenispekerjaanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourcePekerjaan = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.TableAdapterPekerjaan = New laboratorium.DataSet_LabTableAdapters.pekerjaanTableAdapter()
        CType(Me.BindingNavigatorPekerjaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorPekerjaan.SuspendLayout()
        CType(Me.dgPekerjaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourcePekerjaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorPekerjaan
        '
        Me.BindingNavigatorPekerjaan.AddNewItem = Me.BindingNavigatorAddNewPekerjaan
        Me.BindingNavigatorPekerjaan.BindingSource = Me.BindingSourcePekerjaan
        Me.BindingNavigatorPekerjaan.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorPekerjaan.DeleteItem = Nothing
        Me.BindingNavigatorPekerjaan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewPekerjaan, Me.BindingNavigatorDeletePekerjaan, Me.ButtonSave})
        Me.BindingNavigatorPekerjaan.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorPekerjaan.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorPekerjaan.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorPekerjaan.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorPekerjaan.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorPekerjaan.Name = "BindingNavigatorPekerjaan"
        Me.BindingNavigatorPekerjaan.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorPekerjaan.Size = New System.Drawing.Size(688, 25)
        Me.BindingNavigatorPekerjaan.TabIndex = 4
        Me.BindingNavigatorPekerjaan.Text = "Pekerjaan"
        '
        'BindingNavigatorAddNewPekerjaan
        '
        Me.BindingNavigatorAddNewPekerjaan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewPekerjaan.Image = CType(resources.GetObject("BindingNavigatorAddNewPekerjaan.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewPekerjaan.Name = "BindingNavigatorAddNewPekerjaan"
        Me.BindingNavigatorAddNewPekerjaan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewPekerjaan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewPekerjaan.Text = "Tambah data dokter"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'BindingNavigatorDeletePekerjaan
        '
        Me.BindingNavigatorDeletePekerjaan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeletePekerjaan.Image = CType(resources.GetObject("BindingNavigatorDeletePekerjaan.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeletePekerjaan.Name = "BindingNavigatorDeletePekerjaan"
        Me.BindingNavigatorDeletePekerjaan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeletePekerjaan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeletePekerjaan.Text = "Delete pekerjaan"
        '
        'ButtonSave
        '
        Me.ButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSave.Image = Global.laboratorium.My.Resources.Resources.save
        Me.ButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(23, 22)
        Me.ButtonSave.Text = "Simpan data dokter"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(473, 46)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(362, 46)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 18
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(7, 48)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 17
        '
        'dgPekerjaan
        '
        Me.dgPekerjaan.AllowUserToAddRows = False
        Me.dgPekerjaan.AutoGenerateColumns = False
        Me.dgPekerjaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPekerjaan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.JenispekerjaanDataGridViewTextBoxColumn})
        Me.dgPekerjaan.DataSource = Me.BindingSourcePekerjaan
        Me.dgPekerjaan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgPekerjaan.Location = New System.Drawing.Point(0, 104)
        Me.dgPekerjaan.Name = "dgPekerjaan"
        Me.dgPekerjaan.Size = New System.Drawing.Size(688, 463)
        Me.dgPekerjaan.TabIndex = 20
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'JenispekerjaanDataGridViewTextBoxColumn
        '
        Me.JenispekerjaanDataGridViewTextBoxColumn.DataPropertyName = "jenis_pekerjaan"
        Me.JenispekerjaanDataGridViewTextBoxColumn.HeaderText = "Pekerjaan"
        Me.JenispekerjaanDataGridViewTextBoxColumn.Name = "JenispekerjaanDataGridViewTextBoxColumn"
        Me.JenispekerjaanDataGridViewTextBoxColumn.Width = 200
        '
        'BindingSourcePekerjaan
        '
        Me.BindingSourcePekerjaan.DataMember = "pekerjaan"
        Me.BindingSourcePekerjaan.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterPekerjaan
        '
        Me.TableAdapterPekerjaan.ClearBeforeFill = True
        '
        'pekerjaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 567)
        Me.Controls.Add(Me.dgPekerjaan)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorPekerjaan)
        Me.Name = "pekerjaan"
        Me.Text = "Jenis Pekerjaan"
        CType(Me.BindingNavigatorPekerjaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorPekerjaan.ResumeLayout(False)
        Me.BindingNavigatorPekerjaan.PerformLayout()
        CType(Me.dgPekerjaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourcePekerjaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorPekerjaan As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewPekerjaan As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeletePekerjaan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgPekerjaan As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourcePekerjaan As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterPekerjaan As laboratorium.DataSet_LabTableAdapters.pekerjaanTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenispekerjaanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
