Public Class EditMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictureBoxMobil.Load(FormMobil.Mobil.GSfoto)
        PictureBoxMobil.SizeMode = PictureBoxSizeMode.StretchImage
        cbJenis.SelectedItem = FormMobil.Mobil.GSJenis
        txtTipe.Text = FormMobil.Mobil.GSTipe
        txtMerek.Text = FormMobil.Mobil.GSMerek
        txtJumlah.Text = FormMobil.Mobil.GSJumlah
        txtHarga.Text = FormMobil.Mobil.GSHarga
        txtTahun.Text = FormMobil.Mobil.GSTahunPembuatan
        dtTglMasuk.Value = FormMobil.Mobil.GSTglMasuk
        cbStatus.SelectedItem = FormMobil.Mobil.GSstatus
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBoxMobil.Load(picKoleksiDir)
        PictureBoxMobil.SizeMode = PictureBoxSizeMode.StretchImage
        FormMobil.Mobil.GSfoto = picKoleksiDir.ToString()
        FormMobil.Mobil.GSfoto = FormMobil.Mobil.GSfoto.Replace("\", "/")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        FormMobil.Mobil.GSJenis = FormMobil.Mobil.getIDJenis(cbJenis.SelectedItem)
        FormMobil.Mobil.GSTipe = txtTipe.Text
        FormMobil.Mobil.GSMerek = txtMerek.Text
        FormMobil.Mobil.GSJumlah = txtJumlah.Text
        FormMobil.Mobil.GSHarga = txtHarga.Text
        FormMobil.Mobil.GSMerek = txtMerek.Text
        FormMobil.Mobil.GSTahunPembuatan = txtTahun.Text
        FormMobil.Mobil.GSTglMasuk = dtTglMasuk.Value
        FormMobil.Mobil.GSstatus = cbStatus.SelectedItem()

        FormMobil.Mobil.UpdateDataKoleksiByIDDatabase(FormMobil.selectedTableKoleksi,
                                                      FormMobil.Mobil.GSfoto,
                                                      FormMobil.Mobil.GSJenis,
                                                      FormMobil.Mobil.GSTipe,
                                                      FormMobil.Mobil.GSMerek,
                                                      FormMobil.Mobil.GSJumlah,
                                                      FormMobil.Mobil.GSHarga,
                                                      FormMobil.Mobil.GSTahunPembuatan,
                                                      FormMobil.Mobil.GSTglMasuk,
                                                      FormMobil.Mobil.GSstatus)
        cbStatus.Items.Clear()
    End Sub


    Private Sub EditMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tambahMobil.data = FormMobil.Mobil.loadJenis()
        cbJenis.Items.Clear()
        For Each kel In tambahMobil.data
            cbJenis.Items.Add(kel)
        Next
        tambahMobil.data.Clear()
        cbJenis.SelectedItem() = FormMobil.Mobil.GSJenis

        '=========================================

        'tambahMobil.data.Clear()
        FormMobil.Mobil.loadStatus(FormMobil.selectedTableKoleksi)
        'For Each kel In data
        '    cbStatus.Items.Add(kel)
        'Next
        cbStatus.SelectedItem() = FormMobil.Mobil.GSstatus
    End Sub
End Class