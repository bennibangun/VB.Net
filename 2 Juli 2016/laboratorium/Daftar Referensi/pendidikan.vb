Public Class pendidikan

    Dim jenisPendidikan As String

#Region "Load Form"
    Private Sub Pendidikan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableAdapterPendidikan.Fill(Me.DataSet_Lab.pendidikan)
        Me.WindowState = FormWindowState.Maximized
    End Sub

#End Region

#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Binding Navigator Delete, Save"

    Private Sub BindingNavigatorDeletePendidikan_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeletePendidikan.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourcePendidikan.RemoveCurrent()
            Me.BindingSourcePendidikan.EndEdit()
            Me.TableAdapterPendidikan.Update(Me.DataSet_Lab.pendidikan)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim emptyResult As Boolean = True

        emptyResult = checkDataGridViewEmpty(dgPendidikan)

        If emptyResult = False Then
            Try
                Me.Validate()
                Me.BindingSourcePendidikan.EndEdit()
                Me.TableAdapterPendidikan.Update(Me.DataSet_Lab.pendidikan)
                MsgBox("Data berhasil di input")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update gagal")
            End Try
        Else
            My.Dialogs.WarningDialog("Pendidikan harus di isi !", "Perhatian")
        End If

    End Sub

#End Region

#Region "Function"
    Public Function checkDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean = True
        For r = 0 To dgPendidikan.RowCount - 1
            If IsDBNull(dgPendidikan.Rows(r).Cells.Item(1).Value) Then
                isEmpty = True
            Else
                isEmpty = False
            End If
        Next
        Return isEmpty
    End Function

#End Region
    
End Class