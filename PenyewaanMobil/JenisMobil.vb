Imports MySql.Data.MySqlClient
Public Class JenisMobil
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "penyewaan_mobil"

    Private jenismobil As String
    Private tanggal As String

    Public Property GSJenisMobil() As String
        Get
            Return jenismobil
        End Get
        Set(value As String)
            jenismobil = value
        End Set
    End Property
    Public Property GSTanggal() As String
        Get
            Return tanggal
        End Get
        Set(value As String)
            tanggal = value
        End Set
    End Property
    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  jenis_mobil as 'Jenis Mobil', 
                                  created_at AS 'Created At'
                                  FROM jenis_mobil"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(jenis_mobil As String,
                                    created_at As Date)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jenis_mobil (jenis_mobil, created_at) VALUE('" _
                                                 & jenis_mobil & "', '" _
                                                 & created_at.ToString("yyyy/MM/dd") & "')"

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
    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM jenis_mobil " &
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
End Class

