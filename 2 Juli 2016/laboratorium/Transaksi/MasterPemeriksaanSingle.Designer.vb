<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterPemeriksaanSingle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterPemeriksaanSingle))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtKodeReagen = New System.Windows.Forms.TextBox()
        Me.BindingSourceReagenOnBoard = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.BindingNavigatorReagenOnBoard = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNamaReagen = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPemakaianR4 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPemakaianR3 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPemakaianR2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPemakaianR1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbxRujukan = New System.Windows.Forms.GroupBox()
        Me.cbxRujukan = New System.Windows.Forms.ComboBox()
        Me.BindingSourceRujukan = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNilaiKritis = New System.Windows.Forms.TextBox()
        Me.cbxBahanPemeriksaan = New System.Windows.Forms.ComboBox()
        Me.BindingSourceBahanPemeriksaan = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxMetodePemeriksaan = New System.Windows.Forms.ComboBox()
        Me.BindingSourceMetodePemeriksaan = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxInstrument = New System.Windows.Forms.ComboBox()
        Me.BindingSourceInstrument = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDecimalHasil = New System.Windows.Forms.TextBox()
        Me.cbxSatuan = New System.Windows.Forms.ComboBox()
        Me.BindingSourceSatuanIsi = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxKelompok = New System.Windows.Forms.ComboBox()
        Me.BindingSourceMasterKelompok = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaPemeriksaan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodePemeriksaan = New System.Windows.Forms.TextBox()
        Me.TableAdapterMasterKelompok = New laboratorium.DataSet_LabTableAdapters.master_kelompokTableAdapter()
        Me.TableAdapterInstrument = New laboratorium.DataSet_LabTableAdapters.instrumentTableAdapter()
        Me.TableAdapterMetodePemeriksaan = New laboratorium.DataSet_LabTableAdapters.metode_pemeriksaanTableAdapter()
        Me.TableAdapterBahanPemeriksaan = New laboratorium.DataSet_LabTableAdapters.bahan_pemeriksaanTableAdapter()
        Me.TableAdapterRujukan = New laboratorium.DataSet_LabTableAdapters.rujukanTableAdapter()
        Me.TableAdapterReagenOnBoard = New laboratorium.DataSet_LabTableAdapters.reagen_on_boardTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgBarangHabisPakai = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceJenisBarangHabisPakai = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceBarangHabisPakai = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourcePrioritas = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgHargaPemeriksaan = New System.Windows.Forms.DataGridView()
        Me.PrioritasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VipserviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeanalisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedokterlabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceHargaPemeriksaan = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgNilaiNormal = New System.Windows.Forms.DataGridView()
        Me.deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UmurbawahtahunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmurbawahbulanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmurbawahhariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmuratastahunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmuratasbulanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmuratashariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaikritisatasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaikritisbawahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaibatasbawahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaibatasatasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplaynilainormalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSetLabBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceNilaiNormal = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterNilaiNormal = New laboratorium.DataSet_LabTableAdapters.nilai_normalTableAdapter()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.TableAdapterSatuanIsi = New laboratorium.DataSet_LabTableAdapters.satuan_isiTableAdapter()
        Me.TableAdapterPrioritas = New laboratorium.DataSet_LabTableAdapters.prioritasTableAdapter()
        Me.TableAdapterBarangHabisPakai = New laboratorium.DataSet_LabTableAdapters.barang_habis_pakaiTableAdapter()
        Me.TableAdapterJenisBarangHabisPakai = New laboratorium.DataSet_LabTableAdapters.jenis_barang_habis_pakaiTableAdapter()
        Me.TableAdapterHargaPemeriksaan = New laboratorium.DataSet_LabTableAdapters.harga_pemeriksaanTableAdapter()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BindingSourceReagenOnBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigatorReagenOnBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorReagenOnBoard.SuspendLayout()
        Me.gbxRujukan.SuspendLayout()
        CType(Me.BindingSourceRujukan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceBahanPemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceMetodePemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSatuanIsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceMasterKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgBarangHabisPakai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceJenisBarangHabisPakai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceBarangHabisPakai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourcePrioritas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgHargaPemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceHargaPemeriksaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgNilaiNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLabBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceNilaiNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSatuan)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.gbxRujukan)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtKeterangan)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtNilaiKritis)
        Me.GroupBox1.Controls.Add(Me.cbxBahanPemeriksaan)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbxMetodePemeriksaan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxInstrument)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDecimalHasil)
        Me.GroupBox1.Controls.Add(Me.cbxSatuan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxKelompok)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNamaPemeriksaan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKodePemeriksaan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 365)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pemeriksaan"
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(119, 117)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(69, 20)
        Me.txtSatuan.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtKodeReagen)
        Me.GroupBox3.Controls.Add(Me.BindingNavigatorReagenOnBoard)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtNamaReagen)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtPemakaianR4)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtPemakaianR3)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtPemakaianR2)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtPemakaianR1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(360, 84)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 228)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reagen"
        '
        'txtKodeReagen
        '
        Me.txtKodeReagen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceReagenOnBoard, "id_reagen_on_board", True))
        Me.txtKodeReagen.Location = New System.Drawing.Point(123, 51)
        Me.txtKodeReagen.Name = "txtKodeReagen"
        Me.txtKodeReagen.ReadOnly = True
        Me.txtKodeReagen.Size = New System.Drawing.Size(191, 20)
        Me.txtKodeReagen.TabIndex = 23
        '
        'BindingSourceReagenOnBoard
        '
        Me.BindingSourceReagenOnBoard.DataMember = "reagen_on_board"
        Me.BindingSourceReagenOnBoard.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorReagenOnBoard
        '
        Me.BindingNavigatorReagenOnBoard.AddNewItem = Nothing
        Me.BindingNavigatorReagenOnBoard.BindingSource = Me.BindingSourceReagenOnBoard
        Me.BindingNavigatorReagenOnBoard.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorReagenOnBoard.DeleteItem = Nothing
        Me.BindingNavigatorReagenOnBoard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigatorReagenOnBoard.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigatorReagenOnBoard.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorReagenOnBoard.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorReagenOnBoard.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorReagenOnBoard.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorReagenOnBoard.Name = "BindingNavigatorReagenOnBoard"
        Me.BindingNavigatorReagenOnBoard.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorReagenOnBoard.Size = New System.Drawing.Size(319, 25)
        Me.BindingNavigatorReagenOnBoard.TabIndex = 22
        Me.BindingNavigatorReagenOnBoard.Text = "BindingNavigatorReagenOnBoard"
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Nama Reagen"
        '
        'txtNamaReagen
        '
        Me.txtNamaReagen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceReagenOnBoard, "nama_reagen", True))
        Me.txtNamaReagen.Location = New System.Drawing.Point(123, 78)
        Me.txtNamaReagen.Name = "txtNamaReagen"
        Me.txtNamaReagen.ReadOnly = True
        Me.txtNamaReagen.Size = New System.Drawing.Size(191, 20)
        Me.txtNamaReagen.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(232, 203)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 13)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "µ l"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(232, 174)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 13)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "µ l"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(232, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "µ l"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(232, 113)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "µ l"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 205)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Pemakaian R4"
        '
        'txtPemakaianR4
        '
        Me.txtPemakaianR4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceReagenOnBoard, "R4", True))
        Me.txtPemakaianR4.Location = New System.Drawing.Point(123, 201)
        Me.txtPemakaianR4.Name = "txtPemakaianR4"
        Me.txtPemakaianR4.ReadOnly = True
        Me.txtPemakaianR4.Size = New System.Drawing.Size(66, 20)
        Me.txtPemakaianR4.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Pemakaian R3"
        '
        'txtPemakaianR3
        '
        Me.txtPemakaianR3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceReagenOnBoard, "R3", True))
        Me.txtPemakaianR3.Location = New System.Drawing.Point(123, 171)
        Me.txtPemakaianR3.Name = "txtPemakaianR3"
        Me.txtPemakaianR3.ReadOnly = True
        Me.txtPemakaianR3.Size = New System.Drawing.Size(66, 20)
        Me.txtPemakaianR3.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Pemakaian R2"
        '
        'txtPemakaianR2
        '
        Me.txtPemakaianR2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceReagenOnBoard, "R2", True))
        Me.txtPemakaianR2.Location = New System.Drawing.Point(123, 141)
        Me.txtPemakaianR2.Name = "txtPemakaianR2"
        Me.txtPemakaianR2.ReadOnly = True
        Me.txtPemakaianR2.Size = New System.Drawing.Size(66, 20)
        Me.txtPemakaianR2.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Pemakaian R1"
        '
        'txtPemakaianR1
        '
        Me.txtPemakaianR1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceReagenOnBoard, "R1", True))
        Me.txtPemakaianR1.Location = New System.Drawing.Point(123, 110)
        Me.txtPemakaianR1.Name = "txtPemakaianR1"
        Me.txtPemakaianR1.ReadOnly = True
        Me.txtPemakaianR1.Size = New System.Drawing.Size(66, 20)
        Me.txtPemakaianR1.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Kode Reagen"
        '
        'gbxRujukan
        '
        Me.gbxRujukan.Controls.Add(Me.cbxRujukan)
        Me.gbxRujukan.Controls.Add(Me.Label11)
        Me.gbxRujukan.Location = New System.Drawing.Point(360, 19)
        Me.gbxRujukan.Name = "gbxRujukan"
        Me.gbxRujukan.Size = New System.Drawing.Size(325, 53)
        Me.gbxRujukan.TabIndex = 20
        Me.gbxRujukan.TabStop = False
        Me.gbxRujukan.Text = "Rujukan"
        '
        'cbxRujukan
        '
        Me.cbxRujukan.DataSource = Me.BindingSourceRujukan
        Me.cbxRujukan.DisplayMember = "nama_kontak"
        Me.cbxRujukan.FormattingEnabled = True
        Me.cbxRujukan.Location = New System.Drawing.Point(123, 19)
        Me.cbxRujukan.Name = "cbxRujukan"
        Me.cbxRujukan.Size = New System.Drawing.Size(191, 21)
        Me.cbxRujukan.TabIndex = 7
        '
        'BindingSourceRujukan
        '
        Me.BindingSourceRujukan.DataMember = "rujukan"
        Me.BindingSourceRujukan.DataSource = Me.DataSet_Lab
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Nama Kontak"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(119, 318)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(566, 37)
        Me.txtKeterangan.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nilai Kritis"
        '
        'txtNilaiKritis
        '
        Me.txtNilaiKritis.Location = New System.Drawing.Point(119, 273)
        Me.txtNilaiKritis.Name = "txtNilaiKritis"
        Me.txtNilaiKritis.Size = New System.Drawing.Size(183, 20)
        Me.txtNilaiKritis.TabIndex = 16
        '
        'cbxBahanPemeriksaan
        '
        Me.cbxBahanPemeriksaan.DataSource = Me.BindingSourceBahanPemeriksaan
        Me.cbxBahanPemeriksaan.DisplayMember = "nama_bahan_pemeriksaan"
        Me.cbxBahanPemeriksaan.FormattingEnabled = True
        Me.cbxBahanPemeriksaan.Location = New System.Drawing.Point(119, 242)
        Me.cbxBahanPemeriksaan.Name = "cbxBahanPemeriksaan"
        Me.cbxBahanPemeriksaan.Size = New System.Drawing.Size(183, 21)
        Me.cbxBahanPemeriksaan.TabIndex = 15
        '
        'BindingSourceBahanPemeriksaan
        '
        Me.BindingSourceBahanPemeriksaan.DataMember = "bahan_pemeriksaan"
        Me.BindingSourceBahanPemeriksaan.DataSource = Me.DataSet_Lab
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Bahan Pemeriksaan"
        '
        'cbxMetodePemeriksaan
        '
        Me.cbxMetodePemeriksaan.DataSource = Me.BindingSourceMetodePemeriksaan
        Me.cbxMetodePemeriksaan.DisplayMember = "nama_metode_pemeriksaan"
        Me.cbxMetodePemeriksaan.FormattingEnabled = True
        Me.cbxMetodePemeriksaan.Location = New System.Drawing.Point(119, 211)
        Me.cbxMetodePemeriksaan.Name = "cbxMetodePemeriksaan"
        Me.cbxMetodePemeriksaan.Size = New System.Drawing.Size(183, 21)
        Me.cbxMetodePemeriksaan.TabIndex = 13
        '
        'BindingSourceMetodePemeriksaan
        '
        Me.BindingSourceMetodePemeriksaan.DataMember = "metode_pemeriksaan"
        Me.BindingSourceMetodePemeriksaan.DataSource = Me.DataSet_Lab
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Metode Pemeriksaan"
        '
        'cbxInstrument
        '
        Me.cbxInstrument.DataSource = Me.BindingSourceInstrument
        Me.cbxInstrument.DisplayMember = "nama_instrument"
        Me.cbxInstrument.FormattingEnabled = True
        Me.cbxInstrument.Location = New System.Drawing.Point(119, 180)
        Me.cbxInstrument.Name = "cbxInstrument"
        Me.cbxInstrument.Size = New System.Drawing.Size(183, 21)
        Me.cbxInstrument.TabIndex = 11
        '
        'BindingSourceInstrument
        '
        Me.BindingSourceInstrument.DataMember = "instrument"
        Me.BindingSourceInstrument.DataSource = Me.DataSet_Lab
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Instrument"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Decimal Hasil"
        '
        'txtDecimalHasil
        '
        Me.txtDecimalHasil.Location = New System.Drawing.Point(119, 149)
        Me.txtDecimalHasil.Name = "txtDecimalHasil"
        Me.txtDecimalHasil.Size = New System.Drawing.Size(183, 20)
        Me.txtDecimalHasil.TabIndex = 8
        '
        'cbxSatuan
        '
        Me.cbxSatuan.DataSource = Me.BindingSourceSatuanIsi
        Me.cbxSatuan.DisplayMember = "nama_satuan_isi"
        Me.cbxSatuan.FormattingEnabled = True
        Me.cbxSatuan.Location = New System.Drawing.Point(194, 117)
        Me.cbxSatuan.Name = "cbxSatuan"
        Me.cbxSatuan.Size = New System.Drawing.Size(108, 21)
        Me.cbxSatuan.TabIndex = 7
        '
        'BindingSourceSatuanIsi
        '
        Me.BindingSourceSatuanIsi.DataMember = "satuan_isi"
        Me.BindingSourceSatuanIsi.DataSource = Me.DataSetLabBindingSource
        '
        'DataSetLabBindingSource
        '
        Me.DataSetLabBindingSource.DataSource = Me.DataSet_Lab
        Me.DataSetLabBindingSource.Position = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Satuan"
        '
        'cbxKelompok
        '
        Me.cbxKelompok.DataSource = Me.BindingSourceMasterKelompok
        Me.cbxKelompok.DisplayMember = "kelompok"
        Me.cbxKelompok.FormattingEnabled = True
        Me.cbxKelompok.Location = New System.Drawing.Point(119, 85)
        Me.cbxKelompok.Name = "cbxKelompok"
        Me.cbxKelompok.Size = New System.Drawing.Size(183, 21)
        Me.cbxKelompok.TabIndex = 5
        '
        'BindingSourceMasterKelompok
        '
        Me.BindingSourceMasterKelompok.DataMember = "master_kelompok"
        Me.BindingSourceMasterKelompok.DataSource = Me.DataSet_Lab
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kelompok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Pemeriksaan"
        '
        'txtNamaPemeriksaan
        '
        Me.txtNamaPemeriksaan.Location = New System.Drawing.Point(119, 54)
        Me.txtNamaPemeriksaan.Name = "txtNamaPemeriksaan"
        Me.txtNamaPemeriksaan.Size = New System.Drawing.Size(183, 20)
        Me.txtNamaPemeriksaan.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Pemeriksaan"
        '
        'txtKodePemeriksaan
        '
        Me.txtKodePemeriksaan.Location = New System.Drawing.Point(119, 25)
        Me.txtKodePemeriksaan.Name = "txtKodePemeriksaan"
        Me.txtKodePemeriksaan.Size = New System.Drawing.Size(183, 20)
        Me.txtKodePemeriksaan.TabIndex = 0
        '
        'TableAdapterMasterKelompok
        '
        Me.TableAdapterMasterKelompok.ClearBeforeFill = True
        '
        'TableAdapterInstrument
        '
        Me.TableAdapterInstrument.ClearBeforeFill = True
        '
        'TableAdapterMetodePemeriksaan
        '
        Me.TableAdapterMetodePemeriksaan.ClearBeforeFill = True
        '
        'TableAdapterBahanPemeriksaan
        '
        Me.TableAdapterBahanPemeriksaan.ClearBeforeFill = True
        '
        'TableAdapterRujukan
        '
        Me.TableAdapterRujukan.ClearBeforeFill = True
        '
        'TableAdapterReagenOnBoard
        '
        Me.TableAdapterReagenOnBoard.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgBarangHabisPakai)
        Me.GroupBox4.Location = New System.Drawing.Point(729, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(629, 196)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Barang Habis Pakai"
        '
        'dgBarangHabisPakai
        '
        Me.dgBarangHabisPakai.AllowUserToAddRows = False
        Me.dgBarangHabisPakai.AutoGenerateColumns = False
        Me.dgBarangHabisPakai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBarangHabisPakai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.JenisDataGridViewTextBoxColumn, Me.jumlah})
        Me.dgBarangHabisPakai.DataSource = Me.BindingSourceJenisBarangHabisPakai
        Me.dgBarangHabisPakai.Location = New System.Drawing.Point(12, 21)
        Me.dgBarangHabisPakai.Name = "dgBarangHabisPakai"
        Me.dgBarangHabisPakai.Size = New System.Drawing.Size(604, 169)
        Me.dgBarangHabisPakai.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "Kode"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDDataGridViewTextBoxColumn.Width = 150
        '
        'JenisDataGridViewTextBoxColumn
        '
        Me.JenisDataGridViewTextBoxColumn.DataPropertyName = "jenis"
        Me.JenisDataGridViewTextBoxColumn.HeaderText = "Jenis"
        Me.JenisDataGridViewTextBoxColumn.Name = "JenisDataGridViewTextBoxColumn"
        Me.JenisDataGridViewTextBoxColumn.ReadOnly = True
        Me.JenisDataGridViewTextBoxColumn.Width = 300
        '
        'jumlah
        '
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.jumlah.DefaultCellStyle = DataGridViewCellStyle10
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Width = 110
        '
        'BindingSourceJenisBarangHabisPakai
        '
        Me.BindingSourceJenisBarangHabisPakai.DataMember = "jenis_barang_habis_pakai"
        Me.BindingSourceJenisBarangHabisPakai.DataSource = Me.DataSet_Lab
        '
        'BindingSourceBarangHabisPakai
        '
        Me.BindingSourceBarangHabisPakai.DataMember = "barang_habis_pakai"
        Me.BindingSourceBarangHabisPakai.DataSource = Me.DataSet_Lab
        '
        'BindingSourcePrioritas
        '
        Me.BindingSourcePrioritas.DataMember = "prioritas"
        Me.BindingSourcePrioritas.DataSource = Me.DataSet_Lab
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgHargaPemeriksaan)
        Me.GroupBox5.Location = New System.Drawing.Point(729, 213)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(629, 162)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Harga Pemeriksaan"
        '
        'dgHargaPemeriksaan
        '
        Me.dgHargaPemeriksaan.AutoGenerateColumns = False
        Me.dgHargaPemeriksaan.CausesValidation = False
        Me.dgHargaPemeriksaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHargaPemeriksaan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrioritasDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.VipserviceDataGridViewTextBoxColumn, Me.FeeanalisDataGridViewTextBoxColumn, Me.FeedokterlabDataGridViewTextBoxColumn})
        Me.dgHargaPemeriksaan.DataSource = Me.BindingSourceHargaPemeriksaan
        Me.dgHargaPemeriksaan.Location = New System.Drawing.Point(12, 22)
        Me.dgHargaPemeriksaan.Name = "dgHargaPemeriksaan"
        Me.dgHargaPemeriksaan.Size = New System.Drawing.Size(604, 130)
        Me.dgHargaPemeriksaan.TabIndex = 0
        '
        'PrioritasDataGridViewTextBoxColumn
        '
        Me.PrioritasDataGridViewTextBoxColumn.DataPropertyName = "prioritas"
        Me.PrioritasDataGridViewTextBoxColumn.DataSource = Me.BindingSourcePrioritas
        Me.PrioritasDataGridViewTextBoxColumn.DisplayMember = "nama_prioritas"
        Me.PrioritasDataGridViewTextBoxColumn.HeaderText = "Prioritas"
        Me.PrioritasDataGridViewTextBoxColumn.Name = "PrioritasDataGridViewTextBoxColumn"
        Me.PrioritasDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PrioritasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PrioritasDataGridViewTextBoxColumn.Width = 120
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.Width = 110
        '
        'VipserviceDataGridViewTextBoxColumn
        '
        Me.VipserviceDataGridViewTextBoxColumn.DataPropertyName = "vip_service"
        Me.VipserviceDataGridViewTextBoxColumn.HeaderText = "VIP Service"
        Me.VipserviceDataGridViewTextBoxColumn.Name = "VipserviceDataGridViewTextBoxColumn"
        Me.VipserviceDataGridViewTextBoxColumn.Width = 110
        '
        'FeeanalisDataGridViewTextBoxColumn
        '
        Me.FeeanalisDataGridViewTextBoxColumn.DataPropertyName = "fee_analis"
        Me.FeeanalisDataGridViewTextBoxColumn.HeaderText = "Fee_ Analis"
        Me.FeeanalisDataGridViewTextBoxColumn.Name = "FeeanalisDataGridViewTextBoxColumn"
        Me.FeeanalisDataGridViewTextBoxColumn.Width = 110
        '
        'FeedokterlabDataGridViewTextBoxColumn
        '
        Me.FeedokterlabDataGridViewTextBoxColumn.DataPropertyName = "fee_dokter_lab"
        Me.FeedokterlabDataGridViewTextBoxColumn.HeaderText = "Fee Dokter Lab"
        Me.FeedokterlabDataGridViewTextBoxColumn.Name = "FeedokterlabDataGridViewTextBoxColumn"
        Me.FeedokterlabDataGridViewTextBoxColumn.Width = 110
        '
        'BindingSourceHargaPemeriksaan
        '
        Me.BindingSourceHargaPemeriksaan.DataMember = "harga_pemeriksaan"
        Me.BindingSourceHargaPemeriksaan.DataSource = Me.DataSetLabBindingSource
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgNilaiNormal)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 387)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1346, 300)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Nilai Normal"
        '
        'dgNilaiNormal
        '
        Me.dgNilaiNormal.AutoGenerateColumns = False
        Me.dgNilaiNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgNilaiNormal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.deskripsi, Me.JeniskelaminDataGridViewTextBoxColumn, Me.UmurbawahtahunDataGridViewTextBoxColumn, Me.UmurbawahbulanDataGridViewTextBoxColumn, Me.UmurbawahhariDataGridViewTextBoxColumn, Me.UmuratastahunDataGridViewTextBoxColumn, Me.UmuratasbulanDataGridViewTextBoxColumn, Me.UmuratashariDataGridViewTextBoxColumn, Me.NilaikritisatasDataGridViewTextBoxColumn, Me.NilaikritisbawahDataGridViewTextBoxColumn, Me.NilaibatasbawahDataGridViewTextBoxColumn, Me.NilaibatasatasDataGridViewTextBoxColumn, Me.DisplaynilainormalDataGridViewTextBoxColumn})
        Me.dgNilaiNormal.DataMember = "nilai_normal"
        Me.dgNilaiNormal.DataSource = Me.DataSetLabBindingSource1
        Me.dgNilaiNormal.Location = New System.Drawing.Point(6, 28)
        Me.dgNilaiNormal.Name = "dgNilaiNormal"
        Me.dgNilaiNormal.Size = New System.Drawing.Size(1327, 258)
        Me.dgNilaiNormal.TabIndex = 1
        '
        'deskripsi
        '
        Me.deskripsi.DataPropertyName = "deskripsi"
        Me.deskripsi.HeaderText = "Deskripsi"
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Width = 200
        '
        'JeniskelaminDataGridViewTextBoxColumn
        '
        Me.JeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.Items.AddRange(New Object() {"L", "P"})
        Me.JeniskelaminDataGridViewTextBoxColumn.Name = "JeniskelaminDataGridViewTextBoxColumn"
        Me.JeniskelaminDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.JeniskelaminDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.JeniskelaminDataGridViewTextBoxColumn.Width = 70
        '
        'UmurbawahtahunDataGridViewTextBoxColumn
        '
        Me.UmurbawahtahunDataGridViewTextBoxColumn.DataPropertyName = "umur_bawah_tahun"
        Me.UmurbawahtahunDataGridViewTextBoxColumn.HeaderText = "Umur Bawah (Tahun)"
        Me.UmurbawahtahunDataGridViewTextBoxColumn.Name = "UmurbawahtahunDataGridViewTextBoxColumn"
        Me.UmurbawahtahunDataGridViewTextBoxColumn.Width = 95
        '
        'UmurbawahbulanDataGridViewTextBoxColumn
        '
        Me.UmurbawahbulanDataGridViewTextBoxColumn.DataPropertyName = "umur_bawah_bulan"
        Me.UmurbawahbulanDataGridViewTextBoxColumn.HeaderText = "Umur Bawah (Bulan)"
        Me.UmurbawahbulanDataGridViewTextBoxColumn.Name = "UmurbawahbulanDataGridViewTextBoxColumn"
        Me.UmurbawahbulanDataGridViewTextBoxColumn.Width = 95
        '
        'UmurbawahhariDataGridViewTextBoxColumn
        '
        Me.UmurbawahhariDataGridViewTextBoxColumn.DataPropertyName = "umur_bawah_hari"
        Me.UmurbawahhariDataGridViewTextBoxColumn.HeaderText = "Umur Bawah (Hari)"
        Me.UmurbawahhariDataGridViewTextBoxColumn.Name = "UmurbawahhariDataGridViewTextBoxColumn"
        Me.UmurbawahhariDataGridViewTextBoxColumn.Width = 95
        '
        'UmuratastahunDataGridViewTextBoxColumn
        '
        Me.UmuratastahunDataGridViewTextBoxColumn.DataPropertyName = "umur_atas_tahun"
        Me.UmuratastahunDataGridViewTextBoxColumn.HeaderText = "Umur Atas (Tahun)"
        Me.UmuratastahunDataGridViewTextBoxColumn.Name = "UmuratastahunDataGridViewTextBoxColumn"
        Me.UmuratastahunDataGridViewTextBoxColumn.Width = 90
        '
        'UmuratasbulanDataGridViewTextBoxColumn
        '
        Me.UmuratasbulanDataGridViewTextBoxColumn.DataPropertyName = "umur_atas_bulan"
        Me.UmuratasbulanDataGridViewTextBoxColumn.HeaderText = "Umur Atas (Bulan)"
        Me.UmuratasbulanDataGridViewTextBoxColumn.Name = "UmuratasbulanDataGridViewTextBoxColumn"
        Me.UmuratasbulanDataGridViewTextBoxColumn.Width = 90
        '
        'UmuratashariDataGridViewTextBoxColumn
        '
        Me.UmuratashariDataGridViewTextBoxColumn.DataPropertyName = "umur_atas_hari"
        Me.UmuratashariDataGridViewTextBoxColumn.HeaderText = "Umur Atas (Hari)"
        Me.UmuratashariDataGridViewTextBoxColumn.Name = "UmuratashariDataGridViewTextBoxColumn"
        Me.UmuratashariDataGridViewTextBoxColumn.Width = 90
        '
        'NilaikritisatasDataGridViewTextBoxColumn
        '
        Me.NilaikritisatasDataGridViewTextBoxColumn.DataPropertyName = "nilai_kritis_atas"
        Me.NilaikritisatasDataGridViewTextBoxColumn.HeaderText = "Nilai Kritis (Atas)"
        Me.NilaikritisatasDataGridViewTextBoxColumn.Name = "NilaikritisatasDataGridViewTextBoxColumn"
        Me.NilaikritisatasDataGridViewTextBoxColumn.Width = 80
        '
        'NilaikritisbawahDataGridViewTextBoxColumn
        '
        Me.NilaikritisbawahDataGridViewTextBoxColumn.DataPropertyName = "nilai_kritis_bawah"
        Me.NilaikritisbawahDataGridViewTextBoxColumn.HeaderText = "Nilai Kritis (Bawah)"
        Me.NilaikritisbawahDataGridViewTextBoxColumn.Name = "NilaikritisbawahDataGridViewTextBoxColumn"
        Me.NilaikritisbawahDataGridViewTextBoxColumn.Width = 80
        '
        'NilaibatasbawahDataGridViewTextBoxColumn
        '
        Me.NilaibatasbawahDataGridViewTextBoxColumn.DataPropertyName = "nilai_batas_bawah"
        DataGridViewCellStyle11.Format = "N1"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.NilaibatasbawahDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.NilaibatasbawahDataGridViewTextBoxColumn.HeaderText = "Nilai Batas (Bawah)"
        Me.NilaibatasbawahDataGridViewTextBoxColumn.Name = "NilaibatasbawahDataGridViewTextBoxColumn"
        Me.NilaibatasbawahDataGridViewTextBoxColumn.Width = 85
        '
        'NilaibatasatasDataGridViewTextBoxColumn
        '
        Me.NilaibatasatasDataGridViewTextBoxColumn.DataPropertyName = "nilai_batas_atas"
        DataGridViewCellStyle12.Format = "N1"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.NilaibatasatasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.NilaibatasatasDataGridViewTextBoxColumn.HeaderText = "Nilai Batas (Atas)"
        Me.NilaibatasatasDataGridViewTextBoxColumn.Name = "NilaibatasatasDataGridViewTextBoxColumn"
        Me.NilaibatasatasDataGridViewTextBoxColumn.Width = 85
        '
        'DisplaynilainormalDataGridViewTextBoxColumn
        '
        Me.DisplaynilainormalDataGridViewTextBoxColumn.DataPropertyName = "display_nilai_normal"
        Me.DisplaynilainormalDataGridViewTextBoxColumn.HeaderText = "Display Nilai Normal"
        Me.DisplaynilainormalDataGridViewTextBoxColumn.Name = "DisplaynilainormalDataGridViewTextBoxColumn"
        Me.DisplaynilainormalDataGridViewTextBoxColumn.Width = 129
        '
        'DataSetLabBindingSource1
        '
        Me.DataSetLabBindingSource1.DataSource = Me.DataSet_Lab
        Me.DataSetLabBindingSource1.Position = 0
        '
        'BindingSourceNilaiNormal
        '
        Me.BindingSourceNilaiNormal.DataMember = "nilai_normal"
        Me.BindingSourceNilaiNormal.DataSource = Me.DataSetLabBindingSource
        '
        'TableAdapterNilaiNormal
        '
        Me.TableAdapterNilaiNormal.ClearBeforeFill = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(587, 693)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 26
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(699, 693)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 27
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'TableAdapterSatuanIsi
        '
        Me.TableAdapterSatuanIsi.ClearBeforeFill = True
        '
        'TableAdapterPrioritas
        '
        Me.TableAdapterPrioritas.ClearBeforeFill = True
        '
        'TableAdapterBarangHabisPakai
        '
        Me.TableAdapterBarangHabisPakai.ClearBeforeFill = True
        '
        'TableAdapterJenisBarangHabisPakai
        '
        Me.TableAdapterJenisBarangHabisPakai.ClearBeforeFill = True
        '
        'TableAdapterHargaPemeriksaan
        '
        Me.TableAdapterHargaPemeriksaan.ClearBeforeFill = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(193, 114)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(31, 13)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "- 100"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(195, 144)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 13)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "- 100"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(195, 174)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 13)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "- 100"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(195, 204)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 13)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "- 100"
        '
        'MasterPemeriksaanSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 746)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MasterPemeriksaanSingle"
        Me.Text = "Master Pemeriksaan (Single)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BindingSourceReagenOnBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigatorReagenOnBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorReagenOnBoard.ResumeLayout(False)
        Me.BindingNavigatorReagenOnBoard.PerformLayout()
        Me.gbxRujukan.ResumeLayout(False)
        Me.gbxRujukan.PerformLayout()
        CType(Me.BindingSourceRujukan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceBahanPemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceMetodePemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSatuanIsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceMasterKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgBarangHabisPakai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceJenisBarangHabisPakai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceBarangHabisPakai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourcePrioritas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgHargaPemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceHargaPemeriksaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgNilaiNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLabBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceNilaiNormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxKelompok As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPemeriksaan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodePemeriksaan As System.Windows.Forms.TextBox
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents BindingSourceMasterKelompok As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterMasterKelompok As laboratorium.DataSet_LabTableAdapters.master_kelompokTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDecimalHasil As System.Windows.Forms.TextBox
    Friend WithEvents cbxSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxInstrument As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BindingSourceInstrument As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterInstrument As laboratorium.DataSet_LabTableAdapters.instrumentTableAdapter
    Friend WithEvents cbxMetodePemeriksaan As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BindingSourceMetodePemeriksaan As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterMetodePemeriksaan As laboratorium.DataSet_LabTableAdapters.metode_pemeriksaanTableAdapter
    Friend WithEvents cbxBahanPemeriksaan As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BindingSourceBahanPemeriksaan As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterBahanPemeriksaan As laboratorium.DataSet_LabTableAdapters.bahan_pemeriksaanTableAdapter
    Friend WithEvents gbxRujukan As System.Windows.Forms.GroupBox
    Friend WithEvents cbxRujukan As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNilaiKritis As System.Windows.Forms.TextBox
    Friend WithEvents BindingSourceRujukan As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterRujukan As laboratorium.DataSet_LabTableAdapters.rujukanTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BindingSourceReagenOnBoard As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterReagenOnBoard As laboratorium.DataSet_LabTableAdapters.reagen_on_boardTableAdapter
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPemakaianR1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPemakaianR3 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPemakaianR2 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPemakaianR4 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dgHargaPemeriksaan As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetLabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dgNilaiNormal As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceNilaiNormal As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterNilaiNormal As laboratorium.DataSet_LabTableAdapters.nilai_normalTableAdapter
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents BindingSourceSatuanIsi As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterSatuanIsi As laboratorium.DataSet_LabTableAdapters.satuan_isiTableAdapter
    Friend WithEvents TableAdapterPrioritas As laboratorium.DataSet_LabTableAdapters.prioritasTableAdapter
    Friend WithEvents BindingSourcePrioritas As System.Windows.Forms.BindingSource
    Friend WithEvents txtNamaReagen As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigatorReagenOnBoard As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtKodeReagen As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgBarangHabisPakai As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceBarangHabisPakai As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterBarangHabisPakai As laboratorium.DataSet_LabTableAdapters.barang_habis_pakaiTableAdapter
    Friend WithEvents BindingSourceJenisBarangHabisPakai As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterJenisBarangHabisPakai As laboratorium.DataSet_LabTableAdapters.jenis_barang_habis_pakaiTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSetLabBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceHargaPemeriksaan As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterHargaPemeriksaan As laboratorium.DataSet_LabTableAdapters.harga_pemeriksaanTableAdapter
    Friend WithEvents PrioritasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VipserviceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeeanalisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeedokterlabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deskripsi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JeniskelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents UmurbawahtahunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmurbawahbulanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmurbawahhariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmuratastahunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmuratasbulanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmuratashariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NilaikritisatasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NilaikritisbawahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NilaibatasbawahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NilaibatasatasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisplaynilainormalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
