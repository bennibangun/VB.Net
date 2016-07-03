<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pasien
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
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbxPekerjaan = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbxTempatLahir = New System.Windows.Forms.ComboBox()
        Me.BindingSourceProvinsi = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cbxStatusPasien = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtEmpty = New System.Windows.Forms.TextBox()
        Me.cbxProvinsi = New System.Windows.Forms.ComboBox()
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
        Me.cbxPendidikan = New System.Windows.Forms.ComboBox()
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
        Me.lblTglRevisi = New System.Windows.Forms.Label()
        Me.lblJamSelesaiRevisi = New System.Windows.Forms.Label()
        Me.lblJamMulaiRevisi = New System.Windows.Forms.Label()
        Me.lblDirevisiOleh = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TableAdapterProvinsi = New laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.TableAdapterBank = New laboratorium.DataSet_LabTableAdapters.bankTableAdapter()
        Me.OpenFilePhoto = New System.Windows.Forms.OpenFileDialog()
        Me.TableAdapterKabupaten = New laboratorium.DataSet_LabTableAdapters.kabupatenTableAdapter()
        Me.TableAdapterKecamatan = New laboratorium.DataSet_LabTableAdapters.kecamatanTableAdapter()
        Me.TableAdapterCaraBayar = New laboratorium.DataSet_LabTableAdapters.cara_bayarTableAdapter()
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSourceProvinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(187, 31)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Master Pasien"
        '
        'BankBindingSource
        '
        Me.BankBindingSource.DataMember = "bank"
        Me.BankBindingSource.DataSource = Me.DataSet_Lab
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
        Me.GroupBox3.Location = New System.Drawing.Point(432, 284)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 69)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controls"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(160, 23)
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
        Me.btnHapus.Location = New System.Drawing.Point(85, 22)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(63, 35)
        Me.btnHapus.TabIndex = 29
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.cbxPekerjaan)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.cbxTempatLahir)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cbxStatusPasien)
        Me.GroupBox1.Controls.Add(Me.Label26)
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
        Me.GroupBox1.Controls.Add(Me.cbxPendidikan)
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 436)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identitas Dokter"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(103, 407)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(222, 20)
        Me.txtEmail.TabIndex = 51
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(15, 410)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(35, 13)
        Me.Label32.TabIndex = 50
        Me.Label32.Text = "E-mail"
        '
        'cbxPekerjaan
        '
        Me.cbxPekerjaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPekerjaan.FormattingEnabled = True
        Me.cbxPekerjaan.Items.AddRange(New Object() {"Akuntan", "Dokter", "Guru", "Insinyur", "Nelayan", "Ojek", "Perawat", "Pegawai Negri", "Pegawai Swasta", "Quality Control", "Wiraswasta"})
        Me.cbxPekerjaan.Location = New System.Drawing.Point(280, 188)
        Me.cbxPekerjaan.Name = "cbxPekerjaan"
        Me.cbxPekerjaan.Size = New System.Drawing.Size(118, 21)
        Me.cbxPekerjaan.TabIndex = 49
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(217, 193)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 13)
        Me.Label31.TabIndex = 48
        Me.Label31.Text = "Pekerjaan"
        '
        'cbxTempatLahir
        '
        Me.cbxTempatLahir.DataSource = Me.BindingSourceProvinsi
        Me.cbxTempatLahir.DisplayMember = "nama_provinsi"
        Me.cbxTempatLahir.FormattingEnabled = True
        Me.cbxTempatLahir.Location = New System.Drawing.Point(103, 120)
        Me.cbxTempatLahir.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTempatLahir.Name = "cbxTempatLahir"
        Me.cbxTempatLahir.Size = New System.Drawing.Size(222, 21)
        Me.cbxTempatLahir.TabIndex = 47
        '
        'BindingSourceProvinsi
        '
        Me.BindingSourceProvinsi.DataMember = "provinsi"
        Me.BindingSourceProvinsi.DataSource = Me.DataSet_Lab
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(12, 123)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 13)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "Tempat Lahir"
        '
        'cbxStatusPasien
        '
        Me.cbxStatusPasien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatusPasien.FormattingEnabled = True
        Me.cbxStatusPasien.Items.AddRange(New Object() {"Tn", "Ny", "Sdr", "Sdr/i"})
        Me.cbxStatusPasien.Location = New System.Drawing.Point(104, 86)
        Me.cbxStatusPasien.Name = "cbxStatusPasien"
        Me.cbxStatusPasien.Size = New System.Drawing.Size(60, 21)
        Me.cbxStatusPasien.TabIndex = 45
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(13, 91)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 13)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "Status"
        '
        'txtEmpty
        '
        Me.txtEmpty.Location = New System.Drawing.Point(415, 121)
        Me.txtEmpty.Name = "txtEmpty"
        Me.txtEmpty.Size = New System.Drawing.Size(120, 20)
        Me.txtEmpty.TabIndex = 43
        Me.txtEmpty.Visible = False
        '
        'cbxProvinsi
        '
        Me.cbxProvinsi.FormattingEnabled = True
        Me.cbxProvinsi.Location = New System.Drawing.Point(104, 271)
        Me.cbxProvinsi.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxProvinsi.Name = "cbxProvinsi"
        Me.cbxProvinsi.Size = New System.Drawing.Size(222, 21)
        Me.cbxProvinsi.TabIndex = 42
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 273)
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
        Me.cbxJenKel.Location = New System.Drawing.Point(283, 84)
        Me.cbxJenKel.Name = "cbxJenKel"
        Me.cbxJenKel.Size = New System.Drawing.Size(55, 21)
        Me.cbxJenKel.TabIndex = 40
        '
        'txtTlpSelular
        '
        Me.txtTlpSelular.Location = New System.Drawing.Point(353, 374)
        Me.txtTlpSelular.Name = "txtTlpSelular"
        Me.txtTlpSelular.Size = New System.Drawing.Size(157, 20)
        Me.txtTlpSelular.TabIndex = 39
        '
        'txtTlpRumah
        '
        Me.txtTlpRumah.Location = New System.Drawing.Point(148, 374)
        Me.txtTlpRumah.Name = "txtTlpRumah"
        Me.txtTlpRumah.Size = New System.Drawing.Size(131, 20)
        Me.txtTlpRumah.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(103, 376)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 13)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Rumah"
        '
        'cbxKecamatan
        '
        Me.cbxKecamatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKecamatan.FormattingEnabled = True
        Me.cbxKecamatan.Location = New System.Drawing.Point(105, 340)
        Me.cbxKecamatan.Name = "cbxKecamatan"
        Me.cbxKecamatan.Size = New System.Drawing.Size(223, 21)
        Me.cbxKecamatan.TabIndex = 36
        '
        'cbxKabupaten
        '
        Me.cbxKabupaten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKabupaten.FormattingEnabled = True
        Me.cbxKabupaten.Location = New System.Drawing.Point(104, 306)
        Me.cbxKabupaten.Name = "cbxKabupaten"
        Me.cbxKabupaten.Size = New System.Drawing.Size(222, 21)
        Me.cbxKabupaten.TabIndex = 35
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(104, 225)
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
        Me.cbxRhesus.Location = New System.Drawing.Point(209, 155)
        Me.cbxRhesus.Name = "cbxRhesus"
        Me.cbxRhesus.Size = New System.Drawing.Size(70, 21)
        Me.cbxRhesus.TabIndex = 33
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(161, 158)
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
        Me.cbxGolonganDarah.Location = New System.Drawing.Point(104, 155)
        Me.cbxGolonganDarah.Name = "cbxGolonganDarah"
        Me.cbxGolonganDarah.Size = New System.Drawing.Size(39, 21)
        Me.cbxGolonganDarah.TabIndex = 30
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.Location = New System.Drawing.Point(415, 120)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(120, 20)
        Me.dtpTglLahir.TabIndex = 29
        '
        'cbxPendidikan
        '
        Me.cbxPendidikan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPendidikan.FormattingEnabled = True
        Me.cbxPendidikan.Items.AddRange(New Object() {"SD", "SMP", "SMU", "Sarjana (S1)", "Master (S2)", "Doktor (S3)"})
        Me.cbxPendidikan.Location = New System.Drawing.Point(103, 191)
        Me.cbxPendidikan.Name = "cbxPendidikan"
        Me.cbxPendidikan.Size = New System.Drawing.Size(96, 21)
        Me.cbxPendidikan.TabIndex = 28
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(104, 55)
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
        Me.btnSearch.Location = New System.Drawing.Point(566, 147)
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
        Me.pbxPhoto.Location = New System.Drawing.Point(564, 19)
        Me.pbxPhoto.Name = "pbxPhoto"
        Me.pbxPhoto.Size = New System.Drawing.Size(100, 121)
        Me.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxPhoto.TabIndex = 23
        Me.pbxPhoto.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(209, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Jenis Kelamin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Selular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Pendidikan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(12, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Kecamatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Golongan Darah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Kabupaten"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Alamat"
        '
        'lblTglRevisi
        '
        Me.lblTglRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTglRevisi.Location = New System.Drawing.Point(599, 552)
        Me.lblTglRevisi.Name = "lblTglRevisi"
        Me.lblTglRevisi.Size = New System.Drawing.Size(74, 18)
        Me.lblTglRevisi.TabIndex = 60
        Me.lblTglRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamSelesaiRevisi
        '
        Me.lblJamSelesaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamSelesaiRevisi.Location = New System.Drawing.Point(483, 552)
        Me.lblJamSelesaiRevisi.Name = "lblJamSelesaiRevisi"
        Me.lblJamSelesaiRevisi.Size = New System.Drawing.Size(67, 18)
        Me.lblJamSelesaiRevisi.TabIndex = 59
        Me.lblJamSelesaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamMulaiRevisi
        '
        Me.lblJamMulaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamMulaiRevisi.Location = New System.Drawing.Point(331, 551)
        Me.lblJamMulaiRevisi.Name = "lblJamMulaiRevisi"
        Me.lblJamMulaiRevisi.Size = New System.Drawing.Size(67, 18)
        Me.lblJamMulaiRevisi.TabIndex = 58
        Me.lblJamMulaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDirevisiOleh
        '
        Me.lblDirevisiOleh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDirevisiOleh.Location = New System.Drawing.Point(132, 549)
        Me.lblDirevisiOleh.Name = "lblDirevisiOleh"
        Me.lblDirevisiOleh.Size = New System.Drawing.Size(129, 21)
        Me.lblDirevisiOleh.TabIndex = 57
        Me.lblDirevisiOleh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(273, 553)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 14)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "mulai jam"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(560, 554)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(36, 14)
        Me.Label29.TabIndex = 63
        Me.Label29.Text = "tgl"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(416, 553)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 14)
        Me.Label28.TabIndex = 62
        Me.Label28.Text = "selesai jam"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(104, 554)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 14)
        Me.Label27.TabIndex = 61
        Me.Label27.Text = "oleh"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 554)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Diperbaharui"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(105, 505)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKeterangan.Size = New System.Drawing.Size(571, 34)
        Me.txtKeterangan.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 513)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Keterangan"
        '
        'TableAdapterProvinsi
        '
        Me.TableAdapterProvinsi.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(309, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(245, 31)
        Me.lblDate.TabIndex = 68
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(560, 16)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(93, 31)
        Me.lblTime.TabIndex = 67
        '
        'TableAdapterBank
        '
        Me.TableAdapterBank.ClearBeforeFill = True
        '
        'OpenFilePhoto
        '
        Me.OpenFilePhoto.FileName = "Photo"
        '
        'TableAdapterKabupaten
        '
        Me.TableAdapterKabupaten.ClearBeforeFill = True
        '
        'TableAdapterKecamatan
        '
        Me.TableAdapterKecamatan.ClearBeforeFill = True
        '
        'TableAdapterCaraBayar
        '
        Me.TableAdapterCaraBayar.ClearBeforeFill = True
        '
        'pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 573)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblTglRevisi)
        Me.Controls.Add(Me.lblJamSelesaiRevisi)
        Me.Controls.Add(Me.lblJamMulaiRevisi)
        Me.Controls.Add(Me.lblDirevisiOleh)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label23)
        Me.Name = "pasien"
        Me.Text = "pasien"
        CType(Me.BankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSourceProvinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmpty As System.Windows.Forms.TextBox
    Friend WithEvents cbxProvinsi As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbxJenKel As System.Windows.Forms.ComboBox
    Friend WithEvents txtTlpSelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTlpRumah As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbxKecamatan As System.Windows.Forms.ComboBox
    Friend WithEvents cbxKabupaten As System.Windows.Forms.ComboBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents cbxRhesus As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cbxGolonganDarah As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxPendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents pbxPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTglRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamSelesaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamMulaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblDirevisiOleh As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbxStatusPasien As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cbxTempatLahir As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents BindingSourceProvinsi As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterProvinsi As laboratorium.DataSet_LabTableAdapters.provinsiTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cbxPekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents BankBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterBank As laboratorium.DataSet_LabTableAdapters.bankTableAdapter
    Friend WithEvents OpenFilePhoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TableAdapterKabupaten As laboratorium.DataSet_LabTableAdapters.kabupatenTableAdapter
    Friend WithEvents TableAdapterKecamatan As laboratorium.DataSet_LabTableAdapters.kecamatanTableAdapter
    Friend WithEvents TableAdapterCaraBayar As laboratorium.DataSet_LabTableAdapters.cara_bayarTableAdapter
End Class
