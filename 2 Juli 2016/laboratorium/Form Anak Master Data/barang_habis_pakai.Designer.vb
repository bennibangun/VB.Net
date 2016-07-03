<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barang_habis_pakai
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHari = New System.Windows.Forms.TextBox()
        Me.txtBulan = New System.Windows.Forms.TextBox()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmpty = New System.Windows.Forms.TextBox()
        Me.dtpExpired = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIsi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSatuanIsi = New System.Windows.Forms.ComboBox()
        Me.BindingSourceSatuanIsi = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Lab = New laboratorium.DataSet_Lab()
        Me.txtKuantitas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboJenis = New System.Windows.Forms.ComboBox()
        Me.BindingSourceJenisBarangHabisPakai = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPeringatanExpired = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboSatuanKuantitas = New System.Windows.Forms.ComboBox()
        Me.BindingSourceSatuanKuantitas = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblIDBrgHabisPakai = New System.Windows.Forms.Label()
        Me.txtNomorBarcode = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BindingSourceBarangHabisPakai = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterBarangHabisPakai = New laboratorium.DataSet_LabTableAdapters.barang_habis_pakaiTableAdapter()
        Me.lblTglRevisi = New System.Windows.Forms.Label()
        Me.lblJamSelesaiRevisi = New System.Windows.Forms.Label()
        Me.lblJamMulaiRevisi = New System.Windows.Forms.Label()
        Me.lblDirevisiOleh = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SupplierTableAdapter = New laboratorium.DataSet_LabTableAdapters.supplierTableAdapter()
        Me.TableAdapterJenisBarangHabisPakai = New laboratorium.DataSet_LabTableAdapters.jenis_barang_habis_pakaiTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableAdapterSatuanKuantitas = New laboratorium.DataSet_LabTableAdapters.satuan_kuantitasTableAdapter()
        Me.TableAdapterSatuanIsi = New laboratorium.DataSet_LabTableAdapters.satuan_isiTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BindingSourceSatuanIsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceJenisBarangHabisPakai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSatuanKuantitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceBarangHabisPakai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(273, 24)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(230, 31)
        Me.lblDate.TabIndex = 101
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(509, 24)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(93, 31)
        Me.lblTime.TabIndex = 100
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(14, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(253, 31)
        Me.Label23.TabIndex = 99
        Me.Label23.Text = "Barang Habis Pakai"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHari)
        Me.GroupBox1.Controls.Add(Me.txtBulan)
        Me.GroupBox1.Controls.Add(Me.txtTahun)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEmpty)
        Me.GroupBox1.Controls.Add(Me.dtpExpired)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIsi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboSatuanIsi)
        Me.GroupBox1.Controls.Add(Me.txtKuantitas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboJenis)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtPeringatanExpired)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cboSatuanKuantitas)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.lblIDBrgHabisPakai)
        Me.GroupBox1.Controls.Add(Me.txtNomorBarcode)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 309)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Barang Habis Pakai"
        '
        'txtHari
        '
        Me.txtHari.Location = New System.Drawing.Point(458, 237)
        Me.txtHari.Name = "txtHari"
        Me.txtHari.ReadOnly = True
        Me.txtHari.Size = New System.Drawing.Size(26, 20)
        Me.txtHari.TabIndex = 62
        Me.txtHari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBulan
        '
        Me.txtBulan.Location = New System.Drawing.Point(380, 239)
        Me.txtBulan.Name = "txtBulan"
        Me.txtBulan.ReadOnly = True
        Me.txtBulan.Size = New System.Drawing.Size(26, 20)
        Me.txtBulan.TabIndex = 61
        Me.txtBulan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(304, 239)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.ReadOnly = True
        Me.txtTahun.Size = New System.Drawing.Size(26, 20)
        Me.txtTahun.TabIndex = 60
        Me.txtTahun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnTutup)
        Me.GroupBox3.Controls.Add(Me.btnSimpan)
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Location = New System.Drawing.Point(360, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 77)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controls"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(172, 26)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(63, 35)
        Me.btnTutup.TabIndex = 30
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(16, 24)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(63, 35)
        Me.btnSimpan.TabIndex = 27
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(95, 24)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(63, 35)
        Me.btnHapus.TabIndex = 29
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(483, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Hari"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(404, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Bulan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Tahun"
        '
        'txtEmpty
        '
        Me.txtEmpty.Location = New System.Drawing.Point(103, 240)
        Me.txtEmpty.Name = "txtEmpty"
        Me.txtEmpty.Size = New System.Drawing.Size(120, 20)
        Me.txtEmpty.TabIndex = 50
        Me.txtEmpty.Visible = False
        '
        'dtpExpired
        '
        Me.dtpExpired.Location = New System.Drawing.Point(103, 240)
        Me.dtpExpired.Name = "dtpExpired"
        Me.dtpExpired.Size = New System.Drawing.Size(120, 20)
        Me.dtpExpired.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Expired"
        '
        'txtIsi
        '
        Me.txtIsi.Location = New System.Drawing.Point(104, 206)
        Me.txtIsi.Name = "txtIsi"
        Me.txtIsi.Size = New System.Drawing.Size(39, 20)
        Me.txtIsi.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Isi"
        '
        'cboSatuanIsi
        '
        Me.cboSatuanIsi.DataSource = Me.BindingSourceSatuanIsi
        Me.cboSatuanIsi.DisplayMember = "nama_satuan_isi"
        Me.cboSatuanIsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSatuanIsi.FormattingEnabled = True
        Me.cboSatuanIsi.Location = New System.Drawing.Point(147, 206)
        Me.cboSatuanIsi.Name = "cboSatuanIsi"
        Me.cboSatuanIsi.Size = New System.Drawing.Size(93, 21)
        Me.cboSatuanIsi.TabIndex = 45
        '
        'BindingSourceSatuanIsi
        '
        Me.BindingSourceSatuanIsi.DataMember = "satuan_isi"
        Me.BindingSourceSatuanIsi.DataSource = Me.DataSet_Lab
        '
        'DataSet_Lab
        '
        Me.DataSet_Lab.DataSetName = "DataSet_Lab"
        Me.DataSet_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtKuantitas
        '
        Me.txtKuantitas.Location = New System.Drawing.Point(105, 170)
        Me.txtKuantitas.Name = "txtKuantitas"
        Me.txtKuantitas.Size = New System.Drawing.Size(39, 20)
        Me.txtKuantitas.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Kuantitas"
        '
        'cboJenis
        '
        Me.cboJenis.DataSource = Me.BindingSourceJenisBarangHabisPakai
        Me.cboJenis.DisplayMember = "jenis"
        Me.cboJenis.FormattingEnabled = True
        Me.cboJenis.Location = New System.Drawing.Point(104, 59)
        Me.cboJenis.Margin = New System.Windows.Forms.Padding(2)
        Me.cboJenis.Name = "cboJenis"
        Me.cboJenis.Size = New System.Drawing.Size(222, 21)
        Me.cboJenis.TabIndex = 42
        '
        'BindingSourceJenisBarangHabisPakai
        '
        Me.BindingSourceJenisBarangHabisPakai.DataMember = "jenis_barang_habis_pakai"
        Me.BindingSourceJenisBarangHabisPakai.DataSource = Me.DataSet_Lab
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 61)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Jenis"
        '
        'txtPeringatanExpired
        '
        Me.txtPeringatanExpired.BackColor = System.Drawing.Color.White
        Me.txtPeringatanExpired.ForeColor = System.Drawing.Color.Red
        Me.txtPeringatanExpired.Location = New System.Drawing.Point(103, 275)
        Me.txtPeringatanExpired.Name = "txtPeringatanExpired"
        Me.txtPeringatanExpired.ReadOnly = True
        Me.txtPeringatanExpired.Size = New System.Drawing.Size(143, 20)
        Me.txtPeringatanExpired.TabIndex = 39
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(239, 243)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Sisa waktu"
        '
        'cboSatuanKuantitas
        '
        Me.cboSatuanKuantitas.DataSource = Me.BindingSourceSatuanKuantitas
        Me.cboSatuanKuantitas.DisplayMember = "nama_satuan_kuantitas"
        Me.cboSatuanKuantitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSatuanKuantitas.FormattingEnabled = True
        Me.cboSatuanKuantitas.Location = New System.Drawing.Point(148, 170)
        Me.cboSatuanKuantitas.Name = "cboSatuanKuantitas"
        Me.cboSatuanKuantitas.Size = New System.Drawing.Size(93, 21)
        Me.cboSatuanKuantitas.TabIndex = 36
        '
        'BindingSourceSatuanKuantitas
        '
        Me.BindingSourceSatuanKuantitas.DataMember = "satuan_kuantitas"
        Me.BindingSourceSatuanKuantitas.DataSource = Me.DataSet_Lab
        '
        'cboSupplier
        '
        Me.cboSupplier.DataSource = Me.SupplierBindingSource
        Me.cboSupplier.DisplayMember = "nama_kontak"
        Me.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(104, 96)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(222, 21)
        Me.cboSupplier.TabIndex = 35
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "supplier"
        Me.SupplierBindingSource.DataSource = Me.DataSet_Lab
        '
        'lblIDBrgHabisPakai
        '
        Me.lblIDBrgHabisPakai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIDBrgHabisPakai.Location = New System.Drawing.Point(104, 23)
        Me.lblIDBrgHabisPakai.Name = "lblIDBrgHabisPakai"
        Me.lblIDBrgHabisPakai.Size = New System.Drawing.Size(134, 21)
        Me.lblIDBrgHabisPakai.TabIndex = 31
        Me.lblIDBrgHabisPakai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNomorBarcode
        '
        Me.txtNomorBarcode.Location = New System.Drawing.Point(104, 134)
        Me.txtNomorBarcode.Name = "txtNomorBarcode"
        Me.txtNomorBarcode.Size = New System.Drawing.Size(134, 20)
        Me.txtNomorBarcode.TabIndex = 27
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
        Me.Label1.Location = New System.Drawing.Point(12, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nomor Barcode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Peringatan Expired"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Supplier"
        '
        'BindingSourceBarangHabisPakai
        '
        Me.BindingSourceBarangHabisPakai.DataMember = "barang_habis_pakai"
        Me.BindingSourceBarangHabisPakai.DataSource = Me.DataSet_Lab
        '
        'TableAdapterBarangHabisPakai
        '
        Me.TableAdapterBarangHabisPakai.ClearBeforeFill = True
        '
        'lblTglRevisi
        '
        Me.lblTglRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTglRevisi.Location = New System.Drawing.Point(518, 457)
        Me.lblTglRevisi.Name = "lblTglRevisi"
        Me.lblTglRevisi.Size = New System.Drawing.Size(80, 18)
        Me.lblTglRevisi.TabIndex = 109
        Me.lblTglRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamSelesaiRevisi
        '
        Me.lblJamSelesaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamSelesaiRevisi.Location = New System.Drawing.Point(419, 457)
        Me.lblJamSelesaiRevisi.Name = "lblJamSelesaiRevisi"
        Me.lblJamSelesaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamSelesaiRevisi.TabIndex = 108
        Me.lblJamSelesaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJamMulaiRevisi
        '
        Me.lblJamMulaiRevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJamMulaiRevisi.Location = New System.Drawing.Point(286, 456)
        Me.lblJamMulaiRevisi.Name = "lblJamMulaiRevisi"
        Me.lblJamMulaiRevisi.Size = New System.Drawing.Size(57, 18)
        Me.lblJamMulaiRevisi.TabIndex = 107
        Me.lblJamMulaiRevisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDirevisiOleh
        '
        Me.lblDirevisiOleh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDirevisiOleh.Location = New System.Drawing.Point(106, 456)
        Me.lblDirevisiOleh.Name = "lblDirevisiOleh"
        Me.lblDirevisiOleh.Size = New System.Drawing.Size(108, 21)
        Me.lblDirevisiOleh.TabIndex = 106
        Me.lblDirevisiOleh.Text = "Susi"
        Me.lblDirevisiOleh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(230, 459)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 14)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "mulai jam"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(488, 459)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(27, 14)
        Me.Label29.TabIndex = 112
        Me.Label29.Text = "tgl"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(357, 459)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 14)
        Me.Label28.TabIndex = 111
        Me.Label28.Text = "selesai jam"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(80, 459)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 14)
        Me.Label27.TabIndex = 110
        Me.Label27.Text = "oleh"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 461)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "Diperbaharui"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(83, 403)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(515, 41)
        Me.txtKeterangan.TabIndex = 105
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 403)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Keterangan"
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterJenisBarangHabisPakai
        '
        Me.TableAdapterJenisBarangHabisPakai.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TableAdapterSatuanKuantitas
        '
        Me.TableAdapterSatuanKuantitas.ClearBeforeFill = True
        '
        'TableAdapterSatuanIsi
        '
        Me.TableAdapterSatuanIsi.ClearBeforeFill = True
        '
        'barang_habis_pakai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 486)
        Me.Controls.Add(Me.lblTglRevisi)
        Me.Controls.Add(Me.lblJamSelesaiRevisi)
        Me.Controls.Add(Me.lblJamMulaiRevisi)
        Me.Controls.Add(Me.lblDirevisiOleh)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label23)
        Me.Name = "barang_habis_pakai"
        Me.Text = "Barang Habis Pakai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.BindingSourceSatuanIsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceJenisBarangHabisPakai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSatuanKuantitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceBarangHabisPakai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIsi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSatuanIsi As System.Windows.Forms.ComboBox
    Friend WithEvents txtKuantitas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboJenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtPeringatanExpired As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboSatuanKuantitas As System.Windows.Forms.ComboBox
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents lblIDBrgHabisPakai As System.Windows.Forms.Label
    Friend WithEvents txtNomorBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataSet_Lab As laboratorium.DataSet_Lab
    Friend WithEvents BindingSourceBarangHabisPakai As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterBarangHabisPakai As laboratorium.DataSet_LabTableAdapters.barang_habis_pakaiTableAdapter
    Friend WithEvents dtpExpired As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmpty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTglRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamSelesaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblJamMulaiRevisi As System.Windows.Forms.Label
    Friend WithEvents lblDirevisiOleh As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As laboratorium.DataSet_LabTableAdapters.supplierTableAdapter
    Friend WithEvents BindingSourceJenisBarangHabisPakai As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterJenisBarangHabisPakai As laboratorium.DataSet_LabTableAdapters.jenis_barang_habis_pakaiTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BindingSourceSatuanKuantitas As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterSatuanKuantitas As laboratorium.DataSet_LabTableAdapters.satuan_kuantitasTableAdapter
    Friend WithEvents BindingSourceSatuanIsi As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterSatuanIsi As laboratorium.DataSet_LabTableAdapters.satuan_isiTableAdapter
    Friend WithEvents txtTahun As System.Windows.Forms.TextBox
    Friend WithEvents txtHari As System.Windows.Forms.TextBox
    Friend WithEvents txtBulan As System.Windows.Forms.TextBox
End Class
