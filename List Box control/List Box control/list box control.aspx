<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list box control.aspx.cs" Inherits="List_Box_control.list_box_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Select Your Prefered Job Location:"></asp:Label>
    
    </div>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem>Hyderabad</asp:ListItem>
            <asp:ListItem>Bangalore</asp:ListItem>
            <asp:ListItem>Chennai</asp:ListItem>
            <asp:ListItem>Pune</asp:ListItem>
          
        </asp:ListBox><br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
