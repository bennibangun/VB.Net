<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class referensi
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
        Me.btnDaftarHasilMemo = New System.Windows.Forms.Button()
        Me.btnLoketPemeriksaan = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSpesialisasiDokter = New System.Windows.Forms.Button()
        Me.btnJenisPekerjaan = New System.Windows.Forms.Button()
        Me.btnPendidikan = New System.Windows.Forms.Button()
        Me.btnAreaDemografi = New System.Windows.Forms.Button()
        Me.pnlReferensi = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnDaftarHasilMemo)
        Me.Panel1.Controls.Add(Me.btnLoketPemeriksaan)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnSpesialisasiDokter)
        Me.Panel1.Controls.Add(Me.btnJenisPekerjaan)
        Me.Panel1.Controls.Add(Me.btnPendidikan)
        Me.Panel1.Controls.Add(Me.btnAreaDemografi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 553)
        Me.Panel1.TabIndex = 1
        '
        'btnDaftarHasilMemo
        '
        Me.btnDaftarHasilMemo.Location = New System.Drawing.Point(12, 221)
        Me.btnDaftarHasilMemo.Name = "btnDaftarHasilMemo"
        Me.btnDaftarHasilMemo.Size = New System.Drawing.Size(152, 26)
        Me.btnDaftarHasilMemo.TabIndex = 6
        Me.btnDaftarHasilMemo.Text = "Daftar Hasil Memo"
        Me.btnDaftarHasilMemo.UseVisualStyleBackColor = True
        '
        'btnLoketPemeriksaan
        '
        Me.btnLoketPemeriksaan.Location = New System.Drawing.Point(12, 182)
        Me.btnLoketPemeriksaan.Name = "btnLoketPemeriksaan"
        Me.btnLoketPemeriksaan.Size = New System.Drawing.Size(152, 26)
        Me.btnLoketPemeriksaan.TabIndex = 5
        Me.btnLoketPemeriksaan.Text = "Bagian"
        Me.btnLoketPemeriksaan.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 261)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 26)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSpesialisasiDokter
        '
        Me.btnSpesialisasiDokter.Location = New System.Drawing.Point(11, 142)
        Me.btnSpesialisasiDokter.Name = "btnSpesialisasiDokter"
        Me.btnSpesialisasiDokter.Size = New System.Drawing.Size(152, 26)
        Me.btnSpesialisasiDokter.TabIndex = 3
        Me.btnSpesialisasiDokter.Text = "Spesialisasi Dokter"
        Me.btnSpesialisasiDokter.UseVisualStyleBackColor = True
        '
        'btnJenisPekerjaan
        '
        Me.btnJenisPekerjaan.Location = New System.Drawing.Point(11, 104)
        Me.btnJenisPekerjaan.Name = "btnJenisPekerjaan"
        Me.btnJenisPekerjaan.Size = New System.Drawing.Size(152, 26)
        Me.btnJenisPekerjaan.TabIndex = 2
        Me.btnJenisPekerjaan.Text = "Jenis Pekerjaan"
        Me.btnJenisPekerjaan.UseVisualStyleBackColor = True
        '
        'btnPendidikan
        '
        Me.btnPendidikan.Location = New System.Drawing.Point(11, 65)
        Me.btnPendidikan.Name = "btnPendidikan"
        Me.btnPendidikan.Size = New System.Drawing.Size(152, 26)
        Me.btnPendidikan.TabIndex = 1
        Me.btnPendidikan.Text = "Pendidikan"
        Me.btnPendidikan.UseVisualStyleBackColor = True
        '
        'btnAreaDemografi
        '
        Me.btnAreaDemografi.Location = New System.Drawing.Point(12, 27)
        Me.btnAreaDemografi.Name = "btnAreaDemografi"
        Me.btnAreaDemografi.Size = New System.Drawing.Size(152, 26)
        Me.btnAreaDemografi.TabIndex = 0
        Me.btnAreaDemografi.Text = "Area Demografi"
        Me.btnAreaDemografi.UseVisualStyleBackColor = True
        '
        'pnlReferensi
        '
        Me.pnlReferensi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlReferensi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReferensi.Location = New System.Drawing.Point(179, 0)
        Me.pnlReferensi.Name = "pnlReferensi"
        Me.pnlReferensi.Size = New System.Drawing.Size(626, 553)
        Me.pnlReferensi.TabIndex = 2
        '
        'referensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 553)
        Me.Controls.Add(Me.pnlReferensi)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "referensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Referensi"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDaftarHasilMemo As System.Windows.Forms.Button
    Friend WithEvents btnLoketPemeriksaan As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSpesialisasiDokter As System.Windows.Forms.Button
    Friend WithEvents btnJenisPekerjaan As System.Windows.Forms.Button
    Friend WithEvents btnPendidikan As System.Windows.Forms.Button
    Friend WithEvents btnAreaDemografi As System.Windows.Forms.Button
    Friend WithEvents pnlReferensi As System.Windows.Forms.Panel
End Class
