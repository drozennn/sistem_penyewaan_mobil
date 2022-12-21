Public Class edit_sewa
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim harga = form_sewa.Data_Sewa.hargaSewa("inova", 2)
        MessageBox.Show(harga)
    End Sub
End Class