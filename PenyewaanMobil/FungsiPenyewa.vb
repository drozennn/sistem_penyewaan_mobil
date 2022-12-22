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

    Public Property GSNama() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property GSNIK() As String
        Get
            Return nik
        End Get
        Set(value As String)
            nik = value
        End Set
    End Property

    Public Property GSAlamat() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property



    'Public Function AddKoleksiDataTable(nik As Integer,
    '                                    nama As String,
    '                                    alamat As String)
    '    koleksiDataTable.Add({nik,
    '                          nama,
    '                          alamat})
    'End Function

    'Public Function ConvertKoleksiToString(vals As List(Of String))
    '    Dim builder As StringBuilder = New StringBuilder()
    '    For Each val As String In vals
    '        builder.Append(val).Append("|")
    '    Next

    '    'Convert to String
    '    Dim res = builder.ToString()
    '    Return res
    'End Function



    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_penyewa AS 'ID',
                                      nama AS 'Nama',
                                      nik AS 'NIK',
                                      alamat AS 'Alamat'
                                      FROM penyewa"

            sqlRead = sqlCommand.ExecuteReader
            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
            Return result
    End Function

    Public Function AddDataKoleksiDatabase(nama As String,
                                           nik As String,
                                           alamat As String)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO penyewa(nama, nik, alamat) VALUE('" _
                        & nama & "', '" _
                        & nik & "', '" _
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

    Public Function GetDataPenyewaByIdDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_penyewa,
                                  nama,
                                  nik,
                                  alamat
                                  FROM penyewa
                                  WHERE id_penyewa='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataPenyewaByIdDatabase(ID As Integer,
                                                  nama As String,
                                                  nik As String,
                                                  alamat As String)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE penyewa SET " &
                        "nama='" & nama & "', " &
                        "nik='" & nik & "', " &
                        "alamat='" & alamat & "' " &
                        "WHERE id_penyewa='" & ID & "'"

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
End Class
