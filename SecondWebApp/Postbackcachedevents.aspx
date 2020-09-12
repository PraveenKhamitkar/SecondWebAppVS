<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Postbackcachedevents.aspx.vb" Inherits="SecondWebApp.Postbackcachedevents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button1" />
       
        <asp:Button ID="Button2" runat="server" Text="Button2" />
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" />
        <asp:TextBox ID="TextBox2" runat="server" />
    </form>
</body>
</html>
