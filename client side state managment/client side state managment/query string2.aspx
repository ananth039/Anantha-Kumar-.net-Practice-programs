<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="query string2.aspx.cs" Inherits="client_side_state_managment.query_string2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
    <div>
    
        <asp:Label ID="lblEno" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lblEname" runat="server" Text=""></asp:Label>
    
    </div>
        <asp:LinkButton ID="linkprev" runat="server" OnClick="linkprev_Click">Prev</asp:LinkButton>
    </form>
</body>
</html>
