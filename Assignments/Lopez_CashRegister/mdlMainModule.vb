Imports System.IO

Module mdlMainModule

    '*************************************************************************************************************************
    'Programmer: Erick Lopez
    'Date: March 8th 2023
    'Title: Final Assignment: Cash Register
    'Description: Cash register app that uses classes.
    '*************************************************************************************************************************

    '*************************************************************************************************************************
    'Global Variables
    '*************************************************************************************************************************
    Public colItems As New Collection
    Public Const decTAX_RATE As Decimal = 0.08D

    '*************************************************************************************************************************
    'Sub Main for Main form load.
    '*************************************************************************************************************************
    Sub Main()
        Dim frmMainForm As New frmMainForm
        frmMainForm.ShowDialog()
    End Sub

    '*************************************************************************************************************************
    'Handles the inventory file load. It reads the file until the end and splits each line into a string. That string then
    'gets separated at the commas into a string array. Each item in the string array gets assigned into a different part of 
    'the inventory class
    '*************************************************************************************************************************
    Public Sub LoadFromFile()
        Dim fileReader As StreamReader
        Try
            fileReader = File.OpenText("inventory.txt")
            Do Until fileReader.EndOfStream
                Dim strInventoryReadLine As String = fileReader.ReadLine()
                Dim strInventoryReadLineSplitIntoArrays As String() = strInventoryReadLine.Split(CChar(","))
                Dim objInventoryItem As New InventoryItem
                objInventoryItem.InventoryNumber = strInventoryReadLineSplitIntoArrays(0)
                objInventoryItem.Description = strInventoryReadLineSplitIntoArrays(1)
                objInventoryItem.Cost = CDec(strInventoryReadLineSplitIntoArrays(2))
                objInventoryItem.Retail = CDec(strInventoryReadLineSplitIntoArrays(3))
                objInventoryItem.OnHand = CInt(strInventoryReadLineSplitIntoArrays(4))
                colItems.Add(objInventoryItem, objInventoryItem.InventoryNumber)
            Loop
            fileReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
