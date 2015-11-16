<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inproc.aspx.cs" Inherits="types_of_sessions.Inproc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnAssign" runat="server" Text="Assign" OnClick="btnAssign_Click" /><br />
        <asp:Label ID="Label1" runat="server"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Retrive" OnClick="Button1_Click" /><br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
