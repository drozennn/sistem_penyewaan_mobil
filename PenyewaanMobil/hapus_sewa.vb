Public Class hapus_sewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        LabelPenyewa.Text = form_sewa.selectedNama
        LabelMerek.Text = form_sewa.selectedMerek

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        form_sewa.Data_Sewa.DeleteDataByIDDatabase(form_sewa.selectedId)
        MessageBox.Show("Data dihapus")

        Dim status_sewa = form_sewa.selectedMerek
        MessageBox.Show(status_sewa)
        form_sewa.Data_Sewa.setSewaDefault(status_sewa)
    End Sub
End Class