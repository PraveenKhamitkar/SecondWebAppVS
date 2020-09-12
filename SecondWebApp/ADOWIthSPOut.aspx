<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ADOWIthSPOut.aspx.vb" Inherits="SecondWebApp.ADOWIthSPOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
            <tr>
                <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                <td>
            <asp:Button ID="Button1" runat="server" Text="Button" />
                    </td>
                </tr>
            <tr >
                <td colspan="2">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            <tr>
                <td colspan="2">
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
