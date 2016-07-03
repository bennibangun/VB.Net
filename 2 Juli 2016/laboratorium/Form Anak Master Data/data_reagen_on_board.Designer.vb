<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_reagen_on_board
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_reagen_on_board))
        Me.dgDataReagenOnBoard = New System.Windows.Forms.DataGridView()
        Me.BindingSourceReagenOnBoard = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewDataReagenOnBoard = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteDataReagenOnBoard = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSaveDataReagenOnBoard = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorInstrument = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TableAdapterReagenOnBoard = New laboratorium.DataSet_LabTableAdapters.reagen_on_boardTableAdapter()
        Me.IdreagenonboardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PeringatanvolumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirevisiolehDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartjamrevisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndjamrevisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglrevisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgDataReagenOnBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceReagenOnBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigatorInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorInstrument.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDataReagenOnBoard
        '
        Me.dgDataReagenOnBoard.AllowUserToAddRows = False
        Me.dgDataReagenOnBoard.AutoGenerateColumns = False
        Me.dgDataReagenOnBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDataReagenOnBoard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdreagenonboardDataGridViewTextBoxColumn, Me.NamareagenDataGridViewTextBoxColumn, Me.NomorlotDataGridViewTextBoxColumn, Me.NomorbatchDataGridViewTextBoxColumn, Me.NomorlabDataGridViewTextBoxColumn, Me.ExpdateDataGridViewTextBoxColumn, Me.PeringatanexpDataGridViewTextBoxColumn, Me.KelompokDataGridViewTextBoxColumn, Me.SupplierDataGridViewTextBoxColumn, Me.SisawaktuthnDataGridViewTextBoxColumn, Me.SisawaktublnDataGridViewTextBoxColumn, Me.SisawaktuhariDataGridViewTextBoxColumn, Me.R1DataGridViewTextBoxColumn, Me.R2DataGridViewTextBoxColumn, Me.R3DataGridViewTextBoxColumn, Me.R4DataGridViewTextBoxColumn, Me.TglinputDataGridViewTextBoxColumn, Me.PeringatanvolumeDataGridViewTextBoxColumn, Me.DirevisiolehDataGridViewTextBoxColumn, Me.StartjamrevisiDataGridViewTextBoxColumn, Me.EndjamrevisiDataGridViewTextBoxColumn, Me.TglrevisiDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.dgDataReagenOnBoard.DataSource = Me.BindingSourceReagenOnBoard
        Me.dgDataReagenOnBoard.Location = New System.Drawing.Point(0, 66)
        Me.dgDataReagenOnBoard.Name = "dgDataReagenOnBoard"
        Me.dgDataReagenOnBoard.Size = New System.Drawing.Size(1370, 436)
        Me.dgDataReagenOnBoard.TabIndex = 11
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
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 33)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewDataReagenOnBoard
        '
        Me.BindingNavigatorAddNewDataReagenOnBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewDataReagenOnBoard.Image = CType(resources.GetObject("BindingNavigatorAddNewDataReagenOnBoard.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewDataReagenOnBoard.Name = "BindingNavigatorAddNewDataReagenOnBoard"
        Me.BindingNavigatorAddNewDataReagenOnBoard.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewDataReagenOnBoard.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewDataReagenOnBoard.Text = "Add new"
        '
        'BindingNavigatorDeleteDataReagenOnBoard
        '
        Me.BindingNavigatorDeleteDataReagenOnBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteDataReagenOnBoard.Image = CType(resources.GetObject("BindingNavigatorDeleteDataReagenOnBoard.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteDataReagenOnBoard.Name = "BindingNavigatorDeleteDataReagenOnBoard"
        Me.BindingNavigatorDeleteDataReagenOnBoard.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteDataReagenOnBoard.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteDataReagenOnBoard.Text = "Delete"
        '
        'ButtonSaveDataReagenOnBoard
        '
        Me.ButtonSaveDataReagenOnBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSaveDataReagenOnBoard.Image = Global.laboratorium.My.Resources.Resources.save
        Me.ButtonSaveDataReagenOnBoard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSaveDataReagenOnBoard.Name = "ButtonSaveDataReagenOnBoard"
        Me.ButtonSaveDataReagenOnBoard.Size = New System.Drawing.Size(23, 22)
        Me.ButtonSaveDataReagenOnBoard.Text = "ToolStripButton1"
        '
        'BindingNavigatorInstrument
        '
        Me.BindingNavigatorInstrument.AddNewItem = Me.BindingNavigatorAddNewDataReagenOnBoard
        Me.BindingNavigatorInstrument.BindingSource = Me.BindingSourceReagenOnBoard
        Me.BindingNavigatorInstrument.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorInstrument.DeleteItem = Nothing
        Me.BindingNavigatorInstrument.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewDataReagenOnBoard, Me.BindingNavigatorDeleteDataReagenOnBoard, Me.ButtonSaveDataReagenOnBoard})
        Me.BindingNavigatorInstrument.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorInstrument.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorInstrument.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorInstrument.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorInstrument.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorInstrument.Name = "BindingNavigatorInstrument"
        Me.BindingNavigatorInstrument.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorInstrument.Size = New System.Drawing.Size(1370, 25)
        Me.BindingNavigatorInstrument.TabIndex = 1
        Me.BindingNavigatorInstrument.Text = "Data Reagen On Board"
        '
        'TableAdapterReagenOnBoard
        '
        Me.TableAdapterReagenOnBoard.ClearBeforeFill = True
        '
        'IdreagenonboardDataGridViewTextBoxColumn
        '
        Me.IdreagenonboardDataGridViewTextBoxColumn.DataPropertyName = "id_reagen_on_board"
        Me.IdreagenonboardDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdreagenonboardDataGridViewTextBoxColumn.Name = "IdreagenonboardDataGridViewTextBoxColumn"
        Me.IdreagenonboardDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdreagenonboardDataGridViewTextBoxColumn.Width = 40
        '
        'NamareagenDataGridViewTextBoxColumn
        '
        Me.NamareagenDataGridViewTextBoxColumn.DataPropertyName = "nama_reagen"
        Me.NamareagenDataGridViewTextBoxColumn.HeaderText = "Nama Reagen"
        Me.NamareagenDataGridViewTextBoxColumn.Name = "NamareagenDataGridViewTextBoxColumn"
        Me.NamareagenDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamareagenDataGridViewTextBoxColumn.Width = 110
        '
        'NomorlotDataGridViewTextBoxColumn
        '
        Me.NomorlotDataGridViewTextBoxColumn.DataPropertyName = "nomor_lot"
        Me.NomorlotDataGridViewTextBoxColumn.HeaderText = "No Lot"
        Me.NomorlotDataGridViewTextBoxColumn.Name = "NomorlotDataGridViewTextBoxColumn"
        Me.NomorlotDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomorlotDataGridViewTextBoxColumn.Width = 70
        '
        'NomorbatchDataGridViewTextBoxColumn
        '
        Me.NomorbatchDataGridViewTextBoxColumn.DataPropertyName = "nomor_batch"
        Me.NomorbatchDataGridViewTextBoxColumn.HeaderText = "No Batch"
        Me.NomorbatchDataGridViewTextBoxColumn.Name = "NomorbatchDataGridViewTextBoxColumn"
        Me.NomorbatchDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomorbatchDataGridViewTextBoxColumn.Width = 80
        '
        'NomorlabDataGridViewTextBoxColumn
        '
        Me.NomorlabDataGridViewTextBoxColumn.DataPropertyName = "nomor_lab"
        Me.NomorlabDataGridViewTextBoxColumn.HeaderText = "No Lab"
        Me.NomorlabDataGridViewTextBoxColumn.Name = "NomorlabDataGridViewTextBoxColumn"
        Me.NomorlabDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomorlabDataGridViewTextBoxColumn.Width = 70
        '
        'ExpdateDataGridViewTextBoxColumn
        '
        Me.ExpdateDataGridViewTextBoxColumn.DataPropertyName = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn.HeaderText = "Exp Date"
        Me.ExpdateDataGridViewTextBoxColumn.Name = "ExpdateDataGridViewTextBoxColumn"
        Me.ExpdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeringatanexpDataGridViewTextBoxColumn
        '
        Me.PeringatanexpDataGridViewTextBoxColumn.DataPropertyName = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn.HeaderText = "Peringatan Exp"
        Me.PeringatanexpDataGridViewTextBoxColumn.Name = "PeringatanexpDataGridViewTextBoxColumn"
        Me.PeringatanexpDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeringatanexpDataGridViewTextBoxColumn.Width = 110
        '
        'KelompokDataGridViewTextBoxColumn
        '
        Me.KelompokDataGridViewTextBoxColumn.DataPropertyName = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn.HeaderText = "Kelompok"
        Me.KelompokDataGridViewTextBoxColumn.Name = "KelompokDataGridViewTextBoxColumn"
        Me.KelompokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierDataGridViewTextBoxColumn
        '
        Me.SupplierDataGridViewTextBoxColumn.DataPropertyName = "supplier"
        Me.SupplierDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.SupplierDataGridViewTextBoxColumn.Name = "SupplierDataGridViewTextBoxColumn"
        Me.SupplierDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SisawaktuthnDataGridViewTextBoxColumn
        '
        Me.SisawaktuthnDataGridViewTextBoxColumn.DataPropertyName = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn.HeaderText = "Sisa Tahun"
        Me.SisawaktuthnDataGridViewTextBoxColumn.Name = "SisawaktuthnDataGridViewTextBoxColumn"
        Me.SisawaktuthnDataGridViewTextBoxColumn.ReadOnly = True
        Me.SisawaktuthnDataGridViewTextBoxColumn.Width = 90
        '
        'SisawaktublnDataGridViewTextBoxColumn
        '
        Me.SisawaktublnDataGridViewTextBoxColumn.DataPropertyName = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn.HeaderText = "Sisa Bulan"
        Me.SisawaktublnDataGridViewTextBoxColumn.Name = "SisawaktublnDataGridViewTextBoxColumn"
        Me.SisawaktublnDataGridViewTextBoxColumn.ReadOnly = True
        Me.SisawaktublnDataGridViewTextBoxColumn.Width = 90
        '
        'SisawaktuhariDataGridViewTextBoxColumn
        '
        Me.SisawaktuhariDataGridViewTextBoxColumn.DataPropertyName = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn.HeaderText = "Sisa Hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn.Name = "SisawaktuhariDataGridViewTextBoxColumn"
        Me.SisawaktuhariDataGridViewTextBoxColumn.ReadOnly = True
        Me.SisawaktuhariDataGridViewTextBoxColumn.Width = 80
        '
        'R1DataGridViewTextBoxColumn
        '
        Me.R1DataGridViewTextBoxColumn.DataPropertyName = "R1"
        Me.R1DataGridViewTextBoxColumn.HeaderText = "R1"
        Me.R1DataGridViewTextBoxColumn.Name = "R1DataGridViewTextBoxColumn"
        Me.R1DataGridViewTextBoxColumn.ReadOnly = True
        Me.R1DataGridViewTextBoxColumn.Width = 40
        '
        'R2DataGridViewTextBoxColumn
        '
        Me.R2DataGridViewTextBoxColumn.DataPropertyName = "R2"
        Me.R2DataGridViewTextBoxColumn.HeaderText = "R2"
        Me.R2DataGridViewTextBoxColumn.Name = "R2DataGridViewTextBoxColumn"
        Me.R2DataGridViewTextBoxColumn.ReadOnly = True
        Me.R2DataGridViewTextBoxColumn.Width = 40
        '
        'R3DataGridViewTextBoxColumn
        '
        Me.R3DataGridViewTextBoxColumn.DataPropertyName = "R3"
        Me.R3DataGridViewTextBoxColumn.HeaderText = "R3"
        Me.R3DataGridViewTextBoxColumn.Name = "R3DataGridViewTextBoxColumn"
        Me.R3DataGridViewTextBoxColumn.ReadOnly = True
        Me.R3DataGridViewTextBoxColumn.Width = 40
        '
        'R4DataGridViewTextBoxColumn
        '
        Me.R4DataGridViewTextBoxColumn.DataPropertyName = "R4"
        Me.R4DataGridViewTextBoxColumn.HeaderText = "R4"
        Me.R4DataGridViewTextBoxColumn.Name = "R4DataGridViewTextBoxColumn"
        Me.R4DataGridViewTextBoxColumn.ReadOnly = True
        Me.R4DataGridViewTextBoxColumn.Width = 40
        '
        'TglinputDataGridViewTextBoxColumn
        '
        Me.TglinputDataGridViewTextBoxColumn.DataPropertyName = "tgl_input"
        Me.TglinputDataGridViewTextBoxColumn.HeaderText = "Tgl Input"
        Me.TglinputDataGridViewTextBoxColumn.Name = "TglinputDataGridViewTextBoxColumn"
        Me.TglinputDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeringatanvolumeDataGridViewTextBoxColumn
        '
        Me.PeringatanvolumeDataGridViewTextBoxColumn.DataPropertyName = "peringatan_volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn.HeaderText = "Peringatan Volume"
        Me.PeringatanvolumeDataGridViewTextBoxColumn.Name = "PeringatanvolumeDataGridViewTextBoxColumn"
        Me.PeringatanvolumeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeringatanvolumeDataGridViewTextBoxColumn.Width = 130
        '
        'DirevisiolehDataGridViewTextBoxColumn
        '
        Me.DirevisiolehDataGridViewTextBoxColumn.DataPropertyName = "direvisi_oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn.HeaderText = "Direvisi Oleh"
        Me.DirevisiolehDataGridViewTextBoxColumn.Name = "DirevisiolehDataGridViewTextBoxColumn"
        Me.DirevisiolehDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartjamrevisiDataGridViewTextBoxColumn
        '
        Me.StartjamrevisiDataGridViewTextBoxColumn.DataPropertyName = "start_jam_revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn.HeaderText = "Start Revisi"
        Me.StartjamrevisiDataGridViewTextBoxColumn.Name = "StartjamrevisiDataGridViewTextBoxColumn"
        Me.StartjamrevisiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndjamrevisiDataGridViewTextBoxColumn
        '
        Me.EndjamrevisiDataGridViewTextBoxColumn.DataPropertyName = "end_jam_revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn.HeaderText = "End Revisi"
        Me.EndjamrevisiDataGridViewTextBoxColumn.Name = "EndjamrevisiDataGridViewTextBoxColumn"
        Me.EndjamrevisiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglrevisiDataGridViewTextBoxColumn
        '
        Me.TglrevisiDataGridViewTextBoxColumn.DataPropertyName = "tgl_revisi"
        Me.TglrevisiDataGridViewTextBoxColumn.HeaderText = "Tgl Revisi"
        Me.TglrevisiDataGridViewTextBoxColumn.Name = "TglrevisiDataGridViewTextBoxColumn"
        Me.TglrevisiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        Me.KeteranganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'data_reagen_on_board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 535)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgDataReagenOnBoard)
        Me.Controls.Add(Me.BindingNavigatorInstrument)
        Me.Name = "data_reagen_on_board"
        Me.Text = "Data Reagen On Board"
        CType(Me.dgDataReagenOnBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceReagenOnBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigatorInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorInstrument.ResumeLayout(False)
        Me.BindingNavigatorInstrument.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgDataReagenOnBoard As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewDataReagenOnBoard As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteDataReagenOnBoard As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSaveDataReagenOnBoard As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorInstrument As System.Windows.Forms.BindingNavigator
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents BindingSourceReagenOnBoard As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterReagenOnBoard As laboratorium.DataSet_LabTableAdapters.reagen_on_boardTableAdapter
    Friend WithEvents IdreagenonboardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents PeringatanvolumeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirevisiolehDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartjamrevisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndjamrevisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglrevisiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
