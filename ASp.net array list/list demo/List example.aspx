<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List example.aspx.cs" Inherits="list_demo.List_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Months"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" Text="add string list to listbox" OnClick="Button1_Click" />
        <br />

        <br />
             <asp:Label ID="Label2" runat="server" Text="days"></asp:Label>
        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
        <asp:Button ID="Button2" runat="server" Text="add int list to listbox" OnClick="Button2_Click" />
 
    <div>
    
    </div>
    </form>
</body>
</html>
