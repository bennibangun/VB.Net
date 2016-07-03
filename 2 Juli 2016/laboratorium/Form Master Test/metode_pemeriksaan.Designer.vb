<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class metode_pemeriksaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(metode_pemeriksaan))
        Me.BindingNavigatorMetodePemeriksaan = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewMetodePemeriksaan = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourceMetodePemeriksaan = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BindingNavigatorDeleteMetodePemeriksaan = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgMetodePemeriksaan = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamametodepemeriksaanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterMetodePemeriksaan = New laboratorium.DataSet_LabTableAdapters.metode_pemeriksaanTableAdapter()
        CType(Me.BindingNavigatorMetodePemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorMetodePemeriksaan.SuspendLayout()
        CType(Me.BindingSourceMetodePemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMetodePemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorMetodePemeriksaan
        '
        Me.BindingNavigatorMetodePemeriksaan.AddNewItem = Me.BindingNavigatorAddNewMetodePemeriksaan
        Me.BindingNavigatorMetodePemeriksaan.BindingSource = Me.BindingSourceMetodePemeriksaan
        Me.BindingNavigatorMetodePemeriksaan.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorMetodePemeriksaan.DeleteItem = Nothing
        Me.BindingNavigatorMetodePemeriksaan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewMetodePemeriksaan, Me.BindingNavigatorDeleteMetodePemeriksaan, Me.ButtonSave})
        Me.BindingNavigatorMetodePemeriksaan.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorMetodePemeriksaan.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorMetodePemeriksaan.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorMetodePemeriksaan.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorMetodePemeriksaan.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorMetodePemeriksaan.Name = "BindingNavigatorMetodePemeriksaan"
        Me.BindingNavigatorMetodePemeriksaan.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorMetodePemeriksaan.Size = New System.Drawing.Size(688, 25)
        Me.BindingNavigatorMetodePemeriksaan.TabIndex = 6
        Me.BindingNavigatorMetodePemeriksaan.Text = "Pendidikan"
        '
        'BindingNavigatorAddNewMetodePemeriksaan
        '
        Me.BindingNavigatorAddNewMetodePemeriksaan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewMetodePemeriksaan.Image = CType(resources.GetObject("BindingNavigatorAddNewMetodePemeriksaan.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewMetodePemeriksaan.Name = "BindingNavigatorAddNewMetodePemeriksaan"
        Me.BindingNavigatorAddNewMetodePemeriksaan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewMetodePemeriksaan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewMetodePemeriksaan.Text = "Tambah data dokter"
        '
        'BindingSourceMetodePemeriksaan
        '
        Me.BindingSourceMetodePemeriksaan.DataMember = "metode_pemeriksaan"
        Me.BindingSourceMetodePemeriksaan.DataSource = Me.DataSet_Lab
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
        'BindingNavigatorDeleteMetodePemeriksaan
        '
        Me.BindingNavigatorDeleteMetodePemeriksaan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteMetodePemeriksaan.Image = CType(resources.GetObject("BindingNavigatorDeleteMetodePemeriksaan.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteMetodePemeriksaan.Name = "BindingNavigatorDeleteMetodePemeriksaan"
        Me.BindingNavigatorDeleteMetodePemeriksaan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteMetodePemeriksaan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteMetodePemeriksaan.Text = "Delete"
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
        Me.btnExit.Location = New System.Drawing.Point(472, 42)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(361, 42)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 27
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 44)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 26
        '
        'dgMetodePemeriksaan
        '
        Me.dgMetodePemeriksaan.AllowUserToAddRows = False
        Me.dgMetodePemeriksaan.AutoGenerateColumns = False
        Me.dgMetodePemeriksaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMetodePemeriksaan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NamametodepemeriksaanDataGridViewTextBoxColumn})
        Me.dgMetodePemeriksaan.DataSource = Me.BindingSourceMetodePemeriksaan
        Me.dgMetodePemeriksaan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgMetodePemeriksaan.Location = New System.Drawing.Point(0, 86)
        Me.dgMetodePemeriksaan.Name = "dgMetodePemeriksaan"
        Me.dgMetodePemeriksaan.Size = New System.Drawing.Size(688, 463)
        Me.dgMetodePemeriksaan.TabIndex = 25
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'NamametodepemeriksaanDataGridViewTextBoxColumn
        '
        Me.NamametodepemeriksaanDataGridViewTextBoxColumn.DataPropertyName = "nama_metode_pemeriksaan"
        Me.NamametodepemeriksaanDataGridViewTextBoxColumn.HeaderText = "Metode Pemeriksaan"
        Me.NamametodepemeriksaanDataGridViewTextBoxColumn.Name = "NamametodepemeriksaanDataGridViewTextBoxColumn"
        Me.NamametodepemeriksaanDataGridViewTextBoxColumn.Width = 300
        '
        'TableAdapterMetodePemeriksaan
        '
        Me.TableAdapterMetodePemeriksaan.ClearBeforeFill = True
        '
        'metode_pemeriksaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 549)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgMetodePemeriksaan)
        Me.Controls.Add(Me.BindingNavigatorMetodePemeriksaan)
        Me.Name = "metode_pemeriksaan"
        Me.Text = "Metode Pemeriksaan"
        CType(Me.BindingNavigatorMetodePemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorMetodePemeriksaan.ResumeLayout(False)
        Me.BindingNavigatorMetodePemeriksaan.PerformLayout()
        CType(Me.BindingSourceMetodePemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMetodePemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorMetodePemeriksaan As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewMetodePemeriksaan As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteMetodePemeriksaan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgMetodePemeriksaan As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceMetodePemeriksaan As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterMetodePemeriksaan As laboratorium.DataSet_LabTableAdapters.metode_pemeriksaanTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamametodepemeriksaanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
