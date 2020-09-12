Public Class SuccessPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim pp As Page = PreviousPage
        'Dim ctrl As Control = pp.FindControl("txtUserName")
        'Dim tb As TextBox = CType(ctrl, TextBox)
        'Dim str As String = tb.Text

        Dim str As String = CType(PreviousPage.FindControl("txtUserName"), TextBox).Text
        Response.Write("Hello " + str + ",Have a nice day!")

    End Sub

End Class