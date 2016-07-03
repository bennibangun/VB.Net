Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class DataOperations_MasterPemeriksaanSingle

    Private SQLCommand_InsertMasterPemeriksaanSingle As String = "INSERT INTO [pengirim] (nama_kontak, alamat, provinsi, kabupaten, kecamatan, telepon, " &
                                      "hp, email, fee, pembayaran_fee, bank, no_rekening, rekening_atas_nama, keterangan, " &
                                      "direvisi_oleh, start_jam_revisi, end_jam_revisi) " &
                                      "VALUES (@nama, @alamat, @provinsi, @kabupaten, @kecamatan, @tlp_rumah," &
                                      " @tlp_selular, @email, @fee, @pembayaran_fee, @bank, @no_rekening, @rekening_atas_nama, @keterangan, " &
                                      "@direvisi_oleh, @start_jam_revisi, @end_jam_revisi);"
    Public Function AddNewMasterPemeriksaanSingle(ByVal nama_kontak As String, ByVal alamat As String, ByVal provinsi As String,
                                 ByVal kabupaten As String, ByVal kecamatan As String, ByVal tlp_rumah As Integer,
                                ByVal tlp_selular As Integer, ByVal email As String, ByVal fee As Integer, ByVal pembayaran_fee As String,
                                ByVal bank As String, ByVal no_rekening As Integer, ByVal rekening_atas_nama As String,
                                ByVal keterangan As String, ByVal direvisi_oleh As String, ByVal start_jam_revisi As String,
                                ByVal end_jam_revisi As String) As String


        cmd = New SqlCommand(SQLCommand_InsertMasterPemeriksaanSingle, connection)

        cmd.Parameters.Add("@nama", SqlDbType.Char)
        cmd.Parameters("@nama").Value = nama_kontak
        cmd.Parameters.AddWithValue("@alamat", alamat)
        cmd.Parameters.AddWithValue("@provinsi", provinsi)
        cmd.Parameters.AddWithValue("@kabupaten", kabupaten)
        cmd.Parameters.AddWithValue("@kecamatan", kecamatan)

        cmd.Parameters.Add("@tlp_rumah", SqlDbType.Int)
        cmd.Parameters("@tlp_rumah").Value = tlp_rumah

        cmd.Parameters.Add("@tlp_selular", SqlDbType.Int)
        cmd.Parameters("@tlp_selular").Value = tlp_selular

        cmd.Parameters.AddWithValue("@email", email)

        cmd.Parameters.Add("@fee", SqlDbType.Int)
        cmd.Parameters("@fee").Value = fee

        cmd.Parameters.AddWithValue("@pembayaran_fee", pembayaran_fee)
        cmd.Parameters.AddWithValue("@bank", bank)

        cmd.Parameters.Add("@no_rekening", SqlDbType.Int)
        cmd.Parameters("@no_rekening").Value = no_rekening

        cmd.Parameters.AddWithValue("@rekening_atas_nama", rekening_atas_nama)
        cmd.Parameters.AddWithValue("@keterangan", keterangan)
        cmd.Parameters.AddWithValue("@direvisi_oleh", direvisi_oleh)
        cmd.Parameters.AddWithValue("@start_jam_revisi", start_jam_revisi)
        cmd.Parameters.AddWithValue("@end_jam_revisi", end_jam_revisi)
        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            My.Dialogs.ExceptionDialog(ex.Message)
            Return False
        End Try

    End Function

End Class
