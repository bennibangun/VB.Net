<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_pengirim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_pengirim))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigatorPengirim = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewPengirim = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourcePengirim = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BindingNavigatorDeletePengirim = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgPengirim = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakontakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pembayaran_fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bank = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembayaranfeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NorekeningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RekeningatasnamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterPengirim = New laboratorium.DataSet_LabTableAdapters.pengirimTableAdapter()
        Me.BankTableAdapter = New laboratorium.DataSet_LabTableAdapters.bankTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingNavigatorPengirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorPengirim.SuspendLayout()
        CType(Me.BindingSourcePengirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPengirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BindingNavigatorPengirim)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1370, 51)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'BindingNavigatorPengirim
        '
        Me.BindingNavigatorPengirim.AddNewItem = Me.BindingNavigatorAddNewPengirim
        Me.BindingNavigatorPengirim.BindingSource = Me.BindingSourcePengirim
        Me.BindingNavigatorPengirim.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorPengirim.DeleteItem = Nothing
        Me.BindingNavigatorPengirim.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewPengirim, Me.BindingNavigatorDeletePengirim, Me.ButtonSave})
        Me.BindingNavigatorPengirim.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigatorPengirim.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorPengirim.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorPengirim.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorPengirim.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorPengirim.Name = "BindingNavigatorPengirim"
        Me.BindingNavigatorPengirim.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorPengirim.Size = New System.Drawing.Size(1364, 25)
        Me.BindingNavigatorPengirim.TabIndex = 0
        Me.BindingNavigatorPengirim.Text = "Pengirim"
        '
        'BindingNavigatorAddNewPengirim
        '
        Me.BindingNavigatorAddNewPengirim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewPengirim.Image = CType(resources.GetObject("BindingNavigatorAddNewPengirim.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewPengirim.Name = "BindingNavigatorAddNewPengirim"
        Me.BindingNavigatorAddNewPengirim.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewPengirim.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewPengirim.Text = "Tambah data dokter"
        '
        'BindingSourcePengirim
        '
        Me.BindingSourcePengirim.DataMember = "pengirim"
        Me.BindingSourcePengirim.DataSource = Me.DataSet_Lab
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
        'BindingNavigatorDeletePengirim
        '
        Me.BindingNavigatorDeletePengirim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeletePengirim.Image = CType(resources.GetObject("BindingNavigatorDeletePengirim.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeletePengirim.Name = "BindingNavigatorDeletePengirim"
        Me.BindingNavigatorDeletePengirim.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeletePengirim.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeletePengirim.Text = "Delete dokter"
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
        Me.btnExit.Location = New System.Drawing.Point(478, 65)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(367, 65)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 8
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 67)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 7
        '
        'dgPengirim
        '
        Me.dgPengirim.AllowUserToAddRows = False
        Me.dgPengirim.AutoGenerateColumns = False
        Me.dgPengirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPengirim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.NamakontakDataGridViewTextBoxColumn, Me.alamat, Me.pembayaran_fee, Me.TeleponDataGridViewTextBoxColumn, Me.HpDataGridViewTextBoxColumn, Me.FeeDataGridViewTextBoxColumn, Me.bank, Me.PembayaranfeeDataGridViewTextBoxColumn, Me.NorekeningDataGridViewTextBoxColumn, Me.RekeningatasnamaDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.dgPengirim.DataSource = Me.BindingSourcePengirim
        Me.dgPengirim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgPengirim.Location = New System.Drawing.Point(0, 114)
        Me.dgPengirim.Name = "dgPengirim"
        Me.dgPengirim.Size = New System.Drawing.Size(1370, 433)
        Me.dgPengirim.TabIndex = 10
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 40
        '
        'NamakontakDataGridViewTextBoxColumn
        '
        Me.NamakontakDataGridViewTextBoxColumn.DataPropertyName = "nama_kontak"
        Me.NamakontakDataGridViewTextBoxColumn.HeaderText = "Nama kontak"
        Me.NamakontakDataGridViewTextBoxColumn.Name = "NamakontakDataGridViewTextBoxColumn"
        '
        'alamat
        '
        Me.alamat.DataPropertyName = "alamat"
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.Width = 400
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
        'FeeDataGridViewTextBoxColumn
        '
        Me.FeeDataGridViewTextBoxColumn.DataPropertyName = "fee"
        Me.FeeDataGridViewTextBoxColumn.HeaderText = "Fee"
        Me.FeeDataGridViewTextBoxColumn.Name = "FeeDataGridViewTextBoxColumn"
        Me.FeeDataGridViewTextBoxColumn.Width = 40
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
        '
        'BankBindingSource
        '
        Me.BankBindingSource.DataMember = "bank"
        Me.BankBindingSource.DataSource = Me.DataSet_Lab
        '
        'PembayaranfeeDataGridViewTextBoxColumn
        '
        Me.PembayaranfeeDataGridViewTextBoxColumn.DataPropertyName = "pembayaran_fee"
        Me.PembayaranfeeDataGridViewTextBoxColumn.HeaderText = "Pembayaran fee"
        Me.PembayaranfeeDataGridViewTextBoxColumn.Name = "PembayaranfeeDataGridViewTextBoxColumn"
        Me.PembayaranfeeDataGridViewTextBoxColumn.Width = 110
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
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        '
        'TableAdapterPengirim
        '
        Me.TableAdapterPengirim.ClearBeforeFill = True
        '
        'BankTableAdapter
        '
        Me.BankTableAdapter.ClearBeforeFill = True
        '
        'data_pengirim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 547)
        Me.Controls.Add(Me.dgPengirim)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "data_pengirim"
        Me.Text = "Pengirim"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingNavigatorPengirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorPengirim.ResumeLayout(False)
        Me.BindingNavigatorPengirim.PerformLayout()
        CType(Me.BindingSourcePengirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPengirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgPengirim As System.Windows.Forms.DataGridView
    Friend WithEvents BindingNavigatorPengirim As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewPengirim As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeletePengirim As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingSourcePengirim As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterPengirim As laboratorium.DataSet_LabTableAdapters.pengirimTableAdapter
    Friend WithEvents BankBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankTableAdapter As laboratorium.DataSet_LabTableAdapters.bankTableAdapter
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamakontakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pembayaran_fee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PembayaranfeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NorekeningDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RekeningatasnamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
