Public Class formmenu


    Private Sub MenuBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MenuBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

    End Sub

    Private Sub formmenu_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet1.menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter1.Fill(Me.Kel_5_si_restoDataSet1.menu)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MenuBindingSource1.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Validate()
        Me.MenuBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

        MessageBox.Show("Data Berhasil Tersimpan")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MenuBindingSource1.CancelEdit()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MessageBox.Show("Hapus Data ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MenuBindingSource1.RemoveCurrent()

            Me.Validate()
            Me.MenuBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.Kel_5_si_restoDataSet1)

            MessageBox.Show("Data Telah Terhapus")

        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formLihatMenu.Show()
        Me.Hide()
    End Sub
End Class