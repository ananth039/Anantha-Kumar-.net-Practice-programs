<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stack example.aspx.cs" Inherits="WebApplication1.stack_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Label ID="Lblcolors" runat="server" Text="Colors:"></asp:Label>
        <asp:DropDownList ID="ddlColors" runat="server">
        </asp:DropDownList>
        <br /><asp:Button ID="btnColors" runat="server" Text="Add colors" OnClick="btnColors_Click" />
    
    </div>
    </form>
</body>
</html>
