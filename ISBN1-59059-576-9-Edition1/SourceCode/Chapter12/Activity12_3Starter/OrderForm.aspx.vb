
Partial Class OrderForm
    Inherits System.Web.UI.Page
    Private oOrder As Order

    Protected Sub dgvProducts_SelectedIndexChanged _
      (ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles dgvProducts.SelectedIndexChanged
        If IsNothing(Session("EmployeeID")) Then
            Response.Redirect("Login.aspx")
        End If

        If Not IsNothing(Session("Order")) Then
            oOrder = CType(Session("Order"), Order)
        Else
            oOrder = New Order()
        End If
        ' Get the currently selected row using the SelectedRow property.
        Dim gvProducts As GridView = CType(sender, GridView)
        Dim row As GridViewRow = gvProducts.SelectedRow

        Dim ProductID As String = row.Cells(1).Text
        Dim UnitPrice As String = row.Cells(4).Text

        oOrder.AddItem(New OrderItem(ProductID, CDbl(UnitPrice), 1))

        BindOrderGrid()
        gvProducts.SelectedIndex = -1
    End Sub

    Private Sub BindOrderGrid()
        dgvOrderItems.DataSource = oOrder.OrderItems
        dgvOrderItems.DataBind()
        Session("Order") = oOrder
        If oOrder.OrderItems.Count > 0 Then
            btnPlaceOrder.Enabled = True
        Else
            btnPlaceOrder.Enabled = False
        End If
        dgvOrderItems.SelectedIndex = -1
    End Sub
    

    Protected Sub dgvOrderItems_SelectedIndexChanged _
     (ByVal sender As Object, ByVal e As System.EventArgs) _
     Handles dgvOrderItems.SelectedIndexChanged
        oOrder = CType(Session("Order"), Order)
        'Get the currently selected row using the SelectedRow property.
        Dim gvOrderItems As GridView = CType(sender, GridView)
        Dim row As GridViewRow = gvOrderItems.SelectedRow
        Dim ProductID As String = row.Cells(0).Text
        oOrder.RemoveItem(ProductID)
        BindOrderGrid()
    End Sub

    Protected Sub btnPlaceOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        oOrder = CType(Session("Order"), Order)
        If oOrder.OrderItems.Count > 0 Then
            lblMessage.Text = "Your order has been submitted as order #" & _
            oOrder.PlaceOrder(CType(Session("EmployeeID"), Integer)).ToString
        Else
            lblMessage.Text = "There are no items in the order."
        End If

    End Sub
End Class
