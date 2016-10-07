'/// Used to process orders.
'/// Items can be added or removed. 
'/// The total cost of the order is calculated.
'/// When the order is placed it is sent as XML
'/// to the dbOrder class for processing.
Public Class Order
    Private m_alOrderItems As New Generic.List(Of OrderItem)
    Public ReadOnly Property OrderItems() As Generic.List(Of OrderItem)
        Get
            Return m_alOrderItems
        End Get
    End Property
    
    Public Sub AddItem(ByVal Value As OrderItem)
        Dim oItem As OrderItem
        For Each oItem In m_alOrderItems
            If oItem.ProductID = Value.ProductID Then
                oItem.Quantity += Value.Quantity
                Exit Sub
            End If
        Next
        m_alOrderItems.Add(Value)
    End Sub
    Public Sub RemoveItem(ByVal ProductID As String)
        Dim oItem As OrderItem
        For Each oItem In m_alOrderItems
            If oItem.ProductID = ProductID Then
                m_alOrderItems.Remove(oItem)
                Exit Sub
            End If
        Next
    End Sub
    Public Function GetOrderTotal() As Double
        If m_alOrderItems.Count = 0 Then
            Return 0.0
        Else
            Dim oItem As OrderItem
            Dim total As Double
            For Each oItem In m_alOrderItems
                total += oItem.SubTotal
            Next
            Return total
        End If
    End Function
    Public Function PlaceOrder(ByVal EmployeeID As Integer) As Integer
        Dim xmlOrder As String
        xmlOrder = "<Order EmployeeID='" & EmployeeID.ToString & "'>"
        Dim oItem As OrderItem
        For Each oItem In m_alOrderItems
            xmlOrder &= oItem.ToString
        Next
        xmlOrder &= "</Order>"

        Dim odbOrder As New dbOrder()

        Return odbOrder.PlaceOrder(xmlOrder)

    End Function
End Class
'/// Used to hold line item information for orders.
'/// toString method has been overriden to provide order
'/// item info in an XML structure.
Public Class OrderItem
    Private m_ProductID As String
    Private m_Quantity As Integer
    Private m_UnitPrice As Double
    Private m_SubTotal As Double

    Public Property ProductID() As String
        Get
            Return m_ProductID
        End Get
        Set(ByVal Value As String)
            Value = m_ProductID
        End Set
    End Property
    Public Property Quantity() As Integer
        Get
            Return m_Quantity
        End Get
        Set(ByVal Value As Integer)
            m_Quantity = Value
        End Set
    End Property
    Public Property UnitPrice() As Double
        Get
            Return m_UnitPrice
        End Get
        Set(ByVal Value As Double)
            m_UnitPrice = Value
        End Set
    End Property
    Public ReadOnly Property SubTotal() As Double
        Get
            Return m_SubTotal
        End Get
    End Property

    Public Sub New(ByVal ProductID As String, ByVal UnitPrice As Double, ByVal Quantity As Integer)

        m_ProductID = ProductID.Trim
        m_UnitPrice = UnitPrice
        m_Quantity = Quantity
        m_SubTotal = m_UnitPrice * m_Quantity

    End Sub
    Public Overrides Function toString() As String
        Dim xml As String
        xml = "<OrderItem"
        xml &= " ProductID='" & m_ProductID & "'"
        xml &= " Quantity='" & m_Quantity & "'"
        xml &= " />"
        Return xml
    End Function
End Class