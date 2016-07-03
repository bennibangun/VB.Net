<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lab_rujukan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lab_rujukan))
        Me.BindingNavigatorLabRujukan = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewLabRujukan = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourceLabRujukan = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BindingNavigatorDeleteLabRujukan = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterLabRujukan = New laboratorium.DataSet_LabTableAdapters.lab_rujukanTableAdapter()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgLabRujukan = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamalabrujukanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakontakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinsiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProvinsiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KabupatenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BindingSourceKabupaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.KecamatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BindingSourceKecamatan = New System.Windows.Forms.BindingSource(Me.components)
        Me.KelurahanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinsiTableAdapter = New laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter()
        Me.TableAdapterKabupaten = New laboratorium.DataSet_LabTableAdapters.kabupatenTableAdapter()
        Me.TableAdapterKecamatan = New laboratorium.DataSet_LabTableAdapters.kecamatanTableAdapter()
        CType(Me.BindingNavigatorLabRujukan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorLabRujukan.SuspendLayout()
        CType(Me.BindingSourceLabRujukan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLabRujukan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinsiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceKabupaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceKecamatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorLabRujukan
        '
        Me.BindingNavigatorLabRujukan.AddNewItem = Me.BindingNavigatorAddNewLabRujukan
        Me.BindingNavigatorLabRujukan.BindingSource = Me.BindingSourceLabRujukan
        Me.BindingNavigatorLabRujukan.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorLabRujukan.DeleteItem = Nothing
        Me.BindingNavigatorLabRujukan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewLabRujukan, Me.BindingNavigatorDeleteLabRujukan, Me.ButtonSave})
        Me.BindingNavigatorLabRujukan.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorLabRujukan.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorLabRujukan.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorLabRujukan.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorLabRujukan.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorLabRujukan.Name = "BindingNavigatorLabRujukan"
        Me.BindingNavigatorLabRujukan.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorLabRujukan.Size = New System.Drawing.Size(688, 25)
        Me.BindingNavigatorLabRujukan.TabIndex = 7
        Me.BindingNavigatorLabRujukan.Text = "Sample / Bahan Test"
        '
        'BindingNavigatorAddNewLabRujukan
        '
        Me.BindingNavigatorAddNewLabRujukan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewLabRujukan.Image = CType(resources.GetObject("BindingNavigatorAddNewLabRujukan.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewLabRujukan.Name = "BindingNavigatorAddNewLabRujukan"
        Me.BindingNavigatorAddNewLabRujukan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewLabRujukan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewLabRujukan.Text = "Tambah data dokter"
        '
        'BindingSourceLabRujukan
        '
        Me.BindingSourceLabRujukan.DataMember = "lab_rujukan"
        Me.BindingSourceLabRujukan.DataSource = Me.DataSet_Lab
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
        'BindingNavigatorDeleteLabRujukan
        '
        Me.BindingNavigatorDeleteLabRujukan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteLabRujukan.Image = CType(resources.GetObject("BindingNavigatorDeleteLabRujukan.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteLabRujukan.Name = "BindingNavigatorDeleteLabRujukan"
        Me.BindingNavigatorDeleteLabRujukan.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteLabRujukan.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteLabRujukan.Text = "Delete pasien"
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
        'TableAdapterLabRujukan
        '
        Me.TableAdapterLabRujukan.ClearBeforeFill = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(474, 43)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(363, 43)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 29
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(8, 45)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 28
        '
        'dgLabRujukan
        '
        Me.dgLabRujukan.AllowUserToAddRows = False
        Me.dgLabRujukan.AutoGenerateColumns = False
        Me.dgLabRujukan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLabRujukan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NamalabrujukanDataGridViewTextBoxColumn, Me.NamakontakDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.ProvinsiDataGridViewTextBoxColumn, Me.KabupatenDataGridViewTextBoxColumn, Me.KecamatanDataGridViewTextBoxColumn, Me.KelurahanDataGridViewTextBoxColumn, Me.TeleponDataGridViewTextBoxColumn, Me.HpDataGridViewTextBoxColumn})
        Me.dgLabRujukan.DataSource = Me.BindingSourceLabRujukan
        Me.dgLabRujukan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgLabRujukan.Location = New System.Drawing.Point(0, 80)
        Me.dgLabRujukan.Name = "dgLabRujukan"
        Me.dgLabRujukan.Size = New System.Drawing.Size(688, 463)
        Me.dgLabRujukan.TabIndex = 31
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 40
        '
        'NamalabrujukanDataGridViewTextBoxColumn
        '
        Me.NamalabrujukanDataGridViewTextBoxColumn.DataPropertyName = "nama_lab_rujukan"
        Me.NamalabrujukanDataGridViewTextBoxColumn.HeaderText = "Lab Rujukan"
        Me.NamalabrujukanDataGridViewTextBoxColumn.Name = "NamalabrujukanDataGridViewTextBoxColumn"
        Me.NamalabrujukanDataGridViewTextBoxColumn.Width = 150
        '
        'NamakontakDataGridViewTextBoxColumn
        '
        Me.NamakontakDataGridViewTextBoxColumn.DataPropertyName = "nama_kontak"
        Me.NamakontakDataGridViewTextBoxColumn.HeaderText = "Nama Kontak"
        Me.NamakontakDataGridViewTextBoxColumn.Name = "NamakontakDataGridViewTextBoxColumn"
        Me.NamakontakDataGridViewTextBoxColumn.Width = 150
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.Width = 300
        '
        'ProvinsiDataGridViewTextBoxColumn
        '
        Me.ProvinsiDataGridViewTextBoxColumn.DataPropertyName = "provinsi"
        Me.ProvinsiDataGridViewTextBoxColumn.DataSource = Me.ProvinsiBindingSource
        Me.ProvinsiDataGridViewTextBoxColumn.DisplayMember = "nama_provinsi"
        Me.ProvinsiDataGridViewTextBoxColumn.HeaderText = "Provinsi"
        Me.ProvinsiDataGridViewTextBoxColumn.Name = "ProvinsiDataGridViewTextBoxColumn"
        Me.ProvinsiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProvinsiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ProvinsiBindingSource
        '
        Me.ProvinsiBindingSource.DataMember = "provinsi"
        Me.ProvinsiBindingSource.DataSource = Me.DataSet_Lab
        '
        'KabupatenDataGridViewTextBoxColumn
        '
        Me.KabupatenDataGridViewTextBoxColumn.DataPropertyName = "kabupaten"
        Me.KabupatenDataGridViewTextBoxColumn.DataSource = Me.BindingSourceKabupaten
        Me.KabupatenDataGridViewTextBoxColumn.DisplayMember = "nama_kabupaten"
        Me.KabupatenDataGridViewTextBoxColumn.HeaderText = "Kabupaten"
        Me.KabupatenDataGridViewTextBoxColumn.Name = "KabupatenDataGridViewTextBoxColumn"
        Me.KabupatenDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KabupatenDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BindingSourceKabupaten
        '
        Me.BindingSourceKabupaten.DataMember = "kabupaten"
        Me.BindingSourceKabupaten.DataSource = Me.DataSet_Lab
        '
        'KecamatanDataGridViewTextBoxColumn
        '
        Me.KecamatanDataGridViewTextBoxColumn.DataPropertyName = "kecamatan"
        Me.KecamatanDataGridViewTextBoxColumn.DataSource = Me.BindingSourceKecamatan
        Me.KecamatanDataGridViewTextBoxColumn.DisplayMember = "nama_kecamatan"
        Me.KecamatanDataGridViewTextBoxColumn.HeaderText = "Kecamatan"
        Me.KecamatanDataGridViewTextBoxColumn.Name = "KecamatanDataGridViewTextBoxColumn"
        Me.KecamatanDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KecamatanDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BindingSourceKecamatan
        '
        Me.BindingSourceKecamatan.DataMember = "kecamatan"
        Me.BindingSourceKecamatan.DataSource = Me.DataSet_Lab
        '
        'KelurahanDataGridViewTextBoxColumn
        '
        Me.KelurahanDataGridViewTextBoxColumn.DataPropertyName = "kelurahan"
        Me.KelurahanDataGridViewTextBoxColumn.HeaderText = "Kelurahan"
        Me.KelurahanDataGridViewTextBoxColumn.Name = "KelurahanDataGridViewTextBoxColumn"
        '
        'TeleponDataGridViewTextBoxColumn
        '
        Me.TeleponDataGridViewTextBoxColumn.DataPropertyName = "telepon"
        Me.TeleponDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.Name = "TeleponDataGridViewTextBoxColumn"
        '
        'HpDataGridViewTextBoxColumn
        '
        Me.HpDataGridViewTextBoxColumn.DataPropertyName = "hp"
        Me.HpDataGridViewTextBoxColumn.HeaderText = "Seluler"
        Me.HpDataGridViewTextBoxColumn.Name = "HpDataGridViewTextBoxColumn"
        '
        'ProvinsiTableAdapter
        '
        Me.ProvinsiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterKabupaten
        '
        Me.TableAdapterKabupaten.ClearBeforeFill = True
        '
        'TableAdapterKecamatan
        '
        Me.TableAdapterKecamatan.ClearBeforeFill = True
        '
        'lab_rujukan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 543)
        Me.Controls.Add(Me.dgLabRujukan)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorLabRujukan)
        Me.Name = "lab_rujukan"
        Me.Text = "Lab Rujukan"
        CType(Me.BindingNavigatorLabRujukan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorLabRujukan.ResumeLayout(False)
        Me.BindingNavigatorLabRujukan.PerformLayout()
        CType(Me.BindingSourceLabRujukan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLabRujukan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinsiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceKabupaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceKecamatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorLabRujukan As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewLabRujukan As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteLabRujukan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingSourceLabRujukan As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterLabRujukan As laboratorium.DataSet_LabTableAdapters.lab_rujukanTableAdapter
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgLabRujukan As System.Windows.Forms.DataGridView
    Friend WithEvents ProvinsiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinsiTableAdapter As laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter
    Friend WithEvents BindingSourceKabupaten As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterKabupaten As laboratorium.DataSet_LabTableAdapters.kabupatenTableAdapter
    Friend WithEvents BindingSourceKecamatan As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterKecamatan As laboratorium.DataSet_LabTableAdapters.kecamatanTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamalabrujukanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamakontakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinsiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents KabupatenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents KecamatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents KelurahanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
