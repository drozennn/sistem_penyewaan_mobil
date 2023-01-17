Public Class registrasi
    Private Sub ButtonRegistrasi_Click(sender As Object, e As EventArgs) Handles ButtonRegistrasi.Click
        If TextBoxUsername.Text.Length > 0 And TextBoxEmail.Text.Length > 0 And TextBoxPassword.Text.Length > 0 Then
            login.FungsiUsers.AddUsersDatabase(TextBoxUsername.Text, TextBoxEmail.Text, TextBoxPassword.Text, login.FungsiUsers.GSFoto)
            MessageBox.Show("Akun dibuat")
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub

    Private Sub ButtonGambar_Click(sender As Object, e As EventArgs) Handles ButtonGambar.Click
        OpenGambar.Title = "Pilih Foto Diri"
        OpenGambar.Filter = "Image JPG|*.jpg|All Format|*.*|Image|*.bmp|Image JPEG|*.jpeg|Image PNG|*.png"
        OpenGambar.ShowDialog()

        Dim dir_gambar As String = OpenGambar.FileName

        PicDaftar.Load(dir_gambar)
        PicDaftar.SizeMode = PictureBoxSizeMode.StretchImage
        login.FungsiUsers.GSFoto = dir_gambar.ToString()
        login.FungsiUsers.GSFoto = login.FungsiUsers.GSFoto.Replace("\", "/")
    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        TextBoxPassword.PasswordChar = "*"c
    End Sub

End Class