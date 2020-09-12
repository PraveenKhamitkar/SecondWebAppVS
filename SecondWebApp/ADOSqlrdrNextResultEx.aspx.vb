Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class ADOSqlrdrNextResultEx
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Using con As sqlconnection = New sqlconnection()
            con.connectionstring = ConfigurationManager.ConnectionStrings("DBCS").ConnectionString
            Dim cmd As SqlCommand = New Sqlcommand()
            cmd.CommandText = "select top 10 store_id, product_id, quantity from production_stocks; select * from production_brands"
            cmd.Connection = con
            con.Open()
            Using rdr As SqlDataReader = cmd.ExecuteReader()
                GridView1.DataSource = rdr
                GridView1.DataBind()

                While rdr.NextResult()
                    GridView2.DataSource = rdr
                    GridView2.DataBind()
                End While
            End Using
        End Using

    End Sub

End Class