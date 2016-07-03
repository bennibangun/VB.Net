

Partial Public Class DataSet_Lab
    Partial Class harga_pemeriksaanDataTable

        Private Sub harga_pemeriksaanDataTable_harga_pemeriksaanRowChanging(sender As Object, e As harga_pemeriksaanRowChangeEvent) Handles Me.harga_pemeriksaanRowChanging

        End Sub

    End Class

    Partial Class master_tabungDataTable

        Private Sub master_tabungDataTable_master_tabungRowChanging(sender As Object, e As master_tabungRowChangeEvent) Handles Me.master_tabungRowChanging

        End Sub

    End Class

    Partial Class nama_tabungDataTable

        Private Sub nama_tabungDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.nama_tabungColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class prioritasDataTable

        Private Sub prioritasDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.nama_prioritasColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class nilai_normalDataTable

        Private Sub nilai_normalDataTable_nilai_normalRowChanging(sender As Object, e As nilai_normalRowChangeEvent) Handles Me.nilai_normalRowChanging

        End Sub

    End Class

    Partial Class pekerjaanDataTable

        Private Sub pekerjaanDataTable_pekerjaanRowChanging(sender As Object, e As pekerjaanRowChangeEvent) Handles Me.pekerjaanRowChanging

        End Sub

    End Class

End Class

Namespace DataSet_LabTableAdapters

    Partial Public Class pekerjaanTableAdapter
    End Class
End Namespace
