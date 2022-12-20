Public Class Penyewa

    Public Shared FungsiPenyewa As FungsiPenyewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FungsiPenyewa = New FungsiPenyewa()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim formtambah = New TambahPenyewa()
        formtambah.Show()
    End Sub
End Class
