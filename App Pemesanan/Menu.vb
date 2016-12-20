Public Class formmenu


    Private Sub formmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet.menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.Kel_5_si_restoDataSet.menu)

    End Sub

    
    Private Sub tambahButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tambahButton.Click
        MenuBindingSource.AddNew()
    End Sub

    Private Sub simpanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanButton.Click

        Me.Validate()
        MenuBindingSource.EndEdit()
        MenuTableAdapter.Update(Kel_5_si_restoDataSet.menu)

        Exit Sub
    End Sub

    Private Sub keluarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluarButton.Click
        Me.Close()
    End Sub

    Private Sub lihatButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lihatButton.Click
        Me.Hide()
        formLihatMenu.Show()
    End Sub
End Class