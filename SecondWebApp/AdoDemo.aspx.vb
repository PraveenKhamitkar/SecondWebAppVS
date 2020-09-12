Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports System.Configuration
Public Class AdoDemo
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Dim CS As String = "data source=localhost\SQLEXPRESS; database=BikeStores; integrated security=SSPI"
        'Dim con As SqlConnection = New SqlConnection(CS)
        'Dim cmd As SqlCommand = New SqlCommand("select * from production_brands", con)
        'con.Open()
        'Dim rdr As SqlDataReader = cmd.ExecuteReader()
        'GridView1.DataSource = rdr
        'GridView1.DataBind()
        'con.Close()
        'Dim con As OracleConnection = New OracleConnection(CS)
        'Dim cmd As OracleCommand = New OracleCommand("select * from production_brands", con)
        'con.Open()
        'Dim rdr As OracleDataReader = cmd.ExecuteReader()
        'GridView1.DataSource = rdr
        'GridView1.DataBind()
        'con.Close()
        'Dim con As SqlConnection = New SqlConnection()
        'Dim cmd As SqlCommand = New SqlCommand()
        'Try

        '    con.ConnectionString = CS
        '    cmd.CommandText = "Select * from production_brands"
        '    cmd.Connection = con
        '    con.Open()
        '    GridView1.DataSource = cmd.ExecuteReader()
        '    GridView1.DataBind()
        'Catch
        'Finally
        '    con.Close()
        'End Try
        'Dim con As SqlConnection
        Dim CS As String = ConfigurationManager.ConnectionStrings("DBCS").ConnectionString
        Using con As SqlConnection = New SqlConnection()
            Dim cmd As SqlCommand = New SqlCommand()


            con.ConnectionString = CS
            cmd.CommandText = "Select * from production_brands"
            cmd.Connection = con
            con.Open()
            GridView1.DataSource = cmd.ExecuteReader()
            GridView1.DataBind()
        End Using

        Dim CS2 As String = ConfigurationManager.ConnectionStrings("DBCS").ConnectionString
        Using Con2 As SqlConnection = New SqlConnection()
            Con2.ConnectionString = CS
            Dim cmd2 As SqlCommand = New SqlCommand()
            cmd2.CommandText = "Select count(*) from production_brands"
            cmd2.Connection = Con2
            Con2.Open()
            TextBox1.Text = cmd2.ExecuteScalar()

        End Using

        Dim CS3 As String = ConfigurationManager.ConnectionStrings("DBCS").ConnectionString
        Using Con3 As SqlConnection = New SqlConnection()
            Con3.ConnectionString = CS
            Dim cmd3 As SqlCommand = New SqlCommand()
            cmd3.CommandText = "insert into production_brands Values ('Sonata')"
            cmd3.Connection = Con3
            Con3.Open()
            TextBox2.Text = cmd3.ExecuteNonQuery()
            cmd3.CommandText = "Update production_brands set brand_name='bazuka' where brand_id=10"
            TextBox3.Text = cmd3.ExecuteNonQuery()
            cmd3.CommandText = "Delete from Production_brands where brand_name='Sonata'"
            TextBox4.Text = cmd3.ExecuteNonQuery()
        End Using

    End Sub

End Class