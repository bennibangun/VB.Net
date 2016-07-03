Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class DataOperations_BahanPemeriksaan
    Private BahanPemeriksaanDataTable As DataTable

#Region "Read ID dan ID Max"
    Public Function ReadIDBahanPemeriksaan() As Integer
        If connection.State = ConnectionState.Closed Then
            connection.ConnectionString = connString
            connection.Open()
        End If

        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT ID FROM [bahan_pemeriksaan]"
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

    Public Function ReadMaxIDBahanPemeriksaan() As Integer
        Dim returnID As Integer
        Dim result As String

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [bahan_pemeriksaan]"
            result = cmd.ExecuteScalar.ToString
            If (result <> "") Then
                returnID = CInt(cmd.ExecuteScalar)
            Else
                returnID = 0
            End If

        End Using

        Return returnID

    End Function
#End Region

End Class
