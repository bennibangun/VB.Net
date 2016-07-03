<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class status_reagen_on_board
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(status_reagen_on_board))
        Me.BindingNavigatorReagenOnBoard = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewReagenOnBoard = New System.Windows.Forms.ToolStripButton()
        Me.BindingSourceReagenOnBoard = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteReagenOnBoard = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgReagenOnBoard = New System.Windows.Forms.DataGridView()
        Me.sisa_volume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceNamaReagen = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceKelompok = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSourceSupplier = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpExpiredDate = New System.Windows.Forms.DateTimePicker()
        Me.TableAdapterReagenOnBoard = New laboratorium.DataSet_LabTableAdapters.reagen_on_boardTableAdapter()
        Me.TableAdapterNamaReagen = New laboratorium.DataSet_LabTableAdapters.nama_reagenTableAdapter()
        Me.TableAdapterKelompok = New laboratorium.DataSet_LabTableAdapters.kelompokTableAdapter()
        Me.SupplierTableAdapter = New laboratorium.DataSet_LabTableAdapters.supplierTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxReagen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxR1 = New System.Windows.Forms.GroupBox()
        Me.gbxR2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxR3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxR4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamareagenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorlotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorbatchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorlabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanexpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelompokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuthnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktublnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuhariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglinputDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisavolumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanvolumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirevisiolehDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartjamrevisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndjamrevisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglrevisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamareagenDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorlotDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorbatchDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorlabDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpdateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanexpDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelompokDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuthnDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktublnDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuhariDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R4DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglinputDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisavolumeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanvolumeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirevisiolehDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartjamrevisiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndjamrevisiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglrevisiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamareagenDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorlotDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorbatchDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorlabDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpdateDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanexpDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelompokDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuthnDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktublnDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuhariDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R4DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglinputDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisavolumeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanvolumeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirevisiolehDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartjamrevisiDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndjamrevisiDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglrevisiDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamareagenDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorlotDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorbatchDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorlabDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpdateDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanexpDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelompokDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuthnDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktublnDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuhariDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R1DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R2DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R3DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R4DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglinputDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisavolumeDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanvolumeDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirevisiolehDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartjamrevisiDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndjamrevisiDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglrevisiDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingNavigatorReagenOnBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorReagenOnBoard.SuspendLayout()
        CType(Me.BindingSourceReagenOnBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReagenOnBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceNamaReagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxR1.SuspendLayout()
        Me.gbxR2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxR3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxR4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorReagenOnBoard
        '
        Me.BindingNavigatorReagenOnBoard.AddNewItem = Me.BindingNavigatorAddNewReagenOnBoard
        Me.BindingNavigatorReagenOnBoard.BindingSource = Me.BindingSourceReagenOnBoard
        Me.BindingNavigatorReagenOnBoard.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorReagenOnBoard.DeleteItem = Me.BindingNavigatorDeleteReagenOnBoard
        Me.BindingNavigatorReagenOnBoard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewReagenOnBoard, Me.BindingNavigatorDeleteReagenOnBoard, Me.ButtonSave})
        Me.BindingNavigatorReagenOnBoard.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorReagenOnBoard.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorReagenOnBoard.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorReagenOnBoard.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorReagenOnBoard.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorReagenOnBoard.Name = "BindingNavigatorReagenOnBoard"
        Me.BindingNavigatorReagenOnBoard.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorReagenOnBoard.Size = New System.Drawing.Size(1370, 25)
        Me.BindingNavigatorReagenOnBoard.TabIndex = 3
        Me.BindingNavigatorReagenOnBoard.Text = "Rujukan"
        '
        'BindingNavigatorAddNewReagenOnBoard
        '
        Me.BindingNavigatorAddNewReagenOnBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewReagenOnBoard.Image = CType(resources.GetObject("BindingNavigatorAddNewReagenOnBoard.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewReagenOnBoard.Name = "BindingNavigatorAddNewReagenOnBoard"
        Me.BindingNavigatorAddNewReagenOnBoard.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewReagenOnBoard.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewReagenOnBoard.Text = "Add new"
        '
        'BindingSourceReagenOnBoard
        '
        Me.BindingSourceReagenOnBoard.DataMember = "reagen_on_board"
        Me.BindingSourceReagenOnBoard.DataSource = Me.DataSet_Lab
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteReagenOnBoard
        '
        Me.BindingNavigatorDeleteReagenOnBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteReagenOnBoard.Image = CType(resources.GetObject("BindingNavigatorDeleteReagenOnBoard.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteReagenOnBoard.Name = "BindingNavigatorDeleteReagenOnBoard"
        Me.BindingNavigatorDeleteReagenOnBoard.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteReagenOnBoard.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteReagenOnBoard.Text = "Delete"
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
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(683, 37)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgReagenOnBoard
        '
        Me.dgReagenOnBoard.AllowUserToAddRows = False
        Me.dgReagenOnBoard.AutoGenerateColumns = False
        Me.dgReagenOnBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReagenOnBoard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sisa_volume, Me.DataGridViewTextBoxColumn46, Me.IdDataGridViewTextBoxColumn3, Me.NamareagenDataGridViewTextBoxColumn3, Me.NomorlotDataGridViewTextBoxColumn3, Me.NomorbatchDataGridViewTextBoxColumn3, Me.NomorlabDataGridViewTextBoxColumn3, Me.ExpdateDataGridViewTextBoxColumn3, Me.PeringatanexpDataGridViewTextBoxColumn3, Me.KelompokDataGridViewTextBoxColumn3, Me.SupplierDataGridViewTextBoxColumn3, Me.SisawaktuthnDataGridViewTextBoxColumn3, Me.SisawaktublnDataGridViewTextBoxColumn3, Me.SisawaktuhariDataGridViewTextBoxColumn3, Me.R1DataGridViewTextBoxColumn3, Me.R2DataGridViewTextBoxColumn3, Me.R3DataGridViewTextBoxColumn3, Me.R4DataGridViewTextBoxColumn3, Me.TglinputDataGridViewTextBoxColumn3, Me.SisavolumeDataGridViewTextBoxColumn3, Me.PeringatanvolumeDataGridViewTextBoxColumn3, Me.DirevisiolehDataGridViewTextBoxColumn3, Me.StartjamrevisiDataGridViewTextBoxColumn3, Me.EndjamrevisiDataGridViewTextBoxColumn3, Me.TglrevisiDataGridViewTextBoxColumn3, Me.KeteranganDataGridViewTextBoxColumn3})
        Me.dgReagenOnBoard.DataSource = Me.BindingSourceReagenOnBoard
        Me.dgReagenOnBoard.Location = New System.Drawing.Point(10, 15)
        Me.dgReagenOnBoard.Name = "dgReagenOnBoard"
        Me.dgReagenOnBoard.Size = New System.Drawing.Size(1343, 125)
        Me.dgReagenOnBoard.TabIndex = 24
        '
        'sisa_volume
        '
        Me.sisa_volume.DataPropertyName = "sisa_volume"
        Me.sisa_volume.HeaderText = "Sisa volume"
        Me.sisa_volume.Name = "sisa_volume"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "sisa_volume"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Sisa"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Width = 50
        '
        'BindingSourceNamaReagen
        '
        Me.BindingSourceNamaReagen.DataMember = "nama_reagen"
        Me.BindingSourceNamaReagen.DataSource = Me.DataSet_Lab
        '
        'BindingSourceKelompok
        '
        Me.BindingSourceKelompok.DataMember = "kelompok"
        Me.BindingSourceKelompok.DataSource = Me.DataSet_Lab
        '
        'BindingSourceSupplier
        '
        Me.BindingSourceSupplier.DataMember = "supplier"
        Me.BindingSourceSupplier.DataSource = Me.DataSet_Lab
        '
        'dtpExpiredDate
        '
        Me.dtpExpiredDate.Location = New System.Drawing.Point(451, 39)
        Me.dtpExpiredDate.Name = "dtpExpiredDate"
        Me.dtpExpiredDate.Size = New System.Drawing.Size(128, 20)
        Me.dtpExpiredDate.TabIndex = 25
        '
        'TableAdapterReagenOnBoard
        '
        Me.TableAdapterReagenOnBoard.ClearBeforeFill = True
        '
        'TableAdapterNamaReagen
        '
        Me.TableAdapterNamaReagen.ClearBeforeFill = True
        '
        'TableAdapterKelompok
        '
        Me.TableAdapterKelompok.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Expired date"
        '
        'cbxReagen
        '
        Me.cbxReagen.DataSource = Me.BindingSourceNamaReagen
        Me.cbxReagen.DisplayMember = "jenis_reagen"
        Me.cbxReagen.FormattingEnabled = True
        Me.cbxReagen.Location = New System.Drawing.Point(58, 39)
        Me.cbxReagen.Name = "cbxReagen"
        Me.cbxReagen.Size = New System.Drawing.Size(262, 21)
        Me.cbxReagen.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Reagen"
        '
        'gbxR1
        '
        Me.gbxR1.Controls.Add(Me.dgReagenOnBoard)
        Me.gbxR1.Location = New System.Drawing.Point(0, 76)
        Me.gbxR1.Name = "gbxR1"
        Me.gbxR1.Size = New System.Drawing.Size(1370, 149)
        Me.gbxR1.TabIndex = 29
        Me.gbxR1.TabStop = False
        Me.gbxR1.Text = "R1"
        '
        'gbxR2
        '
        Me.gbxR2.Controls.Add(Me.DataGridView1)
        Me.gbxR2.Location = New System.Drawing.Point(0, 237)
        Me.gbxR2.Name = "gbxR2"
        Me.gbxR2.Size = New System.Drawing.Size(1370, 151)
        Me.gbxR2.TabIndex = 30
        Me.gbxR2.TabStop = False
        Me.gbxR2.Text = "R2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn14, Me.IdDataGridViewTextBoxColumn2, Me.NamareagenDataGridViewTextBoxColumn2, Me.NomorlotDataGridViewTextBoxColumn2, Me.NomorbatchDataGridViewTextBoxColumn2, Me.NomorlabDataGridViewTextBoxColumn2, Me.ExpdateDataGridViewTextBoxColumn2, Me.PeringatanexpDataGridViewTextBoxColumn2, Me.KelompokDataGridViewTextBoxColumn2, Me.SupplierDataGridViewTextBoxColumn2, Me.SisawaktuthnDataGridViewTextBoxColumn2, Me.SisawaktublnDataGridViewTextBoxColumn2, Me.SisawaktuhariDataGridViewTextBoxColumn2, Me.R1DataGridViewTextBoxColumn2, Me.R2DataGridViewTextBoxColumn2, Me.R3DataGridViewTextBoxColumn2, Me.R4DataGridViewTextBoxColumn2, Me.TglinputDataGridViewTextBoxColumn2, Me.SisavolumeDataGridViewTextBoxColumn2, Me.PeringatanvolumeDataGridViewTextBoxColumn2, Me.DirevisiolehDataGridViewTextBoxColumn2, Me.StartjamrevisiDataGridViewTextBoxColumn2, Me.EndjamrevisiDataGridViewTextBoxColumn2, Me.TglrevisiDataGridViewTextBoxColumn2, Me.KeteranganDataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.BindingSourceReagenOnBoard
        Me.DataGridView1.Location = New System.Drawing.Point(10, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1343, 125)
        Me.DataGridView1.TabIndex = 24
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "sisa_volume"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Sisa volume"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "sisa_volume"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Sisa"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 50
        '
        'gbxR3
        '
        Me.gbxR3.Controls.Add(Me.DataGridView2)
        Me.gbxR3.Location = New System.Drawing.Point(0, 402)
        Me.gbxR3.Name = "gbxR3"
        Me.gbxR3.Size = New System.Drawing.Size(1370, 150)
        Me.gbxR3.TabIndex = 31
        Me.gbxR3.TabStop = False
        Me.gbxR3.Text = "R3"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn28, Me.IdDataGridViewTextBoxColumn1, Me.NamareagenDataGridViewTextBoxColumn1, Me.NomorlotDataGridViewTextBoxColumn1, Me.NomorbatchDataGridViewTextBoxColumn1, Me.NomorlabDataGridViewTextBoxColumn1, Me.ExpdateDataGridViewTextBoxColumn1, Me.PeringatanexpDataGridViewTextBoxColumn1, Me.KelompokDataGridViewTextBoxColumn1, Me.SupplierDataGridViewTextBoxColumn1, Me.SisawaktuthnDataGridViewTextBoxColumn1, Me.SisawaktublnDataGridViewTextBoxColumn1, Me.SisawaktuhariDataGridViewTextBoxColumn1, Me.R1DataGridViewTextBoxColumn1, Me.R2DataGridViewTextBoxColumn1, Me.R3DataGridViewTextBoxColumn1, Me.R4DataGridViewTextBoxColumn1, Me.TglinputDataGridViewTextBoxColumn1, Me.SisavolumeDataGridViewTextBoxColumn1, Me.PeringatanvolumeDataGridViewTextBoxColumn1, Me.DirevisiolehDataGridViewTextBoxColumn1, Me.StartjamrevisiDataGridViewTextBoxColumn1, Me.EndjamrevisiDataGridViewTextBoxColumn1, Me.TglrevisiDataGridViewTextBoxColumn1, Me.KeteranganDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.BindingSourceReagenOnBoard
        Me.DataGridView2.Location = New System.Drawing.Point(10, 15)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1343, 125)
        Me.DataGridView2.TabIndex = 24
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "sisa_volume"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Sisa volume"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "sisa_volume"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Sisa"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 50
        '
        'gbxR4
        '
        Me.gbxR4.Controls.Add(Me.DataGridView3)
        Me.gbxR4.Location = New System.Drawing.Point(0, 569)
        Me.gbxR4.Name = "gbxR4"
        Me.gbxR4.Size = New System.Drawing.Size(1370, 152)
        Me.gbxR4.TabIndex = 32
        Me.gbxR4.TabStop = False
        Me.gbxR4.Text = "R4"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn42, Me.IdDataGridViewTextBoxColumn, Me.NamareagenDataGridViewTextBoxColumn, Me.NomorlotDataGridViewTextBoxColumn, Me.NomorbatchDataGridViewTextBoxColumn, Me.NomorlabDataGridViewTextBoxColumn, Me.ExpdateDataGridViewTextBoxColumn, Me.PeringatanexpDataGridViewTextBoxColumn, Me.KelompokDataGridViewTextBoxColumn, Me.SupplierDataGridViewTextBoxColumn, Me.SisawaktuthnDataGridViewTextBoxColumn, Me.SisawaktublnDataGridViewTextBoxColumn, Me.SisawaktuhariDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.R4DataGridViewTextBoxColumn, Me.TglinputDataGridViewTextBoxColumn, Me.SisavolumeDataGridViewTextBoxColumn, Me.PeringatanvolumeDataGridViewTextBoxColumn, Me.DirevisiolehDataGridViewTextBoxColumn, Me.StartjamrevisiDataGridViewTextBoxColumn, Me.EndjamrevisiDataGridViewTextBoxColumn, Me.TglrevisiDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.BindingSourceReagenOnBoard
        Me.DataGridView3.Location = New System.Drawing.Point(10, 17)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1343, 125)
        Me.DataGridView3.TabIndex = 24
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "sisa_volume"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Sisa volume"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "sisa_volume"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Sisa"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 50
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamareagenDataGridViewTextBoxColumn
        '
        Me.NamareagenDataGridViewTextBoxColumn.DataPropertyName = "nama_reagen"
        Me.NamareagenDataGridViewTextBoxColumn.HeaderText = "nama_reagen"
        Me.NamareagenDataGridViewTextBoxColumn.Name = "NamareagenDataGridViewTextBoxColumn"
        '
        'NomorlotDataGridViewTextBoxColumn
        '
        Me.NomorlotDataGridViewTextBoxColumn.DataPropertyName = "nomor_lot"
        Me.NomorlotDataGridViewTextBoxColumn.HeaderText = "nomor_lot"
        Me.NomorlotDataGridViewTextBoxColumn.Name = "NomorlotDataGridViewTextBoxColumn"
        '
        'NomorbatchDataGridViewTextBoxColumn
        '
        Me.NomorbatchDataGridViewTextBoxColumn.DataPropertyName = "nomor_batch"
        Me.NomorbatchDataGridViewTextBoxColumn.HeaderText = "nomor_batch"
        Me.NomorbatchDataGridViewTextBoxColumn.Name = "NomorbatchDataGridViewTextBoxColumn"
        '
        'NomorlabDataGridViewTextBoxColumn
        '
        Me.NomorlabDataGridViewTextBoxColumn.DataPropertyName = "nomor_lab"
        Me.NomorlabDataGridViewTextBoxColumn.HeaderText = "nomor_lab"
        Me.NomorlabDataGridViewTextBoxColumn.Name = "NomorlabDataGridViewTextBoxColumn"
        '
        'ExpdateDataGridViewTextBoxColumn
        '
        Me.ExpdateDataGridViewTextBoxColumn.DataPropertyName = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn.HeaderText = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn.Name = "ExpdateDataGridViewTextBoxColumn"
        '
        'PeringatanexpDataGridViewTextBoxColumn
        '
        Me.PeringatanexpDataGridViewTextBoxColumn.DataPropertyName = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn.HeaderText = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn.Name = "PeringatanexpDataGridViewTextBoxColumn"
        '
        'KelompokDataGridViewTextBoxColumn
        '
        Me.KelompokDataGridViewTextBoxColumn.DataPropertyName = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn.HeaderText = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn.Name = "KelompokDataGridViewTextBoxColumn"
        '
        'SupplierDataGridViewTextBoxColumn
        '
        Me.SupplierDataGridViewTextBoxColumn.DataPropertyName = "supplier"
        Me.SupplierDataGridViewTextBoxColumn.HeaderText = "supplier"
        Me.SupplierDataGridViewTextBoxColumn.Name = "SupplierDataGridViewTextBoxColumn"
        '
        'SisawaktuthnDataGridViewTextBoxColumn
        '
        Me.SisawaktuthnDataGridViewTextBoxColumn.DataPropertyName = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn.HeaderText = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn.Name = "SisawaktuthnDataGridViewTextBoxColumn"
        '
        'SisawaktublnDataGridViewTextBoxColumn
        '
        Me.SisawaktublnDataGridViewTextBoxColumn.DataPropertyName = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn.HeaderText = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn.Name = "SisawaktublnDataGridViewTextBoxColumn"
        '
        'SisawaktuhariDataGridViewTextBoxColumn
        '
        Me.SisawaktuhariDataGridViewTextBoxColumn.DataPropertyName = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn.HeaderText = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn.Name = "SisawaktuhariDataGridViewTextBoxColumn"
        '
        'R1DataGridViewTextBoxColumn
        '
        Me.R1DataGridViewTextBoxColumn.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn.Name = "R1DataGridViewTextBoxColumn"
        '
        'R2DataGridViewTextBoxColumn
        '
        Me.R2DataGridViewTextBoxColumn.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn.Name = "R2DataGridViewTextBoxColumn"
        '
        'R3DataGridViewTextBoxColumn
        '
        Me.R3DataGridViewTextBoxColumn.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn.Name = "R3DataGridViewTextBoxColumn"
        '
        'R4DataGridViewTextBoxColumn
        '
        Me.R4DataGridViewTextBoxColumn.DataPropertyName = "R4"
        Me.R4DataGridViewTextBoxColumn.HeaderText = "R4"
        Me.R4DataGridViewTextBoxColumn.Name = "R4DataGridViewTextBoxColumn"
        '
        'TglinputDataGridViewTextBoxColumn
        '
        Me.TglinputDataGridViewTextBoxColumn.DataPropertyName = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn.HeaderText = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn.Name = "TglinputDataGridViewTextBoxColumn"
        '
        'SisavolumeDataGridViewTextBoxColumn
        '
        Me.SisavolumeDataGridViewTextBoxColumn.DataPropertyName = "sisa_volume"
        Me.SisavolumeDataGridViewTextBoxColumn.HeaderText = "sisa_volume"
        Me.SisavolumeDataGridViewTextBoxColumn.Name = "SisavolumeDataGridViewTextBoxColumn"
        '
        'PeringatanvolumeDataGridViewTextBoxColumn
        '
        Me.PeringatanvolumeDataGridViewTextBoxColumn.DataPropertyName = "peringatan_volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn.HeaderText = "peringatan_volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn.Name = "PeringatanvolumeDataGridViewTextBoxColumn"
        '
        'DirevisiolehDataGridViewTextBoxColumn
        '
        Me.DirevisiolehDataGridViewTextBoxColumn.DataPropertyName = "direvisi_oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn.HeaderText = "direvisi_oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn.Name = "DirevisiolehDataGridViewTextBoxColumn"
        '
        'StartjamrevisiDataGridViewTextBoxColumn
        '
        Me.StartjamrevisiDataGridViewTextBoxColumn.DataPropertyName = "start_jam_revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn.HeaderText = "start_jam_revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn.Name = "StartjamrevisiDataGridViewTextBoxColumn"
        '
        'EndjamrevisiDataGridViewTextBoxColumn
        '
        Me.EndjamrevisiDataGridViewTextBoxColumn.DataPropertyName = "end_jam_revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn.HeaderText = "end_jam_revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn.Name = "EndjamrevisiDataGridViewTextBoxColumn"
        '
        'TglrevisiDataGridViewTextBoxColumn
        '
        Me.TglrevisiDataGridViewTextBoxColumn.DataPropertyName = "tgl_revisi"
        Me.TglrevisiDataGridViewTextBoxColumn.HeaderText = "tgl_revisi"
        Me.TglrevisiDataGridViewTextBoxColumn.Name = "TglrevisiDataGridViewTextBoxColumn"
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NamareagenDataGridViewTextBoxColumn1
        '
        Me.NamareagenDataGridViewTextBoxColumn1.DataPropertyName = "nama_reagen"
        Me.NamareagenDataGridViewTextBoxColumn1.HeaderText = "nama_reagen"
        Me.NamareagenDataGridViewTextBoxColumn1.Name = "NamareagenDataGridViewTextBoxColumn1"
        '
        'NomorlotDataGridViewTextBoxColumn1
        '
        Me.NomorlotDataGridViewTextBoxColumn1.DataPropertyName = "nomor_lot"
        Me.NomorlotDataGridViewTextBoxColumn1.HeaderText = "nomor_lot"
        Me.NomorlotDataGridViewTextBoxColumn1.Name = "NomorlotDataGridViewTextBoxColumn1"
        '
        'NomorbatchDataGridViewTextBoxColumn1
        '
        Me.NomorbatchDataGridViewTextBoxColumn1.DataPropertyName = "nomor_batch"
        Me.NomorbatchDataGridViewTextBoxColumn1.HeaderText = "nomor_batch"
        Me.NomorbatchDataGridViewTextBoxColumn1.Name = "NomorbatchDataGridViewTextBoxColumn1"
        '
        'NomorlabDataGridViewTextBoxColumn1
        '
        Me.NomorlabDataGridViewTextBoxColumn1.DataPropertyName = "nomor_lab"
        Me.NomorlabDataGridViewTextBoxColumn1.HeaderText = "nomor_lab"
        Me.NomorlabDataGridViewTextBoxColumn1.Name = "NomorlabDataGridViewTextBoxColumn1"
        '
        'ExpdateDataGridViewTextBoxColumn1
        '
        Me.ExpdateDataGridViewTextBoxColumn1.DataPropertyName = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn1.HeaderText = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn1.Name = "ExpdateDataGridViewTextBoxColumn1"
        '
        'PeringatanexpDataGridViewTextBoxColumn1
        '
        Me.PeringatanexpDataGridViewTextBoxColumn1.DataPropertyName = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn1.HeaderText = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn1.Name = "PeringatanexpDataGridViewTextBoxColumn1"
        '
        'KelompokDataGridViewTextBoxColumn1
        '
        Me.KelompokDataGridViewTextBoxColumn1.DataPropertyName = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn1.HeaderText = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn1.Name = "KelompokDataGridViewTextBoxColumn1"
        '
        'SupplierDataGridViewTextBoxColumn1
        '
        Me.SupplierDataGridViewTextBoxColumn1.DataPropertyName = "supplier"
        Me.SupplierDataGridViewTextBoxColumn1.HeaderText = "supplier"
        Me.SupplierDataGridViewTextBoxColumn1.Name = "SupplierDataGridViewTextBoxColumn1"
        '
        'SisawaktuthnDataGridViewTextBoxColumn1
        '
        Me.SisawaktuthnDataGridViewTextBoxColumn1.DataPropertyName = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn1.HeaderText = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn1.Name = "SisawaktuthnDataGridViewTextBoxColumn1"
        '
        'SisawaktublnDataGridViewTextBoxColumn1
        '
        Me.SisawaktublnDataGridViewTextBoxColumn1.DataPropertyName = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn1.HeaderText = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn1.Name = "SisawaktublnDataGridViewTextBoxColumn1"
        '
        'SisawaktuhariDataGridViewTextBoxColumn1
        '
        Me.SisawaktuhariDataGridViewTextBoxColumn1.DataPropertyName = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn1.HeaderText = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn1.Name = "SisawaktuhariDataGridViewTextBoxColumn1"
        '
        'R1DataGridViewTextBoxColumn1
        '
        Me.R1DataGridViewTextBoxColumn1.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn1.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn1.Name = "R1DataGridViewTextBoxColumn1"
        '
        'R2DataGridViewTextBoxColumn1
        '
        Me.R2DataGridViewTextBoxColumn1.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn1.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn1.Name = "R2DataGridViewTextBoxColumn1"
        '
        'R3DataGridViewTextBoxColumn1
        '
        Me.R3DataGridViewTextBoxColumn1.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn1.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn1.Name = "R3DataGridViewTextBoxColumn1"
        '
        'R4DataGridViewTextBoxColumn1
        '
        Me.R4DataGridViewTextBoxColumn1.DataPropertyName = "R4"
        Me.R4DataGridViewTextBoxColumn1.HeaderText = "R4"
        Me.R4DataGridViewTextBoxColumn1.Name = "R4DataGridViewTextBoxColumn1"
        '
        'TglinputDataGridViewTextBoxColumn1
        '
        Me.TglinputDataGridViewTextBoxColumn1.DataPropertyName = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn1.HeaderText = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn1.Name = "TglinputDataGridViewTextBoxColumn1"
        '
        'SisavolumeDataGridViewTextBoxColumn1
        '
        Me.SisavolumeDataGridViewTextBoxColumn1.DataPropertyName = "sisa_volume"
        Me.SisavolumeDataGridViewTextBoxColumn1.HeaderText = "sisa_volume"
        Me.SisavolumeDataGridViewTextBoxColumn1.Name = "SisavolumeDataGridViewTextBoxColumn1"
        '
        'PeringatanvolumeDataGridViewTextBoxColumn1
        '
        Me.PeringatanvolumeDataGridViewTextBoxColumn1.DataPropertyName = "peringatan_volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn1.HeaderText = "peringatan_volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn1.Name = "PeringatanvolumeDataGridViewTextBoxColumn1"
        '
        'DirevisiolehDataGridViewTextBoxColumn1
        '
        Me.DirevisiolehDataGridViewTextBoxColumn1.DataPropertyName = "direvisi_oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn1.HeaderText = "direvisi_oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn1.Name = "DirevisiolehDataGridViewTextBoxColumn1"
        '
        'StartjamrevisiDataGridViewTextBoxColumn1
        '
        Me.StartjamrevisiDataGridViewTextBoxColumn1.DataPropertyName = "start_jam_revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn1.HeaderText = "start_jam_revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn1.Name = "StartjamrevisiDataGridViewTextBoxColumn1"
        '
        'EndjamrevisiDataGridViewTextBoxColumn1
        '
        Me.EndjamrevisiDataGridViewTextBoxColumn1.DataPropertyName = "end_jam_revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn1.HeaderText = "end_jam_revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn1.Name = "EndjamrevisiDataGridViewTextBoxColumn1"
        '
        'TglrevisiDataGridViewTextBoxColumn1
        '
        Me.TglrevisiDataGridViewTextBoxColumn1.DataPropertyName = "tgl_revisi"
        Me.TglrevisiDataGridViewTextBoxColumn1.HeaderText = "tgl_revisi"
        Me.TglrevisiDataGridViewTextBoxColumn1.Name = "TglrevisiDataGridViewTextBoxColumn1"
        '
        'KeteranganDataGridViewTextBoxColumn1
        '
        Me.KeteranganDataGridViewTextBoxColumn1.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn1.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn1.Name = "KeteranganDataGridViewTextBoxColumn1"
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        Me.IdDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'NamareagenDataGridViewTextBoxColumn2
        '
        Me.NamareagenDataGridViewTextBoxColumn2.DataPropertyName = "nama_reagen"
        Me.NamareagenDataGridViewTextBoxColumn2.HeaderText = "nama_reagen"
        Me.NamareagenDataGridViewTextBoxColumn2.Name = "NamareagenDataGridViewTextBoxColumn2"
        '
        'NomorlotDataGridViewTextBoxColumn2
        '
        Me.NomorlotDataGridViewTextBoxColumn2.DataPropertyName = "nomor_lot"
        Me.NomorlotDataGridViewTextBoxColumn2.HeaderText = "nomor_lot"
        Me.NomorlotDataGridViewTextBoxColumn2.Name = "NomorlotDataGridViewTextBoxColumn2"
        '
        'NomorbatchDataGridViewTextBoxColumn2
        '
        Me.NomorbatchDataGridViewTextBoxColumn2.DataPropertyName = "nomor_batch"
        Me.NomorbatchDataGridViewTextBoxColumn2.HeaderText = "nomor_batch"
        Me.NomorbatchDataGridViewTextBoxColumn2.Name = "NomorbatchDataGridViewTextBoxColumn2"
        '
        'NomorlabDataGridViewTextBoxColumn2
        '
        Me.NomorlabDataGridViewTextBoxColumn2.DataPropertyName = "nomor_lab"
        Me.NomorlabDataGridViewTextBoxColumn2.HeaderText = "nomor_lab"
        Me.NomorlabDataGridViewTextBoxColumn2.Name = "NomorlabDataGridViewTextBoxColumn2"
        '
        'ExpdateDataGridViewTextBoxColumn2
        '
        Me.ExpdateDataGridViewTextBoxColumn2.DataPropertyName = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn2.HeaderText = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn2.Name = "ExpdateDataGridViewTextBoxColumn2"
        '
        'PeringatanexpDataGridViewTextBoxColumn2
        '
        Me.PeringatanexpDataGridViewTextBoxColumn2.DataPropertyName = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn2.HeaderText = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn2.Name = "PeringatanexpDataGridViewTextBoxColumn2"
        '
        'KelompokDataGridViewTextBoxColumn2
        '
        Me.KelompokDataGridViewTextBoxColumn2.DataPropertyName = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn2.HeaderText = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn2.Name = "KelompokDataGridViewTextBoxColumn2"
        '
        'SupplierDataGridViewTextBoxColumn2
        '
        Me.SupplierDataGridViewTextBoxColumn2.DataPropertyName = "supplier"
        Me.SupplierDataGridViewTextBoxColumn2.HeaderText = "supplier"
        Me.SupplierDataGridViewTextBoxColumn2.Name = "SupplierDataGridViewTextBoxColumn2"
        '
        'SisawaktuthnDataGridViewTextBoxColumn2
        '
        Me.SisawaktuthnDataGridViewTextBoxColumn2.DataPropertyName = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn2.HeaderText = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn2.Name = "SisawaktuthnDataGridViewTextBoxColumn2"
        '
        'SisawaktublnDataGridViewTextBoxColumn2
        '
        Me.SisawaktublnDataGridViewTextBoxColumn2.DataPropertyName = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn2.HeaderText = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn2.Name = "SisawaktublnDataGridViewTextBoxColumn2"
        '
        'SisawaktuhariDataGridViewTextBoxColumn2
        '
        Me.SisawaktuhariDataGridViewTextBoxColumn2.DataPropertyName = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn2.HeaderText = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn2.Name = "SisawaktuhariDataGridViewTextBoxColumn2"
        '
        'R1DataGridViewTextBoxColumn2
        '
        Me.R1DataGridViewTextBoxColumn2.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn2.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn2.Name = "R1DataGridViewTextBoxColumn2"
        '
        'R2DataGridViewTextBoxColumn2
        '
        Me.R2DataGridViewTextBoxColumn2.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn2.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn2.Name = "R2DataGridViewTextBoxColumn2"
        '
        'R3DataGridViewTextBoxColumn2
        '
        Me.R3DataGridViewTextBoxColumn2.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn2.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn2.Name = "R3DataGridViewTextBoxColumn2"
        '
        'R4DataGridViewTextBoxColumn2
        '
        Me.R4DataGridViewTextBoxColumn2.DataPropertyName = "R4"
        Me.R4DataGridViewTextBoxColumn2.HeaderText = "R4"
        Me.R4DataGridViewTextBoxColumn2.Name = "R4DataGridViewTextBoxColumn2"
        '
        'TglinputDataGridViewTextBoxColumn2
        '
        Me.TglinputDataGridViewTextBoxColumn2.DataPropertyName = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn2.HeaderText = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn2.Name = "TglinputDataGridViewTextBoxColumn2"
        '
        'SisavolumeDataGridViewTextBoxColumn2
        '
        Me.SisavolumeDataGridViewTextBoxColumn2.DataPropertyName = "sisa_volume"
        Me.SisavolumeDataGridViewTextBoxColumn2.HeaderText = "sisa_volume"
        Me.SisavolumeDataGridViewTextBoxColumn2.Name = "SisavolumeDataGridViewTextBoxColumn2"
        '
        'PeringatanvolumeDataGridViewTextBoxColumn2
        '
        Me.PeringatanvolumeDataGridViewTextBoxColumn2.DataPropertyName = "peringatan_volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn2.HeaderText = "peringatan_volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn2.Name = "PeringatanvolumeDataGridViewTextBoxColumn2"
        '
        'DirevisiolehDataGridViewTextBoxColumn2
        '
        Me.DirevisiolehDataGridViewTextBoxColumn2.DataPropertyName = "direvisi_oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn2.HeaderText = "direvisi_oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn2.Name = "DirevisiolehDataGridViewTextBoxColumn2"
        '
        'StartjamrevisiDataGridViewTextBoxColumn2
        '
        Me.StartjamrevisiDataGridViewTextBoxColumn2.DataPropertyName = "start_jam_revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn2.HeaderText = "start_jam_revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn2.Name = "StartjamrevisiDataGridViewTextBoxColumn2"
        '
        'EndjamrevisiDataGridViewTextBoxColumn2
        '
        Me.EndjamrevisiDataGridViewTextBoxColumn2.DataPropertyName = "end_jam_revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn2.HeaderText = "end_jam_revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn2.Name = "EndjamrevisiDataGridViewTextBoxColumn2"
        '
        'TglrevisiDataGridViewTextBoxColumn2
        '
        Me.TglrevisiDataGridViewTextBoxColumn2.DataPropertyName = "tgl_revisi"
        Me.TglrevisiDataGridViewTextBoxColumn2.HeaderText = "tgl_revisi"
        Me.TglrevisiDataGridViewTextBoxColumn2.Name = "TglrevisiDataGridViewTextBoxColumn2"
        '
        'KeteranganDataGridViewTextBoxColumn2
        '
        Me.KeteranganDataGridViewTextBoxColumn2.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn2.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn2.Name = "KeteranganDataGridViewTextBoxColumn2"
        '
        'IdDataGridViewTextBoxColumn3
        '
        Me.IdDataGridViewTextBoxColumn3.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn3.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn3.Name = "IdDataGridViewTextBoxColumn3"
        Me.IdDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'NamareagenDataGridViewTextBoxColumn3
        '
        Me.NamareagenDataGridViewTextBoxColumn3.DataPropertyName = "nama_reagen"
        Me.NamareagenDataGridViewTextBoxColumn3.HeaderText = "nama_reagen"
        Me.NamareagenDataGridViewTextBoxColumn3.Name = "NamareagenDataGridViewTextBoxColumn3"
        '
        'NomorlotDataGridViewTextBoxColumn3
        '
        Me.NomorlotDataGridViewTextBoxColumn3.DataPropertyName = "nomor_lot"
        Me.NomorlotDataGridViewTextBoxColumn3.HeaderText = "nomor_lot"
        Me.NomorlotDataGridViewTextBoxColumn3.Name = "NomorlotDataGridViewTextBoxColumn3"
        '
        'NomorbatchDataGridViewTextBoxColumn3
        '
        Me.NomorbatchDataGridViewTextBoxColumn3.DataPropertyName = "nomor_batch"
        Me.NomorbatchDataGridViewTextBoxColumn3.HeaderText = "nomor_batch"
        Me.NomorbatchDataGridViewTextBoxColumn3.Name = "NomorbatchDataGridViewTextBoxColumn3"
        '
        'NomorlabDataGridViewTextBoxColumn3
        '
        Me.NomorlabDataGridViewTextBoxColumn3.DataPropertyName = "nomor_lab"
        Me.NomorlabDataGridViewTextBoxColumn3.HeaderText = "nomor_lab"
        Me.NomorlabDataGridViewTextBoxColumn3.Name = "NomorlabDataGridViewTextBoxColumn3"
        '
        'ExpdateDataGridViewTextBoxColumn3
        '
        Me.ExpdateDataGridViewTextBoxColumn3.DataPropertyName = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn3.HeaderText = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn3.Name = "ExpdateDataGridViewTextBoxColumn3"
        '
        'PeringatanexpDataGridViewTextBoxColumn3
        '
        Me.PeringatanexpDataGridViewTextBoxColumn3.DataPropertyName = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn3.HeaderText = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn3.Name = "PeringatanexpDataGridViewTextBoxColumn3"
        '
        'KelompokDataGridViewTextBoxColumn3
        '
        Me.KelompokDataGridViewTextBoxColumn3.DataPropertyName = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn3.HeaderText = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn3.Name = "KelompokDataGridViewTextBoxColumn3"
        '
        'SupplierDataGridViewTextBoxColumn3
        '
        Me.SupplierDataGridViewTextBoxColumn3.DataPropertyName = "supplier"
        Me.SupplierDataGridViewTextBoxColumn3.HeaderText = "supplier"
        Me.SupplierDataGridViewTextBoxColumn3.Name = "SupplierDataGridViewTextBoxColumn3"
        '
        'SisawaktuthnDataGridViewTextBoxColumn3
        '
        Me.SisawaktuthnDataGridViewTextBoxColumn3.DataPropertyName = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn3.HeaderText = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn3.Name = "SisawaktuthnDataGridViewTextBoxColumn3"
        '
        'SisawaktublnDataGridViewTextBoxColumn3
        '
        Me.SisawaktublnDataGridViewTextBoxColumn3.DataPropertyName = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn3.HeaderText = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn3.Name = "SisawaktublnDataGridViewTextBoxColumn3"
        '
        'SisawaktuhariDataGridViewTextBoxColumn3
        '
        Me.SisawaktuhariDataGridViewTextBoxColumn3.DataPropertyName = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn3.HeaderText = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn3.Name = "SisawaktuhariDataGridViewTextBoxColumn3"
        '
        'R1DataGridViewTextBoxColumn3
        '
        Me.R1DataGridViewTextBoxColumn3.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn3.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn3.Name = "R1DataGridViewTextBoxColumn3"
        '
        'R2DataGridViewTextBoxColumn3
        '
        Me.R2DataGridViewTextBoxColumn3.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn3.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn3.Name = "R2DataGridViewTextBoxColumn3"
        '
        'R3DataGridViewTextBoxColumn3
        '
        Me.R3DataGridViewTextBoxColumn3.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn3.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn3.Name = "R3DataGridViewTextBoxColumn3"
        '
        'R4DataGridViewTextBoxColumn3
        '
        Me.R4DataGridViewTextBoxColumn3.DataPropertyName = "R4"
        Me.R4DataGridViewTextBoxColumn3.HeaderText = "R4"
        Me.R4DataGridViewTextBoxColumn3.Name = "R4DataGridViewTextBoxColumn3"
        '
        'TglinputDataGridViewTextBoxColumn3
        '
        Me.TglinputDataGridViewTextBoxColumn3.DataPropertyName = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn3.HeaderText = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn3.Name = "TglinputDataGridViewTextBoxColumn3"
        '
        'SisavolumeDataGridViewTextBoxColumn3
        '
        Me.SisavolumeDataGridViewTextBoxColumn3.DataPropertyName = "sisa_volume"
        Me.SisavolumeDataGridViewTextBoxColumn3.HeaderText = "sisa_volume"
        Me.SisavolumeDataGridViewTextBoxColumn3.Name = "SisavolumeDataGridViewTextBoxColumn3"
        '
        'PeringatanvolumeDataGridViewTextBoxColumn3
        '
        Me.PeringatanvolumeDataGridViewTextBoxColumn3.DataPropertyName = "peringatan_volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn3.HeaderText = "peringatan_volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn3.Name = "PeringatanvolumeDataGridViewTextBoxColumn3"
        '
        'DirevisiolehDataGridViewTextBoxColumn3
        '
        Me.DirevisiolehDataGridViewTextBoxColumn3.DataPropertyName = "direvisi_oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn3.HeaderText = "direvisi_oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn3.Name = "DirevisiolehDataGridViewTextBoxColumn3"
        '
        'StartjamrevisiDataGridViewTextBoxColumn3
        '
        Me.StartjamrevisiDataGridViewTextBoxColumn3.DataPropertyName = "start_jam_revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn3.HeaderText = "start_jam_revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn3.Name = "StartjamrevisiDataGridViewTextBoxColumn3"
        '
        'EndjamrevisiDataGridViewTextBoxColumn3
        '
        Me.EndjamrevisiDataGridViewTextBoxColumn3.DataPropertyName = "end_jam_revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn3.HeaderText = "end_jam_revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn3.Name = "EndjamrevisiDataGridViewTextBoxColumn3"
        '
        'TglrevisiDataGridViewTextBoxColumn3
        '
        Me.TglrevisiDataGridViewTextBoxColumn3.DataPropertyName = "tgl_revisi"
        Me.TglrevisiDataGridViewTextBoxColumn3.HeaderText = "tgl_revisi"
        Me.TglrevisiDataGridViewTextBoxColumn3.Name = "TglrevisiDataGridViewTextBoxColumn3"
        '
        'KeteranganDataGridViewTextBoxColumn3
        '
        Me.KeteranganDataGridViewTextBoxColumn3.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn3.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn3.Name = "KeteranganDataGridViewTextBoxColumn3"
        '
        'reagen_on_board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 746)
        Me.Controls.Add(Me.gbxR4)
        Me.Controls.Add(Me.dtpExpiredDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxR3)
        Me.Controls.Add(Me.gbxR2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbxR1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cbxReagen)
        Me.Controls.Add(Me.BindingNavigatorReagenOnBoard)
        Me.Name = "reagen_on_board"
        Me.Text = "Reagen On Board"
        CType(Me.BindingNavigatorReagenOnBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorReagenOnBoard.ResumeLayout(False)
        Me.BindingNavigatorReagenOnBoard.PerformLayout()
        CType(Me.BindingSourceReagenOnBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReagenOnBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceNamaReagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxR1.ResumeLayout(False)
        Me.gbxR2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxR3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxR4.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorReagenOnBoard As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewReagenOnBoard As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteReagenOnBoard As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents dgReagenOnBoard As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceReagenOnBoard As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterReagenOnBoard As laboratorium.DataSet_LabTableAdapters.reagen_on_boardTableAdapter
    Friend WithEvents BindingSourceNamaReagen As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterNamaReagen As laboratorium.DataSet_LabTableAdapters.nama_reagenTableAdapter
    Friend WithEvents BindingSourceKelompok As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterKelompok As laboratorium.DataSet_LabTableAdapters.kelompokTableAdapter
    Friend WithEvents BindingSourceSupplier As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As laboratorium.DataSet_LabTableAdapters.supplierTableAdapter
    Friend WithEvents dtpExpiredDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxReagen As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbxR1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxR2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents gbxR3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents gbxR4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sisa_volume As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamareagenDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorlotDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorbatchDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorlabDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpdateDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanexpDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelompokDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuthnDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktublnDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuhariDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R4DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglinputDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisavolumeDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanvolumeDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirevisiolehDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartjamrevisiDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndjamrevisiDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglrevisiDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamareagenDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorlotDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorbatchDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorlabDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpdateDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanexpDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelompokDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuthnDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktublnDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuhariDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R4DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglinputDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisavolumeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanvolumeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirevisiolehDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartjamrevisiDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndjamrevisiDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglrevisiDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamareagenDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorlotDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorbatchDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorlabDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpdateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanexpDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelompokDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuthnDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktublnDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuhariDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R4DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglinputDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisavolumeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanvolumeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirevisiolehDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartjamrevisiDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndjamrevisiDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglrevisiDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamareagenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorlotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorbatchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomorlabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanexpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelompokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuthnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktublnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuhariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglinputDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisavolumeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanvolumeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirevisiolehDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartjamrevisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndjamrevisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglrevisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
