Public Class frmListMembersByJoinDate
    '******************************************************************************
    'The code below handles the menu button click
    '******************************************************************************
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    '******************************************************************************
    'The code below handles the initial form load and loads the database info onto the grid
    '******************************************************************************

    Private Sub frmListMembersByJoinDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsKarate.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.DsKarate.Members)

    End Sub

    '******************************************************************************
    'The code belows handles the value changed event on the DateTimePicker.
    'It performs a check to see if the radio buttons have already been selected and updates the grid accordingly.
    '******************************************************************************
    Private Sub dtpSelectedDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectedDate.ValueChanged
        If radBeforeDate.Checked Then
            Me.MembersTableAdapter.FillBeforeDate(Me.DsKarate.Members, dtpSelectedDate.Value)
        ElseIf radOnOrAfterDate.Checked Then
            Me.MembersTableAdapter.FillOnAfterDate(Me.DsKarate.Members, dtpSelectedDate.Value)
        Else
            'Don't need to do anything if no radio button is selected
        End If
    End Sub

    '******************************************************************************
    'The code below handles the radio buttons click events to help update the grid
    '******************************************************************************
    Private Sub radBeforeDate_CheckedChanged(sender As Object, e As EventArgs) Handles radBeforeDate.CheckedChanged
        Me.MembersTableAdapter.FillBeforeDate(Me.DsKarate.Members, dtpSelectedDate.Value)
    End Sub

    Private Sub radOnOrAfterDate_CheckedChanged(sender As Object, e As EventArgs) Handles radOnOrAfterDate.CheckedChanged
        Me.MembersTableAdapter.FillOnAfterDate(Me.DsKarate.Members, dtpSelectedDate.Value)
    End Sub
End Class