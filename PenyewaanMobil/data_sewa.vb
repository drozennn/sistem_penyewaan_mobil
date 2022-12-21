Imports MySql.Data.MySqlClient
Public Class data_sewa
    'variable database

    Private dataTableSewa As New List(Of String)
    Private tableTipe As New List(Of String)

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

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
    Private totalBiayaSewa As String
    Private biayaKelebihanSewa As String
    Private totalBayar As String
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

    Public Property GStotalBiayaSewa() As String
        Get
            Return totalBiayaSewa
        End Get
        Set(value As String)
            totalBiayaSewa = value
        End Set
    End Property

    Public Property GSbiayaKelebihanSewa() As String
        Get
            Return biayaKelebihanSewa
        End Get
        Set(value As String)
            biayaKelebihanSewa = value
        End Set
    End Property

    Public Property GStotalBayar() As String
        Get
            Return totalBayar
        End Get
        Set(value As String)
            totalBayar = value
        End Set
    End Property

    Public Property GSstatusSewa() As String
        Get
            Return statusSewa
        End Get
        Set(value As String)
            statusSewa = value
        End Set
    End Property

    Public Property GStipe() As List(Of String)
        Get
            Return tableTipe
        End Get
        Set(value As List(Of String))
            tableTipe = value
        End Set
    End Property

    '====================================================

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id AS 'ID',
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

            sqlRead = sqlCommand.ExecuteReader
            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


    Public Function AddDataKoleksiDatabase(merek As Integer,
                                           penyewa As Integer,
                                           rencana_pinjam As Integer,
                                           tanggal_pinjam As Date,
                                           tanggal_kembali As Date,
                                           total_biaya_sewa As String,
                                           biaya_kelebihan_pinjam As String,
                                           total_bayar As String,
                                           status_sewa As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try

            Dim idPenyewa = getIdPenyewa(penyewa)
            Dim idMerek = getIdMerek(merek)

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO sewa (merek, penyewa, 
                        rencana_pinjam, tanggal_pinjam, tanggal_kembali, 
                        total_biaya_sewa, biaya_kelebihan_pinjam, total_bayar, 
                        status_sewa) VALUE('" _
                        & merek & "', '" _
                        & idPenyewa & "', '" _
                        & rencana_pinjam & "', '" _
                        & tanggal_pinjam.ToString("yyyy/MM/dd") & "', '" _
                        & tanggal_kembali.ToString("yyyy/MM/dd") & "', '" _
                        & total_biaya_sewa & "', '" _
                        & biaya_kelebihan_pinjam & "', '" _
                        & total_bayar & "', '" _
                        & status_sewa & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function loadPenyewa()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT nama FROM penyewa"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                dataTableSewa.Add(sqlRead.GetString(0).ToString)
            End While
            sqlRead.Close()
            dbConn.Close()

            Return dataTableSewa

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function LoadMobil()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT merek FROM mobil WHERE status_sewa = 'Tersedia'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dataTableSewa.Clear()
            While sqlRead.Read
                dataTableSewa.Add(sqlRead.GetString(0).ToString)
            End While
            sqlRead.Close()
            dbConn.Close()

            Return dataTableSewa

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function LoadTipe(merek As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT tipe FROM mobil WHERE merek = '" & merek & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dataTableSewa.Clear()
            While sqlRead.Read
                dataTableSewa.Add(sqlRead.GetString(0).ToString)
            End While
            sqlRead.Close()
            dbConn.Close()

            Return dataTableSewa

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function getIdPenyewa(nama As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT id FROM penyewa WHERE nama = " & nama

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Close()
            dbConn.Close()

            Return sqlRead.GetString(0).ToString

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function getIdMerek(merek As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT id FROM penyewa WHERE nama = " & merek

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Close()
            dbConn.Close()

            Return sqlRead.GetString(0).ToString

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

End Class
