Public Class master_data

    Dim frmPasien As New data_pasien
    Dim frmDokter As New data_dokter
    Dim frmRujukan As New data_rujukan
    Dim frmSupplier As New data_supplier
    Dim frmPengirim As New data_pengirim
    Dim frmBrgHabisPakai As New data_barang_habis_pakai
    Dim frmReagenOnBoard As New data_reagen_on_board
    Dim frmInstrument As New data_instrument
    Dim frmTabung As New data_master_tabung

#Region "Button click"
    Public Sub showReagenOnBoard()
        If frmPengirim.Visible = True Then
            frmPengirim.Hide()
        ElseIf frmPasien.Visible = True Then
            frmPasien.Hide()
        ElseIf frmRujukan.Visible = True Then
            frmRujukan.Hide()
        ElseIf frmSupplier.Visible = True Then
            frmSupplier.Hide()
        ElseIf frmBrgHabisPakai.Visible = True Then
            frmBrgHabisPakai.Hide()
        ElseIf frmDokter.Visible = True Then
            frmDokter.Hide()
        ElseIf frmInstrument.Visible = True Then
            frmInstrument.Hide()
        ElseIf frmTabung.Visible = True Then
            frmTabung.Hide()
        End If

        frmReagenOnBoard.TopLevel = False
        frmReagenOnBoard.Parent = Me.pnlMasterData
        frmReagenOnBoard.Show()

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub btnPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasien.Click
        If frmPengirim.Visible = True Then
            frmPengirim.Hide()
        ElseIf frmDokter.Visible = True Then
            frmDokter.Hide()
        ElseIf frmRujukan.Visible = True Then
            frmRujukan.Hide()
        ElseIf frmSupplier.Visible = True Then
            frmSupplier.Hide()
        ElseIf frmBrgHabisPakai.Visible = True Then
            frmBrgHabisPakai.Hide()
        ElseIf frmReagenOnBoard.Visible = True Then
            frmReagenOnBoard.Hide()
        ElseIf frmInstrument.Visible = True Then
            frmInstrument.Hide()
        ElseIf frmTabung.Visible = True Then
            frmTabung.Hide()
        End If

        frmPasien.TopLevel = False
        frmPasien.Parent = Me.pnlMasterData
        frmPasien.Show()

    End Sub

    Private Sub btnDokter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDokter.Click
        If frmPengirim.Visible = True Then
            frmPengirim.Hide()
        ElseIf frmPasien.Visible = True Then
            frmPasien.Hide()
        ElseIf frmRujukan.Visible = True Then
            frmRujukan.Hide()
        ElseIf frmSupplier.Visible = True Then
            frmSupplier.Hide()
        ElseIf frmBrgHabisPakai.Visible = True Then
            frmBrgHabisPakai.Hide()
        ElseIf frmReagenOnBoard.Visible = True Then
            frmReagenOnBoard.Hide()
        ElseIf frmInstrument.Visible = True Then
            frmInstrument.Hide()
        ElseIf frmTabung.Visible = True Then
            frmTabung.Hide()
        End If

        frmDokter.TopLevel = False
        frmDokter.Parent = Me.pnlMasterData
        frmDokter.Show()

    End Sub

    Private Sub btnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplier.Click
        If frmPengirim.Visible = True Then
            frmPengirim.Hide()
        ElseIf frmPasien.Visible = True Then
            frmPasien.Hide()
        ElseIf frmRujukan.Visible = True Then
            frmRujukan.Hide()
        ElseIf frmDokter.Visible = True Then
            frmDokter.Hide()
        ElseIf frmBrgHabisPakai.Visible = True Then
            frmBrgHabisPakai.Hide()
        ElseIf frmReagenOnBoard.Visible = True Then
            frmReagenOnBoard.Hide()
        ElseIf frmInstrument.Visible = True Then
            frmInstrument.Hide()
        ElseIf frmTabung.Visible = True Then
            frmTabung.Hide()
        End If

        frmSupplier.TopLevel = False
        frmSupplier.Parent = Me.pnlMasterData
        frmSupplier.Show()

    End Sub

    Private Sub btnPengirim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPengirim.Click
        If frmSupplier.Visible = True Then
            frmSupplier.Hide()
        ElseIf frmPasien.Visible = True Then
            frmPasien.Hide()
        ElseIf frmRujukan.Visible = True Then
            frmRujukan.Hide()
        ElseIf frmDokter.Visible = True Then
            frmDokter.Hide()
        ElseIf frmBrgHabisPakai.Visible = True Then
            frmBrgHabisPakai.Hide()
        ElseIf frmReagenOnBoard.Visible = True Then
            frmReagenOnBoard.Hide()
        ElseIf frmInstrument.Visible = True Then
            frmInstrument.Hide()
        End If

        frmPengirim.TopLevel = False
        frmPengirim.Parent = Me.pnlMasterData
        frmPengirim.Show()

    End Sub

    Private Sub btnRujukan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRujukan.Click
        If frmSupplier.Visible = True Then
            frmSupplier.Hide()
        ElseIf frmPasien.Visible = True Then
            frmPasien.Hide()
        ElseIf frmPengirim.Visible = True Then
            frmPengirim.Hide()
        ElseIf frmDokter.Visible = True Then
            frmDokter.Hide()
        ElseIf frmBrgHabisPakai.Visible = True Then
            frmBrgHabisPakai.Hide()
        ElseIf frmReagenOnBoard.Visible = True Then
            frmReagenOnBoard.Hide()
        ElseIf frmInstrument.Visible = True Then
            frmInstrument.Hide()
        End If

        frmRujukan.TopLevel = False
        frmRujukan.Parent = Me.pnlMasterData
        frmRujukan.Show()

    End Sub

    Private Sub btnBarangHabisPakai_Click(sender As Object, e As EventArgs) Handles btnBarangHabisPakai.Click
        If frmSupplier.Visible = True Then
            frmSupplier.Hide()
        ElseIf frmPasien.Visible = True Then
            frmPasien.Hide()
        ElseIf frmPengirim.Visible = True Then
            frmPengirim.Hide()
        ElseIf frmDokter.Visible = True Then
            frmDokter.Hide()
        ElseIf frmRujukan.Visible = True Then
            frmRujukan.Hide()
        ElseIf frmReagenOnBoard.Visible = True Then
            frmReagenOnBoard.Hide()
        ElseIf frmInstrument.Visible = True Then
            frmInstrument.Hide()
        ElseIf frmTabung.Visible = True Then
            frmTabung.Hide()
        End If

        frmBrgHabisPakai.TopLevel = False
        frmBrgHabisPakai.Parent = Me.pnlMasterData
        frmBrgHabisPakai.Show()

    End Sub

    Private Sub btnReagenOnBoard_Click(sender As Object, e As EventArgs) Handles btnReagenOnBoard.Click
        If frmSupplier.Visible = True Then
            frmSupplier.Hide()
        ElseIf frmPasien.Visible = True Then
            frmPasien.Hide()
        ElseIf frmPengirim.Visible = True Then
            frmPengirim.Hide()
        ElseIf frmDokter.Visible = True Then
            frmDokter.Hide()
        ElseIf frmRujukan.Visible = True Then
            frmRujukan.Hide()
        ElseIf frmBrgHabisPakai.Visible = True Then
            frmBrgHabisPakai.Hide()
        ElseIf frmInstrument.Visible = True Then
            frmInstrument.Hide()
        ElseIf frmTabung.Visible = True Then
            frmTabung.Hide()
        End If


        frmReagenOnBoard.TopLevel = False
        frmReagenOnBoard.Parent = Me.pnlMasterData
        frmReagenOnBoard.Show()
    End Sub

    Private Sub btnInstrument_Click(sender As Object, e As EventArgs) Handles btnInstrument.Click
        If frmSupplier.Visible = True Then
            frmSupplier.Hide()
        ElseIf frmPasien.Visible = True Then
            frmPasien.Hide()
        ElseIf frmPengirim.Visible = True Then
            frmPengirim.Hide()
        ElseIf frmDokter.Visible = True Then
            frmDokter.Hide()
        ElseIf frmRujukan.Visible = True Then
            frmRujukan.Hide()
        ElseIf frmBrgHabisPakai.Visible = True Then
            frmBrgHabisPakai.Hide()
        ElseIf frmReagenOnBoard.Visible = True Then
            frmReagenOnBoard.Hide()        
        ElseIf frmTabung.Visible = True Then
            frmTabung.Hide()
        End If

        frmInstrument.TopLevel = False
        frmInstrument.Parent = Me.pnlMasterData
        frmInstrument.Show()
    End Sub

    Private Sub btnTabung_Click(sender As Object, e As EventArgs) Handles btnTabung.Click
        If frmSupplier.Visible = True Then
            frmSupplier.Hide()
        ElseIf frmPasien.Visible = True Then
            frmPasien.Hide()
        ElseIf frmPengirim.Visible = True Then
            frmPengirim.Hide()
        ElseIf frmDokter.Visible = True Then
            frmDokter.Hide()
        ElseIf frmRujukan.Visible = True Then
            frmRujukan.Hide()
        ElseIf frmBrgHabisPakai.Visible = True Then
            frmBrgHabisPakai.Hide()
        ElseIf frmReagenOnBoard.Visible = True Then
            frmReagenOnBoard.Hide()
        ElseIf frmInstrument.Visible = True Then
            frmInstrument.Hide()
        End If

        frmTabung.TopLevel = False
        frmTabung.Parent = Me.pnlMasterData
        frmTabung.Show()
    End Sub

#End Region
    
#Region "Form Load"
    Private Sub master_data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()
        Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region
    
    
End Class