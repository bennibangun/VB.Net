Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class DataOperations_ReagenOnBoard

#Region "Check volume"
    Public Function ReadVolume() As Integer
        If connection.State = ConnectionState.Closed Then
            connection.ConnectionString = connString
            connection.Open()
        End If

        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT sisa_volume FROM [reagen_on_board] WHERE nama_reagen = @nama_reagen AND id = MAX(ID)"
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

#End Region

#Region "Add new pengirim"
    Private SQLCommand_InsertReagenOnBoard As String = "INSERT INTO [reagen_on_board] (id_reagen_on_board, nama_reagen, nomor_lot, nomor_batch, exp_date, peringatan_exp, " &
                                      "supplier, sisa_waktu_thn, sisa_waktu_bln, sisa_waktu_hari, R1, R2, R3, R4, tgl_input, " &
                                      "peringatan_volume, direvisi_oleh, start_jam_revisi, end_jam_revisi, keterangan) " &
                                      "VALUES (@id_reagen_on_board, @nama_reagen, @nomor_lot, @nomor_batch, @exp_date, @peringatan_exp, @kelompok, @supplier, @sisa_waktu_thn, " &
                                      "@sisa_waktu_bln, @sisa_waktu_hari, @R1, @R2, @R3, @R4, @tgl_input, @peringatan_volume, @direvisi_oleh, " &
                                      "@start_jam_revisi, @end_jam_revisi, @keterangan);"

    Public Function AddNewReagenOnBoard(ByVal id_reagen_on_board As String, ByVal nama_reagen As String, ByVal nomor_lot As String, ByVal nomor_batch As String,
                                        ByVal exp_date As Date, ByVal peringatan_exp As String,
                                        ByVal supplier As String, ByVal sisa_waktu_thn As Integer, ByVal sisa_waktu_bln As Integer,
                                        ByVal sisa_waktu_hari As Integer, ByVal R1 As Integer, ByVal R2 As Integer,
                                        ByVal R3 As Integer, ByVal R4 As Integer, ByVal tgl_input As Date,
                                        ByVal peringatan_volume As String, ByVal direvisi_oleh As String, ByVal start_jam_revisi As String,
                                        ByVal end_jam_revisi As String, ByVal keterangan As String) As String


        cmd = New SqlCommand(SQLCommand_InsertReagenOnBoard, connection)

        cmd.Parameters.AddWithValue("@id_reagen_on_board", nama_reagen)
        cmd.Parameters.AddWithValue("@nama_reagen", nama_reagen)
        cmd.Parameters.AddWithValue("@nomor_lot", nomor_lot)
        cmd.Parameters.AddWithValue("@nomor_batch", nomor_batch)

        cmd.Parameters.Add("@exp_date", SqlDbType.Date)
        cmd.Parameters("@exp_date").Value = exp_date

        cmd.Parameters.AddWithValue("@peringatan_exp", peringatan_exp)        
        cmd.Parameters.AddWithValue("@supplier", supplier)

        cmd.Parameters.Add("@sisa_waktu_thn", SqlDbType.Int)
        cmd.Parameters("@sisa_waktu_thn").Value = sisa_waktu_thn

        cmd.Parameters.Add("@sisa_waktu_bln", SqlDbType.Int)
        cmd.Parameters("@sisa_waktu_bln").Value = sisa_waktu_bln

        cmd.Parameters.Add("@sisa_waktu_hari", SqlDbType.Int)
        cmd.Parameters("@sisa_waktu_hari").Value = sisa_waktu_hari

        cmd.Parameters.Add("@R1", SqlDbType.Int)
        cmd.Parameters("@R1").Value = R1

        cmd.Parameters.Add("@R2", SqlDbType.Int)
        cmd.Parameters("@R2").Value = R2

        cmd.Parameters.Add("@R3", SqlDbType.Int)
        cmd.Parameters("@R3").Value = R3

        cmd.Parameters.Add("@R4", SqlDbType.Int)
        cmd.Parameters("@R4").Value = R4

        cmd.Parameters.Add("@tgl_input", SqlDbType.Date)
        cmd.Parameters("@tgl_input").Value = tgl_input

        cmd.Parameters.AddWithValue("@peringatan_volume", peringatan_volume)
        cmd.Parameters.AddWithValue("@direvisi_oleh", direvisi_oleh)
        cmd.Parameters.AddWithValue("@start_jam_revisi", start_jam_revisi)
        cmd.Parameters.AddWithValue("@end_jam_revisi", end_jam_revisi)
        cmd.Parameters.AddWithValue("@keterangan", keterangan)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            My.Dialogs.ExceptionDialog(ex.Message)
            Return False
        End Try

    End Function
#End Region

End Class
