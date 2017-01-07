Public Class formPemesanan

    Private Sub PemesananBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PemesananBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

    End Sub

    Private Sub formPemesanan_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet1.pemesanan' table. You can move, or remove it, as needed.
        Me.PemesananTableAdapter1.Fill(Me.Kel_5_si_restoDataSet1.pemesanan)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PemesananBindingSource1.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.PemesananBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

        MessageBox.Show("Data Telah Tersimpan")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PemesananBindingSource1.CancelEdit()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Validate()
        Me.PemesananBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

        MessageBox.Show("Data Telah Terhapus")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub
End Class