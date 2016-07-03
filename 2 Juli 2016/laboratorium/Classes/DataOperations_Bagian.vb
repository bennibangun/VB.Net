Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration

Public Class DataOperations_Bagian

    Private DataTable_Bagian As DataTable
    Public Function GetBagian() As DataTable
        Return DataTable_Bagian
    End Function

    Public Sub New()

        Me.DataTable_Bagian = New DataTable
        Me.DataTable_Bagian.Columns.Add(New DataColumn With {.ColumnName = "id", .DataType = GetType(Integer)})
        Me.DataTable_Bagian.Columns.Add(New DataColumn With {.ColumnName = "bagian", .DataType = GetType(String)})

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT id, nama_bagian FROM [bagian] ORDER BY id"
            Dim Reader = cmd.ExecuteReader
            If Reader.HasRows Then
                While Reader.Read
                    Me.DataTable_Bagian.Rows.Add(New Object() {Reader.GetInt32(0), Reader.GetString(1)})
                End While
            End If
        End Using

        Me.DataTable_Bagian.AcceptChanges()

    End Sub

    Public Sub AddBagian(ByVal table As DataTable)
        For Each row As DataRow In table.Rows
            If row.RowState = DataRowState.Added Then
                If Not String.IsNullOrEmpty(row.Field(Of String)("bagian")) Then
                    Dim newID As Integer = DataOps.ReadMaxIDBagian + 1
                    If AddNewBagian(row.Field(Of String)("bagian")) Then
                        row.SetField(Of Integer)("id", newID)
                    End If
                End If
            End If
        Next
        table.AcceptChanges()
    End Sub

   Private InsertBagian As String = "INSERT INTO [bagian] (nama_bagian) VALUES (@bagian);"
    Public Function AddNewBagian(ByVal bagian As String) As String
        cmd = New SqlCommand(InsertBagian, connection)
        cmd.Parameters.AddWithValue("@bagian", bagian)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            My.Dialogs.ExceptionDialog(ex.Message)
            Return False
        End Try

    End Function
End Class
