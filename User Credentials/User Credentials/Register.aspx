<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="User_Credentials.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblrepwd" runat="server" Text="Reenter Password"></asp:Label>
            <asp:TextBox ID="txtrepwd" runat="server"></asp:TextBox><br />
            <asp:Button ID="" runat="server" Text="Button" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
