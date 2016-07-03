<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_reagen_on_board
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
        Me.txtKodeReagen = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtThn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBln = New System.Windows.Forms.TextBox()
        Me.txtHari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPeringatanExpired = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtEmpty = New System.Windows.Forms.TextBox()
        Me.dtpExpiredDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomorBatch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomorLab = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxNamaReagen = New System.Windows.Forms.ComboBox()
        Me.BindingSourceNamaReagen = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.txtNomorLot = New System.Windows.Forms.TextBox()
        Me.cbxKelompok = New System.Windows.Forms.ComboBox()
        Me.BindingSourceKelompok = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxSupplier = New System.Windows.Forms.ComboBox()
        Me.BindingSourceSupplier = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbxVolume = New System.Windows.Forms.GroupBox()
        Me.txtPeringatanJumlah = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtR4 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtR3 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtR2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtR1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTglRevisi = New System.Windows.Forms.Label()
        Me.lblJamSelesaiRevisi = New System.Windows.Forms.Label()
        Me.lblJamMulaiRevisi = New System.Windows.Forms.Label()
        Me.lblDirevisiOleh = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BindingSourceReagenOnBoard = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterReagenOnBoard = New laboratorium.DataSet_LabTableAdapters.reagen_on_boardTableAdapter()
        Me.TableAdapterNamaReagen = New laboratorium.DataSet_LabTableAdapters.nama_reagenTableAdapter()
        Me.TableAdapterSupplier = New laboratorium.DataSet_LabTableAdapters.supplierTableAdapter()
        Me.TableAdapterMasterKelompok = New laboratorium.DataSet_LabTableAdapters.master_kelompokTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingSourceNamaReagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxVolume.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BindingSourceReagenOnBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKodeReagen)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtPeringatanExpired)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtEmpty)
        Me.GroupBox1.Controls.Add(Me.dtpExpiredDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNomorBatch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNomorLab)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbxNamaReagen)
        Me.GroupBox1.Controls.Add(Me.txtNomorLot)
        Me.GroupBox1.Controls.Add(Me.cbxKelompok)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cbxSupplier)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 261)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Reagen On Board"
        '
        'txtKodeReagen
        '
        Me.txtKodeReagen.Location = New System.Drawing.Point(107, 22)
        Me.txtKodeReagen.Name = "txtKodeReagen"
        Me.txtKodeReagen.Size = New System.Drawing.Size(175, 20)
        Me.txtKodeReagen.TabIndex = 61
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtThn)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtBln)
        Me.GroupBox2.Controls.Add(Me.txtHari)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(312, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 54)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sisa waktu"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Tahun"
        '
        'txtThn
        '
        Me.txtThn.Location = New System.Drawing.Point(10, 24)
        Me.txtThn.Name = "txtThn"
        Me.txtThn.Size = New System.Drawing.Size(36, 20)
        Me.txtThn.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Bulan"
        '
        'txtBln
        '
        Me.txtBln.Location = New System.Drawing.Point(108, 24)
        Me.txtBln.Name = "txtBln"
        Me.txtBln.Size = New System.Drawing.Size(36, 20)
        Me.txtBln.TabIndex = 39
        '
        'txtHari
        '
        Me.txtHari.Location = New System.Drawing.Point(204, 25)
        Me.txtHari.Name = "txtHari"
        Me.txtHari.Size = New System.Drawing.Size(36, 20)
        Me.txtHari.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(243, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Hari"
        '
        'txtPeringatanExpired
        '
        Me.txtPeringatanExpired.Location = New System.Drawing.Point(107, 230)
        Me.txtPeringatanExpired.Name = "txtPeringatanExpired"
        Me.txtPeringatanExpired.Size = New System.Drawing.Size(120, 20)
        Me.txtPeringatanExpired.TabIndex = 59
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(10, 232)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 13)
        Me.Label30.TabIndex = 58
        Me.Label30.Text = "Peringatan Expired"
        '
        'txtEmpty
        '
        Me.txtEmpty.Location = New System.Drawing.Point(107, 193)
        Me.txtEmpty.Name = "txtEmpty"
        Me.txtEmpty.Size = New System.Drawing.Size(120, 20)
        Me.txtEmpty.TabIndex = 52
        Me.txtEmpty.Visible = False
        '
        'dtpExpiredDate
        '
        Me.dtpExpiredDate.Location = New System.Drawing.Point(107, 193)
        Me.dtpExpiredDate.Name = "dtpExpiredDate"
        Me.dtpExpiredDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpExpiredDate.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tanggal Expired"
        '
        'txtNomorBatch
        '
        Me.txtNomorBatch.Location = New System.Drawing.Point(107, 160)
        Me.txtNomorBatch.Name = "txtNomorBatch"
        Me.txtNomorBatch.Size = New System.Drawing.Size(175, 20)
        Me.txtNomorBatch.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Nomor Batch"
        '
        'txtNomorLab
        '
        Me.txtNomorLab.Location = New System.Drawing.Point(107, 125)
        Me.txtNomorLab.Name = "txtNomorLab"
        Me.txtNomorLab.Size = New System.Drawing.Size(175, 20)
        Me.txtNomorLab.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Nomor Lab"
        '
        'cbxNamaReagen
        '
        Me.cbxNamaReagen.DataSource = Me.BindingSourceNamaReagen
        Me.cbxNamaReagen.DisplayMember = "jenis_reagen"
        Me.cbxNamaReagen.FormattingEnabled = True
        Me.cbxNamaReagen.Location = New System.Drawing.Point(107, 56)
        Me.cbxNamaReagen.Name = "cbxNamaReagen"
        Me.cbxNamaReagen.Size = New System.Drawing.Size(175, 21)
        Me.cbxNamaReagen.TabIndex = 44
        '
        'BindingSourceNamaReagen
        '
        Me.BindingSourceNamaReagen.DataMember = "nama_reagen"
        Me.BindingSourceNamaReagen.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNomorLot
        '
        Me.txtNomorLot.Location = New System.Drawing.Point(107, 91)
        Me.txtNomorLot.Name = "txtNomorLot"
        Me.txtNomorLot.Size = New System.Drawing.Size(175, 20)
        Me.txtNomorLot.TabIndex = 43
        '
        'cbxKelompok
        '
        Me.cbxKelompok.DataSource = Me.BindingSourceKelompok
        Me.cbxKelompok.DisplayMember = "kelompok"
        Me.cbxKelompok.FormattingEnabled = True
        Me.cbxKelompok.Location = New System.Drawing.Point(412, 56)
        Me.cbxKelompok.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxKelompok.Name = "cbxKelompok"
        Me.cbxKelompok.Size = New System.Drawing.Size(182, 21)
        Me.cbxKelompok.TabIndex = 42
        '
        'BindingSourceKelompok
        '
        Me.BindingSourceKelompok.DataMember = "master_kelompok"
        Me.BindingSourceKelompok.DataSource = Me.DataSet_Lab
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(353, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Kelompok"
        '
        'cbxSupplier
        '
        Me.cbxSupplier.DataSource = Me.BindingSourceSupplier
        Me.cbxSupplier.DisplayMember = "nama_kontak"
        Me.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(412, 93)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(182, 21)
        Me.cbxSupplier.TabIndex = 35
        '
        'BindingSourceSupplier
        '
        Me.BindingSourceSupplier.DataMember = "supplier"
        Me.BindingSourceSupplier.DataSource = Me.DataSet_Lab
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(14, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Kode Reagen"
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
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nama Reagen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nomor LOT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(353, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Supplier"
        '
        'gbxVolume
        '
        Me.gbxVolume.Controls.Add(Me.txtPeringatanJumlah)
        Me.gbxVolume.Controls.Add(Me.Label26)
        Me.gbxVolume.Controls.Add(Me.GroupBox3)
        Me.gbxVolume.Controls.Add(Me.Label17)
        Me.gbxVolume.Controls.Add(Me.txtR4)
        Me.gbxVolume.Controls.Add(Me.Label18)
        Me.gbxVolume.Controls.Add(Me.Label14)
        Me.gbxVolume.Controls.Add(Me.txtR3)
        Me.gbxVolume.Controls.Add(Me.Label15)
        Me.gbxVolume.Controls.Add(Me.Label12)
        Me.gbxVolume.Controls.Add(Me.txtR2)
        Me.gbxVolume.Controls.Add(Me.Label13)
        Me.gbxVolume.Controls.Add(Me.Label11)
        Me.gbxVolume.Controls.Add(Me.txtR1)
        Me.gbxVolume.Controls.Add(Me.Label10)
        Me.gbxVolume.Location = New System.Drawing.Point(0, 330)
        Me.gbxVolume.Name = "gbxVolume"
        Me.gbxVolume.Size = New System.Drawing.Size(617, 176)
        Me.gbxVolume.TabIndex = 56
        Me.gbxVolume.TabStop = False
        Me.gbxVolume.Text = "Volume"
        '
        'txtPeringatanJumlah
        '
        Me.txtPeringatanJumlah.Location = New System.Drawing.Point(114, 147)
        Me.txtPeringatanJumlah.Name = "txtPeringatanJumlah"
        Me.txtPeringatanJumlah.Size = New System.Drawing.Size(172, 20)
        Me.txtPeringatanJumlah.TabIndex = 74
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 150)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(91, 13)
        Me.Label26.TabIndex = 73
        Me.Label26.Text = "Peringatan jumlah"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnTutup)
        Me.GroupBox3.Controls.Add(Me.btnSimpan)
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Location = New System.Drawing.Point(350, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 69)
        Me.GroupBox3.TabIndex = 57
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(215, 118)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 13)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "µ l"
        '
        'txtR4
        '
        Me.txtR4.Location = New System.Drawing.Point(114, 115)
        Me.txtR4.Name = "txtR4"
        Me.txtR4.Size = New System.Drawing.Size(95, 20)
        Me.txtR4.TabIndex = 63
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 13)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "R4"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(215, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 13)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "µ l"
        '
        'txtR3
        '
        Me.txtR3.Location = New System.Drawing.Point(114, 85)
        Me.txtR3.Name = "txtR3"
        Me.txtR3.Size = New System.Drawing.Size(95, 20)
        Me.txtR3.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "R3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(215, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "µ l"
        '
        'txtR2
        '
        Me.txtR2.Location = New System.Drawing.Point(114, 53)
        Me.txtR2.Name = "txtR2"
        Me.txtR2.Size = New System.Drawing.Size(95, 20)
        Me.txtR2.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "R2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(215, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "µ l"
        '
        'txtR1
        '
        Me.txtR1.Location = New System.Drawing.Point(114, 22)
        Me.txtR1.Name = "txtR1"
        Me.txtR1.Size = New System.Drawing.Size(95, 20)
        Me.txtR1.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "R1"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(4, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(231, 31)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Reagen On Board"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(268, 8)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(245, 31)
        Me.lblDate.TabIndex = 50
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(519, 8)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(93, 31)
        Me.lblTime.TabIndex = 49
        '
        'lblTglRevisi
        '
        Me.lblTglRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTglRevisi.Location = New System.Drawing.Point(528, 569)
        Me.lblTglRevisi.Name = "lblTglRevisi"
        Me.lblTglRevisi.Size = New System.Drawing.Size(74, 18)
        Me.lblTglRevisi.TabIndex = 62
        Me.lblTglRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJamSelesaiRevisi
        '
        Me.lblJamSelesaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamSelesaiRevisi.Location = New System.Drawing.Point(440, 569)
        Me.lblJamSelesaiRevisi.Name = "lblJamSelesaiRevisi"
        Me.lblJamSelesaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamSelesaiRevisi.TabIndex = 61
        Me.lblJamSelesaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamMulaiRevisi
        '
        Me.lblJamMulaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamMulaiRevisi.Location = New System.Drawing.Point(311, 568)
        Me.lblJamMulaiRevisi.Name = "lblJamMulaiRevisi"
        Me.lblJamMulaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamMulaiRevisi.TabIndex = 59
        Me.lblJamMulaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDirevisiOleh
        '
        Me.lblDirevisiOleh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDirevisiOleh.Location = New System.Drawing.Point(136, 568)
        Me.lblDirevisiOleh.Name = "lblDirevisiOleh"
        Me.lblDirevisiOleh.Size = New System.Drawing.Size(108, 21)
        Me.lblDirevisiOleh.TabIndex = 58
        Me.lblDirevisiOleh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(255, 571)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 14)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "mulai jam"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(507, 571)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(19, 14)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "tgl"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(378, 571)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 14)
        Me.Label28.TabIndex = 64
        Me.Label28.Text = "selesai jam"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(108, 571)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 14)
        Me.Label27.TabIndex = 63
        Me.Label27.Text = "oleh"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(110, 514)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKeterangan.Size = New System.Drawing.Size(492, 34)
        Me.txtKeterangan.TabIndex = 60
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 571)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Diperbaharui"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(17, 522)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 56
        Me.Label25.Text = "Keterangan"
        '
        'BindingSourceReagenOnBoard
        '
        Me.BindingSourceReagenOnBoard.DataMember = "reagen_on_board"
        Me.BindingSourceReagenOnBoard.DataSource = Me.DataSet_Lab
        '
        'TableAdapterReagenOnBoard
        '
        Me.TableAdapterReagenOnBoard.ClearBeforeFill = True
        '
        'TableAdapterNamaReagen
        '
        Me.TableAdapterNamaReagen.ClearBeforeFill = True
        '
        'TableAdapterSupplier
        '
        Me.TableAdapterSupplier.ClearBeforeFill = True
        '
        'TableAdapterMasterKelompok
        '
        Me.TableAdapterMasterKelompok.ClearBeforeFill = True
        '
        'data_reagen_on_board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 594)
        Me.Controls.Add(Me.lblTglRevisi)
        Me.Controls.Add(Me.lblJamSelesaiRevisi)
        Me.Controls.Add(Me.lblJamMulaiRevisi)
        Me.Controls.Add(Me.lblDirevisiOleh)
        Me.Controls.Add(Me.gbxVolume)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "data_reagen_on_board"
        Me.Text = "Master Reagen On Board"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BindingSourceNamaReagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxVolume.ResumeLayout(False)
        Me.gbxVolume.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.BindingSourceReagenOnBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNomorLot As System.Windows.Forms.TextBox
    Friend WithEvents cbxKelompok As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtBln As System.Windows.Forms.TextBox
    Friend WithEvents txtThn As System.Windows.Forms.TextBox
    Friend WithEvents cbxSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbxNamaReagen As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtNomorLab As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNomorBatch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpExpiredDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEmpty As System.Windows.Forms.TextBox
    Friend WithEvents gbxVolume As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtR4 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtR3 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtR2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtR1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtHari As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPeringatanJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblTglRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamSelesaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamMulaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblDirevisiOleh As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents txtPeringatanExpired As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents BindingSourceReagenOnBoard As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterReagenOnBoard As laboratorium.DataSet_LabTableAdapters.reagen_on_boardTableAdapter
    Friend WithEvents BindingSourceNamaReagen As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterNamaReagen As laboratorium.DataSet_LabTableAdapters.nama_reagenTableAdapter
    Friend WithEvents BindingSourceKelompok As System.Windows.Forms.BindingSource
    'Friend WithEvents TableAdapterKelompok As laboratorium.DataSet_LabTableAdapters.kelompokTableAdapter
    Friend WithEvents BindingSourceSupplier As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterSupplier As laboratorium.DataSet_LabTableAdapters.supplierTableAdapter
    Friend WithEvents TableAdapterMasterKelompok As laboratorium.DataSet_LabTableAdapters.master_kelompokTableAdapter
    Friend WithEvents txtKodeReagen As System.Windows.Forms.TextBox
End Class
