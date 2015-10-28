<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hidden fileds.aspx.cs" Inherits="view_state_managament_demo1.Hidden_fileds" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hidden fields example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
        <asp:HiddenField ID="HiddenField1"  runat="server"  Value="0" />
        <asp:Label ID="Label2" runat="server" Text="Number of post backs:"></asp:Label>
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </form>
</body>
</html>
