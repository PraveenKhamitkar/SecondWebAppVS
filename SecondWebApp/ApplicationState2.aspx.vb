Public Class ApplicationState2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not (IsPostBack) Then
            If Application("Clicks") = Nothing Then
                Application("Clicks") = 0

            End If
        End If
        TextBox1.Text = Application("Clicks").ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = (Convert.ToInt32(Application("Clicks")) + 1).ToString()
        Application("Clicks") = TextBox1.Text
    End Sub

End Class