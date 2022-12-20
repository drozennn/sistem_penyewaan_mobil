Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FungsiPenyewa

    Private koleksiDataTable As New ArrayList()

    Private nama As String
    Private nik As String
    Private alamat As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "penyewaan_mobil"

    Public Function AddKoleksiDataTable(nik As Integer,
                                        nama As String,
                                        alamat As String)
        koleksiDataTable.Add({nik,
                              nama,
                              alamat})
    End Function

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert to String
        Dim res = builder.ToString()
        Return res
    End Function



    'Public Function GetDataKoleksiDatabase() As DataTable
    '    Dim result As New DataTable

    '    dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
    '    dbConn.Open()
    '    sqlCommand.Connection = dbConn
    '    sqlCommand.CommandText = "SELECT id_koleksi AS 'ID'"
    'End Function

    Public Function AddDataKoleksiDatabase(nik As String,
                                           nama As String,
                                           alamat As String)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO penyewaan_mobil(nik, nama, alamat) VALUE('" _
                        & nik & "', '" _
                        & nama & "', '" _
                        & alamat & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
