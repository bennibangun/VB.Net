Public Class master_test

    Dim frmMetodePemeriksaan As New metode_pemeriksaan
    Dim frmSample As New sample
    Dim frmLabRujukan As New lab_rujukan

    Private Sub btnMetodePemeriksaan_Click(sender As Object, e As EventArgs) Handles btnMetodePemeriksaan.Click
        If frmSample.Visible = True Then
            frmSample.Hide()
        ElseIf frmLabRujukan.Visible = True Then
            frmLabRujukan.Hide()        
        End If

        frmMetodePemeriksaan.TopLevel = False
        frmMetodePemeriksaan.Parent = Me.pnlMasterTest
        frmMetodePemeriksaan.Show()

    End Sub

    Private Sub master_test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnSample_Click(sender As Object, e As EventArgs) Handles btnSample.Click
        If frmMetodePemeriksaan.Visible = True Then
            frmMetodePemeriksaan.Hide()
        ElseIf frmLabRujukan.Visible = True Then
            frmLabRujukan.Hide()
        End If

        frmSample.TopLevel = False
        frmSample.Parent = Me.pnlMasterTest
        frmSample.Show()

    End Sub

    Private Sub btnLabRujukan_Click(sender As Object, e As EventArgs) Handles btnLabRujukan.Click
        If frmMetodePemeriksaan.Visible = True Then
            frmMetodePemeriksaan.Hide()
        ElseIf frmSample.Visible = True Then
            frmSample.Hide()
        End If

        frmLabRujukan.TopLevel = False
        frmLabRujukan.Parent = Me.pnlMasterTest
        frmLabRujukan.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class