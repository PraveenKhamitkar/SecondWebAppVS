Public Class Loginform1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            txtUserName.Focus()
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "admin" And TxtPwd.Text = "admin" Then
            Server.Transfer("SuccessPage.aspx")
        Else
            Response.Redirect("Failure.aspx?Name=" & txtUserName.Text)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUserName.Focus()
    End Sub
End Class