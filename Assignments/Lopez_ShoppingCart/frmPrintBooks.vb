Public Class frmPrintBooks
    '**************************************************************************************
    'Handle Add Print Book Button Click
    'Handles the button click for the add print book button.
    '**************************************************************************************
    Private Sub btnAddPrintBookToCart_Click(sender As Object, e As EventArgs) Handles btnAddPrintBookToCart.Click
        If lstSelectablePrintBooks.SelectedIndex <> -1 Then
            GetSelectedBook(lstSelectablePrintBooks.SelectedItem.ToString())
            g_intNumberOfBooks += 1
        Else
            MessageBox.Show("No book was selected.")
        End If
    End Sub
    '**************************************************************************************
    'End: Handle Add Print Book Button Click
    '**************************************************************************************

    '**************************************************************************************
    'Handle Form Close Button
    'Handles the button click for the form close button
    '**************************************************************************************
    Private Sub btnClosePrintBookForm_Click(sender As Object, e As EventArgs) Handles btnClosePrintBookForm.Click
        Me.Close()
    End Sub
    '**************************************************************************************
    'End: Handle Form Close Button
    '**************************************************************************************

End Class