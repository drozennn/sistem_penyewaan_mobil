Public Class form_sewa

    Public Shared Data_Sewa As data_sewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Data_Sewa = New data_sewa()
        ReloadDataTableDatabase()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridSewa.DataSource = Data_Sewa.GetDataKoleksiDatabase()
    End Sub

    Private Sub form_sewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class