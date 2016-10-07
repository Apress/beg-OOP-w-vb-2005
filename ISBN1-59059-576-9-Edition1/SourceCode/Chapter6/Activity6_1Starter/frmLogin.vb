Public Class frmLogin

    Private Sub btnLogIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Try
            'TODO your code goes here

        Catch eException As Exception
            MessageBox.Show(eException.Message, "Login Failed")
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class