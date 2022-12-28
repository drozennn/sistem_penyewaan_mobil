Imports MySql.Data.MySqlClient
Public Class Mobil
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "penyewaan_mobil"

    Private dataJenis As New List(Of String)

    Private jenis As String
    Private tipe As String
    Private jumlah As Integer
    Private merek As String
    Private harga As Integer
    Private tahunPembuatan As String
    Private tglMasuk As String
    Private status As String
    Private foto

    Public Property GSfoto() As String
        Get
            Return foto
        End Get
        Set(ByVal value As String)
            foto = value
        End Set
    End Property
    Public Property GSJenis() As String
        Get
            Return jenis
        End Get
        Set(value As String)
            jenis = value
        End Set
    End Property
    Public Property GSTipe() As String
        Get
            Return tipe
        End Get
        Set(value As String)
            tipe = value
        End Set
    End Property
    Public Property GSMerek() As String
        Get
            Return merek
        End Get
        Set(value As String)
            merek = value
        End Set
    End Property
    Public Property GSJumlah() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property
    Public Property GSHarga() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property
    Public Property GSTahunPembuatan() As String
        Get
            Return tahunPembuatan
        End Get
        Set(value As String)
            tahunPembuatan = value
        End Set
    End Property
    Public Property GSTglMasuk() As String
        Get
            Return tglMasuk
        End Get
        Set(value As String)
            tglMasuk = value
        End Set
    End Property
    Public Property GSstatus() As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property
    Public Function loadJenis()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT jenis_mobil FROM jenis_mobil"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                dataJenis.Add(sqlRead.GetString(0).ToString)
            End While
            sqlRead.Close()
            dbConn.Close()

            Return dataJenis

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  jenis AS 'Jenis Mobil',
                                  foto_mobil AS 'Gambar',
                                  tipe AS 'tipe mobil',
                                  merek AS 'merek mobil',
                                  jumlah AS 'jumlah mobil',
                                  harga_sewa AS 'harga sewa',
                                  tahun_pembuatan AS 'Tahun Pembuatan', 
                                  tanggal_data_masuk AS 'Tanggal Masuk',
                                  status_sewa AS 'Status'
                                 
                                  FROM mobil"
        sqlRead = sqlCommand.ExecuteReader
        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  dir_gambar As String,
                                                  jenis As String,
                                                  tipe As String,
                                                  merek As Integer,
                                                  jumlah As Integer,
                                                  harga_sewa As String,
                                                  tahun_pembuatan As Date,
                                                  tanggal_data_masuk As Date,
                                                  status As String)
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE koleksi SET " &
                "jenis='" & jenis & "', " &
                "dir_gambar='" & dir_gambar & "', " &
                "tipe='" & tipe & "', " &
                "merek='" & merek & "', " &
                "jumlah='" & jumlah & "', " &
                "harga_sewa='" & harga_sewa & "', " &
                "tahun_pembuatan='" & tahun_pembuatan & "', " &
                "tanggal_data_masuk='" & tanggal_data_masuk & "', " &
                "status='" & status & "' " &
                " WHERE id='" & ID & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader
                dbConn.Close()
                sqlRead.Close()
                MessageBox.Show("data diupdate")
            Catch ex As Exception
                MessageBox.Show("gagal update : " & ex.Message.ToString())
            Finally
                dbConn.Dispose()
            End Try
        Catch ex As Exception
            MessageBox.Show("masalah koneksi")
        End Try
    End Function
    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id,
                                  jenis,
                                  foto_mobil,
                                  tipe,
                                  merek,
                                  jumlah,
                                  harga_sewa,
                                  tahun_pembuatan,
                                  tanggal_data_masuk,
                                  status_sewa
                                  FROM mobil
                                  WHERE id='" & ID & "'"

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

        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
               + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM mobil " &
                        "WHERE id='" & ID & "'"

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
    Public Function addKoleksiDataTableDatabase(dir_gambar As String,
                                  jenis As String,
                                  tipe As String,
                                  merek As String,
                                  jumlah As Integer,
                                  harga_sewa As String,
                                  tahun_pembuatan As String,
                                  tanggal_data_masuk As Date)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try

            Dim idJenis = getIDJenis(jenis)

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO mobil(jenis, foto_mobil, tipe, merek,
                       jumlah, harga_sewa, tahun_pembuatan, tanggal_data_masuk, status_sewa)
                        VALUES(" _
            & idJenis & ", '" _
            & dir_gambar & "', '" _
            & tipe & "','" _
            & merek & "'," _
            & jumlah & "," _
            & harga_sewa & ",'" _
            & tahun_pembuatan & "','" _
            & tanggal_data_masuk.ToString("yyyy/MM/dd") & "','Tersedia')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function
    Public Function getIDJenis(merek As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT id FROM jenis_mobil WHERE jenis_mobil = '" & merek & "'"

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

End Class
