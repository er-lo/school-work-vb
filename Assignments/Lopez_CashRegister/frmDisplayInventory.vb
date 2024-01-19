Public Class frmDisplayInventory
    '*************************************************************************************************************************
    'Menu Exit Code
    '*************************************************************************************************************************
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
    '*************************************************************************************************************************
    'end menu exit code.
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Initial Form Load
    'When form is loaded, the listbox is populated with the inventory numbers of the items inside the collection.
    '*************************************************************************************************************************
    Private Sub frmDisplayInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PerformListBoxLoad()
    End Sub
    '*************************************************************************************************************************
    'end initial form load.
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Select Index Change on Listbox
    'When the selected item is changed inside the listbox, the fields on the form are populated with the selected inventory
    'item information.
    '*************************************************************************************************************************
    Private Sub lstDisplayInventoryNumbers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisplayInventoryNumbers.SelectedIndexChanged
        Dim objInventoryItem As InventoryItem
        Try
            objInventoryItem = CType(colItems.Item(lstDisplayInventoryNumbers.SelectedItem), InventoryItem)
            FillFields(objInventoryItem)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '*************************************************************************************************************************
    'end select index change
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Search Button
    'Performs the search on the collection of items and populates the fields on the form with the searched inventory
    'item information.
    '*************************************************************************************************************************
    Private Sub btnSearchInventory_Click(sender As Object, e As EventArgs) Handles btnSearchInventory.Click
        Dim objInventoryItem As InventoryItem
        Try
            objInventoryItem = CType(colItems.Item(txtSearchInventory.Text), InventoryItem)
            FillFields(objInventoryItem)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '*************************************************************************************************************************
    'end search button
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Purchase Button
    'When the purchase button is clicked, the purchase is simulated. The number of items on hand updates and
    'sales tax and sale total is calculated. Fields are also updated. If number of items falls to zero then it 
    'is removed from the listbox.
    '*************************************************************************************************************************
    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim objInventoryItem As InventoryItem
        Dim intCheck As Integer
        If Not Integer.TryParse(txtNumberToPurchase.Text, intCheck) Then
            MessageBox.Show("Please enter a number for the number to purchase.")
        ElseIf txtNumberToPurchase.Text = String.Empty Then
            MessageBox.Show("Please enter a number for the number to purchase.")
        Else
            Try
                objInventoryItem = CType(colItems.Item(lblDisplayInventoryNumber.Text), InventoryItem)
                UpdateItemsOnHand(objInventoryItem, CInt(txtNumberToPurchase.Text))
                PerformListBoxLoad()
                FillFields(objInventoryItem)
                FillSalesInformation(objInventoryItem.Retail, CInt(txtNumberToPurchase.Text))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    '*************************************************************************************************************************
    'end purchase button
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Update Items on hand
    'Handles the update on the number of items on hand. Does a check to make sure value doesn't go below zero then
    'subtracts the number of items "purchased".
    '*************************************************************************************************************************
    Private Sub UpdateItemsOnHand(ByVal objInventoryItem As InventoryItem, ByVal purchasedAmount As Integer)
        If purchasedAmount > objInventoryItem.OnHand Then
            MessageBox.Show("Can't perform this action. Amount to purchase can't be greater than the amount on hand.")
        Else
            Try
                objInventoryItem.OnHand -= purchasedAmount
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    '*************************************************************************************************************************
    'end update items on hand
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Calculations
    'Functions to handle the calculations. Both sales tax and sales total are calculated.
    '*************************************************************************************************************************
    Private Function CalculateSalesTax(ByVal decSubTotal As Decimal) As Decimal
        Return decSubTotal * decTAX_RATE
    End Function

    Private Function CalculateSalesTotal(ByVal decSubTotal As Decimal, ByVal decSalesTax As Decimal) As Decimal
        Return decSubTotal + decSalesTax
    End Function
    '*************************************************************************************************************************
    'end calculations
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Fill fields on form
    'This fills the fields with the necessary data on the form.
    '*************************************************************************************************************************
    Private Sub FillSalesInformation(ByVal decRetailPrice As Decimal, ByVal intAmountSold As Integer)
        'fills the sales info fields
        Dim decSubTotal = decRetailPrice * CDec(intAmountSold)
        Dim decSalesTax = CalculateSalesTax(decSubTotal)
        lblDisplaySalesTax.Text = decSalesTax.ToString("c")
        lblDisplaySalesTotal.Text = CalculateSalesTotal(decSubTotal, decSalesTax).ToString("c")
    End Sub

    Private Sub FillFields(ByVal objInventoryItem As InventoryItem)
        'fills the item info fields
        lblDisplayInventoryNumber.Text = objInventoryItem.InventoryNumber
        lblDisplayItemDescription.Text = objInventoryItem.Description
        lblDisplayItemCost.Text = objInventoryItem.Cost.ToString("c")
        lblDisplayRetailPrice.Text = objInventoryItem.Retail.ToString("c")
        lblDisplayOnHandNumber.Text = objInventoryItem.OnHand.ToString()
    End Sub
    '*************************************************************************************************************************
    'end fill fields
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Listbox Load
    'This loads the information into the listbox. Since this forms simulates purchases the list box potentially needs to
    'update when an item goes out of stock.
    '*************************************************************************************************************************
    Private Sub PerformListBoxLoad()
        Dim objInventoryItem As InventoryItem
        lstDisplayInventoryNumbers.Items.Clear()
        Try
            For Each objInventoryItem In colItems
                If objInventoryItem.OnHand > 0 Then
                    lstDisplayInventoryNumbers.Items.Add(objInventoryItem.InventoryNumber)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '*************************************************************************************************************************
    'end listbox load
    '*************************************************************************************************************************
End Class