Public Class formMoreInfo

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If user.Text = "user" Or
            password.Text = "12345" Then
            Me.Hide()
            formpelayan.Show()
            user.Clear()
            password.Clear()
        Else
            MessageBox.Show("Username atau Sandi yang Anda Masukkan Salah ")
            user.Clear()
            password.Clear()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password.TextChanged

    End Sub
End Class