<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_supplier))
        Me.BindingNavigatorSupplier = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewSupplier = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourceSupplier = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteSupplier = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterSupplier = New laboratorium.DataSet_LabTableAdapters.supplierTableAdapter()
        Me.dgSupplier = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_kontak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pembayaran_fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NorekeningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RekeningatasnamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BankTableAdapter = New laboratorium.DataSet_LabTableAdapters.bankTableAdapter()
        CType(Me.BindingNavigatorSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorSupplier.SuspendLayout()
        CType(Me.BindingSourceSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorSupplier
        '
        Me.BindingNavigatorSupplier.AddNewItem = Me.BindingNavigatorAddNewSupplier
        Me.BindingNavigatorSupplier.BindingSource = Me.BindingSourceSupplier
        Me.BindingNavigatorSupplier.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorSupplier.DeleteItem = Me.BindingNavigatorDeleteSupplier
        Me.BindingNavigatorSupplier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewSupplier, Me.BindingNavigatorDeleteSupplier, Me.ButtonSave})
        Me.BindingNavigatorSupplier.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorSupplier.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorSupplier.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorSupplier.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorSupplier.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorSupplier.Name = "BindingNavigatorSupplier"
        Me.BindingNavigatorSupplier.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorSupplier.Size = New System.Drawing.Size(1370, 25)
        Me.BindingNavigatorSupplier.TabIndex = 1
        Me.BindingNavigatorSupplier.Text = "Rujukan"
        '
        'BindingNavigatorAddNewSupplier
        '
        Me.BindingNavigatorAddNewSupplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewSupplier.Image = CType(resources.GetObject("BindingNavigatorAddNewSupplier.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewSupplier.Name = "BindingNavigatorAddNewSupplier"
        Me.BindingNavigatorAddNewSupplier.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewSupplier.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewSupplier.Text = "Add new"
        '
        'BindingSourceSupplier
        '
        Me.BindingSourceSupplier.DataMember = "supplier"
        Me.BindingSourceSupplier.DataSource = Me.DataSet_Lab
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
        'BindingNavigatorDeleteSupplier
        '
        Me.BindingNavigatorDeleteSupplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteSupplier.Image = CType(resources.GetObject("BindingNavigatorDeleteSupplier.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteSupplier.Name = "BindingNavigatorDeleteSupplier"
        Me.BindingNavigatorDeleteSupplier.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteSupplier.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteSupplier.Text = "Delete"
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
        'ButtonSave
        '
        Me.ButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSave.Image = Global.laboratorium.My.Resources.Resources.save
        Me.ButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(23, 22)
        Me.ButtonSave.Text = "Save"
        '
        'TableAdapterSupplier
        '
        Me.TableAdapterSupplier.ClearBeforeFill = True
        '
        'dgSupplier
        '
        Me.dgSupplier.AllowUserToAddRows = False
        Me.dgSupplier.AutoGenerateColumns = False
        Me.dgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_kontak, Me.alamat, Me.FeeDataGridViewTextBoxColumn, Me.pembayaran_fee, Me.TeleponDataGridViewTextBoxColumn, Me.HpDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.BankDataGridViewTextBoxColumn, Me.NorekeningDataGridViewTextBoxColumn, Me.RekeningatasnamaDataGridViewTextBoxColumn})
        Me.dgSupplier.DataMember = "supplier"
        Me.dgSupplier.DataSource = Me.DataSet_Lab
        Me.dgSupplier.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgSupplier.Location = New System.Drawing.Point(0, 102)
        Me.dgSupplier.Name = "dgSupplier"
        Me.dgSupplier.Size = New System.Drawing.Size(1370, 433)
        Me.dgSupplier.TabIndex = 18
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 40
        '
        'nama_kontak
        '
        Me.nama_kontak.DataPropertyName = "nama_kontak"
        Me.nama_kontak.HeaderText = "Nama kontak"
        Me.nama_kontak.Name = "nama_kontak"
        '
        'alamat
        '
        Me.alamat.DataPropertyName = "alamat"
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.Width = 400
        '
        'FeeDataGridViewTextBoxColumn
        '
        Me.FeeDataGridViewTextBoxColumn.DataPropertyName = "fee"
        Me.FeeDataGridViewTextBoxColumn.HeaderText = "Fee"
        Me.FeeDataGridViewTextBoxColumn.Name = "FeeDataGridViewTextBoxColumn"
        Me.FeeDataGridViewTextBoxColumn.Width = 40
        '
        'pembayaran_fee
        '
        Me.pembayaran_fee.DataPropertyName = "pembayaran_fee"
        Me.pembayaran_fee.HeaderText = "Pembayaran fee"
        Me.pembayaran_fee.Name = "pembayaran_fee"
        Me.pembayaran_fee.Width = 90
        '
        'TeleponDataGridViewTextBoxColumn
        '
        Me.TeleponDataGridViewTextBoxColumn.DataPropertyName = "telepon"
        Me.TeleponDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.Name = "TeleponDataGridViewTextBoxColumn"
        Me.TeleponDataGridViewTextBoxColumn.Width = 70
        '
        'HpDataGridViewTextBoxColumn
        '
        Me.HpDataGridViewTextBoxColumn.DataPropertyName = "hp"
        Me.HpDataGridViewTextBoxColumn.HeaderText = "Seluler"
        Me.HpDataGridViewTextBoxColumn.Name = "HpDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'BankDataGridViewTextBoxColumn
        '
        Me.BankDataGridViewTextBoxColumn.DataPropertyName = "bank"
        Me.BankDataGridViewTextBoxColumn.DataSource = Me.BankBindingSource
        Me.BankDataGridViewTextBoxColumn.DisplayMember = "nama_bank"
        Me.BankDataGridViewTextBoxColumn.HeaderText = "Bank"
        Me.BankDataGridViewTextBoxColumn.Name = "BankDataGridViewTextBoxColumn"
        Me.BankDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BankDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BankDataGridViewTextBoxColumn.Width = 200
        '
        'BankBindingSource
        '
        Me.BankBindingSource.DataMember = "bank"
        Me.BankBindingSource.DataSource = Me.DataSet_Lab
        '
        'NorekeningDataGridViewTextBoxColumn
        '
        Me.NorekeningDataGridViewTextBoxColumn.DataPropertyName = "no_rekening"
        Me.NorekeningDataGridViewTextBoxColumn.HeaderText = "No rekening"
        Me.NorekeningDataGridViewTextBoxColumn.Name = "NorekeningDataGridViewTextBoxColumn"
        '
        'RekeningatasnamaDataGridViewTextBoxColumn
        '
        Me.RekeningatasnamaDataGridViewTextBoxColumn.DataPropertyName = "rekening_atas_nama"
        Me.RekeningatasnamaDataGridViewTextBoxColumn.HeaderText = "Rekening a/n"
        Me.RekeningatasnamaDataGridViewTextBoxColumn.Name = "RekeningatasnamaDataGridViewTextBoxColumn"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(478, 50)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(367, 50)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 16
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 52)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 15
        '
        'BankTableAdapter
        '
        Me.BankTableAdapter.ClearBeforeFill = True
        '
        'data_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 535)
        Me.Controls.Add(Me.dgSupplier)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorSupplier)
        Me.Name = "data_supplier"
        Me.Text = "Supplier"
        CType(Me.BindingNavigatorSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorSupplier.ResumeLayout(False)
        Me.BindingNavigatorSupplier.PerformLayout()
        CType(Me.BindingSourceSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorSupplier As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewSupplier As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteSupplier As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingSourceSupplier As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterSupplier As laboratorium.DataSet_LabTableAdapters.supplierTableAdapter
    Friend WithEvents dgSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BankBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankTableAdapter As laboratorium.DataSet_LabTableAdapters.bankTableAdapter
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_kontak As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pembayaran_fee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NorekeningDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RekeningatasnamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
