Public Class reservation

    Private Sub AddEquipmentItem()
        Dim Basketball_Ball As New ListViewItem()
        Dim Volleyball_Ball As New ListViewItem()
        Dim Table_Tennis_Racket As New ListViewItem()
        Dim Table_Tennis_Ball As New ListViewItem()

        ' Set the text description for the item.
        Basketball_Ball.Text = "Basketball Ball" & vbCrLf & "Equipment ID: 1"
        Volleyball_Ball.Text = "Volleyball Ball" & vbCrLf & "Equipment ID: 2"
        Table_Tennis_Racket.Text = "Table Tennis Racket" & vbCrLf & "Equipment ID: 3"
        Table_Tennis_Ball.Text = "Table Tennis Ball" & vbCrLf & "Equipment ID: 4"
        ' Set the image index to use the first image in the ImageList

        Volleyball_Ball.ImageIndex = 0
        Basketball_Ball.ImageIndex = 1
        Table_Tennis_Racket.ImageIndex = 2
        Table_Tennis_Ball.ImageIndex = 3


        ' Add the item to the ListView.
        lvEquipments.Items.Add(Basketball_Ball)
        lvEquipments.Items.Add(Volleyball_Ball)
        lvEquipments.Items.Add(Table_Tennis_Racket)
        lvEquipments.Items.Add(Table_Tennis_Ball)

        ' Set the font to a 12-point Arial font (adjust as needed).

        lvEquipments.Font = New Font("Poppins", 12)
    End Sub

    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#Region "Date and Time of Equipment Availability"
        DateTimePicker1.CustomFormat = "MMMM dd, yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        pnl_manage_reservation.Select()
#End Region
        AddEquipmentItem()

    End Sub

    Private Sub lvEquipments_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles lvEquipments.DrawItem
        Dim item As ListViewItem = e.Item

        If e.State = ListViewItemStates.Selected Or e.State = ListViewItemStates.Hot Then
            e.Graphics.FillRectangle(Brushes.White, e.Bounds) ' Change the background color to white
            e.Graphics.DrawString(item.Text, lvEquipments.Font, Brushes.Black, e.Bounds) ' Change the text color to black
        Else
            e.DrawBackground()
        End If

        e.DrawText()
    End Sub
End Class