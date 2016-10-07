Public Class frmOrder
    Private EmployeeID As Integer
    Private dsProdCat As DataSet
    Private bsProdCat As New BindingSource
    Private oOrder As Order
    Private oOrderItemDlg As New dlgOrderItem()
    Private oLoginDlg As New dlgLogin()
    Private Sub frmOrder_Load(ByVal sender As Object, _
            ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oProdCat As New ProductCatalog()
        dsProdCat = oProdCat.getProductInfo
        bsProdCat.DataSource = dsProdCat
        bsProdCat.DataMember = "Category"
        cboProductCategories.DataSource = bsProdCat
        cboProductCategories.DisplayMember = "Name"

        dgvProducts.DataSource = bsProdCat
        dgvProducts.DataMember = "drCat_Prod"
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim oEmployee As New Employee()
        Dim strUserName As String
        Dim strPassword As String

        If oLoginDlg.ShowDialog(Me) = DialogResult.OK Then
            strUserName = oLoginDlg.txtName.Text
            strPassword = oLoginDlg.txtPassword.Text
            EmployeeID = oEmployee.Login(strUserName, strPassword)
            If EmployeeID > 0 Then
                ssMsg.Text = "You are logged in as employee number " & EmployeeID
                pnlOrder.Enabled = True
                oOrder = New Order()
            Else
                MessageBox.Show("You could not be verified. Please try again.")
                pnlOrder.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnAddItem_Click(ByVal sender As Object, _
              ByVal e As System.EventArgs) Handles btnAddItem.Click
        Dim strProdID As String
        Dim dblUnitPrice As Double
        Dim intQuantity As Integer

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvProducts.SelectedRows(0)
        strProdID = CStr(selectedRow.Cells(0).Value)
        dblUnitPrice = CDbl(selectedRow.Cells(4).Value)

        oOrderItemDlg.txtProductID.Text = strProdID
        oOrderItemDlg.txtUnitPrice.Text = dblUnitPrice.ToString
        If oOrderItemDlg.ShowDialog(Me) = DialogResult.OK Then
            intQuantity = oOrderItemDlg.nupQuantity.Value
            oOrder.AddItem(New OrderItem(strProdID, dblUnitPrice, intQuantity))
            Dim bsOrderItems As New BindingSource
            bsOrderItems.DataSource = oOrder
            bsOrderItems.DataMember = "OrderItems"
            dgvOrders.DataSource = bsOrderItems
        End If
    End Sub
    Private Sub btnRemoveItem_Click(ByVal sender As Object, _
                ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        Dim strProdID As String
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvOrders.SelectedRows(0)
        strProdID = CStr(selectedRow.Cells(1).Value)
        oOrder.RemoveItem(strProdID)
        Dim bsOrderItems As New BindingSource
        bsOrderItems.DataSource = oOrder
        bsOrderItems.DataMember = "OrderItems"
        dgvOrders.DataSource = bsOrderItems
    End Sub
    Private Sub btnPlaceOrder_Click(ByVal sender As System.Object, _
                 ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        Dim intOrderNumber As Integer
        intOrderNumber = oOrder.PlaceOrder(EmployeeID)
        ssMsg.Text = "The order has been placed. The order number is " _
            & intOrderNumber
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        oLoginDlg.Close()
        oOrderItemDlg.Close()
        Me.Close()
    End Sub
End Class