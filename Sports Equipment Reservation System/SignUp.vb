Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class SignUp
    Private Sub btnAdminRegister_Click(sender As Object, e As EventArgs) Handles btnAdminRegister.Click
        ' Handle the registration button click event
        Dim conn As New MySqlConnection("server=localhost; userid=root; password=; database=login_database")

        Try
            ' Define regular expression patterns for validation
            Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
            Dim isEmailValid As Boolean = Regex.IsMatch(tbAdminEmail.Text, emailPattern)
            Dim customPattern As String = "^[A-Z]{3}.*\d.*$"
            Dim phonenumberPattern As String = "^(09)\d{9}$"
            Dim isPhoneNumberValid As Boolean = Regex.IsMatch(tbAdminPhoneNum.Text, phonenumberPattern)
            Dim isIdNumberValid As Boolean = Regex.IsMatch(tbAdminIDNum.Text, customPattern)
            Dim isFillOut As Boolean = tbAdminEmail.Text = "" And tbAdminName.Text = "" And tbAdminConfirmPass.Text = "" And tbAdminIDNum.Text = "" And tbAdminPhoneNum.Text = "" And tbAdminUsername.Text = "" And tbAdminPass.Text = ""

            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO admin_information (username, password, phone_number, id_number, email, name, lastname) VALUES (@username, @password, @phone_number, @id_number, @email, @name, @lastname)", conn)

            If (isFillOut = False) Then
                ' Check if required fields are filled out

                cmd.Parameters.AddWithValue("@username", tbAdminUsername.Text)
                cmd.Parameters.AddWithValue("@name", tbAdminName.Text)
                cmd.Parameters.AddWithValue("@lastname", tbAdminLastName.Text)

                If isPhoneNumberValid Then
                    cmd.Parameters.AddWithValue("@phone_number", tbAdminPhoneNum.Text)
                Else
                    MsgBox("Invalid phone number")
                End If

                If isIdNumberValid Then
                    cmd.Parameters.AddWithValue("@id_number", tbAdminIDNum.Text)
                Else
                    MsgBox("Invalid id number")
                End If

                If isEmailValid Then
                    cmd.Parameters.AddWithValue("@email", tbAdminEmail.Text)
                Else
                    MsgBox("Invalid email address")
                End If

                If tbAdminPass.Text = tbAdminConfirmPass.Text Then
                    cmd.Parameters.AddWithValue("@password", tbAdminPass.Text)
                End If

                cmd.ExecuteNonQuery()
                MsgBox("Successfully Created an Account")

                ' Clear the input fields
                tbAdminUsername.Text = ""
                tbAdminConfirmPass.Text = ""
                tbAdminPass.Text = ""
                tbAdminEmail.Text = ""
                tbAdminIDNum.Text = ""
                tbAdminPhoneNum.Text = ""
                tbAdminName.Text = ""
                tbAdminLastName.Text = ""
            Else
                MsgBox("Please fill out all required fields")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub lnkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignUp.LinkClicked
        ' Handle the link label click event to show the "Form1" and hide the current form
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cbShowHidePass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowHidePass.CheckedChanged
        ' Handle the checkbox for showing/hiding the password
        If cbShowHidePass.Checked Then
            tbAdminPass.UseSystemPasswordChar = False
        Else
            tbAdminPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Handle the checkbox for showing/hiding the password
        If CheckBox1.Checked Then
            tbAdminConfirmPass.UseSystemPasswordChar = False
        Else
            tbAdminConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub tbAdminEmail_TextChanged(sender As Object, e As EventArgs) Handles tbAdminEmail.TextChanged

    End Sub

    Private Sub tbAdminName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAdminName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = " " Then
            e.Handled = True
        End If

    End Sub

    Private Sub tbAdminLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAdminLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbAdminPhoneNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAdminPhoneNum.KeyPress
        ' Check if the character associated with the keypress is NOT a numeric digit
        ' AND the keypress is NOT the Delete key
        ' AND the keypress is NOT the Backspace key
        ' AND the keypress is NOT a Space character
        ' If all conditions are met, prevent the keypress from being processed (e.Handled = True)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If

    End Sub

    Private Sub tbAdminPhoneNum_TextChanged(sender As Object, e As EventArgs) Handles tbAdminPhoneNum.TextChanged

    End Sub

    Private Sub tbAdminIDNum_TextChanged(sender As Object, e As EventArgs) Handles tbAdminIDNum.TextChanged

    End Sub
End Class
