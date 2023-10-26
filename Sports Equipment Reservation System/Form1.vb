
Imports MySql.Data.MySqlClient

Public Class Form1
    ' Import necessary libraries and declare the Form1 class.

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Handle the login button click event.
        ' Establish a connection to a MySQL database named "login_database" on the local server using the root user with no password.
        Dim conn As New MySqlConnection("server=localhost; userid=root; password=; database=login_database")

        ' Open the database connection.
        conn.Open()

        ' Create a SQL query to check if the entered username and password match a record in the "admin" table.
        Dim cmd As New MySqlCommand("SELECT * FROM admin WHERE BINARY username = @username AND BINARY password = @password", conn)

        ' Set the parameters @username and @password in the query to values from text boxes.
        cmd.Parameters.AddWithValue("@username", tbUsername.Text)
        cmd.Parameters.AddWithValue("@password", tbPassword.Text)


        ' Execute the query and check if a matching record is found.
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            ' If a match is found, display the "Main" form and hide the current form.
            Main.Show()
            Me.Hide()
        Else
            ' If no match is found, display an error message.
            MsgBox("Invalid Username or Password")
        End If
        conn.Close()
    End Sub

    Private Sub cbShowHidePass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowHidePass.CheckedChanged
        ' Handle the checkbox for showing/hiding the password.
        If cbShowHidePass.Checked Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub lnkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignUp.LinkClicked
        ' Handle the link label click event to show the "SignUp" form and hide the current form.
        Me.Hide()
        SignUp.Show()
    End Sub


End Class

