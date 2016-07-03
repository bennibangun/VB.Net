Public Class data_pengirim

    Private DataOpsPengirim As New DataOperations_Pengirim

#Region "Form Load"
    Private Sub data_pengirim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BankTableAdapter.Fill(Me.DataSet_Lab.bank)
        Try
            Me.TableAdapterPengirim.Fill(Me.DataSet_Lab.pengirim)
        Catch ex As Exception
            My.Dialogs.ExceptionDialog(ex.Message)
        End Try
        dgPengirim.Refresh()
    End Sub
#End Region
    
#Region "Button click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
#End Region

#Region "Binding Navigator Add New, Delete, Save"
    Private Sub BindingNavigatorAddNewPengirim_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewPengirim.Click
        pengirim.ShowDialog()
        master_data.btnPengirim.PerformClick()
        dgPengirim.Refresh()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.BindingSourcePengirim.EndEdit()
            Me.TableAdapterPengirim.Update(Me.DataSet_Lab.pengirim)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub BindingNavigatorDeletePengirim_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeletePengirim.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourcePengirim.RemoveCurrent()
            Me.BindingSourcePengirim.EndEdit()
            Me.TableAdapterPengirim.Update(Me.DataSet_Lab.pengirim)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

#End Region

#Region "Datagridview double click"
    Private Sub dgPengirim_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPengirim.CellDoubleClick
        idPengirim = dgPengirim.Rows(e.RowIndex).Cells(0).Value
        DataOpsPengirim.getDataPengirim(idPengirim)
        readPengirim = 1
        pengirim.ShowDialog()
        master_data.btnPengirim.PerformClick()
    End Sub
#End Region
    
End Class