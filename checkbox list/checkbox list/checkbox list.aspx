<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkbox list.aspx.cs" Inherits="checkbox_list.checkbox_list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <asp:Label ID="lbllanguage" runat="server" Text="select your known languages :"></asp:Label>
        
    <div>
    
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem>Telugu</asp:ListItem>
            <asp:ListItem>English</asp:ListItem>
            <asp:ListItem>Hindi</asp:ListItem>
        </asp:CheckBoxList><br />
        <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
