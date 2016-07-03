Public Class data_supplier

#Region "Form Load"
    Private Sub data_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BankTableAdapter.Fill(Me.DataSet_Lab.bank)
        Me.TableAdapterSupplier.Fill(Me.DataSet_Lab.supplier)
    End Sub
#End Region

#Region "Button click"    
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Binding Navigator Add New, Delete, Save"
    Private Sub BindingNavigatorAddNewSupplier_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewSupplier.Click
        supplier.ShowDialog()
        master_data.btnSupplier.PerformClick()
    End Sub

    Private Sub BindingNavigatorDeleteSupplier_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteSupplier.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceSupplier.RemoveCurrent()
            Me.BindingSourceSupplier.EndEdit()
            Me.TableAdapterSupplier.Update(Me.DataSet_Lab.supplier)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.BindingSourceSupplier.EndEdit()
            Me.TableAdapterSupplier.Update(Me.DataSet_Lab.supplier)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

#End Region

#Region "Datagridview double click"
    Private Sub dgSupplier_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSupplier.CellDoubleClick
        idSupplier = dgSupplier.Rows(e.RowIndex).Cells(0).Value
        DataOpsSupplier.getDataSupplier(idSupplier)
        readSupplier = 1
        supplier.ShowDialog()
        master_data.btnSupplier.PerformClick()
    End Sub

#End Region

End Class