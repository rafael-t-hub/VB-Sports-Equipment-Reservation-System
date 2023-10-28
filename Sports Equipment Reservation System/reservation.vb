Public Class reservation
    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = "MMMM dd, yyyy hh:mm tt"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        pnl_manage_reservation.Select()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub pnlReservation_Paint(sender As Object, e As PaintEventArgs) Handles pnlReservation.Paint

    End Sub

    Private Sub pnlReservation_Resize(sender As Object, e As EventArgs) Handles pnlReservation.Resize
        pnlReservation.AutoScrollPosition = New Point(0, 0)

    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class