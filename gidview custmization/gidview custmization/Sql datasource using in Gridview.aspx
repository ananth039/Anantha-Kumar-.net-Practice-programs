<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sql datasource using in Gridview.aspx.cs" Inherits="gidview_custmization.Sql_datasource_using_in_Gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="empdetails" >
        </asp:GridView>
        <asp:SqlDataSource ID="empdetails" runat="server"  ConnectionString="Server=ANANTH\ANANTH;Database=Sql queries Practice;Integrated Security=True" SelectCommand="select * from employee">
           
        </asp:SqlDataSource>
    </form>
</body>
</html>
