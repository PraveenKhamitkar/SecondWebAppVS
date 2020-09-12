Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ADODataAdapterEx
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using Con As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("DBCS").ConnectionString)
            Dim da As SqlDataAdapter = New SqlDataAdapter("SPGetBrands", Con)
            'da.SelectCommand.CommandText = "SPGetBrands"
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@brand_name", TextBox1.Text + "%")
            'da.SelectCommand.Connection = Con
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            GridView1.DataSource = ds
            GridView1.DataBind()
        End Using
    End Sub
End Class