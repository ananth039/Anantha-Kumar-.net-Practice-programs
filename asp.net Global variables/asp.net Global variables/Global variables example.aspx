<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Global variables example.aspx.cs" Inherits="asp.net_Global_variables.Global_variables_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblxvalue" runat="server" Text="X value is"></asp:Label>
        <asp:TextBox ID="txtxValue" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblyValue" runat="server" Text="Y Value is"></asp:Label>
        <asp:TextBox ID="txtYValue" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" />
    
    </div>
       
    </form>
</body>
</html>
