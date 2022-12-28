Public Class FormMobil
    Public Shared Mobil As Mobil
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Mobil = New Mobil()
        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridViewMobil.DataSource = Mobil.GetDataKoleksiDatabase()
    End Sub

    Private Sub FormMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambahMobil_Click(sender As Object, e As EventArgs) Handles BtnTambahMobil.Click
        Dim tambahMobil = New tambahMobil()
        tambahMobil.Show()
    End Sub



    Private Sub DataGridViewMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMobil.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        selectedRow = DataGridViewMobil.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(3).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedKoleksi As List(Of String) = Mobil.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        Mobil.GSfoto = selectedKoleksi(2)

        Mobil.GSJenis = selectedKoleksi(1)
        Mobil.GSTipe = selectedKoleksi(3)
        Mobil.GSMerek = selectedKoleksi(4)
        Mobil.GSJumlah = selectedKoleksi(5)
        Mobil.GSHarga = selectedKoleksi(6)
        Mobil.GSTahunPembuatan = selectedKoleksi(7)
        Mobil.GSTglMasuk = selectedKoleksi(8)
        Mobil.GSstatus = selectedKoleksi(9)



        Dim formUpdate = New EditMobil()
        formUpdate.Show()
    End Sub

    Private Sub BtnKurangMobil_Click(sender As Object, e As EventArgs) Handles BtnKurangMobil.Click
        Dim formhapus = New HapusMobil()
        formhapus.Show()
    End Sub
End Class