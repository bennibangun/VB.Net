Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class MasterPemeriksaanSingle

#Region "Variabel Barang Habis Pakai"
    Dim kodeBarangHabisPakai As String
    Dim jenisBarangHabisPakai As String
    Dim jumlahBarangHabisPakai As Int16
#End Region
    
#Region "Variabel Nilai Normal"
    Dim dataDeskripsi As String
    Dim dataJenisKelamin As String
    Dim dataUmurBawahTahun As Int16
    Dim dataUmurBawahBulan As Int16
    Dim dataUmurBawahHari As Int16
    Dim dataUmurAtasTahun As Int16
    Dim dataUmurAtasBulan As Int16
    Dim dataUmurAtasHari As Int16
    Dim dataNilaiKritisAtas As Int16
    Dim dataNilaiKritisBawah As Int16
    Dim dataNilaiBatasAtas As Int16
    Dim dataNilaiBatasBawah As Int16
#End Region

#Region "Load Table Adapter"
    Private Sub MasterPemeriksaanSingle_Load(sender As Object, e As EventArgs) Handles MyBase.Load                
        Me.TableAdapterHargaPemeriksaan.Fill(Me.DataSet_Lab.harga_pemeriksaan)                
        Me.TableAdapterJenisBarangHabisPakai.Fill(Me.DataSet_Lab.jenis_barang_habis_pakai)
        Me.TableAdapterBarangHabisPakai.Fill(Me.DataSet_Lab.barang_habis_pakai)
        Me.TableAdapterPrioritas.Fill(Me.DataSet_Lab.prioritas)        
        Me.TableAdapterSatuanIsi.Fill(Me.DataSet_Lab.satuan_isi)
        Me.TableAdapterNilaiNormal.Fill(Me.DataSet_Lab.nilai_normal)
        Me.TableAdapterReagenOnBoard.Fill(Me.DataSet_Lab.reagen_on_board)
        Me.TableAdapterRujukan.Fill(Me.DataSet_Lab.rujukan)
        Me.TableAdapterBahanPemeriksaan.Fill(Me.DataSet_Lab.bahan_pemeriksaan)
        Me.TableAdapterMetodePemeriksaan.Fill(Me.DataSet_Lab.metode_pemeriksaan)
        Me.TableAdapterInstrument.Fill(Me.DataSet_Lab.instrument)
        Me.TableAdapterMasterKelompok.Fill(Me.DataSet_Lab.master_kelompok)
        Me.WindowState = FormWindowState.Maximized

    End Sub

#End Region

#Region "Make datagridview only accept numeric value"
    Private Sub dgBarangHabisPakai_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgBarangHabisPakai.EditingControlShowing

        If dgBarangHabisPakai.CurrentCell.ColumnIndex = 2 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Numeric_Only
            'ElseIf dgBarangHabisPakai.CurrentCell.ColumnIndex = 1 Then
            'AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Numeric_and_Decimal
        End If

        If (dgNilaiNormal.CurrentCell.ColumnIndex = 2) Or dgNilaiNormal.CurrentCell.ColumnIndex = 3 Or dgNilaiNormal.CurrentCell.ColumnIndex = 4 Or dgNilaiNormal.CurrentCell.ColumnIndex = 5 Or dgNilaiNormal.CurrentCell.ColumnIndex = 6 Or dgNilaiNormal.CurrentCell.ColumnIndex = 7 Or dgNilaiNormal.CurrentCell.ColumnIndex = 8 Or dgNilaiNormal.CurrentCell.ColumnIndex = 9 Or dgNilaiNormal.CurrentCell.ColumnIndex = 10 Or dgNilaiNormal.CurrentCell.ColumnIndex = 11 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Numeric_Only
        End If

    End Sub

    Private Sub dgNilaiNormal_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgNilaiNormal.EditingControlShowing

        If (dgNilaiNormal.CurrentCell.ColumnIndex = 2) Or dgNilaiNormal.CurrentCell.ColumnIndex = 3 Or dgNilaiNormal.CurrentCell.ColumnIndex = 4 Or dgNilaiNormal.CurrentCell.ColumnIndex = 5 Or dgNilaiNormal.CurrentCell.ColumnIndex = 6 Or dgNilaiNormal.CurrentCell.ColumnIndex = 7 Or dgNilaiNormal.CurrentCell.ColumnIndex = 8 Or dgNilaiNormal.CurrentCell.ColumnIndex = 9 Or dgNilaiNormal.CurrentCell.ColumnIndex = 10 Or dgNilaiNormal.CurrentCell.ColumnIndex = 11 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Numeric_Only
        End If

    End Sub

    Private Sub Numeric_Only(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If (Char.IsDigit(CChar(CStr(e.KeyChar))) = False And e.KeyChar <> Convert.ToChar(Keys.Back)) Then e.Handled = True
    End Sub

    Private Sub Numeric_and_Decimal(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not ((Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") And (e.KeyChar <> Convert.ToChar(Keys.Back))) Then e.Handled = True
    End Sub
#End Region

#Region "Get Data Barang Habis Pakai"
    Private Sub dgBarangHabisPakai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBarangHabisPakai.CellClick

        If Not IsDBNull(dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value) Then
            kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
            jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
            jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
        End If

    End Sub


    'Private Sub dgBarangHabisPakai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBarangHabisPakai.CellContentClick
    '    kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
    '    jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
    '    jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
    'End Sub

    Private Sub dgBarangHabisPakai_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgBarangHabisPakai.CellEndEdit
        kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
        jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub dgBarangHabisPakai_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgBarangHabisPakai.CellEnter
        kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
        jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
    End Sub

    'Private Sub dgBarangHabisPakai_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgBarangHabisPakai.CellMouseClick
    '    kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
    '    jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
    '    jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
    'End Sub

    'Private Sub dgBarangHabisPakai_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgBarangHabisPakai.CellMouseDoubleClick
    '    kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
    '    jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
    '    jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
    'End Sub

    'Private Sub dgBarangHabisPakai_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgBarangHabisPakai.CellMouseDown
    '    kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
    '    jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
    '    jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
    'End Sub

    'Private Sub dgBarangHabisPakai_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgBarangHabisPakai.ColumnHeaderMouseClick
    '    kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
    '    jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
    '    jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
    'End Sub

#End Region

#Region "Harga Pemeriksaan"

#End Region

#Region "Nilai Normal"

#End Region

#Region "Button Click"
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
#End Region

#Region "Get Data Nilai Normal & merge column Nilai Batas Bawah and Nilai Batas Atas"
    Private Sub dgNilaiNormal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgNilaiNormal.CellClick
        dataDeskripsi = dgNilaiNormal.Rows(e.RowIndex).Cells(0).Value
        dataJenisKelamin = dgNilaiNormal.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgNilaiNormal.Rows(e.RowIndex).Cells(2).Value
        dgNilaiNormal.Rows(e.RowIndex).Cells(12).Value = dgNilaiNormal.Rows(e.RowIndex).Cells(10).Value & " - " & dgNilaiNormal.Rows(e.RowIndex).Cells(11).Value
    End Sub


    Private Sub dgNilaiNormal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgNilaiNormal.CellContentClick
        kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
        jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
        dgNilaiNormal.Rows(e.RowIndex).Cells(12).Value = dgNilaiNormal.Rows(e.RowIndex).Cells(10).Value & " - " & dgNilaiNormal.Rows(e.RowIndex).Cells(11).Value
    End Sub

    Private Sub dgNilaiNormal_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgNilaiNormal.CellEndEdit
        kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
        jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
        dgNilaiNormal.Rows(e.RowIndex).Cells(12).Value = dgNilaiNormal.Rows(e.RowIndex).Cells(10).Value & " - " & dgNilaiNormal.Rows(e.RowIndex).Cells(11).Value
    End Sub

    Private Sub dgNilaiNormal_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgNilaiNormal.CellEnter
        kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
        jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
        dgNilaiNormal.Rows(e.RowIndex).Cells(12).Value = dgNilaiNormal.Rows(e.RowIndex).Cells(10).Value & " - " & dgNilaiNormal.Rows(e.RowIndex).Cells(11).Value
    End Sub

    Private Sub dgNilaiNormal_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgNilaiNormal.CellMouseClick
        kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
        jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
        dgNilaiNormal.Rows(e.RowIndex).Cells(12).Value = dgNilaiNormal.Rows(e.RowIndex).Cells(10).Value & " - " & dgNilaiNormal.Rows(e.RowIndex).Cells(11).Value
    End Sub

    Private Sub dgNilaiNormal_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgNilaiNormal.CellMouseDoubleClick
        kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
        jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
        dgNilaiNormal.Rows(e.RowIndex).Cells(12).Value = dgNilaiNormal.Rows(e.RowIndex).Cells(10).Value & " - " & dgNilaiNormal.Rows(e.RowIndex).Cells(11).Value
    End Sub

    Private Sub dgNilaiNormal_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgNilaiNormal.CellMouseDown
        kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
        jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
        dgNilaiNormal.Rows(e.RowIndex).Cells(12).Value = dgNilaiNormal.Rows(e.RowIndex).Cells(10).Value & " - " & dgNilaiNormal.Rows(e.RowIndex).Cells(11).Value
    End Sub

    Private Sub dgNilaiNormal_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgNilaiNormal.ColumnHeaderMouseClick
        kodeBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(0).Value
        jenisBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(1).Value
        jumlahBarangHabisPakai = dgBarangHabisPakai.Rows(e.RowIndex).Cells(2).Value
        dgNilaiNormal.Rows(e.RowIndex).Cells(12).Value = dgNilaiNormal.Rows(e.RowIndex).Cells(10).Value & " - " & dgNilaiNormal.Rows(e.RowIndex).Cells(11).Value
    End Sub
#End Region

#Region "Save"
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then

            'If connection.State = ConnectionState.Closed Then
            '    connection.ConnectionString = connString
            '    connection.Open()

            '    DataOperations_MasterPemeriksaanSingle(txtKodePemeriksaan.Text, txtNamaPemeriksaan.Text, cbxKelompok.Text, txtSatuan.Text,
            '                                           cbxSatuan.Text, txtDecimalHasil.Text, cbxInstrument.Text, cbxMetodePemeriksaan.Text,
            '                                           cbxBahanPemeriksaan.Text, txtNilaiKritis.Text, cbxRujukan.Text, txtKodeReagen.Text,
            '                                           txtNamaReagen.Text, txtPemakaianR1.Text, txtPemakaianR2.Text, txtPemakaianR3.Text,
            '                                           txtPemakaianR4.Text, txtKeterangan.Text, kodeBarangHabisPakai, jenisBarangHabisPakai,
            '                                           jumlahBarangHabisPakai, )
            'End If

        End If
    End Sub
#End Region

    
End Class