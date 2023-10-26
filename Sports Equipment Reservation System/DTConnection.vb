Imports MySql.Data.MySqlClient

Public Class DTConnection
    Dim conect As MySqlConnection
    Dim connectionString As String = "server=localhost; userid=root; password=; database=login_database"

    Public Function Open() As MySqlConnection
        Try
            If conect Is Nothing Then
                conect = New MySqlConnection(connectionString)
            End If

            If conect.State = ConnectionState.Closed Then
                conect.Open()
            End If
        Catch ex As Exception
            ' Handle connection opening errors here
            ' You can log the error or take appropriate actions
            Throw New Exception("Failed to open the connection.", ex)
        End Try

        Return conect
    End Function

    Public Function Close() As MySqlConnection
        Try
            If conect IsNot Nothing AndAlso conect.State = ConnectionState.Open Then
                conect.Close()
            End If
        Catch ex As Exception
            ' Handle connection closing errors here
            ' You can log the error or take appropriate actions
            Throw New Exception("Failed to close the connection.", ex)
        End Try

        Return conect
    End Function
End Class

