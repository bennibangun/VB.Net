<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dokter
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
        Me.txtEmpty = New System.Windows.Forms.TextBox()
        Me.cbxProvinsi = New System.Windows.Forms.ComboBox()
        Me.BindingSourceProvinsi = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxJenKel = New System.Windows.Forms.ComboBox()
        Me.txtTlpSelular = New System.Windows.Forms.TextBox()
        Me.txtTlpRumah = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxKecamatan = New System.Windows.Forms.ComboBox()
        Me.cbxKabupaten = New System.Windows.Forms.ComboBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.cbxRhesus = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cbxGolonganDarah = New System.Windows.Forms.ComboBox()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.cbxSpesialisasi = New System.Windows.Forms.ComboBox()
        Me.BindingSourceSpesialisasi = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pbxPhoto = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabDataSet = New laboratorium.LabDataSet()
        Me.BindingSourceKabupaten = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.txtAtasNama = New System.Windows.Forms.TextBox()
        Me.txtNoRekening = New System.Windows.Forms.TextBox()
        Me.cbxBank = New System.Windows.Forms.ComboBox()
        Me.BindingSourceBank = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxPembayaranFee = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.OpenFilePhoto = New System.Windows.Forms.OpenFileDialog()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblDirevisiOleh = New System.Windows.Forms.Label()
        Me.lblJamMulaiRevisi = New System.Windows.Forms.Label()
        Me.lblJamSelesaiRevisi = New System.Windows.Forms.Label()
        Me.lblTglRevisi = New System.Windows.Forms.Label()
        Me.TableAdapterKecamatan = New laboratorium.DataSet_LabTableAdapters.kecamatanTableAdapter()
        Me.TableAdapterProvinsi = New laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter()
        Me.TableAdapterKabupaten = New laboratorium.DataSet_LabTableAdapters.kabupatenTableAdapter()
        Me.TableAdapterBank = New laboratorium.DataSet_LabTableAdapters.bankTableAdapter()
        Me.TableAdapterSpesialisasi = New laboratorium.DataSet_LabTableAdapters.spesialisasiTableAdapter()
        Me.BindingSourceCaraBayar = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterCaraBayar = New laboratorium.DataSet_LabTableAdapters.cara_bayarTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSourceProvinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSpesialisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceKabupaten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingSourceBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BindingSourceCaraBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmpty)
        Me.GroupBox1.Controls.Add(Me.cbxProvinsi)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cbxJenKel)
        Me.GroupBox1.Controls.Add(Me.txtTlpSelular)
        Me.GroupBox1.Controls.Add(Me.txtTlpRumah)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cbxKecamatan)
        Me.GroupBox1.Controls.Add(Me.cbxKabupaten)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.cbxRhesus)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.cbxGolonganDarah)
        Me.GroupBox1.Controls.Add(Me.dtpTglLahir)
        Me.GroupBox1.Controls.Add(Me.cbxSpesialisasi)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.pbxPhoto)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 381)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identitas Dokter"
        '
        'txtEmpty
        '
        Me.txtEmpty.Location = New System.Drawing.Point(104, 128)
        Me.txtEmpty.Name = "txtEmpty"
        Me.txtEmpty.Size = New System.Drawing.Size(120, 20)
        Me.txtEmpty.TabIndex = 43
        Me.txtEmpty.Visible = False
        '
        'cbxProvinsi
        '
        Me.cbxProvinsi.DataSource = Me.BindingSourceProvinsi
        Me.cbxProvinsi.FormattingEnabled = True
        Me.cbxProvinsi.Location = New System.Drawing.Point(104, 246)
        Me.cbxProvinsi.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxProvinsi.Name = "cbxProvinsi"
        Me.cbxProvinsi.Size = New System.Drawing.Size(222, 21)
        Me.cbxProvinsi.TabIndex = 42
        '
        'BindingSourceProvinsi
        '
        Me.BindingSourceProvinsi.DataMember = "provinsi"
        Me.BindingSourceProvinsi.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 248)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Provinsi"
        '
        'cbxJenKel
        '
        Me.cbxJenKel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxJenKel.FormattingEnabled = True
        Me.cbxJenKel.Items.AddRange(New Object() {"pria", "wanita"})
        Me.cbxJenKel.Location = New System.Drawing.Point(438, 13)
        Me.cbxJenKel.Name = "cbxJenKel"
        Me.cbxJenKel.Size = New System.Drawing.Size(55, 21)
        Me.cbxJenKel.TabIndex = 40
        '
        'txtTlpSelular
        '
        Me.txtTlpSelular.Location = New System.Drawing.Point(353, 350)
        Me.txtTlpSelular.Name = "txtTlpSelular"
        Me.txtTlpSelular.Size = New System.Drawing.Size(157, 20)
        Me.txtTlpSelular.TabIndex = 39
        '
        'txtTlpRumah
        '
        Me.txtTlpRumah.Location = New System.Drawing.Point(148, 350)
        Me.txtTlpRumah.Name = "txtTlpRumah"
        Me.txtTlpRumah.Size = New System.Drawing.Size(131, 20)
        Me.txtTlpRumah.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(103, 352)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 13)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Rumah"
        '
        'cbxKecamatan
        '
        Me.cbxKecamatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKecamatan.FormattingEnabled = True
        Me.cbxKecamatan.Location = New System.Drawing.Point(105, 316)
        Me.cbxKecamatan.Name = "cbxKecamatan"
        Me.cbxKecamatan.Size = New System.Drawing.Size(223, 21)
        Me.cbxKecamatan.TabIndex = 36
        '
        'cbxKabupaten
        '
        Me.cbxKabupaten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKabupaten.FormattingEnabled = True
        Me.cbxKabupaten.Location = New System.Drawing.Point(104, 281)
        Me.cbxKabupaten.Name = "cbxKabupaten"
        Me.cbxKabupaten.Size = New System.Drawing.Size(222, 21)
        Me.cbxKabupaten.TabIndex = 35
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(104, 200)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(388, 32)
        Me.txtAlamat.TabIndex = 34
        '
        'cbxRhesus
        '
        Me.cbxRhesus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRhesus.FormattingEnabled = True
        Me.cbxRhesus.Items.AddRange(New Object() {"Positive", "Negative"})
        Me.cbxRhesus.Location = New System.Drawing.Point(209, 164)
        Me.cbxRhesus.Name = "cbxRhesus"
        Me.cbxRhesus.Size = New System.Drawing.Size(70, 21)
        Me.cbxRhesus.TabIndex = 33
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(161, 167)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Rhesus"
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
        'cbxGolonganDarah
        '
        Me.cbxGolonganDarah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGolonganDarah.FormattingEnabled = True
        Me.cbxGolonganDarah.Items.AddRange(New Object() {"A", "B", "AB", "O"})
        Me.cbxGolonganDarah.Location = New System.Drawing.Point(104, 164)
        Me.cbxGolonganDarah.Name = "cbxGolonganDarah"
        Me.cbxGolonganDarah.Size = New System.Drawing.Size(39, 21)
        Me.cbxGolonganDarah.TabIndex = 30
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Location = New System.Drawing.Point(104, 128)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(120, 20)
        Me.dtpTglLahir.TabIndex = 29
        '
        'cbxSpesialisasi
        '
        Me.cbxSpesialisasi.DataSource = Me.BindingSourceSpesialisasi
        Me.cbxSpesialisasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSpesialisasi.FormattingEnabled = True
        Me.cbxSpesialisasi.Location = New System.Drawing.Point(104, 91)
        Me.cbxSpesialisasi.Name = "cbxSpesialisasi"
        Me.cbxSpesialisasi.Size = New System.Drawing.Size(388, 21)
        Me.cbxSpesialisasi.TabIndex = 28
        '
        'BindingSourceSpesialisasi
        '
        Me.BindingSourceSpesialisasi.DataMember = "spesialisasi"
        Me.BindingSourceSpesialisasi.DataSource = Me.DataSet_Lab
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(104, 57)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(134, 20)
        Me.txtNama.TabIndex = 27
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
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(514, 147)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(95, 23)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(494, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 23)
        Me.Label16.TabIndex = 24
        '
        'pbxPhoto
        '
        Me.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxPhoto.ImageLocation = ""
        Me.pbxPhoto.Location = New System.Drawing.Point(512, 19)
        Me.pbxPhoto.Name = "pbxPhoto"
        Me.pbxPhoto.Size = New System.Drawing.Size(100, 121)
        Me.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPhoto.TabIndex = 23
        Me.pbxPhoto.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(364, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Jenis Kelamin"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Selular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Spesialisasi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(12, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Kecamatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Golongan Darah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Kabupaten"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Alamat"
        '
        'LabDataSet
        '
        Me.LabDataSet.DataSetName = "LabDataSet"
        Me.LabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSourceKabupaten
        '
        Me.BindingSourceKabupaten.DataMember = "kabupaten"
        Me.BindingSourceKabupaten.DataSource = Me.DataSet_Lab
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtFee)
        Me.GroupBox2.Controls.Add(Me.txtAtasNama)
        Me.GroupBox2.Controls.Add(Me.txtNoRekening)
        Me.GroupBox2.Controls.Add(Me.cbxBank)
        Me.GroupBox2.Controls.Add(Me.cbxPembayaranFee)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 430)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 195)
        Me.GroupBox2.TabIndex = 3
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
        'cbxBank
        '
        Me.cbxBank.DataSource = Me.BindingSourceBank
        Me.cbxBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBank.FormattingEnabled = True
        Me.cbxBank.Location = New System.Drawing.Point(105, 99)
        Me.cbxBank.Name = "cbxBank"
        Me.cbxBank.Size = New System.Drawing.Size(256, 21)
        Me.cbxBank.TabIndex = 42
        '
        'BindingSourceBank
        '
        Me.BindingSourceBank.DataMember = "bank"
        Me.BindingSourceBank.DataSource = Me.DataSet_Lab
        '
        'cbxPembayaranFee
        '
        Me.cbxPembayaranFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPembayaranFee.FormattingEnabled = True
        Me.cbxPembayaranFee.Items.AddRange(New Object() {"cash", "credit", "transfer"})
        Me.cbxPembayaranFee.Location = New System.Drawing.Point(104, 63)
        Me.cbxPembayaranFee.Name = "cbxPembayaranFee"
        Me.cbxPembayaranFee.Size = New System.Drawing.Size(72, 21)
        Me.cbxPembayaranFee.TabIndex = 37
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnTutup)
        Me.GroupBox3.Controls.Add(Me.btnSimpan)
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Location = New System.Drawing.Point(371, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 69)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controls"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(164, 21)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(63, 35)
        Me.btnTutup.TabIndex = 30
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(9, 22)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(63, 35)
        Me.btnSimpan.TabIndex = 27
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(87, 22)
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 639)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Keterangan"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 683)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Diperbaharui"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(105, 631)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKeterangan.Size = New System.Drawing.Size(492, 34)
        Me.txtKeterangan.TabIndex = 44
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(4, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(185, 31)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Master Dokter"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(519, 17)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(93, 31)
        Me.lblTime.TabIndex = 46
        '
        'Timer1
        '
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(268, 17)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(245, 31)
        Me.lblDate.TabIndex = 48
        '
        'OpenFilePhoto
        '
        Me.OpenFilePhoto.FileName = "Photo"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(103, 683)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 14)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "oleh"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(373, 683)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 14)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "selesai jam"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(502, 683)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(19, 14)
        Me.Label29.TabIndex = 53
        Me.Label29.Text = "tgl"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(250, 683)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 14)
        Me.Label24.TabIndex = 55
        Me.Label24.Text = "mulai jam"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDirevisiOleh
        '
        Me.lblDirevisiOleh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDirevisiOleh.Location = New System.Drawing.Point(131, 680)
        Me.lblDirevisiOleh.Name = "lblDirevisiOleh"
        Me.lblDirevisiOleh.Size = New System.Drawing.Size(108, 21)
        Me.lblDirevisiOleh.TabIndex = 43
        Me.lblDirevisiOleh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamMulaiRevisi
        '
        Me.lblJamMulaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamMulaiRevisi.Location = New System.Drawing.Point(306, 680)
        Me.lblJamMulaiRevisi.Name = "lblJamMulaiRevisi"
        Me.lblJamMulaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamMulaiRevisi.TabIndex = 44
        Me.lblJamMulaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamSelesaiRevisi
        '
        Me.lblJamSelesaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamSelesaiRevisi.Location = New System.Drawing.Point(435, 681)
        Me.lblJamSelesaiRevisi.Name = "lblJamSelesaiRevisi"
        Me.lblJamSelesaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamSelesaiRevisi.TabIndex = 46
        Me.lblJamSelesaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTglRevisi
        '
        Me.lblTglRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTglRevisi.Location = New System.Drawing.Point(523, 681)
        Me.lblTglRevisi.Name = "lblTglRevisi"
        Me.lblTglRevisi.Size = New System.Drawing.Size(74, 18)
        Me.lblTglRevisi.TabIndex = 47
        Me.lblTglRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableAdapterKecamatan
        '
        Me.TableAdapterKecamatan.ClearBeforeFill = True
        '
        'TableAdapterProvinsi
        '
        Me.TableAdapterProvinsi.ClearBeforeFill = True
        '
        'TableAdapterKabupaten
        '
        Me.TableAdapterKabupaten.ClearBeforeFill = True
        '
        'TableAdapterBank
        '
        Me.TableAdapterBank.ClearBeforeFill = True
        '
        'TableAdapterSpesialisasi
        '
        Me.TableAdapterSpesialisasi.ClearBeforeFill = True
        '
        'BindingSourceCaraBayar
        '
        Me.BindingSourceCaraBayar.DataMember = "cara_bayar"
        Me.BindingSourceCaraBayar.DataSource = Me.DataSet_Lab
        '
        'TableAdapterCaraBayar
        '
        Me.TableAdapterCaraBayar.ClearBeforeFill = True
        '
        'dokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 707)
        Me.Controls.Add(Me.lblTglRevisi)
        Me.Controls.Add(Me.lblJamSelesaiRevisi)
        Me.Controls.Add(Me.lblJamMulaiRevisi)
        Me.Controls.Add(Me.lblDirevisiOleh)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "dokter"
        Me.Text = "Dokter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSourceProvinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSpesialisasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceKabupaten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BindingSourceBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.BindingSourceCaraBayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents pbxPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cbxGolonganDarah As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxSpesialisasi As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtTlpSelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTlpRumah As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbxKecamatan As System.Windows.Forms.ComboBox
    Friend WithEvents cbxKabupaten As System.Windows.Forms.ComboBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents cbxRhesus As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbxJenKel As System.Windows.Forms.ComboBox
    Friend WithEvents txtAtasNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNoRekening As System.Windows.Forms.TextBox
    Friend WithEvents cbxBank As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPembayaranFee As System.Windows.Forms.ComboBox
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents LabDataSet As laboratorium.LabDataSet
    Friend WithEvents BindingSourceSpesialisasi As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceBank As System.Windows.Forms.BindingSource
    Friend WithEvents cbxProvinsi As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BindingSourceProvinsi As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceKabupaten As System.Windows.Forms.BindingSource
    Friend WithEvents OpenFilePhoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblDirevisiOleh As System.Windows.Forms.Label
    Friend WithEvents lblJamMulaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamSelesaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblTglRevisi As System.Windows.Forms.Label
    Friend WithEvents txtEmpty As System.Windows.Forms.TextBox
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents TableAdapterKecamatan As laboratorium.DataSet_LabTableAdapters.kecamatanTableAdapter
    Friend WithEvents TableAdapterProvinsi As laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter
    Friend WithEvents TableAdapterKabupaten As laboratorium.DataSet_LabTableAdapters.kabupatenTableAdapter
    Friend WithEvents TableAdapterBank As laboratorium.DataSet_LabTableAdapters.bankTableAdapter
    Friend WithEvents TableAdapterSpesialisasi As laboratorium.DataSet_LabTableAdapters.spesialisasiTableAdapter
    Friend WithEvents BindingSourceCaraBayar As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterCaraBayar As laboratorium.DataSet_LabTableAdapters.cara_bayarTableAdapter
End Class
