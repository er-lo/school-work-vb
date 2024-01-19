Imports System.IO

Public Class frmMainForm
    '*************************************************************************************************************************
    'Menu Strip and Form Buttons Click event handlers
    '*************************************************************************************************************************
    Private Sub mnuInventoryAdd_Click(sender As Object, e As EventArgs) Handles mnuInventoryAdd.Click, btnAddInventory.Click
        'handles menu button and form button to open the add inventory form.
        Dim frmAddInventory As New frmAddInventory
        frmAddInventory.ShowDialog()
    End Sub

    Private Sub mnuInventoryUpdate_Click(sender As Object, e As EventArgs) Handles mnuInventoryUpdate.Click, btnUpdateInventory.Click
        'handles menu button and form button to open the update inventory form.
        Dim frmUpdateInventory As New frmUpdateInventory
        frmUpdateInventory.ShowDialog()
    End Sub

    Private Sub mnuInventoryDisplay_Click(sender As Object, e As EventArgs) Handles mnuInventoryDisplay.Click, btnDisplayInventory.Click
        'handles menu button and form button to open the display inventory form.
        Dim frmDisplayInventory As New frmDisplayInventory
        frmDisplayInventory.ShowDialog()
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click, MyBase.FormClosing
        'handles the file save menu button and the form closing event. 
        'This code just saves the most up to date collection into the form.
        Try
            ClearOldInventoryItems()
            SaveMostRecentInventoryItems()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MessageBox.Show("All Items have been saved.")
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Exit the Program
        Me.Close()
    End Sub
    '*************************************************************************************************************************
    'end menu and form button code
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Initial form load.
    '*************************************************************************************************************************
    Private Sub frmMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calls the load form sub from the main module.
        LoadFromFile()
    End Sub
    '*************************************************************************************************************************
    'end initial form load.
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Clear Old Inventory Items
    'This clears the file in order to have the up to date collection saved
    '*************************************************************************************************************************
    Private Sub ClearOldInventoryItems()
        Try
            Dim fileWriter As New StreamWriter("inventory.txt")
            fileWriter.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '*************************************************************************************************************************
    'Save Most Recent collection to the file
    'This code saves the up to date collection to the file.
    '*************************************************************************************************************************
    Private Sub SaveMostRecentInventoryItems()
        Dim fileWriter As StreamWriter
        Dim objInventoryItem As InventoryItem
        Dim fileWriteString As String
        Try
            fileWriter = File.AppendText("inventory.txt")
            For Each objInventoryItem In colItems
                fileWriteString = objInventoryItem.InventoryNumber + "," + objInventoryItem.Description + "," + objInventoryItem.Cost.ToString() + "," + objInventoryItem.Retail.ToString() + "," + objInventoryItem.OnHand.ToString()
                fileWriter.WriteLine(fileWriteString)
            Next
            fileWriter.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
