Public Class Reservations
    Private Sub Reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddNewReservation_Click(sender As Object, e As EventArgs) Handles btnAddNewReservation.Click
        ' Create a new instance of the reservation form
        Dim addForm As New FormAddNewReservation()
        addForm.StartPosition = FormStartPosition.CenterParent

        ' Show the form modally
        If addForm.ShowDialog() = DialogResult.OK Then
            ' Retrieve the reservation data stored in the form's Tag
            Dim data = DirectCast(addForm.Tag, Object)

            ' Add a new row to the DataGridView
            DataReservations.Rows.Add(
                data.FullName,
                data.Email,
                data.Phone,
                data.Guests,
                data.EventType,
                data.DateValue,
                data.TimeValue,
                data.Notes
            )
        End If
    End Sub


End Class
