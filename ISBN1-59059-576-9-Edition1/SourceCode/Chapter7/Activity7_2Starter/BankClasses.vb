Public Class Account
    Private _intAccountNumber As Integer
    Protected dblBalance As Double
    Public ReadOnly Property Balance() As Double
        Get
            Return dblBalance
        End Get
    End Property
    Public Property AccountNumber() As Integer
        Get
            Return _intAccountNumber
        End Get
        Set(ByVal Value As Integer)
            _intAccountNumber = Value
        End Set
    End Property

    Public Function GetBalance() As Double
        'Data normally retrieved from database. Hard coded for demo only
        If AccountNumber = 1 Then
            dblBalance = 1000
            Return dblBalance
        ElseIf AccountNumber = 2 Then
            dblBalance = 2000
            Return dblBalance
        Else
            Throw New Exception("Account number incorrect.")
        End If
    End Function

    Public Function Withdraw(ByVal Amount As Double) As Double
        If dblBalance >= Amount Then
            dblBalance -= Amount
            Return dblBalance
        Else
            Throw New Exception("Not enough funds")
        End If

    End Function
End Class
Public Class CheckingAccount
    Inherits Account

End Class

Public Class SavingsAccount
    Inherits Account

End Class

