Public Class lab_rujukan

    Private Sub lab_rujukan_Load(sender As Object, e As EventArgs) Handles MyBase.Load    
        Me.TableAdapterKecamatan.Fill(Me.DataSet_Lab.kecamatan)        
        Me.TableAdapterKabupaten.Fill(Me.DataSet_Lab.kabupaten)        
        Me.ProvinsiTableAdapter.Fill(Me.DataSet_Lab.provinsi)
        Me.TableAdapterLabRujukan.Fill(Me.DataSet_Lab.lab_rujukan)
        Me.WindowState = FormWindowState.Maximized
    End Sub

#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Binding Navigator Delete, Save"

    Private Sub BindingNavigatorDeleteLabRujukan_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteLabRujukan.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceLabRujukan.RemoveCurrent()
            Me.BindingSourceLabRujukan.EndEdit()
            Me.TableAdapterLabRujukan.Update(Me.DataSet_Lab.lab_rujukan)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim emptyResult As Boolean = True

        emptyResult = checkDataGridViewEmpty(dgLabRujukan)

        If emptyResult = False Then
            Try
                Me.Validate()
                Me.BindingSourceLabRujukan.EndEdit()
                Me.TableAdapterLabRujukan.Update(Me.DataSet_Lab.lab_rujukan)
                MsgBox("Data berhasil di input")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update gagal")
            End Try
        Else
            My.Dialogs.WarningDialog("Lab Rujukan harus di isi !", "Perhatian")
        End If

    End Sub

#End Region

#Region "Function"
    Public Function checkDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean = True
        For r = 0 To dgLabRujukan.RowCount - 1
            If IsDBNull(dgLabRujukan.Rows(r).Cells.Item(1).Value) Then
                isEmpty = True
            Else
                isEmpty = False
            End If
        Next
        Return isEmpty
    End Function

#End Region

End Class