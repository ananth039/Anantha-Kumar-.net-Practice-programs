<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gridview example1.aspx.cs" Inherits="gridview_ex_1_with_connection_oriented_Architecture.gridview_example1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridEmp" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
