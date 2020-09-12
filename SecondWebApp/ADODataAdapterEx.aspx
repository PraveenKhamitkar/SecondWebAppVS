<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ADODataAdapterEx.aspx.vb" Inherits="SecondWebApp.ADODataAdapterEx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
