<%@ Page Language="vb" AutoEventWireup="false"  Inherits="SecondWebApp.Form1" %>

<!DOCTYPE html>
<script runat="server">
    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Response.Write("Clicked the button")

    End Sub
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write("My first page in Second Web App") %>
            <asp:Button ID="Button1" runat="server" Text="Click Me"  OnClick="Button1_Click"/>
            <br />
            <input type="text"  name="text1" />
        </div>
    </form>
</body>
</html>
