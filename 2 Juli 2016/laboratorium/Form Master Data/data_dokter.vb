Public Class data_dokter

#Region "Form Load"
    Private Sub data_dokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        Me.TableAdapterSpesialisasi.Fill(Me.DataSet_Lab.spesialisasi)
        Me.TableAdapterCaraBayar.Fill(Me.DataSet_Lab.cara_bayar)
        Me.TableAdapterBank.Fill(Me.DataSet_Lab.bank)
        Me.TableAdapterDokter.Fill(Me.DataSet_Lab.dokter)
        Me.WindowState = FormWindowState.Maximized
        dgDokter.Refresh()
    End Sub

#End Region

#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region

#Region "Binding Navigator Add New, Delete, Save"
    Private Sub BindingNavigatorAddNewDokter_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewDokter.Click
        dokter.ShowDialog()
        master_data.btnDokter.PerformClick()
    End Sub

    Private Sub BindingNavigatorDeleteDokter_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteDokter.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceDokter.RemoveCurrent()
            Me.BindingSourceDokter.EndEdit()
            Me.TableAdapterDokter.Update(Me.DataSet_Lab.dokter)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.BindingSourceDokter.EndEdit()
            Me.TableAdapterDokter.Update(Me.DataSet_Lab.dokter)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Update gagal")
        End Try
    End Sub

#End Region
    
#Region "Datagridview double click"
    Private Sub dgDokter_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDokter.CellDoubleClick
        idDokter = dgDokter.Rows(e.RowIndex).Cells(0).Value
        DataOpsDokter.getDataDokter(idDokter)
        readDokter = 1
        dokter.ShowDialog()
        master_data.btnDokter.PerformClick()
    End Sub
#End Region
    
    
End Class