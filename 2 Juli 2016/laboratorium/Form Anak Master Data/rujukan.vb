Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class rujukan

    Dim fee As Integer
    Dim tlp_rmh As Integer
    Dim tlp_selular As Integer
    Dim no_rek As Integer
    'Dim pembayaran_fee As Integer
    Dim startRevisi As String
    Dim frmDataRujukan As New data_rujukan

#Region "Form Load"
    Private Sub rujukan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableAdapterCaraBayar.Fill(Me.DataSet_Lab.cara_bayar)
        Me.TableAdapterProvinsi.Fill(Me.DataSet_Lab.provinsi)
        Me.TableAdapterKabupaten.Fill(Me.DataSet_Lab.kabupaten)
        Me.TableAdapterKecamatan.Fill(Me.DataSet_Lab.kecamatan)

        Me.WindowState = FormWindowState.Maximized
        lblJamMulaiRevisi.Text = TimeOfDay.ToString("hh:mm:ss tt")
        Timer1.Start()

        If readRujukan <> 1 Then
            If (DataOpsRujukan.ReadIDRujukan = 0) Then
                lblID.Text = 1
            Else
                lblID.Text = DataOpsRujukan.ReadMaxIDRujukan + 1
            End If
        Else
            lblID.Text = idRujukan
        End If

        '*********** show provinsi ************'
        Me.TableAdapterProvinsi.Fill(Me.DataSet_Lab.provinsi)
        Dim dtProvinsi As New DataSet_Lab.provinsiDataTable

        For Each col As DataColumn In dtProvinsi.Columns
            col.AllowDBNull = True
        Next
        Me.TableAdapterProvinsi.Fill(dtProvinsi)
        cboProvinsi.DisplayMember = "nama_provinsi"
        cboProvinsi.DataSource = dtProvinsi


        '*********** show bank ************'
        If readPengirim <> 1 Then
            Me.TableAdapterBank.Fill(Me.DataSet_Lab.bank)
            Dim dtBank As New DataSet_Lab.bankDataTable

            For Each col As DataColumn In dtBank.Columns
                col.AllowDBNull = True
            Next
            Me.TableAdapterBank.Fill(dtBank)
            cboBank.DisplayMember = "nama_bank"
            cboBank.DataSource = dtBank
        Else
            Dim comboSourceBank As New Dictionary(Of String, String)()
            comboSourceBank.Add(namaBank, "1")
            cboBank.DataSource = New BindingSource(comboSourceBank, Nothing)
            cboBank.DisplayMember = namaBank
            cboBank.ValueMember = "Key"
        End If


        If readRujukan = 1 Then
            Dim comboSourceKabupaten As New Dictionary(Of String, String)()
            comboSourceKabupaten.Add(kabupaten, "1")
            cboKabupaten.DataSource = New BindingSource(comboSourceKabupaten, Nothing)
            cboKabupaten.DisplayMember = kabupaten
            cboKabupaten.ValueMember = "Key"

            Dim comboSourceKecamatan As New Dictionary(Of String, String)()
            comboSourceKecamatan.Add(kecamatan, "1")
            cboKecamatan.DataSource = New BindingSource(comboSourceKecamatan, Nothing)
            cboKecamatan.DisplayMember = kecamatan
            cboKecamatan.ValueMember = "Key"
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim jamku As Date
        jamku = DateTime.Now
        lblTime.Text = Format(Now, "hh:mm:ss tt")
        lblDate.Text = Format(Now, "dddd, dd – MMMM – yyyy")

        lblDirevisiOleh.Text = "Joni Bangun"
        lblJamSelesaiRevisi.Text = lblTime.Text
        lblTglRevisi.Text = Date.Today.ToLongDateString
    End Sub

#End Region
   
#Region "Kabupaten, Kecamatan, Pembayaran Fee"
    Private Sub cboKabupaten_MouseClick(sender As Object, e As MouseEventArgs) Handles cboKabupaten.MouseClick
        cboKabupaten.DataSource = Nothing
        cboKabupaten.Items.Clear()

        If connection.State = ConnectionState.Closed Then
            connection.ConnectionString = connString
            connection.Open()
        End If

        If cboProvinsi.Text <> "" Then
            Dim queryString = "SELECT nama_kabupaten FROM dbo.kabupaten WHERE provinsi_id IN (SELECT id FROM provinsi WHERE nama_provinsi = '" & cboProvinsi.Text & "')"
            Dim command As New SqlCommand(queryString, connection)

            reader = command.ExecuteReader()
            Try
                While reader.Read()
                    cboKabupaten.Items.Add(reader(0))
                End While
            Finally
                reader.Close()
            End Try
        End If

    End Sub

    Private Sub cboKecamatan_MouseClick(sender As Object, e As MouseEventArgs) Handles cboKecamatan.MouseClick
        cboKecamatan.DataSource = Nothing
        cboKecamatan.Items.Clear()

        If connection.State = ConnectionState.Closed Then
            connection.ConnectionString = connString
            connection.Open()
        End If

        If cboKabupaten.Text <> "" Then
            Dim queryString = "SELECT nama_kecamatan FROM dbo.kecamatan WHERE kabupaten_id IN (SELECT id FROM kabupaten WHERE nama_kabupaten = '" & cboKabupaten.Text & "')"
            Dim command As New SqlCommand(queryString, connection)

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim reader As SqlDataReader = command.ExecuteReader()
            Try
                While reader.Read()
                    cboKecamatan.Items.Add(reader(0))
                End While
            Finally
                reader.Close()
            End Try
        End If

    End Sub

    Private Sub cboPembayaranFee_MouseClick(sender As Object, e As MouseEventArgs) Handles cboPembayaranFee.MouseClick

        If readPengirim = 1 Then
            cboPembayaranFee.DataSource = Nothing
            cboPembayaranFee.Items.Clear()
            Dim comboSourcePembayaranFee As New Dictionary(Of String, String)()
            comboSourcePembayaranFee.Add(pembayaranFee, "1")
            cboPembayaranFee.DataSource = New BindingSource(comboSourcePembayaranFee, Nothing)
            cboPembayaranFee.DisplayMember = pembayaranFee
            cboPembayaranFee.ValueMember = "Key"
        Else
            'cboPembayaranFee.Items.Clear()
        End If


        '    If connection.State = ConnectionState.Closed Then
        '        connection.ConnectionString = connString
        '        connection.Open()
        '    End If

        '    If cboKabupaten.Text <> "" Then
        '        Dim queryString = "SELECT nama_kecamatan FROM dbo.kecamatan WHERE kabupaten_id IN (SELECT id FROM kabupaten WHERE nama_kabupaten = '" & cboKabupaten.Text & "')"
        '        Dim command As New SqlCommand(queryString, connection)

        '        If connection.State = ConnectionState.Closed Then
        '            connection.Open()
        '        End If

        '        Dim reader As SqlDataReader = command.ExecuteReader()
        '        Try
        '            While reader.Read()
        '                cboKecamatan.Items.Add(reader(0))
        '            End While
        '        Finally
        '            reader.Close()
        '        End Try
        '    End If
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

#Region "Button simpan, hapus, tutup click"
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


                If readRujukan < 1 Then
                    DataOpsRujukan.AddNewRujukan(txtNamaKontak.Text,
                                     txtAlamat.Text, cboProvinsi.Text, cboKabupaten.Text,
                                     cboKecamatan.Text, tlp_rmh, tlp_selular, txtEmail.Text,
                                     fee, cboPembayaranFee.Text, cboBank.Text, no_rek,
                                     txtAtasNama.Text, txtKeterangan.Text, lblDirevisiOleh.Text,
                                     lblJamMulaiRevisi.Text, lblJamSelesaiRevisi.Text)
                Else
                    DataOpsRujukan.UpdateRujukan(lblID.Text, txtNamaKontak.Text,
                                     txtAlamat.Text, cboProvinsi.Text, cboKabupaten.Text,
                                     cboKecamatan.Text, tlp_rmh, tlp_selular, txtEmail.Text,
                                     fee, cboPembayaranFee.Text, cboBank.Text, no_rek,
                                     txtAtasNama.Text, txtKeterangan.Text, lblDirevisiOleh.Text,
                                     lblJamMulaiRevisi.Text, lblJamSelesaiRevisi.Text)
                End If


                hapus()
                lblID.Text = DataOpsRujukan.ReadMaxIDRujukan + 1
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
        lblID.Text = ""
        txtNamaKontak.Text = ""
        txtAlamat.Clear()
        cboProvinsi.SelectedIndex = -1
        cboKabupaten.SelectedIndex = -1
        cboKecamatan.SelectedIndex = -1
        txtTlpRumah.Text = ""
        txtTlpSelular.Text = ""
        txtFee.Text = ""
        cboPembayaranFee.SelectedIndex = -1
        cboBank.SelectedIndex = -1
        txtNoRekening.Text = ""
        txtAtasNama.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Function validateAllFileds() As Integer
        Dim value As Integer = 1

        If (txtNamaKontak.Text = "") Then
            My.Dialogs.WarningDialog("Nama harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtAlamat.Text = "") Then
            My.Dialogs.WarningDialog("Alamat harus di isi !", "Perhatian")
            value = 0
        ElseIf (cboProvinsi.Text = "") Then
            My.Dialogs.WarningDialog("Provinsi harus di isi !", "Perhatian")
            value = 0
        ElseIf (cboKabupaten.Text = "") Then
            My.Dialogs.WarningDialog("Kabupaten harus di isi !", "Perhatian")
            value = 0
        ElseIf (cboKecamatan.Text = "") Then
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
        ElseIf (txtFee.Text = "") Then
            My.Dialogs.WarningDialog("Fee harus di isi !", "Perhatian")
            value = 0
        ElseIf (cboPembayaranFee.Text = "") Then
            My.Dialogs.WarningDialog("Pembayaran fee harus di isi !", "Perhatian")
            value = 0
        ElseIf (cboBank.Text = "") Then
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

    Private Sub rujukan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.DialogResult = Windows.Forms.CloseReason.UserClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


End Class