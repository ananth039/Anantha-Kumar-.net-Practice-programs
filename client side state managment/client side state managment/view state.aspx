<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view state.aspx.cs" Inherits="client_side_state_managment.view_state" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblpostback" runat="server" Text="Post Back Request is :"></asp:Label><asp:TextBox ID="txtRequest" runat="server"></asp:TextBox>
    
    </div>
        
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </form>
</body>
</html>
