Imports Mysqlx.XDevAPI.Relational

Public Class form_sewa
    Private data As New List(Of String)
    Public Shared Data_Sewa As data_sewa
    Public Shared selectedId
    Public Shared selectedMerek
    Public Shared selectedNama
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
        If selectedId = 0 Then
            MessageBox.Show("pilih baris yang ingin dihapus pada datagrid ")
        Else
            Dim hapus = New hapus_sewa()
            hapus.Show()
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim tambah = New tambah_data_sewa()
        tambah.Show()
    End Sub

    Private Sub DataGridSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSewa.CellClick
        Dim index As Integer = e.RowIndex
        selectedRow = DataGridSewa.Rows(index)
        selectedId = selectedRow.Cells(0).Value
        selectedMerek = selectedRow.Cells(1).Value
        selectedNama = selectedRow.Cells(2).Value
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If selectedId = 0 Then
            MessageBox.Show("Pilih baris yang ingin di update pada datagrid")
        Else
            Dim selectedData As List(Of String) = Data_Sewa.GetDataByIDDatabase(selectedId)

            Data_Sewa.GSmerek = selectedData(10)
            Data_Sewa.GSnamaPenyewa = selectedData(2)
            Data_Sewa.GSrencanaPinjam = selectedData(3)
            Data_Sewa.GStanggalPinjam = Date.Parse(selectedData(4))

            If selectedData(5) = "Belum Dikembalikan" Then
                Data_Sewa.GStanggalKembali = Date.Parse(selectedData(4)).AddDays(selectedData(3))
            Else
                Data_Sewa.GStanggalKembali = selectedData(5)
            End If
            Data_Sewa.GStotalBiayaSewa = selectedData(6)
            Data_Sewa.GSbiayaKelebihanSewa = selectedData(7)
            Data_Sewa.GStotalBayar = selectedData(8)
            Data_Sewa.GSstatusSewa = selectedData(9)
            Data_Sewa.GStipe = selectedData(1)
            Data_Sewa.GSHargaSewa = selectedData(11)

            Dim edit = New edit_sewa()
            edit.Show()
        End If
    End Sub
End Class