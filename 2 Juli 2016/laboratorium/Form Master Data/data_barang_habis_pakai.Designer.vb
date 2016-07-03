<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_barang_habis_pakai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_barang_habis_pakai))
        Me.BindingNavigatorBarangHabisPakai = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewBarangHabisPakai = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourceBarangHabisPakai = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteBarangHabisPakai = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgSupplier = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BindingSourceJenisBarangHabisPakai = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomorbarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BindingSourceSatuanIsi = New System.Windows.Forms.BindingSource(Me.components)
        Me.kuantitas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Satuan = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BindingSourceSatuanKuantitas = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisatahunexpiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisabulanexpiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisahariexpiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasaperingatanexpiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterBarangHabisPakai = New laboratorium.DataSet_LabTableAdapters.barang_habis_pakaiTableAdapter()
        Me.SupplierTableAdapter = New laboratorium.DataSet_LabTableAdapters.supplierTableAdapter()
        Me.TableAdapterJenisBarangHabisPakai = New laboratorium.DataSet_LabTableAdapters.jenis_barang_habis_pakaiTableAdapter()
        Me.TableAdapterSatuanIsi = New laboratorium.DataSet_LabTableAdapters.satuan_isiTableAdapter()
        Me.TableAdapterSatuanKuantitas = New laboratorium.DataSet_LabTableAdapters.satuan_kuantitasTableAdapter()
        CType(Me.BindingNavigatorBarangHabisPakai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorBarangHabisPakai.SuspendLayout()
        CType(Me.BindingSourceBarangHabisPakai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceJenisBarangHabisPakai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSatuanIsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSatuanKuantitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorBarangHabisPakai
        '
        Me.BindingNavigatorBarangHabisPakai.AddNewItem = Me.BindingNavigatorAddNewBarangHabisPakai
        Me.BindingNavigatorBarangHabisPakai.BindingSource = Me.BindingSourceBarangHabisPakai
        Me.BindingNavigatorBarangHabisPakai.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorBarangHabisPakai.DeleteItem = Me.BindingNavigatorDeleteBarangHabisPakai
        Me.BindingNavigatorBarangHabisPakai.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewBarangHabisPakai, Me.BindingNavigatorDeleteBarangHabisPakai, Me.ButtonSave})
        Me.BindingNavigatorBarangHabisPakai.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorBarangHabisPakai.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorBarangHabisPakai.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorBarangHabisPakai.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorBarangHabisPakai.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorBarangHabisPakai.Name = "BindingNavigatorBarangHabisPakai"
        Me.BindingNavigatorBarangHabisPakai.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorBarangHabisPakai.Size = New System.Drawing.Size(1370, 25)
        Me.BindingNavigatorBarangHabisPakai.TabIndex = 2
        Me.BindingNavigatorBarangHabisPakai.Text = "Rujukan"
        '
        'BindingNavigatorAddNewBarangHabisPakai
        '
        Me.BindingNavigatorAddNewBarangHabisPakai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewBarangHabisPakai.Image = CType(resources.GetObject("BindingNavigatorAddNewBarangHabisPakai.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewBarangHabisPakai.Name = "BindingNavigatorAddNewBarangHabisPakai"
        Me.BindingNavigatorAddNewBarangHabisPakai.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewBarangHabisPakai.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewBarangHabisPakai.Text = "Add new"
        '
        'BindingSourceBarangHabisPakai
        '
        Me.BindingSourceBarangHabisPakai.DataMember = "barang_habis_pakai"
        Me.BindingSourceBarangHabisPakai.DataSource = Me.DataSet_Lab
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
        'BindingNavigatorDeleteBarangHabisPakai
        '
        Me.BindingNavigatorDeleteBarangHabisPakai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteBarangHabisPakai.Image = CType(resources.GetObject("BindingNavigatorDeleteBarangHabisPakai.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteBarangHabisPakai.Name = "BindingNavigatorDeleteBarangHabisPakai"
        Me.BindingNavigatorDeleteBarangHabisPakai.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteBarangHabisPakai.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteBarangHabisPakai.Text = "Delete"
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
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(472, 47)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(361, 47)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 19
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 49)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 18
        '
        'dgSupplier
        '
        Me.dgSupplier.AllowUserToAddRows = False
        Me.dgSupplier.AutoGenerateColumns = False
        Me.dgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.JenisDataGridViewTextBoxColumn, Me.NomorbarcodeDataGridViewTextBoxColumn, Me.IsiDataGridViewTextBoxColumn, Me.SatuanisiDataGridViewTextBoxColumn, Me.kuantitas, Me.Satuan, Me.ExpiredDataGridViewTextBoxColumn, Me.SisatahunexpiredDataGridViewTextBoxColumn, Me.SisabulanexpiredDataGridViewTextBoxColumn, Me.SisahariexpiredDataGridViewTextBoxColumn, Me.MasaperingatanexpiredDataGridViewTextBoxColumn, Me.SupplierDataGridViewTextBoxColumn})
        Me.dgSupplier.DataSource = Me.BindingSourceBarangHabisPakai
        Me.dgSupplier.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgSupplier.Location = New System.Drawing.Point(0, 102)
        Me.dgSupplier.Name = "dgSupplier"
        Me.dgSupplier.Size = New System.Drawing.Size(1370, 433)
        Me.dgSupplier.TabIndex = 21
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 40
        '
        'JenisDataGridViewTextBoxColumn
        '
        Me.JenisDataGridViewTextBoxColumn.DataPropertyName = "jenis"
        Me.JenisDataGridViewTextBoxColumn.DataSource = Me.BindingSourceJenisBarangHabisPakai
        Me.JenisDataGridViewTextBoxColumn.DisplayMember = "jenis"
        Me.JenisDataGridViewTextBoxColumn.HeaderText = "Jenis"
        Me.JenisDataGridViewTextBoxColumn.MaxDropDownItems = 20
        Me.JenisDataGridViewTextBoxColumn.Name = "JenisDataGridViewTextBoxColumn"
        Me.JenisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JenisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BindingSourceJenisBarangHabisPakai
        '
        Me.BindingSourceJenisBarangHabisPakai.DataMember = "jenis_barang_habis_pakai"
        Me.BindingSourceJenisBarangHabisPakai.DataSource = Me.DataSet_Lab
        '
        'NomorbarcodeDataGridViewTextBoxColumn
        '
        Me.NomorbarcodeDataGridViewTextBoxColumn.DataPropertyName = "nomor_barcode"
        Me.NomorbarcodeDataGridViewTextBoxColumn.HeaderText = "No barcode"
        Me.NomorbarcodeDataGridViewTextBoxColumn.Name = "NomorbarcodeDataGridViewTextBoxColumn"
        '
        'IsiDataGridViewTextBoxColumn
        '
        Me.IsiDataGridViewTextBoxColumn.DataPropertyName = "isi"
        Me.IsiDataGridViewTextBoxColumn.HeaderText = "Isi"
        Me.IsiDataGridViewTextBoxColumn.Name = "IsiDataGridViewTextBoxColumn"
        Me.IsiDataGridViewTextBoxColumn.Width = 40
        '
        'SatuanisiDataGridViewTextBoxColumn
        '
        Me.SatuanisiDataGridViewTextBoxColumn.DataPropertyName = "satuan_isi"
        Me.SatuanisiDataGridViewTextBoxColumn.DataSource = Me.BindingSourceSatuanIsi
        Me.SatuanisiDataGridViewTextBoxColumn.DisplayMember = "nama_satuan_isi"
        Me.SatuanisiDataGridViewTextBoxColumn.HeaderText = "Satuan"
        Me.SatuanisiDataGridViewTextBoxColumn.MaxDropDownItems = 20
        Me.SatuanisiDataGridViewTextBoxColumn.Name = "SatuanisiDataGridViewTextBoxColumn"
        Me.SatuanisiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SatuanisiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SatuanisiDataGridViewTextBoxColumn.Width = 50
        '
        'BindingSourceSatuanIsi
        '
        Me.BindingSourceSatuanIsi.DataMember = "satuan_isi"
        Me.BindingSourceSatuanIsi.DataSource = Me.DataSet_Lab
        '
        'kuantitas
        '
        Me.kuantitas.DataPropertyName = "kuantitas"
        Me.kuantitas.HeaderText = "Kuantitas"
        Me.kuantitas.Name = "kuantitas"
        Me.kuantitas.Width = 60
        '
        'Satuan
        '
        Me.Satuan.DataPropertyName = "satuan_kuantitas"
        Me.Satuan.DataSource = Me.BindingSourceSatuanKuantitas
        Me.Satuan.DisplayMember = "nama_satuan_kuantitas"
        Me.Satuan.HeaderText = "Satuan"
        Me.Satuan.MaxDropDownItems = 20
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Satuan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Satuan.Width = 50
        '
        'BindingSourceSatuanKuantitas
        '
        Me.BindingSourceSatuanKuantitas.DataMember = "satuan_kuantitas"
        Me.BindingSourceSatuanKuantitas.DataSource = Me.DataSet_Lab
        '
        'ExpiredDataGridViewTextBoxColumn
        '
        Me.ExpiredDataGridViewTextBoxColumn.DataPropertyName = "expired"
        Me.ExpiredDataGridViewTextBoxColumn.HeaderText = "Expired"
        Me.ExpiredDataGridViewTextBoxColumn.Name = "ExpiredDataGridViewTextBoxColumn"
        '
        'SisatahunexpiredDataGridViewTextBoxColumn
        '
        Me.SisatahunexpiredDataGridViewTextBoxColumn.DataPropertyName = "sisa_tahun_expired"
        Me.SisatahunexpiredDataGridViewTextBoxColumn.HeaderText = "Sisa exp (thn)"
        Me.SisatahunexpiredDataGridViewTextBoxColumn.Name = "SisatahunexpiredDataGridViewTextBoxColumn"
        '
        'SisabulanexpiredDataGridViewTextBoxColumn
        '
        Me.SisabulanexpiredDataGridViewTextBoxColumn.DataPropertyName = "sisa_bulan_expired"
        Me.SisabulanexpiredDataGridViewTextBoxColumn.HeaderText = "Sisa exp (bln)"
        Me.SisabulanexpiredDataGridViewTextBoxColumn.Name = "SisabulanexpiredDataGridViewTextBoxColumn"
        '
        'SisahariexpiredDataGridViewTextBoxColumn
        '
        Me.SisahariexpiredDataGridViewTextBoxColumn.DataPropertyName = "sisa_hari_expired"
        Me.SisahariexpiredDataGridViewTextBoxColumn.HeaderText = "Sisa exp (hari)"
        Me.SisahariexpiredDataGridViewTextBoxColumn.Name = "SisahariexpiredDataGridViewTextBoxColumn"
        '
        'MasaperingatanexpiredDataGridViewTextBoxColumn
        '
        Me.MasaperingatanexpiredDataGridViewTextBoxColumn.DataPropertyName = "masa_peringatan_expired"
        Me.MasaperingatanexpiredDataGridViewTextBoxColumn.HeaderText = "Peringatan exp"
        Me.MasaperingatanexpiredDataGridViewTextBoxColumn.Name = "MasaperingatanexpiredDataGridViewTextBoxColumn"
        Me.MasaperingatanexpiredDataGridViewTextBoxColumn.Width = 130
        '
        'SupplierDataGridViewTextBoxColumn
        '
        Me.SupplierDataGridViewTextBoxColumn.DataPropertyName = "supplier"
        Me.SupplierDataGridViewTextBoxColumn.DataSource = Me.SupplierBindingSource
        Me.SupplierDataGridViewTextBoxColumn.DisplayMember = "nama_kontak"
        Me.SupplierDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.SupplierDataGridViewTextBoxColumn.MaxDropDownItems = 20
        Me.SupplierDataGridViewTextBoxColumn.Name = "SupplierDataGridViewTextBoxColumn"
        Me.SupplierDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "supplier"
        Me.SupplierBindingSource.DataSource = Me.DataSet_Lab
        '
        'TableAdapterBarangHabisPakai
        '
        Me.TableAdapterBarangHabisPakai.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterJenisBarangHabisPakai
        '
        Me.TableAdapterJenisBarangHabisPakai.ClearBeforeFill = True
        '
        'TableAdapterSatuanIsi
        '
        Me.TableAdapterSatuanIsi.ClearBeforeFill = True
        '
        'TableAdapterSatuanKuantitas
        '
        Me.TableAdapterSatuanKuantitas.ClearBeforeFill = True
        '
        'data_barang_habis_pakai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 535)
        Me.Controls.Add(Me.dgSupplier)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorBarangHabisPakai)
        Me.Name = "data_barang_habis_pakai"
        Me.Text = "Barang Habis Pakai"
        CType(Me.BindingNavigatorBarangHabisPakai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorBarangHabisPakai.ResumeLayout(False)
        Me.BindingNavigatorBarangHabisPakai.PerformLayout()
        CType(Me.BindingSourceBarangHabisPakai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceJenisBarangHabisPakai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSatuanIsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSatuanKuantitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorBarangHabisPakai As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewBarangHabisPakai As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteBarangHabisPakai As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceBarangHabisPakai As System.Windows.Forms.BindingSource
    Friend WithEvents SisawaktutahunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktubulanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuhariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterBarangHabisPakai As laboratorium.DataSet_LabTableAdapters.barang_habis_pakaiTableAdapter
    Friend WithEvents KuantitasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As laboratorium.DataSet_LabTableAdapters.supplierTableAdapter
    Friend WithEvents BindingSourceJenisBarangHabisPakai As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterJenisBarangHabisPakai As laboratorium.DataSet_LabTableAdapters.jenis_barang_habis_pakaiTableAdapter
    Friend WithEvents BindingSourceSatuanIsi As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterSatuanIsi As laboratorium.DataSet_LabTableAdapters.satuan_isiTableAdapter
    Friend WithEvents BindingSourceSatuanKuantitas As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterSatuanKuantitas As laboratorium.DataSet_LabTableAdapters.satuan_kuantitasTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NomorbarcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatuanisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents kuantitas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Satuan As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ExpiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisatahunexpiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisabulanexpiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisahariexpiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasaperingatanexpiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
