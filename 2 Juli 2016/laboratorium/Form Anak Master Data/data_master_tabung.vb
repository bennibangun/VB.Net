Public Class data_master_tabung

    Private Sub data_master_tabung_Load(sender As Object, e As EventArgs) Handles MyBase.Load       
        'TODO: This line of code loads data into the 'DataSet_Lab.master_tabung' table. You can move, or remove it, as needed.
        Me.TableAdapterMasterTabung.Fill(Me.DataSet_Lab.master_tabung)
        'Me.TableAdapterNamaTabung.Fill(Me.DataSet_Lab.nama_tabung)
        Me.TableAdapterJenisKelompok.Fill(Me.DataSet_Lab.jenis_kelompok)        
        Me.TableAdapterMasterTabung.Fill(Me.DataSet_Lab.master_tabung)

    End Sub

#Region "Datagridview double click"
    Private Sub dgDataMasterTabung_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDataMasterTabung.CellDoubleClick
        master_tabung.ShowDialog()
        'master_data.showReagenOnBoard()
    End Sub

#End Region
    
    Private Sub BindingNavigatorAddNewDataReagenOnBoard_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewDataTabung.Click
        master_tabung.ShowDialog()
        master_data.btnTabung.PerformClick()
    End Sub
End Class