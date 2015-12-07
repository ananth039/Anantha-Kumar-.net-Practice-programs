<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Forms_Authentication.Security_authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 17px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:LinkButton ID="LinkButtonNewUser" runat="server" OnClick="LinkButtonNewUser_Click">New user</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton ID="LinkButtonLogin" runat="server" OnClick="LinkButtonLogin_Click">Login</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton ID="LinkButtonPostQuery" runat="server" OnClick="LinkButtonPostQuery_Click">PostQuery</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton ID="LinkButtonPostAnswer" runat="server" OnClick="LinkButtonPostAnswer_Click">PostAnswer</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="LinkButtonDeleteQuery" runat="server" OnClick="LinkButtonDeleteQuery_Click">DeleteQuery</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:LinkButton ID="LinkButtonDeleteArticles" runat="server" OnClick="LinkButtonDeleteArticles_Click" >DeleteArticles</asp:LinkButton>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
