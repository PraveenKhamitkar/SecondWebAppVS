<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ADOQueryWithParameters.aspx.vb" Inherits="SecondWebApp.ADOQueryWithParameters" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtbox1" runat="server" />
            <asp:Button ID="btn1" runat="server" Text="brands" />
            <asp:GridView ID="grdview1" runat="server"  />
        </div>
    </form>
</body>
</html>
