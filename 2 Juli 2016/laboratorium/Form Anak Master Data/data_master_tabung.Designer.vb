<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_master_tabung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_master_tabung))
        Me.BindingNavigatorInstrument = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewDataTabung = New System.Windows.Forms.ToolStripButton()
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
        Me.BindingNavigatorDeleteDataTabung = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSaveDataTabung = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgDataMasterTabung = New System.Windows.Forms.DataGridView()
        Me.BindingSourceJenisKelompok = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterJenisKelompok = New laboratorium.DataSet_LabTableAdapters.jenis_kelompokTableAdapter()
        Me.BindingSourceTabung = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterMasterTabung = New laboratorium.DataSet_LabTableAdapters.master_tabungTableAdapter()
        Me.KodetabungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelompokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamatabungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KuantitasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuthnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktublnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisawaktuhariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanexpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeringatanjumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingNavigatorInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorInstrument.SuspendLayout()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDataMasterTabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceJenisKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceTabung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorInstrument
        '
        Me.BindingNavigatorInstrument.AddNewItem = Me.BindingNavigatorAddNewDataTabung
        Me.BindingNavigatorInstrument.BindingSource = Me.BindingSourceTabung
        Me.BindingNavigatorInstrument.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorInstrument.DeleteItem = Nothing
        Me.BindingNavigatorInstrument.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewDataTabung, Me.BindingNavigatorDeleteDataTabung, Me.ButtonSaveDataTabung})
        Me.BindingNavigatorInstrument.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorInstrument.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorInstrument.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorInstrument.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorInstrument.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorInstrument.Name = "BindingNavigatorInstrument"
        Me.BindingNavigatorInstrument.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorInstrument.Size = New System.Drawing.Size(1370, 25)
        Me.BindingNavigatorInstrument.TabIndex = 2
        Me.BindingNavigatorInstrument.Text = "Data Reagen On Board"
        '
        'BindingNavigatorAddNewDataTabung
        '
        Me.BindingNavigatorAddNewDataTabung.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewDataTabung.Image = CType(resources.GetObject("BindingNavigatorAddNewDataTabung.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewDataTabung.Name = "BindingNavigatorAddNewDataTabung"
        Me.BindingNavigatorAddNewDataTabung.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewDataTabung.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewDataTabung.Text = "Add new"
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
        'BindingNavigatorDeleteDataTabung
        '
        Me.BindingNavigatorDeleteDataTabung.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteDataTabung.Image = CType(resources.GetObject("BindingNavigatorDeleteDataTabung.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteDataTabung.Name = "BindingNavigatorDeleteDataTabung"
        Me.BindingNavigatorDeleteDataTabung.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteDataTabung.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteDataTabung.Text = "Delete"
        '
        'ButtonSaveDataTabung
        '
        Me.ButtonSaveDataTabung.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSaveDataTabung.Image = CType(resources.GetObject("ButtonSaveDataTabung.Image"), System.Drawing.Image)
        Me.ButtonSaveDataTabung.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSaveDataTabung.Name = "ButtonSaveDataTabung"
        Me.ButtonSaveDataTabung.Size = New System.Drawing.Size(23, 22)
        Me.ButtonSaveDataTabung.Text = "ToolStripButton1"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 33)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgDataMasterTabung
        '
        Me.dgDataMasterTabung.AllowUserToAddRows = False
        Me.dgDataMasterTabung.AutoGenerateColumns = False
        Me.dgDataMasterTabung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDataMasterTabung.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodetabungDataGridViewTextBoxColumn, Me.KelompokDataGridViewTextBoxColumn, Me.NamatabungDataGridViewTextBoxColumn, Me.KuantitasDataGridViewTextBoxColumn, Me.ExpdateDataGridViewTextBoxColumn, Me.SisawaktuthnDataGridViewTextBoxColumn, Me.SisawaktublnDataGridViewTextBoxColumn, Me.SisawaktuhariDataGridViewTextBoxColumn, Me.PeringatanexpDataGridViewTextBoxColumn, Me.PeringatanjumlahDataGridViewTextBoxColumn})
        Me.dgDataMasterTabung.DataSource = Me.BindingSourceTabung
        Me.dgDataMasterTabung.Location = New System.Drawing.Point(-12, 85)
        Me.dgDataMasterTabung.Name = "dgDataMasterTabung"
        Me.dgDataMasterTabung.Size = New System.Drawing.Size(1370, 436)
        Me.dgDataMasterTabung.TabIndex = 13
        '
        'BindingSourceJenisKelompok
        '
        Me.BindingSourceJenisKelompok.DataMember = "jenis_kelompok"
        Me.BindingSourceJenisKelompok.DataSource = Me.DataSet_Lab
        '
        'TableAdapterJenisKelompok
        '
        Me.TableAdapterJenisKelompok.ClearBeforeFill = True
        '
        'BindingSourceTabung
        '
        Me.BindingSourceTabung.DataMember = "master_tabung"
        Me.BindingSourceTabung.DataSource = Me.DataSet_Lab
        '
        'TableAdapterMasterTabung
        '
        Me.TableAdapterMasterTabung.ClearBeforeFill = True
        '
        'KodetabungDataGridViewTextBoxColumn
        '
        Me.KodetabungDataGridViewTextBoxColumn.DataPropertyName = "kode_tabung"
        Me.KodetabungDataGridViewTextBoxColumn.HeaderText = "Kode Tabung"
        Me.KodetabungDataGridViewTextBoxColumn.Name = "KodetabungDataGridViewTextBoxColumn"
        '
        'KelompokDataGridViewTextBoxColumn
        '
        Me.KelompokDataGridViewTextBoxColumn.DataPropertyName = "kelompok"
        Me.KelompokDataGridViewTextBoxColumn.HeaderText = "Kelompok"
        Me.KelompokDataGridViewTextBoxColumn.Name = "KelompokDataGridViewTextBoxColumn"
        '
        'NamatabungDataGridViewTextBoxColumn
        '
        Me.NamatabungDataGridViewTextBoxColumn.DataPropertyName = "nama_tabung"
        Me.NamatabungDataGridViewTextBoxColumn.HeaderText = "Nama Tabung"
        Me.NamatabungDataGridViewTextBoxColumn.Name = "NamatabungDataGridViewTextBoxColumn"
        '
        'KuantitasDataGridViewTextBoxColumn
        '
        Me.KuantitasDataGridViewTextBoxColumn.DataPropertyName = "kuantitas"
        Me.KuantitasDataGridViewTextBoxColumn.HeaderText = "Kuantitas"
        Me.KuantitasDataGridViewTextBoxColumn.Name = "KuantitasDataGridViewTextBoxColumn"
        '
        'ExpdateDataGridViewTextBoxColumn
        '
        Me.ExpdateDataGridViewTextBoxColumn.DataPropertyName = "exp_date"
        Me.ExpdateDataGridViewTextBoxColumn.HeaderText = "Exp Date"
        Me.ExpdateDataGridViewTextBoxColumn.Name = "ExpdateDataGridViewTextBoxColumn"
        '
        'SisawaktuthnDataGridViewTextBoxColumn
        '
        Me.SisawaktuthnDataGridViewTextBoxColumn.DataPropertyName = "sisa_waktu_thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn.HeaderText = "Sisa Thn"
        Me.SisawaktuthnDataGridViewTextBoxColumn.Name = "SisawaktuthnDataGridViewTextBoxColumn"
        '
        'SisawaktublnDataGridViewTextBoxColumn
        '
        Me.SisawaktublnDataGridViewTextBoxColumn.DataPropertyName = "sisa_waktu_bln"
        Me.SisawaktublnDataGridViewTextBoxColumn.HeaderText = "Sisa Bln"
        Me.SisawaktublnDataGridViewTextBoxColumn.Name = "SisawaktublnDataGridViewTextBoxColumn"
        '
        'SisawaktuhariDataGridViewTextBoxColumn
        '
        Me.SisawaktuhariDataGridViewTextBoxColumn.DataPropertyName = "sisa_waktu_hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn.HeaderText = "Sisa Hari"
        Me.SisawaktuhariDataGridViewTextBoxColumn.Name = "SisawaktuhariDataGridViewTextBoxColumn"
        '
        'PeringatanexpDataGridViewTextBoxColumn
        '
        Me.PeringatanexpDataGridViewTextBoxColumn.DataPropertyName = "peringatan_exp"
        Me.PeringatanexpDataGridViewTextBoxColumn.HeaderText = "Peringatan exp"
        Me.PeringatanexpDataGridViewTextBoxColumn.Name = "PeringatanexpDataGridViewTextBoxColumn"
        '
        'PeringatanjumlahDataGridViewTextBoxColumn
        '
        Me.PeringatanjumlahDataGridViewTextBoxColumn.DataPropertyName = "peringatan_jumlah"
        Me.PeringatanjumlahDataGridViewTextBoxColumn.HeaderText = "Peringatan Jumlah"
        Me.PeringatanjumlahDataGridViewTextBoxColumn.Name = "PeringatanjumlahDataGridViewTextBoxColumn"
        '
        'data_master_tabung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 535)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgDataMasterTabung)
        Me.Controls.Add(Me.BindingNavigatorInstrument)
        Me.Name = "data_master_tabung"
        Me.Text = "Data Master Tabung"
        CType(Me.BindingNavigatorInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorInstrument.ResumeLayout(False)
        Me.BindingNavigatorInstrument.PerformLayout()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDataMasterTabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceJenisKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceTabung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorInstrument As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewDataTabung As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteDataTabung As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSaveDataTabung As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents dgDataMasterTabung As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents BindingSourceJenisKelompok As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterJenisKelompok As laboratorium.DataSet_LabTableAdapters.jenis_kelompokTableAdapter
    Friend WithEvents BindingSourceTabung As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterMasterTabung As laboratorium.DataSet_LabTableAdapters.master_tabungTableAdapter
    Friend WithEvents KodetabungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelompokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamatabungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KuantitasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuthnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktublnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisawaktuhariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanexpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeringatanjumlahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
