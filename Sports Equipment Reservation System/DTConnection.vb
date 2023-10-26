Imports MySql.Data.MySqlClient

Public Class DTConnection
    Dim conect As New MySqlConnection("server=localhost; userid=root; password=; database=login_database")


    Public Function open() As MySqlConnection
        Try
            conect.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return conect
    End Function

    Public Function close() As MySqlConnection
        Try
            conect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return conect
    End Function
End Class
