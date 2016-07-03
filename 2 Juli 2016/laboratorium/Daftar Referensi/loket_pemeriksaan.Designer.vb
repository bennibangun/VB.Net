<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loket_pemeriksaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loket_pemeriksaan))
        Me.BindingNavigatorLoketPemeriksaan = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewLoketPemeriksaan = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourceLoketPemeriksaan = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BindingNavigatorDeleteLoketPemeriksaan = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterLoketPemeriksaan = New laboratorium.DataSet_LabTableAdapters.loket_pemeriksaanTableAdapter()
        Me.dgLoketPemeriksaan = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaloketpemeriksaanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingNavigatorLoketPemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorLoketPemeriksaan.SuspendLayout()
        CType(Me.BindingSourceLoketPemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLoketPemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorLoketPemeriksaan
        '
        Me.BindingNavigatorLoketPemeriksaan.AddNewItem = Me.BindingNavigatorAddNewLoketPemeriksaan
        Me.BindingNavigatorLoketPemeriksaan.BindingSource = Me.BindingSourceLoketPemeriksaan
        Me.BindingNavigatorLoketPemeriksaan.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorLoketPemeriksaan.DeleteItem = Nothing
        Me.BindingNavigatorLoketPemeriksaan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewLoketPemeriksaan, Me.BindingNavigatorDeleteLoketPemeriksaan, Me.ButtonSave})
        Me.BindingNavigatorLoketPemeriksaan.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorLoketPemeriksaan.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorLoketPemeriksaan.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorLoketPemeriksaan.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorLoketPemeriksaan.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorLoketPemeriksaan.Name = "BindingNavigatorLoketPemeriksaan"
        Me.BindingNavigatorLoketPemeriksaan.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorLoketPemeriksaan.Size = New System.Drawing.Size(688, 25)
        Me.BindingNavigatorLoketPemeriksaan.TabIndex = 5
        Me.BindingNavigatorLoketPemeriksaan.Text = "Pendidikan"
        '
        'BindingNavigatorAddNewLoketPemeriksaan
        '
        Me.BindingNavigatorAddNewLoketPemeriksaan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewLoketPemeriksaan.Image = CType(resources.GetObject("BindingNavigatorAddNewLoketPemeriksaan.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewLoketPemeriksaan.Name = "BindingNavigatorAddNewLoketPemeriksaan"
        Me.BindingNavigatorAddNewLoketPemeriksaan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewLoketPemeriksaan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewLoketPemeriksaan.Text = "Tambah data dokter"
        '
        'BindingSourceLoketPemeriksaan
        '
        Me.BindingSourceLoketPemeriksaan.DataMember = "loket_pemeriksaan"
        Me.BindingSourceLoketPemeriksaan.DataSource = Me.DataSet_Lab
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
        'BindingNavigatorDeleteLoketPemeriksaan
        '
        Me.BindingNavigatorDeleteLoketPemeriksaan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteLoketPemeriksaan.Image = CType(resources.GetObject("BindingNavigatorDeleteLoketPemeriksaan.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteLoketPemeriksaan.Name = "BindingNavigatorDeleteLoketPemeriksaan"
        Me.BindingNavigatorDeleteLoketPemeriksaan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteLoketPemeriksaan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteLoketPemeriksaan.Text = "Delete pasien"
        '
        'ButtonSave
        '
        Me.ButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(23, 22)
        Me.ButtonSave.Text = "Simpan data dokter"
        '
        'TableAdapterLoketPemeriksaan
        '
        Me.TableAdapterLoketPemeriksaan.ClearBeforeFill = True
        '
        'dgLoketPemeriksaan
        '
        Me.dgLoketPemeriksaan.AllowUserToAddRows = False
        Me.dgLoketPemeriksaan.AutoGenerateColumns = False
        Me.dgLoketPemeriksaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLoketPemeriksaan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NamaloketpemeriksaanDataGridViewTextBoxColumn})
        Me.dgLoketPemeriksaan.DataSource = Me.BindingSourceLoketPemeriksaan
        Me.dgLoketPemeriksaan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgLoketPemeriksaan.Location = New System.Drawing.Point(0, 92)
        Me.dgLoketPemeriksaan.Name = "dgLoketPemeriksaan"
        Me.dgLoketPemeriksaan.Size = New System.Drawing.Size(688, 463)
        Me.dgLoketPemeriksaan.TabIndex = 21
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(472, 43)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(361, 43)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 23
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 45)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 22
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'NamaloketpemeriksaanDataGridViewTextBoxColumn
        '
        Me.NamaloketpemeriksaanDataGridViewTextBoxColumn.DataPropertyName = "nama_loket_pemeriksaan"
        Me.NamaloketpemeriksaanDataGridViewTextBoxColumn.HeaderText = "Bagian"
        Me.NamaloketpemeriksaanDataGridViewTextBoxColumn.Name = "NamaloketpemeriksaanDataGridViewTextBoxColumn"
        Me.NamaloketpemeriksaanDataGridViewTextBoxColumn.Width = 300
        '
        'loket_pemeriksaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 555)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgLoketPemeriksaan)
        Me.Controls.Add(Me.BindingNavigatorLoketPemeriksaan)
        Me.Name = "loket_pemeriksaan"
        Me.Text = "Bagian"
        CType(Me.BindingNavigatorLoketPemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorLoketPemeriksaan.ResumeLayout(False)
        Me.BindingNavigatorLoketPemeriksaan.PerformLayout()
        CType(Me.BindingSourceLoketPemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLoketPemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorLoketPemeriksaan As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewLoketPemeriksaan As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteLoketPemeriksaan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingSourceLoketPemeriksaan As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterLoketPemeriksaan As laboratorium.DataSet_LabTableAdapters.loket_pemeriksaanTableAdapter
    Friend WithEvents dgLoketPemeriksaan As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaloketpemeriksaanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
