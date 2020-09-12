Public Class ValidatePage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Name As String = Request.Form("txtUserName")
        Dim Pwd As String = Request.Form("txtPwd")

        If Name = "admin" And Pwd = "admin" Then
            Response.Write("Valid User")
        Else
            Response.Write("InValid User")
        End If
    End Sub

End Class