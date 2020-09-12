<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="LoginForm.aspx.vb" Inherits="SecondWebApp.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <table align="Center" >
              <caption>Login Form</caption>
              <tr>
                  <td>
                    User Name:
                  </td>
                  <td>
                      <asp:TextBox ID="txtUserName" runat="server" Width="150"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td>
                      Password:
                  </td>
                  <td>
                       <asp:TextBox ID="TxtPwd" runat="server" TextMode="Password" Width="150"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td align="right">
                      <asp:Button ID="btnLogin" runat="server" Text="Login" />
                  </td>
                  <td>
                      <asp:Button ID="btnReset" runat="server" Text="Reset" />
                  </td>
              </tr>
          </table>
        </div>
    </form>
</body>
</html>
