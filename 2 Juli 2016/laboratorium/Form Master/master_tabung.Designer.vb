<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_tabung
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtPeringatanJumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPeringatanExpired = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSisaTahun = New System.Windows.Forms.TextBox()
        Me.txtSisaHari = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSisaBulan = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKuantitas = New System.Windows.Forms.TextBox()
        Me.cbxNamaTabung = New System.Windows.Forms.ComboBox()
        Me.BindingSourceNamaTabung = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.txtKodeTabung = New System.Windows.Forms.TextBox()
        Me.txtEmpty = New System.Windows.Forms.TextBox()
        Me.cbxKelompok = New System.Windows.Forms.ComboBox()
        Me.BindingSourceJenisKelompok = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpTglExpired = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTglRevisi = New System.Windows.Forms.Label()
        Me.lblJamSelesaiRevisi = New System.Windows.Forms.Label()
        Me.lblJamMulaiRevisi = New System.Windows.Forms.Label()
        Me.lblDirevisiOleh = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TableAdapterJenisKelompok = New laboratorium.DataSet_LabTableAdapters.jenis_kelompokTableAdapter()
        Me.TableAdapterNamaTabung = New laboratorium.DataSet_LabTableAdapters.nama_tabungTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingSourceNamaTabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceJenisKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtPeringatanJumlah)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPeringatanExpired)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtKuantitas)
        Me.GroupBox1.Controls.Add(Me.cbxNamaTabung)
        Me.GroupBox1.Controls.Add(Me.txtKodeTabung)
        Me.GroupBox1.Controls.Add(Me.txtEmpty)
        Me.GroupBox1.Controls.Add(Me.cbxKelompok)
        Me.GroupBox1.Controls.Add(Me.dtpTglExpired)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 327)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Tabung"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnTutup)
        Me.GroupBox4.Controls.Add(Me.btnSimpan)
        Me.GroupBox4.Controls.Add(Me.btnHapus)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 240)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(583, 69)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Controls"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(332, 21)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(63, 35)
        Me.btnTutup.TabIndex = 30
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(74, 22)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(63, 35)
        Me.btnSimpan.TabIndex = 27
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(198, 22)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(63, 35)
        Me.btnHapus.TabIndex = 29
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'txtPeringatanJumlah
        '
        Me.txtPeringatanJumlah.Location = New System.Drawing.Point(114, 198)
        Me.txtPeringatanJumlah.Name = "txtPeringatanJumlah"
        Me.txtPeringatanJumlah.Size = New System.Drawing.Size(175, 20)
        Me.txtPeringatanJumlah.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Peringatan Jumlah"
        '
        'txtPeringatanExpired
        '
        Me.txtPeringatanExpired.Location = New System.Drawing.Point(114, 164)
        Me.txtPeringatanExpired.Name = "txtPeringatanExpired"
        Me.txtPeringatanExpired.Size = New System.Drawing.Size(175, 20)
        Me.txtPeringatanExpired.TabIndex = 57
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSisaTahun)
        Me.GroupBox2.Controls.Add(Me.txtSisaHari)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtSisaBulan)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 55)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sisa Waktu"
        '
        'txtSisaTahun
        '
        Me.txtSisaTahun.Location = New System.Drawing.Point(6, 24)
        Me.txtSisaTahun.Name = "txtSisaTahun"
        Me.txtSisaTahun.Size = New System.Drawing.Size(40, 20)
        Me.txtSisaTahun.TabIndex = 51
        '
        'txtSisaHari
        '
        Me.txtSisaHari.Location = New System.Drawing.Point(175, 23)
        Me.txtSisaHari.Name = "txtSisaHari"
        Me.txtSisaHari.Size = New System.Drawing.Size(40, 20)
        Me.txtSisaHari.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(218, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Hari"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Thn"
        '
        'txtSisaBulan
        '
        Me.txtSisaBulan.Location = New System.Drawing.Point(93, 24)
        Me.txtSisaBulan.Name = "txtSisaBulan"
        Me.txtSisaBulan.Size = New System.Drawing.Size(40, 20)
        Me.txtSisaBulan.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(136, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Bln"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(212, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "tabung"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKuantitas
        '
        Me.txtKuantitas.Location = New System.Drawing.Point(114, 90)
        Me.txtKuantitas.Name = "txtKuantitas"
        Me.txtKuantitas.Size = New System.Drawing.Size(94, 20)
        Me.txtKuantitas.TabIndex = 46
        '
        'cbxNamaTabung
        '
        Me.cbxNamaTabung.DataSource = Me.BindingSourceNamaTabung
        Me.cbxNamaTabung.DisplayMember = "nama_tabung"
        Me.cbxNamaTabung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNamaTabung.FormattingEnabled = True
        Me.cbxNamaTabung.Location = New System.Drawing.Point(114, 57)
        Me.cbxNamaTabung.Name = "cbxNamaTabung"
        Me.cbxNamaTabung.Size = New System.Drawing.Size(185, 21)
        Me.cbxNamaTabung.TabIndex = 45
        '
        'BindingSourceNamaTabung
        '
        Me.BindingSourceNamaTabung.DataMember = "nama_tabung"
        Me.BindingSourceNamaTabung.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtKodeTabung
        '
        Me.txtKodeTabung.Location = New System.Drawing.Point(113, 23)
        Me.txtKodeTabung.Name = "txtKodeTabung"
        Me.txtKodeTabung.Size = New System.Drawing.Size(185, 20)
        Me.txtKodeTabung.TabIndex = 44
        '
        'txtEmpty
        '
        Me.txtEmpty.Location = New System.Drawing.Point(114, 128)
        Me.txtEmpty.Name = "txtEmpty"
        Me.txtEmpty.Size = New System.Drawing.Size(120, 20)
        Me.txtEmpty.TabIndex = 43
        Me.txtEmpty.Visible = False
        '
        'cbxKelompok
        '
        Me.cbxKelompok.DataSource = Me.BindingSourceJenisKelompok
        Me.cbxKelompok.DisplayMember = "nama_kelompok"
        Me.cbxKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKelompok.FormattingEnabled = True
        Me.cbxKelompok.Location = New System.Drawing.Point(438, 23)
        Me.cbxKelompok.Name = "cbxKelompok"
        Me.cbxKelompok.Size = New System.Drawing.Size(167, 21)
        Me.cbxKelompok.TabIndex = 40
        '
        'BindingSourceJenisKelompok
        '
        Me.BindingSourceJenisKelompok.DataMember = "jenis_kelompok"
        Me.BindingSourceJenisKelompok.DataSource = Me.DataSet_Lab
        '
        'dtpTglExpired
        '
        Me.dtpTglExpired.Location = New System.Drawing.Point(114, 128)
        Me.dtpTglExpired.Name = "dtpTglExpired"
        Me.dtpTglExpired.Size = New System.Drawing.Size(120, 20)
        Me.dtpTglExpired.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Kode"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(380, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Kelompok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Kuantitas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Expired"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Peringatan Expired"
        '
        'lblTglRevisi
        '
        Me.lblTglRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTglRevisi.Location = New System.Drawing.Point(531, 400)
        Me.lblTglRevisi.Name = "lblTglRevisi"
        Me.lblTglRevisi.Size = New System.Drawing.Size(74, 18)
        Me.lblTglRevisi.TabIndex = 64
        Me.lblTglRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJamSelesaiRevisi
        '
        Me.lblJamSelesaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamSelesaiRevisi.Location = New System.Drawing.Point(443, 400)
        Me.lblJamSelesaiRevisi.Name = "lblJamSelesaiRevisi"
        Me.lblJamSelesaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamSelesaiRevisi.TabIndex = 63
        Me.lblJamSelesaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamMulaiRevisi
        '
        Me.lblJamMulaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamMulaiRevisi.Location = New System.Drawing.Point(314, 399)
        Me.lblJamMulaiRevisi.Name = "lblJamMulaiRevisi"
        Me.lblJamMulaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamMulaiRevisi.TabIndex = 62
        Me.lblJamMulaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDirevisiOleh
        '
        Me.lblDirevisiOleh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDirevisiOleh.Location = New System.Drawing.Point(139, 399)
        Me.lblDirevisiOleh.Name = "lblDirevisiOleh"
        Me.lblDirevisiOleh.Size = New System.Drawing.Size(108, 21)
        Me.lblDirevisiOleh.TabIndex = 61
        Me.lblDirevisiOleh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(258, 402)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 14)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "mulai jam"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(510, 402)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(19, 14)
        Me.Label29.TabIndex = 67
        Me.Label29.Text = "tgl"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(381, 402)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 14)
        Me.Label28.TabIndex = 66
        Me.Label28.Text = "selesai jam"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(111, 402)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 14)
        Me.Label27.TabIndex = 65
        Me.Label27.Text = "oleh"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(18, 402)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Diperbaharui"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(268, 6)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(245, 31)
        Me.lblDate.TabIndex = 51
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(519, 6)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(93, 31)
        Me.lblTime.TabIndex = 50
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(4, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(196, 31)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Master Tabung"
        '
        'TableAdapterJenisKelompok
        '
        Me.TableAdapterJenisKelompok.ClearBeforeFill = True
        '
        'TableAdapterNamaTabung
        '
        Me.TableAdapterNamaTabung.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'master_tabung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 432)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTglRevisi)
        Me.Controls.Add(Me.lblJamSelesaiRevisi)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblJamMulaiRevisi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDirevisiOleh)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Name = "master_tabung"
        Me.Text = "Master Tabung"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BindingSourceNamaTabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceJenisKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmpty As System.Windows.Forms.TextBox
    Friend WithEvents cbxKelompok As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTglExpired As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKodeTabung As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbxNamaTabung As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents BindingSourceJenisKelompok As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterJenisKelompok As laboratorium.DataSet_LabTableAdapters.jenis_kelompokTableAdapter
    Friend WithEvents BindingSourceNamaTabung As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterNamaTabung As laboratorium.DataSet_LabTableAdapters.nama_tabungTableAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKuantitas As System.Windows.Forms.TextBox
    Friend WithEvents txtSisaTahun As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSisaBulan As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSisaHari As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPeringatanJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPeringatanExpired As System.Windows.Forms.TextBox
    Friend WithEvents lblTglRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamSelesaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamMulaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblDirevisiOleh As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
