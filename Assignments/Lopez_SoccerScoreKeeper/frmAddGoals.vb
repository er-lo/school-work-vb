Public Class frmAddGoals
    '***************************************************************************************
    'Add Goal Button Click
    'handles the event of the menu button click.
    '*************************************************************************************** 
    Private Sub AddGoalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGoalsToolStripMenuItem.Click
        If Not txtEnterNumberOfGoals.Text = String.Empty Then
            If IsNumeric(txtEnterNumberOfGoals.Text) Then
                g_intPlayerGoals(g_intPlayerGoalSelectedIndex) = CInt(txtEnterNumberOfGoals.Text)
                Me.Close()
            Else
                MessageBox.Show("Enter a number and not a name.")
            End If
        Else
            MessageBox.Show("Ensure that the textfield isn't empty.")
        End If
    End Sub
    '***************************************************************************************
    'End: Add Goal Button Click
    '***************************************************************************************

    '***************************************************************************************
    'Handle Form Load
    'handles the form load to display selected player
    '***************************************************************************************
    Private Sub frmAddGoals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplaySelectedPlayer.Text = g_strCurrentlySelectedPlayer
    End Sub
    '***************************************************************************************
    'End: Handle Form Load
    '***************************************************************************************
End Class