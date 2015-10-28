<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Queue example.aspx.cs" Inherits="Queue_demo.Queue_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblmobileBrands" runat="server" Text="MobileBrands"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnAddvalues" runat="server" OnClick="btnAddvalues_Click" Text="Add values" />
    <div>
    
    </div>
    </form>
</body>
</html>
