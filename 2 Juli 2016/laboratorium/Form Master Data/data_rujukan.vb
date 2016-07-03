Public Class data_rujukan

#Region "Form Load"
    Private Sub data_rujukan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BankTableAdapter.Fill(Me.DataSet_Lab.bank)
        Me.TableAdapterRujukan.Fill(Me.DataSet_Lab.rujukan)
    End Sub
#End Region
    
#Region "Button click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
#End Region
    
#Region "Binding Navigator Add New, Delete, Save"
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.BindingSourceRujukan.EndEdit()
            Me.TableAdapterRujukan.Update(Me.DataSet_Lab.rujukan)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteRujukan_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteRujukan.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceRujukan.RemoveCurrent()
            Me.BindingSourceRujukan.EndEdit()
            Me.TableAdapterRujukan.Update(Me.DataSet_Lab.rujukan)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub BindingNavigatorAddNewRujukan_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewRujukan.Click
        rujukan.ShowDialog()
        master_data.btnRujukan.PerformClick()
    End Sub

#End Region

#Region "Datagridview double click"
    Private Sub dgRujukan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRujukan.CellDoubleClick
        idRujukan = dgRujukan.Rows(e.RowIndex).Cells(0).Value
        DataOpsRujukan.getDataRujukan(idRujukan)
        readRujukan = 1
        rujukan.ShowDialog()
        master_data.btnRujukan.PerformClick()
    End Sub
#End Region
    
End Class