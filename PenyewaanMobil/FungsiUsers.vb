Imports MySql.Data.MySqlClient

Public Class FungsiUsers

    Dim dir_foto As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "penyewaan_mobil"

    Public Property GSFoto() As String
        Get
            Return dir_foto
        End Get
        Set(value As String)
            dir_foto = value
        End Set
    End Property

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function AddUsersDatabase(username_regist As String, email_regist As String, password_regist As String, foto_regist As String)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO users (username, email, password, foto) VALUE('" _
                        & username_regist & "', '" _
                        & email_regist & "', '" _
                        & EncryptMD5(password_regist) & "', '" _
                        & foto_regist & "')"

            Debug.WriteLine(sqlQuery)

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

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database
            dbConn.Open()

            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id, username FROM users WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
