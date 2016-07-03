Public Class data_reagen_on_board

#Region "Form Load"
    Private Sub data_reagen_on_board_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        Me.TableAdapterMasterKelompok.Fill(Me.DataSet_Lab.master_kelompok)
        Me.TableAdapterSupplier.Fill(Me.DataSet_Lab.supplier)
        Me.TableAdapterNamaReagen.Fill(Me.DataSet_Lab.nama_reagen)
        Me.TableAdapterReagenOnBoard.Fill(Me.DataSet_Lab.reagen_on_board)
        Me.TableAdapterSupplier.Fill(Me.DataSet_Lab.supplier)        
        Me.TableAdapterNamaReagen.Fill(Me.DataSet_Lab.nama_reagen)
    End Sub
#End Region
    
#Region "Button search, simpan, hapus, tutup event click"
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            Dim result = validateAllFileds()

        End If
    End Sub
#End Region

#Region "Hapus dan validateAllFields"
    Private Sub hapus()
        txtKodeReagen.Text = ""
        cbxNamaReagen.SelectedIndex = -1
        cbxKelompok.SelectedIndex = -1
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

        If (cbxNamaReagen.Text = "") Then
            My.Dialogs.WarningDialog("Nama Reagen harus di isi !", "Perhatian")
            value = 0
        ElseIf (cbxKelompok.Text = "") Then
            My.Dialogs.WarningDialog("Kelompok harus di isi !", "Perhatian")
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
        ElseIf (txtPeringatanExpired.Text = "") Then
            My.Dialogs.WarningDialog("Peringatan Expired harus di isi !", "Perhatian")
            value = 0
        ElseIf (txtThn.Text = "") Then
            My.Dialogs.WarningDialog("Sisa waktu tahun fee harus di isi !", "Perhatian")
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
        End If
        Return value
    End Function

#End Region
End Class