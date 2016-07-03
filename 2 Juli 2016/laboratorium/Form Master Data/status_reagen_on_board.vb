Public Class status_reagen_on_board

#Region "Form Load"
    Private Sub reagen_on_board_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SupplierTableAdapter.Fill(Me.DataSet_Lab.supplier)
        ' Me.TableAdapterKelompok.Fill(Me.DataSet_Lab.kelompok)
        Me.TableAdapterNamaReagen.Fill(Me.DataSet_Lab.nama_reagen)
        Me.TableAdapterReagenOnBoard.Fill(Me.DataSet_Lab.reagen_on_board)

        dtpExpiredDate.Format = DateTimePickerFormat.Custom
        dtpExpiredDate.CustomFormat = "dd/MM/yyyy"
    End Sub
#End Region

#Region "Button click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
    Private Sub btnCariData_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#Region "Binding Navigator Add New, Delete, Save"
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.BindingSourceReagenOnBoard.EndEdit()
            Me.TableAdapterReagenOnBoard.Update(Me.DataSet_Lab.reagen_on_board)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteReagenOnBoard_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteReagenOnBoard.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceReagenOnBoard.RemoveCurrent()
            Me.BindingSourceReagenOnBoard.EndEdit()
            Me.TableAdapterReagenOnBoard.Update(Me.DataSet_Lab.reagen_on_board)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

#End Region

#Region "Datagridview double click"
    Private Sub dgReagenOnBoard_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReagenOnBoard.CellClick
        If (e.ColumnIndex = 3) Then
            dtpExpiredDate.Focus()
            dgReagenOnBoard.Columns(3).ValueType = GetType(Date)
            dgReagenOnBoard.Columns(3).DefaultCellStyle.Format = "dd/MM/yyyy"
            dgReagenOnBoard.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = dtpExpiredDate.Text
        End If
    End Sub
#End Region

End Class