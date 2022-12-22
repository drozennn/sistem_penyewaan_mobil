Public Class Penyewa

    Dim selectedTablePenyewa
    Dim selectedTablePenyewaNama

    Public Shared FungsiPenyewa As FungsiPenyewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FungsiPenyewa = New FungsiPenyewa()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridPenyewa.DataSource = FungsiPenyewa.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim formtambah = New TambahPenyewa()
        formtambah.Show()
    End Sub

    Private Sub Penyewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridPenyewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPenyewa.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridPenyewa.Rows(index)

        selectedTablePenyewa = selectedRow.Cells(0).Value
        selectedTablePenyewaNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedPenyewa As List(Of String) = FungsiPenyewa.GetDataPenyewaByIdDatabase(selectedTablePenyewa)

        FungsiPenyewa.GSNama = selectedPenyewa(1)
        FungsiPenyewa.GSNIK = selectedPenyewa(2)
        FungsiPenyewa.GSAlamat = selectedPenyewa(3)

        Dim form_edit = New EditPenyewa()
        form_edit.Show()
    End Sub
End Class
