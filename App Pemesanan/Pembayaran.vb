Public Class formpembayaran

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KasirBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KasirBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

    End Sub


    Private Sub KasirBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KasirBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

    End Sub

    Private Sub formpembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet.kasir' table. You can move, or remove it, as needed.
        Me.KasirTableAdapter.Fill(Me.Kel_5_si_restoDataSet.kasir)

        c2.Items.Add("Nasi Goreng Udang")
        c2.Items.Add("Pasta")
        c2.Items.Add("Chiken Roasted")
        c2.Items.Add("Ikan Sambal Wijen")
        c2.Items.Add("Kepiting Rempah")
        c2.Items.Add("Sop Buntut")
        c2.Items.Add("Ayam Rempah")
        c2.Items.Add("Salmon's Spinach")
        c2.Items.Add("Sate")
        c2.Items.Add("Beef Stik")
        c2.Items.Add("Ayam Bali")
        c2.Items.Add("Nasi Oncom")
        c2.Items.Add("Chiken Tofu")
        c2.Items.Add("Amagos")
        c2.Items.Add("Takoyaki")
        c2.Items.Add("Ubi Wasabi")
        c2.Items.Add("Big Burger")
        c2.Items.Add("Bakpao")
        c2.Items.Add("Almond Cake")
        c2.Items.Add("Pudding Buah")


        c5.Items.Add("Es Teh")
        c5.Items.Add("Jjus")
        c5.Items.Add("Sop Buah")
        c5.Items.Add("S Cendol")
        c5.Items.Add("S Buah")
        c5.Items.Add("Coffe")
    End Sub

    Private Sub Total_pembayaranLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub smpn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smpn.Click
        Me.Validate()
        Me.KasirBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)
        MessageBox.Show("Data Telah Tersimpan")
    End Sub

    Private Sub btl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btl.Click
        KasirBindingSource.CancelEdit()
    End Sub

    Private Sub hps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hps.Click
        If MessageBox.Show("Hapus Data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            KasirBindingSource.RemoveCurrent()

            Me.Validate()
            Me.KasirBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)
            MessageBox.Show("Data Telah Terhapus")
        End If
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
    End Sub

    Private Sub t8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t8.TextChanged
        t8.Text = (Val(t3.Text) * Val(t4.Text)) + (Val(t6.Text) * Val(t7.Text))
    End Sub

    Private Sub t9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t9.TextChanged
        Const uangbayar As String = "Uang Kembalian" + vbNewLine
        Dim pembayaran As String = Val(t9.Text) - Val(t8.Text)
        kembali.Text = uangbayar
        If pembayaran < 0 Then
            kembali2.Text = "-"
        Else
            kembali2.Text = "Rp. " & pembayaran
        End If
    End Sub

    Private Sub tmbh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmbh.Click
        KasirBindingSource.AddNew()
        t1.Text = " "

        t3.Text = " "
        t4.Text = " "

        t6.Text = " "
        t7.Text = " "
        t8.Text = " "
        t9.Text = " "
    End Sub

   
End Class