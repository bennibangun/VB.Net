Public Class data_instrument

#Region "On Load"
    Private Sub data_instrument_Load(sender As Object, e As EventArgs) Handles MyBase.Load                
        Me.TableAdapterInstrument.Fill(Me.DataSet_Lab.instrument)        
    End Sub
#End Region

#Region "Button Click"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region
    
#Region "Binding Navigator Delete, Save"
    Private Sub BindingNavigatorDeleteInstrument_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteInstrument.Click
        If MsgBox("Anda yakin ingin hapus data ?", MsgBoxStyle.YesNo, "Hapus data") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.BindingSourceInstrument.RemoveCurrent()
            Me.BindingSourceInstrument.EndEdit()
            Me.TableAdapterInstrument.Update(Me.DataSet_Lab.instrument)
            'Me.TableAdapterInstrument.Update(Me.DataSet_Lab.instrument)
            MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub ButtonSaveInstrument_Click(sender As Object, e As EventArgs) Handles ButtonSaveInstrument.Click
        Try
            Me.Validate()
            Me.BindingSourceInstrument.EndEdit()
            Me.TableAdapterInstrument.Update(Me.DataSet_Lab.instrument)
            MsgBox("Data berhasil di input")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Update failed")
        End Try
    End Sub

#End Region

End Class