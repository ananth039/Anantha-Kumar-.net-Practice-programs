<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view database example.aspx.cs" Inherits="retrive_the_views_from_database.view_database_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" EmptyDataText="No Results Found">
        </asp:GridView><br />
        <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" />
    
    </div>
    </form>
</body>
</html>
