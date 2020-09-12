<%@ Page Language="vb" AutoEventWireup="True" CodeBehind="autoeventwireupex.aspx.vb" Inherits="SecondWebApp.autoeventwireupex" %>

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
                    <asp:Button ID="Button1" runat="server" Text="Print" OnCommand="Button_Command" CommandName="Print" CommandArgument="Print"  />
                    <td>
            <asp:Button ID="Button2" runat="server" Text="Delete" OnCommand="Button_Command" CommandName="Delete"  />
                    <td>
            <asp:Button ID="Button3" runat="server" Text="Top10" OnCommand="Button_Command" CommandName="show" commandArgument="Top10" />
                    <td>
            <asp:Button ID="Button4" runat="server" Text="Bottom10" OnCommand="Button_Command" CommandName="show" commandArgument="Bottom10" />
                </tr>
            <tr>
                <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
<%--                    <asp:ListItem Value="1">Praveen</asp:ListItem>
                    <asp:ListItem Value="2"  Text="Naveen">Naveen</asp:ListItem>
                    <asp:ListItem Value="3" >Lakshmi</asp:ListItem>--%>
                </asp:DropDownList>
            </td>
              </tr>
                <tr>
                <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem Value="1">Lakshmi</asp:ListItem>
                    <asp:ListItem Value="2">Praveen</asp:ListItem>
                    <asp:ListItem Value="3">Naveen</asp:ListItem>
                </asp:DropDownList>
            </td>
              </tr>
            </table>
                   
            </div>
    </form>
</body>
</html>
