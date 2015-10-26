<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add rotator control demo.aspx.cs" Inherits="Add_rotator_control.Add_rotator_control_demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="SqlDataSource1" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Anantha KumarConnectionString %>" SelectCommand="SELECT * FROM [MobileShop]"></asp:SqlDataSource>
    <div>
    
    </div>
    </form>
</body>
</html>
