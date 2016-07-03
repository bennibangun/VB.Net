Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class DataOperations_BarangHabisPakai
    Private BarangHabisPakaiDataTable As DataTable


#Region "Barang Habis Pakai"
    Public Function ReadID_BarangHabisPakai() As Integer
        If connection.State = ConnectionState.Closed Then
            connection.ConnectionString = connString
            connection.Open()
        End If

        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT ID FROM [barang_habis_pakai]"
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

    Public Function ReadMaxID_BarangHabisPakai() As Integer
        Dim returnID As Integer
        Dim result As String

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [barang_habis_pakai]"
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

#Region "Jenis Barang Habis Pakai"
    Public Function ReadID_JenisBarangHabisPakai() As Integer
        If connection.State = ConnectionState.Closed Then
            connection.ConnectionString = connString
            connection.Open()
        End If

        Dim Identifier As Integer = 0

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT ID FROM [jenis_barang_habis_pakai]"
            Identifier = CInt(cmd.ExecuteScalar)
        End Using

        Return Identifier

    End Function

    Public Function ReadMaxID_JenisBarangHabisPakai() As Integer
        Dim returnID As Integer
        Dim result As String

        Using cmd As New SqlCommand With {.Connection = connection}
            cmd.CommandText = "SELECT MAX(ID) FROM [jenis_barang_habis_pakai]"
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
    

    Public Sub getDataBarangHabisPakai(id As Integer)

        If connection.State = ConnectionState.Closed Then
            connection.ConnectionString = connString
            connection.Open()
        End If

        Using connection
            Dim command As SqlCommand = New SqlCommand( _
              "SELECT jenis, nomor_barcode, kuantitas, satuan_kuantitas, isi, satuan_isi, exipred, sisa_waktu_tahun, " &
              "sisa_waktu_bulan, sisa_waktu_hari, angka_peringatan_expired, masa_peringatan_expired, supplier " &
              "FROM barang_habis_pakai WHERE id = @id", connection)

            command.Parameters.AddWithValue("@id", id)

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                Do While reader.Read()
                    barang_habis_pakai.lblIDBrgHabisPakai.Text = id
                    jenis_barang_habis_pakai = reader.GetString(0)
                    barang_habis_pakai.txtNomorBarcode.Text = reader.GetString(1)
                    barang_habis_pakai.txtKuantitas.Text = reader.GetString(2)
                    satuan_kuantitas = reader.GetString(3)
                    barang_habis_pakai.txtIsi.Text = reader.GetString(4)
                    satuan_isi = reader.GetString(5)
                    barang_habis_pakai.dtpExpired.Text = reader.GetString(6)
                    barang_habis_pakai.txtTahun.Text = reader.GetString(7)
                    barang_habis_pakai.txtBulan.Text = reader.GetString(8)
                    barang_habis_pakai.txtHari.Text = reader.GetString(9)
                    rujukan.txtKeterangan.Text = reader.GetString(10)                    
                Loop
            Else
                Console.WriteLine("No rows found.")
            End If

            reader.Close()
        End Using
    End Sub

#Region "Add new rujukan"
    Private SQLCommand_Insert_Barang_Habis_Pakai As String = "INSERT INTO [barang_habis_pakai] (jenis, supplier, nomor_barcode, kuantitas, satuan_kuantitas, isi, satuan_isi, " &
                                      "expired, sisa_tahun_expired, sisa_bulan_expired, sisa_hari_expired, masa_peringatan_expired, keterangan, " &
                                      "direvisi_oleh, start_jam_revisi, end_jam_revisi) VALUES (@jenis, @supplier, @nomor_barcode, @kuantitas, @satuan_kuantitas, @isi, @satuan_isi,  @expired, @sisa_tahun_expired, " &
                                      "@sisa_bulan_expired, @sisa_hari_expired, @masa_peringatan_expired, @keterangan, @direvisi_oleh, @start_jam_revisi, @end_jam_revisi);"


    Public Function AddNewBarang_Habis_Pakai(ByVal jenis As String, ByVal supplier As String, ByVal nomor_barcode As String, ByVal kuantitas As Integer,
                                ByVal satuan_kuantitas As String, ByVal isi As Integer, ByVal satuan_isi As String,
                                ByVal expired As DateTime, ByVal sisa_tahun_expired As Integer, ByVal sisa_bulan_expired As Integer,
                                ByVal sisa_hari_expired As Integer, ByVal masa_peringatan_expired As String,
                                ByVal keterangan As String, ByVal direvisi_oleh As String,
                                ByVal start_jam_revisi As String, ByVal end_jam_revisi As String) As String


        cmd = New SqlCommand(SQLCommand_Insert_Barang_Habis_Pakai, connection)

        cmd.Parameters.AddWithValue("@jenis", jenis)
        cmd.Parameters.AddWithValue("@supplier", supplier)
        cmd.Parameters.AddWithValue("@nomor_barcode", nomor_barcode)

        cmd.Parameters.Add("@kuantitas", SqlDbType.Int)
        cmd.Parameters("@kuantitas").Value = kuantitas

        cmd.Parameters.AddWithValue("@satuan_kuantitas", satuan_kuantitas)

        cmd.Parameters.Add("@isi", SqlDbType.Int)
        cmd.Parameters("@isi").Value = isi

        cmd.Parameters.AddWithValue("@satuan_isi", satuan_isi)

        cmd.Parameters.Add("@expired", SqlDbType.DateTime)
        cmd.Parameters("@expired").Value = expired

        cmd.Parameters.Add("@sisa_tahun_expired", SqlDbType.Int)
        cmd.Parameters("@sisa_tahun_expired").Value = sisa_tahun_expired

        cmd.Parameters.Add("@sisa_bulan_expired", SqlDbType.Int)
        cmd.Parameters("@sisa_bulan_expired").Value = sisa_bulan_expired

        cmd.Parameters.Add("@sisa_hari_expired", SqlDbType.Int)
        cmd.Parameters("@sisa_hari_expired").Value = sisa_hari_expired

        cmd.Parameters.AddWithValue("@masa_peringatan_expired", masa_peringatan_expired)
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
#End Region

#Region "Edit Barang Habis Pakai"
    Private SQLCommand_Update_Barang_Habis_Pakai As String = "UPDATE [barang_habis_pakai] SET jenis = @jenis, nomor_barcode = @nomor_barcode, kuantitas = @kuantitas, satuan_kuantitas = @satuan_kuantitas, " &
                                     "isi= @isi, satuan_isi = @satuan_isi, expired = @expired, sisa_tahun_expired = @sisa_tahun_expired, sisa_bulan_expired = @sisa_bulan_expired, sisa_hari_expired = @sisa_hari_expired, " &
                                     "masa_peringatan_expired = @masa_peringatan_expired, keterangan = @keterangan, keterangan = @keterangan, " &
                                     "direvisi_oleh = @direvisi_oleh, start_jam_revisi = @start_jam_revisi, end_jam_revisi = @end_jam_revisi WHERE id = @id; "

    Public Function Update_Barang_Habis_Pakai(ByVal id As String, ByVal jenis As String, ByVal supplier As String, ByVal nomor_barcode As String, ByVal kuantitas As Integer,
                                ByVal satuan_kuantitas As String, ByVal isi As Integer, ByVal satuan_isi As String,
                                ByVal expired As DateTime, ByVal sisa_tahun_expired As Integer, ByVal sisa_bulan_expired As Integer,
                                ByVal sisa_hari_expired As Integer, ByVal masa_peringatan_expired As String,
                                ByVal keterangan As String, ByVal direvisi_oleh As String,
                                ByVal start_jam_revisi As String, ByVal end_jam_revisi As String) As String


        cmd = New SqlCommand(SQLCommand_Update_Barang_Habis_Pakai, connection)

        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@jenis", jenis)
        cmd.Parameters.AddWithValue("@nomor_barcode", nomor_barcode)

        cmd.Parameters.Add("@kuantitas", SqlDbType.Int)
        cmd.Parameters("@kuantitas").Value = kuantitas

        cmd.Parameters.AddWithValue("@satuan_kuantitas", satuan_kuantitas)

        cmd.Parameters.Add("@isi", SqlDbType.Int)
        cmd.Parameters("@isi").Value = isi

        cmd.Parameters.AddWithValue("@satuan_isi", satuan_isi)

        cmd.Parameters.Add("@expired", SqlDbType.DateTime)
        cmd.Parameters("@expired").Value = expired

        cmd.Parameters.Add("@sisa_tahun_expired", SqlDbType.Int)
        cmd.Parameters("@sisa_tahun_expired").Value = sisa_tahun_expired

        cmd.Parameters.Add("@sisa_bulan_expired", SqlDbType.Int)
        cmd.Parameters("@sisa_bulan_expired").Value = sisa_bulan_expired

        cmd.Parameters.Add("@sisa_hari_expired", SqlDbType.Int)
        cmd.Parameters("@sisa_hari_expired").Value = sisa_hari_expired


        cmd.Parameters.AddWithValue("@masa_peringatan_expired", masa_peringatan_expired)
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
#End Region

End Class
