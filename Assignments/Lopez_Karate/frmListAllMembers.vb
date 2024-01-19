Public Class frmListAllMembers
    '******************************************************************************
    'The code belows handles the menu button click and also the initial form load.
    '******************************************************************************
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub frmListAllMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This handles the initial form load and loads the database data into the grid
        Me.MembersTableAdapter.Fill(Me.DsKarate.Members)
    End Sub
End Class