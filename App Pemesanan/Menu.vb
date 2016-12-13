Public Class formmenu

    Private Sub MenuBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MenuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)

    End Sub

    Private Sub formmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kel_5_si_restoDataSet.menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.Kel_5_si_restoDataSet.menu)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MenuBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.MenuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Kel_5_si_restoDataSet)
    End Sub
End Class