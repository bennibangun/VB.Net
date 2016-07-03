Public Class spesialisasi

#Region "Form Load"
    Private Sub spesialisasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load        
        Me.TableAdapterSpesialisasi.Fill(Me.DataSet_Lab.spesialisasi)
        Me.TableAdapterSpesialisasi.Fill(Me.DataSet_Lab.spesialisasi)
        Me.WindowState = FormWindowState.Maximized
    End Sub

#End Region
    
#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Binding Navigator Delete, Save"

    Private Sub BindingNavigatorDeleteSpesialisasi_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteSpesialisasi.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceSpesialisasi.RemoveCurrent()
            Me.BindingSourceSpesialisasi.EndEdit()
            Me.TableAdapterSpesialisasi.Update(Me.DataSet_Lab.spesialisasi)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim emptyResult As Boolean = True

        emptyResult = checkDataGridViewEmpty(dgSpesialisasi)

        If emptyResult = False Then
            Try
                Me.Validate()
                Me.BindingSourceSpesialisasi.EndEdit()
                Me.TableAdapterSpesialisasi.Update(Me.DataSet_Lab.spesialisasi)
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
        For r = 0 To dgSpesialisasi.RowCount - 1
            If IsDBNull(dgSpesialisasi.Rows(r).Cells.Item(1).Value) Then
                isEmpty = True
            Else
                isEmpty = False
            End If
        Next
        Return isEmpty
    End Function

#End Region


End Class