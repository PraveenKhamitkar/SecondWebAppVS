Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Public Class ADOSqlDataReaderEx
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Using con As SqlConnection = New SqlConnection()
            con.ConnectionString = ConfigurationManager.ConnectionStrings("DBCS").ConnectionString
            Dim cmd As SqlCommand = New SqlCommand()
            Dim table As DataTable = New DataTable()
            table.Columns.Add("Store_id")
            table.Columns.Add("Product_id")
            table.Columns.Add("quantity")
            table.Columns.Add("Discountquantity")
            cmd.CommandText = "select store_id, product_id, quantity from production_stocks"
            cmd.Connection = con
            con.Open()

            Using rdr As SqlDataReader = cmd.ExecuteReader()

                While rdr.Read()
                    Dim Row As DataRow = table.NewRow()
                    Row("Store_id") = rdr("Store_id")
                    Row("product_id") = rdr("product_id")
                    Row("quantity") = rdr("quantity")
                    Row("Discountquantity") = CType(rdr("quantity"), Integer) * 0.9
                    table.Rows.Add(Row)
                End While
            End Using
            GridView1.DataSource = table
            GridView1.DataBind()
        End Using


    End Sub

End Class