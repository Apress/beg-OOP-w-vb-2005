'/// Used to verify employees and provide the employee
'/// id so employees can place an order.
Imports System.Data.SqlClient
Imports System.Data
Imports System.Diagnostics
Public Class Employee
    Private m_LoginAttempt As Integer
    Public Function Login(ByVal UserName As String, ByVal Password As String) As Integer
        Dim conn As SqlConnection = New SqlConnection()
        Try
            conn.ConnectionString = "Integrated Security=True;" & _
                            "Data Source=LocalHost;Initial Catalog=OfficeSupply"
            conn.Open()
            Dim comm As SqlCommand = New SqlCommand()
            Dim userID As Integer
            comm.Connection = conn
            comm.CommandText = "Select EmployeeID from Employee where UserName='" _
                & UserName & "' and Password='" & Password & "'"
            userID = CType(comm.ExecuteScalar(), Integer)
            If userID > 0 Then
                Return userID
            Else
                m_LoginAttempt += 1
                If m_LoginAttempt >= 3 Then
                    Throw New Exception("Too many invalid attemps!")
                End If
                Return -1
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Function
End Class
