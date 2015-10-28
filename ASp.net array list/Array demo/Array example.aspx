<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Array example.aspx.cs" Inherits="Array_demo.Array_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="weeeks"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="add array values to listbox" />
    
    </div>
    </form>
</body>
</html>
