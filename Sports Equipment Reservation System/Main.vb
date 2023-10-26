Public Class Main
    ' Main form class definition.

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegisterNav.Click
        ' Handle the button click event (presumably, this button is for user registration).
        ' Display the "manage_user" form inside the "pnlMain" panel.

        ' Create an instance of the "manage_user" form.
        With manage_user
            ' Set the TopLevel property of the "manage_user" form to False to allow it to be embedded in another form.
            .TopLevel = False

            ' Add the "manage_user" form to the "pnlMain" panel.
            pnlMain.Controls.Add(manage_user)

            ' Bring the "manage_user" form to the front so it becomes visible.
            .BringToFront()

            ' Show the "manage_user" form.
            .Show()
        End With
    End Sub
End Class
