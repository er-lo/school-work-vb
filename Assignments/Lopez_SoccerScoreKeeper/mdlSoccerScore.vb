Module mdlSoccerScore
    '***************************************************************************************
    'Programmer: Erick Lopez
    'Date: February 12th 2023
    'Title: Assignment 4: Soccer Team Score Keeping
    'Description: Program to help keep track of a teams goals using arrays. 
    '***************************************************************************************

    'Below are defined the global variables
    Public g_intMaxNumberOfPlayers As Integer 'Way to set initial array size
    Public g_strPlayerNames() As String 'Array for the Player's Names
    Public g_intPlayerGoals() As Integer 'Array for the Player's goals
    Public g_intPlayerNameArrayIndex As Integer = 0 'Index to keep track of position in the Player Name Array
    Public g_intPlayerGoalSelectedIndex As Integer 'variable to be able to set the index for the correct position in the array and be accessed by another form
    Public g_strCurrentlySelectedPlayer As String 'variable to save current player string to be accessed by other forms

    '***************************************************************************************
    'StartUp Object
    '***************************************************************************************
    Public Sub Main()
        Dim startForm As New frmStartup
        startForm.ShowDialog()
    End Sub
    '***************************************************************************************
    'End StartUp Object
    '***************************************************************************************

    '***************************************************************************************
    'Assign Array Size
    'Assign the initial array size
    '***************************************************************************************
    Sub AssignArraySize()
        ReDim g_strPlayerNames(g_intMaxNumberOfPlayers - 1)
        ReDim g_intPlayerGoals(g_intMaxNumberOfPlayers - 1)
    End Sub
    '***************************************************************************************
    'End: Assign Array Size
    '***************************************************************************************

    '***************************************************************************************
    'Empty Arrays
    'Resets the arrays
    '***************************************************************************************
    Sub EmptyArrays()
        g_strPlayerNames.Clear(g_strPlayerNames, 0, g_strPlayerNames.Length)
        g_intPlayerGoals.Clear(g_intPlayerGoals, 0, g_intPlayerGoals.Length)
    End Sub
    '***************************************************************************************
    'End: Empty Arrays
    '***************************************************************************************
End Module
