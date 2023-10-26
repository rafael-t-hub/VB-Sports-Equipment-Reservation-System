Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class user_table
#Region "declaration"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim dadapter As MySqlDataAdapter
    Dim dtable As New DataTable

#End Region
#Region "ForGridview"
    Sub VwGridview()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "select * from user_table order by NO asc"
        dadapter = New MySqlDataAdapter(mycmd)
        dtable.Rows.Clear()
        dadapter.Fill(dtable)
        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
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
            DGV1.Columns(8).DataPropertyName = "NO"
        End If
        DGV1.ClearSelection() ' Clear the selection after data is loaded
        myconnection.close()
    End Sub

    Sub clickGridView()
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
                    Tbstatus.Text = .Rows(i).Cells(3).Value.ToString
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

#Region "ForChekingValueInput"

    Function UserExists(name As String, studentId As String) As Boolean
        ' Implement code to check if a user with the same name or student ID exists in the database
        ' You can use a SQL query or another method to perform this check
        ' If a user with the same name or student ID is found, return True; otherwise, return False
        ' Replace the following with your actual database check code
        Dim sqlCheck As String = "SELECT COUNT(*) FROM user_table WHERE Name = @Name OR `Student Id` = @StudentId"

        mycmd.Connection = myconnection.open() ' Open the connection
        mycmd.CommandText = sqlCheck
        mycmd.Parameters.AddWithValue("@Name", name)
        mycmd.Parameters.AddWithValue("@StudentId", studentId)
        Dim count As Integer = Convert.ToInt32(mycmd.ExecuteScalar())
        myconnection.close() ' Close the connection

        Return count > 0
    End Function
#End Region


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mycmd.Connection = myconnection.open()

        Dim i As Integer
        i = DGV1.CurrentRow.Index


        ' Access the "NO" column value from the underlying data source.
        Dim noValue As String = DGV1.Rows(i).Cells("NO").Value.ToString


        mycmd.CommandText = "UPDATE user_table 
                    SET Name = @Name, `Student ID` = @StudentId, 
                        `Year and Section` = @YearSection, 
                        Status = @Status, 
                        `Phone Number` = @PhoneNumber, 
                        Email = @Email, 
                        Username = @Username, 
                        Password = @Password 
                    WHERE NO = @NO"
        mycmd.Parameters.Clear()

        ' Set parameter values
        mycmd.Parameters.AddWithValue("@Name", Tbname.Text)
        mycmd.Parameters.AddWithValue("@StudentId", Tbid.Text)
        mycmd.Parameters.AddWithValue("@YearSection", Tbyearandsection.Text)
        mycmd.Parameters.AddWithValue("@Status", Tbstatus.Text)
        mycmd.Parameters.AddWithValue("@PhoneNumber", Tbpn.Text)
        mycmd.Parameters.AddWithValue("@Email", Tbemail.Text)
        mycmd.Parameters.AddWithValue("@Username", Tbun.Text)
        mycmd.Parameters.AddWithValue("@Password", Tbpassword.Text)
        mycmd.Parameters.AddWithValue("@NO", noValue)



        mycmd.ExecuteNonQuery()
        myconnection.close()
        VwGridview()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VwGridview()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mycmd.Connection = myconnection.open()
        mycmd.CommandText = "delete from user_table where `Student Id`='" & Tbid.Text & "'"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        VwGridview()
        MsgBox("Data deleted !", MsgBoxStyle.Information, "Notice")
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        clickGridView()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrWhiteSpace(Tbname.Text) OrElse
        String.IsNullOrWhiteSpace(Tbid.Text) OrElse
        String.IsNullOrWhiteSpace(Tbyearandsection.Text) OrElse
        String.IsNullOrWhiteSpace(Tbstatus.Text) OrElse
        String.IsNullOrWhiteSpace(Tbpn.Text) OrElse
        String.IsNullOrWhiteSpace(Tbemail.Text) OrElse
        String.IsNullOrWhiteSpace(Tbun.Text) OrElse
        String.IsNullOrWhiteSpace(Tbpassword.Text) Then
            ' Display a message box if any of the fields is empty
            MsgBox("Please fill up all fields.", MsgBoxStyle.Exclamation, "Error")
        Else
            If UserExists(Tbname.Text, Tbid.Text) Then
                MsgBox("A user with the same name or student ID already exists.", MsgBoxStyle.Exclamation, "Error")
            Else
                ' Continue with inserting data into the user_table
                mycmd.Connection = myconnection.open()
                mycmd.CommandText = "INSERT INTO user_table (Name, `Student Id`, `Year and Section`, Status, `Phone Number`, Email, Username, Password) VALUES('" & Tbname.Text & "','" & Tbid.Text & "','" & Tbyearandsection.Text & "','" & Tbstatus.Text & "','" & Tbpn.Text & "','" & Tbemail.Text & "','" & Tbun.Text & "','" & Tbpassword.Text & "')"
                mycmd.ExecuteNonQuery()
                myconnection.close() ' Close the connection
                VwGridview()
                MsgBox("Data saved!", MsgBoxStyle.Information, "Notice")
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class



