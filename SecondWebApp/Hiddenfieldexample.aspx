<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Hiddenfieldexample.aspx.vb" Inherits="SecondWebApp.Hiddenfieldexample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Txtbx1" runat="server"></asp:TextBox>
            <asp:button ID="button1" runat="server" Text="Hit Count" />
            <asp:Button ID="button2" runat="server" Text="Open new page" PostBackUrl="~/gethiddenfiledValue.aspx" />
            <asp:HiddenField ID="hfcount" runat="server" />
        </div>
    </form>
</body>
</html>
