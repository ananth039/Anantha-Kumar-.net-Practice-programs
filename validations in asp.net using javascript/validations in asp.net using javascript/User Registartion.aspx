<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User Registartion.aspx.cs" Inherits="validations_in_asp.net_using_javascript.User_Registartion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        <asp:DropDownList ID="ddlday" runat="server">
            <asp:ListItem>Day</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlmonth" runat="server">
            <asp:ListItem>Month</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="ddlyear" runat="server">
            <asp:ListItem>year</asp:ListItem>
        </asp:DropDownList><br />

        <asp:Button ID="Button1" runat="server" Text="Button" /><br />
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
