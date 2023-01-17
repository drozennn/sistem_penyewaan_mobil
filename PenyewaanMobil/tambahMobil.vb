Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class tambahMobil
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Shared data As New List(Of String)

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        PictureBoxMobil.Load(OpenFileDialog1.FileName)
        PictureBoxMobil.SizeMode = PictureBoxSizeMode.StretchImage
        FormMobil.Mobil.GSfoto = OpenFileDialog1.FileName.ToString()
        FormMobil.Mobil.GSfoto = FormMobil.Mobil.GSfoto.Replace("\", "/")
    End Sub

    Private Sub tambahMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        data = FormMobil.Mobil.loadJenis()
        cbJenis.Items.Clear()
        For Each kel In data
            cbJenis.Items.Add(kel)
        Next
        data.Clear()
    End Sub

    Private Sub BtnTmbh_Click(sender As Object, e As EventArgs) Handles BtnTmbh.Click
        FormMobil.Mobil.GSJenis = FormMobil.Mobil.getIDJenis(cbJenis.Text)
        FormMobil.Mobil.GSTipe = txtTipe.Text
        FormMobil.Mobil.GSMerek = txtMerek.Text
        FormMobil.Mobil.GSJumlah = txtJumlah.Text
        FormMobil.Mobil.GSHarga = txtHarga.Text
        FormMobil.Mobil.GSMerek = txtMerek.Text
        FormMobil.Mobil.GSTahunPembuatan = txtTahun.Text
        FormMobil.Mobil.GSTglMasuk = dtTglMasuk.Value

        FormMobil.Mobil.addKoleksiDataTableDatabase(FormMobil.Mobil.GSfoto,
                                                    FormMobil.Mobil.GSJenis,
                                                    FormMobil.Mobil.GSTipe,
                                                    FormMobil.Mobil.GSMerek,
                                                    FormMobil.Mobil.GSJumlah,
                                                    FormMobil.Mobil.GSHarga,
                                                    FormMobil.Mobil.GSTahunPembuatan,
                                                    FormMobil.Mobil.GSTglMasuk)
        MessageBox.Show("Data Ditambahkan")
        Me.Close()
    End Sub
End Class