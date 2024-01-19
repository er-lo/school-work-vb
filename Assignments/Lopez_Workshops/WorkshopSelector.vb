Public Class frmWorkshopSelector
    '************************************************************************************
    'Programmer: Erick Lopez
    'Date: January 29th 2023
    'Title: Assignment 2: Workshop Selector
    'Description: Workshop price is calculated after a list of workshops and locations are selected.
    '************************************************************************************


    '************************************************************************************
    'Handle the Add Workshop Button Click action
    'Assigns necessary fees to variables dependent on workshop and location selected.
    '************************************************************************************
    Private Sub btnAddWorkshop_Click(sender As Object, e As EventArgs) Handles btnAddWorkshop.Click
        'This block of code handles the add worskhop action. Calculates initial cost then adds it to the list of costs
        'Need to define all variables first
        Dim decWorkshopRegistrationFee As Decimal 'Workshop Registration Fee
        Dim decNumberOfDays As Decimal 'Number of Days for the workshop
        Dim decLodgingFee As Decimal 'Lodging Fee for location
        Dim decCalculatedLodgingFees As Decimal 'Total cost for lodging fees after multiplication
        Dim decTotalFeeCost As Decimal 'Total Fee to be added to list of costs
        Dim strSelectedWorkshop As String 'Selected workshop string for select case
        Dim strSelectedLocation As String 'Selected location string for select case

        'If statements to check for selections in the workshop and location listboxes
        If lstWorkshopList.SelectedIndex <> -1 Then
            If lstLocationList.SelectedIndex <> -1 Then
                strSelectedWorkshop = lstWorkshopList.SelectedItem.ToString()
                strSelectedLocation = lstLocationList.SelectedItem.ToString()

                'Select case to handle workshop selection
                Select Case strSelectedWorkshop
                    Case "Handling Stress"
                        decWorkshopRegistrationFee = 595
                        decNumberOfDays = 3
                    Case "Time Management"
                        decWorkshopRegistrationFee = 695
                        decNumberOfDays = 3
                    Case "Supervision Skills"
                        decWorkshopRegistrationFee = 995
                        decNumberOfDays = 3
                    Case "Negotiation"
                        decWorkshopRegistrationFee = 1295
                        decNumberOfDays = 5
                    Case "How to Interview"
                        decWorkshopRegistrationFee = 395
                        decNumberOfDays = 1
                End Select

                'Select case to handle location selection
                Select Case strSelectedLocation
                    Case "Austin"
                        decLodgingFee = 95
                    Case "Chicago"
                        decLodgingFee = 125
                    Case "Dallas"
                        decLodgingFee = 110
                    Case "Orlando"
                        decLodgingFee = 100
                    Case "Phoenix"
                        decLodgingFee = 92
                    Case "Raleigh"
                        decLodgingFee = 90
                End Select

                'calculations for workshop + location fees
                decCalculatedLodgingFees = decNumberOfDays * decLodgingFee
                decTotalFeeCost = decCalculatedLodgingFees + decWorkshopRegistrationFee

                'Add cost to list of costs
                lstCostsList.Items.Add(decTotalFeeCost)

                'Once an item is added to lists of costs we enable the Calculate Button which was previously disabled
                If lstCostsList.Items.Count > 0 Then
                    btnCalculateTotal.Enabled = True
                Else
                End If

            Else
                MessageBox.Show("A Workshop was selected, but no location was selected. A workshop AND a location must be selected.")

            End If
        Else
            MessageBox.Show("A Workshop AND a location must be selected.")

        End If

    End Sub
    '************************************************************************************
    'End: Handle Add Workshop
    '************************************************************************************

    '************************************************************************************
    'Handle Calculate Total Button
    'Performs the calculation of all the items in the list of costs list.
    '************************************************************************************
    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim intCount As Integer 'intCount used for For Next Loop
        Dim decFinalTotal As Decimal = 0 'Final Total variable for sum of all list items

        'Check to see if the list is empty (shouldn't be since button should be disabled)
        If lstCostsList.Items.Count > 0 Then
            'For loop to handle the sum of list
            For intCount = 0 To lstCostsList.Items.Count - 1
                decFinalTotal += CDec(lstCostsList.Items(intCount))
            Next
        Else
            MessageBox.Show("List of Costs empty. Nothing to calculate.")
        End If

        'Display the final cost after everything is added.
        lblDisplayTotalCost.Text = decFinalTotal.ToString("c")

    End Sub
    '************************************************************************************
    'End: Handle Calculate Total Button
    '************************************************************************************

    '************************************************************************************
    'Handle Reset Button
    'Resets all fields on the form.
    '************************************************************************************
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'This block of code handles the reset for the list boxes
        lstWorkshopList.SelectedIndex = -1
        lstLocationList.SelectedIndex = -1
        lstCostsList.SelectedIndex = -1
        lblDisplayTotalCost.Text = String.Empty
        lstCostsList.Items.Clear()
        btnCalculateTotal.Enabled = False
    End Sub
    '************************************************************************************
    'End: Handle Add Workshop
    '************************************************************************************

    '************************************************************************************
    'Handle Exit Button
    'Handles Program Exit
    '************************************************************************************
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This block of code handles the program exit
        Me.Close()
    End Sub
    '************************************************************************************
    'End: Handle Exit Button
    '************************************************************************************
End Class
