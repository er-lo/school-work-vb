Module mdlShoppingCartModule
    '************************************************************************************
    'Programmer: Erick Lopez
    'Date: February 5th 2023
    'Title: Assignment 3: Shopping Cart
    'Description: Shopping cart for a book store
    '************************************************************************************

    'Below are all the global variables used
    Public Const g_decSALES_TAX As Decimal = 0.06D 'Sales tax constant
    Public Const g_decSHIPPING_CHARGE As Decimal = 2D 'Shipping charge, to be multiplied against number of books being purchased
    Public Const g_decI_DID_IT_YOUR_WAY_PRICE As Decimal = 11.95D 'Price for I did it your way (print only)
    Public Const g_decTHE_HISTORY_OF_SCOTLAND_PRICE As Decimal = 14.5D 'Price for The history of scotland (print and audio book)
    Public Const g_decLEARN_CALCULUS_IN_ONE_DAY_PRICE As Decimal = 29.95D 'Price for Learn calculus in one day (print and audio book)
    Public Const g_decFEEL_THE_STRESS_PRICE As Decimal = 18.5D 'Price for Feel the stress (print only)
    Public Const g_decTHE_SCIENCE_OF_BODY_LANGUAGE_PRICE As Decimal = 12.95D 'Price for The science of body language (audio only)
    Public Const g_decRELAXATION_TECHNIQUES_PRICE As Decimal = 11.5D 'Price for Relaxation Techniques (audio only)
    Public Const g_strI_DID_IT_YOUR_WAY_NAME As String = "I Did It Your Way" 'Name for I did it your way (print only)
    Public Const g_strTHE_HISTORY_OF_SCOTLAND_NAME As String = "The History of Scotland" 'Name for The history of scotland (print and audio book)
    Public Const g_strLEARN_CALCULUS_IN_ONE_DAY_NAME As String = "Learn Calculus in One Day" 'Name for Learn calculus in one day (print and audio book)
    Public Const g_strFEEL_THE_STRESS_NAME As String = "Feel the Stress" 'Name for Feel the stress (print only)
    Public Const g_strTHE_SCIENCE_OF_BODY_LANGUAGE_NAME As String = "The Science of Body Language" 'Name for The science of body language (audio only)
    Public Const g_strRELAXATION_TECHNIQUES_NAME As String = "Relaxation Techniques" 'Name for Relaxation Techniques (audio only)

    Public g_decSubtotal As Decimal = 0D 'Subtotal variable
    Public g_decTax As Decimal = 0D 'Tax variable
    Public g_decShipping As Decimal = 0D 'Shipping variable
    Public g_decTotal As Decimal = 0D 'Total Cost variable
    Public g_decSelectedBookCost As Decimal 'Selected Book Price variable
    Public g_strSelectedBookName As String 'Selected Book Name variable
    Public g_intNumberOfBooks As Integer = 0 'Number of books in cart variable

    '**************************************************************************************
    'StartUp object
    '**************************************************************************************
    Public Sub main()
        Dim frmOne As New frmShoppingCartByErickLopez
        frmOne.ShowDialog()
    End Sub
    '**************************************************************************************
    'End: StartUp object
    '**************************************************************************************

    '**************************************************************************************
    'Reset Charges
    'Resets the variables in charge of prices
    '**************************************************************************************
    Public Sub ResetCharges()
        g_decSubtotal = 0D
        g_decTax = 0D
        g_decShipping = 0D
        g_decTotal = 0D
        g_intNumberOfBooks = 0
        g_decSelectedBookCost = 0D
        g_strSelectedBookName = String.Empty
    End Sub
    '**************************************************************************************
    'End: Reset Charges
    '**************************************************************************************

    '**************************************************************************************
    'Get Selected Book
    'Retrieves the book name and cost. Book name gets added to the list on the main form and the price is used to do calculations
    '**************************************************************************************
    Public Function GetSelectedBook(ByRef strSelectedItem As String) As Decimal
        Console.WriteLine(strSelectedItem)
        Select Case strSelectedItem
            Case g_strI_DID_IT_YOUR_WAY_NAME
                g_decSelectedBookCost = g_decI_DID_IT_YOUR_WAY_PRICE
                g_strSelectedBookName = g_strI_DID_IT_YOUR_WAY_NAME
            Case g_strTHE_HISTORY_OF_SCOTLAND_NAME
                g_decSelectedBookCost = g_decTHE_HISTORY_OF_SCOTLAND_PRICE
                g_strSelectedBookName = g_strTHE_HISTORY_OF_SCOTLAND_NAME
            Case g_strLEARN_CALCULUS_IN_ONE_DAY_NAME
                g_decSelectedBookCost = g_decLEARN_CALCULUS_IN_ONE_DAY_PRICE
                g_strSelectedBookName = g_strLEARN_CALCULUS_IN_ONE_DAY_NAME
            Case g_strFEEL_THE_STRESS_NAME
                g_decSelectedBookCost = g_decFEEL_THE_STRESS_PRICE
                g_strSelectedBookName = g_strFEEL_THE_STRESS_NAME
            Case g_strTHE_SCIENCE_OF_BODY_LANGUAGE_NAME
                g_decSelectedBookCost = g_decTHE_SCIENCE_OF_BODY_LANGUAGE_PRICE
                g_strSelectedBookName = g_strTHE_SCIENCE_OF_BODY_LANGUAGE_NAME
            Case g_strRELAXATION_TECHNIQUES_NAME
                g_decSelectedBookCost = g_decRELAXATION_TECHNIQUES_PRICE
                g_strSelectedBookName = g_strRELAXATION_TECHNIQUES_NAME
        End Select
        Return g_decSelectedBookCost
    End Function
    '**************************************************************************************
    'End: Get Selected Book
    '**************************************************************************************

    '**************************************************************************************
    'Calculations
    'Below are all the calculations performed in the program
    '**************************************************************************************
    Public Function CalcSubtotal() As Decimal
        g_decSubtotal += g_decSelectedBookCost
        Return g_decSubtotal
    End Function

    Public Function CalcTax() As Decimal
        g_decTax = g_decSubtotal * g_decSALES_TAX
        Return g_decTax
    End Function

    Public Function CalcShipping() As Decimal
        g_decShipping = CDec(g_intNumberOfBooks) * g_decSHIPPING_CHARGE
        Return g_decShipping
    End Function

    Public Function CalcTotalCost() As Decimal
        g_decTotal = g_decSubtotal + g_decTax + g_decShipping
        Return g_decTotal
    End Function
    '**************************************************************************************
    'End: Calculations
    '**************************************************************************************

End Module
