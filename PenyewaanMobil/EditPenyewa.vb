Public Class EditPenyewa
    Dim id As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtNamaPenyewa.Text = Penyewa.FungsiPenyewa.GSNama
        txtNIKPenyewa.Text = Penyewa.FungsiPenyewa.GSNIK
        txtAlamatPenyewa.Text = Penyewa.FungsiPenyewa.GSAlamat

        id = Penyewa.selectedTablePenyewa

    End Sub

    Private Sub BtnEditPenyewa_Click(sender As Object, e As EventArgs) Handles BtnEditPenyewa.Click

        Penyewa.FungsiPenyewa.UpdateDataPenyewaByIdDatabase(id,
                                                            txtNamaPenyewa.Text,
                                                            txtNIKPenyewa.Text,
                                                            txtAlamatPenyewa.Text)
        'MessageBox.Show(id)
        'MessageBox.Show(txtNamaPenyewa.Text)
        'MessageBox.Show(txtNIKPenyewa.Text)
        'MessageBox.Show(txtAlamatPenyewa.Text)

        'MessageBox.Show(Penyewa.selectedTablePenyewa)
        'MessageBox.Show(Penyewa.FungsiPenyewa.GSNama)
        'MessageBox.Show(Penyewa.FungsiPenyewa.GSNIK)
        'MessageBox.Show(Penyewa.FungsiPenyewa.GSAlamat)
        Me.Close()
    End Sub
End Class