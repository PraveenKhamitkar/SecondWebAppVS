Public Class Failure
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Name As String = Request.QueryString("Name")
        Response.Write("Hello " + Name + ",You are an Invalid User")

    End Sub

End Class