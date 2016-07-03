Public Class data_barang_habis_pakai

    Private Sub data_barang_habis_pakai_Load(sender As Object, e As EventArgs) Handles MyBase.Load                
        Me.TableAdapterSatuanKuantitas.Fill(Me.DataSet_Lab.satuan_kuantitas)        
        Me.TableAdapterSatuanIsi.Fill(Me.DataSet_Lab.satuan_isi)        
        Me.TableAdapterJenisBarangHabisPakai.Fill(Me.DataSet_Lab.jenis_barang_habis_pakai)        
        Me.SupplierTableAdapter.Fill(Me.DataSet_Lab.supplier)        
        Me.TableAdapterBarangHabisPakai.Fill(Me.DataSet_Lab.barang_habis_pakai)
        Me.TableAdapterBarangHabisPakai.Fill(Me.DataSet_Lab.barang_habis_pakai)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.BindingSourceBarangHabisPakai.EndEdit()
            Me.TableAdapterBarangHabisPakai.Update(Me.DataSet_Lab.barang_habis_pakai)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub BindingNavigatorBarangHabisPakai_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteBarangHabisPakai.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceBarangHabisPakai.RemoveCurrent()
            Me.BindingSourceBarangHabisPakai.EndEdit()
            Me.TableAdapterBarangHabisPakai.Update(Me.DataSet_Lab.barang_habis_pakai)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorAddBarangHabisPakai_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewBarangHabisPakai.Click
        barang_habis_pakai.ShowDialog()
        master_data.btnBarangHabisPakai.PerformClick()
    End Sub


End Class