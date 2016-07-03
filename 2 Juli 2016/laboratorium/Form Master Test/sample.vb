Public Class sample
    Private Sub sample_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        Me.TableAdapterSample.Fill(Me.DataSet_Lab.sample)
        Me.WindowState = FormWindowState.Maximized
    End Sub

#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Binding Navigator Delete, Save"

    Private Sub BindingNavigatorMetodeSample_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteSample.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceSample.RemoveCurrent()
            Me.BindingSourceSample.EndEdit()
            Me.TableAdapterSample.Update(Me.DataSet_Lab.sample)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim emptyResult As Boolean = True

        emptyResult = checkDataGridViewEmpty(dgSample)

        If emptyResult = False Then
            Try
                Me.Validate()
                Me.BindingSourceSample.EndEdit()
                Me.TableAdapterSample.Update(Me.DataSet_Lab.sample)
                MsgBox("Data berhasil di input")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update gagal")
            End Try
        Else
            My.Dialogs.WarningDialog("Sample / Bahan Test harus di isi !", "Perhatian")
        End If

    End Sub

#End Region

#Region "Function"
    Public Function checkDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean = True
        For r = 0 To dgSample.RowCount - 1
            If IsDBNull(dgSample.Rows(r).Cells.Item(1).Value) Then
                isEmpty = True
            Else
                isEmpty = False
            End If
        Next
        Return isEmpty
    End Function

#End Region

End Class