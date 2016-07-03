Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class menuutama

    Private Sub menuutama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection.Open()
    End Sub

    Private Sub PenetapanAwalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenetapanAwalToolStripMenuItem.Click
        penetapan_awal.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        master_test.ShowDialog()
    End Sub

    Private Sub tsmMasterData_Click(sender As Object, e As EventArgs) Handles tsmMasterData.Click
        'dokter.ShowDialog()
        master_data.ShowDialog()
    End Sub

    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click    
        connection.Close()
        Application.Exit()
    End Sub

    Private Sub tsmDaftarReferensi_Click(sender As Object, e As EventArgs) Handles tsmDaftarReferensi.Click
        referensi.ShowDialog()
    End Sub

    Private Sub tsmMasterPemeriksaanSingle_Click(sender As Object, e As EventArgs) Handles tsmMasterPemeriksaanSingle.Click
        MasterPemeriksaanSingle.ShowDialog()
    End Sub
End Class
