Imports System.Data.SqlClient
Imports System.Configuration
Public Class ADOWithSP
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Using con As sqlconnection = New sqlconnection()
            con.ConnectionString = ConfigurationManager.ConnectionStrings("DBCS").ConnectionString
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = con
            cmd.CommandText = "SpGetBrands"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@brand_name", txtbox1.Text + "%")
            con.Open()
            grdview1.DataSource = cmd.ExecuteReader()
            grdview1.DataBind()
        End Using
    End Sub
End Class