Imports System.IO

Public Class frmAddInventory
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
    'Add Inventory Button
    'Performs the addition of an inventory item using the data entered into the fields on the form.
    '*************************************************************************************************************************
    Private Sub btnAddInventoryItem_Click(sender As Object, e As EventArgs) Handles btnAddInventoryItem.Click
        Dim objInventoryItem As New InventoryItem
        Dim decCheck As Decimal
        Dim intCheck As Integer
        If txtInventoryNumber.Text = String.Empty Or txtDescription.Text = String.Empty Or txtCost.Text = String.Empty Or txtRetail.Text = String.Empty Or txtItemsOnHand.Text = String.Empty Then
            MessageBox.Show("Please ensure all fields are entered.")
        ElseIf Not Decimal.TryParse(txtCost.Text, decCheck) Then
            MessageBox.Show("Please enter a number for the item cost.")
        ElseIf Not Decimal.TryParse(txtRetail.Text, decCheck) Then
            MessageBox.Show("Please enter a number for the item retail price.")
        ElseIf Not Integer.TryParse(txtItemsOnHand.Text, intCheck) Then
            MessageBox.Show("Please enter a number for the number of items on hand.")
        Else
            Try
                GetData(objInventoryItem)
                SaveInventoryItem(objInventoryItem)
                ClearFields()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    '*************************************************************************************************************************
    'end add inventory button
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Save Inventory Item
    'Performs a save of the inventory item entered. Item gets saved to the file and also to the collection of inventory items.
    '*************************************************************************************************************************
    Private Sub SaveInventoryItem(ByVal objInventoryItem As InventoryItem)
        Dim fileWriter As StreamWriter
        Dim fileWriteString As String
        Try
            fileWriter = File.AppendText("inventory.txt")
            fileWriteString = objInventoryItem.InventoryNumber + "," + objInventoryItem.Description + "," + objInventoryItem.Cost.ToString() + "," + objInventoryItem.Retail.ToString() + "," + objInventoryItem.OnHand.ToString()
            colItems.Add(objInventoryItem, objInventoryItem.InventoryNumber)
            MessageBox.Show("Item was added to inventory.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        fileWriter.Close()
    End Sub
    '*************************************************************************************************************************
    'end save inventory
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Get Data
    'Saves the form fields into the inventory item object
    '*************************************************************************************************************************
    Private Sub GetData(ByVal objInventoryItem As InventoryItem)
        Try
            objInventoryItem.InventoryNumber = txtInventoryNumber.Text
            objInventoryItem.Description = txtDescription.Text
            objInventoryItem.Cost = CDec(txtCost.Text)
            objInventoryItem.Retail = CDec(txtRetail.Text)
            objInventoryItem.OnHand = CInt(txtItemsOnHand.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '*************************************************************************************************************************
    'end get data
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Clear Fields
    'Clears the fields on the form.
    '*************************************************************************************************************************
    Private Sub ClearFields()
        txtInventoryNumber.Clear()
        txtDescription.Clear()
        txtCost.Clear()
        txtRetail.Clear()
        txtItemsOnHand.Clear()
    End Sub
    '*************************************************************************************************************************
    'end clear fields
    '*************************************************************************************************************************
End Class