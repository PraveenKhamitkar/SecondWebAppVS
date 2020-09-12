Public Class sessionstate1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            If Session("Clicks") = Nothing Then
                Session("Clicks") = 0

            End If
        End If
        TextBox1.Text = Session("Clicks").ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TextBox1.Text = (Integer.Parse(Session("Clicks")) + 1).ToString()
        TextBox1.Text = (Convert.ToInt32(Session("Clicks")) + 1).ToString()
        Session("Clicks") = TextBox1.Text
    End Sub
End Class