Public Class formPembayaran

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KasirBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KasirBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

    End Sub

    Private Sub formPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet.kasir' table. You can move, or remove it, as needed.
        Me.KasirTableAdapter.Fill(Me.Kel_5_si_restoDataSet.kasir)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KasirDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KasirDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahButton.Click
        KasirBindingSource.AddNew()
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        Me.Validate()
        Me.KasirBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

        MessageBox.Show("Data Telah Terhapus")
    End Sub

    Private Sub simpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanButton.Click
        Me.Validate()
        Me.KasirBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

        MessageBox.Show("Data Telah Tersimpan")
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        KasirBindingSource.CancelEdit()
    End Sub

    Private Sub keluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluarButton.Click
        Me.Close()
    End Sub
End Class