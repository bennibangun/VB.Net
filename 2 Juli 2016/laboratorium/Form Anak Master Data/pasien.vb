Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Imaging

Public Class pasien

    Dim fee As Integer
    Dim tlp_rmh As Integer
    Dim tlp_seluler As Integer
    Dim no_rek As Integer
    'Dim pembayaran_fee As Integer
    Dim photo As Byte()
    Dim memStr As New MemoryStream()

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

    Private Sub pasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableAdapterBank.Fill(Me.DataSet_Lab.bank)
        Me.TableAdapterProvinsi.Fill(Me.DataSet_Lab.provinsi)
        Me.TableAdapterKabupaten.Fill(Me.DataSet_Lab.kabupaten)
        Me.TableAdapterProvinsi.Fill(Me.DataSet_Lab.provinsi)
        Me.TableAdapterKecamatan.Fill(Me.DataSet_Lab.kecamatan)
        Me.WindowState = FormWindowState.Maximized

        Me.WindowState = FormWindowState.Maximized
        lblJamMulaiRevisi.Text = TimeOfDay.ToString("hh:mm:ss tt")
        Timer1.Start()

        If (DataOpsPasien.ReadIDPasien = 0) Then
            lblID.Text = 1
        Else
            lblID.Text = DataOpsPasien.ReadMaxIDPasien + 1
        End If


        Dim dtProvinsi As New DataSet_Lab.provinsiDataTable


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


        If readDokter = 1 Then
            cbxJenKel.SelectedIndex = cbxJenKel.FindString(jenkelDokter)
            cbxStatusPasien.SelectedIndex = cbxStatusPasien.FindString(statusPasien)
            cbxJenKel.SelectedIndex = cbxJenKel.FindString(jenkelPasien)
            cbxTempatLahir.SelectedIndex = cbxJenKel.FindString(tmplahirPasien)
            dtpTglLahir.Text = tgllahirPasien
            cbxGolonganDarah.SelectedIndex = cbxGolonganDarah.FindString(golDarahPasien)
            cbxRhesus.SelectedIndex = cbxRhesus.FindString(rhesusPasien)
            cbxPendidikan.SelectedIndex = cbxPendidikan.FindString(pendidikanPasien)
            cbxPekerjaan.SelectedIndex = cbxPekerjaan.FindString(pekerjaanPasien)
            cbxProvinsi.SelectedIndex = cbxProvinsi.FindString(provinsi)
            cbxKecamatan.SelectedIndex = cbxKecamatan.FindString(kecamatan)
            cbxKabupaten.SelectedIndex = cbxKabupaten.FindString(kabupaten)            
        End If

    End Sub


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
                Int32.TryParse(txtTlpRumah.Text, tlp_rmh)
                Int32.TryParse(txtTlpSelular.Text, tlp_seluler)                

                If Not pbxPhoto.Image Is Nothing Then
                    pbxPhoto.BackgroundImage.Save(memStr, Imaging.ImageFormat.Jpeg)
                    photo = memStr.GetBuffer()
                End If
                

                If readPasien < 1 Then
                    DataOpsPasien.AddNewPasien(photo, txtNama.Text, cbxStatusPasien.Text, cbxJenKel.Text, cbxTempatLahir.Text,
                                     dtpTglLahir.Text, cbxGolonganDarah.Text, cbxRhesus.Text, cbxPendidikan.Text,
                                     cbxPekerjaan.Text, txtAlamat.Text, cbxProvinsi.Text, cbxKabupaten.Text,
                                     cbxKecamatan.Text, tlp_rmh, tlp_seluler, txtEmail.Text,
                                     txtKeterangan.Text, lblDirevisiOleh.Text, lblJamMulaiRevisi.Text,
                                     lblJamSelesaiRevisi.Text, lblTglRevisi.Text)
                Else
                    DataOpsPasien.Update_Pasien(lblID.Text, photo, txtNama.Text, cbxStatusPasien.Text, cbxJenKel.Text, cbxTempatLahir.Text,
                                     dtpTglLahir.Text, cbxGolonganDarah.Text, cbxRhesus.Text, cbxPendidikan.Text,
                                     cbxPekerjaan.Text, txtAlamat.Text, cbxProvinsi.Text, cbxKabupaten.Text,
                                     cbxKecamatan.Text, tlp_rmh, tlp_seluler, txtEmail.Text,
                                     txtKeterangan.Text, lblDirevisiOleh.Text, lblJamMulaiRevisi.Text,
                                     lblJamSelesaiRevisi.Text, lblTglRevisi.Text)
                End If

                'hapus()
                'lblID.Text = DataOpsPasien.ReadMaxIDPasien + 1
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

#Region "Hapus dan validateAllFields"
    Private Sub hapus()
        lblID.Text = ""
        pbxPhoto.BackgroundImage = Nothing
        txtNama.Text = ""
        cbxStatusPasien.SelectedIndex = -1
        cbxJenKel.SelectedIndex = -1
        cbxTempatLahir.SelectedIndex = -1
        txtEmpty.Visible = True
        cbxGolonganDarah.SelectedIndex = -1
        cbxRhesus.SelectedIndex = -1
        cbxPendidikan.SelectedIndex = -1
        cbxPekerjaan.SelectedIndex = -1
        txtAlamat.Clear()
        cbxProvinsi.SelectedIndex = -1
        cbxKabupaten.SelectedIndex = -1
        cbxKecamatan.SelectedIndex = -1
        txtTlpRumah.Text = ""
        txtTlpSelular.Text = ""
        txtEmail.Text = ""        
        txtKeterangan.Text = ""
    End Sub

    Private Function validateAllFileds() As Integer
        Dim value As Integer = 1        

        If (txtNama.Text = "") Then
            My.Dialogs.WarningDialog("Nama harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxStatusPasien.Text = "") Then
            My.Dialogs.WarningDialog("Status harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxJenKel.Text = "") Then
            My.Dialogs.WarningDialog("Jenis kelamin harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxTempatLahir.Text = "") Then
            My.Dialogs.WarningDialog("Tempat lahir harus di isi !", "Perhatian")
            value = 0        
        ElseIf (cbxGolonganDarah.Text = "") Then
            My.Dialogs.WarningDialog("Golongan darah harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxRhesus.Text = "") Then
            My.Dialogs.WarningDialog("Rhesus harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxPendidikan.Text = "") Then
            My.Dialogs.WarningDialog("Pendidikan harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxPekerjaan.Text = "") Then
            My.Dialogs.WarningDialog("Pekerjaan harus di isi !", "Perhatian")
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
        ElseIf (txtEmail.Text = "") Then
            My.Dialogs.WarningDialog("Email harus di isi !", "Perhatian")
            value = 0       
        ElseIf (txtKeterangan.Text = "") Then
            My.Dialogs.WarningDialog("Keterangan harus di isi !", "Perhatian")
            value = 0
        End If
        Return value
    End Function

#End Region

#Region "Textbox, combobox event click"

#Region "Event click combobox"
    Private Sub cbxTempatLahir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTempatLahir.SelectedIndexChanged
        txtEmpty.Visible = False
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

    Private Sub txtNoRekening_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFee_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region

#End Region

End Class