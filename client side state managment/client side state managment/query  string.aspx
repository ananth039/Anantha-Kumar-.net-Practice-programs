<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="query  string.aspx.cs" Inherits="client_side_state_managment.query__string" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <asp:Label ID="Label1" runat="server" Text="Emp No"></asp:Label>
        <asp:TextBox ID="txtEno" runat="server"></asp:TextBox>
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Emp Name"></asp:Label>
        <asp:TextBox ID="txtEname" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    
    </div>
    </form>
</body>
</html>
