Imports MySql.Data.MySqlClient

Module connection
    Public Sub dbConnection()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;user id=root;password=alex;database=newpost_database"
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
