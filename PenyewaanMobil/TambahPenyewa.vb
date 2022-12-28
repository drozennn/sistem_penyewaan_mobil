Public Class TambahPenyewa
    Private Sub BtnTambahPenyewa_Click(sender As Object, e As EventArgs)
        Penyewa.FungsiPenyewa.GSNama = txtNamaPenyewa.Text
        Penyewa.FungsiPenyewa.GSNIK = txtNIKPenyewa.Text
        Penyewa.FungsiPenyewa.GSAlamat = txtAlamatPenyewa.Text

        Penyewa.FungsiPenyewa.AddDataKoleksiDatabase(Penyewa.FungsiPenyewa.GSNama,
                                                     Penyewa.FungsiPenyewa.GSNIK,
                                                     Penyewa.FungsiPenyewa.GSAlamat)
        MessageBox.Show("Data Berhasil di Input")
    End Sub
End Class