Public Class HapusMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblHapusMobil.Text = FormMobil.selectedTableKoleksiNama
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        FormMobil.Mobil.DeleteDataKoleksiByIDDatabase(FormMobil.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class