Public Class EditPenyewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtNamaPenyewa.Text = Penyewa.FungsiPenyewa.GSNama
        txtNIKPenyewa.Text = Penyewa.FungsiPenyewa.GSNIK
        txtAlamatPenyewa.Text = Penyewa.FungsiPenyewa.GSAlamat
    End Sub

    Private Sub BtnEditPenyewa_Click(sender As Object, e As EventArgs) Handles BtnEditPenyewa.Click
        Penyewa.FungsiPenyewa.GSNama = txtNamaPenyewa.Text.ToString()
        Penyewa.FungsiPenyewa.GSNIK = txtNIKPenyewa.Text.ToString()
        Penyewa.FungsiPenyewa.GSAlamat = txtAlamatPenyewa.Text.ToString()

        Penyewa.FungsiPenyewa.UpdateDataPenyewaByIdDatabase(Penyewa.selectedTablePenyewa,
                                                            Penyewa.FungsiPenyewa.GSNama,
                                                            Penyewa.FungsiPenyewa.GSNIK,
                                                            Penyewa.FungsiPenyewa.GSAlamat)

        Me.Close()
    End Sub
End Class