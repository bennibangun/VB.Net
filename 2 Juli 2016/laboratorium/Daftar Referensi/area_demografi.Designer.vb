<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class area_demografi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(area_demografi))
        Me.BindingNavigatorAreaDemografi = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgPasien = New System.Windows.Forms.DataGridView()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlp_seluler = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewPasien = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeletePasien = New System.Windows.Forms.ToolStripButton()
        Me.ButtonSave = New System.Windows.Forms.ToolStripButton()
        CType(Me.BindingNavigatorAreaDemografi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorAreaDemografi.SuspendLayout()
        CType(Me.dgPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorAreaDemografi
        '
        Me.BindingNavigatorAreaDemografi.AddNewItem = Me.BindingNavigatorAddNewPasien
        Me.BindingNavigatorAreaDemografi.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorAreaDemografi.DeleteItem = Nothing
        Me.BindingNavigatorAreaDemografi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewPasien, Me.BindingNavigatorDeletePasien, Me.ButtonSave})
        Me.BindingNavigatorAreaDemografi.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorAreaDemografi.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorAreaDemografi.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorAreaDemografi.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorAreaDemografi.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorAreaDemografi.Name = "BindingNavigatorAreaDemografi"
        Me.BindingNavigatorAreaDemografi.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorAreaDemografi.Size = New System.Drawing.Size(688, 25)
        Me.BindingNavigatorAreaDemografi.TabIndex = 2
        Me.BindingNavigatorAreaDemografi.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'dgPasien
        '
        Me.dgPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPasien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.alamat, Me.tlp_seluler})
        Me.dgPasien.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgPasien.Location = New System.Drawing.Point(0, 98)
        Me.dgPasien.Name = "dgPasien"
        Me.dgPasien.Size = New System.Drawing.Size(688, 463)
        Me.dgPasien.TabIndex = 14
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
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(478, 53)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCariData
        '
        Me.btnCariData.Location = New System.Drawing.Point(367, 53)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(75, 23)
        Me.btnCariData.TabIndex = 12
        Me.btnCariData.Text = "Cari data"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 55)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 20)
        Me.txtSearch.TabIndex = 11
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
        'AreaDemografi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 561)
        Me.Controls.Add(Me.dgPasien)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCariData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BindingNavigatorAreaDemografi)
        Me.Name = "AreaDemografi"
        Me.Text = "Area Demografi"
        CType(Me.BindingNavigatorAreaDemografi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorAreaDemografi.ResumeLayout(False)
        Me.BindingNavigatorAreaDemografi.PerformLayout()
        CType(Me.dgPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorAreaDemografi As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents dgPasien As System.Windows.Forms.DataGridView
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tlp_seluler As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
