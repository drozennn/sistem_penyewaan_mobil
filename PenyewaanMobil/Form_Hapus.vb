﻿Public Class Form_Hapus
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LblJenisMobil.Text = Form_JenisMobil.selectedNama
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Form_JenisMobil.jenismobil.DeleteDataKoleksiByIDDatabase(Form_JenisMobil.selectedTableId)
        MessageBox.Show("Jenis Mobill Berhasil Dihapus")
    End Sub
End Class