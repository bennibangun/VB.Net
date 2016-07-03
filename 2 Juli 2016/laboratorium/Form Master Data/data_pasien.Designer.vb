<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_pasien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_pasien))
        Me.BindingNavigatorPasien = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewPasien = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourcePasien = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BindingNavigatorDeletePasien = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgPasien = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlp_seluler = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempatlahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgllahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GoldarahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RhesusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TlprumahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TlpselulerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceProvinsi = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterProvinsi = New laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter()
        Me.TableAdapterPasien = New laboratorium.DataSet_LabTableAdapters.pasienTableAdapter()
        CType(Me.BindingNavigatorPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorPasien.SuspendLayout()
        CType(Me.BindingSourcePasien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceProvinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorPasien
        '
        Me.BindingNavigatorPasien.AddNewItem = Me.BindingNavigatorAddNewPasien
        Me.BindingNavigatorPasien.BindingSource = Me.BindingSourcePasien
        Me.BindingNavigatorPasien.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorPasien.DeleteItem = Nothing
        Me.BindingNavigatorPasien.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewPasien, Me.BindingNavigatorDeletePasien, Me.ButtonSave})
        Me.BindingNavigatorPasien.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorPasien.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorPasien.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorPasien.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorPasien.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorPasien.Name = "BindingNavigatorPasien"
        Me.BindingNavigatorPasien.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorPasien.Size = New System.Drawing.Size(1370, 25)
        Me.BindingNavigatorPasien.TabIndex = 1
        Me.BindingNavigatorPasien.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewPasien
        '
        Me.BindingNavigatorAddNewPasien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewPasien.Image = CType(resources.GetObject("BindingNavigatorAddNewPasien.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewPasien.Name = "BindingNavigatorAddNewPasien"
        Me.BindingNavigatorAddNewPasien.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewPasien.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewPasien.Text = "Tambah data dokter"
        '
        'BindingSourcePasien
        '
        Me.BindingSourcePasien.DataMember = "pasien"
        Me.BindingSourcePasien.DataSource = Me.DataSet_Lab
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
        'BindingNavigatorDeletePasien
        '
        Me.BindingNavigatorDeletePasien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeletePasien.Image = CType(resources.GetObject("BindingNavigatorDeletePasien.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeletePasien.Name = "BindingNavigatorDeletePasien"
        Me.BindingNavigatorDeletePasien.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeletePasien.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeletePasien.Text = "Delete pasien"
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
        Me.btnExit.Location = New System.Drawing.Point(478, 39)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(367, 39)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 8
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 41)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 7
        '
        'dgPasien
        '
        Me.dgPasien.AllowUserToAddRows = False
        Me.dgPasien.AutoGenerateColumns = False
        Me.dgPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPasien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.alamat, Me.tlp_seluler, Me.JeniskelaminDataGridViewTextBoxColumn, Me.TempatlahirDataGridViewTextBoxColumn, Me.TgllahirDataGridViewTextBoxColumn, Me.GoldarahDataGridViewTextBoxColumn, Me.RhesusDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.AlamatDataGridViewTextBoxColumn, Me.TlprumahDataGridViewTextBoxColumn, Me.TlpselulerDataGridViewTextBoxColumn})
        Me.dgPasien.DataSource = Me.BindingSourcePasien
        Me.dgPasien.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgPasien.Location = New System.Drawing.Point(0, 78)
        Me.dgPasien.Name = "dgPasien"
        Me.dgPasien.Size = New System.Drawing.Size(1370, 463)
        Me.dgPasien.TabIndex = 10
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'alamat
        '
        Me.alamat.DataPropertyName = "alamat"
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.Width = 300
        '
        'tlp_seluler
        '
        Me.tlp_seluler.DataPropertyName = "tlp_seluler"
        Me.tlp_seluler.HeaderText = "tlp_seluler"
        Me.tlp_seluler.Name = "tlp_seluler"
        '
        'JeniskelaminDataGridViewTextBoxColumn
        '
        Me.JeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.Name = "JeniskelaminDataGridViewTextBoxColumn"
        '
        'TempatlahirDataGridViewTextBoxColumn
        '
        Me.TempatlahirDataGridViewTextBoxColumn.DataPropertyName = "tempat_lahir"
        Me.TempatlahirDataGridViewTextBoxColumn.HeaderText = "tempat_lahir"
        Me.TempatlahirDataGridViewTextBoxColumn.Name = "TempatlahirDataGridViewTextBoxColumn"
        '
        'TgllahirDataGridViewTextBoxColumn
        '
        Me.TgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir"
        Me.TgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir"
        Me.TgllahirDataGridViewTextBoxColumn.Name = "TgllahirDataGridViewTextBoxColumn"
        '
        'GoldarahDataGridViewTextBoxColumn
        '
        Me.GoldarahDataGridViewTextBoxColumn.DataPropertyName = "gol_darah"
        Me.GoldarahDataGridViewTextBoxColumn.HeaderText = "gol_darah"
        Me.GoldarahDataGridViewTextBoxColumn.Name = "GoldarahDataGridViewTextBoxColumn"
        '
        'RhesusDataGridViewTextBoxColumn
        '
        Me.RhesusDataGridViewTextBoxColumn.DataPropertyName = "rhesus"
        Me.RhesusDataGridViewTextBoxColumn.HeaderText = "rhesus"
        Me.RhesusDataGridViewTextBoxColumn.Name = "RhesusDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "pendidikan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "pendidikan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "pekerjaan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "pekerjaan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'TlprumahDataGridViewTextBoxColumn
        '
        Me.TlprumahDataGridViewTextBoxColumn.DataPropertyName = "tlp_rumah"
        Me.TlprumahDataGridViewTextBoxColumn.HeaderText = "tlp_rumah"
        Me.TlprumahDataGridViewTextBoxColumn.Name = "TlprumahDataGridViewTextBoxColumn"
        '
        'TlpselulerDataGridViewTextBoxColumn
        '
        Me.TlpselulerDataGridViewTextBoxColumn.DataPropertyName = "tlp_seluler"
        Me.TlpselulerDataGridViewTextBoxColumn.HeaderText = "tlp_seluler"
        Me.TlpselulerDataGridViewTextBoxColumn.Name = "TlpselulerDataGridViewTextBoxColumn"
        '
        'TableAdapterProvinsi
        '
        Me.TableAdapterProvinsi.ClearBeforeFill = True
        '
        'TableAdapterPasien
        '
        Me.TableAdapterPasien.ClearBeforeFill = True
        '
        'data_pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 541)
        Me.Controls.Add(Me.dgPasien)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorPasien)
        Me.Name = "data_pasien"
        Me.Text = "Data pasien"
        CType(Me.BindingNavigatorPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorPasien.ResumeLayout(False)
        Me.BindingNavigatorPasien.PerformLayout()
        CType(Me.BindingSourcePasien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPasien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceProvinsi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorPasien As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewPasien As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeletePasien As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgPasien As System.Windows.Forms.DataGridView
    Friend WithEvents PekerjaanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PendidikanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSourceProvinsi As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterProvinsi As laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter
    Friend WithEvents BindingSourcePasien As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterPasien As laboratorium.DataSet_LabTableAdapters.pasienTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tlp_seluler As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JeniskelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TempatlahirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TgllahirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GoldarahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RhesusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TlprumahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TlpselulerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
