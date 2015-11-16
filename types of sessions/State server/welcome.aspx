<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="State_server.welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="linkuid" runat="server" align="right" OnClick="linkuid_Click"></asp:LinkButton>
    
    </div>
        <asp:Label ID="lblwishes" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnlogout" runat="server" Text="Button" OnClick="btnlogout_Click" />
    </form>
</body>
</html>
