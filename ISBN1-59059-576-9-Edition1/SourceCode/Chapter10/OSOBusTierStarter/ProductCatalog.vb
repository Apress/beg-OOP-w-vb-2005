'/// Retrieves information on product categories and products
'/// Returns information as a dataset object.
Imports System.Data.SqlClient
Public Class ProductCatalog
    Private m_conn As SqlConnection
    Private m_dsProducts As New DataSet()

    Public Function getProductInfo() As DataSet
        Try
            'Get the Category info
            Dim strSQL As String = "select CatID, Name, Descript from Category"
            Dim cmdSelCatagory As SqlCommand = New SqlCommand(strSQL, m_conn)
            Dim daCatagory As SqlDataAdapter = New SqlDataAdapter(cmdSelCatagory)
            daCatagory.Fill(m_dsProducts, "Category")
            'Get the product info
            strSQL = "Select ProductID,CatID,Name,Descript,UnitCost from Product"
            Dim cmdSelProductInfo As SqlCommand = New SqlCommand(strSQL, m_conn)
            Dim daProductInfo As SqlDataAdapter = New SqlDataAdapter(cmdSelProductInfo)
            daProductInfo.Fill(m_dsProducts, "Product")
            'Set up the table relation
            Dim drCat_Prod As New DataRelation _
                        ("drCat_Prod", m_dsProducts.Tables("Category").Columns("CatID"), _
                        m_dsProducts.Tables("Product").Columns("CatID"))

            m_dsProducts.Relations.Add(drCat_Prod)
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return m_dsProducts
    End Function
    Public Sub New()
        m_conn = New SqlConnection()
        m_conn.ConnectionString = "Integrated Security=True;" & _
                    "Data Source=LocalHost;Initial Catalog=OfficeSupply"
    End Sub
End Class
