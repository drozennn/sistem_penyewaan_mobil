Imports MySql.Data.MySqlClient
Public Class data_sewa
    'variable database

    Private dataTableSewa As New ArrayList()

    Public Shared dbconn As New MySqlConnection
    Public Shared sqlcommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader
    Private sqlquery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "penyewaan_mobil"

    '==================================================

    'variable local

    Private namaPenyewa As Integer
    Private merek As Integer
    Private rencanaPinjam As Integer
    Private tanggalPinjam As Date
    Private tanggalKembali As Date
    Private totalBiayaSewa As Integer
    Private biayaKelebihanSewa As Integer
    Private totalBayar As Integer
    Private statusSewa As String

    '====================================================

    Public Property GSnamaPenyewa() As Integer
        Get
            Return namaPenyewa
        End Get
        Set(value As Integer)
            namaPenyewa = value
        End Set
    End Property

    Public Property GSmerek() As Integer
        Get
            Return merek
        End Get
        Set(value As Integer)
            merek = value
        End Set
    End Property

    Public Property GSrencanaPinjam() As Integer
        Get
            Return rencanaPinjam
        End Get
        Set(value As Integer)
            rencanaPinjam = value
        End Set
    End Property

    Public Property GStanggalPinjam() As Date
        Get
            Return tanggalPinjam
        End Get
        Set(value As Date)
            tanggalPinjam = value
        End Set
    End Property

    Public Property GStanggalKembali() As Date
        Get
            Return tanggalKembali
        End Get
        Set(value As Date)
            tanggalKembali = value
        End Set
    End Property

    Public Property GStotalBiayaSewa() As Integer
        Get
            Return totalBiayaSewa
        End Get
        Set(value As Integer)
            totalBiayaSewa = value
        End Set
    End Property

    Public Property GSbiayaKelebihanSewa() As Integer
        Get
            Return biayaKelebihanSewa
        End Get
        Set(value As Integer)
            biayaKelebihanSewa = value
        End Set
    End Property

    Public Property GStotalBayar() As Integer
        Get
            Return totalBayar
        End Get
        Set(value As Integer)
            totalBayar = value
        End Set
    End Property

    Public Property GSstatusSewa() As Integer
        Get
            Return statusSewa
        End Get
        Set(value As Integer)
            statusSewa = value
        End Set
    End Property

    '====================================================

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbconn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database=" + database
        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlcommand.CommandText = "SELECT id AS 'ID',
                                  merek AS 'Merek',
                                  penyewa AS 'Penyewa',
                                  rencana_pinjam AS 'Rencana Pinjam',
                                  tanggal_pinjam AS 'Tanggal Pinjam',
                                  tanggal_kembali AS 'Tanggal Kembali',
                                  total_biaya_sewa AS 'Total Biaya Sewa',
                                  biaya_kelebihan_pinjam AS 'Biaya Kelebihan Pinjam',
                                  total_bayar AS 'Total Bayar'
                                  status_sewa AS 'Status Sewa'
                                  FROM sewa"

            sqlread = sqlcommand.ExecuteReader
            result.Load(sqlread)
            sqlread.Close()
            dbconn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


    Public Function AddDataKoleksiDatabase(merek As Integer,
                                           penyewa As String,
                                           rencana_pinjam As Integer,
                                           tanggal_pinjam As Date,
                                           tanggal_kembali As Date,
                                           total_biaya_sewa As Integer,
                                           biaya_kelebihan_pinjam As Integer,
                                           total_bayar As Integer,
                                           status_sewa As String)

        dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = "INSERT INTO SEWA (merek, penyewa, 
                        rencana_pinjam, tanggal_pinjam, tanggal_kembali, 
                        total_biaya_sewa, biaya_kelebihan_pinjam, total_bayar, 
                        status_sewa) VALUE('" _
                        & merek & "', '" _
                        & penyewa & "', '" _
                        & rencana_pinjam & "', '" _
                        & tanggal_pinjam.ToString("yyyy/MM/dd") & "', '" _
                        & tanggal_kembali.ToString("yyyy/MM/dd") & "', '" _
                        & total_biaya_sewa & "', '" _
                        & biaya_kelebihan_pinjam & "', '" _
                        & total_bayar & "', '" _
                        & status_sewa & "')"

            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader
            dbconn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlread.Close()
            dbconn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbconn.Dispose()
        End Try
    End Function


End Class
