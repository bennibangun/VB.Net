Public Class loket_pemeriksaan

#Region "Form Load"
    Private Sub loket_pemeriksaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        Me.TableAdapterLoketPemeriksaan.Fill(Me.DataSet_Lab.loket_pemeriksaan)
        Me.WindowState = FormWindowState.Maximized
    End Sub

#End Region
    

#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Binding Navigator Delete, Save"

    Private Sub BindingNavigatorDeleteLoketPemeriksaan_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteLoketPemeriksaan.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceLoketPemeriksaan.RemoveCurrent()
            Me.BindingSourceLoketPemeriksaan.EndEdit()
            Me.TableAdapterLoketPemeriksaan.Update(Me.DataSet_Lab.loket_pemeriksaan)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim emptyResult As Boolean = True

        emptyResult = checkDataGridViewEmpty(dgLoketPemeriksaan)

        If emptyResult = False Then
            Try
                Me.Validate()
                Me.BindingSourceLoketPemeriksaan.EndEdit()
                Me.TableAdapterLoketPemeriksaan.Update(Me.DataSet_Lab.loket_pemeriksaan)
                MsgBox("Data berhasil di input")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update gagal")
            End Try
        Else
            My.Dialogs.WarningDialog("Spesialisasi harus di isi !", "Perhatian")
        End If

    End Sub

#End Region

#Region "Function"
    Public Function checkDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean = True
        For r = 0 To dgLoketPemeriksaan.RowCount - 1
            If IsDBNull(dgLoketPemeriksaan.Rows(r).Cells.Item(1).Value) Then
                isEmpty = True
            Else
                isEmpty = False
            End If
        Next
        Return isEmpty
    End Function

#End Region

End Class