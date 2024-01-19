Public Class frmListAllPayments
    '******************************************************************************
    ' The code belows handles the menu button click action and also the initial form load
    '******************************************************************************
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub frmListAllPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Code to load the database info into the grid
        Me.PaymentsTableAdapter.Fill(Me.DsKarate1.Payments)
    End Sub

End Class