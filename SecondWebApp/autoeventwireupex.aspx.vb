Public Class autoeventwireupex
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Dim sibling1 As New ListItem("Lakshmi", "1")
            Dim sibling2 As New ListItem("Praveen", "2")
            Dim Sibling3 As New ListItem("Naveen", "3")

            DropDownList1.Items.Add(sibling1)
            DropDownList1.Items.Add(sibling2)
            DropDownList1.Items.Add(Sibling3)
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Protected Sub Button_Command(sender As Object, e As CommandEventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim test As String = btn.CommandArgument.ToString()
        Select Case e.CommandName
            Case "Print"
                Response.Write("you clicked Print button")
            Case "Delete"
                Response.Write("you clicked Delete button")
            Case "show"
                If e.CommandArgument.ToString() = "Top10" Then
                    Response.Write("you clicked on Top10")
                Else
                    Response.Write("you clicked on Bottom10")
                End If
            Case Else
                Response.Write("we don't know which button you clicked")
        End Select
    End Sub
End Class