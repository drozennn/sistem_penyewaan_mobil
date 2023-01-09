Public Class edit_sewa
    Private data As New List(Of String)
    Private tipe
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        data = form_sewa.Data_Sewa.loadPenyewa
        ComboBoxPenyewa.Items.Clear()
        For Each kel In data
            ComboBoxPenyewa.Items.Add(kel)
        Next
        '========================================
        data.Clear()
        data = form_sewa.Data_Sewa.LoadMobilUpdate

        ComboBoxMerek.Items.Clear()
        For Each kel In data
            ComboBoxMerek.Items.Add(kel)
        Next
        '======================================
        data.Clear()

        data = form_sewa.Data_Sewa.LoadTipeUpdate(form_sewa.Data_Sewa.GStipe)
        ComboBoxTipe.Items.Clear()
        For Each kel In data
            ComboBoxTipe.Items.Add(kel)
        Next
        '======================================
        data.Clear()

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
        tipe = form_sewa.Data_Sewa.GStipe
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        form_sewa.Data_Sewa.GSnamaPenyewa = ComboBoxPenyewa.SelectedItem
        form_sewa.Data_Sewa.GSmerek = ComboBoxTipe.SelectedItem
        form_sewa.Data_Sewa.GSrencanaPinjam = TextBoxRencana.Text
        form_sewa.Data_Sewa.GStanggalPinjam = DateTimePickerTglPinjam.Value
        form_sewa.Data_Sewa.GStanggalKembali = DateTimePickerTglKembali.Value
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
        If form_sewa.Data_Sewa.GSmerek = tipe Then
            form_sewa.Data_Sewa.setSewa(form_sewa.Data_Sewa.GSmerek, form_sewa.Data_Sewa.GSstatusSewa)
            MessageBox.Show("sama")
        Else
            form_sewa.Data_Sewa.setSewaUpdate(tipe)
            form_sewa.Data_Sewa.setSewa(form_sewa.Data_Sewa.GSmerek, form_sewa.Data_Sewa.GSstatusSewa)
            MessageBox.Show("beda")
        End If

        MessageBox.Show("Data di Update")

    End Sub

    Private Sub ComboBoxMerek_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxMerek.SelectedValueChanged
        Dim data2 As List(Of String) = form_sewa.Data_Sewa.LoadTipeUpdate(ComboBoxMerek.SelectedItem)
        ComboBoxTipe.Items.Clear()
        For Each kel In data2
            ComboBoxTipe.Items.Add(kel)
        Next
        '======================================
        data2.Clear()
    End Sub

    Private Sub TextBoxRencana_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxRencana.KeyUp
        Dim data As Integer

        If TextBoxRencana.Text.Length > 0 Then
            data = Integer.Parse(TextBoxRencana.Text)
        Else
            data = 0
        End If
        Dim result As Integer = form_sewa.Data_Sewa.hargaSewa(ComboBoxTipe.SelectedItem, data)
        TextBoxTotalBiayaSewa.Text = result

        TextBoxTotalBayar.Text = result + Integer.Parse(TextBoxBiayaKelebihan.Text)

    End Sub

    Private Sub DateTimePickerTglKembali_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerTglKembali.ValueChanged
        Dim selisih_hari = (DateTimePickerTglKembali.Value - Date.Parse(form_sewa.Data_Sewa.GStanggalKembali)).TotalDays
        Dim denda = form_sewa.Data_Sewa.GSHargaSewa * 0.1
        Dim total_denda = selisih_hari * denda

        TextBoxBiayaKelebihan.Text = total_denda
        TextBoxTotalBayar.Text = total_denda + form_sewa.Data_Sewa.GStotalBiayaSewa

    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs) Handles ButtonKembali.Click
        Dim main = New form_sewa()
        main.Show()
    End Sub
End Class
