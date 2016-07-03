Imports System.Data.SqlClient

Public Class DataOperations
    Private CustomerDataTable As DataTable


#Region "Pengirim"
    Public Function ReadIDPengirim() As Integer
        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT ID FROM [pengirim]"
            'cmd.CommandText = "SELECT ID FROM [pengirim] WHERE ID = @ID"
            'cmd.Parameters.AddWithValue("@ID", value)
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

    Public Function ReadMaxIDPengirim() As Integer
        Dim returnID As Integer
        Dim result As String

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [pengirim]"
            result = cmd.ExecuteScalar.ToString
            If (result <> "") Then
                returnID = CInt(cmd.ExecuteScalar)
            Else
                returnID = 0
            End If

        End Using

        Return returnID

    End Function

    'Private InsertPengirim As String = "INSERT INTO [pengirim] (nama_kontak, alamat, provinsi, kabupaten, kecamatan, telepon, " &
    '                                    "hp, email, fee, pembayaran_fee, bank, no_rekening, rekening_atas_nama, keterangan, " &
    '                                    "direvisi_oleh, start_jam_revisi, end_jam_revisi) " &
    '                                    "VALUES (@nama, @alamat, @provinsi, @kabupaten, @kecamatan, @tlp_rumah," &
    '                                    " @tlp_selular, @email, @fee, @pembayaran_fee, @bank, @no_rekening, @rekening_atas_nama, @keterangan, " &
    '                                    "@direvisi_oleh, @start_jam_revisi, @end_jam_revisi);"

    'Public Function AddNewPengirim(ByVal nama_kontak As String, ByVal alamat As String, ByVal provinsi As String,
    '                             ByVal kabupaten As String, ByVal kecamatan As String, ByVal tlp_rumah As Integer,
    '                            ByVal tlp_selular As Integer, ByVal email As String, ByVal fee As Integer, ByVal pembayaran_fee As Integer,
    '                            ByVal bank As String, ByVal no_rekening As Integer, ByVal rekening_atas_nama As String,
    '                            ByVal keterangan As String, ByVal direvisi_oleh As String, ByVal start_jam_revisi As String,
    '                            ByVal end_jam_revisi As String) As String


    '    cmd = New SqlCommand(InsertPengirim, connection)

    '    cmd.Parameters.Add("@nama", SqlDbType.Char)
    '    cmd.Parameters("@nama").Value = nama_kontak
    '    cmd.Parameters.AddWithValue("@alamat", alamat)
    '    cmd.Parameters.AddWithValue("@provinsi", provinsi)
    '    cmd.Parameters.AddWithValue("@kabupaten", kabupaten)
    '    cmd.Parameters.AddWithValue("@kecamatan", kecamatan)

    '    cmd.Parameters.Add("@tlp_rumah", SqlDbType.Int)
    '    cmd.Parameters("@tlp_rumah").Value = tlp_rumah

    '    cmd.Parameters.Add("@tlp_selular", SqlDbType.Int)
    '    cmd.Parameters("@tlp_selular").Value = tlp_selular

    '    cmd.Parameters.AddWithValue("@email", email)

    '    cmd.Parameters.Add("@fee", SqlDbType.Int)
    '    cmd.Parameters("@fee").Value = fee

    '    cmd.Parameters.Add("@pembayaran_fee", SqlDbType.VarChar)
    '    cmd.Parameters("@pembayaran_fee").Value = pembayaran_fee

    '    cmd.Parameters.AddWithValue("@bank", bank)

    '    cmd.Parameters.Add("@no_rekening", SqlDbType.Int)
    '    cmd.Parameters("@no_rekening").Value = no_rekening

    '    cmd.Parameters.AddWithValue("@rekening_atas_nama", rekening_atas_nama)
    '    cmd.Parameters.AddWithValue("@keterangan", keterangan)
    '    cmd.Parameters.AddWithValue("@direvisi_oleh", direvisi_oleh)
    '    cmd.Parameters.AddWithValue("@start_jam_revisi", start_jam_revisi)
    '    cmd.Parameters.AddWithValue("@end_jam_revisi", end_jam_revisi)        
    '    Try
    '        cmd.ExecuteNonQuery()
    '        Return True
    '    Catch ex As Exception
    '        My.Dialogs.ExceptionDialog(ex.Message)
    '        Return False
    '    End Try

    'End Function

#End Region


    Public Function GetCustomers() As DataTable
        Return CustomerDataTable
    End Function

    Public Function RemoveRow(ByVal Identifier As Integer) As Boolean
        Dim Result As Boolean = False
        Using cn As New SqlConnection With {.ConnectionString = My.Settings.ConnectionString}
            Using cmd As New SqlCommand With {.Connection = cn, .CommandText = "DELETE FROM Customer WHERE Identifier = " & Identifier.ToString}
                cn.Open()
                Result = (cmd.ExecuteNonQuery = 1)
            End Using
        End Using
        Return Result
    End Function

    Public Function RemoveRows() As Boolean
        Throw New NotImplementedException("TODO")
    End Function
    Private UpdateStatement As String = "UPDATE Customer SET CompanyName = @CompanyName, ContactName = @ContactName,ContactTitle = @ContactTitle WHERE Identifier = @Identifier"
    ''' <summary>
    ''' Responsible for updating rows that have 
    ''' Row.RowState = Modified
    ''' 
    ''' Use the same logic as done in the add method below.
    ''' </summary>
    ''' <param name="row"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' Once you understand the logic in add rows you will be capable
    ''' to implement this method
    ''' </remarks>
    Public Function UpdateRow(ByVal row As DataRow) As Boolean
        Dim Result As Boolean = False
        Using cn As New SqlConnection With {.ConnectionString = My.Settings.ConnectionString}
            Using cmd As New SqlCommand With {.Connection = cn}
                cmd.CommandText = UpdateStatement
                cmd.Parameters.AddWithValue("@CompanyName", row.Field(Of String)("CompanyName"))
                cmd.Parameters.AddWithValue("@ContactName", row.Field(Of String)("ContactTitle"))
                cmd.Parameters.AddWithValue("@ContactTitle", row.Field(Of String)("ContactTitle"))
                cmd.Parameters.AddWithValue("@Identifier", row.Field(Of Integer)("Identifier"))
                cn.Open()
                Try
                    If CInt(cmd.ExecuteNonQuery) = 1 Then
                        Result = True
                    End If
                Catch ex As Exception
                    Return False
                End Try
            End Using
        End Using
        Return Result
    End Function



    Private InsertPrioritas As String = "INSERT INTO [prioritas] (nama_prioritas) VALUES (@prioritas);"
    Public Function AddPrioritas(ByVal prioritas As String) As String
        cmd = New SqlCommand(InsertPrioritas, connection)
        cmd.Parameters.AddWithValue("@prioritas", prioritas)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            My.Dialogs.ExceptionDialog(ex.Message)
            Return False
        End Try

    End Function

    Private InsertCaraBayar As String = "INSERT INTO [cara_bayar] (nama_cara_bayar) VALUES (@cara_bayar);"
    Public Function AddCaraBayar(ByVal cara_bayar As String) As String
        cmd = New SqlCommand(InsertPrioritas, connection)
        cmd.Parameters.AddWithValue("@prioritas", cara_bayar)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            My.Dialogs.ExceptionDialog(ex.Message)
            Return False
        End Try

    End Function

    Private InsertBank As String = "INSERT INTO [bank] (nama_bank) VALUES (@bank);"
    Public Function AddBank(ByVal bank As String) As String
        cmd = New SqlCommand(InsertBank, connection)
        cmd.Parameters.AddWithValue("@bank", bank)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            My.Dialogs.ExceptionDialog(ex.Message)
            Return False
        End Try

    End Function

    Private InsertKelompok As String = "INSERT INTO [kelompok] (nama_kelompok) VALUES (@kelompok);"
    Public Function AddKelompok(ByVal kelompok As String) As String
        cmd = New SqlCommand(InsertKelompok, connection)
        cmd.Parameters.AddWithValue("@kelompok", kelompok)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            My.Dialogs.ExceptionDialog(ex.Message)
            Return False
        End Try

    End Function

    Private InsertHasil As String = "INSERT INTO [hasil] (nama_hasil) VALUES (@hasil);"
    Public Function AddHasil(ByVal hasil As String) As String
        cmd = New SqlCommand(InsertHasil, connection)
        cmd.Parameters.AddWithValue("@hasil", hasil)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            My.Dialogs.ExceptionDialog(ex.Message)
            Return False
        End Try

    End Function

    Public Function UpdateRows(ByVal table As DataTable) As Boolean
        Throw New NotImplementedException("TODO")
    End Function

    Public Function ReadIDPrioritas(ByVal value As Integer) As Integer
        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT ID FROM [prioritas] WHERE ID = @ID"
            cmd.Parameters.AddWithValue("@ID", value)
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

    Public Function ReadIDCaraBayar(ByVal value As Integer) As Integer
        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT ID FROM [cara_bayar] WHERE ID = @ID"
            cmd.Parameters.AddWithValue("@ID", value)
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

    Public Function ReadIDBank(ByVal value As Integer) As Integer
        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT ID FROM [bank] WHERE ID = @ID"
            cmd.Parameters.AddWithValue("@ID", value)
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

    Public Function ReadIDKelompok(ByVal value As Integer) As Integer
        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT ID FROM [master_kelompok] WHERE ID = @ID"
            cmd.Parameters.AddWithValue("@ID", value)
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

    Public Function ReadIDHasil(ByVal value As Integer) As Integer
        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT ID FROM [hasil] WHERE ID = @ID"
            cmd.Parameters.AddWithValue("@ID", value)
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

    Public Function ReadMaxIDBagian() As Integer
        Dim returnID As Integer

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [bagian]"
            returnID = CInt(cmd.ExecuteScalar)
        End Using

        Return returnID

    End Function

    Public Function ReadMaxIDPrioritas() As Integer
        Dim returnID As Integer

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [prioritas]"
            returnID = CInt(cmd.ExecuteScalar)
        End Using

        Return returnID

    End Function

    Public Function ReadMaxIDCaraBayar() As Integer
        Dim returnID As Integer

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [cara_bayar]"
            returnID = CInt(cmd.ExecuteScalar)
        End Using

        Return returnID

    End Function

    Public Function ReadMaxIDBank() As Integer
        Dim returnID As Integer

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [bank]"
            returnID = CInt(cmd.ExecuteScalar)
        End Using

        Return returnID

    End Function

    Public Function ReadMaxIDKelompok() As Integer
        Dim returnID As Integer

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [kelompok]"
            returnID = CInt(cmd.ExecuteScalar)
        End Using

        Return returnID

    End Function

    Public Function ReadMaxIDHasil() As Integer
        Dim returnID As Integer

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [hasil]"
            returnID = CInt(cmd.ExecuteScalar)
        End Using

        Return returnID

    End Function

End Class
