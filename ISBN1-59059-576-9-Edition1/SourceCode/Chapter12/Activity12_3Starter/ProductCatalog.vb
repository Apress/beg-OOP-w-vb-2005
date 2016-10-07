'/// Retrieves information on product categories and products
'/// Returns information as a dataset object.
Imports System.Data.SqlClient
Imports System.Data
Imports System.Diagnostics
Public Class ProductCatalog
    Private m_conn As SqlConnection
    Private m_dsProducts As New DataSet()

    Public Function getProductInfo() As DataSet
        Try
            'Get the Category info
            Dim strSQL As String = "select CatID, Name, Descript from Category"
            Dim cmdSelCategory As SqlCommand = New SqlCommand(strSQL, m_conn)
            Dim daCategory As SqlDataAdapter = New SqlDataAdapter(cmdSelCategory)
            daCategory.Fill(m_dsProducts, "Category")
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
    Public Function GetCategories() As Data.DataTable
        'Get the Category info
        Try
            Dim strSQL As String = "select CatID, Name, Descript from Category"
            Dim cmdSelCategory As SqlCommand = New SqlCommand(strSQL, m_conn)
            Dim daCategory As SqlDataAdapter = New SqlDataAdapter(cmdSelCategory)
            daCategory.Fill(m_dsProducts, "Category")
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try
        Return m_dsProducts.Tables("category")
    End Function
    Public Function GetProducts(ByVal CatID As Integer) As Data.DataTable
        Try
            'Get the product info
            Dim strSQL As String = "Select ProductID,CatID,Name,Descript,UnitCost" & _
                " from Product where CatID = " & CatID
            Dim cmdSelProductInfo As SqlCommand = New SqlCommand(strSQL, m_conn)
            Dim daProductInfo As SqlDataAdapter = New SqlDataAdapter(cmdSelProductInfo)
            daProductInfo.Fill(m_dsProducts, "Product")
        Catch ex As Exception

        End Try
        Return m_dsProducts.Tables("Product")
    End Function
    Public Sub New()
        m_conn = New SqlConnection()
        m_conn.ConnectionString = "Integrated Security=True;" & _
                    "Data Source=LocalHost;Initial Catalog=OfficeSupply"
    End Sub
End Class
