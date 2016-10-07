Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Public Class PubDB

    
    Public Function GetPubInfo() As DataSet

        Dim sConnString As String
        Dim oSqlCommand As SqlCommand
        Dim oDataAdapter As SqlDataAdapter
        Try
            sConnString = "Integrated Security=True;Data Source=LocalHost;" & _
              "Initial Catalog=Pubs"
            Using oPubConnection As New SqlConnection(sConnString)
                oPubConnection.Open()
                oSqlCommand = oPubConnection.CreateCommand
                oSqlCommand = New SqlCommand()
                oSqlCommand.Connection = oPubConnection
                oSqlCommand.CommandText = "Select pub_id,pub_name,city from publishers"
                oDataAdapter = New SqlDataAdapter()
                oDataAdapter.SelectCommand = oSqlCommand
                Dim dsPubInfo As DataSet = New DataSet()
                oDataAdapter.Fill(dsPubInfo, "Publishers")
                Return dsPubInfo
            End Using
        Catch oEx As Exception
            Throw oEx
        
        End Try
    End Function

    Public Function GetBookInfo() As DataSet
        'Dim oPubConnection As SqlConnection
        Dim sConnString As String
        Dim oSqlCommand As SqlCommand
        Dim oDataAdapter As SqlDataAdapter
        Try
            sConnString = "Integrated Security=True;Data Source=LocalHost;" & _
              "Initial Catalog=Pubs"
            Using oPubConnection As New SqlConnection(sConnString)
                'oPubConnection.Open()
                oSqlCommand = oPubConnection.CreateCommand
                oSqlCommand = New SqlCommand()
                oSqlCommand.Connection = oPubConnection
                oSqlCommand.CommandText = "Select title_id,title,pub_id, ytd_sales,pubdate from titles"
                oDataAdapter = New SqlDataAdapter()
                oDataAdapter.SelectCommand = oSqlCommand
                Dim dsBookInfo As DataSet = New DataSet()
                oDataAdapter.Fill(dsBookInfo, "Books")
                Return dsBookInfo
            End Using

        Catch oEx As Exception
            Throw oEx
        End Try
    End Function
    Public Function GetPubBookInfo() As DataSet
        Dim dsPubInfo As New DataSet()
        Dim dsBookInfo As New DataSet()
        dsPubInfo = GetPubInfo()
        dsBookInfo = GetBookInfo()
        dsPubInfo.Merge(dsBookInfo)
        Dim drPub_Book As New DataRelation("PubBookKey", _
            dsPubInfo.Tables("Publishers").Columns("pub_id"), _
            dsPubInfo.Tables("Books").Columns("pub_id"))
        dsPubInfo.Relations.Add(drPub_Book)
        Return dsPubInfo
    End Function
End Class
