Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Response.Write("Code behind button click")
    End Sub
End Class