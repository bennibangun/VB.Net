Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class reagen_on_board

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
    Private Sub reagen_on_board_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableAdapterSupplier.Fill(Me.DataSet_Lab.supplier)
        Me.TableAdapterMasterKelompok.Fill(Me.DataSet_Lab.master_kelompok)
        Me.TableAdapterNamaReagen.Fill(Me.DataSet_Lab.nama_reagen)
        lblJamMulaiRevisi.Text = TimeOfDay.ToString("hh:mm:ss tt")
        Timer1.Start()
        Me.WindowState = FormWindowState.Maximized
    End Sub



#End Region

#Region "Button search, simpan, hapus, tutup event click"
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            Dim result = validateAllFileds()

            If result = 1 Then
                If connection.State = ConnectionState.Closed Then
                    connection.ConnectionString = connString
                    connection.Open()
                End If

                DataOpsRegionOnBoard.AddNewReagenOnBoard(txtIDReagenOnBoard.Text, cbxNamaReagen.Text, txtNomorLot.Text, txtNomorBatch.Text,
                                                         dtpExpiredDate.Text, txtPeringatanExpired.Text, cbxSupplier.Text,
                                                         txtThn.Text, txtBln.Text, txtHari.Text, txtR1.Text, txtR2.Text, txtR3.Text, txtR4.Text,
                                                         lblTglRevisi.Text, txtPeringatanVolume.Text, lblDirevisiOleh.Text, lblJamMulaiRevisi.Text,
                                                         lblJamSelesaiRevisi.Text, txtKeterangan.Text)
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        hapus()
    End Sub

    Private Sub txtNomorBatch_Click(sender As Object, e As EventArgs) Handles txtNomorBatch.Click
        txtEmpty.Visible = False
    End Sub

#End Region

#Region "Hapus dan validateAllFields"
    Private Sub hapus()
        txtIDReagenOnBoard.Text = ""
        cbxNamaReagen.SelectedIndex = -1        
        cbxSupplier.SelectedIndex = -1
        txtNomorLot.Text = ""
        txtNomorLab.Text = ""
        txtEmpty.Visible = True
        txtNomorBatch.Text = ""
        txtEmpty.Text = ""
        txtPeringatanExpired.Text = ""
        txtThn.Text = ""
        txtBln.Text = ""
        txtHari.Text = ""
        txtR1.Text = ""
        txtR2.Text = ""
        txtR3.Text = ""
        txtR4.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Function validateAllFileds() As Integer
        Dim value As Integer = 1

        If (txtIDReagenOnBoard.Text = "") Then
            My.Dialogs.WarningDialog("Kode Reagen harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxNamaReagen.Text = "") Then
            My.Dialogs.WarningDialog("Nama Reagen harus di isi !", "Perhatian")
            value = 0        
        ElseIf (txtNomorLot.Text = "") Then
            My.Dialogs.WarningDialog("Nomor Lot harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtNomorLab.Text = "") Then
            My.Dialogs.WarningDialog("Nomor Lab harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtNomorBatch.Text = "") Then
            My.Dialogs.WarningDialog("Nomor Batch harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtEmpty.Visible = True) Then
            My.Dialogs.WarningDialog("Tanggal Expired harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtPeringatanExpired.Text = "") Then
            My.Dialogs.WarningDialog("Peringatan Expired harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtThn.Text = "") Then
            My.Dialogs.WarningDialog("Sisa waktu tahun harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtBln.Text = "") Then
            My.Dialogs.WarningDialog("Sisa waktu bulan harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtHari.Text = "") Then
            My.Dialogs.WarningDialog("Sisa waktu hari harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtR1.Text = "") Then
            My.Dialogs.WarningDialog("R1 harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtR2.Text = "") Then
            My.Dialogs.WarningDialog("R2 harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtR3.Text = "") Then
            My.Dialogs.WarningDialog("R3 harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtR4.Text = "") Then
            My.Dialogs.WarningDialog("R4 harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtPeringatanVolume.Text = "") Then
            My.Dialogs.WarningDialog("Peringatan Volume harus di isi !", "Perhatian")
            value = 0
        End If
        Return value
    End Function

#End Region



    
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub txtIDReagenOnBoard_TextChanged(sender As Object, e As EventArgs) Handles txtIDReagenOnBoard.TextChanged

    End Sub
End Class