Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class ADODataSetEx
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim CS As String = "data source=localhost\SQLEXPRESS; database=BikeStores;  integrated security=SSPI"
            Using Con As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("DBCS").ConnectionString)
                Dim da As SqlDataAdapter = New SqlDataAdapter("select * from production_brands; select * from production_Categories", Con)
                da.SelectCommand.CommandType = CommandType.Text
                Dim ds As DataSet = New DataSet()
                da.Fill(ds)
                ds.Tables(0).TableName = "Brands"
                ds.Tables(1).TableName = "Categories"
                GridView1.DataSource = ds.Tables("Brands")
                GridView2.DataSource = ds.Tables("Categories")
                GridView1.DataBind()
                GridView2.DataBind()
            End Using
        End If
    End Sub

End Class