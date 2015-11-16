<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="User_Credentials.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblusername" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="txtusrname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnLogib" runat="server" Text="Login" /><br />
            <asp:HyperLink ID="hlRegister" runat="server" NavigateUrl="Register.aspx">Register</asp:HyperLink>   <br />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
