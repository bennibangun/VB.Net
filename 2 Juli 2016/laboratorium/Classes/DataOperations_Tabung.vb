Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class DataOperations_Tabung

#Region "Get data from database and show the result in child form"

#End Region

#Region "Add new tabung"

    Private SQLCommand_InsertTabung As String = "INSERT INTO [master_tabung] (kode_tabung, kelompok, nama_tabung, " &
                                       "kuantitas, exp_date, sisa_waktu_thn, sisa_waktu_bln, sisa_waktu_hari, peringatan_exp, " &
                                       "peringatan_jumlah, direvisi_oleh, start_jam_revisi, end_jam_revisi) " &
                                       "VALUES (@kode_tabung, @kelompok, @nama_tabung, @kuantitas, @exp_date, @sisa_waktu_thn, " &
                                       "@sisa_waktu_bln, @sisa_waktu_hari, @peringatan_exp, @peringatan_jumlah, @direvisi_oleh, " &
                                       "@start_jam_revisi, @end_jam_revisi);"

    Public Function AddNewTabung(ByVal kode_tabung As String, ByVal kelompok As String,
                                 ByVal nama_tabung As String, ByVal kuantitas As Integer, ByVal exp_date As Date, ByVal sisa_waktu_thn As Integer,
                                 ByVal sisa_waktu_bln As Integer, ByVal sisa_waktu_hari As Integer, ByVal peringatan_exp As String,
                                 ByVal peringatan_jumlah As String, ByVal di_revisi_oleh As String, ByVal start_jam_revisi As String,
                                 ByVal end_jam_revisi As String) As String


        cmd = New SqlCommand(SQLCommand_InsertTabung, connection)

        cmd.Parameters.AddWithValue("@kode_tabung", kode_tabung)
        cmd.Parameters.AddWithValue("@kelompok", kelompok)
        cmd.Parameters.AddWithValue("@nama_tabung", nama_tabung)

        cmd.Parameters.Add("@kuantitas", SqlDbType.Int)
        cmd.Parameters("@kuantitas").Value = kuantitas

        cmd.Parameters.Add("@exp_date", SqlDbType.Date)
        cmd.Parameters("@exp_date").Value = exp_date

        cmd.Parameters.Add("@sisa_waktu_thn", SqlDbType.Int)
        cmd.Parameters("@sisa_waktu_thn").Value = sisa_waktu_thn

        cmd.Parameters.Add("@sisa_waktu_bln", SqlDbType.Int)
        cmd.Parameters("@sisa_waktu_bln").Value = sisa_waktu_bln

        cmd.Parameters.Add("@sisa_waktu_hari", SqlDbType.Int)
        cmd.Parameters("@sisa_waktu_hari").Value = sisa_waktu_hari

        cmd.Parameters.AddWithValue("@peringatan_exp", peringatan_exp)
        cmd.Parameters.AddWithValue("@peringatan_jumlah", peringatan_jumlah)
        cmd.Parameters.AddWithValue("@direvisi_oleh", di_revisi_oleh)
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
#End Region


End Class
