Imports System.Data.SqlClient
Imports System.Configuration
Public Class ADOWIthSPOut
    Inherits System.Web.UI.Page
    Dim CS As String = ConfigurationManager.ConnectionStrings("DBCS").ConnectionString
    Dim con As SqlConnection = New SqlConnection()
    Dim cmd As SqlCommand = New SqlCommand()
    Dim ds As DataSet = New DataSet()
    Dim dt As DataTable = New DataTable()


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            con.ConnectionString = CS
            cmd.CommandText = "SpProdutionCategories"
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()

            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)

            da.Fill(ds)
            dt = ds.Tables(0)
            DropDownList1.DataSource = dt
            ' DropDownList1.DataTextField =ds
            'DropDownList1.DataValueField = dt.Columns.IndexOf(1)
            DropDownList1.DataSource = ds
            DropDownList1.DataValueField = "Category_id"
            DropDownList1.DataTextField = "Category_name"
            DropDownList1.DataBind()
            con.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        con.ConnectionString = CS
        cmd.CommandText = "SpInsertBrands"
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@brand_name", TextBox1.Text)
        Dim outputparameter As SqlParameter = New SqlParameter()
        outputparameter.ParameterName = "@Brand_Id"
        outputparameter.SqlDbType = System.Data.SqlDbType.Int
        outputparameter.Direction = System.Data.ParameterDirection.Output
        cmd.Parameters.Add(outputparameter)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Label1.Text = outputparameter.Value

    End Sub
End Class