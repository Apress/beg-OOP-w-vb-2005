Public Class Employee
    Private _empID As Integer
    Private _loginName As String
    Private _passWord As String
    Private _SSN As Integer
    Private _department As String

    Public ReadOnly Property EmployeeID() As Integer
        Get
            Return _empID
        End Get
    End Property
    Public Property LoginName() As String
        Get
            Return _loginName
        End Get
        Set(ByVal Value As String)
            _loginName = Value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _passWord
        End Get
        Set(ByVal Value As String)
            _passWord = Value
        End Set
    End Property
    Public Property SSN() As Integer
        Get
            Return _SSN
        End Get
        Set(ByVal Value As Integer)
            _SSN = Value
        End Set
    End Property
    Public Property Department() As String
        Get
            Return _department
        End Get
        Set(ByVal Value As String)
            _department = Value
        End Set
    End Property

    Public Sub New()
        'Default Constructor
    End Sub
    

End Class
