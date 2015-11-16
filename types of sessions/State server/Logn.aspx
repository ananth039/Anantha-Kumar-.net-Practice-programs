<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logn.aspx.cs" Inherits="State_server.Sate_server" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Txtpwd" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    
    </div>
    </form>
</body>
</html>
