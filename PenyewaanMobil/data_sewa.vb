Imports MySql.Data.MySqlClient
Public Class data_sewa
    'variable database

    Private dataTableSewa As New List(Of String)

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

    Private namaPenyewa As String
    Private merek As String
    Private Tipe As String
    Private rencanaPinjam As Integer
    Private tanggalPinjam As String
    Private tanggalKembali As String
    Private totalBiayaSewa As String
    Private biayaKelebihanSewa As String
    Private totalBayar As String
    Private statusSewa As String
    Private harga_sewa As Integer

    '====================================================

    Public Property GSnamaPenyewa() As String
        Get
            Return namaPenyewa
        End Get
        Set(value As String)
            namaPenyewa = value
        End Set
    End Property

    Public Property GSmerek() As String
        Get
            Return merek
        End Get
        Set(value As String)
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

    Public Property GStanggalPinjam() As String
        Get
            Return tanggalPinjam
        End Get
        Set(value As String)
            tanggalPinjam = value
        End Set
    End Property

    Public Property GStanggalKembali() As String
        Get
            Return tanggalKembali
        End Get
        Set(value As String)
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

    Public Property GStipe() As String
        Get
            Return Tipe
        End Get
        Set(value As String)
            Tipe = value
        End Set
    End Property

    Public Property GSHargaSewa() As Integer
        Get
            Return harga_sewa
        End Get
        Set(value As Integer)
            harga_sewa = value
        End Set
    End Property

    '====================================================

    Public Function GetDataDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT sewa.id AS 'id', 
                                      mobil.tipe AS 'Merek', 
                                      penyewa.nama AS 'Penyewa', 
                                      rencana_pinjam AS 'Rencana Pinjam', 
                                      tanggal_pinjam AS 'Tanggal Pinjam', 
                                      CASE WHEN tanggal_kembali IS NULL THEN 'Belum Dikembalikan' 
                                      ELSE tanggal_kembali
                                      END AS 'Tanggal Kembali', 
                                      total_biaya_sewa AS 'Total Biaya Sewa', 
                                      biaya_kelebihan_pinjam AS 'Biaya Kelebihan Pinjam', 
                                      total_bayar AS 'Total Bayar', 
                                      sewa.status_sewa AS 'Status Sewa' 
                                      FROM sewa JOIN mobil on sewa.merek = mobil.id 
                                      JOIN penyewa on sewa.penyewa = penyewa.id_penyewa"

            sqlRead = sqlCommand.ExecuteReader
            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


    Public Function AddDataDatabase(merek As String,
                                           penyewa As String,
                                           rencana_pinjam As Integer,
                                           tanggal_pinjam As Date,
                                           total_biaya_sewa As String,
                                           status_sewa As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try

            Dim idPenyewa = getIdPenyewa(penyewa)
            Dim idMerek = getIdMerek(merek)

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO sewa (merek, penyewa, 
                        rencana_pinjam, tanggal_pinjam, total_biaya_sewa, 
                        biaya_kelebihan_pinjam, total_bayar, 
                        status_sewa) VALUES(" _
                        & idMerek & ", " _
                        & idPenyewa & ", " _
                        & rencana_pinjam & ", '" _
                        & tanggal_pinjam.ToString("yyyy/MM/dd") & "', " _
                        & total_biaya_sewa & ", " _
                        & 0 & ", " _
                        & total_biaya_sewa & ", '" _
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

    Public Function GetDataByIDDatabase(id As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT sewa.id,
                                  mobil.tipe,
                                  penyewa.nama,
                                  rencana_pinjam,
                                  tanggal_pinjam,
                                  CASE WHEN tanggal_kembali IS NULL THEN 'Belum Dikembalikan'
                                  ELSE tanggal_kembali
                                  END,
                                  total_biaya_sewa,
                                  biaya_kelebihan_pinjam,
                                  total_bayar,
                                  sewa.status_sewa,
                                  mobil.merek,
                                  mobil.harga_sewa
                                  FROM sewa JOIN mobil on sewa.merek = mobil.id 
                                  JOIN penyewa on sewa.penyewa = penyewa.id_penyewa 
                                  WHERE sewa.id ='" & id & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function


    'masih belum bisa update
    Public Function UpdateDataByIDDatabase(id As Integer,
                                                  merek As String,
                                                  penyewa As String,
                                                  rencana_pinjam As Integer,
                                                  tanggal_pinjam As Date,
                                                  tanggal_kembali As Date,
                                                  total_biaya_sewa As String,
                                                  biaya_kelebihan_pinjam As String,
                                                  total_bayar As String,
                                                  status_sewa As String)

        'tahun_terbit = tahun_terbit.ToString()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try

            Dim idPenyewa = getIdPenyewa(penyewa)
            Dim idMerek = getIdMerek(merek)

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE sewa SET " &
                        "merek=" & idMerek & ", " &
                        "penyewa=" & idPenyewa & ", " &
                        "rencana_pinjam=" & rencana_pinjam & ", " &
                        "tanggal_pinjam='" & tanggal_pinjam.ToString("yyyy/MM/dd") & "', " &
                        "tanggal_kembali='" & tanggal_kembali.ToString("yyyy/MM/dd") & "', " &
                        "total_biaya_sewa=" & total_biaya_sewa & ", " &
                        "biaya_kelebihan_pinjam=" & biaya_kelebihan_pinjam & ", " &
                        "total_bayar=" & total_bayar & ", " &
                        "status_sewa='" & status_sewa & "' " &
                        "WHERE id='" & id & "'"

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

    Public Function DeleteDataByIDDatabase(id As Integer)

        'tahun_terbit = tahun_terbit.ToString()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM sewa WHERE id = '" & id & "'"

            Debug.WriteLine(sqlQuery)

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
            sqlQuery = "SELECT DISTINCT merek FROM mobil WHERE status_sewa = 'Tersedia'"

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

    Public Function LoadMobilUpdate()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT DISTINCT merek FROM mobil"

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
            sqlQuery = "SELECT tipe FROM mobil WHERE merek = '" & merek & "' AND status_sewa = 'Tersedia'"

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

    Public Function LoadTipeUpdate(merek As String)
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
            sqlQuery = "SELECT id_penyewa FROM penyewa WHERE nama = '" & nama & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            Dim result As Integer
            While sqlRead.Read
                result = sqlRead.GetString(0).ToString
            End While

            sqlRead.Close()
            dbConn.Close()

            Return result

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function getIdMerek(tipe As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT id FROM mobil WHERE tipe = '" & tipe & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            Dim result As Integer
            While sqlRead.Read
                result = sqlRead.GetString(0).ToString
            End While

            sqlRead.Close()
            dbConn.Close()

            Return result

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function hargaSewa(tipe As String, hari As Integer) As Integer
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT harga_sewa FROM mobil WHERE tipe = '" & tipe & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            Dim result As Integer
            While sqlRead.Read
                result = sqlRead.GetString(0).ToString
            End While

            Dim harga As Integer = Integer.Parse(result) * hari

            sqlRead.Close()
            dbConn.Close()

            Return harga

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function getTipe(id As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
           + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT tipe FROM mobil WHERE id = '" & id & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            Dim result As String
            While sqlRead.Read
                result = sqlRead.GetString(0).ToString
            End While

            sqlRead.Close()
            dbConn.Close()

            Return result

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function getMerekById(id As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
           + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT merek FROM mobil WHERE id = '" & id & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            Dim result As String
            While sqlRead.Read
                result = sqlRead.GetString(0).ToString
            End While

            sqlRead.Close()
            dbConn.Close()

            Return result

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function setSewa(id As String, status_sewa As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            Dim idMerek = getIdMerek(id)
            Dim status As String

            If status_sewa = "Booking" Then
                status = "Di Booking"
            ElseIf status_sewa = "Pinjam" Then
                status = "Dipinjam"
            Else
                status = "Tersedia"
            End If

            MessageBox.Show(status)

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE mobil SET " &
                        "status_sewa='" & status & "' " &
                        "WHERE id='" & idMerek & "'"

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

End Class
