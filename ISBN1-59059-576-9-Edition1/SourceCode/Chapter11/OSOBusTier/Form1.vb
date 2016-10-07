Public Class Form1

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim oEmployee As New Employee()
        MessageBox.Show(oEmployee.Login(txtUserName.Text, txtPassword.Text).ToString)

    End Sub

    Private Sub btnGetProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetProducts.Click
        Dim oProducts As New ProductCatalog()
        dgvCategories.DataSource = bsCategories
        dgvProducts.DataSource = bsProducts
        bsCategories.DataSource = oProducts.getProductInfo
        bsCategories.DataMember = "Category"
        bsProducts.DataSource = bsCategories
        bsProducts.DataMember = "drCat_Prod"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim oOrder As New Order()
        oOrder.AddItem(New OrderItem("ACM-10414", 3.79, 2))
        oOrder.AddItem(New OrderItem("ACM-10414", 3.79, 4))
        oOrder.AddItem(New OrderItem("OIC-5000", 1.99, 2))
        oOrder.AddItem(New OrderItem("MMM-6200", 3.9, 2))

        Dim i As Integer
        For i = 0 To oOrder.OrderItems.Count - 1
            MessageBox.Show(oOrder.OrderItems.Item(i).ToString)
        Next
        MessageBox.Show(oOrder.GetOrderTotal.ToString)
        MessageBox.Show(oOrder.PlaceOrder(1).ToString)

    End Sub

    
End Class