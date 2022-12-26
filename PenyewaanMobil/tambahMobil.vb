Public Class tambahMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private data As New List(Of String)

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormMobil.Mobil.GSJenis = cbJenis.SelectedItem
        FormMobil.Mobil.GSTipe = txtTipe.Text
        FormMobil.Mobil.GSMerek = txtMerek.Text
        FormMobil.Mobil.GSJumlah = txtJumlah.Text
        FormMobil.Mobil.GSHarga = txtHarga.Text
        FormMobil.Mobil.GSMerek = txtMerek.Text
        FormMobil.Mobil.GSTahunPembuatan = DtTahunPembuatan.Value
        FormMobil.Mobil.GSTglMasuk = dtTglMasuk.Value



        FormMobil.Mobil.addKoleksiDataTableDatabase(FormMobil.Mobil.GSfoto,
                                                    FormMobil.Mobil.GSJenis,
                                                    FormMobil.Mobil.GSTipe,
                                                    FormMobil.Mobil.GSMerek,
                                                    FormMobil.Mobil.GSJumlah,
                                                    FormMobil.Mobil.GSHarga,
                                                    FormMobil.Mobil.GSTahunPembuatan,
                                                    FormMobil.Mobil.GSTglMasuk)
        Me.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBoxMobil.Load(picKoleksiDir)
        PictureBoxMobil.SizeMode = PictureBoxSizeMode.StretchImage
        FormMobil.Mobil.GSfoto = OpenFileDialog1.FileName.ToString()
        'Perpus.dataPerpustakaan.GSfoto = picKoleksiDir.ToString()
        FormMobil.Mobil.GSfoto = FormMobil.Mobil.GSfoto.Replace("\", "/")
    End Sub

    Private Sub tambahMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        data = FormMobil.Mobil.loadJenis
        cbJenis.Items.Clear()
        For Each kel In data
            cbJenis.Items.Add(kel)
        Next
    End Sub
End Class