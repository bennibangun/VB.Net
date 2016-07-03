Public Class data_reagen_on_board

#Region "On Load"
    Private Sub data_reagen_on_board_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        Me.TableAdapterReagenOnBoard.Fill(Me.DataSet_Lab.reagen_on_board)
    End Sub
#End Region
    
#Region "Binding Navigator Delete, Save"
    Private Sub ButtonSaveDataReagenOnBoard_Click(sender As Object, e As EventArgs) Handles ButtonSaveDataReagenOnBoard.Click
        Try
            Me.Validate()
            Me.BindingSourceReagenOnBoard.EndEdit()
            Me.TableAdapterReagenOnBoard.Update(Me.DataSet_Lab.reagen_on_board)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Update failed")
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteDataReagenOnBoard_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteDataReagenOnBoard.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceReagenOnBoard.RemoveCurrent()
            Me.BindingSourceReagenOnBoard.EndEdit()
            Me.TableAdapterReagenOnBoard.Update(Me.DataSet_Lab.reagen_on_board)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

#End Region
    
#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
#End Region

#Region "Datagridview double click"
    Private Sub dgDataReagenOnBoard_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDataReagenOnBoard.CellDoubleClick
        reagen_on_board.ShowDialog()
        master_data.showReagenOnBoard()
    End Sub

#End Region
    
End Class