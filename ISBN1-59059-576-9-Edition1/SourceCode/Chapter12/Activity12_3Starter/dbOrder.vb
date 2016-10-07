'/// Persists order data to the database.
'/// Uses the up_PlaceOrder stored procedure
Imports System.Data.SqlClient
Imports System.Data
Imports System.Diagnostics
Public Class dbOrder
    Public Function PlaceOrder(ByVal xmlOrder As String) As Integer
        Dim cn As SqlConnection = New SqlConnection()
        cn.ConnectionString = "Integrated Security=True;Data Source=localhost;Initial Catalog=OfficeSupply"
        Try
            Dim cmd As SqlCommand = cn.CreateCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "up_PlaceOrder"

            Dim inParameter As New SqlParameter()
            inParameter.ParameterName = "@xmlOrder"
            inParameter.Value = xmlOrder
            inParameter.DbType = DbType.String
            inParameter.Direction = ParameterDirection.Input
            cmd.Parameters.Add(inParameter)

            Dim ReturnParameter As New SqlParameter()
            ReturnParameter.ParameterName = "@OrderID"
            ReturnParameter.Direction = ParameterDirection.ReturnValue
            cmd.Parameters.Add(ReturnParameter)

            Dim intOrderNo As Integer
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            intOrderNo = CType(cmd.Parameters("@OrderID").Value, Integer)
        Return intOrderNo
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
    End Function
End Class
