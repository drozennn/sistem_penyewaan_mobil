Public Class login

    Public Shared FungsiUsers As FungsiUsers

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FungsiUsers = New FungsiUsers()
    End Sub

    Private Sub ButtonRegistrasi_Click(sender As Object, e As EventArgs) Handles ButtonRegistrasi.Click
        Dim formRegis = New registrasi()
        formRegis.Show()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPassword.Text

        Dim data_user As List(Of String) = FungsiUsers.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            FungsiUsers.GSNama = data_user(1)
            MessageBox.Show("Login berhasil") 'Nonaktifkan setelah merge

            'Aktifkan setelah merge
            'sewa.Show()
            'Me.Hide()
        Else
            MessageBox.Show("Username atau Password Salah")
        End If
    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        TextBoxPassword.PasswordChar = "*"c

    End Sub
End Class
