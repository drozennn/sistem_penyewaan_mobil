Public Class edit_sewa
    Private data As New List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxPenyewa.SelectedItem() = form_sewa.Data_Sewa.GSnamaPenyewa
        ComboBoxMerek.SelectedItem() = form_sewa.Data_Sewa.GSmerek
        ComboBoxTipe.SelectedItem() = form_sewa.Data_Sewa.GStipe
        TextBoxRencana.Text = form_sewa.Data_Sewa.GSrencanaPinjam
        DateTimePickerTglPinjam.Value = form_sewa.Data_Sewa.GStanggalPinjam
        DateTimePickerTglKembali.Value = form_sewa.Data_Sewa.GStanggalKembali
        TextBoxTotalBiayaSewa.Text = form_sewa.Data_Sewa.GStotalBiayaSewa
        TextBoxBiayaKelebihan.Text = form_sewa.Data_Sewa.GSbiayaKelebihanSewa
        TextBoxTotalBayar.Text = form_sewa.Data_Sewa.GStotalBayar
        ComboBoxSewa.SelectedItem() = form_sewa.Data_Sewa.GSstatusSewa

    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        form_sewa.Data_Sewa.GSnamaPenyewa = ComboBoxPenyewa.SelectedItem
        form_sewa.Data_Sewa.GSmerek = ComboBoxTipe.SelectedItem
        form_sewa.Data_Sewa.GSrencanaPinjam = TextBoxRencana.Text
        form_sewa.Data_Sewa.GStanggalPinjam = DateTimePickerTglPinjam.Value.ToString("yyyy/MM/dd")
        form_sewa.Data_Sewa.GStanggalKembali = DateTimePickerTglKembali.Value.ToString("yyyy/MM/dd")
        form_sewa.Data_Sewa.GStotalBiayaSewa = TextBoxTotalBiayaSewa.Text
        form_sewa.Data_Sewa.GSbiayaKelebihanSewa = TextBoxBiayaKelebihan.Text
        form_sewa.Data_Sewa.GStotalBayar = TextBoxTotalBayar.Text
        form_sewa.Data_Sewa.GSstatusSewa = ComboBoxSewa.SelectedItem

        form_sewa.Data_Sewa.UpdateDataByIDDatabase(form_sewa.selectedId,
                                                   form_sewa.Data_Sewa.GSmerek,
                                                   form_sewa.Data_Sewa.GSnamaPenyewa,
                                                   form_sewa.Data_Sewa.GSrencanaPinjam,
                                                   form_sewa.Data_Sewa.GStanggalPinjam,
                                                   form_sewa.Data_Sewa.GStanggalKembali,
                                                   form_sewa.Data_Sewa.GStotalBiayaSewa,
                                                   form_sewa.Data_Sewa.GSbiayaKelebihanSewa,
                                                   form_sewa.Data_Sewa.GStotalBayar,
                                                   form_sewa.Data_Sewa.GSstatusSewa
                                                   )
    End Sub

    Private Sub edit_sewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Data = form_sewa.Data_Sewa.loadPenyewa
        ComboBoxPenyewa.Items.Clear()
        For Each kel In Data
            ComboBoxPenyewa.Items.Add(kel)
        Next
        '========================================
        Data.Clear()
        Data = form_sewa.Data_Sewa.LoadMobil

        ComboBoxMerek.Items.Clear()
        For Each kel In Data
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

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click

    End Sub
End Class
