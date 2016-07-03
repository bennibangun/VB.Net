Public Class penetapan_awal

#Region "Prioritas"
    Private namaPrioritas As Object
    Private idPrioritas As Object
#End Region

#Region "Bagian"
    WithEvents bsBagian As New BindingSource
    Private namaBagian As Object
    Private DataOpsBagian As New DataOperations_Bagian
    Private idBagian As Object
#End Region

#Region "Satuan Kuantitas"
    Private satuanKuantitas As Object
    Private idKuantitas As Object
#End Region

#Region "Satuan Isi"
    Private satuanIsi As Object
    Private idIsi As Object
#End Region

#Region "Kelompok"
    Private namaKelompok As Object
    Private idKelompok As Object
#End Region

#Region "Cara Bayar"
    Private idCaraBayar As Object
    Private namaCaraBayar As Object
#End Region

#Region "Bank"
    Private idBank As Object
    Private namaBank As Object
#End Region

#Region "Pengambilan Hasil"
    Private idPengambilanHasil As Object
    Private namaPengambilanHasil As Object
#End Region

#Region "Bahan Pemeriksaan"
    Private idBahanPemeriksaan As Object
    Private namaBahanPemeriksaan As Object
#End Region

#Region "Nama Tabung"
    Private idNamaTabung As Object
    Private namaNamaTabung As Object
#End Region
    


    Private Sub btnSimpanPrioritas_Click(sender As Object, e As EventArgs) Handles btnSimpanPrioritas.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            If (txtPrioritas.Text <> "") Then
                DataOps.AddPrioritas(txtPrioritas.Text)
                txtPrioritas.Text = ""
                lblIDPrioritas.Text = DataOps.ReadMaxIDPrioritas + 1
            Else
                My.Dialogs.WarningDialog("Prioritas harus di isi !", "Perhatian")
            End If
        End If
    End Sub

    Private Sub btnSimpanCaraBayar_Click(sender As Object, e As EventArgs) Handles btnSimpanCaraBayar.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            DataOps.AddCaraBayar(txtCaraBayar.Text)
            txtCaraBayar.Text = ""
            lblIDCaraBayar.Text = DataOps.ReadMaxIDCaraBayar + 1
        Else
            My.Dialogs.WarningDialog("Cara bayar harus di isi !", "Perhatian")
        End If
    End Sub

    Private Sub btnSimpanBank_Click(sender As Object, e As EventArgs) Handles btnSimpanBank.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            If (txtBank.Text <> "") Then
                DataOps.AddBank(txtBank.Text)
                lblIDBank.Text = DataOps.ReadMaxIDBank + 1
            Else
                My.Dialogs.WarningDialog("Bank harus di isi !", "Perhatian")
            End If
        End If
    End Sub

    'Private Sub btnSimpanKelompok_Click(sender As Object, e As EventArgs)
    '    If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
    '        If (txtKelompok.Text <> "") Then
    '            DataOps.AddKelompok(txtKelompok.Text)
    '            lblIDKelompok.Text = DataOps.ReadMaxIDKelompok + 1
    '        Else
    '            My.Dialogs.WarningDialog("Kelompok harus di isi !", "Perhatian")
    '        End If
    '    End If
    'End Sub

    Private Sub btnSimpanHasil_Click(sender As Object, e As EventArgs) Handles btnSimpanHasil.Click
        If MsgBox("Anda yakin ingin simpan data ?", MsgBoxStyle.YesNo, "Simpan data") = MsgBoxResult.Yes Then
            If (txtHasil.Text <> "") Then
                DataOps.AddHasil(txtHasil.Text)
                lblIDHasil.Text = DataOps.ReadMaxIDHasil + 1
            Else
                My.Dialogs.WarningDialog("Hasil harus di isi !", "Perhatian")
            End If
        End If
    End Sub

    Private Sub penetapan_awal_Load(sender As Object, e As EventArgs) Handles MyBase.Load                        
        Me.TableAdapterNamaTabung.Fill(Me.DataSet_Lab.nama_tabung)
        Me.TableAdapterJenisKelompok.Fill(Me.DataSet_Lab.jenis_kelompok)
        Me.TableAdapterMasterKelompok.Fill(Me.DataSet_Lab.master_kelompok)
        Me.TableAdapterNamaReagen.Fill(Me.DataSet_Lab.nama_reagen)
        Me.TableAdapterMetodePemeriksaan.Fill(Me.DataSet_Lab.metode_pemeriksaan)
        Me.TableAdapterBahanPemeriksaan.Fill(Me.DataSet_Lab.bahan_pemeriksaan)
        Me.TableAdapterPengambilanHasil.Fill(Me.DataSet_Lab.pengambilan_hasil)
        Me.TableAdapterSatuanIsi.Fill(Me.DataSet_Lab.satuan_isi)
        Me.TableAdapterSatuanKuantitas.Fill(Me.DataSet_Lab.satuan_kuantitas)
        Me.TableAdapterJenisBarangHabisPakai.Fill(Me.DataSet_Lab.jenis_barang_habis_pakai)
        Me.TableAdapterHasil.Fill(Me.DataSet_Lab.hasil)        
        Me.TableAdapterCaraBayar.Fill(Me.DataSet_Lab.cara_bayar)
        Me.TableAdapterBagian.Fill(Me.DataSet_Lab.bagian)
        Me.TableAdapterPrioritas.Fill(Me.DataSet_Lab.prioritas)
        Me.TableAdapterBank.Fill(Me.DataSet_Lab.bank)

    End Sub
#Region "Tab Page"
    Private Sub tbpPrioritas_Enter(sender As Object, e As EventArgs) Handles tbpPrioritas.Enter
        If (DataOps.ReadIDPrioritas(1) = 0) Then
            lblIDPrioritas.Text = 1
        Else
            lblIDPrioritas.Text = DataOps.ReadMaxIDPrioritas + 1
        End If
    End Sub


    Private Sub tbpCaraBayar_Enter(sender As Object, e As EventArgs) Handles tbpCaraBayar.Enter
        If (DataOps.ReadIDCaraBayar(1) = 0) Then
            lblIDCaraBayar.Text = 1
        Else
            lblIDCaraBayar.Text = DataOps.ReadMaxIDCaraBayar + 1
        End If
    End Sub

    Private Sub tbpBank_Enter(sender As Object, e As EventArgs) Handles tbpBank.Enter
        If (DataOps.ReadIDBank(1) = 0) Then
            lblIDBank.Text = 1
        Else
            lblIDBank.Text = DataOps.ReadMaxIDBank + 1
        End If
    End Sub

    'Private Sub tbpKelompok_Enter(sender As Object, e As EventArgs) Handles tbpJenisKelompok.Enter
    '    If (DataOps.ReadIDKelompok(1) = 0) Then
    '        lblIDKelompok.Text = 1
    '    Else
    '        lblIDKelompok.Text = DataOps.ReadMaxIDKelompok + 1
    '    End If
    'End Sub

    Private Sub tbpHasil_Enter(sender As Object, e As EventArgs) Handles tbpHasil.Enter
        If (DataOps.ReadIDHasil(1) = 0) Then
            lblIDHasil.Text = 1
        Else
            lblIDHasil.Text = DataOps.ReadMaxIDHasil + 1
        End If
    End Sub

    Private Sub tbpBagian_Enter(sender As Object, e As EventArgs) Handles tbpKelompok.Enter
        'Dim DataOpsBagian As New DataOperations_Bagian
        'bsBagian.DataSource = DataOpsBagian.GetBagian
        'dgBagian.DataSource = bsBagian
        'Me.BindingNavigator.BindingSource = Me.BindingSourceBagian
    End Sub

    Private Sub tbpJenisBarangHabisPakai_Enter(sender As Object, e As EventArgs) Handles tbpJenisBarangHabisPakai.Enter
        If (DataOpsBrgHabisPakai.ReadID_JenisBarangHabisPakai = 0) Then
            lblIDJenisBarangHabisPakai.Text = 1
        Else
            lblIDJenisBarangHabisPakai.Text = DataOpsBrgHabisPakai.ReadMaxID_JenisBarangHabisPakai + 1
        End If
    End Sub

    Private Sub tbpBahanPemeriksaan_Click(sender As Object, e As EventArgs) Handles tbpBahanPemeriksaan.Click
        If (DataOpsBahanPemeriksaan.ReadIDBahanPemeriksaan = 0) Then
            lblIDHasil.Text = 1
        Else
            lblIDHasil.Text = DataOpsBahanPemeriksaan.ReadMaxIDBahanPemeriksaan + 1
        End If
    End Sub

#End Region

#Region "Button Save"

    Private Sub SaveButtonNamaTabung_Click(sender As Object, e As EventArgs) Handles SaveButtonNamaTabung.Click
        Try
            Me.Validate()
            Me.BindingSourceNamaTabung.EndEdit()
            Me.TableAdapterNamaTabung.Update(Me.DataSet_Lab.nama_tabung)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
    Private Sub SaveButtonKelompok_Click(sender As Object, e As EventArgs) Handles SaveButtonKelompok.Click
        Try
            Me.Validate()
            Me.BindingSourceKelompok.EndEdit()
            Me.TableAdapterMasterKelompok.Update(Me.DataSet_Lab.master_kelompok)
            MsgBox("Data berhasil di input")                        
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonPrioritas_Click(sender As Object, e As EventArgs) Handles SaveButtonPrioritas.Click
        Try
            Me.Validate()
            Me.BindingSourcePrioritas.EndEdit()
            Me.TableAdapterPrioritas.Update(Me.DataSet_Lab.prioritas)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonCaraBayar_Click(sender As Object, e As EventArgs) Handles SaveButtonCaraBayar.Click
        Try
            Me.Validate()
            Me.BindingSourceCaraBayar.EndEdit()
            Me.TableAdapterCaraBayar.Update(Me.DataSet_Lab.cara_bayar)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonBank_Click(sender As Object, e As EventArgs) Handles SaveButtonBank.Click
        Try
            Me.Validate()
            Me.BindingSourceBank.EndEdit()
            Me.TableAdapterBank.Update(Me.DataSet_Lab.bank)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonJenisKelompok_Click(sender As Object, e As EventArgs) Handles SaveButtonJenisKelompok.Click
        Try
            Me.Validate()
            Me.BindingSourceJenisKelompok.EndEdit()
            Me.TableAdapterJenisKelompok.Update(Me.DataSet_Lab.jenis_kelompok)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonHasil_Click(sender As Object, e As EventArgs) Handles SaveButtonHasil.Click
        Try
            Me.Validate()
            Me.BindingSourceHasil.EndEdit()
            Me.TableAdapterHasil.Update(Me.DataSet_Lab.hasil)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonJenisBarangHabisPakai_Click(sender As Object, e As EventArgs) Handles SaveButtonJenisBarangHabisPakai.Click
        Try
            Me.Validate()
            Me.BindingSourceJenisBarangHabisPakai.EndEdit()
            Me.TableAdapterJenisBarangHabisPakai.Update(Me.DataSet_Lab.jenis_barang_habis_pakai)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonSatuanKuantitas_Click(sender As Object, e As EventArgs) Handles SaveButtonSatuanKuantitas.Click
        Try
            Me.Validate()
            Me.BindingSourceSatuanKuantitas.EndEdit()
            Me.TableAdapterSatuanKuantitas.Update(Me.DataSet_Lab.satuan_kuantitas)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonSatuanIsi_Click(sender As Object, e As EventArgs) Handles SaveButtonSatuanIsi.Click
        Try
            Me.Validate()
            Me.BindingSourceSatuanIsi.EndEdit()
            Me.TableAdapterSatuanIsi.Update(Me.DataSet_Lab.satuan_isi)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonBahanPemeriksaan_Click(sender As Object, e As EventArgs) Handles SaveButtonBahanPemeriksaan.Click
        Try
            Me.Validate()
            Me.BindingSourceBahanPemeriksaan.EndEdit()
            Me.TableAdapterBahanPemeriksaan.Update(Me.DataSet_Lab.bahan_pemeriksaan)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonMetodePemeriksaan_Click(sender As Object, e As EventArgs) Handles SaveButtonMetodePemeriksaan.Click
        Try
            Me.Validate()
            Me.BindingSourceMetodePemeriksaan.EndEdit()
            Me.TableAdapterMetodePemeriksaan.Update(Me.DataSet_Lab.metode_pemeriksaan)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub SaveButtonNamaReagen_Click(sender As Object, e As EventArgs) Handles SaveButtonNamaReagen.Click
        Try
            Me.Validate()
            Me.BindingSourceNamaReagen.EndEdit()
            Me.TableAdapterNamaReagen.Update(Me.DataSet_Lab.nama_reagen)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

#End Region

#Region "Button Delete"

    Private Sub BindingNavigatorDeleteNamaTabung_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteNamaTabung.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceNamaTabung.RemoveCurrent()
            Me.BindingSourceNamaTabung.EndEdit()
            Me.TableAdapterNamaTabung.Update(Me.DataSet_Lab.nama_tabung)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItemBagian_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItemKelompok.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceBagian.RemoveCurrent()
            Me.BindingSourceBagian.EndEdit()
            Me.TableAdapterBagian.Update(Me.DataSet_Lab.bagian)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItemPrioritas_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItemPrioritas.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourcePrioritas.RemoveCurrent()
            Me.BindingSourcePrioritas.EndEdit()
            Me.TableAdapterPrioritas.Update(Me.DataSet_Lab.prioritas)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItemCaraBayar_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItemCaraBayar.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceCaraBayar.RemoveCurrent()
            Me.BindingSourceCaraBayar.EndEdit()
            Me.TableAdapterCaraBayar.Update(Me.DataSet_Lab.cara_bayar)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteBank_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteBank.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceBank.RemoveCurrent()
            Me.BindingSourceBank.EndEdit()
            Me.TableAdapterBank.Update(Me.DataSet_Lab.bank)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteKelompok_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteJenisKelompok.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceKelompok.RemoveCurrent()
            Me.BindingSourceKelompok.EndEdit()
            'Me.TableAdapterKelompok.Update(Me.DataSet_Lab.kelompok)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteHasil_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteHasil.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceHasil.RemoveCurrent()
            Me.BindingSourceHasil.EndEdit()
            Me.TableAdapterHasil.Update(Me.DataSet_Lab.hasil)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteJenisBarangHabisPakai_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteJenisBarangHabisPakai.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceJenisBarangHabisPakai.RemoveCurrent()
            Me.BindingSourceJenisBarangHabisPakai.EndEdit()
            Me.TableAdapterJenisBarangHabisPakai.Update(Me.DataSet_Lab.jenis_barang_habis_pakai)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteSatuanKuantitas_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteSatuanKuantitas.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceSatuanKuantitas.RemoveCurrent()
            Me.BindingSourceSatuanKuantitas.EndEdit()
            Me.TableAdapterSatuanKuantitas.Update(Me.DataSet_Lab.satuan_kuantitas)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteSatuanIsi_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteSatuanIsi.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceSatuanIsi.RemoveCurrent()
            Me.BindingSourceSatuanIsi.EndEdit()
            Me.TableAdapterSatuanIsi.Update(Me.DataSet_Lab.satuan_isi)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteBahanPemeriksaan_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteBahanPemeriksaan.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceBahanPemeriksaan.RemoveCurrent()
            Me.BindingSourceBahanPemeriksaan.EndEdit()
            Me.TableAdapterBahanPemeriksaan.Update(Me.DataSet_Lab.bahan_pemeriksaan)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteMetodePemeriksaan_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteMetodePemeriksaan.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceMetodePemeriksaan.RemoveCurrent()
            Me.BindingSourceMetodePemeriksaan.EndEdit()
            Me.TableAdapterMetodePemeriksaan.Update(Me.DataSet_Lab.metode_pemeriksaan)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteNamaReagen_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteNamaReagen.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceNamaReagen.RemoveCurrent()
            Me.BindingSourceNamaReagen.EndEdit()
            Me.TableAdapterNamaReagen.Update(Me.DataSet_Lab.nama_reagen)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

#End Region

#Region "Click cell datagrid"
    'Private Sub dgKelompok_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKelompok.CellClick
    '    'dgBagian.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    '    namaBagian = dgKelompok.Rows(e.RowIndex).Cells(1).Value
    '    idBagian = dgKelompok.Rows(e.RowIndex).Cells(0).Value

    '    If (namaBagian.ToString <> "") Then

    '        lblIDSatuanIsi.Text = idBagian
    '    End If

    'End Sub

    Private Sub dgPrioritas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPrioritas.CellClick
        namaPrioritas = dgPrioritas.Rows(e.RowIndex).Cells(1).Value
        idPrioritas = dgPrioritas.Rows(e.RowIndex).Cells(0).Value

        If (namaPrioritas.ToString <> "") Then
            txtPrioritas.Text = namaPrioritas
            lblIDPrioritas.Text = idPrioritas
        End If
    End Sub

    Private Sub dgCaraBayar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCaraBayar.CellClick
        namaCaraBayar = dgCaraBayar.Rows(e.RowIndex).Cells(1).Value
        idCaraBayar = dgCaraBayar.Rows(e.RowIndex).Cells(0).Value

        If (namaCaraBayar.ToString <> "") Then
            txtCaraBayar.Text = namaCaraBayar
            lblIDCaraBayar.Text = idCaraBayar
        End If
    End Sub

    Private Sub dgBank_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBank.CellClick
        namaBank = dgBank.Rows(e.RowIndex).Cells(1).Value
        idBank = dgBank.Rows(e.RowIndex).Cells(0).Value

        If (idBank.ToString = "") Then
            dgBank.Rows(e.RowIndex).Cells(0).Value = BindingNavigatorPositionItemBank.Text
        End If

        If (namaBank.ToString <> "") Then
            txtBank.Text = namaBank
            lblIDBank.Text = idBank
        End If
    End Sub

    Private Sub dgKelompok_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKelompok.CellClick
        'dgKelompok.Rows(e.RowIndex).Cells(1).Value = cbxJenisKelompok.Text
    End Sub

    'Private Sub dgKelompok_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgJenisKelompok.CellClick
    'dgJenisKelompok.Rows(e.RowIndex).Cells(1).Value = cbxJenisKelompok.Text
    'idKelompok = dgJenisKelompok.Rows(e.RowIndex).Cells(0).Value

    'If (namaKelompok.ToString <> "") Then
    '    txtKelompok.Text = namaKelompok
    '    lblIDKelompok.Text = idKelompok
    'End If
    'End Sub

    'Private Sub dgKelompok_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKelompok.CellContentClick
    'dgJenisKelompok.Rows(e.RowIndex).Cells(1).Value = cbxJenisKelompok.Text
    'End Sub

    Private Sub dgSatuanKuantitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSatuanKuantitas.CellClick
        satuanKuantitas = dgSatuanKuantitas.Rows(e.RowIndex).Cells(1).Value
        idKuantitas = dgSatuanKuantitas.Rows(e.RowIndex).Cells(0).Value

        If (satuanKuantitas.ToString <> "") Then
            txtSatuanKuantitas.Text = satuanKuantitas
            lblIDSatuanKuantitas.Text = idKuantitas
        End If
    End Sub

    Private Sub dgSatuanIsi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSatuanIsi.CellClick
        satuanIsi = dgSatuanIsi.Rows(e.RowIndex).Cells(1).Value
        idIsi = dgSatuanIsi.Rows(e.RowIndex).Cells(0).Value

        If (satuanIsi.ToString <> "") Then
            txtSatuanIsi.Text = satuanIsi
            lblIDSatuanIsi.Text = idIsi
        End If
    End Sub

    Private Sub dgBahanPemeriksaan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBahanPemeriksaan.CellClick
        namaBahanPemeriksaan = dgBahanPemeriksaan.Rows(e.RowIndex).Cells(1).Value
        idBahanPemeriksaan = dgBahanPemeriksaan.Rows(e.RowIndex).Cells(0).Value

        If (namaBahanPemeriksaan.ToString <> "") Then
            txtSatuanIsi.Text = satuanIsi
            lblIDSatuanIsi.Text = idIsi
        End If
    End Sub

#End Region

    Private Sub cbxJenisKelompok_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub cbxJenisKelompok_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    'Private Sub cbxJenisKelompok_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxJenisKelompok.SelectedIndexChanged
    '    Dim DTEmpty As New DataTable
    '    Dim DTRealData As New DataTable
    '    'DTRealData. = BindingSourceKelompok.
    '    dgKelompok.DataSource = BindingSourceKelompok

    '    If (DT.Rows.Count > 0) Then
    '        DT.Clear()
    '    End If
    'End Sub

        
    
End Class