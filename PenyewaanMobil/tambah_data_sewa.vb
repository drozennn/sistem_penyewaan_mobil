Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class tambah_data_sewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ButtonKirim_Click(sender As Object, e As EventArgs) Handles ButtonKirim.Click
        'form_sewa.Data_Sewa.GSnamaPenyewa = ComboBoxPenyewa.Text
        'form_sewa.Data_Sewa.GSmerek = ComboBoxMerek.Text
        form_sewa.Data_Sewa.GSnamaPenyewa = 1
        form_sewa.Data_Sewa.GSmerek = 1
        form_sewa.Data_Sewa.GSrencanaPinjam = TextBoxRencana.Text
        form_sewa.Data_Sewa.GStanggalPinjam = DateTimePickerTglPinjam.Value.ToShortDateString
        form_sewa.Data_Sewa.GStanggalKembali = DateTimePickerTglKembali.Value.ToShortDateString
        form_sewa.Data_Sewa.GStotalBiayaSewa = TextBoxTotalBiayaSewa.Text
        form_sewa.Data_Sewa.GSbiayaKelebihanSewa = TextBoxBiayaKelebihan.Text
        form_sewa.Data_Sewa.GStotalBayar = TextBoxTotalBayar.Text
        form_sewa.Data_Sewa.GSstatusSewa = TextBoxStatusSewa.Text

        form_sewa.Data_Sewa.AddDataKoleksiDatabase(form_sewa.Data_Sewa.GSmerek,
                                                   form_sewa.Data_Sewa.GSnamaPenyewa,
                                                   form_sewa.Data_Sewa.GSrencanaPinjam,
                                                   form_sewa.Data_Sewa.GStanggalPinjam,
                                                   form_sewa.Data_Sewa.GStanggalKembali,
                                                   form_sewa.Data_Sewa.GStotalBiayaSewa,
                                                   form_sewa.Data_Sewa.GSbiayaKelebihanSewa,
                                                   form_sewa.Data_Sewa.GStotalBayar,
                                                   form_sewa.Data_Sewa.GSstatusSewa
                                                   )
        MessageBox.Show("data dimasukan")
    End Sub
End Class