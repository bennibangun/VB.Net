<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pendidikan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pendidikan))
        Me.BindingNavigatorPendidikan = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewPendidikan = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourcePendidikan = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeletePendidikan = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgPendidikan = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenispendidikanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterPendidikan = New laboratorium.DataSet_LabTableAdapters.pendidikanTableAdapter()
        CType(Me.BindingNavigatorPendidikan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorPendidikan.SuspendLayout()
        CType(Me.BindingSourcePendidikan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPendidikan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorPendidikan
        '
        Me.BindingNavigatorPendidikan.AddNewItem = Me.BindingNavigatorAddNewPendidikan
        Me.BindingNavigatorPendidikan.BindingSource = Me.BindingSourcePendidikan
        Me.BindingNavigatorPendidikan.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorPendidikan.DeleteItem = Nothing
        Me.BindingNavigatorPendidikan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewPendidikan, Me.BindingNavigatorDeletePendidikan, Me.ButtonSave})
        Me.BindingNavigatorPendidikan.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorPendidikan.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorPendidikan.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorPendidikan.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorPendidikan.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorPendidikan.Name = "BindingNavigatorPendidikan"
        Me.BindingNavigatorPendidikan.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorPendidikan.Size = New System.Drawing.Size(688, 25)
        Me.BindingNavigatorPendidikan.TabIndex = 3
        Me.BindingNavigatorPendidikan.Text = "Pendidikan"
        '
        'BindingNavigatorAddNewPendidikan
        '
        Me.BindingNavigatorAddNewPendidikan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewPendidikan.Image = CType(resources.GetObject("BindingNavigatorAddNewPendidikan.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewPendidikan.Name = "BindingNavigatorAddNewPendidikan"
        Me.BindingNavigatorAddNewPendidikan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewPendidikan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewPendidikan.Text = "Tambah data dokter"
        '
        'BindingSourcePendidikan
        '
        Me.BindingSourcePendidikan.DataMember = "pendidikan"
        Me.BindingSourcePendidikan.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'BindingNavigatorDeletePendidikan
        '
        Me.BindingNavigatorDeletePendidikan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeletePendidikan.Image = CType(resources.GetObject("BindingNavigatorDeletePendidikan.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeletePendidikan.Name = "BindingNavigatorDeletePendidikan"
        Me.BindingNavigatorDeletePendidikan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeletePendidikan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeletePendidikan.Text = "Delete pasien"
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
        Me.btnExit.Location = New System.Drawing.Point(472, 46)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(361, 46)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 15
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 48)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 14
        '
        'dgPendidikan
        '
        Me.dgPendidikan.AllowUserToAddRows = False
        Me.dgPendidikan.AutoGenerateColumns = False
        Me.dgPendidikan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPendidikan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.JenispendidikanDataGridViewTextBoxColumn})
        Me.dgPendidikan.DataSource = Me.BindingSourcePendidikan
        Me.dgPendidikan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgPendidikan.Location = New System.Drawing.Point(0, 104)
        Me.dgPendidikan.Name = "dgPendidikan"
        Me.dgPendidikan.Size = New System.Drawing.Size(688, 463)
        Me.dgPendidikan.TabIndex = 17
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'JenispendidikanDataGridViewTextBoxColumn
        '
        Me.JenispendidikanDataGridViewTextBoxColumn.DataPropertyName = "jenis_pendidikan"
        Me.JenispendidikanDataGridViewTextBoxColumn.HeaderText = "Pendidikan"
        Me.JenispendidikanDataGridViewTextBoxColumn.Name = "JenispendidikanDataGridViewTextBoxColumn"
        Me.JenispendidikanDataGridViewTextBoxColumn.Width = 200
        '
        'TableAdapterPendidikan
        '
        Me.TableAdapterPendidikan.ClearBeforeFill = True
        '
        'pendidikan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 567)
        Me.Controls.Add(Me.dgPendidikan)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorPendidikan)
        Me.Name = "pendidikan"
        Me.Text = "Pendidikan"
        CType(Me.BindingNavigatorPendidikan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorPendidikan.ResumeLayout(False)
        Me.BindingNavigatorPendidikan.PerformLayout()
        CType(Me.BindingSourcePendidikan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPendidikan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorPendidikan As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewPendidikan As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeletePendidikan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgPendidikan As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents BindingSourcePendidikan As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterPendidikan As laboratorium.DataSet_LabTableAdapters.pendidikanTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenispendidikanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
