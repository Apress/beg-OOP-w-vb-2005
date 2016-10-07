
Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim oEmployee As New Employee()
        Dim strUserName As String
        Dim strPassword As String
        Dim EmployeeID As Integer

        strUserName = txtUserName.Text
        strPassword = txtPassword.Text
        EmployeeID = oEmployee.Login(strUserName, strPassword)
        If EmployeeID > 0 Then
            Session("EmployeeID") = EmployeeID
            Response.Redirect("OrderForm.aspx")
        Else
            lblMessage.Text = "You could not be verified. Please try again."
        End If

    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Response.Redirect("OrderForm.aspx")
    End Sub
End Class
