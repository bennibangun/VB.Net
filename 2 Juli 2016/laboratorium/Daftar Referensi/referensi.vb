Public Class referensi
    Dim frmPendidikan As New pendidikan
    Dim frmPekerjaan As New pekerjaan
    Dim frmSpesialisasi As New spesialisasi
    Dim frmLoketPemeriksaan As New loket_pemeriksaan

#Region "Form Load"
    Private Sub Referensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        Me.WindowState = FormWindowState.Maximized
    End Sub

#End Region

#Region "Button Click"
    Private Sub btnPendidikan_Click(sender As Object, e As EventArgs) Handles btnPendidikan.Click
        frmPendidikan.TopLevel = False
        frmPendidikan.Parent = Me.pnlReferensi
        frmPendidikan.Show()
    End Sub

    Private Sub btnJenisPekerjaan_Click(sender As Object, e As EventArgs) Handles btnJenisPekerjaan.Click
        frmPekerjaan.TopLevel = False
        frmPekerjaan.Parent = Me.pnlReferensi
        frmPekerjaan.Show()
    End Sub

    Private Sub btnSpesialisasiDokter_Click(sender As Object, e As EventArgs) Handles btnSpesialisasiDokter.Click
        frmSpesialisasi.TopLevel = False
        frmSpesialisasi.Parent = Me.pnlReferensi
        frmSpesialisasi.Show()
    End Sub

    Private Sub btnLoketPemeriksaan_Click(sender As Object, e As EventArgs) Handles btnLoketPemeriksaan.Click
        frmLoketPemeriksaan.TopLevel = False
        frmLoketPemeriksaan.Parent = Me.pnlReferensi
        frmLoketPemeriksaan.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

#End Region
    
End Class