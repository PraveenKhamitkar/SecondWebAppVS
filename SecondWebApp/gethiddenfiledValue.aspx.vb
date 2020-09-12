Public Class gethiddenfiledValue
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim value As String = Request.Form("hfcount")
        Response.Write("hfcount value is:" + value)

    End Sub

End Class