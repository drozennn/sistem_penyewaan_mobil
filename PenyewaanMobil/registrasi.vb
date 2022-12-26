Public Class registrasi
    Private Sub ButtonRegistrasi_Click(sender As Object, e As EventArgs) Handles ButtonRegistrasi.Click
        If TextBoxUsername.Text.Length > 0 And TextBoxEmail.Text.Length > 0 And TextBoxPassword.Text.Length > 0 Then
            login.FungsiUsers.AddUsersDatabase(TextBoxUsername.Text, TextBoxEmail.Text, TextBoxPassword.Text, login.FungsiUsers.GSFoto)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub
End Class