Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class pengirim
    WithEvents bsCustomers As New BindingSource
    Dim fee As Integer
    Dim tlp_rmh As Integer
    Dim tlp_selular As Integer
    Dim no_rek As Integer
    'Dim pembayaran_fee As Integer
    Dim startRevisi As String
    Dim con As New SqlConnection(connString)

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

    Private Sub pengirim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TableAdapterCaraBayar.Fill(Me.DataSet_Lab.cara_bayar)
        Me.TableAdapterProvinsi.Fill(Me.DataSet_Lab.provinsi)
        Me.TableAdapterKabupaten.Fill(Me.DataSet_Lab.kabupaten)
        Me.TableAdapterKecamatan.Fill(Me.DataSet_Lab.kecamatan)

        Me.WindowState = FormWindowState.Maximized
        lblJamMulaiRevisi.Text = TimeOfDay.ToString("hh:mm:ss tt")
        Timer1.Start()

        If readPengirim <> 1 Then
            If (DataOps.ReadIDPengirim = 0) Then
                lblID.Text = 1
            Else
                lblID.Text = DataOps.ReadMaxIDPengirim + 1
            End If
        Else
            lblID.Text = idPengirim
        End If


        '*********** show provinsi ************'
        Me.TableAdapterProvinsi.Fill(Me.DataSet_Lab.provinsi)
        Dim dtProvinsi As New DataSet_Lab.provinsiDataTable

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



        '*********** show bank ************'
            Me.TableAdapterBank.Fill(Me.DataSet_Lab.bank)
            Dim dtBank As New DataSet_Lab.bankDataTable

            For Each col As DataColumn In dtBank.Columns
                col.AllowDBNull = True
            Next
            Me.TableAdapterBank.Fill(dtBank)
            cbxBank.DisplayMember = "nama_bank"
            cbxBank.DataSource = dtBank


        If readPengirim = 1 Then            
            cbxKecamatan.SelectedIndex = cbxKecamatan.FindString(kecamatan)
            cbxKabupaten.SelectedIndex = cbxKabupaten.FindString(kabupaten)
            cbxPembayaranFee.SelectedIndex = cbxPembayaranFee.FindString(pembayaranFee)
            cbxBank.SelectedIndex = cbxBank.FindString(namaBank)
        End If

    End Sub

#End Region

#Region "Kabupaten, Kecamatan dan Pembayaran Fee"
    Private Sub cbxKabupaten_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxKabupaten.MouseClick
        cbxKabupaten.DataSource = Nothing
        cbxKabupaten.Items.Clear()

        If connection.State = ConnectionState.Closed Then
            connection.ConnectionString = connString
            connection.Open()
        End If

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

    Private Sub cbxKecamatan_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxKecamatan.MouseClick
        cbxKecamatan.DataSource = Nothing
        cbxKecamatan.Items.Clear()

        If connection.State = ConnectionState.Closed Then
            connection.ConnectionString = connString
            connection.Open()
        End If

        If cbxKabupaten.Text <> "" Then
            Dim queryString = "SELECT nama_kecamatan FROM dbo.kecamatan WHERE kabupaten_id IN (SELECT id FROM kabupaten WHERE nama_kabupaten = '" & cbxKabupaten.Text & "')"
            Dim command As New SqlCommand(queryString, connection)

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

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

#Region "Textbox keypress"
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

#Region "Button simpan, tutup, hapus event click"
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            Dim result = validateAllFileds()

            If connection.State = ConnectionState.Closed Then
                connection.ConnectionString = connString
                connection.Open()
            End If

            If (result = 1) Then
                Int32.TryParse(txtFee.Text, fee)
                Int32.TryParse(txtTlpRumah.Text, tlp_rmh)
                Int32.TryParse(txtTlpSelular.Text, tlp_selular)
                Int32.TryParse(txtNoRekening.Text, no_rek)                

                If readPengirim < 1 Then
                    DataOpsPengirim.AddNewPengirim(txtNamaKontak.Text,
                                     txtAlamat.Text, cbxProvinsi.Text, cbxKabupaten.Text,
                                     cbxKecamatan.Text, tlp_rmh, tlp_selular, txtEmail.Text,
                                     fee, cbxPembayaranFee.Text, cbxBank.Text, no_rek,
                                     txtAtasNama.Text, txtKeterangan.Text, lblDirevisiOleh.Text,
                                     lblJamMulaiRevisi.Text, lblJamSelesaiRevisi.Text)
                Else
                    DataOpsPengirim.UpdatePengirim(lblID.Text, txtNamaKontak.Text,
                                     txtAlamat.Text, cbxProvinsi.Text, cbxKabupaten.Text,
                                     cbxKecamatan.Text, tlp_rmh, tlp_selular, txtEmail.Text,
                                     fee, cbxPembayaranFee.Text, cbxBank.Text, no_rek,
                                     txtAtasNama.Text, txtKeterangan.Text, lblDirevisiOleh.Text,
                                     lblJamMulaiRevisi.Text, lblJamSelesaiRevisi.Text)
                End If


                'hapus()
                'lblID.Text = DataOps.ReadMaxIDPengirim + 1
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        hapus()
    End Sub
#End Region

#Region "Hapus dan validateAllFields"
    Private Function validateAllFileds() As Integer
        Dim value As Integer = 1

        If (txtNamaKontak.Text = "") Then
            My.Dialogs.WarningDialog("Nama harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtNamaKontak.Text = "") Then
            My.Dialogs.WarningDialog("Nama harus di isi !", "Perhatian")
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
            My.Dialogs.WarningDialog("E-mail harus di isi !", "Perhatian")
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

    Private Sub hapus()
        lblID.Text = ""
        txtNamaKontak.Text = ""
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
    End Sub

#End Region

#Region "Form Close"
    Private Sub pengirim_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.DialogResult = Windows.Forms.CloseReason.UserClosing
    End Sub
#End Region

End Class