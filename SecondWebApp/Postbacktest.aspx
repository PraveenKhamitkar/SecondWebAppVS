<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Postbacktest.aspx.vb" Inherits="SecondWebApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtbox1" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:Button ID="btn1" runat="server" Text="Click Me" />
        </div>
    </form>
</body>
</html>
