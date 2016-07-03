Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Imaging

Public Class dokter
    WithEvents bsCustomers As New BindingSource
    Dim fee As Integer
    Dim tlp_rmh As Integer
    Dim tlp_selular As Integer
    Dim no_rek As Integer
    'Dim pembayaran_fee As Integer
    Dim startRevisi As String
    Dim photo As Byte()
    Dim memStr As New MemoryStream()

    Private Sub dokter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.DialogResult = Windows.Forms.CloseReason.UserClosing

    End Sub

#Region "Form Load"

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim jamku As Date
        jamku = DateTime.Now
        lblTime.Text = Format(Now, "hh:mm:ss tt")
        lblDate.Text = Format(Now, "dddd, dd – MMMM – yyyy")

        lblDirevisiOleh.Text = "Joni Bangun"
        lblJamSelesaiRevisi.Text = lblTime.Text
        lblTglRevisi.Text = Date.Today.ToLongDateString
    End Sub

    Private Sub dokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load            
        Me.TableAdapterCaraBayar.Fill(Me.DataSet_Lab.cara_bayar)
        Me.TableAdapterSpesialisasi.Fill(Me.DataSet_Lab.spesialisasi)
        Me.TableAdapterBank.Fill(Me.DataSet_Lab.bank)        
        Me.TableAdapterKabupaten.Fill(Me.DataSet_Lab.kabupaten)        
        Me.TableAdapterProvinsi.Fill(Me.DataSet_Lab.provinsi)        
        Me.TableAdapterKecamatan.Fill(Me.DataSet_Lab.kecamatan)
        Me.WindowState = FormWindowState.Maximized

        lblJamMulaiRevisi.Text = TimeOfDay.ToString("hh:mm:ss tt")
        Timer1.Start()

        If (DataOpsDokter.ReadIDDocter = 0) Then
            lblID.Text = 1
        Else
            lblID.Text = DataOpsDokter.ReadMaxIDDocter + 1
        End If

        Me.TableAdapterSpesialisasi.Fill(Me.DataSet_Lab.spesialisasi)
        Me.TableAdapterBank.Fill(Me.DataSet_Lab.bank)
        Me.TableAdapterProvinsi.Fill(Me.DataSet_Lab.provinsi)

        Dim dtSpesialisasi As New DataSet_Lab.spesialisasiDataTable
        Dim dtBank As New DataSet_Lab.bankDataTable
        Dim dtProvinsi As New DataSet_Lab.provinsiDataTable


        '*********** show spesialis ************'
        For Each col As DataColumn In dtSpesialisasi.Columns
            col.AllowDBNull = True
        Next
        Me.TableAdapterSpesialisasi.Fill(dtSpesialisasi)
        cbxSpesialisasi.DisplayMember = "spesialis"
        cbxSpesialisasi.DataSource = dtSpesialisasi


        '*********** show bank ************'
        For Each col As DataColumn In dtBank.Columns
            col.AllowDBNull = True
        Next
        Me.TableAdapterBank.Fill(dtBank)
        cbxBank.DisplayMember = "nama_bank"
        cbxBank.DataSource = dtBank


        '*********** show provinsi ************'
        For Each col As DataColumn In dtProvinsi.Columns
            col.AllowDBNull = True
        Next
        Me.TableAdapterProvinsi.Fill(dtProvinsi)
        cbxProvinsi.DisplayMember = "nama_provinsi"
        cbxProvinsi.DataSource = dtProvinsi


        '*********** show kabupaten ************'
        Me.TableAdapterKabupaten.Fill(Me.DataSet_Lab.kabupaten)
        Dim dtKabupaten As New DataSet_Lab.kabupatenDataTable

        For Each col As DataColumn In dtKabupaten.Columns
            col.AllowDBNull = True
        Next
        Me.TableAdapterKabupaten.Fill(dtKabupaten)
        cbxKabupaten.DisplayMember = "nama_kabupaten"
        cbxKabupaten.DataSource = dtKabupaten



        '*********** show kecamatan ************'
        Me.TableAdapterKecamatan.Fill(Me.DataSet_Lab.kecamatan)
        Dim dtKecamatan As New DataSet_Lab.kecamatanDataTable

        For Each col As DataColumn In dtKecamatan.Columns
            col.AllowDBNull = True
        Next
        Me.TableAdapterKecamatan.Fill(dtKecamatan)
        cbxKecamatan.DisplayMember = "nama_kecamatan"
        cbxKecamatan.DataSource = dtKecamatan


        '*********** show cara bayar ******'
        Me.TableAdapterCaraBayar.Fill(Me.DataSet_Lab.cara_bayar)
        Dim dtCaraBayar As New DataSet_Lab.cara_bayarDataTable

        For Each colCaraBayar As DataColumn In dtCaraBayar.Columns
            colCaraBayar.AllowDBNull = True
        Next
        Me.TableAdapterCaraBayar.Fill(dtCaraBayar)
        cbxPembayaranFee.DisplayMember = "nama_cara_bayar"
        cbxPembayaranFee.DataSource = dtCaraBayar


        If readDokter = 1 Then
            cbxJenKel.SelectedIndex = cbxJenKel.FindString(jenkelDokter)
            cbxSpesialisasi.SelectedIndex = cbxSpesialisasi.FindString(spesialisasiDokter)
            cbxGolonganDarah.SelectedIndex = cbxGolonganDarah.FindString(golDarahDokter)
            cbxRhesus.SelectedIndex = cbxRhesus.FindString(rhesusDokter)
            cbxProvinsi.SelectedIndex = cbxProvinsi.FindString(provinsi)
            cbxKecamatan.SelectedIndex = cbxKecamatan.FindString(kecamatan)
            cbxKabupaten.SelectedIndex = cbxKabupaten.FindString(kabupaten)
            cbxPembayaranFee.SelectedIndex = cbxPembayaranFee.FindString(pembayaranFee)
            cbxBank.SelectedIndex = cbxBank.FindString(namaBank)
        End If

    End Sub

#End Region

#Region "Hapus dan validateAllFields"
    Private Sub hapus()
        lblID.Text = ""
        cbxJenKel.SelectedIndex = -1
        txtNama.Text = ""
        cbxSpesialisasi.SelectedIndex = -1
        txtEmpty.Visible = True
        cbxGolonganDarah.SelectedIndex = -1
        cbxRhesus.SelectedIndex = -1
        txtAlamat.Clear()
        cbxProvinsi.SelectedIndex = -1
        cbxKabupaten.SelectedIndex = -1
        cbxKecamatan.SelectedIndex = -1
        txtTlpRumah.Text = ""
        txtTlpSelular.Text = ""
        txtFee.Text = ""
        cbxPembayaranFee.SelectedIndex = -1
        cbxBank.SelectedIndex = -1
        txtNoRekening.Text = ""
        txtAtasNama.Text = ""
        txtKeterangan.Text = ""
        pbxPhoto.BackgroundImage = Nothing
    End Sub

    Private Function validateAllFileds() As Integer
        Dim value As Integer = 1
        Dim age As Integer = Now.Year - dtpTglLahir.Value.Year

        If (txtNama.Text = "") Then
            My.Dialogs.WarningDialog("Nama harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxJenKel.Text = "") Then
            My.Dialogs.WarningDialog("Jenis kelamin harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxSpesialisasi.Text = "") Then
            My.Dialogs.WarningDialog("Spesialisasi harus di isi !", "Perhatian")
            value = 0
        ElseIf (age < 20) Then
            My.Dialogs.WarningDialog("Tgl lahir salah ! (Umur tidak tepat)", "Perhatian")
            value = 0
        ElseIf (cbxGolonganDarah.Text = "") Then
            My.Dialogs.WarningDialog("Golongan darah harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxRhesus.Text = "") Then
            My.Dialogs.WarningDialog("Rhesus harus di isi !", "Perhatian")
            value = 0
        ElseIf (pbxPhoto.BackgroundImage Is Nothing) Then
            My.Dialogs.WarningDialog("Photo harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtAlamat.Text = "") Then
            My.Dialogs.WarningDialog("Alamat harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxProvinsi.Text = "") Then
            My.Dialogs.WarningDialog("Provinsi harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxKabupaten.Text = "") Then
            My.Dialogs.WarningDialog("Kabupaten harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxKecamatan.Text = "") Then
            My.Dialogs.WarningDialog("Kecamatan harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtTlpRumah.Text = "") Then
            My.Dialogs.WarningDialog("Telepon rumah harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtTlpSelular.Text = "") Then
            My.Dialogs.WarningDialog("Nomor Telepon selular harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtFee.Text = "") Then
            My.Dialogs.WarningDialog("Fee harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxPembayaranFee.Text = "") Then
            My.Dialogs.WarningDialog("Pembayaran fee harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxBank.Text = "") Then
            My.Dialogs.WarningDialog("Bank harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtNoRekening.Text = "") Then
            My.Dialogs.WarningDialog("Nomor rekening harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtAtasNama.Text = "") Then
            My.Dialogs.WarningDialog("Atas nama harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtKeterangan.Text = "") Then
            My.Dialogs.WarningDialog("Keterangan harus di isi !", "Perhatian")
            value = 0
        End If
        Return value
    End Function

#End Region

#Region "Button search, simpan, hapus, tutup event click"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim result As DialogResult = OpenFilePhoto.ShowDialog


        If result = Windows.Forms.DialogResult.OK Then
            If (OpenFilePhoto.FileName IsNot Nothing) Or (OpenFilePhoto.FileName <> String.Empty) Then
                pbxPhoto.BackgroundImage = Image.FromFile(OpenFilePhoto.FileName)
                If (pbxPhoto.Image Is Nothing) Then
                    pbxPhoto.BackgroundImage.Save(memStr, Imaging.ImageFormat.Jpeg)
                    photo = memStr.GetBuffer()
                    pbxPhoto.BackgroundImageLayout = ImageLayout.Zoom
                Else
                    photo = memStr.GetBuffer()
                    pbxPhoto.BackgroundImageLayout = ImageLayout.Zoom
                End If
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            Dim result = validateAllFileds()

            If (result = 1) Then
                Int32.TryParse(txtFee.Text, fee)
                Int32.TryParse(txtTlpRumah.Text, tlp_rmh)
                Int32.TryParse(txtTlpSelular.Text, tlp_selular)
                Int32.TryParse(txtNoRekening.Text, no_rek)

                pbxPhoto.BackgroundImage.Save(memStr, Imaging.ImageFormat.Jpeg)
                photo = memStr.GetBuffer()

                If readDokter < 1 Then
                    DataOpsDokter.AddNewDocter(cbxJenKel.Text, txtNama.Text, cbxSpesialisasi.Text,
                                     dtpTglLahir.Text, cbxGolonganDarah.Text, cbxRhesus.Text,
                                     photo, txtAlamat.Text, cbxProvinsi.Text, cbxKabupaten.Text,
                                     cbxKecamatan.Text, tlp_rmh, tlp_selular,
                                     fee, cbxPembayaranFee.Text, cbxBank.Text, no_rek,
                                     txtAtasNama.Text, txtKeterangan.Text, lblDirevisiOleh.Text,
                                     lblJamMulaiRevisi.Text, lblJamSelesaiRevisi.Text, lblTglRevisi.Text)
                Else
                    DataOpsDokter.UpdateDocter(lblID.Text, cbxJenKel.Text, txtNama.Text, cbxSpesialisasi.Text,
                                     dtpTglLahir.Text, cbxGolonganDarah.Text, cbxRhesus.Text,
                                     photo, txtAlamat.Text, cbxProvinsi.Text, cbxKabupaten.Text,
                                     cbxKecamatan.Text, tlp_rmh, tlp_selular,
                                     fee, cbxPembayaranFee.Text, cbxBank.Text, no_rek,
                                     txtAtasNama.Text, txtKeterangan.Text, lblDirevisiOleh.Text,
                                     lblJamMulaiRevisi.Text, lblJamSelesaiRevisi.Text, lblTglRevisi.Text)
                End If

                'hapus()
                'lblID.Text = DataOpsDokter.ReadMaxIDDocter + 1
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        hapus()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

#End Region

#Region "Textbox, combobox event click"

#Region "Event click combobox"
    Private Sub cboSpesialisasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSpesialisasi.SelectedIndexChanged
        txtEmpty.Visible = False
    End Sub

    Private Sub cboKabupaten_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxKabupaten.MouseClick
        cbxKabupaten.Items.Clear()
        If cbxProvinsi.Text <> "" Then
            Dim queryString = "SELECT nama_kabupaten FROM dbo.kabupaten WHERE provinsi_id IN (SELECT id FROM provinsi WHERE nama_provinsi = '" & cbxProvinsi.Text & "')"
            Dim command As New SqlCommand(queryString, connection)
            reader = command.ExecuteReader()
            Try
                While reader.Read()
                    cbxKabupaten.Items.Add(reader(0))
                End While
            Finally
                reader.Close()
            End Try
        End If
    End Sub

    Private Sub cboKecamatan_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxKecamatan.MouseClick
        cbxKecamatan.Items.Clear()
        If cbxKabupaten.Text <> "" Then
            Dim queryString = "SELECT nama_kecamatan FROM dbo.kecamatan WHERE kabupaten_id IN (SELECT id FROM kabupaten WHERE nama_kabupaten = '" & cbxKabupaten.Text & "')"
            Dim command As New SqlCommand(queryString, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            Try
                While reader.Read()
                    cbxKecamatan.Items.Add(reader(0))
                End While
            Finally
                reader.Close()
            End Try
        End If
    End Sub

#End Region

#Region "Event click textbox"
    Private Sub txtTlpRumah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTlpRumah.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTlpSelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTlpSelular.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNoRekening_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoRekening.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFee.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region

#End Region

End Class