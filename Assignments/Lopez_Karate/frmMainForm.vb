Public Class frmMainForm
    '************************************************************************************
    'Programmer: Erick Lopez
    'Date: February 19th 2023
    'Title: Assignment 5: Karate 
    'Description: Program to access the karate database
    '************************************************************************************

    '************************************************************************************
    'The code belows handles all the menu strip menu options.
    '************************************************************************************
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Closes the form
        Me.Close()
    End Sub

    Private Sub AllMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuMembersAllMembers.Click
        'open all members form
        Dim frmAllMembers As New frmListAllMembers
        frmAllMembers.ShowDialog()
    End Sub

    Private Sub MembersByJoinDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuMembersJoinDateMembers.Click
        'open members by join date form
        Dim frmMembersByJoinDate As New frmListMembersByJoinDate
        frmMembersByJoinDate.ShowDialog()
    End Sub

    Private Sub AllPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPaymentsAllPayments.Click
        'open all payments form
        Dim frmAllPayments As New frmListAllPayments
        frmAllPayments.ShowDialog()
    End Sub

    Private Sub ModifyExistingPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPaymentsModifyPayment.Click
        'open modify payment form
        Dim frmModifyPayment As New frmModifyExistingPayment
        frmModifyPayment.ShowDialog()
    End Sub

    Private Sub PaymentBySpecificMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPaymentsSpecificMemberPayments.Click
        'open specific member payment form
        Dim frmSpecificMemberPayments As New frmListSpecificMemberPayments
        frmSpecificMemberPayments.ShowDialog()
    End Sub
End Class
