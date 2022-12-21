Public Class edit_sewa
    Private Sub ButtonKirim_Click(sender As Object, e As EventArgs) Handles ButtonKirim.Click
        Dim isi = form_sewa.Data_Sewa.getIdMerek("inova")
        MessageBox.Show(isi)
    End Sub
End Class