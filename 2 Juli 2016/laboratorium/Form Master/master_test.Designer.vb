<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_test
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
        Me.btnLabRujukan = New System.Windows.Forms.Button()
        Me.pnlMasterTest = New System.Windows.Forms.Panel()
        Me.btnMetodePemeriksaan = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDaftarHarga = New System.Windows.Forms.Button()
        Me.btnKategoriFeeAnalis = New System.Windows.Forms.Button()
        Me.btnMasterTest = New System.Windows.Forms.Button()
        Me.btnKelompok = New System.Windows.Forms.Button()
        Me.btnSample = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLabRujukan
        '
        Me.btnLabRujukan.Location = New System.Drawing.Point(11, 137)
        Me.btnLabRujukan.Name = "btnLabRujukan"
        Me.btnLabRujukan.Size = New System.Drawing.Size(124, 26)
        Me.btnLabRujukan.TabIndex = 2
        Me.btnLabRujukan.Text = "Lab. Rujukan"
        Me.btnLabRujukan.UseVisualStyleBackColor = True
        '
        'pnlMasterTest
        '
        Me.pnlMasterTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMasterTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMasterTest.Location = New System.Drawing.Point(148, 0)
        Me.pnlMasterTest.Name = "pnlMasterTest"
        Me.pnlMasterTest.Size = New System.Drawing.Size(657, 494)
        Me.pnlMasterTest.TabIndex = 3
        '
        'btnMetodePemeriksaan
        '
        Me.btnMetodePemeriksaan.Location = New System.Drawing.Point(11, 64)
        Me.btnMetodePemeriksaan.Name = "btnMetodePemeriksaan"
        Me.btnMetodePemeriksaan.Size = New System.Drawing.Size(124, 26)
        Me.btnMetodePemeriksaan.TabIndex = 1
        Me.btnMetodePemeriksaan.Text = "Metode Pemeriksaan"
        Me.btnMetodePemeriksaan.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnSample)
        Me.Panel1.Controls.Add(Me.btnDaftarHarga)
        Me.Panel1.Controls.Add(Me.btnKategoriFeeAnalis)
        Me.Panel1.Controls.Add(Me.btnMasterTest)
        Me.Panel1.Controls.Add(Me.btnLabRujukan)
        Me.Panel1.Controls.Add(Me.btnMetodePemeriksaan)
        Me.Panel1.Controls.Add(Me.btnKelompok)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 494)
        Me.Panel1.TabIndex = 2
        '
        'btnDaftarHarga
        '
        Me.btnDaftarHarga.Location = New System.Drawing.Point(11, 247)
        Me.btnDaftarHarga.Name = "btnDaftarHarga"
        Me.btnDaftarHarga.Size = New System.Drawing.Size(124, 26)
        Me.btnDaftarHarga.TabIndex = 5
        Me.btnDaftarHarga.Text = "Daftar Harga"
        Me.btnDaftarHarga.UseVisualStyleBackColor = True
        '
        'btnKategoriFeeAnalis
        '
        Me.btnKategoriFeeAnalis.Location = New System.Drawing.Point(12, 211)
        Me.btnKategoriFeeAnalis.Name = "btnKategoriFeeAnalis"
        Me.btnKategoriFeeAnalis.Size = New System.Drawing.Size(124, 26)
        Me.btnKategoriFeeAnalis.TabIndex = 4
        Me.btnKategoriFeeAnalis.Text = "Kategori Fee Analis"
        Me.btnKategoriFeeAnalis.UseVisualStyleBackColor = True
        '
        'btnMasterTest
        '
        Me.btnMasterTest.Location = New System.Drawing.Point(12, 174)
        Me.btnMasterTest.Name = "btnMasterTest"
        Me.btnMasterTest.Size = New System.Drawing.Size(124, 26)
        Me.btnMasterTest.TabIndex = 3
        Me.btnMasterTest.Text = "Master Test"
        Me.btnMasterTest.UseVisualStyleBackColor = True
        '
        'btnKelompok
        '
        Me.btnKelompok.Location = New System.Drawing.Point(12, 27)
        Me.btnKelompok.Name = "btnKelompok"
        Me.btnKelompok.Size = New System.Drawing.Size(124, 26)
        Me.btnKelompok.TabIndex = 0
        Me.btnKelompok.Text = "Kelompok"
        Me.btnKelompok.UseVisualStyleBackColor = True
        '
        'btnSample
        '
        Me.btnSample.Location = New System.Drawing.Point(12, 100)
        Me.btnSample.Name = "btnSample"
        Me.btnSample.Size = New System.Drawing.Size(124, 26)
        Me.btnSample.TabIndex = 10
        Me.btnSample.Text = "Sample / Bahan Test"
        Me.btnSample.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(11, 285)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 26)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'master_test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 494)
        Me.Controls.Add(Me.pnlMasterTest)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "master_test"
        Me.Text = "Master Test"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLabRujukan As System.Windows.Forms.Button
    Friend WithEvents pnlMasterTest As System.Windows.Forms.Panel
    Friend WithEvents btnMetodePemeriksaan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnKelompok As System.Windows.Forms.Button
    Friend WithEvents btnKategoriFeeAnalis As System.Windows.Forms.Button
    Friend WithEvents btnMasterTest As System.Windows.Forms.Button
    Friend WithEvents btnDaftarHarga As System.Windows.Forms.Button
    Friend WithEvents btnSample As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
