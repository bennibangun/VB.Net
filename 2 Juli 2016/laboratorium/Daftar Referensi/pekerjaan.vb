Public Class pekerjaan

#Region "Form Load"
    Private Sub jenis_pekerjaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableAdapterPekerjaan.Fill(Me.DataSet_Lab.pekerjaan)
        Me.WindowState = FormWindowState.Maximized
    End Sub

#End Region

#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Binding Navigator Delete, Save"

    Private Sub BindingNavigatorDeletePekerjaan_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeletePekerjaan.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourcePekerjaan.RemoveCurrent()
            Me.BindingSourcePekerjaan.EndEdit()
            Me.TableAdapterPekerjaan.Update(Me.DataSet_Lab.pekerjaan)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim emptyResult As Boolean = True

        emptyResult = checkDataGridViewEmpty(dgPekerjaan)

        If emptyResult = False Then
            Try
                Me.Validate()
                Me.BindingSourcePekerjaan.EndEdit()
                Me.TableAdapterPekerjaan.Update(Me.DataSet_Lab.pekerjaan)
                MsgBox("Data berhasil di input")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update gagal")
            End Try
        Else
            My.Dialogs.WarningDialog("Pekerjaan harus di isi !", "Perhatian")
        End If

    End Sub

#End Region

#Region "Function"
    Public Function IsDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean = True
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrEmpty(cell.Value) Then
                    If Not String.IsNullOrEmpty(Trim(cell.Value.ToString())) Then
                        isEmpty = False
                        'Exit For
                    Else
                        isEmpty = True
                    End If
                End If
            Next
        Next
        Return isEmpty

    End Function

    Public Function checkDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean = True
        For r = 0 To dgPekerjaan.RowCount - 1
            If IsDBNull(dgPekerjaan.Rows(r).Cells.Item(1).Value) Then
                isEmpty = True
            Else
                isEmpty = False
            End If    
        Next
        Return isEmpty

    End Function
    
#End Region

End Class