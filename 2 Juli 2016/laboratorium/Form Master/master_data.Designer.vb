<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_data
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInstrument = New System.Windows.Forms.Button()
        Me.btnReagenOnBoard = New System.Windows.Forms.Button()
        Me.btnBarangHabisPakai = New System.Windows.Forms.Button()
        Me.btnRujukan = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnPengirim = New System.Windows.Forms.Button()
        Me.btnDokter = New System.Windows.Forms.Button()
        Me.btnPasien = New System.Windows.Forms.Button()
        Me.pnlMasterData = New System.Windows.Forms.Panel()
        Me.btnTabung = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnTabung)
        Me.Panel1.Controls.Add(Me.btnInstrument)
        Me.Panel1.Controls.Add(Me.btnReagenOnBoard)
        Me.Panel1.Controls.Add(Me.btnBarangHabisPakai)
        Me.Panel1.Controls.Add(Me.btnRujukan)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnSupplier)
        Me.Panel1.Controls.Add(Me.btnPengirim)
        Me.Panel1.Controls.Add(Me.btnDokter)
        Me.Panel1.Controls.Add(Me.btnPasien)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 746)
        Me.Panel1.TabIndex = 0
        '
        'btnInstrument
        '
        Me.btnInstrument.Location = New System.Drawing.Point(12, 301)
        Me.btnInstrument.Name = "btnInstrument"
        Me.btnInstrument.Size = New System.Drawing.Size(123, 23)
        Me.btnInstrument.TabIndex = 8
        Me.btnInstrument.Text = "Instrument"
        Me.btnInstrument.UseVisualStyleBackColor = True
        '
        'btnReagenOnBoard
        '
        Me.btnReagenOnBoard.Location = New System.Drawing.Point(11, 262)
        Me.btnReagenOnBoard.Name = "btnReagenOnBoard"
        Me.btnReagenOnBoard.Size = New System.Drawing.Size(124, 26)
        Me.btnReagenOnBoard.TabIndex = 7
        Me.btnReagenOnBoard.Text = "Reagen On Board"
        Me.btnReagenOnBoard.UseVisualStyleBackColor = True
        '
        'btnBarangHabisPakai
        '
        Me.btnBarangHabisPakai.Location = New System.Drawing.Point(12, 221)
        Me.btnBarangHabisPakai.Name = "btnBarangHabisPakai"
        Me.btnBarangHabisPakai.Size = New System.Drawing.Size(124, 26)
        Me.btnBarangHabisPakai.TabIndex = 6
        Me.btnBarangHabisPakai.Text = "Barang Habis Pakai"
        Me.btnBarangHabisPakai.UseVisualStyleBackColor = True
        '
        'btnRujukan
        '
        Me.btnRujukan.Location = New System.Drawing.Point(12, 182)
        Me.btnRujukan.Name = "btnRujukan"
        Me.btnRujukan.Size = New System.Drawing.Size(124, 26)
        Me.btnRujukan.TabIndex = 5
        Me.btnRujukan.Text = "Rujukan"
        Me.btnRujukan.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 374)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.Location = New System.Drawing.Point(11, 142)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(124, 26)
        Me.btnSupplier.TabIndex = 3
        Me.btnSupplier.Text = "Supplier"
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'btnPengirim
        '
        Me.btnPengirim.Location = New System.Drawing.Point(11, 104)
        Me.btnPengirim.Name = "btnPengirim"
        Me.btnPengirim.Size = New System.Drawing.Size(124, 26)
        Me.btnPengirim.TabIndex = 2
        Me.btnPengirim.Text = "Pengirim"
        Me.btnPengirim.UseVisualStyleBackColor = True
        '
        'btnDokter
        '
        Me.btnDokter.Location = New System.Drawing.Point(11, 65)
        Me.btnDokter.Name = "btnDokter"
        Me.btnDokter.Size = New System.Drawing.Size(124, 26)
        Me.btnDokter.TabIndex = 1
        Me.btnDokter.Text = "Dokter"
        Me.btnDokter.UseVisualStyleBackColor = True
        '
        'btnPasien
        '
        Me.btnPasien.Location = New System.Drawing.Point(12, 27)
        Me.btnPasien.Name = "btnPasien"
        Me.btnPasien.Size = New System.Drawing.Size(124, 26)
        Me.btnPasien.TabIndex = 0
        Me.btnPasien.Text = "Pasien"
        Me.btnPasien.UseVisualStyleBackColor = True
        '
        'pnlMasterData
        '
        Me.pnlMasterData.AutoScroll = True
        Me.pnlMasterData.AutoSize = True
        Me.pnlMasterData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMasterData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMasterData.Location = New System.Drawing.Point(148, 0)
        Me.pnlMasterData.Name = "pnlMasterData"
        Me.pnlMasterData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pnlMasterData.Size = New System.Drawing.Size(1222, 746)
        Me.pnlMasterData.TabIndex = 1
        '
        'btnTabung
        '
        Me.btnTabung.Location = New System.Drawing.Point(12, 337)
        Me.btnTabung.Name = "btnTabung"
        Me.btnTabung.Size = New System.Drawing.Size(123, 23)
        Me.btnTabung.TabIndex = 9
        Me.btnTabung.Text = "Tabung"
        Me.btnTabung.UseVisualStyleBackColor = True
        '
        'master_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 746)
        Me.Controls.Add(Me.pnlMasterData)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "master_data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlMasterData As System.Windows.Forms.Panel
    Friend WithEvents btnPasien As System.Windows.Forms.Button
    Friend WithEvents btnPengirim As System.Windows.Forms.Button
    Friend WithEvents btnDokter As System.Windows.Forms.Button
    Friend WithEvents btnSupplier As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRujukan As System.Windows.Forms.Button
    Friend WithEvents btnBarangHabisPakai As System.Windows.Forms.Button
    Friend WithEvents btnReagenOnBoard As System.Windows.Forms.Button
    Friend WithEvents btnInstrument As System.Windows.Forms.Button
    Friend WithEvents btnTabung As System.Windows.Forms.Button
End Class
