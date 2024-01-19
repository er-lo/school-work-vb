Public Class frmSoccerScoreMain

    '***************************************************************************************
    'Menu Strip Code
    'Below is the code the handles all the menu strip actions
    '***************************************************************************************
    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        'Clears all the fields on the main form and also empties arrays and the array index
        lstPlayers.Items.Clear()
        EmptyArrays()
        lblDisplaySelectedPlayerName.Text = String.Empty
        lblDisplaySelectedPlayerGoals.Text = String.Empty
        lblDisplayTeamGoals.Text = String.Empty
        lblDisplayTeamAverage.Text = String.Empty
        g_intPlayerNameArrayIndex = 0
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Handles the program exit
        Me.Close()
    End Sub

    Private Sub mnuAddPlayer_Click(sender As Object, e As EventArgs) Handles mnuAddPlayer.Click
        'Handles the opening of the add player form. Does an initial check to make sure the max array size hasn't been reached
        If lstPlayers.Items.Count <= g_intMaxNumberOfPlayers - 1 Then
            Dim frmAddPlayer As New frmAddPlayer
            frmAddPlayer.ShowDialog()
        Else
            MessageBox.Show("Max number of players already entered.")
        End If
    End Sub

    Private Sub mnuAddGoals_Click(sender As Object, e As EventArgs) Handles mnuAddGoals.Click
        'Handles the opening of the add goals form. Does an initial check to make sure a player is selected and then if that player has already had goals set then doesn't allow them to be changed.
        If lstPlayers.SelectedIndex <> -1 Then
            If g_intPlayerGoals(lstPlayers.SelectedIndex) > 0 Then
                MessageBox.Show("Goals already set for this player.")
            Else
                g_intPlayerGoalSelectedIndex = lstPlayers.SelectedIndex
                Dim frmAddGoal As New frmAddGoals
                frmAddGoal.ShowDialog()
            End If
        Else
            MessageBox.Show("Make sure you select a player to add their goals.")
        End If
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        'Handles the opening of the about box.
        Dim frmAbout As New AboutBoxSoccerScore
        frmAbout.ShowDialog()
    End Sub
    '***************************************************************************************
    'End: Menu Strip Code
    '***************************************************************************************

    '***************************************************************************************
    'List Selected Index Changed
    'Updates the selected player and displays that players name and their goals on the main form when the selected index is changed.
    '***************************************************************************************
    Private Sub lstPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPlayers.SelectedIndexChanged
        g_strCurrentlySelectedPlayer = g_strPlayerNames(lstPlayers.SelectedIndex)
        lblDisplaySelectedPlayerName.Text = g_strPlayerNames(lstPlayers.SelectedIndex)
        lblDisplaySelectedPlayerGoals.Text = g_intPlayerGoals(lstPlayers.SelectedIndex).ToString()
    End Sub
    '***************************************************************************************
    'End: Selected Index Changed
    '***************************************************************************************

    '***************************************************************************************
    'Form Activation Updates
    'Updates the List box and the teams goal information when the form is activated.
    '***************************************************************************************
    Private Sub frmSoccerScoreMain_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdateListBox()
        UpdateTeamGoals()
    End Sub
    '***************************************************************************************
    'End: Form Activation
    '***************************************************************************************

    '***************************************************************************************
    'Update List Box
    'Updates the listbox to include the names of the players grabbed from the array
    '***************************************************************************************
    Sub UpdateListBox()
        lstPlayers.Items.Clear()
        lblDisplaySelectedPlayerName.Text = String.Empty
        lblDisplaySelectedPlayerGoals.Text = String.Empty
        If g_intPlayerNameArrayIndex <> 0 Then
            For index = 0 To g_intPlayerNameArrayIndex - 1
                lstPlayers.Items.Add(g_strPlayerNames(index))
            Next
        End If
    End Sub
    '***************************************************************************************
    'End: List Box
    '***************************************************************************************

    '***************************************************************************************
    'Update Team Info
    'Updates the teams info in the group box
    '***************************************************************************************
    Sub UpdateTeamGoals()
        Dim intTotal As Integer = 0
        Dim dblAverage As Double

        For index = 0 To (g_intPlayerGoals.Length - 1)
            intTotal += g_intPlayerGoals(index)
        Next

        dblAverage = intTotal / g_intPlayerGoals.Length

        lblDisplayTeamGoals.Text = intTotal.ToString()
        lblDisplayTeamAverage.Text = dblAverage.ToString()
    End Sub
    '***************************************************************************************
    'End: Update Team Info
    '***************************************************************************************
End Class