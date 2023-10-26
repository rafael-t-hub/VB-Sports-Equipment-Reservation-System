Imports MySql.Data.MySqlClient

Public Class DTConnection
    Dim conect As New MySqlConnection("server=localhost; userid=root; password=; database=login_database")

    Public Function Open() As MySqlConnection
        Try
            conect.Open()
        Catch ex As Exception
            ' Handle connection opening errors here
            ' You can log the error or take appropriate actions
            Throw New Exception("Failed to open the connection.", ex)
        End Try
        Return conect
    End Function

    Public Function Close() As MySqlConnection
        Try
            conect.Close()
        Catch ex As Exception
            ' Handle connection closing errors here
            ' You can log the error or take appropriate actions
            Throw New Exception("Failed to close the connection.", ex)
        End Try
        Return conect
    End Function
End Class
