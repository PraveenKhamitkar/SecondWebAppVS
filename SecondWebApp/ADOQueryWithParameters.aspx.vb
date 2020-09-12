Imports System.Data.SqlClient
Imports System.Configuration
Public Class ADOQueryWithParameters
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Using con As SqlConnection = New SqlConnection()
            Dim cmd As SqlCommand = New SqlCommand()
            con.ConnectionString = ConfigurationManager.ConnectionStrings("DBCS").ConnectionString
            cmd.Connection = con
            cmd.CommandText = "select * from production_brands where brand_name like @brand_name"
            cmd.Parameters.AddWithValue("@brand_name", txtbox1.Text + "%")
            con.Open()
            grdview1.DataSource = cmd.ExecuteReader()
            grdview1.DataBind()
        End Using

    End Sub
End Class