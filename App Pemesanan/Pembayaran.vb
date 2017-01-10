Public Class formPembayaran

    Private Sub KasirBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KasirBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

    End Sub

    Private Sub formPembayaran_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet1.kasir' table. You can move, or remove it, as needed.
        Me.KasirTableAdapter1.Fill(Me.Kel_5_si_restoDataSet1.kasir)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        id.Text = "-"
        nama.Text = "-"
        harga.Text = "0"
        jumlah.Text = "0"
        biaya.Text = "0"
        pembyrn.Text = "0"
        KasirBindingSource1.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.KasirBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

        MessageBox.Show("Data Telah Tersimpan")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        KasirBindingSource1.CancelEdit()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MessageBox.Show("Hapus Data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            KasirBindingSource1.RemoveCurrent()

            Me.Validate()
            Me.KasirBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

            MessageBox.Show("Data Telah Terhapus")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub pembyrn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pembyrn.TextChanged
        Const uangbayar As String = "Uang Kembalian " + vbNewLine
        Dim pembayaran As String = Val(pembyrn.Text) - Val(biaya.Text)
        kembali.Text = uangbayar
        If pembayaran < 0 Then
            kembali2.Text = "Uang Anda Kurang"
        Else
            kembali2.Text = "Rp. " & pembayaran
        End If
    End Sub

    Private Sub biaya_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biaya.TextChanged
        biaya.Text = Val(harga.Text) * Val(jumlah.Text)
    End Sub
End Class