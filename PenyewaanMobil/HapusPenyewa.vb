Public Class HapusPenyewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        NamaPenyewaHapus.Text = Penyewa.selectedTablePenyewaNama
        MessageBox.Show(Penyewa.selectedTablePenyewaNama)

    End Sub
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnKonfirmasi_Click(sender As Object, e As EventArgs) Handles BtnKonfirmasi.Click
        Penyewa.FungsiPenyewa.DeleteDataPenyewaByIdDatabase(Penyewa.selectedTablePenyewa)
        Me.Close()
    End Sub
End Class