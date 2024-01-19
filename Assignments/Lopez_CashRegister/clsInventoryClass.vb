Public Class InventoryItem
    'custom class for the inventory item
    'class variables
    Private strInvNumber As String
    Private strDescription As String
    Private decCost As Decimal
    Private decRetail As Decimal
    Private intOnHand As Integer

    Public Sub New()
        Debug.WriteLine("New Inventory Item object was created")
        strInvNumber = "(unknown)"
        strDescription = "(unknown)"
        decCost = 0
        decRetail = 0
        intOnHand = 0
    End Sub

    Public Property InventoryNumber() As String
        Get
            Return strInvNumber
        End Get
        Set(value As String)
            strInvNumber = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return strDescription
        End Get
        Set(value As String)
            strDescription = value
        End Set
    End Property

    Public Property Cost() As Decimal
        Get
            Return decCost
        End Get
        Set(value As Decimal)
            decCost = value
        End Set
    End Property

    Public Property Retail() As Decimal
        Get
            Return decRetail
        End Get
        Set(value As Decimal)
            decRetail = value
        End Set
    End Property

    Public Property OnHand() As Integer
        Get
            Return intOnHand
        End Get
        Set(value As Integer)
            intOnHand = value
        End Set
    End Property
End Class
