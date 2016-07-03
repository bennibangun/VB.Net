Public Class master_tabung

#Region "On Load"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim jamku As Date
        jamku = DateTime.Now
        lblTime.Text = Format(Now, "hh:mm:ss tt")
        lblDate.Text = Format(Now, "dddd, dd – MMMM – yyyy")

        lblDirevisiOleh.Text = "Joni Bangun"
        lblJamSelesaiRevisi.Text = lblTime.Text
        lblTglRevisi.Text = Date.Today.ToLongDateString
    End Sub

    Private Sub master_tabung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableAdapterNamaTabung.Fill(Me.DataSet_Lab.nama_tabung)
        Me.TableAdapterJenisKelompok.Fill(Me.DataSet_Lab.jenis_kelompok)
        lblJamMulaiRevisi.Text = TimeOfDay.ToString("hh:mm:ss tt")
        Timer1.Start()
        Me.WindowState = FormWindowState.Maximized
    End Sub

#End Region
    
#Region "Button save"
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            Dim result = validateAllFileds()

            If (result = 1) Then                
                DataOpsTabung.AddNewTabung(txtKodeTabung.Text, cbxKelompok.Text, cbxNamaTabung.Text,
                                     txtKuantitas.Text, dtpTglExpired.Text, txtSisaTahun.Text,
                                     txtSisaBulan.Text, txtSisaHari.Text, txtPeringatanExpired.Text,
                                      txtPeringatanJumlah.Text, lblDirevisiOleh.Text,
                                     lblJamMulaiRevisi.Text, lblJamSelesaiRevisi.Text)
                Me.Close()
                End If

            End If
    End Sub
    
#End Region

#Region "Hapus dan validateAllFields"
    Private Sub hapus()
        txtKodeTabung.Text = ""
        cbxKelompok.SelectedIndex = -1
        cbxNamaTabung.SelectedIndex = -1
        txtKuantitas.Text = ""
        txtEmpty.Visible = True
        txtPeringatanExpired.Text = ""
        txtPeringatanJumlah.Text = ""
        txtSisaTahun.Text = ""
        txtSisaBulan.Text = ""
        txtSisaHari.Text = ""
    End Sub

    Private Function validateAllFileds() As Integer
        Dim value As Integer = 1

        If (cbxKelompok.Text = "") Then
            My.Dialogs.WarningDialog("Kelompok harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxNamaTabung.Text = "") Then
            My.Dialogs.WarningDialog("Nama Tabung harus di pilih !", "Perhatian")
            value = 0
        ElseIf (txtKuantitas.Text = "") Then
            My.Dialogs.WarningDialog("Kuantitas harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtPeringatanExpired.Text = "") Then
            My.Dialogs.WarningDialog("Peringatan Expired harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtEmpty.Visible = True) Then
            My.Dialogs.WarningDialog("Tanggal Expired harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtPeringatanJumlah.Text = "") Then
            My.Dialogs.WarningDialog("Peringatan Jumlah harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtSisaTahun.Text = "") Then
            My.Dialogs.WarningDialog("Sisa waktu tahun harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtSisaBulan.Text = "") Then
            My.Dialogs.WarningDialog("Sisa waktu bulan harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtSisaHari.Text = "") Then
            My.Dialogs.WarningDialog("Sisa waktu hari harus di isi !", "Perhatian")
            value = 0        
        End If
        Return value
    End Function

#End Region
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub


End Class