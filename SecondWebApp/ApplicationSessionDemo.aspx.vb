Public Class ApplicationSessionDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("Total Applications:" + Application("TotalApps").ToString())
        Response.Write("Total Applications:" + Application("TotalSessions").ToString())
    End Sub

End Class