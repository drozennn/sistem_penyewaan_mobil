Public Class Form_JenisMobil
    Public Shared jenismobil As JenisMobil
    Public Shared selectedTableId
    Public Shared selectedTableJenisMobil
    Public Shared selectedNama
    Public Shared selectedRow As DataGridViewRow


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        jenismobil = New JenisMobil()
        ReloadDataTableDatabase()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridJenisMobil.DataSource = JenisMobil.GetDataKoleksiDatabase()
    End Sub

    Private Sub Form_JenisMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim insert = New Form_Insert()
        insert.Show()

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If selectedTableId = 0 Then
            MessageBox.Show("Pilih baris yang akan dihapus")
        Else
            Dim formhapus = New Form_Hapus()
            formhapus.Show()
        End If
    End Sub

    Private Sub DataGridJenisMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJenisMobil.CellClick
        Dim index As Integer = e.RowIndex
        selectedRow = DataGridJenisMobil.Rows(index)
        selectedTableId = selectedRow.Cells(0).Value
        selectedNama = selectedRow.Cells(1).Value
    End Sub
End Class