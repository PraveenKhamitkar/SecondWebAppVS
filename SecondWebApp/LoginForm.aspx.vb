Public Class LoginForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Me.IsPostBack) Then
            txtUserName.Focus()
        End If
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUserName.Text = "admin" And TxtPwd.Text = "admin") Then
            Response.Write("Valid User.")
        Else
            Response.Write("Invalid User")
        End If
        txtUserName.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUserName.Text = String.Empty
        TxtPwd.Text = String.Empty
        txtUserName.Focus()
    End Sub
End Class