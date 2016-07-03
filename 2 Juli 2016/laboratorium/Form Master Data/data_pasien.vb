Public Class data_pasien

#Region "Form Load"
    Private Sub data_pasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        Me.TableAdapterProvinsi.Fill(Me.DataSet_Lab.provinsi)                
        Me.TableAdapterPasien.Fill(Me.DataSet_Lab.pasien)
        Me.WindowState = FormWindowState.Maximized
    End Sub

#End Region

#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region
    
#Region "Binding Navigator Add New, Delete, Save"
    Private Sub BindingNavigatorAddNewPasien_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewPasien.Click
        pasien.ShowDialog()
        master_data.btnPasien.PerformClick()
    End Sub

    Private Sub BindingNavigatorDeletePasien_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeletePasien.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourcePasien.RemoveCurrent()
            Me.BindingSourcePasien.EndEdit()
            Me.TableAdapterPasien.Update(Me.DataSet_Lab.pasien)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.BindingSourcePasien.EndEdit()
            Me.TableAdapterPasien.Update(Me.DataSet_Lab.pasien)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Update gagal")
        End Try
    End Sub

#End Region

#Region "Datagridview double click"
    Private Sub dgPasien_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPasien.CellDoubleClick
        idPasien = dgPasien.Rows(e.RowIndex).Cells(0).Value
        DataOpsPasien.getDataPasien(idPasien)
        readPasien = 1
        pasien.ShowDialog()
        master_data.btnPasien.PerformClick()
    End Sub
#End Region
    
End Class