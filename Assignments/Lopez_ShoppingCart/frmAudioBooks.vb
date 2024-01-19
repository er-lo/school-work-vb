Public Class frmAudioBooks
    '**************************************************************************************
    'Handle Add Audio Book Button Click
    'Handles the button click for the add audio book button.
    '**************************************************************************************
    Private Sub btnAddAudioBookToCart_Click(sender As Object, e As EventArgs) Handles btnAddAudioBookToCart.Click
        If lstSelectableAudioBooks.SelectedIndex <> -1 Then
            GetSelectedBook(lstSelectableAudioBooks.SelectedItem.ToString())
            g_intNumberOfBooks += 1
        Else
            MessageBox.Show("No book was selected.")
        End If
    End Sub
    '**************************************************************************************
    'End: Handle Add Audio Book Button Click
    '**************************************************************************************

    '**************************************************************************************
    'Handle Form Close Button
    'Handles the button click for the form close button
    '**************************************************************************************
    Private Sub btnCloseAudioBookForm_Click(sender As Object, e As EventArgs) Handles btnCloseAudioBookForm.Click
        Me.Close()
    End Sub
    '**************************************************************************************
    'End: Handle Form Close Button
    '**************************************************************************************
End Class