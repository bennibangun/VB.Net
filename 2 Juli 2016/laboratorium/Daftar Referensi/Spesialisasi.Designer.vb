<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spesialisasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(spesialisasi))
        Me.BindingNavigatorSpesialisasi = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewSpesialisasi = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteSpesialisasi = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgSpesialisasi = New System.Windows.Forms.DataGridView()
        Me.BindingSourceSpesialisasi = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.TableAdapterSpesialisasi = New laboratorium.DataSet_LabTableAdapters.spesialisasiTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisspesialisasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingNavigatorSpesialisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorSpesialisasi.SuspendLayout()
        CType(Me.dgSpesialisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSpesialisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorSpesialisasi
        '
        Me.BindingNavigatorSpesialisasi.AddNewItem = Me.BindingNavigatorAddNewSpesialisasi
        Me.BindingNavigatorSpesialisasi.BindingSource = Me.BindingSourceSpesialisasi
        Me.BindingNavigatorSpesialisasi.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorSpesialisasi.DeleteItem = Nothing
        Me.BindingNavigatorSpesialisasi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewSpesialisasi, Me.BindingNavigatorDeleteSpesialisasi, Me.ButtonSave})
        Me.BindingNavigatorSpesialisasi.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorSpesialisasi.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorSpesialisasi.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorSpesialisasi.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorSpesialisasi.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorSpesialisasi.Name = "BindingNavigatorSpesialisasi"
        Me.BindingNavigatorSpesialisasi.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorSpesialisasi.Size = New System.Drawing.Size(688, 25)
        Me.BindingNavigatorSpesialisasi.TabIndex = 4
        Me.BindingNavigatorSpesialisasi.Text = "Pendidikan"
        '
        'BindingNavigatorAddNewSpesialisasi
        '
        Me.BindingNavigatorAddNewSpesialisasi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewSpesialisasi.Image = CType(resources.GetObject("BindingNavigatorAddNewSpesialisasi.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewSpesialisasi.Name = "BindingNavigatorAddNewSpesialisasi"
        Me.BindingNavigatorAddNewSpesialisasi.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewSpesialisasi.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewSpesialisasi.Text = "Tambah data dokter"
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
        'BindingNavigatorDeleteSpesialisasi
        '
        Me.BindingNavigatorDeleteSpesialisasi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteSpesialisasi.Image = CType(resources.GetObject("BindingNavigatorDeleteSpesialisasi.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteSpesialisasi.Name = "BindingNavigatorDeleteSpesialisasi"
        Me.BindingNavigatorDeleteSpesialisasi.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteSpesialisasi.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteSpesialisasi.Text = "Delete pasien"
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
        Me.btnExit.Location = New System.Drawing.Point(473, 44)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(362, 44)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 18
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(7, 46)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 17
        '
        'dgSpesialisasi
        '
        Me.dgSpesialisasi.AllowUserToAddRows = False
        Me.dgSpesialisasi.AutoGenerateColumns = False
        Me.dgSpesialisasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSpesialisasi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.JenisspesialisasiDataGridViewTextBoxColumn})
        Me.dgSpesialisasi.DataSource = Me.BindingSourceSpesialisasi
        Me.dgSpesialisasi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgSpesialisasi.Location = New System.Drawing.Point(0, 98)
        Me.dgSpesialisasi.Name = "dgSpesialisasi"
        Me.dgSpesialisasi.Size = New System.Drawing.Size(688, 463)
        Me.dgSpesialisasi.TabIndex = 20
        '
        'BindingSourceSpesialisasi
        '
        Me.BindingSourceSpesialisasi.DataMember = "spesialisasi"
        Me.BindingSourceSpesialisasi.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterSpesialisasi
        '
        Me.TableAdapterSpesialisasi.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'JenisspesialisasiDataGridViewTextBoxColumn
        '
        Me.JenisspesialisasiDataGridViewTextBoxColumn.DataPropertyName = "jenis_spesialisasi"
        Me.JenisspesialisasiDataGridViewTextBoxColumn.HeaderText = "Spesialisasi"
        Me.JenisspesialisasiDataGridViewTextBoxColumn.Name = "JenisspesialisasiDataGridViewTextBoxColumn"
        Me.JenisspesialisasiDataGridViewTextBoxColumn.Width = 400
        '
        'spesialisasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 561)
        Me.Controls.Add(Me.dgSpesialisasi)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorSpesialisasi)
        Me.Name = "spesialisasi"
        Me.Text = "Spesialisasi Dokter"
        CType(Me.BindingNavigatorSpesialisasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorSpesialisasi.ResumeLayout(False)
        Me.BindingNavigatorSpesialisasi.PerformLayout()
        CType(Me.dgSpesialisasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSpesialisasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorSpesialisasi As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewSpesialisasi As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteSpesialisasi As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButtonSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgSpesialisasi As System.Windows.Forms.DataGridView
    Friend WithEvents SpesialisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSourceSpesialisasi As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterSpesialisasi As laboratorium.DataSet_LabTableAdapters.spesialisasiTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisspesialisasiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
