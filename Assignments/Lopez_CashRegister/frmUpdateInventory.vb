Public Class frmUpdateInventory
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
    Private Sub frmUpdateInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objInventoryItem As InventoryItem
        Try
            For Each objInventoryItem In colItems
                lstDisplayInventoryNumbers.Items.Add(objInventoryItem.InventoryNumber)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
    'Update Button
    'When the update button is clicked, the data for collection item is updated with the information grabbed from the fields.
    '*************************************************************************************************************************
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim objInventoryItem As InventoryItem
        Try
            objInventoryItem = CType(colItems.Item(lblDisplayInventoryNumber.Text), InventoryItem)
            UpdateData(objInventoryItem)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '*************************************************************************************************************************
    'end update button
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Update data
    'the collection items data is updated
    '*************************************************************************************************************************
    Private Sub UpdateData(ByVal objInventoryItem As InventoryItem)
        Try
            objInventoryItem.Description = txtItemDescription.Text
            objInventoryItem.Cost = CDec(txtItemCost.Text)
            objInventoryItem.Retail = CDec(txtItemRetailPrice.Text)
            objInventoryItem.OnHand = CInt(txtItemsOnHand.Text)
            MessageBox.Show("Inventory item was updated.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '*************************************************************************************************************************
    'end update data
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Fill Fields
    'filles the fields on the form with the collection items data
    '*************************************************************************************************************************
    Private Sub FillFields(ByVal objInventoryItem As InventoryItem)
        Try
            lblDisplayInventoryNumber.Text = objInventoryItem.InventoryNumber
            txtItemDescription.Text = objInventoryItem.Description
            txtItemCost.Text = objInventoryItem.Cost.ToString()
            txtItemRetailPrice.Text = objInventoryItem.Retail.ToString()
            txtItemsOnHand.Text = objInventoryItem.OnHand.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '*************************************************************************************************************************
    'end fill fields
    '*************************************************************************************************************************
End Class