Public Class FormMobil
    Public Shared Mobil As Mobil

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
End Class