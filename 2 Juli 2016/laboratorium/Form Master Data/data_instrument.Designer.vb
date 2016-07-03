<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_instrument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_instrument))
        Me.BindingNavigatorInstrument = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItemInstrument = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteInstrument = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSaveInstrument = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgInstrument = New System.Windows.Forms.DataGridView()
        Me.BindingSourceInstrument = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.TableAdapterInstrument = New laboratorium.DataSet_LabTableAdapters.instrumentTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamainstrumentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingNavigatorInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorInstrument.SuspendLayout()
        CType(Me.dgInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorInstrument
        '
        Me.BindingNavigatorInstrument.AddNewItem = Me.BindingNavigatorAddNewItemInstrument
        Me.BindingNavigatorInstrument.BindingSource = Me.BindingSourceInstrument
        Me.BindingNavigatorInstrument.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorInstrument.DeleteItem = Nothing
        Me.BindingNavigatorInstrument.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItemInstrument, Me.BindingNavigatorDeleteInstrument, Me.ButtonSaveInstrument})
        Me.BindingNavigatorInstrument.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorInstrument.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorInstrument.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorInstrument.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorInstrument.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorInstrument.Name = "BindingNavigatorInstrument"
        Me.BindingNavigatorInstrument.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorInstrument.Size = New System.Drawing.Size(1370, 25)
        Me.BindingNavigatorInstrument.TabIndex = 0
        Me.BindingNavigatorInstrument.Text = "Instrument"
        '
        'BindingNavigatorAddNewItemInstrument
        '
        Me.BindingNavigatorAddNewItemInstrument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItemInstrument.Image = CType(resources.GetObject("BindingNavigatorAddNewItemInstrument.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItemInstrument.Name = "BindingNavigatorAddNewItemInstrument"
        Me.BindingNavigatorAddNewItemInstrument.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItemInstrument.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItemInstrument.Text = "Add new"
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
        'BindingNavigatorDeleteInstrument
        '
        Me.BindingNavigatorDeleteInstrument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteInstrument.Image = CType(resources.GetObject("BindingNavigatorDeleteInstrument.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteInstrument.Name = "BindingNavigatorDeleteInstrument"
        Me.BindingNavigatorDeleteInstrument.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteInstrument.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteInstrument.Text = "Delete"
        '
        'ButtonSaveInstrument
        '
        Me.ButtonSaveInstrument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonSaveInstrument.Image = Global.laboratorium.My.Resources.Resources.save
        Me.ButtonSaveInstrument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonSaveInstrument.Name = "ButtonSaveInstrument"
        Me.ButtonSaveInstrument.Size = New System.Drawing.Size(23, 22)
        Me.ButtonSaveInstrument.Text = "ToolStripButton1"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(496, 41)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(385, 41)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 8
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(30, 43)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 7
        '
        'dgInstrument
        '
        Me.dgInstrument.AllowUserToAddRows = False
        Me.dgInstrument.AutoGenerateColumns = False
        Me.dgInstrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInstrument.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NamainstrumentDataGridViewTextBoxColumn})
        Me.dgInstrument.DataSource = Me.BindingSourceInstrument
        Me.dgInstrument.Location = New System.Drawing.Point(0, 70)
        Me.dgInstrument.Name = "dgInstrument"
        Me.dgInstrument.Size = New System.Drawing.Size(1370, 463)
        Me.dgInstrument.TabIndex = 10
        '
        'BindingSourceInstrument
        '
        Me.BindingSourceInstrument.DataMember = "instrument"
        Me.BindingSourceInstrument.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterInstrument
        '
        Me.TableAdapterInstrument.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'NamainstrumentDataGridViewTextBoxColumn
        '
        Me.NamainstrumentDataGridViewTextBoxColumn.DataPropertyName = "nama_instrument"
        Me.NamainstrumentDataGridViewTextBoxColumn.HeaderText = "Nama Instrument"
        Me.NamainstrumentDataGridViewTextBoxColumn.Name = "NamainstrumentDataGridViewTextBoxColumn"
        Me.NamainstrumentDataGridViewTextBoxColumn.Width = 200
        '
        'data_instrument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 541)
        Me.Controls.Add(Me.dgInstrument)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorInstrument)
        Me.Name = "data_instrument"
        Me.Text = "Master Instrument"
        CType(Me.BindingNavigatorInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorInstrument.ResumeLayout(False)
        Me.BindingNavigatorInstrument.PerformLayout()
        CType(Me.dgInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorInstrument As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItemInstrument As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteInstrument As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ButtonSaveInstrument As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgInstrument As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceInstrument As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterInstrument As laboratorium.DataSet_LabTableAdapters.instrumentTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamainstrumentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
