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
    End Sub
End Class
