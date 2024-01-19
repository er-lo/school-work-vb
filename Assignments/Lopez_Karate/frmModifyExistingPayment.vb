Public Class frmModifyExistingPayment
    '******************************************************************************
    'The code below handles the menu button click
    '******************************************************************************
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    '******************************************************************************
    'The code below handles the initial form load and populates the grid
    '******************************************************************************
    Private Sub frmModifyExistingPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsKarate.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.DsKarate.Payments)
    End Sub
End Class