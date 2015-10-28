<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="array list is added to list box control in asp.net.aspx.cs" Inherits="array_list_in_asp.net.array_list_is_added_to_list_box_control_in_asp_net" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Label ID="lblweeks" runat="server" Text="Weeks"></asp:Label> <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
      <br /><br />  <asp:Button ID="btnAddWeeks" runat="server" Text="Add weeks to ListBox" OnClick="btnAddWeeks_Click" />
    </div>
        <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove Monday" />
        <asp:Button ID="btnAddmonday" runat="server" OnClick="btnAddmonday_Click" Text="Insert monday" />
        <asp:Button ID="btnsort" runat="server" OnClick="btnsort_Click" Text="Sort List" />
    </form>
</body>
</html>
