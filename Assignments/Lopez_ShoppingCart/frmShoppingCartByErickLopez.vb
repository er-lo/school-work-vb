Public Class frmShoppingCartByErickLopez

    '***********************************************************************************************
    'Menu Strip Code
    'Below is all the code that handles the menu strip actions.
    '***********************************************************************************************
    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        'Resets the fields in the form by clearing the list and clearing the display labels calling ClearDisplayLabels() and also resets the variables in the module by calling ResetCharges()
        lstProductsSelected.Items.Clear()
        ClearDisplayLabels()
        ResetCharges()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Handles the program exit
        Me.Close()
    End Sub

    Private Sub mnuProductsPrintBooks_Click(sender As Object, e As EventArgs) Handles mnuProductsPrintBooks.Click, ctxMenuPrintBooks.Click
        'Handles the Print Books form opening. Also handles the context menu button
        Dim frmPrintBooks As New frmPrintBooks
        frmPrintBooks.ShowDialog()
    End Sub

    Private Sub mnuProductsAudioBooks_Click(sender As Object, e As EventArgs) Handles mnuProductsAudioBooks.Click, ctxMenuAudioBooks.Click
        'Handles the Audio Books form opening. Also handles the context menu button
        Dim frmAudioBooks As New frmAudioBooks
        frmAudioBooks.ShowDialog()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        'Handles the about box opening. 
        MessageBox.Show("Shopping Cart Program by Erick Lopez")
    End Sub
    '***********************************************************************************************
    'End: Menu Strip code
    '***********************************************************************************************

    '***********************************************************************************************
    'Handle Remove Button
    'Code to handle the remove button on click
    '***********************************************************************************************
    Private Sub btnRemoveSelectedProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveSelectedProduct.Click
        If lstProductsSelected.Items.Count <= 0 Then
            MessageBox.Show("There is nothing to remove.")
            g_strSelectedBookName = String.Empty
            g_decSelectedBookCost = 0D
        Else
            Dim decSelectedBookCost As Decimal = GetSelectedBook(lstProductsSelected.SelectedItem.ToString())
            lstProductsSelected.Items.Remove(lstProductsSelected.SelectedItem)
            g_intNumberOfBooks -= 1
            g_decSubtotal -= decSelectedBookCost
            UpdateCharges()
        End If
    End Sub
    '***********************************************************************************************
    'End: Handle Remove Button
    '***********************************************************************************************

    '***********************************************************************************************
    'Handle Form Activation
    'Handles any changes to form upon activation.
    '***********************************************************************************************
    Private Sub frmShoppingCartByErickLopez_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CalcSubtotal()
        UpdateSelectedList()
        UpdateCharges()
    End Sub
    '***********************************************************************************************
    'End: Handle Form Activation
    '***********************************************************************************************

    '***********************************************************************************************
    'Clear Display Labels
    'I made this to make my life easier since I was clearing the labels in two locations on this file. All is does is clear the display labels on the form.
    '***********************************************************************************************
    Sub ClearDisplayLabels()
        lblDisplaySubtotal.Text = String.Empty
        lblDisplayTax.Text = String.Empty
        lblDisplayShipping.Text = String.Empty
        lblDisplayTotal.Text = String.Empty
    End Sub
    '***********************************************************************************************
    'End: Clear Display Labels
    '***********************************************************************************************

    '***********************************************************************************************
    'Update Selected List
    'Updates the lstProducts Selected with the newest added book
    '***********************************************************************************************
    Sub UpdateSelectedList()
        If Not g_strSelectedBookName = String.Empty Then
            lstProductsSelected.Items.Add(g_strSelectedBookName)
        End If
    End Sub
    '***********************************************************************************************
    'End: Update Selected List
    '***********************************************************************************************

    '***********************************************************************************************
    'Update Charges
    'This handles any charges updates.
    '***********************************************************************************************
    Sub UpdateCharges()
        If lstProductsSelected.Items.Count > 0 Then
            lblDisplaySubtotal.Text = g_decSubtotal.ToString("c")
            lblDisplayTax.Text = CalcTax.ToString("c")
            lblDisplayShipping.Text = CalcShipping.ToString("c")
            lblDisplayTotal.Text = CalcTotalCost.ToString("c")
        ElseIf lstProductsSelected.Items.Count <= 0 Then
            ClearDisplayLabels()
        End If
    End Sub
    '***********************************************************************************************
    'End: Update Charges
    '***********************************************************************************************
End Class
