Public Class formPemesanan

    Private Sub PemesananBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PemesananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

    End Sub

    Private Sub formPemesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet.pemesanan' table. You can move, or remove it, as needed.
        Me.PemesananTableAdapter.Fill(Me.Kel_5_si_restoDataSet.pemesanan)

    End Sub

    Private Sub PemesananDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PemesananDataGridView.CellContentClick

    End Sub

    Private Sub tambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahButton.Click
        PemesananBindingSource.AddNew()

    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        Me.Validate()
        Me.PemesananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

        MessageBox.Show("Data Telah Terhapus")
       
    End Sub

    Private Sub simpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanButton.Click
        Me.Validate()
        Me.PemesananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

        MessageBox.Show("Data Telah Tersimpan")
    End Sub

    Private Sub batalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batalButton.Click
        PemesananBindingSource.CancelEdit()
    End Sub

    Private Sub keluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluarButton.Click


    End Sub
End Class