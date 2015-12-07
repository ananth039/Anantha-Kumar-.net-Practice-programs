<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Forms_Authentication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;

        }
        #LinkButtonHome
        {
            text-align:right;
            text-decoration:none;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton  ID="LinkButtonHome" runat="server" ToolTip="Go to Home page"  Text="Home" OnClick="LinkButtonHome_Click" />
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="Login">
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
