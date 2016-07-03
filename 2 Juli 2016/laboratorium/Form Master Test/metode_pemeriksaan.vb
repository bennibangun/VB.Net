Public Class metode_pemeriksaan

#Region "Form Load"
    Private Sub metode_pemeriksaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableAdapterMetodePemeriksaan.Fill(Me.DataSet_Lab.metode_pemeriksaan)
        Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region
    
#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Binding Navigator Delete, Save"

    Private Sub BindingNavigatorMetodePemeriksaan_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteMetodePemeriksaan.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceMetodePemeriksaan.RemoveCurrent()
            Me.BindingSourceMetodePemeriksaan.EndEdit()
            Me.TableAdapterMetodePemeriksaan.Update(Me.DataSet_Lab.metode_pemeriksaan)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim emptyResult As Boolean = True

        emptyResult = checkDataGridViewEmpty(dgMetodePemeriksaan)

        If emptyResult = False Then
            Try
                Me.Validate()
                Me.BindingSourceMetodePemeriksaan.EndEdit()
                Me.TableAdapterMetodePemeriksaan.Update(Me.DataSet_Lab.metode_pemeriksaan)
                MsgBox("Data berhasil di input")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update gagal")
            End Try
        Else
            My.Dialogs.WarningDialog("Metode Pemeriksaan harus di isi !", "Perhatian")
        End If

    End Sub

#End Region

#Region "Function"
    Public Function checkDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean = True
        For r = 0 To dgMetodePemeriksaan.RowCount - 1
            If IsDBNull(dgMetodePemeriksaan.Rows(r).Cells.Item(1).Value) Then
                isEmpty = True
            Else
                isEmpty = False
            End If
        Next
        Return isEmpty
    End Function

#End Region

End Class