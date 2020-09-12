Public Class Hiddenfieldexample
    Inherits System.Web.UI.Page
    Dim count As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Txtbx1.Text = 1
        End If
    End Sub

    Protected Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        'count = Val(hfcount.Value)
        'count = count + 1
        'Response.Write("hitcount:" + count.ToString())
        'hfcount.Value = count.ToString()

        count = Txtbx1.Text
        count = count + 1
        Txtbx1.Text = count

    End Sub
End Class