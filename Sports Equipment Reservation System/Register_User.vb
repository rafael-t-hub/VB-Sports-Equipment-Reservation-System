Imports System.Text.RegularExpressions
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class Register_User
    Private Sub Register_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub cbShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPass.CheckedChanged
        If cbShowPass.Checked = True Then
            tbPass.UseSystemPasswordChar = False

        Else
            tbPass.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub cbShowPass1_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPass1.CheckedChanged
        If cbShowPass1.Checked = True Then

            tBConfirmPass.UseSystemPasswordChar = False

        Else
            tBConfirmPass.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim conn As New MySqlConnection("server=localhost; userid=root; password=; database=login_database")


        Try
            Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
            Dim isEmailValid As Boolean = Regex.IsMatch(tbEmail.Text, emailPattern)
            Dim numberPattern As String = "^\d{1,30}(-\d{1,30})(-\d{1,30})(-\d{1,30})?$"
            Dim phonenumberPattern As String = "^\d{11}$"
            Dim isIdNumberValid As Boolean = Regex.IsMatch(tbIDNum.Text, numberPattern)
            Dim isPhoneNumberValid As Boolean = Regex.IsMatch(tbPhoneNum.Text, phonenumberPattern)

            Dim isFillOut As Boolean = tbEmail.Text = "" And tbName.Text = "" And tBConfirmPass.Text = "" And tbIDNum.Text = "" And tbPhoneNum.Text = "" And tbUsername.Text = "" And tbPass.Text = "" And cbCourseAndSection.SelectedIndex = -1



            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO user_information (username, password, phone_number, id_number, email, name, lastname, year_and_section) VALUES (@username, @password, @phone_number, @id_number, @email, @name, @lastname, @section)", conn)


            If (isFillOut = False) Then

                cmd.Parameters.AddWithValue("@username", tbUsername.Text)
                cmd.Parameters.AddWithValue("@name", tbName.Text)
                cmd.Parameters.AddWithValue("@lastname", tbLastName.Text)
                cmd.Parameters.AddWithValue("@section", cbCourseAndSection.SelectedItem)


                If isPhoneNumberValid Then
                    cmd.Parameters.AddWithValue("@phone_number", tbPhoneNum.Text)

                Else
                    MsgBox("Invalid phone number")
                End If

                If isIdNumberValid Then
                    cmd.Parameters.AddWithValue("@id_number", tbIDNum.Text)
                Else
                    MsgBox("Invalid id number")
                End If

                If isEmailValid Then
                    cmd.Parameters.AddWithValue("@email", tbEmail.Text.Trim())
                Else
                    MsgBox("Invalid email address")

                End If

                If tbPass.Text = tBConfirmPass.Text Then
                    cmd.Parameters.AddWithValue("@password", tbPass.Text.Trim)

                Else
                    MsgBox("Error: Password Confirmation Mismatch")
                End If


                cmd.ExecuteNonQuery()
                MsgBox("Succesfully Created an Account")

                tbUsername.Text = ""
                tBConfirmPass.Text = ""
                tbPass.Text = ""
                tbEmail.Text = ""
                tbIDNum.Text = ""
                tbPhoneNum.Text = ""
                tbName.Text = ""
                tbLastName.Text = ""
                cbCourseAndSection.SelectedIndex = -1

            Else
                MsgBox("Please fill out all required fields")


            End If


        Catch ex As Exception
            MsgBox(ex.Message)


        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub Register_User_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub


End Class