Public Class frmListSpecificMemberPayments
    '******************************************************************************
    'The code below handles the menu button click
    '******************************************************************************
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    '******************************************************************************
    'The code below handles the form load and populates the database info into the listbox
    '******************************************************************************
    Private Sub frmListSpecificMemberPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MembersTableAdapter.Fill(Me.DsKarate.Members)
    End Sub

    '******************************************************************************
    'The code below handles the index change for the list box and updates the grid accordingly
    '******************************************************************************
    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged
        Dim strMemberName = (Me.lstMembers.GetItemText(lstMembers.SelectedItem))
        Me.PaymentsTableAdapter.ByName(Me.DsKarate.Payments, strMemberName)
    End Sub
End Class