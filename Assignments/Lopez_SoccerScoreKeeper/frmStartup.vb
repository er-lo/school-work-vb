Public Class frmStartup
    Private Sub btnSubmitNumberOfPlayers_Click(sender As Object, e As EventArgs) Handles btnSubmitNumberOfPlayers.Click
        If txtNumberOfPlayers.Text <> String.Empty Then
            If IsNumeric(txtNumberOfPlayers.Text) Then
                If CInt(txtNumberOfPlayers.Text) > 0 Then
                    g_intMaxNumberOfPlayers = CInt(txtNumberOfPlayers.Text)
                    AssignArraySize()
                    Dim frmSoccerMain As New frmSoccerScoreMain
                    frmSoccerMain.ShowDialog()
                    Me.Close()
                Else
                    MessageBox.Show("Please enter a value of 1 or greater.")
                End If
            Else
                MessageBox.Show("Please enter a number.")
            End If
        Else
            MessageBox.Show("Please enter a number.")
        End If
    End Sub
End Class
