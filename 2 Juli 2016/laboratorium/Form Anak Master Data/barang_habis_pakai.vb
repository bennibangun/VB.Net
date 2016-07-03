Public Class barang_habis_pakai

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

    Private Sub barang_habis_pakai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableAdapterSatuanIsi.Fill(Me.DataSet_Lab.satuan_isi)
        Me.TableAdapterSatuanKuantitas.Fill(Me.DataSet_Lab.satuan_kuantitas)
        Me.TableAdapterJenisBarangHabisPakai.Fill(Me.DataSet_Lab.jenis_barang_habis_pakai)
        Me.SupplierTableAdapter.Fill(Me.DataSet_Lab.supplier)
        Me.TableAdapterBarangHabisPakai.Fill(Me.DataSet_Lab.barang_habis_pakai)

        Me.WindowState = FormWindowState.Maximized
        lblJamMulaiRevisi.Text = TimeOfDay.ToString("hh:mm:ss tt")
        Timer1.Start()
        txtEmpty.Visible = True

        If read_BrgHabisPakai <> 1 Then
            If (DataOpsBrgHabisPakai.ReadID_BarangHabisPakai = 0) Then
                lblIDBrgHabisPakai.Text = 1
            Else
                lblIDBrgHabisPakai.Text = DataOpsBrgHabisPakai.ReadMaxID_BarangHabisPakai + 1
            End If
        Else
            lblIDBrgHabisPakai.Text = id_BrgHabisPakai
        End If

        If read_BrgHabisPakai = 1 Then
            Dim comboJenisSourceBrgHabisPakai As New Dictionary(Of String, String)()
            comboJenisSourceBrgHabisPakai.Add(jenis_barang_habis_pakai, "1")
            cboJenis.DataSource = New BindingSource(comboJenisSourceBrgHabisPakai, Nothing)
            cboJenis.DisplayMember = jenis_barang_habis_pakai
            cboJenis.ValueMember = "Key"

            Dim comboSatuanKuantitas As New Dictionary(Of String, String)()
            comboSatuanKuantitas.Add(satuan_kuantitas, "1")
            cboSatuanKuantitas.DataSource = New BindingSource(comboSatuanKuantitas, Nothing)
            cboSatuanKuantitas.DisplayMember = satuan_kuantitas
            cboSatuanKuantitas.ValueMember = "Key"

            Dim comboSatuanIsi As New Dictionary(Of String, String)()
            comboSatuanIsi.Add(satuan_isi, "1")
            cboSatuanIsi.DataSource = New BindingSource(comboSatuanIsi, Nothing)
            cboSatuanIsi.DisplayMember = satuan_kuantitas
            cboSatuanIsi.ValueMember = "Key"
        End If

    End Sub

#End Region

#Region "Expired Date"
    Private Sub perhitunganExp()
        Dim sisaTahun As String = ""
        Dim sisaBulan As String = ""
        Dim sisaHari As String = ""
        Dim peringatanExp As String = ""

        If dtpExpired.Value.Year > Date.Now.Year Then
            sisaTahun = dtpExpired.Value.Year - Date.Now.Year
        ElseIf dtpExpired.Value.Year < Date.Now.Year Then
            sisaTahun = "- " + CStr(Date.Now.Year - dtpExpired.Value.Year)
        ElseIf dtpExpired.Value.Year = Date.Now.Year Then
            sisaTahun = "0"
        End If


        If dtpExpired.Value.Year = Date.Now.Year Then
            If (dtpExpired.Value.Month > Date.Now.Month) Then
                sisaBulan = dtpExpired.Value.Month - Date.Now.Month
            ElseIf (dtpExpired.Value.Month < Date.Now.Month) Then
                sisaBulan = "- " + Date.Now.Month - dtpExpired.Value.Month
            ElseIf (dtpExpired.Value.Month = Date.Now.Month) Then
                sisaBulan = "0"
            End If
        ElseIf dtpExpired.Value.Year > Date.Now.Year Then
            If (dtpExpired.Value.Month > Date.Now.Month) Then
                sisaBulan = dtpExpired.Value.Month - Date.Now.Month
            ElseIf (dtpExpired.Value.Month < Date.Now.Month) Then
                sisaBulan = dtpExpired.Value.Month
            ElseIf (dtpExpired.Value.Month = Date.Now.Month) Then
                sisaBulan = "0"
            End If
        End If


        If (dtpExpired.Value.Year = Date.Now.Year And dtpExpired.Value.Month = Date.Now.Month) Then
            If (dtpExpired.Value.Day > Date.Now.Day) Then
                sisaHari = dtpExpired.Value.Day - Date.Now.Day
            ElseIf (dtpExpired.Value.Day < Date.Now.Day) Then
                sisaHari = "- " + CStr(Date.Now.Day - dtpExpired.Value.Day)
            ElseIf (dtpExpired.Value.Day = Date.Now.Day) Then
                sisaHari = dtpExpired.Value.Day
            End If
        ElseIf (dtpExpired.Value.Year > Date.Now.Year) Then
            If (dtpExpired.Value.Day > Date.Now.Day) Then
                sisaHari = dtpExpired.Value.Day - Date.Now.Day
            ElseIf (dtpExpired.Value.Day = Date.Now.Day) Then
                sisaHari = dtpExpired.Value.Day
            End If
        End If


        If (CInt(sisaBulan) <> 0 And CInt(sisaBulan) < 6 And CInt(sisaTahun) = 0) Then
            peringatanExp = "< 6 bulan"
        ElseIf (CInt(sisaBulan) <> 0 And CInt(sisaBulan) < 5 And CInt(sisaTahun) = 0) Then
            peringatanExp = "< 5 bulan"
        ElseIf (CInt(sisaBulan) <> 0 And CInt(sisaBulan) < 4 And CInt(sisaTahun) = 0) Then
            peringatanExp = "< 4 bulan"
        ElseIf (CInt(sisaBulan) <> 0 And CInt(sisaBulan) < 3 And CInt(sisaTahun) = 0) Then
            peringatanExp = "< 3 bulan"
        ElseIf (CInt(sisaBulan) <> 0 And CInt(sisaBulan) < 2) Then
            peringatanExp = "< 2 bulan"
        ElseIf (CInt(sisaBulan) = 0 And CInt(sisaBulan) < 1 And CInt(sisaTahun) = 0) Then
            peringatanExp = "< 1 bulan"
        End If

        txtTahun.Text = sisaTahun
        txtBulan.Text = sisaBulan
        txtHari.Text = sisaHari
        txtPeringatanExpired.Text = peringatanExp

    End Sub

#End Region

#Region "Textbox, combobox, datetimepicker keypress"
    Private Sub dtpExpired_ValueChanged(sender As Object, e As EventArgs) Handles dtpExpired.ValueChanged
        perhitunganExp()
    End Sub
    Private Sub cboSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplier.SelectedIndexChanged
        txtEmpty.Visible = False
        perhitunganExp()
    End Sub

    Private Sub txtIsi_TextChanged(sender As Object, e As EventArgs) Handles txtIsi.TextChanged
        txtEmpty.Visible = False
        perhitunganExp()
    End Sub

    Private Sub txtKuantitas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKuantitas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtIsi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIsi.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

#End Region

#Region "Button simpan, hapus, tutup event click"
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim sisaTahunExp As Integer
        Dim sisaBulanExp As Integer
        Dim sisaHariExp As Integer
        Dim kuantitas As Integer
        Dim isi As Integer

        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            Dim result = validateAllFileds()

            If connection.State = ConnectionState.Closed Then
                connection.ConnectionString = connString
                connection.Open()
            End If

            If (result = 1) Then
                Int32.TryParse(txtTahun.Text, sisaTahunExp)
                Int32.TryParse(txtBulan.Text, sisaBulanExp)
                Int32.TryParse(txtHari.Text, sisaHariExp)
                Int32.TryParse(txtKuantitas.Text, kuantitas)
                Int32.TryParse(txtIsi.Text, isi)

                If readRujukan < 1 Then
                    DataOpsBrgHabisPakai.AddNewBarang_Habis_Pakai(cboJenis.Text,
                                     cboSupplier.Text, txtNomorBarcode.Text, kuantitas, cboSatuanKuantitas.Text,
                                     isi, cboSatuanIsi.Text, dtpExpired.Text, sisaTahunExp, sisaBulanExp,
                                     sisaHariExp, txtPeringatanExpired.Text, txtKeterangan.Text,
                                     lblDirevisiOleh.Text, lblJamMulaiRevisi.Text, lblJamSelesaiRevisi.Text)

                Else
                    DataOpsBrgHabisPakai.Update_Barang_Habis_Pakai(lblIDBrgHabisPakai.Text, cboJenis.Text,
                                     cboSupplier.Text, txtNomorBarcode.Text, kuantitas, cboSatuanKuantitas.Text,
                                     isi, cboSatuanIsi.Text, dtpExpired.Text, sisaTahunExp, sisaBulanExp,
                                     sisaHariExp, txtPeringatanExpired.Text, txtKeterangan.Text,
                                     lblDirevisiOleh.Text, lblJamMulaiRevisi.Text, lblJamSelesaiRevisi.Text)
                End If


                hapus()
                lblIDBrgHabisPakai.Text = DataOpsBrgHabisPakai.ReadMaxID_BarangHabisPakai + 1
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

#Region "hapus, validateAllFileds"
    Private Sub hapus()
        cboJenis.SelectedIndex = -1
        cboSupplier.SelectedIndex = -1
        txtNomorBarcode.Text = ""
        txtKuantitas.Text = ""
        cboSatuanKuantitas.SelectedIndex = -1
        txtIsi.Text = ""
        cboSatuanIsi.SelectedIndex = -1
        txtEmpty.Visible = True
        txtEmpty.Text = ""
        txtTahun.Text = ""
        txtBulan.Text = ""
        txtHari.Text = ""
        txtPeringatanExpired.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Function validateAllFileds() As Integer
        Dim value As Integer = 1

        If (cboJenis.Text = "") Then
            My.Dialogs.WarningDialog("Jenis harus di isi !", "Perhatian")
            value = 0
        ElseIf (cboSupplier.Text = "") Then
            My.Dialogs.WarningDialog("Supplier harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtNomorBarcode.Text = "") Then
            My.Dialogs.WarningDialog("Nomor Barcode harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtKuantitas.Text = "") Then
            My.Dialogs.WarningDialog("Kuantitas harus di isi !", "Perhatian")
            value = 0
        ElseIf (cboSatuanKuantitas.Text = "") Then
            My.Dialogs.WarningDialog("Satuan Kuantitas harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtIsi.Text = "") Then
            My.Dialogs.WarningDialog("Isi tidak boleh kosong !", "Perhatian")
            value = 0
        ElseIf (cboSatuanIsi.Text = "") Then
            My.Dialogs.WarningDialog("Satuan Isi tidak boleh kosong !", "Perhatian")
            value = 0
        ElseIf (dtpExpired.Text = "") Then
            My.Dialogs.WarningDialog("Expired harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtKeterangan.Text = "") Then
            My.Dialogs.WarningDialog("Keterangan harus di isi !", "Perhatian")
            value = 0
        End If
        Return value
    End Function
#End Region
           
End Class