Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class Form_Insert
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Form_JenisMobil.jenismobil.GSJenisMobil = TxtBoxJenisMobil.Text
        Form_JenisMobil.jenismobil.GSTanggal = DateTimePickerTanggal.Value

        Form_JenisMobil.jenismobil.AddDataKoleksiDatabase(Form_JenisMobil.jenismobil.GSJenisMobil,
                                                          Form_JenisMobil.jenismobil.GSTanggal)
        MessageBox.Show("Jenis Mobill Berhasil Ditambahkan")

    End Sub

End Class