Public Class formPembayaran

    Private Sub KasirBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KasirBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

    End Sub

    Private Sub formPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet.kasir' table. You can move, or remove it, as neede    Me.KasirTableAdapter.Fill(Me.Kel_5_si_restoDataSet.kasir)

    End Sub

    Private Sub Button2_Click(ByVal senderem.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        k()
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub biaya_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biaya.TextChanged

    End Sub

    Private Sub KasirBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KasirBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

    End Sub

    Private Sub formPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet.kasir' table. You can move, or remove it, as needed.
        Me.KasirTableAdapter1.Fill(Me.Kel_5_si_restoDataSet1.kasir)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        id.Text = "-"
        nama.Text = "-"
        harga.Text = "0"
        jumlah.Text = "0"
        biaya.Text = "0"
        pembyrn.Text = "0"
        KasirBindingSource1.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.KasirBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

        MessageBox.Show("Data Telah Tersimpan")
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show("Hapus Data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            KasirBindingSource1.RemoveCurrent()

            Me.Validate()
            Me.KasirBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

            MessageBox.Show("Data Telah Terhapus")
    End Sub

    Private Sub KasirDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KasirDataGridView.CellContentClick

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        KasirBindingSource1.CancelEdit()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class