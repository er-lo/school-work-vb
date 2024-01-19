Public Class frmAddPlayer
    '***************************************************************************************
    'Add Player Button Click
    'handles the event of the menu button click.
    '***************************************************************************************
    Private Sub mnuAddPlayer_Click(sender As Object, e As EventArgs) Handles mnuAddPlayer.Click
        If Not txtEnterPlayerName.Text = String.Empty Then
            If Not IsNumeric(txtEnterPlayerName.Text) Then
                g_strPlayerNames(g_intPlayerNameArrayIndex) = txtEnterPlayerName.Text
                g_intPlayerNameArrayIndex += 1
                Me.Close()
            Else
                MessageBox.Show("Enter a name and not a number.")
            End If
        Else
            MessageBox.Show("Ensure that the textfield isn't empty.")
        End If
    End Sub
End Class