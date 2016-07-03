Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.OleDb

Module ModuleGlobalVariable
    Public connString = ConfigurationManager.ConnectionStrings("labConnStr").ConnectionString
    Public connection As New SqlConnection(connString)
    Public reader As SqlDataReader
    Public DataOps As New DataOperations
    Public cmd As New SqlCommand
    Public provinsi As String
    Public kabupaten As String
    Public kecamatan As String
    Public pembayaranFee As String
    Public namaBank As String

#Region "Pengirim"
    Public DataOpsPengirim As New DataOperations_Pengirim
    Public readPengirim As Integer
    Public idPengirim As Integer
#End Region

#Region "Region On Board"
    Public DataOpsRegionOnBoard As New DataOperations_ReagenOnBoard
    Public readReagenOnBoard As Integer
    Public idReagenOnBoard As Integer
#End Region

#Region "Rujukan"
    Public DataOpsRujukan As New DataOperations_Rujukan
    Public readRujukan As Integer
    Public idRujukan As Integer
#End Region

#Region "Dokter"
    Public DataOpsDokter As New DataOperations_Dokter
    Public readDokter As Integer
    Public idDokter As Integer
    Public jenkelDokter As String
    Public spesialisasiDokter As String
    Public golDarahDokter As String
    Public rhesusDokter As String
#End Region

#Region "Pasien"
    Public DataOpsPasien As New DataOperations_Pasien
    Public statusPasien As String
    Public jenkelPasien As String
    Public tmplahirPasien As String
    Public tgllahirPasien As Date
    Public golDarahPasien As String
    Public pendidikanPasien As String
    Public pekerjaanPasien As String
    Public rhesusPasien As String
    Public readPasien As Integer
    Public idPasien As Integer
#End Region

#Region "Supplier"
    Public DataOpsSupplier As New DataOperations_Supplier
    Public readSupplier As Integer
    Public idSupplier As Integer
#End Region

#Region "Barang Habis Pakai"
    Public DataOpsBrgHabisPakai As New DataOperations_BarangHabisPakai
    Public read_BrgHabisPakai As Integer
    Public id_BrgHabisPakai As Integer
    Public jenis_barang_habis_pakai As String
    Public satuan_kuantitas As String
    Public satuan_isi As String
#End Region

#Region "Pengambilan Hasil"
    Public DataOpsPengambilanHasil As New DataOperations_PengambilanHasil
    Public readPengambilanHasil As Integer
    Public idPengambilanHasil As Integer
#End Region

#Region "Tabung"
    Public DataOpsTabung As New DataOperations_Tabung    
#End Region

#Region "Metode Pemeriksaan"
    Public DataOpsMetodePemeriksaan As New DataOperations_MetodePemeriksaan
    Public readMetodePemeriksaan As Integer
    Public idMetodePemeriksaan As Integer
#End Region

#Region "Bahan Pemeriksaan"
    Public DataOpsBahanPemeriksaan As New DataOperations_BahanPemeriksaan
    Public readBahanPemeriksaan As Integer
    Public idBahanPemeriksaan As Integer
#End Region

#Region "Pemeriksaan Single"
    Public DataOpsMasterPemeriksaanSingle As New DataOperations_MasterPemeriksaanSingle
#End Region

End Module
