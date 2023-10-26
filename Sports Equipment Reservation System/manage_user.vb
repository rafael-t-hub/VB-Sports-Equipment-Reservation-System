Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class manage_user
#Region "declaration"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim dadapter As MySqlDataAdapter
    Dim dtable As New DataTable

#End Region

#Region "ForGridview"
    Sub VwGridview()
        Try
            ' Retrieve and display data in the DataGridView
            mycmd.Connection = myconnection.open
            mycmd.CommandText = "select * from user_table order by NO asc"
            dadapter = New MySqlDataAdapter(mycmd)
            dtable.Rows.Clear()
            dadapter.Fill(dtable)

            If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
                ' Bind data to the DataGridView
                DGV1.AutoGenerateColumns = False
                DGV1.DataSource = dtable
                DGV1.Columns(0).DataPropertyName = "Student Id"
                DGV1.Columns(1).DataPropertyName = "Name"
                DGV1.Columns(2).DataPropertyName = "Year and Section"
                DGV1.Columns(3).DataPropertyName = "Status"
                DGV1.Columns(4).DataPropertyName = "Phone Number"
                DGV1.Columns(5).DataPropertyName = "Email"
                DGV1.Columns(6).DataPropertyName = "Username"
                DGV1.Columns(7).DataPropertyName = "Password"
                DGV1.Columns(8).DataPropertyName = "Gender"
                DGV1.Columns(9).DataPropertyName = "NO"
            End If
            ' Clear the selection after data is loaded
            DGV1.ClearSelection()
        Catch ex As Exception
            ' Handle any exceptions here, for example, display an error message
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the database connection is always closed
            myconnection.close()
        End Try
    End Sub

    Sub clickGridView()
        ' Handle DataGridView cell click event to populate the text boxes
        Dim i As Integer
        Try
            With DGV1
                If .CurrentCell.Value Is Nothing Then
                    Exit Sub
                Else
                    i = .CurrentRow.Index
                    Tbid.Text = .Rows(i).Cells(0).Value.ToString
                    Tbname.Text = .Rows(i).Cells(1).Value.ToString
                    Tbyearandsection.Text = .Rows(i).Cells(2).Value.ToString

                    ' Set the selected item in the ComboBox to Tbstatus
                    Dim selectedStatus As String = .Rows(i).Cells(3).Value.ToString
                    Dim selectedGender As String = .Rows(i).Cells(8).Value.ToString
                    If cbStatus.Items.Contains(selectedStatus) Then
                        cbStatus.SelectedItem = selectedStatus
                    Else
                        ' If the selected status is not found in the ComboBox, you can handle it accordingly.
                        ' For example, you can add it to the ComboBox or show an error message.

                        MsgBox("Status fail to recognize")
                    End If

                    If cbGender.Items.Contains(selectedGender) Then
                        cbGender.SelectedItem = selectedGender

                    Else
                        MsgBox("Gender fail to recognize")
                    End If
                    Tbpn.Text = .Rows(i).Cells(4).Value.ToString
                    Tbemail.Text = .Rows(i).Cells(5).Value.ToString
                    Tbun.Text = .Rows(i).Cells(6).Value.ToString
                    Tbpassword.Text = .Rows(i).Cells(7).Value.ToString
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub


#End Region



#Region "Checking Duplicated Names and ID"
    ' Function to check if a user with the same name or student ID exists in the database
    Function UserExists(name As String, studentId As String) As Boolean
        ' Replace this section with your actual database check logic
        Dim sqlCheck As String = "SELECT COUNT(*) FROM user_table WHERE Name = @CheckName OR `Student ID` = @CheckStudentId"
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = sqlCheck
        mycmd.Parameters.Clear()
        mycmd.Parameters.AddWithValue("@CheckName", name)
        mycmd.Parameters.AddWithValue("@CheckStudentId", studentId)
        Dim count As Integer = Convert.ToInt32(mycmd.ExecuteScalar())
        myconnection.close()
        Return count > 0
    End Function
#End Region




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mycmd.Connection = myconnection.open()

        Dim i As Integer

        If DGV1.SelectedRows.Count > 0 Then
            i = DGV1.CurrentRow.Index

            ' Access the "NO" column value from the underlying data source
            Dim noValue As String = DGV1.Rows(i).Cells("NO").Value.ToString

            ' Check if there are any changes in the values
            Dim changesMade As Boolean = CheckForChanges(i)

            If changesMade Then
                mycmd.CommandText = "UPDATE user_table 
                SET Name = @Name, `Student ID` = @StudentId, 
                    `Year and Section` = @YearSection, 
                    Status = @Status, 
                    `Phone Number` = @PhoneNumber, 
                    Email = @Email, 
                    Username = @Username, 
                    Password = @Password,
                    Gender = @Gender
                WHERE NO = @NO"
                mycmd.Parameters.Clear()

                ' Set parameter values
                mycmd.Parameters.AddWithValue("@Name", Tbname.Text)
                mycmd.Parameters.AddWithValue("@StudentId", Tbid.Text)
                mycmd.Parameters.AddWithValue("@YearSection", Tbyearandsection.Text)
                mycmd.Parameters.AddWithValue("@Status", cbStatus.SelectedItem.ToString())
                mycmd.Parameters.AddWithValue("@PhoneNumber", Tbpn.Text)
                mycmd.Parameters.AddWithValue("@Email", Tbemail.Text)
                mycmd.Parameters.AddWithValue("@Username", Tbun.Text)
                mycmd.Parameters.AddWithValue("@Password", Tbpassword.Text)
                mycmd.Parameters.AddWithValue("@Gender", cbGender.SelectedItem.ToString())
                mycmd.Parameters.AddWithValue("@NO", noValue)

                mycmd.ExecuteNonQuery()
                VwGridview()

                Tbname.Text = ""
                Tbid.Text = ""
                Tbyearandsection.Text = ""
                cbStatus.SelectedIndex = -1 ' Clear the selected item in the ComboBox
                Tbpn.Text = ""
                Tbpassword.Text = ""
                Tbemail.Text = ""
                Tbun.Text = ""
                cbGender.SelectedIndex = -1

                MsgBox("Data updated!", MsgBoxStyle.Information, "Notice")
            Else
                MsgBox("No changes made to the data.", MsgBoxStyle.Information, "Notice")
            End If
        Else
            MessageBox.Show("Please select a row to update")
        End If
        myconnection.close()
    End Sub

    Private Function CheckForChanges(rowIndex As Integer) As Boolean
        ' Compare the values in the textboxes with the values in the DataGridView
        If Tbname.Text <> DGV1.Rows(rowIndex).Cells(1).Value.ToString Or
       Tbid.Text <> DGV1.Rows(rowIndex).Cells(0).Value.ToString Or
       Tbyearandsection.Text <> DGV1.Rows(rowIndex).Cells(2).Value.ToString Or
       cbStatus.SelectedItem.ToString() <> DGV1.Rows(rowIndex).Cells(3).Value.ToString Or
       Tbpn.Text <> DGV1.Rows(rowIndex).Cells(4).Value.ToString Or
       Tbemail.Text <> DGV1.Rows(rowIndex).Cells(5).Value.ToString Or
       Tbun.Text <> DGV1.Rows(rowIndex).Cells(6).Value.ToString Or
       Tbpassword.Text <> DGV1.Rows(rowIndex).Cells(7).Value.ToString Or
       cbGender.SelectedItem.ToString() <> DGV1.Rows(rowIndex).Cells(8).Value.ToString Then
            Return True ' Changes were made
        Else
            Return False ' No changes were made
        End If
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Handle the refresh button click event
        VwGridview()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Handle the delete button click event
        Dim i As Integer

        If DGV1.SelectedRows.Count > 0 Then
            i = DGV1.CurrentRow.Index

            Dim noValue As String = DGV1.Rows(i).Cells("NO").Value.ToString
            mycmd.Connection = myconnection.open()
            mycmd.Parameters.Clear()
            mycmd.CommandText = "DELETE FROM user_table WHERE NO = @NO"
            mycmd.Parameters.AddWithValue("@NO", noValue)
            mycmd.ExecuteNonQuery()
            VwGridview()


            Tbname.Text = ""
            Tbid.Text = ""
            Tbyearandsection.Text = ""
            cbStatus.SelectedIndex = -1 ' Clear the selected item in the ComboBox
            Tbpn.Text = ""
            Tbpassword.Text = ""
            Tbemail.Text = ""
            Tbun.Text = ""
            cbGender.SelectedIndex = -1
            MsgBox("Data deleted!", MsgBoxStyle.Information, "Notice")
        Else
            MessageBox.Show("Please select a row to delete")
        End If
        myconnection.close()

    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        ' Handle the DataGridView cell click event to populate the text boxes
        clickGridView()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Handle the Save button click event
            Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
            Dim phonenumberPattern As String = "^(09)\d{9}$"

            If String.IsNullOrWhiteSpace(Tbname.Text) OrElse
        String.IsNullOrWhiteSpace(Tbid.Text) OrElse Not Regex.IsMatch(Tbid.Text, "^\d{2}-\d{1}-\d{1}-\d{4}$") OrElse
        String.IsNullOrWhiteSpace(Tbyearandsection.Text) OrElse
        cbStatus.SelectedItem Is Nothing OrElse ' Check if no item is selected in the ComboBox
         cbGender.SelectedItem Is Nothing OrElse
        String.IsNullOrWhiteSpace(Tbpn.Text) OrElse Not Regex.IsMatch(Tbpn.Text, phonenumberPattern) OrElse
        String.IsNullOrWhiteSpace(Tbemail.Text) OrElse Not Regex.IsMatch(Tbemail.Text, emailPattern) OrElse
        String.IsNullOrWhiteSpace(Tbun.Text) OrElse
        String.IsNullOrWhiteSpace(Tbpassword.Text) Then
                ' Display a message box if any of the fields is empty or if any field has an invalid format
                MsgBox("Please fill up all fields.", MsgBoxStyle.Exclamation, "Error")
                If Not Regex.IsMatch(Tbid.Text, "^\d{2}-\d{1}-\d{1}-\d{4}$") Then
                    MsgBox("ID is invalid. Please use the format '0-0-0-0000'.", MsgBoxStyle.Exclamation, "Error")
                ElseIf Not Regex.IsMatch(Tbpn.Text, phonenumberPattern) Then
                    MsgBox("Phone number is invalid", MsgBoxStyle.Exclamation, "Error")
                ElseIf Not Regex.IsMatch(Tbemail.Text, emailPattern) Then
                    MsgBox("Email is invalid. Please enter a valid email address.", MsgBoxStyle.Exclamation, "Error")
                Else
                    MsgBox("Please fill up all fields.", MsgBoxStyle.Exclamation, "Error")
                End If
            Else
                If UserExists(Tbname.Text, Tbid.Text) Then
                    MsgBox("A user with the same name or student ID already exists.", MsgBoxStyle.Exclamation, "Error")
                Else
                    ' Continue with inserting data into the user_table
                    mycmd.Connection = myconnection.open()
                    mycmd.CommandText = "INSERT INTO user_table (Name, `Student Id`, `Year and Section`, Status, `Phone Number`, Email, Username, Password, Gender) VALUES('" & Tbname.Text & "','" & Tbid.Text & "','" & Tbyearandsection.Text & "','" & cbStatus.SelectedItem.ToString() & "','" & Tbpn.Text & "','" & Tbemail.Text & "','" & Tbun.Text & "','" & Tbpassword.Text & "', '" & cbGender.SelectedItem.ToString() & "')"

                    mycmd.ExecuteNonQuery()

                    VwGridview()
                    MsgBox("Data saved!", MsgBoxStyle.Information, "Notice")


                    Tbname.Text = ""
                    Tbid.Text = ""
                    Tbyearandsection.Text = ""
                    cbStatus.SelectedIndex = -1 ' Clear the selected item in the ComboBox
                    Tbpn.Text = ""
                    Tbpassword.Text = ""
                    Tbemail.Text = ""
                    Tbun.Text = ""
                    cbGender.SelectedIndex = -1


                End If
            End If
            myconnection.close() ' Close the connection
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try

    End Sub



    Private Sub Tbid_Enter(sender As Object, e As EventArgs) Handles Tbid.Enter
        ' Handle the Enter event for the Student ID TextBox
        ' If the TextBox contains the placeholder text, clear it
        If Tbid.Text = "eg 21-2-2-0008" Then
            Tbid.Text = ""
            Tbid.ForeColor = Color.White
        End If
    End Sub

    Private Sub Tbpn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbpn.KeyPress

        ' Check if the character associated with the keypress is NOT a numeric digit
        ' AND the keypress is NOT the Delete key
        ' AND the keypress is NOT the Backspace key
        ' AND the keypress is NOT a Space character
        ' If all conditions are met, prevent the keypress from being processed (e.Handled = True)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub

    Private Sub csPass_CheckedChanged(sender As Object, e As EventArgs) Handles csPass.CheckedChanged
        ' Handle the checkbox for showing/hiding the password
        If csPass.Checked Then
            Tbpassword.UseSystemPasswordChar = False
        Else
            Tbpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Tbname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
End Class

