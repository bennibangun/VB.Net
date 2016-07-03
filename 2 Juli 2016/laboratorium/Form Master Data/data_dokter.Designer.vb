<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_dokter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_dokter))
        Me.dgDokter = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpesialisasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgllahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TlprumahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TlpselulerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PembayaranfeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BindingSourceBank = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.NorekeningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RekeningatasnamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceDokter = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigatorDokter = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewDokter = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteDokter = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.TableAdapterDokter = New laboratorium.DataSet_LabTableAdapters.dokterTableAdapter()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TableAdapterBank = New laboratorium.DataSet_LabTableAdapters.bankTableAdapter()
        Me.BindingSourceCaraBayar = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterCaraBayar = New laboratorium.DataSet_LabTableAdapters.cara_bayarTableAdapter()
        Me.BindingSourceSpesialisasi = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterSpesialisasi = New laboratorium.DataSet_LabTableAdapters.spesialisasiTableAdapter()
        CType(Me.dgDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingNavigatorDokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorDokter.SuspendLayout()
        CType(Me.BindingSourceCaraBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSpesialisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDokter
        '
        Me.dgDokter.AllowUserToAddRows = False
        Me.dgDokter.AutoGenerateColumns = False
        Me.dgDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDokter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.JeniskelaminDataGridViewTextBoxColumn, Me.SpesialisasiDataGridViewTextBoxColumn, Me.TgllahirDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TlprumahDataGridViewTextBoxColumn, Me.TlpselulerDataGridViewTextBoxColumn, Me.FeeDataGridViewTextBoxColumn, Me.PembayaranfeeDataGridViewTextBoxColumn, Me.BankDataGridViewTextBoxColumn, Me.NorekeningDataGridViewTextBoxColumn, Me.RekeningatasnamaDataGridViewTextBoxColumn})
        Me.dgDokter.DataSource = Me.BindingSourceDokter
        Me.dgDokter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgDokter.Location = New System.Drawing.Point(0, 84)
        Me.dgDokter.Name = "dgDokter"
        Me.dgDokter.Size = New System.Drawing.Size(1370, 463)
        Me.dgDokter.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 40
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.Width = 150
        '
        'JeniskelaminDataGridViewTextBoxColumn
        '
        Me.JeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.HeaderText = "Jenkel"
        Me.JeniskelaminDataGridViewTextBoxColumn.Name = "JeniskelaminDataGridViewTextBoxColumn"
        Me.JeniskelaminDataGridViewTextBoxColumn.Width = 50
        '
        'SpesialisasiDataGridViewTextBoxColumn
        '
        Me.SpesialisasiDataGridViewTextBoxColumn.DataPropertyName = "spesialisasi"
        Me.SpesialisasiDataGridViewTextBoxColumn.HeaderText = "Spesialisasi"
        Me.SpesialisasiDataGridViewTextBoxColumn.Name = "SpesialisasiDataGridViewTextBoxColumn"
        Me.SpesialisasiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SpesialisasiDataGridViewTextBoxColumn.Width = 200
        '
        'TgllahirDataGridViewTextBoxColumn
        '
        Me.TgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir"
        Me.TgllahirDataGridViewTextBoxColumn.HeaderText = "Tgl lahir"
        Me.TgllahirDataGridViewTextBoxColumn.Name = "TgllahirDataGridViewTextBoxColumn"
        Me.TgllahirDataGridViewTextBoxColumn.Width = 80
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.Width = 200
        '
        'TlprumahDataGridViewTextBoxColumn
        '
        Me.TlprumahDataGridViewTextBoxColumn.DataPropertyName = "tlp_rumah"
        Me.TlprumahDataGridViewTextBoxColumn.HeaderText = "Tlp rumah"
        Me.TlprumahDataGridViewTextBoxColumn.Name = "TlprumahDataGridViewTextBoxColumn"
        Me.TlprumahDataGridViewTextBoxColumn.Width = 80
        '
        'TlpselulerDataGridViewTextBoxColumn
        '
        Me.TlpselulerDataGridViewTextBoxColumn.DataPropertyName = "tlp_seluler"
        Me.TlpselulerDataGridViewTextBoxColumn.HeaderText = "Seluler"
        Me.TlpselulerDataGridViewTextBoxColumn.Name = "TlpselulerDataGridViewTextBoxColumn"
        Me.TlpselulerDataGridViewTextBoxColumn.Width = 80
        '
        'FeeDataGridViewTextBoxColumn
        '
        Me.FeeDataGridViewTextBoxColumn.DataPropertyName = "fee"
        Me.FeeDataGridViewTextBoxColumn.HeaderText = "Fee"
        Me.FeeDataGridViewTextBoxColumn.Name = "FeeDataGridViewTextBoxColumn"
        Me.FeeDataGridViewTextBoxColumn.Width = 40
        '
        'PembayaranfeeDataGridViewTextBoxColumn
        '
        Me.PembayaranfeeDataGridViewTextBoxColumn.DataPropertyName = "pembayaran_fee"
        Me.PembayaranfeeDataGridViewTextBoxColumn.HeaderText = "Cara bayar"
        Me.PembayaranfeeDataGridViewTextBoxColumn.Name = "PembayaranfeeDataGridViewTextBoxColumn"
        Me.PembayaranfeeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'BankDataGridViewTextBoxColumn
        '
        Me.BankDataGridViewTextBoxColumn.DataPropertyName = "bank"
        Me.BankDataGridViewTextBoxColumn.DataSource = Me.BindingSourceBank
        Me.BankDataGridViewTextBoxColumn.DisplayMember = "nama_bank"
        Me.BankDataGridViewTextBoxColumn.HeaderText = "Bank"
        Me.BankDataGridViewTextBoxColumn.Name = "BankDataGridViewTextBoxColumn"
        Me.BankDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BankDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BankDataGridViewTextBoxColumn.Width = 200
        '
        'BindingSourceBank
        '
        Me.BindingSourceBank.DataMember = "bank"
        Me.BindingSourceBank.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'BindingSourceDokter
        '
        Me.BindingSourceDokter.DataMember = "dokter"
        Me.BindingSourceDokter.DataSource = Me.DataSet_Lab
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BindingNavigatorDokter)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1370, 51)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'BindingNavigatorDokter
        '
        Me.BindingNavigatorDokter.AddNewItem = Me.BindingNavigatorAddNewDokter
        Me.BindingNavigatorDokter.BindingSource = Me.BindingSourceDokter
        Me.BindingNavigatorDokter.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorDokter.DeleteItem = Nothing
        Me.BindingNavigatorDokter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewDokter, Me.BindingNavigatorDeleteDokter, Me.ButtonSave})
        Me.BindingNavigatorDokter.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigatorDokter.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorDokter.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorDokter.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorDokter.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorDokter.Name = "BindingNavigatorDokter"
        Me.BindingNavigatorDokter.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorDokter.Size = New System.Drawing.Size(1364, 25)
        Me.BindingNavigatorDokter.TabIndex = 0
        Me.BindingNavigatorDokter.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewDokter
        '
        Me.BindingNavigatorAddNewDokter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewDokter.Image = CType(resources.GetObject("BindingNavigatorAddNewDokter.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewDokter.Name = "BindingNavigatorAddNewDokter"
        Me.BindingNavigatorAddNewDokter.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewDokter.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewDokter.Text = "Tambah data dokter"
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
        'BindingNavigatorDeleteDokter
        '
        Me.BindingNavigatorDeleteDokter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteDokter.Image = CType(resources.GetObject("BindingNavigatorDeleteDokter.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteDokter.Name = "BindingNavigatorDeleteDokter"
        Me.BindingNavigatorDeleteDokter.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteDokter.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteDokter.Text = "Delete dokter"
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
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(23, 59)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 3
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(378, 57)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 5
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'TableAdapterDokter
        '
        Me.TableAdapterDokter.ClearBeforeFill = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(489, 57)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TableAdapterBank
        '
        Me.TableAdapterBank.ClearBeforeFill = True
        '
        'BindingSourceCaraBayar
        '
        Me.BindingSourceCaraBayar.DataMember = "cara_bayar"
        Me.BindingSourceCaraBayar.DataSource = Me.DataSet_Lab
        '
        'TableAdapterCaraBayar
        '
        Me.TableAdapterCaraBayar.ClearBeforeFill = True
        '
        'BindingSourceSpesialisasi
        '
        Me.BindingSourceSpesialisasi.DataMember = "spesialisasi"
        Me.BindingSourceSpesialisasi.DataSource = Me.DataSet_Lab
        '
        'TableAdapterSpesialisasi
        '
        Me.TableAdapterSpesialisasi.ClearBeforeFill = True
        '
        'data_dokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgDokter)
        Me.Name = "data_dokter"
        Me.Text = "Dokter"
        CType(Me.dgDokter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceDokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingNavigatorDokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorDokter.ResumeLayout(False)
        Me.BindingNavigatorDokter.PerformLayout()
        CType(Me.BindingSourceCaraBayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSpesialisasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgDokter As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents TableAdapterDokter As laboratorium.DataSet_LabTableAdapters.dokterTableAdapter
    Friend WithEvents BindingNavigatorDokter As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewDokter As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteDokter As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents BindingSourceDokter As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceBank As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterBank As laboratorium.DataSet_LabTableAdapters.bankTableAdapter
    Friend WithEvents HpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents BindingSourceCaraBayar As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterCaraBayar As laboratorium.DataSet_LabTableAdapters.cara_bayarTableAdapter
    Friend WithEvents BindingSourceSpesialisasi As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterSpesialisasi As laboratorium.DataSet_LabTableAdapters.spesialisasiTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JeniskelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpesialisasiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TgllahirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TlprumahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TlpselulerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PembayaranfeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NorekeningDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RekeningatasnamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
