<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_rujukan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_rujukan))
        Me.BindingNavigatorRujukan = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewRujukan = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourceRujukan = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteRujukan = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.dgRujukan = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_kontak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bank = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pembayaran_fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NorekeningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RekeningatasnamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.TableAdapterRujukan = New laboratorium.DataSet_LabTableAdapters.rujukanTableAdapter()
        Me.BankTableAdapter = New laboratorium.DataSet_LabTableAdapters.bankTableAdapter()
        CType(Me.BindingNavigatorRujukan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorRujukan.SuspendLayout()
        CType(Me.BindingSourceRujukan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRujukan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorRujukan
        '
        Me.BindingNavigatorRujukan.AddNewItem = Me.BindingNavigatorAddNewRujukan
        Me.BindingNavigatorRujukan.BindingSource = Me.BindingSourceRujukan
        Me.BindingNavigatorRujukan.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorRujukan.DeleteItem = Me.BindingNavigatorDeleteRujukan
        Me.BindingNavigatorRujukan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewRujukan, Me.BindingNavigatorDeleteRujukan, Me.ButtonSave})
        Me.BindingNavigatorRujukan.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorRujukan.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorRujukan.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorRujukan.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorRujukan.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorRujukan.Name = "BindingNavigatorRujukan"
        Me.BindingNavigatorRujukan.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorRujukan.Size = New System.Drawing.Size(1370, 25)
        Me.BindingNavigatorRujukan.TabIndex = 0
        Me.BindingNavigatorRujukan.Text = "Rujukan"
        '
        'BindingNavigatorAddNewRujukan
        '
        Me.BindingNavigatorAddNewRujukan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewRujukan.Image = CType(resources.GetObject("BindingNavigatorAddNewRujukan.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewRujukan.Name = "BindingNavigatorAddNewRujukan"
        Me.BindingNavigatorAddNewRujukan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewRujukan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewRujukan.Text = "Add new"
        '
        'BindingSourceRujukan
        '
        Me.BindingSourceRujukan.DataMember = "rujukan"
        Me.BindingSourceRujukan.DataSource = Me.DataSet_Lab
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
        'BindingNavigatorDeleteRujukan
        '
        Me.BindingNavigatorDeleteRujukan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteRujukan.Image = CType(resources.GetObject("BindingNavigatorDeleteRujukan.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteRujukan.Name = "BindingNavigatorDeleteRujukan"
        Me.BindingNavigatorDeleteRujukan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteRujukan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteRujukan.Text = "Delete"
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
        'dgRujukan
        '
        Me.dgRujukan.AllowUserToAddRows = False
        Me.dgRujukan.AutoGenerateColumns = False
        Me.dgRujukan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRujukan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_kontak, Me.alamat, Me.FeeDataGridViewTextBoxColumn, Me.bank, Me.pembayaran_fee, Me.TeleponDataGridViewTextBoxColumn, Me.HpDataGridViewTextBoxColumn, Me.NorekeningDataGridViewTextBoxColumn, Me.RekeningatasnamaDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.dgRujukan.DataSource = Me.BindingSourceRujukan
        Me.dgRujukan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgRujukan.Location = New System.Drawing.Point(0, 96)
        Me.dgRujukan.Name = "dgRujukan"
        Me.dgRujukan.Size = New System.Drawing.Size(1370, 433)
        Me.dgRujukan.TabIndex = 14
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
        '
        'bank
        '
        Me.bank.DataPropertyName = "bank"
        Me.bank.DataSource = Me.BankBindingSource
        Me.bank.DisplayMember = "nama_bank"
        Me.bank.HeaderText = "Bank"
        Me.bank.Name = "bank"
        Me.bank.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.bank.Width = 200
        '
        'BankBindingSource
        '
        Me.BankBindingSource.DataMember = "bank"
        Me.BankBindingSource.DataSource = Me.DataSet_Lab
        '
        'pembayaran_fee
        '
        Me.pembayaran_fee.DataPropertyName = "pembayaran_fee"
        Me.pembayaran_fee.HeaderText = "Pembayaran fee"
        Me.pembayaran_fee.Name = "pembayaran_fee"
        Me.pembayaran_fee.Width = 120
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
        Me.HpDataGridViewTextBoxColumn.Width = 90
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
        Me.RekeningatasnamaDataGridViewTextBoxColumn.HeaderText = "Rekening atas nama"
        Me.RekeningatasnamaDataGridViewTextBoxColumn.Name = "RekeningatasnamaDataGridViewTextBoxColumn"
        Me.RekeningatasnamaDataGridViewTextBoxColumn.Width = 130
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(478, 48)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(367, 48)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 12
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 50)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 11
        '
        'TableAdapterRujukan
        '
        Me.TableAdapterRujukan.ClearBeforeFill = True
        '
        'BankTableAdapter
        '
        Me.BankTableAdapter.ClearBeforeFill = True
        '
        'data_rujukan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 529)
        Me.Controls.Add(Me.dgRujukan)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorRujukan)
        Me.Name = "data_rujukan"
        Me.Text = "Rujukan"
        CType(Me.BindingNavigatorRujukan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorRujukan.ResumeLayout(False)
        Me.BindingNavigatorRujukan.PerformLayout()
        CType(Me.BindingSourceRujukan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRujukan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorRujukan As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewRujukan As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteRujukan As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgRujukan As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Telepon1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hp1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSourceRujukan As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterRujukan As laboratorium.DataSet_LabTableAdapters.rujukanTableAdapter
    Friend WithEvents BankBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankTableAdapter As laboratorium.DataSet_LabTableAdapters.bankTableAdapter
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_kontak As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents pembayaran_fee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NorekeningDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RekeningatasnamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
