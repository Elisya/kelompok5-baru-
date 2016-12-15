Public Class Form1

    Private Sub menuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuButton.Click
        formLihatMenu.Show()
    End Sub

    Private Sub pemesananButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pemesananButton.Click
        formPemesanan.Show()
    End Sub

    Private Sub pembayaranButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pembayaranButton3.Click
        formPembayaran.Show()
    End Sub

    Private Sub infoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles infoButton.Click
        formMoreInfo.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
