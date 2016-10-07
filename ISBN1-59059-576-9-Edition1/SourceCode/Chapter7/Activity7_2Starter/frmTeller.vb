Public Class frmTeller
    Private oCheckingAccount As CheckingAccount = New CheckingAccount()
    Private oSavingsAccount As SavingsAccount = New SavingsAccount()
    'Private oInterestCheckingAccount As CheckingAccount = New InterestCheckingAccount()
    Private Sub btnGetBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetBalance.Click

        Try
            If rdbChecking.Checked Then
                oCheckingAccount.AccountNumber = CInt(txtAccountNumber.Text)
                txtBalance.Text = oCheckingAccount.GetBalance().ToString
                'ElseIf rdbInterestChecking.Checked Then
                '    oInterestCheckingAccount.AccountNumber = CInt(txtAccountNumber.Text)
                '    txtBalance.Text = oInterestCheckingAccount.GetBalance().ToString
            ElseIf rdbSavings.Checked Then
                oSavingsAccount.AccountNumber = CInt(txtAccountNumber.Text)
                txtBalance.Text = oSavingsAccount.GetBalance().ToString
            End If
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