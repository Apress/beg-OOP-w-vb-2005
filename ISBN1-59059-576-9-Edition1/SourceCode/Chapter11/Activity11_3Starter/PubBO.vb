Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Public Class PubBO
    Inherits Generic.List(Of Publisher)
    Public Sub Load()
        Dim cmdPublisher As New SqlCommand()
        Dim drPublisherList As SqlDataReader
        Dim sConnString As String
        Try
            sConnString = "Integrated Security=True;Data Source=LocalHost;" & _
              "Initial Catalog=Pubs"
            Using cnPubs As New SqlConnection(sConnString)
                cmdPublisher.Connection = cnPubs
                cmdPublisher.CommandText = "Select pub_id,pub_name,city from publishers"
                cnPubs.Open()
                drPublisherList = cmdPublisher.ExecuteReader
                Do While drPublisherList.Read = True
                    Dim oPub As New Publisher
                    oPub.ID = drPublisherList.GetSqlString(0)
                    oPub.Name = drPublisherList.GetSqlString(1)
                    oPub.City = drPublisherList.GetSqlString(2)
                    Me.Add(oPub)
                Loop
            End Using
        Catch ex As SqlException
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
End Class
Public Class Publisher
    Private _ID As String
    Private _Name As String
    Private _City As String

    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
        End Set
    End Property
End Class