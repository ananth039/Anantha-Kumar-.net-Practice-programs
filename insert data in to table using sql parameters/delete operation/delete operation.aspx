<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete operation.aspx.cs" Inherits="delete_operation.delete_operation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="Delete">
       
        <asp:Label ID="lbleno" runat="server" Text="Select Emp No"></asp:Label>
        <asp:DropDownList ID="ddlEno" runat="server">
        </asp:DropDownList><br />
             <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /><br />
             <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
             </asp:Panel>
    
    </div>
    </form>
</body>
</html>
