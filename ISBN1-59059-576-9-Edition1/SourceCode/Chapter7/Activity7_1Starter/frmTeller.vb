Public Class frmTeller
    Private Sub btnGetBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetBalance.Click

        Try


        Catch eException As Exception
            MsgBox(eException.Message)
        End Try
    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        Try

        Catch eException As Exception
            MsgBox(eException.Message)
        End Try
    End Sub
End Class