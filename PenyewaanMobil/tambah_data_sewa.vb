﻿Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class tambah_data_sewa
    Private data As New List(Of String)


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ButtonKirim_Click(sender As Object, e As EventArgs) Handles ButtonKirim.Click

        form_sewa.Data_Sewa.GSnamaPenyewa = ComboBoxPenyewa.SelectedItem
        form_sewa.Data_Sewa.GSmerek = ComboBoxTipe.SelectedItem
        form_sewa.Data_Sewa.GSrencanaPinjam = TextBoxRencana.Text
        form_sewa.Data_Sewa.GStanggalPinjam = DateTimePickerTglPinjam.Value.ToString("yyyy/MM/dd")
        form_sewa.Data_Sewa.GStanggalKembali = DateTimePickerTglKembali.Value.ToString("yyyy/MM/dd")
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
        MessageBox.Show(form_sewa.Data_Sewa.GSmerek)
        MessageBox.Show(form_sewa.Data_Sewa.GSnamaPenyewa)
        MessageBox.Show(form_sewa.Data_Sewa.GSrencanaPinjam)
        MessageBox.Show(form_sewa.Data_Sewa.GStanggalPinjam)
        MessageBox.Show(form_sewa.Data_Sewa.GStanggalKembali)
        MessageBox.Show(form_sewa.Data_Sewa.GStotalBiayaSewa)
        MessageBox.Show(form_sewa.Data_Sewa.GSbiayaKelebihanSewa)
        MessageBox.Show(form_sewa.Data_Sewa.GStotalBayar)
        MessageBox.Show(form_sewa.Data_Sewa.GSstatusSewa)


        MessageBox.Show("data dimasukan")
    End Sub

    Private Sub tambah_data_sewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        data = form_sewa.Data_Sewa.loadPenyewa
        ComboBoxPenyewa.Items.Clear()
        For Each kel In data
            ComboBoxPenyewa.Items.Add(kel)
        Next
        '========================================
        data.Clear()
        data = form_sewa.Data_Sewa.LoadMobil

        ComboBoxMerek.Items.Clear()
        For Each kel In data
            ComboBoxMerek.Items.Add(kel)
        Next
        '======================================
        data.Clear()

    End Sub

    Private Sub ComboBoxMerek_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxMerek.SelectedValueChanged
        Dim data2 As List(Of String) = form_sewa.Data_Sewa.LoadTipe(ComboBoxMerek.SelectedItem)
        ComboBoxTipe.Items.Clear()
        For Each kel In data2
            ComboBoxTipe.Items.Add(kel)
        Next
        '======================================
        data2.Clear()
    End Sub

    Private Sub TextBoxRencana_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxRencana.KeyDown
        TextBoxTotalBiayaSewa.Text = form_sewa.Data_Sewa.hargaSewa(ComboBoxTipe.SelectedItem, TextBoxRencana.Text)
    End Sub
End Class