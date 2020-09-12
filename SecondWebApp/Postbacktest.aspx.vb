Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtbox1.Text = "12"
        Response.Write(Me.IsPostBack.ToString() + "<br />")
        If (Me.IsPostBack = True) Then
            Response.Write("Value of textbox:" + txtbox1.Text + "<br />")
        End If
        Response.Write(txtbox1.Text)
    End Sub

End Class