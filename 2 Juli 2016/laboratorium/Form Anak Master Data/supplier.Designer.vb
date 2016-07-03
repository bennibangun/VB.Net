<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplier
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.txtAtasNama = New System.Windows.Forms.TextBox()
        Me.txtNoRekening = New System.Windows.Forms.TextBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.cboPembayaranFee = New System.Windows.Forms.ComboBox()
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProvinsi = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTlpSelular = New System.Windows.Forms.TextBox()
        Me.txtTlpRumah = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboKecamatan = New System.Windows.Forms.ComboBox()
        Me.cboKabupaten = New System.Windows.Forms.ComboBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtNamaKontak = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblTglRevisi = New System.Windows.Forms.Label()
        Me.lblJamSelesaiRevisi = New System.Windows.Forms.Label()
        Me.lblJamMulaiRevisi = New System.Windows.Forms.Label()
        Me.lblDirevisiOleh = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TableAdapterCaraBayar = New laboratorium.DataSet_LabTableAdapters.cara_bayarTableAdapter()
        Me.TableAdapterProvinsi = New laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter()
        Me.TableAdapterKabupaten = New laboratorium.DataSet_LabTableAdapters.kabupatenTableAdapter()
        Me.TableAdapterKecamatan = New laboratorium.DataSet_LabTableAdapters.kecamatanTableAdapter()
        Me.TableAdapterBank = New laboratorium.DataSet_LabTableAdapters.bankTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(267, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(245, 31)
        Me.lblDate.TabIndex = 101
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(518, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(93, 31)
        Me.lblTime.TabIndex = 100
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(23, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(203, 31)
        Me.Label23.TabIndex = 99
        Me.Label23.Text = "Master Supplier"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtFee)
        Me.GroupBox2.Controls.Add(Me.txtAtasNama)
        Me.GroupBox2.Controls.Add(Me.txtNoRekening)
        Me.GroupBox2.Controls.Add(Me.cboBank)
        Me.GroupBox2.Controls.Add(Me.cboPembayaranFee)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 366)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 195)
        Me.GroupBox2.TabIndex = 103
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Administrasi Pembayaran"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(149, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(15, 13)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "%"
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(106, 26)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(38, 20)
        Me.txtFee.TabIndex = 44
        '
        'txtAtasNama
        '
        Me.txtAtasNama.Location = New System.Drawing.Point(104, 166)
        Me.txtAtasNama.Name = "txtAtasNama"
        Me.txtAtasNama.Size = New System.Drawing.Size(157, 20)
        Me.txtAtasNama.TabIndex = 43
        '
        'txtNoRekening
        '
        Me.txtNoRekening.Location = New System.Drawing.Point(104, 134)
        Me.txtNoRekening.Name = "txtNoRekening"
        Me.txtNoRekening.Size = New System.Drawing.Size(157, 20)
        Me.txtNoRekening.TabIndex = 41
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.FormattingEnabled = True
        Me.cboBank.Location = New System.Drawing.Point(105, 99)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(256, 21)
        Me.cboBank.TabIndex = 42
        '
        'cboPembayaranFee
        '
        Me.cboPembayaranFee.DataSource = Me.DataSet_Lab
        Me.cboPembayaranFee.DisplayMember = "cara_bayar.nama_cara_bayar"
        Me.cboPembayaranFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPembayaranFee.FormattingEnabled = True
        Me.cboPembayaranFee.Location = New System.Drawing.Point(104, 63)
        Me.cboPembayaranFee.Name = "cboPembayaranFee"
        Me.cboPembayaranFee.Size = New System.Drawing.Size(72, 21)
        Me.cboPembayaranFee.TabIndex = 37
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnTutup)
        Me.GroupBox3.Controls.Add(Me.btnSimpan)
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Location = New System.Drawing.Point(377, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 68)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controls"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(156, 23)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(63, 35)
        Me.btnTutup.TabIndex = 30
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(13, 22)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(63, 35)
        Me.btnSimpan.TabIndex = 27
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(85, 22)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(63, 35)
        Me.btnHapus.TabIndex = 29
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Atas Nama"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Fee"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Bank"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Pembayaran Fee"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Nomor Rekening"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboProvinsi)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtTlpSelular)
        Me.GroupBox1.Controls.Add(Me.txtTlpRumah)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cboKecamatan)
        Me.GroupBox1.Controls.Add(Me.cboKabupaten)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.txtNamaKontak)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 309)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identitas Supplier"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(105, 275)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(134, 20)
        Me.txtEmail.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "E-mail"
        '
        'cboProvinsi
        '
        Me.cboProvinsi.FormattingEnabled = True
        Me.cboProvinsi.Location = New System.Drawing.Point(104, 137)
        Me.cboProvinsi.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProvinsi.Name = "cboProvinsi"
        Me.cboProvinsi.Size = New System.Drawing.Size(222, 21)
        Me.cboProvinsi.TabIndex = 42
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 139)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Provinsi"
        '
        'txtTlpSelular
        '
        Me.txtTlpSelular.Location = New System.Drawing.Point(353, 241)
        Me.txtTlpSelular.Name = "txtTlpSelular"
        Me.txtTlpSelular.Size = New System.Drawing.Size(157, 20)
        Me.txtTlpSelular.TabIndex = 39
        '
        'txtTlpRumah
        '
        Me.txtTlpRumah.Location = New System.Drawing.Point(148, 241)
        Me.txtTlpRumah.Name = "txtTlpRumah"
        Me.txtTlpRumah.Size = New System.Drawing.Size(131, 20)
        Me.txtTlpRumah.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(103, 243)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 13)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Rumah"
        '
        'cboKecamatan
        '
        Me.cboKecamatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKecamatan.FormattingEnabled = True
        Me.cboKecamatan.Location = New System.Drawing.Point(105, 207)
        Me.cboKecamatan.Name = "cboKecamatan"
        Me.cboKecamatan.Size = New System.Drawing.Size(223, 21)
        Me.cboKecamatan.TabIndex = 36
        '
        'cboKabupaten
        '
        Me.cboKabupaten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKabupaten.FormattingEnabled = True
        Me.cboKabupaten.Location = New System.Drawing.Point(104, 172)
        Me.cboKabupaten.Name = "cboKabupaten"
        Me.cboKabupaten.Size = New System.Drawing.Size(222, 21)
        Me.cboKabupaten.TabIndex = 35
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(104, 91)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(388, 32)
        Me.txtAlamat.TabIndex = 34
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Location = New System.Drawing.Point(104, 23)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(134, 21)
        Me.lblID.TabIndex = 31
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaKontak
        '
        Me.txtNamaKontak.Location = New System.Drawing.Point(104, 57)
        Me.txtNamaKontak.Name = "txtNamaKontak"
        Me.txtNamaKontak.Size = New System.Drawing.Size(134, 20)
        Me.txtNamaKontak.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "ID"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(494, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 23)
        Me.Label16.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nama Kontak"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Selular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(12, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Kecamatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Kabupaten"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(12, 94)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(39, 13)
        Me.Label30.TabIndex = 17
        Me.Label30.Text = "Alamat"
        '
        'lblTglRevisi
        '
        Me.lblTglRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTglRevisi.Location = New System.Drawing.Point(522, 621)
        Me.lblTglRevisi.Name = "lblTglRevisi"
        Me.lblTglRevisi.Size = New System.Drawing.Size(80, 18)
        Me.lblTglRevisi.TabIndex = 110
        Me.lblTglRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamSelesaiRevisi
        '
        Me.lblJamSelesaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamSelesaiRevisi.Location = New System.Drawing.Point(423, 621)
        Me.lblJamSelesaiRevisi.Name = "lblJamSelesaiRevisi"
        Me.lblJamSelesaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamSelesaiRevisi.TabIndex = 109
        Me.lblJamSelesaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamMulaiRevisi
        '
        Me.lblJamMulaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamMulaiRevisi.Location = New System.Drawing.Point(290, 620)
        Me.lblJamMulaiRevisi.Name = "lblJamMulaiRevisi"
        Me.lblJamMulaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamMulaiRevisi.TabIndex = 108
        Me.lblJamMulaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDirevisiOleh
        '
        Me.lblDirevisiOleh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDirevisiOleh.Location = New System.Drawing.Point(110, 620)
        Me.lblDirevisiOleh.Name = "lblDirevisiOleh"
        Me.lblDirevisiOleh.Size = New System.Drawing.Size(108, 21)
        Me.lblDirevisiOleh.TabIndex = 107
        Me.lblDirevisiOleh.Text = "Susi"
        Me.lblDirevisiOleh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(234, 623)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "mulai jam"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(498, 623)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(23, 14)
        Me.Label29.TabIndex = 113
        Me.Label29.Text = "tgl"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(361, 623)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 14)
        Me.Label28.TabIndex = 112
        Me.Label28.Text = "selesai jam"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(84, 623)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 14)
        Me.Label27.TabIndex = 111
        Me.Label27.Text = "oleh"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 625)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = "Diperbaharui"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(87, 567)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(515, 41)
        Me.txtKeterangan.TabIndex = 106
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 567)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "Keterangan"
        '
        'TableAdapterCaraBayar
        '
        Me.TableAdapterCaraBayar.ClearBeforeFill = True
        '
        'TableAdapterProvinsi
        '
        Me.TableAdapterProvinsi.ClearBeforeFill = True
        '
        'TableAdapterKabupaten
        '
        Me.TableAdapterKabupaten.ClearBeforeFill = True
        '
        'TableAdapterKecamatan
        '
        Me.TableAdapterKecamatan.ClearBeforeFill = True
        '
        'TableAdapterBank
        '
        Me.TableAdapterBank.ClearBeforeFill = True
        '
        'supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 644)
        Me.Controls.Add(Me.lblTglRevisi)
        Me.Controls.Add(Me.lblJamSelesaiRevisi)
        Me.Controls.Add(Me.lblJamMulaiRevisi)
        Me.Controls.Add(Me.lblDirevisiOleh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label23)
        Me.Name = "supplier"
        Me.Text = "Supplier"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents txtAtasNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNoRekening As System.Windows.Forms.TextBox
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents cboPembayaranFee As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboProvinsi As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTlpSelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTlpRumah As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboKecamatan As System.Windows.Forms.ComboBox
    Friend WithEvents cboKabupaten As System.Windows.Forms.ComboBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtNamaKontak As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblTglRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamSelesaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamMulaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblDirevisiOleh As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterCaraBayar As laboratorium.DataSet_LabTableAdapters.cara_bayarTableAdapter
    Friend WithEvents TableAdapterProvinsi As laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter
    Friend WithEvents TableAdapterKabupaten As laboratorium.DataSet_LabTableAdapters.kabupatenTableAdapter
    Friend WithEvents TableAdapterKecamatan As laboratorium.DataSet_LabTableAdapters.kecamatanTableAdapter
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterBank As laboratorium.DataSet_LabTableAdapters.bankTableAdapter
End Class
