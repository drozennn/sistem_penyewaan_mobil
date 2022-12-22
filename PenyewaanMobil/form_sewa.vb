Imports Mysqlx.XDevAPI.Relational

Public Class form_sewa

    Public Shared Data_Sewa As data_sewa
    Public Shared selectedId
    Public Shared selectedTableKoleksiNama
    Public Shared selectedRow As DataGridViewRow


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Data_Sewa = New data_sewa()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridSewa.DataSource = Data_Sewa.GetDataDatabase()
    End Sub

    Private Sub form_sewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Dim hapus = New hapus_sewa()
        hapus.Show()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim tambah = New tambah_data_sewa()
        tambah.Show()
    End Sub

    Private Sub DataGridSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSewa.CellClick
        Dim index As Integer = e.RowIndex
        selectedRow = DataGridSewa.Rows(index)

        selectedId = selectedRow.Cells(0).Value
        'selectedTableKoleksiNama = selectedRow.Cells(1).Value

    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim selectedData As List(Of String) = Data_Sewa.GetDataByIDDatabase(selectedId)

        'harus mengirimkan id untuk mengambil value dari nama penyewa, merek, tipe dan status sewa
        'error di bagian ambil data kembali yang NULL

        Data_Sewa.GSmerek = Data_Sewa.getMerekById(selectedData(1))
        Data_Sewa.GSnamaPenyewa = selectedData(2)
        Data_Sewa.GSrencanaPinjam = selectedData(3)
        Data_Sewa.GStanggalPinjam = selectedData(4)
        Data_Sewa.GStanggalKembali = selectedData(5)
        Data_Sewa.GStotalBiayaSewa = selectedData(6)
        Data_Sewa.GSbiayaKelebihanSewa = selectedData(7)
        Data_Sewa.GStotalBayar = selectedData(8)
        Data_Sewa.GSstatusSewa = selectedData(9)
        Data_Sewa.GStipe = Data_Sewa.getTipe(selectedData(1))

        Dim edit = New edit_sewa()
        edit.Show()
    End Sub
End Class