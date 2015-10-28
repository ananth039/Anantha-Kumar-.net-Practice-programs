<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Application state.aspx.cs" Inherits="Server_side_state_managament_techniques.Application_state" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="LblName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
    <div>
    
        <asp:Label ID="lblnumberOfPostbacks" runat="server" Text="Number of Post backs:"></asp:Label>
        <asp:Label ID="lblCount" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
