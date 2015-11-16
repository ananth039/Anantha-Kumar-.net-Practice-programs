<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie1.aspx.cs" Inherits="client_side_state_managment.Cookie1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <div>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Mail Id"></asp:Label>
        <asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>
