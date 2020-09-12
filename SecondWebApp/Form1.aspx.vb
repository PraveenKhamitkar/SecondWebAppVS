Imports System
Imports System.String

Public Class Form1
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String = ""
        str1 = Request.Form("text1")
        Response.Write(str1)
    End Sub
End Class